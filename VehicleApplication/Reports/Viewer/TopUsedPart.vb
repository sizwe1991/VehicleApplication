Imports System.Data.SqlClient

Public Class TopUsedPart


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim sql As String = "SELECT        TOP (" & NumericUpDown1.Value & ") SUM(dbo.tblLabourPart.Qty) AS Expr1, dbo.tblPart.Code, dbo.tblPart.Description, dbo.tblPart.Qty, dbo.tblPart.CostPrice, dbo.tblPart.SupplierID, " & _
  "      dbo.tblPart.Vehicle, dbo.tblPart.Model, dbo.tblPart.Year, dbo.tblPart.SellPrice, dbo.tblPart.EngineNo, dbo.tblPart.Shelf " & _
" FROM            dbo.tblQuoteLabour INNER JOIN " & _
   "                      dbo.tblQuote ON dbo.tblQuoteLabour.QuoteNo = dbo.tblQuote.QuoteNo INNER JOIN " & _
  "                       dbo.tblLabourPart ON dbo.tblQuoteLabour.LabourNo = dbo.tblLabourPart.LabourNo INNER JOIN " & _
 "                        dbo.tblPart ON dbo.tblLabourPart.Code = dbo.tblPart.Code " & _
"GROUP BY dbo.tblPart.Code, dbo.tblPart.Description, dbo.tblPart.Qty, dbo.tblPart.CostPrice, dbo.tblPart.SupplierID, dbo.tblPart.Vehicle, dbo.tblPart.Model, dbo.tblPart.Year, " & _
   "                      dbo.tblPart.SellPrice, dbo.tblPart.EngineNo, dbo.tblPart.Shelf, dbo.tblLabourPart.Qty"
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