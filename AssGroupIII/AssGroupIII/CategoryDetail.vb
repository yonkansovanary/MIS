Public Class CategoryDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub CategoryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewCategory.DataSource = myCon.listAllData("select * from category")
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class