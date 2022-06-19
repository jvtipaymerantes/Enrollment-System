Imports System.IO
Imports System.Data.OleDb

Public Class frmUser

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

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim a As New Form2
        a.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
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

        sql = "select * from tblStudent where studentNumber LIKE '%" + txtSearch.Text + "%' OR fname LIKE '%" + txtSearch.Text + "%' OR lname LIKE '%" + txtSearch.Text + "%'"
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

        sql = "select * from tblStudent where studentNumber LIKE '%" + txtSearch.Text + "%' OR fname LIKE '%" + txtSearch.Text + "%' OR lname LIKE '%" + txtSearch.Text + "%' "
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

        sql = "select * from tblStudent where course='" + ComboBox1.Text + "'"
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

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim a As New Form5
        a.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        Dim a As New Form1
        a.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim a As New Form1
        a.Show()
        Me.Close()
    End Sub
End Class