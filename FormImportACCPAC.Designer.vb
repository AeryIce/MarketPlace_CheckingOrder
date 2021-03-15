<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportACCPAC
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
		Me.gbImport = New System.Windows.Forms.GroupBox()
		Me.cbMP = New System.Windows.Forms.ComboBox()
		Me.pnMinimizeMaximizeClose = New System.Windows.Forms.Panel()
		Me.btClose = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.btMinimize = New System.Windows.Forms.Button()
		Me.btImport = New System.Windows.Forms.Button()
		Me.gbImport.SuspendLayout()
		Me.pnMinimizeMaximizeClose.SuspendLayout()
		Me.SuspendLayout()
		'
		'gbImport
		'
		Me.gbImport.Controls.Add(Me.cbMP)
		Me.gbImport.Controls.Add(Me.btImport)
		Me.gbImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbImport.Location = New System.Drawing.Point(275, 149)
		Me.gbImport.Name = "gbImport"
		Me.gbImport.Size = New System.Drawing.Size(240, 160)
		Me.gbImport.TabIndex = 1
		Me.gbImport.TabStop = False
		'
		'cbMP
		'
		Me.cbMP.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbMP.FormattingEnabled = True
		Me.cbMP.Location = New System.Drawing.Point(48, 66)
		Me.cbMP.Name = "cbMP"
		Me.cbMP.Size = New System.Drawing.Size(142, 33)
		Me.cbMP.TabIndex = 1
		'
		'pnMinimizeMaximizeClose
		'
		Me.pnMinimizeMaximizeClose.BackColor = System.Drawing.Color.Tomato
		Me.pnMinimizeMaximizeClose.Controls.Add(Me.btClose)
		Me.pnMinimizeMaximizeClose.Controls.Add(Me.btMaximize)
		Me.pnMinimizeMaximizeClose.Controls.Add(Me.btMinimize)
		Me.pnMinimizeMaximizeClose.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnMinimizeMaximizeClose.Location = New System.Drawing.Point(0, 0)
		Me.pnMinimizeMaximizeClose.Name = "pnMinimizeMaximizeClose"
		Me.pnMinimizeMaximizeClose.Size = New System.Drawing.Size(800, 42)
		Me.pnMinimizeMaximizeClose.TabIndex = 2
		'
		'btClose
		'
		Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btClose.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.close_window_32px1
		Me.btClose.Location = New System.Drawing.Point(765, 5)
		Me.btClose.Name = "btClose"
		Me.btClose.Size = New System.Drawing.Size(33, 31)
		Me.btClose.TabIndex = 5
		Me.btClose.UseVisualStyleBackColor = True
		'
		'btMaximize
		'
		Me.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMaximize.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.maximize_window_32px
		Me.btMaximize.Location = New System.Drawing.Point(726, 5)
		Me.btMaximize.Name = "btMaximize"
		Me.btMaximize.Size = New System.Drawing.Size(33, 31)
		Me.btMaximize.TabIndex = 4
		Me.btMaximize.UseVisualStyleBackColor = True
		'
		'btMinimize
		'
		Me.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMinimize.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.minimize_window_32px
		Me.btMinimize.Location = New System.Drawing.Point(687, 5)
		Me.btMinimize.Name = "btMinimize"
		Me.btMinimize.Size = New System.Drawing.Size(33, 31)
		Me.btMinimize.TabIndex = 3
		Me.btMinimize.UseVisualStyleBackColor = True
		'
		'btImport
		'
		Me.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btImport.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.cloud_sync_30px
		Me.btImport.Location = New System.Drawing.Point(83, 105)
		Me.btImport.Name = "btImport"
		Me.btImport.Size = New System.Drawing.Size(77, 34)
		Me.btImport.TabIndex = 0
		Me.btImport.UseVisualStyleBackColor = True
		'
		'FormImportACCPAC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Teal
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.pnMinimizeMaximizeClose)
		Me.Controls.Add(Me.gbImport)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormImportACCPAC"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormImportACCPAC"
		Me.gbImport.ResumeLayout(False)
		Me.pnMinimizeMaximizeClose.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btImport As Button
	Friend WithEvents gbImport As GroupBox
	Friend WithEvents cbMP As ComboBox
	Friend WithEvents pnMinimizeMaximizeClose As Panel
	Friend WithEvents btMinimize As Button
	Friend WithEvents btMaximize As Button
	Friend WithEvents btClose As Button
End Class
