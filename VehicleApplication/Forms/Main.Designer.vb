<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicleTowingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartsManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendSMSNotificationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllPartsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostUsedPartsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TowingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprintMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProcessingToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.PartToolStripMenuItem, Me.VehicleToolStripMenuItem, Me.CSIToolStripMenuItem, Me.NotificationToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ReprintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 537)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1267, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.RestartToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ProcessingToolStripMenuItem
        '
        Me.ProcessingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuotationToolStripMenuItem, Me.BookingToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.VehicleTowingToolStripMenuItem})
        Me.ProcessingToolStripMenuItem.Name = "ProcessingToolStripMenuItem"
        Me.ProcessingToolStripMenuItem.Size = New System.Drawing.Size(95, 23)
        Me.ProcessingToolStripMenuItem.Text = "Processing"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'VehicleTowingToolStripMenuItem
        '
        Me.VehicleTowingToolStripMenuItem.Name = "VehicleTowingToolStripMenuItem"
        Me.VehicleTowingToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.VehicleTowingToolStripMenuItem.Text = "Vehicle Towing"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'UpdateCustomerToolStripMenuItem
        '
        Me.UpdateCustomerToolStripMenuItem.Name = "UpdateCustomerToolStripMenuItem"
        Me.UpdateCustomerToolStripMenuItem.Size = New System.Drawing.Size(240, 24)
        Me.UpdateCustomerToolStripMenuItem.Text = "Customer Management"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeManagementToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(87, 23)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'EmployeeManagementToolStripMenuItem
        '
        Me.EmployeeManagementToolStripMenuItem.Name = "EmployeeManagementToolStripMenuItem"
        Me.EmployeeManagementToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.EmployeeManagementToolStripMenuItem.Text = "Employee Management"
        '
        'PartToolStripMenuItem
        '
        Me.PartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartsManagementToolStripMenuItem})
        Me.PartToolStripMenuItem.Name = "PartToolStripMenuItem"
        Me.PartToolStripMenuItem.Size = New System.Drawing.Size(50, 23)
        Me.PartToolStripMenuItem.Text = "Part"
        '
        'PartsManagementToolStripMenuItem
        '
        Me.PartsManagementToolStripMenuItem.Name = "PartsManagementToolStripMenuItem"
        Me.PartsManagementToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.PartsManagementToolStripMenuItem.Text = "Parts Management"
        '
        'VehicleToolStripMenuItem
        '
        Me.VehicleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewVehicleToolStripMenuItem})
        Me.VehicleToolStripMenuItem.Name = "VehicleToolStripMenuItem"
        Me.VehicleToolStripMenuItem.Size = New System.Drawing.Size(69, 23)
        Me.VehicleToolStripMenuItem.Text = "Vehicle"
        '
        'NewVehicleToolStripMenuItem
        '
        Me.NewVehicleToolStripMenuItem.Name = "NewVehicleToolStripMenuItem"
        Me.NewVehicleToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.NewVehicleToolStripMenuItem.Text = "New Vehicle"
        '
        'CSIToolStripMenuItem
        '
        Me.CSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCSIToolStripMenuItem})
        Me.CSIToolStripMenuItem.Name = "CSIToolStripMenuItem"
        Me.CSIToolStripMenuItem.Size = New System.Drawing.Size(42, 23)
        Me.CSIToolStripMenuItem.Text = "CSI"
        '
        'NewCSIToolStripMenuItem
        '
        Me.NewCSIToolStripMenuItem.Name = "NewCSIToolStripMenuItem"
        Me.NewCSIToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.NewCSIToolStripMenuItem.Text = "CSI Management"
        '
        'NotificationToolStripMenuItem
        '
        Me.NotificationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendSMSNotificationToolStripMenuItem})
        Me.NotificationToolStripMenuItem.Name = "NotificationToolStripMenuItem"
        Me.NotificationToolStripMenuItem.Size = New System.Drawing.Size(101, 23)
        Me.NotificationToolStripMenuItem.Text = "Notification"
        '
        'SendSMSNotificationToolStripMenuItem
        '
        Me.SendSMSNotificationToolStripMenuItem.Name = "SendSMSNotificationToolStripMenuItem"
        Me.SendSMSNotificationToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.SendSMSNotificationToolStripMenuItem.Text = "Send SMS Notification"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllPartsToolStripMenuItem, Me.InvoiceReportToolStripMenuItem, Me.BookingReportsToolStripMenuItem, Me.TowingReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'AllPartsToolStripMenuItem
        '
        Me.AllPartsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllPartsToolStripMenuItem1, Me.MostUsedPartsToolStripMenuItem})
        Me.AllPartsToolStripMenuItem.Name = "AllPartsToolStripMenuItem"
        Me.AllPartsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.AllPartsToolStripMenuItem.Text = "Parts Reports"
        '
        'AllPartsToolStripMenuItem1
        '
        Me.AllPartsToolStripMenuItem1.Name = "AllPartsToolStripMenuItem1"
        Me.AllPartsToolStripMenuItem1.Size = New System.Drawing.Size(191, 24)
        Me.AllPartsToolStripMenuItem1.Text = "All Parts"
        '
        'MostUsedPartsToolStripMenuItem
        '
        Me.MostUsedPartsToolStripMenuItem.Name = "MostUsedPartsToolStripMenuItem"
        Me.MostUsedPartsToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.MostUsedPartsToolStripMenuItem.Text = "Most Used Parts"
        '
        'InvoiceReportToolStripMenuItem
        '
        Me.InvoiceReportToolStripMenuItem.Name = "InvoiceReportToolStripMenuItem"
        Me.InvoiceReportToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.InvoiceReportToolStripMenuItem.Text = "Invoice Report"
        '
        'BookingReportsToolStripMenuItem
        '
        Me.BookingReportsToolStripMenuItem.Name = "BookingReportsToolStripMenuItem"
        Me.BookingReportsToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.BookingReportsToolStripMenuItem.Text = "Booking Report"
        '
        'TowingReportToolStripMenuItem
        '
        Me.TowingReportToolStripMenuItem.Name = "TowingReportToolStripMenuItem"
        Me.TowingReportToolStripMenuItem.Size = New System.Drawing.Size(185, 24)
        Me.TowingReportToolStripMenuItem.Text = "Towing Report"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ReprintToolStripMenuItem
        '
        Me.ReprintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReprintMenuToolStripMenuItem})
        Me.ReprintToolStripMenuItem.Name = "ReprintToolStripMenuItem"
        Me.ReprintToolStripMenuItem.Size = New System.Drawing.Size(76, 23)
        Me.ReprintToolStripMenuItem.Text = "Re-print"
        '
        'ReprintMenuToolStripMenuItem
        '
        Me.ReprintMenuToolStripMenuItem.Name = "ReprintMenuToolStripMenuItem"
        Me.ReprintMenuToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ReprintMenuToolStripMenuItem.Text = "Reprint Menu"
        '
        'Timer1
        '
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Garamond", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(1018, 372)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 8
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(23, 456)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(262, 66)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Label1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1267, 564)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewVehicleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllPartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCSIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents PartsManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReprintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllPartsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostUsedPartsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TowingReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehicleTowingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendSMSNotificationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReprintMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
