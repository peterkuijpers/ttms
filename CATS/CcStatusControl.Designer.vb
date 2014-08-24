<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CcStatusControl
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.ActionFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.UserCb = New System.Windows.Forms.ComboBox()
		Me.GroupBox1.SuspendLayout()
		Me.ActionFlowPanel.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.ActionFlowPanel)
		Me.GroupBox1.Controls.Add(Me.UserCb)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(293, 171)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "CC Actions"
		'
		'ActionFlowPanel
		'
		Me.ActionFlowPanel.Controls.Add(Me.Button1)
		Me.ActionFlowPanel.Dock = System.Windows.Forms.DockStyle.Left
		Me.ActionFlowPanel.Location = New System.Drawing.Point(3, 16)
		Me.ActionFlowPanel.Name = "ActionFlowPanel"
		Me.ActionFlowPanel.Size = New System.Drawing.Size(157, 152)
		Me.ActionFlowPanel.TabIndex = 5
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(3, 3)
		Me.Button1.MaximumSize = New System.Drawing.Size(150, 0)
		Me.Button1.MinimumSize = New System.Drawing.Size(150, 25)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(150, 25)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'UserCb
		'
		Me.UserCb.FormattingEnabled = True
		Me.UserCb.Items.AddRange(New Object() {"Alice", "Ben", "Charlie"})
		Me.UserCb.Location = New System.Drawing.Point(169, 25)
		Me.UserCb.Name = "UserCb"
		Me.UserCb.Size = New System.Drawing.Size(109, 21)
		Me.UserCb.TabIndex = 4
		'
		'CcStatusControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "CcStatusControl"
		Me.Size = New System.Drawing.Size(293, 171)
		Me.GroupBox1.ResumeLayout(False)
		Me.ActionFlowPanel.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents ActionFlowPanel As System.Windows.Forms.FlowLayoutPanel
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents UserCb As System.Windows.Forms.ComboBox

End Class
