Imports System.Data.SqlClient
Public Class FormDetailedBuku
	Private Sub FormDetailedBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Dim IsbnUrl As String = TBURLISBN.Text
		'PBBuku.ImageLocation = "http://st.xsm.us/c/b/'" & IsbnUrl & "'"
		TBURLISBN.Visible = False



	End Sub

	Private Sub BtCloseWindow_Click(sender As Object, e As EventArgs) Handles BtCloseWindow.Click
		Me.Close()
	End Sub

	Private Sub TBURLISBN_TextChanged(sender As Object, e As EventArgs) Handles TBURLISBN.TextChanged
		Dim IsbnUrl As String = TBURLISBN.Text
		PBBuku.ImageLocation = "http://st.xsm.us/c/b/" & IsbnUrl & ""
	End Sub


End Class