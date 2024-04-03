Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ObjectDemonstrations.Show()
        Me.Hide()
    End Sub

    Private Sub TextButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized
        ' Change background color to red
        Me.BackColor = Color.Red
    End Sub
End Class
