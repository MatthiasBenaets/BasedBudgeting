Imports System.Windows.Forms.DataVisualization.Charting
Public Class App
    Dim roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Dim filtering = False
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load                  ' When applications loads
        Me.lblDate.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()                           ' Print correct date
        Me.lblDateValue.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()
        Me.dtpDate.Value = DateTime.Now                                                         ' Update DateTimePicker to current date

        If System.IO.Directory.Exists(roaming + "\BasedBudgeting") Then                         ' Check if BasedData exist, if not create it and run SaveTransaction
        Else
            System.IO.Directory.CreateDirectory(roaming + "\BasedBudgeting")
            System.IO.Directory.CreateDirectory(roaming + "\BasedBudgeting\BasedData")
        End If


        For Each column As DataGridViewColumn In dgvBudget.Columns                              ' Disable sorting for dgvBudget
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        Dim rows() As String
        Dim values() As String
        If My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\transactions.csv") Then  ' If saved transaction file exists
            rows = File.ReadAllLines(roaming + "\BasedBudgeting\transactions.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(";")                                          ' Split values at ";"
                Dim row(values.Length - 1) As String
                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j
                dgvTransactions.Rows.Add(row)                                                   ' Add row to datagridview

                Dim toDate As String = dgvTransactions.Rows(i).Cells(1).Value                   ' Change a few types from string to date and dec in dgvTransactions
                dgvTransactions.Rows(i).Cells(1).Value = CType(toDate, Date)
                If dgvTransactions.Rows(i).Cells(6).Value <> "" Then
                    Dim toDec As Decimal = dgvTransactions.Rows(i).Cells(6).Value
                    dgvTransactions.Rows(i).Cells(6).Value = CType(toDec, Decimal)
                End If
                If dgvTransactions.Rows(i).Cells(7).Value <> "" Then
                    Dim toDec = dgvTransactions.Rows(i).Cells(7).Value
                    dgvTransactions.Rows(i).Cells(7).Value = CType(toDec, Decimal)
                End If
            Next i
        End If

        'dgvBudget.Columns(2).ReadOnly = True                                                   ' For not disabled so manual edit is possible, if error made at transactions
        dgvBudget.Columns(3).ReadOnly = True
        If My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\budget.csv") Then       ' If saved budget file exists
            rows = File.ReadAllLines(roaming + "\BasedBudgeting\budget.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(";")                                          ' Split values at ";"
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j
                dgvBudget.Rows.Add(row)                                                         ' Add row to datagridview
            Next i
        End If

        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Give category row a background color
            If dgvBudget.Rows(i).Cells(4).Value = "C" Then
                dgvBudget.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(230, 245, 250)
            End If
            For j As Integer = 1 To 3                                                           ' If there are values imported, convert from string to integer to get correct format
                If dgvBudget.Rows(i).Cells(0).Value = "" Then                                   ' Do nothing if category is not filled
                ElseIf dgvBudget.Rows(i).Cells(j).Value = "" Then                               ' If no value, print 0
                    dgvBudget.Rows(i).Cells(j).Value = 0
                Else                                                                            ' Else convert stored value to double and 
                    Dim toInt As String = dgvBudget.Rows(i).Cells(j).Value
                    dgvBudget.Rows(i).Cells(j).Value = CType(toInt, Decimal)
                End If
            Next
        Next

        If My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\accounts.csv") Then     ' If saved transaction file exists
            rows = File.ReadAllLines(roaming + "\BasedBudgeting\accounts.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(";")                                          ' Split values at ";"
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j

                dgvAccounts.Rows.Add(row)                                                       ' Add row to datagridview
                If dgvAccounts.Rows(i).Cells(1).Value <> "" Then
                    Dim toDec As Decimal = dgvAccounts.Rows(i).Cells(1).Value
                    dgvAccounts.Rows(i).Cells(1).Value = CType(toDec, Decimal)
                End If
            Next i
        End If

        Dim checkedDate As Date
        If My.Settings.startDate = "start" Then                                                 ' If no global date variable exist | used t reset dgvBudget for new month
            My.Settings.startDate = DateTime.Now.ToString("MMM yyyy")
            checkedDate = CType(My.Settings.startDate, DateTime)
        ElseIf DateTime.Now.Year > checkedDate.Year Or DateTime.Now.Month > checkedDate.Month Then  ' Check if global date month is earlier than current date
            Dim writer As New StreamWriter(CStr(roaming + "\BasedBudgeting\BasedData\" + checkedDate.ToString("MMM yyyy") + ".csv"))
            For i As Integer = 0 To dgvBudget.Rows.Count - 1 Step +1                            ' Save dgvBudget
                For j As Integer = 0 To dgvBudget.Columns.Count - 1 Step +1
                    If j = dgvBudget.Columns.Count - 1 Then
                        writer.Write(dgvBudget.Rows(i).Cells(j).Value)
                    Else
                        writer.Write(dgvBudget.Rows(i).Cells(j).Value & ";")
                    End If
                Next j
                writer.WriteLine("")
            Next i
            writer.Close()

            My.Settings.startDate = DateTime.Now.ToString("MMM yyyy")                           ' Reset global dat to current date

            For Each row As DataGridViewRow In dgvBudget.Rows
                row.Cells(2).Value = 0                                                          ' Reset activity for new month
            Next
        End If

        If dgvTransactions.Rows.Count <> 0 Then                                                 ' Check if navigation button should be available
            btnReports.Visible = True
        End If
        If dgvAccounts.Rows.Count <> 0 Then
            btnAccounts.Visible = True
        End If

        dgvAccounts.Columns(1).ReadOnly = True
        For j As Integer = 0 To dgvAccounts.Rows.Count - 1                                      ' Add up total balance
            Dim toDec As Decimal
            toDec = lblTotalBalance.Text + dgvAccounts.Rows(j).Cells(1).Value
            lblTotalBalance.Text = toDec.ToString("C")
        Next
    End Sub
    Private Sub App_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed              ' When application closes
        dgvDateChange(DateTime.Now.ToString("MMM yyyy").ToUpper())                              ' Reset dgvBudget back to present so it is saved correctly
        SaveData()
        My.Settings.Reset()
    End Sub
    Private Sub BtnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click       ' When Budget menu is selected
        btnBudget.BackColor = Color.FromArgb(0, 90, 120)                                        ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(45, 150, 175)
        btnAccounts.BackColor = Color.FromArgb(45, 150, 175)
        pnlBudgetStatistics.Visible = True                                                      ' Show correct panels for selected menu
        pnlBudgetControl.Visible = True
        pnlReportsStatistics.Visible = False
        pnlReportsCharts.Visible = False
        pnlAccountsTransaction.Visible = False
        pnlAccountsFilter.Visible = False
        dgvTransactions.Visible = False
        pnlToBeBudgeted.Visible = True
        pnlWorkingBalance.Visible = False
        pnlReports.Visible = False
        dgvBudget.Visible = True
        dgvBudget.Refresh()
    End Sub
    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click     ' When Reports button is selected
        btnBudget.BackColor = Color.FromArgb(45, 150, 175)                                      ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(0, 90, 120)
        btnAccounts.BackColor = Color.FromArgb(45, 150, 175)
        pnlBudgetStatistics.Visible = False                                                     ' Show correct panels for selected menu
        pnlBudgetControl.Visible = False
        pnlReportsStatistics.Visible = True
        pnlReportsCharts.Visible = True
        pnlAccountsTransaction.Visible = False
        pnlAccountsFilter.Visible = False
        dgvBudget.Visible = False
        dgvTransactions.Visible = False
        pnlToBeBudgeted.Visible = False
        pnlWorkingBalance.Visible = False
        pnlReports.Visible = True

        populateCharts()
    End Sub
    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click   ' When Accounts button is selected
        btnBudget.BackColor = Color.FromArgb(45, 150, 175)                                      ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(45, 150, 175)
        btnAccounts.BackColor = Color.FromArgb(0, 90, 120)
        pnlBudgetStatistics.Visible = False                                                     ' Show correct panels for selected menu
        pnlBudgetControl.Visible = False
        pnlReportsStatistics.Visible = False
        pnlReportsCharts.Visible = False
        pnlAccountsTransaction.Visible = True
        pnlAccountsFilter.Visible = True
        dgvBudget.Visible = False
        dgvTransactions.Visible = True
        pnlToBeBudgeted.Visible = False
        pnlWorkingBalance.Visible = True
        pnlReports.Visible = False
        checkCombobox()
        dgvTransactions.Refresh()                                                               ' Precaution visual bug
    End Sub
    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click ' Add category at end of dgvBudget
        Dim strCat As String
        Dim test As Integer = dgvBudget.Rows.Count
        strCat = InputBox("Please give a category name", "Category")
        For Each row As DataGridViewRow In dgvBudget.Rows                                       ' If category already exists, don't add it
            If strCat = row.Cells(0).Value.ToString Then
                MsgBox("Category already exists")
                Exit Sub
            End If
        Next
        dgvBudget.Rows.Add(strCat, 0, 0, 0, "C")
        dgvBudget.Rows(test).DefaultCellStyle.BackColor = Color.FromArgb(230, 245, 250)         ' Change background 
        dgvBudget.Rows.Add("", "", "", "", "S")
    End Sub
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click   ' When Add Account buttin is clicked
        Dim accounts(2)
        accounts(0) = InputBox("Name of account")                                               ' Inputbox to get info from user
        If accounts(0) <> "" Then                                                               ' If answer is canceled. Do nothing
            accounts(1) = InputBox("Balance of " & accounts(0) & ".")
            If accounts(1) <> "" Then
                dgvAccounts.Rows.Add(accounts)                                                  ' Add info to DataGridView

                For i As Integer = 0 To dgvAccounts.Rows.Count - 1                              ' Add up total balance and change format of added account balance
                    Dim toDec As Decimal
                    Dim totDec As Decimal
                    toDec = dgvAccounts.Rows(i).Cells(1).Value
                    dgvAccounts.Rows(i).Cells(1).Value = toDec.ToString("C")
                    totDec += dgvAccounts.Rows(i).Cells(1).Value
                    lblTotalBalance.Text = totDec.ToString("C")
                Next
                SaveAccounts()
            End If
        End If
    End Sub
    Private Sub dgvAccounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellEndEdit
        SaveAccounts()
    End Sub
    Private Sub dgvBudget_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBudget.CellEndEdit  ' Used to automatically add rows in dgvBudget and update total available
        If dgvBudget.CurrentCell.RowIndex = 0 Then
            For Each row As DataGridViewRow In dgvBudget.Rows                                   ' If subcategory already exists, don't add it
                If dgvBudget.CurrentCell.Value.ToString = row.Cells(0).Value.ToString Then
                    dgvBudget.CurrentCell.Value = ""
                    MsgBox("Subcategory already exists")
                    Exit Sub
                End If
            Next
        End If

        If dgvBudget.CurrentCell.ColumnIndex > 0 Then                                           ' Check if category cell is selected
        ElseIf dgvBudget.CurrentCell.Value <> "" And
                dgvBudget.Rows(e.RowIndex).Cells(1).Value.ToString <> "" And
                dgvBudget.Rows(e.RowIndex).Cells(2).Value.ToString <> "" And
                dgvBudget.Rows(e.RowIndex).Cells(3).Value.ToString <> "" Then
        ElseIf dgvBudget.Rows(e.RowIndex).Cells(4).Value = "S" Then                             ' If selected cell is a subcategory
            If dgvBudget.Rows(e.RowIndex).Cells(0).Value = "" Then                              ' And if value is not null after edit - nothing
            ElseIf dgvBudget.CurrentCell.Value <> "" And                                        ' If not filled yet but category name is given
                dgvBudget.Rows(e.RowIndex).Cells(1).Value.ToString = "" And
                dgvBudget.Rows(e.RowIndex).Cells(2).Value.ToString = "" And
                dgvBudget.Rows(e.RowIndex).Cells(3).Value.ToString = "" Then
                dgvBudget.Rows(e.RowIndex).Cells(1).Value = 0
                dgvBudget.Rows(e.RowIndex).Cells(2).Value = 0
                dgvBudget.Rows(e.RowIndex).Cells(3).Value = 0
                dgvBudget.Rows.Insert(e.RowIndex + 1, "", "", "", "", "S")
            Else                                                                                ' else insert a new row in category
                dgvBudget.Rows.Insert(e.RowIndex + 1, "", "", "", "", "S")
            End If
        End If

        If dgvBudget.CurrentCell.ColumnIndex = 1 Or dgvBudget.CurrentCell.ColumnIndex = 2 Then  ' Convert given value to decimal currency
            dgvBudget.CurrentCell.Value = CType(dgvBudget.CurrentCell.Value, Decimal).ToString("C")
        End If

        Dim totBudgeted As Decimal = 0
        Dim indexCount As Integer = 0
        If dgvBudget.CurrentCell.ColumnIndex = 1 Then                                           ' Update available after edit in budgeted
            dgvBudget.Rows(e.RowIndex).Cells(3).Value = CType(dgvBudget.Rows(e.RowIndex).Cells(1).Value, Decimal) + CType(dgvBudget.Rows(e.RowIndex).Cells(2).Value, Decimal)
            For i As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Update total budgeted of category, below edit
                If dgvBudget.Rows(e.RowIndex + i).Cells(0).Value.ToString <> "" And dgvBudget.Rows(e.RowIndex + i).Cells(4).Value.ToString = "S" Then
                    totBudgeted += CType(dgvBudget.Rows(e.RowIndex + i).Cells(1).Value, Decimal)
                Else
                    i = dgvBudget.Rows.Count - 1
                End If
            Next
            For i As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' above edit, until category titel 
                If dgvBudget.Rows(e.RowIndex - i).Cells(0).Value.ToString <> "" And dgvBudget.Rows(e.RowIndex - i).Cells(4).Value.ToString = "S" Then
                    totBudgeted += CType(dgvBudget.Rows(e.RowIndex - i).Cells(1).Value, Decimal)
                    indexCount += 1
                Else
                    dgvBudget.Rows(e.RowIndex - indexCount).Cells(1).Value = totBudgeted - CType(dgvBudget.Rows(e.RowIndex).Cells(1).Value, Decimal)    ' Change total budgeted for category
                    i = dgvBudget.Rows.Count - 1
                End If
            Next
        End If

        For j As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Calculate total available for the category
            Dim totAvailable As Decimal = 0
            Dim l = j + 1
            For k As Integer = dgvBudget.CurrentCell.RowIndex - indexCount + 1 To dgvBudget.Rows.Count - 1
                If dgvBudget.Rows(k).Cells(0).Value.ToString <> "" Then
                    totAvailable += CType(dgvBudget.Rows(k).Cells(3).Value, Decimal)
                Else
                    k = dgvBudget.Rows.Count - 1
                End If
            Next
            'dgvBudget.Rows(j).Cells(3).Value = totAvailable
            dgvBudget.Rows(e.RowIndex - indexCount).Cells(3).Value = totAvailable
        Next
        dgvBudget.Refresh()                                                                     ' Precaution visual bug
    End Sub
    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellEndEdit
        Dim toDec As Decimal = 0
        If dgvTransactions.CurrentCell.ColumnIndex = 6 Then                                     ' After edit, change value to correct format
            If dgvTransactions.CurrentCell.Value Is Nothing Then
            Else
                toDec = dgvTransactions.CurrentCell.Value
                dgvTransactions.CurrentCell.Value = toDec.ToString("C")
            End If
        End If
        toDec = 0
        If dgvTransactions.CurrentCell.ColumnIndex = 7 Then
            If dgvTransactions.CurrentCell.Value Is Nothing Then
            Else
                toDec = dgvTransactions.CurrentCell.Value
                dgvTransactions.CurrentCell.Value = toDec.ToString("C")
            End If
        End If
    End Sub
    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged   ' When text in cbCategory changes
        Dim catText As String = cbCategory.Text
        cbSubcategory.Text = ""
        cbSubcategory.Items.Clear()
        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Populate combobox with correct items (from category - subcategory)
            If dgvBudget.Rows(i).Cells(0).Value.ToString = catText Then
                i += 1
                For j As Integer = i To dgvBudget.Rows.Count - 1
                    If dgvBudget.Rows(j).Cells(4).Value.ToString = "S" And dgvBudget.Rows(j).Cells(0).Value.ToString <> "" Then
                        cbSubcategory.Items.Add(dgvBudget.Rows(j).Cells(0).Value.ToString)
                    Else
                        j = dgvBudget.Rows.Count - 1
                    End If
                Next
                i = dgvBudget.Rows.Count - 1
            End If
        Next
        cbSubcategory.Enabled = True                                                            ' Enable cbSubcategory so it can be selected.

        If cbCategory.Text = "To Be Budgeted" Then                                              ' If category is "To be budgeted", do next...
            cbSubcategory.Items.Add("No subcategory")
            cbSubcategory.Text = "No subcategory"
            cbSubcategory.Enabled = False
            tbOutflow.Text = ""
            tbOutflow.Enabled = False
        End If
    End Sub
    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click   ' When transaction add button is clicked
        Dim traOutflow As Boolean = False
        Dim traInflow As Boolean = False
        Dim traTransfer As Boolean = False
        Dim toDec As Decimal
        Dim i = 0
        If dgvTransactions.Rows.Count = 0 Then                                                  ' Loop to check where in DataGridView data needs to be stored
            i = 0                                                                               ' If no transactions, will inserted at x=0
        Else
            For j As Integer = 0 To dgvTransactions.Rows.Count - 1                              ' Loop through whole transactions list
                If dtpDate.Value < dgvTransactions.Rows(j).Cells(1).Value Then                  ' Count if date is lower than transaction to know where to place new transactions
                    i += 1
                End If
            Next
        End If

        If cbAccount.Text = "" Or cbPayee.Text = "" Or cbCategory.Text = "" Or cbSubcategory.Text = "" Then ' If labels are not filled
            MsgBox("not all information needed given")
        ElseIf tbOutflow.Text = "" And tbInflow.Text = "" Then                                  ' If outflow or inflow is not filled
            MsgBox("Either enter a inflow or outflow value")
        Else
            If IsNumeric(tbOutflow.Text) Then                                                   ' Print data to DataGridView on correct row.
                dgvTransactions.Rows.Insert(i, cbAccount.Text, CType(dtpDate.Text, Date), cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, CType(tbOutflow.Text, Decimal), tbInflow.Text)
                traOutflow = True
            ElseIf IsNumeric(tbInflow.Text) Then                                                ' Thus no date filter required
                dgvTransactions.Rows.Insert(i, cbAccount.Text, CType(dtpDate.Text, Date), cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, tbOutflow.Text, CType(tbInflow.Text, Decimal))
                traInflow = True
            Else
                MsgBox("Transaction value not a number")
            End If
            btnReports.Visible = True


            For j As Integer = 0 To dgvAccounts.Rows.Count - 1
                If cbPayee.Text = dgvAccounts.Rows(j).Cells(0).Value.ToString Then              ' If cbPayee is a category, it is a transfer
                    traTransfer = True
                    j = dgvAccounts.Rows.Count - 1
                Else
                    traTransfer = False
                End If
            Next

            If traTransfer = True Then                                                          ' Check if normal transaction or transfer
                For j As Integer = 0 To dgvAccounts.Rows.Count - 1
                    If cbPayee.Text = dgvAccounts.Rows(j).Cells(0).Value.ToString Then          ' Find correct account and add or subtract from account
                        If traOutflow = True Then
                            dgvAccounts.Rows(j).Cells(1).Value += CType(tbOutflow.Text, Decimal)
                        ElseIf traInflow = True Then
                            dgvAccounts.Rows(j).Cells(1).Value -= CType(tbInflow.Text, Decimal)
                        End If
                    End If
                    If cbAccount.Text = dgvAccounts.Rows(j).Cells(0).Value.ToString Then
                        If traOutflow = True Then
                            dgvAccounts.Rows(j).Cells(1).Value -= CType(tbOutflow.Text, Decimal)
                        ElseIf traInflow = True Then
                            dgvAccounts.Rows(j).Cells(1).Value += CType(tbInflow.Text, Decimal)
                        End If
                    End If
                Next
            ElseIf traTransfer = False Then
                For j As Integer = 0 To dgvAccounts.Rows.Count - 1
                    If dgvAccounts.Rows(j).Cells(0).Value.ToString = cbAccount.Text Then        ' Add or subtract value and count total balance
                        If traOutflow = True Then                                               ' Check if its outflow or inflow
                            dgvAccounts.Rows(j).Cells(1).Value -= CType(tbOutflow.Text, Decimal)
                            toDec = CType(lblTotalBalance.Text, Decimal) - CType(tbOutflow.Text, Decimal)
                            lblTotalBalance.Text = toDec.ToString("C")
                        ElseIf traInflow = True Then
                            dgvAccounts.Rows(j).Cells(1).Value += CType(tbInflow.Text, Decimal)
                            toDec = CType(lblTotalBalance.Text, Decimal) + CType(tbInflow.Text, Decimal)
                            lblTotalBalance.Text = toDec.ToString("C")
                        End If
                    End If
                Next
            End If

            For j As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Add transaction to activity tab in dgvBudget
                If traOutflow = True And cbCategory.Text <> "Transfer" And cbCategory.Text <> "To Be Budgeted" Then
                    If dgvBudget.Rows(j).Cells(0).Value.ToString = cbSubcategory.Text Then
                        toDec = CType(dgvBudget.Rows(j).Cells(2).Value, Decimal) - CType(tbOutflow.Text, Decimal)
                        dgvBudget.Rows(j).Cells(2).Value = toDec.ToString("C")
                        toDec = CType(dgvBudget.Rows(j).Cells(3).Value, Decimal) - CType(tbOutflow.Text, Decimal)
                        dgvBudget.Rows(j).Cells(3).Value = toDec.ToString("C")
                    End If
                ElseIf traInflow = True And cbCategory.Text <> "Transfer" And cbCategory.Text <> "To Be Budgeted" Then
                    If dgvBudget.Rows(j).Cells(0).Value.ToString = cbSubcategory.Text Then
                        toDec = CType(dgvBudget.Rows(j).Cells(2).Value, Decimal) + CType(tbInflow.Text, Decimal)
                        dgvBudget.Rows(j).Cells(2).Value = toDec.ToString("C")
                        toDec = CType(dgvBudget.Rows(j).Cells(3).Value, Decimal) + CType(tbInflow.Text, Decimal)
                        dgvBudget.Rows(j).Cells(3).Value = toDec.ToString("C")
                    End If
                End If
            Next
            For j As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Calculate total activity for the category
                If cbCategory.Text = dgvBudget.Rows(j).Cells(0).Value.ToString Then
                    Dim totActivity As Decimal = 0
                    Dim totAvailable As Decimal = 0
                    Dim l = j + 1
                    For k As Integer = l To dgvBudget.Rows.Count - 1
                        If dgvBudget.Rows(k).Cells(0).Value.ToString <> "" Then
                            totActivity += CType(dgvBudget.Rows(k).Cells(2).Value, Decimal)
                            totAvailable += CType(dgvBudget.Rows(k).Cells(3).Value, Decimal)
                        Else
                            k = dgvBudget.Rows.Count - 1
                        End If
                    Next
                    dgvBudget.Rows(j).Cells(2).Value = totActivity
                    dgvBudget.Rows(j).Cells(3).Value = totAvailable
                End If
            Next

            SaveTransaction()

            cbAccount.Items.Clear()                                                             ' Reset transaction menu to default
            dtpDate.Text = DateTime.Now
            cbPayee.Text = ""
            cbCategory.Items.Clear()
            cbCategory.Enabled = True
            cbSubcategory.Items.Clear()
            cbSubcategory.Enabled = False
            tbMemo.Text = ""
            tbOutflow.Text = ""
            tbOutflow.Enabled = True
            tbInflow.Text = ""
            traOutflow = False
            traInflow = False
            traTransfer = False

            checkCombobox()
        End If
    End Sub
    Private Sub cbPayee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayee.TextChanged  ' When text changes inside the Payee combobox
        Dim traOutflow As Boolean = False
        Dim traInflow As Boolean = False
        Dim traTransfer As Boolean = False
        For j As Integer = 0 To dgvAccounts.Rows.Count - 1
            If cbPayee.Text = dgvAccounts.Rows(j).Cells(0).Value.ToString Then                  ' If cbPayee is a category, it is a transfer
                traTransfer = True
                j = dgvAccounts.Rows.Count - 1
            Else
                traTransfer = False
            End If
        Next

        If traTransfer = True Then                                                              ' Check if normal transaction or transfer
            cbCategory.Items.Add("Transfer")                                                    ' Add extra items for combobox
            cbCategory.Text = "Transfer"
            cbCategory.Enabled = False
            cbSubcategory.Items.Add("No subcategory")
            cbSubcategory.Text = "No subcategory"
            cbSubcategory.Enabled = False
            tbMemo.Text = "Transfer"
        Else                                                                                    ' Remove limitations if changing back to external payee
            cbCategory.Enabled = True
            cbCategory.Items.Remove("Transfer")
            cbCategory.Text = ""
            cbSubcategory.Items.Remove("No subcategory")
            cbSubcategory.Text = ""
        End If
    End Sub
    Private Sub tbOutflow_TextChanged(sender As Object, e As EventArgs) Handles tbOutflow.TextChanged   ' When textinput from outflow changes
        If tbOutflow.Text = "" Then                                                             ' If outflow textinput = empty, enable inflow
            tbInflow.Enabled = True
        Else                                                                                    ' Else disable inflow textbox
            tbInflow.Enabled = False
        End If
    End Sub
    Private Sub tbInflow_TextChanged(sender As Object, e As EventArgs) Handles tbInflow.TextChanged ' When textinput from inflow changes
        If tbInflow.Text = "" Then                                                              ' If inflow textinput = empty, enable outflow
            tbOutflow.Enabled = True
        Else                                                                                    ' Else disable outflow textbox
            tbOutflow.Enabled = False
        End If
    End Sub
    Private Sub populateCharts()
        populateNetWorth()
        populateSpending()
        populateTrend()
    End Sub
    Private Sub populateNetWorth()                                                              ' Add values to chart one in reports
        Dim rowsAcc() As String = File.ReadAllLines(roaming + "\BasedBudgeting\accounts.csv")
        Dim accVal() As String
        Dim xAcc(rowsAcc.Length) As String
        Dim yAcc(rowsAcc.Length) As Double
        Dim seriesAcc As String = Nothing
        Dim j As Integer = 0

        For i As Integer = 0 To rowsAcc.Length - 1 Step +1                                      ' Looping through all accounts
            accVal = rowsAcc(j).ToString().Split(";")
            xAcc(j) = accVal(0)
            yAcc(j) = accVal(1)
            j += 1
        Next i

        chNet.Series.Clear()                                                                    ' Clear chart before fill so no exceptions are generated
        chNet.Titles.Clear()
        seriesAcc = "chNet"                                                                     ' Unique chart name
        chNet.Series.Add(seriesAcc)
        chNet.Series(seriesAcc).Points.DataBindXY(xAcc, yAcc)
        chNet.Series(seriesAcc).ChartType = DataVisualization.Charting.SeriesChartType.Pie      ' Define chart type
        chNet.Legends(0).Enabled = True                                                         ' Chart legend
        For Each dp As DataPoint In chNet.Series(seriesAcc).Points
            If dp.YValues(0) = 0.0 Then
                dp.LabelForeColor = Color.Transparent
            End If
        Next
        chNet.Series("chNet").IsValueShownAsLabel = True
    End Sub
    Private Sub populateSpending()                                                              ' Add values to chart two in reports
        Dim rowsTra() As String = File.ReadAllLines(roaming + "\BasedBudgeting\transactions.csv")
        Dim traVal() As String
        Dim preMonth As DateTime = DateTime.Now.AddMonths(-1)
        Dim traDate As DateTime
        Dim xTra(rowsTra.Length) As String
        Dim yTra(rowsTra.Length) As Double
        Dim seriesTra As String = Nothing
        Dim j As Integer = 0
        Dim k As Integer
        Dim l As Boolean

        For i As Integer = 0 To rowsTra.Length - 1 Step +1                                      ' Looping through all transactions
            traVal = rowsTra(j).ToString().Split(";")
            traDate = Convert.ToDateTime(traVal(1))
            If (traDate >= preMonth) Then                                                       ' Check if date is not older than 30 days
                k = 0
                l = False
                While k < xTra.Length
                    If traVal(6) = "" Or dgvTransactions.Rows(i).Cells(4).Value.ToString = "No subcategory" Then ' If outflow does not exist (its probably inflow transaction), skip
                        k += 1
                        l = True
                    Else
                        If xTra(k) = traVal(4) Then
                            yTra(k) = yTra(k) + traVal(6)
                            l = True
                            k = xTra.Length
                        End If
                        k += 1
                    End If
                End While

                If l = False Then
                    xTra(j) = traVal(4)
                    yTra(j) = traVal(6)
                End If
            Else
                i = rowsTra.Length - 1                                                          ' Quit loop if month ends (will only work if csv is chronological
            End If
            j += 1
        Next i

        chSpending.Series.Clear()                                                               ' Clear chart before fill so no exceptions are generated
        chSpending.Titles.Clear()
        seriesTra = "chSpending"                                                                ' Unique chart name
        chSpending.Series.Add(seriesTra)
        chSpending.Series(seriesTra).Points.DataBindXY(xTra, yTra)
        chSpending.Series(seriesTra).ChartType = DataVisualization.Charting.SeriesChartType.Doughnut ' Define chart type
        chSpending.Legends(0).Enabled = True                                                    ' Chart legend
        For Each dp As DataPoint In chSpending.Series(seriesTra).Points
            If dp.YValues(0) = 0.0 Then
                dp.LabelForeColor = Color.Transparent
            End If
        Next
        chSpending.Series("chSpending").IsValueShownAsLabel = True                              ' Show value instead of name for chart items
    End Sub
    Private Sub populateTrend()                                                                 ' Add values to chart three in reports
        Dim rowsTra() As String = File.ReadAllLines(roaming + "\BasedBudgeting\transactions.csv")
        Dim traVal() As String
        Dim strCat As String = ""
        Dim strDate As String = ""
        Dim preYear As DateTime = DateTime.Now.AddYears(-1)                                     ' Start date for all visible transactions in chart
        Dim dtTrend As DataTable = New DataTable
        dtTrend.Columns.Add("outflow", GetType(Double))                                         ' Columns for DataTable
        dtTrend.Columns.Add("date", GetType(String))
        dtTrend.Columns.Add("category", GetType(String))
        Dim valExist As Boolean
        Dim l As Integer = 0
        Dim m As Integer = 0

        For i As Integer = 0 To rowsTra.Length - 1 Step +1                                      ' Loop all transactions to add to DataTable and list all dates and categories
            traVal = rowsTra(l).ToString().Split(";")
            Dim traDate As String = Convert.ToDateTime(traVal(1))
            Dim traMonth = CDate(traVal(1)).ToString("MMM yyyy")                                ' Convert to Month Year
            If (traDate >= preYear) Then                                                        ' Check if date is not older than 1 year
                If traVal(6) = "" Or dgvTransactions.Rows(i).Cells(4).Value.ToString = "No subcategory" Then ' Transactions are sometimes "", in this case, change to 0
                Else
                    If dtTrend.Rows.Count = 0 Then                                              ' First transaction loop
                        dtTrend.Rows.Add(traVal(6), traMonth, traVal(4))                        ' Add row to DataTable in order "outflow/date/category"
                    Else                                                                        ' If not first transaction
                        m = 0
                        valExist = False                                                        ' Reset valExist to false
                        While m < dtTrend.Rows.Count                                            ' Loop DataTable, used to add outflow to existing categories
                            If dtTrend.Rows(m)(1).ToString = traMonth And dtTrend.Rows(m)(2) = traVal(4) Then   ' Check if date and category match between DataTable and Transactions 
                                dtTrend.Rows(m)(0) = dtTrend.Rows(m)(0) + traVal(6)             ' Add outflow to existing DataTable row
                                m = dtTrend.Rows.Count
                                valExist = True
                            End If
                            m += 1
                        End While

                        If valExist = False Then                                                ' If combo of date and subcategory does not exist:
                            dtTrend.Rows.Add(traVal(6), traMonth, traVal(4))                    ' Add new line to DataTable
                        End If
                    End If

                    If strCat = "" Then                                                         ' If string has no value (first loop). Used to create list of subcategories
                        strCat = traVal(4)
                    ElseIf strCat.Contains(traVal(4)) Then                                      ' Check if category already exist in the string
                    Else
                        strCat = strCat + ";" + traVal(4)
                    End If
                    If strDate = "" Then                                                        ' Ditto about but for Date
                        strDate = traMonth
                    ElseIf strDate.Contains(traMonth) Then
                    Else
                        strDate = strDate + ";" + traMonth
                    End If
                End If
            Else
                i = rowsTra.Length - 1                                                          ' Quit loop if year ends (will only work if csv is chronological
            End If
            l += 1
        Next

        Dim arrCat() As String = strCat.Split(";")                                              ' Split string to use in array
        Dim arrDate() As String = strDate.Split(";")
        Dim tfMatch As Boolean
        For i As Integer = 0 To arrCat.Length - 1 Step +1                                       ' Loop existing categories, used to add non existing row
            For j As Integer = 0 To arrDate.Length - 1 Step +1                                  ' Loop existing dates, rows need to be added to get full series
                Dim dtRows = dtTrend.Rows.Count
                For k As Integer = 0 To dtRows - 1                                              ' Loop through original DataTable values
                    If dtTrend.Rows(k)(1) = arrDate(j) And dtTrend.Rows(k)(2) = arrCat(i) Then  ' Check if date and categorys match anywhere in the DataTable
                        tfMatch = True
                    End If
                Next
                If tfMatch = True Then                                                          ' If match, reset and search with next date
                    tfMatch = False
                Else
                    dtTrend.Rows.Add(0, arrDate(j), arrCat(i))                                  ' If no match, add as new row in DataTable
                    tfMatch = False                                                             ' Reset, moving to next category
                End If
            Next
        Next

        Dim dv As DataView = New DataView(dtTrend)
        dv.Sort = "date desc"

        chTrend.Series.Clear()                                                                  ' Clear chart before fill so no exceptions are generated
        chTrend.Titles.Clear()
        chTrend.DataManipulator.FilterSetEmptyPoints = True                                     ' Filter to get correct stack
        chTrend.DataManipulator.FilterMatchedPoints = True
        chTrend.DataBindCrossTable(dv, "category", "date", "outflow", "Label=outflow")          ' Populate chart

        For Each cs As Series In chTrend.Series                                                 ' Removes labels of newly added rows with value "0"
            chTrend.DataManipulator.Filter(DataVisualization.Charting.CompareMethod.EqualTo, 0, cs)   'Compare if equal to zero, filter out
            cs.ChartType = SeriesChartType.StackedColumn                                        ' Chart type
            'Dim dpcp As DataPointCustomProperties = New DataPointCustomProperties
        Next
    End Sub
    Private Sub SaveData()
        SaveBudget()
        SaveAccounts()
        SaveTransaction()
    End Sub
    Private Sub SaveBudget()
        Dim writer As New StreamWriter(CStr(roaming + "\BasedBudgeting\budget.csv"))
        For i As Integer = 0 To dgvBudget.Rows.Count - 1 Step +1                                ' Loop through all rows
            For j As Integer = 0 To dgvBudget.Columns.Count - 1 Step +1                         ' Loop through all columns within the row
                If j = dgvBudget.Columns.Count - 1 Then                                         ' Print values with ";", except last column
                    writer.Write(dgvBudget.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvBudget.Rows(i).Cells(j).Value & ";")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub
    Private Sub SaveAccounts()
        Dim writer As New StreamWriter(CStr(roaming + "\BasedBudgeting\accounts.csv"))
        For i As Integer = 0 To dgvAccounts.Rows.Count - 1 Step +1                              ' Loop through all rows
            For j As Integer = 0 To dgvAccounts.Columns.Count - 1 Step +1                       ' Loop through all columns within the row
                If j = dgvAccounts.Columns.Count - 1 Then                                       ' Print values with ";", except last column
                    writer.Write(dgvAccounts.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvAccounts.Rows(i).Cells(j).Value & ";")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub
    Private Sub SaveTransaction()
        Dim writer As New StreamWriter(CStr(roaming + "\BasedBudgeting\transactions.csv"))
        For i As Integer = 0 To dgvTransactions.Rows.Count - 1 Step +1                          ' Loop through all rows
            For j As Integer = 0 To dgvTransactions.Columns.Count - 1 Step +1                   ' Loop through all columns within the row
                If j = dgvTransactions.Columns.Count - 1 Then                                   ' Print values with ";", except last column
                    writer.Write(dgvTransactions.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvTransactions.Rows(i).Cells(j).Value & ";")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub
    Private Sub checkCombobox()
        If cbCategory.Text = "" Then                                                            ' Populate combobox with correct items (category)
            cbCategory.Items.Clear()
            cbCategory.Items.Add("To Be Budgeted")
            For i As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Add correct info to combobox category
                If dgvBudget.Rows(i).Cells(4).Value.ToString = "C" Then
                    If dgvBudget.Rows(i).Cells(0).Value.ToString <> "" Then
                        cbCategory.Items.Add(dgvBudget.Rows(i).Cells(0).Value.ToString)
                    End If
                End If
            Next
        End If
        If cbCategoryFilter.Text = "" Then                                                      ' Populate combobox with correct items (category)
            cbCategoryFilter.Items.Clear()
            For i As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Add correct info to combobox category
                If dgvBudget.Rows(i).Cells(4).Value.ToString = "C" Then
                    If dgvBudget.Rows(i).Cells(0).Value.ToString <> "" Then
                        cbCategoryFilter.Items.Add(dgvBudget.Rows(i).Cells(0).Value.ToString)
                    End If
                End If
            Next
        End If
        If cbSubcategoryFilter.Text = "" Then                                                   ' Populate combobox with correct items (category)
            cbSubcategoryFilter.Items.Clear()
            For i As Integer = 0 To dgvBudget.Rows.Count - 1                                    ' Add correct info to combobox category
                If dgvBudget.Rows(i).Cells(4).Value.ToString = "S" Then
                    If dgvBudget.Rows(i).Cells(0).Value.ToString <> "" Then
                        cbSubcategoryFilter.Items.Add(dgvBudget.Rows(i).Cells(0).Value.ToString)
                    End If
                End If
            Next
        End If

        If cbAccount.Text = "" Then
            cbAccount.Items.Clear()                                                             ' Clear combobox
            For i As Integer = 0 To dgvAccounts.Rows.Count - 1                                  ' Add correct info to combobox account/payee
                cbAccount.Items.Add(dgvAccounts.Rows(i).Cells(0).Value.ToString)                ' Add to combobox items
            Next
        End If
        If cbPayee.Text = "" Then
            cbPayee.Items.Clear()
            For i As Integer = 0 To dgvAccounts.Rows.Count - 1                                  ' Add correct info to combobox account/payee
                cbPayee.Items.Add(dgvAccounts.Rows(i).Cells(0).Value.ToString)
            Next
        End If
        If cbAccountFilter.Text = "" Then
            cbAccountFilter.Items.Clear()
            For i As Integer = 0 To dgvAccounts.Rows.Count - 1                                  ' Add correct info to combobox account/payee
                cbAccountFilter.Items.Add(dgvAccounts.Rows(i).Cells(0).Value.ToString)
            Next
        End If
        If cbPayee.Text = "" Then
            cbPayeeFilter.Items.Clear()
            For i As Integer = 0 To dgvAccounts.Rows.Count - 1                                  ' Add correct info to combobox account/payee
                cbPayeeFilter.Items.Add(dgvAccounts.Rows(i).Cells(0).Value.ToString)
            Next
        End If
    End Sub
    Private Sub checkVariables_Tick(sender As Object, e As EventArgs) Handles checkVariables.Tick   ' Ticker every 0.5 second
        If dgvTransactions.Rows.Count = 0 Then                                                  ' Check if there are transactions to show reports
            btnReports.Visible = False
        ElseIf lblDate.Text <> DateTime.Now.ToString("MMM yyyy").ToUpper() Then                 ' If lbldate is different from current date, hide buttons
            btnReports.Visible = False
        Else
            btnReports.Visible = True
        End If
        If dgvAccounts.Rows.Count = 0 Then                                                      ' Check if there are any accounts to show transactions menu
            btnAccounts.Visible = False
        ElseIf lblDate.Text <> DateTime.Now.ToString("MMM yyyy").ToUpper() Then
            btnAccounts.Visible = False
        Else
            btnAccounts.Visible = True
        End If
        If lblDate.Text <> DateTime.Now.ToString("MMM yyyy").ToUpper() Then                     ' If lblDate Is different from current date ...
            lblToBeBudgeted.Visible = False
            lblToBeBudgetedValue.Visible = False
            pbArrow.Visible = False
            btnAddCategory.Visible = False
        Else
            lblToBeBudgeted.Visible = True
            lblToBeBudgetedValue.Visible = True
            pbArrow.Visible = True
            btnAddCategory.Visible = True
        End If
    End Sub
    Private Sub updateLabels_Tick(sender As Object, e As EventArgs) Handles updateLabels.Tick
        Dim totValue As Decimal = 0
        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Total Budgeted label
            If dgvBudget.Rows(i).Cells(4).Value.ToString = "S" Then                             ' Loop through budget list and do if it is subcategory ...
                If dgvBudget.Rows(i).Cells(1).Value.ToString <> "" Then                         ' If not empty
                    totValue += dgvBudget.Rows(i).Cells(1).Value                                ' Add to total
                End If
            End If
        Next
        lblTotalBudgetedValue.Text = totValue.ToString("C")                                     ' Convert to currency string and print on label

        totValue = 0
        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Total Activity label
            If dgvBudget.Rows(i).Cells(4).Value.ToString = "S" Then
                If dgvBudget.Rows(i).Cells(2).Value.ToString <> "" Then
                    totValue += dgvBudget.Rows(i).Cells(2).Value
                End If
            End If
        Next
        lblTotalActivityValue.Text = totValue.ToString("C")

        totValue = 0
        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Total Available label
            If dgvBudget.Rows(i).Cells(4).Value.ToString = "S" Then
                If dgvBudget.Rows(i).Cells(3).Value.ToString <> "" Then
                    totValue += dgvBudget.Rows(i).Cells(3).Value
                End If
            End If
        Next
        If lblDate.Text = DateTime.Now.ToString("MMM yyyy").ToUpper() Then
            totValue += CType(lblToBeBudgetedValue.Text, Decimal)
        End If
        lblTotalAvailableValue.Text = totValue.ToString("C")
        lblWorkingBalanceValue.Text = totValue.ToString("C")

        totValue = 0
        Dim traDate As DateTime
        Dim dt As Date
        Date.TryParse(lblDate.Text, dt)                                                         ' Get date
        Dim premonth As New Date(dt.Year, dt.Month, 1)                                          ' First day of month and last day of month
        Dim endMonth As New Date(dt.Year, dt.Month, Date.DaysInMonth(dt.Year, dt.Month))
        For i As Integer = 0 To dgvTransactions.Rows.Count - 1                                  ' Total Inflow label
            traDate = dgvTransactions.Rows(i).Cells(1).Value
            If premonth <= traDate And endMonth >= traDate Then                                 ' If transaction is lower than preMonth
                If dgvTransactions.Rows(i).Cells(7).Value.ToString = "" Or dgvTransactions.Rows(i).Cells(3).Value.ToString = "Transfer" Then    ' Ignore null and transfers
                Else
                    totValue += dgvTransactions.Rows(i).Cells(7).Value
                End If
            Else
                i = dgvTransactions.Rows.Count - 1
            End If
        Next
        lblTotalInflowValue.Text = totValue.ToString("C")

        totValue = 0
        For i As Integer = 0 To dgvTransactions.Rows.Count - 1                                  ' Total Spending for current month
            traDate = dgvTransactions.Rows(i).Cells(1).Value
            If premonth <= traDate And endMonth >= traDate Then
                If dgvTransactions.Rows(i).Cells(6).Value.ToString = "" Or dgvTransactions.Rows(i).Cells(3).Value.ToString = "Transfer" Then    ' Ignore null and transfers
                Else
                    totValue += dgvTransactions.Rows(i).Cells(6).Value
                End If
            Else
                i = dgvTransactions.Rows.Count - 1
            End If
        Next
        lblTotalSpendingValue.Text = totValue.ToString("C")

        totValue = 0
        Dim preYear As DateTime = DateTime.Now.AddYears(-1)
        For i As Integer = 0 To dgvTransactions.Rows.Count - 1                                  ' Average Spending each month
            traDate = dgvTransactions.Rows(i).Cells(1).Value
            If preYear <= traDate Then
                If dgvTransactions.Rows(i).Cells(6).Value.ToString = "" Or dgvTransactions.Rows(i).Cells(3).Value.ToString <> "Transfer" Then
                Else
                    totValue += dgvTransactions.Rows(i).Cells(6).Value
                End If
            Else
                i = dgvTransactions.Rows.Count - 1
            End If
        Next
        totValue = totValue / 12
        lblAverageSpendingValue.Text = totValue.ToString("C")

        totValue = 0
        For i As Integer = 0 To dgvAccounts.Rows.Count - 1                                      ' Update To be budgeted label
            totValue += dgvAccounts.Rows(i).Cells(1).Value
        Next
        For i As Integer = 0 To dgvBudget.Rows.Count - 1
            If dgvBudget.Rows(i).Cells(4).Value.ToString = "S" And dgvBudget.Rows(i).Cells(1).Value.ToString <> "" Then
                totValue -= CType(dgvBudget.Rows(i).Cells(1).Value, Decimal)
            End If
        Next
        lblToBeBudgetedValue.Text = totValue.ToString("C")

        Dim conDate As DateTime = CDate(lblDate.Text)                                           ' Check if document exist
        Dim downDate As String = conDate.AddMonths(-1).ToString("MMM yyyy").ToUpper()
        Dim upDate As String = conDate.AddMonths(+1).ToString("MMM yyyy").ToUpper()
        If My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\BasedData\" + downDate + ".csv") Then
            pbPrevMonth.Visible = True
        Else
            pbPrevMonth.Visible = False
        End If
        If lblDate.Text = DateTime.Now.ToString("MMM yyyy").ToUpper() Then
            pbNextMonth.Visible = False
        ElseIf upDate = DateTime.Now.ToString("MMM yyyy").ToUpper() Then
            pbNextMonth.Visible = True
        ElseIf My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\BasedData\" + upDate + ".csv") Then
            pbNextMonth.Visible = True
        Else
            pbNextMonth.Visible = False
        End If
    End Sub
    Private Sub redDetector_Tick(sender As Object, e As EventArgs) Handles redDetector.Tick     ' Check every second if TBB is pos or neg. Change color if needed
        If CType(lblToBeBudgetedValue.Text, Decimal) >= 0 And lblToBeBudgetedValue.ForeColor = Color.FromArgb(207, 82, 76) Then    ' Update color of to be budgeted label
            lblToBeBudgetedValue.ForeColor = Color.FromArgb(106, 168, 79)
            lblToBeBudgeted.BackColor = Color.FromArgb(106, 168, 79)
            lblToBeBudgeted.ForeColor = Color.FromArgb(0, 64, 0)
            pbArrow.Image = BasedBudgeting.My.Resources.Resources.arrow
        ElseIf CType(lblToBeBudgetedValue.Text, Decimal) < 0 And lblToBeBudgetedValue.ForeColor = Color.FromArgb(106, 168, 79) Then
            lblToBeBudgetedValue.ForeColor = Color.FromArgb(207, 82, 76)
            lblToBeBudgeted.BackColor = Color.FromArgb(207, 82, 76)
            lblToBeBudgeted.ForeColor = Color.FromArgb(124, 25, 25)
            pbArrow.Image = BasedBudgeting.My.Resources.Resources.arrowred
        End If
        If CType(lblWorkingBalanceValue.Text, Decimal) >= 0 And lblWorkingBalanceValue.ForeColor = Color.FromArgb(207, 82, 76) Then ' Update working balance color
            lblWorkingBalanceValue.ForeColor = Color.FromArgb(106, 168, 79)
            lblAllAccounts.BackColor = Color.FromArgb(106, 168, 79)
            pbArrow2.Image = BasedBudgeting.My.Resources.Resources.arrow
        ElseIf CType(lblWorkingBalanceValue.Text, Decimal) < 0 And lblWorkingBalanceValue.ForeColor = Color.FromArgb(106, 168, 79) Then
            lblWorkingBalanceValue.ForeColor = Color.FromArgb(207, 82, 76)
            lblAllAccounts.BackColor = Color.FromArgb(207, 82, 76)
            pbArrow2.Image = BasedBudgeting.My.Resources.Resources.arrowred
        End If
    End Sub

    Private Sub dgvBudget_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvBudget.CellFormatting   ' Conditional formatting, dgvBudget column 3
        For Each row As DataGridViewRow In dgvBudget.Rows
            If row.Cells(0).Value.ToString <> "" Then                                           ' Only do for  subcategories that have filled category name
                If row.Cells(3).Value = 0 And row.Cells(4).Value.ToString = "S" Then            ' If available value = 0  than default
                    row.Cells(3).Style.ForeColor = Color.FromArgb(0, 50, 65)
                    row.Cells(3).Style.BackColor = Color.White
                Else
                    If row.Cells(3).Value > 0 And row.Cells(4).Value.ToString = "S" Then        ' If negative
                        row.Cells(3).Style.ForeColor = Color.White
                        row.Cells(3).Style.BackColor = Color.FromArgb(106, 168, 79)
                    ElseIf row.Cells(3).Value < 0 And row.Cells(4).Value.ToString = "S" Then    ' If positive
                        row.Cells(3).Style.ForeColor = Color.White
                        row.Cells(3).Style.BackColor = Color.FromArgb(207, 82, 76)
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub cbAccountFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountFilter.TextChanged  ' Transaction filter
        For Each row As DataGridViewRow In dgvTransactions.Rows                                 ' For every row in transactions
            If filtering = False Then                                                           ' Loop to check there is already a filter active
                row.Visible = True
                filtering = True
                dtpDateFilter.Enabled = False
            End If
            If row.Cells(0).Value.ToString <> cbAccountFilter.Text Then                         ' Hide rows that are not filtered
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub dtpDateFilter_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFilter.ValueChanged ' Transaction filter
        Dim conDateFilter As String
        Dim conDate As String
        For Each row As DataGridViewRow In dgvTransactions.Rows
            row.Visible = True
            filtering = True
            conDate = CDate(row.Cells(1).Value).ToString("MM yyyy")                             ' Convert to month year string to compare
            conDateFilter = CDate(dtpDateFilter.Text).ToString("MM yyyy")
            If conDateFilter <> conDate Then                                                    ' Make rows with other months invisible
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub cbPayeeFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayeeFilter.TextChanged  ' Transaction filter
        For Each row As DataGridViewRow In dgvTransactions.Rows                                 ' For every row in transactions
            If filtering = False Then                                                           ' Loop to check there is already a filter active
                row.Visible = True
                filtering = True
                dtpDateFilter.Enabled = False
            End If
            If row.Cells(2).Value.ToString <> cbPayeeFilter.Text Then                           ' Hide rows that are not filtered
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub cbCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoryFilter.TextChanged    ' Transaction filter
        For Each row As DataGridViewRow In dgvTransactions.Rows
            If filtering = False Then
                row.Visible = True
                filtering = True
                dtpDateFilter.Enabled = False
            End If
            If row.Cells(3).Value.ToString <> cbCategoryFilter.Text Then
                row.Visible = False
            End If
        Next

    End Sub
    Private Sub cbSubcategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubcategoryFilter.TextChanged  ' Transaction filter
        For Each row As DataGridViewRow In dgvTransactions.Rows
            If filtering = False Then
                row.Visible = True
                filtering = True
                dtpDateFilter.Enabled = False
            End If
            If row.Cells(4).Value.ToString <> cbSubcategoryFilter.Text Then
                row.Visible = False
            End If
        Next
    End Sub
    Private Sub btnResetTransaction_Click(sender As Object, e As EventArgs) Handles btnResetTransaction.Click   ' Transaction filter
        cbAccountFilter.Text = ""
        dtpDateFilter.Text = ""
        cbPayeeFilter.Text = ""
        cbCategoryFilter.Text = ""
        cbSubcategoryFilter.Text = ""
        filtering = False
        dtpDateFilter.Enabled = True
        For Each row As DataGridViewRow In dgvTransactions.Rows
            row.Visible = True
        Next
    End Sub

    Private Sub pbPrevMonth_Click(sender As Object, e As EventArgs) Handles pbPrevMonth.Click
        lblDate.Text = CDate(lblDate.Text).AddMonths(-1).ToString("MMM yyyy").ToUpper()
        dgvDateChange(lblDate.Text)
    End Sub

    Private Sub pbNextMonth_Click(sender As Object, e As EventArgs) Handles pbNextMonth.Click
        lblDate.Text = CDate(lblDate.Text).AddMonths(+1).ToString("MMM yyyy").ToUpper()
        dgvDateChange(lblDate.Text)
    End Sub

    Private Sub dgvDateChange(dateMonth As String)                                              ' Used to change datagridview if other month is selected
        dgvBudget.Rows.Clear()
        Dim rows() As String
        Dim values() As String
        If My.Computer.FileSystem.FileExists(roaming + "\BasedBudgeting\BasedData\" + dateMonth + ".csv") Then  ' If saved budget file exists
            rows = File.ReadAllLines(roaming + "\BasedBudgeting\BasedData\" + dateMonth + ".csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(";")                                          ' Split values at ";"
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j
                dgvBudget.Rows.Add(row)                                                         ' Add row to datagridview
            Next i
        ElseIf dateMonth = DateTime.Now.ToString("MMM yyyy").ToUpper Then
            rows = File.ReadAllLines(roaming + "\BasedBudgeting\budget.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(";")                                          ' Split values at ";"
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j
                dgvBudget.Rows.Add(row)                                                         ' Add row to datagridview
            Next i
        End If

        For i As Integer = 0 To dgvBudget.Rows.Count - 1                                        ' Give category row a background color
            If dgvBudget.Rows(i).Cells(4).Value = "C" Then
                dgvBudget.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(230, 245, 250)
            End If
            For j As Integer = 1 To 3                                                           ' If there are values imported, convert from string to integer to get correct format
                If dgvBudget.Rows(i).Cells(0).Value = "" Then                                   ' Do nothing if category is not filled
                ElseIf dgvBudget.Rows(i).Cells(j).Value = "" Then                               ' If no value, print 0
                    dgvBudget.Rows(i).Cells(j).Value = 0
                Else                                                                            ' Else convert stored value to double and 
                    Dim toInt As String = dgvBudget.Rows(i).Cells(j).Value
                    dgvBudget.Rows(i).Cells(j).Value = CType(toInt, Decimal)
                End If
            Next
        Next
    End Sub
End Class
' TO DO
'
'   UPDATE AVAILABLE WHEN ACTIVITY IS EDITED
'   UPDATE TO DOUBLE WHEN E.cellindex is edited
