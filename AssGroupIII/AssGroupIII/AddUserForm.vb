Imports System.Data.SqlClient
Imports System.Globalization

Public Class AddUserForm
    Dim myCon As New Connection
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As Date = Today
        myCon.listAllData(" INSERT INTO sec_user (id, first_name, last_name, username, password, DOB, email, phone, address,
isLock, date_created, last_updated, Version, full_name) VALUES ('3','" + txtFirstname.Text + "', '" + txtLastname.Text + "', 
'" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + DOB.Text + "', '" + txtEmail.Text + "', 
'" + txtAddress.Text + "','" + CheckBoxLock.Text + "', '" + txtAddress.Text + "', '" + dt + "', '" + dt + "', '0', '" + txtLastname.Text + "'")

    End Sub

    Private Sub AddUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myCon.listAllData("select * from sec_user")
    End Sub
End Class