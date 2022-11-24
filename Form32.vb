Public Class Form32
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form31.Show()
        Me.Hide()

    End Sub

    Private Sub Form32_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form33.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form34.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        form35.show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form36.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form37.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form38.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form39.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form40.Show()
        Me.Hide()
    End Sub
End Class