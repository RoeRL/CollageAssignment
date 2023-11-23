Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class LoginForm
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
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Konek()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox2.Text = "admin" Then
                AdminP.Activate()
                AdminP.Show()
                Me.Hide()

            Else
                da = New Odbc.OdbcDataAdapter($"select NIM, NAMA, KELAS from `main_mahasiswa` where NIM = '{TextBox2.Text}'", con)
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "`main_mahasiswa`")
                selectNameMhs = ds.Tables(0).Rows(0).Item(1).ToString()
                selectKelasMhs = ds.Tables(0).Rows(0).Item(2).ToString()
                selectNimMhs = ds.Tables(0).Rows(0).Item(0).ToString()

                mahasiswa.Activate()
                mahasiswa.Show()
                Me.Hide()

            End If
            TextBox2.Text = ""

        Catch ex As Exception
            MsgBox("User ID Tidak dapat ditemukan")
        End Try


    End Sub
End Class