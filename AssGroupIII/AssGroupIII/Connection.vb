
Imports System.Data.SqlClient
Public Class Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public Sub sqlConnector()
        myConn = New SqlConnection("Server=Localhost;Database=MIS;UID=sa;PWD=12345;")
        myCmd = myConn.CreateCommand
        Return
    End Sub
    Public Function listAllData(sql As String)
        Dim data As New DataTable
        Try
            sqlConnector()
            myCmd.CommandText = sql
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            data.Load(myReader)
            Return data
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function myReaderFunction(sql As String)
        Dim data As New DataTable
        sqlConnector()
        myCmd.CommandText = sql
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Return myReader
    End Function
    Public Function getCurentUser(sql As String)
        Dim data As New DataTable
        sqlConnector()
        myCmd.CommandText = sql
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Return myReader
    End Function

End Class