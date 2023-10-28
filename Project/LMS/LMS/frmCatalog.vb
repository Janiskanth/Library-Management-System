Public Class frmCatalog

    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = False

        Dim dtym As Date = Date.Now
        Label6.Text = dtym
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSetect.Enabled = True
        txtSelect.Enabled = True
        btnSave.Enabled = False

        'reload combo box
        xSearchComboBox(txtSelect, "Catalog_tbl", "Catalog_ID", "Catalog_ID", "")

    End Sub

    Private Sub btnSetect_Click(sender As Object, e As EventArgs) Handles btnSetect.Click
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        Dim ColName() As String = {"Material_ID", "Quantity", "Shelf_No", "Row_No"}
        Dim Controls() As Windows.Forms.Control = {cobMet, txtQua, txtShelf, txtRow}
        Dim Condition As String = "Catalog_ID =" & txtSelect.SelectedValue
        xReturnValToControl("Catalog_tbl", ColName, Controls, Condition)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True

        'reload cobobox
        xSearchComboBox(cobMet, "Liberty_Material", "Metrial_ID", "Metrial_ID", "")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtQua.Text = "" Or txtRow.Text = "" Or txtShelf.Text = "" Or cobMet.SelectedIndex = -1) Then
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")

        Else

            'save data
            Dim Avi As String = "YES"
            Dim M_ID As String = cobMet.SelectedValue
            Dim values() As String = {Avi, txtQua.Text.ToUpper, txtShelf.Text.ToUpper, txtRow.Text.ToUpper, M_ID}
            xSaveDATA("Catalog_tbl", "Availabilty,Quantity,Shelf_No,Row_No,Material_ID", values)
            'success msg
            MsgBox("New Member Added Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reset
            txtQua.Clear()
            txtRow.Clear()
            txtShelf.Clear()
            cobMet.SelectedIndex = -1
            cobMet.Focus()


        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cobMet.Text = ""
        txtQua.Text = ""
        txtRow.Text = ""
        txtShelf.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (cobMet.Text <> "" And txtQua.Text <> "" And txtRow.Text <> "" And txtShelf.Text <> "") Then
            If MsgBox("Are you want to edit this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then

                'update data
                Dim fields() As String = {"Material_ID", "Quantity", "Shelf_No", "Row_No"}
                Dim values() As String = {cobMet.Text, txtQua.Text, txtShelf.Text.ToUpper, txtRow.Text.ToUpper}
                Dim Condition As String = "Catalog_ID =" & txtSelect.SelectedValue
                xUpdateDATA("Catalog_tbl", fields, values, Condition)
                'success msg
                MsgBox("Member Edited Sucessfully", MsgBoxStyle.Information, "Sucess")
                'reset
                cobMet.Text = ""
                txtQua.Text = ""
                txtRow.Text = ""
                txtShelf.Text = ""

            End If
        Else
            MsgBox("Inputs are Empty... Please check", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you want to Delete this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
            'delete data
            Dim Condition As String = "Catalog_ID =" & txtSelect.SelectedValue
            xDeleteDATA("Catalog_tbl", Condition)
            'success msg
            MsgBox("Record Deleted Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reload combo box
            xSearchComboBox(txtSelect, "Catalog_tbl", "Catalog_ID", "Catalog_ID", "")
            'reset
            cobMet.Text = ""
            txtQua.Text = ""
            txtRow.Text = ""
            txtShelf.Text = ""
        End If
    End Sub
End Class