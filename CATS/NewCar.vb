﻿
''' <summary>
''' Enter details for new Customer Assistance Request (CAR) or view/modify details for existing CAR
''' </summary>
''' <remarks></remarks>
Public Class NewCARForm

	Private isCreateNewCAR As Boolean = False
	Private theUser As TTMS.User = Nothing
	Private raisedToUser As TTMS.User = Nothing
	Private raisedDate As DateTime = Nothing
	Private CarId As Integer? = Nothing

	Public Property User As TTMS.User
		Get
			Return theUser
		End Get
		Set(value As TTMS.User)
			Me.theUser = value
		End Set
	End Property

	''' <summary>
	''' Get the property that indicates for the form that a new CAR is needed (TRUE) or 
	''' viewing an existing CAR (FALSE)
	''' </summary>
	''' <value></value>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Property CreateNewCAR As Boolean
		Get
			Return isCreateNewCAR
		End Get
		Set(value As Boolean)
			Me.isCreateNewCAR = value
		End Set

	End Property

	''' <summary>
	''' Set the CAR Id property for showing the CAR details
	''' </summary>
	''' <value></value>
	''' <remarks></remarks>
	Public WriteOnly Property CarIdent As Integer
		Set(value As Integer)
			Me.CarId = value
		End Set
	End Property

	Private Sub CARDetailsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
		Me.NCR_StatusTableAdapter.Fill(Me.DataSet1.NCR_Status1)
		Me.DataSet1.Users.Clear()
		Me.UsersTableAdapter = New TTMS.TTMSDataSetTableAdapters.UsersTableAdapter()
		Me.UsersTableAdapter.Fill(Me.TtmsDataSet1.Users)
		If (isCreateNewCAR) Then
			ShowCreateForm()
		Else
			ShowViewForm()
		End If
	End Sub

	Private Sub ShowCreateForm()
		HeaderLabel.Text = "New CAR Details"
		RaisedByCombo.Enabled = False
		'set raised_to is nothing and disable
		RaisedToTb = Nothing
		RaisedDatePicker.Value = DateTime.Now
		' set the status to New NCR 
		StatusTb.Text = Nothing
		Me.AcceptButton = CreateBtn
		OkBtn.Visible = False
		CreateBtn.Visible = True

	End Sub

	Private Sub ShowViewForm()
		HeaderLabel.Text = "View CAR Details"

		Dim NcrTable As New TTMS.TTMSDataSet.NCRsDataTable
		Dim adapt As New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter
		If (IsNothing(CarId)) Then
			Return
		End If
		NcrTable.Clear()
		adapt.FillBy(NcrTable, CarId)

		If (NcrTable.Rows.Count <> 1) Then
			Return
		End If

		Dim ncrRow As DataRow = NcrTable.Rows(0)
		Dim editNcr As TTMS.NCR = New TTMS.NCR()
		editNcr.Id = CType(ncrRow.Item("Id"), Integer)
		editNcr.raised_by_id = CType(ncrRow.Item("raised_by_id"), Integer)
		editNcr.raised_date = CType(ncrRow.Item("raised_date"), DateTime)
		If Not IsDBNull(ncrRow.Item("raised_to_id")) Then
			editNcr.raised_to_id = CType(ncrRow.Item("raised_to_id"), Integer)
		Else
			editNcr.raised_to_id = Nothing
		End If
		editNcr.status_id = CType(ncrRow.Item("status_id"), Integer)
		If Not IsDBNull(ncrRow.Item("description")) Then
			editNcr.Description = CType(ncrRow.Item("description"), String)
		Else
			editNcr.Description = ""
		End If

		RaisedByCombo.SelectedValue = editNcr.raised_by_id
		RaisedDatePicker.Value = editNcr.raised_date
		RaisedToTb.Text = editNcr.Id
		If Not IsNothing(editNcr.raised_to_id) Then
			RaisedToTb.Text = editNcr.raised_to_id
		End If
		DescriptionTB.Text = editNcr.Description

		StatusTb.Text = editNcr.status_id
	End Sub


	''' <summary>
	''' Create new car ticket
	''' </summary>
	''' <param name="sender"></param>
	''' <param name="e"></param>
	''' <remarks></remarks>
	Private Sub CreateBtn_Click(sender As System.Object, e As System.EventArgs) Handles CreateBtn.Click
		raisedDate = Me.RaisedDatePicker.Value
		'raised-to id
		'		Dim raisedToId As Integer? = Me.RaisedToCombo.SelectedValue
		'status id
		'		Dim statusId As Integer = StatusCombo.SelectedValue
		DialogResult = Windows.Forms.DialogResult.OK
		Dim adapt As New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter
		Dim description As String = DescriptionTB.Text
		Dim title As String = TitleTb.Text
		''' TODO 
		Dim newId = adapt.InsertQuery(theUser.Id, DateTime.Now, Nothing, Nothing, Nothing, description, title)

		' add entry to log file
		Dim logAdapt As New TTMS.TTMSDataSetTableAdapters.LogsTableAdapter()
		logAdapt.InsertQuery(DateTime.Now, "New NCR created", newId, User.Id)
		MessageBox.Show(Me, "New CAR Created")
		Me.Close()
	End Sub


End Class