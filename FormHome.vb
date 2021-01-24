Public Class FormHome

	Private Sub BtHome_MouseHover(sender As Object, e As EventArgs) Handles BtHome.MouseHover
		Me.PnBtHome.BackColor = Color.Yellow
		Me.PnMenuNow.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.home_32px_White


	End Sub

	Private Sub BtHome_MouseLeave(sender As Object, e As EventArgs) Handles BtHome.MouseLeave
		Me.PnBtHome.BackColor = Color.WhiteSmoke
		Me.PnMenuNow.BackgroundImage = Nothing
	End Sub
	Private Sub BtOrder_MouseHover(sender As Object, e As EventArgs) Handles BtOrder.MouseHover
		Me.PnBtOrder.BackColor = Color.Yellow
		Me.PnMenuNow.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.shopping_cart_32px
	End Sub

	Private Sub BtOrder_MouseLeave(sender As Object, e As EventArgs) Handles BtOrder.MouseLeave
		Me.PnBtOrder.BackColor = Color.WhiteSmoke
	End Sub
	Private Sub BtAdmin_MouseHover(sender As Object, e As EventArgs) Handles BtAdmin.MouseHover
		Me.PnbtAdmin.BackColor = Color.Yellow

	End Sub

	Private Sub BtAdmin_MouseLeave(sender As Object, e As EventArgs) Handles BtAdmin.MouseLeave
		Me.PnbtAdmin.BackColor = Color.WhiteSmoke
	End Sub

	Private Sub BtHome_Click(sender As Object, e As EventArgs) Handles BtHome.Click
		Me.PnBtHome.BackColor = Color.Yellow
		Me.PnMenuNow.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.home_32px_White
		FormDashboard.TopLevel = False
		FormDashboard.TopMost = True
		Me.PnDisplay.Controls.Add(FormDashboard)
		FormDashboard.Show()
	End Sub

	Private Sub BtOrder_Click(sender As Object, e As EventArgs) Handles BtOrder.Click
		Me.PnBtHome.BackColor = Color.Yellow
		Me.PnMenuNow.BackgroundImage = Global.MarketPlace_CheckingOrder.My.Resources.Resources.shopping_cart_32px
		FormCheckingOrder.TopLevel = False
		FormCheckingOrder.TopMost = True
		Me.PnDisplay.Controls.Add(FormCheckingOrder)
		FormCheckingOrder.Show()
	End Sub
End Class