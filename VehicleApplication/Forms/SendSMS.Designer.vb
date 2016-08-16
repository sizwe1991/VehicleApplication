<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendSMS
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.rdbIndividual = New System.Windows.Forms.RadioButton()
        Me.rdbBooking = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbQuotation = New System.Windows.Forms.RadioButton()
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
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnSendSMS)
        Me.Panel1.Controls.Add(Me.txtMsg)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Controls.Add(Me.lblValue)
        Me.Panel1.Controls.Add(Me.rdbIndividual)
        Me.Panel1.Controls.Add(Me.rdbBooking)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.rdbQuotation)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 390)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(11, 351)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 27)
        Me.btnClose.TabIndex = 79
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(138, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 27)
        Me.btnClear.TabIndex = 78
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSendSMS
        '
        Me.btnSendSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendSMS.Location = New System.Drawing.Point(253, 351)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(113, 27)
        Me.btnSendSMS.TabIndex = 77
        Me.btnSendSMS.Text = "Send SMS"
        Me.btnSendSMS.UseVisualStyleBackColor = True
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(9, 221)
        Me.txtMsg.MaxLength = 120
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(357, 110)
        Me.txtMsg.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Message"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(153, 131)
        Me.txtNumber.MaxLength = 10
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(213, 26)
        Me.txtNumber.TabIndex = 43
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(6, 134)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(48, 18)
        Me.lblValue.TabIndex = 42
        Me.lblValue.Text = "Label3"
        '
        'rdbIndividual
        '
        Me.rdbIndividual.AutoSize = True
        Me.rdbIndividual.Location = New System.Drawing.Point(281, 77)
        Me.rdbIndividual.Name = "rdbIndividual"
        Me.rdbIndividual.Size = New System.Drawing.Size(85, 22)
        Me.rdbIndividual.TabIndex = 41
        Me.rdbIndividual.TabStop = True
        Me.rdbIndividual.Text = "Individual"
        Me.rdbIndividual.UseVisualStyleBackColor = True
        '
        'rdbBooking
        '
        Me.rdbBooking.AutoSize = True
        Me.rdbBooking.Location = New System.Drawing.Point(182, 77)
        Me.rdbBooking.Name = "rdbBooking"
        Me.rdbBooking.Size = New System.Drawing.Size(98, 22)
        Me.rdbBooking.TabIndex = 40
        Me.rdbBooking.TabStop = True
        Me.rdbBooking.Text = "Booking No"
        Me.rdbBooking.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Send To"
        '
        'rdbQuotation
        '
        Me.rdbQuotation.AutoSize = True
        Me.rdbQuotation.Location = New System.Drawing.Point(67, 77)
        Me.rdbQuotation.Name = "rdbQuotation"
        Me.rdbQuotation.Size = New System.Drawing.Size(109, 22)
        Me.rdbQuotation.TabIndex = 38
        Me.rdbQuotation.TabStop = True
        Me.rdbQuotation.Text = "Quotation No"
        Me.rdbQuotation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 29)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Send SMS Notification"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VehicleApplication.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'SendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 390)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SendSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SendSMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMsg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents rdbIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBooking As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdbQuotation As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSendSMS As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
