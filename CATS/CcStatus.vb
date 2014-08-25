Public Class CcStatus

	Public Structure StatusStruct
		Public Property Id As Integer
		Public Property Description As StatusType
		Sub New(p1 As Integer, statusType As CcStatus.StatusType)
			Id = p1
			Description = statusType
		End Sub
	End Structure

	Public Enum StatusType
		Creating = 0
		SubmittedToApprover = 1
		PlanExecution = 2
		SolutionVerification = 3
		Closed = 4
	End Enum

	Public Shared CcStatusTypes As StatusType() = {
	  StatusType.Creating,
	  StatusType.SubmittedToApprover,
	  StatusType.PlanExecution,
	  StatusType.SolutionVerification,
	  StatusType.Closed
	}
	Public Shared Property StatMessages As String() = {"CC is being Created", "CC Plan is submitted to Approver", "CC Plan Approved and Executing", "CC Solution Verification", "CC Verified and Closed"}

	Public Enum Actions
		Create = 0
		Submit = 1
		RejectByApprover = 2
		AcceptByApprover = 3
		ExecutionFinished = 4
		VerificationPassed = 5
		VerificationFailed = 6
	End Enum

	Public Shared ActionsArray As Actions() = {
	 Actions.Create,
	 Actions.Submit,
	 Actions.RejectByApprover,
	 Actions.AcceptByApprover,
	 Actions.ExecutionFinished,
	 Actions.VerificationPassed,
	 Actions.VerificationFailed
	}
	Public Property ActionMessages As String() = {"CC Creating", "CC submitted to approver", "CC Plan Rejected by Approver", "CC Plan Accepted by Approver", "CC Execution finished", "CC Verification Passed", "CC Verification Failed"}
	Public Shared Property ActionRequiresUsername As Boolean() = {False, True, False, False, True, False, False}

	Private status
	Private _state As StatusType

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

	Private statusItemList As List(Of CcStatus.StatusType)

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
		Return CcStatusTypes
	End Function

	Public Shared Function GetStatusList() As List(Of StatusStruct)
		Dim result = New List(Of StatusStruct)()
		result.Add(New StatusStruct(0, StatusType.Creating))
		result.Add(New StatusStruct(1, StatusType.SubmittedToApprover))
		result.Add(New StatusStruct(2, StatusType.PlanExecution))
		result.Add(New StatusStruct(3, StatusType.SolutionVerification))
		result.Add(New StatusStruct(4, StatusType.Closed))
		Return result
	End Function

End Class
