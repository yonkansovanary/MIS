Imports System.Data.SqlClient
Public Class MainForm
    Dim myCon As New Connection

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles PanelAdminBtn.Paint
    End Sub

    Public Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        Dim btnDe As New DataGridViewButtonColumn
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub LabelUserAdminName_Click(sender As Object, e As EventArgs) Handles LabelUserAdminName.Click

    End Sub

    Private Sub LabelProjectTitle_Click(sender As Object, e As EventArgs) Handles LabelProjectTitle.Click

    End Sub

    Private Sub PanelSidebar_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        AddUserForm.Show()
        AddUserForm.btnUserDelete.Visible = False
        AddUserForm.btnUpdate.Visible = False
        AddUserForm.btnSave.Visible = True
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUserAdminName.Text = Form1.txtUsername.Text
    End Sub

    Private Sub DataGridView_sec_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_sec_user.CellContentClick
        Dim dob As Date
        Dim id, firstName, lastName, username, pass, email, phone, address, gender, conPass As String
        Dim lock As Boolean

        Try
            id = DataGridView_sec_user.CurrentRow.Cells(0).Value.ToString()
            firstName = DataGridView_sec_user.CurrentRow.Cells(1).Value.ToString()
            lastName = DataGridView_sec_user.CurrentRow.Cells(2).Value.ToString()
            username = DataGridView_sec_user.CurrentRow.Cells(3).Value.ToString()
            pass = DataGridView_sec_user.CurrentRow.Cells(4).Value.ToString()
            dob = DataGridView_sec_user.CurrentRow.Cells(5).Value.ToString()
            email = DataGridView_sec_user.CurrentRow.Cells(6).Value.ToString()
            phone = DataGridView_sec_user.CurrentRow.Cells(7).Value.ToString()
            address = DataGridView_sec_user.CurrentRow.Cells(8).Value.ToString()
            lock = DataGridView_sec_user.CurrentRow.Cells(9).Value.ToString()
            gender = DataGridView_sec_user.CurrentRow.Cells(14).Value.ToString()
            conPass = DataGridView_sec_user.CurrentRow.Cells(15).Value.ToString()

            AddUserForm.txtCode.Text = id
            AddUserForm.txtFirstname.Text = firstName
            AddUserForm.txtLastname.Text = lastName
            AddUserForm.txtUsername.Text = username
            AddUserForm.txtPassword.Text = pass
            AddUserForm.DOB.Value = dob.ToString("yyyy-MM-dd")
            AddUserForm.txtEmail.Text = email
            AddUserForm.txtPhone.Text = phone
            AddUserForm.txtAddress.Text = address
            AddUserForm.CheckBoxLock.Checked = lock
            AddUserForm.ComboBoxGender.Text = gender
            AddUserForm.txtConPassword.Text = conPass


            AddUserForm.txtCode.ReadOnly = True
            AddUserForm.txtUsername.ReadOnly = True
            AddUserForm.txtPassword.ReadOnly = True
            AddUserForm.txtConPassword.ReadOnly = True

            AddUserForm.Show()
            AddUserForm.btnSave.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class