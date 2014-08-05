Public Class Status

	Public Enum StatusType
		Creating = 1
		SubmitToAssignee = 2
		Assigned = 3
		SubmitToDelegate = 4
		Delegated = 5
	End Enum
	
	Public Property StatMessages As String() = {"NCR is being Created", "NCR is submitted to Assignee", "NCR is Assigned", "NCR is submitted to Delegate", "NCR is delegated"}
	Public Property State As StatusType
	Public Property PrevStat As StatusType
	Public Property UserFrom As Integer
	Public Property UserTo As Integer
	Public Property StatMsg As String

	Public Property AssignedTo As Integer
	Public Property DelegatedTo As Integer

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
