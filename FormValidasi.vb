Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class FormValidasi
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
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
    End Sub
    Private Sub DGVInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInvoice.CellContentClick
        Dim senderGrid As DataGridView = sender
        Dim data = senderGrid.Rows(e.RowIndex).DataBoundItem
    End Sub
    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        Call Konek()
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
                    Cmd = New SqlCommand("UPDATE MP_CheckingOrder_Temp set Proses_status=1 WHERE order_id in('" & row.Cells(1).Value & "') and isbn in('" & row.Cells(3).Value & "')", ConnectDb)
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

    Private Sub TextBoxvalidasiisbn_TextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TextBoxvalidasiisbn.TextChanged
        Call Konek()
        Dim senderGrid As DataGridView = sender
        Dim data = senderGrid.Rows(e.RowIndex).DataBoundItem
        Dim idxRow As DataGridViewCheckBoxCell = DGVInvoice.Rows(0).Cells(5)
        Dim intRow As Integer = idxRow.RowIndex

        Cmd = New SqlCommand("SELECT isbn FROM MP_CheckingOrder_Temp WHERE isbn ='" & TextBoxvalidasiisbn.Text & "'", ConnectDb)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            Call Konek()
            Da = New SqlDataAdapter("SELECT isbn FROM MP_CheckingOrder_Temp WHERE isbn ='" & TextBoxvalidasiisbn.Text & "' AND Proses_Status is null", ConnectDb)
            Ds = New DataSet
            Da.Fill(Ds)
            data.Value = True
            MsgBox("ISBN Ada di Invoive !!")
            TextBoxvalidasiisbn.Clear()
            TextBoxvalidasiisbn.Focus()
        Else
            MsgBox("ISBN Tidak Ada Pada List!!!")
        End If
    End Sub
End Class
