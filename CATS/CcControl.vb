Imports BaseModel

Public Class CcControl
	Dim users = DB.LoadUsers()
	Dim ncr As Ncr
	Dim seqCounter As Integer
	Dim ccItemTable = New MySqlDataSet.ccitemDataTable()
	Dim ccItemAdapt = New MySqlDataSetTableAdapters.ccitemTableAdapter()

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		'
		ActionByCmb.DataSource = users
		ActionByCmb.ValueMember = "id"
		ActionByCmb.DisplayMember = "userid"
		seqCounter = 1

	End Sub
	Public Sub Reload(ncr As Ncr)
		Me.ncr = ncr

		ccItemAdapt.Fill(ccItemTable, ncr.id)

		Dim bindingSource = New BindingSource()
		bindingSource.DataSource = ccItemTable
		CcPlanGridView.DataSource = bindingSource
		CcPlanGridView.Refresh()

		seqCounter = 1
		NcrIdTb.Text = ncr.id
		NcrSubjectTb.Text = ncr.title
	End Sub

	Private Sub CcPlanGridView_DefaultValuesNeeded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowEventArgs) Handles CcPlanGridView.DefaultValuesNeeded
		Dim row = e.Row
		row.Cells("SeqCol").Value = seqCounter
		row.Cells("ncrIdCol").Value = ncr.id
		seqCounter += 1
	End Sub


	'Private Sub CcPlanGridView_RowEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CcPlanGridView.RowEnter
	'	If (CcPlanGridView.Rows(e.RowIndex).IsNewRow) Then
	'   CcPlanGridView.Rows(e.RowIndex).Cells(0).Value = 1
	'	End If
	'End Sub

	Private Sub CcPlanGridView_RowValidated(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CcPlanGridView.RowValidated
		Dim rowindex As Integer
		rowindex = e.RowIndex
		ccItemAdapt.Update(ccItemTable)

	End Sub


	Private Sub CcPlanGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles CcPlanGridView.DataError
		MessageBox.Show("This row has an error")

	End Sub

	Private Sub CcPlanGridView_RowDirtyStateNeeded(sender As System.Object, e As System.Windows.Forms.QuestionEventArgs) Handles CcPlanGridView.RowDirtyStateNeeded
		MessageBox.Show("Dirty row")
	End Sub


	Private Sub NewItemBtn_Click(sender As System.Object, e As System.EventArgs)

	End Sub

	Private Sub CcPlanGridView_UserDeletingRow(sender As System.Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles CcPlanGridView.UserDeletingRow
		Dim result As Integer = MessageBox.Show("Are you sure you want to delete this row?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
		If (result <> DialogResult.OK) Then
			e.Cancel = True
		End If

	End Sub


End Class
