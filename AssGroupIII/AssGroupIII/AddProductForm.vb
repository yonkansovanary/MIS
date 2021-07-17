Public Class AddProductForm
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Dim now As String
    Dim user As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text

        Try
            myReader = myCon.listAllData("INSERT INTO product (code,name,description,unit_price,qty_agree,date_created,
            last_udpated,is_deleted,created_by,updated_by,deleted_by ,category_id,brand_id) 
            VALUES('" + txtProductCode.Text + "','" + txtProductName.Text + "','" + txtDescription.Text + "',
            '" + txtUnitprice.Text + "','" + txtQty.Text + "','" + now + "','" + now + "',
            '0','" + user + "','','',(select category.id from category where category.name = '" + ComboBoxcategory.Text + "'),(select brand.id from brand where brand.name = '" + ComboBoxBrand.Text + "'))")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Product created successfully")
        Me.Close()
        MainForm.DataGridViewProduct.DataSource = myCon.listAllData("select * from product where is_deleted='0'")
    End Sub

    Private Sub AddProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim category, brand As DataTable

        DateCreated.Format = DateTimePickerFormat.Custom
        DateCreated.CustomFormat = "yyyy-MM-dd"

        Try
            category = myCon.listAllData("Select * from category")
            ComboBoxcategory.DisplayMember = "name"
            ComboBoxcategory.ValueMember = "id"
            ComboBoxcategory.DataSource = category

            brand = myCon.listAllData("Select * from brand")
            ComboBoxBrand.DisplayMember = "name"
            ComboBoxBrand.ValueMember = "id"
            ComboBoxBrand.DataSource = brand
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        user = Form1.txtUsername.Text
        Try
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Cancelled")

                Exit Sub

            End If
            myReader = myCon.listAllData(" Update  product set deleted_by = '" + user + "',is_deleted= '1' Where code = " + txtProductCode.Text + " ")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        MsgBox("Product deleted successfully!")
        Me.Close()
        MainForm.DataGridView_sec_user.DataSource = myCon.listAllData("select * from product where is_deleted = '0'")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text

        Try
            myReader = myCon.listAllData(" Update product set name='" + txtProductName.Text + "',description='" + txtDescription.Text + "',
            unit_price='" + txtUnitprice.Text + "',qty_agree='" + txtQty.Text + "',date_created='" + DateCreated.Text + "',updated_by='" + user + "',
            category_id = (select category.id from category where category.name = '" + ComboBoxcategory.Text + "'),
            brand_id = (select brand.id from brand where brand.name = '" + ComboBoxBrand.Text + "') where id =" + txtProductCode.Text + "")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        MsgBox("Product update successfully")
        Me.Close()
        MainForm.DataGridViewProduct.DataSource = myCon.listAllData("select * from product where is_deleted='0'")
    End Sub

    Private Sub ComboBoxcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxcategory.SelectedIndexChanged

    End Sub
End Class