Imports System.Data.Odbc
Module ConnectDB
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public QUERY As String
    Public DS As DataSet
    Public DT As DataTable

    Sub KONEKSI()
        Dim str As String = "Dsn=con_serahterima"
        CONN = New OdbcConnection(str)

        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
            'MsgBox("Koneksi Berhasil")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub

End Module
