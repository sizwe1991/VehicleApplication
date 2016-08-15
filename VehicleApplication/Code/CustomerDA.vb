Imports System.Data.SqlClient

Public Class CustomerDA
    Public Sub saveCustomer(ByVal objCustomer As CustomerPD)
        Dim cmd As New SqlCommand("insert into tblCustomer(CompanyName,PhysicalAddress,PostalAddress,EmailAddress,TelNo,FaxNo,Balance, MobileNo) values(@name,@physical,@postal,@email,@tel,@fax,@Balance, @mobile)", objCon)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = objCustomer.Name
        cmd.Parameters.Add("@physical", SqlDbType.VarChar).Value = objCustomer.Physical
        cmd.Parameters.Add("@postal", SqlDbType.VarChar).Value = objCustomer.Postal
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = objCustomer.Email
        cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = objCustomer.Tel
        cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = objCustomer.Fax
        cmd.Parameters.Add("@Balance", SqlDbType.Decimal).Value = 0.0
        cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = objCustomer.Mobile
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Public Function searchEmail(ByVal email As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblCustomer where EmailAddress=@email", objCon)
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


    Public Function searchTel(ByVal telNo As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblCustomer where telno=@tel", objCon)
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
        Dim cmd As New sqlCommand("select * from tblCustomer where faxno=@fax", objCon)
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

    Public Function searchMobile(ByVal mobileNo As String) As Boolean
        Dim cmd As New SqlCommand("select * from tblCustomer where MobileNo=@mobileNo", objCon)
        cmd.Parameters.Add("@mobileNo", SqlDbType.Char).Value = mobileNo
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim value As Boolean = False
        If reader.Read Then
            value = True
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


    Public Function getCustomerInfo(ByVal customerNo As Integer) As CustomerPD
        Dim cmd As New sqlCommand("select * from tblCustomer where CustomerNo=@supplierNo", objCon)
        cmd.Parameters.Add("@supplierNo", SqlDbType.int).Value = customerNo
        objCon.Close()
        objCon.Open()
        Dim reader As sqlDataReader = cmd.ExecuteReader
        Dim value As CustomerPD = Nothing
        If reader.Read Then
            value = New CustomerPD(reader("companyname"), reader("physicalAddress"), reader("postalAddress"), reader("EmailAddress"), reader("TelNo"), reader("FaxNo"), reader("MobileNo"))
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


    Public Sub UpdateCustomer(ByVal CustomerNo As Integer, _
                              ByVal objCustomer As CustomerPD)
        Dim cmd As New SqlCommand("update tblCustomer  set MobileNo=@mobile, CompanyName=@name,PhysicalAddress=@physical,PostalAddress=@postal,EmailAddress=@email,TelNo=@tel,FaxNo=@fax where CustomerNo=@CustomerNo", objCon)

        cmd.Parameters.Add("@CustomerNo", SqlDbType.int).Value = CustomerNo

        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = objCustomer.Name
        cmd.Parameters.Add("@physical", SqlDbType.VarChar).Value = objCustomer.Physical
        cmd.Parameters.Add("@postal", SqlDbType.VarChar).Value = objCustomer.Postal
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = objCustomer.Email
        cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = objCustomer.Tel
        cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = objCustomer.Fax
        cmd.Parameters.Add("@mobile", SqlDbType.VarChar).Value = objCustomer.Mobile
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
End Class
