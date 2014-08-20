Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports BaseModel

<Export(GetType(IOperation))>
<ExportMetadata("PluginType", "dots")>
Public Class DotsForm
	Implements IOperation


	Public Sub ShowPluginForm(ByVal user As User, ByVal ncrId As Integer) Implements IOperation.ShowPluginForm
		Me.ShowDialog()
	End Sub


	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub
End Class