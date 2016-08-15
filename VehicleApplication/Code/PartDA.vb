Imports System.Data.SqlClient


Public Class PartDA

    Sub savePart(ByVal partPD As PartPD)
        Dim sql As String = "INSERT INTO tblPart " & _
                    "     (Code, Description, Qty, CostPrice, SupplierID, Vehicle, Model, Year, SellPrice, EngineNo, Shelf)" & _
"  VALUES        ('" & partPD.Code & "', '" & partPD.Description & "', " & partPD.Qty & ", " & partPD.CostPrice & ", " & partPD.SupplierID & ", '" & partPD.Vehicle & "','" & partPD.Model & "'," & partPD.Year & ", " & partPD.SellingPrice & ", '" & partPD.EngineNo & "', '" & partPD.Shelf & "')"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub


    Sub UpdatePart(ByVal partPD As PartPD)
        Dim sql As String = "UPDATE tblPart SET Description='" & partPD.Description & "', Qty=" & partPD.Qty & ", Price=" & partPD.CostPrice & ", SupplierID=" & partPD.SupplierID & ", Shelf='" & partPD.Shelf & "' WHERE Code='" & partPD.Code & "'"

        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub


    Function checkPart(ByVal code As String) As Boolean
        Dim cmd As New SqlCommand("select * from tblPart where Code=@code", objCon)
        cmd.Parameters.Add("@code", SqlDbType.Char).Value = code
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


    Function getPartInfo(ByVal code As String) As PartPD
        Dim cmd As New SqlCommand("select * from tblPart where Code=@code", objCon)
        cmd.Parameters.Add("@code", SqlDbType.Char).Value = code
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        Dim value As PartPD = Nothing
        If reader.Read Then
            value = New PartPD(reader(0), reader(1), reader(3), reader(2), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9), reader(10))
        End If
        reader.Close()
        cmd.Dispose()
        objCon.Close()
        Return value
    End Function


End Class
