Imports BaseModel
Public Class NcrLog

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Public Sub RefreshLog(ncrId As Integer)
		Dim logAdapt = New MySqlDataSetTableAdapters.logTableAdapter()
		'	logAdapt.FillBy(Me.LogDataSet.log, ncrId)
	End Sub
End Class
