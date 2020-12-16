Public Class FormValidasi
	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		Me.Close()
		FormCheckingOrder.Show()
	End Sub
End Class