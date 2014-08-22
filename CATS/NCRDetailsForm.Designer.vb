<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NCRDetailsForm
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
		Me.NCRTabControl = New System.Windows.Forms.TabControl()
		Me.DetailsTab = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.DescriptionTB = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.RaisedDatePicker = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.IdTb = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TitleTb = New System.Windows.Forms.TextBox()
		Me.RaisedByTb = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.StatusControl2 = New CATS.StatusControl()
		Me.AssignedToTb = New System.Windows.Forms.TextBox()
		Me.DelegatedToTb = New System.Windows.Forms.TextBox()
		Me.CurrentStatusTb = New System.Windows.Forms.TextBox()
		Me.CcTab = New System.Windows.Forms.TabPage()
		Me.CcControl2 = New CATS.CcControl()
		Me.RCP_Tab = New System.Windows.Forms.TabPage()
		Me.PA_Tab = New System.Windows.Forms.TabPage()
		Me.FollowupTab = New System.Windows.Forms.TabPage()
		Me.AttachTab = New System.Windows.Forms.TabPage()
		Me.StatusTab = New System.Windows.Forms.TabPage()
		Me.StatusSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.MySqlDataSet1 = New BaseModel.MySqlDataSet()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.NCRTabControl.SuspendLayout()
		Me.DetailsTab.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.CcTab.SuspendLayout()
		CType(Me.StatusSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MySqlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'NCRTabControl
		'
		Me.NCRTabControl.Controls.Add(Me.DetailsTab)
		Me.NCRTabControl.Controls.Add(Me.CcTab)
		Me.NCRTabControl.Controls.Add(Me.RCP_Tab)
		Me.NCRTabControl.Controls.Add(Me.PA_Tab)
		Me.NCRTabControl.Controls.Add(Me.FollowupTab)
		Me.NCRTabControl.Controls.Add(Me.AttachTab)
		Me.NCRTabControl.Controls.Add(Me.StatusTab)
		Me.NCRTabControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.NCRTabControl.Location = New System.Drawing.Point(3, 3)
		Me.NCRTabControl.Name = "NCRTabControl"
		Me.NCRTabControl.SelectedIndex = 0
		Me.NCRTabControl.Size = New System.Drawing.Size(862, 528)
		Me.NCRTabControl.TabIndex = 0
		'
		'DetailsTab
		'
		Me.DetailsTab.Controls.Add(Me.TableLayoutPanel2)
		Me.DetailsTab.Location = New System.Drawing.Point(4, 22)
		Me.DetailsTab.Name = "DetailsTab"
		Me.DetailsTab.Padding = New System.Windows.Forms.Padding(3)
		Me.DetailsTab.Size = New System.Drawing.Size(854, 502)
		Me.DetailsTab.TabIndex = 0
		Me.DetailsTab.Text = "NCR Details"
		Me.DetailsTab.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 5
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.DescriptionTB, 2, 7)
		Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 7)
		Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 5)
		Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 3)
		Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.RaisedDatePicker, 2, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.IdTb, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 6)
		Me.TableLayoutPanel2.Controls.Add(Me.TitleTb, 2, 6)
		Me.TableLayoutPanel2.Controls.Add(Me.RaisedByTb, 2, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 4)
		Me.TableLayoutPanel2.Controls.Add(Me.StatusControl2, 3, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.AssignedToTb, 2, 3)
		Me.TableLayoutPanel2.Controls.Add(Me.DelegatedToTb, 2, 4)
		Me.TableLayoutPanel2.Controls.Add(Me.CurrentStatusTb, 2, 5)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 8
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(848, 496)
		Me.TableLayoutPanel2.TabIndex = 1
		'
		'DescriptionTB
		'
		Me.DescriptionTB.AcceptsReturn = True
		Me.DescriptionTB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left) _
				  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TableLayoutPanel2.SetColumnSpan(Me.DescriptionTB, 2)
		Me.DescriptionTB.Location = New System.Drawing.Point(124, 178)
		Me.DescriptionTB.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
		Me.DescriptionTB.MaxLength = 300
		Me.DescriptionTB.MinimumSize = New System.Drawing.Size(4, 50)
		Me.DescriptionTB.Multiline = True
		Me.DescriptionTB.Name = "DescriptionTB"
		Me.DescriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.DescriptionTB.Size = New System.Drawing.Size(445, 315)
		Me.DescriptionTB.TabIndex = 29
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 175)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 321)
		Me.Label1.TabIndex = 28
		Me.Label1.Text = "Description"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(3, 125)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(94, 25)
		Me.Label9.TabIndex = 23
		Me.Label9.Text = "Status"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(3, 75)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(94, 25)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Assigned to"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 50)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(94, 25)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Raised date"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 25)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 25)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Raised by"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'RaisedDatePicker
		'
		Me.RaisedDatePicker.Enabled = False
		Me.RaisedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.RaisedDatePicker.Location = New System.Drawing.Point(124, 53)
		Me.RaisedDatePicker.Name = "RaisedDatePicker"
		Me.RaisedDatePicker.Size = New System.Drawing.Size(121, 21)
		Me.RaisedDatePicker.TabIndex = 17
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Location = New System.Drawing.Point(3, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(94, 25)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Id"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'IdTb
		'
		Me.IdTb.Location = New System.Drawing.Point(124, 3)
		Me.IdTb.Name = "IdTb"
		Me.IdTb.ReadOnly = True
		Me.IdTb.Size = New System.Drawing.Size(42, 21)
		Me.IdTb.TabIndex = 31
		Me.IdTb.Text = "-"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Location = New System.Drawing.Point(3, 150)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(94, 25)
		Me.Label4.TabIndex = 32
		Me.Label4.Text = "Title"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TitleTb
		'
		Me.TitleTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.TitleTb.Location = New System.Drawing.Point(124, 153)
		Me.TitleTb.Name = "TitleTb"
		Me.TitleTb.Size = New System.Drawing.Size(330, 21)
		Me.TitleTb.TabIndex = 33
		'
		'RaisedByTb
		'
		Me.RaisedByTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.RaisedByTb.Location = New System.Drawing.Point(124, 28)
		Me.RaisedByTb.Name = "RaisedByTb"
		Me.RaisedByTb.ReadOnly = True
		Me.RaisedByTb.Size = New System.Drawing.Size(121, 21)
		Me.RaisedByTb.TabIndex = 38
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(20, 105)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(77, 15)
		Me.Label8.TabIndex = 41
		Me.Label8.Text = "Delegated to"
		'
		'StatusControl2
		'
		Me.TableLayoutPanel2.SetColumnSpan(Me.StatusControl2, 2)
		Me.StatusControl2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.StatusControl2.Location = New System.Drawing.Point(482, 3)
		Me.StatusControl2.Name = "StatusControl2"
		Me.TableLayoutPanel2.SetRowSpan(Me.StatusControl2, 6)
		Me.StatusControl2.Size = New System.Drawing.Size(363, 144)
		Me.StatusControl2.TabIndex = 43
		'
		'AssignedToTb
		'
		Me.AssignedToTb.Location = New System.Drawing.Point(124, 78)
		Me.AssignedToTb.Name = "AssignedToTb"
		Me.AssignedToTb.ReadOnly = True
		Me.AssignedToTb.Size = New System.Drawing.Size(121, 21)
		Me.AssignedToTb.TabIndex = 45
		'
		'DelegatedToTb
		'
		Me.DelegatedToTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.DelegatedToTb.Location = New System.Drawing.Point(124, 103)
		Me.DelegatedToTb.Name = "DelegatedToTb"
		Me.DelegatedToTb.ReadOnly = True
		Me.DelegatedToTb.Size = New System.Drawing.Size(121, 21)
		Me.DelegatedToTb.TabIndex = 44
		'
		'CurrentStatusTb
		'
		Me.CurrentStatusTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.CurrentStatusTb.Location = New System.Drawing.Point(124, 128)
		Me.CurrentStatusTb.Name = "CurrentStatusTb"
		Me.CurrentStatusTb.ReadOnly = True
		Me.CurrentStatusTb.Size = New System.Drawing.Size(253, 21)
		Me.CurrentStatusTb.TabIndex = 46
		'
		'CcTab
		'
		Me.CcTab.Controls.Add(Me.CcControl2)
		Me.CcTab.Location = New System.Drawing.Point(4, 22)
		Me.CcTab.Name = "CcTab"
		Me.CcTab.Padding = New System.Windows.Forms.Padding(3)
		Me.CcTab.Size = New System.Drawing.Size(854, 502)
		Me.CcTab.TabIndex = 7
		Me.CcTab.Text = "Correct & Contain"
		Me.CcTab.UseVisualStyleBackColor = True
		'
		'CcControl2
		'
		Me.CcControl2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CcControl2.Location = New System.Drawing.Point(3, 3)
		Me.CcControl2.Name = "CcControl2"
		Me.CcControl2.Size = New System.Drawing.Size(848, 496)
		Me.CcControl2.TabIndex = 0
		'
		'RCP_Tab
		'
		Me.RCP_Tab.Location = New System.Drawing.Point(4, 22)
		Me.RCP_Tab.Name = "RCP_Tab"
		Me.RCP_Tab.Padding = New System.Windows.Forms.Padding(3)
		Me.RCP_Tab.Size = New System.Drawing.Size(854, 502)
		Me.RCP_Tab.TabIndex = 2
		Me.RCP_Tab.Text = "Root Cause Prevention"
		Me.RCP_Tab.UseVisualStyleBackColor = True
		'
		'PA_Tab
		'
		Me.PA_Tab.Location = New System.Drawing.Point(4, 22)
		Me.PA_Tab.Name = "PA_Tab"
		Me.PA_Tab.Padding = New System.Windows.Forms.Padding(3)
		Me.PA_Tab.Size = New System.Drawing.Size(854, 502)
		Me.PA_Tab.TabIndex = 3
		Me.PA_Tab.Text = "Preventive Action"
		Me.PA_Tab.UseVisualStyleBackColor = True
		'
		'FollowupTab
		'
		Me.FollowupTab.Location = New System.Drawing.Point(4, 22)
		Me.FollowupTab.Name = "FollowupTab"
		Me.FollowupTab.Padding = New System.Windows.Forms.Padding(3)
		Me.FollowupTab.Size = New System.Drawing.Size(854, 502)
		Me.FollowupTab.TabIndex = 4
		Me.FollowupTab.Text = "Follow Up"
		Me.FollowupTab.UseVisualStyleBackColor = True
		'
		'AttachTab
		'
		Me.AttachTab.Location = New System.Drawing.Point(4, 22)
		Me.AttachTab.Name = "AttachTab"
		Me.AttachTab.Padding = New System.Windows.Forms.Padding(3)
		Me.AttachTab.Size = New System.Drawing.Size(854, 502)
		Me.AttachTab.TabIndex = 5
		Me.AttachTab.Text = "Attach File"
		Me.AttachTab.UseVisualStyleBackColor = True
		'
		'StatusTab
		'
		Me.StatusTab.Location = New System.Drawing.Point(4, 22)
		Me.StatusTab.Name = "StatusTab"
		Me.StatusTab.Padding = New System.Windows.Forms.Padding(3)
		Me.StatusTab.Size = New System.Drawing.Size(854, 502)
		Me.StatusTab.TabIndex = 6
		Me.StatusTab.Text = "NCR Status"
		Me.StatusTab.UseVisualStyleBackColor = True
		'
		'StatusSource
		'
		Me.StatusSource.DataSource = Me.MySqlDataSet1
		Me.StatusSource.Position = 0
		'
		'MySqlDataSet1
		'
		Me.MySqlDataSet1.DataSetName = "MySqlDataSet"
		Me.MySqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 92)
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
		Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(183, 22)
		Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(183, 22)
		Me.ToolStripMenuItem3.Text = "ToolStripMenuItem3"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(183, 22)
		Me.ToolStripMenuItem4.Text = "ToolStripMenuItem4"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 1
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 0)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 41)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.SteelBlue
		Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 3)
		Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label7.Location = New System.Drawing.Point(3, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(862, 40)
		Me.Label7.TabIndex = 1
		Me.Label7.Text = "NCR Details"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(868, 22)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 2
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 1
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.NCRTabControl, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 41)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 2
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(868, 574)
		Me.TableLayoutPanel3.TabIndex = 3
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.CloseBtn)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 537)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(862, 34)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'CloseBtn
		'
		Me.CloseBtn.Location = New System.Drawing.Point(784, 3)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
		Me.CloseBtn.TabIndex = 1
		Me.CloseBtn.Text = "Close"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'NCRDetailsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(868, 637)
		Me.Controls.Add(Me.TableLayoutPanel3)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Name = "NCRDetailsForm"
		Me.Text = "NCR Details Form"
		Me.NCRTabControl.ResumeLayout(False)
		Me.DetailsTab.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.CcTab.ResumeLayout(False)
		CType(Me.StatusSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MySqlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents NCRTabControl As System.Windows.Forms.TabControl
	Friend WithEvents DetailsTab As System.Windows.Forms.TabPage
	Friend WithEvents RCP_Tab As System.Windows.Forms.TabPage
	Friend WithEvents PA_Tab As System.Windows.Forms.TabPage
	Friend WithEvents FollowupTab As System.Windows.Forms.TabPage
	Friend WithEvents AttachTab As System.Windows.Forms.TabPage
	Friend WithEvents StatusTab As System.Windows.Forms.TabPage
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents RaisedDatePicker As System.Windows.Forms.DateTimePicker
	Friend WithEvents DescriptionTB As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents IdTb As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents TitleTb As System.Windows.Forms.TextBox
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
	Friend WithEvents NcrLog1 As CATS.NcrLog
	Friend WithEvents StatusSource As System.Windows.Forms.BindingSource
	Friend WithEvents RaisedByTb As System.Windows.Forms.TextBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents StatusControl2 As CATS.StatusControl
	Friend WithEvents MySqlDataSet1 As BaseModel.MySqlDataSet
	Friend WithEvents CcTab As System.Windows.Forms.TabPage
	Friend WithEvents AssignedToTb As System.Windows.Forms.TextBox
	Friend WithEvents DelegatedToTb As System.Windows.Forms.TextBox
	Friend WithEvents CurrentStatusTb As System.Windows.Forms.TextBox
	Friend WithEvents CcControl2 As CATS.CcControl
End Class
