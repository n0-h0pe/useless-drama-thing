<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resources
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
        Me.CoBResourceType = New System.Windows.Forms.ComboBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'CoBResourceType
        '
        Me.CoBResourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoBResourceType.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoBResourceType.FormattingEnabled = True
        Me.CoBResourceType.Items.AddRange(New Object() {"All items...", "Physical resources", "Digital Resources"})
        Me.CoBResourceType.Location = New System.Drawing.Point(597, 35)
        Me.CoBResourceType.Name = "CoBResourceType"
        Me.CoBResourceType.Size = New System.Drawing.Size(142, 25)
        Me.CoBResourceType.TabIndex = 0
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(597, 98)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(142, 139)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Resources
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 526)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.CoBResourceType)
        Me.Name = "Resources"
        Me.Text = "Resources"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CoBResourceType As ComboBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
