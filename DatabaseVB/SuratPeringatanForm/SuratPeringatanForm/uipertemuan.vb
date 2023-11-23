Public Class uipertemuan
    Private Sub pertemuan(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Konek()
        da = New Odbc.OdbcDataAdapter($"SELECT mahasiswa.NAMA, mahasiswa.TANGGAL FROM mahasiswa WHERE mahasiswa.TANGGAL IS NOT NULL AND NIM = '{DetailMahasiswa.adminNim}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))


        Label.Text = DetailMahasiswa.adminNama
        Label2.Text = DetailMahasiswa.adminNim
        Label3.Text = DetailMahasiswa.adminKelas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetailMahasiswa.Activate()
        DetailMahasiswa.Show()
        Me.Close()
    End Sub

End Class
