Imports System.IO
Imports System.Data.OleDb

Public Class Form2

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=enrollment.accdb")


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sn As String

        con.Open()

        Dim strsql As String
        strsql = "Select Count(*) from tblStudent"
        Dim cmd As New OleDbCommand(strsql, con)

        Dim vaccantCount As Int32 = 0
        vaccantCount = Convert.ToInt32(cmd.ExecuteScalar())
        sn = vaccantCount.ToString

        Dim year As String = String.Format("{0:yyyy}", DateTime.Now)

        Dim snFinal As New System.Text.StringBuilder
        snFinal.Append(year.ToString())
        snFinal.Append(sn.ToString())

        txtStudentNumber.Text = snFinal.ToString()

        con.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

        If (txtFname.Text = "" Or txtLname.Text = "" Or txtMname.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or cmbCourse.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "") Then
            MsgBox("Error")
        Else

            createData()

            Dim a As New Form3
            a.Show()
            Me.Close()

        End If

    End Sub

    Private Sub createData()

        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim i As Integer

        Dim bday As New System.Text.StringBuilder
        bday.Append(ComboBox1.Text + " ")
        bday.Append(ComboBox2.Text + " ")
        bday.Append(ComboBox3.Text)



        Try
            con.Open()
            sql = "Insert into tblStudent (studentNumber, fname, mname, lname, course, birthmonth, contactNumber, address) values ('" & txtStudentNumber.Text & "', '" & txtFname.Text & "', '" & txtMname.Text & "', '" & txtLname.Text & "', '" & cmbCourse.Text & "', '" & bday.ToString() & "', '" & txtContact.Text & "', '" & txtAddress.Text & "')"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Inserted")
            Else
                MsgBox("Error")
            End If


        Catch ex As Exception

        End Try

        con.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim a As New Form3
        a.Show()
        Me.Close()
    End Sub

End Class