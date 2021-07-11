
Imports System.Data.SqlClient
Public Class Connection
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Public Sub sqlConnector()
        myConn = New SqlConnection("Server= DESKTOP-JTNSKEL; Database= MIS; Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        Return
    End Sub
    Public Function listAllData(sql As String)
        Dim data As New DataTable
        sqlConnector()
        myCmd.CommandText = sql
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        data.Load(myReader)
        Return data
    End Function
    Public Function myReaderFunction(sql As String)
        Dim data As New DataTable
        sqlConnector()
        myCmd.CommandText = sql
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Return myReader
    End Function

End Class