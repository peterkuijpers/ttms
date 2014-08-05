Imports TTMS

Public Class NCRDetailsForm
	Private ncrId As Integer
	Private user As User
	Private curNcr As NCR
	
	Public Sub New(id As Integer)
		InitializeComponent()
		'
		Me.ncrId = id
		curNcr = DB.LoadNcr(id)
		curNcr.RaisedByUser = DB.LoadUser(curNcr.raised_by_id)

		Me.ActionCmb.DataSource = DB.LoadActions(curNcr.status_id)
		Me.ActionCmb.DisplayMember = "description"
		Me.ActionCmb.ValueMember = "Code"

		Me.CurStatusCmb.DataSource = DB.LoadStatus
		Me.CurStatusCmb.DisplayMember = "short_description"
		Me.CurStatusCmb.ValueMember = "id"
		Me.CurStatusCmb.SelectedValue = curNcr.status_id

		'Me.CurStatusCmb.SelectedIndex = curNcr.status_id

		Me.RaisedToCmb.DataSource = DB.LoadUsers
		Me.RaisedToCmb.DisplayMember = "fullname"
		Me.RaisedToCmb.ValueMember = "id"
		If (Not IsNothing(curNcr.raised_to_id)) Then
			Me.RaisedToCmb.SelectedValue = curNcr.raised_to_id
		Else
			Me.RaisedToCmb.SelectedItem = Nothing
		End If
		Me.IdTb.Text = curNcr.Id
		Me.DescriptionTB.Text = curNcr.Description

		Me.TitleTb.Text = curNcr.title
		Me.DescriptionTB.Text = curNcr.Description
		Me.RaisedDatePicker.Value = curNcr.raised_date
		Me.RaisedByTb.Text = curNcr.RaisedByUser.Surname + ", " + curNcr.RaisedByUser.Firstname

		'enable/disable objects according to the status
		Select Case curNcr.status_id
			Case Status.NewNCR
				StatusNewNCR()
			Case Status.NewNcrSubmit
				StatusNewNcrSubmitted()
			Case Status.NewNcrAccepted
				StatusNcrAccepted()
			Case Status.NewNcrDelegated
				StatusNcrDelegated()
			Case Else
				StatusStrip1.Items.Clear()
				StatusStrip1.Items.Add("invalid status detected")
		End Select

		' display the log info for this ncr
		Me.NcrLog1.RefreshLog(Me.ncrId)

	End Sub

	Public Sub SetCurrentUser(user As User)
		Me.user = user
		curNcr.RaisedByUser = user
	End Sub
	''' <summary>
	''' Perform action depending on new status
	''' </summary>
	''' <param name="stat"></param>
	''' <remarks></remarks>
	Private Sub SelectStatus(stat As Integer)
		Select Case stat
			Case Status.NewNCR
				StatusNewNCR()
			Case Status.NewNcrSubmit
				StatusSubmitAndWaitingApprovalNCR()
			Case Else

		End Select
	End Sub

	Private Sub StatusNewNcrSubmitted()
		Me.TitleTb.Enabled = False
		Me.DescriptionTB.Enabled = False
		Me.RaisedToCmb.Enabled = False
		Me.RaisedByTb.Enabled = False
		'
		Me.RaisedByTb.Enabled = False
		NCRTabControl.TabPages(0).Enabled = True
		NCRTabControl.TabPages(1).Enabled = False
		NCRTabControl.TabPages(2).Enabled = False
		NCRTabControl.TabPages(3).Enabled = False
		NCRTabControl.TabPages(4).Enabled = False
		NCRTabControl.TabPages(5).Enabled = False
	End Sub

	Private Sub StatusNewNCR()
		Me.RaisedByTb.Enabled = False
		Me.RaisedToCmb.Enabled = True
		NCRTabControl.TabPages(0).Enabled = True
		NCRTabControl.TabPages(1).Enabled = False
		NCRTabControl.TabPages(2).Enabled = False
		NCRTabControl.TabPages(3).Enabled = False
		NCRTabControl.TabPages(4).Enabled = False
		NCRTabControl.TabPages(5).Enabled = False
		Me.ActionCmb.DataSource = DB.LoadActions(curNcr.status_id)
	End Sub

	Private Sub StatusNcrAccepted()
		NCRTabControl.TabPages(0).Enabled = True
		RaisedByTb.Enabled = False
		RaisedDatePicker.Enabled = False
		'RaisedToCmb.Enabled = False
		CurStatusCmb.Enabled = False
		TitleTb.Enabled = False
		DescriptionTB.Enabled = False
		'ActionCmb.Enabled = False
		'SubmitBtn.Enabled = False
		NCRTabControl.TabPages(1).Enabled = True
		NCRTabControl.TabPages(2).Enabled = False
		NCRTabControl.TabPages(3).Enabled = False
		NCRTabControl.TabPages(4).Enabled = False
		NCRTabControl.TabPages(5).Enabled = False
	End Sub

	Private Sub StatusNcrDelegated()
		NCRTabControl.TabPages(0).Enabled = True
		RaisedByTb.Enabled = False
		RaisedDatePicker.Enabled = False
		RaisedToCmb.Enabled = False
		CurStatusCmb.Enabled = False
		TitleTb.Enabled = False
		DescriptionTB.Enabled = False
		'ActionCmb.Enabled = False
		'SubmitBtn.Enabled = False
		NCRTabControl.TabPages(1).Enabled = True
		NCRTabControl.TabPages(2).Enabled = False
		NCRTabControl.TabPages(3).Enabled = False
		NCRTabControl.TabPages(4).Enabled = False
		NCRTabControl.TabPages(5).Enabled = False
	End Sub
	Private Sub StatusSubmitAndWaitingApprovalNCR()

	End Sub

	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub

	Private Sub SubmitBtn_Click(sender As System.Object, e As System.EventArgs) Handles SubmitBtn.Click

		Dim actionCode As String = Me.ActionCmb.SelectedValue

		' get raised to user
		If (Not IsNothing(RaisedToCmb.SelectedValue)) Then
			curNcr.raised_to_id = RaisedToCmb.SelectedValue

			Dim raisedToUser As TTMS.User = New TTMS.User()
			curNcr.RaisedToUser = DB.LoadUser(curNcr.raised_to_id)

		End If

		Select Case actionCode
			Case "SUBMIT"
				Dim result = NewNcrSubmitValidate()
				If (result <> 0) Then
					StatusStrip1.Items.Clear()
					StatusStrip1.Items.Add(CatsForm.ErrorCodes(result))
				Else 'validated
					NewNcrSubmit()
				End If
			Case "ACCEPT"
				Dim result = NcrAcceptValidate()
				If (result <> 0) Then
					StatusStrip1.Items.Clear()
					StatusStrip1.Items.Add(CatsForm.ErrorCodes(result))
				Else ' valid
					NcrAccept()
				End If
			Case "REJECT"
				Dim result = NcrRejectValidate()
				If (result <> 0) Then
					StatusStrip1.Items.Clear()
					StatusStrip1.Items.Add(CatsForm.ErrorCodes(result))
				Else
					'valid action
					NcrReject()
				End If
			Case "DELEGATE"
				Dim result = NcrDelegateValidate()
				If (result <> 0) Then
					StatusStrip1.Items.Clear()
					StatusStrip1.Items.Add(CatsForm.ErrorCodes(result))
				Else
					'valid action
					NcrDelegate()
				End If
			Case Else
				StatusStrip1.Items.Clear()
				StatusStrip1.Items.Add("Invalid action")
		End Select
	End Sub

	Private Function NewNcrSubmitValidate() As Integer
		' check if current status is newncr
		If (curNcr.status_id <> Status.NewNCR) Then Return ErrorCode.ActionNotAllowedForThisStatus
		'check if ncr is assigned to someone
		If (IsNothing(curNcr.raised_to_id)) Then Return ErrorCode.NcrNotAssigned
		'check if current user is same as raised_by
		If (curNcr.raised_by_id <> user.Id) Then Return ErrorCode.WrongNcrOwner
		Return 0
	End Function

	Private Sub NewNcrSubmit()
		'update status in db
		Dim ncrAdapt As TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter()
		Dim result = ncrAdapt.UpdateRaisedTo(curNcr.raised_to_id, curNcr.Id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.NewNcrSubmit, curNcr.Id)
		'add item to log
		Dim logAdapt As New TTMS.TTMSDataSetTableAdapters.LogsTableAdapter()
		Dim message As String = "New NCR Submitted to " + curNcr.RaisedToUser.Fullname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.Id, user.Id)
		'refresh the log tab
		NcrLog1.RefreshLog(curNcr.Id)
		'add item to notifications
		Dim notesAdapt As New TTMS.TTMSDataSetTableAdapters.NotificationsTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.Id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raised_to_id, curNcr.Id, "New NCR was assigned to you. Please update its status", DateTime.Now)
		'
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Function NcrAcceptValidate() As Integer
		' check if current status is ncrsubmit
		'If (curNcr.status_id <> Status.NewNcrSubmit) Then Return ErrorCode.ActionNotAllowedForThisStatus
		'check if ncr assignee is user
		If (curNcr.raised_to_id <> user.Id) Then Return ErrorCode.WrongNcrOwner
		Return 0
	End Function
	''' <summary>
	''' NCR status change to Accepted. Start CC
	''' </summary>
	''' <remarks></remarks>
	Private Sub NcrAccept()
		'update status in db
		Dim ncrAdapt As TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter()
		Dim statusResult = ncrAdapt.UpdateStatus(Status.NewNcrAccepted, curNcr.Id)
		'add item to log
		Dim logAdapt As New TTMS.TTMSDataSetTableAdapters.LogsTableAdapter()
		Dim message As String = "NCR Accepted by " & user.Fullname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.Id, user.Id)
		'
		RaisedToCmb.Enabled = False
		' create cc
		Dim cc = CreateCC(curNcr.Id)

		curNcr.CCs = cc


		'refresh the log tab
		NcrLog1.RefreshLog(curNcr.Id)
		'
		Dim notesAdapt As New TTMS.TTMSDataSetTableAdapters.NotificationsTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.Id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raised_to_id, curNcr.Id, "NCR was accepted by you. Please take actions", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Function NcrRejectValidate() As Integer
		' check if current status is ncrsubmit
		If (curNcr.status_id <> Status.NewNcrSubmit And curNcr.status_id <> Status.NewNcrDelegated) Then Return ErrorCode.ActionNotAllowedForThisStatus
		'check if ncr assignee is user
		If (curNcr.raised_to_id <> user.Id) Then Return ErrorCode.WrongNcrOwner
		Return 0
	End Function

	Private Sub NcrReject()
		'update status in db
		Dim ncrAdapt As TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter()
		Dim result = ncrAdapt.UpdateRaisedTo(Nothing, curNcr.Id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.NewNCR, curNcr.Id)
		'add item to log
		Dim logAdapt As New TTMS.TTMSDataSetTableAdapters.LogsTableAdapter()
		Dim message As String = "NCR Rejected by " & user.Fullname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.Id, user.Id)
		'refresh the log tab
		NcrLog1.RefreshLog(curNcr.Id)
		'
		Dim notesAdapt As New TTMS.TTMSDataSetTableAdapters.NotificationsTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.Id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raised_by_id, curNcr.Id, "NCR was rejected. Please reassign", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	Private Function NcrDelegateValidate() As Integer
		' check if current status is ncraccepted
		If (curNcr.status_id <> Status.NewNcrAccepted) Then Return ErrorCode.ActionNotAllowedForThisStatus
		'check if ncr assignee is user
		If (curNcr.raised_to_id = user.Id) Then Return ErrorCode.WrongNcrOwner
		Return 0
	End Function

	Private Sub NcrDelegate()
		'update status in db
		Dim ncrAdapt As TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter()
		Dim result = ncrAdapt.UpdateRaisedTo(curNcr.raised_to_id, curNcr.Id)
		Dim statusResult = ncrAdapt.UpdateStatus(Status.NewNcrDelegated, curNcr.Id)
		'add item to log
		Dim logAdapt As New TTMS.TTMSDataSetTableAdapters.LogsTableAdapter()
		Dim message As String = "NCR Delegated to " & curNcr.RaisedToUser.Fullname
		Dim logResult = logAdapt.InsertQuery(DateTime.Now, message, curNcr.Id, curNcr.Id)
		'
		RaisedToCmb.Enabled = False

		'refresh the log tab
		NcrLog1.RefreshLog(curNcr.Id)
		'
		Dim notesAdapt As New TTMS.TTMSDataSetTableAdapters.NotificationsTableAdapter()
		' remove previous messages for this ncr
		notesAdapt.DeleteAllNotificationsForNcr(curNcr.Id)
		Dim notesResult = notesAdapt.InsertQuery(curNcr.raised_to_id, curNcr.Id, "NCR was delegated to you. Please take actions", DateTime.Now)
		StatusStrip1.Items.Clear()
		StatusStrip1.Items.Add(message)
	End Sub

	''' <summary>
	''' Create the CC and return it
	''' </summary>
	''' <param name="ncrId"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	Private Function CreateCC(ncrId As Integer) As CC
		Dim ccAdapt = New TTMS.TTMSDataSetTableAdapters.CCsTableAdapter()
		' insert into db, returns new cc-id
		Dim result = ccAdapt.Insert(False, 0)
		Dim cc As CC = Nothing
		If (result > 0) Then
			'success
			NCRTabControl.TabPages(1).Enabled = True
			cc = New CC
			cc.Id = result
		End If
		Return cc
	End Function
End Class