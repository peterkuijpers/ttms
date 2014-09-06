Imports BaseModel

Public Delegate Sub Listener()

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

	Dim listener As Listener

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		'
		PlanActionByCmb.DataSource = users
		PlanActionByCmb.ValueMember = "id"
		PlanActionByCmb.DisplayMember = "userid"

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
		PlanGridView.AllowUserToAddRows = False
		Select Case curCc.status_id
			Case CcStatus.StatusType.Creating
				ReviewGridView.Hide()
				PlanComplDateCal.Visible = False
				If (curUser.id = curCc.owner_id) Then
					PlanGridView.AllowUserToAddRows = True
					seqTextCol.ReadOnly = False
					actionTextCol.ReadOnly = False
					PlanActionByCmb.ReadOnly = False
					PlanDueDateCal.ReadOnly = False
					PlanComplDateCal.ReadOnly = True
				Else
					PlanGridView.Enabled = False
					PlanGridView.AllowUserToAddRows = False
					seqTextCol.ReadOnly = True
					actionTextCol.ReadOnly = True
					PlanActionByCmb.ReadOnly = True
					PlanDueDateCal.ReadOnly = True
					PlanComplDateCal.ReadOnly = True
				End If
			Case CcStatus.StatusType.SubmittedToApprover
				PlanComplDateCal.Visible = False
				PlanGridView.Enabled = False
				PlanGridView.AllowUserToAddRows = False
				seqTextCol.ReadOnly = True
				actionTextCol.ReadOnly = True
				PlanActionByCmb.ReadOnly = True
				PlanDueDateCal.ReadOnly = True
				PlanComplDateCal.ReadOnly = True
				ReviewGridView.Hide()
			Case CcStatus.StatusType.PlanExecution
				'only enable completion date col
				PlanComplDateCal.Visible = True
				PlanGridView.AllowUserToAddRows = False
				seqTextCol.ReadOnly = True
				actionTextCol.ReadOnly = True
				PlanActionByCmb.ReadOnly = True
				PlanDueDateCal.ReadOnly = True
				PlanComplDateCal.ReadOnly = False
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
		'if no items than create a first item

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

	''' <summary>
	''' Handle the action
	''' </summary>
	''' <param name="action"></param>
	''' <param name="newUserid"></param>
	''' <remarks></remarks>
	Private Sub HandleAction(action As CcStatus.Actions, newUserid As Integer)
		Dim newUser
		Select Case action
			Case CcStatus.Actions.Create
				UpdateLog(CcStatus.StatMessages()(CcStatus.StatusType.Creating), newUserid, curCc.id)
			Case CcStatus.Actions.Submit
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.SubmittedToApprover)
				DB.SetCcPlanApprover(curCc.id, newUserid)
				'update user in db
				DB.SetCcOwner(curCc.id, newUserid)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.SubmittedToApprover)
				If newUserid > 0 Then
					newUser = DB.LoadUser(newUserid)
					message += ", " & newUser.userid
				End If
				UpdateLog(message, curCc.id, curUser.id)
			Case CcStatus.Actions.RejectByApprover
				'RejectByApprover()
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcPlanApprover(curCc.id, Nothing)
				' reset owner back to ncr owner
				DB.SetCcOwner(curCc.id, curNcr.owner_id)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.Creating)
				If newUserid > 0 Then
					newUser = DB.LoadUser(newUserid)
					message += ", " & newUser.userid
				End If
				UpdateLog(message, curCc.id, curUser.id)
			Case CcStatus.Actions.AcceptByApprover
				'AcceptByApprover(): Execution can start
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.PlanExecution)
				DB.UpdateCcPlanApproveDate(curCc.id, DateTime.Now)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.PlanExecution)
				UpdateLog(message, curCc.id, curUser.id)
			Case CcStatus.Actions.ExecutionFinished
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.SolutionVerification)
				DB.SetCcSolutionVerifier(curCc.id, newUserid)
				DB.SetCcOwner(curCc.id, newUserid)
				DB.UpdateCcCompletionDate(curCc.id, DateTime.Now)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.SolutionVerification)
				If newUserid > 0 Then
					newUser = DB.LoadUser(newUserid)
					message += ", " & newUser.userid
				End If
				UpdateLog(message, curCc.id, curUser.id)
			Case CcStatus.Actions.VerificationPassed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Closed)
				DB.UpdateCcVerificationDate(curCc.id, DateTime.Now)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.Closed)
				If newUserid > 0 Then
					newUser = DB.LoadUser(newUserid)
					message += ", " & newUser.userid
				End If
				UpdateLog(message, curCc.id, curUser.id)
			Case CcStatus.Actions.VerificationFailed
				DB.UpdateCcStatus(curCc.id, CcStatus.StatusType.Creating)
				DB.SetCcSolutionVerifier(curCc.id, Nothing)
				'reset cc owner back to ncr owner
				DB.SetCcOwner(curCc.id, curNcr.owner_id)
				Dim message = CcStatus.StatMessages()(CcStatus.StatusType.Creating)
				If newUserid > 0 Then
					newUser = DB.LoadUser(newUserid)
					message += ", " & newUser.userid
				End If
				UpdateLog(message, curCc.id, curUser.id)
		End Select
		ReloadCc(curCc.id)
	End Sub

	Private Sub PlanGridView_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles PlanGridView.DefaultValuesNeeded
		Dim row = e.Row
		row.Cells("SeqTextCol").Value = seqCounter
		row.Cells("ccIdCol").Value = curNcr.id
		row.Cells("passedCol").Value = 0
		row.Cells("failedCol").Value = 0
		seqCounter = PlanGridView.RowCount + 1

	End Sub

	''' <summary>
	''' Update the row  in the database
	''' and check if all actions are completed which indicates execution of cc is finished
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub PlanGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PlanGridView.RowValidated
		ccItemAdapt.Update(ccItemTable)
		' was the completiondate updated?
		If (e.ColumnIndex = 5) Then
			Console.WriteLine("Row validated: " & e.RowIndex & "-" & e.ColumnIndex)
			CheckExecutionCompleted()
		End If

	End Sub

	Private Sub CcPlanGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles PlanGridView.DataError
		MessageBox.Show("This row has an error")
	End Sub

	Private Sub PlanGridView_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles PlanGridView.UserDeletingRow
		Dim result As Integer = MessageBox.Show("Are you sure you want to delete this row?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
		If (result <> DialogResult.OK) Then
			e.Cancel = True
		End If
	End Sub

	''' <summary>
	''' If all action items are completed than the cc should move from status execution to verifying
	''' </summary>
	''' <remarks></remarks>
	Private Sub CheckExecutionCompleted()
		Dim result = ccItemAdapt.CheckCompleted(curCc.id)
		If (result = 0) Then
			MessageBox.Show(Me, "All CC items completed. Execution of CC is now finished", "CC Execution finished", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			ccAdapt.UpdateStatus(CcStatus.StatusType.SolutionVerification, curCc.id)
			ReloadCc(curCc.id)
		End If
	End Sub

	Private Sub ReviewGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReviewGridView.RowValidated
		ccItemAdapt.Update(ccItemTable)
		Dim uncompleted = ccItemAdapt.GetTotalUncompleted(curCc.id)
		If uncompleted = 0 And curCc.status_id = CcStatus.StatusType.SolutionVerification Then
			Dim failed = ccItemAdapt.GetTotalFailed(curCc.id)
			Dim newStatus As Integer
			If (failed > 0) Then
				MessageBox.Show("Verificiation complete but one or more of the tasks were failed. CC is rejected")
				newStatus = CcStatus.StatusType.Creating
			Else
				MessageBox.Show("Verification complete and all tasks passed. CC is closed")
				newStatus = CcStatus.StatusType.Closed
			End If
			ccAdapt.UpdateStatus(newStatus, curCc.id)
			ReloadCc(curCc.id)
		End If
	End Sub

	''' <summary>
	''' Validating verification row:
	''' if Pass: must have review_by, review_date
	''' if Fail: must have review_by, review_date and comment
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub ReviewGridView_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ReviewGridView.RowValidating
		Dim valid = True
		Dim row = ReviewGridView.Rows(e.RowIndex)
		Dim pass = CType(row.Cells("passCol").Value, Boolean)
		Dim fail = CType(row.Cells("failCol").Value, Boolean)
		If (pass) Then
			If (IsDBNull(row.Cells("ReviewByCol")) Or IsDBNull(row.Cells("ReviewDateCol"))) Then
				MessageBox.Show("For Passed items please select Reviewer and Review date")
				valid = False
			End If
		End If
		If (fail) Then
			If (IsDBNull(row.Cells("CommentCol").Value) Or IsDBNull(row.Cells("ReviewByCol").Value) Or IsDBNull(row.Cells("ReviewDateCol").Value)) Then
				MessageBox.Show("For Failed items please select Reviewer, Review date and Comment")
				valid = False
			End If
		End If
		If (Not valid) Then
			e.Cancel = True
		End If

	End Sub

	Private Sub ReviewGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

	End Sub

	Private Sub ReviewGridView_CurrentCellDirtyStateChanged(sender As System.Object, e As System.EventArgs) Handles ReviewGridView.CurrentCellDirtyStateChanged
		Dim cell = ReviewGridView.CurrentCell
		Dim colIndex = cell.ColumnIndex
		Dim rowIndex = cell.RowIndex
		If (colIndex = 3) Then
			Dim checkCell As DataGridViewCheckBoxCell = CType(ReviewGridView.Rows(rowIndex).Cells("failCol"), DataGridViewCheckBoxCell)
			checkCell.Value = False
		End If
		If (colIndex = 4) Then
			Dim checkCell As DataGridViewCheckBoxCell = CType(ReviewGridView.Rows(rowIndex).Cells("passCol"), DataGridViewCheckBoxCell)
			checkCell.Value = False
		End If
	End Sub

	Private Sub UpdateLog(logMessage As String, userId As Integer, ccId As Integer)
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, logMessage, ccId, userId)
		If (Not IsNothing(listener)) Then
			listener()
		End If

	End Sub


	Private Sub UpdateNotes(noteMsg As String, userId As Integer, ccId As Integer)
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(ccId)
		Dim notesResult = notesAdapt.InsertQuery(userId, ccId, noteMsg, DateTime.Now)
		listener()
	End Sub

	'
	Public Sub SetListener(listener As Listener)
		Me.listener = listener
	End Sub
End Class
