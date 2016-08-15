Imports System.Data.SqlClient
Imports System.IO

Public Class NewCSI

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()

        If Not OpenFileDialog1.FileName = Nothing Then
            lblFileName.Text = OpenFileDialog1.FileName
            ' PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If
    End Sub





    Private Sub btnCSI_Click(sender As System.Object, e As System.EventArgs) Handles btnCSI.Click



        Dim desc As String = txtDesc.Text
        Dim number As String = txtNumber.Text


        Dim startDate, endDAte As Date

        startDate = StartDateTimePicker2.Value
        endDAte = EndDateTimePicker1.Value

        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please Enter Certificate Name", 48)
        ElseIf startDate = endDAte Then
            MsgBox("Certificate Start Date can not be the same as end date", 48)
        ElseIf startDate > endDAte Then
            MsgBox("Start Date must be lesser than end of the Certificate", 48)
        ElseIf String.IsNullOrEmpty(lblFileName.Text) Then
            MsgBox("Please Browse document", 48)
        ElseIf Not File.Exists(lblFileName.Text) Then
            MsgBox("Selected File does not exists", 48)
        ElseIf Path.GetExtension(lblFileName.Text) <> ".pdf" Then
            MsgBox("Only PDF can be uploaded", 48)
        Else

            ' Read the file and convert it to Byte Array
            Dim filePath As String = lblFileName.Text
            Dim filename As String = Path.GetFileName(filePath)

            Dim fs As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim bytes As Byte() = br.ReadBytes(Convert.ToInt32(fs.Length))
            br.Close()
            fs.Close()



            'Dim strQuery As String = "insert into tblFiles(Name, ContentType, Data) values (@Name, @ContentType, @Data)"
            'Dim cmd As SqlCommand = New SqlCommand(strQuery)
            'cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename
            'cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value = "application/pdf"
            'cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes
            Dim cmd As New SqlCommand("insert into tblCSI(UploadDate, Name, CSINumber, Description, StartDate, EndDate, DocName,ContentType, Data) Values(@UploadDate, @Name, @CSINumber, @Description, @StartDate, @EndDate, @DocName,@ContentType, @Data)", objCon)
            objCon.Close()
            objCon.Open()

            cmd.Parameters.AddWithValue("@UploadDate", Now)
            '    cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@DocName", filename)
            cmd.Parameters.AddWithValue("@ContentType", "application/pdf")
            cmd.Parameters.AddWithValue("@Data", bytes)

            cmd.Parameters.AddWithValue("@CSINumber", number)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Description", desc)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDAte)


            cmd.ExecuteNonQuery()

            cmd.Dispose()
            objCon.Close()
            clear()

            MsgBox("New CSI Information Saved Successfully in the Database", 64)
        End If
    End Sub

    Sub clear()
        lblFileName.Text = ""
        txtDesc.Clear()
        txtName.Clear()
        txtNumber.Text = ""
        'PictureBox1.Image = Nothing
        txtName.Focus()
        StartDateTimePicker2.Value = Now.Date
        EndDateTimePicker1.Value = Now.Date
    End Sub

    Private Sub NewCSI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        StartDateTimePicker2.MaxDate = Now.Date
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub
End Class