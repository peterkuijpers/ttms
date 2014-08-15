<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
		Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("test")
		Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
		Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
		Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
		Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.UserNameLbl = New System.Windows.Forms.Label()
		Me.DepartmentLbl = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.LevelLbl = New System.Windows.Forms.Label()
		Me.LevelDescriptionLbl = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RightGroupBox = New System.Windows.Forms.GroupBox()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.LogoutBtn = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.UserManagementBtn = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CatsBtn = New System.Windows.Forms.Button()
		Me.IssuesBtn = New System.Windows.Forms.Button()
		Me.DotsBtn = New System.Windows.Forms.Button()
		Me.OhsBtn = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.NotificationsGridView = New System.Windows.Forms.DataGridView()
		Me.user_idCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ncr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MessageDataGridViewImageColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.timestampCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NotificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.MySqlDataSet = New TTMS.MySqlDataSet()
		Me.NotificationTableAdapter = New TTMS.MySqlDataSetTableAdapters.notificationTableAdapter()
		Me.Panel1.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.RightGroupBox.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		CType(Me.NotificationsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NotificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MySqlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
		Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1084, 61)
		Me.Panel1.TabIndex = 0
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.BackColor = System.Drawing.Color.SteelBlue
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 1, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(1084, 49)
		Me.TableLayoutPanel2.TabIndex = 2
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
		Me.PictureBox1.Image = Global.TTMS.My.Resources.Resources.CompanyLogo
		Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(94, 44)
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'Panel3
		'
		Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Panel3.Controls.Add(Me.Label1)
		Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Panel3.Location = New System.Drawing.Point(103, 3)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(978, 44)
		Me.Panel3.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(75, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(171, 26)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Managers Portal"
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
		Me.Panel2.Controls.Add(Me.Panel1)
		Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel2.Location = New System.Drawing.Point(0, 0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(1084, 50)
		Me.Panel2.TabIndex = 1
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 6
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.UserNameLbl, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.DepartmentLbl, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label9, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.LevelLbl, 3, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.LevelDescriptionLbl, 3, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 13)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(849, 51)
		Me.TableLayoutPanel1.TabIndex = 1
		'
		'Label3
		'
		Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(35, 27)
		Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Label3.Size = New System.Drawing.Size(62, 15)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "Department"
		'
		'UserNameLbl
		'
		Me.UserNameLbl.AutoSize = True
		Me.UserNameLbl.BackColor = System.Drawing.Color.Silver
		Me.UserNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.UserNameLbl.Location = New System.Drawing.Point(103, 0)
		Me.UserNameLbl.MinimumSize = New System.Drawing.Size(100, 20)
		Me.UserNameLbl.Name = "UserNameLbl"
		Me.UserNameLbl.Size = New System.Drawing.Size(100, 20)
		Me.UserNameLbl.TabIndex = 2
		Me.UserNameLbl.Text = "Kesor"
		Me.UserNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'DepartmentLbl
		'
		Me.DepartmentLbl.AutoSize = True
		Me.DepartmentLbl.BackColor = System.Drawing.Color.Silver
		Me.DepartmentLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.DepartmentLbl.Location = New System.Drawing.Point(103, 24)
		Me.DepartmentLbl.MinimumSize = New System.Drawing.Size(100, 20)
		Me.DepartmentLbl.Name = "DepartmentLbl"
		Me.DepartmentLbl.Size = New System.Drawing.Size(100, 20)
		Me.DepartmentLbl.TabIndex = 3
		Me.DepartmentLbl.Text = "Safety Dep"
		Me.DepartmentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(42, 5)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Username"
		'
		'Label6
		'
		Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(253, 27)
		Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
		Me.Label6.Size = New System.Drawing.Size(44, 15)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Position"
		'
		'Label9
		'
		Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(239, 5)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(58, 13)
		Me.Label9.TabIndex = 4
		Me.Label9.Text = "User Level"
		'
		'LevelLbl
		'
		Me.LevelLbl.AutoSize = True
		Me.LevelLbl.BackColor = System.Drawing.Color.Silver
		Me.LevelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LevelLbl.Location = New System.Drawing.Point(303, 0)
		Me.LevelLbl.MinimumSize = New System.Drawing.Size(100, 20)
		Me.LevelLbl.Name = "LevelLbl"
		Me.LevelLbl.Size = New System.Drawing.Size(100, 20)
		Me.LevelLbl.TabIndex = 6
		Me.LevelLbl.Text = "3"
		Me.LevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'LevelDescriptionLbl
		'
		Me.LevelDescriptionLbl.AutoSize = True
		Me.LevelDescriptionLbl.BackColor = System.Drawing.Color.Silver
		Me.LevelDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LevelDescriptionLbl.Location = New System.Drawing.Point(303, 24)
		Me.LevelDescriptionLbl.MinimumSize = New System.Drawing.Size(100, 20)
		Me.LevelDescriptionLbl.Name = "LevelDescriptionLbl"
		Me.LevelDescriptionLbl.Size = New System.Drawing.Size(100, 20)
		Me.LevelDescriptionLbl.TabIndex = 7
		Me.LevelDescriptionLbl.Text = "QA Manager"
		Me.LevelDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
		Me.TableLayoutPanel3.SetColumnSpan(Me.GroupBox1, 2)
		Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
		Me.GroupBox1.Size = New System.Drawing.Size(855, 67)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		'
		'RightGroupBox
		'
		Me.RightGroupBox.BackColor = System.Drawing.Color.Gainsboro
		Me.RightGroupBox.Controls.Add(Me.FlowLayoutPanel2)
		Me.RightGroupBox.Controls.Add(Me.FlowLayoutPanel1)
		Me.RightGroupBox.Dock = System.Windows.Forms.DockStyle.Right
		Me.RightGroupBox.Location = New System.Drawing.Point(975, 50)
		Me.RightGroupBox.Name = "RightGroupBox"
		Me.RightGroupBox.Size = New System.Drawing.Size(109, 427)
		Me.RightGroupBox.TabIndex = 2
		Me.RightGroupBox.TabStop = False
		Me.RightGroupBox.Text = "Modules"
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
				  Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel2.Controls.Add(Me.CloseBtn)
		Me.FlowLayoutPanel2.Controls.Add(Me.LogoutBtn)
		Me.FlowLayoutPanel2.Controls.Add(Me.Button3)
		Me.FlowLayoutPanel2.Controls.Add(Me.UserManagementBtn)
		Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(6, 226)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(97, 195)
		Me.FlowLayoutPanel2.TabIndex = 2
		'
		'CloseBtn
		'
		Me.CloseBtn.Location = New System.Drawing.Point(3, 169)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(88, 23)
		Me.CloseBtn.TabIndex = 0
		Me.CloseBtn.Text = "Exit"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'LogoutBtn
		'
		Me.LogoutBtn.Location = New System.Drawing.Point(3, 140)
		Me.LogoutBtn.Name = "LogoutBtn"
		Me.LogoutBtn.Size = New System.Drawing.Size(88, 23)
		Me.LogoutBtn.TabIndex = 1
		Me.LogoutBtn.Text = "Log out"
		Me.LogoutBtn.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(3, 111)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(88, 23)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Account"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'UserManagementBtn
		'
		Me.UserManagementBtn.Location = New System.Drawing.Point(3, 70)
		Me.UserManagementBtn.Name = "UserManagementBtn"
		Me.UserManagementBtn.Size = New System.Drawing.Size(88, 35)
		Me.UserManagementBtn.TabIndex = 3
		Me.UserManagementBtn.Text = "User Management"
		Me.UserManagementBtn.UseVisualStyleBackColor = True
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
		Me.FlowLayoutPanel1.Controls.Add(Me.CatsBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.IssuesBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.DotsBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.OhsBtn)
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 19)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(97, 201)
		Me.FlowLayoutPanel1.TabIndex = 0
		'
		'CatsBtn
		'
		Me.CatsBtn.Location = New System.Drawing.Point(3, 3)
		Me.CatsBtn.Name = "CatsBtn"
		Me.CatsBtn.Size = New System.Drawing.Size(75, 23)
		Me.CatsBtn.TabIndex = 0
		Me.CatsBtn.Text = "CATS"
		Me.CatsBtn.UseVisualStyleBackColor = True
		Me.CatsBtn.Visible = False
		'
		'IssuesBtn
		'
		Me.IssuesBtn.Location = New System.Drawing.Point(3, 32)
		Me.IssuesBtn.Name = "IssuesBtn"
		Me.IssuesBtn.Size = New System.Drawing.Size(75, 23)
		Me.IssuesBtn.TabIndex = 1
		Me.IssuesBtn.Text = "ISSUES"
		Me.IssuesBtn.UseVisualStyleBackColor = True
		Me.IssuesBtn.Visible = False
		'
		'DotsBtn
		'
		Me.DotsBtn.Location = New System.Drawing.Point(3, 61)
		Me.DotsBtn.Name = "DotsBtn"
		Me.DotsBtn.Size = New System.Drawing.Size(75, 23)
		Me.DotsBtn.TabIndex = 2
		Me.DotsBtn.Text = "DOTS"
		Me.DotsBtn.UseVisualStyleBackColor = True
		Me.DotsBtn.Visible = False
		'
		'OhsBtn
		'
		Me.OhsBtn.Location = New System.Drawing.Point(3, 90)
		Me.OhsBtn.Name = "OhsBtn"
		Me.OhsBtn.Size = New System.Drawing.Size(75, 23)
		Me.OhsBtn.TabIndex = 3
		Me.OhsBtn.Text = "OHS"
		Me.OhsBtn.UseVisualStyleBackColor = True
		Me.OhsBtn.Visible = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 477)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1084, 22)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.Color.Silver
		Me.GroupBox3.Controls.Add(Me.ListView1)
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox3.Location = New System.Drawing.Point(3, 70)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(152, 354)
		Me.GroupBox3.TabIndex = 4
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Tasks"
		'
		'ListView1
		'
		Me.ListView1.BackColor = System.Drawing.SystemColors.Info
		Me.ListView1.CheckBoxes = True
		Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
		ListViewItem1.StateImageIndex = 0
		ListViewItem2.StateImageIndex = 0
		ListViewItem3.StateImageIndex = 0
		ListViewItem4.StateImageIndex = 0
		ListViewItem5.Checked = True
		ListViewItem5.StateImageIndex = 1
		Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
		Me.ListView1.Location = New System.Drawing.Point(3, 16)
		Me.ListView1.MultiSelect = False
		Me.ListView1.Name = "ListView1"
		Me.ListView1.ShowGroups = False
		Me.ListView1.Size = New System.Drawing.Size(146, 335)
		Me.ListView1.TabIndex = 0
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = ""
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro
		Me.TableLayoutPanel3.ColumnCount = 3
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.57355!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.42645!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.GroupBox1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.GroupBox3, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.GroupBox4, 1, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 50)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 2
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(975, 427)
		Me.TableLayoutPanel3.TabIndex = 5
		'
		'GroupBox4
		'
		Me.GroupBox4.BackColor = System.Drawing.Color.Gainsboro
		Me.TableLayoutPanel3.SetColumnSpan(Me.GroupBox4, 2)
		Me.GroupBox4.Controls.Add(Me.TableLayoutPanel4)
		Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox4.Location = New System.Drawing.Point(161, 70)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(811, 354)
		Me.GroupBox4.TabIndex = 5
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Notifications"
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 1
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.NotificationsGridView, 0, 1)
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(36, 32)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 2
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.54321!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(705, 211)
		Me.TableLayoutPanel4.TabIndex = 0
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(96, 13)
		Me.Label4.TabIndex = 0
		Me.Label4.Text = "CATS Notifications"
		'
		'NotificationsGridView
		'
		Me.NotificationsGridView.AllowUserToAddRows = False
		Me.NotificationsGridView.AllowUserToDeleteRows = False
		Me.NotificationsGridView.AllowUserToResizeColumns = False
		Me.NotificationsGridView.AutoGenerateColumns = False
		Me.NotificationsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.NotificationsGridView.BackgroundColor = System.Drawing.Color.Silver
		Me.NotificationsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.NotificationsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.user_idCol, Me.ncr_id, Me.MessageDataGridViewImageColumn, Me.timestampCol})
		Me.NotificationsGridView.DataSource = Me.NotificationBindingSource
		Me.NotificationsGridView.Location = New System.Drawing.Point(3, 22)
		Me.NotificationsGridView.MinimumSize = New System.Drawing.Size(0, 50)
		Me.NotificationsGridView.Name = "NotificationsGridView"
		Me.NotificationsGridView.ReadOnly = True
		Me.NotificationsGridView.RowHeadersVisible = False
		Me.NotificationsGridView.Size = New System.Drawing.Size(684, 108)
		Me.NotificationsGridView.TabIndex = 1
		'
		'user_idCol
		'
		Me.user_idCol.DataPropertyName = "user_id"
		Me.user_idCol.HeaderText = "user_id"
		Me.user_idCol.Name = "user_idCol"
		Me.user_idCol.ReadOnly = True
		Me.user_idCol.Visible = False
		Me.user_idCol.Width = 66
		'
		'ncr_id
		'
		Me.ncr_id.DataPropertyName = "ncr_id"
		Me.ncr_id.FillWeight = 50.0!
		Me.ncr_id.HeaderText = "ncr_id"
		Me.ncr_id.MinimumWidth = 50
		Me.ncr_id.Name = "ncr_id"
		Me.ncr_id.ReadOnly = True
		Me.ncr_id.Width = 122
		'
		'MessageDataGridViewImageColumn
		'
		Me.MessageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.MessageDataGridViewImageColumn.DataPropertyName = "message"
		Me.MessageDataGridViewImageColumn.HeaderText = "message"
		Me.MessageDataGridViewImageColumn.Name = "MessageDataGridViewImageColumn"
		Me.MessageDataGridViewImageColumn.ReadOnly = True
		Me.MessageDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.MessageDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
		'
		'timestampCol
		'
		Me.timestampCol.DataPropertyName = "timestamp"
		Me.timestampCol.FillWeight = 130.0!
		Me.timestampCol.HeaderText = "timestamp"
		Me.timestampCol.MinimumWidth = 130
		Me.timestampCol.Name = "timestampCol"
		Me.timestampCol.ReadOnly = True
		Me.timestampCol.Width = 316
		'
		'NotificationBindingSource
		'
		Me.NotificationBindingSource.DataMember = "notification"
		Me.NotificationBindingSource.DataSource = Me.MySqlDataSet
		Me.NotificationBindingSource.Filter = ""
		Me.NotificationBindingSource.Sort = ""
		'
		'MySqlDataSet
		'
		Me.MySqlDataSet.DataSetName = "MySqlDataSet"
		Me.MySqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'NotificationTableAdapter
		'
		Me.NotificationTableAdapter.ClearBeforeFill = True
		'
		'Dashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LemonChiffon
		Me.ClientSize = New System.Drawing.Size(1084, 499)
		Me.Controls.Add(Me.TableLayoutPanel3)
		Me.Controls.Add(Me.RightGroupBox)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Panel2)
		Me.Name = "Dashboard"
		Me.Text = "TTMS Dashboard"
		Me.Panel1.ResumeLayout(False)
		Me.TableLayoutPanel2.ResumeLayout(False)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.RightGroupBox.ResumeLayout(False)
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		CType(Me.NotificationsGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NotificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MySqlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents UserNameLbl As System.Windows.Forms.Label
	Friend WithEvents DepartmentLbl As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Panel3 As System.Windows.Forms.Panel
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents LevelLbl As System.Windows.Forms.Label
	Friend WithEvents LevelDescriptionLbl As System.Windows.Forms.Label
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents RightGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents CatsBtn As System.Windows.Forms.Button
	Friend WithEvents IssuesBtn As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents ListView1 As System.Windows.Forms.ListView
	Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Friend WithEvents DotsBtn As System.Windows.Forms.Button
	Friend WithEvents OhsBtn As System.Windows.Forms.Button
	Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
	Friend WithEvents LogoutBtn As System.Windows.Forms.Button
	Friend WithEvents Button3 As System.Windows.Forms.Button
	Friend WithEvents UserManagementBtn As System.Windows.Forms.Button
	Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents NotificationsGridView As System.Windows.Forms.DataGridView
	Friend WithEvents NotificationBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents MySqlDataSet As MySqlDataSet
	Friend WithEvents NotificationTableAdapter As MySqlDataSetTableAdapters.notificationTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_idCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ncr_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewImageColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timestampCol As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
