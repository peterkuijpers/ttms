﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCARForm
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
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.HeaderLabel = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.RaisedByCombo = New System.Windows.Forms.ComboBox()
		Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataSet1 = New TTMS.TTMSDataSet()
		Me.RaisedDatePicker = New System.Windows.Forms.DateTimePicker()
		Me.DescriptionTB = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TitleTb = New System.Windows.Forms.TextBox()
		Me.RaisedToTb = New System.Windows.Forms.TextBox()
		Me.StatusTb = New System.Windows.Forms.TextBox()
		Me.UsersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.NCRStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CancelBtn = New System.Windows.Forms.Button()
		Me.OkBtn = New System.Windows.Forms.Button()
		Me.CreateBtn = New System.Windows.Forms.Button()
		Me.NCR_StatusTableAdapter = New TTMS.TTMSDataSetTableAdapters.NCR_Status1TableAdapter()
		Me.TtmsDataSet1 = New TTMS.TTMSDataSet()
		Me.UsersTableAdapter = New TTMS.TTMSDataSetTableAdapters.UsersTableAdapter()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NCRStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel1.SuspendLayout()
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.HeaderLabel, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.RaisedByCombo, 2, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.RaisedDatePicker, 2, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.DescriptionTB, 2, 7)
		Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 2, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.TitleTb, 2, 6)
		Me.TableLayoutPanel1.Controls.Add(Me.RaisedToTb, 2, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.StatusTb, 2, 5)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 8
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(713, 276)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(3, 200)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(94, 76)
		Me.Label1.TabIndex = 28
		Me.Label1.Text = "Description"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(3, 150)
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
		Me.Label6.Location = New System.Drawing.Point(3, 125)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(94, 25)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Raised to"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(3, 100)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(94, 25)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Raised date"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'HeaderLabel
		'
		Me.HeaderLabel.AutoSize = True
		Me.HeaderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.TableLayoutPanel1.SetColumnSpan(Me.HeaderLabel, 3)
		Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
		Me.HeaderLabel.Location = New System.Drawing.Point(3, 0)
		Me.HeaderLabel.Name = "HeaderLabel"
		Me.HeaderLabel.Size = New System.Drawing.Size(707, 50)
		Me.HeaderLabel.TabIndex = 0
		Me.HeaderLabel.Text = "CAR Details"
		Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(3, 75)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 25)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Raised by"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'RaisedByCombo
		'
		Me.RaisedByCombo.DataSource = Me.UsersBindingSource
		Me.RaisedByCombo.DisplayMember = "Fullname"
		Me.RaisedByCombo.Enabled = False
		Me.RaisedByCombo.FormattingEnabled = True
		Me.RaisedByCombo.Location = New System.Drawing.Point(124, 78)
		Me.RaisedByCombo.Name = "RaisedByCombo"
		Me.RaisedByCombo.Size = New System.Drawing.Size(121, 23)
		Me.RaisedByCombo.TabIndex = 16
		Me.RaisedByCombo.ValueMember = "Id"
		'
		'UsersBindingSource
		'
		Me.UsersBindingSource.DataMember = "Users"
		Me.UsersBindingSource.DataSource = Me.DataSet1
		'
		'DataSet1
		'
		Me.DataSet1.DataSetName = "DataSet1"
		Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'RaisedDatePicker
		'
		Me.RaisedDatePicker.Enabled = False
		Me.RaisedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.RaisedDatePicker.Location = New System.Drawing.Point(124, 103)
		Me.RaisedDatePicker.Name = "RaisedDatePicker"
		Me.RaisedDatePicker.Size = New System.Drawing.Size(121, 21)
		Me.RaisedDatePicker.TabIndex = 17
		'
		'DescriptionTB
		'
		Me.DescriptionTB.AcceptsReturn = True
		Me.DescriptionTB.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DescriptionTB.Location = New System.Drawing.Point(124, 203)
		Me.DescriptionTB.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
		Me.DescriptionTB.MaxLength = 500
		Me.DescriptionTB.Multiline = True
		Me.DescriptionTB.Name = "DescriptionTB"
		Me.DescriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.DescriptionTB.Size = New System.Drawing.Size(579, 70)
		Me.DescriptionTB.TabIndex = 2
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label3.Location = New System.Drawing.Point(3, 50)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(94, 25)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "Id"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TextBox1
		'
		Me.TextBox1.Enabled = False
		Me.TextBox1.Location = New System.Drawing.Point(124, 53)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(42, 21)
		Me.TextBox1.TabIndex = 31
		Me.TextBox1.Text = "-"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label4.Location = New System.Drawing.Point(3, 175)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(94, 25)
		Me.Label4.TabIndex = 32
		Me.Label4.Text = "Title"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TitleTb
		'
		Me.TitleTb.Location = New System.Drawing.Point(124, 178)
		Me.TitleTb.Name = "TitleTb"
		Me.TitleTb.Size = New System.Drawing.Size(330, 21)
		Me.TitleTb.TabIndex = 1
		'
		'RaisedToTb
		'
		Me.RaisedToTb.Enabled = False
		Me.RaisedToTb.Location = New System.Drawing.Point(124, 128)
		Me.RaisedToTb.Name = "RaisedToTb"
		Me.RaisedToTb.Size = New System.Drawing.Size(121, 21)
		Me.RaisedToTb.TabIndex = 34
		'
		'StatusTb
		'
		Me.StatusTb.Enabled = False
		Me.StatusTb.Location = New System.Drawing.Point(124, 153)
		Me.StatusTb.Name = "StatusTb"
		Me.StatusTb.Size = New System.Drawing.Size(330, 21)
		Me.StatusTb.TabIndex = 35
		'
		'UsersBindingSource1
		'
		Me.UsersBindingSource1.AllowNew = False
		Me.UsersBindingSource1.DataMember = "Users"
		Me.UsersBindingSource1.DataSource = Me.DataSet1
		'
		'NCRStatusBindingSource
		'
		Me.NCRStatusBindingSource.DataMember = "NCR_Status1"
		Me.NCRStatusBindingSource.DataSource = Me.DataSet1
		'
		'DataSet1BindingSource
		'
		Me.DataSet1BindingSource.DataSource = Me.DataSet1
		Me.DataSet1BindingSource.Position = 0
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.CancelBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.OkBtn)
		Me.FlowLayoutPanel1.Controls.Add(Me.CreateBtn)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 276)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 3, 3, 0)
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(713, 38)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'CancelBtn
		'
		Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelBtn.Location = New System.Drawing.Point(632, 6)
		Me.CancelBtn.Name = "CancelBtn"
		Me.CancelBtn.Size = New System.Drawing.Size(75, 25)
		Me.CancelBtn.TabIndex = 0
		Me.CancelBtn.Text = "Cancel"
		Me.CancelBtn.UseVisualStyleBackColor = True
		'
		'OkBtn
		'
		Me.OkBtn.Location = New System.Drawing.Point(551, 6)
		Me.OkBtn.Name = "OkBtn"
		Me.OkBtn.Size = New System.Drawing.Size(75, 25)
		Me.OkBtn.TabIndex = 1
		Me.OkBtn.Text = "OK"
		Me.OkBtn.UseVisualStyleBackColor = True
		'
		'CreateBtn
		'
		Me.CreateBtn.Location = New System.Drawing.Point(470, 6)
		Me.CreateBtn.Name = "CreateBtn"
		Me.CreateBtn.Size = New System.Drawing.Size(75, 25)
		Me.CreateBtn.TabIndex = 2
		Me.CreateBtn.Text = "Create"
		Me.CreateBtn.UseVisualStyleBackColor = True
		'
		'NCR_StatusTableAdapter
		'
		Me.NCR_StatusTableAdapter.ClearBeforeFill = True
		'
		'TtmsDataSet1
		'
		Me.TtmsDataSet1.DataSetName = "TTMSDataSet"
		Me.TtmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'UsersTableAdapter
		'
		Me.UsersTableAdapter.ClearBeforeFill = True
		'
		'NewCARForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.CancelBtn
		Me.ClientSize = New System.Drawing.Size(713, 314)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Name = "NewCARForm"
		Me.Text = "CAR Details"
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.UsersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NCRStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		CType(Me.TtmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents HeaderLabel As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents RaisedByCombo As System.Windows.Forms.ComboBox
	Friend WithEvents RaisedDatePicker As System.Windows.Forms.DateTimePicker
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents CancelBtn As System.Windows.Forms.Button
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents CreateBtn As System.Windows.Forms.Button
	Friend WithEvents DataSet1 As TTMS.TTMSDataSet
	Friend WithEvents UsersTableAdapter As TTMS.TTMSDataSetTableAdapters.UsersTableAdapter
	Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents NCRStatusBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents NCR_StatusTableAdapter As TTMS.TTMSDataSetTableAdapters.NCR_Status1TableAdapter
	Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents UsersBindingSource1 As System.Windows.Forms.BindingSource
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents DescriptionTB As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents OkBtn As System.Windows.Forms.Button
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents TitleTb As System.Windows.Forms.TextBox
	Friend WithEvents RaisedToTb As System.Windows.Forms.TextBox
	Friend WithEvents StatusTb As System.Windows.Forms.TextBox
	Friend WithEvents TtmsDataSet1 As TTMS.TTMSDataSet
End Class
