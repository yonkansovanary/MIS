Imports System.Data.SqlClient
Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public Sub sqlConnector()
        myConn = New SqlConnection("Server= DESKTOP-JTNSKEL; Database= AssignmentGroupIII; Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        Return
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        sqlConnector()
        Try
            myCmd.CommandText = "SELECT * FROM Student "
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            While myReader.Read()
                MsgBox(myReader("ID").ToString())
                MsgBox(myReader("Name").ToString())
                MsgBox(myReader("Age").ToString())
            End While
            myReader.Close()
            myConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GetStudent()
        Dim data As New DataTable
        sqlConnector()
        myCmd.CommandText = "SELECT * FROM Student "
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        data.Load(myReader)
        Return data
    End Function
End Class
