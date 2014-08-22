<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatsListForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.NewNcrBtn = New System.Windows.Forms.Button()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.NcrDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.VersionStripLbl = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.UserStripLbl = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.LevelStripLbl = New System.Windows.Forms.ToolStripStatusLabel()
		Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RaisedByCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.AssignedToCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.DelegatedToCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.RaiseddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.StatusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CcidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.RcpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NcrDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.StatusStrip2.SuspendLayout()
		CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.573529!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.42647!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.84415!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.15585!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 77)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(167, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(506, 26)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "CATS - NON COMPLIANCE TRACKING SYSTEM"
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 3
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.11729!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88272!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.CloseBtn, 2, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.NewNcrBtn, 1, 0)
		Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(24, 45)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 1
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(792, 29)
		Me.TableLayoutPanel4.TabIndex = 1
		'
		'CloseBtn
		'
		Me.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.CloseBtn.Location = New System.Drawing.Point(717, 3)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(70, 23)
		Me.CloseBtn.TabIndex = 0
		Me.CloseBtn.Text = "Close"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'NewNcrBtn
		'
		Me.NewNcrBtn.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.NewNcrBtn.Location = New System.Drawing.Point(635, 3)
		Me.NewNcrBtn.Name = "NewNcrBtn"
		Me.NewNcrBtn.Size = New System.Drawing.Size(71, 23)
		Me.NewNcrBtn.TabIndex = 1
		Me.NewNcrBtn.Text = "New NCR"
		Me.NewNcrBtn.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue
		Me.TableLayoutPanel2.ColumnCount = 3
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 1, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 77)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(843, 423)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdColumn, Me.RaisedByCol, Me.AssignedToCol, Me.DelegatedToCol, Me.RaiseddateDataGridViewTextBoxColumn, Me.StatusCol, Me.CcidDataGridViewTextBoxColumn, Me.RcpidDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.NcrDataTableBindingSource
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(23, 3)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(797, 417)
		Me.DataGridView1.TabIndex = 0
		'
		'NcrDataTableBindingSource
		'
		Me.NcrDataTableBindingSource.AllowNew = False
		Me.NcrDataTableBindingSource.DataSource = GetType(BaseModel.MySqlDataSet.ncrDataTable)
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.4814!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5186!))
		Me.TableLayoutPanel3.Controls.Add(Me.StatusStrip1, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.StatusStrip2, 0, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 500)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(843, 25)
		Me.TableLayoutPanel3.TabIndex = 2
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionStripLbl})
		Me.StatusStrip1.Location = New System.Drawing.Point(762, 3)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(81, 22)
		Me.StatusStrip1.TabIndex = 0
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'VersionStripLbl
		'
		Me.VersionStripLbl.Name = "VersionStripLbl"
		Me.VersionStripLbl.Size = New System.Drawing.Size(55, 17)
		Me.VersionStripLbl.Text = "NCTS 1.1"
		'
		'StatusStrip2
		'
		Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.UserStripLbl, Me.ToolStripStatusLabel3, Me.LevelStripLbl})
		Me.StatusStrip2.Location = New System.Drawing.Point(0, 1)
		Me.StatusStrip2.Name = "StatusStrip2"
		Me.StatusStrip2.Size = New System.Drawing.Size(762, 24)
		Me.StatusStrip2.TabIndex = 1
		Me.StatusStrip2.Text = "StatusStrip2"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(30, 19)
		Me.ToolStripStatusLabel1.Text = "User"
		'
		'UserStripLbl
		'
		Me.UserStripLbl.BackColor = System.Drawing.Color.Khaki
		Me.UserStripLbl.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.UserStripLbl.Name = "UserStripLbl"
		Me.UserStripLbl.Size = New System.Drawing.Size(21, 19)
		Me.UserStripLbl.Text = "--"
		'
		'ToolStripStatusLabel3
		'
		Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
		Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(34, 19)
		Me.ToolStripStatusLabel3.Text = "Level"
		'
		'LevelStripLbl
		'
		Me.LevelStripLbl.BackColor = System.Drawing.Color.Khaki
		Me.LevelStripLbl.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.LevelStripLbl.Name = "LevelStripLbl"
		Me.LevelStripLbl.Size = New System.Drawing.Size(21, 19)
		Me.LevelStripLbl.Text = "--"
		'
		'UserBindingSource
		'
		Me.UserBindingSource.DataSource = GetType(BaseModel.MySqlDataSet.userDataTable)
		'
		'IdColumn
		'
		Me.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.IdColumn.DataPropertyName = "id"
		Me.IdColumn.HeaderText = "Id"
		Me.IdColumn.MinimumWidth = 30
		Me.IdColumn.Name = "IdColumn"
		Me.IdColumn.ReadOnly = True
		Me.IdColumn.Width = 30
		'
		'RaisedByCol
		'
		Me.RaisedByCol.DataPropertyName = "raisedby_id"
		Me.RaisedByCol.DataSource = Me.UserBindingSource
		Me.RaisedByCol.DisplayMember = "userid"
		Me.RaisedByCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.RaisedByCol.HeaderText = "Raised By"
		Me.RaisedByCol.Name = "RaisedByCol"
		Me.RaisedByCol.ReadOnly = True
		Me.RaisedByCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.RaisedByCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.RaisedByCol.ValueMember = "id"
		'
		'AssignedToCol
		'
		Me.AssignedToCol.DataPropertyName = "assignedto_id"
		Me.AssignedToCol.DataSource = Me.UserBindingSource
		Me.AssignedToCol.DisplayMember = "userid"
		Me.AssignedToCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.AssignedToCol.HeaderText = "Assigned To"
		Me.AssignedToCol.Name = "AssignedToCol"
		Me.AssignedToCol.ReadOnly = True
		Me.AssignedToCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.AssignedToCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.AssignedToCol.ValueMember = "id"
		'
		'DelegatedToCol
		'
		Me.DelegatedToCol.DataPropertyName = "delegatedto_id"
		Me.DelegatedToCol.DataSource = Me.UserBindingSource
		Me.DelegatedToCol.DisplayMember = "userid"
		Me.DelegatedToCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.DelegatedToCol.HeaderText = "Delegated To"
		Me.DelegatedToCol.Name = "DelegatedToCol"
		Me.DelegatedToCol.ReadOnly = True
		Me.DelegatedToCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DelegatedToCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DelegatedToCol.ValueMember = "id"
		'
		'RaiseddateDataGridViewTextBoxColumn
		'
		Me.RaiseddateDataGridViewTextBoxColumn.DataPropertyName = "raiseddate"
		DataGridViewCellStyle3.Format = "dd-MM-yyyy"
		Me.RaiseddateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
		Me.RaiseddateDataGridViewTextBoxColumn.HeaderText = "Date Raised"
		Me.RaiseddateDataGridViewTextBoxColumn.Name = "RaiseddateDataGridViewTextBoxColumn"
		Me.RaiseddateDataGridViewTextBoxColumn.ReadOnly = True
		'
		'StatusCol
		'
		Me.StatusCol.DataPropertyName = "status_id"
		Me.StatusCol.HeaderText = "Status"
		Me.StatusCol.Name = "StatusCol"
		Me.StatusCol.ReadOnly = True
		Me.StatusCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		'
		'CcidDataGridViewTextBoxColumn
		'
		Me.CcidDataGridViewTextBoxColumn.DataPropertyName = "cc_id"
		Me.CcidDataGridViewTextBoxColumn.HeaderText = "cc_id"
		Me.CcidDataGridViewTextBoxColumn.Name = "CcidDataGridViewTextBoxColumn"
		Me.CcidDataGridViewTextBoxColumn.ReadOnly = True
		Me.CcidDataGridViewTextBoxColumn.Visible = False
		'
		'RcpidDataGridViewTextBoxColumn
		'
		Me.RcpidDataGridViewTextBoxColumn.DataPropertyName = "rcp_id"
		Me.RcpidDataGridViewTextBoxColumn.HeaderText = "rcp_id"
		Me.RcpidDataGridViewTextBoxColumn.Name = "RcpidDataGridViewTextBoxColumn"
		Me.RcpidDataGridViewTextBoxColumn.ReadOnly = True
		Me.RcpidDataGridViewTextBoxColumn.Visible = False
		'
		'DescriptionDataGridViewTextBoxColumn
		'
		Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
		Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
		Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
		Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
		Me.DescriptionDataGridViewTextBoxColumn.Visible = False
		'
		'TitleDataGridViewTextBoxColumn
		'
		Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
		Me.TitleDataGridViewTextBoxColumn.HeaderText = "Subject"
		Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 100
		Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
		Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
		'
		'CatsListForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 525)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.TableLayoutPanel3)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Name = "CatsListForm"
		Me.Text = "CatsList"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NcrDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.StatusStrip2.ResumeLayout(False)
		Me.StatusStrip2.PerformLayout()
		CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents VersionStripLbl As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
	Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents UserStripLbl As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents LevelStripLbl As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
	Friend WithEvents NewNcrBtn As System.Windows.Forms.Button
	Friend WithEvents NcrDataTableBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents IdColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RaisedByCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents AssignedToCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents DelegatedToCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents RaiseddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents StatusCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CcidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RcpidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
