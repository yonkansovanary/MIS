Imports System.Data.SqlClient
Imports System.Globalization

Public Class AddUserForm
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Dim now As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim lock As String
        now = myDt.ToString("yyyy-MM-dd")
        If CheckBoxLock.Checked = True Then
            lock = "1"
        Else
            lock = "0"
        End If
        Dim pass, conPass As String
        pass = myCon.EncryptPasword(txtPassword.Text)
        conPass = myCon.EncryptPasword(txtConPassword.Text)

        Try
            If txtPassword.Text = txtConPassword.Text Then
                myReader = myCon.listAllData("INSERT INTO sec_user (id, first_name, last_name, username, password,confirm_password, DOB, email, phone, address,
                is_lock, date_created, last_updated, version, full_name,gender) VALUES('" + txtCode.Text + "','" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtUsername.Text + "','" + pass + "','" + conPass + "','" + DOB.Text + "',
		        '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + lock + "','" + now + "','" + now + "','0','" + txtFirstname.Text + " " + txtLastname.Text + "', '" + ComboBoxGender.Text + "')")
                MsgBox("Successfully")
                Me.Close()
            Else
                MsgBox("Password is not match!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")

    End Sub

    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DOB.Format = DateTimePickerFormat.Custom
        DOB.CustomFormat = "yyyy-MM-dd"
        Try
            myReader = myCon.listAllData("Select * from role")
            ComboBoxRole.DisplayMember = "name"
            ComboBoxRole.ValueMember = "id"
            ComboBoxRole.DataSource = myReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DOB_ValueChanged(sender As Object, e As EventArgs) Handles DOB.ValueChanged

    End Sub

    Private Sub CheckBoxLock_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxLock.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim lock As String
        Dim dataReader As SqlDataReader

        If CheckBoxLock.Checked = True Then
            lock = "1"
        Else
            lock = "0"
        End If

        Try
            dataReader = myCon.myReaderFunction("Update sec_user Set  first_name = '" + txtFirstname.Text + "', 
           last_name = '" + txtLastname.Text + "', DOB='" + DOB.Value.ToString("yyyy-MM-dd") + "', email='" + txtEmail.Text + "', 
            phone='" + txtPhone.Text + "', address ='" + txtAddress.Text + "',is_lock='" + lock + "',
           full_name='" + txtFirstname.Text + " " + txtLastname.Text + "', gender='" + ComboBoxGender.Text + "' where id='" + txtCode.Text + "'")
            MsgBox("Successfully")
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnUserDelete.Click
        Try
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")

                Exit Sub

            End If
            myReader = myCon.listAllData(" Delete from sec_user Where id = " + txtCode.Text + " ")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub

    Private Sub ComboBoxRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged

    End Sub
End Class