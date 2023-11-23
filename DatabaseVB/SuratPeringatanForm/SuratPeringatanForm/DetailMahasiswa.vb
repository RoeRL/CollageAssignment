Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO

Public Class DetailMahasiswa
    Public loginNama As String
    Public loginNim As String
    Public loginKelas As String
    Public adminNama As String
    Public adminNim As String
    Public adminKelas As String
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        adminNama = AdminP.selectNameMhs
        adminNim = AdminP.selectNimMhs
        adminKelas = AdminP.selectKelasMhs
        Label1.Text = loginNama
        Label2.Text = LoginForm.selectNimMhs
        Label3.Text = LoginForm.selectKelasMhs


            da = New Odbc.OdbcDataAdapter($"SELECT COUNT(NIM) as 'JMLH' FROM mahasiswa WHERE KODE_SP = 'SPL' AND NIM = {LoginForm.selectNimMhs Or AdminP.selectNimMhs}", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        If ds.Tables(0).Rows(0).Item(0).ToString() > 4 Then
            ProgressBar1.Value = 4
            Label6.Text = "> 4"
        ElseIf ds.Tables(0).Rows(0).Item(0).ToString() < 4 Then
            ProgressBar1.Value = ds.Tables(0).Rows(0).Item(0).ToString()
        End If

        Label5.Text = ds.Tables(0).Rows(0).Item(0).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminP.Show()
        AdminP.Activate()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da = New Odbc.OdbcDataAdapter($"INSERT INTO `pertemuan` (`NIM`, `TANGGAL`) VALUES ('{adminNim Or loginNim}', '{DateTimePicker1.Text}')", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        MsgBox("Berhasil Mengirim")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        uipertemuan.Activate()
        uipertemuan.Show()
        Me.Close()
    End Sub
End Class