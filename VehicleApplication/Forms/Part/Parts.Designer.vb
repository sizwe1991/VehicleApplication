<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parts
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnAddQty = New System.Windows.Forms.Button()
        Me.pnlNewPart = New System.Windows.Forms.Panel()
        Me.txtSelf = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEngineNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nudMarkUp = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbVehicle = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnVehicle = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReloadVehicle = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNewPart.SuspendLayout()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(949, 404)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Part"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(398, 27)
        Me.TextBox1.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(499, 67)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 26)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Edit Part"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Location = New System.Drawing.Point(598, 67)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(90, 26)
        Me.btnAddNew.TabIndex = 4
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnAddQty
        '
        Me.btnAddQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddQty.Location = New System.Drawing.Point(694, 67)
        Me.btnAddQty.Name = "btnAddQty"
        Me.btnAddQty.Size = New System.Drawing.Size(95, 26)
        Me.btnAddQty.TabIndex = 5
        Me.btnAddQty.Text = "Add Qty"
        Me.btnAddQty.UseVisualStyleBackColor = True
        '
        'pnlNewPart
        '
        Me.pnlNewPart.BackgroundImage = Global.VehicleApplication.My.Resources.Resources.backgroud
        Me.pnlNewPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlNewPart.Controls.Add(Me.PictureBox2)
        Me.pnlNewPart.Controls.Add(Me.txtSelf)
        Me.pnlNewPart.Controls.Add(Me.Label15)
        Me.pnlNewPart.Controls.Add(Me.txtEngineNumber)
        Me.pnlNewPart.Controls.Add(Me.Label14)
        Me.pnlNewPart.Controls.Add(Me.cmbSupplier)
        Me.pnlNewPart.Controls.Add(Me.Label13)
        Me.pnlNewPart.Controls.Add(Me.txtSellingPrice)
        Me.pnlNewPart.Controls.Add(Me.Label12)
        Me.pnlNewPart.Controls.Add(Me.nudMarkUp)
        Me.pnlNewPart.Controls.Add(Me.Label7)
        Me.pnlNewPart.Controls.Add(Me.btnClose)
        Me.pnlNewPart.Controls.Add(Me.btnClear)
        Me.pnlNewPart.Controls.Add(Me.btnSave)
        Me.pnlNewPart.Controls.Add(Me.btnNewSupplier)
        Me.pnlNewPart.Controls.Add(Me.cmbModel)
        Me.pnlNewPart.Controls.Add(Me.Label9)
        Me.pnlNewPart.Controls.Add(Me.cmbVehicle)
        Me.pnlNewPart.Controls.Add(Me.NumericUpDown1)
        Me.pnlNewPart.Controls.Add(Me.txtPrice)
        Me.pnlNewPart.Controls.Add(Me.btnVehicle)
        Me.pnlNewPart.Controls.Add(Me.Label10)
        Me.pnlNewPart.Controls.Add(Me.txtdesc)
        Me.pnlNewPart.Controls.Add(Me.cmbYear)
        Me.pnlNewPart.Controls.Add(Me.txtCode)
        Me.pnlNewPart.Controls.Add(Me.Label6)
        Me.pnlNewPart.Controls.Add(Me.Label5)
        Me.pnlNewPart.Controls.Add(Me.Label4)
        Me.pnlNewPart.Controls.Add(Me.btnReloadVehicle)
        Me.pnlNewPart.Controls.Add(Me.Label3)
        Me.pnlNewPart.Controls.Add(Me.Label2)
        Me.pnlNewPart.Controls.Add(Me.Label8)
        Me.pnlNewPart.Location = New System.Drawing.Point(180, 3)
        Me.pnlNewPart.Name = "pnlNewPart"
        Me.pnlNewPart.Size = New System.Drawing.Size(554, 500)
        Me.pnlNewPart.TabIndex = 6
        Me.pnlNewPart.Visible = False
        '
        'txtSelf
        '
        Me.txtSelf.Location = New System.Drawing.Point(139, 418)
        Me.txtSelf.Name = "txtSelf"
        Me.txtSelf.Size = New System.Drawing.Size(399, 27)
        Me.txtSelf.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 421)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 19)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Shelf Description"
        '
        'txtEngineNumber
        '
        Me.txtEngineNumber.Location = New System.Drawing.Point(139, 283)
        Me.txtEngineNumber.Name = "txtEngineNumber"
        Me.txtEngineNumber.Size = New System.Drawing.Size(120, 27)
        Me.txtEngineNumber.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 287)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 19)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Engine Number"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(139, 333)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(256, 27)
        Me.cmbSupplier.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(329, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 29)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "New Parts Window"
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.Location = New System.Drawing.Point(395, 187)
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.ReadOnly = True
        Me.txtSellingPrice.Size = New System.Drawing.Size(143, 27)
        Me.txtSellingPrice.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(320, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 19)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sell Price"
        '
        'nudMarkUp
        '
        Me.nudMarkUp.Location = New System.Drawing.Point(396, 142)
        Me.nudMarkUp.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMarkUp.Name = "nudMarkUp"
        Me.nudMarkUp.Size = New System.Drawing.Size(142, 27)
        Me.nudMarkUp.TabIndex = 23
        Me.nudMarkUp.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Mark Up"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(11, 460)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 28)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(180, 459)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 28)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(375, 459)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 28)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Part"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSupplier.Location = New System.Drawing.Point(398, 331)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(151, 28)
        Me.btnNewSupplier.TabIndex = 10
        Me.btnNewSupplier.Text = "Manage Suppliers"
        Me.btnNewSupplier.UseVisualStyleBackColor = True
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(139, 232)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(169, 27)
        Me.cmbModel.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Model"
        '
        'cmbVehicle
        '
        Me.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVehicle.FormattingEnabled = True
        Me.cmbVehicle.Location = New System.Drawing.Point(139, 182)
        Me.cmbVehicle.Name = "cmbVehicle"
        Me.cmbVehicle.Size = New System.Drawing.Size(169, 27)
        Me.cmbVehicle.TabIndex = 15
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(139, 380)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1316134912, 2328, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 27)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(139, 138)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(169, 27)
        Me.txtPrice.TabIndex = 7
        '
        'btnVehicle
        '
        Me.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehicle.Location = New System.Drawing.Point(273, 283)
        Me.btnVehicle.Name = "btnVehicle"
        Me.btnVehicle.Size = New System.Drawing.Size(106, 27)
        Me.btnVehicle.TabIndex = 20
        Me.btnVehicle.Text = "Add Vehicle"
        Me.btnVehicle.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Year"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(139, 95)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(399, 27)
        Me.txtdesc.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(360, 232)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(178, 27)
        Me.cmbYear.TabIndex = 19
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(139, 51)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(399, 27)
        Me.txtCode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cost Price"
        '
        'btnReloadVehicle
        '
        Me.btnReloadVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReloadVehicle.Location = New System.Drawing.Point(410, 283)
        Me.btnReloadVehicle.Name = "btnReloadVehicle"
        Me.btnReloadVehicle.Size = New System.Drawing.Size(128, 27)
        Me.btnReloadVehicle.TabIndex = 21
        Me.btnReloadVehicle.Text = "Reload Vehicle"
        Me.btnReloadVehicle.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Part Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Vehicle"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.VehicleApplication.My.Resources.Resources.backgroud
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnReload)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.pnlNewPart)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAddQty)
        Me.Panel1.Controls.Add(Me.btnAddNew)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(956, 504)
        Me.Panel1.TabIndex = 7
        '
        'btnReload
        '
        Me.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReload.Location = New System.Drawing.Point(795, 66)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(77, 28)
        Me.btnReload.TabIndex = 32
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(878, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 28)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(556, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(299, 29)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Parts Management Window"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(11, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 81
        Me.PictureBox2.TabStop = False
        '
        'Parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Parts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNewPart.ResumeLayout(False)
        Me.pnlNewPart.PerformLayout()
        CType(Me.nudMarkUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnAddQty As System.Windows.Forms.Button
    Friend WithEvents pnlNewPart As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnNewSupplier As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnReloadVehicle As System.Windows.Forms.Button
    Friend WithEvents btnVehicle As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nudMarkUp As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents btnReload As System.Windows.Forms.Button
    Friend WithEvents txtEngineNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSelf As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
