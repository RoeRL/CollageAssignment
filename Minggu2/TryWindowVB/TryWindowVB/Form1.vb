Public Class Form1
    Private Sub DisplayNIM_Click(sender As Object, e As EventArgs) Handles DisplayNIM.Click
        Form1.ActiveForm.Text = DisplayBox1.Text
    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click
        OutputLabel.Text = DisplayBox1.Text
    End Sub

    Private Sub DisplayTB_Click(sender As Object, e As EventArgs) Handles DisplayTB.Click
        DisplayBox2.Text = DisplayBox1.Text
    End Sub

    Private Sub ChangeColor_Click(sender As Object, e As EventArgs) Handles ChangeColor.Click
        BackColor = Color.AliceBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ActiveForm.Text = DisplayBox1.Text
        OutputLabel.Text = DisplayBox1.Text
        OutputLabel.ForeColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OutputLabel.Text = DisplayBox1.Text & " " & DisplayBox2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OutputLabel.Text = Val(DisplayBox1.Text) * Val(DisplayBox2.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OutputLabel.Text = DisplayBox1.Text
        OutputLabel.ForeColor = Color.Yellow
        OutputLabel.BackColor = Color.Blue
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OutputLabel.Text = (Val(DisplayBox1.Text) * Val(DisplayBox2.Text)) / 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OutputLabel.Text = DisplayBox1.Text & " " & DisplayBox2.Text
        If CheckBox1.Checked Then OutputLabel.Font = New Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Bold)
        If CheckBox2.Checked Then OutputLabel.Font = New Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Italic)
        If CheckBox1.Checked AndAlso CheckBox2.Checked Then OutputLabel.Font = New Font(DefaultFont.FontFamily, DefaultFont.Size, FontStyle.Italic Or FontStyle.Bold)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OutputLabel.Text = DisplayBox1.Text & " " & DisplayBox2.Text
        BackColor = Color.Green
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OutputLabel.Text = DisplayBox1.Text & " " & DisplayBox2.Text
        Button8.BackColor = Color.Blue
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OutputLabel.Text = Val(DisplayBox1.Text) Mod Val(DisplayBox2.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim temporary As Int64 = 1
        For index = 0 To Val(DisplayBox2.Text) + 1
            temporary *= Val(DisplayBox1.Text)
            index += 1
        Next
        OutputLabel.Text = temporary
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OutputLabel.Text = (2 * Val(DisplayBox1.Text)) + (2 * Val(DisplayBox2.Text))
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        DisplayBox1.Text = ""
        DisplayBox2.Text = ""
        OutputLabel.Text = ""
    End Sub
End Class
