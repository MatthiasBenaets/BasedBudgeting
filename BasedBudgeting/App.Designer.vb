<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class App
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.chNet = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnBudget = New System.Windows.Forms.Button()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.pnlBudgetStatistics = New System.Windows.Forms.Panel()
        Me.lblTotalActivity = New System.Windows.Forms.Label()
        Me.lblTotalAvailable = New System.Windows.Forms.Label()
        Me.lblTotalInflow = New System.Windows.Forms.Label()
        Me.lblTotalBudgeted = New System.Windows.Forms.Label()
        Me.lblTotalBudgetedValue = New System.Windows.Forms.Label()
        Me.lblTotalActivityValue = New System.Windows.Forms.Label()
        Me.lblTotalAvailableValue = New System.Windows.Forms.Label()
        Me.lblTotalInflowValue = New System.Windows.Forms.Label()
        Me.pnlReportsStatistics = New System.Windows.Forms.Panel()
        Me.lblAverageSpendingValue = New System.Windows.Forms.Label()
        Me.lblPeriod2 = New System.Windows.Forms.Label()
        Me.lblAverageSpending = New System.Windows.Forms.Label()
        Me.lblTotalSpendingValue = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblDateValue = New System.Windows.Forms.Label()
        Me.lblTotalSpending = New System.Windows.Forms.Label()
        Me.lblIncluded = New System.Windows.Forms.Label()
        Me.pnlAccountsTransaction = New System.Windows.Forms.Panel()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.tbInflow = New System.Windows.Forms.TextBox()
        Me.tbOutflow = New System.Windows.Forms.TextBox()
        Me.tbMemo = New System.Windows.Forms.TextBox()
        Me.cbSubcategory = New System.Windows.Forms.ComboBox()
        Me.cbAccount = New System.Windows.Forms.ComboBox()
        Me.cbPayee = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblInflow = New System.Windows.Forms.Label()
        Me.lblOutflow = New System.Windows.Forms.Label()
        Me.lblMemo = New System.Windows.Forms.Label()
        Me.lblSubcategory = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblPayee = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAccountsFilter = New System.Windows.Forms.Panel()
        Me.dtpDateFilter = New System.Windows.Forms.DateTimePicker()
        Me.cbSubcategoryFilter = New System.Windows.Forms.ComboBox()
        Me.cbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.cbPayeeFilter = New System.Windows.Forms.ComboBox()
        Me.cbAccountFilter = New System.Windows.Forms.ComboBox()
        Me.pnlReportsCharts = New System.Windows.Forms.Panel()
        Me.chSpending = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlMenu.SuspendLayout()
        CType(Me.chNet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNavigation.SuspendLayout()
        Me.pnlBudgetStatistics.SuspendLayout()
        Me.pnlReportsStatistics.SuspendLayout()
        Me.pnlAccountsTransaction.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccountsFilter.SuspendLayout()
        Me.pnlReportsCharts.SuspendLayout()
        CType(Me.chSpending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.txtTitle)
        Me.pnlMenu.Controls.Add(Me.btnAccounts)
        Me.pnlMenu.Controls.Add(Me.btnReports)
        Me.pnlMenu.Controls.Add(Me.btnBudget)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(214, 608)
        Me.pnlMenu.TabIndex = 0
        '
        'chNet
        '
        ChartArea1.Name = "ChartArea1"
        Me.chNet.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chNet.Legends.Add(Legend1)
        Me.chNet.Location = New System.Drawing.Point(0, 0)
        Me.chNet.Margin = New System.Windows.Forms.Padding(0)
        Me.chNet.Name = "chNet"
        Me.chNet.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chNet.Series.Add(Series1)
        Me.chNet.Size = New System.Drawing.Size(596, 300)
        Me.chNet.TabIndex = 10
        Me.chNet.Text = "chNet"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(3, 20)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitle.Size = New System.Drawing.Size(212, 49)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "My Budget"
        '
        'btnAccounts
        '
        Me.btnAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnAccounts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(0, 162)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(214, 37)
        Me.btnAccounts.TabIndex = 2
        Me.btnAccounts.Text = "All Accounts"
        Me.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(0, 125)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(214, 37)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnBudget
        '
        Me.btnBudget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBudget.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBudget.FlatAppearance.BorderSize = 0
        Me.btnBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBudget.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnBudget.ForeColor = System.Drawing.Color.White
        Me.btnBudget.Location = New System.Drawing.Point(0, 87)
        Me.btnBudget.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBudget.Name = "btnBudget"
        Me.btnBudget.Size = New System.Drawing.Size(214, 37)
        Me.btnBudget.TabIndex = 0
        Me.btnBudget.Text = "Budget"
        Me.btnBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBudget.UseVisualStyleBackColor = False
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlNavigation.Controls.Add(Me.lblDate)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNavigation.Location = New System.Drawing.Point(214, 0)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(869, 87)
        Me.pnlNavigation.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(110, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(199, 78)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "[Date]"
        '
        'pnlBudgetStatistics
        '
        Me.pnlBudgetStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalActivity)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalAvailable)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalInflow)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalBudgeted)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalBudgetedValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalActivityValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalAvailableValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalInflowValue)
        Me.pnlBudgetStatistics.Location = New System.Drawing.Point(826, 87)
        Me.pnlBudgetStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBudgetStatistics.Name = "pnlBudgetStatistics"
        Me.pnlBudgetStatistics.Size = New System.Drawing.Size(257, 504)
        Me.pnlBudgetStatistics.TabIndex = 2
        '
        'lblTotalActivity
        '
        Me.lblTotalActivity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalActivity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalActivity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalActivity.Location = New System.Drawing.Point(0, 87)
        Me.lblTotalActivity.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalActivity.Name = "lblTotalActivity"
        Me.lblTotalActivity.Size = New System.Drawing.Size(257, 17)
        Me.lblTotalActivity.TabIndex = 6
        Me.lblTotalActivity.Text = "TOTAL ACTIVITY"
        Me.lblTotalActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAvailable
        '
        Me.lblTotalAvailable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAvailable.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalAvailable.Location = New System.Drawing.Point(0, 165)
        Me.lblTotalAvailable.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalAvailable.Name = "lblTotalAvailable"
        Me.lblTotalAvailable.Size = New System.Drawing.Size(257, 17)
        Me.lblTotalAvailable.TabIndex = 5
        Me.lblTotalAvailable.Text = "TOTAL AVAILABLE"
        Me.lblTotalAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalInflow
        '
        Me.lblTotalInflow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalInflow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalInflow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalInflow.Location = New System.Drawing.Point(0, 243)
        Me.lblTotalInflow.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalInflow.Name = "lblTotalInflow"
        Me.lblTotalInflow.Size = New System.Drawing.Size(257, 17)
        Me.lblTotalInflow.TabIndex = 4
        Me.lblTotalInflow.Text = "TOTAL INFLOW"
        Me.lblTotalInflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBudgeted
        '
        Me.lblTotalBudgeted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBudgeted.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBudgeted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalBudgeted.Location = New System.Drawing.Point(0, 9)
        Me.lblTotalBudgeted.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalBudgeted.Name = "lblTotalBudgeted"
        Me.lblTotalBudgeted.Size = New System.Drawing.Size(257, 17)
        Me.lblTotalBudgeted.TabIndex = 3
        Me.lblTotalBudgeted.Text = "TOTAL BUDGETED"
        Me.lblTotalBudgeted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBudgetedValue
        '
        Me.lblTotalBudgetedValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBudgetedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBudgetedValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalBudgetedValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalBudgetedValue.Location = New System.Drawing.Point(-1, 25)
        Me.lblTotalBudgetedValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalBudgetedValue.Name = "lblTotalBudgetedValue"
        Me.lblTotalBudgetedValue.Size = New System.Drawing.Size(259, 53)
        Me.lblTotalBudgetedValue.TabIndex = 7
        Me.lblTotalBudgetedValue.Text = "[TotBud]"
        Me.lblTotalBudgetedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalActivityValue
        '
        Me.lblTotalActivityValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalActivityValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalActivityValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalActivityValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalActivityValue.Location = New System.Drawing.Point(-1, 103)
        Me.lblTotalActivityValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalActivityValue.Name = "lblTotalActivityValue"
        Me.lblTotalActivityValue.Size = New System.Drawing.Size(259, 53)
        Me.lblTotalActivityValue.TabIndex = 8
        Me.lblTotalActivityValue.Text = "[TotAct]"
        Me.lblTotalActivityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAvailableValue
        '
        Me.lblTotalAvailableValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAvailableValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAvailableValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAvailableValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalAvailableValue.Location = New System.Drawing.Point(-1, 181)
        Me.lblTotalAvailableValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalAvailableValue.Name = "lblTotalAvailableValue"
        Me.lblTotalAvailableValue.Size = New System.Drawing.Size(259, 53)
        Me.lblTotalAvailableValue.TabIndex = 9
        Me.lblTotalAvailableValue.Text = "[TotAva]"
        Me.lblTotalAvailableValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalInflowValue
        '
        Me.lblTotalInflowValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalInflowValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalInflowValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalInflowValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalInflowValue.Location = New System.Drawing.Point(-1, 259)
        Me.lblTotalInflowValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalInflowValue.Name = "lblTotalInflowValue"
        Me.lblTotalInflowValue.Size = New System.Drawing.Size(259, 53)
        Me.lblTotalInflowValue.TabIndex = 10
        Me.lblTotalInflowValue.Text = "[TotInf]"
        Me.lblTotalInflowValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReportsStatistics
        '
        Me.pnlReportsStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlReportsStatistics.Controls.Add(Me.lblAverageSpendingValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblPeriod2)
        Me.pnlReportsStatistics.Controls.Add(Me.lblAverageSpending)
        Me.pnlReportsStatistics.Controls.Add(Me.lblTotalSpendingValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblPeriod)
        Me.pnlReportsStatistics.Controls.Add(Me.lblDateValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblTotalSpending)
        Me.pnlReportsStatistics.Controls.Add(Me.lblIncluded)
        Me.pnlReportsStatistics.Location = New System.Drawing.Point(826, 87)
        Me.pnlReportsStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlReportsStatistics.Name = "pnlReportsStatistics"
        Me.pnlReportsStatistics.Size = New System.Drawing.Size(257, 504)
        Me.pnlReportsStatistics.TabIndex = 3
        Me.pnlReportsStatistics.Visible = False
        '
        'lblAverageSpendingValue
        '
        Me.lblAverageSpendingValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAverageSpendingValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblAverageSpendingValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblAverageSpendingValue.Location = New System.Drawing.Point(0, 175)
        Me.lblAverageSpendingValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAverageSpendingValue.Name = "lblAverageSpendingValue"
        Me.lblAverageSpendingValue.Size = New System.Drawing.Size(257, 37)
        Me.lblAverageSpendingValue.TabIndex = 12
        Me.lblAverageSpendingValue.Text = "[AvgSpend]"
        Me.lblAverageSpendingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPeriod2
        '
        Me.lblPeriod2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPeriod2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeriod2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblPeriod2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblPeriod2.Location = New System.Drawing.Point(-1, 211)
        Me.lblPeriod2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPeriod2.Name = "lblPeriod2"
        Me.lblPeriod2.Size = New System.Drawing.Size(257, 23)
        Me.lblPeriod2.TabIndex = 13
        Me.lblPeriod2.Text = "for the first time period"
        Me.lblPeriod2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAverageSpending
        '
        Me.lblAverageSpending.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAverageSpending.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.lblAverageSpending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblAverageSpending.Location = New System.Drawing.Point(0, 156)
        Me.lblAverageSpending.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAverageSpending.Name = "lblAverageSpending"
        Me.lblAverageSpending.Size = New System.Drawing.Size(257, 20)
        Me.lblAverageSpending.TabIndex = 11
        Me.lblAverageSpending.Text = "AVERAGE SPENDING"
        Me.lblAverageSpending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSpendingValue
        '
        Me.lblTotalSpendingValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSpendingValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotalSpendingValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalSpendingValue.Location = New System.Drawing.Point(0, 97)
        Me.lblTotalSpendingValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalSpendingValue.Name = "lblTotalSpendingValue"
        Me.lblTotalSpendingValue.Size = New System.Drawing.Size(257, 37)
        Me.lblTotalSpendingValue.TabIndex = 8
        Me.lblTotalSpendingValue.Text = "[TotSpend]"
        Me.lblTotalSpendingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPeriod
        '
        Me.lblPeriod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeriod.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblPeriod.Location = New System.Drawing.Point(-1, 133)
        Me.lblPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(257, 23)
        Me.lblPeriod.TabIndex = 10
        Me.lblPeriod.Text = "for the first time period"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateValue
        '
        Me.lblDateValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblDateValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblDateValue.Location = New System.Drawing.Point(0, 9)
        Me.lblDateValue.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDateValue.Name = "lblDateValue"
        Me.lblDateValue.Size = New System.Drawing.Size(257, 35)
        Me.lblDateValue.TabIndex = 7
        Me.lblDateValue.Text = "[Date]"
        Me.lblDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSpending
        '
        Me.lblTotalSpending.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalSpending.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.lblTotalSpending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTotalSpending.Location = New System.Drawing.Point(0, 78)
        Me.lblTotalSpending.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalSpending.Name = "lblTotalSpending"
        Me.lblTotalSpending.Size = New System.Drawing.Size(257, 20)
        Me.lblTotalSpending.TabIndex = 6
        Me.lblTotalSpending.Text = "TOTAL SPENDING"
        Me.lblTotalSpending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncluded
        '
        Me.lblIncluded.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIncluded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncluded.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic)
        Me.lblIncluded.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblIncluded.Location = New System.Drawing.Point(-1, 42)
        Me.lblIncluded.Margin = New System.Windows.Forms.Padding(0)
        Me.lblIncluded.Name = "lblIncluded"
        Me.lblIncluded.Size = New System.Drawing.Size(257, 36)
        Me.lblIncluded.TabIndex = 3
        Me.lblIncluded.Text = "All categories and accounts included"
        Me.lblIncluded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAccountsTransaction
        '
        Me.pnlAccountsTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlAccountsTransaction.Controls.Add(Me.btnAddTransaction)
        Me.pnlAccountsTransaction.Controls.Add(Me.tbInflow)
        Me.pnlAccountsTransaction.Controls.Add(Me.tbOutflow)
        Me.pnlAccountsTransaction.Controls.Add(Me.tbMemo)
        Me.pnlAccountsTransaction.Controls.Add(Me.cbSubcategory)
        Me.pnlAccountsTransaction.Controls.Add(Me.cbAccount)
        Me.pnlAccountsTransaction.Controls.Add(Me.cbPayee)
        Me.pnlAccountsTransaction.Controls.Add(Me.cbCategory)
        Me.pnlAccountsTransaction.Controls.Add(Me.dtpDate)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblInflow)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblOutflow)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblMemo)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblSubcategory)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblDate2)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblPayee)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblCategory)
        Me.pnlAccountsTransaction.Controls.Add(Me.lblAccount)
        Me.pnlAccountsTransaction.Location = New System.Drawing.Point(826, 87)
        Me.pnlAccountsTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlAccountsTransaction.Name = "pnlAccountsTransaction"
        Me.pnlAccountsTransaction.Size = New System.Drawing.Size(257, 521)
        Me.pnlAccountsTransaction.TabIndex = 3
        Me.pnlAccountsTransaction.Visible = False
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.Location = New System.Drawing.Point(98, 439)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(64, 20)
        Me.btnAddTransaction.TabIndex = 21
        Me.btnAddTransaction.Text = "Add"
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'tbInflow
        '
        Me.tbInflow.Location = New System.Drawing.Point(43, 394)
        Me.tbInflow.Name = "tbInflow"
        Me.tbInflow.Size = New System.Drawing.Size(172, 20)
        Me.tbInflow.TabIndex = 20
        '
        'tbOutflow
        '
        Me.tbOutflow.Location = New System.Drawing.Point(43, 342)
        Me.tbOutflow.Name = "tbOutflow"
        Me.tbOutflow.Size = New System.Drawing.Size(172, 20)
        Me.tbOutflow.TabIndex = 19
        '
        'tbMemo
        '
        Me.tbMemo.Location = New System.Drawing.Point(43, 290)
        Me.tbMemo.Name = "tbMemo"
        Me.tbMemo.Size = New System.Drawing.Size(172, 20)
        Me.tbMemo.TabIndex = 18
        '
        'cbSubcategory
        '
        Me.cbSubcategory.FormattingEnabled = True
        Me.cbSubcategory.Location = New System.Drawing.Point(43, 238)
        Me.cbSubcategory.Name = "cbSubcategory"
        Me.cbSubcategory.Size = New System.Drawing.Size(172, 21)
        Me.cbSubcategory.TabIndex = 17
        '
        'cbAccount
        '
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.Location = New System.Drawing.Point(43, 30)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(172, 21)
        Me.cbAccount.TabIndex = 16
        '
        'cbPayee
        '
        Me.cbPayee.FormattingEnabled = True
        Me.cbPayee.Location = New System.Drawing.Point(43, 134)
        Me.cbPayee.Name = "cbPayee"
        Me.cbPayee.Size = New System.Drawing.Size(172, 21)
        Me.cbPayee.TabIndex = 15
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(43, 186)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(172, 21)
        Me.cbCategory.TabIndex = 14
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Calibri", 11.25!)
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(43, 82)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(172, 26)
        Me.dtpDate.TabIndex = 13
        Me.dtpDate.Value = New Date(2021, 12, 17, 0, 0, 0, 0)
        '
        'lblInflow
        '
        Me.lblInflow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInflow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInflow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblInflow.Location = New System.Drawing.Point(0, 373)
        Me.lblInflow.Margin = New System.Windows.Forms.Padding(0)
        Me.lblInflow.Name = "lblInflow"
        Me.lblInflow.Size = New System.Drawing.Size(257, 17)
        Me.lblInflow.TabIndex = 10
        Me.lblInflow.Text = "INFLOW"
        Me.lblInflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutflow
        '
        Me.lblOutflow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOutflow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblOutflow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblOutflow.Location = New System.Drawing.Point(0, 321)
        Me.lblOutflow.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOutflow.Name = "lblOutflow"
        Me.lblOutflow.Size = New System.Drawing.Size(257, 17)
        Me.lblOutflow.TabIndex = 9
        Me.lblOutflow.Text = "OUTFLOW"
        Me.lblOutflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemo
        '
        Me.lblMemo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMemo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMemo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblMemo.Location = New System.Drawing.Point(0, 269)
        Me.lblMemo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMemo.Name = "lblMemo"
        Me.lblMemo.Size = New System.Drawing.Size(257, 17)
        Me.lblMemo.TabIndex = 8
        Me.lblMemo.Text = "MEMO"
        Me.lblMemo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubcategory
        '
        Me.lblSubcategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubcategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubcategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblSubcategory.Location = New System.Drawing.Point(0, 217)
        Me.lblSubcategory.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSubcategory.Name = "lblSubcategory"
        Me.lblSubcategory.Size = New System.Drawing.Size(257, 17)
        Me.lblSubcategory.TabIndex = 7
        Me.lblSubcategory.Text = "SUBCATEGORY"
        Me.lblSubcategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate2
        '
        Me.lblDate2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblDate2.Location = New System.Drawing.Point(0, 61)
        Me.lblDate2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(257, 17)
        Me.lblDate2.TabIndex = 6
        Me.lblDate2.Text = "DATE"
        Me.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayee
        '
        Me.lblPayee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayee.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblPayee.Location = New System.Drawing.Point(0, 113)
        Me.lblPayee.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPayee.Name = "lblPayee"
        Me.lblPayee.Size = New System.Drawing.Size(257, 17)
        Me.lblPayee.TabIndex = 5
        Me.lblPayee.Text = "PAYEE"
        Me.lblPayee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(0, 165)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(257, 17)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.Text = "CATEGORY"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccount
        '
        Me.lblAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblAccount.Location = New System.Drawing.Point(0, 9)
        Me.lblAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(257, 17)
        Me.lblAccount.TabIndex = 3
        Me.lblAccount.Text = "ACCOUNT"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactions.GridColor = System.Drawing.Color.LightGray
        Me.dgvTransactions.Location = New System.Drawing.Point(213, 104)
        Me.dgvTransactions.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.RowHeadersWidth = 20
        Me.dgvTransactions.RowTemplate.Height = 25
        Me.dgvTransactions.Size = New System.Drawing.Size(614, 504)
        Me.dgvTransactions.TabIndex = 8
        Me.dgvTransactions.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ACCOUNT"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PAYEE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "CATEGORY"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUBCATEGORY"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "MEMO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "OUTFLOW"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "INFLOW"
        Me.Column8.Name = "Column8"
        '
        'pnlAccountsFilter
        '
        Me.pnlAccountsFilter.Controls.Add(Me.dtpDateFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbSubcategoryFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbCategoryFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbPayeeFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbAccountFilter)
        Me.pnlAccountsFilter.Location = New System.Drawing.Point(214, 87)
        Me.pnlAccountsFilter.Name = "pnlAccountsFilter"
        Me.pnlAccountsFilter.Size = New System.Drawing.Size(613, 17)
        Me.pnlAccountsFilter.TabIndex = 9
        Me.pnlAccountsFilter.Visible = False
        '
        'dtpDateFilter
        '
        Me.dtpDateFilter.CustomFormat = "MM yyyy"
        Me.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFilter.Location = New System.Drawing.Point(90, -1)
        Me.dtpDateFilter.Name = "dtpDateFilter"
        Me.dtpDateFilter.Size = New System.Drawing.Size(76, 20)
        Me.dtpDateFilter.TabIndex = 4
        '
        'cbSubcategoryFilter
        '
        Me.cbSubcategoryFilter.FormattingEnabled = True
        Me.cbSubcategoryFilter.Location = New System.Drawing.Point(314, -1)
        Me.cbSubcategoryFilter.Name = "cbSubcategoryFilter"
        Me.cbSubcategoryFilter.Size = New System.Drawing.Size(76, 21)
        Me.cbSubcategoryFilter.TabIndex = 3
        '
        'cbCategoryFilter
        '
        Me.cbCategoryFilter.FormattingEnabled = True
        Me.cbCategoryFilter.Location = New System.Drawing.Point(239, -1)
        Me.cbCategoryFilter.Name = "cbCategoryFilter"
        Me.cbCategoryFilter.Size = New System.Drawing.Size(76, 21)
        Me.cbCategoryFilter.TabIndex = 2
        '
        'cbPayeeFilter
        '
        Me.cbPayeeFilter.FormattingEnabled = True
        Me.cbPayeeFilter.Location = New System.Drawing.Point(165, -1)
        Me.cbPayeeFilter.Name = "cbPayeeFilter"
        Me.cbPayeeFilter.Size = New System.Drawing.Size(76, 21)
        Me.cbPayeeFilter.TabIndex = 1
        '
        'cbAccountFilter
        '
        Me.cbAccountFilter.FormattingEnabled = True
        Me.cbAccountFilter.Location = New System.Drawing.Point(15, -1)
        Me.cbAccountFilter.Name = "cbAccountFilter"
        Me.cbAccountFilter.Size = New System.Drawing.Size(76, 21)
        Me.cbAccountFilter.TabIndex = 0
        '
        'pnlReportsCharts
        '
        Me.pnlReportsCharts.AutoScroll = True
        Me.pnlReportsCharts.BackColor = System.Drawing.Color.White
        Me.pnlReportsCharts.Controls.Add(Me.chTrend)
        Me.pnlReportsCharts.Controls.Add(Me.chSpending)
        Me.pnlReportsCharts.Controls.Add(Me.chNet)
        Me.pnlReportsCharts.Location = New System.Drawing.Point(214, 87)
        Me.pnlReportsCharts.Name = "pnlReportsCharts"
        Me.pnlReportsCharts.Size = New System.Drawing.Size(613, 521)
        Me.pnlReportsCharts.TabIndex = 10
        Me.pnlReportsCharts.Visible = False
        '
        'chSpending
        '
        ChartArea3.Name = "ChartArea1"
        Me.chSpending.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chSpending.Legends.Add(Legend3)
        Me.chSpending.Location = New System.Drawing.Point(0, 300)
        Me.chSpending.Margin = New System.Windows.Forms.Padding(0)
        Me.chSpending.Name = "chSpending"
        Me.chSpending.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chSpending.Series.Add(Series3)
        Me.chSpending.Size = New System.Drawing.Size(596, 300)
        Me.chSpending.TabIndex = 11
        Me.chSpending.Text = "chSpending"
        '
        'chTrend
        '
        ChartArea2.Name = "ChartArea1"
        Me.chTrend.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chTrend.Legends.Add(Legend2)
        Me.chTrend.Location = New System.Drawing.Point(0, 600)
        Me.chTrend.Margin = New System.Windows.Forms.Padding(0)
        Me.chTrend.Name = "chTrend"
        Me.chTrend.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chTrend.Series.Add(Series2)
        Me.chTrend.Size = New System.Drawing.Size(596, 300)
        Me.chTrend.TabIndex = 12
        Me.chTrend.Text = "chTrend"
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1083, 608)
        Me.Controls.Add(Me.pnlReportsCharts)
        Me.Controls.Add(Me.pnlAccountsTransaction)
        Me.Controls.Add(Me.pnlReportsStatistics)
        Me.Controls.Add(Me.pnlBudgetStatistics)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.pnlAccountsFilter)
        Me.MaximumSize = New System.Drawing.Size(1099, 647)
        Me.MinimumSize = New System.Drawing.Size(1099, 647)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Based Budgeting"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.chNet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlNavigation.PerformLayout()
        Me.pnlBudgetStatistics.ResumeLayout(False)
        Me.pnlReportsStatistics.ResumeLayout(False)
        Me.pnlAccountsTransaction.ResumeLayout(False)
        Me.pnlAccountsTransaction.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccountsFilter.ResumeLayout(False)
        Me.pnlReportsCharts.ResumeLayout(False)
        CType(Me.chSpending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents pnlBudgetStatistics As Panel
    Friend WithEvents lblTotalBudgeted As Label
    Friend WithEvents lblTotalActivity As Label
    Friend WithEvents lblTotalAvailable As Label
    Friend WithEvents lblTotalInflow As Label
    Friend WithEvents lblTotalInflowValue As Label
    Friend WithEvents lblTotalAvailableValue As Label
    Friend WithEvents lblTotalActivityValue As Label
    Friend WithEvents lblTotalBudgetedValue As Label
    Friend WithEvents pnlReportsStatistics As Panel
    Friend WithEvents lblTotalSpending As Label
    Friend WithEvents lblIncluded As Label
    Friend WithEvents lblDateValue As Label
    Friend WithEvents lblTotalSpendingValue As Label
    Friend WithEvents lblAverageSpendingValue As Label
    Friend WithEvents lblPeriod2 As Label
    Friend WithEvents lblAverageSpending As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents pnlAccountsTransaction As Panel
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblPayee As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblInflow As Label
    Friend WithEvents lblOutflow As Label
    Friend WithEvents lblMemo As Label
    Friend WithEvents lblSubcategory As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents tbInflow As TextBox
    Friend WithEvents tbOutflow As TextBox
    Friend WithEvents tbMemo As TextBox
    Friend WithEvents cbSubcategory As ComboBox
    Friend WithEvents cbAccount As ComboBox
    Friend WithEvents cbPayee As ComboBox
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents pnlAccountsFilter As Panel
    Friend WithEvents cbAccountFilter As ComboBox
    Friend WithEvents cbCategoryFilter As ComboBox
    Friend WithEvents cbPayeeFilter As ComboBox
    Friend WithEvents cbSubcategoryFilter As ComboBox
    Friend WithEvents dtpDateFilter As DateTimePicker
    Friend WithEvents chNet As DataVisualization.Charting.Chart
    Friend WithEvents pnlReportsCharts As Panel
    Friend WithEvents chSpending As DataVisualization.Charting.Chart
    Friend WithEvents chTrend As DataVisualization.Charting.Chart
End Class
