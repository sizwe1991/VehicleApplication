Imports System.Data.SqlClient

Public Class Reprint

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub rdbQuotation_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbQuotation.CheckedChanged
        lblValue.Text = "Quotation No"
        chkMerchant.Enabled = True
        chksignature.Enabled = False
        MaskedTextBox1.Focus()
        MaskedTextBox1.Clear()
    End Sub

    Private Sub rdbBooking_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbBooking.CheckedChanged
        lblValue.Text = "Booking No"
        chkMerchant.Enabled = False
        chksignature.Enabled = False
        MaskedTextBox1.Focus()
        MaskedTextBox1.Clear()
    End Sub

    Private Sub rdbInvoice_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbInvoice.CheckedChanged
        lblValue.Text = "Invoice No"
        chkMerchant.Enabled = True
        chksignature.Enabled = True
        MaskedTextBox1.Focus()
        MaskedTextBox1.Clear()
    End Sub

    Private Sub rdbtowing_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbtowing.CheckedChanged
        lblValue.Text = "Towing No"
        chkMerchant.Enabled = False
        chksignature.Enabled = False
        MaskedTextBox1.Focus()
        MaskedTextBox1.Clear()
    End Sub

    Private Sub btnReprintPRev_Click(sender As System.Object, e As System.EventArgs) Handles btnReprintPRev.Click
        If rdbQuotation.Checked = True Then
            If chkMerchant.Checked Then
                Dim sql As String = "SELECT   * from QuoteView" & _
              "  WHERE        (quoteno = " & getQuoteNo() & ")"
                Dim cmd As New SqlDataAdapter
                Dim ds As New DataTable
                Dim report As New QuoteTwoCrystalReport
                cmd.SelectCommand = New SqlCommand
                cmd.SelectCommand.CommandText = sql
                cmd.SelectCommand.Connection = objCon
                '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
                cmd.Fill(ds)

                report.SetDataSource(ds)
                Dim objReport As New ReportViewer
                objReport.CrystalReportViewer1.ReportSource = (report)
                objReport.ShowDialog()
                ' Me.CrystalReportViewer1.ReportSource = report
                ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
            Else

                Dim sql As String = "SELECT   * from quoteview" & _
        "  WHERE        (quoteno = " & getQuoteNo() & ")"
                Dim cmd As New SqlDataAdapter
                Dim ds As New DataTable
                Dim report As New QuoteCrystalReport
                cmd.SelectCommand = New SqlCommand
                cmd.SelectCommand.CommandText = sql
                cmd.SelectCommand.Connection = objCon
                '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
                cmd.Fill(ds)

                report.SetDataSource(ds)
                Dim objReport As New ReportViewer
                objReport.CrystalReportViewer1.ReportSource = (report)
                objReport.ShowDialog()
                ' Me.CrystalReportViewer1.ReportSource = report
                ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
            End If
        ElseIf rdbBooking.Checked = True Then
            'Dim technicianName As String=InputBox("Enter Technician Name", "Please Enter Technician Name"
            printBookingReport(getBookingNo)
        ElseIf rdbInvoice.Checked = True Then
            If chksignature.Checked = True Then
                printInvoice2(getQuotationNo(getInvoiceNo), getInvoiceNo)
            Else
                printInvoice1(getQuotationNo(getInvoiceNo), getInvoiceNo)
            End If
        ElseIf rdbtowing.Checked = True Then
            printTowingReport(getTowingNo())
        End If
    End Sub

    Public Sub printTowingReport(ByVal bkno As Integer)

        Dim sql As String = "select * from [Towing.] where towno=" & bkno
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New TowingCrystalReport
        cmd.SelectCommand = New SqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Public Sub printBookingReport(ByVal bkno As Integer)

        Dim sql As String = "select * from tblbooking where BookingNo=" & bkno
        Dim cmd As New sqlDataAdapter
        Dim ds As New DataTable
        Dim report As New BookingCrystalReport
        cmd.SelectCommand = New sqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Private Function getInvoiceNo() As Integer
        Dim cmd As New SqlCommand("select max(invoiceno) from tbinvoice", objCon)
        Dim number As Integer
        objCon.Close()
        objCon.Open()
        number = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function


    Private Function getQuotationNo(InvoiceNo As Integer) As Integer
        Dim cmd As New SqlCommand("select QuoteNo from tbinvoice where InvoiceNo=" & InvoiceNo, objCon)
        Dim number As Integer
        objCon.Close()
        objCon.Open()
        number = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function

    Public Sub printInvoice2(ByVal bkno As Integer, invoiceNo As Integer)

        Dim sql As String = "SELECT   * from quoteview" & _
 "  WHERE        (quoteno = " & bkno & ")"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New InvoiceTwoCrystalReport
        cmd.SelectCommand = New SqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        Dim merchant As String = ""
        If chkMerchant.Checked = True Then
            merchant = "MERCHANT NO: 188 722 63"
        End If
        report.SetParameterValue(0, invoiceNo)
        report.SetParameterValue(1, merchant)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Public Sub printInvoice1(ByVal bkno As Integer, invoiceNo As Integer)

        Dim sql As String = "SELECT   * from quoteview" & _
"  WHERE        (quoteno = " & bkno & ")"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New InvoiceCrystalReport
        cmd.SelectCommand = New SqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        Dim merchant As String = ""
        If chkMerchant.Checked = True Then
            merchant = "MERCHANT NO: 188 722 63"
        End If
        report.SetParameterValue(0, invoiceNo)
        report.SetParameterValue(1, merchant)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Private Sub btnReprint_Click(sender As System.Object, e As System.EventArgs) Handles btnReprint.Click
        If rdbBooking.Checked = True Then
            If String.IsNullOrEmpty(MaskedTextBox1.Text) Then
                MsgBox("Please Enter Booking No", 48)
                MaskedTextBox1.Focus()
            ElseIf Not checkbookingNo(MaskedTextBox1.Text) Then
                MsgBox("Invalid Booking No, Please try again", 48)
                MaskedTextBox1.Focus()
            Else
                printBookingReport(MaskedTextBox1.Text)
            End If
        ElseIf rdbInvoice.Checked = True Then
            If String.IsNullOrEmpty(MaskedTextBox1.Text) Then
                MsgBox("Please Enter Invoice No", 48)
                MaskedTextBox1.Focus()
            ElseIf Not checkInvoiceNo(MaskedTextBox1.Text) Then
                If chksignature.Checked = True Then
                    printInvoice2(getQuotationNo(MaskedTextBox1.Text), MaskedTextBox1.Text)
                Else
                    printInvoice1(getQuotationNo(MaskedTextBox1.Text), MaskedTextBox1.Text)
                End If
            End If
        ElseIf rdbQuotation.Checked = True Then
            If String.IsNullOrEmpty(MaskedTextBox1.Text) Then
                MsgBox("Please Enter Quotation No", 48)
                MaskedTextBox1.Focus()
            Else

                If chkMerchant.Checked Then
                    Dim sql As String = "SELECT   * from QuoteView" & _
                  "  WHERE        (quoteno = " & MaskedTextBox1.Text & ")"
                    Dim cmd As New SqlDataAdapter
                    Dim ds As New DataTable
                    Dim report As New QuoteTwoCrystalReport
                    cmd.SelectCommand = New SqlCommand
                    cmd.SelectCommand.CommandText = sql
                    cmd.SelectCommand.Connection = objCon
                    '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
                    cmd.Fill(ds)

                    report.SetDataSource(ds)
                    Dim objReport As New ReportViewer
                    objReport.CrystalReportViewer1.ReportSource = (report)
                    objReport.ShowDialog()
                    ' Me.CrystalReportViewer1.ReportSource = report
                    ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
                Else

                    Dim sql As String = "SELECT   * from quoteview" & _
            "  WHERE        (quoteno = " & MaskedTextBox1.Text & ")"
                    Dim cmd As New SqlDataAdapter
                    Dim ds As New DataTable
                    Dim report As New QuoteCrystalReport
                    cmd.SelectCommand = New SqlCommand
                    cmd.SelectCommand.CommandText = sql
                    cmd.SelectCommand.Connection = objCon
                    '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
                    cmd.Fill(ds)

                    report.SetDataSource(ds)
                    Dim objReport As New ReportViewer
                    objReport.CrystalReportViewer1.ReportSource = (report)
                    objReport.ShowDialog()
                    ' Me.CrystalReportViewer1.ReportSource = report
                    ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
                End If

            End If
        ElseIf rdbtowing.Checked = True Then
            If String.IsNullOrEmpty(MaskedTextBox1.Text) Then
                MsgBox("Please Enter Quotation No", 48)
                MaskedTextBox1.Focus()
            Else
                Dim sql As String = "select * from [Towing.] where towno=" & MaskedTextBox1.Text
                Dim cmd As New SqlDataAdapter
                Dim ds As New DataTable
                Dim report As New TowingCrystalReport
                cmd.SelectCommand = New SqlCommand
                cmd.SelectCommand.CommandText = sql
                cmd.SelectCommand.Connection = objCon
                '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
                cmd.Fill(ds)

                report.SetDataSource(ds)
                Dim objReport As New ReportViewer
                objReport.CrystalReportViewer1.ReportSource = (report)
                objReport.ShowDialog()
                ' Me.CrystalReportViewer1.ReportSource = report
                ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
            End If
        End If
    End Sub

    Private Function checkQuotationNo(quoteNio As Integer) As Integer
        Dim cmd As New SqlCommand("select count(0) from tblQuote where QuoteNo=" & quoteNio, objCon)
        Dim number As Integer
        objCon.Close()
        objCon.Open()
        number = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function

    Private Function checkInvoiceNo(invoiceNio As Integer) As Integer
        Dim cmd As New SqlCommand("select count(0) from tbinvoice where invoiceno=" & invoiceNio, objCon)
        Dim number As Integer
        objCon.Close()
        objCon.Open()
        number = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function


    Private Function checkbookingNo(bookingNio As Integer) As Integer
        Dim cmd As New SqlCommand("select count(0) from tblbooking where bookingno=" & bookingNio, objCon)
        Dim number As Integer
        objCon.Close()
        objCon.Open()
        number = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function


End Class