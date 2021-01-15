Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
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
					'Dim CmdEsImport As SqlCommand

					CmdEsDell = New SqlCommand("DELETE FROM MP_CheckingOrder_Temp WHERE MP = 'TokoPedia' ", ConnEs)
					CmdEsDell.ExecuteNonQuery()



					For Each DrwEs In DsEx.Tables(0).Rows
						Dim Judul As String = DrwEs(6)
						Judul = Judul.Replace("'", "''")

						Dim Alamat As String = DrwEs(17)
						Alamat = Alamat.Replace("'", "''")

						CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Invoice_OrderID,Resi,ISBN,Judul,QTY,Harga,Courrier,[Address],Nama_Cust,Nama_Penerima,No_Hp_Cus,Tanggal_Pesanan,Proses_Status) VALUES 
											  ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(2).ToString & "','" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "',
											   '" & Judul & "'," & DrwEs(7) & "," & DrwEs(10) & ",'" & DrwEs(18).ToString & "','" & Alamat & "','" & DrwEs(13).ToString & "',
											   '" & DrwEs(15).ToString & "','" & DrwEs(14).ToString & "','" & DrwEs(3).ToString & "','" & DrwEs(4).ToString & "' ) ", ConnEs)
						DrEs = CmdEs.ExecuteReader
						DrEs.Close()
						'WHERE NOT EXIST ( SELECT '" & DrwEs(1).ToString & "' FROM MP_CheckingOrder_Temp WHERE Proses_Status = 1  ) 
					Next
					MsgBox("Import Tokopedia Done !!!!")

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

					'CmdEsImport = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location)
					'							  SELECT MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location
					'							  FROM MP_CheckingOrder_Temp
					'                                             WHERE MP_CheckingOrder_Temp.Order_Id NOT IN (SELECT Order_Id FROM MP_CheckingOrder)", ConnEs)
					'CmdEsImport.ExecuteNonQuery()




				End If
			Catch ex As Exception

			End Try

		ElseIf ComboBoxPilihMP.Text = "Shopee" Then
			Dim Loc As String
			Loc = "PP342"
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

					Dim DaEx As New OleDbDataAdapter("SELECT * FROM [orders$A1:AS5000]", ConnEx)
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder_Temp")
					Dim DsEx As New DataSet
					Dim DtEx As New DataTable
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = TRUE")
					ConnEs.Open()
					Dim DrwEs1 As DataRow
					Dim DrEs1 As SqlDataReader
					Dim CmdEsDell1 As SqlCommand
					Dim CmdEsImport As SqlCommand

					CmdEsDell1 = New SqlCommand("DELETE FROM MP_CheckingOrder_Temp WHERE MP = 'Shopee' ", ConnEs)
					CmdEsDell1.ExecuteNonQuery()

					For Each DrwEs1 In DsEx.Tables(0).Rows
						Dim HargaAwal As String = DrwEs1(15)
						Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
						HargaAwal = harga.Replace(".", String.Empty)
						Dim HargaFinal As Integer = Integer.Parse(HargaAwal)

						Dim Ongkir As String = DrwEs1(33)
						Dim HargaOngkir As String = Ongkir.Replace("Rp", String.Empty)
						HargaOngkir = HargaOngkir.Replace(".", String.Empty)
						Dim FinalOngkir As Integer = Integer.Parse(HargaOngkir)

						Dim Quan As Integer = Integer.Parse(DrwEs1(17))

						Dim CmdEs As New SqlCommand("INSERT INTO MP_CheckingOrder_Temp (MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location) 
												VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs1(0).ToString & "','" & DrwEs1(11).ToString & "','" & DrwEs1(0).ToString & "','" & DrwEs1(4).ToString & "','" & DrwEs1(11).ToString & "',
												'" & Quan & "','" & HargaFinal & "','" & FinalOngkir & "','" & Loc & "')", ConnEs)
						DrEs1 = CmdEs.ExecuteReader
						DrEs1.Close()
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

					CmdEsImport = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location)
												  SELECT MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location
												  FROM MP_CheckingOrder_Temp
                                                  WHERE MP_CheckingOrder_Temp.Order_Id NOT IN (SELECT Order_Id FROM MP_CheckingOrder)", ConnEs)
					CmdEsImport.ExecuteNonQuery()

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
		Cmd = New SqlCommand("SELECT * FROM MP_CheckingOrder_Temp WHERE isbn ='" & TextBoxScanIsbn.Text & "'", ConnectDb)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			Call Konek()
			Da = New SqlDataAdapter("SELECT MP,Invoice,Order_id,Qty FROM MP_CheckingOrder_Temp WHERE isbn ='" & TextBoxScanIsbn.Text & "' AND Proses_Status is null", ConnectDb)
			Ds = New DataSet
			Da.Fill(Ds)
			DGV_MPCheckingOrder.DataSource = Ds.Tables(0)
		Else
			MsgBox("Data Yang Dicari Sudah Terproses!!!")
		End If
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
			Cmd = New SqlCommand("SELECT * FROM MP_CheckingOrder_Temp WHERE invoice = '" & selectedRow.Cells(1).Value & "'", ConnectDb)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				Call Konek()
				Da = New SqlDataAdapter("SELECT MP,Order_id,Invoice,Isbn,Qty FROM MP_CheckingOrder_Temp WHERE invoice = '" & selectedRow.Cells(1).Value & "' AND Proses_Status is null", ConnectDb)
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


End Class
