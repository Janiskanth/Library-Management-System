Public Class frmLend

    Public Property btnEditClicked As Boolean = False

    Private Sub frmLend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label6.Text = dtym
        Label2.Text = dtym


        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnReturn.Enabled = False
        btnSave.Enabled = False

        'reload return tab
        'reload cobo box
        xSearchComboBox(txtRSelect, "Lend", "Lending_ID", "Lending_ID", " WHERE Return = 'NO'")

    End Sub

    Private Sub txtSelect_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSelect_Leave(sender As Object, e As EventArgs)
        txtSelect.Text = "Enter the Lending ID"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEditClicked = True
        Dim verifyForm As New frmAuthentication()
        verifyForm.Owner = Me
        verifyForm.Show()

        'reset
        btnCheck.Enabled = False
        txtMet.Text = ""
        txtMem.Text = ""
        dtpLen.Value = Date.Now
        dtpDue.Value = Date.Now
        txtTqua.Text = ""
        txtMret.Text = ""


        'reload combobox
        xSearchComboBox(txtSelect, "Lend", "Lending_ID", "Lending_ID", "")

    End Sub

    Private Sub btnSetect_Click(sender As Object, e As EventArgs) Handles btnSetect.Click
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        'reload data
        If txtSelect.SelectedIndex <> -1 Then
            Dim ColName() As String = {"Material_ID", "Member_ID", "Lend_Date", "Due_Date"}
            Dim Controls() As Windows.Forms.Control = {txtMet, txtMem, dtpLen, dtpDue}
            Dim Condition As String = "Lending_ID =" & txtSelect.SelectedValue
            xReturnValToControl("Lend", ColName, Controls, Condition)
        Else
            MsgBox("Please select Catalog ID", MsgBoxStyle.Exclamation, "Warring")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnSetect.Enabled = False
        txtSelect.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnReturn.Enabled = False
        btnSave.Enabled = True

        'reload combobox
        Dim criteria As String = " WHERE Quantity > 0"
        xSearchComboBox(txtMet, "Catalog_tbl", "Material_ID", "Material_ID", criteria)

        xSearchComboBox(txtMem, "Member", "Member_ID", "Member_ID", "")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtMem.SelectedIndex = -1 Or txtMet.SelectedIndex = -1 Or dtpLen.Value = Nothing Or dtpDue.Value = Nothing) Then
            MsgBox("Inputs are Missing.... Please Check", MsgBoxStyle.Critical, "Error")


        ElseIf (dtpDue.Value <= dtpLen.Value) Then
            MsgBox("Please Change the Due Date", MsgBoxStyle.Exclamation, "Warinig")

            'ElseIf (txt) Then


        Else

            If (txtTqua.Text = "" Or txtMret.Text = "") Then
                MsgBox("Please Check the Total Quantity and Previously Borrowed Status", MsgBoxStyle.Exclamation, "Missing")
            Else
                'update quanitity on catalog table
                xUpdateDATA("Catalog_tbl", {"Quantity"}, {txtTqua.Text - 1}, "Material_ID = " & txtMet.SelectedValue)
                'save date on lend table
                Dim values() As String = {txtMet.SelectedValue, txtMem.SelectedValue, dtpLen.Value.Date, dtpDue.Value.Date, "NO"}
                xSaveDATA("Lend", "Material_ID,Member_ID,Lend_Date,Due_Date,Return", values)
                MsgBox("Book Lended Sucessfully", MsgBoxStyle.Information, "Scuess")

                'reset
                txtMet.Text = ""
                txtMem.Text = ""
                dtpLen.Value = Date.Now
                dtpDue.Value = Date.Now
                txtTqua.Text = ""
                txtMret.Text = ""

            End If
            
            
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If (txtMet.SelectedIndex = -1 Or txtMem.SelectedIndex = -1) Then
            MsgBox("Please Check the Total Quantity and Previously Borrowed Status", MsgBoxStyle.Exclamation, "Missing")

        Else
            xReturnValToControl("Catalog_tbl", {"Quantity"}, {txtTqua}, "Material_ID =" & txtMet.SelectedValue)
            xReturnValToControl("Lend", {"Return"}, {txtMret}, "Member_ID =" & txtMem.SelectedValue)

            If txtMret.Text = "" Then
                txtMret.Text = "YES"
            End If
        End If


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtMet.Text = "" Or txtMem.Text = "" Or dtpLen.Text = "" Or dtpDue.Text = "") Then
            MsgBox("Inputs are Missing....Please Check", MsgBoxStyle.Critical, "Error")
        Else
            If MsgBox("Are you want to edit this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
                Dim fields() As String = {"Material_ID", "Member_ID", "Lend_Date", "Due_Date"}
                Dim values() As String = {txtMet.Text, txtMem.Text, dtpLen.Value.Date, dtpDue.Value.Date}
                Dim Condition As String = "Lending_ID =" & txtSelect.SelectedValue
                xUpdateDATA("Lend", fields, values, Condition)

                'scuess msg
                MsgBox("Data Edited Sucessfully", MsgBoxStyle.Information, "Sucess")
                'reset
                txtMet.Text = ""
                txtMem.Text = ""
                dtpDue.Value = Date.Now
                dtpLen.Value = Date.Now
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you want to Delete this record", MsgBoxStyle.YesNo, "Confirm?") = MsgBoxResult.Yes Then
            Dim Condition As String = "Lending_ID =" & txtSelect.SelectedValue
            xDeleteDATA("Lend", Condition)
            MsgBox("Record Deleted Sucessfully", MsgBoxStyle.Information, "Sucess")
            'reload combobox
            xSearchComboBox(txtSelect, "Lend", "Lending_ID", "Lending_ID", "")
            'reset
            txtMet.Text = ""
            txtMem.Text = ""
            dtpDue.Value = Date.Now
            dtpLen.Value = Date.Now
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtMet.Text = ""
        txtMem.Text = ""
        dtpLen.Value = Date.Now
        dtpDue.Value = Date.Now
        txtTqua.Text = ""
        txtMret.Text = ""
    End Sub

    Private Sub btnRSelect_Click(sender As Object, e As EventArgs) Handles btnRSelect.Click

        If txtRSelect.SelectedIndex <> -1 Then
            btnReturn.Enabled = True

            'call record
            Dim ColName() As String = {"Material_ID", "Member_ID", "Lend_Date", "Due_Date"}
            Dim Controls() As Windows.Forms.Control = {txtRmat, txtRmem, txtRled, txtRdue}
            Dim Condition As String = "Lending_ID =" & txtRSelect.SelectedValue
            xReturnValToControl("Lend", ColName, Controls, Condition)

            If (xCheckPassword("Fine", "Lending_ID =" & txtRSelect.SelectedValue)) Then
                xReturnValToControl("Fine", {"Amount"}, {txtRfin}, "Lending_ID =" & txtRSelect.SelectedValue)
            Else
                txtRfin.Text = "0"
            End If
            
        Else
            MsgBox("Please select the Lending ID", MsgBoxStyle.Critical, "Error")
        End If


    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        If txtRled.Text < dtpRret.Value.Date Then
            If txtRfin.Text <> "0" Then
                xUpdateDATA("Fine", {"Paid"}, {"YES"}, "Lending_ID =" & txtRSelect.SelectedValue)
            End If

            xUpdateDATA("Lend", {"Return_Date", "Return"}, {dtpRret.Value.Date, "YES"}, "Lending_ID =" & txtRSelect.SelectedValue)
            'msg
            MsgBox("Metrial Returned Sucessfullly", MsgBoxStyle.Information, "Scuess")
            'reload combo box
            xSearchComboBox(txtRSelect, "Lend", "Lending_ID", "Lending_ID", " WHERE Return = 'NO'")
            'reset
            txtRdue.Text = "'"
            txtRfin.Text = ""
            txtRmat.Text = ""
            txtRled.Text = ""
            txtRmem.Text = ""
            dtpRret.Value = Date.Now
        Else
            MsgBox("Please Select the Correct Return Date", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
End Class