Public Class frmAdmin

    Private Sub Manage_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOldcode.Focus()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        If (txtConfirmcode.Text <> "" And txtNewcode.Text <> "" And txtOldcode.Text <> "") Then

            If xCheckPassword("Admin_code", "code = '" & txtOldcode.Text & "'") Then
                If txtNewcode.Text = txtConfirmcode.Text Then
                    If MsgBox("Are you want to Change Admin code", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
                        xUpdateDATA("Admin_code", {"code"}, {txtNewcode.Text}, "code = '" & txtOldcode.Text & "'")
                        'reset
                        txtConfirmcode.Clear()
                        txtNewcode.Clear()
                        txtOldcode.Clear()
                    End If
                Else
                    MsgBox("New code and Confirm code are Diffrent", MsgBoxStyle.Exclamation, "Warring")
                End If
            Else
                MsgBox("Admin Code Invalid", MsgBoxStyle.Exclamation, "Warring")
            End If

        Else
        MsgBox("Inputs are Empty please check !!!", MsgBoxStyle.Exclamation, "Warring")
        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If txtNewcode.UseSystemPasswordChar = True Then
            txtNewcode.UseSystemPasswordChar = False
            txtConfirmcode.UseSystemPasswordChar = False
            txtOldcode.UseSystemPasswordChar = False

        ElseIf txtNewcode.UseSystemPasswordChar = False Then
            txtNewcode.UseSystemPasswordChar = True
            txtConfirmcode.UseSystemPasswordChar = True
            txtOldcode.UseSystemPasswordChar = True
        End If

    End Sub
End Class