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
		Me.PlanGridView = New System.Windows.Forms.DataGridView()
		Me.CcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ReviewGridView = New System.Windows.Forms.DataGridView()
		Me.idCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.seqCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.actionCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.passCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.failCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.actionByIdCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.dueDateCol = New Calendar.CalendarColumn()
		Me.CompletionDateCol = New Calendar.CalendarColumn()
		Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ReviewByCol = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.ReviewDateCol = New Calendar.CalendarColumn()
		Me.CommentCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.NcrSubjectTb = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.NcrIdTb = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.StatusTb = New System.Windows.Forms.TextBox()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CalendarColumn1 = New Calendar.CalendarColumn()
		Me.CalendarColumn2 = New Calendar.CalendarColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.CcStatusCntr = New CATS.CcStatusControl()
		Me.IdTextCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.seqTextCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.actionTextCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PlanActionByCmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
		Me.PlanDueDateCal = New Calendar.CalendarColumn()
		Me.PlanComplDateCal = New Calendar.CalendarColumn()
		Me.StatusTextCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.passedCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.failedCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ccIdCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.PlanGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ReviewGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.TableLayoutPanel1.Controls.Add(Me.PlanGridView, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.ReviewGridView, 1, 2)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 79)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(991, 332)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'PlanGridView
		'
		Me.PlanGridView.AllowUserToDeleteRows = False
		Me.PlanGridView.AllowUserToResizeColumns = False
		Me.PlanGridView.AllowUserToResizeRows = False
		Me.PlanGridView.AutoGenerateColumns = False
		Me.PlanGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.PlanGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTextCol, Me.seqTextCol, Me.actionTextCol, Me.PlanActionByCmb, Me.PlanDueDateCal, Me.PlanComplDateCal, Me.StatusTextCol, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.passedCol, Me.failedCol, Me.ccIdCol})
		Me.PlanGridView.DataSource = Me.CcBindingSource
		Me.PlanGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PlanGridView.Location = New System.Drawing.Point(13, 14)
		Me.PlanGridView.Name = "PlanGridView"
		Me.PlanGridView.RowHeadersVisible = False
		Me.PlanGridView.Size = New System.Drawing.Size(965, 162)
		Me.PlanGridView.TabIndex = 1
		'
		'CcBindingSource
		'
		Me.CcBindingSource.DataSource = GetType(BaseModel.MySqlDataSet.ccitemDataTable)
		'
		'ReviewGridView
		'
		Me.ReviewGridView.AllowUserToAddRows = False
		Me.ReviewGridView.AllowUserToDeleteRows = False
		Me.ReviewGridView.AllowUserToResizeColumns = False
		Me.ReviewGridView.AllowUserToResizeRows = False
		Me.ReviewGridView.AutoGenerateColumns = False
		Me.ReviewGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.ReviewGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCol, Me.seqCol, Me.actionCol, Me.passCol, Me.failCol, Me.actionByIdCol, Me.dueDateCol, Me.CompletionDateCol, Me.DataGridViewTextBoxColumn14, Me.ReviewByCol, Me.ReviewDateCol, Me.CommentCol, Me.DataGridViewTextBoxColumn20})
		Me.ReviewGridView.DataSource = Me.CcBindingSource
		Me.ReviewGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ReviewGridView.Location = New System.Drawing.Point(13, 182)
		Me.ReviewGridView.Name = "ReviewGridView"
		Me.ReviewGridView.RowHeadersVisible = False
		Me.ReviewGridView.Size = New System.Drawing.Size(965, 147)
		Me.ReviewGridView.TabIndex = 2
		'
		'idCol
		'
		Me.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.idCol.DataPropertyName = "id"
		Me.idCol.HeaderText = "id"
		Me.idCol.MinimumWidth = 30
		Me.idCol.Name = "idCol"
		Me.idCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
		Me.idCol.Visible = False
		Me.idCol.Width = 30
		'
		'seqCol
		'
		Me.seqCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.seqCol.DataPropertyName = "seq"
		Me.seqCol.HeaderText = "Seq"
		Me.seqCol.MinimumWidth = 30
		Me.seqCol.Name = "seqCol"
		Me.seqCol.ReadOnly = True
		Me.seqCol.Width = 30
		'
		'actionCol
		'
		Me.actionCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.actionCol.DataPropertyName = "action"
		Me.actionCol.FillWeight = 50.0!
		Me.actionCol.HeaderText = "Action"
		Me.actionCol.MinimumWidth = 50
		Me.actionCol.Name = "actionCol"
		Me.actionCol.ReadOnly = True
		'
		'passCol
		'
		Me.passCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.passCol.DataPropertyName = "passed"
		Me.passCol.FalseValue = "0"
		Me.passCol.HeaderText = "Pass"
		Me.passCol.MinimumWidth = 40
		Me.passCol.Name = "passCol"
		Me.passCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.passCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.passCol.TrueValue = "1"
		Me.passCol.Width = 40
		'
		'failCol
		'
		Me.failCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.failCol.DataPropertyName = "failed"
		Me.failCol.FalseValue = "0"
		Me.failCol.HeaderText = "Fail"
		Me.failCol.MinimumWidth = 40
		Me.failCol.Name = "failCol"
		Me.failCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.failCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.failCol.TrueValue = "1"
		Me.failCol.Width = 40
		'
		'actionByIdCol
		'
		Me.actionByIdCol.DataPropertyName = "actionby_id"
		Me.actionByIdCol.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
		Me.actionByIdCol.HeaderText = "Action By"
		Me.actionByIdCol.Name = "actionByIdCol"
		Me.actionByIdCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.actionByIdCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.actionByIdCol.Visible = False
		'
		'dueDateCol
		'
		Me.dueDateCol.DataPropertyName = "duedate"
		Me.dueDateCol.HeaderText = "Due Date"
		Me.dueDateCol.Name = "dueDateCol"
		Me.dueDateCol.Visible = False
		'
		'CompletionDateCol
		'
		Me.CompletionDateCol.DataPropertyName = "completiondate"
		Me.CompletionDateCol.HeaderText = "Completion Date"
		Me.CompletionDateCol.Name = "CompletionDateCol"
		Me.CompletionDateCol.Visible = False
		'
		'DataGridViewTextBoxColumn14
		'
		Me.DataGridViewTextBoxColumn14.DataPropertyName = "status"
		Me.DataGridViewTextBoxColumn14.HeaderText = "Status"
		Me.DataGridViewTextBoxColumn14.MinimumWidth = 100
		Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
		Me.DataGridViewTextBoxColumn14.Visible = False
		'
		'ReviewByCol
		'
		Me.ReviewByCol.DataPropertyName = "reviewer_id"
		Me.ReviewByCol.HeaderText = "Review By"
		Me.ReviewByCol.Name = "ReviewByCol"
		Me.ReviewByCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ReviewByCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'ReviewDateCol
		'
		Me.ReviewDateCol.DataPropertyName = "reviewdate"
		Me.ReviewDateCol.HeaderText = "Review Date"
		Me.ReviewDateCol.Name = "ReviewDateCol"
		Me.ReviewDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ReviewDateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'CommentCol
		'
		Me.CommentCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.CommentCol.DataPropertyName = "reviewcomment"
		Me.CommentCol.FillWeight = 50.0!
		Me.CommentCol.HeaderText = "Comment"
		Me.CommentCol.MinimumWidth = 100
		Me.CommentCol.Name = "CommentCol"
		'
		'DataGridViewTextBoxColumn20
		'
		Me.DataGridViewTextBoxColumn20.DataPropertyName = "cc_id"
		Me.DataGridViewTextBoxColumn20.HeaderText = "cc_id"
		Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
		Me.DataGridViewTextBoxColumn20.Visible = False
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.13131!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.86869!))
		Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.CcStatusCntr, 1, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 1
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(991, 79)
		Me.TableLayoutPanel2.TabIndex = 2
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 4
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.Controls.Add(Me.NcrSubjectTb, 3, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.NcrIdTb, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.StatusTb, 3, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 3
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(619, 73)
		Me.TableLayoutPanel3.TabIndex = 1
		'
		'NcrSubjectTb
		'
		Me.NcrSubjectTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.NcrSubjectTb.Enabled = False
		Me.NcrSubjectTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NcrSubjectTb.Location = New System.Drawing.Point(228, 3)
		Me.NcrSubjectTb.Name = "NcrSubjectTb"
		Me.NcrSubjectTb.ReadOnly = True
		Me.NcrSubjectTb.Size = New System.Drawing.Size(215, 23)
		Me.NcrSubjectTb.TabIndex = 3
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(17, 5)
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
		Me.Label2.Location = New System.Drawing.Point(167, 5)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Subject"
		'
		'NcrIdTb
		'
		Me.NcrIdTb.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.NcrIdTb.Enabled = False
		Me.NcrIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NcrIdTb.Location = New System.Drawing.Point(53, 3)
		Me.NcrIdTb.Name = "NcrIdTb"
		Me.NcrIdTb.ReadOnly = True
		Me.NcrIdTb.Size = New System.Drawing.Size(80, 23)
		Me.NcrIdTb.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(152, 33)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 17)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "CC Status"
		'
		'StatusTb
		'
		Me.StatusTb.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.StatusTb.Enabled = False
		Me.StatusTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusTb.Location = New System.Drawing.Point(228, 31)
		Me.StatusTb.Name = "StatusTb"
		Me.StatusTb.ReadOnly = True
		Me.StatusTb.Size = New System.Drawing.Size(215, 23)
		Me.StatusTb.TabIndex = 5
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "seq"
		Me.DataGridViewTextBoxColumn1.HeaderText = "Seq"
		Me.DataGridViewTextBoxColumn1.MinimumWidth = 30
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.Width = 30
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "action"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Action"
		Me.DataGridViewTextBoxColumn3.MinimumWidth = 50
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		'
		'CalendarColumn1
		'
		Me.CalendarColumn1.DataPropertyName = "duedate"
		Me.CalendarColumn1.HeaderText = "Due Date"
		Me.CalendarColumn1.Name = "CalendarColumn1"
		'
		'CalendarColumn2
		'
		Me.CalendarColumn2.DataPropertyName = "completiondate"
		Me.CalendarColumn2.HeaderText = "Completion Date"
		Me.CalendarColumn2.Name = "CalendarColumn2"
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "status"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "passed"
		Me.DataGridViewTextBoxColumn5.HeaderText = "passed"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.Visible = False
		'
		'DataGridViewTextBoxColumn10
		'
		Me.DataGridViewTextBoxColumn10.DataPropertyName = "cc_id"
		Me.DataGridViewTextBoxColumn10.HeaderText = "cc_id"
		Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
		Me.DataGridViewTextBoxColumn10.Visible = False
		'
		'CcStatusCntr
		'
		Me.CcStatusCntr.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.CcStatusCntr.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CcStatusCntr.Location = New System.Drawing.Point(628, 3)
		Me.CcStatusCntr.Name = "CcStatusCntr"
		Me.CcStatusCntr.Size = New System.Drawing.Size(360, 73)
		Me.CcStatusCntr.TabIndex = 2
		'
		'IdTextCol
		'
		Me.IdTextCol.DataPropertyName = "id"
		Me.IdTextCol.HeaderText = "id"
		Me.IdTextCol.Name = "IdTextCol"
		Me.IdTextCol.Visible = False
		'
		'seqTextCol
		'
		Me.seqTextCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
		Me.seqTextCol.DataPropertyName = "seq"
		Me.seqTextCol.HeaderText = "Seq"
		Me.seqTextCol.MinimumWidth = 30
		Me.seqTextCol.Name = "seqTextCol"
		Me.seqTextCol.Width = 30
		'
		'actionTextCol
		'
		Me.actionTextCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.actionTextCol.DataPropertyName = "action"
		Me.actionTextCol.HeaderText = "Action"
		Me.actionTextCol.MinimumWidth = 50
		Me.actionTextCol.Name = "actionTextCol"
		'
		'PlanActionByCmb
		'
		Me.PlanActionByCmb.DataPropertyName = "actionby_id"
		Me.PlanActionByCmb.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
		Me.PlanActionByCmb.HeaderText = "Action By"
		Me.PlanActionByCmb.Name = "PlanActionByCmb"
		Me.PlanActionByCmb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.PlanActionByCmb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		'
		'PlanDueDateCal
		'
		Me.PlanDueDateCal.DataPropertyName = "duedate"
		Me.PlanDueDateCal.HeaderText = "Due Date"
		Me.PlanDueDateCal.Name = "PlanDueDateCal"
		'
		'PlanComplDateCal
		'
		Me.PlanComplDateCal.DataPropertyName = "completiondate"
		Me.PlanComplDateCal.HeaderText = "Completion Date"
		Me.PlanComplDateCal.Name = "PlanComplDateCal"
		'
		'StatusTextCol
		'
		Me.StatusTextCol.DataPropertyName = "status"
		Me.StatusTextCol.HeaderText = "Status"
		Me.StatusTextCol.Name = "StatusTextCol"
		Me.StatusTextCol.Visible = False
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
		'passedCol
		'
		Me.passedCol.DataPropertyName = "passed"
		Me.passedCol.HeaderText = "passed"
		Me.passedCol.Name = "passedCol"
		Me.passedCol.Visible = False
		'
		'failedCol
		'
		Me.failedCol.DataPropertyName = "failed"
		Me.failedCol.HeaderText = "failed"
		Me.failedCol.Name = "failedCol"
		Me.failedCol.Visible = False
		'
		'ccIdCol
		'
		Me.ccIdCol.DataPropertyName = "cc_id"
		Me.ccIdCol.HeaderText = "cc_id"
		Me.ccIdCol.Name = "ccIdCol"
		Me.ccIdCol.Visible = False
		'
		'CcControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Name = "CcControl"
		Me.Size = New System.Drawing.Size(991, 411)
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.PlanGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ReviewGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents PlanGridView As System.Windows.Forms.DataGridView
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
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents StatusTb As System.Windows.Forms.TextBox
	Friend WithEvents CcStatusCntr As CATS.CcStatusControl
	Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents CalendarColumn1 As Calendar.CalendarColumn
	Friend WithEvents CalendarColumn2 As Calendar.CalendarColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewGridView As System.Windows.Forms.DataGridView
	Friend WithEvents ReviewByIdCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents idCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents seqCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents actionCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents passCol As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents failCol As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents actionByIdCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents dueDateCol As Calendar.CalendarColumn
	Friend WithEvents CompletionDateCol As Calendar.CalendarColumn
	Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ReviewByCol As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents ReviewDateCol As Calendar.CalendarColumn
	Friend WithEvents CommentCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents IdTextCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents seqTextCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents actionTextCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents PlanActionByCmb As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents PlanDueDateCal As Calendar.CalendarColumn
	Friend WithEvents PlanComplDateCal As Calendar.CalendarColumn
	Friend WithEvents StatusTextCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents passedCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents failedCol As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents ccIdCol As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
