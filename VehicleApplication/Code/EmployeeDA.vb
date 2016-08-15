Imports System.Data.SqlClient

Public Class EmployeeDA
    Public Sub saveEmployee(ByVal objEmployee As EmployeePD)
        Try
            Dim cmd As New SqlCommand("insert into tblEmployee(Name, Surname, ContactNo, EmailAddress, Question, Answer, Username, [Password]) values('" & objEmployee.Name & "','" & objEmployee.Surname & "','" & objEmployee.Cell & "','" & objEmployee.Email & "','" & objEmployee.Question & "','" & objEmployee.Answer & "','" & objEmployee.Username & "','" & objEmployee.Passsword & "')", objCon)
            'cmd.Parameters.Add("@name", SqlDbType.Char).Value = objEmployee.Name
            'cmd.Parameters.Add("@surname", SqlDbType.Char).Value = objEmployee.Surname
            'cmd.Parameters.Add("@physical", SqlDbType.Char).Value = objEmployee.Physical
            'cmd.Parameters.Add("@postal", SqlDbType.Char).Value = objEmployee.Postal
            'cmd.Parameters.Add("@cell", SqlDbType.Char).Value = objEmployee.Cell
            'cmd.Parameters.Add("@email", SqlDbType.Char).Value = objEmployee.Email

            'cmd.Parameters.Add("@question", SqlDbType.Char).Value = objEmployee.Question
            'cmd.Parameters.Add("@answer", SqlDbType.Char).Value = objEmployee.Answer
            'cmd.Parameters.Add("@username", SqlDbType.Char).Value = objEmployee.Username
            'cmd.Parameters.Add("@password", SqlDbType.Char).Value = objEmployee.Passsword
            objCon.Close()
            objCon.Open()
            cmd.ExecuteNonQuery()
            objCon.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try
    End Sub


    Public Function searchUsername(ByVal username As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblEmployee where username=@username", objCon)
        cmd.Parameters.Add("@username", SqlDbType.Char).Value = username
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As Boolean = False
        If reader.Read Then
            value = True
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value


    End Function


    Public Function getEmplpoyeeNo(ByVal username As String) As Integer
        Dim cmd As New sqlCommand("select * from tblEmployee where username=@username", objCon)
        cmd.Parameters.Add("@username", SqlDbType.Char).Value = username
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As Integer
        If reader.Read Then
            value = reader(0)
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value


    End Function


    Public Function searchEmail(ByVal email As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblEmployee where EmailAddress=@email", objCon)
        cmd.Parameters.Add("@email", SqlDbType.Char).Value = email
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As Boolean = False
        If reader.Read Then
            value = True
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


    Public Function searchCell(ByVal cellNo As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblEmployee where contactNo=@tel", objCon)
        cmd.Parameters.Add("@tel", SqlDbType.Char).Value = cellNo
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As Boolean = False
        If reader.Read Then
            value = True
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function



    Public Function getEmployeeInfo(ByVal employeeNo As Integer) As EmployeePD
        Dim cmd As New sqlCommand("select * from tblEmployee where EmployeeNo=@supplierNo", objCon)
        cmd.Parameters.Add("@supplierNo", SqlDbType.int).Value = employeeNo
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As EmployeePD = Nothing
        If reader.Read Then
            value = New EmployeePD(reader("name"), reader("Surname"), reader("ContactNo"), reader("EmailAddress"), reader("Question"), reader("Answer"), reader("username"), reader("Password"))
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


    Public Sub UpdateEmployee(ByVal employeeNo As Integer, _
                              ByVal objEmployee As EmployeePD)
        Dim cmd As New SqlCommand("update tblEmployee set name=@name,surname=@surname,contactno=@cell,emailaddress=@email,question=@question,answer=@answer where employeeNo=@empNo", objCon)

        cmd.Parameters.Add("@empNo", SqlDbType.int).Value = employeeNo

        cmd.Parameters.Add("@name", SqlDbType.Char).Value = objEmployee.Name
        cmd.Parameters.Add("@surname", SqlDbType.Char).Value = objEmployee.Surname
        'cmd.Parameters.Add("@physical", SqlDbType.Char).Value = objEmployee.Physical
        'cmd.Parameters.Add("@postal", SqlDbType.Char).Value = objEmployee.Postal
        cmd.Parameters.Add("@email", SqlDbType.Char).Value = objEmployee.Email
        cmd.Parameters.Add("@cell", SqlDbType.Char).Value = objEmployee.Cell
        cmd.Parameters.Add("@question", SqlDbType.Char).Value = objEmployee.Question
        cmd.Parameters.Add("@answer", SqlDbType.Char).Value = objEmployee.Answer
        'cmd.Parameters.Add("@username", SqlDbType.Char).Value = objEmployee.Username
        'cmd.Parameters.Add("@password", SqlDbType.Char).Value = objEmployee.Passsword
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
End Class
