Imports System.Data.SqlClient
' Imports System.Data.SqlClient

Public Class ChangePassword

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtConfirm.Clear()
        txtNewPassword.Clear()
        txtOldPassword.Clear()

        txtOldPassword.Focus()
    End Sub

    Public Function LoginUser(ByVal password As String) As Boolean
        Dim value As Boolean = False

        Dim cmd As New sqlCommand("select * from tblemployee where EmployeeNo=@user and password=@pass", objCon)

        'pass paramters
        cmd.Parameters.Add("@user", SqlDbType.Char).Value = loggedEmpoyee
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password

        ' close connectionn to the database in case is open
        objCon.Close()

        ' close connectionn to the database in case is open
        objCon.Open()

        ' declare reader variabl 
        Dim reader As sqlDataReader = cmd.ExecuteReader

        ' check if the reader variable has return record
        If reader.Read Then
            value = True
        End If

        ' close reader variable
        reader.Close()


        ' close connectionn to the database in case is open
        objCon.Close()

        'dispose memory of the database
        cmd.Dispose()

        '       value.Sort()

        Return value
    End Function


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Try

            If String.IsNullOrEmpty(txtOldPassword.Text) Then
                MsgBox("Please Enter Old Password", 48)
                txtOldPassword.Focus()
            ElseIf String.IsNullOrEmpty(txtNewPassword.Text) Then
                MsgBox("Please Enter New Password", 48)
                txtNewPassword.Focus()
            ElseIf String.IsNullOrEmpty(txtConfirm.Text) Then
                MsgBox("Please Confirm Password", 48)
                txtConfirm.Focus()
            ElseIf txtNewPassword.Text.Length < 4 Then
                MsgBox("Password must be atleast 4 characters", 48)
            ElseIf txtNewPassword.Text <> txtConfirm.Text Then
                MsgBox("Password does not match", 48)
                txtConfirm.Focus()
            ElseIf LoginUser(txtOldPassword.Text) = False Then
                MsgBox("Old Password is incorrect", 48)
                txtOldPassword.Focus()
            ElseIf txtOldPassword.Text = txtNewPassword.Text Then
                MsgBox("Old Password can not be the same as new password", 48)
            Else
             
                Dim cmd As New sqlCommand("UPDATE tblEmployee SET [Password]=@Pass WHERE EmployeeNo=@user", objCon)
                objCon.Close()
                objCon.Open()
                cmd.Parameters.AddWithValue("@User", loggedEmpoyee)
                cmd.Parameters.AddWithValue("@Pass", txtNewPassword.Text)
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()

                txtConfirm.Clear()
                txtNewPassword.Clear()
                txtOldPassword.Clear()

                txtOldPassword.Focus()

                MsgBox("Your Password Successfully Updated in the Database", 64)
            End If

        Catch ex As Exception
            MsgBox("You have an error please contact system administrator" & vbLf & ex.Message, 48)
        End Try
    End Sub


End Class