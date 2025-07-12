<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LanguageSelectionPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LanguageSelectionPage))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(85, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 45)
        Label1.TabIndex = 0
        Label1.Text = "Select a language:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 12F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(54, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(357, 29)
        ComboBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(144, 206)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 50)
        Button2.TabIndex = 3
        Button2.Text = "Continue"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(466, 281)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        ShowInTaskbar = False
        Text = "LanguageSelection"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
End Class
