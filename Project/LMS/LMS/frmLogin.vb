Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label6.Text = dtym
    End Sub

    
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.DimGray
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.White
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        txtUsername.Focus()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtUsername.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtPassword.Focus()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        txtPassword.Focus()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        ElseIf txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text <> "" And txtPassword.Text <> "" Then
            If xCheckPassword("Account_tbl", "Username = '" & txtUsername.Text & "' AND pass_word = '" & txtPassword.Text & "'") Then
                txtPassword.Clear()
                Me.Hide()
                frmMain.Show()
            Else
                MsgBox("Username or Password Incorrect", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Inputs are Empty Please Check!!!", MsgBoxStyle.Exclamation, "Warring")
        End If
    End Sub
End Class