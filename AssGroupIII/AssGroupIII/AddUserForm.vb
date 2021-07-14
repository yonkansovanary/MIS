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

        Try
            myReader = myCon.listAllData("INSERT INTO sec_user (id, first_name, last_name, username, password,confirm_password, DOB, email, phone, address,
           is_lock, date_created, last_updated, version, full_name,gender) VALUES('" + txtCode.Text + "','" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtConPassword.Text + "','" + DOB.Text + "',
		   '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + lock + "','" + now + "','" + now + "','0','" + txtFirstname.Text + " " + txtLastname.Text + "', '" + ComboBoxGender.Text + "')")
            MsgBox("Successfully")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")

    End Sub

    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    End Sub
End Class