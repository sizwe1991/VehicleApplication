Imports System.Data.Sqlclient
Module ModuleSetting

    Public objCon As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Public\Documents\VehicleApplication-2015-11-16\VehicleApplication\VehicleApplication\Database\Naremotho.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Public supplierNo As String = ""
    ' Public CustomerNo As String = ""
    Public employeeNo As String = ""
    Public partCode As String = ""
    Public loggedEmpoyee As String = 1

    'Public Function ValidNumber(ByVal Number As String) As Boolean
    '    Dim value As Boolean = True

    '    ' Name = Name.Replace(" ", "")
    '    For i As Integer = 0 To Number.Length - 1
    '        If Not UCase(Number(i)) Like "[1234567890]" Then
    '            value = False
    '        End If
    '    Next i
    '    Return value
    'End Function


    Public Function ValidAlphabet(ByVal Name As String) As Boolean
        Dim value As Boolean = True

        Name = Name.Replace(" ", "")
        For i As Integer = 0 To Name.Length - 1
            If Not UCase(Name(i)) Like "[ABCDEFGHIJKLMNOPQRSTUVWXYZ-]" Then
                value = False
            End If
        Next i
        Return value
    End Function


    Function getQuoteNo() As Integer
        Dim cmd As New SqlCommand("select max(QuoteNo) from tblQuote", objCon)
        objCon.Close()
        objCon.Open()
        Dim number As Integer = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function

    Function getBookingNo() As Integer
        Dim cmd As New SqlCommand("select max(BookingNo) from tblBooking", objCon)
        objCon.Close()
        objCon.Open()
        Dim number As Integer = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return number
    End Function


    Public Function ValidNumber(ByVal Number As String) As Boolean
        Dim value As Boolean = True

        ' Name = Name.Replace(" ", "")
        For i As Integer = 0 To Number.Length - 1
            If Not UCase(Number(i)) Like "[1234567890]" Then
                value = False
            End If
        Next i
        Return value
    End Function

    Public Function ValidateID(ByVal IDno As String) As Boolean
        Dim value As Boolean = False
        Dim a As Integer = 0
        For i As Integer = 0 To 5
            a += CInt(IDno.Substring(i * 2, 1))
        Next

        Dim b As Integer = 0
        For i As Integer = 0 To 5
            b = b * 10 + CInt(IDno.Substring(2 * i + 1, 1))
        Next
        b *= 2
        Dim c As Integer = 0
        Do
            c += b Mod 10
            b = CInt(Int(b / 10))
        Loop Until b <= 0
        c += a
        Dim d As Integer = 0
        d = 10 - (c Mod 10)
        If (d = 10) Then d = 0
        If (d = CInt(IDno.Substring(12, 1))) And (IsDate("19" & IDno.Substring(0, 2) & "/" & IDno.Substring(2, 2) & "/" & IDno.Substring(4, 2)) Or IsDate("20" & IDno.Substring(0, 2) & "/" & IDno.Substring(2, 2) & "/" & IDno.Substring(4, 2))) Then


            value = True
        Else
            value = False

        End If

        Return value
    End Function 'Validate

    Function isClose() As Boolean
        Dim value As Boolean = False
        If MessageBox.Show("Do you really want to close", "Close Current Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            value = True
        End If
        Return value
    End Function

    Function login(ByVal username As String, _
                   ByVal password As String) As Boolean
        Dim cmd As New SqlCommand("SELECT * FROM tblEmployee WHERE Username=@user and Password=@pass", objCon)
        objCon.Close()
        objCon.Open()
        cmd.Parameters.Add("@user", SqlDbType.Char).Value = username
        cmd.Parameters.Add("@pass", SqlDbType.Char).Value = password
        Dim value As Boolean = False
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            value = True
        End If
        reader.Close()
        objCon.Close()
        cmd.Dispose()
        Return value
    End Function


    Sub saveTrackPart(ByVal partCode As String, _
                      ByVal number As Integer)
        Dim cmd As New SqlCommand("insert into TrackPart values(@code,@number,@date)", objCon)
        cmd.Parameters.AddWithValue("@code", partCode)
        cmd.Parameters.AddWithValue("@number", number)
        cmd.Parameters.AddWithValue("@date", Now.Date)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
End Module
