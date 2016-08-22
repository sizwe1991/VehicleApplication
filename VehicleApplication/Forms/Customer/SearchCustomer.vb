

Imports System.Data.Sqlclient

Public Class SearchCustomer

 
 

    Private Sub loadCustomers()
        Dim cmd As New SqlCommand("select  CustomerNo, CompanyName, FaxNo, TelNo, EmailAddress from tblCustomer", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New sqlCommand("select  CustomerNo, CompanyName, FaxNo, TelNo, EmailAddress from tblCustomer where CompanyName like '%" & TextBox1.Text & "%' or EmailAddress like '%" & TextBox1.Text & "%'", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New sqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        cmd.Dispose()
        objCon.Close()
    End Sub

    'Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    If MessageBox.Show("Do you want to Update selected Customer", "Update Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
    '        Hide()
    '        CustomerNo = DataGridView1.CurrentRow.Cells(1).Value
    '        Me.Close()
    '        UpdateCustomer.ShowDialog()
    '    End If
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub btnNewCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnNewCustomer.Click
        Dim frm As New NewCustomer
        frm.ShowDialog()
    End Sub

    Private CustomerNo As Integer
    Private objCustomerDA As New CustomerDA

    Private Sub btnEditCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnEditCustomer.Click

        CustomerNo = DataGridView1.CurrentRow.Cells(0).Value

        Dim customerpd As CustomerPD = objCustomerDA.getCustomerInfo(CustomerNo)

        txtName.Text = customerpd.Name
        txtPhysical.Text = customerpd.Physical
        txtPostal.Text = customerpd.Postal
        txtEmail.Text = customerpd.Email
        txtTel.Text = customerpd.Tel
        txtFax.Text = customerpd.Fax
        txtMobileNo.Text = customerpd.Mobile


        Panel2.Show()
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

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If isClose() Then
            Panel2.Hide()
        End If
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        loadCustomers()
    End Sub

  
    Private Sub SearchCustomer_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadCustomers()
    End Sub


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

    Private Sub btnSaveCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveCustomer.Click
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
            'ElseIf objCustomerDA.searchTel(txtTel.Text) Then
            '    MsgBox("Customer with the same telephone number exists already in the database", 48)
            '    txtTel.Focus()
        ElseIf txtFax.Text.Length = 14 And txtFax.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Fax Number valid Fax No must start with 0", 48)
            txtFax.Focus()
            'ElseIf txtFax.Text.Length = 14 And objCustomerDA.searchfax(txtEmail.Text) Then
            '    MsgBox("Customer with the same fax No exist already in the database", 48)
            '    txtFax.Focus()
        ElseIf txtMobileNo.Text.Length <> 14 Then
            MsgBox("Customer Mobile Number must be 10 Digits", 48)
            txtMobileNo.Focus()
        ElseIf txtMobileNo.Text.Length <> 14 Then
            MsgBox("Customer Mobile Number must be 10 Digits", 48)
            txtMobileNo.Focus()
        ElseIf txtMobileNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Mobile Number, txtMobileNo number must start with 0", 48)
            txtMobileNo.Focus()

        Else
            Dim faxNo As String = ""

            If txtFax.Text.Length = 14 Then
                faxNo = txtFax.Text
            End If

            Dim objCustomer As New CustomerPD(txtName.Text, txtPhysical.Text, txtPostal.Text, txtEmail.Text, txtTel.Text, faxNo, txtMobileNo.Text)

            objCustomerDA.UpdateCustomer(CustomerNo, objCustomer)

            MsgBox("Customer has Successfully been Edited in the database", 64)

            clear()

            btnReload.PerformClick()

            Panel2.Hide()
        End If
    End Sub
End Class