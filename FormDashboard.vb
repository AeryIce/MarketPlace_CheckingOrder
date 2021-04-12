Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Public Class FormDashboard

	'Sub KonekPikabuk()
	'	Dim ConPik As SqlConnection
	'	ConPik = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = PIKABUK; Integrated Security = True")
	'	Try
	'		ConPik.Open()
	'		MsgBox("Conek Bro")
	'	Catch ex As Exception
	'		MsgBox("Ra konek Cuk")
	'	End Try



	'End Sub
	Public IsbnBuku As String
	Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CBMonthly.Items.Add("Januari")
		CBMonthly.Items.Add("Februari")
		CBMonthly.Items.Add("Maret")
		CBMonthly.Items.Add("April")
		CBMonthly.Items.Add("Mei")
		CBMonthly.Items.Add("Juni")
		CBMonthly.Items.Add("Juli")
		CBMonthly.Items.Add("Agustus")
		CBMonthly.Items.Add("September")
		CBMonthly.Items.Add("Oktober")
		CBMonthly.Items.Add("November")
		CBMonthly.Items.Add("Desember")

		CBStartMonthly.Items.Add("Januari")
		CBStartMonthly.Items.Add("Februari")
		CBStartMonthly.Items.Add("Maret")
		CBStartMonthly.Items.Add("April")
		CBStartMonthly.Items.Add("Mei")
		CBStartMonthly.Items.Add("Juni")
		CBStartMonthly.Items.Add("Juli")
		CBStartMonthly.Items.Add("Agustus")
		CBStartMonthly.Items.Add("September")
		CBStartMonthly.Items.Add("Oktober")
		CBStartMonthly.Items.Add("November")
		CBStartMonthly.Items.Add("Desember")


		CBEndMonthly.Items.Add("Januari")
		CBEndMonthly.Items.Add("Februari")
		CBEndMonthly.Items.Add("Maret")
		CBEndMonthly.Items.Add("April")
		CBEndMonthly.Items.Add("Mei")
		CBEndMonthly.Items.Add("Juni")
		CBEndMonthly.Items.Add("Juli")
		CBEndMonthly.Items.Add("Agustus")
		CBEndMonthly.Items.Add("September")
		CBEndMonthly.Items.Add("Oktober")
		CBEndMonthly.Items.Add("November")
		CBEndMonthly.Items.Add("Desember")

		CBMonthly.Visible = False
		CBStartMonthly.Visible = False
		CBEndMonthly.Visible = False
		LbStartMonth.Visible = False
		LbEndMonth.Visible = False
		LbUntil.Visible = False

		RBALL.Checked = True

		LbTest.Visible = False

	End Sub

	Private Sub BtImport_Click(sender As Object, e As EventArgs) Handles BtImport.Click

		Try
			Dim CariFile As New OpenFileDialog
			With CariFile
				.Filter = "Shopee (*.xls)|*.xls|All Files (*.*)|*.*"
				.FilterIndex = 1
				.Title = "Pilih File"
			End With


			If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
				Dim NamaFile = CariFile.FileName

				Dim ConnEx As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "' ;Extended Properties = ""Excel 12.0 xml; HDR = Yes "" ")
				ConnEx.Open()

				Dim DaExShopee As New OleDbDataAdapter("SELECT * FROM [orders$A1:AS5000]", ConnEx)
				DaExShopee.TableMappings.Add("'" & NamaFile & "'", "KahananPasar_Temp")
				Dim DsExShopee As New DataSet
				DaExShopee.Fill(DsExShopee)
				ConnEx.Close()

				Dim Connes As New SqlConnection("Data Source =AERYICE-PC666\SQLEXPRESS; Initial Catalog = PIKABUK ; Integrated Security = True")
				Connes.Open()
				Dim DRowEsShopee As DataRow
				Dim DrEsShopee As SqlDataReader
				Dim CmdEsImportTempShopee As SqlCommand
				Dim CmdEsImportShopee As SqlCommand
				Dim CmdEsDellTempShopee As SqlCommand

				CmdEsDellTempShopee = New SqlCommand("DELETE FROM KahananPasar_Temp ", Connes)
				CmdEsDellTempShopee.ExecuteNonQuery()

				For Each DRowEsShopee In DsExShopee.Tables(0).Rows

					If DRowEsShopee(37).ToString = "" Then

						Dim HargaAwalShopee As String = DRowEsShopee(15)
						Dim HargaShopee As String = HargaAwalShopee.Replace("Rp", String.Empty)
						HargaAwalShopee = HargaShopee.Replace(".", String.Empty)
						Dim HargaFinalShopee As Integer = Integer.Parse(HargaAwalShopee)

						Dim QuanShopee As Integer = Integer.Parse(DRowEsShopee(16))

						Dim JudulShopee As String = DRowEsShopee(11)

						JudulShopee = JudulShopee.Replace("'", "''")

						Dim BeratShopee As String = DRowEsShopee(23)
						Dim BobotShopee As String = BeratShopee.Replace("gr", String.Empty)
						Dim BeratFinalShopee As Integer = Integer.Parse(BobotShopee)

						Dim Telepon As String = DRowEsShopee(39)
						Dim NoHp As String = Telepon.Replace("62", "0")

						Dim AlamatShopee As String = DRowEsShopee(40)
						AlamatShopee = AlamatShopee.Replace("'", "''")

						Dim PenerimaShopee As String = DRowEsShopee(38)
						PenerimaShopee = PenerimaShopee.Replace("'", "''")



						Dim Tanggal As Date
						Tanggal = Today


						CmdEsImportTempShopee = New SqlCommand("INSERT INTO KahananPasar_Temp (NoPesanan,StatusPesanan,NoResi,OpsiPengiriman,AntarkeCounterPickUp,WaktuPesananDibuat,SKUInduk,NamaProduk,HargaProduk,JumlahQty,BeratProduk,Username,NoTelepon,AlamatPengiriman,KotaKabupaten,Provinsi,Tgl_Import) VALUES ('" & DRowEsShopee(0) & "','" & DRowEsShopee(1).ToString & "','" & DRowEsShopee(3).ToString & "','" & DRowEsShopee(4).ToString & "','" & DRowEsShopee(5).ToString & "','" & DRowEsShopee(8).ToString & "','" & DRowEsShopee(10).ToString & "','" & JudulShopee & "','" & HargaFinalShopee & "','" & QuanShopee & "','" & BeratFinalShopee & "','" & PenerimaShopee & "','" & NoHp & "','" & AlamatShopee & "','" & DRowEsShopee(41) & "','" & DRowEsShopee(42) & "','" & Tanggal & "')", Connes)

						DrEsShopee = CmdEsImportTempShopee.ExecuteReader
						DrEsShopee.Close()
					Else
						Dim HargaAwalShopee As String = DRowEsShopee(15)
						Dim HargaShopee As String = HargaAwalShopee.Replace("Rp", String.Empty)
						HargaAwalShopee = HargaShopee.Replace(".", String.Empty)
						Dim HargaFinalShopee As Integer = Integer.Parse(HargaAwalShopee)

						Dim QuanShopee As Integer = Integer.Parse(DRowEsShopee(16))

						Dim JudulShopee As String = DRowEsShopee(11)
						JudulShopee = JudulShopee.Replace("'", "''")

						Dim BeratShopee As String = DRowEsShopee(23)
						Dim BobotShopee As String = BeratShopee.Replace("gr", String.Empty)
						Dim BeratFinalShopee As Integer = Integer.Parse(BobotShopee)

						Dim Telepon As String = DRowEsShopee(39)
						Dim NoHp As String = Telepon.Replace("62", "0")

						Dim AlamatShopee As String = DRowEsShopee(40)
						AlamatShopee = AlamatShopee.Replace("'", "''")

						Dim PenerimaShopee As String = DRowEsShopee(37)
						PenerimaShopee = PenerimaShopee.Replace("'", "''")



						Dim Tanggal As Date
						Tanggal = Today


						CmdEsImportTempShopee = New SqlCommand("INSERT INTO KahananPasar_Temp (NoPesanan,StatusPesanan,NoResi,OpsiPengiriman,AntarkeCounterPickUp,WaktuPesananDibuat,SKUInduk,NamaProduk,HargaProduk,JumlahQty,BeratProduk,Username,NoTelepon,AlamatPengiriman,KotaKabupaten,Provinsi,Tgl_Import) VALUES ('" & DRowEsShopee(0) & "','" & DRowEsShopee(1).ToString & "','" & DRowEsShopee(3).ToString & "','" & DRowEsShopee(4).ToString & "','" & DRowEsShopee(5).ToString & "','" & DRowEsShopee(8).ToString & "','" & DRowEsShopee(10).ToString & "','" & JudulShopee & "','" & HargaFinalShopee & "','" & QuanShopee & "','" & BeratFinalShopee & "','" & PenerimaShopee & "','" & NoHp & "','" & AlamatShopee & "','" & DRowEsShopee(41) & "','" & DRowEsShopee(42) & "','" & Tanggal & "')", Connes)

						DrEsShopee = CmdEsImportTempShopee.ExecuteReader
						DrEsShopee.Close()
					End If
				Next


				CmdEsImportShopee = New SqlCommand("INSERT INTO KahananPasar (NoPesanan,StatusPesanan,NoResi,OpsiPengiriman,AntarkeCounterPickUp,WaktuPesananDibuat,SKUInduk,NamaProduk,HargaProduk,JumlahQty,BeratProduk,Username,NoTelepon,AlamatPengiriman,KotaKabupaten,Provinsi,Tgl_Import)
												  SELECT NoPesanan,StatusPesanan,NoResi,OpsiPengiriman,AntarkeCounterPickUp,WaktuPesananDibuat,SKUInduk,NamaProduk,HargaProduk,JumlahQty,BeratProduk,Username,NoTelepon,AlamatPengiriman,KotaKabupaten,Provinsi,Tgl_Import
												  From KahananPasar_Temp
                                                  Where KahananPasar_Temp.NoPesanan Not In (Select NoPesanan FROM KahananPasar)", Connes)
				CmdEsImportShopee.ExecuteNonQuery()

				'CmdUpdateShopee = New SqlCommand("UPDATE MP_CheckingOrder  
				'									SET Proses_Status = b.Proses_Status , Tanggal_Selesai = GETDATE()
				'									FROM MP_CheckingOrder a
				'							     	INNER JOIN MP_CheckingOrder_Temp b 
				'									ON
				'									a.Invoice_OrderID = b.Invoice_OrderID 
				'									WHERE a.Proses_Status LIKE '%Terkirim%' ", Connes)
				'CmdUpdateShop.ExecuteNonQuery()

				MsgBox("Import Shopee Done!!!!")

			End If


		Catch ex As Exception

		End Try
	End Sub

	Private Sub RBMonthly_CheckedChanged(sender As Object, e As EventArgs) Handles RBMonthly.CheckedChanged
		CBMonthly.Text = ""
		CBMonthly.Visible = True
		CBStartMonthly.Visible = False
		CBEndMonthly.Visible = False
		LbStartMonth.Visible = False
		LbEndMonth.Visible = False
		LbUntil.Visible = False


	End Sub

	Private Sub RBSpecific_CheckedChanged(sender As Object, e As EventArgs) Handles RBSpecific.CheckedChanged
		CBMonthly.Visible = False
		CBStartMonthly.Visible = True
		CBEndMonthly.Visible = True
		LbStartMonth.Visible = True
		LbEndMonth.Visible = True
		LbUntil.Visible = True
		CBStartMonthly.Text = ""
		CBEndMonthly.Text = ""

		LbStartMonth.Text = "Start"
		LbEndMonth.Text = "End"
		LbUntil.Text = "--->"
	End Sub

	Private Sub RBALL_CheckedChanged(sender As Object, e As EventArgs) Handles RBALL.CheckedChanged
		CBMonthly.Visible = False
		CBStartMonthly.Visible = False
		CBEndMonthly.Visible = False
		LbStartMonth.Visible = False
		LbEndMonth.Visible = False
		LbUntil.Visible = False
	End Sub

	Private Sub BtAnalyze_Click(sender As Object, e As EventArgs) Handles BtAnalyze.Click

		'FormLoading.Show()
		If RBALL.Checked = True Then
			Dim ConPik As New SqlConnection("Data Source =AERYICE-PC666\SQLEXPRESS; Initial Catalog = PIKABUK ; Integrated Security = True")
			ConPik.Open()

			Dim DaBestSeller As SqlDataAdapter
			Dim DsBestSeller As DataSet

			DaBestSeller = New SqlDataAdapter("SELECT TOP 25 a.NamaProduk, a.SKUInduk As ISBN, b.OPTFLD4 As KodeBarang, COUNT(a.JumlahQty) As JmlOrder, c.Stock AS StockPOE
			From PIKABUK..KahananPasar a
			Join SRV4.BRDJKT.dbo.ICITEM b 
			On a.SKUInduk = b.FMTITEMNO
			Join SRV4.INV.dbo.INV_SALES c 
			On a.SKUInduk = c.item
			WHERE c.[location] = 'PP341'
			Group BY a.NamaProduk , a.SKUInduk, b.OPTFLD4, c.stock
			ORDER BY JmlOrder DESC", ConPik)
			DsBestSeller = New DataSet
			DaBestSeller.Fill(DsBestSeller)
			DGVBestSeller.DataSource = DsBestSeller.Tables(0)

			Dim ConnPIKABUK As New SqlConnection("Data Source =AERYICE-PC666\SQLEXPRESS; Initial Catalog = PIKABUK ; Integrated Security = True")
			ConnPIKABUK.Open()
			Dim DaBestAuthor As SqlDataAdapter
			Dim DsBestAuthor As DataSet

			DaBestAuthor = New SqlDataAdapter("SELECT TOP 25 a.COMMENT1 AS AUTHOR , Count(a.COMMENT1) AS Jumlah,Sum(b.TotalHargaProduk) AS Sales,CEILING(sum(b.TotalHargaProduk)/count(a.COMMENT1)) AS AVG
			FROM SRV4.BRDJKT.dbo.ICITEM a
			JOIN PIKABUK..KahananPasar b
			ON a.ITEMNO = b.SKUInduk
			GROUP BY a.COMMENT1
			ORDER BY Jumlah DESC", ConnPIKABUK)

			DsBestAuthor = New DataSet
			DaBestAuthor.Fill(DsBestAuthor)
			DGVBestAuthor.DataSource = DsBestAuthor.Tables(0)

			Dim DaBestKat As SqlDataAdapter
			Dim DsBestKat As DataSet

			DaBestKat = New SqlDataAdapter("SELECT TOP 15 (RTrim(c.[code])+c.[data])AS KAT, SUM(b.JumlahQty) AS Orderan ,SUm(b.TotalHargaProduk) AS Sales
			From SRV4.BRDJKT.dbo.ICITEM a 
			JOIN PIKABUK..KahananPasar b
			ON a.ITEMNO = b.SKUInduk
			Join SRV4.BRDJKT.dbo.CSOPT c
			On a.OPTFLD3 = c.CODE
			GROUP BY c.Code,C.[Data]
			ORDER BY Orderan DESC", ConnPIKABUK)

			DsBestKat = New DataSet
			DaBestKat.Fill(DsBestKat)
			DGVBestKat.DataSource = DsBestKat.Tables(0)

			Dim DaLoyalCust As SqlDataAdapter
			Dim DsLoyalCust As DataSet

			DaLoyalCust = New SqlDataAdapter("SELECT Username,SUM(JumlahQty) AS Orderan,SUM (JumlahQty * HargaProduk )AS Belanja 
			FROM KahananPasar
			GROUP BY Username
			ORder By Orderan DESC", ConnPIKABUK)

			DsLoyalCust = New DataSet
			DaLoyalCust.Fill(DsLoyalCust)
			DGVLoyalCust.DataSource = DsLoyalCust.Tables(0)

			Dim DaBestDay As SqlDataAdapter
			Dim DsBestDay As DataSet

			DaBestDay = New SqlDataAdapter("SELECT Convert(varchar,WaktuPesananDibuat,101) AS Tanggal, Count(JumlahQty) As JmlOrder,SUM(TotalHargaProduk) AS Sales
			FROM KahananPasar
			Group BY Convert(varchar,WaktuPesananDibuat,101)
			ORDER BY Sales DESC", ConnPIKABUK)

			DsBestDay = New DataSet
			DaBestDay.Fill(DsBestDay)
			DGVBestDay.DataSource = DsBestDay.Tables(0)
		End If
	End Sub

	Private Sub DGVBestSeller_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBestSeller.CellContentClick
		FormDetailedBuku.Show()
		Dim Index As Integer
		Index = e.RowIndex
		Dim SelectedRow As DataGridViewRow
		SelectedRow = DGVBestSeller.Rows(Index)

		Dim ConnBRDJKT As New SqlConnection("SERVER =SRV4; Initial Catalog = BRDJKT; User Id = sa ;Password =")
		ConnBRDJKT.Open()

		Dim CMDBestSeller As SqlCommand
		Dim DrBestSeller As SqlDataReader

		CMDBestSeller = New SqlCommand("SELECT a.[DESC] AS Judul , (RTRIM(a.FMTITEMNO)) As ISBN, a.OPTFLD4 As KodeBarang, 
			(RTrim(c.[code])+c.[data])AS KAT,(RTRIM(a.COMMENT1)) AS AUTHOR,
			ISNULL((SELECT c.[Data] FROM SRV4.BRDJKT.dbo.CSOPT c WHERE a.OPTFLD5 = c.CODE And [TABLE] ='PUBLISH' ),0) AS Publisher
			From SRV4.BRDJKT.dbo.ICITEM a 
			Join SRV4.INV.dbo.INV_SALES b 
			On a.FMTITEMNO = b.item
			Join SRV4.BRDJKT.dbo.CSOPT c
			On a.OPTFLD3 = c.CODE
			WHERE a.FMTITEMNO = '" & SelectedRow.Cells(1).Value & "'
			Group BY a.[DESC] , a.FMTITEMNO, a.OPTFLD4, c.Code, c.[data], a.COMMENT1, a.OPTFLD5", ConnBRDJKT)
		DrBestSeller = CMDBestSeller.ExecuteReader
		DrBestSeller.Read()



		'When Value result is from joining table.. use alias, so program can exactly find the column name
		FormDetailedBuku.LbNamaJudulBuku.Text = Convert.ToString(DrBestSeller.Item("Judul"))
		FormDetailedBuku.LbISBNBuku.Text = Convert.ToString(DrBestSeller.Item("ISBN"))
		FormDetailedBuku.LbKodeBuku.Text = Convert.ToString(DrBestSeller.Item("KodeBarang"))
		FormDetailedBuku.LbKatBuku.Text = Convert.ToString(DrBestSeller.Item("KAT"))
		FormDetailedBuku.LbAuthorBuku.Text = Convert.ToString(DrBestSeller.Item("AUTHOR"))
		FormDetailedBuku.LbPublisherBuku.Text = Convert.ToString(DrBestSeller.Item("Publisher"))
		Me.LbTest.Text = Convert.ToString(DrBestSeller.Item("ISBN"))
		IsbnBuku = LbTest.Text
		FormDetailedBuku.TBURLISBN.Text = Convert.ToString(DrBestSeller.Item("ISBN"))
		'Dim IsbnUrl As String = FormDetailedBuku.TBURLISBN.Text
		'FormDetailedBuku.PBBuku.ImageLocation = "http://st.xsm.us/c/b/'" & IsbnUrl & "'"
		ConnBRDJKT.Close()

		Dim ConnINV As SqlConnection
		Dim DaStockBuku As SqlDataAdapter
		Dim DsStockBuku As DataSet

		ConnINV = New SqlConnection("SERVER =SRV4; Initial Catalog = INV; User Id = sa ;Password =")
		ConnINV.Open()

		Dim IndexStock As Integer
		IndexStock = e.RowIndex
		Dim SelectedRowStock As DataGridViewRow
		SelectedRowStock = DGVBestSeller.Rows(Index)

		DaStockBuku = New SqlDataAdapter("SELECT a.[location] AS LOC,b.[DESC] AS TOKO,a.kdbrg AS KODE,a.harga AS HARGA,a.M1 AS H7,a.M2 AS H14,a.ams AS AMS,a.MDS ,a.stock AS STOCK
			FROM SRV4.INV.dbo.INV_SALES a
			JOIN SRV4.BRDJKT.dbo.ICLOC b
			ON a.[location] = b.[location]
			WHERE a.[location] LIKE 'PP3%' AND a.kdbrg = '" & SelectedRowStock.Cells(2).Value & "' AND b.INACTIVE = 0
			ORDER BY a.[location]", ConnINV)
		DsStockBuku = New DataSet
		DaStockBuku.Fill(DsStockBuku)
		FormDetailedBuku.DGVStock.DataSource = DsStockBuku.Tables(0)
		FormDetailedBuku.DGVStock.Columns(0).Width = 75 'LOC
		FormDetailedBuku.DGVStock.Columns(1).Width = 200 'TOKO
		FormDetailedBuku.DGVStock.Columns(3).Width = 75 'HARGA
		FormDetailedBuku.DGVStock.Columns(4).Width = 35 'H7
		FormDetailedBuku.DGVStock.Columns(5).Width = 45 'H14
		FormDetailedBuku.DGVStock.Columns(6).Width = 55 'AMS
		FormDetailedBuku.DGVStock.Columns(7).Width = 55 'MDS
		FormDetailedBuku.DGVStock.Columns(8).Width = 65 'Stock

		For Baris As Integer = 0 To FormDetailedBuku.DGVStock.Rows.Count - 1
			If FormDetailedBuku.DGVStock.Rows(Baris).Cells(8).Value > (FormDetailedBuku.DGVStock.Rows(Baris).Cells(7).Value) Then
				FormDetailedBuku.DGVStock.Rows(Baris).DefaultCellStyle.BackColor = Color.LightGreen
				'FormDetailedBuku.DGVStock.Rows(Baris).Cells(C).Style.Font.Bold = New Font(FormDetailedBuku.DGVStock.Font, Font.Bold)

			End If
		Next

	End Sub
End Class