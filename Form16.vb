Public Class Form16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form17.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form18.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form14.Show()
        Me.Hide()
    End Sub
End Class