Imports System.Data.Sqlclient

Public Class SearchSupplier

    Private Sub loadSupplier()
        Dim cmd As New SqlCommand("select Supplierid,name,emailaddress,telno,faxno from tblSupplier", objCon)
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

    Private Sub SearchSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadSupplier()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New sqlCommand("select Supplierid,name,emailaddress,telno,faxno from tblSupplier where name like '%" & TextBox1.Text & "%' or emailaddress like '%" & TextBox1.Text & "%'", objCon)
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

 

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub clear()
        txtName.Clear()
        '     txtPhysical.Clear()
        '    txtPostal.Clear()
        txtEmail.Clear()
        txtTel.Clear()
        txtFax.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Leave
        If String.IsNullOrEmpty(txtName.Text) = False Then
            If ValidAlphabet(txtName.Text) = False Then
                MsgBox("Name must be alphabets onlys", 48)
                txtName.Focus()
            ElseIf objSupplierDA.getSupplierNo(txtName.Text) <> 0 Then
                MsgBox("Supplier Already exists in the database", 48)
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
            ElseIf objSupplierDA.searchEmail(txtEmail.Text) Then
                MsgBox("Supplier witht the same email address exists already the database", 48)
            End If
        End If
    End Sub

    Private objSupplierDA As New SupplierDA

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If isClose() Then
            Panel2.Hide()
        End If
    End Sub

    Private Sub btnSaveSupplier_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveSupplier.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please Enter Supplier Name", 48)
            txtName.Focus()
            'ElseIf String.IsNullOrEmpty(txtPhysical.Text) Then
            '    MsgBox("Please Enter Supplier Physical Address", 48)
            '    txtPhysical.Focus()
            'ElseIf String.IsNullOrEmpty(txtPostal.Text) Then
            '    MsgBox("Please Enter Supplier Postal Address", 48)
            '    txtPhysical.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please Enter Email Address", 48)
        ElseIf txtTel.Text.Length <> 14 Then
            MsgBox("Please Supplier 10 Digits Supplier Telephone Number", 48)
            txtTel.Focus()
        ElseIf txtTel.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Telephone Number, Telephone number must start with 0", 48)
            txtTel.Focus()
        ElseIf objSupplierDA.searchTel(txtTel.Text) Then
            MsgBox("Supplier with the same telephone number exists already in the database", 48)
            txtTel.Focus()
        ElseIf txtFax.Text.Length = 14 And txtFax.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Fax Number valid Fax No must start with 0", 48)
            txtFax.Focus()
        ElseIf txtFax.Text.Length = 14 And objSupplierDA.searchfax(txtEmail.Text) Then
            MsgBox("Supplier with the same fax No exist already in the database", 48)
            txtFax.Focus()
        Else
            Dim faxNo As String = ""

            If txtFax.Text.Length = 14 Then
                faxNo = txtFax.Text
            End If

            Dim objSupplier As New SupplierPD(txtName.Text, txtEmail.Text, txtTel.Text, faxNo)


            objSupplierDA.saveSupplier(objSupplier)

            clear()

            MsgBox("New Supplier Successfully Saved into the database", 64)

            Panel2.Hide()


            loadSupplier()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel2.Show()
    End Sub

 
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click


        Dim supplierPD As SupplierPD = objSupplierDA.getSupplierInfo(DataGridView1.CurrentRow.Cells(0).Value)

        txtEditName.Text = supplierPD.Name
        txtEditEmail.Text = supplierPD.Email
        txtEditTelNo.Text = supplierPD.Tel
        txtEditFax.Text = supplierPD.Fax

        Panel2.Show()
        Panel3.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If isClose() Then
            Panel2.Hide() : Panel3.Hide()
        End If
    End Sub

   
  
    Private Sub btnEditSave_Click(sender As System.Object, e As System.EventArgs) Handles btnEditSave.Click
        If String.IsNullOrEmpty(txtEditName.Text) Then
            MsgBox("Please Enter Supplier Name", 48)
            txtEditName.Focus()
            'ElseIf String.IsNullOrEmpty(txtPhysical.Text) Then
            '    MsgBox("Please Enter Supplier Physical Address", 48)
            '    txtPhysical.Focus()
            'ElseIf String.IsNullOrEmpty(txtPostal.Text) Then
            '    MsgBox("Please Enter Supplier Postal Address", 48)
            '    txtPhysical.Focus()
        ElseIf String.IsNullOrEmpty(txtEditEmail.Text) Then
            MsgBox("Please Enter Email Address", 48) : txtEditEmail.Focus()
        ElseIf txtEditTelNo.Text.Length <> 14 Then
            MsgBox("Please Supplier 10 Digits Supplier Telephone Number", 48)
            txtEditTelNo.Focus()
        ElseIf txtEditTelNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Telephone Number, Telephone number must start with 0", 48)
            txtEditTelNo.Focus()
            'ElseIf objSupplierDA.searchTel(txtTel.Text) Then
            '    MsgBox("Supplier with the same telephone number exists already in the database", 48)
            '    txtTel.Focus()
        ElseIf txtEditFax.Text.Length = 14 And txtEditFax.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Fax Number valid Fax No must start with 0", 48)
            txtEditFax.Focus()
            'ElseIf txtEditFax.Text.Length = 14 And objSupplierDA.searchfax(txtEmail.Text) Then
            '    MsgBox("Supplier with the same fax No exist already in the database", 48)
            '    txtEditFax.Focus()
        Else
            Dim faxNo As String = ""

            If txtFax.Text.Length = 14 Then
                faxNo = txtEditFax.Text
            End If

            Dim objSupplier As New SupplierPD(txtEditName.Text, txtEditEmail.Text, txtEditTelNo.Text, faxNo)


            objSupplierDA.UpdateSupplier(DataGridView1.CurrentRow.Cells(0).Value, objSupplier)

            clear()

            MsgBox("New Supplier Successfully Saved into the database", 64)

            Panel2.Hide()


            loadSupplier()

            Close()
        End If

    End Sub
End Class