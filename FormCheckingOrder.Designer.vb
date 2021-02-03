<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckingOrder
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.ComboBoxPilihMP = New System.Windows.Forms.ComboBox()
		Me.GroupBoxCariOrderId = New System.Windows.Forms.GroupBox()
		Me.TextBoxScanIsbn = New System.Windows.Forms.TextBox()
		Me.GroupBoxImport = New System.Windows.Forms.GroupBox()
		Me.GroupBoxCheckingOrder = New System.Windows.Forms.GroupBox()
		Me.DGV_MPCheckingOrder = New System.Windows.Forms.DataGridView()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LabelStatusKoneksi = New System.Windows.Forms.Label()
		Me.GBSortirPencarian = New System.Windows.Forms.GroupBox()
		Me.RBTokopedia = New System.Windows.Forms.RadioButton()
		Me.RBShopee = New System.Windows.Forms.RadioButton()
		Me.RBSemua = New System.Windows.Forms.RadioButton()
		Me.ButtonImport = New System.Windows.Forms.Button()
		Me.ButtonCariISBN = New System.Windows.Forms.Button()
		Me.GroupBoxCariOrderId.SuspendLayout()
		Me.GroupBoxImport.SuspendLayout()
		Me.GroupBoxCheckingOrder.SuspendLayout()
		CType(Me.DGV_MPCheckingOrder, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBSortirPencarian.SuspendLayout()
		Me.SuspendLayout()
		'
		'ComboBoxPilihMP
		'
		Me.ComboBoxPilihMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBoxPilihMP.FormattingEnabled = True
		Me.ComboBoxPilihMP.Location = New System.Drawing.Point(6, 18)
		Me.ComboBoxPilihMP.Name = "ComboBoxPilihMP"
		Me.ComboBoxPilihMP.Size = New System.Drawing.Size(163, 32)
		Me.ComboBoxPilihMP.TabIndex = 0
		'
		'GroupBoxCariOrderId
		'
		Me.GroupBoxCariOrderId.Controls.Add(Me.ButtonCariISBN)
		Me.GroupBoxCariOrderId.Controls.Add(Me.TextBoxScanIsbn)
		Me.GroupBoxCariOrderId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.GroupBoxCariOrderId.Location = New System.Drawing.Point(151, 112)
		Me.GroupBoxCariOrderId.Name = "GroupBoxCariOrderId"
		Me.GroupBoxCariOrderId.Size = New System.Drawing.Size(260, 64)
		Me.GroupBoxCariOrderId.TabIndex = 1
		Me.GroupBoxCariOrderId.TabStop = False
		Me.GroupBoxCariOrderId.Text = "Scan Barcode ISBN"
		'
		'TextBoxScanIsbn
		'
		Me.TextBoxScanIsbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxScanIsbn.Location = New System.Drawing.Point(6, 19)
		Me.TextBoxScanIsbn.Name = "TextBoxScanIsbn"
		Me.TextBoxScanIsbn.Size = New System.Drawing.Size(206, 31)
		Me.TextBoxScanIsbn.TabIndex = 0
		'
		'GroupBoxImport
		'
		Me.GroupBoxImport.Controls.Add(Me.ButtonImport)
		Me.GroupBoxImport.Controls.Add(Me.ComboBoxPilihMP)
		Me.GroupBoxImport.Location = New System.Drawing.Point(417, 112)
		Me.GroupBoxImport.Name = "GroupBoxImport"
		Me.GroupBoxImport.Size = New System.Drawing.Size(290, 64)
		Me.GroupBoxImport.TabIndex = 2
		Me.GroupBoxImport.TabStop = False
		Me.GroupBoxImport.Text = "Import File"
		'
		'GroupBoxCheckingOrder
		'
		Me.GroupBoxCheckingOrder.Controls.Add(Me.DGV_MPCheckingOrder)
		Me.GroupBoxCheckingOrder.Location = New System.Drawing.Point(151, 241)
		Me.GroupBoxCheckingOrder.Name = "GroupBoxCheckingOrder"
		Me.GroupBoxCheckingOrder.Size = New System.Drawing.Size(555, 185)
		Me.GroupBoxCheckingOrder.TabIndex = 3
		Me.GroupBoxCheckingOrder.TabStop = False
		Me.GroupBoxCheckingOrder.Text = "Checking Order"
		'
		'DGV_MPCheckingOrder
		'
		Me.DGV_MPCheckingOrder.AllowUserToAddRows = False
		Me.DGV_MPCheckingOrder.AllowUserToDeleteRows = False
		Me.DGV_MPCheckingOrder.BackgroundColor = System.Drawing.Color.Aquamarine
		Me.DGV_MPCheckingOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.DGV_MPCheckingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGV_MPCheckingOrder.GridColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.DGV_MPCheckingOrder.Location = New System.Drawing.Point(6, 19)
		Me.DGV_MPCheckingOrder.Name = "DGV_MPCheckingOrder"
		Me.DGV_MPCheckingOrder.ReadOnly = True
		Me.DGV_MPCheckingOrder.RowHeadersVisible = False
		Me.DGV_MPCheckingOrder.Size = New System.Drawing.Size(537, 153)
		Me.DGV_MPCheckingOrder.TabIndex = 0
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(591, 432)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(103, 50)
		Me.ButtonExit.TabIndex = 3
		Me.ButtonExit.Text = "EXIT"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(215, 75)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(426, 25)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Checking Order Tokopedia dan Shopee"
		'
		'LabelStatusKoneksi
		'
		Me.LabelStatusKoneksi.AutoSize = True
		Me.LabelStatusKoneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelStatusKoneksi.Location = New System.Drawing.Point(600, 519)
		Me.LabelStatusKoneksi.Name = "LabelStatusKoneksi"
		Me.LabelStatusKoneksi.Size = New System.Drawing.Size(0, 9)
		Me.LabelStatusKoneksi.TabIndex = 5
		'
		'GBSortirPencarian
		'
		Me.GBSortirPencarian.Controls.Add(Me.RBTokopedia)
		Me.GBSortirPencarian.Controls.Add(Me.RBShopee)
		Me.GBSortirPencarian.Controls.Add(Me.RBSemua)
		Me.GBSortirPencarian.Location = New System.Drawing.Point(151, 182)
		Me.GBSortirPencarian.Name = "GBSortirPencarian"
		Me.GBSortirPencarian.Size = New System.Drawing.Size(260, 53)
		Me.GBSortirPencarian.TabIndex = 6
		Me.GBSortirPencarian.TabStop = False
		Me.GBSortirPencarian.Text = "Sortir Pencarian"
		'
		'RBTokopedia
		'
		Me.RBTokopedia.AutoSize = True
		Me.RBTokopedia.Location = New System.Drawing.Point(172, 20)
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
		Me.RBShopee.Location = New System.Drawing.Point(91, 20)
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
		Me.RBSemua.Location = New System.Drawing.Point(7, 20)
		Me.RBSemua.Name = "RBSemua"
		Me.RBSemua.Size = New System.Drawing.Size(58, 17)
		Me.RBSemua.TabIndex = 0
		Me.RBSemua.TabStop = True
		Me.RBSemua.Text = "Semua"
		Me.RBSemua.UseVisualStyleBackColor = True
		'
		'ButtonImport
		'
		Me.ButtonImport.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.add_file_32px
		Me.ButtonImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ButtonImport.Location = New System.Drawing.Point(175, 15)
		Me.ButtonImport.Name = "ButtonImport"
		Me.ButtonImport.Size = New System.Drawing.Size(103, 43)
		Me.ButtonImport.TabIndex = 0
		Me.ButtonImport.Text = "Import Data"
		Me.ButtonImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.ButtonImport.UseVisualStyleBackColor = True
		'
		'ButtonCariISBN
		'
		Me.ButtonCariISBN.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.search_16px
		Me.ButtonCariISBN.Location = New System.Drawing.Point(218, 19)
		Me.ButtonCariISBN.Name = "ButtonCariISBN"
		Me.ButtonCariISBN.Size = New System.Drawing.Size(28, 31)
		Me.ButtonCariISBN.TabIndex = 1
		Me.ButtonCariISBN.UseVisualStyleBackColor = True
		'
		'FormCheckingOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightBlue
		Me.ClientSize = New System.Drawing.Size(844, 519)
		Me.Controls.Add(Me.GBSortirPencarian)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.LabelStatusKoneksi)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBoxCheckingOrder)
		Me.Controls.Add(Me.GroupBoxImport)
		Me.Controls.Add(Me.GroupBoxCariOrderId)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormCheckingOrder"
		Me.Opacity = 0.95R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Checking Order"
		Me.GroupBoxCariOrderId.ResumeLayout(False)
		Me.GroupBoxCariOrderId.PerformLayout()
		Me.GroupBoxImport.ResumeLayout(False)
		Me.GroupBoxCheckingOrder.ResumeLayout(False)
		CType(Me.DGV_MPCheckingOrder, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBSortirPencarian.ResumeLayout(False)
		Me.GBSortirPencarian.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBoxPilihMP As ComboBox
	Friend WithEvents GroupBoxCariOrderId As GroupBox
	Friend WithEvents ButtonCariISBN As Button
	Friend WithEvents TextBoxScanIsbn As TextBox
	Friend WithEvents GroupBoxImport As GroupBox
	Friend WithEvents ButtonImport As Button
	Friend WithEvents GroupBoxCheckingOrder As GroupBox
	Friend WithEvents ButtonExit As Button
	Friend WithEvents DGV_MPCheckingOrder As DataGridView
	Friend WithEvents Label1 As Label
	Public WithEvents LabelStatusKoneksi As Label
	Friend WithEvents GBSortirPencarian As GroupBox
	Friend WithEvents RBTokopedia As RadioButton
	Friend WithEvents RBShopee As RadioButton
	Friend WithEvents RBSemua As RadioButton
End Class
