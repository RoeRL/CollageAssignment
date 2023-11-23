Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Konek()
        da = New Odbc.OdbcDataAdapter("select * from mahasiswa", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "mahasiswa")
        DataGridView1.DataSource = (ds.Tables("mahasiswa"))
    End Sub
End Class
