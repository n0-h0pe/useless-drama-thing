Public Class Settings
    Private Sub LBL1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip_CP.Popup

    End Sub

    Private Sub BT_ChangePass_Click(sender As Object, e As EventArgs) Handles BT_ChangePass.Click

        Dim Change_Password_ As New Change_Password
        Me.Hide()
        Change_Password_.ShowDialog()
        Me.Show()
        Me.Close()

    End Sub

End Class