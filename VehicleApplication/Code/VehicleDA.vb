Imports System.Data.Sqlclient

Public Class VehicleDA
    Public Sub saveVehicle(ByVal objVehicle As VehiclePD)
        Dim cmd As New sqlCommand("insert into tblVehicle values(@RegNo,@Name,@Model,@Company,@Color,@CustomerNo)", objCon)
        cmd.Parameters.Add("@RegNo", SqlDbType.Char).Value = objVehicle.RegNo
        cmd.Parameters.Add("@name", SqlDbType.Char).Value = objVehicle.Name
        cmd.Parameters.Add("@Model", SqlDbType.Char).Value = objVehicle.Model
        cmd.Parameters.Add("@Company", SqlDbType.Char).Value = objVehicle.Company
        cmd.Parameters.Add("@Color", SqlDbType.Char).Value = objVehicle.Color
        cmd.Parameters.Add("@CustomerNo", SqlDbType.Char).Value = objVehicle.CustomerNo
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Public Function searchRegNo(ByVal regNo As String) As Boolean
        Dim cmd As New sqlCommand("select * from tblVehicle where registrationno=@regNo", objCon)
        cmd.Parameters.Add("@regNo", SqlDbType.Char).Value = regNo
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
End Class
