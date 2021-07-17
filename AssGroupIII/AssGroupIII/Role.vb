Public Class Role
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub Role_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewrRole.DataSource = myCon.listAllData("select * from role")
        Me.CenterToScreen()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class