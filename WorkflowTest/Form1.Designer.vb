<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusTb = New System.Windows.Forms.Label()
		Me.StatusMessageTb = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.CreatedByTb = New System.Windows.Forms.Label()
		Me.AssignedToTb = New System.Windows.Forms.Label()
		Me.DelegatedToTb = New System.Windows.Forms.Label()
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.StatCntr = New WorkflowTest.StatusControl()
		Me.GroupBox2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(37, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Status"
		'
		'StatusTb
		'
		Me.StatusTb.AutoSize = True
		Me.StatusTb.Location = New System.Drawing.Point(104, 60)
		Me.StatusTb.Name = "StatusTb"
		Me.StatusTb.Size = New System.Drawing.Size(35, 13)
		Me.StatusTb.TabIndex = 1
		Me.StatusTb.Text = "status"
		'
		'StatusMessageTb
		'
		Me.StatusMessageTb.AutoSize = True
		Me.StatusMessageTb.Location = New System.Drawing.Point(104, 80)
		Me.StatusMessageTb.Name = "StatusMessageTb"
		Me.StatusMessageTb.Size = New System.Drawing.Size(35, 13)
		Me.StatusMessageTb.TabIndex = 3
		Me.StatusMessageTb.Text = "status"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 80)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(83, 13)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Status Message"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(359, 212)
		Me.GroupBox2.TabIndex = 6
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "CATS Details"
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68608!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.31392!))
		Me.TableLayoutPanel1.Controls.Add(Me.DelegatedToTb, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.AssignedToTb, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.StatusMessageTb, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.CreatedByTb, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.StatusTb, 1, 3)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(26, 24)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 5
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(309, 101)
		Me.TableLayoutPanel1.TabIndex = 0
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 13)
		Me.Label2.TabIndex = 0
		Me.Label2.Text = "Created By"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 20)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(62, 13)
		Me.Label5.TabIndex = 2
		Me.Label5.Text = "Assigned to"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(3, 40)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(68, 13)
		Me.Label7.TabIndex = 4
		Me.Label7.Text = "Delegated to"
		'
		'CreatedByTb
		'
		Me.CreatedByTb.AutoSize = True
		Me.CreatedByTb.Location = New System.Drawing.Point(104, 0)
		Me.CreatedByTb.Name = "CreatedByTb"
		Me.CreatedByTb.Size = New System.Drawing.Size(69, 13)
		Me.CreatedByTb.TabIndex = 5
		Me.CreatedByTb.Text = "CreatedByTb"
		'
		'AssignedToTb
		'
		Me.AssignedToTb.AutoSize = True
		Me.AssignedToTb.Location = New System.Drawing.Point(104, 20)
		Me.AssignedToTb.Name = "AssignedToTb"
		Me.AssignedToTb.Size = New System.Drawing.Size(39, 13)
		Me.AssignedToTb.TabIndex = 6
		Me.AssignedToTb.Text = "Label6"
		'
		'DelegatedToTb
		'
		Me.DelegatedToTb.AutoSize = True
		Me.DelegatedToTb.Location = New System.Drawing.Point(104, 40)
		Me.DelegatedToTb.Name = "DelegatedToTb"
		Me.DelegatedToTb.Size = New System.Drawing.Size(39, 13)
		Me.DelegatedToTb.TabIndex = 7
		Me.DelegatedToTb.Text = "Label8"
		'
		'CloseBtn
		'
		Me.CloseBtn.Location = New System.Drawing.Point(553, 223)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
		Me.CloseBtn.TabIndex = 7
		Me.CloseBtn.Text = "Close"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'StatCntr
		'
		Me.StatCntr.Location = New System.Drawing.Point(377, 12)
		Me.StatCntr.Name = "StatCntr"
		Me.StatCntr.Size = New System.Drawing.Size(296, 143)
		Me.StatCntr.TabIndex = 8
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(738, 341)
		Me.Controls.Add(Me.StatCntr)
		Me.Controls.Add(Me.CloseBtn)
		Me.Controls.Add(Me.GroupBox2)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox2.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents StatusTb As System.Windows.Forms.Label
	Friend WithEvents StatusMessageTb As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents DelegatedToTb As System.Windows.Forms.Label
	Friend WithEvents AssignedToTb As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents CreatedByTb As System.Windows.Forms.Label
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
	Friend WithEvents StatCntr As WorkflowTest.StatusControl

End Class
