Imports System.Data.SqlClient
Public Class MainForm
    Dim myCon As New Connection

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Public Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
        DataGridViewProduct.Visible = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)

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
        DataGridView_sec_user.Visible = False
        DataGridViewProduct.Visible = False
        LabelUserAdminName.Text = Form1.txtUsername.Text
        PanelHR.Visible = False
    End Sub

    Private Sub DataGridView_sec_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_sec_user.CellContentClick
        Dim dob As Date
        Dim code, firstName, lastName, username, pass, email, phone, address, gender, conPass As String
        Dim lock As Boolean

        Try
            code = DataGridView_sec_user.CurrentRow.Cells(1).Value.ToString()
            firstName = DataGridView_sec_user.CurrentRow.Cells(2).Value.ToString()
            lastName = DataGridView_sec_user.CurrentRow.Cells(3).Value.ToString()
            username = DataGridView_sec_user.CurrentRow.Cells(4).Value.ToString()
            pass = DataGridView_sec_user.CurrentRow.Cells(5).Value.ToString()
            dob = DataGridView_sec_user.CurrentRow.Cells(6).Value.ToString()
            email = DataGridView_sec_user.CurrentRow.Cells(7).Value.ToString()
            phone = DataGridView_sec_user.CurrentRow.Cells(8).Value.ToString()
            address = DataGridView_sec_user.CurrentRow.Cells(9).Value.ToString()
            lock = DataGridView_sec_user.CurrentRow.Cells(10).Value.ToString()
            gender = DataGridView_sec_user.CurrentRow.Cells(15).Value.ToString()
            conPass = DataGridView_sec_user.CurrentRow.Cells(16).Value.ToString()

            AddUserForm.txtCode.Text = code
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ListUserPanel.Visible = True
        DataGridViewProduct.DataSource = myCon.listAllData("select * from product where is_deleted = '0'")
        DataGridViewProduct.Visible = True
        DataGridView_sec_user.Visible = False
    End Sub
    Private Function CloseDataGrid()
        DataGridView_sec_user.Visible = False
        DataGridViewProduct.Visible = False
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        AddProductForm.btnUpdate.Visible = False
        AddProductForm.btnDelete.Visible = False
        AddProductForm.Show()
    End Sub

    Private Sub DataGridViewProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProduct.CellContentClick
        Dim code, Name, description, price, qty As String
        Dim dateCreated As Date

        Try
            code = DataGridViewProduct.CurrentRow.Cells(1).Value.ToString()
            Name = DataGridViewProduct.CurrentRow.Cells(2).Value.ToString()
            description = DataGridViewProduct.CurrentRow.Cells(3).Value.ToString()
            price = DataGridViewProduct.CurrentRow.Cells(4).Value.ToString()
            qty = DataGridViewProduct.CurrentRow.Cells(5).Value.ToString()
            dateCreated = DataGridViewProduct.CurrentRow.Cells(6).Value.ToString()

            AddProductForm.txtProductCode.Text = code
            AddProductForm.txtProductName.Text = Name
            AddProductForm.txtDescription.Text = description
            AddProductForm.txtUnitprice.Text = price
            AddProductForm.txtQty.Text = qty
            AddProductForm.DateCreated.Value = dateCreated.ToString("yyyy-MM-dd")

            AddProductForm.txtProductCode.ReadOnly = True
            AddProductForm.Show()
            AddUserForm.btnSave.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        PanelHR.Visible = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PanelHR.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        CloseForm()
        CategoryDetail.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        CloseForm()
        BrandDetail.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        CloseForm()
        Position.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        CloseForm()
        CustomerDetail.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If MessageBox.Show("Do you really want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        Me.Close()
        Form1.Show()
        Form1.txtUsername.Text = ""
        Form1.txtPassword.Text = ""
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        CloseForm()
        Role.Show()
    End Sub
    Private Function CloseForm()
        Position.Close()
        CategoryDetail.Close()
        Role.Close()
        BrandDetail.Close()
        AddUserForm.Close()
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PurchaseDetail.Show()
    End Sub
End Class