Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        '  Me.Close()
        If String.IsNullOrEmpty(UsernameTextBox.Text) Then
            MsgBox("Please Enter  Username", 48)
            UsernameTextBox.Focus()
        ElseIf String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MsgBox("Please Enter Password", 48)
            PasswordTextBox.Focus()
        ElseIf login(UsernameTextBox.Text, PasswordTextBox.Text) Then
            loggedEmpoyee = New EmployeeDA().getEmplpoyeeNo(UsernameTextBox.Text)
           Dim frm As New Main : Me.Hide()
            frm.ShowDialog() : Close()
        Else
            MsgBox("Password or Username is incorrect", 48)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnForgotPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgotPassword.Click
        ForgotPassword.ShowDialog()
    End Sub
End Class
