Imports System.Threading

Public Class PollingDb

	Private Shared lastUpdate As DateTime
	Private Shared subscriber As IUpdateCallback

	Private Shared trd As Thread

	Public Shared Sub StartPolling()
		trd = New Thread(AddressOf CheckUpdate)
		trd.IsBackground = True
		trd.Start()
	End Sub

	Public Shared Sub CheckUpdate()
		Do
			Dim projectAdapt As MySqlDataSetTableAdapters.projectTableAdapter = New MySqlDataSetTableAdapters.projectTableAdapter()
			Dim dbLastUpdateTime = projectAdapt.GetLastUpdate()
			If (dbLastUpdateTime > lastUpdate) Then
				lastUpdate = dbLastUpdateTime
				subscriber.UpdateCallback()
			End If
			Console.WriteLine(dbLastUpdateTime)
			' timeout
			Thread.Sleep(5000)
		Loop
	End Sub

	Public Shared Sub SetSubscriber(subscr As IUpdateCallback)
		subscriber = subscr
	End Sub
End Class

Public Interface IUpdateCallback
	Sub UpdateCallback()
End Interface
