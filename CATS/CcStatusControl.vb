Imports BaseModel

Public Class CcStatusControl
	Private statusMatrix()() As Integer = New Integer(5)() {}
	Private users = New List(Of User)
	Private state As CcStatus.StatusType
	Private callback As Action(Of CcStatus.Actions, String)
	Private curUser As User


	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		statusMatrix(0) = {1}	'status: creating; actions: submit
		statusMatrix(1) = {2, 3} 'status: submit; actions: reject, approve
		statusMatrix(2) = {4}	'status: execution; actions: ExecutionFinished
		statusMatrix(3) = {5, 6} 'status: verification; actions: Passed, Failed
		statusMatrix(4) = {}	'status: close
	End Sub

	Public Sub SetupCallback(callback As Action(Of CcStatus.Actions, String))
		Me.callback = callback
	End Sub

	Public Sub SetUsers(users As List(Of User))
		Me.users = users
		UserCb.DataSource = Me.users
		UserCb.ValueMember = "id"
		UserCb.DisplayMember = "firstname" + "," + "surname"
		UserCb.SelectedIndex = -1
	End Sub
	Public Sub SetUsers(users As MySqlDataSet.userDataTable)
		UserCb.DataSource = users
		UserCb.ValueMember = "id"
		UserCb.DisplayMember = "userid"
		UserCb.SelectedIndex = -1
	End Sub

	Public Sub SetStatus(state As CcStatus.StatusType)
		Me.state = state

		RemoveAllButtons()
		'get available actions for this state
		Dim actions As Integer() = statusMatrix(state)
		UserCb.Visible = False
		For Each action As Integer In actions
			Dim button As Button = New Button()
			button.Width = 150
			button.Tag = action
			AddHandler button.Click, AddressOf OnButtonClick
			ActionFlowPanel.Controls.Add(button)
			Dim usernameReq As Boolean = CcStatus.ActionRequiresUsername(action)
			If usernameReq Then
				UserCb.Visible = True
			End If
			Select Case action
				Case CcStatus.Actions.Create
					button.Text = "Create"
				Case CcStatus.Actions.Submit
					button.Text = "Submit to Approver"
				Case CcStatus.Actions.RejectByApprover
					button.Text = "Reject by Approver"
				Case CcStatus.Actions.AcceptByApprover
					button.Text = "Accept by Approver"
				Case CcStatus.Actions.ExecutionFinished
					button.Text = "Execution Finished"
				Case CcStatus.Actions.VerificationPassed
					button.Text = "Verification Passed"
				Case CcStatus.Actions.VerificationFailed
					button.Text = "Verification Failed"
				Case Else
					'else do
			End Select
		Next
	End Sub
	Private Sub RemoveAllButtons()
		ActionFlowPanel.Controls.Clear()
	End Sub

	Private Sub OnButtonClick(sender As System.Object, e As System.EventArgs)
		' inform caller that there was an action 
		Dim button As Button = DirectCast(sender, Button)
		Dim action As CcStatus.Actions
		action = DirectCast(button.Tag, CcStatus.Actions)
		Dim userReq As Boolean = CcStatus.ActionRequiresUsername(action)
		Dim userid As Integer
		If userReq Then
			If UserCb.SelectedValue Is Nothing Then
				MessageBox.Show("Select user")
				Exit Sub
			Else
				userid = UserCb.SelectedValue
			End If
		End If
		callback(action, userid)
	End Sub

End Class
