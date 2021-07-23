Imports System.Data.SqlClient
Public Class MainForm
    Dim myCon As New Connection

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Public Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("SELECT sec_user.code as Code,first_name as 'First Name',last_name as 'Last Name',
        username 'User Name',password 'Password',dob 'Date of Birth',email 'Email',phone 'Phone',address 'Address',date_created 'Create Date',full_name 'Full Name',
        gender 'Gender',role.name 'Role',position.name 'Position' ,is_lock 'Lock' FROM sec_user left join role on sec_user.role_Id= role.id left join position on sec_user.position_id = position.id ")
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

        Dim myReader As SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select max(id) as id  from sec_user")
        myReader.Read()
        nextCode = myReader("id")
        AddUserForm.txtCode.Text = "US00" + (nextCode + 1).ToString
        AddUserForm.txtCode.ReadOnly = True
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_sec_user.Visible = False
        DataGridViewProduct.Visible = False
        LabelUserAdminName.Text = Form1.txtUsername.Text
        PanelHR.Visible = False
    End Sub

    Private Sub DataGridView_sec_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_sec_user.CellContentClick
        Dim dob As Date
        Dim code, firstName, lastName, username, pass, email, phone, address, gender, conPass, role, positon As String
        Dim lock As Boolean
        AddUserForm.Show()
        Try
            code = DataGridView_sec_user.CurrentRow.Cells(0).Value.ToString()
            firstName = DataGridView_sec_user.CurrentRow.Cells(1).Value.ToString()
            lastName = DataGridView_sec_user.CurrentRow.Cells(2).Value.ToString()
            username = DataGridView_sec_user.CurrentRow.Cells(3).Value.ToString()
            pass = DataGridView_sec_user.CurrentRow.Cells(4).Value.ToString()
            dob = DataGridView_sec_user.CurrentRow.Cells(5).Value.ToString()
            email = DataGridView_sec_user.CurrentRow.Cells(6).Value.ToString()
            phone = DataGridView_sec_user.CurrentRow.Cells(7).Value.ToString()
            address = DataGridView_sec_user.CurrentRow.Cells(8).Value.ToString()
            gender = DataGridView_sec_user.CurrentRow.Cells(11).Value.ToString()
            conPass = DataGridView_sec_user.CurrentRow.Cells(4).Value.ToString()
            role = DataGridView_sec_user.CurrentRow.Cells(12).Value.ToString()
            positon = DataGridView_sec_user.CurrentRow.Cells(13).Value.ToString()
            lock = DataGridView_sec_user.CurrentRow.Cells(14).Value.ToString()

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
            AddUserForm.ComboBoxRole.Text = role
            AddUserForm.ComboBoxPosition.Text = positon

            AddUserForm.txtCode.ReadOnly = True
            AddUserForm.txtUsername.ReadOnly = True
            AddUserForm.txtPassword.ReadOnly = True
            AddUserForm.txtConPassword.ReadOnly = True

            AddUserForm.btnSave.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ListUserPanel.Visible = True
        DataGridViewProduct.DataSource = myCon.listAllData("SELECT product.id 'Id',code 'Code',product.name 'Name',product.description 'Description',unit_price 'Unit Price',qty_agree 'Qty Agree',
        date_created 'Date Created',last_udpated 'Last Updated',is_deleted 'Deleted',created_by 'Created By',updated_by 'Updated By',
        deleted_by 'Deleted By',category.name 'Category',brand.name 'Brand'FROM product left join category on product.category_id = category.id
        left join brand on product.brand_id = brand.id where is_deleted = '0'")
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

        Dim myReader As SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select max(id) as id  from product")
        myReader.Read()
        nextCode = myReader("id")
        AddProductForm.txtProductCode.Text = "PR" + (nextCode + 1).ToString
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
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PanelHR.Visible = False
        PictureBox5.Visible = True
        PictureBox7.Visible = False

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
        CustomerDetail.Close()
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PurchaseDetail.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PanelHR.Visible = True
        PictureBox5.Visible = False
        PictureBox7.Visible = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Supplier.Show()
    End Sub

    Private Sub Label14_Click_1(sender As Object, e As EventArgs) Handles Label14.Click
        OrderForm.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        SaleManagment.Show()
    End Sub
End Class