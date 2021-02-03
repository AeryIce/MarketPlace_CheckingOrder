<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
		Me.GBDataAdmin = New System.Windows.Forms.GroupBox()
		Me.DGVAdmin = New System.Windows.Forms.DataGridView()
		Me.LbSalesper = New System.Windows.Forms.Label()
		Me.LbTgl = New System.Windows.Forms.Label()
		Me.LbNominal = New System.Windows.Forms.Label()
		Me.GBCRUD = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.GBAdminTeritory = New System.Windows.Forms.GroupBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RBProces = New System.Windows.Forms.RadioButton()
		Me.RBBatal = New System.Windows.Forms.RadioButton()
		Me.RBSelesai = New System.Windows.Forms.RadioButton()
		Me.RBTerkirim = New System.Windows.Forms.RadioButton()
		Me.RBAll = New System.Windows.Forms.RadioButton()
		Me.GBSortToko = New System.Windows.Forms.GroupBox()
		Me.RBTokopedia = New System.Windows.Forms.RadioButton()
		Me.RBShopee = New System.Windows.Forms.RadioButton()
		Me.RBSemua = New System.Windows.Forms.RadioButton()
		Me.BtCariInvoice = New System.Windows.Forms.Button()
		Me.TBCariInvoice = New System.Windows.Forms.TextBox()
		Me.GBDataAdmin.SuspendLayout()
		CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBCRUD.SuspendLayout()
		Me.GBAdminTeritory.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GBSortToko.SuspendLayout()
		Me.SuspendLayout()
		'
		'GBDataAdmin
		'
		Me.GBDataAdmin.Controls.Add(Me.DGVAdmin)
		Me.GBDataAdmin.Location = New System.Drawing.Point(6, 117)
		Me.GBDataAdmin.Name = "GBDataAdmin"
		Me.GBDataAdmin.Size = New System.Drawing.Size(583, 167)
		Me.GBDataAdmin.TabIndex = 1
		Me.GBDataAdmin.TabStop = False
		Me.GBDataAdmin.Text = "Data Transaksi"
		'
		'DGVAdmin
		'
		Me.DGVAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
		Me.DGVAdmin.BackgroundColor = System.Drawing.Color.Aquamarine
		Me.DGVAdmin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.DGVAdmin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DGVAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVAdmin.GridColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.DGVAdmin.Location = New System.Drawing.Point(21, 19)
		Me.DGVAdmin.Name = "DGVAdmin"
		Me.DGVAdmin.RowHeadersVisible = False
		Me.DGVAdmin.Size = New System.Drawing.Size(540, 125)
		Me.DGVAdmin.TabIndex = 0
		'
		'LbSalesper
		'
		Me.LbSalesper.AutoSize = True
		Me.LbSalesper.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbSalesper.Location = New System.Drawing.Point(315, 20)
		Me.LbSalesper.Name = "LbSalesper"
		Me.LbSalesper.Size = New System.Drawing.Size(114, 25)
		Me.LbSalesper.TabIndex = 2
		Me.LbSalesper.Text = "SALES Per "
		'
		'LbTgl
		'
		Me.LbTgl.AutoSize = True
		Me.LbTgl.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbTgl.Location = New System.Drawing.Point(421, 21)
		Me.LbTgl.Name = "LbTgl"
		Me.LbTgl.Size = New System.Drawing.Size(93, 24)
		Me.LbTgl.TabIndex = 3
		Me.LbTgl.Text = "Tanggal"
		'
		'LbNominal
		'
		Me.LbNominal.AutoSize = True
		Me.LbNominal.Font = New System.Drawing.Font("Century Gothic", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
				Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbNominal.Location = New System.Drawing.Point(558, 9)
		Me.LbNominal.Name = "LbNominal"
		Me.LbNominal.Size = New System.Drawing.Size(147, 39)
		Me.LbNominal.TabIndex = 4
		Me.LbNominal.Text = "Nominal"
		'
		'GBCRUD
		'
		Me.GBCRUD.Controls.Add(Me.Button1)
		Me.GBCRUD.Location = New System.Drawing.Point(621, 115)
		Me.GBCRUD.Name = "GBCRUD"
		Me.GBCRUD.Size = New System.Drawing.Size(155, 167)
		Me.GBCRUD.TabIndex = 5
		Me.GBCRUD.TabStop = False
		Me.GBCRUD.Text = "CRUD"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(17, 20)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(118, 27)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'GBAdminTeritory
		'
		Me.GBAdminTeritory.Controls.Add(Me.GroupBox1)
		Me.GBAdminTeritory.Controls.Add(Me.GBSortToko)
		Me.GBAdminTeritory.Controls.Add(Me.BtCariInvoice)
		Me.GBAdminTeritory.Controls.Add(Me.TBCariInvoice)
		Me.GBAdminTeritory.Controls.Add(Me.GBDataAdmin)
		Me.GBAdminTeritory.Controls.Add(Me.GBCRUD)
		Me.GBAdminTeritory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GBAdminTeritory.Location = New System.Drawing.Point(17, 68)
		Me.GBAdminTeritory.Name = "GBAdminTeritory"
		Me.GBAdminTeritory.Size = New System.Drawing.Size(798, 322)
		Me.GBAdminTeritory.TabIndex = 6
		Me.GBAdminTeritory.TabStop = False
		Me.GBAdminTeritory.Text = "Admin Teritory"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RBProces)
		Me.GroupBox1.Controls.Add(Me.RBBatal)
		Me.GroupBox1.Controls.Add(Me.RBSelesai)
		Me.GroupBox1.Controls.Add(Me.RBTerkirim)
		Me.GroupBox1.Controls.Add(Me.RBAll)
		Me.GroupBox1.Location = New System.Drawing.Point(259, 54)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(330, 57)
		Me.GroupBox1.TabIndex = 9
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Sort By Status"
		'
		'RBProces
		'
		Me.RBProces.AutoSize = True
		Me.RBProces.Location = New System.Drawing.Point(234, 23)
		Me.RBProces.Name = "RBProces"
		Me.RBProces.Size = New System.Drawing.Size(80, 17)
		Me.RBProces.TabIndex = 4
		Me.RBProces.TabStop = True
		Me.RBProces.Text = "On Process"
		Me.RBProces.UseVisualStyleBackColor = True
		'
		'RBBatal
		'
		Me.RBBatal.AutoSize = True
		Me.RBBatal.Location = New System.Drawing.Point(181, 23)
		Me.RBBatal.Name = "RBBatal"
		Me.RBBatal.Size = New System.Drawing.Size(49, 17)
		Me.RBBatal.TabIndex = 3
		Me.RBBatal.TabStop = True
		Me.RBBatal.Text = "Batal"
		Me.RBBatal.UseVisualStyleBackColor = True
		'
		'RBSelesai
		'
		Me.RBSelesai.AutoSize = True
		Me.RBSelesai.Location = New System.Drawing.Point(118, 23)
		Me.RBSelesai.Name = "RBSelesai"
		Me.RBSelesai.Size = New System.Drawing.Size(59, 17)
		Me.RBSelesai.TabIndex = 2
		Me.RBSelesai.TabStop = True
		Me.RBSelesai.Text = "Selesai"
		Me.RBSelesai.UseVisualStyleBackColor = True
		'
		'RBTerkirim
		'
		Me.RBTerkirim.AutoSize = True
		Me.RBTerkirim.Location = New System.Drawing.Point(52, 23)
		Me.RBTerkirim.Name = "RBTerkirim"
		Me.RBTerkirim.Size = New System.Drawing.Size(62, 17)
		Me.RBTerkirim.TabIndex = 1
		Me.RBTerkirim.TabStop = True
		Me.RBTerkirim.Text = "Terkirim"
		Me.RBTerkirim.UseVisualStyleBackColor = True
		'
		'RBAll
		'
		Me.RBAll.AutoSize = True
		Me.RBAll.Location = New System.Drawing.Point(12, 23)
		Me.RBAll.Name = "RBAll"
		Me.RBAll.Size = New System.Drawing.Size(36, 17)
		Me.RBAll.TabIndex = 0
		Me.RBAll.TabStop = True
		Me.RBAll.Text = "All"
		Me.RBAll.UseVisualStyleBackColor = True
		'
		'GBSortToko
		'
		Me.GBSortToko.Controls.Add(Me.RBTokopedia)
		Me.GBSortToko.Controls.Add(Me.RBShopee)
		Me.GBSortToko.Controls.Add(Me.RBSemua)
		Me.GBSortToko.Location = New System.Drawing.Point(6, 54)
		Me.GBSortToko.Name = "GBSortToko"
		Me.GBSortToko.Size = New System.Drawing.Size(247, 57)
		Me.GBSortToko.TabIndex = 8
		Me.GBSortToko.TabStop = False
		Me.GBSortToko.Text = "Sort By Toko"
		'
		'RBTokopedia
		'
		Me.RBTokopedia.AutoSize = True
		Me.RBTokopedia.Location = New System.Drawing.Point(165, 23)
		Me.RBTokopedia.Name = "RBTokopedia"
		Me.RBTokopedia.Size = New System.Drawing.Size(76, 17)
		Me.RBTokopedia.TabIndex = 2
		Me.RBTokopedia.TabStop = True
		Me.RBTokopedia.Text = "Tokopedia"
		Me.RBTokopedia.UseVisualStyleBackColor = True
		'
		'RBShopee
		'
		Me.RBShopee.AutoSize = True
		Me.RBShopee.Location = New System.Drawing.Point(100, 23)
		Me.RBShopee.Name = "RBShopee"
		Me.RBShopee.Size = New System.Drawing.Size(62, 17)
		Me.RBShopee.TabIndex = 1
		Me.RBShopee.TabStop = True
		Me.RBShopee.Text = "Shopee"
		Me.RBShopee.UseVisualStyleBackColor = True
		'
		'RBSemua
		'
		Me.RBSemua.AutoSize = True
		Me.RBSemua.Location = New System.Drawing.Point(9, 23)
		Me.RBSemua.Name = "RBSemua"
		Me.RBSemua.Size = New System.Drawing.Size(86, 17)
		Me.RBSemua.TabIndex = 0
		Me.RBSemua.TabStop = True
		Me.RBSemua.Text = "Semua Toko"
		Me.RBSemua.UseVisualStyleBackColor = True
		'
		'BtCariInvoice
		'
		Me.BtCariInvoice.BackColor = System.Drawing.Color.LightBlue
		Me.BtCariInvoice.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.search_64px
		Me.BtCariInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.BtCariInvoice.FlatAppearance.BorderSize = 0
		Me.BtCariInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtCariInvoice.Location = New System.Drawing.Point(565, 16)
		Me.BtCariInvoice.Name = "BtCariInvoice"
		Me.BtCariInvoice.Size = New System.Drawing.Size(24, 31)
		Me.BtCariInvoice.TabIndex = 7
		Me.BtCariInvoice.UseVisualStyleBackColor = False
		'
		'TBCariInvoice
		'
		Me.TBCariInvoice.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TBCariInvoice.Location = New System.Drawing.Point(367, 14)
		Me.TBCariInvoice.Name = "TBCariInvoice"
		Me.TBCariInvoice.Size = New System.Drawing.Size(192, 33)
		Me.TBCariInvoice.TabIndex = 6
		Me.TBCariInvoice.Text = "Masukan Invoice"
		'
		'FormAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightBlue
		Me.ClientSize = New System.Drawing.Size(844, 519)
		Me.Controls.Add(Me.GBAdminTeritory)
		Me.Controls.Add(Me.LbNominal)
		Me.Controls.Add(Me.LbTgl)
		Me.Controls.Add(Me.LbSalesper)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormAdmin"
		Me.Opacity = 0.98R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormAdmin"
		Me.GBDataAdmin.ResumeLayout(False)
		CType(Me.DGVAdmin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBCRUD.ResumeLayout(False)
		Me.GBAdminTeritory.ResumeLayout(False)
		Me.GBAdminTeritory.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GBSortToko.ResumeLayout(False)
		Me.GBSortToko.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GBDataAdmin As GroupBox
	Friend WithEvents LbSalesper As Label
	Public WithEvents LbTgl As Label
	Public WithEvents LbNominal As Label
	Friend WithEvents DGVAdmin As DataGridView
	Friend WithEvents GBCRUD As GroupBox
	Friend WithEvents GBAdminTeritory As GroupBox
	Friend WithEvents TBCariInvoice As TextBox
	Friend WithEvents BtCariInvoice As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents RBProces As RadioButton
	Friend WithEvents RBBatal As RadioButton
	Friend WithEvents RBSelesai As RadioButton
	Friend WithEvents RBTerkirim As RadioButton
	Friend WithEvents RBAll As RadioButton
	Friend WithEvents GBSortToko As GroupBox
	Friend WithEvents RBTokopedia As RadioButton
	Friend WithEvents RBShopee As RadioButton
	Friend WithEvents RBSemua As RadioButton
End Class
