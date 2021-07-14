Imports System.Data.SqlClient
Public Class MainForm
    Dim myCon As New Connection
    Dim btnEd As New DataGridViewButtonColumn




    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles PanelAdminBtn.Paint
    End Sub

    Public Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        Dim btnDe As New DataGridViewButtonColumn
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
        'delete'
        btnDe.HeaderText = ""
        btnDe.Text = "Delete"
        btnDe.Name = "btnDelete"
        btnDe.UseColumnTextForButtonValue = True
        DataGridView_sec_user.Columns.Insert(16, btnDe)

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
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUserAdminName.Text = Form1.txtUsername.Text
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub

    Private Sub DataGridView_sec_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_sec_user.CellContentClick
        Dim id As String
        Dim firstName As String
        Dim lastName As String
        Dim username As String
        Dim pass As String
        Dim dob As Date
        Dim email As String
        Dim phone, address, gender, conPass, delete As String
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
            delete = DataGridView_sec_user.CurrentRow.Cells(16).Value.ToString()

            AddUserForm.txtCode.Text = id
            AddUserForm.txtFirstname.Text = firstName
            AddUserForm.txtLastname.Text = lastName
            AddUserForm.txtUsername.Text = username
            AddUserForm.txtPassword.Text = pass
            AddUserForm.DOB.Value = dob
            AddUserForm.txtEmail.Text = email
            AddUserForm.txtPhone.Text = phone
            AddUserForm.txtAddress.Text = address
            AddUserForm.CheckBoxLock.Checked = lock
            AddUserForm.ComboBoxGender.Text = gender
            AddUserForm.txtConPassword.Text = conPass
            AddUserForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class