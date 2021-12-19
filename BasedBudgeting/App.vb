Imports System.IO
Public Class App
    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load                  ' When applications loads
        Me.lblDate.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()                           ' Print correct date
        Me.lblDateValue.Text = DateTime.Now.ToString("MMM yyyy").ToUpper()
        Me.dtpDate.Value = DateTime.Now.ToString("dd MMM yyyy")                                 ' Update DateTimePicker to current date

        Dim rows() As String
        Dim values() As String
        If My.Computer.FileSystem.FileExists(".\transactions.csv") Then                         ' If saved transaction file exists
            rows = File.ReadAllLines(".\transactions.csv")
            For i As Integer = 0 To rows.Length - 1 Step +1                                     ' Loop through all rows
                values = rows(i).ToString().Split(",")                                          ' Split values at ","
                Dim row(values.Length - 1) As String

                For j As Integer = 0 To values.Length - 1 Step +1
                    row(j) = values(j).Trim()
                Next j

                dgvTransactions.Rows.Add(row)                                                   ' Add row to datagridview
            Next i
        End If
    End Sub

    Private Sub App_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed              ' When application closes
        Dim writer As New StreamWriter(".\transactions.csv")
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
    Private Sub BtnBudget_Click(sender As Object, e As EventArgs) Handles btnBudget.Click       ' When Budget menu is selected
        btnBudget.BackColor = Color.FromArgb(0, 90, 120)                                        ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(45, 150, 175)
        btnAccounts.BackColor = Color.FromArgb(45, 150, 175)
        pnlBudgetStatistics.Visible = True                                                      ' Show correct panels for selected menu
        pnlReportsStatistics.Visible = False
        pnlAccountsTransaction.Visible = False
        pnlAccountsFilter.Visible = False
        dgvTransactions.Visible = False
        lblDate.Visible = True
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click     ' When Reports button is selected
        btnBudget.BackColor = Color.FromArgb(45, 150, 175)                                      ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(0, 90, 120)
        btnAccounts.BackColor = Color.FromArgb(45, 150, 175)
        pnlBudgetStatistics.Visible = False                                                     ' Show correct panels for selected menu
        pnlReportsStatistics.Visible = True
        pnlAccountsTransaction.Visible = False
        pnlAccountsFilter.Visible = False
        dgvTransactions.Visible = False
        lblDate.Visible = False
    End Sub

    Private Sub BtnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click   ' When Accounts button is selected
        btnBudget.BackColor = Color.FromArgb(45, 150, 175)                                      ' Change Button Colors depending on selected menu
        btnReports.BackColor = Color.FromArgb(45, 150, 175)
        btnAccounts.BackColor = Color.FromArgb(0, 90, 120)
        pnlBudgetStatistics.Visible = False                                                     ' Show correct panels for selected menu
        pnlReportsStatistics.Visible = False
        pnlAccountsTransaction.Visible = True
        pnlAccountsFilter.Visible = True
        dgvTransactions.Visible = True
        lblDate.Visible = False
    End Sub

    Private Sub btnAddTransaction_Click(sender As Object, e As EventArgs) Handles btnAddTransaction.Click                       ' When transaction add button is clicked
        If cbAccount.Text = "" Or cbPayee.Text = "" Or cbCategory.Text = "" Or cbSubcategory.Text = "" Or tbMemo.Text = "" Then ' If labels are not filled
            MsgBox("not all information needed given")
        ElseIf tbOutflow.Text = "" And tbInflow.Text = "" Then                                  ' If outflow or inflow is not filled
            MsgBox("Either enter a inflow or outflow value")
        Else
            If IsNumeric(tbOutflow.Text) Then                                                   ' Print data to DataGridView
                dgvTransactions.Rows.Add(cbAccount.Text, dtpDate.Text, cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, tbOutflow.Text, tbInflow.Text)
            ElseIf IsNumeric(tbInflow.Text) Then
                dgvTransactions.Rows.Add(cbAccount.Text, dtpDate.Text, cbPayee.Text, cbCategory.Text, cbSubcategory.Text, tbMemo.Text, tbOutflow.Text, tbInflow.Text)
            Else
                MsgBox("Transaction value not a number")
            End If
        End If
    End Sub

    Private Sub tbOutflow_TextChanged(sender As Object, e As EventArgs) Handles tbOutflow.TextChanged                           ' When textinput from outflow changes
        If tbOutflow.Text = "" Then                                                             ' If outflow textinput = empty, enable inflow
            tbInflow.Enabled = True
        Else                                                                                    ' Else disable inflow textbox
            tbInflow.Enabled = False
        End If
    End Sub

    Private Sub tbInflow_TextChanged(sender As Object, e As EventArgs) Handles tbInflow.TextChanged                             ' When textinput from inflow changes
        If tbInflow.Text = "" Then                                                              ' If inflow textinput = empty, enable outflow
            tbOutflow.Enabled = True
        Else                                                                                    ' Else disable outflow textbox
            tbOutflow.Enabled = False
        End If
    End Sub
End Class
