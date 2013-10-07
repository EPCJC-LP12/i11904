Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim alfabeto As String = ""
        For i = 65 To 90
            alfabeto += Chr(i)
        Next

        Dim numero As New Random


        Dim senha1 As String = ""
        senha1 = numero.Next(0, 9).ToString("0")

        TextBox1.Text = senha1

        Dim senha2 As String = ""
        senha2 = numero.Next(0, 9).ToString("0")

        TextBox2.Text = senha2

        Dim senha3 As String = ""
        senha3 = numero.Next(0, 9).ToString("0")

        TextBox3.Text = senha3


        If senha1 = 7 Or senha2 = 7 Or senha3 = 7 Then
            PictureBox1.Visible = True
            Label2.Visible = False
        Else
            PictureBox1.Visible = False
            Label2.Visible = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
