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
		seqCounter = 1

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

		End Select

		ccItemAdapt.Fill(ccItemTable, curCc.id)

		Dim bindingSource = New BindingSource()
		bindingSource.DataSource = ccItemTable
		CcPlanGridView.DataSource = bindingSource
		CcPlanGridView.Refresh()

		seqCounter = 1

		' set status controller to current status id
		' use callback when status is changed
		CcStatusCntr.SetupCallback(AddressOf StatusChanged)
		CcStatusCntr.SetUsers(DB.LoadUsers)
		CcStatusCntr.SetStatus(curCc.status_id)
		'Update Status Control Display
		Dim actionUserId = GetActionUser(curCc)
		'TODO next lines needs replaced!
		If actionUserId = 0 Then
			actionUserId = curNcr.raisedby_id
		End If
		EnableStatusControl(curUser, actionUserId)
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
			Dim userAllowed As Boolean = False
			If (user.id = actionUserId) Then
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
				'NewSubmitNcr(userId)
			Case CcStatus.Actions.RejectByApprover
				'RejectByApprover()
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcPlanApprover(curCc.id, Nothing)
			Case CcStatus.Actions.AcceptByApprover
				'AcceptByApprover()
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.PlanExecution)
			Case CcStatus.Actions.ExecutionFinished
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.SolutionVerification)
				DB.SetCcSolutionVerifier(curCc.id, newUserid)
			Case CcStatus.Actions.VerificationPassed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Closed)
			Case CcStatus.Actions.VerificationFailed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcSolutionVerifier(curCc.id, Nothing)
		End Select
		ReloadCc(curCc.id)
	End Sub

	Private Sub CcPlanGridView_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles CcPlanGridView.DefaultValuesNeeded
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

	Private Sub CcPlanGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CcPlanGridView.RowValidated
		Dim rowindex As Integer
		rowindex = e.RowIndex
		ccItemAdapt.Update(ccItemTable)

	End Sub


	Private Sub CcPlanGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CcPlanGridView.DataError
		MessageBox.Show("This row has an error")

	End Sub

	Private Sub CcPlanGridView_RowDirtyStateNeeded(sender As System.Object, e As System.Windows.Forms.QuestionEventArgs) Handles CcPlanGridView.RowDirtyStateNeeded
		MessageBox.Show("Dirty row")
	End Sub


	Private Sub NewItemBtn_Click(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub CcPlanGridView_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles CcPlanGridView.UserDeletingRow
		Dim result As Integer = MessageBox.Show("Are you sure you want to delete this row?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
		If (result <> DialogResult.OK) Then
			e.Cancel = True
		End If

	End Sub

	Private Function GetActionUser(curCc As cc) As Integer
		Dim actionUser As Integer = -1
		If Not IsNothing(curCc.solutionverifier_id) Then
			actionUser = curCc.solutionverifier_id
		ElseIf Not IsNothing(curCc.planapprover_id) Then
			actionUser = curCc.planapprover_id
		Else
			actionUser = -1
		End If
		Return actionUser
	End Function

End Class
