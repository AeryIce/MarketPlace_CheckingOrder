'Imports System.Data.SqlClient
'Imports System.Data.OleDb
'Public Class FormImportACCPAC
'	Private Sub FormImportACCPAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'		cbMP.Items.Add("Tokopedia")
'		cbMP.Items.Add("Shopee")
'		cbMP.Items.Add("Lazada")
'		cbMP.Items.Add("JD_ID")
'	End Sub

'	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
'		Me.Close()

'	End Sub

'	Private Sub btMaximize_Click(sender As Object, e As EventArgs) Handles btMaximize.Click
'		Me.WindowState = FormWindowState.Maximized
'	End Sub

'	Private Sub btMinimize_Click(sender As Object, e As EventArgs) Handles btMinimize.Click
'		Me.WindowState = FormWindowState.Minimized
'	End Sub

'	Private Sub btImport_Click(sender As Object, e As EventArgs) Handles btImport.Click

'		If cbMP.Text = "Tokopedia" Then
'			Try
'				Dim CariFile As New OpenFileDialog
'				With CariFile
'					.Filter = " Tokopedia (*.xlsx)|*.xlsx|All Files (*.*)|*.* "
'					.FilterIndex = 1
'					.Title = "Pilih File"

'				End With

'				If CariFile.ShowDialog = Windows.Forms.DialogResult.OK Then
'					Dim NamaFile = CariFile.FileName
'					Dim ConnEx As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" & NamaFile & "' ; Extended Properties = "" Excel 12.0 XML ;HDR = YES"" ")
'					ConnEx.Open()
'					Dim DaExTokopedia As New OleDbDataAdapter("SELECT * FROM  [sheets1$A4 : AB5000]", ConnEx)
'					DaExTokopedia.TableMappings.Add("'" & NamaFile & "'", "OtwACCPAC")
'					Dim DsExTokopedia As New DataSet
'					DaExTokopedia.Fill(DsExTokopedia)
'					ConnEx.Close()

'					Dim ConnEs As New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS ; Initial Catalog = INV ; Integrated Security = True")
'					ConnEs.Open()
'					Dim DRowEsTokopedia As DataRow
'					Dim DrEsTokopedia As SqlDataReader
'					Dim CmdEsTokopedia As SqlCommand
'					Dim CmdEsDelTokopediaTemp As SqlCommand
'					Dim CmdEsImportTokopedia As SqlCommand
'					Dim CmdEsUpdateTokopedia As SqlCommand

'					CmdEsDelTokopediaTemp = New SqlCommand("SELECT * FROM OtwACCPAC_Temp WHERE MP = 'Tokopedia' ", ConnEs)
'					CmdEsDelTokopediaTemp.ExecuteReader()

'					Dim KodeToko As String = "PP343"
'					For Each DRowEsTokopedia In DsExTokopedia.Tables(0).Rows

'						If IsDate(DRowEsTokopedia(3)) Then
'							Dim Judul As String = DRowEsTokopedia(6)
'							Judul = Judul.Replace("'", "''")

'							Dim Alamat As String = DRowEsTokopedia(17)
'							Alamat = Alamat.Replace("'", "''")


'						End If

'					Next




'				End If
'			Catch ex As Exception

'			End Try

'		ElseIf cbMP.Text = "Shopee" Then

'		ElseIf cbMP.Text = "Lazada" Then

'		ElseIf cbMP.Text = "JD_ID" Then

'		Else
'			MsgBox("Pilih MP")

'		End If
'	End Sub
'End Class