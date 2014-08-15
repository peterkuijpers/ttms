Partial Class TTMSDataSet
	Partial Class LevelsDataTable

		Private Sub LevelsDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
			If (e.Column.ColumnName = Me.short_descriptionColumn.ColumnName) Then
				'Add user code here
			End If

		End Sub

	End Class

End Class

Namespace TTMSDataSetTableAdapters
    
	Partial Class NCRsTableAdapter

	End Class

	Partial Public Class LogsTableAdapter
	End Class
End Namespace

Namespace TTMSDataSetTableAdapters

	Partial Public Class NotificationsTableAdapter
	End Class
End Namespace

Namespace TTMSDataSetTableAdapters

	Partial Public Class NCRsTableAdapter
	End Class
End Namespace
