Imports System.Data.SqlClient

Public Class Parts

    Private Sub loadParts()
        Dim sql As String = "SELECT        tblPart.Code, tblPart.Description, tblPart.Qty, tblPart.Vehicle, tblPart.Model, tblPart.Year, tblPart.SellPrice as Price, tblSupplier.Name as Supplier, tblPart.EngineNo, tblpart.Shelf" & _
" FROM            (tblPart INNER JOIN " & _
           "      tblSupplier ON tblPart.SupplierID = tblSupplier.SupplierID)"
        Dim cmd As New SqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub populateSuppliers()
        cmbSupplier.Items.Clear()
        Dim cmd As New SqlCommand("select Name from  tblSupplier", objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        While reader.Read
            cmbSupplier.Items.Add(reader(0))
        End While
        reader.Close()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub Parts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        populateSuppliers()

        loadParts()

        btnSave.Text = "Save Part"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As String = "SELECT        tblPart.Code, tblPart.Description, tblPart.Qty, tblPart.Vehicle, tblPart.Model, tblPart.Year, tblPart.SellPrice as Price, tblSupplier.Name as Supplier, tblpart.EngineNo,tblpart.Shelf " & _
" FROM            (tblPart INNER JOIN " & _
                "      tblSupplier ON tblPart.SupplierID = tblSupplier.SupplierID) where  tblPart.Description like '%" & TextBox1.Text & "%' or tblSupplier.Name like '%" & TextBox1.Text & "%' or tblPart.Code like '%" & TextBox1.Text & "%' or tblPart.EngineNo like '%" & TextBox1.Text & "%' or tblpart.Shelf like '%" & TextBox1.Text & "%'"
        Dim cmd As New sqlCommand(sql, objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New sqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub btnAddQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQty.Click

        If String.IsNullOrEmpty(DataGridView1.CurrentRow.Cells(1).Value) Then
            MsgBox("Please Select the Part to be Updated", 48)
            ' End If
        ElseIf MessageBox.Show("Would you like to add Qty for Selected Part", "Add Part Qty", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Dim strNum As String = ""
            Dim number As Integer = 0

            strNum = InputBox("Please Enter Qty", "Part Qty")

            Dim isconverted As Boolean = Integer.TryParse(strNum, number)


            If isconverted = False Then
                MsgBox("Please Enter int Qty", 48)
            ElseIf number <= 0 Then
                MsgBox("Qty must be greater than 0", 48)
            Else
                saveTrackPart(DataGridView1.CurrentRow.Cells(0).Value, number)
                Dim cmd As New SqlCommand("update tblPart set Qty=Qty+" & number & " where Code='" & DataGridView1.CurrentRow.Cells(0).Value & "'", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
                TextBox1.Clear()
                Parts_Load(sender, e)

                MsgBox("Quantity Added Successfully", 64)
            End If
        End If

    End Sub

    Sub clear()
        txtCode.Clear()
        txtdesc.Clear()
        txtPrice.Clear()
        NumericUpDown1.Value = 1
        cmbSupplier.Text = ""
        txtCode.Focus()
        txtEngineNumber.Clear()
        cmbVehicle.SelectedIndex = 0
        cmbYear.SelectedIndex = 0
        cmbModel.SelectedIndex = 0
        txtCode.Focus()
        txtSelf.Clear()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            clear()
            pnlNewPart.Hide()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtCode.Text) Then
            MsgBox("Please Enter Part Code", 48)
            txtCode.Focus()
            txtCode.Clear()
        ElseIf partDA.checkPart(txtCode.Text) Then
            MsgBox("Part Code exists already in the database", 48)
            txtCode.Focus()
            txtCode.Clear()
        ElseIf String.IsNullOrEmpty(txtdesc.Text) Then
            MsgBox("Please enter part Description", 48)
            txtdesc.Focus()
            txtdesc.Clear()
        ElseIf txtdesc.Text.Length < 3 Then
            MsgBox("Part Description is too short it must atleast be 3 characters", 48)
            txtdesc.Focus()
            txtdesc.Clear()
        ElseIf String.IsNullOrEmpty(txtPrice.Text) Then
            MsgBox("Please Enter Part Price", 48)
            txtPrice.Focus()
        ElseIf String.IsNullOrEmpty(cmbSupplier.Text) Then
            MsgBox("Please Select Supplier", 48)
        ElseIf cmbVehicle.SelectedIndex = 0 Then
            MsgBox("Please Select Vehicle Name", 48)
        ElseIf cmbModel.SelectedIndex = 0 Then
            MsgBox("Please Select Model Number", 48)
        ElseIf cmbYear.SelectedIndex = 0 Then
            MsgBox("Please Select Year of the Vehicle Name and Model", 48)
        ElseIf String.IsNullOrEmpty(txtEngineNumber.Text) Then
            MsgBox("Please Enter Engine number", 48)
            txtEngineNumber.Focus()
        ElseIf New SupplierDA().getSupplierNo(cmbSupplier.Text) = 0 Then
            MsgBox("Oops the Selected Supplier Name is invalid", 48)
            cmbSupplier.Focus()
        ElseIf String.IsNullOrEmpty(txtSelf.Text) Then
            MsgBox("Please Enter Shelf Description", 48)
            txtSelf.Focus()
        Else
            partDA.savePart(New PartPD(txtCode.Text, txtdesc.Text, txtPrice.Text, NumericUpDown1.Value, New SupplierDA().getSupplierNo(cmbSupplier.Text), cmbVehicle.SelectedItem, cmbModel.SelectedItem, cmbYear.SelectedItem, txtSellingPrice.Text, txtEngineNumber.Text, txtSelf.Text))
            saveTrackPart(txtCode.Text, NumericUpDown1.Value)
            clear()

            loadParts()



            MsgBox("Part was Successfully been saved into the database", 64)



        End If
    End Sub

    Private partDA As New PartDA

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        If txtCode.Text.Length > 0 Then
            If partDA.checkPart(txtCode.Text) Then
                MsgBox("Part exists already in the Database", 48)
                txtCode.Clear()
                txtCode.Focus()
            End If
        End If
    End Sub

    Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
        If txtdesc.Text.Length > 0 Then
            If ValidAlphabet(txtdesc.Text) = False Then
                MsgBox("Description must  be alphebts only", 48)
                txtdesc.Clear()
                txtdesc.Focus()
            End If
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.Leave
        txtSellingPrice.Clear()

        If String.IsNullOrEmpty(txtPrice.Text) = False Then
            If IsNumeric(txtPrice.Text) = False Then
                MsgBox("Price must be int", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            ElseIf CDec(txtPrice.Text) <= 0 Then
                MsgBox("Price must be above 0", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            Else
                txtSellingPrice.Text = CDec(txtPrice.Text + (txtPrice.Text * (nudMarkUp.Value / 100)))
            End If
        End If
    End Sub

    'Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click

    '    Dim cmd As New sqlCommand("select Supplierid,name,emailaddress,telno from tblSupplier", objCon)
    '    objCon.Close()
    '    objCon.Open()
    '    Dim data As New DataTable
    '    Dim adp As New sqlDataAdapter(cmd)
    '    adp.Fill(data)
    '    DataGridView2.DataSource = data
    '    DataGridView2.Refresh()
    '    cmd.Dispose()
    '    objCon.Close()


    '    pnlSupplier.Show()


    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    pnlSupplier.Hide()
    'End Sub

    'Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim cmd As New SqlCommand("select Supplierid,name,emailaddress,telno,faxno from tblSupplier where name like '%" & TextBox2.Text & "%' or emailaddress like '%" & TextBox2.Text & "%'", objCon)
    '    objCon.Close()
    '    objCon.Open()
    '    Dim data As New DataTable
    '    Dim adp As New SqlDataAdapter(cmd)
    '    adp.Fill(data)
    '    DataGridView2.DataSource = data
    '    DataGridView2.Refresh()
    '    cmd.Dispose()
    '    objCon.Close()
    'End Sub

    'Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    lblSupplier.Text = DataGridView2.CurrentRow.Cells(1).Value
    '    pnlSupplier.Hide()
    'End Sub


    Sub loadVehicle()
        Dim cmd As New SqlCommand("select * from tblVehicleNames", objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        cmbVehicle.Items.Clear()
        cmbVehicle.Items.Add("Please Select")
        cmbVehicle.SelectedIndex = 0
        While reader.Read
            cmbVehicle.Items.Add(reader(0))
        End While
        reader.Close()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        cmbYear.Items.Clear()
        cmbYear.Items.Add("Please Select")
        cmbYear.SelectedIndex = 0

        For i As Integer = 1995 To Now.Year
            cmbYear.Items.Add(i)
        Next i

        loadVehicle()
        cmbModel.Items.Clear()
        cmbModel.Items.Add("Please Select")
        cmbModel.SelectedIndex = 0
        pnlNewPart.Show()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(DataGridView1.CurrentRow.Cells(1).Value) Then
            MsgBox("Please Select Part to update", 48)
        ElseIf MessageBox.Show("Would you like to update selected part", "Update Part", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            '   Hide()
            partCode = DataGridView1.CurrentRow.Cells(0).Value
            '  Me.hji()
            Dim frm As New UpdatePart
            frm.ShowDialog()

        End If
    End Sub

    'Private Sub btnNewSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Main.NewSupplierToolStripMenuItem.PerformClick()
    'End Sub

    Private Sub cmbVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbVehicle.SelectedIndexChanged

        If cmbVehicle.SelectedIndex = 0 Then
            cmbModel.Items.Clear()
            cmbModel.Items.Add("Please Select")
            cmbModel.SelectedIndex = 0
        Else
            cmbModel.Items.Clear()
            cmbModel.Items.Add("Please Select")
            cmbModel.SelectedIndex = 0

            Dim cmd As New SqlCommand("select * from tblLinkedVehicle where name='" & cmbVehicle.SelectedItem & "'", objCon)
            objCon.Close()
            objCon.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                cmbModel.Items.Add(reader(1))
            End While
            reader.Close()
            cmd.Dispose()
            objCon.Close()
        End If
    End Sub

    Private Sub btnReloadVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnReloadVehicle.Click
        loadVehicle()
        cmbModel.Items.Clear()
        cmbModel.Items.Add("Please Select")
        cmbModel.SelectedIndex = 0
    End Sub

    Private Sub btnVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnVehicle.Click
        Dim frm As New AddVehicleModel
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub nudMarkUp_ValueChanged(sender As System.Object, e As System.EventArgs) Handles nudMarkUp.ValueChanged
        txtSellingPrice.Clear()

        If String.IsNullOrEmpty(txtPrice.Text) = False Then
            If IsNumeric(txtPrice.Text) = False Then
                MsgBox("Price must be int", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            ElseIf CDec(txtPrice.Text) <= 0 Then
                MsgBox("Price must be above 0", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            Else
                txtSellingPrice.Text = CDec(txtPrice.Text + (txtPrice.Text * (nudMarkUp.Value / 100))).ToString("N2")
            End If
        End If
    End Sub

    Private Sub btnReload_Click(sender As System.Object, e As System.EventArgs) Handles btnReload.Click
        loadParts()
    End Sub

    Private Sub btnNewSupplier_Click_1(sender As System.Object, e As System.EventArgs) Handles btnNewSupplier.Click
        Dim frm As New SearchSupplier
        frm.ShowDialog()
    End Sub

    Private Sub txtSelf_Leave(sender As Object, e As System.EventArgs) Handles txtSelf.Leave
        If txtSelf.Text.Length > 0 Then
            If ValidAlphabet(txtSelf.Text) = False Then
                MsgBox("Shelf Description must  be alphebts only", 48)
                txtSelf.Clear()
                txtSelf.Focus()
            End If
        End If
    End Sub


End Class