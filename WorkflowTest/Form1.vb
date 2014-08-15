Public Class Form1
	Private stat As Status
	Private tempAssignee As String
	Private tempDelegate As String

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		tempAssignee = vbNull
		tempDelegate = vbNull

		stat = New Status()
		stat.State = Status.StatusType.Creating
		stat.CreatedBy = "John"
		UpdateDisplay(stat)

		Me.StatCntr.SetupCallback(AddressOf Me.ActionChanged)
		Me.StatCntr.SetStatus(stat.State)
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub

	Public Sub ActionChanged(action As Status.Actions, username As String)
		MessageBox.Show("Action: " + action.ToString())
		HandleAction(action, username)
		UpdateDisplay(stat)
	End Sub

	Public Sub UpdateDisplay(stat As Status)
		CreatedByTb.Text = stat.CreatedBy
		AssignedToTb.Text = stat.AssignedTo
		DelegatedToTb.Text = stat.DelegatedTo
		StatusTb.Text = stat.State.ToString()
		Me.StatusMessageTb.Text = stat.StatMsg
	End Sub

	Private Sub HandleAction(action As Status.Actions, username As String)
		Select Case action
			Case Status.Actions.Create
				stat.State = Status.StatusType.Creating
			Case Status.Actions.Submit
				stat.State = Status.StatusType.SubmittedToAssignee
				tempAssignee = username
			Case Status.Actions.RejectByAssignee
				stat.State = Status.StatusType.Creating
			Case Status.Actions.AcceptByAssignee
				stat.State = Status.StatusType.Assigned
				stat.AssignedTo = tempAssignee
				tempAssignee = vbNull
			Case Status.Actions.Delegat
				stat.State = Status.StatusType.SubmittedToDelegate
				tempDelegate = username
			Case Status.Actions.RejectByDelegate
				stat.State = Status.StatusType.Assigned
			Case Status.Actions.AcceptByDelegate
				stat.State = Status.StatusType.Delegated
				stat.DelegatedTo = tempDelegate
				tempDelegate = vbNull
			Case Status.Actions.Save
			Case Status.Actions.Drop
				stat.State = Status.StatusType.NA
				stat.CreatedBy = ""
		End Select
		Me.StatCntr.SetStatus(stat.State)
	End Sub
End Class
