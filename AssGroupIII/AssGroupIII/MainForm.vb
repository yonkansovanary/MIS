Public Class MainForm
    Dim myCon As New Connection

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint
    End Sub

    Private Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub
End Class