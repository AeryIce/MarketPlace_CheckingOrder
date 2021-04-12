

Partial Public Class INVDataSet
	Partial Public Class MP_CheckingOrderDataTable
		Private Sub MP_CheckingOrderDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
			If (e.Column.ColumnName = Me.Tanggal_SelesaiColumn.ColumnName) Then
				'Add user code here
			End If

		End Sub

	End Class
End Class
