﻿Public Class uipertemuan
    Public temporaryNIM As String
    Public temporaryKelas As String
    Public temporaryNama As String

    Private Sub pertemuan(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Konek()
        da = New Odbc.OdbcDataAdapter(
            $"SELECT pertemuan.NIM, 
            main_mahasiswa.NAMA, 
            pertemuan.TANGGAL_PERTEMUAN FROM pertemuan, 
            main_mahasiswa WHERE 
            pertemuan.NIM = main_mahasiswa.NIM AND pertemuan.NIM = '{DetailMahasiswa.adminNim}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))


        Label.Text = DetailMahasiswa.adminNama
        Label2.Text = DetailMahasiswa.adminNim
        Label3.Text = DetailMahasiswa.adminKelas
        temporaryNIM = Label2.Text
        temporaryNama = Label.Text
        temporaryKelas = Label3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DetailMahasiswa.Activate()
        DetailMahasiswa.Show()
        Me.Close()
    End Sub

End Class