Imports System.Data.SqlClient

Public Class Invoice

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click, Button1.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub Invoice_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        populateQuoteNumbers()
    End Sub

    Sub populateQuoteNumbers()
        Dim sql As String = "select * from tblQuote"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim list As New ArrayList
        While reader.Read
            list.Add(reader(0))
        End While
        reader.Close()
        objCon.Close()
        cmd.Dispose()
        txtQuoteNo.Items.Clear()
        For Each number As Integer In list
            If Not checkIfChangedToInvoice(number) Then
                txtQuoteNo.Items.Add(number)
            End If
        Next number
    End Sub

    Private Function checkQuoteNo(quoteNo As Integer) As Boolean
        Dim value As Boolean = False
        Dim sql As String = "select * from tblQuote where QuoteNo=" & quoteNo
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            value = True
        End If
        reader.Close()
        objCon.Close()
        cmd.Dispose()
        Return value
    End Function


    Private Function checkIfChangedToInvoice(quoteNo As Integer) As Boolean
        Dim value As Boolean = False
        Dim sql As String = "select * from tbInvoice where QuoteNo=" & quoteNo
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            value = True
        End If
        reader.Close()
        objCon.Close()
        cmd.Dispose()
        Return value
    End Function

    Dim partList As New ArrayList

    Sub clear()
        txtQuoteNo.Focus()

        txtCompany.Clear()
        txtInclTotal.Clear()
        txtDescription.Clear()
        txtLabour.Clear()
        txtPartAmount.Clear()
        txtRegNo.Clear()
        txtExclTotal.Clear()
        chkMerchant.Checked = False
        chksignature.Checked = False
        Panel2.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        clear()

        If String.IsNullOrEmpty(txtQuoteNo.Text) Then
            MsgBox("Please Enter Quotation Number", 48)
        ElseIf Not CBool(Integer.TryParse(txtQuoteNo.Text, 0)) Then
            MsgBox("Quote Number must be integer value")
        ElseIf Not checkQuoteNo(txtQuoteNo.Text) Then
            MsgBox("Invalid Quotation Number", 48)
        ElseIf checkIfChangedToInvoice(txtQuoteNo.Text) Then
            MsgBox("Invoice for this quotation has already been generated", 48)
        Else
            txtLabour.Text = getlabour(txtQuoteNo.Text)
            txtPartAmount.Text = getpart(txtQuoteNo.Text)

            Dim sql As String = "SELECT        tblQuote.Description, tblCustomer.CompanyName, tblVehicle.registrationno " & _
" FROM            tblQuote INNER JOIN " & _
   "                      tblVehicle ON tblQuote.RegistrationNo = tblVehicle.registrationno INNER JOIN " & _
  "                       tblCustomer ON tblVehicle.CustomerNo = tblCustomer.CustomerNo " & _
" WHERE        (tblQuote.QuoteNo = " & txtQuoteNo.Text & ")"
            Dim cmd As New SqlCommand(sql, objCon)
            objCon.Close()
            objCon.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.Read Then
                txtRegNo.Text = reader(2)
                txtDescription.Text = reader(0)
                txtCompany.Text = reader(1)
            End If
            reader.Close()
            objCon.Close()
            cmd.Dispose()

            txtExclTotal.Text = CDec(CDec(txtPartAmount.Text) + CDec(txtLabour.Text)).ToString("N2")
            txtInclTotal.Text = CDec(CDec(CDec(txtExclTotal.Text) * 0.14) + CDec(txtExclTotal.Text)).ToString("N2")

            Panel2.Enabled = True
        End If
    End Sub

    Private Function getpart(quoteNo As Integer) As Decimal
        '        Dim sql As String = "SELECT        SUM(tblPart.SellPrice * tblLabourPart.Qty) " & _
        '" FROM            tblPart INNER JOIN " & _
        '  "                       tblLabourPart ON tblPart.Code = tblLabourPart.Code where Type='Part' and QuoteNo=" & quoteNo
        Dim sql As String = "SELECT       sum( tblPart.SellPrice * tblLabourPart.Qty) AS Expr1" & _
" FROM            tblPart INNER JOIN " & _
   "                      tblLabourPart ON tblPart.Code = tblLabourPart.Code INNER JOIN " & _
  "                       tblQuoteLabour ON tblLabourPart.LabourNo = tblQuoteLabour.LabourNo " & _
" WHERE        (tblQuoteLabour.QuoteNo = " & quoteNo & ")"

        Dim cmd As New SqlCommand(Sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim amount As Decimal = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return amount
    End Function

    Private Sub populatePartList(quoteNo As Integer)
        partList.Clear()
        Dim sql As String = "SELECT        tblLabourPart.Code, tblLabourPart.Qty" & _
" FROM            tblLabourPart INNER JOIN " & _
        "                 tblQuoteLabour ON tblLabourPart.LabourNo = tblQuoteLabour.LabourNo " & _
       " WHERE(tblQuoteLabour.QuoteNo = " & quoteNo & ")"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            partList.Add(reader("Code") & "," & reader("Qty"))
        End While
        reader.Close()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Function getlabour(quoteNo As Integer) As Decimal
        Dim sql As String = "select sum(qty*price) from tblquotelabour where   QuoteNo=" & quoteNo
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim amount As Decimal = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return amount
    End Function

    Private Sub btnInvoice_Click(sender As System.Object, e As System.EventArgs) Handles btnInvoice.Click
        If String.IsNullOrEmpty(txtQuoteNo.Text) Then
            MsgBox("Please Enter Quotation Number", 48)
        ElseIf Not CBool(Integer.TryParse(txtQuoteNo.Text, 0)) Then
            MsgBox("Quote Number must be integer value")
        ElseIf Not checkQuoteNo(txtQuoteNo.Text) Then
            MsgBox("Invalid Quotation Number", 48)
        ElseIf checkIfChangedToInvoice(txtQuoteNo.Text) Then
            MsgBox("Invoice for this quotation has already been generated", 48)
        Else


            Dim quoteNo As Integer = txtQuoteNo.Text

            populatePartList(quoteNo)

            For Each Parts As String In partList
                Dim data(1) As String
                data = Parts.Split(",")
                deductePart(data(1), data(0))
            Next Parts

            insertInvoice(quoteNo)



            MsgBox("Invoice Successfully been Created", 64)


            If chksignature.Checked = True Then
                printInvoice2(quoteNo)
            Else
                printInvoice1(quoteNo)
            End If
            clear()

            Close()
        End If
    End Sub

    Public Sub printInvoice2(ByVal bkno As Integer)

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
        report.SetParameterValue(0, getInvoiceNo)
        report.SetParameterValue(1, merchant)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Public Sub printInvoice1(ByVal bkno As Integer)

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
        report.SetParameterValue(0, getInvoiceNo)
        report.SetParameterValue(1, merchant)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Private Sub updateBalance(ByVal custNo As String, _
                             ByVal amount As Decimal)
        Dim cmd As New sqlCommand("update tblcustomer set balance=balance+" & amount & " where customerNo=@custNo", objCon)
        objCon.Close()
        objCon.Open()
        cmd.Parameters.Add("@custNo", SqlDbType.Char).Value = custNo
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Function getInvoiceNo() As Integer
        Dim cmd As New SqlCommand("select max(InvoiceNo) from tbInvoice", objCon)
        objCon.Close()
        objCon.Open()
        Dim number As Integer = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function

    Private Sub insertInvoice(quoteNo As Integer)
        Dim cmd As New SqlCommand("insert into tbInvoice values('" & Now.Date & "', " & quoteNo & ")", objCon)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteScalar()
        objCon.Close()
        cmd.Dispose()
    End Sub


    Private Sub deductePart(ByVal Number As Integer, _
                            ByVal Code As String)
        Dim cmd As New SqlCommand("update tblPart set qty=qty-" & Number & " where code=@code", objCon)
        objCon.Close()
        objCon.Open()
        cmd.Parameters.Add("@code", SqlDbType.Char).Value = Code
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
End Class