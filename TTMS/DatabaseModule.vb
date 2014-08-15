Module DatabaseModule

	Public Class Database
		''' <summary>
		''' Get the user from database by userid
		''' </summary>
		''' <param name="userid"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Public Shared Function LoadUser(userid As Integer) As User
			Dim userAdapter As New MySqlDataSetTableAdapters.userTableAdapter()
			Dim userTable As New MySqlDataSet.userDataTable()
			Dim result As Integer = userAdapter.FillById(userTable, userid)

			If (result = 1) Then
				Dim user As New User
				user.Firstname = userTable.Item(0).Field(Of String)("FirstName")
				user.Surname = userTable.Item(0).Field(Of String)("surname")
				user.Fullname = user.Surname + ", " + user.Firstname
				user.Id = userTable.Item(0).Field(Of Integer)("id")
				'
				'If (Not userTable.Item(0).Isdepartment_idNull) Then
				user.department_id = userTable.Item(0).Field(Of Integer)("department_id")
				'End If
				user.level_id = userTable.Item(0).Field(Of Integer)("level_id")
				user.is_admin = userTable.Item(0).Field(Of Boolean)("admin")
				Return user
			Else
				Return Nothing
			End If

		End Function

		''' <summary>
		''' Get the department from the database for the user
		''' </summary>
		''' <param name="user"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Public Shared Function LoadDepartment(user As User) As Department
			Dim departmentAdapter As New TTMSDataSetTableAdapters.DepartmentsTableAdapter
			Dim departmentTable As New TTMSDataSet.DepartmentsDataTable
			departmentAdapter.Fill(departmentTable)

			Dim results = From tempDep In departmentTable
			  Where tempDep.Id = user.department_id

			Dim resultDep As New Department
			If results.Count > 0 Then
				resultDep.Id = results(0).Id
				resultDep.Description = results(0).Description
			End If

			Return resultDep

		End Function
		''' <summary>
		''' Get the level from the database for user
		''' </summary>
		''' <param name="user"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Public Shared Function LoadLevel(user As User) As Level
			Dim levelAdapter As New MySqlDataSetTableAdapters.userlevelTableAdapter()
			Dim levelTable As New MySqlDataSet.userlevelDataTable()
			levelAdapter.Fill(levelTable)

			Dim results = From tempLevel In levelTable
			   Where tempLevel.id = user.level_id

			Dim resultLevel As New Level
			If results.Count > 0 Then
				resultLevel.Id = results(0).Id
				resultLevel.full_description = results(0).fulldescription
				resultLevel.short_description = results(0).shortdescription
			End If
			Return resultLevel
		End Function
	End Class
End Module
