Public Class Form13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Reg.TextBox3.Text
        TextBox2.Text = Reg.TextBox4.Text
        TextBox3.Text = Reg.TextBox5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U71.mov")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U72.mov")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U73.mov")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U74.mov")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U75.mov")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("C:\kktech\Class1\Marathi\English\U76.mov")
    End Sub
End Class