Public Class Form1
    Private Sub ButFor1_Click(sender As Object, e As EventArgs) Handles ButFor1.Click
        Dim x As Integer
        For x = 1 To 5
            Res.Items.Add("ABC")
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim i As Integer = 1
        While i <= 5
            Res.Items.Add("ABC")
            i += 1
        End While
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim i As Integer = 1
        Do
            Res.Items.Add("ABC")
            i += 1
        Loop While i <= 5
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            Res.Items.Add(a & " aaaa")
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a = 1 Then Res.Items.Add(" * ")
            If a <> 1 Then Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a = Val(Inp.Text) Then Res.Items.Add(" x ")
            If a <> Val(Inp.Text) Then Res.Items.Add(a)
        Next
    End Sub

    'Study Case'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a Mod 2 = 0 Then Res.Items.Add("*")
            If a Mod 2 <> 0 Then Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a Mod 2 = 1 Then Res.Items.Add("*")
            If a Mod 2 <> 1 Then Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a = Val(Inp.Text) Or a = 1 Then
                Res.Items.Add("*")
            Else Res.Items.Add(a)
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a = Val(Inp.Text) - 1 Then
                Res.Items.Add("*")
            Else Res.Items.Add(a)
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mid As Integer = Val(Inp.Text) / 2
        Res.Items.Clear()
        For index = 1 To Val(Inp.Text)
            If Val(Inp.Text) Mod 2 = 0 Then
                If index = mid Or index = mid + 1 Then Res.Items.Add("*") Else Res.Items.Add(index)
            End If
            If Val(Inp.Text) Mod 2 <> 0 Then
                If index = ((Val(Inp.Text) - 1) / 2) + 1 Then Res.Items.Add("*") Else Res.Items.Add(index)
            End If
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Res.Items.Clear()
        For a = 1 To Val(Inp.Text)
            If a Mod 3 = 0 Then Res.Items.Add("*") Else Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Res.Items.Clear()
        For a = 1 To Val(Inp.Text)
            If a = 1 Or a = Val(Inp.Text) - 1 Then Res.Items.Add("*") Else Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a = Val(Inp.Text) Or a = 1 Then
                Res.Items.Add(a)
            Else Res.Items.Add("*")
            End If
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If Val(Inp.Text) Mod 2 = 0 Then If a = Val(Inp.Text) Or a = 1 Or a = Val(Inp.Text) / 2 Or a = (Val(Inp.Text) / 2) + 1 Then Res.Items.Add(a) Else Res.Items.Add("*")
            If Val(Inp.Text) Mod 2 <> 0 Then If a = Val(Inp.Text) Or a = 1 Or a = ((Val(Inp.Text) - 1) / 2) + 1 Then Res.Items.Add(a) Else Res.Items.Add("*")
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a <= 5 Then Res.Items.Add(a) Else Res.Items.Add("*")
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Res.Items.Clear()
        Dim temp As Integer = 1
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a Mod 3 = 0 Then Res.Items.Add(a * 2) Else Res.Items.Add(a)
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Res.Items.Clear()
        Dim a As Integer
        For a = 1 To Val(Inp.Text)
            If a <= 5 Then
                Res.Items.Add(Chr(a + 64))
            Else Res.Items.Add(a)
            End If
        Next
    End Sub
End Class
