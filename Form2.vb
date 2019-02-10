Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Invalid password.", MsgBoxStyle.OkOnly, "Signin")
        Else
            My.Settings.Password = TextBox1.Text
            My.Settings.Save()
            Close()
        End If
    End Sub
End Class