Public Class DB

	Public Shared Function LoadNcr(ncrId As Integer) As Ncr
		Dim ncrAdapt = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim datatable = ncrAdapt.GetDataBy1(ncrId)
		If datatable.Rows.Count <> 1 Then
			Return Nothing
		Else
			Dim dr = datatable.Rows(0)
			Dim id As Integer = CType(dr.Item("id"), Integer)
			Dim raised_by_id As Integer? = Nothing
			If Not IsDBNull(dr.Item("raisedby_id")) Then
				raised_by_id = CType(dr.Item("raisedby_id"), Integer)
			End If
			Dim raised_date = CType(dr.Item("raiseddate"), DateTime)
			Dim raised_to_id As Integer? = Nothing
			If Not IsDBNull(dr.Item("assignedto_id")) Then
				raised_to_id = CType(dr.Item("assignedto_id"), Integer)
			End If
			Dim status_id = CType(dr.Item("status_id"), Integer)
			Dim CC_id As Integer? = Nothing
			Dim RCP_id As Integer? = Nothing
			If Not IsDBNull(dr.Item("RCP_id")) Then
				RCP_id = CType(dr.Item("RCP_id"), Integer)
			End If
			Dim description As String = Nothing
			If Not IsDBNull(dr.Item("Description")) Then
				description = CType(dr.Item("Description"), String)
			End If
			Dim title = CType(dr.Item("title"), String)
			'Dim thisNcr As NCR = NCR.CreateNCR(id, raised_by_id, raised_date, raised_to_id, status_id, description, title)
			Dim thisNcr As Ncr = New Ncr()
			thisNcr.id = id
			thisNcr.raisedby_id = raised_by_id
			thisNcr.raiseddate = raised_date
			thisNcr.assignedto_id = raised_to_id
			thisNcr.status_id = status_id
			thisNcr.rcp_id = RCP_id
			thisNcr.description = description
			thisNcr.title = title
			Return thisNcr
		End If

	End Function

	Public Shared Function StoreNcr(ncr As Ncr) As Boolean

	End Function

	Public Shared Function UpdateNcr(ncr As Ncr) As Boolean
		Dim ncrAdapt = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim result As Integer = 1
		'		Dim result As Integer = ncrAdapt.UpdateNcrDetails(ncr.raised_to_id, ncr.Description, ncr.Id, System.DBNull)
		'		Dim result As Integer = ncrAdapt.Update(ncr.raised_by_id, ncr.raised_date, ncr.raised_to_id, ncr.status_id, ncr.RCP_id, ncr.Description, ncr.title, ncr.Id, ncr.raised_by_id, ncr.raised_date, ncr.raised_to_id, ncr.status_id, ncr.RCP_id)


		If result > 0 Then
			Return True
		Else
			Return False
		End If

	End Function

	Public Shared Function LoadUser(id As Integer) As User
		Dim userAdapt = New MySqlDataSetTableAdapters.userTableAdapter()
		Dim dataTable = userAdapt.GetDataById(id)
		If (dataTable.Rows.Count <> 1) Then
			Return Nothing
		Else
			Dim dr = dataTable.Rows(0)
			Dim userid As Integer = CType(dr.Item("id"), Integer)
			Dim firstname As String = CType(dr.Item("firstname"), String)
			Dim surname As String = CType(dr.Item("surname"), String)

			Dim user As User = New User()

			user.Id = userid
			user.Firstname = firstname
			user.Surname = surname
			'			user.Fullname = surname + ", " + firstname
			Return user
		End If

	End Function

	''' <summary>
	''' Load datatable with all users from the database
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Shared Function LoadUsers() As MySqlDataSet.userDataTable
		Dim userAdapt = New MySqlDataSetTableAdapters.userTableAdapter()
		Dim dt = userAdapt.GetData()
		Return dt
	End Function

	''' <summary>
	''' Load datatable with all status from database
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	'Public Shared Function LoadStatus() As MySqlDataSet.NCR_Status1DataTable
	'	MySqlDataSet.ncr
	'	'Dim dt As TTMSDataSet.NCR_StatusDataTable = New TTMSDataSet.NCR_StatusDataTable()
	'	'dt.Clear()
	'	'Dim statusAdapt = New TTMS.TTMSDataSetTableAdapters.NCR_StatusTableAdapter()
	'	Dim dt As TTMS.TTMSDataSet.NCR_Status1DataTable = New TTMS.TTMSDataSet.NCR_Status1DataTable()
	'	dt.Clear()
	'	Dim statusAdapt = New TTMS.TTMSDataSetTableAdapters.NCR_Status1TableAdapter()
	'	dt = statusAdapt.GetData()
	'	Return dt
	'End Function

	'Public Shared Function LoadActions(statusId As Integer) As TTMS.TTMSDataSet.ActionsDataTable
	'	Dim actionsAdapt = New TTMS.TTMSDataSetTableAdapters.ActionsTableAdapter()
	'	Dim dt = actionsAdapt.GetDataByStatusId(statusId)
	'	Return dt
	'End Function
End Class
