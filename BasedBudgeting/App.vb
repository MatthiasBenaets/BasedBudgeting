Imports System.Windows.Forms.DataVisualization.Charting
Public Class App
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load                  ' When applications loads
        Me.lblDate.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()                           ' Print correct date
        Me.lblDateValue.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()
        Me.dtpDate.Value = DateTime.Now.ToString("dd MMM yyyy")                                 ' Update DateTimePicker to current date

        Dim rows() As String
        Dim values() As String
        If My.Computer.FileSystem.FileExists(".\BasedData\transactions.csv") Then               ' If saved transaction file exists
            rows = File.ReadAllLines(".\BasedData\transactions.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(",")                                          ' Split values at ","
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j

                dgvTransactions.Rows.Add(row)                                                   ' Add row to datagridview
            Next i
        Else
            dgvTransactions.Rows.Insert(0, "START", "01 Jan 1900", "START", "START", "START", "START", "", "")  'Baseline info, fixes OutOfRange when second transaction is earlier than first transaction
            If System.IO.Directory.Exists(".\BasedData") Then                                   ' Check if BasedData exist, if not create it and run SaveTransaction
                SaveTransaction()
            Else
                System.IO.Directory.CreateDirectory(".\BasedData")
                SaveTransaction()
            End If
        End If

        If My.Computer.FileSystem.FileExists(".\BasedData\budget.csv") Then                     ' If saved budget file exists
            rows = File.ReadAllLines(".\BasedData\budget.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(",")                                          ' Split values at ","
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
        Next

        If My.Computer.FileSystem.FileExists(".\BasedData\accounts.csv") Then                   ' If saved transaction file exists
            rows = File.ReadAllLines(".\BasedData\accounts.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(",")                                          ' Split values at ","
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j

                dgvAccounts.Rows.Add(row)                                                       ' Add row to datagridview
            Next i
        End If
    End Sub

    Private Sub App_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed              ' When application closes
        SaveTransaction()
        SaveBudget()
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
        dgvBudget.Visible = True
        dgvTransactions.Visible = False
        lblDate.Visible = True
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
        lblDate.Visible = False

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
        lblDate.Visible = False
    End Sub
    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim strCat As String
        Dim test As Integer = dgvBudget.Rows.Count
        strCat = InputBox("Please give a category name", "Category")
        dgvBudget.Rows.Add(strCat, 0, 0, 0, "C")
        dgvBudget.Rows(test).DefaultCellStyle.BackColor = Color.FromArgb(230, 245, 250)
        dgvBudget.Rows.Add("", "", "", "", "S")
    End Sub
    Private Sub btnAddAccount_Click(sender As Object, e As EventArgs) Handles btnAddAccount.Click   ' When Add Account buttin is clicked
        Dim accounts(2)
        accounts(0) = InputBox("Name of account")                                               ' Inputbox to get info from user
        accounts(1) = InputBox("Balance of " & accounts(0) & ".")
        dgvAccounts.Rows.Add(accounts)                                                          ' Add info to DataGridView

        Dim curBalance = Double.Parse(lblTotalBalance.Text)
        lblTotalBalance.Text = curBalance + accounts(1)

        SaveAccounts()
    End Sub
    Private Sub dgvBudget_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBudget.CellEndEdit  ' Used to automatically add rows in dgvBudget
        If dgvBudget.Rows(e.RowIndex).Cells(4).Value = "S" Then                                 ' If selected cell is a subcategory
            If dgvBudget.Rows(e.RowIndex).Cells(0).Value = "" Then
            ElseIf dgvBudget.CurrentRow.Index = dgvBudget.Rows.Count - 1 Then
                dgvBudget.Rows.Add("", "", "", "", "S")
            Else
                dgvBudget.Rows.Insert(e.RowIndex + 1, "", "", "", "", "S")
            End If
        End If
    End Sub

    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click   ' When transaction add button is clicked
        Dim transactionDate As DateTime = dtpDate.Value.ToString("dd MMM yyyy")
        Dim i = 0
        While transactionDate < dgvTransactions.Rows(i).Cells(1).Value                          ' Loop to check where in DataGridView, data needs to be stored
            i += 1
        End While

        If cbAccount.Text = "" Or cbPayee.Text = "" Or cbCategory.Text = "" Or cbSubcategory.Text = "" Or tbMemo.Text = "" Then ' If labels are not filled
            MsgBox("not all information needed given")
        ElseIf tbOutflow.Text = "" And tbInflow.Text = "" Then                                  ' If outflow or inflow is not filled
            MsgBox("Either enter a inflow or outflow value")
        Else
            If IsNumeric(tbOutflow.Text) Then                                                   ' Print data to DataGridView on correct row.
                dgvTransactions.Rows.Insert(i, cbAccount.Text, dtpDate.Text, cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, tbOutflow.Text, tbInflow.Text)
            ElseIf IsNumeric(tbInflow.Text) Then                                                ' Thus no date filter required
                dgvTransactions.Rows.Insert(i, cbAccount.Text, dtpDate.Text, cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, tbOutflow.Text, tbInflow.Text)
            Else
                MsgBox("Transaction value not a number")
            End If
        End If
        SaveTransaction()
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
        Dim rowsAcc() As String = File.ReadAllLines(".\BasedData\accounts.csv")
        Dim accVal() As String
        Dim xAcc(rowsAcc.Length) As String
        Dim yAcc(rowsAcc.Length) As Double
        Dim seriesAcc As String = Nothing
        Dim j As Integer = 0

        For i As Integer = 0 To rowsAcc.Length - 1 Step +1                                      ' Looping through all accounts
            accVal = rowsAcc(j).ToString().Split(",")
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
        Dim rowsTra() As String = File.ReadAllLines(".\BasedData\transactions.csv")
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
            traVal = rowsTra(j).ToString().Split(",")
            traDate = Convert.ToDateTime(traVal(1))
            If (traDate >= preMonth) Then                                                       ' Check if date is not older than 30 days
                k = 0
                l = False
                While k < xTra.Length
                    If xTra(k) = traVal(4) Then
                        yTra(k) = yTra(k) + traVal(6)
                        l = True
                        k = xTra.Length
                    End If
                    k += 1
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
        Dim rowsTra() As String = File.ReadAllLines(".\BasedData\transactions.csv")
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
            traVal = rowsTra(l).ToString().Split(",")
            Dim traDate As String = Convert.ToDateTime(traVal(1))
            Dim traMonth = CDate(traVal(1)).ToString("MMM yyyy")                                ' Convert to Month Year
            If (traDate >= preYear) Then                                                        ' Check if date is not older than 1 year
                If dtTrend.Rows.Count = 0 Then                                                  ' First transaction loop
                    dtTrend.Rows.Add(traVal(6), traMonth, traVal(4))                            ' Add row to DataTable in order "outflow/date/category"
                Else                                                                            ' If not first transaction
                    m = 0
                    valExist = False                                                            ' Reset valExist to false
                    While m < dtTrend.Rows.Count                                                ' Loop DataTable, used to add outflow to existing categories
                        If dtTrend.Rows(m)(1).ToString = traMonth And dtTrend.Rows(m)(2) = traVal(4) Then   ' Check if date and category match between DataTable and Transactions 
                            dtTrend.Rows(m)(0) = dtTrend.Rows(m)(0) + traVal(6)                 ' Add outflow to existing DataTable row
                            m = dtTrend.Rows.Count
                            valExist = True
                        End If
                        m += 1
                    End While

                    If valExist = False Then                                                    ' If combo of date and subcategory does not exist:
                        dtTrend.Rows.Add(traVal(6), traMonth, traVal(4))                        ' Add new line to DataTable
                    End If
                End If

                If strCat = "" Then                                                             ' If string has no value (first loop). Used to create list of subcategories
                    strCat = traVal(4)
                ElseIf strCat.Contains(traVal(4)) Then                                          ' Check if category already exist in the string
                Else
                    strCat = strCat + "," + traVal(4)
                End If
                If strDate = "" Then                                                            ' Ditto about but for Date
                    strDate = traMonth
                ElseIf strDate.Contains(traMonth) Then
                Else
                    strDate = strDate + "," + traMonth
                End If
            Else
                i = rowsTra.Length - 1                                                          ' Quit loop if year ends (will only work if csv is chronological
            End If
            l += 1
        Next

        Dim arrCat() As String = strCat.Split(",")                                              ' Split string to use in array
        Dim arrDate() As String = strDate.Split(",")
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
        Dim writer As New StreamWriter(".\BasedData\budget.csv")
        For i As Integer = 0 To dgvBudget.Rows.Count - 1 Step +1                                ' Loop through all rows
            For j As Integer = 0 To dgvBudget.Columns.Count - 1 Step +1                         ' Loop through all columns within the row
                If j = dgvBudget.Columns.Count - 1 Then                                         ' Print values with ","; except last column
                    writer.Write(dgvBudget.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvBudget.Rows(i).Cells(j).Value & ",")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub

    Private Sub SaveAccounts()
        Dim writer As New StreamWriter(".\BasedData\accounts.csv")
        For i As Integer = 0 To dgvAccounts.Rows.Count - 1 Step +1                              ' Loop through all rows
            For j As Integer = 0 To dgvAccounts.Columns.Count - 1 Step +1                       ' Loop through all columns within the row
                If j = dgvAccounts.Columns.Count - 1 Then                                       ' Print values with ","; except last column
                    writer.Write(dgvAccounts.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvAccounts.Rows(i).Cells(j).Value & ",")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub

    Private Sub SaveTransaction()
        Dim writer As New StreamWriter(".\BasedData\transactions.csv")
        For i As Integer = 0 To dgvTransactions.Rows.Count - 1 Step +1                          ' Loop through all rows
            For j As Integer = 0 To dgvTransactions.Columns.Count - 1 Step +1                   ' Loop through all columns within the row
                If j = dgvTransactions.Columns.Count - 1 Then                                   ' Print values with ","; except last column
                    writer.Write(dgvTransactions.Rows(i).Cells(j).Value)
                Else
                    writer.Write(dgvTransactions.Rows(i).Cells(j).Value & ",")
                End If
            Next j
            writer.WriteLine("")                                                                ' Next line
        Next i
        writer.Close()
    End Sub
End Class

' TO DO
' 
' Make editable Datagridview for Budget menu 
' Fix total balance auto calculation on load (possibly change how it gets calculated when added at first)
' Possibly link all saved files
' Setup all calculations in menu
' Functioning "To be budgeted button"