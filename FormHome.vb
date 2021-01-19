Public Class FormHome
	Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
		Me.Close()
	End Sub

	Private Sub BtHome_MouseHover(sender As Object, e As EventArgs) Handles BtHome.MouseHover
		PnBtHomeHover.BackColor = Color.Lavender
		PnBtOrderHover.BackColor = Color.DarkBlue
	End Sub

	Private Sub BtHome_MouseMove(sender As Object, e As MouseEventArgs) Handles BtHome.MouseMove
		PnBtHomeHover.BackColor = Color.DeepSkyBlue

	End Sub

	Private Sub BtHome_Click(sender As Object, e As EventArgs) Handles BtHome.Click
		PnBtHomeHover.BackColor = Color.Navy
		BtHome.BackColor = Color.Lavender
		BtHome.ForeColor = Color.Black
	End Sub

	Private Sub BtHome_MouseClick(sender As Object, e As MouseEventArgs) Handles BtHome.MouseClick
		PnBtHomeHover.BackColor = Color.Navy
		BtHome.BackColor = Color.Lavender
		BtHome.ForeColor = Color.Black
	End Sub

	Private Sub BtMinimize_Click(sender As Object, e As EventArgs) Handles BtMinimize.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub BtMaximize_Click(sender As Object, e As EventArgs) Handles BtMaximize.Click
		Me.WindowState = FormWindowState.Maximized
	End Sub


	Private Sub BtOrder_MouseHover(sender As Object, e As EventArgs) Handles BtOrder.MouseHover
		PnBtHomeHover.BackColor = Color.DarkBlue
		PnBtOrderHover.BackColor = Color.Lavender
	End Sub

	Private Sub BtOrder_Click(sender As Object, e As EventArgs) Handles BtOrder.Click
		PnBtOrderHover.BackColor = Color.Navy
		BtOrder.BackColor = Color.Lavender
		BtOrder.ForeColor = Color.Black
	End Sub
End Class