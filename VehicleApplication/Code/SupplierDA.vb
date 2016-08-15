Imports System.Data.SqlClient

Public Class SupplierDA

    Public Sub saveSupplier(ByVal objSupplier As SupplierPD)
        Dim cmd As New SqlCommand("insert into tblSupplier(Name,emailaddress,telno,faxno) values(@Name,@emailaddress,@telno,@faxno)", objCon)
        cmd.Parameters.Add("@Name", SqlDbType.Char).Value = objSupplier.Name
    
        cmd.Parameters.Add("@emailaddress", SqlDbType.Char).Value = objSupplier.Email
        cmd.Parameters.Add("@telno", SqlDbType.Char).Value = objSupplier.Tel
        cmd.Parameters.Add("@faxno", SqlDbType.Char).Value = objSupplier.Fax
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Public Function searchEmail(ByVal email As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblSupplier where EmailAddress=@email", objCon)
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

    Public Function getSupplierNo(ByVal name As String) As Integer
        Dim cmd As New SqlCommand("select * from tblSupplier where Name=@name", objCon)
        cmd.Parameters.Add("@name", SqlDbType.Char).Value = name
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim value As Integer = 0
        If reader.Read Then
            value = reader(0)
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function

    Public Function searchTel(ByVal telNo As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblSupplier where telno=@tel", objCon)
        cmd.Parameters.Add("@tel", SqlDbType.Char).Value = telNo
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

    Public Function searchfax(ByVal faxNo As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblSupplier where faxno=@fax", objCon)
        cmd.Parameters.Add("@fax", SqlDbType.Char).Value = faxNo
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

    Public Function getSupplierInfo(ByVal supplierNo As Integer) As SupplierPD
        Dim cmd As New sqlCommand("select * from tblSupplier where supplierID=@supplierNo", objCon)
        cmd.Parameters.Add("@supplierNo", SqlDbType.int).Value = supplierNo
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As SupplierPD = Nothing
        If reader.Read Then
            value = New SupplierPD(reader("name"), reader("EmailAddress"), reader("TelNo"), reader("FaxNo"))
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


    Public Sub UpdateSupplier(ByVal SupplierNo As Integer, _
                              ByVal objSupplier As SupplierPD)
        Dim cmd As New SqlCommand("update tblSupplier  set Name=@name,EmailAddress=@email,TelNo=@tel,FaxNo=@fax where SupplierID=@SupplierNo", objCon)

        cmd.Parameters.Add("@SupplierNo", SqlDbType.Int).Value = SupplierNo

        cmd.Parameters.Add("@name", SqlDbType.Char).Value = objSupplier.Name
        'cmd.Parameters.Add("@physical", SqlDbType.Char).Value = objSupplier.Physical
        'cmd.Parameters.Add("@postal", SqlDbType.Char).Value = objSupplier.Postal
        cmd.Parameters.Add("@email", SqlDbType.Char).Value = objSupplier.Email
        cmd.Parameters.Add("@tel", SqlDbType.Char).Value = objSupplier.Tel
        cmd.Parameters.Add("@fax", SqlDbType.Char).Value = objSupplier.Fax
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
End Class
