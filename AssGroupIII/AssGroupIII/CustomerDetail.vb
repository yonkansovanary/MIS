Public Class CustomerDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Dim myDt As DateTime = DateTime.Now
    Dim now As String
    Dim user As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub CustomerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        DataGridViewCustomer.DataSource = myCon.listAllData("select * from customer")
    End Sub
End Class