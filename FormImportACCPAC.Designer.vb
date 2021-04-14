Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Me.btImport = New System.Windows.Forms.Button()
		Me.pnMinimizeMaximizeClose = New System.Windows.Forms.Panel()
		Me.btClose = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.btMinimize = New System.Windows.Forms.Button()
		Me.CariFile = New System.Windows.Forms.OpenFileDialog()
		Me.gbImport.SuspendLayout()
		Me.pnMinimizeMaximizeClose.SuspendLayout()
		Me.SuspendLayout()
		'
		'gbImport
		'
		Me.gbImport.Anchor = System.Windows.Forms.AnchorStyles.None
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
		Me.cbMP.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.cbMP.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbMP.FormattingEnabled = True
		Me.cbMP.Location = New System.Drawing.Point(48, 66)
		Me.cbMP.Name = "cbMP"
		Me.cbMP.Size = New System.Drawing.Size(142, 33)
		Me.cbMP.TabIndex = 1
		'
		'btImport
		'
		Me.btImport.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btImport.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.cloud_sync_30px
		Me.btImport.Location = New System.Drawing.Point(83, 105)
		Me.btImport.Name = "btImport"
		Me.btImport.Size = New System.Drawing.Size(77, 34)
		Me.btImport.TabIndex = 0
		Me.btImport.UseVisualStyleBackColor = True
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
		Me.btClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
		Me.btMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
		Me.btMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMinimize.Image = Global.MarketPlace_CheckingOrder.My.Resources.Resources.minimize_window_32px
		Me.btMinimize.Location = New System.Drawing.Point(687, 5)
		Me.btMinimize.Name = "btMinimize"
		Me.btMinimize.Size = New System.Drawing.Size(33, 31)
		Me.btMinimize.TabIndex = 3
		Me.btMinimize.UseVisualStyleBackColor = True
		'
		'CariFile
		'
		Me.CariFile.FileName = "Tokopedia"
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

	Private Sub FormImportACCPAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cbMP.Items.Add("Tokopedia")
		cbMP.Items.Add("Shopee")
		cbMP.Items.Add("JDID")
		cbMP.Items.Add("Lazada")
	End Sub

	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
		Me.Close()
	End Sub

	Private Sub btMinimize_Click(sender As Object, e As EventArgs) Handles btMinimize.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btMaximize_Click(sender As Object, e As EventArgs) Handles btMaximize.Click
		If Me.WindowState = FormWindowState.Maximized Then

			Me.Width = 800
			Me.Height = 450
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Refresh()


		End If
		Me.WindowState = FormWindowState.Maximized
	End Sub

	Private Sub btImport_Click(sender As Object, e As EventArgs) Handles btImport.Click
		If cbMP.Text = "Tokopedia" Then
			'Dim Loc As String
			'Loc = "PP343"
			'Dim Tanggal As Date
			'Tanggal = Today

			Try
				Dim CariFile As New OpenFileDialog
				With CariFile
					.Filter = " Tokopedia (*.xlsx)|*.xlsx|All Files (*.*)|*.* "
					.FilterIndex = 1
					.Title = "Pilih File"
				End With

				If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
					Dim NamaFile = CariFile.FileName
					Dim ConnEx As New OleDbConnection(" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "';Extended Properties = ""Excel 12.0 xml;HDR = Yes""")
					ConnEx.Open()
					Dim DaEx As New OleDbDataAdapter("SELECT * FROM [Sheet1$A4:AB5000]", ConnEx)
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_TRANSACT_TEMP")
					Dim DsEx As New DataSet
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEsSRV4 As New SqlConnection("SERVER = SRV4; Initial Catalog = INV ; User Id = sa; Password=")
					ConnEsSRV4.Open()
					Dim DrwEs As DataRow
					Dim DrEs As SqlDataReader
					Dim CmdEs As SqlCommand
					Dim CmdEsDell As SqlCommand
					'Dim CmdEsImport As SqlCommand
					'Dim CmdUpdate As SqlCommand

					CmdEsDell = New SqlCommand("DELETE FROM MP_TRANSACT_TEMP WHERE MP = 'Tokopedia' ", ConnEsSRV4)
					CmdEsDell.ExecuteNonQuery()

					For Each DrwEs In DsEx.Tables(0).Rows


						'If IsDate(DrwEs(3)) Then
						Dim Judul As String = DrwEs(6)
						Judul = Judul.Replace("'", "''")

						Dim Alamat As String = DrwEs(17)
						Alamat = Alamat.Replace("'", "''")

						Dim NamaCust As String = DrwEs(13)
						NamaCust = NamaCust.Replace("'", "''")

						Dim NamaRecipient As String = DrwEs(15)
						NamaRecipient = NamaRecipient.Replace("'", "''")

						Dim regDate As DateTime = DrwEs(3)
						'Dim strDate As String = regDate.ToString("dd-MM-yyyy")

						Dim TanggalKirim As DateTime = Today
						Dim TanggalSelesai As DateTime = Today

						CmdEs = New SqlCommand("INSERT INTO MP_TRANSACT_TEMP (MP,InvoiceOrderID,StatusPesanan,Resi,ISBN,Judul,QTY,Harga,Kurir,[Address],NamaCust,NamaPenerima,HpCust,HpPenerima,TanggalPesanan,TanggalDikirim,TanggalSelesai) VALUES 
											  ('" & cbMP.SelectedItem & "', '" & DrwEs(2).ToString & "','" & DrwEs(4).ToString & "','" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "',
											   '" & Judul & "'," & DrwEs(7) & "," & DrwEs(10) & ",'" & DrwEs(18).ToString & "','" & Alamat & "','" & NamaCust & "',
											   '" & NamaRecipient & "','" & DrwEs(14).ToString & "','" & DrwEs(16).ToString & "','" & regDate & "','" & TanggalKirim & "','" & TanggalSelesai & "' ) ", ConnEsSRV4)
						DrEs = CmdEs.ExecuteReader
						DrEs.Close()
						'WHERE NOT EXIST ( SELECT '" & DrwEs(1).ToString & "' FROM MP_CheckingOrder_Temp WHERE Proses_Status = 1  )
						'			Else
						'				Dim Judul As String = DrwEs(6)
						'				Judul = Judul.Replace("'", "''")

						'				Dim Alamat As String = DrwEs(17)
						'				Alamat = Alamat.Replace("'", "''")

						'				''Dim Tanggal As String = DrwEs(3).Text
						'				''Dim TrimTanggal As String
						'				''Dim Potong As Integer = 10
						'				''TrimTanggal = LTrim(DrwEs(3).ToString, Potong)

						'				Dim Tanggal As String = DrwEs(3)
						'				'Dim Rgx As New Regex("[0-9]")
						'				'Dim Hasil As String = Regex.Replace(Tanggal, "[0-9]", String.Empty)
						'				'Tanggal = Tanggal.Replace("[0-9]", "")

						'				Dim FinalTanggal As String = Tanggal
						'				FinalTanggal = FinalTanggal.Replace(":", "")

						'				Dim TrimTanggal As String
						'				TrimTanggal = FinalTanggal.Substring(0, FinalTanggal.Length - 7)

						'				'Dim PokokeTanggal As Date = TrimTanggal


						'				Dim ConvertTanggal = Date.ParseExact(TrimTanggal, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
						'				'Dim CobaTanggal As String = ConvertTanggal

						'				'Dim ConvertTanggal As String = TrimTanggal.ToString("yyyy-MM-dd")
						'				'Dim ConvertTanggal As DateTime = DateTime.ParseExact(ConvertTanggal, "dd-MM-yyyy", Nothing)
						'				'MsgBox(ConvertTanggal.ToString())

						'				'Dim Coba As String = "test isDate"
						'				'MsgBox(Coba)

						'				CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) VALUES 
						'								  ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(2).ToString & "','" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "',
						'								   '" & Judul & "'," & DrwEs(7) & "," & DrwEs(10) & ",'" & DrwEs(18).ToString & "','" & Alamat & "','" & DrwEs(13).ToString & "',
						'								   '" & DrwEs(15).ToString & "','" & DrwEs(14).ToString & "','" & ConvertTanggal.ToString() & "','" & DrwEs(4).ToString & "' ) ", ConnEs)
						'				DrEs = CmdEs.ExecuteReader
						'				DrEs.Close()
						'			End If

					Next


					'		'<-- To Delete Duplicate Value -->
					'		'Dim ConnEsDup As SqlConnection
					'		'ConnEsDup = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
					'		'ConnEsDup.Open()
					'		'Dim CmdEsDup As SqlCommand
					'		'CmdEsDup = New SqlCommand("
					'		'WITH DUP AS( 
					'		'	SELECT 
					'		'	*,
					'		'	ROW_NUMBER() OVER(
					'		'		PARTITION BY
					'		'		MP,
					'		'		Tokped_ProductId,
					'		'		Order_ID,
					'		'		Invoice
					'		'	ORDER BY
					'		'		Proses_status desc
					'		'	)as ROW_NUM 
					'		'	FROM MP_CheckingOrder_Temp)
					'		'		DELETE FROM DUP
					'		'		WHERE ROW_NUM > 1", ConnEsDup)
					'		'Dim DrEsDUp As SqlDataReader
					'		'DrEsDUp = CmdEsDup.ExecuteReader
					'		'DrEsDUp.Close()
					'		'ConnEs.Close()
					'		'ConnEsDup.Close()
					'		' <-- End -->

					'		CmdEsImport = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status)
					'									  SELECT MP,Invoice_OrderID, Resi, ISBN, Judul, QTY, Harga, Courrier, [Address], Nama_Cust, Nama_Penerima, No_Hp_Cus, Tanggal_Pesanan,Proses_Status
					'									  From MP_CheckingOrder_Temp
					'                                               Where MP_CheckingOrder_Temp.Invoice_OrderID Not In (Select Invoice_OrderID FROM MP_CheckingOrder)", ConnEs)
					'		CmdEsImport.ExecuteNonQuery()


					'		CmdUpdate = New SqlCommand("UPDATE MP_CheckingOrder  
					'										SET Proses_Status = b.Proses_Status  , Tanggal_Selesai = GETDATE()
					'										FROM MP_CheckingOrder a
					'								     	INNER JOIN MP_CheckingOrder_Temp b 
					'										ON
					'										a.Invoice_OrderID = b.Invoice_OrderID 
					'										WHERE a.Proses_Status LIKE '%Terkirim%' ", ConnEs)
					'		CmdUpdate.ExecuteNonQuery()

					MsgBox("Import Tokopedia Done !!!!")


				End If
				'Catch ex As Exception

				'End Try

				'ElseIf ComboBoxPilihMP.Text = "Shopee" Then
				'Dim Loc As String
				'Loc = "PP342"
				'Dim Tanggal As Date
				'Tanggal = Today

				'		Try
				'Dim CariFile As New OpenFileDialog
				'With CariFile
				'	.Filter = " Shopee (*.xls)|*.xls|All Files (*.*)|*.* "
				'	.FilterIndex = 1
				'	.Title = "Pilih File"

				'End With

				'If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
				'	Dim NamaFile = CariFile.FileName
				'	Dim ConnEx As New OleDbConnection(" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "';Extended Properties = ""Excel 12.0 xml;HDR = Yes"" ")
				'	ConnEx.Open()

				'	Dim DaEx1 As New OleDbDataAdapter("SELECT * FROM [orders$A1:AS5000]", ConnEx)
				'	DaEx1.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder_Temp")
				'	Dim DsEx1 As New DataSet
				'	Dim DtEx1 As New DataTable
				'	DaEx1.Fill(DsEx1)
				'	ConnEx.Close()

				'	Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = TRUE")
				'	ConnEs.Open()
				'	Dim DrwEs1 As DataRow
				'	Dim DrEs1 As SqlDataReader
				'	Dim CmdEs1 As SqlCommand
				'	Dim CmdEsDell1 As SqlCommand
				'	Dim CmdEsImportShop As SqlCommand
				'	Dim CmdUpdateShop As SqlCommand

				'	CmdEsDell1 = New SqlCommand("DELETE FROM MP_CheckingOrder_Temp WHERE MP = 'Shopee' ", ConnEs)
				'	CmdEsDell1.ExecuteNonQuery()

				'	For Each DrwEs1 In DsEx1.Tables(0).Rows


				'		If DrwEs1(38).ToString = "" Then


				'			Dim HargaAwal As String = DrwEs1(16)
				'			Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
				'			HargaAwal = harga.Replace(".", String.Empty)
				'			Dim HargaFinal As Integer = Integer.Parse(HargaAwal)

				'			Dim Quan As Integer = Integer.Parse(DrwEs1(17))

				'			Dim judul1 As String = DrwEs1(12)
				'			judul1 = judul1.Replace("'", "''")

				'			Dim alamat1 As String = DrwEs1(41)
				'			alamat1 = alamat1.Replace("'", "''")

				'			Dim penerima1 As String = DrwEs1(39)
				'			penerima1 = penerima1.Replace("'", "''")


				'			CmdEs1 = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) 
				'									VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs1(0).ToString & "','" & DrwEs1(4).ToString & "','" & DrwEs1(11).ToString & "','" & judul1 & "',
				'											'" & Quan & "','" & HargaFinal & "','" & DrwEs1(5).ToString & "','" & alamat1 & "','" & penerima1 & "','" & penerima1 & "','" & DrwEs1(40).ToString & "',
				'											'" & DrwEs1(9).ToString & "','" & DrwEs1(1).ToString & "')", ConnEs)
				'			DrEs1 = CmdEs1.ExecuteReader
				'			DrEs1.Close()

				'		Else

				'			Dim HargaAwal As String = DrwEs1(16)
				'			Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
				'			HargaAwal = harga.Replace(".", String.Empty)
				'			Dim HargaFinal As Integer = Integer.Parse(HargaAwal)

				'			Dim Quan As Integer = Integer.Parse(DrwEs1(17))

				'			Dim judul1 As String = DrwEs1(12)
				'			judul1 = judul1.Replace("'", "''")

				'			Dim alamat1 As String = DrwEs1(41)
				'			alamat1 = alamat1.Replace("'", "''")

				'			Dim penerima1 As String = DrwEs1(39)
				'			penerima1 = penerima1.Replace("'", "''")

				'			Dim namacust1 As String = DrwEs1(38)
				'			namacust1 = namacust1.Replace("'", "''")

				'			CmdEs1 = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) 
				'										VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs1(0).ToString & "','" & DrwEs1(4).ToString & "','" & DrwEs1(11).ToString & "','" & judul1 & "',
				'												'" & Quan & "','" & HargaFinal & "','" & DrwEs1(5).ToString & "','" & alamat1 & "','" & namacust1 & "','" & penerima1 & "','" & DrwEs1(40).ToString & "',
				'												'" & DrwEs1(9).ToString & "','" & DrwEs1(1).ToString & "')", ConnEs)
				'			DrEs1 = CmdEs1.ExecuteReader
				'			DrEs1.Close()

				'End If


				'Next

				'<-- Syntax To delete Duplicate Value -->
				'Dim ConnEsDup As SqlConnection
				'ConnEsDup = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
				'ConnEsDup.Open()
				'Dim CmdEsDup As SqlCommand
				'CmdEsDup = New SqlCommand("
				'WITH DUP AS( 
				'	SELECT 
				'	*,
				'	ROW_NUMBER() OVER(
				'		PARTITION BY
				'		MP,
				'		Tokped_ProductId,
				'		Order_ID,
				'		Invoice
				'	ORDER BY
				'		Proses_status desc
				'	)as ROW_NUM 
				'	FROM MP_CheckingOrder_Temp)
				'		DELETE FROM DUP
				'		WHERE ROW_NUM > 1", ConnEsDup)

				'Dim DrEsDUp As SqlDataReader
				'DrEsDUp = CmdEsDup.ExecuteReader
				'DrEsDUp.Close()
				'ConnEsDup.Close()
				'ConnEs.Close()
				' <-- End -->

				'	CmdEsImportShop = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status)
				'								  SELECT MP,Invoice_OrderID, Resi, ISBN, Judul, QTY, Harga, Courrier, [Address], Nama_Cust, Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status
				'								  From MP_CheckingOrder_Temp
				'                                              Where MP_CheckingOrder_Temp.Invoice_OrderID Not In (Select Invoice_OrderID FROM MP_CheckingOrder)", ConnEs)
				'	CmdEsImportShop.ExecuteNonQuery()

				'	CmdUpdateShop = New SqlCommand("UPDATE MP_CheckingOrder  
				'									SET Proses_Status = b.Proses_Status , Tanggal_Selesai = GETDATE()
				'									FROM MP_CheckingOrder a
				'							     	INNER JOIN MP_CheckingOrder_Temp b 
				'									ON
				'									a.Invoice_OrderID = b.Invoice_OrderID 
				'									WHERE a.Proses_Status LIKE '%Terkirim%' ", ConnEs)
				'	CmdUpdateShop.ExecuteNonQuery()

				'	MsgBox("Import Shopee Done!!!!")
				'End If
			Catch ex As Exception

			End Try

		Else
			MsgBox("Pilih Marketplace Yang Akan Diimport !!!")
		End If
	End Sub

	Friend WithEvents CariFile As OpenFileDialog
End Class
