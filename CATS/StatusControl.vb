Imports BaseModel

Public Class StatusControl
	Private statusMatrix()() As Integer = New Integer(5)() {}
	Private users = New List(Of User)
	Private state As Status.StatusType
	Private callback As Action(Of Status.Actions, String)
	Private curUser As User

	Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		statusMatrix(0) = {0}		'status "creating": Actions: Create
		statusMatrix(1) = {1, 7, 8}	'status "modifying": submit, save, drop
		statusMatrix(2) = {3, 2}  ' status "submittedtoassignee": reject, accept
		statusMatrix(3) = {4}	  'status "delegate"
		statusMatrix(4) = {6, 5}  ' status "submittedtodelegate": reject, accept
		statusMatrix(5) = {}	  ' status "delegated"
	End Sub


	Public Sub SetupCallback(callback As Action(Of Status.Actions, String))
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

	Public Sub SetStatus(state As Status.StatusType)
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
			Dim usernameReq As Boolean = Status.ActionRequiresUsername(action)
			If usernameReq Then
				UserCb.Visible = True
			End If
			Select Case action
				Case Status.Actions.Create
					button.Text = "Create"
				Case Status.Actions.Submit
					button.Text = "Submit to Assignee"
				Case Status.Actions.RejectByAssignee
					button.Text = "Reject by Assignee"
				Case Status.Actions.AcceptByAssignee
					button.Text = "Accept by Assignee"
				Case Status.Actions.Delegat
					button.Text = "Delegate to"
				Case Status.Actions.RejectByDelegate
					button.Text = "Reject by Delegate"
				Case Status.Actions.AcceptByDelegate
					button.Text = "Accept by Delegate"
				Case Status.Actions.Save
					button.Text = "Save"
				Case Status.Actions.Drop
					button.Text = "Drop"
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
		Dim action As Status.Actions
		action = DirectCast(button.Tag, Status.Actions)
		Dim userReq As Boolean = Status.ActionRequiresUsername(action)
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