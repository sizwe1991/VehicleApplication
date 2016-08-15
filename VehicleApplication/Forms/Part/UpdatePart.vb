Imports System.Data.SqlClient

Public Class UpdatePart

    Sub clear()
        txtCode.Clear()
        txtdesc.Clear()
        txtPrice.Clear()
        NumericUpDown1.Value = 1
        lblSupplier.Text = ""
        txtCode.Focus()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        clear()
        Close()
        ' pnlNewPart.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtCode.Text) Then
            MsgBox("Please Enter Part Code", 48)
            txtCode.Focus()
            txtCode.Clear()
            'ElseIf partDA.checkPart(txtCode.Text) Then
            '    MsgBox("Part Code exists already in the database", 48)
            '    txtCode.Focus()
            '    txtCode.Clear()
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
        ElseIf String.IsNullOrEmpty(lblSupplier.Text) Then
            MsgBox("Please Select Supplier", 48)
        Else

            ' PartPD = New PartPD(txtCode.Text, txtdesc.Text, txtPrice.Text, NumericUpDown1.Value, lblSupplier.Text, Nothing, Nothing, Nothing, no)


            partDA.UpdatePart(PartPD)



            clear()

            '  Parts_Load(sender, e)

            MsgBox("Part was Successfully been updated into the database", 64)


            Me.Close()
        End If
    End Sub

    Private partDA As New PartDA


    Private Sub txtdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesc.TextChanged
        If txtdesc.Text.Length > 0 Then
            If ValidAlphabet(txtdesc.Text) = False Then
                MsgBox("Description must  be alphebts onlys", 48)
                txtdesc.Clear()
                txtdesc.Focus()
            End If
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        If String.IsNullOrEmpty(txtPrice.Text) = False Then
            If IsNumeric(txtPrice.Text) = False Then
                MsgBox("Price must be int", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            ElseIf CDec(txtPrice.Text) <= 0 Then
                MsgBox("Price must be above 0", 48)
                txtPrice.Clear()
                txtPrice.Focus()
            End If
        End If
    End Sub

    Private Sub btnSearchSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSupplier.Click

        Dim cmd As New sqlCommand("select Supplierid,name,emailaddress,telno from tblSupplier", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New sqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView2.DataSource = data
        DataGridView2.Refresh()
        cmd.Dispose()
        objCon.Close()


        pnlSupplier.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pnlSupplier.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Dim cmd As New sqlCommand("select Supplierid,name,emailaddress,telno,faxno from tblSupplier where name like '%" & TextBox2.Text & "%' or emailaddress like '%" & TextBox2.Text & "%'", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New sqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView2.DataSource = data
        DataGridView2.Refresh()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        lblSupplier.Text = DataGridView2.CurrentRow.Cells(1).Value
        pnlSupplier.Hide()
    End Sub

    'Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
    '    pnlNewPart.Show()
    'End Sub

    Private PartPD As PartPD


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PartPD = partDA.getPartInfo(partCode)

        txtCode.Enabled = False
        txtCode.Text = partCode

        'MsgBox(PartPD.Description)

        txtdesc.Text = PartPD.Description
        NumericUpDown1.Value = PartPD.Qty
        txtPrice.Text = PartPD.CostPrice
        lblSupplier.Text = PartPD.SupplierID
    End Sub
End Class