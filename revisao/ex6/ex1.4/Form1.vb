Public Class Form1

    Private lim As Integer = 100


    Private Sub Gerar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim randomico As New Random()
        Dim numero As Double = randomico.Next(0, lim)

        Dim contar As Integer
        Dim palpite As Integer = -1

        While (numero <> palpite)
            palpite = CDbl(InputBox("Qual o seu palpite?"))

            If numero = palpite Then
                MessageBox.Show("Acertou!!!!")

            ElseIf numero < palpite Then
                MessageBox.Show("Palpite Alto!")

            ElseIf numero > palpite Then
                MessageBox.Show("Palpite Baixo!")
            End If
            contar = contar + 1

        End While
        TextBox1.Text = contar
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        lim = 100
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        lim = 1000
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
