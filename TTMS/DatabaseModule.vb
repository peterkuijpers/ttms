﻿Module DatabaseModule

	Public Class Database
		Public Shared Function LoadUser(userid As Integer) As User
			Dim userAdapter As New TTMSDataSetTableAdapters.UsersTableAdapter
			Dim userTable As New TTMSDataSet.UsersDataTable
			Dim result As Integer = userAdapter.FillById(userTable, userid)

			If (result = 1) Then
				Dim user As New User
				user.Firstname = userTable.Item(0).Field(Of String)("FirstName")
				user.Surname = userTable.Item(0).Field(Of String)("surname")
				user.Fullname = user.Surname + ", " + user.Firstname
				user.Id = userTable.Item(0).Field(Of Integer)("id")
				If (Not userTable.Item(0).Isdepartment_idNull) Then
					user.department_id = userTable.Item(0).Field(Of Integer)("department_id")
				End If
				user.level_id = userTable.Item(0).Field(Of Integer)("level_id")
				user.is_admin = userTable.Item(0).Field(Of Boolean)("is_admin")
				Return user
			Else
				Return Nothing
			End If

		End Function

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
		Public Shared Function LoadLevel(user As User) As Level
			Dim levelAdapter As New TTMSDataSetTableAdapters.LevelsTableAdapter
			Dim levelTable As New TTMSDataSet.LevelsDataTable
			levelAdapter.Fill(levelTable)


			Dim results = From tempLevel In levelTable
			  Where tempLevel.Id = user.level_id

			Dim resultLevel As New Level
			If results.Count > 0 Then
				resultLevel.Id = results(0).Id
				resultLevel.full_description = results(0).full_description
				resultLevel.short_description = results(0).short_description
			End If

			Return resultLevel

		End Function


	End Class

End Module
