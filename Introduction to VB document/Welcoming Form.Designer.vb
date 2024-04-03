<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoadButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadButton
        ' 
        LoadButton.Location = New Point(179, 192)
        LoadButton.Name = "LoadButton"
        LoadButton.Size = New Size(222, 70)
        LoadButton.TabIndex = 0
        LoadButton.Text = "Load Object Demo"
        LoadButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(424, 192)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(220, 70)
        ExitButton.TabIndex = 1
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 474)
        Controls.Add(ExitButton)
        Controls.Add(LoadButton)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadButton As Button
    Friend WithEvents ExitButton As Button

End Class
