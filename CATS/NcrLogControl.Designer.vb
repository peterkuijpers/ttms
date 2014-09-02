<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NcrLogControl
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
		Me.TimestampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.userid = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.LogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'LogDataSet
		'
		Me.LogDataSet.DataSetName = "MySqlDataSet"
		Me.LogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'LogGridView
		'
		Me.LogGridView.AllowUserToAddRows = False
		Me.LogGridView.AllowUserToDeleteRows = False
		Me.LogGridView.AllowUserToResizeRows = False
		Me.LogGridView.AutoGenerateColumns = False
		Me.LogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.LogGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimestampDataGridViewTextBoxColumn, Me.userid, Me.DescriptionDataGridViewTextBoxColumn})
		Me.LogGridView.DataSource = Me.LogBindingSource
		Me.LogGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LogGridView.Location = New System.Drawing.Point(0, 0)
		Me.LogGridView.Name = "LogGridView"
		Me.LogGridView.ReadOnly = True
		Me.LogGridView.RowHeadersVisible = False
		Me.LogGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.LogGridView.Size = New System.Drawing.Size(796, 436)
		Me.LogGridView.TabIndex = 0
		'
		'LogBindingSource
		'
		Me.LogBindingSource.DataMember = "log"
		Me.LogBindingSource.DataSource = Me.LogDataSet
		'
		'TimestampDataGridViewTextBoxColumn
		'
		Me.TimestampDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.TimestampDataGridViewTextBoxColumn.DataPropertyName = "timestamp"
		Me.TimestampDataGridViewTextBoxColumn.HeaderText = "Date"
		Me.TimestampDataGridViewTextBoxColumn.MinimumWidth = 120
		Me.TimestampDataGridViewTextBoxColumn.Name = "TimestampDataGridViewTextBoxColumn"
		Me.TimestampDataGridViewTextBoxColumn.ReadOnly = True
		Me.TimestampDataGridViewTextBoxColumn.Width = 120
		'
		'userid
		'
		Me.userid.DataPropertyName = "userid"
		Me.userid.HeaderText = "User Id"
		Me.userid.Name = "userid"
		Me.userid.ReadOnly = True
		'
		'DescriptionDataGridViewTextBoxColumn
		'
		Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
		Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
		Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
		Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
		'
		'NcrLogControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.LogGridView)
		Me.Name = "NcrLogControl"
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
	Friend WithEvents NCRIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TimestampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents userid As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
