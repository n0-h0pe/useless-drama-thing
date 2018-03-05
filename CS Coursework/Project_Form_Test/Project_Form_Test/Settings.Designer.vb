<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_ChangePass = New System.Windows.Forms.Button()
        Me.BT_EditTT = New System.Windows.Forms.Button()
        Me.BT_ManageUsers = New System.Windows.Forms.Button()
        Me.BT_ManageDB = New System.Windows.Forms.Button()
        Me.ToolTip_CP = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'BT_ChangePass
        '
        Me.BT_ChangePass.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BT_ChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_ChangePass.FlatAppearance.BorderSize = 0
        Me.BT_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ChangePass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ChangePass.Location = New System.Drawing.Point(75, 72)
        Me.BT_ChangePass.Name = "BT_ChangePass"
        Me.BT_ChangePass.Size = New System.Drawing.Size(275, 39)
        Me.BT_ChangePass.TabIndex = 1
        Me.BT_ChangePass.Text = "Change Password"
        Me.ToolTip_CP.SetToolTip(Me.BT_ChangePass, "Change your current login password")
        Me.BT_ChangePass.UseVisualStyleBackColor = False
        '
        'BT_EditTT
        '
        Me.BT_EditTT.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BT_EditTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_EditTT.FlatAppearance.BorderSize = 0
        Me.BT_EditTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_EditTT.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_EditTT.Location = New System.Drawing.Point(75, 117)
        Me.BT_EditTT.Name = "BT_EditTT"
        Me.BT_EditTT.Size = New System.Drawing.Size(275, 39)
        Me.BT_EditTT.TabIndex = 2
        Me.BT_EditTT.Text = "Edit Timetable"
        Me.ToolTip_CP.SetToolTip(Me.BT_EditTT, "Edit the room time table and see recent changes")
        Me.BT_EditTT.UseVisualStyleBackColor = False
        '
        'BT_ManageUsers
        '
        Me.BT_ManageUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BT_ManageUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_ManageUsers.FlatAppearance.BorderSize = 0
        Me.BT_ManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ManageUsers.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ManageUsers.Location = New System.Drawing.Point(75, 162)
        Me.BT_ManageUsers.Name = "BT_ManageUsers"
        Me.BT_ManageUsers.Size = New System.Drawing.Size(275, 39)
        Me.BT_ManageUsers.TabIndex = 3
        Me.BT_ManageUsers.Text = "Manage Users"
        Me.ToolTip_CP.SetToolTip(Me.BT_ManageUsers, "Manage user accounts")
        Me.BT_ManageUsers.UseVisualStyleBackColor = False
        '
        'BT_ManageDB
        '
        Me.BT_ManageDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BT_ManageDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BT_ManageDB.FlatAppearance.BorderSize = 0
        Me.BT_ManageDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_ManageDB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ManageDB.Location = New System.Drawing.Point(75, 207)
        Me.BT_ManageDB.Name = "BT_ManageDB"
        Me.BT_ManageDB.Size = New System.Drawing.Size(275, 39)
        Me.BT_ManageDB.TabIndex = 4
        Me.BT_ManageDB.Text = "Manage Database"
        Me.ToolTip_CP.SetToolTip(Me.BT_ManageDB, "Open the database file in Microsoft Access")
        Me.BT_ManageDB.UseVisualStyleBackColor = False
        '
        'ToolTip_CP
        '
        '
        'BTBack
        '
        Me.BTBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.BTBack.FlatAppearance.BorderSize = 0
        Me.BTBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTBack.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBack.Location = New System.Drawing.Point(12, 419)
        Me.BTBack.Name = "BTBack"
        Me.BTBack.Size = New System.Drawing.Size(91, 31)
        Me.BTBack.TabIndex = 5
        Me.BTBack.Text = "Back"
        Me.BTBack.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 462)
        Me.Controls.Add(Me.BTBack)
        Me.Controls.Add(Me.BT_ManageDB)
        Me.Controls.Add(Me.BT_ManageUsers)
        Me.Controls.Add(Me.BT_EditTT)
        Me.Controls.Add(Me.BT_ChangePass)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BT_ChangePass As Button
    Friend WithEvents BT_EditTT As Button
    Friend WithEvents BT_ManageUsers As Button
    Friend WithEvents BT_ManageDB As Button
    Friend WithEvents ToolTip_CP As ToolTip
    Friend WithEvents BTBack As Button
End Class
