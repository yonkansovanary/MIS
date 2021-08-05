Imports System.Data.SqlClient
Public Class Supplier
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        getAllSupplier()
        'Next code'
        getNextCode()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            myReader = myCon.listAllData("INSERT INTO [dbo].[supplier]
           ([code]
           ,[supplier_name]
           ,[phone]
           ,[email]
           ,[location]
           ,[company_name]
           ,[company_loation])
     VALUES
           ('" + txtSuppCode.Text + "','" + txtSuppName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "',
            '" + txtLocation.Text + "','" + txtCompanyName.Text + "','" + txtComLocation.Text + "')")
            MsgBox("Supplier created successfully")
            getAllSupplier()
            getNextCode()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Function getAllSupplier()
        DataGridViewSupplier.DataSource = myCon.listAllData("SELECT * from supplier")
    End Function
    Private Function clearData()
        txtSuppName.Text = ""
        txtEmail.Text = ""
        txtLocation.Text = ""
        txtCompanyName.Text = ""
        txtComLocation.Text = ""
    End Function
    Private Function getNextCode()
        Dim myReader As SqlDataReader
        Dim nextCode As Integer
        myReader = myCon.myReaderFunction("select isnull(0,max(id)) as id  from supplier")
        myReader.Read()
        nextCode = myReader("id")
        txtSuppCode.Text = "SU" + (nextCode + 1).ToString
    End Function
End Class