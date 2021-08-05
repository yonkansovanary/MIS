Public Class Position
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPosition.CellContentClick

    End Sub

    Private Sub LabelAddBrandTitle_Click(sender As Object, e As EventArgs) Handles LabelAddBrandTitle.Click

    End Sub

    Private Sub Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllPosition()
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        myReader = myCon.listAllData("INSERT INTO [dbo].[position]
           ([name]
           ,[description])
     VALUES
           ('" + txtName.Text + "','" + txtDescription.Text + "')")
        MsgBox("Position is created")
        getAllPosition()
        clearData()
    End Sub
    Public Function getAllPosition()
        DataGridViewPosition.DataSource = myCon.listAllData("select * from position")
    End Function
    Public Function clearData()
        txtName.Text = ""
        txtDescription.Text = ""
    End Function

End Class