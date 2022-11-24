
Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If MessageBox.Show("DO YOU WANT confirn ", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Login.Show()
            Me.Hide()


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub






    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        C1.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class