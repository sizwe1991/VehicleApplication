Imports System.Data.SqlClient

Public Class AddVehicleModel

    Private Sub AddVehicleModel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadVehicle()
        loadModel()
    End Sub


    Sub loadVehicle()
        Dim cmd As New SqlCommand("select * from tblVehicleNames", objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        cmbVehicle.Items.Clear()
        cmbVehicle.Items.Add("Please Select")
        cmbVehicle.SelectedIndex = 0
        While reader.Read
            cmbVehicle.Items.Add(reader(0))
        End While
        reader.Close()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Sub loadModel()
        Dim cmd As New SqlCommand("select * from tblvehiclemodel", objCon)
        objCon.Close()
        objCon.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        cmbModel.Items.Clear()
        cmbModel.Items.Add("Please Select")
        cmbModel.SelectedIndex = 0
        While reader.Read
            cmbModel.Items.Add(reader(0))
        End While
        reader.Close()
        cmd.Dispose()
        objCon.Close()
    End Sub

    Private Sub btnAddVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnAddVehicle.Click
        Dim name As String = InputBox("Please Enter Vehicle", "Vehicle Name")

        If Not String.IsNullOrEmpty(name) Then
            If Not ValidAlphabet(name) Then
                MsgBox("Vehicle Name must be alphabets only", 48)
            Else
                Dim cmd As New SqlCommand("insert into tblvehiclenames values('" & name & "')", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
                loadVehicle()
                MsgBox("New Vehicle Name Successfully added", 64)
            End If
        End If

    End Sub

    Private Sub btnAddModel_Click(sender As System.Object, e As System.EventArgs) Handles btnAddModel.Click
        Dim name As String = InputBox("Please Enter Model", "Vehicle Model")

        If Not String.IsNullOrEmpty(name) Then
           
            Dim cmd As New SqlCommand("insert into tblvehiclemodel values('" & name & "')", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
            loadModel()
            MsgBox("New Vehicle Model Successfully added", 64)
            '  End If
        End If
    End Sub

    Private Sub btnRemoveVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveVehicle.Click
        If Not cmbVehicle.SelectedIndex = 0 Then
            If MessageBox.Show("Do you really wish to delete " & cmbVehicle.SelectedItem & " in the database", "Delete Vehicle Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                deleteLinkedVehicle(cmbModel.SelectedItem)
                Dim cmd As New SqlCommand("delete tblvehiclenames where Name='" & cmbVehicle.SelectedItem & "'", objCon)
                '  Dim cmd As New SqlCommand("insert into tblvehiclenames values('" & Name & "')", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
                loadVehicle()
                MsgBox(" Vehicle Name Deleted Successfully added", 64)
            End If
        End If
    End Sub

    Private Sub btnRemoveModel_Click(sender As System.Object, e As System.EventArgs) Handles btnRemoveModel.Click
        If Not cmbModel.SelectedIndex = 0 Then
            If MessageBox.Show("Do you really wish to delete " & cmbModel.SelectedItem & " in the database", "Delete Vehicle Model", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                deleteLinkedModel(cmbModel.SelectedItem)
                Dim cmd As New SqlCommand("delete tblvehiclemodel where Name='" & cmbVehicle.SelectedItem & "'", objCon)
                '  Dim cmd As New SqlCommand("insert into tblvehiclenames values('" & Name & "')", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
                loadModel()
                MsgBox(" Vehicle Model Deleted Successfully added", 64)
            End If
        End If
    End Sub

    Private Sub deleteLinkedVehicle(name As String)
        Dim cmd As New SqlCommand("delete tblLinkedVehicle where Name='" & name & "'", objCon)
        '  Dim cmd As New SqlCommand("insert into tblvehiclenames values('" & Name & "')", objCon)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub

    Private Sub deleteLinkedModel(name As String)
        Dim cmd As New SqlCommand("delete tblLinkedVehicle where Model='" & name & "'", objCon)
        '  Dim cmd As New SqlCommand("insert into tblvehiclenames values('" & Name & "')", objCon)
        objCon.Close()
        objCon.Open()
        cmd.ExecuteNonQuery()
        objCon.Close()
        cmd.Dispose()
    End Sub


    Private Sub btnLinkVehicle_Click(sender As System.Object, e As System.EventArgs) Handles btnLinkVehicle.Click
        If cmbModel.SelectedIndex = 0 Then
            MsgBox("Please Select Model No", 48)
        ElseIf cmbVehicle.SelectedIndex = 0 Then
            MsgBox("Please Select Vehicle Name", 48)
        Else
            Try
                Dim cmd As New SqlCommand("insert into tblLinkedVehicle values('" & cmbVehicle.SelectedItem & "','" & cmbModel.SelectedItem & "')", objCon)
                objCon.Close()
                objCon.Open()
                cmd.ExecuteNonQuery()
                objCon.Close()
                cmd.Dispose()
                loadVehicle()
                loadModel()
                MsgBox(" Vehicle Name and Model Linked Successfully added", 64)
                Close()
            Catch ex As Exception
                MsgBox("You have an error !!" & vbLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If isClose() Then
            Close()
        End If
    End Sub
End Class