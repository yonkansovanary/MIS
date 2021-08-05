Public Class Role
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub Role_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllRole()
        Me.CenterToScreen()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        myReader = myCon.listAllData("INSERT INTO [dbo].[role]
           ([name]
           ,[description])
     VALUES
           ('" + txtName.Text + "','" + txtDescription.Text + "')")
        MsgBox("Brand is created")
        getAllRole()
        clearData()
    End Sub
    Public Function clearData()
        txtName.Text = ""
        txtDescription.Text = ""
    End Function
    Public Function getAllRole()
        DataGridViewrRole.DataSource = myCon.listAllData("select * from role")
    End Function
End Class