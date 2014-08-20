Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports BaseModel

Public Enum ErrorCode As Integer
	WrongNcrOwner = 1
	ActionNotAllowedForThisStatus = 2
	NcrNotAssigned = 3
End Enum
<Export(GetType(IOperation))>
<ExportMetadata("PluginType", "cats")>
Public Class CatsForm
	Implements IOperation
	'must match with errorcode
	Public Shared ErrorCodes As String() = {"",
	 "You are not allowed to perform action",
	 "This action is not allowed for this status",
	 "Ncr was not assigned to a user"
	}

	Private catsUser As User
	''' <summary>
	''' Show this form as a Plugin
	''' </summary>
	''' <param name="usr"></param>
	''' <remarks></remarks>
	Public Sub ShowPluginForm(ByVal usr As User, ByVal ncrId As Integer) Implements IOperation.ShowPluginForm
		Me.catsUser = usr
		UpdateHeaderInfo(usr)
		If (ncrId = -1) Then
			Me.ShowDialog()
		Else
			ShowDetails(ncrId)
		End If


	End Sub

	''' <summary>
	''' Update the header part of the form with the user details
	''' </summary>
	''' <param name="usr"></param>
	''' <remarks></remarks>
	Private Sub UpdateHeaderInfo(usr As user)
		UserStatStripLbl.Text = usr.Firstname & " " & usr.Surname
		LevelStatStripLbl.Text = usr.userlevel.fulldescription
	End Sub

	''' <summary>
	''' Close this form
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub QuitBtn_Click(sender As System.Object, e As System.EventArgs) Handles QuitBtn.Click
		Me.Close()
	End Sub

	''' <summary>
	''' Start creating a new CAR
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub NewCarBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewCarBtn.Click
		'Dim carForm As New NewCARForm()
		'carForm.CreateNewCAR = True
		'carForm.User = catsUser

		'Dim result As DialogResult = carForm.ShowDialog(Me)
		'If result = DialogResult.OK Then
		'Reload()
		'DataGridView1.Refresh()
		'End If

		Dim newForm As New NCRDetailsForm()
		newForm.SetNcrDetails(-1, catsUser)
		'		newForm.SetCurrentUser(catsUser)
		newForm.ShowDialog()

	End Sub


	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs)
		Me.Close()
	End Sub

	Private Sub Reload()
		
		Dim ncrAdapt As MySqlDataSetTableAdapters.ncrTableAdapter = New MySqlDataSetTableAdapters.ncrTableAdapter()
		Dim ncrTable = New MySqlDataSet.ncrDataTable()
		ncrAdapt.Fill(ncrTable)
		DataGridView1.DataSource = ncrTable

		
		Dim userAdapt = New MySqlDataSetTableAdapters.userTableAdapter()
		Dim userTable = New MySqlDataSet.userDataTable()
		userAdapt.Fill(userTable)
		RaisedByIdCmb.DataSource = userTable
		RaisedByIdCmb.ValueMember = "id"
		RaisedByIdCmb.DisplayMember = "userid"

		StatusIdCmb.DataSource = Status.GetStatusList()
		StatusIdCmb.ValueMember = "Id"
		StatusIdCmb.DisplayMember = "Description"

		AssignedToIdCmb.DataSource = userTable
		AssignedToIdCmb.ValueMember = "id"
		AssignedToIdCmb.DisplayMember = "userid"
		DelegateIdCmb.DataSource = userTable
		DelegateIdCmb.ValueMember = "id"
		DelegateIdCmb.DisplayMember = "userId"

	End Sub

	''' <summary>
	''' Show details when any cell is double clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
		Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
		Dim selectedCarId As Integer = row.Cells("idColumn").Value
		ShowDetails(selectedCarId)
		Reload()
	End Sub

	''' <summary>
	''' Show details of selected CAR
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowDetails(selectedCarId As Integer)
		Dim form As New NCRDetailsForm()
		form.SetNcrDetails(selectedCarId, catsUser)
		''		form.SetCurrentUser(catsUser)
		Dim result As DialogResult = form.ShowDialog(Me)
	End Sub


	Private Sub CatsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		Reload()
	End Sub
End Class


