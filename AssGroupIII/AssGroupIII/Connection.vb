
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

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
    Public Sub sqlConnection()
        myConn = New SqlConnection("Server= DESKTOP-JTNSKEL; Database= MIS; Integrated Security=SSPI;")
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

    Public Function EncryptPasword(pass As String)
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()

        Bytes = Encoding.Default.GetBytes(pass)

        'Get md5 hash
        Bytes = MD5.Create().ComputeHash(Bytes)

        'Loop though the byte array and convert each byte to hex.
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString
    End Function

    Friend Function qlConnection() As SqlConnection
        Return New SqlConnection("Server= DESKTOP-JTNSKEL; Database= MIS; Integrated Security=SSPI;")
    End Function
End Class