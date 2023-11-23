Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a As Integer = 1 To Val(TextBox1.Text)
            Dim temp As String = " "
            If a = 1 Or a = ((Val(TextBox1.Text) - 1) / 2) + 1 Then
                For b As Integer = 1 To Val(TextBox1.Text)
                    temp = temp & "*" & " "
                Next
                ListBox1.Items.Add(temp)
            Else
                ListBox1.Items.Add("*")
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        For x = 1 To Val(TextBox1.Text)
            Dim var_z As String = " "
            Dim var_a As String = " "
            Dim var_bb As String = " "
            If x = 1 Or x = Val(TextBox1.Text) Then
                var_z &= " "
                For y = 1 To Val(TextBox1.Text)
                    var_z = var_z & " *"
                Next
                ListBox2.Items.Add(var_z)
                ListBox3.Items.Add(var_z)

            Else
                For z = 1 To Val(TextBox1.Text)
                    If x < ((Val(TextBox1.Text) - 1) / 2) + 1 Then
                        If z = 1 Then var_bb = var_bb & "*" Else var_bb = var_bb & " " & "  "
                    End If
                    If x > ((Val(TextBox1.Text) - 1) / 2) + 1 Then
                        If z = Val(TextBox1.Text) Or z = 1 Then var_bb = var_bb & "*" Else var_bb = var_bb & " " & "  "
                    End If
                    If z = Val(TextBox1.Text) Or z = 1 Then var_a = var_a & "*" Else var_a = var_a & " " & "  "
                Next
                ListBox2.Items.Add(var_a)
                ListBox3.Items.Add(var_bb)



            End If

            If x = ((Val(TextBox1.Text) - 1) / 2) + 1 Then
                For b As Integer = 1 To Val(TextBox1.Text)
                    var_bb = var_bb & "*" & " "
                Next
                ListBox3.Items.Add(var_bb)
            End If

        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) Mod 2 = 0 Or Val(TextBox1.Text) < 5 Then MsgBox("Angka harus diatas 5 dan Ganjil!", , "Alert!!!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        TextBox1.Clear()
    End Sub
End Class
