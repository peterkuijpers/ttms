Public Class DB

	Public Shared Function LoadNcr(ncrId As Integer) As Ncr
		Dim ncrAdapt = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim datatable = ncrAdapt.GetDataBy1(ncrId)
		If datatable.Rows.Count <> 1 Then
			Return Nothing
		Else
			Dim dr = datatable.Rows(0)
			Dim id As Integer = CType(dr.Item("id"), Integer)
			Dim raisedby_id As Integer? = Nothing
			If Not IsDBNull(dr.Item("raisedby_id")) Then
				raisedby_id = CType(dr.Item("raisedby_id"), Integer)
			End If
			Dim raised_date = CType(dr.Item("raiseddate"), DateTime)
			Dim assignedto_id As Integer? = Nothing
			If Not IsDBNull(dr.Item("assignedto_id")) Then
				assignedto_id = CType(dr.Item("assignedto_id"), Integer)
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
			Dim owner_id = CType(dr.Item("owner_id"), Integer)
			Dim thisNcr As Ncr = New Ncr()
			thisNcr.id = id
			thisNcr.raisedby_id = raisedby_id
			thisNcr.raiseddate = raised_date
			thisNcr.assignedto_id = assignedto_id
			thisNcr.status_id = status_id
			thisNcr.rcp_id = RCP_id
			thisNcr.description = description
			thisNcr.title = title
			thisNcr.owner_id = owner_id
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


	Public Shared Function LoadCc(ccId As Integer) As cc
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim datatable = ccAdapt.GetDataById(ccId)
		If datatable.Rows.Count <> 1 Then
			Return Nothing
		Else
			Dim dr = datatable.Rows(0)
			Dim id As Integer = CType(dr.Item("id"), Integer)
			Dim status_id = CType(dr.Item("status_id"), Integer)
			Dim planapprover_id As Integer = Nothing
			If Not IsDBNull(dr.Item("planapprover_id")) Then
				planapprover_id = CType(dr.Item("planapprover_id"), Integer)
			End If
			Dim solutionverifier_id = Nothing
			If Not IsDBNull(dr.Item("solutionverifier_id")) Then
				solutionverifier_id = CType(dr.Item("solutionverifier_id"), Integer)
			End If
			Dim owner_id = CType(dr.Item("owner_id"), Integer)
			Dim thisCc As cc = New cc()
			thisCc.id = id
			thisCc.status_id = status_id
			thisCc.planapprover_id = planapprover_id
			thisCc.solutionverifier_id = solutionverifier_id
			thisCc.owner_id = owner_id
			Return thisCc
		End If
	End Function

	Public Shared Function UpdateCcStatus(ccId As Integer, newStatus As Integer) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateStatus(newStatus, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	
	Public Shared Function SetCcPlanApprover(ccId As Integer, planApproverId As Integer) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdatePlanApprover(planApproverId, ccid)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function SetCcSolutionVerifier(ccId As Integer, solutionVerifierId As Integer) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateSolutionVerifier(solutionVerifierId, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function SetCcOwner(ccId As Integer, ownerId As Integer) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateOwner(ownerId, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function SetNcrOwner(ncrId As Integer, ownerid As Integer) As Boolean
		Dim ncrAdapt = New MySqlDataSetTableAdapters.ncrTableAdapter
		Dim result = ncrAdapt.UpdateOwner(ownerid, ncrId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function UpdateCcPlanApprovaDate(ccId As Integer, updDate As DateTime) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateCcPlanApproveDate(updDate, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function UpdateCcPlanApproveDate(ccId As Integer, updDate As DateTime) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateCcPlanApproveDate(updDate, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function UpdateCcCompletionDate(ccId As Integer, updDate As DateTime) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateCompletionDate(updDate, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Shared Function UpdateCcVerificationDate(ccId As Integer, updDate As DateTime) As Boolean
		Dim ccAdapt = New MySqlDataSetTableAdapters.ccTableAdapter
		Dim result = ccAdapt.UpdateVerificationDate(updDate, ccId)
		If result > 0 Then
			Return True
		Else
			Return False
		End If
	End Function


End Class
