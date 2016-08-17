Imports System.Data.SqlClient

Public Class ProceesedBookings


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        If StartDateTimePicker1.Value > EndDateTimePicker2.Value Then
            MsgBox("Start date must be lesser than end date", 48)
        Else

            Dim sql As String = "select * from tblBooking where bookingdate between '" & StartDateTimePicker1.Value & "' and '" & EndDateTimePicker2.Value & "'"
            Dim cmd As New SqlDataAdapter
            Dim ds As New DataTable
            Dim report As New ProcessedBookingCrystalReport
            cmd.SelectCommand = New SqlCommand
            cmd.SelectCommand.CommandText = sql
            cmd.SelectCommand.Connection = objCon
            '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
            cmd.Fill(ds)

            report.SetDataSource(ds)
            report.SetParameterValue(0, StartDateTimePicker1.Value)
            report.SetParameterValue(1, StartDateTimePicker1.Value)
            '  Dim objReport As New ReportViewer
            CrystalReportViewer1.ReportSource = (report)
            '  objReport.ShowDialog()

        End If
    End Sub
End Class