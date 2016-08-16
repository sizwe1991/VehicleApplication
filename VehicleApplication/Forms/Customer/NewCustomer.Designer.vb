<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomer
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSaveSupplier = New System.Windows.Forms.Button()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPostal = New System.Windows.Forms.TextBox()
        Me.txtPhysical = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMobileNo = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(165, 485)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 26)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSaveSupplier
        '
        Me.btnSaveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSupplier.Location = New System.Drawing.Point(303, 485)
        Me.btnSaveSupplier.Name = "btnSaveSupplier"
        Me.btnSaveSupplier.Size = New System.Drawing.Size(135, 26)
        Me.btnSaveSupplier.TabIndex = 26
        Me.btnSaveSupplier.Text = "Save Customer"
        Me.btnSaveSupplier.UseVisualStyleBackColor = True
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(146, 391)
        Me.txtFax.Mask = "(999) 000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(292, 27)
        Me.txtFax.TabIndex = 25
        Me.txtFax.Text = "0"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(146, 337)
        Me.txtTel.Mask = "(999) 000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(292, 27)
        Me.txtTel.TabIndex = 24
        Me.txtTel.Text = "0"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(146, 284)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 27)
        Me.txtEmail.TabIndex = 23
        '
        'txtPostal
        '
        Me.txtPostal.Location = New System.Drawing.Point(146, 195)
        Me.txtPostal.Multiline = True
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.Size = New System.Drawing.Size(292, 73)
        Me.txtPostal.TabIndex = 22
        '
        'txtPhysical
        '
        Me.txtPhysical.Location = New System.Drawing.Point(146, 104)
        Me.txtPhysical.Multiline = True
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(292, 73)
        Me.txtPhysical.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(146, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(292, 27)
        Me.txtName.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Fax No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Telephone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Physical Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Postal Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Company Name"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.VehicleApplication.My.Resources.Resources.backgroud
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtMobileNo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSaveSupplier)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPostal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtPhysical)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 524)
        Me.Panel1.TabIndex = 28
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(146, 438)
        Me.txtMobileNo.Mask = "(999) 000-0000"
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(292, 27)
        Me.txtMobileNo.TabIndex = 31
        Me.txtMobileNo.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 441)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mobile No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(183, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 29)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "New Customer Window"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(8, 485)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 26)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(8, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewCustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSaveSupplier As System.Windows.Forms.Button
    Friend WithEvents txtFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPostal As System.Windows.Forms.TextBox
    Friend WithEvents txtPhysical As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMobileNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
