Imports System.Data.SqlClient

Public Class SendSMS

    Private Sub rdbQuotation_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbQuotation.CheckedChanged
        lblValue.Text = "Quotation No:"
        txtNumber.MaxLength = 7
        txtNumber.Focus()
        txtNumber.Clear()
    End Sub

    Private Sub rdbBooking_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbBooking.CheckedChanged
        lblValue.Text = "Booking No:"
        txtNumber.MaxLength = 7
        txtNumber.Focus()
        txtNumber.Clear()

    End Sub

    Private Sub rdbIndividual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbIndividual.CheckedChanged
        lblValue.Text = "Cellphone No: "
        txtNumber.MaxLength = 10
        txtNumber.Focus()
        txtNumber.Clear()
    End Sub

    Private Sub SendSMS_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        rdbIndividual.Checked = True
        rdbIndividual_CheckedChanged(sender, e)

    End Sub

    Sub clear()
        rdbIndividual.Checked = True
        lblValue.Text = "Cellphone No: "
        txtNumber.MaxLength = 10
        txtMsg.Clear()
        txtNumber.Clear()
        txtNumber.Focus()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As System.EventArgs) Handles txtNumber.Leave
        If Not String.IsNullOrEmpty(txtNumber.Text) Then
            If Not ValidNumber(txtNumber.Text) Then
                MsgBox("Please Enter numeric value", 48)
                txtNumber.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private theNumber As String

    Private Sub btnSendSMS_Click(sender As System.Object, e As System.EventArgs) Handles btnSendSMS.Click

        'Dim number As String = txtCellphoneMo.Text.Replace(" ", "")

        'number = number.Replace("(", "")
        'number = number.Replace(")", "")

        'number = number.Replace("-", "")

        'number = "+27" & number.Substring(1)

        If String.IsNullOrEmpty(txtNumber.Text) Then
            MsgBox("Please Type value for number", 48)
            txtNumber.Focus()
        ElseIf String.IsNullOrEmpty(txtMsg.Text) Then
            MsgBox("Please Enter Message to send", 48)
            txtMsg.Focus()
        ElseIf rdbQuotation.Checked = True Then
            If Not checkQuotationNo(txtNumber.Text) Then
                MsgBox("Invalid Quotation Number", 48)
                txtNumber.Focus()
            Else
                Dim number As String = getQuoatationCellNo(txtNumber.Text).Replace(" ", "")

                number = number.Replace("(", "")
                number = number.Replace(")", "")

                number = number.Replace("-", "")

                number = "+27" & number.Substring(1)
                MyApplication.Main(number, txtMsg.Text)
                clear()
                MsgBox("Message Sent Successfully", 64)
            End If
        ElseIf rdbBooking.Checked = True Then
            If Not checkBookingNo(txtNumber.Text) Then
                MsgBox("Invalid Booking Number", 48)
                txtNumber.Focus()
            Else
                Dim number As String = theNumber.Replace(" ", "")

                number = number.Replace("(", "")
                number = number.Replace(")", "")

                number = number.Replace("-", "")

                number = "+27" & number.Substring(1)
                MyApplication.Main(number, txtMsg.Text)
                clear()
                MsgBox("Message Sent Successfully", 64)
            End If
        ElseIf rdbIndividual.Checked = True Then
            If txtNumber.Text.Length <> 10 Then
                MsgBox("Cellphone Number must beb 10 digits", 48)
                txtNumber.Focus()
            ElseIf txtNumber.Text.StartsWith("0") = False Then
                MsgBox("Cellphone number must start with 0", 48)
                txtNumber.Focus()
            Else
                Dim number As String = "+27" & txtNumber.Text.Substring(1)
                MyApplication.Main(number, txtMsg.Text)
                clear()
                MsgBox("Message Sent Successfully", 64)
            End If
        End If
    End Sub


    Private Function getQuoatationCellNo(quotation As Integer) As String
        Dim value As String = ""
        Dim cmd As New SqlCommand("SELECT        tblCustomer.MobileNo " & _
" FROM            tblQuote INNER JOIN  " & _
   "                      tblVehicle ON tblQuote.RegistrationNo = tblVehicle.registrationno INNER JOIN " & _
      "                   tblCustomer ON tblVehicle.CustomerNo = tblCustomer.CustomerNo " & _
"WHERE        (tblQuote.QuoteNo = " & quotation & ")", objCon)
        objCon.Close()
        objCon.Open()
        value = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return value
    End Function

    Private Function checkBookingNo(bookingNo As Integer) As Boolean
        Dim value As Boolean = False
        Dim cmd As New SqlCommand("select * from tblBooking where bookingno=" & bookingNo, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            theNumber = reader("CellphoneNo")
            value = True
        End If
        reader.Close()
        objCon.Close()
        cmd.Dispose()
        Return value
    End Function

    Private Function checkQuotationNo(quotationNo As Integer) As Boolean
        Dim value As Boolean = False
        Dim cmd As New SqlCommand("select * from tblQuote where quoteNo=" & quotationNo, objCon)
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
End Class