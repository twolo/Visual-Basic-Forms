Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Password Then
            If TextBox2.Text = Nothing Then
                MsgBox("Invalid password.", MsgBoxStyle.OkOnly, "Change password")
            Else
                My.Settings.Password = TextBox2.Text
                My.Settings.Save()
                MsgBox("Done.", MsgBoxStyle.OkOnly, "Change password")
                Close()
            End If
        Else
            MsgBox("Wrong current password.")
        End If
    End Sub
End Class