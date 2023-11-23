Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To 5
            Dim var_z As String = " "
            For y = 1 To 5
                var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To 5
            Dim var_z As String = " "
            For y = 1 To 5
                var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        Dim nilai As Integer = 0
        For x = 1 To Val(tb.Text)
            Dim var_z As String = " "
            For y = 1 To Val(tb.Text)
                nilai += 1
                var_z = var_z & Str(nilai) & vbTab
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        Dim akhir As String = tb.Text
        For x = 1 To akhir
            Dim var_z As String = " "
            For y = 1 To akhir
                If x Mod 2 = 1 Then
                    var_z = var_z & vbTab & y
                Else
                    var_z = var_z & vbTab & akhir
                    akhir -= 1
                End If
            Next
            akhir = tb.Text
            lb.Items.Add(var_z)

        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        Dim akhir As String = tb.Text
        For x = 1 To akhir
            Dim var_z As String = " "
            For y = 1 To akhir
                If x Mod 2 = 1 Then
                    If y = 1 Or y = tb.Text Then var_z = var_z & vbTab & "*" Else var_z = var_z & vbTab & y
                Else
                        var_z = var_z & vbTab & akhir
                    akhir -= 1
                End If
            Next
            akhir = tb.Text
            lb.Items.Add(var_z)

        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y Mod 2 = 0 Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y Mod 2 = 1 Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If x Mod 2 = 0 Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If x = 1 Or x = tb.Text Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y = 1 Or y = tb.Text Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y = 1 Or y = tb.Text Or x = 1 Or x = tb.Text Then var_z = var_z & "  *" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y = 1 Or y = tb.Text Or x = 1 Or x = tb.Text Then var_z = var_z & "* " Else var_z = var_z & "  "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If Val(tb.Text) Mod 2 = 1 Then
                    If x = ((tb.Text - 1) / 2) + 1 Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
                End If
                If Val(tb.Text) Mod 2 = 0 Then
                    If x = tb.Text / 2 Or x = tb.Text / 2 + 1 Then var_z = var_z & "*" & " " Else var_z = var_z & Str(y) & " "
                End If
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To x
                var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text - x
                var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y = 1 Or x = tb.Text Then var_z = var_z & "  *" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        lb.Items.Clear()
        Dim x As Integer
        Dim y As Integer
        For x = 1 To tb.Text
            Dim var_z As String = " "
            For y = 1 To tb.Text
                If y = tb.Text Or x = 1 Then var_z = var_z & "  *" & " " Else var_z = var_z & Str(y) & " "
            Next
            lb.Items.Add(var_z)
        Next
    End Sub
End Class
