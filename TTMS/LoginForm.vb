''' <summary>
''' Login. Returns OK if successful. Get userid by calling GetUserId
''' </summary>
''' <remarks></remarks>
Public Class LoginForm

	Private userid As Integer



	Public Function GetUserId() As Integer
		Return userid
	End Function

	Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

	End Sub

	Private Sub LoginBtn_Click(sender As System.Object, e As System.EventArgs) Handles LoginBtn.Click

		Dim userTable As New MySqlDataSet.userDataTable()
		Dim userAdapt As New MySqlDataSetTableAdapters.userTableAdapter()

		Dim result As Integer = Convert.ToInt32(userAdapt.CheckPwd(Me.UserIdTb.Text, Me.PwdTb.Text))
		' returns  id of the user or 0 if not found
		If (result > 0) Then
			userid = result
			Me.DialogResult = Windows.Forms.DialogResult.OK
			Me.Close()
		Else
			Me.StatusStrip1.Items.Clear()
			Me.StatusStrip1.Items.Add("Invalid userid/password combination")
			userid = -1
		End If

	End Sub

	Private Sub TextBox1_Enter(sender As System.Object, e As System.EventArgs) Handles UserIdTb.Enter
		Me.StatusStrip1.Items.Clear()
	End Sub

	Private Sub PwdTb_Enter(sender As System.Object, e As System.EventArgs) Handles PwdTb.Enter
		Me.StatusStrip1.Items.Clear()
	End Sub
End Class