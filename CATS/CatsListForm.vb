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
Public Class CatsListForm
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
	''' <param name="user"></param>
	''' <remarks></remarks>
	Public Sub ShowPluginForm(ByVal user As User, ByVal ncrId As Integer) Implements IOperation.ShowPluginForm
		Me.catsUser = user
		UpdateHeaderInfo(user)
	
		If (ncrId = -1) Then
			Me.ShowDialog()
		Else
			ShowDetails(ncrId)
		End If


	End Sub

	''' <summary>
	''' Update the header part of the form with the user details
	''' </summary>
	''' <param name="user"></param>
	''' <remarks></remarks>
	Private Sub UpdateHeaderInfo(user As User)
		'UsernameLbl.Text = user.Firstname & " " & user.Surname
		'LevelLbl.Text = user.Level.full_description
		UserStripLbl.Text = user.firstname & " " & user.surname
		LevelStripLbl.Text = user.userlevel.fulldescription
	End Sub


	''' <summary>
	''' Close this form
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
		Me.Close()
	End Sub

	''' <summary>
	''' Start creating a new CAR
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub NewCarBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewNcrBtn.Click
		'Dim form As New NewCARForm()
		'form.CreateNewCAR = True
		'form.User = catsUser

		'Dim result As DialogResult = form.ShowDialog(Me)
		'If result = DialogResult.OK Then
		'	Reload()
		'	DataGridView1.Refresh()
		'End If

	End Sub

	Private Sub Reload()

		DataGridView1.AutoGenerateColumns = False
		Dim NCRsTableAdapter = New BaseModel.MySqlDataSetTableAdapters.ncrTableAdapter
		Dim ncrTable = New BaseModel.MySqlDataSet.ncrDataTable()
		NCRsTableAdapter.Fill(ncrTable)
		DataGridView1.DataSource = ncrTable

		Dim UserTableAdapter = New BaseModel.MySqlDataSetTableAdapters.userTableAdapter
		Dim userTable = New BaseModel.MySqlDataSet.userDataTable()
		UserTableAdapter.Fill(userTable)

		RaisedByCol.DataSource = userTable
		RaisedByCol.ValueMember = "id"
		RaisedByCol.DisplayMember = "userid"

		AssignedToCol.DataSource = userTable
		AssignedToCol.ValueMember = "id"
		AssignedToCol.DisplayMember = "userid"

		DelegatedToCol.DataSource = userTable
		DelegatedToCol.ValueMember = "id"
		DelegatedToCol.DisplayMember = "userid"

		Dim statList = New Dictionary(Of Int16, String)
		statList.Add(1, "one")
		statList.Add(2, "two2")
		statList.Add(3, "two3")
		statList.Add(4, "two4")
		statList.Add(5, "two5")
		statList.Add(6, "two6")
		statList.Add(7, "two7")
		statList.Add(8, "two8")
		statList.Add(9, "two9")
		statList.Add(0, "two0")

		'StatusCol.DataSource = Nothing
		'StatusCol.DataSource = New BindingSource(statList, Nothing)
		'StatusCol.ValueMember = "Key"
		'StatusCol.DisplayMember = "Value"






	End Sub

	''' <summary>
	''' Show details when any cell is double clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
		Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
		Dim selectedCarId As Integer = row.Cells("idcolumn").Value

		ShowDetails(selectedCarId)
		Reload()
	End Sub

	''' <summary>
	''' Show details of selected CAR
	''' </summary>
	''' <remarks></remarks>
	Private Sub ShowDetails(selectedCarId As Integer)
		Dim form As New NCRDetailsForm(selectedCarId)
		form.SetCurrentUser(catsUser)
		Dim result As DialogResult = form.ShowDialog(Me)

	End Sub

	Private Sub CatsListForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		DataGridView1.ReadOnly = True
		Reload()
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

	End Sub

	Private Sub DataGridView1_CellContentDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

		Dim id = CType(DataGridView1.Rows(e.RowIndex).Cells("IdColumn").Value, Integer)
		Dim form = New NCRDetailsForm(id)
		form.ShowDialog(Me)

	End Sub
End Class



