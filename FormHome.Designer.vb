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
		Me.PbPeriplus = New System.Windows.Forms.PictureBox()
		Me.PnMenuNow = New System.Windows.Forms.Panel()
		Me.PnbtAdmin = New System.Windows.Forms.Panel()
		Me.BtAdmin = New System.Windows.Forms.Button()
		Me.PnBtOrder = New System.Windows.Forms.Panel()
		Me.BtOrder = New System.Windows.Forms.Button()
		Me.PnBtHome = New System.Windows.Forms.Panel()
		Me.BtHome = New System.Windows.Forms.Button()
		Me.PnHeaderButton = New System.Windows.Forms.Panel()
		Me.PnHeader = New System.Windows.Forms.Panel()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PnDisplay = New System.Windows.Forms.Panel()
		Me.PnMenu.SuspendLayout()
		CType(Me.PbPeriplus, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PnbtAdmin.SuspendLayout()
		Me.PnBtOrder.SuspendLayout()
		Me.PnBtHome.SuspendLayout()
		Me.PnHeader.SuspendLayout()
		Me.SuspendLayout()
		'
		'PnMenu
		'
		Me.PnMenu.BackColor = System.Drawing.Color.MidnightBlue
		Me.PnMenu.Controls.Add(Me.PbPeriplus)
		Me.PnMenu.Controls.Add(Me.PnMenuNow)
		Me.PnMenu.Controls.Add(Me.PnbtAdmin)
		Me.PnMenu.Controls.Add(Me.PnBtOrder)
		Me.PnMenu.Controls.Add(Me.PnBtHome)
		Me.PnMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.PnMenu.Location = New System.Drawing.Point(0, 0)
		Me.PnMenu.Name = "PnMenu"
		Me.PnMenu.Size = New System.Drawing.Size(138, 680)
		Me.PnMenu.TabIndex = 0
		'
		'PbPeriplus
		'
		Me.PbPeriplus.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.L_w__pLOVR_oOhAj_1842_periplus_1522833402_1
		Me.PbPeriplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PbPeriplus.Location = New System.Drawing.Point(4, 23)
		Me.PbPeriplus.Name = "PbPeriplus"
		Me.PbPeriplus.Size = New System.Drawing.Size(131, 118)
		Me.PbPeriplus.TabIndex = 3
		Me.PbPeriplus.TabStop = False
		'
		'PnMenuNow
		'
		Me.PnMenuNow.BackColor = System.Drawing.Color.LightBlue
		Me.PnMenuNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PnMenuNow.Location = New System.Drawing.Point(48, 157)
		Me.PnMenuNow.Name = "PnMenuNow"
		Me.PnMenuNow.Size = New System.Drawing.Size(45, 48)
		Me.PnMenuNow.TabIndex = 3
		'
		'PnbtAdmin
		'
		Me.PnbtAdmin.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PnbtAdmin.Controls.Add(Me.BtAdmin)
		Me.PnbtAdmin.Location = New System.Drawing.Point(4, 288)
		Me.PnbtAdmin.Name = "PnbtAdmin"
		Me.PnbtAdmin.Size = New System.Drawing.Size(131, 30)
		Me.PnbtAdmin.TabIndex = 5
		'
		'BtAdmin
		'
		Me.BtAdmin.BackColor = System.Drawing.Color.DarkBlue
		Me.BtAdmin.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.administrator_male_32px
		Me.BtAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BtAdmin.FlatAppearance.BorderSize = 0
		Me.BtAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtAdmin.ForeColor = System.Drawing.Color.White
		Me.BtAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtAdmin.Location = New System.Drawing.Point(14, 0)
		Me.BtAdmin.Name = "BtAdmin"
		Me.BtAdmin.Size = New System.Drawing.Size(103, 30)
		Me.BtAdmin.TabIndex = 3
		Me.BtAdmin.Text = "Admin"
		Me.BtAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.BtAdmin.UseVisualStyleBackColor = False
		'
		'PnBtOrder
		'
		Me.PnBtOrder.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PnBtOrder.Controls.Add(Me.BtOrder)
		Me.PnBtOrder.Location = New System.Drawing.Point(4, 259)
		Me.PnBtOrder.Name = "PnBtOrder"
		Me.PnBtOrder.Size = New System.Drawing.Size(131, 30)
		Me.PnBtOrder.TabIndex = 4
		'
		'BtOrder
		'
		Me.BtOrder.BackColor = System.Drawing.Color.DarkBlue
		Me.BtOrder.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.shopping_cart_32px
		Me.BtOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BtOrder.FlatAppearance.BorderSize = 0
		Me.BtOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtOrder.ForeColor = System.Drawing.Color.White
		Me.BtOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtOrder.Location = New System.Drawing.Point(14, 0)
		Me.BtOrder.Name = "BtOrder"
		Me.BtOrder.Size = New System.Drawing.Size(103, 30)
		Me.BtOrder.TabIndex = 3
		Me.BtOrder.Text = "Orders"
		Me.BtOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.BtOrder.UseVisualStyleBackColor = False
		'
		'PnBtHome
		'
		Me.PnBtHome.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PnBtHome.Controls.Add(Me.BtHome)
		Me.PnBtHome.Location = New System.Drawing.Point(4, 229)
		Me.PnBtHome.Name = "PnBtHome"
		Me.PnBtHome.Size = New System.Drawing.Size(131, 30)
		Me.PnBtHome.TabIndex = 3
		'
		'BtHome
		'
		Me.BtHome.BackColor = System.Drawing.Color.DarkBlue
		Me.BtHome.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.home_32px_White
		Me.BtHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BtHome.FlatAppearance.BorderSize = 0
		Me.BtHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtHome.ForeColor = System.Drawing.Color.White
		Me.BtHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.BtHome.Location = New System.Drawing.Point(14, 0)
		Me.BtHome.Name = "BtHome"
		Me.BtHome.Size = New System.Drawing.Size(103, 30)
		Me.BtHome.TabIndex = 3
		Me.BtHome.Text = "Beranda"
		Me.BtHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.BtHome.UseVisualStyleBackColor = False
		'
		'PnHeaderButton
		'
		Me.PnHeaderButton.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PnHeaderButton.Dock = System.Windows.Forms.DockStyle.Top
		Me.PnHeaderButton.Location = New System.Drawing.Point(138, 0)
		Me.PnHeaderButton.Name = "PnHeaderButton"
		Me.PnHeaderButton.Size = New System.Drawing.Size(862, 20)
		Me.PnHeaderButton.TabIndex = 1
		'
		'PnHeader
		'
		Me.PnHeader.BackColor = System.Drawing.Color.MidnightBlue
		Me.PnHeader.Controls.Add(Me.Label2)
		Me.PnHeader.Controls.Add(Me.Label1)
		Me.PnHeader.Location = New System.Drawing.Point(138, 20)
		Me.PnHeader.Name = "PnHeader"
		Me.PnHeader.Size = New System.Drawing.Size(862, 123)
		Me.PnHeader.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.AliceBlue
		Me.Label2.Location = New System.Drawing.Point(462, 49)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(179, 72)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "PT. Periplus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jl. Rawa Gelam IV No.9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kawasan Industri Pulogadung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jakarta Timur"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
				Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
		Me.Label1.Location = New System.Drawing.Point(458, 3)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(392, 46)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Periplus Marketplace"
		'
		'PnDisplay
		'
		Me.PnDisplay.BackColor = System.Drawing.Color.WhiteSmoke
		Me.PnDisplay.Location = New System.Drawing.Point(147, 149)
		Me.PnDisplay.Name = "PnDisplay"
		Me.PnDisplay.Size = New System.Drawing.Size(844, 519)
		Me.PnDisplay.TabIndex = 3
		'
		'FormHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightBlue
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(1000, 680)
		Me.Controls.Add(Me.PnDisplay)
		Me.Controls.Add(Me.PnHeader)
		Me.Controls.Add(Me.PnHeaderButton)
		Me.Controls.Add(Me.PnMenu)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormHome"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormHome"
		Me.PnMenu.ResumeLayout(False)
		CType(Me.PbPeriplus, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PnbtAdmin.ResumeLayout(False)
		Me.PnBtOrder.ResumeLayout(False)
		Me.PnBtHome.ResumeLayout(False)
		Me.PnHeader.ResumeLayout(False)
		Me.PnHeader.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PnMenu As Panel
	Friend WithEvents PnHeaderButton As Panel
	Friend WithEvents PnHeader As Panel
	Friend WithEvents PnBtHome As Panel
	Friend WithEvents BtHome As Button
	Friend WithEvents PnBtOrder As Panel
	Friend WithEvents BtOrder As Button
	Friend WithEvents PnbtAdmin As Panel
	Friend WithEvents BtAdmin As Button
	Friend WithEvents PnMenuNow As Panel
	Friend WithEvents PbPeriplus As PictureBox
	Friend WithEvents PnDisplay As Panel
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
End Class
