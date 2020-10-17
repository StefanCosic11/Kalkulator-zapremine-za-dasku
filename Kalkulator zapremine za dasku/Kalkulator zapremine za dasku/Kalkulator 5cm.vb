Public Class Form1
    Dim suma As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Double
        y = (Val(TextBox1.Text) / 100) * (Val(TextBox2.Text) / 100) * 0.05
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class
