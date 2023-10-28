Public Class frmMember

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label6.Text = dtym

        txtName.Focus()
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnSetect_Click(sender As Object, e As EventArgs) Handles btnSetect.Click
        If txtSelect.SelectedIndex <> -1 Then
            btnUpdate.Enabled = True
            btnDelete.Enabled = True

            'call record
            Dim ColName() As String = {"Name", "NIC", "Address", "Email", "Phone_No", "City"}
            Dim Controls() As Windows.Forms.Control = {txtName, txtNic, txtAdd, txtEmail, txtMobile, txtCity}
            Dim Condition As String = "Member_ID =" & txtSelect.SelectedValue
            xReturnValToControl("Member", ColName, Controls, Condition)
        Else
            MsgBox("Please select the Member ID", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSetect.Enabled = True
        txtSelect.Enabled = True
        btnSave.Enabled = False

        xSearchComboBox(txtSelect, "Member", "Member_ID", "Member_ID", "")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Clear()
        txtAdd.Clear()
        txtCity.Clear()
        txtEmail.Clear()
        txtNic.Clear()
        txtMobile.Clear()

        txtName.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtAdd.Text = "" Or txtCity.Text = "" Or txtEmail.Text = "" Or txtMobile.Text = "" Or txtName.Text = "" Or txtNic.Text = "") Then
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")
        Else
            'save data
            Dim values() As String = {txtName.Text.ToUpper, txtNic.Text.ToUpper, txtAdd.Text.ToUpper, txtEmail.Text, txtMobile.Text.ToUpper, txtCity.Text.ToUpper}
            xSaveDATA("Member", "Name,NIC,Address,Email,Phone_No,City", values)
            'success msg
            MsgBox("New Member Added Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reset
            txtName.Clear()
            txtAdd.Clear()
            txtCity.Clear()
            txtEmail.Clear()
            txtNic.Clear()
            txtMobile.Clear()

            txtName.Focus()


        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtAdd.Text <> "" And txtCity.Text <> "" And txtEmail.Text <> "" And txtMobile.Text <> "" And txtName.Text <> "" And txtNic.Text <> "") Then

            If MsgBox("Are you want to edit this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then

                'update data
                Dim fields() As String = {"Name", "NIC", "Address", "Email", "Phone_No", "City"}
                Dim values() As String = {txtName.Text.ToUpper, txtNic.Text.ToUpper, txtAdd.Text.ToUpper, txtEmail.Text, txtMobile.Text.ToUpper, txtCity.Text.ToUpper}
                Dim Condition As String = "Member_ID =" & txtSelect.SelectedValue
                xUpdateDATA("Member", fields, values, Condition)
                'success msg
                MsgBox("Member Edited Sucessfully", MsgBoxStyle.Information, "Sucess")
                'reset
                txtName.Clear()
                txtAdd.Clear()
                txtCity.Clear()
                txtEmail.Clear()
                txtNic.Clear()
                txtMobile.Clear()

                txtName.Focus()

            End If
        Else
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you want to Delete this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
            'delete data
            Dim Condition As String = "Member_ID =" & txtSelect.SelectedValue
            xDeleteDATA("Member", Condition)
            MsgBox("Material Deleted Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reload combobox
            xSearchComboBox(txtSelect, "Member", "Member_ID", "Member_ID", "")
            'reset
            txtName.Clear()
            txtAdd.Clear()
            txtCity.Clear()
            txtEmail.Clear()
            txtNic.Clear()
            txtMobile.Clear()

            txtName.Focus()

        End If
    End Sub
End Class