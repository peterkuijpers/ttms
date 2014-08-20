﻿Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports TTMS

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
		UserStatStripLbl.Text = user.Firstname & " " & user.Surname
		LevelStatStripLbl.Text = user.Level.full_description
	End Sub

	''' <summary>
	''' Close this form
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub QuitBtn_Click(sender As System.Object, e As System.EventArgs)
		Me.Close()
	End Sub

	''' <summary>
	''' Start creating a new CAR
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub NewCarBtn_Click(sender As System.Object, e As System.EventArgs)
		Dim form As New NewCARForm()
		form.CreateNewCAR = True
		form.User = catsUser

		Dim result As DialogResult = form.ShowDialog(Me)
		If result = DialogResult.OK Then
			Reload()
			DataGridView1.Refresh()
		End If

	End Sub

	Private Sub CatsForm_Load(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs)
		Me.Close()
	End Sub

	Private Sub Reload()
		'TODO: This line of code loads data into the 'DataSet1.NCR_Status' table. You can move, or remove it, as needed.
		'Me.TtmsDataSet1.NCR_Status.Clear()
		TtmsDataSet1.NCR_Status1.Clear()
		NCR_StatusTableAdapter.Fill(TtmsDataSet1.NCR_Status1)
		'Me.NCR_StatusTableAdapter.Fill(Me.TtmsDataSet1.NCR_Status)
		'TODO: This line of code loads data into the 'DataSet1.Users' table. You can move, or remove it, as needed.
		Me.UsersTableAdapter.Fill(Me.TtmsDataSet1.Users)
		'TODO: This line of code loads data into the 'DataSet1.NCRs' table. You can move, or remove it, as needed.

		Me.NCRsTableAdapter.Fill(Me.TtmsDataSet1.NCRs)

	End Sub

	''' <summary>
	''' Show details when any cell is double clicked
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
		Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
		Dim selectedCarId As Integer = row.Cells("IdColumn").Value

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

	Private Sub NewCarBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles NewCarBtn.Click
		Dim form As New NewCARForm()
		form.CreateNewCAR = True
		form.User = catsUser

		Dim result As DialogResult = form.ShowDialog(Me)
		If result = DialogResult.OK Then
			Reload()
			DataGridView1.Refresh()
		End If

	End Sub

	Private Sub QuitBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles QuitBtn.Click
		Me.Close()
	End Sub

	Private Sub CatsForm_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		DataGridView1.ReadOnly = True
		Reload()
	End Sub

	Private Sub UserBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles UserBindingSource.CurrentChanged

	End Sub
End Class

