<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVehicleModel
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
        Me.cmbVehicle = New System.Windows.Forms.ComboBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.btnAddModel = New System.Windows.Forms.Button()
        Me.btnRemoveVehicle = New System.Windows.Forms.Button()
        Me.btnRemoveModel = New System.Windows.Forms.Button()
        Me.btnLinkVehicle = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model Number"
        '
        'cmbVehicle
        '
        Me.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVehicle.FormattingEnabled = True
        Me.cmbVehicle.Location = New System.Drawing.Point(118, 69)
        Me.cmbVehicle.Name = "cmbVehicle"
        Me.cmbVehicle.Size = New System.Drawing.Size(264, 26)
        Me.cmbVehicle.TabIndex = 2
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(118, 145)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(264, 26)
        Me.cmbModel.TabIndex = 3
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVehicle.Location = New System.Drawing.Point(394, 70)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(64, 25)
        Me.btnAddVehicle.TabIndex = 4
        Me.btnAddVehicle.Text = "+"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'btnAddModel
        '
        Me.btnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddModel.Location = New System.Drawing.Point(394, 145)
        Me.btnAddModel.Name = "btnAddModel"
        Me.btnAddModel.Size = New System.Drawing.Size(64, 26)
        Me.btnAddModel.TabIndex = 5
        Me.btnAddModel.Text = "+"
        Me.btnAddModel.UseVisualStyleBackColor = True
        '
        'btnRemoveVehicle
        '
        Me.btnRemoveVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveVehicle.Location = New System.Drawing.Point(464, 70)
        Me.btnRemoveVehicle.Name = "btnRemoveVehicle"
        Me.btnRemoveVehicle.Size = New System.Drawing.Size(49, 25)
        Me.btnRemoveVehicle.TabIndex = 6
        Me.btnRemoveVehicle.Text = "-"
        Me.btnRemoveVehicle.UseVisualStyleBackColor = True
        '
        'btnRemoveModel
        '
        Me.btnRemoveModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveModel.Location = New System.Drawing.Point(464, 145)
        Me.btnRemoveModel.Name = "btnRemoveModel"
        Me.btnRemoveModel.Size = New System.Drawing.Size(49, 26)
        Me.btnRemoveModel.TabIndex = 7
        Me.btnRemoveModel.Text = "-"
        Me.btnRemoveModel.UseVisualStyleBackColor = True
        '
        'btnLinkVehicle
        '
        Me.btnLinkVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinkVehicle.Location = New System.Drawing.Point(329, 202)
        Me.btnLinkVehicle.Name = "btnLinkVehicle"
        Me.btnLinkVehicle.Size = New System.Drawing.Size(184, 25)
        Me.btnLinkVehicle.TabIndex = 8
        Me.btnLinkVehicle.Text = "Link Vehicle"
        Me.btnLinkVehicle.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(11, 202)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 25)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnLinkVehicle)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnRemoveModel)
        Me.Panel1.Controls.Add(Me.cmbVehicle)
        Me.Panel1.Controls.Add(Me.btnRemoveVehicle)
        Me.Panel1.Controls.Add(Me.cmbModel)
        Me.Panel1.Controls.Add(Me.btnAddModel)
        Me.Panel1.Controls.Add(Me.btnAddVehicle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 264)
        Me.Panel1.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(288, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(225, 29)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Link Vehicle Window"
        '
        'AddVehicleModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 264)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddVehicleModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddVehicleModel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModel As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddVehicle As System.Windows.Forms.Button
    Friend WithEvents btnAddModel As System.Windows.Forms.Button
    Friend WithEvents btnRemoveVehicle As System.Windows.Forms.Button
    Friend WithEvents btnRemoveModel As System.Windows.Forms.Button
    Friend WithEvents btnLinkVehicle As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
