Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO

Public Class DetailMahasiswa
    Public adminNama As String
    Public adminNim As String
    Public adminKelas As String
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        adminNama = AdminP.selectNameMhs
        adminNim = AdminP.selectNimMhs
        adminKelas = AdminP.selectKelasMhs


        If adminNama = "" Then
            Label1.Text = uipertemuan.temporaryNama
            Label2.Text = uipertemuan.temporaryNIM
            Label3.Text = uipertemuan.temporaryKelas

        ElseIf uipertemuan.temporaryNama = "" Then
            Label1.Text = adminNama
            Label2.Text = adminNim
            Label3.Text = adminKelas
        End If


        da = New Odbc.OdbcDataAdapter($"SELECT COUNT(NIM) as 'JMLH' FROM mahasiswa_sp WHERE KODE_SP = 'SPL' AND NIM = {adminNim Or uipertemuan.temporaryNIM}", con)
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
        da = New Odbc.OdbcDataAdapter($"INSERT INTO `pertemuan` (`NIM`, `TANGGAL_PERTEMUAN`) VALUES ('{adminNim}', '{DateTimePicker1.Text}')", con)
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