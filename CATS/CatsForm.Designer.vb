﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatsForm
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
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.UserStatStripLbl = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.LevelStatStripLbl = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.QuitBtn = New System.Windows.Forms.Button()
		Me.NewCarBtn = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.IdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TtmsDataSet1 = New TTMS.TTMSDataSet()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.NCRsTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter()
		Me.NCR_StatusTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCR_Status1TableAdapter()
		Me.UsersTableAdapter = New TTMS.TTMSDataSetTableAdapters.UsersTableAdapter()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.StatusStrip1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.StatusStrip2.SuspendLayout()
		Me.SuspendLayout()
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.UserStatStripLbl, Me.ToolStripStatusLabel2, Me.LevelStatStripLbl})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(749, 25)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(30, 20)
		Me.ToolStripStatusLabel1.Text = "User"
		'
		'UserStatStripLbl
		'
		Me.UserStatStripLbl.BackColor = System.Drawing.Color.Khaki
		Me.UserStatStripLbl.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.UserStatStripLbl.Name = "UserStatStripLbl"
		Me.UserStatStripLbl.Size = New System.Drawing.Size(21, 20)
		Me.UserStatStripLbl.Text = "--"
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 20)
		Me.ToolStripStatusLabel2.Text = "Level"
		'
		'LevelStatStripLbl
		'
		Me.LevelStatStripLbl.BackColor = System.Drawing.Color.Khaki
		Me.LevelStatStripLbl.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
				  Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me.LevelStatStripLbl.Name = "LevelStatStripLbl"
		Me.LevelStatStripLbl.Size = New System.Drawing.Size(21, 20)
		Me.LevelStatStripLbl.Text = "--"
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
		Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(869, 101)
		Me.Panel1.TabIndex = 3
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(867, 99)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(49, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(715, 50)
		Me.Label5.TabIndex = 1
		Me.Label5.Text = "CATS - NON COMPLIANCE TRACKING SYSTEM"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FlowLayoutPanel1
		'
		Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel1, 2)
		Me.FlowLayoutPanel1.Controls.Add(Me.QuitBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.NewCarBtn)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(49, 53)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(815, 44)
		Me.FlowLayoutPanel1.TabIndex = 3
		'
		'QuitBtn
		'
		Me.QuitBtn.Location = New System.Drawing.Point(727, 8)
		Me.QuitBtn.Name = "QuitBtn"
		Me.QuitBtn.Size = New System.Drawing.Size(75, 25)
		Me.QuitBtn.TabIndex = 0
		Me.QuitBtn.Text = "Close"
		Me.QuitBtn.UseVisualStyleBackColor = True
		'
		'NewCarBtn
		'
		Me.NewCarBtn.Location = New System.Drawing.Point(646, 8)
		Me.NewCarBtn.Name = "NewCarBtn"
		Me.NewCarBtn.Size = New System.Drawing.Size(75, 25)
		Me.NewCarBtn.TabIndex = 2
		Me.NewCarBtn.Text = "New NCR"
		Me.NewCarBtn.UseVisualStyleBackColor = True
		'
		'Panel2
		'
		Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel2.Location = New System.Drawing.Point(0, 101)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
		Me.Panel2.Size = New System.Drawing.Size(869, 379)
		Me.Panel2.TabIndex = 4
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 859.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 0, 0)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 5)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 1
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(859, 369)
		Me.TableLayoutPanel3.TabIndex = 0
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.Khaki
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.TitleDataGridViewTextBoxColumn})
		Me.DataGridView1.DataMember = "NCRs"
		Me.DataGridView1.DataSource = Me.TtmsDataSet1
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersWidth = 20
		Me.DataGridView1.Size = New System.Drawing.Size(853, 363)
		Me.DataGridView1.TabIndex = 0
		'
		'IdColumn
		'
		Me.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.IdColumn.DataPropertyName = "Id"
		Me.IdColumn.HeaderText = "Id"
		Me.IdColumn.MinimumWidth = 50
		Me.IdColumn.Name = "IdColumn"
		Me.IdColumn.ReadOnly = True
		Me.IdColumn.Width = 50
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "raised_by_id"
		Me.DataGridViewTextBoxColumn1.DataSource = Me.UserBindingSource
		Me.DataGridViewTextBoxColumn1.DisplayMember = "FullName"
		Me.DataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.DataGridViewTextBoxColumn1.HeaderText = "Raised By"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DataGridViewTextBoxColumn1.ValueMember = "Id"
		'
		'UserBindingSource
		'
		Me.UserBindingSource.DataMember = "Users"
		Me.UserBindingSource.DataSource = Me.TtmsDataSet1
		Me.UserBindingSource.Sort = "surname"
		'
		'TtmsDataSet1
		'
		Me.TtmsDataSet1.DataSetName = "TTMSDataSet"
		Me.TtmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "raised_date"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Raised Date"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "raised_to_id"
		Me.DataGridViewTextBoxColumn3.DataSource = Me.UserBindingSource
		Me.DataGridViewTextBoxColumn3.DisplayMember = "FullName"
		Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.DataGridViewTextBoxColumn3.HeaderText = "Raised To"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DataGridViewTextBoxColumn3.ValueMember = "Id"
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "status_id"
		Me.DataGridViewTextBoxColumn4.DataSource = Me.StatusBindingSource
		Me.DataGridViewTextBoxColumn4.DisplayMember = "short_description"
		Me.DataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		Me.DataGridViewTextBoxColumn4.ReadOnly = True
		Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.DataGridViewTextBoxColumn4.ValueMember = "id"
		'
		'StatusBindingSource
		'
		Me.StatusBindingSource.DataMember = "NCR_Status1"
		Me.StatusBindingSource.DataSource = Me.TtmsDataSet1
		'
		'TitleDataGridViewTextBoxColumn
		'
		Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
		Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
		Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
		Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
		'
		'Label7
		'
		Me.Label7.Location = New System.Drawing.Point(0, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(100, 23)
		Me.Label7.TabIndex = 0
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
		'
		'NCRsTableAdapter
		'
		Me.NCRsTableAdapter.ClearBeforeFill = True
		'
		'NCR_StatusTableAdapter
		'
		Me.NCR_StatusTableAdapter.ClearBeforeFill = True
		'
		'UsersTableAdapter
		'
		Me.UsersTableAdapter.ClearBeforeFill = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.StatusStrip1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.StatusStrip2, 1, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 480)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(869, 25)
		Me.TableLayoutPanel2.TabIndex = 5
		'
		'StatusStrip2
		'
		Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3})
		Me.StatusStrip2.Location = New System.Drawing.Point(749, 0)
		Me.StatusStrip2.Name = "StatusStrip2"
		Me.StatusStrip2.Size = New System.Drawing.Size(120, 25)
		Me.StatusStrip2.SizingGrip = False
		Me.StatusStrip2.TabIndex = 3
		Me.StatusStrip2.Text = "StatusStrip2"
		'
		'ToolStripStatusLabel3
		'
		Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
		Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(97, 20)
		Me.ToolStripStatusLabel3.Text = "NCTS Version 1.1"
		'
		'CatsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(869, 505)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "CatsForm"
		Me.Text = "CATS Form"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.Panel2.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.StatusStrip2.ResumeLayout(False)
		Me.StatusStrip2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents QuitBtn As System.Windows.Forms.Button
	Friend WithEvents NewCarBtn As System.Windows.Forms.Button
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
	Friend WithEvents NCRsBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents NCRsTableAdapter As TTMS.TTMSDataSetTableAdapters.NCRsTableAdapter
	Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents UsersTableAdapter As TTMS.TTMSDataSetTableAdapters.UsersTableAdapter
	Friend WithEvents UsersBindingSource1 As System.Windows.Forms.BindingSource
	Friend WithEvents NCRStatusBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents IdCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RaisedbyidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents RaiseddateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RaisedtoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents StatusidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents CCidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents RCPidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents TtmsDataSet1 As TTMS.TTMSDataSet
	Friend WithEvents UserBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents StatusBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents IdColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents NCR_StatusTableAdapter As TTMS.TTMSDataSetTableAdapters.NCR_Status1TableAdapter
	Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents UserStatStripLbl As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents LevelStatStripLbl As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
	Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
