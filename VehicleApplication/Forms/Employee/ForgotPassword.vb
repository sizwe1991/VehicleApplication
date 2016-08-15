Imports System.Data.Sqlclient

Public Class ForgotPassword

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtAnswer.Clear()
        txtQuestion.Clear()
        txtUsername.Clear()

        txtUsername.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If String.IsNullOrEmpty(txtUsername.Text) Then
            MsgBox("Please Enter Username", 48)
            txtUsername.Focus()
        ElseIf New EmployeeDA().searchUsername(txtUsername.Text) Then
            empPD = New EmployeeDA().getEmployeeInfo(New EmployeeDA().getEmplpoyeeNo(txtUsername.Text))
            txtQuestion.Text = empPD.Question
        Else
            MsgBox("Username does not exists in our database", 48)
            txtUsername.Focus()
        End If


    End Sub

    Dim empPD As EmployeePD = Nothing

    Private Sub btnRecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecover.Click
        Try

            If String.IsNullOrEmpty(txtUsername.Text) Then
                MsgBox("Please Enter Username", 48)
                txtUsername.Focus()
            ElseIf New EmployeeDA().searchUsername(txtUsername.Text) = False Then
                MsgBox("Username does not exists in our database", 48)
                txtUsername.Focus()
            ElseIf String.IsNullOrEmpty(txtAnswer.Text) Then
                MsgBox("Please Enter Security Answer", 48)
                txtAnswer.Focus()
            Else





                If empPD.Answer <> txtAnswer.Text Then
                    MsgBox("Security Answer is incorrect please try again", 48)
                    txtAnswer.Focus()
                Else
                    Dim usr As String = txtUsername.Text
                    btnCancel.PerformClick()
                    MsgBox("Thank you, your Password: " & empPD.Passsword, 64)
                End If
            End If

        Catch ex As Exception
            MsgBox("You have an error please contact system administrator" & vbLf & ex.Message, 48)
        End Try
    End Sub



    'Private Function getPassword(ByVal Uername As String) As String
    '    Dim value As String = ""
    '    Dim cmd As New SqlCommand("select * from Employee where Username=@username", objcon)
    '    cmd.Parameters.AddWithValue("@username", Uername)
    '    objcon.Close()
    '    objcon.Open()
    '    Dim reader As SqlDataReader = cmd.ExecuteReader
    '    If reader.Read Then
    '        value = reader("Password")
    '    End If
    '    reader.Close()
    '    objcon.Close()
    '    Return value
    'End Function
End Class