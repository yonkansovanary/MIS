Public Class Position
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPosition.CellContentClick

    End Sub

    Private Sub LabelAddBrandTitle_Click(sender As Object, e As EventArgs) Handles LabelAddBrandTitle.Click

    End Sub

    Private Sub Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewPosition.DataSource = myCon.listAllData("select * from position")
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class