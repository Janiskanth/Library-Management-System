Public Class frmReport
    'reload Metrial tab comboBoxs
    Sub ReloadMetrialCombobox()        
        xSearchComboBox(cbMetrialPub, "Liberty_Material", "Publisher", "Publisher", "")
        xSearchComboBox(cbMetrialAut, "Liberty_Material", "Author", "Author", "")
        xSearchComboBox(cbMetrialType, "Liberty_Material", "Type", "Type", "")
        xSearchComboBox(cbMetrialPGer, "Liberty_Material", "Gerner", "Gerner", "")
        xSearchComboBox(cbMetrialYear, "Liberty_Material", "Publication_Year", "Publication_Year", "")
    End Sub

    'change Metrial dgv coloum size
    Sub MDataGridViewChange()
        MetrialDataGridView.Columns(0).HeaderText = "METRIAL ID"
        MetrialDataGridView.Columns(1).HeaderText = "ISSN/ISBN"
        MetrialDataGridView.Columns(2).HeaderText = "TITLE"
        MetrialDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        MetrialDataGridView.Columns(3).HeaderText = "PUBLISHER"
        MetrialDataGridView.Columns(4).HeaderText = "TYPE"
        MetrialDataGridView.Columns(5).HeaderText = "GERNER"
        MetrialDataGridView.Columns(6).HeaderText = "AUTHOR"
        MetrialDataGridView.Columns(7).HeaderText = "YEAR"
        MetrialDataGridView.Columns(8).HeaderText = "DESCRIPITION"
        MetrialDataGridView.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    'reload Catalog tap comboboxs
    Sub ReloadCatalogCombobox()
        xSearchComboBox(cbCAvi, "Catalog_tbl", "Availabilty", "Availabilty", "")
        xSearchComboBox(cbCShelf, "Catalog_tbl", "Shelf_No", "Shelf_No", "")
        xSearchComboBox(cbCRow, "Catalog_tbl", "Row_No", "Row_No", "")
    End Sub

    'change catalog dgv coloum size
    Sub CDataGridViewChange()
        CatalogDataGridView.Columns(0).HeaderText = "CATALOG ID"
        CatalogDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CatalogDataGridView.Columns(1).HeaderText = "AVAILABLE"
        CatalogDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CatalogDataGridView.Columns(2).HeaderText = "QUANTITY"
        CatalogDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CatalogDataGridView.Columns(3).HeaderText = "SHELF NO"
        CatalogDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CatalogDataGridView.Columns(4).HeaderText = "ROW NO"
        CatalogDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CatalogDataGridView.Columns(5).HeaderText = "MATERIAL ID"
        CatalogDataGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    'reload member tap combobox
    Sub ReloadMemberCombobox()
        xSearchComboBox(cbMMcity, "Member", "City", "City", "")
    End Sub

    'change member dgv coloum size
    Sub MMDataGridViewChange()
        MemberDataGridView.Columns(0).HeaderText = "MEMBER ID"
        MemberDataGridView.Columns(1).HeaderText = "NAME"
        MemberDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        MemberDataGridView.Columns(2).HeaderText = "NIC"
        MemberDataGridView.Columns(3).HeaderText = "ADDRESS"
        MemberDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        MemberDataGridView.Columns(4).HeaderText = "EMAIL"
        MemberDataGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        MemberDataGridView.Columns(5).HeaderText = "MOBILE"
        MemberDataGridView.Columns(6).HeaderText = "CITY"
    End Sub

    'reload fine tap combobox
    Sub ReloadFineCombobox()
        xSearchComboBox(cbFpaid, "Fine", "Paid", "Paid", "")
    End Sub

    'change fine dgv column size
    Sub FDataGridViewChange()
        FineDataGridView.Columns(0).HeaderText = "FINE ID"
        FineDataGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FineDataGridView.Columns(1).HeaderText = "LENDING ID"
        FineDataGridView.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FineDataGridView.Columns(2).HeaderText = "AMOUNT"
        FineDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        FineDataGridView.Columns(3).HeaderText = "PAID"
        FineDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    'reload lend tap combobox
    Sub ReloadLendCombobox()
        xSearchComboBox(cbLstatus, "Lend", "Return", "Return", "")
    End Sub

    'change lend tap column size
    Sub LDataGridViewChange()
        LendDatGridView.Columns(0).HeaderText = "LENDING ID"
        LendDatGridView.Columns(1).HeaderText = "MATERIAL ID"
        LendDatGridView.Columns(2).HeaderText = "MEMBER ID"
        LendDatGridView.Columns(3).HeaderText = "LEND DATE"
        LendDatGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        LendDatGridView.Columns(4).HeaderText = "DUE DATE"
        LendDatGridView.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        LendDatGridView.Columns(5).HeaderText = "RETURN DATE"
        LendDatGridView.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        LendDatGridView.Columns(6).HeaderText = "RETURN"

    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtym As Date = Date.Now
        Label2.Text = dtym
        Label13.Text = dtym
        Label17.Text = dtym
        Label19.Text = dtym
        Label27.Text = dtym

        'Material
        ReloadMetrialCombobox()
        xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material", MetrialDataGridView)
        MDataGridViewChange()

        'Catalog
        ReloadCatalogCombobox()
        xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl", CatalogDataGridView)
        CDataGridViewChange()

        'Member
        ReloadMemberCombobox()
        xLoadDataToGridview("Member", "SELECT * FROM Member", MemberDataGridView)
        MMDataGridViewChange()

        'Fine
        ReloadFineCombobox()
        xLoadDataToGridview("Fine", "SELECT * FROM Fine", FineDataGridView)
        FDataGridViewChange()

        'Lend
        ReloadLendCombobox()
        xLoadDataToGridview("Lend", "SELECT * FROM Lend", LendDatGridView)
        LDataGridViewChange()
    End Sub

    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMSearch.MouseClick
        txtMSearch.Clear()
    End Sub


    Private Sub btnMFilter_Click(sender As Object, e As EventArgs) Handles btnMFilter.Click
        If (cbMetrialAut.SelectedIndex <> -1 And cbMetrialPGer.SelectedIndex <> -1 And cbMetrialPub.SelectedIndex <> -1 And cbMetrialType.SelectedIndex <> -1 And cbMetrialYear.SelectedIndex <> -1) Then
            'call metrial records
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material WHERE Publisher = '" & cbMetrialPub.SelectedValue & "' AND Type = '" & cbMetrialType.SelectedValue & "' AND Gerner = '" & cbMetrialPGer.SelectedValue & "' AND Author = '" & cbMetrialAut.SelectedValue & "' AND Publication_Year = '" & cbMetrialYear.SelectedValue & "'", MetrialDataGridView)
            'call dgv sizemethod
            MDataGridViewChange()

        ElseIf ((cbMetrialAut.SelectedIndex <> -1 Or cbMetrialPGer.SelectedIndex <> -1 Or cbMetrialPub.SelectedIndex <> -1 Or cbMetrialType.SelectedIndex <> -1 Or cbMetrialYear.SelectedIndex <> -1)) Then
            'call metrial records
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material WHERE Publisher = '" & cbMetrialPub.SelectedValue & "' OR Type = '" & cbMetrialType.SelectedValue & "' OR Gerner = '" & cbMetrialPGer.SelectedValue & "' OR Author = '" & cbMetrialAut.SelectedValue & "' OR Publication_Year = '" & cbMetrialYear.SelectedValue & "'", MetrialDataGridView)
            'call dgv sizemethod
            MDataGridViewChange()

        Else
            MsgBox("Please Select Filer Options", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub btnMSearch_Click(sender As Object, e As EventArgs) Handles btnMSearch.Click
        If rbMtitle.Checked Then
            'call metrial records
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material WHERE Title LIKE '%" & txtMSearch.Text & "%'", MetrialDataGridView)
            'call dgv sizemethod
            MDataGridViewChange()

        ElseIf rbMid.Checked Then
            'call metrial records
            xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material WHERE Metrial_ID =" & txtMSearch.Text, MetrialDataGridView)
            'call dgv sizemethod
            MDataGridViewChange()
        Else
            MsgBox("Please select the ID or TITLE", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    'material tab reset
    Private Sub btnMReset_Click(sender As Object, e As EventArgs) Handles btnMReset.Click
        cbMetrialAut.SelectedValue = -1
        cbMetrialPGer.SelectedValue = -1
        cbMetrialPub.SelectedValue = -1
        cbMetrialType.SelectedValue = -1
        cbMetrialYear.SelectedValue = -1

        rbMid.Checked = False
        rbMtitle.Checked = False
        txtMSearch.Text = "Search"
        xLoadDataToGridview("Liberty_Material", "SELECT * FROM Liberty_Material", MetrialDataGridView)
    End Sub

    'load catalog table to datagridview
    Private Sub btnCFilter_Click(sender As Object, e As EventArgs) Handles btnCFilter.Click
        If (cbCAvi.SelectedIndex = -1 And cbCRow.SelectedIndex = -1 And cbCShelf.SelectedIndex = -1) Then
            MsgBox("Please Select Filer Options", MsgBoxStyle.Exclamation, "Warning")

        ElseIf (cbCAvi.SelectedIndex <> -1 And cbCRow.SelectedIndex <> -1 And cbCShelf.SelectedIndex <> -1) Then
            xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl WHERE Availabilty = '" & cbCAvi.SelectedValue & "' AND Shelf_No = '" & cbCShelf.SelectedValue & "' AND Row_No = '" & cbCRow.SelectedValue & "'", CatalogDataGridView)

        Else
            xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl WHERE Availabilty = '" & cbCAvi.SelectedValue & "' OR Shelf_No = '" & cbCShelf.SelectedValue & "' OR Row_No = '" & cbCRow.SelectedValue & "'", CatalogDataGridView)
        End If
    End Sub

    'Catalog tap reset
    Private Sub btnCReset_Click(sender As Object, e As EventArgs) Handles btnCReset.Click
        cbCAvi.SelectedIndex = -1
        cbCRow.SelectedIndex = -1
        cbCShelf.SelectedIndex = -1
        txtCsearch.Text = "Search"
        rbCCat.Checked = False
        rbCMat.Checked = False
        xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl", CatalogDataGridView)

    End Sub

    'load catalog record on dgv
    Private Sub btnCSearch_Click(sender As Object, e As EventArgs) Handles btnCSearch.Click
        If rbCCat.Checked Then

            If txtCsearch.Text <> "" Then
                xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl WHERE Catalog_ID =" & txtCsearch.Text, CatalogDataGridView)
            Else
                MsgBox("Please Enter the Catalog ID", MsgBoxStyle.Exclamation, "Warning")
            End If

        ElseIf rbCMat.Checked Then

            If txtCsearch.Text <> "" Then
                xLoadDataToGridview("Catalog_tbl", "SELECT * FROM Catalog_tbl WHERE Material_ID =" & txtCsearch.Text, CatalogDataGridView)
            Else
                MsgBox("Please Enter the Material ID", MsgBoxStyle.Exclamation, "Warning")
            End If

        Else
            MsgBox("Please select the Catalog_ID or Material_ID", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtCsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCsearch.MouseClick
        txtCsearch.Clear()
    End Sub

    'load catalog record on dgv
    Private Sub btnMMfilter_Click(sender As Object, e As EventArgs) Handles btnMMfilter.Click
        If cbMMcity.SelectedIndex <> -1 Then
            xLoadDataToGridview("Member", "SELECT * FROM Member WHERE City = '" & cbMMcity.SelectedValue & "'", MemberDataGridView)

        Else
            MsgBox("Please select the City Filter Option", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtMMSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMMSearch.MouseClick
        txtMMSearch.Clear()
    End Sub

    'load member record on dgv
    Private Sub btnMMSearch_Click(sender As Object, e As EventArgs) Handles btnMMSearch.Click
        If rbMMID.Checked Then
            If txtMMSearch.Text <> "" Then

                xLoadDataToGridview("Member", "SELECT * FROM Member WHERE Member_ID =" & txtMMSearch.Text, MemberDataGridView)

            Else
                MsgBox("Please Enter the Member ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        ElseIf rbMMName.Checked Then
            If txtMMSearch.Text <> "" Then
                xLoadDataToGridview("Member", "SELECT * FROM Member WHERE Name LIKE '%" & txtMMSearch.Text & "%'", MemberDataGridView)
            Else
                MsgBox("Please Enter the Name", MsgBoxStyle.Exclamation, "Warning")
            End If

        ElseIf rbMMnic.Checked Then
            If txtMMSearch.Text <> "" Then
                xLoadDataToGridview("Member", "SELECT * FROM Member WHERE NIC = '" & txtMMSearch.Text & "'", MemberDataGridView)
            Else
                MsgBox("Please Enter the NIC", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Please Select Member ID or NIC or Name Option ", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub rbCMat_MouseClick(sender As Object, e As MouseEventArgs) Handles rbCMat.MouseClick
        txtCsearch.Clear()
    End Sub

    Private Sub rbCCat_MouseClick(sender As Object, e As MouseEventArgs) Handles rbCCat.MouseClick
        txtCsearch.Clear()
    End Sub

    Private Sub rbMMID_MouseClick(sender As Object, e As MouseEventArgs) Handles rbMMID.MouseClick
        txtMMSearch.Clear()
    End Sub

    Private Sub rbMMName_MouseClick(sender As Object, e As MouseEventArgs) Handles rbMMName.MouseClick
        txtMMSearch.Clear()
    End Sub

    Private Sub rbMMnic_MouseClick(sender As Object, e As MouseEventArgs) Handles rbMMnic.MouseClick
        txtMMSearch.Clear()
    End Sub

    'member tab reset
    Private Sub btnMMreset_Click(sender As Object, e As EventArgs) Handles btnMMreset.Click
        txtMMSearch.Text = "Search"
        rbMMID.Checked = False
        rbMMName.Checked = False
        rbMMnic.Checked = False
        cbMMcity.SelectedIndex = -1
        xLoadDataToGridview("Member", "SELECT * FROM Member", MemberDataGridView)
    End Sub

    'fine reset tap
    Private Sub btnFreset_Click(sender As Object, e As EventArgs) Handles btnFreset.Click
        txtFsearch.Text = "Search"
        rbFid.Checked = False
        rbFldid.Checked = False
        cbFpaid.SelectedIndex = -1
        ReloadFineCombobox()
        xLoadDataToGridview("Fine", "SELECT * FROM Fine", FineDataGridView)
        FDataGridViewChange()
    End Sub

    'load fine table to dvg search
    Private Sub btnFsearch_Click(sender As Object, e As EventArgs) Handles btnFsearch.Click
        If rbFid.Checked Then

            If txtFsearch.Text <> "" Then
                xLoadDataToGridview("Fine", "SELECT * FROM Fine WHERE Fine_ID =" & txtFsearch.Text, FineDataGridView)
            Else
                MsgBox("Please Enter the Fine ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        ElseIf rbFldid.Checked Then

            If txtFsearch.Text <> "" Then
                xLoadDataToGridview("Fine", "SELECT * FROM Fine WHERE Lending_ID =" & txtFsearch.Text, FineDataGridView)
            Else
                MsgBox("Please Enter the Lending ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Please Select the Fine ID or Lending ID", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtFsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtFsearch.MouseClick
        txtFsearch.Clear()
    End Sub

    'load fine table to dvg filter
    Private Sub btnFfilter_Click(sender As Object, e As EventArgs) Handles btnFfilter.Click
        If cbFpaid.SelectedIndex <> -1 Then
            xLoadDataToGridview("Fine", "SELECT * FROM Fine WHERE Paid = '" & cbFpaid.SelectedValue & "'", FineDataGridView)
        Else
            MsgBox("Please Select the Paid Filter Option", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    'load lend table  to dvg filter
    Private Sub btnLfilter_Click(sender As Object, e As EventArgs) Handles btnLfilter.Click
        If (cbLstatus.SelectedIndex <> -1) Then
            xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Return = '" & cbLstatus.SelectedValue & "'", LendDatGridView)

        ElseIf cbLDate.Checked Then
            xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Lend_Date BETWEEN #" & dtpLfrom.Value.Date & "# AND #" & dtpLto.Value.Date & "#", LendDatGridView)

        ElseIf cbLstatus.SelectedIndex <> -1 And cbLDate.Checked Then
            'Dim fromDate As String = dtpLfrom.Value.Date
            xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Lend_Date BETWEEN #" & dtpLfrom.Value.Date & "# AND #" & dtpLto.Value.Date & "# AND Return = '" & cbLstatus.SelectedValue & "'", LendDatGridView)
            MsgBox(dtpLfrom.Value.Date)
        Else
            MsgBox("Please Select the Status Or Date Filter Option", MsgBoxStyle.Exclamation, "Warning")
        End If

    End Sub

    'load lend table  to dvg search
    Private Sub btnLsearch_Click(sender As Object, e As EventArgs) Handles btnLsearch.Click
        If rbLlendid.Checked Then
            If txtLsearch.Text <> "" Then
                xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Lending_ID = " & txtLsearch.Text, LendDatGridView)
            Else
                MsgBox("Please Enter the Lending ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        ElseIf rbLmatid.Checked Then
            If txtLsearch.Text <> "" Then
                xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Material_ID = " & txtLsearch.Text, LendDatGridView)
            Else
                MsgBox("Please Enter the Matrial ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        ElseIf rbLmemid.Checked Then
            If txtLsearch.Text <> "" Then
                xLoadDataToGridview("Lend", "SELECT * FROM Lend WHERE Member_ID = " & txtLsearch.Text, LendDatGridView)
            Else
                MsgBox("Please Enter the Member ID", MsgBoxStyle.Exclamation, "Warning")
            End If
        Else
            MsgBox("Please Select Lending ID or Member ID or Material ID", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub txtLsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLsearch.MouseClick
        txtLsearch.Clear()
    End Sub

    'lend tap reset
    Private Sub brnLreset_Click(sender As Object, e As EventArgs) Handles brnLreset.Click
        rbLlendid.Checked = False
        rbLmatid.Checked = False
        rbLmemid.Checked = False
        txtLsearch.Text = "Search"
        cbLstatus.SelectedIndex = -1
        cbLDate.Checked = False
        dtpLfrom.Value = Date.Now
        dtpLto.Value = Date.Now

        xLoadDataToGridview("Lend", "SELECT * FROM Lend", LendDatGridView)
        LDataGridViewChange()
    End Sub
End Class