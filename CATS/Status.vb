Public Class Status

	Public Enum StatusType
		NA = 0
		Creating = 1
		SubmittedToAssignee = 2
		Assigned = 3
		SubmittedToDelegate = 4
		Delegated = 5
	End Enum

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
	Private _state As StatusType
	Public Shared Property ActionRequiresUsername As Boolean() = {False, True, False, False, True, False, False, False, False}
	Public Property StatMessages As String() = {"Not Applicable", "NCR is being Created", "NCR is submitted to Assignee", "NCR is Assigned", "NCR is submitted to Delegate", "NCR is delegated"}
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


End Class
