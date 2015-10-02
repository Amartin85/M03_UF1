Public Class Form1
    Dim op1 As Integer = 0
    Dim op2 As Integer = 0
    Dim resultado As Integer


    Private Sub sumaBtn_Click(sender As Object, e As EventArgs) Handles sumaBtn.Click


        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 + op2

        Label1.Text = resultado.ToString()

    End Sub

    Private Sub RestaBtn_Click(sender As Object, e As EventArgs) Handles RestaBtn.Click
        op1 = CInt(TextBox1.Text)
        op2 = CInt(TextBox2.Text)

        resultado = op1 - op2

        Label1.Text = resultado.ToString()
    End Sub
End Class
