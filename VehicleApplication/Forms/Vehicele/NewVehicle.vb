Imports System.Data.Sqlclient

Public Class NewVehicle

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()

        lblColor.BackColor = ColorDialog1.Color
    End Sub


    Dim objVehicleDA As New VehicleDA

    Private Sub btnSaveVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveVehicle.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please Enter Vehicle Name", 48)
            txtName.Focus()
        ElseIf objVehicleDA.searchRegNo(txtregistrationNo.Text) Then
            MsgBox("Vehicle Registration Number exists in the database", 48)
            txtregistrationNo.Focus()
        ElseIf String.IsNullOrEmpty(txtModel.Text) Then
            MsgBox("Please Vehicle Model No", 48)
            txtModel.Focus()
        ElseIf String.IsNullOrEmpty(txtCompany.Text) Then
            MsgBox("Please Enter Company Name", 48)
            txtCompany.Focus()
        ElseIf ColorDialog1.Color = Nothing Then
            MsgBox("Please Select Vehicle Color", 48)
        Else
            objVehicleDA.saveVehicle(New VehiclePD(txtregistrationNo.Text, txtName.Text, txtModel.Text, txtCompany.Text, ColorDialog1.Color.Name, lblCustNo.Text))


            MsgBox("New Customer Vehicle Successfully Saved into the database", 64)

            clear()
        End If
    End Sub

    Private Sub clear()
        lblColor.BackColor = Nothing
        lblCustNo.Text = ""
        txtregistrationNo.Clear()
        txtModel.Clear()
        txtCompany.Clear()
        txtName.Clear()
        txtregistrationNo.Focus()
        lblCompanyName.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub populateCustomerVehicles()

        Dim cmd As New SqlCommand("select  CustomerNo, CompanyName, TelNo, EmailAddress from tblCustomer", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        cmd.Dispose()
        objCon.Close()

    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New sqlCommand("select  CustomerNo, CompanyName, TelNo, EmailAddress from tblCustomer where CompanyName like '%" & TextBox1.Text & "%' or EmailAddress like '%" & TextBox1.Text & "%'", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New sqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        DataGridView1.Refresh()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lblCustNo.Text = DataGridView1.CurrentRow.Cells(1).Value
        lblCompanyName.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub NewVehicle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        populateCustomerVehicles()
    End Sub

 


    Private Sub btnCustomerManagement_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomerManagement.Click
        Dim frm As New SearchCustomer : frm.ShowDialog()
    End Sub
End Class