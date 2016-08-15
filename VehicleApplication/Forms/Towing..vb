Imports System.Data.SqlClient

Public Class Towing

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Sub clear()
        txtCompany.Clear()
        txtFaxNo.Clear()
        txtKM.Clear()
        txtModel.Clear()
        txtPrice.Clear()
        txtregNo.Clear()
        txtTelNo.Clear()
        txtregNo.Focus()
        NumericUpDown1.Value = 1
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnSaveSupplier_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveSupplier.Click
        If String.IsNullOrEmpty(txtregNo.Text) Then
            MsgBox("Please Enter Registration No", 48)
            txtregNo.Focus()
        ElseIf String.IsNullOrEmpty(txtKM.Text) Then
            MsgBox("Please Enter Kilometer Reading", 48)
            txtKM.Focus()
        ElseIf String.IsNullOrEmpty(txtCompany.Text) Then
            MsgBox("Please Enter Company Name", 48)
            txtCompany.Focus()
        ElseIf txtTelNo.Text.Replace(" ", "") = "()-" Then
            MsgBox("Please enter Telephone No", 48)
            txtTelNo.Focus()
        ElseIf txtTelNo.Text.Length <> 14 Then
            MsgBox("Telephone No must be 10 digits long", 48)
            txtTelNo.Focus()
        ElseIf txtTelNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Telephone Number must start with 0", 48)
            txtTelNo.Focus()
        ElseIf txtFaxNo.Text.Replace(" ", "") = "()-" Then
            MsgBox("Please enter Fax No", 48)
            txtFaxNo.Focus()
        ElseIf txtFaxNo.Text.Length <> 14 Then
            MsgBox("Fax No must be 10 digits long", 48)
            txtFaxNo.Focus()
        ElseIf txtFaxNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Fax Number must start with 0", 48)
            txtFaxNo.Focus()
        ElseIf txtFaxNo.Text = txtTelNo.Text Then
            MsgBox("Fax No and Tel no can not be the same", 48)
        Else
            Dim cmd As New SqlCommand("insert into [Towing.] values(@date,@desc,@reg,@km,@model,@company,@tel,@fax,@qty,@price)", objCon)
            objCon.Close()
            objCon.Open()




            cmd.Parameters.Add("@desc", SqlDbType.Char).Value = "Towing"
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Now.Date
            'cmd.Parameters.Add("@surname", SqlDbType.Char).Value = txtSurname.Text
            'cmd.Parameters.Add("@initials", SqlDbType.Char).Value = txtInitials.Text
            cmd.Parameters.Add("@km", SqlDbType.Char).Value = txtKM.Text
            cmd.Parameters.Add("@company", SqlDbType.Char).Value = txtCompany.Text
            'cmd.Parameters.Add("@name", SqlDbType.Char).Value = txtFullName.Text
            'cmd.Parameters.Add("@id", SqlDbType.Char).Value = txtID.Text
            cmd.Parameters.Add("@tel", SqlDbType.Char).Value = txtTelNo.Text

            cmd.Parameters.Add("@reg", SqlDbType.Char).Value = txtregNo.Text
            cmd.Parameters.Add("@model", SqlDbType.Char).Value = txtModel.Text
            cmd.Parameters.Add("@qty", SqlDbType.Char).Value = NumericUpDown1.Value
            cmd.Parameters.Add("@price", SqlDbType.Char).Value = txtPrice.Text
            cmd.Parameters.Add("@fax", SqlDbType.Char).Value = txtFaxNo.Text

            cmd.ExecuteNonQuery()
            objCon.Close()
            cmd.Dispose()



            clear()

            Dim bookingNo As Integer = getTowingNo()

            MsgBox("Tow has been saved successfully", 64)
            printBookingReport(bookingNo)

        End If
    End Sub

    Function getTowingNo() As Integer
        Dim cmd As New SqlCommand("select max(TowNo) from  [Towing.]", objCon)
        objCon.Close()
        objCon.Open()
        Dim number As Integer = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function

    Public Sub printBookingReport(ByVal bkno As Integer)

        Dim sql As String = "select * from [Towing.] where towno=" & bkno
        Dim cmd As New sqlDataAdapter
        Dim ds As New DataTable
        Dim report As New TowingCrystalReport
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
End Class