Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U61.mov")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U62.mov")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U63.mov")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U64.mov")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U65.mov")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U66.mov")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U67.mov")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U68.mov")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U69.mov")
    End Sub
End Class