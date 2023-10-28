Imports System.Data.OleDb

Module xDBConnection

    Public xConn As New OleDbConnection
    Dim DBProvider As String
    Dim DBSource As String


    Friend Sub xConnopen()

        xConn.ConnectionString = ""
        xConn.Open()

    End Sub

    Friend Sub xConnClose()
        xConn.Close()
    End Sub

End Module