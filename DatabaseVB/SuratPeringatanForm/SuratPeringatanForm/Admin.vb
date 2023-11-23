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
        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa` where KODE_SP = 'SPL'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))

        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa` where KODE_SP = 'SPT'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))
    End Sub

    Private Sub SPLKirim_Click(sender As Object, e As EventArgs) Handles SPLKirim.Click
        nimMhs = InputSPLNIM.Text
        namaMhs = InputSPLNama.Text
        kelasMhs = InputSPLKelas.Text
        tipeSP = "SPL"
        alasanSP = InputSPLAlasan.Text
        pelaporSPL = InputSPLPelapor.Text
        tanggalSPL = InputSPTDate.Text


        da = New Odbc.OdbcDataAdapter($"INSERT INTO `mahasiswa` (`NIM`, `NAMA`, `KELAS`, `KODE_SP`, `ALASAN`, `PELAPOR`, `TANGGAL`) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tipeSP}', '{alasanSP}', '{pelaporSPL}', '{tanggalSPL}')", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))

        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa` where KODE_SP = 'SPL'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
        InputSPLNama.Clear()
        InputSPLNIM.Clear()
        InputSPLAlasan.Clear()
        InputSPLPelapor.Clear()
        InputSPLKelas.Clear()
    End Sub


    Private Sub SPLHapus_Click(sender As Object, e As EventArgs) Handles SPLHapus.Click
        selectedRow = DataGridView1.SelectedRows(0).Index
        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
        da = New Odbc.OdbcDataAdapter($"DELETE FROM `mahasiswa` WHERE NIM = '{selected}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")

        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa`", con)
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
        tanggalSPT = InputSPTDate.Text


        da = New Odbc.OdbcDataAdapter($"INSERT INTO `mahasiswa` (`NIM`, `NAMA`, `KELAS`, `KODE_SP`, `ALASAN`) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tipeSP}', '{alasanSP}')", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))

        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa` where KODE_SP = 'SPT'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))


        InputSPTNama.Clear()
        InputSPTNIM.Clear()
        InputSPTAlasan.Clear()
        InputSPTPelapor.Clear()
        InputSPTKelas.Clear()
    End Sub

    Private Sub SPTHapus_Click(sender As Object, e As EventArgs) Handles SPTHapus.Click
        selectedRow = DataGridView1.SelectedRows(0).Index
        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
        da = New Odbc.OdbcDataAdapter($"DELETE FROM `mahasiswa` WHERE NIM = '{selected}'", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")

        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa`", con)
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
