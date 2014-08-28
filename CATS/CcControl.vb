Imports BaseModel

Public Class CcControl
	Dim users = DB.LoadUsers()
	Dim curNcr As Ncr
	Dim curUser As User
	Dim curCc As cc
	Dim seqCounter As Integer
	Dim ccItemTable = New MySqlDataSet.ccitemDataTable()
	Dim ccItemAdapt = New MySqlDataSetTableAdapters.ccitemTableAdapter()
	Dim ccTable = New MySqlDataSet.ccDataTable()
	Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter()

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		'
		ActionByCmb.DataSource = users
		ActionByCmb.ValueMember = "id"
		ActionByCmb.DisplayMember = "userid"

		ReviewByCol.DataSource = users
		ReviewByCol.ValueMember = "id"
		ReviewByCol.DisplayMember = "userid"

		seqCounter = 1

	End Sub
	Public Sub SetOwner(ccId As Int32, ownerId As Int32)
		DB.SetCcOwner(ccId, ownerId)
	End Sub

	Public Sub Reload(curNcr As Ncr, curUser As User)
		Me.curNcr = curNcr
		Me.curUser = curUser
		NcrIdTb.Text = curNcr.id
		NcrSubjectTb.Text = curNcr.title
		ReloadCc(curNcr.id)
	End Sub

	Private Sub ReloadCc(ccId As Integer)
		' per definition cc-id is equal to ncr-id
		curCc = DB.LoadCc(ccId)

		Select Case curCc.status_id
			Case CcStatus.StatusType.Creating
				seqTextCol.ReadOnly = False
				actionTextCol.ReadOnly = False
				ActionByCmb.ReadOnly = False
				DueDateCal.ReadOnly = False
				ComplDateCal.ReadOnly = True
				ReviewGridView.Hide()

			Case CcStatus.StatusType.SubmittedToApprover
				PlanGridView.Enabled = False
				ReviewGridView.Enabled = False
			Case CcStatus.StatusType.PlanExecution
				seqTextCol.ReadOnly = True
				actionTextCol.ReadOnly = True
				ActionByCmb.ReadOnly = True
				DueDateCal.ReadOnly = True
				ComplDateCal.ReadOnly = False
				ReviewGridView.Hide()
			Case CcStatus.StatusType.SolutionVerification
				PlanGridView.Enabled = False
				ReviewGridView.Show()
				ReviewGridView.Enabled = True
			Case CcStatus.StatusType.Closed
				PlanGridView.Enabled = False
				ReviewGridView.Show()
				ReviewGridView.Enabled = False

		End Select

		ccItemAdapt.Fill(ccItemTable, curCc.id)

		Dim bindingSource = New BindingSource()
		bindingSource.DataSource = ccItemTable
		PlanGridView.DataSource = bindingSource
		PlanGridView.Refresh()

		seqCounter = 1

		Dim bindingSource2 = New BindingSource()
		bindingSource2.DataSource = ccItemTable
		ReviewGridView.DataSource = bindingSource2
		ReviewGridView.Refresh()


		' set status controller to current status id
		' use callback when status is changed
		CcStatusCntr.SetupCallback(AddressOf StatusChanged)
		CcStatusCntr.SetUsers(DB.LoadUsers)
		CcStatusCntr.SetStatus(curCc.status_id)
		'Update Status Control Display
		EnableStatusControl(curUser, curCc.owner_id)
		' display current status
		StatusTb.Text = CcStatus.StatMessages(curCc.status_id)

	End Sub

	''' <summary>
	''' Enable/disable the status control box, depending on who you are
	''' and the ncr details
	''' </summary>
	''' <remarks></remarks>
	Private Sub EnableStatusControl(user As User, actionUserId As Integer)
		If (IsNothing(user)) Then
			CcStatusCntr.Hide()
		Else
			If (user.id = curCc.owner_id) Then
				CcStatusCntr.Visible = True
			Else
				CcStatusCntr.Visible = False
			End If
		End If
	End Sub

	''' <summary>
	''' Called when the action/status control has a new status
	''' </summary>
	''' <remarks></remarks>
	Public Sub StatusChanged(action As CcStatus.Actions, newUserid As Integer)
		Dim newUser = DB.LoadUser(newUserid)
		MessageBox.Show("Action: " + action.ToString())
		HandleAction(action, newUserid)
	End Sub

	Private Sub HandleAction(action As CcStatus.Actions, newUserid As Integer)

		Select Case action
			Case CcStatus.Actions.Create
				'CreateNewNcr()
			Case CcStatus.Actions.Submit
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.SubmittedToApprover)
				DB.SetCcPlanApprover(curCc.id, newUserid)
				'update user in db
				DB.SetCcOwner(curCc.id, newUserid)
				'NewSubmitNcr(userId)
			Case CcStatus.Actions.RejectByApprover
				'RejectByApprover()
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcPlanApprover(curCc.id, Nothing)
				' reset owner back to ncr owner
				DB.SetCcOwner(curCc.id, curNcr.owner_id)
			Case CcStatus.Actions.AcceptByApprover
				'AcceptByApprover()
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.PlanExecution)
			Case CcStatus.Actions.ExecutionFinished
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.SolutionVerification)
				DB.SetCcSolutionVerifier(curCc.id, newUserid)
				DB.SetCcOwner(curCc.id, newUserid)
			Case CcStatus.Actions.VerificationPassed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Closed)
			Case CcStatus.Actions.VerificationFailed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcSolutionVerifier(curCc.id, Nothing)
				'reset cc owner back to ncr owner
				DB.SetCcOwner(curCc.id, curNcr.owner_id)
		End Select
		ReloadCc(curCc.id)
	End Sub

	Private Sub CcPlanGridView_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles PlanGridView.DefaultValuesNeeded
		Dim row = e.Row
		row.Cells("SeqCol").Value = seqCounter
		row.Cells("ccIdCol").Value = curNcr.id
		seqCounter += 1
	End Sub


	'Private Sub CcPlanGridView_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CcPlanGridView.RowEnter
	'	If (CcPlanGridView.Rows(e.RowIndex).IsNewRow) Then
	'   CcPlanGridView.Rows(e.RowIndex).Cells(0).Value = 1
	'	End If
	'End Sub

	Private Sub CcPlanGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PlanGridView.RowValidated
		ccItemAdapt.Update(ccItemTable)
		If (e.ColumnIndex = 5) Then
			Console.WriteLine("Row validated: " & e.RowIndex & "-" & e.ColumnIndex)
			CheckExecutionCompleted()
		End If

	End Sub


	Private Sub CcPlanGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles PlanGridView.DataError
		MessageBox.Show("This row has an error")

	End Sub

	Private Sub CcPlanGridView_RowDirtyStateNeeded(sender As System.Object, e As System.Windows.Forms.QuestionEventArgs) Handles PlanGridView.RowDirtyStateNeeded
		MessageBox.Show("Dirty row")
	End Sub


	Private Sub NewItemBtn_Click(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub CcPlanGridView_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles PlanGridView.UserDeletingRow
		Dim result As Integer = MessageBox.Show("Are you sure you want to delete this row?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
		If (result <> DialogResult.OK) Then
			e.Cancel = True
		End If

	End Sub

	

	Private Sub CheckExecutionCompleted()
		Dim result = ccItemAdapt.CheckCompleted(curCc.id)
		If (result = 0) Then
			MessageBox.Show(Me, "All CC items completed. Execution of CC is now finished", "CC Execution finished", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			ccAdapt.UpdateStatus(CcStatus.StatusType.SolutionVerification, curCc.id)
			ReloadCc(curCc.id)
		End If
	End Sub
End Class
