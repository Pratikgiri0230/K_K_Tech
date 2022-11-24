Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (TextBox1.Text = Reg.TextBox1.Text And TextBox2.Text = Reg.TextBox2.Text And ComboBox1.Text = "User") Then
            Home.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Admin" And TextBox2.Text = "Admin" And ComboBox1.Text = "Admin") Then
            Reg.Show()
            Me.Hide()

        Else
            MessageBox.Show("Please enter corret Id and Password ")




        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reg.TextBox1.Text = "KKTECH"
        Reg.TextBox2.Text = "KKTECH123"
        Reg.TextBox3.Text = ""
        Reg.TextBox4.Text = "K. K. TECHNOLOGY"
        Reg.TextBox5.Text = ""


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
