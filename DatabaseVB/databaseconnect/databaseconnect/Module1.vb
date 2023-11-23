Imports System.Data.Odbc
Imports System.Data

Module Koneksi
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String

    Public Sub Konek()
        strcon = "Driver={MySQL ODBC 5.3 ANSI Driver};database=dataku;server=locahost;uid=root"
        conn = New OdbcConnection(strcon)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

End Module
