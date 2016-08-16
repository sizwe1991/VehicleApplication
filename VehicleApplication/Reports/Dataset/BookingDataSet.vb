Partial Class BookingDataSet



    Partial Class BookingViewDataTable

        Private Sub BookingViewDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PartDescColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class PurchasedPartViewDataTable

        Private Sub PurchasedPartViewDataTable_ColumnChanging(sender As System.Object, e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DateInColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class PartsViewDataTable

        Private Sub PartsViewDataTable_PartsViewRowChanging(sender As System.Object, e As PartsViewRowChangeEvent) Handles Me.PartsViewRowChanging

        End Sub

    End Class

End Class

Namespace BookingDataSetTableAdapters

    Partial Public Class PurchasedPartViewTableAdapter
    End Class
End Namespace
