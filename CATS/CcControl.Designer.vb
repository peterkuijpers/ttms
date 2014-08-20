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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.TtmsDataSet1 = New TTMS.TTMSDataSet()
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionbyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompletionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CCIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PassedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.FailedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.ReviewerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReviewDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReviewCommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ActionbyidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DuedateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CompletionDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CCIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PassedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.FailedDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.ReviewerIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReviewDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReviewCommentDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.DataGridView2, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(962, 389)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 389)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(962, 22)
		Me.StatusStrip1.TabIndex = 1
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(956, 34)
		Me.FlowLayoutPanel1.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(878, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ActionDataGridViewTextBoxColumn, Me.ActionbyidDataGridViewTextBoxColumn, Me.DuedateDataGridViewTextBoxColumn, Me.CompletionDateDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CCIdDataGridViewTextBoxColumn, Me.PassedDataGridViewCheckBoxColumn, Me.FailedDataGridViewCheckBoxColumn, Me.ReviewerIdDataGridViewTextBoxColumn, Me.ReviewDateDataGridViewTextBoxColumn, Me.ReviewCommentDataGridViewTextBoxColumn})
		Me.DataGridView1.DataMember = "CC_Item"
		Me.DataGridView1.DataSource = Me.TtmsDataSet1
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(3, 43)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(956, 190)
		Me.DataGridView1.TabIndex = 1
		'
		'DataGridView2
		'
		Me.DataGridView2.AutoGenerateColumns = False
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ActionDataGridViewTextBoxColumn1, Me.ActionbyidDataGridViewTextBoxColumn1, Me.DuedateDataGridViewTextBoxColumn1, Me.CompletionDateDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn1, Me.CCIdDataGridViewTextBoxColumn1, Me.PassedDataGridViewCheckBoxColumn1, Me.FailedDataGridViewCheckBoxColumn1, Me.ReviewerIdDataGridViewTextBoxColumn1, Me.ReviewDateDataGridViewTextBoxColumn1, Me.ReviewCommentDataGridViewTextBoxColumn1})
		Me.DataGridView2.DataMember = "CC_Item"
		Me.DataGridView2.DataSource = Me.TtmsDataSet1
		Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView2.Location = New System.Drawing.Point(3, 239)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(956, 147)
		Me.DataGridView2.TabIndex = 2
		'
		'TtmsDataSet1
		'
		Me.TtmsDataSet1.DataSetName = "TTMSDataSet"
		Me.TtmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ActionDataGridViewTextBoxColumn
		'
		Me.ActionDataGridViewTextBoxColumn.DataPropertyName = "Action"
		Me.ActionDataGridViewTextBoxColumn.HeaderText = "Action"
		Me.ActionDataGridViewTextBoxColumn.Name = "ActionDataGridViewTextBoxColumn"
		'
		'ActionbyidDataGridViewTextBoxColumn
		'
		Me.ActionbyidDataGridViewTextBoxColumn.DataPropertyName = "Action_by_id"
		Me.ActionbyidDataGridViewTextBoxColumn.HeaderText = "Action_by_id"
		Me.ActionbyidDataGridViewTextBoxColumn.Name = "ActionbyidDataGridViewTextBoxColumn"
		'
		'DuedateDataGridViewTextBoxColumn
		'
		Me.DuedateDataGridViewTextBoxColumn.DataPropertyName = "due_date"
		Me.DuedateDataGridViewTextBoxColumn.HeaderText = "due_date"
		Me.DuedateDataGridViewTextBoxColumn.Name = "DuedateDataGridViewTextBoxColumn"
		'
		'CompletionDateDataGridViewTextBoxColumn
		'
		Me.CompletionDateDataGridViewTextBoxColumn.DataPropertyName = "completion_Date"
		Me.CompletionDateDataGridViewTextBoxColumn.HeaderText = "completion_Date"
		Me.CompletionDateDataGridViewTextBoxColumn.Name = "CompletionDateDataGridViewTextBoxColumn"
		'
		'StatusDataGridViewTextBoxColumn
		'
		Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
		Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
		Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
		'
		'CCIdDataGridViewTextBoxColumn
		'
		Me.CCIdDataGridViewTextBoxColumn.DataPropertyName = "CC_Id"
		Me.CCIdDataGridViewTextBoxColumn.HeaderText = "CC_Id"
		Me.CCIdDataGridViewTextBoxColumn.Name = "CCIdDataGridViewTextBoxColumn"
		'
		'PassedDataGridViewCheckBoxColumn
		'
		Me.PassedDataGridViewCheckBoxColumn.DataPropertyName = "Passed"
		Me.PassedDataGridViewCheckBoxColumn.HeaderText = "Passed"
		Me.PassedDataGridViewCheckBoxColumn.Name = "PassedDataGridViewCheckBoxColumn"
		'
		'FailedDataGridViewCheckBoxColumn
		'
		Me.FailedDataGridViewCheckBoxColumn.DataPropertyName = "Failed"
		Me.FailedDataGridViewCheckBoxColumn.HeaderText = "Failed"
		Me.FailedDataGridViewCheckBoxColumn.Name = "FailedDataGridViewCheckBoxColumn"
		'
		'ReviewerIdDataGridViewTextBoxColumn
		'
		Me.ReviewerIdDataGridViewTextBoxColumn.DataPropertyName = "Reviewer_Id"
		Me.ReviewerIdDataGridViewTextBoxColumn.HeaderText = "Reviewer_Id"
		Me.ReviewerIdDataGridViewTextBoxColumn.Name = "ReviewerIdDataGridViewTextBoxColumn"
		'
		'ReviewDateDataGridViewTextBoxColumn
		'
		Me.ReviewDateDataGridViewTextBoxColumn.DataPropertyName = "Review_Date"
		Me.ReviewDateDataGridViewTextBoxColumn.HeaderText = "Review_Date"
		Me.ReviewDateDataGridViewTextBoxColumn.Name = "ReviewDateDataGridViewTextBoxColumn"
		'
		'ReviewCommentDataGridViewTextBoxColumn
		'
		Me.ReviewCommentDataGridViewTextBoxColumn.DataPropertyName = "Review_Comment"
		Me.ReviewCommentDataGridViewTextBoxColumn.HeaderText = "Review_Comment"
		Me.ReviewCommentDataGridViewTextBoxColumn.Name = "ReviewCommentDataGridViewTextBoxColumn"
		'
		'IdDataGridViewTextBoxColumn1
		'
		Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
		Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
		Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
		Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
		'
		'ActionDataGridViewTextBoxColumn1
		'
		Me.ActionDataGridViewTextBoxColumn1.DataPropertyName = "Action"
		Me.ActionDataGridViewTextBoxColumn1.HeaderText = "Action"
		Me.ActionDataGridViewTextBoxColumn1.Name = "ActionDataGridViewTextBoxColumn1"
		Me.ActionDataGridViewTextBoxColumn1.Visible = False
		'
		'ActionbyidDataGridViewTextBoxColumn1
		'
		Me.ActionbyidDataGridViewTextBoxColumn1.DataPropertyName = "Action_by_id"
		Me.ActionbyidDataGridViewTextBoxColumn1.HeaderText = "Action_by_id"
		Me.ActionbyidDataGridViewTextBoxColumn1.Name = "ActionbyidDataGridViewTextBoxColumn1"
		Me.ActionbyidDataGridViewTextBoxColumn1.Visible = False
		'
		'DuedateDataGridViewTextBoxColumn1
		'
		Me.DuedateDataGridViewTextBoxColumn1.DataPropertyName = "due_date"
		Me.DuedateDataGridViewTextBoxColumn1.HeaderText = "due_date"
		Me.DuedateDataGridViewTextBoxColumn1.Name = "DuedateDataGridViewTextBoxColumn1"
		Me.DuedateDataGridViewTextBoxColumn1.Visible = False
		'
		'CompletionDateDataGridViewTextBoxColumn1
		'
		Me.CompletionDateDataGridViewTextBoxColumn1.DataPropertyName = "completion_Date"
		Me.CompletionDateDataGridViewTextBoxColumn1.HeaderText = "completion_Date"
		Me.CompletionDateDataGridViewTextBoxColumn1.Name = "CompletionDateDataGridViewTextBoxColumn1"
		Me.CompletionDateDataGridViewTextBoxColumn1.Visible = False
		'
		'StatusDataGridViewTextBoxColumn1
		'
		Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "status"
		Me.StatusDataGridViewTextBoxColumn1.HeaderText = "status"
		Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
		Me.StatusDataGridViewTextBoxColumn1.Visible = False
		'
		'CCIdDataGridViewTextBoxColumn1
		'
		Me.CCIdDataGridViewTextBoxColumn1.DataPropertyName = "CC_Id"
		Me.CCIdDataGridViewTextBoxColumn1.HeaderText = "CC_Id"
		Me.CCIdDataGridViewTextBoxColumn1.Name = "CCIdDataGridViewTextBoxColumn1"
		Me.CCIdDataGridViewTextBoxColumn1.Visible = False
		'
		'PassedDataGridViewCheckBoxColumn1
		'
		Me.PassedDataGridViewCheckBoxColumn1.DataPropertyName = "Passed"
		Me.PassedDataGridViewCheckBoxColumn1.HeaderText = "Passed"
		Me.PassedDataGridViewCheckBoxColumn1.Name = "PassedDataGridViewCheckBoxColumn1"
		'
		'FailedDataGridViewCheckBoxColumn1
		'
		Me.FailedDataGridViewCheckBoxColumn1.DataPropertyName = "Failed"
		Me.FailedDataGridViewCheckBoxColumn1.HeaderText = "Failed"
		Me.FailedDataGridViewCheckBoxColumn1.Name = "FailedDataGridViewCheckBoxColumn1"
		'
		'ReviewerIdDataGridViewTextBoxColumn1
		'
		Me.ReviewerIdDataGridViewTextBoxColumn1.DataPropertyName = "Reviewer_Id"
		Me.ReviewerIdDataGridViewTextBoxColumn1.HeaderText = "Reviewer_Id"
		Me.ReviewerIdDataGridViewTextBoxColumn1.Name = "ReviewerIdDataGridViewTextBoxColumn1"
		'
		'ReviewDateDataGridViewTextBoxColumn1
		'
		Me.ReviewDateDataGridViewTextBoxColumn1.DataPropertyName = "Review_Date"
		Me.ReviewDateDataGridViewTextBoxColumn1.HeaderText = "Review_Date"
		Me.ReviewDateDataGridViewTextBoxColumn1.Name = "ReviewDateDataGridViewTextBoxColumn1"
		'
		'ReviewCommentDataGridViewTextBoxColumn1
		'
		Me.ReviewCommentDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.ReviewCommentDataGridViewTextBoxColumn1.DataPropertyName = "Review_Comment"
		Me.ReviewCommentDataGridViewTextBoxColumn1.HeaderText = "Review_Comment"
		Me.ReviewCommentDataGridViewTextBoxColumn1.Name = "ReviewCommentDataGridViewTextBoxColumn1"
		'
		'CcControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "CcControl"
		Me.Size = New System.Drawing.Size(962, 411)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
	Friend WithEvents TtmsDataSet1 As TTMS.TTMSDataSet
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

End Class
