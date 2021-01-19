<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
		Me.PnMenu = New System.Windows.Forms.Panel()
		Me.PnBtOrder = New System.Windows.Forms.Panel()
		Me.PnBtOrderHover = New System.Windows.Forms.Panel()
		Me.BtOrder = New System.Windows.Forms.Button()
		Me.PnBtHome = New System.Windows.Forms.Panel()
		Me.PnBtHomeHover = New System.Windows.Forms.Panel()
		Me.BtHome = New System.Windows.Forms.Button()
		Me.PnHeader = New System.Windows.Forms.Panel()
		Me.LbHeader2 = New System.Windows.Forms.Label()
		Me.LbHeader1 = New System.Windows.Forms.Label()
		Me.PnBanner = New System.Windows.Forms.Panel()
		Me.PnForm = New System.Windows.Forms.Panel()
		Me.BtClose = New System.Windows.Forms.Button()
		Me.BtMaximize = New System.Windows.Forms.Button()
		Me.BtMinimize = New System.Windows.Forms.Button()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.PnMenu.SuspendLayout()
		Me.PnBtOrder.SuspendLayout()
		Me.PnBtHome.SuspendLayout()
		Me.PnHeader.SuspendLayout()
		Me.PnForm.SuspendLayout()
		Me.SuspendLayout()
		'
		'PnMenu
		'
		Me.PnMenu.BackColor = System.Drawing.Color.DarkBlue
		Me.PnMenu.Controls.Add(Me.PnBtOrder)
		Me.PnMenu.Controls.Add(Me.PnBtHome)
		Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.PnMenu.Location = New System.Drawing.Point(0, 0)
		Me.PnMenu.Name = "PnMenu"
		Me.PnMenu.Size = New System.Drawing.Size(122, 521)
		Me.PnMenu.TabIndex = 0
		'
		'PnBtOrder
		'
		Me.PnBtOrder.BackColor = System.Drawing.Color.Transparent
		Me.PnBtOrder.Controls.Add(Me.PnBtOrderHover)
		Me.PnBtOrder.Controls.Add(Me.BtOrder)
		Me.PnBtOrder.Location = New System.Drawing.Point(2, 195)
		Me.PnBtOrder.Name = "PnBtOrder"
		Me.PnBtOrder.Size = New System.Drawing.Size(116, 37)
		Me.PnBtOrder.TabIndex = 4
		'
		'PnBtOrderHover
		'
		Me.PnBtOrderHover.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.PnBtOrderHover.Location = New System.Drawing.Point(-1, 0)
		Me.PnBtOrderHover.Name = "PnBtOrderHover"
		Me.PnBtOrderHover.Size = New System.Drawing.Size(11, 38)
		Me.PnBtOrderHover.TabIndex = 3
		'
		'BtOrder
		'
		Me.BtOrder.BackColor = System.Drawing.Color.Navy
		Me.BtOrder.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.handle_with_care_30px
		Me.BtOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BtOrder.FlatAppearance.BorderSize = 0
		Me.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtOrder.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.BtOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtOrder.Location = New System.Drawing.Point(9, -1)
		Me.BtOrder.Name = "BtOrder"
		Me.BtOrder.Size = New System.Drawing.Size(111, 38)
		Me.BtOrder.TabIndex = 3
		Me.BtOrder.Text = "    Order"
		Me.BtOrder.UseVisualStyleBackColor = False
		'
		'PnBtHome
		'
		Me.PnBtHome.BackColor = System.Drawing.Color.Transparent
		Me.PnBtHome.Controls.Add(Me.PnBtHomeHover)
		Me.PnBtHome.Controls.Add(Me.BtHome)
		Me.PnBtHome.Location = New System.Drawing.Point(2, 152)
		Me.PnBtHome.Name = "PnBtHome"
		Me.PnBtHome.Size = New System.Drawing.Size(116, 37)
		Me.PnBtHome.TabIndex = 3
		'
		'PnBtHomeHover
		'
		Me.PnBtHomeHover.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.PnBtHomeHover.Location = New System.Drawing.Point(-1, 0)
		Me.PnBtHomeHover.Name = "PnBtHomeHover"
		Me.PnBtHomeHover.Size = New System.Drawing.Size(11, 38)
		Me.PnBtHomeHover.TabIndex = 3
		'
		'BtHome
		'
		Me.BtHome.BackColor = System.Drawing.Color.Navy
		Me.BtHome.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.home_32px
		Me.BtHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BtHome.FlatAppearance.BorderSize = 0
		Me.BtHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtHome.ForeColor = System.Drawing.Color.WhiteSmoke
		Me.BtHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtHome.Location = New System.Drawing.Point(9, -1)
		Me.BtHome.Name = "BtHome"
		Me.BtHome.Size = New System.Drawing.Size(111, 39)
		Me.BtHome.TabIndex = 3
		Me.BtHome.Text = "    Home"
		Me.BtHome.UseVisualStyleBackColor = False
		'
		'PnHeader
		'
		Me.PnHeader.BackColor = System.Drawing.Color.DarkBlue
		Me.PnHeader.Controls.Add(Me.LbHeader2)
		Me.PnHeader.Controls.Add(Me.LbHeader1)
		Me.PnHeader.Controls.Add(Me.PnBanner)
		Me.PnHeader.Location = New System.Drawing.Point(122, 23)
		Me.PnHeader.Name = "PnHeader"
		Me.PnHeader.Size = New System.Drawing.Size(812, 122)
		Me.PnHeader.TabIndex = 1
		'
		'LbHeader2
		'
		Me.LbHeader2.AutoSize = True
		Me.LbHeader2.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbHeader2.ForeColor = System.Drawing.Color.White
		Me.LbHeader2.Location = New System.Drawing.Point(304, 54)
		Me.LbHeader2.Name = "LbHeader2"
		Me.LbHeader2.Size = New System.Drawing.Size(289, 36)
		Me.LbHeader2.TabIndex = 4
		Me.LbHeader2.Text = "Div. MarketPlace"
		'
		'LbHeader1
		'
		Me.LbHeader1.AutoSize = True
		Me.LbHeader1.Font = New System.Drawing.Font("Lucida Bright", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbHeader1.ForeColor = System.Drawing.Color.White
		Me.LbHeader1.Location = New System.Drawing.Point(355, 14)
		Me.LbHeader1.Name = "LbHeader1"
		Me.LbHeader1.Size = New System.Drawing.Size(187, 40)
		Me.LbHeader1.TabIndex = 3
		Me.LbHeader1.Text = "PERIPLUS"
		'
		'PnBanner
		'
		Me.PnBanner.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.L_w__pLOVR_oOhAj_1842_periplus_1522833402_1
		Me.PnBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PnBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PnBanner.Location = New System.Drawing.Point(0, 8)
		Me.PnBanner.Name = "PnBanner"
		Me.PnBanner.Size = New System.Drawing.Size(106, 103)
		Me.PnBanner.TabIndex = 2
		'
		'PnForm
		'
		Me.PnForm.Controls.Add(Me.BtClose)
		Me.PnForm.Controls.Add(Me.BtMaximize)
		Me.PnForm.Controls.Add(Me.BtMinimize)
		Me.PnForm.Dock = System.Windows.Forms.DockStyle.Top
		Me.PnForm.Location = New System.Drawing.Point(122, 0)
		Me.PnForm.Name = "PnForm"
		Me.PnForm.Size = New System.Drawing.Size(812, 23)
		Me.PnForm.TabIndex = 2
		'
		'BtClose
		'
		Me.BtClose.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.close_window_24px
		Me.BtClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.BtClose.FlatAppearance.BorderSize = 0
		Me.BtClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtClose.Location = New System.Drawing.Point(782, 0)
		Me.BtClose.Name = "BtClose"
		Me.BtClose.Size = New System.Drawing.Size(25, 20)
		Me.BtClose.TabIndex = 5
		Me.BtClose.UseVisualStyleBackColor = True
		'
		'BtMaximize
		'
		Me.BtMaximize.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.maximize_window_32px
		Me.BtMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.BtMaximize.FlatAppearance.BorderSize = 0
		Me.BtMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtMaximize.Location = New System.Drawing.Point(750, 0)
		Me.BtMaximize.Name = "BtMaximize"
		Me.BtMaximize.Size = New System.Drawing.Size(25, 20)
		Me.BtMaximize.TabIndex = 4
		Me.BtMaximize.UseVisualStyleBackColor = True
		'
		'BtMinimize
		'
		Me.BtMinimize.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.minimize_window_32px
		Me.BtMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.BtMinimize.FlatAppearance.BorderSize = 0
		Me.BtMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtMinimize.Location = New System.Drawing.Point(718, 0)
		Me.BtMinimize.Name = "BtMinimize"
		Me.BtMinimize.Size = New System.Drawing.Size(25, 20)
		Me.BtMinimize.TabIndex = 3
		Me.BtMinimize.UseVisualStyleBackColor = True
		'
		'Panel1
		'
		Me.Panel1.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.Developing_soon__
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Panel1.Location = New System.Drawing.Point(128, 152)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(801, 357)
		Me.Panel1.TabIndex = 3
		'
		'FormHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Lavender
		Me.ClientSize = New System.Drawing.Size(934, 521)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.PnForm)
		Me.Controls.Add(Me.PnHeader)
		Me.Controls.Add(Me.PnMenu)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormHome"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormHome"
		Me.PnMenu.ResumeLayout(False)
		Me.PnBtOrder.ResumeLayout(False)
		Me.PnBtHome.ResumeLayout(False)
		Me.PnHeader.ResumeLayout(False)
		Me.PnHeader.PerformLayout()
		Me.PnForm.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PnMenu As Panel
	Friend WithEvents PnHeader As Panel
	Friend WithEvents PnBanner As Panel
	Friend WithEvents LbHeader1 As Label
	Friend WithEvents PnForm As Panel
	Friend WithEvents BtMinimize As Button
	Friend WithEvents BtMaximize As Button
	Friend WithEvents BtClose As Button
	Friend WithEvents LbHeader2 As Label
	Friend WithEvents PnBtHome As Panel
	Friend WithEvents BtHome As Button
	Friend WithEvents PnBtHomeHover As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents PnBtOrder As Panel
	Friend WithEvents PnBtOrderHover As Panel
	Friend WithEvents BtOrder As Button
End Class
