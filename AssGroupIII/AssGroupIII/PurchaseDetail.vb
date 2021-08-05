Imports System.Data.SqlClient

Public Class PurchaseDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Dim now As String
    Dim user As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub PurchaseDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchaseDate.Format = DateTimePickerFormat.Custom
        PurchaseDate.CustomFormat = "yyyy-MM-dd"
        Dim secuser, uom As DataTable


        'select uom'
        Try
            uom = myCon.listAllData("Select * from unit_of_measure")
            ComboBoxUom.DisplayMember = "name"
            ComboBoxUom.ValueMember = "id"
            ComboBoxUom.DataSource = uom
   
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select employee'

        Try
            secuser = myCon.listAllData("select full_name from sec_user where username = '" + Form1.txtUsername.Text + "'")
            ComboBoxPurchaseEm.DisplayMember = "full_name"
            ComboBoxPurchaseEm.ValueMember = "id"
            ComboBoxPurchaseEm.DataSource = secuser
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select employee'

        Me.CenterToScreen()
        getAllPurchase()
        getAllPurchaseDetail()

        Dim myReader As SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select max(id) as id  from purchase")
        myReader.Read()
        nextCode = myReader("id")
        txtPurchaseCode.Text = "PU00" + (nextCode + 1).ToString
        ComboBoxPurchaseEm.Enabled = False

        '------------------------------Purchase detail------------------------------------'
        'select pruduct'
        Dim product, purchase, shipping, supplier, category As DataTable

        Try
            product = myCon.listAllData("SELECT [product].[name]FROM [MIS].[dbo].[product] where is_deleted = '0'")
            PurchaseDeProId.DisplayMember = "name"
            PurchaseDeProId.ValueMember = "id"
            PurchaseDeProId.DataSource = product
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select purchase'

        Try
            purchase = myCon.listAllData("Select code from purchase where status = 'Pending'")
            ComboBoxPurchaseDeId.DisplayMember = "code"
            ComboBoxPurchaseDeId.ValueMember = "id"
            ComboBoxPurchaseDeId.DataSource = purchase
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

        'select supplier'

        Try
            supplier = myCon.listAllData("Select supplier_name from supplier")
            ComboBoxSupplier.DisplayMember = "supplier_name"
            ComboBoxSupplier.ValueMember = "id"
            ComboBoxSupplier.DataSource = supplier
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'select category'
        Try
            category = myCon.listAllData("Select name from category")
            ComboBoxProCategory.DisplayMember = "name"
            ComboBoxProCategory.ValueMember = "id"
            ComboBoxProCategory.DataSource = category
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'set value default'
        txtPurchaseUnitprice.Text = 0
        txtTotalPrice.Text = 0
        txtTotalPrice.ReadOnly = True
        txtQuantityShortage.Text = 0
        txtQuantityShortage.Visible = False
        Label12.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text

        Try
            myReader = myCon.listAllData("INSERT INTO purchase (code,employee_id,date_purchase,total_amount,date_created,last_updated,is_deleted,status) 
            VALUES('" + txtPurchaseCode.Text + "',(select sec_user.id from sec_user where sec_user.username = '" + Form1.txtUsername.Text + "'),
            '" + PurchaseDate.Text + "','" + txtTotalAmount.Text + "','" + now + "','" + now + "','0','" + ComboBoxPurStatus.Text + "')")
            MsgBox("Add purchase successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getAllPurchase()
        clearDatePurchase()
        'select purchase'
        Dim purchase As DataTable
        Try
            purchase = myCon.listAllData("Select code from purchase where status = 'Pending'")
            ComboBoxPurchaseDeId.DisplayMember = "code"
            ComboBoxPurchaseDeId.ValueMember = "id"
            ComboBoxPurchaseDeId.DataSource = purchase
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text
        now = myDt.ToString("yyyy-MM-dd")

        Try
            myReader = myCon.listAllData(" INSERT INTO purchase_detail (purchase_id, product_id, unit_price,unit_of_measure_id, qty, shipping_id, status, supplier_id, total_price, date_created, is_deleted)
             VALUES((select purchase.id from purchase where purchase.code = '" + ComboBoxPurchaseDeId.Text + "'),(select product.id from product where product.name = '" + PurchaseDeProId.Text + "' and is_deleted='0'),
            '" + txtPurchaseUnitprice.Text + "', (select unit_of_measure.id from unit_of_measure where unit_of_measure.name = '" + ComboBoxUom.Text + "'),'" + txtPurchaseQty.Text + "',(select shipping.id from shipping where shipping.shipping_method ='" + ComboBoxShipping.Text + "'),
            '" + ComboBoxStatus.Text + "',(select supplier.id from supplier where supplier.supplier_name = '" + ComboBoxSupplier.Text + "'),
            '" + txtTotalPrice.Text + "','" + now + "','0')")


            AddStockIn()
            getAllPurchaseDetail()
            MsgBox("Purchase Detail created successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function AddStockIn()
        Dim myRead As SqlDataReader
        Dim purchaseVersion As Integer
        now = myDt.ToString("yyyy-MM-dd")
        Dim version As String
        myRead = myCon.myReaderFunction("select isnull(max(purchase_version),0) 'version' from stock_detail  where product_id = (select product.id from product where product.name = '" + PurchaseDeProId.Text + "' and is_deleted ='0')")
        myRead.Read()

        version = myRead("version")
        purchaseVersion = Convert.ToInt32(version) + 1

        Try
            myReader = myCon.listAllData(" INSERT INTO stock_detail (qty, purchase_id, product_id, price, total_amount,date_instock,purchase_version) 
             VALUES ( " + txtPurchaseQty.Text + ",(select id from purchase where purchase.code = '" + ComboBoxPurchaseDeId.Text + "'), 
              (select id from product where product.name = '" + PurchaseDeProId.Text + "' and is_deleted='0'),
           " + txtPurchaseUnitprice.Text + "," + txtTotalPrice.Text + ",'" + now + "'," + purchaseVersion.ToString + ")")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function getAllPurchase()
        DataGridViewPurchase.DataSource = myCon.listAllData("SELECT purchase.code As Code,sec_user.full_name as 'Employee Name' ,
        date_purchase as 'Purchase Date',total_amount as 'Total Amount',status as Status
    FROM purchase left join sec_user on employee_id=sec_user.id  where purchase.is_deleted = '0'")
    End Function
    Private Function getAllPurchaseDetail()
        DataGridViewPurchaseDetail.DataSource = myCon.listAllData(
     "SELECT purchase.code 'Purchase Code',product.name 'Product Name',purchase_detail.unit_price 'Unit Price',
      unit_of_measure.name UOM ,qty 'Qty',shipping.shipping_method 'Shipping',purchase_detail.status 'Status',
     supplier.supplier_name 'Supplier Name',total_price 'Total Price',purchase_detail.date_created 'Date Created'
      FROM purchase_detail left join product on product_id = product.id
     left join purchase  on purchase_id = purchase.id
      left join shipping on shipping_id= shipping.id
     left join supplier on  supplier_id = supplier.id 
     left join unit_of_measure on unit_of_measure_id = unit_of_measure.id
     where purchase_detail.is_deleted = '0'")
    End Function

    Private Function clearDatePurchase()
        now = myDt.ToString("yyyy-MM-dd")
        txtPurchaseCode.Text = ""
        txtTotalAmount.Text = ""
        PurchaseDate.Text = now
        Dim myReader As SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select max(id) as id  from purchase")
        myReader.Read()
        nextCode = myReader("id")
        txtPurchaseCode.Text = "PU00" + (nextCode + 1).ToString
        ComboBoxPurchaseEm.Enabled = False
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtPurchaseUnitprice_Enter(sender As Object, e As EventArgs) Handles txtPurchaseUnitprice.Enter


    End Sub

    Private Sub txtPurchaseUnitprice_TextChanged(sender As Object, e As EventArgs) Handles txtPurchaseUnitprice.TextChanged

    End Sub

    Private Sub txtPurchaseUnitprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPurchaseUnitprice.KeyPress

    End Sub

    Private Sub txtPurchaseUnitprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPurchaseUnitprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim totalPrice As Double
            totalPrice = CDbl(txtPurchaseQty.Text) * CDbl(txtPurchaseUnitprice.Text)
            txtTotalPrice.Text = totalPrice
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBoxUom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUom.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxProCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProCategory.SelectedIndexChanged
        'select pruduct'
        Dim product As DataTable
        PurchaseDeProId.Text = ""
        Try
            product = myCon.listAllData("Select product.name from product where is_deleted = '0' and category_id = (select category.id from category where category.name = '" + ComboBoxProCategory.Text + "') ")
            PurchaseDeProId.DisplayMember = "code"
            PurchaseDeProId.ValueMember = "id"
            PurchaseDeProId.DataSource = product
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ComboBoxStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxStatus.SelectedIndexChanged
        If (ComboBoxStatus.Text = "Shortage") Then
            txtQuantityShortage.Visible = True
            Label12.Visible = True
        Else
            txtQuantityShortage.Visible = False
            Label12.Visible = False
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        now = myDt.ToString("yyyy-MM-dd")
        user = Form1.txtUsername.Text
        now = myDt.ToString("yyyy-MM-dd")

        Try
            myReader = myCon.listAllData(" INSERT INTO purchase_detail (purchase_id, product_id, unit_price,unit_of_measure_id, qty, shipping_id, status, supplier_id, total_price, date_created, is_deleted)
             VALUES((select purchase.id from purchase where purchase.code = '" + ComboBoxPurchaseDeId.Text + "'),(select product.id from product where product.name = '" + PurchaseDeProId.Text + "' and is_deleted='0'),
            '" + txtPurchaseUnitprice.Text + "', (select unit_of_measure.id from unit_of_measure where unit_of_measure.name = '" + ComboBoxUom.Text + "'),'" + txtPurchaseQty.Text + "',(select shipping.id from shipping where shipping.shipping_method ='" + ComboBoxShipping.Text + "'),
            '" + ComboBoxStatus.Text + "',(select supplier.id from supplier where supplier.supplier_name = '" + ComboBoxSupplier.Text + "'),
            '" + txtTotalPrice.Text + "','" + now + "','0')")


            AddStockIn()
            getAllPurchaseDetail()
            MsgBox("Purchase Detail created successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class