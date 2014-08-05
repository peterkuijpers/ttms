<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DotsForm
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
		Me.CloseBtn = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'CloseBtn
		'
		Me.CloseBtn.Location = New System.Drawing.Point(191, 207)
		Me.CloseBtn.Name = "CloseBtn"
		Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
		Me.CloseBtn.TabIndex = 0
		Me.CloseBtn.Text = "Close"
		Me.CloseBtn.UseVisualStyleBackColor = True
		'
		'DotsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.CloseBtn)
		Me.Name = "DotsForm"
		Me.Text = "DotsForm"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents CloseBtn As System.Windows.Forms.Button
End Class
