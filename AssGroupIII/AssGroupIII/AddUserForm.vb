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
                myReader = myCon.listAllData("INSERT INTO sec_user (code, first_name, last_name, username, password,confirm_password, DOB, email, phone, address,
                is_lock, date_created, last_updated, version, full_name,gender,role_id,position_id,is_deleted) VALUES('" + txtCode.Text + "','" + txtFirstname.Text + "',
                '" + txtLastname.Text + "','" + txtUsername.Text + "','" + pass + "','" + conPass + "','" + DOB.Text + "',
		        '" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + lock + "','" + now + "','" + now + "','0','" + txtFirstname.Text + " " + txtLastname.Text + "',
                '" + ComboBoxGender.Text + "',(select role.id from role where role.name = '" + ComboBoxRole.Text + "'),
                (select position.id from position where position.name = '" + ComboBoxPosition.Text + "'),'0')")
                MsgBox("Create user successfully")
                Me.Close()
            Else
                MsgBox("Password is not match!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        listAllUser()
    End Sub

    Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.CenterToScreen()
            DOB.Format = DateTimePickerFormat.Custom
            DOB.CustomFormat = "yyyy-MM-dd"
            Dim role, position As DataTable

            Try
                role = myCon.listAllData("Select * from role")
                ComboBoxRole.DisplayMember = "name"
                ComboBoxRole.ValueMember = "id"
                ComboBoxRole.DataSource = role
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                position = myCon.listAllData("Select * from position")
                ComboBoxPosition.DisplayMember = "name"
                ComboBoxPosition.ValueMember = "id"
                ComboBoxPosition.DataSource = position
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
        now = myDt.ToString("yyyy-MM-dd")


        If CheckBoxLock.Checked = True Then
            lock = "1"
        Else
            lock = "0"
        End If

        Try
            dataReader = myCon.myReaderFunction("Update sec_user Set last_updated ='" + now + "' , first_name = '" + txtFirstname.Text + "', 
           last_name = '" + txtLastname.Text + "', DOB='" + DOB.Value.ToString("yyyy-MM-dd") + "', email='" + txtEmail.Text + "', 
            phone='" + txtPhone.Text + "', address ='" + txtAddress.Text + "',is_lock='" + lock + "',
           full_name='" + txtFirstname.Text + " " + txtLastname.Text + "', gender='" + ComboBoxGender.Text + "',
            role_Id = (select role.id from role where role.name = '" + ComboBoxRole.Text + "'),position_id =  (select position.id from position where position.name = '" + ComboBoxPosition.Text + "')
           where code='" + txtCode.Text + "'")
            MsgBox("Updated Employee successfully")
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        listAllUser()
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnUserDelete.Click
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

            MsgBox("Cancelled")

            Exit Sub

        End If
        Try
            myReader = myCon.listAllData(" Update sec_user set is_deleted = '1'  Where code = '" + txtCode.Text + "' ")
            MsgBox("Employee is deleted sucessfully")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        listAllUser()
    End Sub

    Private Sub ComboBoxRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectedIndexChanged

    End Sub
    Private Function listAllUser()
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("SELECT sec_user.code as Code,first_name as 'First Name',last_name as 'Last Name',
        username 'User Name',password 'Password',dob 'Date of Birth',email 'Email',phone 'Phone',address 'Address',date_created 'Create Date',full_name 'Full Name',
        gender 'Gender',role.name 'Role',position.name 'Position' ,is_lock 'Lock' FROM sec_user left join role on sec_user.role_Id= role.id left join position on sec_user.position_id = position.id where sec_user.is_deleted ='0'")
    End Function
End Class