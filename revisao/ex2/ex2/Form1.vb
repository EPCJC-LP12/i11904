Public Class Form1

    Dim n1 As Double = CDbl(TextBox1.Text)
    Dim n2 As Double = CDbl(TextBox2.Text)

    Private Sub soma()
        Dim soma As Double = n1 + n2
    End Sub
    Private Sub subt()
        Dim subt As Double = n1 - n2
    End Sub
    Private Sub mult()
        Dim mult As Double = n1 * n2
    End Sub
    Private Sub div()
        Dim div As Double = n1 / n2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox3.Text = n1 + n2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox3.Text = n1 - n2
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TextBox3.Text = n1 * n2
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.TextBox3.Text = n1 / n2
    End Sub
End Class
