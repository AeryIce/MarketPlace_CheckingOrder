Imports System.Data.SqlClient
Public Class FormAdmin

	Sub IsiDGV()
		Call Konek()
		Dim DaIsiDGVLoad As SqlDataAdapter
		Dim DsIsiDGVLoad As DataSet
		DaIsiDGVLoad = New SqlDataAdapter("SELECT MP, Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder ORDER BY Tanggal_Pesanan", ConnectDb)
		DsIsiDGVLoad = New DataSet
		DaIsiDGVLoad.Fill(DsIsiDGVLoad)
		DGVAdmin.DataSource = DsIsiDGVLoad.Tables(0)

		For Baris As Integer = 0 To DGVAdmin.RowCount - 1
			If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
				DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
			Else
				DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow
			End If
		Next

	End Sub

	Sub AllAll()

	End Sub
	Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim TanggalNow As Date
		TanggalNow = Today
		Me.LbTgl.Text = Format(TanggalNow, "dd/MM/yyyy")

		Call Konek()
		Cmd = New SqlCommand("SELECT SUM(Total_Harga) AS Totalan FROM MP_CheckingOrder", ConnectDb)

		Dr = Cmd.ExecuteReader
		Dr.Read()
		Dim PiyeTo As Integer = Dr("Totalan")
		Dim SalesPer As Integer
		SalesPer = Integer.Parse(PiyeTo, System.Globalization.NumberStyles.Integer Or System.Globalization.NumberStyles.AllowThousands)
		Me.LbNominal.Text = ("RP. " + Format(SalesPer, "#,#"))

		Call IsiDGV()




	End Sub

	Private Sub TBCariInvoice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCariInvoice.KeyPress
		If e.KeyChar = Chr(13) Then
			BtCariInvoice.PerformClick()

		End If

	End Sub

	Private Sub BtCariInvoice_Click(sender As Object, e As EventArgs) Handles BtCariInvoice.Click
		Call Konek()
		Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE Invoice_OrderID = '" & TBCariInvoice.Text & "' ", ConnectDb)
		Ds = New DataSet
		Da.Fill(Ds)
		DGVAdmin.DataSource = Ds.Tables(0)
		'TextBoxScanIsbn.Text = ""
		For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
			If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
				DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
			Else
				DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

			End If
		Next
	End Sub



	Private Sub RBSemuaStatus_CheckedChanged(sender As Object, e As EventArgs) Handles RBAll.CheckedChanged
		If RBSemua.Checked = True Then
			Dim DaAllMP = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder ", ConnectDb)
			Dim DsAllMP = New DataSet
			DaAllMP.Fill(DsAllMP)
			DGVAdmin.DataSource = DsAllMP.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBShopee.Checked = True Then
			Dim DaShopeeAll = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee'", ConnectDb)
			Dim DsShopeeAll = New DataSet
			DaShopeeAll.Fill(DsShopeeAll)
			DGVAdmin.DataSource = DsShopeeAll.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaTokopediaAll = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia'", ConnectDb)
			Dim DsTokopediaAll = New DataSet
			DaTokopediaAll.Fill(DsTokopediaAll)
			DGVAdmin.DataSource = DsTokopediaAll.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		End If
	End Sub

	Private Sub RBSemua_CheckedChanged(sender As Object, e As EventArgs) Handles RBSemua.CheckedChanged
		If RBAll.Checked = True Then
			Dim DaSemuaTokoAll = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder ", ConnectDb)
			Dim DsSemuaTokoAll = New DataSet
			DaSemuaTokoAll.Fill(DsSemuaTokoAll)
			DGVAdmin.DataSource = DsSemuaTokoAll.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBTerkirim.Checked = True Then
			Dim DaSemuaTokoTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%') ", ConnectDb)
			Dim DsSemuaTokoTerkirim = New DataSet
			DaSemuaTokoTerkirim.Fill(DsSemuaTokoTerkirim)
			DGVAdmin.DataSource = DsSemuaTokoTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBSelesai.Checked = True Then
			Dim DaSemuaTokoSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%') ", ConnectDb)
			Dim DsSemuaTokoSelesai = New DataSet
			DaSemuaTokoSelesai.Fill(DsSemuaTokoSelesai)
			DGVAdmin.DataSource = DsSemuaTokoSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBBatal.Checked = True Then
			Dim DaSemuaTokoBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%') ", ConnectDb)
			Dim DsSemuaTokoBatal = New DataSet
			DaSemuaTokoBatal.Fill(DsSemuaTokoBatal)
			DGVAdmin.DataSource = DsSemuaTokoBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaSemuaTokoOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan diOnProcesskan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%OnProcess%' OR Proses_Status LIKE '%Transaksi diOnProcesskan.%') ", ConnectDb)
			Dim DsSemuaTokoOnProcess = New DataSet
			DaSemuaTokoOnProcess.Fill(DsSemuaTokoOnProcess)
			DGVAdmin.DataSource = DsSemuaTokoOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next

		End If
	End Sub

	Private Sub RBShopee_CheckedChanged(sender As Object, e As EventArgs) Handles RBShopee.CheckedChanged
		If RBAll.Checked = True Then
			Dim DaSemuaTokoAll = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee' ", ConnectDb)
			Dim DsSemuaTokoAll = New DataSet
			DaSemuaTokoAll.Fill(DsSemuaTokoAll)
			DGVAdmin.DataSource = DsSemuaTokoAll.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBTerkirim.Checked = True Then
			Dim DaSemuaTokoTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%') AND MP = 'Shopee' ", ConnectDb)
			Dim DsSemuaTokoTerkirim = New DataSet
			DaSemuaTokoTerkirim.Fill(DsSemuaTokoTerkirim)
			DGVAdmin.DataSource = DsSemuaTokoTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBSelesai.Checked = True Then
			Dim DaSemuaTokoSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%') AND MP = 'Shopee' ", ConnectDb)
			Dim DsSemuaTokoSelesai = New DataSet
			DaSemuaTokoSelesai.Fill(DsSemuaTokoSelesai)
			DGVAdmin.DataSource = DsSemuaTokoSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBBatal.Checked = True Then
			Dim DaSemuaTokoBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%') AND MP = 'Shopee' ", ConnectDb)
			Dim DsSemuaTokoBatal = New DataSet
			DaSemuaTokoBatal.Fill(DsSemuaTokoBatal)
			DGVAdmin.DataSource = DsSemuaTokoBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaSemuaTokoOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan diOnProcesskan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%OnProcess%' OR Proses_Status LIKE '%Transaksi diOnProcesskan.%') AND MP = 'Shopee' ", ConnectDb)
			Dim DsSemuaTokoOnProcess = New DataSet
			DaSemuaTokoOnProcess.Fill(DsSemuaTokoOnProcess)
			DGVAdmin.DataSource = DsSemuaTokoOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next

		End If
	End Sub

	Private Sub RBTokopedia_CheckedChanged(sender As Object, e As EventArgs) Handles RBTokopedia.CheckedChanged
		If RBAll.Checked = True Then
			Dim DaSemuaTokoAll = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia' ", ConnectDb)
			Dim DsSemuaTokoAll = New DataSet
			DaSemuaTokoAll.Fill(DsSemuaTokoAll)
			DGVAdmin.DataSource = DsSemuaTokoAll.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBTerkirim.Checked = True Then
			Dim DaSemuaTokoTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%') AND MP = 'TokoPedia' ", ConnectDb)
			Dim DsSemuaTokoTerkirim = New DataSet
			DaSemuaTokoTerkirim.Fill(DsSemuaTokoTerkirim)
			DGVAdmin.DataSource = DsSemuaTokoTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBSelesai.Checked = True Then
			Dim DaSemuaTokoSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%') AND MP = 'TokoPedia' ", ConnectDb)
			Dim DsSemuaTokoSelesai = New DataSet
			DaSemuaTokoSelesai.Fill(DsSemuaTokoSelesai)
			DGVAdmin.DataSource = DsSemuaTokoSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBBatal.Checked = True Then
			Dim DaSemuaTokoBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%') AND MP = 'TokoPedia' ", ConnectDb)
			Dim DsSemuaTokoBatal = New DataSet
			DaSemuaTokoBatal.Fill(DsSemuaTokoBatal)
			DGVAdmin.DataSource = DsSemuaTokoBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaSemuaTokoOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan diOnProcesskan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%OnProcess%' OR Proses_Status LIKE '%Transaksi diOnProcesskan.%') AND MP = 'TokoPedia' ", ConnectDb)
			Dim DsSemuaTokoOnProcess = New DataSet
			DaSemuaTokoOnProcess.Fill(DsSemuaTokoOnProcess)
			DGVAdmin.DataSource = DsSemuaTokoOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next

		End If
	End Sub

	Private Sub RBTerkirim_CheckedChanged(sender As Object, e As EventArgs) Handles RBTerkirim.CheckedChanged
		If RBSemua.Checked = True Then
			Dim DaSemuaTokoTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%')", ConnectDb)
			Dim DsSemuaTokoTerkirim = New DataSet
			DaSemuaTokoTerkirim.Fill(DsSemuaTokoTerkirim)
			DGVAdmin.DataSource = DsSemuaTokoTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBShopee.Checked = True Then
			Dim DaShopeeTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee' AND (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%')", ConnectDb)
			Dim DsShopeeTerkirim = New DataSet
			DaShopeeTerkirim.Fill(DsShopeeTerkirim)
			DGVAdmin.DataSource = DsShopeeTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaTokopediaTerkirim = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia' AND (Proses_Status LIKE '%Pesanan telah dikirim.. Pesanan dalam proses pengiriman oleh kurir.%' OR Proses_Status LIKE '%Sedang Dikirim%')", ConnectDb)
			Dim DsTokopediaTerkirim = New DataSet
			DaTokopediaTerkirim.Fill(DsTokopediaTerkirim)
			DGVAdmin.DataSource = DsTokopediaTerkirim.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		End If

	End Sub

	Private Sub RBSelesai_CheckedChanged(sender As Object, e As EventArgs) Handles RBSelesai.CheckedChanged
		If RBSemua.Checked = True Then
			Dim DaSemuaTokoSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%')", ConnectDb)
			Dim DsSemuaTokoSelesai = New DataSet
			DaSemuaTokoSelesai.Fill(DsSemuaTokoSelesai)
			DGVAdmin.DataSource = DsSemuaTokoSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBShopee.Checked = True Then
			Dim DaShopeeSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee' AND (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%')", ConnectDb)
			Dim DsShopeeSelesai = New DataSet
			DaShopeeSelesai.Fill(DsShopeeSelesai)
			DGVAdmin.DataSource = DsShopeeSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaTokopediaSelesai = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia' AND (Proses_Status LIKE '%Transaksi selesai.. Dana akan diteruskan ke penjual.%' OR Proses_Status LIKE '%Pesanan telah tiba di tujuan.. Dana akan diteruskan ketika barang dikonfirmasi pembeli atau otomatis dalam 48 jam.%' OR Proses_Status LIKE '%Selesai%')", ConnectDb)
			Dim DsTokopediaSelesai = New DataSet
			DaTokopediaSelesai.Fill(DsTokopediaSelesai)
			DGVAdmin.DataSource = DsTokopediaSelesai.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		End If
	End Sub

	Private Sub RBBatal_CheckedChanged(sender As Object, e As EventArgs) Handles RBBatal.CheckedChanged
		If RBSemua.Checked = True Then
			Dim DaSemuaTokoBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%')", ConnectDb)
			Dim DsSemuaTokoBatal = New DataSet
			DaSemuaTokoBatal.Fill(DsSemuaTokoBatal)
			DGVAdmin.DataSource = DsSemuaTokoBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBShopee.Checked = True Then
			Dim DaShopeeBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee' AND (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%')", ConnectDb)
			Dim DsShopeeBatal = New DataSet
			DaShopeeBatal.Fill(DsShopeeBatal)
			DGVAdmin.DataSource = DsShopeeBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaTokopediaBatal = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia' AND (Proses_Status LIKE '%Pesanan dibatalkan pembeli.%' OR Proses_Status LIKE '%Transaksi ditolak.%' OR Proses_Status LIKE '%Batal%' OR Proses_Status LIKE '%Transaksi dibatalkan.%')", ConnectDb)
			Dim DsTokopediaBatal = New DataSet
			DaTokopediaBatal.Fill(DsTokopediaBatal)
			DGVAdmin.DataSource = DsTokopediaBatal.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		End If
	End Sub

	Private Sub RBProces_CheckedChanged(sender As Object, e As EventArgs) Handles RBProces.CheckedChanged
		If RBSemua.Checked = True Then
			Dim DaSemuaTokoOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE (Proses_Status LIKE '%Pemesanan sedang diproses oleh penjual.%' OR Proses_Status LIKE '%Perlu Dikirim%' OR Proses_Status LIKE '%Menunggu Pick Up%' OR Proses_Status LIKE '%Verifikasi Konfirmasi Pembayaran.. Pembayaran telah diterima Tokopedia dan pesanan sudah diteruskan ke penjual.%')", ConnectDb)
			Dim DsSemuaTokoOnProcess = New DataSet
			DaSemuaTokoOnProcess.Fill(DsSemuaTokoOnProcess)
			DGVAdmin.DataSource = DsSemuaTokoOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		ElseIf RBShopee.Checked = True Then
			Dim DaShopeeOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'Shopee' AND (Proses_Status LIKE '%Pemesanan sedang diproses oleh penjual.%' OR Proses_Status LIKE '%Perlu Dikirim%' OR Proses_Status LIKE '%Menunggu Pick Up%' OR Proses_Status LIKE '%Verifikasi Konfirmasi Pembayaran.. Pembayaran telah diterima Tokopedia dan pesanan sudah diteruskan ke penjual.%')", ConnectDb)
			Dim DsShopeeOnProcess = New DataSet
			DaShopeeOnProcess.Fill(DsShopeeOnProcess)
			DGVAdmin.DataSource = DsShopeeOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		Else
			Dim DaTokopediaOnProcess = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Total_Harga,Courrier FROM MP_CheckingOrder WHERE MP = 'TokoPedia' AND (Proses_Status LIKE '%Pemesanan sedang diproses oleh penjual.%' OR Proses_Status LIKE '%Perlu Dikirim%' OR Proses_Status LIKE '%Menunggu Pick Up%' OR Proses_Status LIKE '%Verifikasi Konfirmasi Pembayaran.. Pembayaran telah diterima Tokopedia dan pesanan sudah diteruskan ke penjual.%')", ConnectDb)
			Dim DsTokopediaOnProcess = New DataSet
			DaTokopediaOnProcess.Fill(DsTokopediaOnProcess)
			DGVAdmin.DataSource = DsTokopediaOnProcess.Tables(0)
			For Baris As Integer = 0 To DGVAdmin.Rows.Count - 1
				If DGVAdmin.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGVAdmin.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

				End If
			Next
		End If
	End Sub
End Class