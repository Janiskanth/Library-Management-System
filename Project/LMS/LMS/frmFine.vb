Public Class frmFine

    Private Sub frmFine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now        
        Label2.Text = dtym

        btnFine.Enabled = False

        xSearchComboBox(txtSelect, "Lend", "Lending_ID", "Lending_ID", " WHERE [Return] = 'NO' AND Due_Date < #" & Date.Now.ToString("yyyy-MM-dd") & "#")

    End Sub

    Private Sub btnFine_Click(sender As Object, e As EventArgs) Handles btnFine.Click
        If txtSelect.SelectedIndex <> -1 Then
            If (IsNumeric(txtAmount.Text) And txtAmount.Text <> "") Then
                xSaveDATA("Fine", "Lending_ID,Amount,Paid", {txtSelect.SelectedValue, txtAmount.Text, "NO"})
                MsgBox("Fine Added Sucessfully", MsgBoxStyle.Information, "Sucess")

                txtSelect.SelectedIndex = -1
                txtAmount.Text = ""
                txtdue.Text = ""
                txtled.Text = "'"
                txtmem.Text = "'"
                txtmat.Text = ""
            Else
                MsgBox("Amount Format is Incorrect Pleasse Check", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Please select the Lend ID", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btmRSelect_Click(sender As Object, e As EventArgs) Handles btmRSelect.Click
        If (txtSelect.SelectedIndex <> -1) Then

            If (xCheckPassword("Fine", " Lending_ID =" & txtSelect.SelectedValue)) Then
                MsgBox("This Lend ID already has a fine." & vbNewLine & "Please select another Lend ID.", MsgBoxStyle.Exclamation, "Missing")
            Else
                'call record
                Dim ColName() As String = {"Material_ID", "Member_ID", "Lend_Date", "Due_Date"}
                Dim Controls() As Windows.Forms.Control = {txtmat, txtmem, txtled, txtdue}
                Dim Condition As String = "Lending_ID =" & txtSelect.SelectedValue
                xReturnValToControl("Lend", ColName, Controls, Condition)

                btnFine.Enabled = True
            End If
        Else
            MsgBox("Please Select the Lend ID", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class