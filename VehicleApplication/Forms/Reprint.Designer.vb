<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reprint
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chksignature = New System.Windows.Forms.CheckBox()
        Me.chkMerchant = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReprintPRev = New System.Windows.Forms.Button()
        Me.btnReprint = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.rdbtowing = New System.Windows.Forms.RadioButton()
        Me.rdbInvoice = New System.Windows.Forms.RadioButton()
        Me.rdbBooking = New System.Windows.Forms.RadioButton()
        Me.rdbQuotation = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.VehicleApplication.My.Resources.Resources.backgroud
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.chksignature)
        Me.Panel1.Controls.Add(Me.chkMerchant)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnReprintPRev)
        Me.Panel1.Controls.Add(Me.btnReprint)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.lblValue)
        Me.Panel1.Controls.Add(Me.rdbtowing)
        Me.Panel1.Controls.Add(Me.rdbInvoice)
        Me.Panel1.Controls.Add(Me.rdbBooking)
        Me.Panel1.Controls.Add(Me.rdbQuotation)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 278)
        Me.Panel1.TabIndex = 0
        '
        'chksignature
        '
        Me.chksignature.AutoSize = True
        Me.chksignature.Location = New System.Drawing.Point(169, 191)
        Me.chksignature.Name = "chksignature"
        Me.chksignature.Size = New System.Drawing.Size(103, 22)
        Me.chksignature.TabIndex = 82
        Me.chksignature.Text = "2 Signatures"
        Me.chksignature.UseVisualStyleBackColor = True
        '
        'chkMerchant
        '
        Me.chkMerchant.AutoSize = True
        Me.chkMerchant.Location = New System.Drawing.Point(13, 191)
        Me.chkMerchant.Name = "chkMerchant"
        Me.chkMerchant.Size = New System.Drawing.Size(109, 22)
        Me.chkMerchant.TabIndex = 81
        Me.chkMerchant.Text = "Merchant No"
        Me.chkMerchant.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(10, 239)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 27)
        Me.btnClose.TabIndex = 76
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReprintPRev
        '
        Me.btnReprintPRev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReprintPRev.Location = New System.Drawing.Point(108, 239)
        Me.btnReprintPRev.Name = "btnReprintPRev"
        Me.btnReprintPRev.Size = New System.Drawing.Size(195, 27)
        Me.btnReprintPRev.TabIndex = 75
        Me.btnReprintPRev.Text = "Reprint Previously Created"
        Me.btnReprintPRev.UseVisualStyleBackColor = True
        '
        'btnReprint
        '
        Me.btnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReprint.Location = New System.Drawing.Point(309, 239)
        Me.btnReprint.Name = "btnReprint"
        Me.btnReprint.Size = New System.Drawing.Size(106, 27)
        Me.btnReprint.TabIndex = 74
        Me.btnReprint.Text = "Reprint"
        Me.btnReprint.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(176, 144)
        Me.MaskedTextBox1.Mask = "999999999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(239, 26)
        Me.MaskedTextBox1.TabIndex = 49
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(10, 147)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(48, 18)
        Me.lblValue.TabIndex = 48
        Me.lblValue.Text = "Label3"
        '
        'rdbtowing
        '
        Me.rdbtowing.AutoSize = True
        Me.rdbtowing.Location = New System.Drawing.Point(344, 83)
        Me.rdbtowing.Name = "rdbtowing"
        Me.rdbtowing.Size = New System.Drawing.Size(71, 22)
        Me.rdbtowing.TabIndex = 47
        Me.rdbtowing.TabStop = True
        Me.rdbtowing.Text = "Towing"
        Me.rdbtowing.UseVisualStyleBackColor = True
        '
        'rdbInvoice
        '
        Me.rdbInvoice.AutoSize = True
        Me.rdbInvoice.Location = New System.Drawing.Point(267, 83)
        Me.rdbInvoice.Name = "rdbInvoice"
        Me.rdbInvoice.Size = New System.Drawing.Size(71, 22)
        Me.rdbInvoice.TabIndex = 46
        Me.rdbInvoice.TabStop = True
        Me.rdbInvoice.Text = "Invoice"
        Me.rdbInvoice.UseVisualStyleBackColor = True
        '
        'rdbBooking
        '
        Me.rdbBooking.AutoSize = True
        Me.rdbBooking.Location = New System.Drawing.Point(184, 81)
        Me.rdbBooking.Name = "rdbBooking"
        Me.rdbBooking.Size = New System.Drawing.Size(77, 22)
        Me.rdbBooking.TabIndex = 45
        Me.rdbBooking.TabStop = True
        Me.rdbBooking.Text = "Booking"
        Me.rdbBooking.UseVisualStyleBackColor = True
        '
        'rdbQuotation
        '
        Me.rdbQuotation.AutoSize = True
        Me.rdbQuotation.Location = New System.Drawing.Point(90, 81)
        Me.rdbQuotation.Name = "rdbQuotation"
        Me.rdbQuotation.Size = New System.Drawing.Size(88, 22)
        Me.rdbQuotation.TabIndex = 44
        Me.rdbQuotation.TabStop = True
        Me.rdbQuotation.Text = "Quotation"
        Me.rdbQuotation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Reciept for"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Reciept Reprint Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 81
        Me.PictureBox1.TabStop = False
        '
        'Reprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 278)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reprint"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents rdbtowing As System.Windows.Forms.RadioButton
    Friend WithEvents rdbInvoice As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBooking As System.Windows.Forms.RadioButton
    Friend WithEvents rdbQuotation As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnReprintPRev As System.Windows.Forms.Button
    Friend WithEvents btnReprint As System.Windows.Forms.Button
    Friend WithEvents chksignature As System.Windows.Forms.CheckBox
    Friend WithEvents chkMerchant As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
