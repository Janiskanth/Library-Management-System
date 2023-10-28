Public Class frmMain

    Public Property Button8Clicked As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label6.Text = dtym


        xLoadDataToGridview("MainView", "SELECT * FROM MainView", DataGridView1)
        DataGridView1.Columns(0).HeaderText = "TITLE"
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(1).HeaderText = "AVAILABILITY"
        DataGridView1.Columns(2).HeaderText = "SHELF NO"
        DataGridView1.Columns(3).HeaderText = "ROW NO"
        DataGridView1.Columns(4).HeaderText = "SUMMARY"
        DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(5).HeaderText = "ID"

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMeterial.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCatalog.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmMember.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmLend.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmFine.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmReport.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8Clicked = True
        Dim verifyForm As New frmAuthentication()
        verifyForm.Owner = Me
        verifyForm.Show()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        rbtnID.Checked = False
        rbtnTitle.Checked = False
        txtSearch.Text = "Search"

        xLoadDataToGridview("MainView", "SELECT * FROM MainView", DataGridView1)
        DataGridView1.Columns(0).HeaderText = "TITLE"
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(1).HeaderText = "AVAILABILITY"
        DataGridView1.Columns(2).HeaderText = "SHELF NO"
        DataGridView1.Columns(3).HeaderText = "ROW NO"
        DataGridView1.Columns(4).HeaderText = "SUMMARY"
        DataGridView1.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.Columns(5).HeaderText = "ID"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (rbtnTitle.Checked) Then
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM MainView WHERE Title LIKE '%" & txtSearch.Text & "%'", DataGridView1)


        ElseIf (rbtnID.Checked) Then
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM MainView WHERE Metrial_ID =" & txtSearch.Text, DataGridView1)

        Else
            MsgBox("Please select the ID or TITLE", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub
End Class