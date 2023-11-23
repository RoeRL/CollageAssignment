Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class mahasiswa
    Public loginNama As String
    Public loginNim As String
    Public loginKelas As String
    Public adminNama As String
    Public adminNim As String
    Public adminKelas As String
    Public Sub MahasiswaForm(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        loginNama = LoginForm.selectNameMhs
        loginNim = LoginForm.selectNimMhs
        loginKelas = LoginForm.selectKelasMhs
        adminNama = AdminP.selectNameMhs
        adminNim = AdminP.selectNimMhs
        adminKelas = AdminP.selectKelasMhs

        If adminNama = "" Then
            Label4.Text = loginNama
            Label5.Text = LoginForm.selectNimMhs
            Label6.Text = LoginForm.selectKelasMhs

        ElseIf loginNama = "" Then
            Label4.Text = adminNama
            Label5.Text = adminNim
            Label6.Text = adminKelas
        End If


        da = New Odbc.OdbcDataAdapter($"SELECT COUNT(NIM) as 'JMLH' FROM mahasiswa WHERE KODE_SP = 'SPL' AND NIM = {LoginForm.selectNimMhs Or AdminP.selectNimMhs}", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "`mahasiswa`")
        If ds.Tables(0).Rows(0).Item(0).ToString() > 4 Then
            ProgressBar1.Value = 4
            Label8.Text = "> 4"
        ElseIf ds.Tables(0).Rows(0).Item(0).ToString() < 4 Then
            ProgressBar1.Value = ds.Tables(0).Rows(0).Item(0).ToString()
            Label8.Text = "4"
        End If

        Label10.Text = ds.Tables(0).Rows(0).Item(0).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mahasiswa2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginForm.Activate()
        LoginForm.Show()
        Me.Close()
    End Sub
End Class
