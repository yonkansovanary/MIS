﻿Imports System.Data.SqlClient
Public Class Form1
    Dim myCon As New Connection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myReader As SqlDataReader
        Dim username As String
        Dim password As String

        Try
            myReader = myCon.myReaderFunction("select * from sec_user where username = '" + txtUsername.Text + "'")
            myReader.Read()
            username = myReader("username").ToString()
            password = myReader("password").ToString()
            If ((username <> txtUsername.Text) OrElse (password <> txtPassword.TextAlign)) Then
                MainForm.Show()
                Me.Hide()

            Else
                MsgBox("Please check username and password again")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Hi")
    End Sub
End Class
