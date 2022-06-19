Imports System.IO
Imports System.Data.OleDb

Public Class Form5

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=enrollment.accdb")

    Private Sub RectangleShape2_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape2.MouseEnter
        RectangleShape2.BackColor = Color.FromArgb(227, 227, 227)
        RectangleShape2.BorderColor = Color.FromArgb(227, 227, 227)
        PictureBox3.BackColor = Color.FromArgb(227, 227, 227)
        Label2.BackColor = Color.FromArgb(227, 227, 227)
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave
        RectangleShape2.BackColor = Color.White
        RectangleShape2.BorderColor = Color.White
        PictureBox3.BackColor = Color.White
        Label2.BackColor = Color.White
    End Sub

    Private Sub RectangleShape3_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape3.MouseEnter
        RectangleShape3.BackColor = Color.FromArgb(227, 227, 227)
        RectangleShape3.BorderColor = Color.FromArgb(227, 227, 227)
        PictureBox4.BackColor = Color.FromArgb(227, 227, 227)
        Label3.BackColor = Color.FromArgb(227, 227, 227)
    End Sub

    Private Sub RectangleShape3_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape3.MouseLeave
        RectangleShape3.BackColor = Color.White
        RectangleShape3.BorderColor = Color.White
        PictureBox4.BackColor = Color.White
        Label3.BackColor = Color.White
    End Sub

    Private Sub RectangleShape4_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape4.MouseEnter
        RectangleShape4.BackColor = Color.FromArgb(227, 227, 227)
        RectangleShape4.BorderColor = Color.FromArgb(227, 227, 227)
        PictureBox5.BackColor = Color.FromArgb(227, 227, 227)
        Label4.BackColor = Color.FromArgb(227, 227, 227)
    End Sub

    Private Sub RectangleShape4_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape4.MouseLeave
        RectangleShape4.BackColor = Color.White
        RectangleShape4.BorderColor = Color.White
        PictureBox5.BackColor = Color.White
        Label4.BackColor = Color.White
    End Sub

    Private Sub RectangleShape5_MouseEnter(sender As Object, e As EventArgs) Handles RectangleShape5.MouseEnter
        RectangleShape5.BackColor = Color.FromArgb(227, 227, 227)
        RectangleShape5.BorderColor = Color.FromArgb(227, 227, 227)
        PictureBox6.BackColor = Color.FromArgb(227, 227, 227)
        Label6.BackColor = Color.FromArgb(227, 227, 227)
    End Sub

    Private Sub RectangleShape5_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape5.MouseLeave
        RectangleShape5.BackColor = Color.White
        RectangleShape5.BorderColor = Color.White
        PictureBox6.BackColor = Color.White
        Label6.BackColor = Color.White
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim a As New Form2
        a.Show()
        Me.Close()
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim a As New Form4
        a.Show()
        Me.Close()
    End Sub

End Class