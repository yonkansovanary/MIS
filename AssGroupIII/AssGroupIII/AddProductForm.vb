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
            '0','" + user + "','','',(select category.id from category where category.name = '" + ComboBoxcategory.Text + "'),
            (select brand.id from brand where brand.name = '" + ComboBoxBrand.Text + "'))")
            MsgBox("Product created successfully")
            Me.Close()
            getAllProduct()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

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
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            brand = myCon.listAllData("Select * from brand")
            ComboBoxBrand.DisplayMember = "name"
            ComboBoxBrand.ValueMember = "id"
            ComboBoxBrand.DataSource = brand
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnUserDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        user = Form1.txtUsername.Text
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Cancelled")
            Exit Sub
        End If
        Try
            myReader = myCon.listAllData(" Update  product set deleted_by = '" + user + "',is_deleted= '1' Where code = '" + txtProductCode.Text + "' ")
            MsgBox("Product deleted successfully!")
            Me.Close()
            getAllProduct()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text

        Try
            myReader = myCon.listAllData(" Update product set product.name='" + txtProductName.Text + "',product.description='" + txtDescription.Text + "',
            product.unit_price='" + txtUnitprice.Text + "',product.qty_agree='" + txtQty.Text + "',date_created='" + DateCreated.Text + "',updated_by='" + user + "',
            category_id = (select category.id from category where category.name = '" + ComboBoxcategory.Text + "'),
            brand_id = (select brand.id from brand where brand.name = '" + ComboBoxBrand.Text + "') where product.code ='" + txtProductCode.Text + "'")
            MsgBox("Product update successfully")
            Me.Close()
            getAllProduct()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub ComboBoxcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxcategory.SelectedIndexChanged

    End Sub

    Private Function getAllProduct()
        MainForm.DataGridViewProduct.DataSource = myCon.listAllData("SELECT product.id 'Id',code 'Code',product.name 'Name',product.description 'Description',unit_price 'Unit Price',qty_agree 'Qty Agree',
        date_created 'Date Created',last_udpated 'Last Updated',is_deleted 'Deleted',created_by 'Created By',updated_by 'Updated By',
        deleted_by 'Deleted By',category.name 'Category',brand.name 'Brand'FROM product left join category on product.category_id = category.id
        left join brand on product.brand_id = brand.id where is_deleted = '0'")
    End Function
End Class