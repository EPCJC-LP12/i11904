Public Class Form1
    Dim n1 As Double
    Dim n2 As Double

    Private Function soma() As Double
        Dim s As Double = n1 + n2
        Return s
    End Function

    Private Function subt() As Double
        Dim subtracao As Double = n1 - n2
        Return subtracao
    End Function
    Private Function mult() As Double
        Dim multi As Double = n1 * n2
        Return multi
    End Function

    Private Function div() As Double
        Dim divi As Double = n1 / n2
        Return divi
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n1 = CDbl(TextBox1.Text)
        n2 = CDbl(TextBox2.Text)
        Me.Label2.Text = "+"
        Me.TextBox3.Text = soma()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        n1 = CDbl(TextBox1.Text)
        n2 = CDbl(TextBox2.Text)
        Me.Label2.Text = "-"
        Me.TextBox3.Text = subt()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        n1 = CDbl(TextBox1.Text)
        n2 = CDbl(TextBox2.Text)
        Me.Label2.Text = "*"
        Me.TextBox3.Text = mult()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        n1 = CDbl(TextBox1.Text)
        n2 = CDbl(TextBox2.Text)
        Me.Label2.Text = "/"
        Me.TextBox3.Text = div()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class