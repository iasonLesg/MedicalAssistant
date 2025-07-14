<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        BTN_Add = New Button()
        Label2 = New Label()
        Panel5 = New Panel()
        BTN_Search = New Button()
        Label1 = New Label()
        Panel4 = New Panel()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Left
        TextBox1.Font = New Font("Segoe UI", 24F)
        TextBox1.Location = New Point(0, 0)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(423, 50)
        TextBox1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SteelBlue
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1028, 113)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1028, 51)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(BTN_Add)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(BTN_Search)
        Panel3.Controls.Add(TextBox1)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(361, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(667, 51)
        Panel3.TabIndex = 0
        ' 
        ' BTN_Add
        ' 
        BTN_Add.AccessibleRole = AccessibleRole.Cursor
        BTN_Add.BackColor = Color.SteelBlue
        BTN_Add.BackgroundImage = CType(resources.GetObject("BTN_Add.BackgroundImage"), Image)
        BTN_Add.BackgroundImageLayout = ImageLayout.Stretch
        BTN_Add.Dock = DockStyle.Right
        BTN_Add.Location = New Point(270, 0)
        BTN_Add.Name = "BTN_Add"
        BTN_Add.Size = New Size(60, 51)
        BTN_Add.TabIndex = 5
        BTN_Add.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Right
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(330, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5)
        Label2.Size = New Size(297, 55)
        Label2.TabIndex = 2
        Label2.Text = "Προσθήκη Ασθενή"
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(627, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(40, 51)
        Panel5.TabIndex = 4
        ' 
        ' BTN_Search
        ' 
        BTN_Search.AccessibleRole = AccessibleRole.Cursor
        BTN_Search.BackColor = Color.SteelBlue
        BTN_Search.BackgroundImage = CType(resources.GetObject("BTN_Search.BackgroundImage"), Image)
        BTN_Search.BackgroundImageLayout = ImageLayout.Stretch
        BTN_Search.Dock = DockStyle.Left
        BTN_Search.Location = New Point(423, 0)
        BTN_Search.Name = "BTN_Search"
        BTN_Search.Size = New Size(55, 51)
        BTN_Search.TabIndex = 3
        BTN_Search.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(5)
        Label1.Size = New Size(361, 55)
        Label1.TabIndex = 1
        Label1.Text = "Ψάξε με όνομα ασθενή"
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1028, 36)
        Panel4.TabIndex = 4
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 16F)
        LinkLabel1.LinkColor = Color.SteelBlue
        LinkLabel1.Location = New Point(50, 150)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(334, 30)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "iasonasfmaso papadopoularasole"
        LinkLabel1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(20, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 30)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(1028, 749)
        Controls.Add(PictureBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainPage"
        Text = "Medical Assistant"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_Search As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BTN_Add As Button
    Friend WithEvents Label2 As Label

End Class
