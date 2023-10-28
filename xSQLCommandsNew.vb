Imports System.Data.OleDb
Module xSQLCommands

    Dim returnVals As String
    Dim returnSetFields As String
    Dim returnCFields As String

    Friend OnOff As Boolean = True


    '-------------------------------------------
    ' Function for get values for SQL command
    '-------------------------------------------

    Function xGetVals(ByVal vals() As String)
        Dim i, x As Integer
        Dim comStr As String = ","
        returnVals = ""

        x = vals.Count - 1

        For i = 0 To x

            If i = x Then
                comStr = ""
            End If

            returnVals = returnVals & "'" & vals(i) & "'" & comStr

        Next

        Return returnVals
    End Function

    '-------------------------------------------
    ' Function for get fields and Values for SQL UPDATE command
    '-------------------------------------------


    Function xGetSetFields(ByVal setFields() As String, ByVal setVals() As String)

        Dim i, x As Integer
        Dim comStr As String = ","
        returnSetFields = ""

        x = setFields.Count - 1

        For i = 0 To x

            If i = x Then
                comStr = ""
            End If

            returnSetFields = returnSetFields & setFields(i) & "=" & "'" & setVals(i) & "'" & comStr

        Next

        Return returnSetFields
    End Function

    '-------------------------------------------
    ' Function for get criteria for SQL UPDATE, DELETE and SELECT Commands
    '-------------------------------------------

    Function xGetCriteria(ByVal cFields() As Object, ByVal cVals() As Object)

        Dim i, x As Integer
        Dim andStr As String = " AND "
        returnCFields = ""


        x = cFields.Count - 1

        For i = 0 To x

            If i = x Then
                andStr = ""
            End If

            If IsNumeric(cVals(i)) Then

                returnCFields = returnCFields & cFields(i) & "=" & cVals(i) & andStr

            Else
                returnCFields = returnCFields & cFields(i) & "=" & "'" & cVals(i) & "'" & andStr

            End If


        Next

        Return returnCFields
    End Function

    '-------------------------------------------
    'Method for SAVE data INTO database 
    '-------------------------------------------
    Friend Sub xSaveDATA(ByVal xTableName As String, ByVal xFields As String, ByVal xValues() As String)
        Dim sql As String

        sql = "INSERT INTO" & " " & xTableName & "(" & xFields & ") VALUES(" & xGetVals(xValues) & ")"

        Dim command1 As New OleDbCommand(sql, xConn)

        Try
            'Switch on success message
            OnOff = True

            xConnopen()
            command1.ExecuteNonQuery()
            xConnClose()


        Catch ex As Exception

            'Switch off success message
            OnOff = False

            xConnClose()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try

    End Sub
    '-------------------------------------------
    'Method for UPDATE data IN a database 
    '-------------------------------------------

    Friend Sub xUpdateDATA(ByVal xTableName As String, ByVal xSFields() As String, ByVal xSVals() As String, ByVal xCondition As String)

        Dim xSQLstr As String

        xSQLstr = "UPDATE " & xTableName & " SET " & xGetSetFields(xSFields, xSVals) & " WHERE " & xCondition

        Dim command1 As New OleDbCommand(xSQLstr, xConn)

        Try
            'Switch on success message
            OnOff = True

            xConnopen()
            command1.ExecuteNonQuery()
            xConnClose()

        Catch ex As Exception

            OnOff = False

            xConnClose()
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    '-------------------------------------------
    'Method for DELETE data IN a database 
    '-------------------------------------------

    Friend Sub xDeleteDATA(ByVal xTableName As String, ByVal xCriteria As String)

        Dim xSQLstr As String

        xSQLstr = "DELETE FROM " & xTableName & " WHERE " & xCriteria

        'Console.WriteLine(xSQLstr)
        Dim command1 As New OleDbCommand(xSQLstr, xConn)

        Try
            'Switch on success message
            OnOff = True

            xConnopen()
            command1.ExecuteNonQuery()
            xConnClose()

        Catch ex As Exception
            'Switch offsuccess message
            OnOff = False

            xConnClose()
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    '-------------------------------------------------
    'Method to Flesh table

    Friend Sub xFlashTable(ByVal xTableName As String)

        Dim xSQLstr As String

        xSQLstr = "DELETE FROM " & xTableName

        ' Console.WriteLine(xSQLstr)
        Dim command1 As New OleDbCommand(xSQLstr, xConn)

        Try
            'Switch on success message
            OnOff = True

            xConnopen()
            command1.ExecuteNonQuery()
            xConnClose()

        Catch ex As Exception
            'Switch offsuccess message
            OnOff = False

            xConnClose()
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Friend Sub xCopy(ByVal FromTable As String, ByVal ToTable As String, ByVal FieldNames As String)

        Dim Sql As String

        Sql = "INSERT INTO " & ToTable & "(" & FieldNames & ") SELECT " & FieldNames & " FROM " & FromTable

        Dim command1 As New OleDbCommand(Sql, xConn)

        Try

            xConnopen()
            command1.ExecuteNonQuery()
            xConnClose()


        Catch ex As Exception

            xConnClose()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try
    End Sub

    Function xRowCount(ByVal colName As String, ByVal tableName As String)

        Dim sql As String
        Dim i As Integer

        sql = "SELECT COUNT(" & colName & ") AS NOS FROM " & tableName

        Try

            xConnopen()

            Dim command As New OleDbCommand(sql, xConn)

            Dim dr As OleDbDataReader

            dr = command.ExecuteReader


            If dr.HasRows Then

                dr.Read()
                i = dr.Item("NOS")
                dr.Close()
            Else

                i = 0

            End If

            xConnClose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xConnClose()
        End Try


        Return i


    End Function

    Friend Sub xLoadDataToGridview(ByVal xTableName As String, ByVal xSQL As String, ByVal xGridview As Windows.Forms.DataGridView)

        Try
            xConnopen()

            Dim table As New DataTable(xTableName)
            Dim da As New OleDbDataAdapter(xSQL, xConn)

            da.Fill(table)

            xGridview.DataSource = table
            xConnClose()
        Catch ex As Exception
            xConnClose()
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Friend Sub xSearchComboBox(ByVal xComboBox As Windows.Forms.ComboBox, ByVal tableName As String, ByVal disAttribute As String, ByVal valAttribute As String, ByVal criteria As String)


        Dim adapter As New OleDbDataAdapter

        Dim ds As New DataSet()
        Dim i As Integer = 0

        Dim sql As String


        sql = "SELECT DISTINCT " & disAttribute & "," & valAttribute & " FROM " & tableName & criteria



        Try
            xConnopen()

            Dim command As New OleDbCommand(sql, xConn)

            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            xConnClose()

            ' xFontS(xComboBox)

            xComboBox.FlatStyle = FlatStyle.Flat
            xComboBox.BackColor = Color.White
            'xComboBox.BackColor = Color.FromArgb(249, 249, 249)
            xComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            xComboBox.AutoCompleteSource = AutoCompleteSource.ListItems

            xComboBox.DataSource = ds.Tables(0)
            xComboBox.ValueMember = valAttribute
            xComboBox.DisplayMember = disAttribute
            xComboBox.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function xReturnValToControl(ByVal tableName As String, ByVal colName() As String, ByVal xControls() As Windows.Forms.Control, ByVal criteria As String)

        Dim sql As String
        Dim returnVal As String = ""
        Dim i As Integer

        sql = "SELECT * FROM " & tableName & " WHERE " & criteria


        Try

            '  MsgBox(sql)
            xConnopen()

            Dim command As New OleDbCommand(sql, xConn)

            Dim dr As OleDbDataReader

            dr = command.ExecuteReader


            If dr.HasRows Then

                dr.Read()

                For i = 0 To colName.Length - 1

                    xControls(i).Text = dr.Item(colName(i))

                Next

                dr.Close()
            Else

                For i = 0 To colName.Length - 1

                    xControls(i).Text = ""

                Next

                returnVal = "Invalid Code"

            End If

            xConnClose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xConnClose()
        End Try


        Return returnVal
    End Function


    Function xCheckPassword(ByVal tableName As String, ByVal criteria As String)

        Dim xpwd As Boolean = False

        Dim sql As String


        sql = "SELECT * FROM " & tableName & " WHERE " & criteria


        Try


            xConnopen()

            Dim command As New OleDbCommand(sql, xConn)

            Dim dr As OleDbDataReader

            dr = command.ExecuteReader


            If dr.HasRows Then

                dr.Read()
                xpwd = True

                dr.Close()
            Else

                xpwd = False

            End If

            xConnClose()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xConnClose()
        End Try


        Return xpwd
    End Function

    Public Sub xGridview(ByVal xgv As Windows.Forms.DataGridView)
        'header style
        With xgv

            .EnableHeadersVisualStyles = False
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 232, 240)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .BackgroundColor = Color.White
            .AllowUserToResizeRows = False

            'Gridview style
            .ReadOnly = True
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Regular)
            .DefaultCellStyle.BackColor = Color.FromArgb(237, 238, 239)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 100, 139)
            .DefaultCellStyle.SelectionForeColor = Color.White
            .ShowCellToolTips = False
            .AllowUserToAddRows = False

        End With



    End Sub
    
End Module
