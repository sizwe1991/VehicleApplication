Imports System.Data.SqlClient

Public Class TopUsedPart

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        Dim sql As String = "SELECT        TOP (" & NumericUpDown1.Value & ") SUM(dbo.tblVehiclePart.Qty) AS Expr2, dbo.tblPart.Description, dbo.tblPart.Qty, dbo.tblPart.Price, dbo.tblPart.Code " & _
" FROM            dbo.tblVehiclePart INNER JOIN " & _
  "                       dbo.tblPart ON dbo.tblVehiclePart.Code = dbo.tblPart.Code " & _
" GROUP BY dbo.tblVehiclePart.Qty, dbo.tblPart.Description, dbo.tblPart.Qty, dbo.tblPart.Price, dbo.tblPart.Code " & _
" ORDER BY dbo.tblVehiclePart.Qty DESC"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New TopUsedPartCrystalReport
        cmd.SelectCommand = New SqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        '  Dim objReport As New ReportViewer
        CrystalReportViewer1.ReportSource = (report)
        '  objReport.ShowDialog()
    End Sub
End Class