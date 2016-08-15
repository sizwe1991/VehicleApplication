Imports System.Data.SqlClient

Public Class Quotation

    Private partList As New ArrayList

    Private Sub BookVehicleIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadForm()
        Timer1.Start()
        btnSearch.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub loadForm()
        Dim sql As String = "SELECT        RegistrationNo, Name, Model, Company, Color " & _
"  FROM            tblVehicle"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        txtRegNo.Items.Clear()
        While reader.Read
            txtRegNo.Items.Add(reader(0))
        End While
        objCon.Close()
        cmd.Dispose()
    End Sub





    Private Sub clear() '
        partList.Clear()
        ListView1.Items.Clear()
        txtRegNo.Text = ""

        txtRegNo.Focus()
        txtRegNo.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        'txtTelNo.Text = ""
        txtLabour.Clear()

        NumericUpDown2.Value = 1
        txtRate.Clear()
        txtCompany.Text = ""

        ListView2.Items.Clear()

        txtDesc.Clear()
        txtKM.Clear()

        calc()
    End Sub






    Public Sub printBookingReport(ByVal bkno As Integer)

        Dim sql As String = "SELECT   * from quoteview" & _
"  WHERE        (quoteno = " & bkno & ")"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New QuoteCrystalReport
        cmd.SelectCommand = New SqlCommand
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

    Public Sub printTwoBookingReport(ByVal bkno As Integer)

        Dim sql As String = "SELECT   * from QuoteView" & _
"  WHERE        (quoteno = " & bkno & ")"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New QuoteTwoCrystalReport
        cmd.SelectCommand = New SqlCommand
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


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterPart.Click
        If String.IsNullOrEmpty(txtCode.Text) Then
            MsgBox("Please Enter Part Code", 48)
            txtCode.Focus()
        ElseIf New PartDA().checkPart(txtCode.Text) Then

            Dim partPD As PartPD = New PartDA().getPartInfo(txtCode.Text)


            For i As Integer = 0 To ListView1.Items.Count - 1
                ' MsgBox(lstView.Items(i).SubItems(7).Text)
                If ListView1.Items(i).SubItems(0).Text = txtCode.Text Then
                    MsgBox(txtCode.Text & ":" & partPD.Description & " was added already in the list " & 64)
                    Return
                End If
            Next




            Dim lv As ListViewItem = ListView1.Items.Add(partPD.Code)
            'The remaining columns are subitems
            lv.SubItems.Add(partPD.Description)
            lv.SubItems.Add(partPD.SellingPrice)
            lv.SubItems.Add(NumericUpDown1.Value)
            lv.SubItems.Add(CDec(partPD.SellingPrice * NumericUpDown1.Value).ToString("n2"))


            txtCode.Clear()
            NumericUpDown1.Value = 1

            calc()
        Else
            MsgBox("Invalid Part Code", 48)
            txtCode.Focus()
        End If
    End Sub

    Private Sub btnRemovePart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePart.Click
        If ListView1.SelectedItems.Count <= 0 Then
            MsgBox("please select the item you want to remove", MsgBoxStyle.Exclamation)
        Else
            'Dim objDev As New DeviceDA
            'objDev.DeleteDevice(lstView.SelectedItems(0).Text)
            MsgBox("Part Deleted Successfully !!", MsgBoxStyle.Information)
            ListView1.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub btnNewPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPart.Click
        Parts.ShowDialog()
    End Sub


    Private partTotal As Decimal = 0

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick




    '    Dim tot As Decimal = 0


    '    If ListView1.Items.Count <= 0 Then
    '        '    MessageBox.Show("Please Enter Product First", "Vortex Technology", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '        tot = 0
    '    Else

    '        For i As Integer = 0 To ListView1.Items.Count - 1
    '            ' MsgBox(lstView.Items(i).SubItems(7).Text)
    '            tot += ListView1.Items(i).SubItems(4).Text
    '        Next i
    '    End If


    '    partTotal = tot

    '    If String.IsNullOrEmpty(txtAmount.Text) = False Then
    '        If IsNumeric(txtAmount.Text) = False Then
    '            Return
    '            MsgBox("Amount must be int", 48)
    '            txtAmount.Clear()
    '            txtAmount.Focus()
    '        ElseIf CDec(txtAmount.Text) < 0 Then
    '            Return
    '            MsgBox("Amount must be greater than 0", 48)
    '            txtAmount.Clear()
    '            txtAmount.Focus()
    '        End If
    '    End If


    '    If txtAmount.Text <> "" Then
    '        tot += CDec(txtAmount.Text)
    '    End If

    '    lblTotal.Text = tot

    'End Sub


    Private Sub saveVehiclePart(ByVal Code As String, _
                                ByVal EmployeeNo As Integer,
                                ByVal Qty As Integer, total As Decimal)
        Dim sql As String = "INSERT INTO tblQuoteVehiclePart " & _
           "              (Code, DateInstalled, EmployeeNo, quoteNo, Qty, Installed, Total) " & _
"  VALUES        ('" & Code & "', '" & Now.Date & "', " & EmployeeNo & ", " & getQuoteNo() & ", " & Qty & ", 'No', " & total & ")"
        Dim cmd As New SqlCommand(sql, objCon)
        'cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = Code
        'cmd.Parameters.Add("@dateinstalled", SqlDbType.Date).Value = Now.Date
        'cmd.Parameters.Add("@employee", SqlDbType.VarChar).Value =
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtRegNo.Text) Then
            MsgBox("Please Enter Registration Number", 48)
            txtRegNo.Focus()
        ElseIf New VehicleDA().searchRegNo(txtRegNo.Text) = False Then
            MsgBox("Invalid Registration Number, please try again", 48)
            txtRegNo.Focus()

        ElseIf ListView2.Items.Count <= 0 Then
            MsgBox("Please Add Labour for this Quote", 48)
        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            MsgBox("Please Enter Description for this Quotation", 48)
            txtDesc.Focus()
        ElseIf String.IsNullOrEmpty(txtKM.Text) Then
            MsgBox("Please Enter Reading Kilometers for the Vehicle", 48)
            txtKM.Focus()
        Else
            Dim cmd As New SqlCommand("insert into tblQuote(Description,Date,EmployeeNo,RegistrationNo,Total, KM) values(@Description,@BookingDate,@EmployeeNo,@RegistrationNo,@total,@km)", objCon)
            objCon.Close()
            objCon.Open()




            cmd.Parameters.Add("@Description", SqlDbType.Char).Value = txtDesc.Text
            cmd.Parameters.Add("@BookingDate", SqlDbType.Date).Value = Now.Date
            'cmd.Parameters.Add("@Collected", SqlDbType.Char).Value = "No"
            cmd.Parameters.Add("@EmployeeNo", SqlDbType.Char).Value = loggedEmpoyee
            cmd.Parameters.Add("@km", SqlDbType.Char).Value = txtKM.Text
            'cmd.Parameters.Add("@RepairStatus", SqlDbType.Char).Value = "No"
            cmd.Parameters.Add("@RegistrationNo", SqlDbType.Char).Value = txtRegNo.Text
            'cmd.Parameters.Add("@Partamt", SqlDbType.Decimal).Value = partTotal
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = lblTotal.Text
            cmd.ExecuteNonQuery()
            objCon.Close()
            cmd.Dispose()

            '  updateBalance(txtCustNo.Text, CDec(lblTotal.Text))

            Dim quoteNo As Integer = getQuoteNo()

            'Dim model As String = ""
            'Dim tel As String = ""
            'Dim fax As String = ""
            'Dim company As String = ""

            'getValues(txtRegNo.Text, tel, fax, model, company)

            'For i As Integer = 0 To ListView1.Items.Count - 1
            '    Dim partPD As PartPD = New PartDA().getPartInfo(ListView1.Items(i).SubItems(0).Text)
            '    saveQuotePart(txtDesc.Text, txtRegNo.Text, fax, tel, txtKM.Text, model, company, partPD.Description, partPD.SellingPrice, ListView1.Items(i).SubItems(3).Text, quoteNo, partPD.Code)
            '    ' saveVehiclePart(ListView1.Items(i).SubItems(0).Text, loggedEmpoyee, ListView1.Items(i).SubItems(3).Text, ListView1.Items(i).SubItems(4).Text)
            'Next i




            For i As Integer = 0 To ListView2.Items.Count - 1
                saveLabor(ListView2.Items(i).SubItems(0).Text, ListView2.Items(i).SubItems(2).Text, ListView2.Items(i).SubItems(1).Text, quoteNo)
                Dim labourNo As Integer = getQuoteLaborNo()
                For Each Part As String In partList
                    Dim data(2) As String
                    data = Part.Split(",")
                    Dim partPD As PartPD = New PartDA().getPartInfo(data(0))
                    If data(1) = ListView2.Items(i).SubItems(0).Text Then
                        saveLaborPart(partPD.Code, data(2), getQuoteLaborNo)
                    End If
                Next Part
            Next i



            MsgBox("Car  Quote successfully ", 64)

            If rdbNo.Checked Then
                printBookingReport(quoteNo)
            ElseIf rdbYes.Checked Then
                printTwoBookingReport(quoteNo)
            End If



            clear()
        End If
    End Sub

    Private Sub saveLabor(desc As String, _
                          qty As Integer, _
                          price As Decimal, _
                          quoteNo As Decimal)
        Dim cmd As New SqlCommand("insert into tblQuoteLabour values(@desc,@qty,@price,@quoteNo)", objCon)
        cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc
        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = qty
        cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = price
        cmd.Parameters.Add("@quoteNo", SqlDbType.Int).Value = quoteNo
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Function getQuoteLaborNo() As Integer
        Dim cmd As New SqlCommand("select max(labourno) from tblquotelabour", objCon)
        objCon.Close()
        objCon.Open()
        Return cmd.ExecuteScalar
    End Function

    Private Sub saveLaborPart(code As String, _
                        qty As Integer, _
                        labourNo As Decimal)
        Dim cmd As New SqlCommand("insert into tblLabourPart values(@code,@qty,@labourNo)", objCon)
        cmd.Parameters.Add("@code", SqlDbType.VarChar).Value = code
        cmd.Parameters.Add("@qty", SqlDbType.Int).Value = qty
        cmd.Parameters.Add("@labourNo", SqlDbType.Int).Value = labourNo
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub
    '    Private Sub getValues(regNo As String, _
    '                          ByRef telNo As String, _
    '                          ByRef faxNo As String, _
    '                          ByRef model As String, _
    '                          ByRef company As String)
    '        Dim sql As String = "SELECT        tblCustomer.CompanyName, tblCustomer.TelNo, tblCustomer.FaxNo, tblVehicle.Model " & _
    '" FROM            tblCustomer INNER JOIN " & _
    '  "                       tblVehicle ON tblCustomer.CustomerNo = tblVehicle.CustomerNo " & _
    '" WHERE        (tblVehicle.registrationno = '" & regNo & "')"
    '        objCon.Close()
    '        objCon.Open()
    '        Dim cmd As New SqlCommand(sql, objCon)
    '        Dim reader As SqlDataReader = cmd.ExecuteReader
    '        If reader.Read Then
    '            company = reader(0)
    '            telNo = reader(1)
    '            faxNo = reader(2)
    '            model = reader(3)
    '        End If
    '        reader.Close()
    '        objCon.Close()
    '        cmd.Dispose()
    '    End Sub

    Private Sub saveQuoteLabour(desc As String, _
                                regNo As String, _
                                fax As String, _
                                telNo As String, _
                                km As Decimal, _
                                model As String, _
                                company As String, _
                                labourDesc As String, _
                                labourRate As String, _
                                labourQty As Integer, _
                                quoteNo As Integer)
        Dim cmd As New SqlCommand("insert into tblQuotationReport" & _
                                  "(Description, RegNo, Tel, Fax, KM, Model, Company, LabourDesc, LabourQty, LabourRate, QuoteNo, Type) values(@Description, @RegNo, @Tel, @Fax, @KM, @Model, @Company, @LabourDesc, @LabourQty, @LabourRate,  @QuoteNo, 'Labour')", objCon)
        cmd.Parameters.AddWithValue("@Description", desc)
        cmd.Parameters.AddWithValue("@RegNo", regNo)
        cmd.Parameters.AddWithValue("@Tel", telNo)
        cmd.Parameters.AddWithValue("@Model", model)
        cmd.Parameters.AddWithValue("@Fax", fax)

        cmd.Parameters.AddWithValue("@KM", km)
        cmd.Parameters.AddWithValue("@Company", company)
        cmd.Parameters.AddWithValue("@LabourDesc", labourDesc)
        cmd.Parameters.AddWithValue("@LabourQty", labourQty)
        cmd.Parameters.AddWithValue("@LabourRate", labourRate)

        cmd.Parameters.AddWithValue("@QuoteNo", quoteNo)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        objCon.Close()
    End Sub



    Private Sub saveQuotePart(desc As String, _
                                regNo As String, _
                                fax As String, _
                                telNo As String, _
                                km As Decimal, _
                                model As String, _
                                company As String, _
                                labourDesc As String, _
                                labourRate As String, _
                                labourQty As Integer, _
                                quoteNo As Integer, _
                                code As String)
        Dim cmd As New SqlCommand("insert into tblQuotationReport" & _
                                  "(Description, RegNo, Tel, Fax, KM, Model, Company, PartDesc, PartQty, PartPrice, QuoteNo, Type, Code) values(@Description, @RegNo, @Tel, @Fax, @KM, @Model, @Company, @LabourDesc, @LabourQty, @LabourRate,  @QuoteNo, 'Part', '" & code & "')", objCon)
        cmd.Parameters.AddWithValue("@Description", desc)
        cmd.Parameters.AddWithValue("@RegNo", regNo)
        cmd.Parameters.AddWithValue("@Tel", telNo)
        cmd.Parameters.AddWithValue("@Model", model)
        cmd.Parameters.AddWithValue("@Fax", fax)

        cmd.Parameters.AddWithValue("@KM", km)
        cmd.Parameters.AddWithValue("@Company", company)
        cmd.Parameters.AddWithValue("@LabourDesc", labourDesc)
        cmd.Parameters.AddWithValue("@LabourQty", labourQty)
        cmd.Parameters.AddWithValue("@LabourRate", labourRate)

        cmd.Parameters.AddWithValue("@QuoteNo", quoteNo)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        objCon.Close()
    End Sub



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim sql As String = "SELECT        tblPart.Code, tblPart.Description, tblPart.Qty, tblPart.SellPrice as Price, tblSupplier.Name as Supplier, tblPart.EngineNo" & _
" FROM            (tblPart INNER JOIN " & _
              "      tblSupplier ON tblPart.SupplierID = tblSupplier.SupplierID) where  tblPart.Description like '%" & TextBox2.Text & "%' or tblSupplier.Name like '%" & TextBox2.Text & "%' or tblPart.Code like '%" & TextBox2.Text & "%' or tblPart.EngineNo like '%" & TextBox2.Text & "%'"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView2.DataSource = data
        DataGridView2.Refresh()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim sql As String = "SELECT        tblPart.Code, tblPart.Description, tblPart.Qty, tblPart.SellPrice as Price, tblSupplier.Name as Supplier, tblPart.EngineNo" & _
" FROM            (tblPart INNER JOIN " & _
                "      tblSupplier ON tblPart.SupplierID = tblSupplier.SupplierID)"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView2.DataSource = data
        DataGridView2.Refresh()
        objCon.Close()
        cmd.Dispose()

        TextBox2.Clear()
        TextBox2.Focus()

        Panel1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Hide()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        txtCode.Text = DataGridView2.CurrentRow.Cells(1).Value
        btnEnterPart.PerformClick()
        Panel1.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Main.NewVehicleToolStripMenuItem.PerformClick()
    End Sub


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub txtRate_Leave(sender As Object, e As System.EventArgs) Handles txtRate.Leave
        If String.IsNullOrEmpty(txtRate.Text) = False Then
            If IsNumeric(txtRate.Text) = False Then
                '  Return
                MsgBox("Amount must be numeric", 48)

                txtRate.Focus()
            ElseIf CDec(txtRate.Text) < 0 Then
                '   Return
                MsgBox("Amount must be greater than 0", 48)

                txtRate.Focus()
            End If
        End If
    End Sub



    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        If String.IsNullOrEmpty(txtLabour.Text) Then
            MsgBox("Please Enter Labour Name", 48)
            txtLabour.Focus()
        ElseIf String.IsNullOrEmpty(txtRate.Text) Then
            MsgBox("Please Enter Amount for Labour", 48)
            txtRate.Focus()
        ElseIf ListView1.Items.Count <= 0 Then
            MsgBox("Please Enter Parts for this labour", 48)
        Else


            For i As Integer = 0 To ListView2.Items.Count - 1
                ' MsgBox(lstView.Items(i).SubItems(7).Text)
                If ListView2.Items(i).SubItems(0).Text = txtLabour.Text Then
                    MsgBox("Labour has already been added", 48)
                    Return
                End If
            Next


            For i As Integer = 0 To ListView1.Items.Count - 1
                partList.Add(ListView1.Items(i).SubItems(0).Text & "," & txtLabour.Text & "," & ListView1.Items(i).SubItems(3).Text)
            Next i

            ListView1.Items.Clear()


            Dim lv As ListViewItem = ListView2.Items.Add(txtLabour.Text)
            'The remaining columns are subitems
            ' lv.SubItems.Add(partPD.Description)
            lv.SubItems.Add(CDec(txtRate.Text).ToString("N2"))
            lv.SubItems.Add(NumericUpDown2.Value)
            lv.SubItems.Add(CDec(txtRate.Text * NumericUpDown2.Value).ToString("N2"))

            txtRate.Clear()
            txtLabour.Clear()
            txtLabour.Focus()
            NumericUpDown2.Value = 1



            calc()
        End If
    End Sub

    Sub calc()
        Dim total As Decimal = 0.0

      For Each part As String In partList
            Dim data(2) As String
            data = part.Split(",")
        Next part




        For i As Integer = 0 To ListView2.Items.Count - 1
            total += ListView2.Items(i).SubItems(3).Text
        Next

        lblTotal.Text = total.ToString("N2")
    End Sub

    Private Sub txtLabour_Leave(sender As Object, e As System.EventArgs) Handles txtLabour.Leave
        If Not String.IsNullOrEmpty(txtLabour.Text) Then
            If Not ValidAlphabet(txtLabour.Text) Then
                MsgBox("Please Enter Alphabets only for labour", 48)
                txtLabour.Focus()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        txtCompany.Text = ""
        txtFax.Text = ""
        txtEmail.Text = ""
        txtTel.Text = ""

        If String.IsNullOrEmpty(txtRegNo.Text) Then
            MsgBox("Please Enter Registration Number", 48)
            txtRegNo.Focus()
        ElseIf New VehicleDA().searchRegNo(txtRegNo.Text) = False Then
            MsgBox("Invalid Registration Number, please try again", 48)
            txtRegNo.Focus()
            'ElseIf checkVehicle(txtRegNo.Text) = True Then
            '    MsgBox("Vehicle is booked in and is still not collected", 48)
            '    txtRegNo.Focus()
        Else
            Dim sql As String = "SELECT        tblCustomer.CustomerNo, tblCustomer.CompanyName, tblCustomer.PhysicalAddress, tblCustomer.PostalAddress, tblCustomer.FaxNo, tblCustomer.TelNo, tblCustomer.EmailAddress, tblCustomer.Balance" & _
" FROM            (tblCustomer INNER JOIN " & _
  "                       tblVehicle ON tblCustomer.CustomerNo = tblVehicle.CustomerNo) " & _
"  WHERE        (tblVehicle.RegistrationNo = '" & txtRegNo.Text & "') "

            Dim cmd As New SqlCommand(sql, objCon)
            objCon.Close()
            objCon.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.Read Then
                '' lblSelectedRegistrationNumber.Text = DataGridView1.CurrentRow.Cells(1).Value
                txtCompany.Text = reader("CompanyName")
                txtFax.Text = reader("FaxNo")
                ' txtTelNo.Text = reader("TelNo")
                txtTel.Text = reader("TelNo")
                txtEmail.Text = reader("EmailAddress")
            End If
            reader.Close()
            cmd.Dispose()
            objCon.Close()
        End If
    End Sub

    Private Sub btnManageVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnManageVehicle.Click
        Dim frm As New NewVehicle
        frm.ShowDialog()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub txtKM_Leave(sender As Object, e As System.EventArgs) Handles txtKM.Leave
        If Not String.IsNullOrEmpty(txtKM.Text) Then
            If Not IsNumeric(txtKM.Text) Then
                MsgBox("Kilometers must be numeric", 48)
                txtKM.Focus()
            ElseIf CDec(txtKM.Text) < 1 Then
                MsgBox("Kilometers must be greater than 1", 48)
                txtKM.Focus()
            End If
        End If
    End Sub

    Private Sub txtDesc_Leave(sender As Object, e As System.EventArgs) Handles txtDesc.Leave
        If Not String.IsNullOrEmpty(txtDesc.Text) Then
            If Not ValidAlphabet(txtDesc.Text) Then
                MsgBox("Description of Quotation must be alphabets only", 48)
                txtDesc.Focus()
            End If
        End If
    End Sub

 


    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If ListView2.SelectedItems.Count <= 0 Then
            MsgBox("Please Select Item to Remove", vbCritical, "Remove Item")
        ElseIf MessageBox.Show("Do you really want to remove selected Item", "Remove Selected Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            For Each part As String In partList
                Dim data(2) As String
                data = part.Split(",")
                If data(1) = ListView2.Items(0).SubItems(0).Text Then
                    partList.Remove(part)
                End If
            Next part
            ListView2.SelectedItems(0).Remove()
            calc()
        End If
    End Sub


End Class