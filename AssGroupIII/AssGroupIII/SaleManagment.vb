Public Class SaleManagment
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Dim now As String
    Dim user As String
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SaleManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaleDate.Format = DateTimePickerFormat.Custom
        SaleDate.CustomFormat = "yyyy-MM-dd"
        Dim secuser, uom As DataTable


        'select uom'
        Try
            uom = myCon.listAllData("Select * from unit_of_measure")
            ComboBoxUOM.DisplayMember = "name"
            ComboBoxUOM.ValueMember = "id"
            ComboBoxUOM.DataSource = uom

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select employee'

        Try
            secuser = myCon.listAllData("select full_name from sec_user where username = '" + Form1.txtUsername.Text + "'")
            ComboBoxSaleEm.DisplayMember = "full_name"
            ComboBoxSaleEm.ValueMember = "id"
            ComboBoxSaleEm.DataSource = secuser
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'select employee'

        Try
            secuser = myCon.listAllData("select full_name from sec_user where username = '" + Form1.txtUsername.Text + "'")
            ComboBoxSaleEm.DisplayMember = "full_name"
            ComboBoxSaleEm.ValueMember = "id"
            ComboBoxSaleEm.DataSource = secuser
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'select code'

        Me.CenterToScreen()

        Dim myReader As SqlClient.SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select max(id) as id  from sale")
        myReader.Read()
        nextCode = myReader("id")
        txtSaleCode.Text = "SA00" + (nextCode + 1).ToString
        ComboBoxSaleEm.Enabled = False

        '------------------------------Sale detail------------------------------------'
        'select pruduct'
        Dim product, sale, shipping, customer As DataTable

        Try
            product = myCon.listAllData("Select name from product where is_deleted = '0'")
            SaleDeProId.DisplayMember = "name"
            SaleDeProId.ValueMember = "id"
            SaleDeProId.DataSource = product

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'show sale'
        Try
            sale = myCon.listAllData("Select code from sale where is_deleted = '0'")
            ComboBoxSaleDeId.DisplayMember = "code"
            ComboBoxSaleDeId.ValueMember = "id"
            ComboBoxSaleDeId.DataSource = sale

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'select shipping'

        Try
            shipping = myCon.listAllData("Select shipping_method from shipping")
            ComboBoxShipping.DisplayMember = "shipping_method"
            ComboBoxShipping.ValueMember = "id"
            ComboBoxShipping.DataSource = shipping
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select customer'

        Try
            customer = myCon.listAllData("Select code from customer")
            ComboBoxCustomer.DisplayMember = "code"
            ComboBoxCustomer.ValueMember = "id"
            ComboBoxCustomer.DataSource = customer
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        getAllSale()
        getAllSaleDetail()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text
        Dim sale As DataTable
        Try
            myReader = myCon.listAllData("INSERT INTO sale (code,employee_id ,total_amount,sale_date,sale_by,is_deleted) 
            VALUES('" + txtSaleCode.Text + "',(select id from sec_user where username = '" + user + "')," + txtTotalAmount.Text + ",'" + SaleDate.Text + "','" + user + "','0')")
            MsgBox("Sale added successfully")
            getAllSale()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            sale = myCon.listAllData("Select code from sale where is_deleted = '0'")
            ComboBoxSaleDeId.DisplayMember = "code"
            ComboBoxSaleDeId.ValueMember = "id"
            ComboBoxSaleDeId.DataSource = sale

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function getAllSale()
        DataGridViewSale.DataSource = myCon.listAllData("SELECT sale.code 'Sale Code',sec_user.full_name 'Employee'
      ,total_amount 'Total Amount',sale_date  'Date Sale',sale_by 'Sale By' FROM sale left join sec_user on employee_id = sec_user.id
    where sale.is_deleted = '0'")
    End Function
    Private Function getAllSaleDetail()
        DataGridViewSaleDetail.DataSource = myCon.listAllData("select * from sale_detail")
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SaleDeProId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SaleDeProId.SelectedIndexChanged


    End Sub

    'TO Do'
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text
        Try
            myReader = myCon.listAllData("INSERT INTO sale_detail(sale_id,product_id,qty,sale_price,total_price,date_create,created_by,is_deleted,uom_id,customer_id)   
            VALUES((select sale.id from sale where sale.code = '" + ComboBoxSaleDeId.Text + "'),(select product.id from product where product.name = '" + SaleDeProId.Text + "' and is_deleted = '0'),'" + txtSaleQty.Text + "','" + txtProUnitprice.Text + "',
            '" + txtTotalPrice.Text + "','" + now + "', '" + user + "','0',(select unit_of_measure.id from unit_of_measure where unit_of_measure.name = '" + ComboBoxUOM.Text + "'),
            (select customer.id from customer where customer.code = '" + ComboBoxCustomer.Text + "'))")
            MsgBox("Sale Detail added successfully")
            getAllSaleDetail()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtProUnitprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProUnitprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim totalPrice, qty, price As Double
            totalPrice = CDbl(txtSaleQty.Text) * CDbl(txtProUnitprice.Text)
            txtTotalPrice.Text = totalPrice
        End If
    End Sub
End Class