Public Class Change_Password
    Private Sub CB_ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CB_ShowPass.CheckedChanged

        If CB_ShowPass.Checked = True Then

            TB_NewPass1.UseSystemPasswordChar = False
            TB_NewPass2.UseSystemPasswordChar = False

        ElseIf CB_ShowPass.Checked = False Then

            TB_NewPass1.UseSystemPasswordChar = True
            TB_NewPass2.UseSystemPasswordChar = True

        End If
    End Sub


End Class