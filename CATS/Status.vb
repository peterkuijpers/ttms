Public Class Status

	Public Structure StatusStruct
		Public Property Id As Integer
		Public Property Description As StatusType
		Sub New(p1 As Integer, statusType As Status.StatusType)
			Id = p1
			Description = statusType
		End Sub
	End Structure
	Public Enum StatusType
		Creating = 0
		Modifying = 1
		SubmittedToAssignee = 2
		Assigned = 3
		SubmittedToDelegate = 4
		Delegated = 5
	End Enum
	Public Shared StatusTypes As StatusType() = {
	  StatusType.Creating,
	  StatusType.Modifying,
	  StatusType.SubmittedToAssignee,
	  StatusType.Assigned,
	  StatusType.SubmittedToDelegate,
	  StatusType.Delegated
	}


	Public Enum Actions
		Create = 0
		Submit = 1
		RejectByAssignee = 2
		AcceptByAssignee = 3
		Delegat = 4
		RejectByDelegate = 5
		AcceptByDelegate = 6
		Save = 7
		Drop = 8
	End Enum
	Public Shared ActionsArray As Actions() = {
	 Actions.Create,
	 Actions.Submit,
	 Actions.RejectByAssignee,
	 Actions.RejectByDelegate,
	 Actions.Delegat,
	 Actions.RejectByDelegate,
	 Actions.AcceptByDelegate,
	 Actions.Save,
	 Actions.Drop
	}

	Private status
	Private _state As StatusType
	Public Shared Property ActionRequiresUsername As Boolean() = {False, True, False, False, True, False, False, False, False}
	Public Shared Property StatMessages As String() = {"NCR is being Created", "NCR Modifying", "NCR is submitted to Assignee", "NCR is Assigned", "NCR is submitted to Delegate", "NCR is delegated"}
	Public Property ActionMessages As String() = {"NCR Created", "NCR submitted to assignee", "Rejected by Assignee", "Accepted by Assignee", "Delegated", "Rejected by Delegate", "Accepted by Delegate", "NCR Saved", "NCR Dropped"}
	Public Property State As StatusType
		Get
			Return _state
		End Get
		Set(value As StatusType)
			_state = value
			StatMsg = StatMessages(value)
		End Set
	End Property
	Public Property PrevStat As StatusType
	Public Property UserFrom As Integer
	Public Property UserTo As Integer
	Public Property StatMsg As String
	Public Property CreatedBy As String
	Public Property AssignedTo As String
	Public Property DelegatedTo As String

	Private emailList As List(Of String)

	Private statusItemList As List(Of Status.StatusType)

	''' <summary>
	''' Constructor
	''' </summary>
	''' <remarks></remarks>
	Public Sub New()
		State = StatusType.Creating
		PrevStat = Nothing
		UserFrom = Nothing
		UserTo = Nothing
		StatMsg = StatMessages(State)
		emailList = GetEmails(State, UserFrom, UserTo, AssignedTo, DelegatedTo)
	End Sub

	Private Function GetEmails(ByVal state As StatusType, UserFrom As Integer, UserTo As Integer, AssignedTo As Integer, DelegatedTo As Integer) As List(Of String)
		Dim emailList As List(Of String) = New List(Of String)
		Return emailList
	End Function

	Public Shared Function GetStatusTypes() As StatusType()
		Return StatusTypes
	End Function

	Public Shared Function GetStatusList() As List(Of StatusStruct)
		Dim result = New List(Of StatusStruct)()
		result.Add(New StatusStruct(0, StatusType.Creating))
		result.Add(New StatusStruct(1, StatusType.Modifying))
		result.Add(New StatusStruct(2, StatusType.SubmittedToAssignee))
		result.Add(New StatusStruct(3, StatusType.Assigned))
		result.Add(New StatusStruct(4, StatusType.SubmittedToDelegate))
		result.Add(New StatusStruct(5, StatusType.Delegated))
		Return result
	End Function

End Class
