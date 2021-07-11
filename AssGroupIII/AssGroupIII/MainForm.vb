Public Class MainForm
    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint
    End Sub

    Private Sub Adminbtn_Click(sender As Object, e As EventArgs) Handles Adminbtn.Click
        ListUserPanel.Visible = True
        AdminLabel.Visible = True
    End Sub
End Class