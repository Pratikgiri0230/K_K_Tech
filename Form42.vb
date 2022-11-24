Public Class Form42
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form31.Show()
        Me.Hide()

    End Sub

    Private Sub Form42_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form43.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        form44.show()
    End Sub
End Class