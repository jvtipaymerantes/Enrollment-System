Imports System.IO
Imports System.Data.OleDb

Public Class Form4

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=enrollment.accdb")

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()


        Dim sql As String
        Dim name As New System.Text.StringBuilder


        sql = "Select studentNumber, fname, mname, lname, course from tblStudent"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            name.Append(myreader("fname").ToString())
            name.Append(" ")
            name.Append(myreader("mname").ToString())
            name.Append(" ")
            name.Append(myreader("lname").ToString())

            Dim uc As New ucLogs
            uc.ucSn.Text = myreader("studentNumber")
            uc.ucName.Text = name.ToString()
            uc.ucCourse.Text = myreader("course")

            Me.FlowLayoutPanel1.Controls.Add(uc)

            name.Clear()

        End While

        con.Close()

    End Sub

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


    Private Sub RectangleShape1_MouseEnter_1(sender As Object, e As EventArgs) Handles RectangleShape1.MouseEnter
        RectangleShape1.BackColor = Color.FromArgb(227, 227, 227)
        RectangleShape1.BorderColor = Color.FromArgb(227, 227, 227)
        PictureBox1.BackColor = Color.FromArgb(227, 227, 227)
        Label1.BackColor = Color.FromArgb(227, 227, 227)
    End Sub

    Private Sub RectangleShape1_MouseLeave_1(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave
        RectangleShape1.BackColor = Color.White
        RectangleShape1.BorderColor = Color.White
        PictureBox1.BackColor = Color.White
        Label1.BackColor = Color.White
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim a As New Form3
        a.Show()
        Me.Close()
    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs) Handles RectangleShape8.Click
        Dim uc As New ucLogs
        Me.FlowLayoutPanel1.Controls.Add(uc)
    End Sub

    Private Sub txtMname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        FlowLayoutPanel1.Controls.Clear()

        con.Open()

        Dim sql As String
        Dim name As New System.Text.StringBuilder

        sql = "select * from tblStudent where studentNumber LIKE '%" + txtSearch.Text + "%' OR lname LIKE '%" + txtSearch.Text + "%'"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            name.Append(myreader("fname").ToString())
            name.Append(" ")
            name.Append(myreader("mname").ToString())
            name.Append(" ")
            name.Append(myreader("lname").ToString())

            Dim uc As New ucLogs
            uc.ucSn.Text = myreader("studentNumber")
            uc.ucName.Text = name.ToString()
            uc.ucCourse.Text = myreader("course")

            Me.FlowLayoutPanel1.Controls.Add(uc)

            name.Clear()

        End While

        con.Close()
    End Sub

    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        txtSearch.Text = "Search Room"
        FlowLayoutPanel1.Controls.Clear()

        con.Open()

        Dim sql As String
        Dim name As New System.Text.StringBuilder

        sql = "Select studentNumber, fname, mname, lname, course from tblStudent"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            name.Append(myreader("fname").ToString())
            name.Append(" ")
            name.Append(myreader("mname").ToString())
            name.Append(" ")
            name.Append(myreader("lname").ToString())

            Dim uc As New ucLogs
            uc.ucSn.Text = myreader("studentNumber")
            uc.ucName.Text = name.ToString()
            uc.ucCourse.Text = myreader("course")

            Me.FlowLayoutPanel1.Controls.Add(uc)

            name.Clear()

        End While

        con.Close()
    End Sub

    Private Sub txtSearch_ModifiedChanged(sender As Object, e As EventArgs) Handles txtSearch.ModifiedChanged
        FlowLayoutPanel1.Controls.Clear()

        con.Open()

        Dim sql As String
        Dim name As New System.Text.StringBuilder

        sql = "select * from tblStudent where studentNumber LIKE '%" + txtSearch.Text + "%' OR lname LIKE '%" + txtSearch.Text + "%'"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            name.Append(myreader("fname").ToString())
            name.Append(" ")
            name.Append(myreader("mname").ToString())
            name.Append(" ")
            name.Append(myreader("lname").ToString())

            Dim uc As New ucLogs
            uc.ucSn.Text = myreader("studentNumber")
            uc.ucName.Text = name.ToString()
            uc.ucCourse.Text = myreader("course")

            Me.FlowLayoutPanel1.Controls.Add(uc)

            name.Clear()

        End While

        con.Close()
    End Sub


    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        FlowLayoutPanel1.Controls.Clear()

        con.Open()

        Dim sql As String
        Dim name As New System.Text.StringBuilder

        sql = "select * from tblStudent where course='" + ComboBox1.Text +"'"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            name.Append(myreader("fname").ToString())
            name.Append(" ")
            name.Append(myreader("mname").ToString())
            name.Append(" ")
            name.Append(myreader("lname").ToString())

            Dim uc As New ucLogs
            uc.ucSn.Text = myreader("studentNumber")
            uc.ucName.Text = name.ToString()
            uc.ucCourse.Text = myreader("course")

            Me.FlowLayoutPanel1.Controls.Add(uc)

            name.Clear()

        End While

        con.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim a As New Form5
        a.Show()
        Me.Close()
    End Sub
End Class