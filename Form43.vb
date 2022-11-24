Public Class Form43
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form42.Show()
        Me.Hide()

    End Sub

    Private Sub Form43_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub
End Class