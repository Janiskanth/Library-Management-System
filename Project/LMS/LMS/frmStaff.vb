Public Class frmStaff

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label6.Text = dtym

        btnSetect.Enabled = False
        txtSelect.Enabled = False        
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSave.Enabled = True
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        btnSetect.Enabled = True
        txtSelect.Enabled = True
        btnSave.Enabled = False

        xSearchComboBox(txtSelect, "staff_tbl", "Staff_ID", "Staff_ID", "")
    End Sub

    Private Sub btnSetect_Click(sender As Object, e As EventArgs) Handles btnSetect.Click
        If txtSelect.SelectedIndex <> -1 Then
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            'get staff table data
            Dim ColName() As String = {"Staff_ID", "Name", "NIC", "Email", "Mobile", "Address"}
            Dim Controls() As Windows.Forms.Control = {txtStaff, txtName, txtNIC, txtEmail, txtMobile, txtAddress}
            Dim Condition As String = "Staff_ID = '" & txtSelect.SelectedValue & "'"
            xReturnValToControl("staff_tbl", ColName, Controls, Condition)
            'get account table data
            Dim ColName1() As String = {"Staff_ID", "Username", "pass_word"}
            Dim Controls1() As Windows.Forms.Control = {txtStaff, txtUsername, txtPassword}
            Dim Condition1 As String = "Staff_ID = '" & txtSelect.SelectedValue & "'"
            xReturnValToControl("Account_tbl", ColName1, Controls1, Condition1)
        Else
            MsgBox("Please selct Staff ID", MsgBoxStyle.Exclamation, "Warring")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtAddress.Text <> "" And txtEmail.Text <> "" And txtMobile.Text <> "" And txtName.Text <> "" And txtNIC.Text <> "" And txtPassword.Text <> "" And txtUsername.Text <> "" Then
                'check the staff id alredy used
                If xCheckPassword("staff_tbl", "Staff_ID = '" & txtStaff.Text.ToUpper & "'") Then
                    MsgBox("This Staff ID already Used....", MsgBoxStyle.Exclamation, "Warring")
                Else
                    'save record on staff tbl
                    Dim values() As String = {txtStaff.Text.ToUpper, txtName.Text.ToUpper, txtNIC.Text.ToUpper, txtEmail.Text, txtMobile.Text, txtAddress.Text.ToUpper}
                    xSaveDATA("staff_tbl", "Staff_ID,Name,NIC,Email,Mobile,Address", values)
                    'save records on account tbl
                    xSaveDATA("Account_tbl", "Staff_ID,Username,pass_word", {txtStaff.Text.ToUpper, txtUsername.Text, txtPassword.Text})

                    MsgBox("Records Added Sucessfully", MsgBoxStyle.Information, "Sucess")
                    xSearchComboBox(txtSelect, "staff_tbl", "Staff_ID", "Staff_ID", "")
                    'reset
                    txtAddress.Text = ""
                    txtEmail.Text = ""
                    txtMobile.Text = ""
                    txtName.Text = ""
                    txtNIC.Text = ""
                    txtPassword.Text = ""
                    txtStaff.Text = ""
                    txtUsername.Text = ""
                    txtStaff.Focus()


                End If
            Else
                MsgBox("Inputs are missing Please check it!!!", MsgBoxStyle.Exclamation, "Warring")
            End If
        Catch ex As Exception
            MsgBox("Somethings wrong!!! " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAddress.Text <> "" And txtEmail.Text <> "" And txtMobile.Text <> "" And txtName.Text <> "" And txtNIC.Text <> "" And txtPassword.Text <> "" And txtUsername.Text <> "" Then

            If MsgBox("Are you want to edit this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then

                'update staff table
                Dim fields() As String = {"Staff_ID", "Name", "NIC", "Email", "Mobile", "Address"}
                Dim values() As String = {txtStaff.Text.ToUpper, txtName.Text.ToUpper, txtNIC.Text.ToUpper, txtEmail.Text, txtMobile.Text, txtAddress.Text.ToUpper}
                Dim Condition As String = "Staff_ID = '" & txtSelect.SelectedValue & "'"
                xUpdateDATA("staff_tbl", fields, values, Condition)
                'update account table
                Dim fields1() As String = {"Staff_ID", "Username", "pass_word"}
                Dim values1() As String = {txtStaff.Text.ToUpper, txtUsername.Text, txtPassword.Text}
                Dim Condition1 As String = "Staff_ID = '" & txtSelect.SelectedValue & "'"
                xUpdateDATA("Account_tbl", fields1, values1, Condition1)

                MsgBox("Record Updated Scuessfully", MsgBoxStyle.Information, "Sucess")
                'reset
                xSearchComboBox(txtSelect, "staff_tbl", "Staff_ID", "Staff_ID", "")
                txtAddress.Text = ""
                txtEmail.Text = ""
                txtMobile.Text = ""
                txtName.Text = ""
                txtNIC.Text = ""
                txtPassword.Text = ""
                txtStaff.Text = ""
                txtUsername.Text = ""
                txtStaff.Focus()
            End If
            
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you want to Delete this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
            Dim Condition As String = "Staff_ID = '" & txtSelect.SelectedValue & "'"
            xDeleteDATA("staff_tbl", Condition)
            MsgBox("Record Deleted Scuessfully", MsgBoxStyle.Information, "Sucess")
            'reset
            xSearchComboBox(txtSelect, "staff_tbl", "Staff_ID", "Staff_ID", "")
            txtSelect.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
            txtMobile.Text = ""
            txtName.Text = ""
            txtNIC.Text = ""
            txtPassword.Text = ""
            txtStaff.Text = ""
            txtUsername.Text = ""
            txtStaff.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtAddress.Text = ""
        txtEmail.Text = ""
        txtMobile.Text = ""
        txtName.Text = ""
        txtNIC.Text = ""
        txtPassword.Text = ""
        txtStaff.Text = ""
        txtUsername.Text = ""
        txtStaff.Focus()
    End Sub

    Private Sub btnManage_admin(sender As Object, e As EventArgs) Handles manage_admin.Click
        frmAdmin.Show()

    End Sub
End Class