Imports System.Data.SqlClient
Imports System.Data.OleDb
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
					Dim DaEx As New OleDbDataAdapter("SELECT * FROM [Sheet1$A5:AB5000]", ConnEx)
					DaEx.TableMappings.Add("'" & NamaFile & "'", "MP_CheckingOrder")
					Dim DsEx As New DataSet
					DaEx.Fill(DsEx)
					ConnEx.Close()

					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
					ConnEs.Open()
					Dim DrwEs As DataRow
					Dim DrEs As SqlDataReader

					For Each DrwEs In DsEx.Tables(0).Rows

						Dim CmdEs As New SqlCommand("INSERT INTO MP_CheckingOrder (MP,Order_Id,Invoice,Resi,Isbn,Qty,Harga,Ongkir,Location,Proses_Status,Tanggal_Proses) VALUES ('" & ComboBoxPilihMP.SelectedItem & "', '" & DrwEs(1).ToString & "','" & DrwEs(2).ToString & "',
												'" & DrwEs(23).ToString & "','" & DrwEs(8).ToString & "'," & DrwEs(7) & "," & DrwEs(10) & "," & DrwEs(19) & ",'PP343','1','' ) ", ConnEs)
						DrEs = CmdEs.ExecuteReader
						DrEs.Close()
					Next

					ConnEs.Close()
					MsgBox("Wis Rampung")

				End If
			Catch ex As Exception

			End Try
		Else
			MsgBox("Sik Rung Rampung")
		End If

	End Sub
End Class
