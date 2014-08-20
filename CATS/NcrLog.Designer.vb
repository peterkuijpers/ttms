<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NcrLog
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
		Me.LogDataSet = New BaseModel.MySqlDataSet()
		Me.LogGridView = New System.Windows.Forms.DataGridView()
		Me.LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NCRIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.LogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogDataSet
		'
		Me.LogDataSet.DataSetName = "TTMSDataSet"
		Me.LogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'LogGridView
		'
		Me.LogGridView.AllowUserToAddRows = False
		Me.LogGridView.AllowUserToDeleteRows = False
		Me.LogGridView.AllowUserToResizeRows = False
		Me.LogGridView.AutoGenerateColumns = False
		Me.LogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.LogGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TimestampDataGridViewTextBoxColumn, Me.UseridDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.NCRIdDataGridViewTextBoxColumn})
		Me.LogGridView.DataSource = Me.LogBindingSource
		Me.LogGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LogGridView.Location = New System.Drawing.Point(0, 0)
		Me.LogGridView.Name = "LogGridView"
		Me.LogGridView.ReadOnly = True
		Me.LogGridView.Size = New System.Drawing.Size(796, 436)
		Me.LogGridView.TabIndex = 0
		'
		'LogBindingSource
		'
		Me.LogBindingSource.DataMember = "Logs"
		Me.LogBindingSource.DataSource = Me.LogDataSet
		'
		'IdDataGridViewTextBoxColumn
		'
		Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
		Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
		Me.IdDataGridViewTextBoxColumn.MinimumWidth = 50
		Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
		Me.IdDataGridViewTextBoxColumn.ReadOnly = True
		Me.IdDataGridViewTextBoxColumn.Width = 50
		'
		'TimestampDataGridViewTextBoxColumn
		'
		Me.TimestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp"
		Me.TimestampDataGridViewTextBoxColumn.HeaderText = "timestamp"
		Me.TimestampDataGridViewTextBoxColumn.Name = "TimestampDataGridViewTextBoxColumn"
		Me.TimestampDataGridViewTextBoxColumn.ReadOnly = True
		'
		'UseridDataGridViewTextBoxColumn
		'
		Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "user_id"
		Me.UseridDataGridViewTextBoxColumn.HeaderText = "user_id"
		Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
		Me.UseridDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DescriptionDataGridViewTextBoxColumn
		'
		Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
		Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
		Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
		Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'NCRIdDataGridViewTextBoxColumn
		'
		Me.NCRIdDataGridViewTextBoxColumn.DataPropertyName = "NCR_Id"
		Me.NCRIdDataGridViewTextBoxColumn.HeaderText = "NCR_Id"
		Me.NCRIdDataGridViewTextBoxColumn.Name = "NCRIdDataGridViewTextBoxColumn"
		Me.NCRIdDataGridViewTextBoxColumn.ReadOnly = True
		Me.NCRIdDataGridViewTextBoxColumn.Visible = False
		'
		'NcrLog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.LogGridView)
		Me.Name = "NcrLog"
		Me.Size = New System.Drawing.Size(796, 436)
		CType(Me.LogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LogGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LogDataSet As BaseModel.MySqlDataSet
	Friend WithEvents LogGridView As System.Windows.Forms.DataGridView
	Friend WithEvents LogBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TimestampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents UseridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents NCRIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
