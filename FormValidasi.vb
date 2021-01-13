Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormValidasi
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        Me.Close()
        FormCheckingOrder.Show()
    End Sub
    Private Sub FormValidasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Konek()
        Dim chk As New DataGridViewCheckBoxColumn()
        DGVInvoice.Columns.Add(chk)
        chk.HeaderText = "Check/Uncheck"
        chk.Name = "chk"
        DGVInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGVInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'BtProses.Enabled = False
    End Sub
    Private Sub DGVInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoice.CellContentClick
        Dim senderGrid As DataGridView = sender
        Dim data = senderGrid.Rows(e.RowIndex).DataBoundItem

        If (DGVInvoice.Columns(e.ColumnIndex).Name = "chk") = True Then
            BtProses.Enabled = True
        Else
            BtProses.Enabled = False
            MsgBox("Checkbox For Confirmation")
        End If
    End Sub
    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles BtProses.Click

        Dim idxRow As DataGridViewCheckBoxCell = DGVInvoice.Rows(0).Cells(5)
            Dim intRow As Integer = idxRow.RowIndex
            Try
                Dim CheckedRows =
                    (
                        From Rows In DGVInvoice.Rows.Cast(Of DataGridViewRow)()
                        Where CBool(Rows.Cells(5).Value) = True
                    ).ToList

                If CheckedRows.Count = 0 Then
                    MsgBox("Checklist Data yang akan diupdate !!!")
                    Exit Sub
                Else
                    For Each row As DataGridViewRow In CheckedRows
                        Cmd = New SqlCommand("UPDATE MP_CheckingOrder set Proses_status=1 WHERE order_id in('" & row.Cells(1).Value & "') and isbn in('" & row.Cells(3).Value & "')", ConnectDb)
                        Dr = Cmd.ExecuteReader
                        Dr.Close()
                    Next
                    MsgBox("Update Succes !!!")
                    Me.Close()
                    FormCheckingOrder.Show()
                    FormCheckingOrder.TextBoxScanIsbn.Clear()
                    FormCheckingOrder.DGV_MPCheckingOrder.Columns.Clear()
                End If
            Catch ex As Exception

            End Try




    End Sub

    Private Sub TextBoxvalidasiisbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxvalidasiisbn.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtCari.PerformClick()
        End If

    End Sub

    Private Sub BtCari_Click(sender As Object, e As EventArgs) Handles BtCari.Click

        Dim Hasil As Integer = 0
        'Dim chk As New DataGridViewCheckBoxColumn()
        'DGVInvoice.Columns.Add(chk)
        'chk.HeaderText = "Check/Uncheck"
        'chk.Name = "chk"
        'DGVInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'DGVInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        'BtProses.Enabled = False

        For CariBaris As Integer = 0 To DGVInvoice.RowCount - 1

            If DGVInvoice.Rows(CariBaris).Cells(3).Value = TextBoxvalidasiisbn.Text Then

                Try

                    Hasil = 1
                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                    If ex.InnerException IsNot Nothing Then
                        MsgBox(ex.InnerException)
                    End If
                End Try

                DGVInvoice.Rows(CariBaris).Cells(5).Value = True
                BtProses.Enabled = True
            End If








        Next
        If Hasil = 0 Then
            MsgBox("Ora ONO!!")
        End If


    End Sub



    'Private Sub DGVInvoice_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoice.CellValueChanged
    '    If (DGVInvoice.Columns(e.ColumnIndex).Name = "chk") = True Then
    '        ButtonProses.Enabled = True
    '    Else
    '        MsgBox("Pilih Centang")
    '    End If

    'End Sub
End Class
