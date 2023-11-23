Imports System.Security.Cryptography.X509Certificates

Public Class AdminP
    Public namaMhs As String
    Public nimMhs As String
    Public kelasMhs As String
    Public tipeSP As String
    Public alasanSP As String
    Public selected As String
    Public selectedRow As Integer
    Public selectNameMhs As String
    Public selectKelasMhs As String
    Public selectNimMhs As String
    Public defaultMahasiswaTable As String

    'Menampilkan Data Dalam Tabel
    Private Sub Home_Admin(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Konek()

        defaultMahasiswaTable = "
SELECT 
mahasiswa_sp.id,
mahasiswa_sp.NIM,
mahasiswa_sp.NAMA,
mahasiswa_sp.KELAS,
mahasiswa_sp.TANGGAL_SP,
mahasiswa_sp.PELAPOR,
tipe_sp.JENIS_SP  FROM mahasiswa_sp, tipe_sp WHERE mahasiswa_sp.KODE_SP = tipe_sp.KODE_SP
"
        da = New Odbc.OdbcDataAdapter($"{defaultMahasiswaTable}", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`sp_mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`sp_mahasiswa`"))


        Label1.Text = "ADMIN PANEL"
        Label1.Font = New Font("SegoeUI", 14)


    End Sub




    'Button Delete
    Private Sub DeleteButton(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            da = New Odbc.OdbcDataAdapter($"{defaultMahasiswaTable}", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`sp_mahasiswa`")
            selectedRow = DataGridView1.SelectedRows(0).Index
            selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
            da = New Odbc.OdbcDataAdapter($"DELETE FROM mahasiswa_sp WHERE mahasiswa_sp.id = '{selected}'", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`sp_mahasiswa`")


            da = New Odbc.OdbcDataAdapter($"{defaultMahasiswaTable}", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`sp_mahasiswa`")
            DataGridView1.DataSource = (ds.Tables("`sp_mahasiswa`"))

        Catch ex As Exception
            MsgBox("Row Tidak Terdeteksi")
        End Try
    End Sub

    'Button SP Lisan > 4
    Private Sub CheckSPTButton(sender As Object, e As EventArgs) Handles Button4.Click
        da = New Odbc.OdbcDataAdapter("SELECT NIM, NAMA, COUNT(NIM) as 'Jumlah SP Lisan' FROM mahasiswa_sp WHERE KODE_SP = 'SPL' GROUP BY (NIM) HAVING COUNT(NIM) > 4", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))
    End Sub



    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Me.Activate()
            selectedRow = DataGridView1.SelectedRows(0).Index
            selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
            selectNameMhs = ds.Tables(0).Rows(selectedRow).Item(2).ToString()
            selectKelasMhs = ds.Tables(0).Rows(selectedRow).Item(3).ToString()
            selectNimMhs = ds.Tables(0).Rows(selectedRow).Item(1).ToString()
            DetailMahasiswa.Show()
            DetailMahasiswa.Activate()
            Me.Close()
        Catch ex As Exception
            MsgBox("Row tidak terdeteksi")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Admin.Show()
        Admin.Activate()
        Me.Close()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm.Activate()
        LoginForm.Show()
        Me.Close()
    End Sub
End Class
