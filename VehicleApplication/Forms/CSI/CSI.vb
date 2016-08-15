Imports System.Data.SqlClient
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Web

Public Class CSI

    Private Sub loadCSI()
        Dim cmd As New SqlCommand("select csino as 'CSI NO', uploaddate as 'date', name as 'CSI NAME', CSINumber as 'Certificate NO', Startdate as 'Start Date', EndDate as 'End Date' from tblcsi", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub CSI_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        loadCSI()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnnew.Click
        Dim frm As New NewCSI
        frm.ShowDialog()
    End Sub

    Private Sub btnrelaod_Click(sender As System.Object, e As System.EventArgs) Handles btnrelaod.Click
        loadCSI()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim cmd As New SqlCommand("select csino as 'CSI NO', uploaddate as 'date', name as 'CSI NAME', CSINumber as 'Certificate NO', Startdate as 'Start Date', EndDate as 'End Date' from tblcsi where name like '%" & TextBox1.Text & "%' or csinumber like '%" & TextBox1.Text & "%' or docname like '%" & TextBox1.Text & "%'", objCon)
        objCon.Close()
        objCon.Open()
        Dim data As New DataTable
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(data)
        DataGridView1.DataSource = data
        objCon.Close()
        cmd.Dispose()
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    '    Dim id As Integer = Integer.Parse(TryCast(sender, LinkButton).CommandArgument)
    '    Dim embed As String = "<object data=""{0}{1}"" type=""application/pdf"" width=""500px"" height=""600px"">"
    '    embed += "If you are unable to view file, you can download from <a href = ""{0}{1}&download=1"">here</a>"
    '    embed += " or download <a target = ""_blank"" href = ""http://get.adobe.com/reader/"">Adobe PDF Reader</a> to view the file."
    '    embed += "</object>"
    '    ltEmbed.Text = String.Format(embed, ResolveUrl("~/FileVB.ashx?Id="), id)
    'End Sub

    'Private Function ResolveUrl(p1 As String) As Object
    '    Throw New NotImplementedException
    'End Function





End Class



