<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Change_Password
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_NewPass2 = New System.Windows.Forms.TextBox()
        Me.TB_NewPass1 = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_ShowPass = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(115, 243)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Confirm New Password"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TB_NewPass2
        '
        Me.TB_NewPass2.BackColor = System.Drawing.Color.White
        Me.TB_NewPass2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_NewPass2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NewPass2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NewPass2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_NewPass2.Location = New System.Drawing.Point(115, 146)
        Me.TB_NewPass2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.TB_NewPass2.MaxLength = 50
        Me.TB_NewPass2.Name = "TB_NewPass2"
        Me.TB_NewPass2.Size = New System.Drawing.Size(306, 32)
        Me.TB_NewPass2.TabIndex = 2
        Me.TB_NewPass2.UseSystemPasswordChar = True
        Me.TB_NewPass2.WordWrap = False
        '
        'TB_NewPass1
        '
        Me.TB_NewPass1.BackColor = System.Drawing.Color.White
        Me.TB_NewPass1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TB_NewPass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TB_NewPass1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NewPass1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TB_NewPass1.Location = New System.Drawing.Point(115, 75)
        Me.TB_NewPass1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.TB_NewPass1.MaxLength = 50
        Me.TB_NewPass1.Name = "TB_NewPass1"
        Me.TB_NewPass1.Size = New System.Drawing.Size(305, 32)
        Me.TB_NewPass1.TabIndex = 1
        Me.TB_NewPass1.UseSystemPasswordChar = True
        Me.TB_NewPass1.WordWrap = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.LawnGreen
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 115
        Me.LineShape1.X2 = 422
        Me.LineShape1.Y1 = 109
        Me.LineShape1.Y2 = 109
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.LawnGreen
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 113
        Me.LineShape2.X2 = 420
        Me.LineShape2.Y1 = 180
        Me.LineShape2.Y2 = 180
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(434, 357)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.Location = New System.Drawing.Point(4, 85)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(105, 20)
        Me.LBL1.TabIndex = 7
        Me.LBL1.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Re-Enter " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "New Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CB_ShowPass
        '
        Me.CB_ShowPass.AutoSize = True
        Me.CB_ShowPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.CB_ShowPass.FlatAppearance.BorderSize = 0
        Me.CB_ShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_ShowPass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_ShowPass.Location = New System.Drawing.Point(162, 220)
        Me.CB_ShowPass.Name = "CB_ShowPass"
        Me.CB_ShowPass.Size = New System.Drawing.Size(105, 17)
        Me.CB_ShowPass.TabIndex = 9
        Me.CB_ShowPass.Text = "Show Password"
        Me.CB_ShowPass.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Please enter your new password"
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 357)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_ShowPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL1)
        Me.Controls.Add(Me.TB_NewPass2)
        Me.Controls.Add(Me.TB_NewPass1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_NewPass2 As TextBox
    Friend WithEvents TB_NewPass1 As TextBox
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LBL1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_ShowPass As CheckBox
    Friend WithEvents Label2 As Label
End Class
