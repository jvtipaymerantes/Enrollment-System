Imports System.IO
Imports System.Data.OleDb

Public Class frmDetails

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=enrollment.accdb")

    Public studentNumber As String

    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtStudentNumber.Text = studentNumber

        con.Open()

        Dim sql As String

        sql = "Select * from tblStudent where studentNumber='" + studentNumber + "' "

        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        myreader.Read()

        txtFname.Text = myreader("fname")
        txtMname.Text = myreader("mname")
        txtLname.Text = myreader("lname")
        txtCourse.Text = myreader("course")
        txtBday.Text = myreader("birthmonth")
        txtContact.Text = myreader("contactNumber")
        txtAddress.Text = myreader("address")


        con.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub


End Class