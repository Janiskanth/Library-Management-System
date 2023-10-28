Public Class frmAuthentication

    Private Sub btnVerifi_Click(sender As Object, e As EventArgs) Handles btnVerifi.Click
        Try
            Dim mainForm As frmMain = Nothing
            Dim lendForm As frmLend = Nothing

            If TypeOf Me.Owner Is frmMain Then
                mainForm = DirectCast(Me.Owner, frmMain)
            ElseIf TypeOf Me.Owner Is frmLend Then
                lendForm = DirectCast(Me.Owner, frmLend)
            End If

            Try
                If (mainForm IsNot Nothing AndAlso mainForm.Button8Clicked) Then
                    If txtVerify.Text = "" Then
                        MessageBox.Show("Please Enter the Authentication Code")
                    ElseIf xCheckPassword("Admin_code", "code = '" & txtVerify.Text & "'") Then
                        Me.Close()
                        frmStaff.Show()
                    Else
                        MsgBox("Please Enter the Valid Authentication Code", MsgBoxStyle.Critical, "Error")
                    End If

                ElseIf (lendForm IsNot Nothing AndAlso lendForm.btnEditClicked) Then
                    If txtVerify.Text = "" Then
                        MessageBox.Show("Please Enter the Authentication Code")

                    ElseIf xCheckPassword("Admin_code", "code = '" & txtVerify.Text & "'") Then
                        Me.Close()
                        frmLend.btnSetect.Enabled = True
                        frmLend.txtSelect.Enabled = True
                    Else
                        MsgBox("Please Enter the Valid Authentication Code", MsgBoxStyle.Critical, "Error")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub frmAuthentication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class