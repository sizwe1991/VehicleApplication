Imports System.Data.SqlClient

Public Class Main


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If isClose() Then
            Application.Exit()
        End If
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        If isClose() Then
            Application.Restart()
        End If
    End Sub

 

    Private Sub UpdateSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New SearchSupplier : frm.ShowDialog()
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frma As New NewCustomer : frma.ShowDialog()
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCustomerToolStripMenuItem.Click
        Dim frm As New SearchCustomer : frm.ShowDialog()
    End Sub

    Private Sub NewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New NewEmployee : frm.ShowDialog()
    End Sub

    Private Sub NewVehicleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewVehicleToolStripMenuItem.Click
        Dim frm As New NewVehicle : frm.ShowDialog()
    End Sub

    Private Sub UpdateEmployeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New SearchEmployee : frm.ShowDialog()
    End Sub



    Private Sub btnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New BookVehicleIn : frm.ShowDialog()
    End Sub

    'Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmPayment : frm.ShowDialog()
    'End Sub

    'Private Sub btnRecordParts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New frmRecordParts : frm.ShowDialog()
    'End Sub

    'Private Sub btnCollectVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frm As New CollectVehicle : frm.ShowDialog()
    'End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Me.Visible = False
        Dim frm As New LoginForm1
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub UpdateEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangePassword.ShowDialog()
    End Sub

    Public Sub printReportAllParts()

        Dim sql As String = "SELECT        * FROM            PartsView"
        Dim cmd As New SqlDataAdapter
        Dim ds As New DataTable
        Dim report As New AllPartsCrystalReport
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

  

    Private Sub TopUsedPartsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New TopUsedPart
        frm.ShowDialog()
    End Sub

    Private Sub PurchasedPartsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New PurchasedParts
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Quotation
        frm.ShowDialog()
    End Sub

    Private Sub Main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub NewCSIToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewCSIToolStripMenuItem.Click
        Dim frm As New CSI
        frm.ShowDialog()
    End Sub

    Private Sub PartsManagementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PartsManagementToolStripMenuItem.Click
        Dim frm As New Parts : frm.ShowDialog()
    End Sub

    Private Sub EmployeeManagementToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeManagementToolStripMenuItem.Click
        Dim frm As New SearchEmployee
        frm.ShowDialog()
    End Sub

    Private Sub QuotationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuotationToolStripMenuItem.Click
        Dim frm As New Quotation
        frm.ShowDialog()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        Dim frm As New BookVehicleIn : frm.ShowDialog()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim frm As New Invoice : frm.ShowDialog()
    End Sub


    Private Sub SendSMSNotificationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SendSMSNotificationToolStripMenuItem.Click
        Dim frm As New SendSMS : frm.ShowDialog()
    End Sub

    Private Sub ReprintMenuToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReprintMenuToolStripMenuItem.Click
        Dim frm As New Reprint : frm.ShowDialog()
    End Sub

    Private Sub VehicleTowingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VehicleTowingToolStripMenuItem.Click
        Dim frm As New Towing
        frm.ShowDialog()
    End Sub

    Private Sub AllPartsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AllPartsToolStripMenuItem1.Click
        printReportAllParts()
    End Sub

    Private Sub MostUsedPartsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MostUsedPartsToolStripMenuItem.Click
        Dim frm As New TopUsedPart
        frm.ShowDialog()
    End Sub
End Class