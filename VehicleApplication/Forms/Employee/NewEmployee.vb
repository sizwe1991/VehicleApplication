Imports System.Data.Sqlclient

Public Class NewEmployee


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


    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Leave
        If String.IsNullOrEmpty(txtUsername.Text) = False Then
            If ValidAlphabet(txtUsername.Text) = False Then
                MsgBox("username must be alphabets only", 48)
                txtUsername.Focus()
            ElseIf objEmployee.searchUsername(txtUsername.Text) Then
                MsgBox("username exist in the database", 48)
                txtUsername.Focus()
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
            ElseIf objEmployee.searchEmail(txtEmail.Text) Then
                MsgBox("Employee with the same email address exists already the database", 48)
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
        txtUsername.Clear()
        txtPwd.Clear()
        txtConfirm.Clear()
        txtName.Focus()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub


    Private objEmployee As New EmployeeDA


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
        ElseIf String.IsNullOrEmpty(txtUsername.Text) Then
            MsgBox("Please Enter Username", 48)
            txtUsername.Focus()
        ElseIf txtUsername.Text.Length < 5 Then
            MsgBox("username must be atleast be 5 characters", 48)
            txtUsername.Focus()
        ElseIf String.IsNullOrEmpty(txtPwd.Text) Then
            MsgBox("Please Enter Password", 48)
            txtPwd.Focus()
        ElseIf txtPwd.Text.Length < 5 Then
            MsgBox("Password must be atleast be 5 characters", 48)
            txtPwd.Focus()
        ElseIf String.IsNullOrEmpty(txtConfirm.Text) Then
            MsgBox("Please Confirm Password", 48)
            txtConfirm.Focus()
        ElseIf txtPwd.Text <> txtConfirm.Text Then
            MsgBox("Password does not match", 48)
            txtConfirm.Focus()
        Else
            'Try
            Dim objEmpPD As EmployeePD = New EmployeePD(txtName.Text, txtSurname.Text, txtCell.Text, txtEmail.Text, txtQuestion.Text, txtAnswer.Text, txtUsername.Text, txtPwd.Text)
            objEmployee.saveEmployee(objEmpPD)

            'Catch ex As sqlException
            '    MessageBox.Show(ex.InnerException.Message)

            'End Try

            MsgBox("New Employee Save Successfully in the Database", 64)

            clear()
        End If
    End Sub
End Class