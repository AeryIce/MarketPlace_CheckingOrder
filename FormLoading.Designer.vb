<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
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
		Me.PbLoding = New System.Windows.Forms.ProgressBar()
		Me.LbStatusLoading = New System.Windows.Forms.Label()
		Me.LbFinishLoading = New System.Windows.Forms.Label()
		Me.TmLoding = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'PbLoding
		'
		Me.PbLoding.Location = New System.Drawing.Point(12, 48)
		Me.PbLoding.Name = "PbLoding"
		Me.PbLoding.Size = New System.Drawing.Size(439, 23)
		Me.PbLoding.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.PbLoding.TabIndex = 0
		'
		'LbStatusLoading
		'
		Me.LbStatusLoading.AutoSize = True
		Me.LbStatusLoading.Location = New System.Drawing.Point(12, 22)
		Me.LbStatusLoading.Name = "LbStatusLoading"
		Me.LbStatusLoading.Size = New System.Drawing.Size(22, 13)
		Me.LbStatusLoading.TabIndex = 1
		Me.LbStatusLoading.Text = "xxx"
		'
		'LbFinishLoading
		'
		Me.LbFinishLoading.AutoSize = True
		Me.LbFinishLoading.Location = New System.Drawing.Point(383, 74)
		Me.LbFinishLoading.Name = "LbFinishLoading"
		Me.LbFinishLoading.Size = New System.Drawing.Size(22, 13)
		Me.LbFinishLoading.TabIndex = 2
		Me.LbFinishLoading.Text = "xxx"
		'
		'TmLoding
		'
		'
		'FormLoading
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(463, 94)
		Me.Controls.Add(Me.LbFinishLoading)
		Me.Controls.Add(Me.LbStatusLoading)
		Me.Controls.Add(Me.PbLoding)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLoading"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormLoading"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PbLoding As ProgressBar
	Friend WithEvents LbStatusLoading As Label
	Friend WithEvents LbFinishLoading As Label
	Friend WithEvents TmLoding As Timer
End Class
