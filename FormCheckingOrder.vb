﻿Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Text.RegularExpressions
Public Class FormCheckingOrder
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub
	Private Sub FormCheckingOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Konek()
		ComboBoxPilihMP.Items.Add("TokoPedia")
		ComboBoxPilihMP.Items.Add("Shopee")
		DGV_MPCheckingOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		DGV_MPCheckingOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
	End Sub

	Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click

		If ComboBoxPilihMP.Text = "TokoPedia" Then
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
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder_Temp")
					Dim DsEx As New DataSet
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
					ConnEs.Open()
					Dim DrwEs As DataRow
					Dim DrEs As SqlDataReader
					Dim CmdEs As SqlCommand
					Dim CmdEsDell As SqlCommand
					Dim CmdEsImport As SqlCommand
					Dim CmdUpdate As SqlCommand

					CmdEsDell = New SqlCommand("DELETE FROM MP_CheckingOrder_Temp WHERE MP = 'TokoPedia' ", ConnEs)
					CmdEsDell.ExecuteNonQuery()

					For Each DrwEs In DsEx.Tables(0).Rows


						If IsDate(DrwEs(3)) Then
							Dim Judul As String = DrwEs(6)
							Judul = Judul.Replace("'", "''")

							Dim Alamat As String = DrwEs(17)
							Alamat = Alamat.Replace("'", "''")

							Dim regDate As Date = DrwEs(3)
							'Dim strDate As String = regDate.ToString("dd-MM-yyyy")

							CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) VALUES 
											  ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(2).ToString & "','" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "',
											   '" & Judul & "'," & DrwEs(7) & "," & DrwEs(10) & ",'" & DrwEs(18).ToString & "','" & Alamat & "','" & DrwEs(13).ToString & "',
											   '" & DrwEs(15).ToString & "','" & DrwEs(14).ToString & "','" & regDate & "','" & DrwEs(4).ToString & "' ) ", ConnEs)
							DrEs = CmdEs.ExecuteReader
							DrEs.Close()
							'WHERE NOT EXIST ( SELECT '" & DrwEs(1).ToString & "' FROM MP_CheckingOrder_Temp WHERE Proses_Status = 1  )
						Else
							Dim Judul As String = DrwEs(6)
							Judul = Judul.Replace("'", "''")

							Dim Alamat As String = DrwEs(17)
							Alamat = Alamat.Replace("'", "''")

							''Dim Tanggal As String = DrwEs(3).Text
							''Dim TrimTanggal As String
							''Dim Potong As Integer = 10
							''TrimTanggal = LTrim(DrwEs(3).ToString, Potong)

							Dim Tanggal As String = DrwEs(3)
							'Dim Rgx As New Regex("[0-9]")
							'Dim Hasil As String = Regex.Replace(Tanggal, "[0-9]", String.Empty)
							'Tanggal = Tanggal.Replace("[0-9]", "")

							Dim FinalTanggal As String = Tanggal
							FinalTanggal = FinalTanggal.Replace(":", "")

							Dim TrimTanggal As String
							TrimTanggal = FinalTanggal.Substring(0, FinalTanggal.Length - 7)

							'Dim PokokeTanggal As Date = TrimTanggal


							Dim ConvertTanggal = Date.ParseExact(TrimTanggal, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture)
							'Dim CobaTanggal As String = ConvertTanggal

							'Dim ConvertTanggal As String = TrimTanggal.ToString("yyyy-MM-dd")
							'Dim ConvertTanggal As DateTime = DateTime.ParseExact(ConvertTanggal, "dd-MM-yyyy", Nothing)
							'MsgBox(ConvertTanggal.ToString())

							'Dim Coba As String = "test isDate"
							'MsgBox(Coba)

							CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) VALUES 
											  ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(2).ToString & "','" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "',
											   '" & Judul & "'," & DrwEs(7) & "," & DrwEs(10) & ",'" & DrwEs(18).ToString & "','" & Alamat & "','" & DrwEs(13).ToString & "',
											   '" & DrwEs(15).ToString & "','" & DrwEs(14).ToString & "','" & ConvertTanggal.ToString() & "','" & DrwEs(4).ToString & "' ) ", ConnEs)
							DrEs = CmdEs.ExecuteReader
							DrEs.Close()
						End If

					Next


					'<-- To Delete Duplicate Value -->
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
					'ConnEs.Close()
					'ConnEsDup.Close()
					' <-- End -->

					CmdEsImport = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status)
												  SELECT MP,Invoice_OrderID, Resi, ISBN, Judul, QTY, Harga, Courrier, [Address], Nama_Cust, Nama_Penerima, No_Hp_Cus, Tanggal_Pesanan,Proses_Status
												  From MP_CheckingOrder_Temp
                                                  Where MP_CheckingOrder_Temp.Invoice_OrderID Not In (Select Invoice_OrderID FROM MP_CheckingOrder)", ConnEs)
					CmdEsImport.ExecuteNonQuery()


					CmdUpdate = New SqlCommand("UPDATE MP_CheckingOrder  
													SET Proses_Status = b.Proses_Status  , Tanggal_Selesai = GETDATE()
													FROM MP_CheckingOrder a
											     	INNER JOIN MP_CheckingOrder_Temp b 
													ON
													a.Invoice_OrderID = b.Invoice_OrderID 
													WHERE a.Proses_Status LIKE '%Terkirim%' ", ConnEs)
					CmdUpdate.ExecuteNonQuery()

					MsgBox("Import Tokopedia Done !!!!")


				End If
			Catch ex As Exception

			End Try

		ElseIf ComboBoxPilihMP.Text = "Shopee" Then
			'Dim Loc As String
			'Loc = "PP342"
			'Dim Tanggal As Date
			'Tanggal = Today

			Try
				Dim CariFile As New OpenFileDialog
				With CariFile
					.Filter = " Shopee (*.xls)|*.xls|All Files (*.*)|*.* "
					.FilterIndex = 1
					.Title = "Pilih File"

				End With

				If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
					Dim NamaFile = CariFile.FileName
					Dim ConnEx As New OleDbConnection(" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "';Extended Properties = ""Excel 12.0 xml;HDR = Yes"" ")
					ConnEx.Open()

					Dim DaEx1 As New OleDbDataAdapter("SELECT * FROM [orders$A1:AS5000]", ConnEx)
					DaEx1.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder_Temp")
					Dim DsEx1 As New DataSet
					Dim DtEx1 As New DataTable
					DaEx1.Fill(DsEx1)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = TRUE")
					ConnEs.Open()
					Dim DrwEs1 As DataRow
					Dim DrEs1 As SqlDataReader
					Dim CmdEs1 As SqlCommand
					Dim CmdEsDell1 As SqlCommand
					Dim CmdEsImportShop As SqlCommand
					Dim CmdUpdateShop As SqlCommand

					CmdEsDell1 = New SqlCommand("DELETE FROM MP_CheckingOrder_Temp WHERE MP = 'Shopee' ", ConnEs)
					CmdEsDell1.ExecuteNonQuery()

					For Each DrwEs1 In DsEx1.Tables(0).Rows


						If DrwEs1(38).ToString = "" Then


							Dim HargaAwal As String = DrwEs1(16)
							Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
							HargaAwal = harga.Replace(".", String.Empty)
							Dim HargaFinal As Integer = Integer.Parse(HargaAwal)

							Dim Quan As Integer = Integer.Parse(DrwEs1(17))

							Dim judul1 As String = DrwEs1(12)
							judul1 = judul1.Replace("'", "''")

							Dim alamat1 As String = DrwEs1(41)
							alamat1 = alamat1.Replace("'", "''")

							Dim penerima1 As String = DrwEs1(39)
							penerima1 = penerima1.Replace("'", "''")


							CmdEs1 = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) 
													VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs1(0).ToString & "','" & DrwEs1(4).ToString & "','" & DrwEs1(11).ToString & "','" & judul1 & "',
															'" & Quan & "','" & HargaFinal & "','" & DrwEs1(5).ToString & "','" & alamat1 & "','" & penerima1 & "','" & penerima1 & "','" & DrwEs1(40).ToString & "',
															'" & DrwEs1(9).ToString & "','" & DrwEs1(1).ToString & "')", ConnEs)
							DrEs1 = CmdEs1.ExecuteReader
							DrEs1.Close()

						Else

							Dim HargaAwal As String = DrwEs1(16)
							Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
							HargaAwal = harga.Replace(".", String.Empty)
							Dim HargaFinal As Integer = Integer.Parse(HargaAwal)

							Dim Quan As Integer = Integer.Parse(DrwEs1(17))

							Dim judul1 As String = DrwEs1(12)
							judul1 = judul1.Replace("'", "''")

							Dim alamat1 As String = DrwEs1(41)
							alamat1 = alamat1.Replace("'", "''")

							Dim penerima1 As String = DrwEs1(39)
							penerima1 = penerima1.Replace("'", "''")

							Dim namacust1 As String = DrwEs1(38)
							namacust1 = namacust1.Replace("'", "''")

							CmdEs1 = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) 
														VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs1(0).ToString & "','" & DrwEs1(4).ToString & "','" & DrwEs1(11).ToString & "','" & judul1 & "',
																'" & Quan & "','" & HargaFinal & "','" & DrwEs1(5).ToString & "','" & alamat1 & "','" & namacust1 & "','" & penerima1 & "','" & DrwEs1(40).ToString & "',
																'" & DrwEs1(9).ToString & "','" & DrwEs1(1).ToString & "')", ConnEs)
							DrEs1 = CmdEs1.ExecuteReader
							DrEs1.Close()

						End If


					Next

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

					CmdEsImportShop = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status)
												  SELECT MP,Invoice_OrderID, Resi, ISBN, Judul, QTY, Harga, Courrier, [Address], Nama_Cust, Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status
												  From MP_CheckingOrder_Temp
                                                  Where MP_CheckingOrder_Temp.Invoice_OrderID Not In (Select Invoice_OrderID FROM MP_CheckingOrder)", ConnEs)
					CmdEsImportShop.ExecuteNonQuery()

					CmdUpdateShop = New SqlCommand("UPDATE MP_CheckingOrder  
													SET Proses_Status = b.Proses_Status , Tanggal_Selesai = GETDATE()
													FROM MP_CheckingOrder a
											     	INNER JOIN MP_CheckingOrder_Temp b 
													ON
													a.Invoice_OrderID = b.Invoice_OrderID 
													WHERE a.Proses_Status LIKE '%Terkirim%' ", ConnEs)
					CmdUpdateShop.ExecuteNonQuery()

					MsgBox("Import Shopee Done!!!!")
				End If
			Catch ex As Exception

			End Try

		Else
			MsgBox("Pilih Marketplace Yang Akan Diimport !!!")
		End If
	End Sub
	Private Shared Sub NewMethod(ConnEs As SqlConnection)
		ConnEs.Close()
	End Sub
	Private Sub ButtonCariISBN_Click(sender As Object, e As EventArgs) Handles ButtonCariISBN.Click
		Call Konek()
		Cmd = New SqlCommand("SELECT * FROM MP_CheckingOrder WHERE isbn ='" & TextBoxScanIsbn.Text & "' ", ConnectDb)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			Call Konek()
			Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE isbn ='" & TextBoxScanIsbn.Text & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%') ", ConnectDb)
			Ds = New DataSet
			Da.Fill(Ds)
			DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
			'TextBoxScanIsbn.Text = ""
			For Baris As Integer = 0 To DGV_MPCheckingOrder.Rows.Count - 1
				If DGV_MPCheckingOrder.Rows(Baris).Cells(0).Value = "TokoPedia" Then
					DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
				Else
					DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.Pink

				End If
			Next
			TextBoxScanIsbn.Focus()
				Else
			Call Konek()
			Cmd = New SqlCommand("SELECT * FROM MP_CheckingOrder WHERE Invoice_OrderID ='" & TextBoxScanIsbn.Text & "' ", ConnectDb)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				Call Konek()
				Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE Invoice_OrderID ='" & TextBoxScanIsbn.Text & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%') ", ConnectDb)
				Ds = New DataSet
				Da.Fill(Ds)
				DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
				'TextBoxScanIsbn.Text = ""
				For Baris As Integer = 0 To DGV_MPCheckingOrder.Rows.Count - 1
					If DGV_MPCheckingOrder.Rows(Baris).Cells(0).Value = "TokoPedia" Then
						DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
					Else
						DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.Pink

					End If
				Next
				TextBoxScanIsbn.Focus()
			Else

				MsgBox("Silahkan Lakukan Import Data Terbaru")

			End If
			End if

	End Sub
	Private Sub TextBoxScanIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxScanIsbn.KeyPress
		If e.KeyChar = Convert.ToChar(13) Then
			ButtonCariISBN.PerformClick()
		End If
	End Sub
	Private Sub DGV_MPCheckingOrder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_MPCheckingOrder.CellContentClick
		Call Konek()
		Dim index As Integer
		index = e.RowIndex
		Dim selectedRow As DataGridViewRow
		selectedRow = DGV_MPCheckingOrder.Rows(index)

		Try
			Cmd = New SqlCommand("SELECT * FROM MP_CheckingOrder WHERE Invoice_OrderID = '" & selectedRow.Cells(1).Value & "'", ConnectDb)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				Call Konek()
				Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE Invoice_OrderID = '" & selectedRow.Cells(1).Value & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%' ) ", ConnectDb)
				Ds = New DataSet
				Da.Fill(Ds)
				FormValidasi.DGVInvoice.DataSource = Ds.Tables(0)
				FormValidasi.Show()
			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs)
		TextBoxScanIsbn.Text = ""
		DGV_MPCheckingOrder.Columns.Clear()
	End Sub

	Private Sub RBShopee_CheckedChanged(sender As Object, e As EventArgs) Handles RBShopee.CheckedChanged
		Call Konek()
		Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE isbn ='" & TextBoxScanIsbn.Text & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%') AND MP = 'Shopee' ", ConnectDb)
		Ds = New DataSet
		Da.Fill(Ds)
		DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
		'TextBoxScanIsbn.Text = ""
		For Baris As Integer = 0 To DGV_MPCheckingOrder.Rows.Count - 1
			If DGV_MPCheckingOrder.Rows(Baris).Cells(0).Value = "TokoPedia" Then
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
			Else
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.Yellow

			End If
		Next
		TextBoxScanIsbn.Focus()
	End Sub

	Private Sub RBTokopedia_CheckedChanged(sender As Object, e As EventArgs) Handles RBTokopedia.CheckedChanged
		Call Konek()
		Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE isbn ='" & TextBoxScanIsbn.Text & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%') AND MP = 'Tokopedia' ", ConnectDb)
		Ds = New DataSet
		Da.Fill(Ds)
		DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
		'TextBoxScanIsbn.Text = ""
		For Baris As Integer = 0 To DGV_MPCheckingOrder.Rows.Count - 1
			If DGV_MPCheckingOrder.Rows(Baris).Cells(0).Value = "TokoPedia" Then
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
			Else
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.Pink

			End If
		Next
		TextBoxScanIsbn.Focus()
	End Sub

	Private Sub RBSemua_CheckedChanged(sender As Object, e As EventArgs) Handles RBSemua.CheckedChanged
		Call Konek()
		Da = New SqlDataAdapter("SELECT MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga FROM MP_CheckingOrder WHERE isbn ='" & TextBoxScanIsbn.Text & "' AND (Proses_Status  LIKE '%Pemesanan sedang diproses oleh penjual%' OR Proses_Status LIKE '%Perlu Dikirim%')  ", ConnectDb)
		Ds = New DataSet
		Da.Fill(Ds)
		DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
		'TextBoxScanIsbn.Text = ""
		For Baris As Integer = 0 To DGV_MPCheckingOrder.Rows.Count - 1
			If DGV_MPCheckingOrder.Rows(Baris).Cells(0).Value = "TokoPedia" Then
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.LightBlue
			Else
				DGV_MPCheckingOrder.Rows(Baris).DefaultCellStyle.BackColor = Color.Pink

			End If
		Next
		TextBoxScanIsbn.Focus()
	End Sub
End Class
