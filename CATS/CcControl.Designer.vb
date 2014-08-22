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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.CcPlanGridView = New System.Windows.Forms.DataGridView()
		Me.CcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.NcrIdTb = New System.Windows.Forms.TextBox()
		Me.NcrSubjectTb = New System.Windows.Forms.TextBox()
		Me.seqCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IdTb = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionByCmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PassedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FailedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ncrIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.CcPlanGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.CcPlanGridView, 1, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 40)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(792, 349)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'CloseBtn
		'
		Me.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.CloseBtn.Location = New System.Drawing.Point(721, 8)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(68, 23)
		Me.CloseBtn.TabIndex = 0
		Me.CloseBtn.Text = "CloseBtn"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'CcPlanGridView
		'
		Me.CcPlanGridView.AutoGenerateColumns = False
		Me.CcPlanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.CcPlanGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seqCol, Me.IdTb, Me.DataGridViewTextBoxColumn2, Me.ActionByCmb, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.PassedDataGridViewTextBoxColumn, Me.FailedDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.ncrIdCol})
		Me.CcPlanGridView.DataSource = Me.CcBindingSource
		Me.CcPlanGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CcPlanGridView.Location = New System.Drawing.Point(13, 14)
		Me.CcPlanGridView.Name = "CcPlanGridView"
		Me.CcPlanGridView.RowHeadersVisible = False
		Me.CcPlanGridView.Size = New System.Drawing.Size(766, 179)
		Me.CcPlanGridView.TabIndex = 1
		'
		'CcBindingSource
		'
		Me.CcBindingSource.DataSource = GetType(BaseModel.MySqlDataSet.ccitemDataTable)
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(792, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.70271!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.297297!))
		Me.TableLayoutPanel2.Controls.Add(Me.CloseBtn, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(792, 40)
		Me.TableLayoutPanel2.TabIndex = 2
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 4
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.NcrSubjectTb, 3, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.NcrIdTb, 1, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(712, 34)
		Me.TableLayoutPanel3.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(17, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(30, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Ncr"
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(167, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Subject"
		'
		'NcrIdTb
		'
		Me.NcrIdTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.NcrIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NcrIdTb.Location = New System.Drawing.Point(53, 5)
		Me.NcrIdTb.Name = "NcrIdTb"
		Me.NcrIdTb.ReadOnly = True
		Me.NcrIdTb.Size = New System.Drawing.Size(94, 23)
		Me.NcrIdTb.TabIndex = 2
		'
		'NcrSubjectTb
		'
		Me.NcrSubjectTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.NcrSubjectTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NcrSubjectTb.Location = New System.Drawing.Point(228, 5)
		Me.NcrSubjectTb.Name = "NcrSubjectTb"
		Me.NcrSubjectTb.ReadOnly = True
		Me.NcrSubjectTb.Size = New System.Drawing.Size(481, 23)
		Me.NcrSubjectTb.TabIndex = 3
		'
		'seqCol
		'
		Me.seqCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.seqCol.DataPropertyName = "seq"
		Me.seqCol.HeaderText = "Seq"
		Me.seqCol.MinimumWidth = 30
		Me.seqCol.Name = "seqCol"
		Me.seqCol.Width = 30
		'
		'IdTb
		'
		Me.IdTb.DataPropertyName = "id"
		Me.IdTb.HeaderText = "id"
		Me.IdTb.Name = "IdTb"
		Me.IdTb.Visible = False
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "action"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Action"
		Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		'
		'ActionByCmb
		'
		Me.ActionByCmb.DataPropertyName = "actionby_id"
		Me.ActionByCmb.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
		Me.ActionByCmb.HeaderText = "Action By"
		Me.ActionByCmb.Name = "ActionByCmb"
		Me.ActionByCmb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ActionByCmb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "duedate"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Due Date"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "completiondate"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Compl Date"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "status"
		Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		'
		'PassedDataGridViewTextBoxColumn
		'
		Me.PassedDataGridViewTextBoxColumn.DataPropertyName = "passed"
		Me.PassedDataGridViewTextBoxColumn.HeaderText = "passed"
		Me.PassedDataGridViewTextBoxColumn.Name = "PassedDataGridViewTextBoxColumn"
		Me.PassedDataGridViewTextBoxColumn.Visible = False
		'
		'FailedDataGridViewTextBoxColumn
		'
		Me.FailedDataGridViewTextBoxColumn.DataPropertyName = "failed"
		Me.FailedDataGridViewTextBoxColumn.HeaderText = "failed"
		Me.FailedDataGridViewTextBoxColumn.Name = "FailedDataGridViewTextBoxColumn"
		Me.FailedDataGridViewTextBoxColumn.Visible = False
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "reviewer_id"
		Me.DataGridViewTextBoxColumn7.HeaderText = "Reviewer"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		Me.DataGridViewTextBoxColumn7.Visible = False
		'
		'DataGridViewTextBoxColumn8
		'
		Me.DataGridViewTextBoxColumn8.DataPropertyName = "reviewdate"
		Me.DataGridViewTextBoxColumn8.HeaderText = "Review Date"
		Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
		Me.DataGridViewTextBoxColumn8.Visible = False
		'
		'DataGridViewTextBoxColumn9
		'
		Me.DataGridViewTextBoxColumn9.DataPropertyName = "reviewcomment"
		Me.DataGridViewTextBoxColumn9.HeaderText = "reviewcomment"
		Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
		Me.DataGridViewTextBoxColumn9.Visible = False
		'
		'ncrIdCol
		'
		Me.ncrIdCol.DataPropertyName = "ncr_id"
		Me.ncrIdCol.HeaderText = "ncr_id"
		Me.ncrIdCol.Name = "ncrIdCol"
		Me.ncrIdCol.Visible = False
		'
		'CcControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "CcControl"
		Me.Size = New System.Drawing.Size(792, 411)
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.CcPlanGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
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
	Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionbyidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DuedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CompletionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CCIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PassedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents FailedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents ReviewerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewCommentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CcBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents NcrSubjectTb As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents NcrIdTb As System.Windows.Forms.TextBox
	Friend WithEvents seqCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents IdTb As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ActionByCmb As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PassedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents FailedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ncrIdCol As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
