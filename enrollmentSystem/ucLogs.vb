Public Class ucLogs


    Private Sub ucLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ucLogs_Click(sender As Object, e As EventArgs) Handles MyBase.Click

        frmDetails.studentNumber = ucSn.Text

        frmDetails.Show()


    End Sub

End Class
