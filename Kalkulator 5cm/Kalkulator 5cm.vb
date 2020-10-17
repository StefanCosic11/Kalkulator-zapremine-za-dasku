Public Class Form1
    Dim suma As Double
    Dim a, b, c As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Double
        If RadioButton1.Checked Then
            y = (Val(TextBox1.Text) / 100) * (Val(TextBox2.Text) / 100) * 0.03

        ElseIf RadioButton2.Checked Then
            y = (Val(TextBox1.Text) / 100) * (Val(TextBox2.Text) / 100) * 0.04
        ElseIf RadioButton3.Checked Then
            y = (Val(TextBox1.Text) / 100) * (Val(TextBox2.Text) / 100) * 0.05

        End If

        suma += y

        TextBox4.Text = suma
        TextBox5.Text = suma * 650
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
        suma = 0
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
