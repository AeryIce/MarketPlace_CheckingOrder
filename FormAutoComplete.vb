Imports System.Data.SqlClient
Public Class FormAutoComplete
	Private Sub FormAutoComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Try
			Dim Dt As DataTable
			Call Konek()
			Da = New SqlDataAdapter("SELECT DISTINCT (Judul) FROM MP_CheckingOrder", ConnectDb)
			Dt = New DataTable
			Da.Fill(Dt)
			Dim R As DataRow

			TextBox1.AutoCompleteCustomSource.Clear()
			For Each R In Dt.Rows
				TextBox1.AutoCompleteCustomSource.Add(R.Item(0).ToString)

			Next

		Catch ex As Exception
			MsgBox(ex.Message)

		End Try



	End Sub
End Class