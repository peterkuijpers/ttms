Public Class NcrLog

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()
	
		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub RefreshLog(ncrId As Integer)

		Dim logAdapt = New BaseModel.MySqlDataSetTableAdapters.logTableAdapter()
		'		logAdapt.FillBy(Me.LogDataSet.Logs, ncrId)
	End Sub
End Class
