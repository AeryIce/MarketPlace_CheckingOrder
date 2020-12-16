Imports System.Data.SqlClient
Module ModuleKoneksi
	Public ConnectDb As SqlConnection
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet
	Public Cmd As SqlCommand

	Sub Konek()
		Try
			ConnectDb = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = True")
			ConnectDb.Open()
			FormCheckingOrder.LabelStatusKoneksi.Text = "Connected"
		Catch ex As Exception
			FormCheckingOrder.LabelStatusKoneksi.Text = "Not Connected"
		End Try


	End Sub



End Module
