Public Class frmMeterial
   
    Private Sub frmMeterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim dtym As Date = Date.Now
        Label6.Text = dtym

        btnSetect.Enabled = False
        cobSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSetect.Enabled = True
        cobSelect.Enabled = True
        btnSave.Enabled = False

        xSearchComboBox(cobSelect, "Liberty_Material", "Metrial_ID", "Metrial_ID", "")

    End Sub

    Private Sub btnSetect_Click(sender As Object, e As EventArgs) Handles btnSetect.Click
        If cobSelect.SelectedIndex <> -1 Then
            btnUpdate.Enabled = True
            btnDelete.Enabled = True

            'select the metrial by metrial ID
            Dim ColName() As String = {"ISSN_ISBN", "Title", "Publisher", "Type", "Gerner", "Author", "Publication_Year", "Summary"}
            Dim Controls() As Windows.Forms.Control = {txtIssn, txtTitle, txtPub, txtType, txtGer, txtAut, txtYear, txtSumm}
            Dim Condition As String = "Metrial_ID =" & cobSelect.SelectedValue
            xReturnValToControl("Liberty_Material", ColName, Controls, Condition)
        Else
            MsgBox("Please select the Metrial ID", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtIssn.Focus()
        btnSetect.Enabled = False
        cobSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If (txtIssn.Text <> "" And txtAut.Text <> "" And txtGer.Text <> "" And txtPub.Text <> "" And txtSumm.Text <> "" And txtTitle.Text <> "" And txtType.Text <> "" And txtYear.Text <> "") Then

            If MsgBox("Are you want to edit this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
                'Update data
                Dim Fields() As String = {"ISSN_ISBN", "Title", "Publisher", "Type", "Gerner", "Author", "Publication_Year", "Summary"}
                Dim values() As String = {txtIssn.Text.ToUpper, txtTitle.Text.ToUpper, txtPub.Text.ToUpper, txtType.Text.ToUpper, txtGer.Text.ToUpper, txtAut.Text.ToUpper, txtYear.Text.ToUpper, txtSumm.Text.ToUpper}
                Dim Condition As String = "Metrial_ID =" & cobSelect.SelectedValue
                xUpdateDATA("Liberty_Material", Fields, values, Condition)
                'success msg
                MsgBox("Material Edited Sucessfully", MsgBoxStyle.Information, "Sucess")
                'reset
                txtGer.Clear()
                txtAut.Clear()
                txtIssn.Clear()
                txtPub.Clear()
                txtSumm.Clear()
                txtTitle.Clear()
                txtType.Clear()
                txtYear.Clear()
                txtIssn.Focus()
            End If
        Else
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you want to Delete this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
            Dim Condition As String = "Metrial_ID =" & cobSelect.SelectedValue
            xDeleteDATA("Liberty_Material", Condition)
            'success msg
            MsgBox("Material Deleted Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reload combobox
            xSearchComboBox(cobSelect, "Liberty_Material", "Metrial_ID", "Metrial_ID", "")
            'reset
            txtGer.Clear()
            txtAut.Clear()
            txtIssn.Clear()
            txtPub.Clear()
            txtSumm.Clear()
            txtTitle.Clear()
            txtType.Clear()
            txtYear.Clear()
            txtIssn.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset
        txtGer.Clear()
        txtAut.Clear()
        txtIssn.Clear()
        txtPub.Clear()
        txtSumm.Clear()
        txtTitle.Clear()
        txtType.Clear()
        txtYear.Clear()
        txtIssn.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtIssn.Text = "" Or txtAut.Text = "" Or txtGer.Text = "" Or txtPub.Text = "" Or txtSumm.Text = "" Or txtTitle.Text = "" Or txtType.Text = "" Or txtYear.Text = "") Then
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")

        Else
            'save data
            Dim values() As String = {txtIssn.Text.ToUpper, txtTitle.Text.ToUpper, txtPub.Text.ToUpper, txtType.Text.ToUpper, txtGer.Text.ToUpper, txtAut.Text.ToUpper, txtYear.Text.ToUpper, txtSumm.Text.ToUpper}
            xSaveDATA("Liberty_Material", "ISSN_ISBN,Title,Publisher,Type,Gerner,Author,Publication_Year,Summary", values)

            'success msg
            MsgBox("Material Saved Sucessfully", MsgBoxStyle.Information, "Sucess")

            'reset
            txtGer.Clear()
            txtAut.Clear()
            txtIssn.Clear()
            txtPub.Clear()
            txtSumm.Clear()
            txtTitle.Clear()
            txtType.Clear()
            txtYear.Clear()

            txtIssn.Focus()
        End If
    End Sub
End Class