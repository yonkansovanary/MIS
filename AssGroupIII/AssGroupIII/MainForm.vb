Public Class MainForm
    Dim myCon As New Connection

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles PanelAdminBtn.Paint
    End Sub

    Private Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
        DataGridView_sec_user.DataSource = myCon.listAllData("select * from sec_user")
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub LabelUserAdminName_Click(sender As Object, e As EventArgs) Handles LabelUserAdminName.Click

    End Sub

    Private Sub LabelProjectTitle_Click(sender As Object, e As EventArgs) Handles LabelProjectTitle.Click

    End Sub

    Private Sub PanelSidebar_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class