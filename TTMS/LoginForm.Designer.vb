<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.LoginBtn = New System.Windows.Forms.Button()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.UserIdTb = New System.Windows.Forms.TextBox()
		Me.PwdTb = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.MySqlDataSet1 = New MySqlDataSet()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.MySqlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.LoginBtn)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 141)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(328, 36)
		Me.FlowLayoutPanel1.TabIndex = 1
		'
		'LoginBtn
		'
		Me.LoginBtn.Location = New System.Drawing.Point(245, 8)
		Me.LoginBtn.Name = "LoginBtn"
		Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
		Me.LoginBtn.TabIndex = 0
		Me.LoginBtn.Text = "Login"
		Me.LoginBtn.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.73723!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.26278!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.UserIdTb, 2, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.PwdTb, 2, 1)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 35)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(299, 72)
		Me.TableLayoutPanel1.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label1.Location = New System.Drawing.Point(37, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 36)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "User id"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
		Me.Label2.Location = New System.Drawing.Point(24, 36)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 36)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Password"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'UserIdTb
		'
		Me.UserIdTb.Dock = System.Windows.Forms.DockStyle.Left
		Me.UserIdTb.Location = New System.Drawing.Point(91, 10)
		Me.UserIdTb.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
		Me.UserIdTb.Name = "UserIdTb"
		Me.UserIdTb.Size = New System.Drawing.Size(128, 20)
		Me.UserIdTb.TabIndex = 2
		Me.UserIdTb.Text = "pkuijp1"
		'
		'PwdTb
		'
		Me.PwdTb.Dock = System.Windows.Forms.DockStyle.Left
		Me.PwdTb.Location = New System.Drawing.Point(91, 46)
		Me.PwdTb.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
		Me.PwdTb.Name = "PwdTb"
		Me.PwdTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.PwdTb.Size = New System.Drawing.Size(76, 20)
		Me.PwdTb.TabIndex = 3
		Me.PwdTb.Text = "pkp123"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(18, 5)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(221, 20)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Login into the TTMS portal"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 119)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(328, 22)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 4
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'MySqlDataSet1
		'
		Me.MySqlDataSet1.DataSetName = "MySqlDataSet"
		Me.MySqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'LoginForm
		'
		Me.AcceptButton = Me.LoginBtn
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.ClientSize = New System.Drawing.Size(328, 177)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "LoginForm"
		Me.Text = "Login"
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		CType(Me.MySqlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents LoginBtn As System.Windows.Forms.Button
	Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents UserIdTb As System.Windows.Forms.TextBox
	Friend WithEvents PwdTb As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents MySqlDataSet1 As MySqlDataSet
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
