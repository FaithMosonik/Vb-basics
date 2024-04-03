<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label1 = New Label()
        DisplayTestGroupBox = New GroupBox()
        SampleTestTextBox = New TextBox()
        FontGroupBox = New GroupBox()
        TahomaRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        GaramondRadioButton = New RadioButton()
        FontStyleGroupBox = New GroupBox()
        BoldItalicRadioButton = New RadioButton()
        BoldRadioButton = New RadioButton()
        ItalicRadioButton = New RadioButton()
        FontClolorGroupBox = New GroupBox()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        ExitButton = New Button()
        LoadPictureButton = New Button()
        PictureBox = New PictureBox()
        DisplayTestGroupBox.SuspendLayout()
        FontGroupBox.SuspendLayout()
        FontStyleGroupBox.SuspendLayout()
        FontClolorGroupBox.SuspendLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(115, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' DisplayTestGroupBox
        ' 
        DisplayTestGroupBox.Controls.Add(SampleTestTextBox)
        DisplayTestGroupBox.Location = New Point(47, 42)
        DisplayTestGroupBox.Name = "DisplayTestGroupBox"
        DisplayTestGroupBox.Size = New Size(200, 93)
        DisplayTestGroupBox.TabIndex = 1
        DisplayTestGroupBox.TabStop = False
        DisplayTestGroupBox.Text = "Display Test"
        ' 
        ' SampleTestTextBox
        ' 
        SampleTestTextBox.Location = New Point(35, 37)
        SampleTestTextBox.Name = "SampleTestTextBox"
        SampleTestTextBox.Size = New Size(116, 23)
        SampleTestTextBox.TabIndex = 0
        SampleTestTextBox.Text = "Sample Test"
        ' 
        ' FontGroupBox
        ' 
        FontGroupBox.Controls.Add(TahomaRadioButton)
        FontGroupBox.Controls.Add(MagnetoRadioButton)
        FontGroupBox.Controls.Add(GaramondRadioButton)
        FontGroupBox.Location = New Point(344, 42)
        FontGroupBox.Name = "FontGroupBox"
        FontGroupBox.Size = New Size(397, 84)
        FontGroupBox.TabIndex = 2
        FontGroupBox.TabStop = False
        FontGroupBox.Text = "Font"
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(258, 37)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(67, 19)
        TahomaRadioButton.TabIndex = 3
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(135, 37)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(73, 19)
        MagnetoRadioButton.TabIndex = 2
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(20, 37)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(81, 19)
        GaramondRadioButton.TabIndex = 1
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FontStyleGroupBox
        ' 
        FontStyleGroupBox.Controls.Add(BoldItalicRadioButton)
        FontStyleGroupBox.Controls.Add(BoldRadioButton)
        FontStyleGroupBox.Controls.Add(ItalicRadioButton)
        FontStyleGroupBox.Location = New Point(344, 161)
        FontStyleGroupBox.Name = "FontStyleGroupBox"
        FontStyleGroupBox.Size = New Size(177, 235)
        FontStyleGroupBox.TabIndex = 4
        FontStyleGroupBox.TabStop = False
        FontStyleGroupBox.Text = "Font Style"
        ' 
        ' BoldItalicRadioButton
        ' 
        BoldItalicRadioButton.AutoSize = True
        BoldItalicRadioButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicRadioButton.Location = New Point(40, 169)
        BoldItalicRadioButton.Name = "BoldItalicRadioButton"
        BoldItalicRadioButton.Size = New Size(84, 19)
        BoldItalicRadioButton.TabIndex = 9
        BoldItalicRadioButton.TabStop = True
        BoldItalicRadioButton.Text = "Bold Italic"
        BoldItalicRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BoldRadioButton
        ' 
        BoldRadioButton.AutoSize = True
        BoldRadioButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldRadioButton.Location = New Point(40, 103)
        BoldRadioButton.Name = "BoldRadioButton"
        BoldRadioButton.Size = New Size(50, 19)
        BoldRadioButton.TabIndex = 8
        BoldRadioButton.TabStop = True
        BoldRadioButton.Text = "Bold"
        BoldRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ItalicRadioButton
        ' 
        ItalicRadioButton.AutoSize = True
        ItalicRadioButton.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicRadioButton.Location = New Point(40, 39)
        ItalicRadioButton.Name = "ItalicRadioButton"
        ItalicRadioButton.Size = New Size(50, 19)
        ItalicRadioButton.TabIndex = 7
        ItalicRadioButton.TabStop = True
        ItalicRadioButton.Text = "Italic"
        ItalicRadioButton.UseVisualStyleBackColor = True
        ' 
        ' FontClolorGroupBox
        ' 
        FontClolorGroupBox.Controls.Add(RedRadioButton)
        FontClolorGroupBox.Controls.Add(BlueRadioButton)
        FontClolorGroupBox.Controls.Add(GreenRadioButton)
        FontClolorGroupBox.Location = New Point(588, 161)
        FontClolorGroupBox.Name = "FontClolorGroupBox"
        FontClolorGroupBox.Size = New Size(172, 235)
        FontClolorGroupBox.TabIndex = 5
        FontClolorGroupBox.TabStop = False
        FontClolorGroupBox.Text = "Font Color"
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(37, 169)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(45, 19)
        RedRadioButton.TabIndex = 6
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(37, 103)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(48, 19)
        BlueRadioButton.TabIndex = 5
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(37, 39)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(56, 19)
        GreenRadioButton.TabIndex = 4
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(638, 415)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(75, 23)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Location = New Point(115, 357)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.RightToLeft = RightToLeft.No
        LoadPictureButton.Size = New Size(107, 23)
        LoadPictureButton.TabIndex = 8
        LoadPictureButton.Text = "Load Picture"
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.BorderStyle = BorderStyle.FixedSingle
        PictureBox.Location = New Point(69, 170)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(190, 166)
        PictureBox.TabIndex = 9
        PictureBox.TabStop = False
        ' 
        ' ObjectDemonstrations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox)
        Controls.Add(LoadPictureButton)
        Controls.Add(ExitButton)
        Controls.Add(FontClolorGroupBox)
        Controls.Add(FontStyleGroupBox)
        Controls.Add(FontGroupBox)
        Controls.Add(DisplayTestGroupBox)
        Controls.Add(Label1)
        Name = "ObjectDemonstrations"
        Text = "Object Demonstrations"
        DisplayTestGroupBox.ResumeLayout(False)
        DisplayTestGroupBox.PerformLayout()
        FontGroupBox.ResumeLayout(False)
        FontGroupBox.PerformLayout()
        FontStyleGroupBox.ResumeLayout(False)
        FontStyleGroupBox.PerformLayout()
        FontClolorGroupBox.ResumeLayout(False)
        FontClolorGroupBox.PerformLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DisplayTestGroupBox As GroupBox
    Friend WithEvents SampleTestTextBox As TextBox
    Friend WithEvents FontGroupBox As GroupBox
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents FontStyleGroupBox As GroupBox
    Friend WithEvents FontClolorGroupBox As GroupBox
    Friend WithEvents BoldItalicRadioButton As RadioButton
    Friend WithEvents BoldRadioButton As RadioButton
    Friend WithEvents ItalicRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents PictureBox As PictureBox
End Class
