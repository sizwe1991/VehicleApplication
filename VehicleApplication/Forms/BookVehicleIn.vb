Imports System.Data.Sqlclient

Public Class BookVehicleIn

    '    Private Sub BookVehicleIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        loadForm()
    '        Timer1.Start()
    '        Button1.FlatStyle = FlatStyle.Flat
    '    End Sub

    '    Private Sub loadForm()
    '        Dim sql As String = "SELECT        RegistrationNo, Name, Model, Company, Color " & _
    '"  FROM            tblVehicle"
    '        Dim cmd As New sqlCommand(sql, objCon)
    '        objCon.Close()
    '        objCon.Open()
    '        Dim data As New DataTable
    '        Dim adp As New sqlDataAdapter(cmd)
    '        adp.Fill(data)
    '        DataGridView1.DataSource = data
    '        DataGridView1.Refresh()
    '        objCon.Close()
    '        cmd.Dispose()
    '    End Sub

    '    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim sql As String = "SELECT        RegistrationNo, Name, Model, Company, Color " & _
    '"  FROM            tblVehicle where RegistrationNo like '%" & TextBox1.Text & "%' or Name like '%" & TextBox1.Text & "%' or Company like '%" & TextBox1.Text & "%'"
    '        Dim cmd As New SqlCommand(sql, objCon)
    '        objCon.Close()
    '        objCon.Open()
    '        Dim data As New DataTable
    '        Dim adp As New SqlDataAdapter(cmd)
    '        adp.Fill(data)
    '        DataGridView1.DataSource = data
    '        DataGridView1.Refresh()
    '        objCon.Close()
    '        cmd.Dispose()
    '    End Sub

    '    Private Function checkVehicle(ByVal registration As String) As Boolean
    '        Dim cmd As New sqlCommand("select * from tblBooking where registrationno=@regNo and Collected='No'", objCon)
    '        cmd.Parameters.Add("@regNo", SqlDbType.Char).Value = registration
    '        objCon.Close()
    '        objCon.Open()
    '        Dim reader As sqlDataReader = cmd.ExecuteReader
    '        Dim value As Boolean = False
    '        If reader.Read Then
    '            value = True
    '        End If
    '        reader.Close()
    '        cmd.Dispose()
    '        objCon.Close()
    '        Return value
    '    End Function


    'Private Sub clear() '
    '    ListView1.Items.Clear()
    '    txtAmount.Clear()
    '    TextBox1.Clear()
    '    lblSelectedRegistrationNumber.Text = ""
    '    txtEmail.Text = ""
    '    txtBalance.Text = ""
    '    txtCustNo.Text = ""
    '    'txtTelNo.Text = ""
    '    txtDesc.Clear()
    '    loadForm()
    '    txtCompany.Text = ""
    'End Sub

    '    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '        If checkVehicle(DataGridView1.CurrentRow.Cells(1).Value) = True Then
    '            clear()
    '            MsgBox("Vehicle is booked in and is still not collected", 48)
    '        Else
    '            Dim sql As String = "SELECT        tblCustomer.CustomerNo, tblCustomer.CompanyName, tblCustomer.PhysicalAddress, tblCustomer.PostalAddress, tblCustomer.FaxNo, tblCustomer.TelNo, tblCustomer.EmailAddress, tblCustomer.Balance" & _
    '" FROM            (tblCustomer INNER JOIN " & _
    '  "                       tblVehicle ON tblCustomer.CustomerNo = tblVehicle.CustomerNo) " & _
    '"  WHERE        (tblVehicle.RegistrationNo = '" & DataGridView1.CurrentRow.Cells(1).Value & "') "

    '            Dim cmd As New SqlCommand(sql, objCon)
    '            objCon.Close()
    '            objCon.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader
    '            If reader.Read Then
    '                lblSelectedRegistrationNumber.Text = DataGridView1.CurrentRow.Cells(1).Value
    '                txtCompany.Text = reader("CompanyName")
    '                txtCustNo.Text = reader("CustomerNo")
    '                ' txtTelNo.Text = reader("TelNo")
    '                txtBalance.Text = reader("Balance")
    '                txtEmail.Text = reader("EmailAddress")
    '            End If
    '            reader.Close()
    '            cmd.Dispose()
    '            objCon.Close()
    '        End If
    '    End Sub


    'Private Sub updateBalance(ByVal custNo As String, _
    '                         ByVal amount As Decimal)
    '    Dim cmd As New sqlCommand("update tblcustomer set balance=balance+" & amount & " where customerNo=@custNo", objCon)
    '    objCon.Close()
    '    objCon.Open()
    '    cmd.Parameters.Add("@custNo", SqlDbType.Char).Value = custNo
    '    cmd.ExecuteNonQuery()
    '    objCon.Close()
    '    cmd.Dispose()
    'End Sub




    'Private Function getBookingNo() As Integer
    '    Dim cmd As New sqlCommand("select max(bookingNo) from tblBooking", objCon)
    '    objCon.Close()
    '    objCon.Open()
    '    Dim number As Integer = cmd.ExecuteScalar
    '    objCon.Close()
    '    cmd.Dispose()
    '    Return number
    'End Function
    Public Sub printBookingReport(ByVal bkno As Integer)

        Dim sql As String = "select * from tblbooking where BookingNo=" & bkno
        Dim cmd As New sqlDataAdapter
        Dim ds As New DataTable
        Dim report As New BookingCrystalReport
        cmd.SelectCommand = New sqlCommand
        cmd.SelectCommand.CommandText = sql
        cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        cmd.Fill(ds)

        report.SetDataSource(ds)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub


    Public Sub printMotorForm()

        'Dim sql As String = "select * from tblbooking where BookingNo="
        'Dim cmd As New SqlDataAdapter
        'Dim ds As New DataTable
        Dim report As New MotorVehicleFormCrystalReport
        'cmd.SelectCommand = New SqlCommand
        'cmd.SelectCommand.CommandText = sql
        'cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        '  cmd.Fill(ds)

        '   report.SetDataSource(ds)
        report.SetParameterValue(0, txtRegNo.Text)
        report.SetParameterValue(1, txtMake.Text)
        report.SetParameterValue(2, txtModel.Text)
        report.SetParameterValue(3, txtKM.Text)
        report.SetParameterValue(4, txtInitials.Text & " " & txtSurname.Text)
        report.SetParameterValue(5, txtTelNo.Text)
        report.SetParameterValue(6, txtBusinessUnit.Text)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    Public Sub printTechnicianForm()

        'Dim sql As String = "select * from tblbooking where BookingNo="
        'Dim cmd As New SqlDataAdapter
        'Dim ds As New DataTable
        Dim report As New TechnicianFormCrystalReport
        'cmd.SelectCommand = New SqlCommand
        'cmd.SelectCommand.CommandText = sql
        'cmd.SelectCommand.Connection = objCon
        '   cmd.SelectCommand.Parameters.Add("@bkno", SqlDbType.Int).Value = bkno
        ' cmd.Fill(ds)

        '   report.SetDataSource(ds)

        report.SetParameterValue(0, txtTechnician.Text)
        report.SetParameterValue(1, txtRegNo.Text)
        report.SetParameterValue(2, txtKM.Text)
        Dim objReport As New ReportViewer
        objReport.CrystalReportViewer1.ReportSource = (report)
        objReport.ShowDialog()
        ' Me.CrystalReportViewer1.ReportSource = report
        ' report.PrintToPrinter(New System.Drawing.Printing.PrinterSettings, New System.Drawing.Printing.PageSettings, False)
    End Sub

    '    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If String.IsNullOrEmpty(txtCode.Text) Then
    '            MsgBox("Please Enter Part Code", 48)
    '            txtCode.Focus()
    '        ElseIf New PartDA().checkPart(txtCode.Text) Then

    '            Dim partPD As PartPD = New PartDA().getPartInfo(txtCode.Text)


    '            For i As Integer = 0 To ListView1.Items.Count - 1
    '                ' MsgBox(lstView.Items(i).SubItems(7).Text)
    '                If ListView1.Items(i).SubItems(0).Text = txtCode.Text Then
    '                    MsgBox(txtCode.Text & ":" & partPD.Description & " was added already in the list " & 64)
    '                    Return
    '                End If
    '            Next




    '            Dim lv As ListViewItem = ListView1.Items.Add(partPD.Code)
    '            'The remaining columns are subitems
    '            lv.SubItems.Add(partPD.Description)
    '            lv.SubItems.Add(partPD.CostPrice)
    '            lv.SubItems.Add(NumericUpDown1.Value)
    '            lv.SubItems.Add(CDec(partPD.CostPrice * NumericUpDown1.Value).ToString("n2"))


    '            txtCode.Clear()
    '            NumericUpDown1.Value = 1
    '        Else
    '            MsgBox("Invalid Part Code", 48)
    '            txtCode.Focus()
    '        End If
    '    End Sub

    '    Private Sub btnRemovePart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If ListView1.SelectedItems.Count <= 0 Then
    '            MsgBox("please select the item you want to remove", MsgBoxStyle.Exclamation)
    '        Else
    '            'Dim objDev As New DeviceDA
    '            'objDev.DeleteDevice(lstView.SelectedItems(0).Text)
    '            MsgBox("Part Deleted Successfully !!", MsgBoxStyle.Information, "Giro Application")
    '            ListView1.SelectedItems(0).Remove()
    '        End If
    '    End Sub

    '    Private Sub btnNewPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Parts.ShowDialog()
    '    End Sub


    '    Private partTotal As Decimal = 0

    '    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick




    '        Dim tot As Decimal = 0


    '        If ListView1.Items.Count <= 0 Then
    '            '    MessageBox.Show("Please Enter Product First", "Vortex Technology", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '            tot = 0
    '        Else

    '            For i As Integer = 0 To ListView1.Items.Count - 1
    '                ' MsgBox(lstView.Items(i).SubItems(7).Text)
    '                tot += ListView1.Items(i).SubItems(4).Text
    '            Next i
    '        End If


    '        partTotal = tot

    '        If String.IsNullOrEmpty(txtAmount.Text) = False Then
    '            If IsNumeric(txtAmount.Text) = False Then
    '                Return
    '                MsgBox("Amount must be int", 48)
    '                txtAmount.Clear()
    '                txtAmount.Focus()
    '            ElseIf CDec(txtAmount.Text) < 0 Then
    '                Return
    '                MsgBox("Amount must be greater than 0", 48)
    '                txtAmount.Clear()
    '                txtAmount.Focus()
    '            End If
    '        End If


    '        If txtAmount.Text <> "" Then
    '            tot += CDec(txtAmount.Text)
    '        End If

    '        lblTotal.Text = tot

    '    End Sub


    '    Private Sub saveVehiclePart(ByVal Code As String, _
    '                                ByVal EmployeeNo As Integer,
    '                                ByVal Qty As Integer)
    '        Dim sql As String = "INSERT INTO tblVehiclePart " & _
    '           "              (Code, DateInstalled, EmployeeNo, BookingNo, Qty, Installed) " & _
    '"  VALUES        ('" & Code & "', '" & Now.Date & "', " & EmployeeNo & ", " & getBookingNo() & ", " & Qty & ", 'No')"
    '        Dim cmd As New sqlCommand(sql, objCon)
    '        'cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = Code
    '        'cmd.Parameters.Add("@dateinstalled", SqlDbType.Date).Value = Now.Date
    '        'cmd.Parameters.Add("@employee", SqlDbType.VarChar).Value =
    '        objCon.Close()
    '        objCon.Open()
    '        cmd.ExecuteNonQuery()
    '        objCon.Close()
    '        cmd.Dispose()
    '    End Sub

    '    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If String.IsNullOrEmpty(lblSelectedRegistrationNumber.Text) Then
    '            MsgBox("Please Select Vehicle", 48)
    '        ElseIf New VehicleDA().searchRegNo(lblSelectedRegistrationNumber.Text) = False Then
    '            MsgBox("Vehicle Registration Number is invalid", 48)
    '        ElseIf checkVehicle(lblSelectedRegistrationNumber.Text) Then
    '            MsgBox("Vehicle is Booked in already in the work Shop", 48)
    '        ElseIf ListView1.Items.Count <= 0 Then
    '            MsgBox("Please Enter Parts in the list", 48)
    '        ElseIf String.IsNullOrEmpty(txtAmount.Text) Then
    '            MsgBox("Please Amount for this booking", 48)
    '            txtAmount.Focus()
    '        ElseIf CDec(txtAmount.Text) <= 0 Then
    '            MsgBox("Amount must be greater than 0", 48)
    '            txtAmount.Focus()
    '            txtAmount.Clear()
    '        Else
    '            Dim cmd As New SqlCommand("insert into tblBooking(Description,BookingDate,Collected,EmployeeNo,RegistrationNo,RepairStatus,LabourAmount,PartAmount,Total) values(@Description,@BookingDate,@Collected,@EmployeeNo,@RegistrationNo,@RepairStatus,@Amount,@Partamt,@total)", objCon)
    '            objCon.Close()
    '            objCon.Open()

    '            Dim desc As String = ""

    '            If String.IsNullOrEmpty(txtDesc.Text) = False Then
    '                desc = txtDesc.Text
    '            End If



    '            cmd.Parameters.Add("@Description", SqlDbType.Char).Value = desc
    '            cmd.Parameters.Add("@BookingDate", SqlDbType.Date).Value = Now.Date
    '            cmd.Parameters.Add("@Collected", SqlDbType.Char).Value = "No"
    '            cmd.Parameters.Add("@EmployeeNo", SqlDbType.Char).Value = loggedEmpoyee
    '            cmd.Parameters.Add("@RegistrationNo", SqlDbType.Char).Value = lblSelectedRegistrationNumber.Text
    '            cmd.Parameters.Add("@RepairStatus", SqlDbType.Char).Value = "No"
    '            cmd.Parameters.Add("@Amount", SqlDbType.Decimal).Value = txtAmount.Text
    '            cmd.Parameters.Add("@Partamt", SqlDbType.Decimal).Value = partTotal
    '            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = lblTotal.Text
    '            cmd.ExecuteNonQuery()
    '            objCon.Close()
    '            cmd.Dispose()

    '            updateBalance(txtCustNo.Text, CDec(lblTotal.Text))


    '            For i As Integer = 0 To ListView1.Items.Count - 1
    '                saveVehiclePart(ListView1.Items(i).SubItems(0).Text, loggedEmpoyee, ListView1.Items(i).SubItems(3).Text)
    '            Next i

    '            clear()

    '            MsgBox("Car successfully Booked in the workshop", 64)

    '            printBookingReport(getBookingNo)
    '        End If
    '    End Sub

  





    Private Function getQuoteRegistrationNo(quoteNo) As String
        Dim regno As String = ""
        Dim cmd As New SqlCommand("select RegistrationNo from tblQuote where QuoteNo=" & quoteNo, objCon)
        objCon.Close()
        objCon.Open()
        regno = cmd.ExecuteScalar
        objCon.Close()
        cmd.Dispose()
        Return regno
    End Function

 

    Sub clear()
        txtBusinessUnit.Clear()
        txtMake.Clear()
        txtTechnician.Clear()
        rdbFemale.Checked = True
        rdbMR.Checked = True
        txtInitials.Focus()
        txtCellphoneMo.Clear()
        txtDesc.Clear()
        txtEngineNo.Clear()
        txtFullName.Clear()
        txtID.Clear()
        txtInitials.Clear()
        txtKM.Clear()
        txtRegNo.Clear()
        txtSurname.Clear()
        txtModel.Clear()
        txtTelNo.Clear()
    End Sub


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub txtInitials_Leave(sender As Object, e As System.EventArgs) Handles txtInitials.Leave
        If Not String.IsNullOrEmpty(txtInitials.Text) Then
            If Not ValidAlphabet(txtInitials.Text) Then
                MsgBox("Initials must be alphabets only", 48)
                txtInitials.Focus()
            Else
                txtInitials.Text = txtInitials.Text.ToUpper
            End If
        End If
    End Sub

    Private Sub txtFullName_Leave(sender As Object, e As System.EventArgs) Handles txtFullName.Leave
        If Not String.IsNullOrEmpty(txtFullName.Text) Then
            If Not ValidAlphabet(txtFullName.Text) Then
                MsgBox("Full Names must be Alphabets Only", 48)
                txtFullName.Focus()
            Else
                txtFullName.Text = txtFullName.Text.Substring(0, 1).ToUpper & txtFullName.Text.Substring(1)
            End If
        End If
    End Sub

    Private Sub txtSurname_Leave(sender As Object, e As System.EventArgs) Handles txtSurname.Leave
        If Not String.IsNullOrEmpty(txtSurname.Text) Then
            If Not ValidAlphabet(txtSurname.Text) Then
                MsgBox("Surname must be Alphabets Only", 48)
                txtSurname.Focus()
            Else
                txtSurname.Text = txtSurname.Text.Substring(0, 1).ToUpper & txtSurname.Text.Substring(1)
            End If
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As System.EventArgs) Handles txtID.Leave
        If Not String.IsNullOrEmpty(txtID.Text) Then
            If Not ValidNumber(txtID.Text) Then
                MsgBox("ID Number must be numbers only", 48)
                txtID.Focus()
            ElseIf Not txtID.Text.Length = 13 Then
                MsgBox("Id number number must be 13 numbers")
            ElseIf Not ValidateID(txtID.Text) Then
                MsgBox("Typed ID is not a valid SA ID number", 48)
                txtID.Focus()
            Else
                Select Case txtID.Text.Substring(6, 1)
                    Case 0 To 4
                        rdbFemale.Checked = True
                    Case Else
                        rdbMale.Checked = True
                End Select
            End If
        End If
    End Sub


    Private Sub txtEngineNo_Leave(sender As Object, e As System.EventArgs) Handles txtEngineNo.Leave
        If Not String.IsNullOrEmpty(txtEngineNo.Text) Then
            If Not IsNumeric(txtEngineNo.Text) Then
                MsgBox("Engine Number is not in form of number please check", 48)
                txtEngineNo.Focus()
            End If
        End If
    End Sub

    Private Sub btnSaveSupplier_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveSupplier.Click
        Dim title As String = ""

        If rdbDr.Checked Then
            title = "Dr"
        ElseIf rdbMR.Checked Then
            title = "Mr"
        ElseIf rdbMrs.Checked Then
            title = "Mrs"
        ElseIf rdbMs.Checked Then
            title = "Ms"
        ElseIf rdbProf.Checked Then
            title = "Prof"
        End If


        If title = "" Then
            MsgBox("Please Select Title", 48)
        ElseIf String.IsNullOrEmpty(txtInitials.Text) Then
            MsgBox("Please Enter Initials", 48)
            txtInitials.Focus()
        ElseIf String.IsNullOrEmpty(txtFullName.Text) Then
            MsgBox("Please Enter Full Name", 48)
            txtFullName.Focus()
        ElseIf String.IsNullOrEmpty(txtSurname.Text) Then
            MsgBox("Please Enter Surname", 48)
            txtSurname.Focus()
        ElseIf String.IsNullOrEmpty(txtID.Text) Then
            MsgBox("Please Enter ID", 48)
            txtID.Focus()
        ElseIf String.IsNullOrEmpty(txtRegNo.Text) Then
            MsgBox("Please Enter Registration Number", 48)
            txtRegNo.Focus()
        ElseIf txtRegNo.Text.Length < 6 Then
            MsgBox("Registration Number is too short", 48)
            txtRegNo.Focus()
        ElseIf String.IsNullOrEmpty(txtModel.Text) Then
            MsgBox("Please Enter Model No of the Vehicle", 48)
            txtModel.Focus()
        ElseIf txtModel.Text.Length < 4 Then
            MsgBox("Model No is too short", 48)
            txtModel.Focus()
        ElseIf String.IsNullOrEmpty(txtKM.Text) Then
            MsgBox("Please Enter Kilometers", 48)
            txtKM.Focus()
        ElseIf Not IsNumeric(txtKM.Text) Then
            MsgBox("Please Enter numeric kilometers", 48)
            txtKM.Focus()
        ElseIf CDec(txtKM.Text) < 0 Then
            MsgBox("Kilometer must be positive number", 48)
            txtKM.Focus()
        ElseIf String.IsNullOrEmpty(txtEngineNo.Text) Then
            MsgBox("Please Enter Engine No", 48)
            txtEngineNo.Focus()
        ElseIf Not IsNumeric(txtEngineNo.Text) Then
            MsgBox("Engine No must be numbers only", 48)
            txtEngineNo.Focus()
        ElseIf txtTelNo.Text.Replace(" ", "") = "()-" Then
            MsgBox("Please enter Telephone No", 48)
            txtTelNo.Focus()
        ElseIf txtTelNo.Text.Length <> 14 Then
            MsgBox("Telephone No must be 10 digits long", 48)
            txtTelNo.Focus()
        ElseIf txtTelNo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Telephone Number must start with 0", 48)
            txtTelNo.Focus()
        ElseIf txtCellphoneMo.Text.Replace(" ", "") = "()-" Then
            MsgBox("Please enter Cellphone No", 48)
            txtCellphoneMo.Focus()
        ElseIf txtCellphoneMo.Text.Length <> 14 Then
            MsgBox("Cellphone No must be 10 digits long", 48)
            txtCellphoneMo.Focus()
        ElseIf txtCellphoneMo.Text.Substring(1, 1) <> "0" Then
            MsgBox("Cellphone Number must start with 0", 48)
            txtCellphoneMo.Focus()
        ElseIf txtCellphoneMo.Text = txtTelNo.Text Then
            MsgBox("Telephone Number can not be same as Cellphone Number", 48)
        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            MsgBox("Please Enter Description of Booking", 48)
            txtDesc.Focus()
        ElseIf String.IsNullOrEmpty(txtMake.Text) Then
            MsgBox("Please Enter Vehicle Make", 48)
            txtMake.Focus()
        ElseIf String.IsNullOrEmpty(txtTechnician.Text) Then
            MsgBox("Please Enter Techician Name", 48)
            txtTechnician.Focus()
        ElseIf String.IsNullOrEmpty(txtBusinessUnit.Text) Then
            MsgBox("Please Enter Business unit", 48)
            txtBusinessUnit.Focus()
        Else
            Dim cmd As New SqlCommand("insert into tblBooking values(@desc,@date,@surname,@initials,@title,@name,@id,@tel,@km,@regno,@model,@engineno,@gender,@cellno)", objCon)
            objCon.Close()
            objCon.Open()


            Dim gender As String = ""
            If rdbMale.Checked = True Then
                gender = "Male"
            ElseIf rdbFemale.Checked = True Then
                gender = "Female"
            End If

            cmd.Parameters.Add("@desc", SqlDbType.Char).Value = txtDesc.Text
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Now.Date
            cmd.Parameters.Add("@surname", SqlDbType.Char).Value = txtSurname.Text
            cmd.Parameters.Add("@initials", SqlDbType.Char).Value = txtInitials.Text
            cmd.Parameters.Add("@km", SqlDbType.Char).Value = txtKM.Text
            cmd.Parameters.Add("@title", SqlDbType.Char).Value = title
            cmd.Parameters.Add("@name", SqlDbType.Char).Value = txtFullName.Text
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = txtID.Text
            cmd.Parameters.Add("@tel", SqlDbType.Char).Value = txtTelNo.Text

            cmd.Parameters.Add("@regno", SqlDbType.Char).Value = txtRegNo.Text
            cmd.Parameters.Add("@model", SqlDbType.Char).Value = txtModel.Text
            cmd.Parameters.Add("@engineno", SqlDbType.Char).Value = txtEngineNo.Text
            cmd.Parameters.Add("@gender", SqlDbType.Char).Value = gender
            cmd.Parameters.Add("@cellno", SqlDbType.Char).Value = txtCellphoneMo.Text

            cmd.ExecuteNonQuery()
            objCon.Close()
            cmd.Dispose()

            Dim number As String = txtCellphoneMo.Text.Replace(" ", "")

            number = number.Replace("(", "")
            number = number.Replace(")", "")

            number = number.Replace("-", "")

            number = "+27" & number.Substring(1)

            Dim bookingNo As Integer = getBookingNo()


            Dim msg As String = "This serves to confirm that you have successfully made a booking with naremotho cc, booking no: " & bookingNo

            MyApplication.Main(number, msg)



            MsgBox("Booking successfuly", 64)


            printBookingReport(bookingNo)

            printMotorForm()
            printTechnicianForm()

            clear()
        End If
    End Sub

    Private Sub txtKM_Leave(sender As Object, e As System.EventArgs) Handles txtKM.Leave
        If Not String.IsNullOrEmpty(txtKM.Text) Then
            If Not IsNumeric(txtKM.Text) Then
                MsgBox("Please Enter kilometers", 48)
                txtKM.Focus()
            ElseIf CDec(txtKM.Text) < 0 Then
                MsgBox("Kilometers must be positive number", 48)
                txtKM.Focus()
            End If
        End If
    End Sub

   

 
    Private Sub txtTechnician_Leave(sender As Object, e As System.EventArgs) Handles txtTechnician.Leave
        If Not String.IsNullOrEmpty(txtTechnician.Text) Then
            If Not ValidAlphabet(txtTechnician.Text) Then
                MsgBox("Technician Name must be alphabets only", 48)
                txtTechnician.Focus()
            Else
                txtTechnician.Text = txtTechnician.Text.ToUpper
            End If
        End If
    End Sub

    Private Sub txtMake_Leave(sender As Object, e As System.EventArgs) Handles txtMake.Leave
        If Not String.IsNullOrEmpty(txtMake.Text) Then
            If Not ValidAlphabet(txtMake.Text) Then
                MsgBox("Vehicle Make must be alphabets only", 48)
                txtMake.Focus()
            Else
                txtMake.Text = txtMake.Text.ToUpper
            End If
        End If
    End Sub

    Private Sub txtBusinessUnit_Leave(sender As Object, e As System.EventArgs) Handles txtBusinessUnit.Leave
        If Not String.IsNullOrEmpty(txtBusinessUnit.Text) Then
            If Not ValidAlphabet(txtBusinessUnit.Text) Then
                MsgBox("Vehicle Make must be alphabets only", 48)
                txtBusinessUnit.Focus()
            Else
                txtBusinessUnit.Text = txtBusinessUnit.Text.ToUpper
            End If
        End If
    End Sub
End Class