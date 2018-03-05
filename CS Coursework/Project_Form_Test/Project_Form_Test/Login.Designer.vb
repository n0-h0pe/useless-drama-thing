<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.BT_Login = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_Username
        '
        Me.TB_Username.BackColor = System.Drawing.Color.White
        Me.TB_Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Username.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Username.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_Username.Location = New System.Drawing.Point(112, 235)
        Me.TB_Username.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.TB_Username.MaxLength = 50
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(305, 32)
        Me.TB_Username.TabIndex = 0
        Me.TB_Username.WordWrap = False
        '
        'BT_Login
        '
        Me.BT_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BT_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_Login.FlatAppearance.BorderSize = 0
        Me.BT_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Login.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_Login.Location = New System.Drawing.Point(86, 411)
        Me.BT_Login.Name = "BT_Login"
        Me.BT_Login.Size = New System.Drawing.Size(275, 39)
        Me.BT_Login.TabIndex = 2
        Me.BT_Login.Text = "Login"
        Me.BT_Login.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(434, 462)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LawnGreen
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 111
        Me.LineShape2.X2 = 418
        Me.LineShape2.Y1 = 341
        Me.LineShape2.Y2 = 341
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LawnGreen
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 113
        Me.LineShape1.X2 = 420
        Me.LineShape1.Y1 = 270
        Me.LineShape1.Y2 = 270
        '
        'TB_Password
        '
        Me.TB_Password.BackColor = System.Drawing.Color.White
        Me.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_Password.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Password.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_Password.Location = New System.Drawing.Point(112, 306)
        Me.TB_Password.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.TB_Password.MaxLength = 50
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(306, 32)
        Me.TB_Password.TabIndex = 1
        Me.TB_Password.UseSystemPasswordChar = True
        Me.TB_Password.WordWrap = False
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.Location = New System.Drawing.Point(16, 245)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(75, 20)
        Me.LBL1.TabIndex = 5
        Me.LBL1.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 90)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Woldgate Drama" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resource System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Project_Form_Test.My.Resources.Resources.drama
        Me.PictureBox1.Location = New System.Drawing.Point(113, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.BT_Login)
        Me.Controls.Add(Me.TB_Username)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_Username As TextBox
    Friend WithEvents BT_Login As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents TB_Password As TextBox
    Friend WithEvents LBL1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

    Private Sub BT_Login_Click(sender As Object, e As EventArgs) Handles BT_Login.Click

        Dim UserEntry As Boolean = True

        Confirm_Login(TB_Username.Text, TB_Password.Text)

        If UserEntry = True Then

            Dim Main_Menu_ As New Main_Menu
            Me.Hide()
            Main_Menu_.ShowDialog()
            Me.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
