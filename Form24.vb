Public Class Form24
    Private Sub Form24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form20.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Urdu\Marathi\U41.mov")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Urdu\Marathi\U42.mov")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Urdu\Marathi\U43.mov")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Urdu\Marathi\U44.mov")

    End Sub
End Class