Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Admin
    Public nimMhs As String
    Public namaMhs As String
    Public kelasMhs As String
    Public tipeSP As String
    Public alasanSP As String
    Public pelaporSPL As String
    Public pelaporSPT As String
    Public selected As String
    Public selectedRow As Integer
    Public selectNameMhs As String
    Public selectKelasMhs As String
    Public selectNimMhs As String
    Public tanggalSPL As String
    Public tanggalSPT As String


    'INPUT Surat Peringatan Lisan Dalam Form Admin Pelapor
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Konek()
        da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPT'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))

        da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPL'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
    End Sub

    Private Sub SPLKirim_Click(sender As Object, e As EventArgs) Handles SPLKirim.Click
        nimMhs = InputSPLNIM.Text
        namaMhs = InputSPLNama.Text
        kelasMhs = InputSPLKelas.Text
        tipeSP = "SPL"
        alasanSP = InputSPLAlasan.Text
        pelaporSPL = InputSPLPelapor.Text
        tanggalSPL = InputSPLDate.Text

        Try

            da = New Odbc.OdbcDataAdapter($"INSERT INTO main_mahasiswa (`NIM`, `NAMA`, `KELAS`) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")


            da = New Odbc.OdbcDataAdapter($"INSERT INTO mahasiswa_sp (`NIM`, `NAMA`, `KELAS`, `TANGGAL_SP`, `PELAPOR`, `KODE_SP` ) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tanggalSPL}', '{pelaporSPL}', 'SPL')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")

            da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPL'", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")
            DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))


            InputSPLNama.Clear()
            InputSPLNIM.Clear()
            InputSPLAlasan.Clear()
            InputSPLPelapor.Clear()
            InputSPLKelas.Clear()

        Catch ex As Exception
            da = New Odbc.OdbcDataAdapter($"INSERT INTO mahasiswa_sp (`NIM`, `NAMA`, `KELAS`, `TANGGAL_SP`, `PELAPOR`, `KODE_SP` ) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tanggalSPL}', '{pelaporSPL}', 'SPL')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")

            da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPL'", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")
            DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))


            InputSPLNama.Clear()
            InputSPLNIM.Clear()
            InputSPLAlasan.Clear()
            InputSPLPelapor.Clear()
            InputSPLKelas.Clear()

        End Try





    End Sub


    Private Sub SPLHapus_Click(sender As Object, e As EventArgs) Handles SPLHapus.Click
        selectedRow = DataGridView1.SelectedRows(0).Index
        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
        da = New Odbc.OdbcDataAdapter($"DELETE FROM `mahasiswa_sp` WHERE id = '{selected}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")

        da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPL'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
    End Sub


    'INPUT SURAT PERINGATAN TULIS
    Private Sub SPTKirim_Click(sender As Object, e As EventArgs) Handles SPTKirim.Click
        nimMhs = InputSPTNIM.Text
        namaMhs = InputSPTNama.Text
        kelasMhs = InputSPTKelas.Text
        tipeSP = "SPT"
        alasanSP = InputSPTAlasan.Text
        pelaporSPT = InputSPTPelapor.Text
        tanggalSPT = InputSPTDate.Text

        Try

            da = New Odbc.OdbcDataAdapter($"INSERT INTO main_mahasiswa (`NIM`, `NAMA`, `KELAS`) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")


            da = New Odbc.OdbcDataAdapter($"INSERT INTO mahasiswa_sp (`NIM`, `NAMA`, `KELAS`, `TANGGAL_SP`, `PELAPOR`, `KODE_SP` ) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tanggalSPT}', '{pelaporSPT}', 'SPT')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")

            da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPT'", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")
            DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))


            InputSPLNama.Clear()
            InputSPLNIM.Clear()
            InputSPLAlasan.Clear()
            InputSPLPelapor.Clear()
            InputSPLKelas.Clear()

        Catch ex As Exception
            da = New Odbc.OdbcDataAdapter($"INSERT INTO mahasiswa_sp (`NIM`, `NAMA`, `KELAS`, `TANGGAL_SP`, `PELAPOR`, `KODE_SP` ) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tanggalSPT}', '{pelaporSPT}', 'SPT')", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")

            da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPT'", con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "`mahasiswa`")
            DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))


            InputSPLNama.Clear()
            InputSPLNIM.Clear()
            InputSPLAlasan.Clear()
            InputSPLPelapor.Clear()
            InputSPLKelas.Clear()

        End Try


    End Sub

    Private Sub SPTHapus_Click(sender As Object, e As EventArgs) Handles SPTHapus.Click
        selectedRow = DataGridView1.SelectedRows(0).Index
        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
        da = New Odbc.OdbcDataAdapter($"DELETE FROM `mahasiswa_sp` WHERE id = '{selected}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")

        da = New Odbc.OdbcDataAdapter("select id, NIM, NAMA, KELAS, TANGGAL_SP, PELAPOR from mahasiswa_sp where KODE_SP = 'SPT'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        AdminP.Show()
        AdminP.Activate()
        Me.Close()
    End Sub
End Class
