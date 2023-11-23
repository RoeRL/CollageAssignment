'Imports System.Security.Cryptography.X509Certificates

'Public Class HomeAdmin
'    Public namaMhs As String
'    Public nimMhs As String
'    Public kelasMhs As String
'    Public tipeSP As String
'    Public alasanSP As String
'    Public selected As String
'    Public selectedRow As Integer
'    Public selectNameMhs As String
'    Public selectKelasMhs As String
'    Public selectNimMhs As String

'    Private Sub Home_Admin(sender As Object, e As EventArgs) Handles MyBase.Load

'        Konek()
'        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa`", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")
'        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))


'        Label1.Text = "ADMIN SIDE"
'        Label1.Font = New Font("SegoeUI", 14)
'        Label2.Text = "INPUT DATA"
'        Label2.Font = New Font("SegoeUI", 11)



'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        nimMhs = TextBox1.Text
'        namaMhs = TextBox2.Text
'        kelasMhs = TextBox3.Text
'        tipeSP = TextBox4.Text
'        alasanSP = TextBox5.Text

'        da = New Odbc.OdbcDataAdapter($"INSERT INTO `mahasiswa` (`NIM`, `NAMA`, `KELAS`, `KODE_SP`, `ALASAN`) VALUES ('{nimMhs}', '{namaMhs}', '{kelasMhs}', '{tipeSP}', '{alasanSP}')", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")
'        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))

'        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa`", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")
'        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
'        TextBox1.Clear()
'        TextBox2.Clear()
'        TextBox3.Clear()
'        TextBox4.Clear()
'        TextBox5.Clear()

'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        selectedRow = DataGridView1.SelectedRows(0).Index
'        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
'        da = New Odbc.OdbcDataAdapter($"DELETE FROM `mahasiswa` WHERE NIM = '{selected}'", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")

'        da = New Odbc.OdbcDataAdapter("select NIM, NAMA, KELAS, KODE_SP from `mahasiswa`", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")
'        DataGridView1.DataSource = (ds.Tables("`mahasiswa`"))
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'        da = New Odbc.OdbcDataAdapter("SELECT NIM, NAMA, COUNT(NIM) as 'Jumlah SP Lisan' FROM mahasiswa WHERE KODE_SP = 'SPL' GROUP BY (NIM) HAVING COUNT(NIM) > 1", con)
'        ds = New DataSet
'        ds.Clear()
'        da.Fill(ds, "`mahasiswa`")
'        DataGridView2.DataSource = (ds.Tables("`mahasiswa`"))
'    End Sub

'    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
'        selectedRow = DataGridView1.SelectedRows(0).Index
'        selected = ds.Tables(0).Rows(selectedRow).Item(0).ToString()
'        selectNameMhs = ds.Tables(0).Rows(selectedRow).Item(1).ToString()
'        selectKelasMhs = ds.Tables(0).Rows(selectedRow).Item(2).ToString()
'        selectNimMhs = ds.Tables(0).Rows(selectedRow).Item(0).ToString()

'        DetailMahasiswa.Show()
'        Me.Hide()
'    End Sub

'    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
'        Admin.Show()
'        Me.Hide()
'    End Sub
'End Class
