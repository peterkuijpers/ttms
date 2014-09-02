
Public Class Dashboard
	Implements IUpdateCallback

	Private loggedIn As Boolean
	Private DotsOps As IOperation
	Private CatsOps As IOperation
	Private IssuesOps As IOperation
	Private OhsOps As IOperation

	Private thisUser As User
	Private thisDepartment As Department
	Private thisLevel As Userlevel


	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Dim p As New Program()
		p.portal.ShowPortalForm(Me)
		PollingDb.SetSubscriber(Me)
		PollingDb.StartPolling()

	End Sub

	Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		' Login before anything else
		Me.Enabled = False
		Dim loginForm = New LoginForm()
		Dim result As DialogResult = loginForm.ShowDialog()
		If (result <> Windows.Forms.DialogResult.OK) Then
			loggedIn = False
			MessageBox.Show(Me, "Closing program", "Closing")
			Me.Close()
			Return
		Else
			loggedIn = True
			Me.Enabled = True
		End If
		' get the user details
		Dim id = loginForm.GetUserId()
		thisUser = Database.LoadUser(id)
		Dim department As New Department
		department = Database.LoadDepartment(thisUser)
		thisUser.department = department
		DepartmentLbl.Text = department.description

		Dim lvl As New Userlevel
		lvl = Database.LoadLevel(thisUser)
		thisUser.userlevel = lvl
		LevelLbl.Text = lvl.fulldescription
		ShowUserDetails(thisUser)
		ShowNotifications(thisUser.id)
		ShowUserAdminBtn(thisUser.admin)

	End Sub
	''' <summary>
	''' Called when polling has detected an database update
	''' </summary>
	''' <remarks></remarks>
	Public Sub UpdateCallback() Implements IUpdateCallback.UpdateCallback
		If (Not IsNothing(thisUser)) Then
			If Me.InvokeRequired Then
				Me.Invoke(New MethodInvoker(AddressOf ShowNotifications))
			End If
		End If

	End Sub
	Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
		MessageBox.Show(Me, "User Admin")
	End Sub

	Public Sub SetDotsOps(ops As IOperation)
		Me.DotsOps = ops
	End Sub

	Public Sub SetCatsOps(ops As IOperation)
		Me.CatsOps = ops
	End Sub
	Public Sub setIssuesOps(ops As IOperation)
		Me.IssuesOps = ops
	End Sub
	Public Sub SetOhsOps(ops As IOperation)
		Me.OhsOps = ops
	End Sub

	Private Sub IssuesBtn_Click(sender As System.Object, e As System.EventArgs) Handles IssuesBtn.Click
		IssuesOps.ShowPluginForm(thisUser, -1)
	End Sub

	Private Sub catsBtn_Click(sender As System.Object, e As System.EventArgs) Handles CatsBtn.Click
		CatsOps.ShowPluginForm(thisUser, -1)
	End Sub

	Private Sub DotsBtn_Click(sender As System.Object, e As System.EventArgs) Handles DotsBtn.Click
		DotsOps.ShowPluginForm(thisUser, -1)
	End Sub

	Private Sub OhsBtn_Click(sender As System.Object, e As System.EventArgs) Handles OhsBtn.Click
		OhsOps.ShowPluginForm(thisUser, -1)
	End Sub

	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub

	Private Sub LogoutBtn_Click(sender As System.Object, e As System.EventArgs) Handles LogoutBtn.Click
		loggedIn = False
		ClearUserDetails()
		LogoutBtn.Visible = False
		Me.Enabled = False

		' open login screen
		Dim loginForm = New LoginForm()
		Dim result As DialogResult = loginForm.ShowDialog()
		If (result <> Windows.Forms.DialogResult.OK) Then ' login failed
			loggedIn = False
			MessageBox.Show(Me, "Closing program", "Closing")
			Me.Close()
			Return
		Else   'login successful
			loggedIn = True
			LogoutBtn.Visible = True
			Me.Enabled = True
		End If
		' get the user details
		Dim id = loginForm.GetUserId()
		thisUser = Database.LoadUser(id)
		Dim department As New Department
		department = Database.LoadDepartment(thisUser)
		thisUser.department = department
		DepartmentLbl.Text = department.description

		Dim lvl As New Userlevel
		lvl = Database.LoadLevel(thisUser)
		thisUser.userlevel = lvl
		LevelLbl.Text = lvl.fulldescription
		ShowUserDetails(thisUser)
		ShowNotifications(thisUser.id)
		ShowUserAdminBtn(thisUser.admin)

	End Sub

	Private Sub ShowUserDetails(thisuser As User)
		UserNameLbl.Text = thisuser.firstname + " " + thisuser.surname

	End Sub

	Private Sub GetUserDetails(id As Integer)

	End Sub

	Private Sub ShowNotifications()
		Dim userid = thisUser.id
		Dim notesAdapt = New MySqlDataSetTableAdapters.notificationTableAdapter()
		Dim notesTable = New MySqlDataSet.notificationDataTable()
		notesTable = notesAdapt.GetDataByUserId(userid)

		NotificationsGridView.DataSource = notesTable
		NotificationsGridView.Refresh()

	End Sub

	Private Sub ShowNotifications(userid As Integer)
		Dim notesAdapt = New MySqlDataSetTableAdapters.notificationTableAdapter()
		Dim notesTable = New MySqlDataSet.notificationDataTable()
		notesTable = notesAdapt.GetDataByUserId(userid)

		NotificationsGridView.DataSource = notesTable
		NotificationsGridView.Refresh()

	End Sub

	Private Sub ClearUserDetails()
		Me.thisUser = Nothing
		Me.UserNameLbl.Text = Nothing
		Me.DepartmentLbl.Text = Nothing
		Me.LevelLbl.Text = Nothing
		Me.LevelDescriptionLbl.Text = Nothing

	End Sub

	Private Sub NotificationsGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles NotificationsGridView.CellDoubleClick
		Dim rowNbr = e.RowIndex
		Dim row = DirectCast(sender, DataGridView).Rows(rowNbr)
		Dim ncrId = DirectCast(row.Cells.Item("ncr_id").Value, Integer)

		CatsOps.ShowPluginForm(thisUser, ncrId)
		ShowNotifications(thisUser.id)
	End Sub

	Private Sub ShowUserAdminBtn(is_admin As Boolean)
		UserManagementBtn.Visible = is_admin
	End Sub
End Class
