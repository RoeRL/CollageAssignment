Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) >= 0 Then ResultLabel.Text = "Positif"
        If Val(TextBox1.Text) < 0 Then ResultLabel.Text = "Negatif"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox1.Text) > 5 Then ResultLabel.Text = "Lebih dari 5"
        If Val(TextBox1.Text) < 5 Then ResultLabel.Text = "Kurang dari 5"
        If Val(TextBox1.Text) = 5 Then ResultLabel.Text = "Sama dengan 5"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Val(TextBox1.Text) > 10 Then ResultLabel.Text = "Lebih dari 10"
        If Val(TextBox1.Text) < 10 Then ResultLabel.Text = "Kurang dari 10"
        If Val(TextBox1.Text) = 10 Then ResultLabel.Text = "Sama dengan 10"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case (Val(TextBox1.Text))
            Case 100
                ResultLabel.Text = "A"
            Case 80
                ResultLabel.Text = "B"
            Case 70
                ResultLabel.Text = "C"
            Case 60
                ResultLabel.Text = "D"
            Case 50
                ResultLabel.Text = "E"
            Case Else
                MsgBox("Nilai tidak terdeteksi", , "Peringatan")
        End Select
    End Sub




    Private Sub SK1_Click(sender As Object, e As EventArgs) Handles SK1.Click
        If Val(TextBox1.Text) Mod 2 = 0 Then ResultLabel.Text = "Genap"
        If Val(TextBox1.Text) Mod 2 = 1 Then ResultLabel.Text = "Ganjil"
    End Sub

    Private Sub SK2_Click(sender As Object, e As EventArgs) Handles SK2.Click
        If Val(TextBox1.Text) Mod 3 = 0 Then ResultLabel.Text = "Kelipatan 3"
        If Val(TextBox1.Text) Mod 3 <> 0 Then ResultLabel.Text = "Bukan Kelipatan 3"
    End Sub

    Private Sub SK3_Click(sender As Object, e As EventArgs) Handles SK3.Click
        If Val(TextBox1.Text) >= 70 Then ResultLabel.Text = "Lulus"
        If Val(TextBox1.Text) < 70 Then ResultLabel.Text = "Tidak Lulus"
    End Sub

    Private Sub SK4_Click(sender As Object, e As EventArgs) Handles SK4.Click
        Dim ratarata As Int16 = (Val(TextBox1.Text) + Val(TextBox2.Text)) / 2
        If (ratarata > 70) Then
            ResultLabel.Text = "Lulus"
            BackColor = Color.Blue
            ResultLabel.ForeColor = Color.Yellow
        Else
            ResultLabel.Text = "Tidak Lulus"
            BackColor = Color.Red
            ResultLabel.ForeColor = Color.White
        End If
    End Sub

    Private Sub SK5_Click(sender As Object, e As EventArgs) Handles SK5.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox1.Text) & "<" & Val(TextBox2.Text)
        If Val(TextBox1.Text) < Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox1.Text) & ">" & Val(TextBox2.Text)
    End Sub

    Private Sub SK6_Click(sender As Object, e As EventArgs) Handles SK6.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox1.Text) & "<" & Val(TextBox2.Text)
        If Val(TextBox1.Text) < Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox1.Text) & ">" & Val(TextBox2.Text)
        If Val(TextBox1.Text) = Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox1.Text) & "=" & Val(TextBox2.Text)

    End Sub

    Private Sub SK7_Click(sender As Object, e As EventArgs) Handles SK7.Click
        Dim ratarata As Int16 = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 2
        If (ratarata > 70) Then
            ResultLabel.Text = "Lulus"
            BackColor = Color.Blue
            ResultLabel.ForeColor = Color.Yellow
        Else
            ResultLabel.Text = "Tidak Lulus"
            BackColor = Color.Red
            ResultLabel.ForeColor = Color.White
        End If
    End Sub

    Private Sub SK8_Click(sender As Object, e As EventArgs) Handles SK8.Click
        If Val(TextBox1.Text) >= 81 AndAlso Val(TextBox1.Text) <= 100 Then ResultLabel.Text = "A"
        If Val(TextBox1.Text) >= 76 AndAlso Val(TextBox1.Text) <= 80 Then ResultLabel.Text = "AB"
        If Val(TextBox1.Text) < 76 Or Val(TextBox1.Text) > 100 Then ResultLabel.Text = "K"
    End Sub

    Private Sub SK9_Click(sender As Object, e As EventArgs) Handles SK9.Click
        Dim ratarata As Int16 = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text)) / 3
        If ratarata >= 81 AndAlso ratarata <= 100 Then ResultLabel.Text = "A"
        If ratarata >= 76 AndAlso ratarata <= 80 Then ResultLabel.Text = "AB"
        If ratarata < 76 Or ratarata > 100 Then ResultLabel.Text = "K"
    End Sub

    Private Sub SK10_Click(sender As Object, e As EventArgs) Handles SK10.Click
        If Val(TextBox1.Text) > Val(TextBox2.Text) AndAlso Val(TextBox1.Text) > Val(TextBox3.Text) Then ResultLabel.Text = Val(TextBox1.Text)
        If Val(TextBox2.Text) > Val(TextBox3.Text) AndAlso Val(TextBox2.Text) > Val(TextBox1.Text) Then ResultLabel.Text = Val(TextBox2.Text)
        If Val(TextBox3.Text) > Val(TextBox1.Text) AndAlso Val(TextBox3.Text) > Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox3.Text)
    End Sub

    Private Sub SK11_Click(sender As Object, e As EventArgs) Handles SK11.Click
        If Val(TextBox1.Text) < Val(TextBox2.Text) AndAlso Val(TextBox1.Text) < Val(TextBox3.Text) Then ResultLabel.Text = Val(TextBox1.Text)
        If Val(TextBox2.Text) < Val(TextBox3.Text) AndAlso Val(TextBox2.Text) < Val(TextBox1.Text) Then ResultLabel.Text = Val(TextBox2.Text)
        If Val(TextBox3.Text) < Val(TextBox1.Text) AndAlso Val(TextBox3.Text) < Val(TextBox2.Text) Then ResultLabel.Text = Val(TextBox3.Text)
    End Sub

    Private Sub SK12_Click(sender As Object, e As EventArgs) Handles SK12.Click
        If Val(TextBox1.Text) = Val(TextBox2.Text) Then ResultLabel.Text = "Input 1 dan 2 sama yaitu: " & Val(TextBox1.Text)
        If Val(TextBox1.Text) = Val(TextBox3.Text) Then ResultLabel.Text = "Input 1 dan 3 sama yaitu: " & Val(TextBox2.Text)
        If Val(TextBox2.Text) = Val(TextBox3.Text) Then ResultLabel.Text = "Input 2 dan 3 sama yaitu: " & Val(TextBox3.Text)
    End Sub
End Class
