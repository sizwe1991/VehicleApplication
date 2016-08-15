Public Class NewCustomer

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Leave
        If String.IsNullOrEmpty(txtName.Text) = False Then
            If ValidAlphabet(txtName.Text) = False Then
                MsgBox("Name must be alphabets onlys", 48)
                txtName.Focus()
            End If
        End If

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.Leave
        If String.IsNullOrEmpty(txtEmail.Text) = False Then
            If txtEmail.Text.Contains("@") = False Or txtEmail.Text.Contains(".") = False Then
                MsgBox("Invalid Email address", 48)
                txtEmail.Focus()
            ElseIf txtEmail.Text.StartsWith("@") Or txtEmail.Text.EndsWith("@") Then
                MsgBox("Invalid Email address, can not start or end with @", 48)
                txtEmail.Focus()
            ElseIf txtEmail.Text.StartsWith(".") Or txtEmail.Text.EndsWith(".") Then
                MsgBox("Invalid Email address, can not start or end with .", 48)
                txtEmail.Focus()
            ElseIf objCustomerDA.searchEmail(txtEmail.Text) Then
                MsgBox("Customer with the same email address exists already the database", 48)
                txtEmail.Focus()
            End If
        End If
    End Sub

    Private objCustomerDA As New CustomerDA


    Private Sub btnSaveSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSupplier.Click



        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please Enter Customer Name", 48)
            txtName.Focus()
        ElseIf String.IsNullOrEmpty(txtPhysical.Text) Then
            MsgBox("Please Enter Customer Physical Address", 48)
            txtPhysical.Focus()
        ElseIf String.IsNullOrEmpty(txtPostal.Text) Then
            MsgBox("Please Enter Customer Postal Address", 48)
            txtPhysical.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please Enter Email Address", 48)
        ElseIf txtTel.Text.Length <> 14 Then
            MsgBox("Customer Telephone Number must be 10 Digits", 48)
            txtTel.Focus()
        ElseIf txtTel.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Telephone Number, Telephone number must start with 0", 48)
            txtTel.Focus()
        ElseIf objCustomerDA.searchTel(txtTel.Text) Then
            MsgBox("Customer with the same telephone number exists already in the database", 48)
            txtTel.Focus()
        ElseIf txtFax.Text.Length = 14 And txtFax.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Fax Number valid Fax No must start with 0", 48)
            txtFax.Focus()
        ElseIf txtFax.Text.Length = 14 And objCustomerDA.searchfax(txtEmail.Text) Then
            MsgBox("Customer with the same fax No exist already in the database", 48)
            txtFax.Focus()
        ElseIf txtMobileNo.Text.Length <> 14 Then
            MsgBox("Customer Mobile Number must be 10 Digits", 48)
            txtMobileNo.Focus()
        ElseIf txtMobileNo.Text.Length <> 14 Then
            MsgBox("Customer Mobile Number must be 10 Digits", 48)
            txtMobileNo.Focus()
        ElseIf txtMobileNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Mobile Number, txtMobileNo number must start with 0", 48)
            txtMobileNo.Focus()
        ElseIf objCustomerDA.searchMobile(txtMobileNo.Text) Then
            MsgBox("Customer with the same Mobile number exists already in the database", 48)
            txtMobileNo.Focus()
        Else
            Dim faxNo As String = ""

            If txtFax.Text.Length = 14 Then
                faxNo = txtFax.Text
            End If

            Dim objCustomer As New CustomerPD(txtName.Text, txtPhysical.Text, txtPostal.Text, txtEmail.Text, txtTel.Text, faxNo, txtMobileNo.Text)




            objCustomerDA.saveCustomer(objCustomer)


            MsgBox("New Customer Successfully Saved into the database", 64)


            clear()

            Close()
        End If
    End Sub

    Private Sub clear()
        txtName.Clear()
        txtPhysical.Clear()
        txtPostal.Clear()
        txtEmail.Clear()
        txtTel.Clear()
        txtFax.Clear()
        txtName.Focus()
        txtMobileNo.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

 
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Me.Close()
        End If
    End Sub

  
End Class