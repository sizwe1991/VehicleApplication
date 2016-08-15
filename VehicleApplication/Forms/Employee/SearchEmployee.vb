Imports System.Data.SqlClient

Public Class SearchEmployee

    Private Sub SearchEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadEmployees()
    End Sub

    Private Sub loadEmployees()
        Dim cmd As New SqlCommand("select EmployeeNo, Name, Surname, ContactNo,EmailAddress from tblEmployee", objCon)
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
        Dim cmd As New sqlCommand("select EmployeeNo, Name, Surname, ContactNo,EmailAddress from tblEmployee where name like '%" & TextBox1.Text & "%' or emailaddress like '%" & TextBox1.Text & "%' or surname like '%" & TextBox1.Text & "%' or contactno like '%" & TextBox1.Text & "%'", objCon)
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
    '    If MessageBox.Show("Do you want to Update selected Employee", "Update Employee Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
    '        Hide()
    '        employeeNo = DataGridView1.CurrentRow.Cells(1).Value
    '        Me.Close()
    '        UpdateEmployee.ShowDialog()
    '    End If
    'End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub


    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        loadEmployees()
    End Sub

    Private Sub btnChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePassword.Click
        Dim frma As New ChangePassword
        frma.ShowDialog()
    End Sub

    Private Sub btnNewEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnNewEmployee.Click
        Dim frma As New NewEmployee
        frma.ShowDialog()
    End Sub

    Private objEmp As EmployeePD


    Private objEmployee As New EmployeeDA

    Private Sub btnEditEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnEditEmployee.Click
        txtEmployeeNumber.Text = DataGridView1.CurrentRow.Cells(0).Value

        objEmp = objEmployee.getEmployeeInfo(txtEmployeeNumber.Text)


        txtName.Text = objEmp.Name
        txtSurname.Text = objEmp.Surname
        'txtPostal.Text = objEmp.Postal
        'txtPhysical.Text = objEmp.Physical
        txtCell.Text = objEmp.Cell
        txtEmail.Text = objEmp.Email
        txtQuestion.Text = objEmp.Question
        txtAnswer.Text = objEmp.Answer

        Panel2.Show()
    End Sub



    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.Leave
        If String.IsNullOrEmpty(txtName.Text) = False Then
            If ValidAlphabet(txtName.Text) = False Then
                MsgBox("Name must be alphabets only", 48)
                txtName.Focus()
            End If
        End If

    End Sub


    Private Sub txtSurnameName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSurname.Leave
        If String.IsNullOrEmpty(txtSurname.Text) = False Then
            If ValidAlphabet(txtSurname.Text) = False Then
                MsgBox("Surname must be alphabets only", 48)
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
                'ElseIf objEmployee.searchEmail(txtEmail.Text) Then
                '    MsgBox("Employee with the same email address exists already the database", 48)
            End If
        End If
    End Sub




    Private Sub clear()
        txtName.Clear()
        txtSurname.Clear()
        'txtPostal.Clear()
        'txtPhysical.Clear()
        txtCell.Clear()
        txtEmail.Clear()
        txtQuestion.Clear()
        txtAnswer.Clear()
        'txtUsername.Clear()
        'txtPwd.Clear()
        'txtConfirm.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If isClose() Then
            Panel2.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please Enter Employee Name", 48)
            txtName.Focus()
        ElseIf String.IsNullOrEmpty(txtSurname.Text) Then
            MsgBox("Please Enter Employee Surname", 48)
            txtSurname.Focus()
            'ElseIf String.IsNullOrEmpty(txtPhysical.Text) Then
            '    MsgBox("Please Enter Customer Physical Address", 48)
            '    txtPhysical.Focus()
            'ElseIf String.IsNullOrEmpty(txtPostal.Text) Then
            '    MsgBox("Please Enter Customer Postal Address", 48)
            '    txtPhysical.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please Enter Email Address", 48)
        ElseIf txtCell.Text.Length <> 14 Then
            MsgBox("Employee must have 10 Digits Celephone Number", 48)
            txtCell.Focus()
        ElseIf txtCell.Text.Substring(1, 1) <> "0" Then
            MsgBox("Invalid Cellphone Number, Telephone number must start with 0", 48)
            txtCell.Focus()
        ElseIf objEmployee.searchCell(txtCell.Text) Then
            MsgBox("Cellphone number exists in the database", 48)
            txtCell.Focus()
        ElseIf String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please Enter Email Address", 48)
            txtEmail.Focus()
        ElseIf String.IsNullOrEmpty(txtQuestion.Text) Then
            MsgBox("Please Enter Security Question", 48)
            txtQuestion.Focus()
        ElseIf String.IsNullOrEmpty(txtAnswer.Text) Then
            MsgBox("Please Enter Security Answer", 48)
            txtAnswer.Focus()
            'ElseIf String.IsNullOrEmpty(txtUsername.Text) Then
            '    MsgBox("Please Enter Username", 48)
            '    txtUsername.Focus()
            'ElseIf txtUsername.Text.Length < 5 Then
            '    MsgBox("username must be atleast be 5 characters", 48)
            '    txtUsername.Focus()
            'ElseIf String.IsNullOrEmpty(txtPwd.Text) Then
            '    MsgBox("Please Enter Password", 48)
            '    txtPwd.Focus()
            'ElseIf txtPwd.Text.Length < 5 Then
            '    MsgBox("Password must be atleast be 5 characters", 48)
            '    txtPwd.Focus()
            'ElseIf String.IsNullOrEmpty(txtConfirm.Text) Then
            '    MsgBox("Please Confirm Password", 48)
            '    txtConfirm.Focus()
            'ElseIf txtPwd.Text <> txtConfirm.Text Then
            '    MsgBox("Password does not match", 48)
            '    txtConfirm.Focus()
        Else
            'objEmp.Name = txtName.Text
            'objEmp.Surname = txtSurname.Text
            'objEmp.Postal = txtPostal.Text
            'objEmp.Physical = txtName.Text
            'objEmp.Cell = txtCell.Text
            'objEmp.Email = txtEmail.Text
            'objEmp.Question = txtQuestion.Text
            'objEmp.Answer = txtAnswer.Text

            objEmp = New EmployeePD(txtName.Text, txtSurname.Text, txtCell.Text, txtEmail.Text, txtQuestion.Text, txtAnswer.Text, "", "")

            objEmployee.UpdateEmployee(txtEmployeeNumber.Text, objEmp)


            MsgBox("New Employee Save Successfully in the Database", 64)

            clear() : Panel2.Hide()
        End If
    End Sub
End Class