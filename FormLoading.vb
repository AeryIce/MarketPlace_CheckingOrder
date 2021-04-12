Public Class FormLoading
	Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load


		TmLoding.Start()

	End Sub

	Private Sub TmLoding_Tick(sender As Object, e As EventArgs) Handles TmLoding.Tick

		If PbLoding.Value < 100 Then
			PbLoding.Value += 2
		Else
			Me.Close()
		End If

	End Sub
End Class