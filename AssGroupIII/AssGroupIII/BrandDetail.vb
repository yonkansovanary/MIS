﻿Public Class BrandDetail
    Dim myCon As New Connection
    Dim myReader As DataTable
    Private Sub BrandDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewBrand.DataSource = myCon.listAllData("select * from brand")
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class