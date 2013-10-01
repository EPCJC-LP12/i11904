Public Class Form1
    Dim conViagem As Double
    Dim custViagem As Double

    Private Sub calcular()
        Dim preco As Double = CDbl(TextBox1.Text)
        Dim consumo As Double = CDbl(TextBox2.Text)
        Dim distancia As Double = CDbl(TextBox3.Text)

        conViagem = (consumo * distancia) / 100
        custViagem = preco * conViagem
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        calcular()
        Me.TextBox4.Text = conViagem
        Me.TextBox5.Text = custViagem


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
