<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailedBuku
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GBDetailBuku = New System.Windows.Forms.GroupBox()
		Me.TBURLISBN = New System.Windows.Forms.TextBox()
		Me.LbPublisherBuku = New System.Windows.Forms.Label()
		Me.LbPublisher = New System.Windows.Forms.Label()
		Me.LbAuthorBuku = New System.Windows.Forms.Label()
		Me.LbAuthor = New System.Windows.Forms.Label()
		Me.LbKatBuku = New System.Windows.Forms.Label()
		Me.LbKat = New System.Windows.Forms.Label()
		Me.LbKodeBuku = New System.Windows.Forms.Label()
		Me.LbKode = New System.Windows.Forms.Label()
		Me.LbISBNBuku = New System.Windows.Forms.Label()
		Me.LbISBN = New System.Windows.Forms.Label()
		Me.GBPrepiu = New System.Windows.Forms.GroupBox()
		Me.PBBuku = New System.Windows.Forms.PictureBox()
		Me.LbNamaJudulBuku = New System.Windows.Forms.Label()
		Me.LbJudulBuku = New System.Windows.Forms.Label()
		Me.GBStockJakarta = New System.Windows.Forms.GroupBox()
		Me.DGVStock = New System.Windows.Forms.DataGridView()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.BtCloseWindow = New System.Windows.Forms.Button()
		Me.GBDetailBuku.SuspendLayout()
		Me.GBPrepiu.SuspendLayout()
		CType(Me.PBBuku, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GBStockJakarta.SuspendLayout()
		CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(297, 43)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(176, 26)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "PeriplusPedia"
		'
		'GBDetailBuku
		'
		Me.GBDetailBuku.BackColor = System.Drawing.Color.MidnightBlue
		Me.GBDetailBuku.Controls.Add(Me.TBURLISBN)
		Me.GBDetailBuku.Controls.Add(Me.LbPublisherBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbPublisher)
		Me.GBDetailBuku.Controls.Add(Me.LbAuthorBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbAuthor)
		Me.GBDetailBuku.Controls.Add(Me.LbKatBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbKat)
		Me.GBDetailBuku.Controls.Add(Me.LbKodeBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbKode)
		Me.GBDetailBuku.Controls.Add(Me.LbISBNBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbISBN)
		Me.GBDetailBuku.Controls.Add(Me.GBPrepiu)
		Me.GBDetailBuku.Controls.Add(Me.LbNamaJudulBuku)
		Me.GBDetailBuku.Controls.Add(Me.LbJudulBuku)
		Me.GBDetailBuku.ForeColor = System.Drawing.Color.White
		Me.GBDetailBuku.Location = New System.Drawing.Point(12, 68)
		Me.GBDetailBuku.Name = "GBDetailBuku"
		Me.GBDetailBuku.Size = New System.Drawing.Size(746, 273)
		Me.GBDetailBuku.TabIndex = 1
		Me.GBDetailBuku.TabStop = False
		Me.GBDetailBuku.Text = "Detail Buku"
		'
		'TBURLISBN
		'
		Me.TBURLISBN.Location = New System.Drawing.Point(601, 12)
		Me.TBURLISBN.Name = "TBURLISBN"
		Me.TBURLISBN.Size = New System.Drawing.Size(100, 20)
		Me.TBURLISBN.TabIndex = 13
		'
		'LbPublisherBuku
		'
		Me.LbPublisherBuku.AutoSize = True
		Me.LbPublisherBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbPublisherBuku.ForeColor = System.Drawing.Color.White
		Me.LbPublisherBuku.Location = New System.Drawing.Point(106, 214)
		Me.LbPublisherBuku.Name = "LbPublisherBuku"
		Me.LbPublisherBuku.Size = New System.Drawing.Size(125, 23)
		Me.LbPublisherBuku.TabIndex = 12
		Me.LbPublisherBuku.Text = "PublisherBuku"
		'
		'LbPublisher
		'
		Me.LbPublisher.AutoSize = True
		Me.LbPublisher.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbPublisher.ForeColor = System.Drawing.Color.White
		Me.LbPublisher.Location = New System.Drawing.Point(4, 218)
		Me.LbPublisher.Name = "LbPublisher"
		Me.LbPublisher.Size = New System.Drawing.Size(96, 19)
		Me.LbPublisher.TabIndex = 11
		Me.LbPublisher.Text = "PUBLISHER  :"
		'
		'LbAuthorBuku
		'
		Me.LbAuthorBuku.AutoSize = True
		Me.LbAuthorBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbAuthorBuku.ForeColor = System.Drawing.Color.White
		Me.LbAuthorBuku.Location = New System.Drawing.Point(106, 183)
		Me.LbAuthorBuku.Name = "LbAuthorBuku"
		Me.LbAuthorBuku.Size = New System.Drawing.Size(106, 23)
		Me.LbAuthorBuku.TabIndex = 10
		Me.LbAuthorBuku.Text = "AuthorBuku"
		'
		'LbAuthor
		'
		Me.LbAuthor.AutoSize = True
		Me.LbAuthor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbAuthor.ForeColor = System.Drawing.Color.White
		Me.LbAuthor.Location = New System.Drawing.Point(4, 185)
		Me.LbAuthor.Name = "LbAuthor"
		Me.LbAuthor.Size = New System.Drawing.Size(95, 19)
		Me.LbAuthor.TabIndex = 9
		Me.LbAuthor.Text = "AUTHOR     :"
		'
		'LbKatBuku
		'
		Me.LbKatBuku.AutoSize = True
		Me.LbKatBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbKatBuku.ForeColor = System.Drawing.Color.White
		Me.LbKatBuku.Location = New System.Drawing.Point(106, 148)
		Me.LbKatBuku.Name = "LbKatBuku"
		Me.LbKatBuku.Size = New System.Drawing.Size(80, 23)
		Me.LbKatBuku.TabIndex = 8
		Me.LbKatBuku.Text = "KATBuku"
		'
		'LbKat
		'
		Me.LbKat.AutoSize = True
		Me.LbKat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbKat.ForeColor = System.Drawing.Color.White
		Me.LbKat.Location = New System.Drawing.Point(6, 151)
		Me.LbKat.Name = "LbKat"
		Me.LbKat.Size = New System.Drawing.Size(94, 19)
		Me.LbKat.TabIndex = 7
		Me.LbKat.Text = "KAT             :"
		'
		'LbKodeBuku
		'
		Me.LbKodeBuku.AutoSize = True
		Me.LbKodeBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbKodeBuku.ForeColor = System.Drawing.Color.White
		Me.LbKodeBuku.Location = New System.Drawing.Point(106, 115)
		Me.LbKodeBuku.Name = "LbKodeBuku"
		Me.LbKodeBuku.Size = New System.Drawing.Size(90, 23)
		Me.LbKodeBuku.TabIndex = 6
		Me.LbKodeBuku.Text = "KodeBuku"
		'
		'LbKode
		'
		Me.LbKode.AutoSize = True
		Me.LbKode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbKode.ForeColor = System.Drawing.Color.White
		Me.LbKode.Location = New System.Drawing.Point(6, 118)
		Me.LbKode.Name = "LbKode"
		Me.LbKode.Size = New System.Drawing.Size(95, 19)
		Me.LbKode.TabIndex = 5
		Me.LbKode.Text = "KODE          :"
		'
		'LbISBNBuku
		'
		Me.LbISBNBuku.AutoSize = True
		Me.LbISBNBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbISBNBuku.ForeColor = System.Drawing.Color.White
		Me.LbISBNBuku.Location = New System.Drawing.Point(106, 80)
		Me.LbISBNBuku.Name = "LbISBNBuku"
		Me.LbISBNBuku.Size = New System.Drawing.Size(88, 23)
		Me.LbISBNBuku.TabIndex = 4
		Me.LbISBNBuku.Text = "ISBNBuku"
		'
		'LbISBN
		'
		Me.LbISBN.AutoSize = True
		Me.LbISBN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbISBN.ForeColor = System.Drawing.Color.White
		Me.LbISBN.Location = New System.Drawing.Point(6, 83)
		Me.LbISBN.Name = "LbISBN"
		Me.LbISBN.Size = New System.Drawing.Size(94, 19)
		Me.LbISBN.TabIndex = 3
		Me.LbISBN.Text = "ISBN            :"
		'
		'GBPrepiu
		'
		Me.GBPrepiu.Controls.Add(Me.PBBuku)
		Me.GBPrepiu.Location = New System.Drawing.Point(562, 28)
		Me.GBPrepiu.Name = "GBPrepiu"
		Me.GBPrepiu.Size = New System.Drawing.Size(178, 239)
		Me.GBPrepiu.TabIndex = 2
		Me.GBPrepiu.TabStop = False
		'
		'PBBuku
		'
		Me.PBBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PBBuku.Location = New System.Drawing.Point(8, 16)
		Me.PBBuku.Name = "PBBuku"
		Me.PBBuku.Size = New System.Drawing.Size(164, 217)
		Me.PBBuku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PBBuku.TabIndex = 0
		Me.PBBuku.TabStop = False
		'
		'LbNamaJudulBuku
		'
		Me.LbNamaJudulBuku.AutoSize = True
		Me.LbNamaJudulBuku.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbNamaJudulBuku.ForeColor = System.Drawing.Color.White
		Me.LbNamaJudulBuku.Location = New System.Drawing.Point(106, 24)
		Me.LbNamaJudulBuku.Name = "LbNamaJudulBuku"
		Me.LbNamaJudulBuku.Size = New System.Drawing.Size(137, 23)
		Me.LbNamaJudulBuku.TabIndex = 1
		Me.LbNamaJudulBuku.Text = "NamaJudulBuku"
		'
		'LbJudulBuku
		'
		Me.LbJudulBuku.AutoSize = True
		Me.LbJudulBuku.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LbJudulBuku.ForeColor = System.Drawing.Color.White
		Me.LbJudulBuku.Location = New System.Drawing.Point(6, 28)
		Me.LbJudulBuku.Name = "LbJudulBuku"
		Me.LbJudulBuku.Size = New System.Drawing.Size(99, 19)
		Me.LbJudulBuku.TabIndex = 0
		Me.LbJudulBuku.Text = "JUDUL          :"
		'
		'GBStockJakarta
		'
		Me.GBStockJakarta.Controls.Add(Me.DGVStock)
		Me.GBStockJakarta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GBStockJakarta.ForeColor = System.Drawing.Color.White
		Me.GBStockJakarta.Location = New System.Drawing.Point(12, 358)
		Me.GBStockJakarta.Name = "GBStockJakarta"
		Me.GBStockJakarta.Size = New System.Drawing.Size(746, 233)
		Me.GBStockJakarta.TabIndex = 2
		Me.GBStockJakarta.TabStop = False
		Me.GBStockJakarta.Text = "Persebaran Stock Area Jakarta"
		'
		'DGVStock
		'
		Me.DGVStock.AllowUserToAddRows = False
		Me.DGVStock.AllowUserToDeleteRows = False
		Me.DGVStock.BackgroundColor = System.Drawing.Color.LightCyan
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DGVStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.DGVStock.DefaultCellStyle = DataGridViewCellStyle2
		Me.DGVStock.GridColor = System.Drawing.Color.MidnightBlue
		Me.DGVStock.Location = New System.Drawing.Point(10, 19)
		Me.DGVStock.Name = "DGVStock"
		Me.DGVStock.ReadOnly = True
		Me.DGVStock.RowHeadersVisible = False
		DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue
		DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
		Me.DGVStock.RowsDefaultCellStyle = DataGridViewCellStyle3
		Me.DGVStock.Size = New System.Drawing.Size(730, 208)
		Me.DGVStock.TabIndex = 0
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightCyan
		Me.Panel1.Controls.Add(Me.BtCloseWindow)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Panel1.Location = New System.Drawing.Point(0, 0)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(770, 26)
		Me.Panel1.TabIndex = 3
		'
		'BtCloseWindow
		'
		Me.BtCloseWindow.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.close_window_24px
		Me.BtCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.BtCloseWindow.Location = New System.Drawing.Point(742, 0)
		Me.BtCloseWindow.Name = "BtCloseWindow"
		Me.BtCloseWindow.Size = New System.Drawing.Size(28, 26)
		Me.BtCloseWindow.TabIndex = 4
		Me.BtCloseWindow.UseVisualStyleBackColor = True
		'
		'FormDetailedBuku
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(770, 598)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.GBStockJakarta)
		Me.Controls.Add(Me.GBDetailBuku)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormDetailedBuku"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormDetailedBuku"
		Me.GBDetailBuku.ResumeLayout(False)
		Me.GBDetailBuku.PerformLayout()
		Me.GBPrepiu.ResumeLayout(False)
		CType(Me.PBBuku, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GBStockJakarta.ResumeLayout(False)
		CType(Me.DGVStock, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents GBDetailBuku As GroupBox
	Public WithEvents LbPublisherBuku As Label
	Friend WithEvents LbPublisher As Label
	Public WithEvents LbAuthorBuku As Label
	Friend WithEvents LbAuthor As Label
	Public WithEvents LbKatBuku As Label
	Friend WithEvents LbKat As Label
	Public WithEvents LbKodeBuku As Label
	Friend WithEvents LbKode As Label
	Public WithEvents LbISBNBuku As Label
	Friend WithEvents LbISBN As Label
	Friend WithEvents GBPrepiu As GroupBox
	Friend WithEvents PBBuku As PictureBox
	Public WithEvents LbNamaJudulBuku As Label
	Friend WithEvents LbJudulBuku As Label
	Friend WithEvents GBStockJakarta As GroupBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents BtCloseWindow As Button
	Friend WithEvents TBURLISBN As TextBox
	Friend WithEvents DGVStock As DataGridView
End Class
