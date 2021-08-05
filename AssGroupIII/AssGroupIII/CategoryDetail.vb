Public Class CategoryDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub CategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllCategory()
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        myReader = myCon.listAllData("INSERT INTO [dbo].[category]
           ([name]
           ,[description])
     VALUES
           ('" + txtName.Text + "','" + txtDescription.Text + "')")
        MsgBox("Category is created")
        getAllCategory()
    End Sub
    Private Function getAllCategory()
        DataGridViewCategory.DataSource = myCon.listAllData("select * from category")
    End Function
End Class