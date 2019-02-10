Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.Password = Nothing 'Reset
        If My.Settings.Password = Nothing Then
            Form2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If My.Settings.Password = Nothing Then
            TextBox1.Text = "0"
        End If

        If Not TextBox1.Text = My.Settings.Password Then
            MsgBox("Access denied.")
        Else
            'Anything
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
    End Sub
End Class
