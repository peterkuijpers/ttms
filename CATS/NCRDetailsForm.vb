Imports BaseModel
Imports System.Xaml

Public Class NCRDetailsForm

	Private ncrId As Integer
	Private user As user
	Private curNcr As Ncr
	Private curStat As Status
	Private showCcState As Boolean

	''' <summary>
	''' NCR Details constructor. User ncrid of -1 for new ncr
	''' </summary>
	''' <param name="ncrId"></param>
	''' <remarks></remarks>
	Public Sub New()
		InitializeComponent()
	End Sub



	Public Sub SetNcrDetails(ncrId As Integer, user As User)
		Me.user = user
		ReloadNcr(ncrId)
		Dim actionUserId As Integer = GetActionUser(curNcr)
		EnableStatusControl(user, actionUserId)
	End Sub

	Private Function GetActionUser(curNcr As Ncr) As Integer
		Dim actionUser As Integer = -1
		If Not IsNothing(curNcr.delegatedto_id) Then
			actionUser = curNcr.delegatedto_id
		ElseIf Not IsNothing(curNcr.assignedto_id) Then
			actionUser = curNcr.assignedto_id
		ElseIf Not IsNothing(curNcr.raisedby_id) Then
			actionUser = curNcr.raisedby_id
		Else
			actionUser = -1
		End If
		Return actionUser
	End Function

	''' <summary>
	''' ncrid = -1 indicates new ncr
	''' </summary>
	''' <param name="ncrId"></param>
	''' <remarks></remarks>
	Private Sub ReloadNcr(ncrId As Integer)
		Me.ncrId = ncrId
		' new ncr
		If (ncrId = -1) Then
			curNcr = New Ncr()
			curNcr.raiseddate = DateTime.Now
			curNcr.raisedby_id = user.id
			curNcr.RaisedBy = user
			Me.IdTb.Text = "--"
		Else
			curNcr = DB.LoadNcr(ncrId)
			curNcr.RaisedBy = DB.LoadUser(curNcr.raisedby_id)
			If (Not IsNothing(curNcr.delegatedto_id) And curNcr.delegatedto_id >= 0) Then
				curNcr.Delegate = DB.LoadUser(curNcr.delegatedto_id)
			End If
			If (Not IsNothing(curNcr.assignedto_id) And curNcr.assignedto_id >= 0) Then
				curNcr.AssignedTo = DB.LoadUser(curNcr.assignedto_id)
			End If
			Me.IdTb.Text = curNcr.id
		End If
		Me.CurrentStatusTb.Text = Status.StatMessages(curNcr.status_id)
		Me.DescriptionTB.Text = curNcr.description
		Me.TitleTb.Text = curNcr.title
		Me.DescriptionTB.Text = curNcr.description
		Me.RaisedDatePicker.Value = curNcr.raiseddate
		Me.RaisedByTb.Text = curNcr.RaisedBy.surname + ", " + curNcr.RaisedBy.firstname
		If (Not IsNothing(curNcr.AssignedTo) And curNcr.assignedto_id >= 0) Then
			AssignedToTb.Text = curNcr.AssignedTo.surname + ", " + curNcr.AssignedTo.firstname
		Else
			AssignedToTb.Text = ""
		End If
		If (Not IsNothing(curNcr.Delegate) And curNcr.delegatedto_id >= 0) Then
			DelegatedToTb.Text = curNcr.Delegate.surname + ", " + curNcr.Delegate.firstname
		Else
			DelegatedToTb.Text = ""
		End If
		' set status controller to current status id
		' use callback when status is changed
		StatusControl2.SetupCallback(AddressOf StatusChanged)
		StatusControl2.SetUsers(DB.LoadUsers)
		StatusControl2.SetStatus(curNcr.status_id)
		'
		'enable/disable objects according to the status
		Select Case (curNcr.status_id)
			Case Status.StatusType.Creating
				TitleTb.Enabled = True
				DescriptionTB.Enabled = True
			Case Status.StatusType.Modifying
				TitleTb.Enabled = True
				DescriptionTB.Enabled = True
			Case Status.StatusType.SubmittedToAssignee
				TitleTb.Enabled = True
				DescriptionTB.Enabled = True
			Case Status.StatusType.Assigned
				TitleTb.Enabled = False
				DescriptionTB.Enabled = False
			Case Status.StatusType.SubmittedToDelegate
				TitleTb.Enabled = False
				DescriptionTB.Enabled = False
			Case Status.StatusType.Delegated
				TitleTb.Enabled = False
				DescriptionTB.Enabled = False
		End Select
		'update status item which is linked to to this ncr
		curStat = New Status()
		curStat.State = curNcr.status_id
		If (IsNothing(curNcr.assignedto_id)) Then
			curStat.AssignedTo = -1
		Else
			curStat.AssignedTo = curNcr.assignedto_id
		End If
		If (IsNothing(curNcr.delegatedto_id)) Then
			curStat.DelegatedTo = -1
		Else
			curStat.DelegatedTo = curNcr.delegatedto_id
		End If
		'Update Status Control Display
		Dim actionUserId = GetActionUser(curNcr)
		EnableStatusControl(user, actionUserId)
		'Update CC control
		If (curNcr.status_id = Status.StatusType.Modifying Or curNcr.status_id = Status.StatusType.Creating Or curNcr.status_id = Status.StatusType.SubmittedToAssignee) Then
			showCcState = False
		Else
			showCcState = True
		End If
		ShowCC(showCcState, user, actionUserId)
	End Sub

	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub

	''' <summary>
	''' Callback for StatusControl
	''' </summary>
	''' <remarks></remarks>
	Public Sub StatusChanged(action As Status.Actions, newUserid As Integer)
		Dim newUser = DB.LoadUser(newUserid)
		MessageBox.Show("Action: " + action.ToString())
		HandleAction(action, newUserid)
	End Sub

	Private Sub HandleAction(action As Status.Actions, userId As Integer)
		Select Case action
			Case Status.Actions.Create
				CreateNewNcr()
			Case Status.Actions.Submit
				NewSubmitNcr(userId)
			Case Status.Actions.RejectByAssignee
				RejectByAssignee()
			Case Status.Actions.AcceptByAssignee
				AcceptByAssignee()
			Case Status.Actions.Delegat
				DelegateNcr(userId)
			Case Status.Actions.RejectByDelegate
				RejectByDelegate()
			Case Status.Actions.AcceptByDelegate
				AcceptByDelegate()
			Case Status.Actions.Save
				SaveNcrDetails()
			Case Status.Actions.Drop
				DropNcr()
				Exit Sub
		End Select
		Me.StatusControl2.SetStatus(curStat.State)
		ReloadNcr(ncrId)
	End Sub

	Private Sub SaveNcrDetails()
		'ensure ncr status is 'creating'
		If (curNcr.status_id = Status.StatusType.Modifying) Then
			'update title and description
			curNcr.title = TitleTb.Text
			curNcr.description = DescriptionTB.Text
			'
			Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
			Dim result = ncrAdapt.UpdateDetails(curNcr.title, curNcr.description, curNcr.id)
			'
			'add item to log
			Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
			Dim message As String = "NCR Saved"
			Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
			'refresh the log tab
			' NcrLog1.RefreshLog(curNcr.id)
			'
			StatusStrip1.Items.Clear()
			StatusStrip1.Items.Add(message)
		Else
			MessageBox.Show("NCR details can only be saved when the NCR is in 'Creating' mode")
		End If
	End Sub

	Private Sub DropNcr()
		If (curNcr.status_id = Status.StatusType.Modifying) Then
			'update title and description
			Dim id = curNcr.id
			Dim result As DialogResult = MessageBox.Show(Me, "Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
			' Dim result As DialogResult = MessageBox.Show(Me, "Are you sure you want to delete NCR id=" + id, "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
			If (result = Windows.Forms.DialogResult.OK) Then
				Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
				Dim delResult As Integer = ncrAdapt.DeleteById(id)
				Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
				Dim message As String = "NCR Saved"
				Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
				'refresh the log tab
				' NcrLog1.RefreshLog(curNcr.id)
				'
				StatusStrip1.Items.Clear()
				StatusStrip1.Items.Add(message)

			End If

		Else
			MessageBox.Show("NCR details can only be saved when the NCR is in 'Creating' mode")
		End If
	End Sub

	Private Sub CreateNewNcr()
		curNcr.status_id = Status.StatusType.Modifying
		curNcr.title = TitleTb.Text
		curNcr.description = DescriptionTB.Text
		curStat.State = Status.StatusType.Modifying
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim statusresult = ncrAdapt.InsertQuery(curNcr.raisedby_id, DateTime.Now, Nothing, Nothing, curNcr.status_id, curNcr.description, curNcr.title)
		' get the inserted ncr-id
		If (statusresult > 0) Then
			curNcr.id = ncrAdapt.LastInsertedId()
			ncrId = curNcr.id
		End If
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Created"
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
		'refresh the log tab
		' NcrLog1.RefreshLog(curNcr.id)
		'add item to notifications
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		'Dim notesResult = notesAdapt.InsertQuery(curNcr.assignedto_id, curNcr.id, "New NCR was created by you. Please assign it to somebody", DateTime.Now)
		'
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub NewSubmitNcr(assigneeId As Integer)
		'update status in db
		curNcr.AssignedTo = DB.LoadUser(assigneeId)
		curNcr.assignedto_id = assigneeId
		'
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result = ncrAdapt.UpdateRaisedTo(curNcr.assignedto_id, curNcr.id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.SubmittedToAssignee, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Submitted to " + curNcr.AssignedTo.firstname + ", " + curNcr.AssignedTo.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
		'refresh the log tab
		' NcrLog1.RefreshLog(curNcr.id)
		'add item to notifications
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.assignedto_id, curNcr.id, "New NCR was assigned to you. Please update its status", DateTime.Now)
		'
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub RejectByAssignee()
		'update status in db
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result = ncrAdapt.UpdateRaisedTo(Nothing, curNcr.id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.Modifying, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Rejected by " & user.firstname & ", " & user.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
		'refresh the log tab
		'NcrLog1.RefreshLog(curNcr.id)
		'
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raisedby_id, curNcr.id, "NCR was rejected. Please re-assign", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub AcceptByAssignee()
		'update status in db
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.Assigned, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Accepted by " & user.firstname + ", " & user.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
		'
		'refresh the log tab
		'NcrLog1.RefreshLog(curNcr.id)
		'
		' Create new CC
		Dim ccTable As MySqlDataSet.ccDataTable = New MySqlDataSet.ccDataTable()
		Dim ccAdapt As MySqlDataSetTableAdapters.ccTableAdapter = New MySqlDataSetTableAdapters.ccTableAdapter()
		ccAdapt.CreateById(curNcr.id, 0)

		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.assignedto_id, curNcr.id, "NCR was accepted by you. Please take actions", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub DelegateNcr(delegateId As Integer)
		'update status in db
		curNcr.Delegate = DB.LoadUser(delegateId)
		curNcr.assignedto_id = delegateId
		'
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result = ncrAdapt.UpdateDelegatedTo(curNcr.delegatedto_id, curNcr.id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.Delegated, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Delegated to " & curNcr.AssignedTo.firstname & ", " & curNcr.AssignedTo.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, curNcr.id)
		'

		'refresh the log tab
		'NcrLog1.RefreshLog(curNcr.id)
		'
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.assignedto_id, curNcr.id, "NCR was delegated to you. Please update its status", DateTime.Now)
		'
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub AcceptByDelegate()
		'update status in db
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result = ncrAdapt.UpdateDelegatedTo(curNcr.delegatedto_id, curNcr.id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.Delegated, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Delegated to " & curNcr.AssignedTo.firstname & ", " & curNcr.AssignedTo.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, curNcr.id)
		' 
		'
		'refresh the log tab
		'NcrLog1.RefreshLog(curNcr.id)
		'
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.assignedto_id, curNcr.id, "NCR was delegated to you. Please take actions", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Sub RejectByDelegate()
		'update status in db
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result = ncrAdapt.UpdateDelegatedTo(Nothing, curNcr.id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.StatusType.Assigned, curNcr.id)
		'add item to log
		Dim logAdapt As New MySqlDataSetTableAdapters.logTableAdapter()
		Dim message As String = "NCR Delegation rejected by " & user.firstname & ", " & user.surname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.id, user.id)
		'refresh the log tab
		'NcrLog1.RefreshLog(curNcr.id)
		'
		Dim notesAdapt As New MySqlDataSetTableAdapters.notificationTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raisedby_id, curNcr.id, "NCR Delegation was rejected.", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub


	''' <summary>
	''' Enable/disable the status control box, depending on who you are
	''' and the ncr details
	''' </summary>
	''' <remarks></remarks>
	Private Sub EnableStatusControl(user As User, actionUserId As Integer)
		If (IsNothing(user)) Then
			StatusControl2.Hide()
		Else
			Dim userAllowed As Boolean = False
			If (user.id = actionUserId) Then
				StatusControl2.Visible = True
			Else
				StatusControl2.Visible = False
			End If
		End If
	End Sub

	Private Sub ShowCC(value As Boolean, user As User, actionUserId As Integer)
		showCcState = value
		If value = True And user.id = actionUserId Then
			CcControl2.Enabled = True
			CcControl2.Reload(curNcr, user)
		Else
			CcControl2.Enabled = False
		End If
	End Sub

	Private Sub EnabledBackgroundColor_Enter(sender As System.Object, e As System.EventArgs) Handles TitleTb.Enter, DescriptionTB.Enter
		If (TypeOf sender Is TextBox) Then
			CType(sender, TextBox).BackColor = Color.Beige
		End If

	End Sub

	Private Sub DisabledBackgroundColor_Enter(sender As System.Object, e As System.EventArgs) Handles TitleTb.Leave, DescriptionTB.Leave
		If (TypeOf sender Is TextBox) Then
			CType(sender, TextBox).BackColor = Color.White
		End If

	End Sub
End Class