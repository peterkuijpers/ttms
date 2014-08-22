Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting

' http://msdn.microsoft.com/en-us/library/dd460648.aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1

Public Module PluginManager

	Public Interface IPortal
		Sub ShowPortalForm(form As Dashboard)
	End Interface

	Public Interface IOperation
		Sub ShowPluginForm(ByVal user As User, ByVal ncrId As Integer)
	End Interface

	Public Interface IOperationData
		ReadOnly Property PluginType As String
	End Interface

	''' <summary>
	''' plugin 
	''' </summary>
	''' <remarks></remarks>
	Public Class Program
		Dim container As CompositionContainer

		Public Sub New()
			Dim catalog = New AggregateCatalog()
			catalog.Catalogs.Add(New AssemblyCatalog(GetType(Program).Assembly))
			container = New CompositionContainer(catalog)
			Try
				catalog.Catalogs.Add(New DirectoryCatalog("C:\Users\Peter.Kuijpers\Documents\VB2010Projects\TTMS\ModelTest\Plugins")) '
				container.ComposeParts(Me)
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
			End Try
		End Sub

		<Import(GetType(IPortal))>
		Public Property portal As IPortal

	End Class


	<Export(GetType(IPortal))>
	Public Class MyPortal
		Implements IPortal

		<ImportMany()>
		Public Property operations As IEnumerable(Of Lazy(Of IOperation, IOperationData))

		Public Sub ShowPortalForm(form As Dashboard) Implements IPortal.ShowPortalForm

			For Each i As Lazy(Of IOperation, IOperationData) In operations
				If i.Metadata.PluginType = "dots" Then
					form.DotsBtn.Visible = True
					form.SetDotsOps(i.Value)
				ElseIf i.Metadata.PluginType = "cats" Then
					form.CatsBtn.Visible = True
					form.setCatsOps(i.Value)
				End If
			Next
		End Sub

	End Class

End Module


