Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Public Class FormCheckingOrder
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

	Private Sub FormCheckingOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'INVDataSet.MP_CheckingOrder' table. You can move, or remove it, as needed.
		Me.MP_CheckingOrderTableAdapter.Fill(Me.INVDataSet.MP_CheckingOrder)
		Call Konek()
		ComboBoxPilihMP.Items.Add("TokoPedia")
		ComboBoxPilihMP.Items.Add("Shopee")

	End Sub

	'Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click

	'	If ComboBoxPilihMP.Text = "TokoPedia" Then
	'		Try
	'			Dim CariFile As New OpenFileDialog
	'			With CariFile
	'				.Filter = " Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.* "
	'				.FilterIndex = 1
	'				.Title = "Pilih File"
	'			End With

	'			If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
	'				Dim NamaFile = CariFile.FileName
	'				Dim ConnEx As New OleDbConnection(" Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "';Extended Properties = ""Excel 12.0 xml;HDR = Yes""")
	'				ConnEx.Open()
	'				Dim DaEx As New OleDbDataAdapter("SELECT * FROM [Sheet1$A5:AB100]", ConnEx)
	'				DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder")
	'				Dim DsEx As New DataSet
	'				DaEx.Fill(DsEx)
	'				ConnEx.Close()

	'				Call Konek()
	'				ConnEs.Open()
	'				For Each DrwEs In DsEx.Tables(0).Rows

	'					CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Order_Id,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location,Proses_Status,Tanggal_Proses) VALUES ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(1).ToString & "','" & DrwEs(2).ToString & "',
	'											'" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "'," & DrwEs(7) & "," & DrwEs(10) & "," & DrwEs(19) & ",'PP343','1','' ) ", ConnEs)
	'					DrEs = CmdEs.ExecuteReader

	'				Next

	'				ConnEs.Close()
	'				MsgBox("Wis Rampung")

	'			End If
	'		Catch ex As Exception

	'		End Try
	'	Else
	'		MsgBox("Sik Rung Rampung")
	'	End If

	'End Sub
	Private Sub ButtonImport_Click(sender As Object, e As EventArgs) Handles ButtonImport.Click

		If ComboBoxPilihMP.Text = "TokoPedia" Then
			Dim Loc As String
			Loc = "PP343"

			Dim Tanggal As Date
			Tanggal = Today
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
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder")
					Dim DsEx As New DataSet
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
					ConnEs.Open()
					Dim DrwEs As DataRow
					Dim DrEs As SqlDataReader
					Dim CmdEs As SqlCommand

					For Each DrwEs In DsEx.Tables(0).Rows

						CmdEs = New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Order_Id,Tokped_ProductID,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location,Tanggal_Proses) VALUES ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(1).ToString & "','" & DrwEs(5).ToString & "','" & DrwEs(2).ToString & "',
												'" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "'," & DrwEs(7) & "," & DrwEs(10) & "," & DrwEs(19) & ",'" & Loc & "','" & Tanggal & "' ) ", ConnEs)
						DrEs = CmdEs.ExecuteReader
						DrEs.Close()

					Next

					Dim ConnEsDup As SqlConnection
					ConnEsDup = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
					ConnEsDup.Open()
					Dim CmdEsDup As SqlCommand
					CmdEsDup = New SqlCommand("
					WITH DUP AS( 
					SELECT 
					MP,
					Order_ID,
					Tokped_ProductId,
					Invoice,
					Proses_Status,
					ROW_NUMBER() OVER(
						PARTITION BY
						MP,
						Order_ID,
						Tokped_ProductId,
						Invoice,
						Proses_Status
					ORDER BY
						MP,
						Order_ID,
						Tokped_ProductId,
						Invoice,
						Proses_Status
					)ROW_NUM 
					FROM MP_CheckingOrder)
					DELETE FROM DUP
					WHERE ROW_NUM > 1 AND Proses_Status IS NULL", ConnEsDup)

					Dim DrEsDUp As SqlDataReader
					DrEsDUp = CmdEsDup.ExecuteReader
					DrEsDUp.Close()

					ConnEs.Close()
					ConnEsDup.Close()


					MsgBox("Wis Rampung")

					DGV_MPCheckingOrder.Update()
				End If
			Catch ex As Exception

			End Try
		ElseIf ComboBoxPilihMP.Text = "Shopee" Then
			Dim Loc As String
			Loc = "PP342"

			Dim Tanggal As Date
			Tanggal = Today

			Try
				Dim CariFile As New OpenFileDialog
				With CariFile
					.Filter = " Shopee (*.xls)|*.xls|All Files (*.*)|*.* "
					.FilterIndex = 1
					.Title = "Pilih File"
				End With

				If CariFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
					Dim NamaFile = CariFile.FileName
					Dim ConnEx As New OleDbConnection("Provider = Microsoft.ACE.OleDb.12.0 ; Data Source = '" & NamaFile & "'; Extended Properties = "" Excel 12.0 xml;IMEX = 1;  HDR = YES"" ")
					ConnEx.Open()

					Dim DaEx As New OleDbDataAdapter("SELECT * FROM [Sheets1$A1:AS2]", ConnEx)
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder")
					Dim DsEx As New DataSet
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = TRUE")
					ConnEs.Open()
					Dim DrwEs As DataRow
					Dim DrEs As SqlDataReader

					Dim HargaAwal As String = DrwEs(15)
					Dim harga As String = HargaAwal.Replace("Rp", String.Empty)
					HargaAwal = harga.Replace(".", String.Empty)

					Dim Ongkir As String = DrwEs(33)
					Dim HargaOngkir As String = Ongkir.Replace("Rp", String.Empty)
					HargaOngkir = HargaOngkir.Replace(".", String.Empty)

					For Each DrwEs In DsEx.Tables(0).Rows
						Dim CmdEs As New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location,Proses_Status,Tanggal_Proses) 
													VALUES ('" & ComboBoxPilihMP.SelectedItem & "','" & DrwEs(0).ToString & "','" & DrwEs(4).ToString & "','" & DrwEs(11).ToString & "',
													" & DrwEs(17) & "," & DrwEs(15) & "," & DrwEs(33) & ",'" & Loc & "','1','" & Tanggal & "')", ConnEs)
						DrEs = CmdEs.ExecuteReader
						DrEs.Close()

					Next
					ConnEs.Close()
					
			
					MsgBox("RAmpung")





				End If
			Catch ex As Exception

			End Try
		Else
			MsgBox("Pilih sik Tokone")

		End If

	End Sub
End Class
