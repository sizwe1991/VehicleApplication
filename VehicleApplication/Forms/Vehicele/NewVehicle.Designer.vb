<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewVehicle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtregistrationNo = New System.Windows.Forms.TextBox()
        Me.lblCustNo = New System.Windows.Forms.Label()
        Me.btnSaveVehicle = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnCustomerManagement = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cust No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registartion No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 339)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Company"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 401)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Vehicle Color"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(438, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Choose Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Location = New System.Drawing.Point(567, 395)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(137, 27)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = " "
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(85, 449)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(238, 27)
        Me.txtCompany.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(85, 397)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(238, 27)
        Me.txtModel.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(85, 336)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(238, 27)
        Me.txtName.TabIndex = 10
        '
        'txtregistrationNo
        '
        Me.txtregistrationNo.Location = New System.Drawing.Point(466, 336)
        Me.txtregistrationNo.Name = "txtregistrationNo"
        Me.txtregistrationNo.Size = New System.Drawing.Size(238, 27)
        Me.txtregistrationNo.TabIndex = 11
        '
        'lblCustNo
        '
        Me.lblCustNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCustNo.Location = New System.Drawing.Point(85, 286)
        Me.lblCustNo.Name = "lblCustNo"
        Me.lblCustNo.Size = New System.Drawing.Size(238, 27)
        Me.lblCustNo.TabIndex = 12
        Me.lblCustNo.Text = " "
        '
        'btnSaveVehicle
        '
        Me.btnSaveVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveVehicle.Location = New System.Drawing.Point(586, 449)
        Me.btnSaveVehicle.Name = "btnSaveVehicle"
        Me.btnSaveVehicle.Size = New System.Drawing.Size(118, 27)
        Me.btnSaveVehicle.TabIndex = 13
        Me.btnSaveVehicle.Text = "Save Vehicle"
        Me.btnSaveVehicle.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(452, 449)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 27)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCustomerManagement
        '
        Me.btnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerManagement.Location = New System.Drawing.Point(501, 57)
        Me.btnCustomerManagement.Name = "btnCustomerManagement"
        Me.btnCustomerManagement.Size = New System.Drawing.Size(203, 28)
        Me.btnCustomerManagement.TabIndex = 12
        Me.btnCustomerManagement.Text = "Manage Customers"
        Me.btnCustomerManagement.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(229, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 27)
        Me.TextBox1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Search Customer Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(696, 169)
        Me.DataGridView1.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Select"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "Select"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(339, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 27)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 29)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "New Customer Vehicle Window"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.VehicleApplication.My.Resources.Resources.backgroud
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblCompanyName)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Controls.Add(Me.lblCustNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCustomerManagement)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtModel)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnSaveVehicle)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtregistrationNo)
        Me.Panel1.Controls.Add(Me.lblColor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 497)
        Me.Panel1.TabIndex = 31
        '
        'lblCompanyName
        '
        Me.lblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompanyName.Location = New System.Drawing.Point(466, 286)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(238, 27)
        Me.lblCompanyName.TabIndex = 32
        Me.lblCompanyName.Text = " "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(335, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Company Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'NewVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewVehicle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtregistrationNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCustNo As System.Windows.Forms.Label
    Friend WithEvents btnSaveVehicle As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCustomerManagement As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
