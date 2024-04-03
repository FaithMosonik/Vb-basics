Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.IO

Public Class ObjectDemonstrations
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            ' Change the font name of the TextBox to Garamond
            SampleTestTextBox.Font = New Font("Garamond", SampleTestTextBox.Font.Size, SampleTestTextBox.Font.Style)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            ' Change the font name of the TextBox to Magneto
            SampleTestTextBox.Font = New Font("Magneto", SampleTestTextBox.Font.Size, SampleTestTextBox.Font.Style)
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            ' Change the font name of the TextBox to Tahoma
            SampleTestTextBox.Font = New Font("Tahoma", SampleTestTextBox.Font.Size, SampleTestTextBox.Font.Style)
        End If
    End Sub

    Private Sub ItalicRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicRadioButton.CheckedChanged
        If ItalicRadioButton.Checked Then
            ' Change the font style of the TextBox to Italic
            SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, FontStyle.Italic)
        End If
    End Sub

    Private Sub BoldRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BoldRadioButton.CheckedChanged
        If BoldRadioButton.Checked Then
            ' Change the font style of the TextBox to bold
            SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub BoldItalicRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicRadioButton.CheckedChanged
        If BoldItalicRadioButton.Checked Then
            ' Change the font style of the TextBox to bold italic
            SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, FontStyle.Bold Or FontStyle.Italic)
        End If
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            ' Change the font color to Green
            SampleTestTextBox.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            ' Change the font color to blue
            SampleTestTextBox.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            ' Change the font color to red
            SampleTestTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set the filter to allow only image files
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*"

        ' Display the dialog to the user
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the selected image into the PictureBox               
                PictureBox.Image = Image.FromFile(openFileDialog.FileName)

            Catch ex As Exception
                ' Handle any errors that occur while loading the image
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class