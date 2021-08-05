Public Class BrandDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub BrandDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllBrand()
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        myReader = myCon.listAllData("INSERT INTO [dbo].[brand]
           ([name]
           ,[description])
     VALUES
           ('" + txtName.Text + "','" + txtDescription.Text + "')")
        MsgBox("Brand is created")
        getAllBrand()
        clearData()
    End Sub
    Private Function getAllBrand()
        DataGridViewBrand.DataSource = myCon.listAllData("select * from brand")
    End Function
    Private Function clearData()
        txtName.Text = ""
        txtDescription.Text = ""
    End Function
End Class