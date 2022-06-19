<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLogs
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ucName = New System.Windows.Forms.TextBox()
        Me.ucSn = New System.Windows.Forms.TextBox()
        Me.ucCourse = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(30, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 1)
        Me.Panel1.TabIndex = 10
        '
        'ucName
        '
        Me.ucName.BackColor = System.Drawing.Color.White
        Me.ucName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ucName.Enabled = False
        Me.ucName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucName.Location = New System.Drawing.Point(204, 15)
        Me.ucName.Name = "ucName"
        Me.ucName.Size = New System.Drawing.Size(337, 14)
        Me.ucName.TabIndex = 16
        Me.ucName.Text = "Student Name"
        Me.ucName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ucSn
        '
        Me.ucSn.BackColor = System.Drawing.Color.White
        Me.ucSn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ucSn.Enabled = False
        Me.ucSn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucSn.Location = New System.Drawing.Point(13, 15)
        Me.ucSn.Name = "ucSn"
        Me.ucSn.Size = New System.Drawing.Size(185, 14)
        Me.ucSn.TabIndex = 17
        Me.ucSn.Text = "Student Number"
        '
        'ucCourse
        '
        Me.ucCourse.BackColor = System.Drawing.Color.White
        Me.ucCourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ucCourse.Enabled = False
        Me.ucCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucCourse.Location = New System.Drawing.Point(547, 15)
        Me.ucCourse.Name = "ucCourse"
        Me.ucCourse.Size = New System.Drawing.Size(260, 14)
        Me.ucCourse.TabIndex = 18
        Me.ucCourse.Text = "Course"
        Me.ucCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ucLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ucCourse)
        Me.Controls.Add(Me.ucSn)
        Me.Controls.Add(Me.ucName)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ucLogs"
        Me.Size = New System.Drawing.Size(820, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ucName As System.Windows.Forms.TextBox
    Friend WithEvents ucSn As System.Windows.Forms.TextBox
    Friend WithEvents ucCourse As System.Windows.Forms.TextBox

End Class
