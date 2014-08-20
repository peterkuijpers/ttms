<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CcControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.CcPlanGridView = New System.Windows.Forms.DataGridView()
		Me.SeqCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ncrIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.action = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionByCmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.duedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.completiondate = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CcItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.NcrSubjectTb = New System.Windows.Forms.TextBox()
		Me.NcrIdTb = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.CcReviewGridView = New System.Windows.Forms.DataGridView()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		CType(Me.CcPlanGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CcItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.CcReviewGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.SuspendLayout()
		'
		'CcPlanGridView
		'
		Me.CcPlanGridView.AutoGenerateColumns = False
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CcPlanGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.CcPlanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.CcPlanGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeqCol, Me.ncrIdCol, Me.action, Me.ActionByCmb, Me.duedate, Me.IdDataGridViewTextBoxColumn, Me.completiondate})
		Me.CcPlanGridView.DataSource = Me.CcItemsBindingSource
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.CcPlanGridView.DefaultCellStyle = DataGridViewCellStyle2
		Me.CcPlanGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CcPlanGridView.Location = New System.Drawing.Point(3, 45)
		Me.CcPlanGridView.Name = "CcPlanGridView"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CcPlanGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
		Me.CcPlanGridView.Size = New System.Drawing.Size(1131, 195)
		Me.CcPlanGridView.TabIndex = 1
		'
		'SeqCol
		'
		Me.SeqCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.SeqCol.DataPropertyName = "seq"
		Me.SeqCol.HeaderText = "Seq"
		Me.SeqCol.MinimumWidth = 30
		Me.SeqCol.Name = "SeqCol"
		Me.SeqCol.Width = 30
		'
		'ncrIdCol
		'
		Me.ncrIdCol.DataPropertyName = "ncr_id"
		Me.ncrIdCol.HeaderText = "ncr_id"
		Me.ncrIdCol.Name = "ncrIdCol"
		Me.ncrIdCol.Visible = False
		'
		'action
		'
		Me.action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.action.DataPropertyName = "action"
		Me.action.HeaderText = "Corrective Action"
		Me.action.MinimumWidth = 100
		Me.action.Name = "action"
		'
		'ActionByCmb
		'
		Me.ActionByCmb.DataPropertyName = "actionby_id"
		Me.ActionByCmb.HeaderText = "CC By"
		Me.ActionByCmb.Name = "ActionByCmb"
		Me.ActionByCmb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ActionByCmb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'duedate
		'
		Me.duedate.DataPropertyName = "duedate"
		Me.duedate.HeaderText = "CC Due"
		Me.duedate.Name = "duedate"
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.Visible = False
		'
		'completiondate
		'
		Me.completiondate.DataPropertyName = "completiondate"
		Me.completiondate.HeaderText = "Completed Date"
		Me.completiondate.Name = "completiondate"
		'
		'CcItemsBindingSource
		'
		Me.CcItemsBindingSource.DataMember = "ccitem"
		Me.CcItemsBindingSource.DataSource = GetType(BaseModel.MySqlDataSet)
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.06779!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.93221!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1131, 36)
		Me.TableLayoutPanel2.TabIndex = 3
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 4
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.NcrSubjectTb, 3, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.NcrIdTb, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(454, 30)
		Me.TableLayoutPanel3.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(106, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(43, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Subject"
		'
		'NcrSubjectTb
		'
		Me.NcrSubjectTb.Dock = System.Windows.Forms.DockStyle.Fill
		Me.NcrSubjectTb.Enabled = False
		Me.NcrSubjectTb.Location = New System.Drawing.Point(155, 3)
		Me.NcrSubjectTb.Name = "NcrSubjectTb"
		Me.NcrSubjectTb.Size = New System.Drawing.Size(296, 20)
		Me.NcrSubjectTb.TabIndex = 3
		'
		'NcrIdTb
		'
		Me.NcrIdTb.Dock = System.Windows.Forms.DockStyle.Fill
		Me.NcrIdTb.Enabled = False
		Me.NcrIdTb.Location = New System.Drawing.Point(41, 3)
		Me.NcrIdTb.Name = "NcrIdTb"
		Me.NcrIdTb.Size = New System.Drawing.Size(54, 20)
		Me.NcrIdTb.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(5, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(30, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "NCR"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 511)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1137, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'CcReviewGridView
		'
		DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CcReviewGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		Me.CcReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.CcReviewGridView.DefaultCellStyle = DataGridViewCellStyle5
		Me.CcReviewGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CcReviewGridView.Location = New System.Drawing.Point(3, 286)
		Me.CcReviewGridView.Name = "CcReviewGridView"
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.CcReviewGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
		Me.CcReviewGridView.Size = New System.Drawing.Size(1131, 222)
		Me.CcReviewGridView.TabIndex = 2
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 1
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel2, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.CcPlanGridView, 0, 1)
		Me.TableLayoutPanel4.Controls.Add(Me.CcReviewGridView, 0, 3)
		Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel1, 0, 2)
		Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 4
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28395!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.71605!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(1137, 511)
		Me.TableLayoutPanel4.TabIndex = 2
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 246)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 1
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1131, 34)
		Me.TableLayoutPanel1.TabIndex = 4
		'
		'CcControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel4)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "CcControl"
		Me.Size = New System.Drawing.Size(1137, 533)
		CType(Me.CcPlanGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CcItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.CcReviewGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CcPlanGridView As System.Windows.Forms.DataGridView
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionbyidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DuedateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CompletionDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CCIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PassedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents FailedDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents ReviewerIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewCommentDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CompletionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CCIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PassedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents FailedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents ReviewerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewCommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CcItemsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents NcrSubjectTb As System.Windows.Forms.TextBox
	Friend WithEvents NcrIdTb As System.Windows.Forms.TextBox
	Friend WithEvents CcReviewGridView As System.Windows.Forms.DataGridView
	Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents SeqCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ncrIdCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents action As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionByCmb As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents duedate As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents completiondate As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
