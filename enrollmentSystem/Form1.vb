Public Class Form1

    
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        If (TextBox1.Text = "admin" And TextBox2.Text = "admin") Then
            Dim a As New Form3
            a.Show()
            Me.Close()
        Else
            PictureBox4.Visible = True
            PictureBox5.Visible = True
        End If


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim a As New frmUser
        a.Show()
        Me.Close()
    End Sub
End Class
