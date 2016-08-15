Imports System.Data.SqlClient

Public Class PurchasedParts

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        If StartDateTimePicker1.Value > EndDateTimePicker2.Value Then
            MsgBox("Start Date must be lesser than the End Date", 48)
        Else
            Dim sql As String = "select * from PurchasedPartView where datein between @start and @end"
            Dim cmd As New SqlDataAdapter
            Dim ds As New DataTable
            Dim report As New PurhasedPartsCrystalReport
            cmd.SelectCommand = New SqlCommand
            cmd.SelectCommand.CommandText = sql
            cmd.SelectCommand.Connection = objCon
            cmd.SelectCommand.Parameters.Add("@end", SqlDbType.Date).Value = EndDateTimePicker2.Value
            cmd.SelectCommand.Parameters.Add("@start", SqlDbType.Date).Value = StartDateTimePicker1.Value
            cmd.Fill(ds)

            report.SetDataSource(ds)
            '  Dim objReport As New ReportViewer
            CrystalReportViewer1.ReportSource = (report)
            '  objReport.ShowDialog()
        End If
    End Sub
End Class