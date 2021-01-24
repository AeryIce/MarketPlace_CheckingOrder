Public Class FormDashboard


	Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'INVDataSet.MP_CheckingOrder' table. You can move, or remove it, as needed.
		Me.MP_CheckingOrderTableAdapter.Fill(Me.INVDataSet.MP_CheckingOrder)
		DGVDone.Columns(4).DefaultCellStyle.Format = "dd.MM.yyyy"
		DGVDone.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

		Dim Tanggal As String
		Tanggal = MonthCalendar.SelectionStart.ToString("dd/MM/yyyy")
		MsgBox("Sekarang Tanggal '" & Tanggal & "'")



	End Sub

	Private Sub PnLastSales_MouseHover(sender As Object, e As EventArgs) Handles PnLastSales.MouseHover
		PnLastSales.BackColor = Color.Pink

	End Sub

	Private Sub PnLastSales_MouseLeave(sender As Object, e As EventArgs) Handles PnLastSales.MouseLeave
		PnLastSales.BackColor = Color.Yellow
	End Sub


	Private Sub PnOrderToday_MouseHover(sender As Object, e As EventArgs) Handles PnOrderToday.MouseHover
		PnOrderToday.BackColor = Color.Pink
	End Sub

	Private Sub PnOrderToday_MouseLeave(sender As Object, e As EventArgs) Handles PnOrderToday.MouseLeave
		PnOrderToday.BackColor = Color.Red
	End Sub
	Private Sub PnProcessToday_MouseHover(sender As Object, e As EventArgs) Handles PnProcessToday.MouseHover
		PnProcessToday.BackColor = Color.Pink
	End Sub

	Private Sub PnProcessToday_MouseLeave(sender As Object, e As EventArgs) Handles PnProcessToday.MouseLeave
		PnProcessToday.BackColor = Color.Blue
	End Sub
	Private Sub PnSalesToday_MouseHover(sender As Object, e As EventArgs) Handles PnSalesToday.MouseHover
		PnSalesToday.BackColor = Color.Pink
	End Sub
	Private Sub PnSalesToday_MouseLeave(sender As Object, e As EventArgs) Handles PnSalesToday.MouseLeave
		PnSalesToday.BackColor = Color.Green
	End Sub

	Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
		Try
			Me.MP_CheckingOrderTableAdapter.FillBy(Me.INVDataSet.MP_CheckingOrder)
		Catch ex As System.Exception
			System.Windows.Forms.MessageBox.Show(ex.Message)
		End Try

	End Sub

	Private Sub MonthCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateChanged

	End Sub
End Class