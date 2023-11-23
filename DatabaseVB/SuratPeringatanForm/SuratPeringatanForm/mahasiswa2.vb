Public Class mahasiswa2

    Private Sub mahasiswa2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Konek()
        da = New Odbc.OdbcDataAdapter($"select NIM, NAMA, KELAS, ALASAN from `mahasiswa` where KODE_SP = 'SPL' AND NIM = '{LoginForm.TextBox2.Text}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))

        da = New Odbc.OdbcDataAdapter($"select NIM, NAMA, KELAS, ALASAN from `mahasiswa` where KODE_SP = 'SPT' AND NIM = '{LoginForm.TextBox2.Text}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mahasiswa.Show()
        Me.Hide()
    End Sub
End Class