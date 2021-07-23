Public Class Supplier
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        getAllSupplier()
    End Sub
    Private Function getAllSupplier()
        DataGridViewSupplier.DataSource = myCon.listAllData("SELECT * from supplier")
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class