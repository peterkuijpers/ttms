Partial Class MySqlDataSet
	Partial Class ccitemDataTable

		Private Sub ccitemDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
			If (e.Column.ColumnName = Me.cc_idColumn.ColumnName) Then
				'Add user code here
			End If

		End Sub

	End Class

End Class
