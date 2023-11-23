Imports System.Data.Odbc
Imports System.Data

Module Koneksi
    Public con As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public strcon As String

    Public Sub Konek()
        strcon = "Dsn=sp_manager;database=sp_management;db=sp_management;description=Surat Peringatan Management;no_schema=1;port=3306;server=localhost;uid=root;user=root"
        con = New OdbcConnection(strcon)
        If con.State = ConnectionState.Closed Then con.Open()

    End Sub

End Module
