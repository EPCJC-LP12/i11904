Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim alfabeto As String = ""
        For i = 65 To 90
            alfabeto += Chr(i)
        Next

        Dim numero As New Random


        Dim senha As String = ""
        senha = numero.Next(0, 9).ToString("0")

        TextBox1.Text = senha

        If senha = 7 Then
            Label2.Visible = False
            PictureBox1.Visible = True
        End If

        If senha <> 7 Then
            Label2.Visible = True
            PictureBox1.Visible = False
        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
