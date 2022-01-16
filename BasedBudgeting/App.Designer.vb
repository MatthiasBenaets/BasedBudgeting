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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App))
        Me.chNet = New System.Windows.Forms.DataVisualization.Charting.Chart()
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
        Me.pbAddTransaction = New System.Windows.Forms.PictureBox()
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
        Me.tbMemoFilter = New System.Windows.Forms.TextBox()
        Me.btnResetTransaction = New System.Windows.Forms.Button()
        Me.dtpDateFilter = New System.Windows.Forms.DateTimePicker()
        Me.cbSubcategoryFilter = New System.Windows.Forms.ComboBox()
        Me.cbCategoryFilter = New System.Windows.Forms.ComboBox()
        Me.cbPayeeFilter = New System.Windows.Forms.ComboBox()
        Me.cbAccountFilter = New System.Windows.Forms.ComboBox()
        Me.pnlReportsCharts = New System.Windows.Forms.Panel()
        Me.chTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chSpending = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvBudget = New System.Windows.Forms.DataGridView()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBudgetControl = New System.Windows.Forms.Panel()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.checkVariables = New System.Windows.Forms.Timer(Me.components)
        Me.updateLabels = New System.Windows.Forms.Timer(Me.components)
        Me.redDetector = New System.Windows.Forms.Timer(Me.components)
        Me.btnBudget = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.lblTotalBalance = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.pbAddAccount = New System.Windows.Forms.PictureBox()
        Me.pnlWorkingBalance = New System.Windows.Forms.Panel()
        Me.lblWorkingBalanceValue = New System.Windows.Forms.Label()
        Me.lblWorkingBalance = New System.Windows.Forms.Label()
        Me.lblAllAccounts = New System.Windows.Forms.Label()
        Me.pbArrow2 = New System.Windows.Forms.PictureBox()
        Me.pnlToBeBudgeted = New System.Windows.Forms.Panel()
        Me.lblToBeBudgeted = New System.Windows.Forms.Label()
        Me.pbArrow = New System.Windows.Forms.PictureBox()
        Me.pbNextMonth = New System.Windows.Forms.PictureBox()
        Me.pbPrevMonth = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblToBeBudgetedValue = New System.Windows.Forms.Label()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.lblSpendingTrendButton = New System.Windows.Forms.Label()
        Me.lblSpendingButton = New System.Windows.Forms.Label()
        Me.lblNetWorthButton = New System.Windows.Forms.Label()
        Me.pnlNavigation = New System.Windows.Forms.Panel()
        Me.pnlNotesNav = New System.Windows.Forms.Panel()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.checkFilter = New System.Windows.Forms.Timer(Me.components)
        Me.pbDarkmode = New System.Windows.Forms.PictureBox()
        Me.pnlNotes = New System.Windows.Forms.Panel()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        CType(Me.chNet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBudgetStatistics.SuspendLayout()
        Me.pnlReportsStatistics.SuspendLayout()
        Me.pnlAccountsTransaction.SuspendLayout()
        CType(Me.pbAddTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccountsFilter.SuspendLayout()
        Me.pnlReportsCharts.SuspendLayout()
        CType(Me.chTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chSpending, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBudgetControl.SuspendLayout()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        CType(Me.pbAddAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWorkingBalance.SuspendLayout()
        CType(Me.pbArrow2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlToBeBudgeted.SuspendLayout()
        CType(Me.pbArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNextMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrevMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReports.SuspendLayout()
        Me.pnlNavigation.SuspendLayout()
        Me.pnlNotesNav.SuspendLayout()
        CType(Me.pbDarkmode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotes.SuspendLayout()
        Me.SuspendLayout()
        '
        'chNet
        '
        Me.chNet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chNet.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chNet.Legends.Add(Legend1)
        Me.chNet.Location = New System.Drawing.Point(0, 0)
        Me.chNet.Margin = New System.Windows.Forms.Padding(0)
        Me.chNet.Name = "chNet"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLabelStyle=Outside"
        Series1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.LabelFormat = "#%"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.SmartLabelStyle.MaxMovingDistance = 300.0R
        Me.chNet.Series.Add(Series1)
        Me.chNet.Size = New System.Drawing.Size(784, 593)
        Me.chNet.TabIndex = 10
        Me.chNet.Text = "chNet"
        Me.chNet.Visible = False
        '
        'pnlBudgetStatistics
        '
        Me.pnlBudgetStatistics.AutoSize = True
        Me.pnlBudgetStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalActivity)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalAvailable)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalInflow)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalBudgeted)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalBudgetedValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalActivityValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalAvailableValue)
        Me.pnlBudgetStatistics.Controls.Add(Me.lblTotalInflowValue)
        Me.pnlBudgetStatistics.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlBudgetStatistics.Location = New System.Drawing.Point(664, 88)
        Me.pnlBudgetStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBudgetStatistics.Name = "pnlBudgetStatistics"
        Me.pnlBudgetStatistics.Size = New System.Drawing.Size(200, 593)
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
        Me.lblTotalActivity.Size = New System.Drawing.Size(200, 17)
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
        Me.lblTotalAvailable.Size = New System.Drawing.Size(200, 17)
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
        Me.lblTotalInflow.Size = New System.Drawing.Size(200, 17)
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
        Me.lblTotalBudgeted.Size = New System.Drawing.Size(200, 17)
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
        Me.lblTotalBudgetedValue.Size = New System.Drawing.Size(202, 53)
        Me.lblTotalBudgetedValue.TabIndex = 7
        Me.lblTotalBudgetedValue.Text = "-"
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
        Me.lblTotalActivityValue.Size = New System.Drawing.Size(202, 53)
        Me.lblTotalActivityValue.TabIndex = 8
        Me.lblTotalActivityValue.Text = "-"
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
        Me.lblTotalAvailableValue.Size = New System.Drawing.Size(202, 53)
        Me.lblTotalAvailableValue.TabIndex = 9
        Me.lblTotalAvailableValue.Text = "-"
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
        Me.lblTotalInflowValue.Size = New System.Drawing.Size(202, 53)
        Me.lblTotalInflowValue.TabIndex = 10
        Me.lblTotalInflowValue.Text = "-"
        Me.lblTotalInflowValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReportsStatistics
        '
        Me.pnlReportsStatistics.AutoSize = True
        Me.pnlReportsStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlReportsStatistics.Controls.Add(Me.lblAverageSpendingValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblPeriod2)
        Me.pnlReportsStatistics.Controls.Add(Me.lblAverageSpending)
        Me.pnlReportsStatistics.Controls.Add(Me.lblTotalSpendingValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblPeriod)
        Me.pnlReportsStatistics.Controls.Add(Me.lblDateValue)
        Me.pnlReportsStatistics.Controls.Add(Me.lblTotalSpending)
        Me.pnlReportsStatistics.Controls.Add(Me.lblIncluded)
        Me.pnlReportsStatistics.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlReportsStatistics.Location = New System.Drawing.Point(1064, 88)
        Me.pnlReportsStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlReportsStatistics.Name = "pnlReportsStatistics"
        Me.pnlReportsStatistics.Size = New System.Drawing.Size(200, 593)
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
        Me.lblAverageSpendingValue.Size = New System.Drawing.Size(200, 37)
        Me.lblAverageSpendingValue.TabIndex = 12
        Me.lblAverageSpendingValue.Text = "-"
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
        Me.lblPeriod2.Size = New System.Drawing.Size(202, 23)
        Me.lblPeriod2.TabIndex = 13
        Me.lblPeriod2.Text = "Per month (last 12 months)"
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
        Me.lblAverageSpending.Size = New System.Drawing.Size(200, 20)
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
        Me.lblTotalSpendingValue.Size = New System.Drawing.Size(200, 37)
        Me.lblTotalSpendingValue.TabIndex = 8
        Me.lblTotalSpendingValue.Text = "-"
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
        Me.lblPeriod.Size = New System.Drawing.Size(202, 23)
        Me.lblPeriod.TabIndex = 10
        Me.lblPeriod.Text = "for this time period"
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
        Me.lblDateValue.Size = New System.Drawing.Size(200, 35)
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
        Me.lblTotalSpending.Size = New System.Drawing.Size(200, 20)
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
        Me.lblIncluded.Size = New System.Drawing.Size(202, 36)
        Me.lblIncluded.TabIndex = 3
        Me.lblIncluded.Text = "All categories and accounts included"
        Me.lblIncluded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAccountsTransaction
        '
        Me.pnlAccountsTransaction.AutoSize = True
        Me.pnlAccountsTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlAccountsTransaction.Controls.Add(Me.pbAddTransaction)
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
        Me.pnlAccountsTransaction.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlAccountsTransaction.Location = New System.Drawing.Point(864, 88)
        Me.pnlAccountsTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlAccountsTransaction.Name = "pnlAccountsTransaction"
        Me.pnlAccountsTransaction.Size = New System.Drawing.Size(200, 593)
        Me.pnlAccountsTransaction.TabIndex = 3
        Me.pnlAccountsTransaction.Visible = False
        '
        'pbAddTransaction
        '
        Me.pbAddTransaction.Image = Global.BasedBudgeting.My.Resources.Resources.addtransaction
        Me.pbAddTransaction.Location = New System.Drawing.Point(46, 442)
        Me.pbAddTransaction.Name = "pbAddTransaction"
        Me.pbAddTransaction.Size = New System.Drawing.Size(106, 23)
        Me.pbAddTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddTransaction.TabIndex = 21
        Me.pbAddTransaction.TabStop = False
        '
        'tbInflow
        '
        Me.tbInflow.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInflow.Location = New System.Drawing.Point(15, 394)
        Me.tbInflow.Name = "tbInflow"
        Me.tbInflow.Size = New System.Drawing.Size(172, 21)
        Me.tbInflow.TabIndex = 20
        '
        'tbOutflow
        '
        Me.tbOutflow.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOutflow.Location = New System.Drawing.Point(15, 342)
        Me.tbOutflow.Name = "tbOutflow"
        Me.tbOutflow.Size = New System.Drawing.Size(172, 21)
        Me.tbOutflow.TabIndex = 19
        '
        'tbMemo
        '
        Me.tbMemo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemo.Location = New System.Drawing.Point(15, 290)
        Me.tbMemo.Name = "tbMemo"
        Me.tbMemo.Size = New System.Drawing.Size(172, 21)
        Me.tbMemo.TabIndex = 18
        '
        'cbSubcategory
        '
        Me.cbSubcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubcategory.Enabled = False
        Me.cbSubcategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubcategory.FormattingEnabled = True
        Me.cbSubcategory.Location = New System.Drawing.Point(15, 238)
        Me.cbSubcategory.Name = "cbSubcategory"
        Me.cbSubcategory.Size = New System.Drawing.Size(172, 21)
        Me.cbSubcategory.TabIndex = 17
        '
        'cbAccount
        '
        Me.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccount.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.Location = New System.Drawing.Point(15, 30)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(172, 21)
        Me.cbAccount.TabIndex = 16
        '
        'cbPayee
        '
        Me.cbPayee.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPayee.FormattingEnabled = True
        Me.cbPayee.Location = New System.Drawing.Point(15, 134)
        Me.cbPayee.Name = "cbPayee"
        Me.cbPayee.Size = New System.Drawing.Size(172, 21)
        Me.cbPayee.TabIndex = 15
        '
        'cbCategory
        '
        Me.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategory.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(15, 186)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(172, 21)
        Me.cbCategory.TabIndex = 14
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Calibri", 11.25!)
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(15, 82)
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
        Me.lblInflow.Size = New System.Drawing.Size(200, 17)
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
        Me.lblOutflow.Size = New System.Drawing.Size(200, 17)
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
        Me.lblMemo.Size = New System.Drawing.Size(200, 17)
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
        Me.lblSubcategory.Size = New System.Drawing.Size(200, 17)
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
        Me.lblDate2.Size = New System.Drawing.Size(200, 17)
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
        Me.lblPayee.Size = New System.Drawing.Size(200, 17)
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
        Me.lblCategory.Size = New System.Drawing.Size(200, 17)
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
        Me.lblAccount.Size = New System.Drawing.Size(200, 17)
        Me.lblAccount.TabIndex = 3
        Me.lblAccount.Text = "ACCOUNT"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToResizeRows = False
        Me.dgvTransactions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTransactions.GridColor = System.Drawing.Color.LightGray
        Me.dgvTransactions.Location = New System.Drawing.Point(299, 104)
        Me.dgvTransactions.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTransactions.RowHeadersWidth = 15
        Me.dgvTransactions.RowTemplate.Height = 25
        Me.dgvTransactions.Size = New System.Drawing.Size(767, 578)
        Me.dgvTransactions.TabIndex = 8
        Me.dgvTransactions.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ACCOUNT"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "PAYEE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.HeaderText = "CATEGORY"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column5
        '
        Me.Column5.HeaderText = "SUBCATEGORY"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.HeaderText = "MEMO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column7
        '
        DataGridViewCellStyle3.Format = "C2"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column7.HeaderText = "OUTFLOW"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column8
        '
        DataGridViewCellStyle4.Format = "C2"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column8.HeaderText = "INFLOW"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'pnlAccountsFilter
        '
        Me.pnlAccountsFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccountsFilter.Controls.Add(Me.tbMemoFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.btnResetTransaction)
        Me.pnlAccountsFilter.Controls.Add(Me.dtpDateFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbSubcategoryFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbCategoryFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbPayeeFilter)
        Me.pnlAccountsFilter.Controls.Add(Me.cbAccountFilter)
        Me.pnlAccountsFilter.Location = New System.Drawing.Point(299, 87)
        Me.pnlAccountsFilter.Name = "pnlAccountsFilter"
        Me.pnlAccountsFilter.Size = New System.Drawing.Size(767, 18)
        Me.pnlAccountsFilter.TabIndex = 9
        Me.pnlAccountsFilter.Visible = False
        '
        'tbMemoFilter
        '
        Me.tbMemoFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbMemoFilter.Location = New System.Drawing.Point(526, -1)
        Me.tbMemoFilter.Name = "tbMemoFilter"
        Me.tbMemoFilter.Size = New System.Drawing.Size(100, 20)
        Me.tbMemoFilter.TabIndex = 6
        '
        'btnResetTransaction
        '
        Me.btnResetTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetTransaction.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetTransaction.Location = New System.Drawing.Point(625, -2)
        Me.btnResetTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.btnResetTransaction.Name = "btnResetTransaction"
        Me.btnResetTransaction.Size = New System.Drawing.Size(112, 21)
        Me.btnResetTransaction.TabIndex = 5
        Me.btnResetTransaction.Text = "Reset Filter"
        Me.btnResetTransaction.UseVisualStyleBackColor = True
        '
        'dtpDateFilter
        '
        Me.dtpDateFilter.CustomFormat = "MM yyyy"
        Me.dtpDateFilter.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFilter.Location = New System.Drawing.Point(117, -1)
        Me.dtpDateFilter.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFilter.Name = "dtpDateFilter"
        Me.dtpDateFilter.Size = New System.Drawing.Size(113, 21)
        Me.dtpDateFilter.TabIndex = 4
        '
        'cbSubcategoryFilter
        '
        Me.cbSubcategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSubcategoryFilter.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSubcategoryFilter.FormattingEnabled = True
        Me.cbSubcategoryFilter.Location = New System.Drawing.Point(427, -1)
        Me.cbSubcategoryFilter.Name = "cbSubcategoryFilter"
        Me.cbSubcategoryFilter.Size = New System.Drawing.Size(100, 21)
        Me.cbSubcategoryFilter.TabIndex = 3
        '
        'cbCategoryFilter
        '
        Me.cbCategoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategoryFilter.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoryFilter.FormattingEnabled = True
        Me.cbCategoryFilter.Location = New System.Drawing.Point(328, -1)
        Me.cbCategoryFilter.Name = "cbCategoryFilter"
        Me.cbCategoryFilter.Size = New System.Drawing.Size(100, 21)
        Me.cbCategoryFilter.TabIndex = 2
        '
        'cbPayeeFilter
        '
        Me.cbPayeeFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPayeeFilter.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPayeeFilter.FormattingEnabled = True
        Me.cbPayeeFilter.Location = New System.Drawing.Point(229, -1)
        Me.cbPayeeFilter.Name = "cbPayeeFilter"
        Me.cbPayeeFilter.Size = New System.Drawing.Size(100, 21)
        Me.cbPayeeFilter.TabIndex = 1
        '
        'cbAccountFilter
        '
        Me.cbAccountFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAccountFilter.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountFilter.FormattingEnabled = True
        Me.cbAccountFilter.Location = New System.Drawing.Point(18, -1)
        Me.cbAccountFilter.Name = "cbAccountFilter"
        Me.cbAccountFilter.Size = New System.Drawing.Size(100, 21)
        Me.cbAccountFilter.TabIndex = 0
        '
        'pnlReportsCharts
        '
        Me.pnlReportsCharts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlReportsCharts.AutoScroll = True
        Me.pnlReportsCharts.BackColor = System.Drawing.Color.White
        Me.pnlReportsCharts.Controls.Add(Me.chTrend)
        Me.pnlReportsCharts.Controls.Add(Me.chSpending)
        Me.pnlReportsCharts.Controls.Add(Me.chNet)
        Me.pnlReportsCharts.Location = New System.Drawing.Point(299, 88)
        Me.pnlReportsCharts.Name = "pnlReportsCharts"
        Me.pnlReportsCharts.Size = New System.Drawing.Size(767, 593)
        Me.pnlReportsCharts.TabIndex = 10
        Me.pnlReportsCharts.Visible = False
        '
        'chTrend
        '
        Me.chTrend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea2.Name = "ChartArea1"
        Me.chTrend.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chTrend.Legends.Add(Legend2)
        Me.chTrend.Location = New System.Drawing.Point(0, 0)
        Me.chTrend.Margin = New System.Windows.Forms.Padding(0)
        Me.chTrend.Name = "chTrend"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chTrend.Series.Add(Series2)
        Me.chTrend.Size = New System.Drawing.Size(784, 593)
        Me.chTrend.TabIndex = 12
        Me.chTrend.Text = "chTrend"
        Me.chTrend.Visible = False
        '
        'chSpending
        '
        Me.chSpending.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.Name = "ChartArea1"
        Me.chSpending.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chSpending.Legends.Add(Legend3)
        Me.chSpending.Location = New System.Drawing.Point(0, 0)
        Me.chSpending.Margin = New System.Windows.Forms.Padding(0)
        Me.chSpending.Name = "chSpending"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.chSpending.Series.Add(Series3)
        Me.chSpending.Size = New System.Drawing.Size(784, 593)
        Me.chSpending.TabIndex = 11
        Me.chSpending.Text = "chSpending"
        '
        'dgvBudget
        '
        Me.dgvBudget.AllowUserToAddRows = False
        Me.dgvBudget.AllowUserToResizeColumns = False
        Me.dgvBudget.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBudget.BackgroundColor = System.Drawing.Color.White
        Me.dgvBudget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBudget.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBudget.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBudget.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 9.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBudget.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvBudget.GridColor = System.Drawing.Color.LightGray
        Me.dgvBudget.Location = New System.Drawing.Point(299, 104)
        Me.dgvBudget.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvBudget.Name = "dgvBudget"
        Me.dgvBudget.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBudget.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvBudget.RowHeadersWidth = 15
        Me.dgvBudget.RowTemplate.Height = 25
        Me.dgvBudget.Size = New System.Drawing.Size(767, 578)
        Me.dgvBudget.TabIndex = 25
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column11.FillWeight = 300.0!
        Me.Column11.HeaderText = "CATEGORY"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = "0,00"
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column12.HeaderText = "BUDGETED"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0,00"
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column13.HeaderText = "ACTIVITY"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0,00"
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column14.HeaderText = "AVAILABLE"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        DataGridViewCellStyle12.NullValue = "S"
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column15.HeaderText = "Type"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'pnlBudgetControl
        '
        Me.pnlBudgetControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBudgetControl.BackColor = System.Drawing.Color.White
        Me.pnlBudgetControl.Controls.Add(Me.btnAddCategory)
        Me.pnlBudgetControl.Location = New System.Drawing.Point(299, 87)
        Me.pnlBudgetControl.Name = "pnlBudgetControl"
        Me.pnlBudgetControl.Size = New System.Drawing.Size(767, 17)
        Me.pnlBudgetControl.TabIndex = 13
        '
        'btnAddCategory
        '
        Me.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddCategory.FlatAppearance.BorderSize = 0
        Me.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCategory.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnAddCategory.Location = New System.Drawing.Point(-1, -6)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(92, 29)
        Me.btnAddCategory.TabIndex = 0
        Me.btnAddCategory.Text = "+ Add Category"
        Me.btnAddCategory.UseVisualStyleBackColor = False
        '
        'checkVariables
        '
        Me.checkVariables.Enabled = True
        Me.checkVariables.Interval = 500
        '
        'updateLabels
        '
        Me.updateLabels.Enabled = True
        Me.updateLabels.Interval = 500
        '
        'redDetector
        '
        Me.redDetector.Enabled = True
        Me.redDetector.Interval = 500
        '
        'btnBudget
        '
        Me.btnBudget.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBudget.FlatAppearance.BorderSize = 0
        Me.btnBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBudget.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnBudget.ForeColor = System.Drawing.Color.White
        Me.btnBudget.Location = New System.Drawing.Point(0, 87)
        Me.btnBudget.Margin = New System.Windows.Forms.Padding(0)
        Me.btnBudget.Name = "btnBudget"
        Me.btnBudget.Size = New System.Drawing.Size(300, 37)
        Me.btnBudget.TabIndex = 0
        Me.btnBudget.Text = "Budget"
        Me.btnBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBudget.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(0, 125)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(0)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(300, 37)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = False
        Me.btnReports.Visible = False
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnAccounts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(0, 162)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(300, 37)
        Me.btnAccounts.TabIndex = 2
        Me.btnAccounts.Text = "All Accounts"
        Me.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.UseVisualStyleBackColor = False
        Me.btnAccounts.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold)
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(7, 18)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitle.Size = New System.Drawing.Size(201, 49)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "My Budget"
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToResizeColumns = False
        Me.dgvAccounts.AllowUserToResizeRows = False
        Me.dgvAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccounts.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.dgvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.ColumnHeadersVisible = False
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10})
        Me.dgvAccounts.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAccounts.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvAccounts.GridColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.dgvAccounts.Location = New System.Drawing.Point(4, 252)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAccounts.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvAccounts.RowHeadersWidth = 10
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvAccounts.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvAccounts.Size = New System.Drawing.Size(291, 388)
        Me.dgvAccounts.TabIndex = 5
        '
        'Column9
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column9.HeaderText = "Account"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column10.HeaderText = "Balance"
        Me.Column10.Name = "Column10"
        '
        'lblBudget
        '
        Me.lblBudget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.ForeColor = System.Drawing.Color.White
        Me.lblBudget.Location = New System.Drawing.Point(4, 232)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(57, 18)
        Me.lblBudget.TabIndex = 6
        Me.lblBudget.Text = "BUDGET"
        Me.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBalance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.ForeColor = System.Drawing.Color.White
        Me.lblTotalBalance.Location = New System.Drawing.Point(150, 231)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotalBalance.Size = New System.Drawing.Size(140, 19)
        Me.lblTotalBalance.TabIndex = 7
        Me.lblTotalBalance.Text = "0.00"
        Me.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoSize = True
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnNotes)
        Me.pnlMenu.Controls.Add(Me.pbAddAccount)
        Me.pnlMenu.Controls.Add(Me.txtTitle)
        Me.pnlMenu.Controls.Add(Me.lblTotalBalance)
        Me.pnlMenu.Controls.Add(Me.lblBudget)
        Me.pnlMenu.Controls.Add(Me.dgvAccounts)
        Me.pnlMenu.Controls.Add(Me.btnAccounts)
        Me.pnlMenu.Controls.Add(Me.btnReports)
        Me.pnlMenu.Controls.Add(Me.btnBudget)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(300, 681)
        Me.pnlMenu.TabIndex = 0
        '
        'btnNotes
        '
        Me.btnNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNotes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNotes.FlatAppearance.BorderSize = 0
        Me.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotes.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnNotes.ForeColor = System.Drawing.Color.White
        Me.btnNotes.Location = New System.Drawing.Point(0, 644)
        Me.btnNotes.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(300, 37)
        Me.btnNotes.TabIndex = 9
        Me.btnNotes.Text = "Notes"
        Me.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotes.UseVisualStyleBackColor = False
        '
        'pbAddAccount
        '
        Me.pbAddAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAddAccount.Image = Global.BasedBudgeting.My.Resources.Resources.addaccount
        Me.pbAddAccount.Location = New System.Drawing.Point(7, 203)
        Me.pbAddAccount.Name = "pbAddAccount"
        Me.pbAddAccount.Size = New System.Drawing.Size(100, 22)
        Me.pbAddAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAddAccount.TabIndex = 8
        Me.pbAddAccount.TabStop = False
        '
        'pnlWorkingBalance
        '
        Me.pnlWorkingBalance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlWorkingBalance.AutoSize = True
        Me.pnlWorkingBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlWorkingBalance.Controls.Add(Me.lblWorkingBalanceValue)
        Me.pnlWorkingBalance.Controls.Add(Me.lblWorkingBalance)
        Me.pnlWorkingBalance.Controls.Add(Me.lblAllAccounts)
        Me.pnlWorkingBalance.Controls.Add(Me.pbArrow2)
        Me.pnlWorkingBalance.Location = New System.Drawing.Point(6, 1)
        Me.pnlWorkingBalance.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWorkingBalance.Name = "pnlWorkingBalance"
        Me.pnlWorkingBalance.Size = New System.Drawing.Size(963, 83)
        Me.pnlWorkingBalance.TabIndex = 26
        Me.pnlWorkingBalance.Visible = False
        '
        'lblWorkingBalanceValue
        '
        Me.lblWorkingBalanceValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblWorkingBalanceValue.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkingBalanceValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblWorkingBalanceValue.Location = New System.Drawing.Point(220, 27)
        Me.lblWorkingBalanceValue.Name = "lblWorkingBalanceValue"
        Me.lblWorkingBalanceValue.Size = New System.Drawing.Size(168, 36)
        Me.lblWorkingBalanceValue.TabIndex = 3
        Me.lblWorkingBalanceValue.Text = "0,00"
        Me.lblWorkingBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkingBalance
        '
        Me.lblWorkingBalance.AutoSize = True
        Me.lblWorkingBalance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkingBalance.ForeColor = System.Drawing.Color.White
        Me.lblWorkingBalance.Location = New System.Drawing.Point(233, 3)
        Me.lblWorkingBalance.Name = "lblWorkingBalance"
        Me.lblWorkingBalance.Size = New System.Drawing.Size(141, 23)
        Me.lblWorkingBalance.TabIndex = 2
        Me.lblWorkingBalance.Text = "Working Balance"
        '
        'lblAllAccounts
        '
        Me.lblAllAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAllAccounts.AutoSize = True
        Me.lblAllAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblAllAccounts.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllAccounts.ForeColor = System.Drawing.Color.White
        Me.lblAllAccounts.Location = New System.Drawing.Point(26, 26)
        Me.lblAllAccounts.Name = "lblAllAccounts"
        Me.lblAllAccounts.Size = New System.Drawing.Size(149, 33)
        Me.lblAllAccounts.TabIndex = 1
        Me.lblAllAccounts.Text = "All Accounts"
        '
        'pbArrow2
        '
        Me.pbArrow2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbArrow2.Image = Global.BasedBudgeting.My.Resources.Resources.arrow
        Me.pbArrow2.Location = New System.Drawing.Point(1, 16)
        Me.pbArrow2.Name = "pbArrow2"
        Me.pbArrow2.Size = New System.Drawing.Size(221, 53)
        Me.pbArrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArrow2.TabIndex = 0
        Me.pbArrow2.TabStop = False
        '
        'pnlToBeBudgeted
        '
        Me.pnlToBeBudgeted.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlToBeBudgeted.Controls.Add(Me.lblToBeBudgeted)
        Me.pnlToBeBudgeted.Controls.Add(Me.pbArrow)
        Me.pnlToBeBudgeted.Controls.Add(Me.pbNextMonth)
        Me.pnlToBeBudgeted.Controls.Add(Me.pbPrevMonth)
        Me.pnlToBeBudgeted.Controls.Add(Me.lblDate)
        Me.pnlToBeBudgeted.Controls.Add(Me.lblToBeBudgetedValue)
        Me.pnlToBeBudgeted.Location = New System.Drawing.Point(3, 2)
        Me.pnlToBeBudgeted.Name = "pnlToBeBudgeted"
        Me.pnlToBeBudgeted.Size = New System.Drawing.Size(959, 82)
        Me.pnlToBeBudgeted.TabIndex = 27
        '
        'lblToBeBudgeted
        '
        Me.lblToBeBudgeted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblToBeBudgeted.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblToBeBudgeted.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToBeBudgeted.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblToBeBudgeted.Location = New System.Drawing.Point(554, 8)
        Me.lblToBeBudgeted.Name = "lblToBeBudgeted"
        Me.lblToBeBudgeted.Size = New System.Drawing.Size(119, 63)
        Me.lblToBeBudgeted.TabIndex = 2
        Me.lblToBeBudgeted.Text = "To Be Budgeted"
        '
        'pbArrow
        '
        Me.pbArrow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbArrow.Image = Global.BasedBudgeting.My.Resources.Resources.arrow
        Me.pbArrow.Location = New System.Drawing.Point(533, -1)
        Me.pbArrow.Name = "pbArrow"
        Me.pbArrow.Size = New System.Drawing.Size(204, 80)
        Me.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArrow.TabIndex = 1
        Me.pbArrow.TabStop = False
        '
        'pbNextMonth
        '
        Me.pbNextMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNextMonth.Image = Global.BasedBudgeting.My.Resources.Resources.nextmonth
        Me.pbNextMonth.Location = New System.Drawing.Point(91, 24)
        Me.pbNextMonth.Name = "pbNextMonth"
        Me.pbNextMonth.Size = New System.Drawing.Size(34, 34)
        Me.pbNextMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNextMonth.TabIndex = 5
        Me.pbNextMonth.TabStop = False
        Me.pbNextMonth.Visible = False
        '
        'pbPrevMonth
        '
        Me.pbPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPrevMonth.Image = Global.BasedBudgeting.My.Resources.Resources.prevmonth
        Me.pbPrevMonth.Location = New System.Drawing.Point(316, 24)
        Me.pbPrevMonth.Name = "pbPrevMonth"
        Me.pbPrevMonth.Size = New System.Drawing.Size(34, 34)
        Me.pbPrevMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPrevMonth.TabIndex = 4
        Me.pbPrevMonth.TabStop = False
        Me.pbPrevMonth.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(142, 18)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(117, 45)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "[Date]"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblToBeBudgetedValue
        '
        Me.lblToBeBudgetedValue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblToBeBudgetedValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblToBeBudgetedValue.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToBeBudgetedValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblToBeBudgetedValue.Location = New System.Drawing.Point(742, 2)
        Me.lblToBeBudgetedValue.Name = "lblToBeBudgetedValue"
        Me.lblToBeBudgetedValue.Size = New System.Drawing.Size(213, 77)
        Me.lblToBeBudgetedValue.TabIndex = 3
        Me.lblToBeBudgetedValue.Text = "0,00 €"
        Me.lblToBeBudgetedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlReports
        '
        Me.pnlReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlReports.AutoSize = True
        Me.pnlReports.Controls.Add(Me.lblSpendingTrendButton)
        Me.pnlReports.Controls.Add(Me.lblSpendingButton)
        Me.pnlReports.Controls.Add(Me.lblNetWorthButton)
        Me.pnlReports.Location = New System.Drawing.Point(3, 0)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(963, 88)
        Me.pnlReports.TabIndex = 28
        Me.pnlReports.Visible = False
        '
        'lblSpendingTrendButton
        '
        Me.lblSpendingTrendButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSpendingTrendButton.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpendingTrendButton.ForeColor = System.Drawing.Color.White
        Me.lblSpendingTrendButton.Location = New System.Drawing.Point(439, 12)
        Me.lblSpendingTrendButton.Name = "lblSpendingTrendButton"
        Me.lblSpendingTrendButton.Size = New System.Drawing.Size(211, 64)
        Me.lblSpendingTrendButton.TabIndex = 2
        Me.lblSpendingTrendButton.Text = "Spending Trend"
        Me.lblSpendingTrendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSpendingButton
        '
        Me.lblSpendingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblSpendingButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSpendingButton.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpendingButton.ForeColor = System.Drawing.Color.White
        Me.lblSpendingButton.Image = CType(resources.GetObject("lblSpendingButton.Image"), System.Drawing.Image)
        Me.lblSpendingButton.Location = New System.Drawing.Point(4, 11)
        Me.lblSpendingButton.Name = "lblSpendingButton"
        Me.lblSpendingButton.Size = New System.Drawing.Size(211, 64)
        Me.lblSpendingButton.TabIndex = 1
        Me.lblSpendingButton.Text = "Spending "
        Me.lblSpendingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetWorthButton
        '
        Me.lblNetWorthButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNetWorthButton.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetWorthButton.ForeColor = System.Drawing.Color.White
        Me.lblNetWorthButton.Location = New System.Drawing.Point(208, 11)
        Me.lblNetWorthButton.Name = "lblNetWorthButton"
        Me.lblNetWorthButton.Size = New System.Drawing.Size(211, 64)
        Me.lblNetWorthButton.TabIndex = 0
        Me.lblNetWorthButton.Text = "Net Worth"
        Me.lblNetWorthButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlNavigation
        '
        Me.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlNavigation.Controls.Add(Me.pnlToBeBudgeted)
        Me.pnlNavigation.Controls.Add(Me.pnlNotesNav)
        Me.pnlNavigation.Controls.Add(Me.pnlReports)
        Me.pnlNavigation.Controls.Add(Me.pnlWorkingBalance)
        Me.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlNavigation.Location = New System.Drawing.Point(300, 0)
        Me.pnlNavigation.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlNavigation.Name = "pnlNavigation"
        Me.pnlNavigation.Size = New System.Drawing.Size(964, 88)
        Me.pnlNavigation.TabIndex = 1
        '
        'pnlNotesNav
        '
        Me.pnlNotesNav.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNotesNav.Controls.Add(Me.lblNotes)
        Me.pnlNotesNav.Location = New System.Drawing.Point(3, 2)
        Me.pnlNotesNav.Name = "pnlNotesNav"
        Me.pnlNotesNav.Size = New System.Drawing.Size(962, 83)
        Me.pnlNotesNav.TabIndex = 28
        Me.pnlNotesNav.Visible = False
        '
        'lblNotes
        '
        Me.lblNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.White
        Me.lblNotes.Location = New System.Drawing.Point(839, 18)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(111, 45)
        Me.lblNotes.TabIndex = 0
        Me.lblNotes.Text = "Notes"
        Me.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'checkFilter
        '
        Me.checkFilter.Enabled = True
        Me.checkFilter.Interval = 500
        '
        'pbDarkmode
        '
        Me.pbDarkmode.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.pbDarkmode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbDarkmode.Image = Global.BasedBudgeting.My.Resources.Resources.sun
        Me.pbDarkmode.Location = New System.Drawing.Point(0, 0)
        Me.pbDarkmode.Name = "pbDarkmode"
        Me.pbDarkmode.Size = New System.Drawing.Size(20, 20)
        Me.pbDarkmode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDarkmode.TabIndex = 26
        Me.pbDarkmode.TabStop = False
        '
        'pnlNotes
        '
        Me.pnlNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlNotes.Controls.Add(Me.rtbNotes)
        Me.pnlNotes.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlNotes.Location = New System.Drawing.Point(300, 88)
        Me.pnlNotes.Name = "pnlNotes"
        Me.pnlNotes.Size = New System.Drawing.Size(965, 595)
        Me.pnlNotes.TabIndex = 27
        Me.pnlNotes.Visible = False
        '
        'rtbNotes
        '
        Me.rtbNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbNotes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbNotes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.rtbNotes.Location = New System.Drawing.Point(10, 12)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(952, 583)
        Me.rtbNotes.TabIndex = 0
        Me.rtbNotes.Text = ""
        '
        'App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.pnlNotes)
        Me.Controls.Add(Me.pbDarkmode)
        Me.Controls.Add(Me.pnlBudgetStatistics)
        Me.Controls.Add(Me.pnlAccountsTransaction)
        Me.Controls.Add(Me.pnlReportsStatistics)
        Me.Controls.Add(Me.pnlNavigation)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.pnlAccountsFilter)
        Me.Controls.Add(Me.pnlReportsCharts)
        Me.Controls.Add(Me.pnlBudgetControl)
        Me.Controls.Add(Me.dgvBudget)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "App"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Based Budgeting"
        CType(Me.chNet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBudgetStatistics.ResumeLayout(False)
        Me.pnlReportsStatistics.ResumeLayout(False)
        Me.pnlAccountsTransaction.ResumeLayout(False)
        Me.pnlAccountsTransaction.PerformLayout()
        CType(Me.pbAddTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccountsFilter.ResumeLayout(False)
        Me.pnlAccountsFilter.PerformLayout()
        Me.pnlReportsCharts.ResumeLayout(False)
        CType(Me.chTrend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chSpending, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBudgetControl.ResumeLayout(False)
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        CType(Me.pbAddAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWorkingBalance.ResumeLayout(False)
        Me.pnlWorkingBalance.PerformLayout()
        CType(Me.pbArrow2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlToBeBudgeted.ResumeLayout(False)
        Me.pnlToBeBudgeted.PerformLayout()
        CType(Me.pbArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNextMonth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrevMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReports.ResumeLayout(False)
        Me.pnlNavigation.ResumeLayout(False)
        Me.pnlNavigation.PerformLayout()
        Me.pnlNotesNav.ResumeLayout(False)
        Me.pnlNotesNav.PerformLayout()
        CType(Me.pbDarkmode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents dgvBudget As DataGridView
    Friend WithEvents pnlBudgetControl As Panel
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents checkVariables As Timer
    Friend WithEvents updateLabels As Timer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents redDetector As Timer
    Friend WithEvents btnResetTransaction As Button
    Friend WithEvents btnBudget As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents lblBudget As Label
    Friend WithEvents lblTotalBalance As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlWorkingBalance As Panel
    Friend WithEvents lblWorkingBalanceValue As Label
    Friend WithEvents lblWorkingBalance As Label
    Friend WithEvents lblAllAccounts As Label
    Friend WithEvents pbArrow2 As PictureBox
    Friend WithEvents pnlToBeBudgeted As Panel
    Friend WithEvents lblToBeBudgeted As Label
    Friend WithEvents pbArrow As PictureBox
    Friend WithEvents pbNextMonth As PictureBox
    Friend WithEvents pbPrevMonth As PictureBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblToBeBudgetedValue As Label
    Friend WithEvents pnlReports As Panel
    Friend WithEvents pnlNavigation As Panel
    Friend WithEvents lblNetWorthButton As Label
    Friend WithEvents lblSpendingButton As Label
    Friend WithEvents lblSpendingTrendButton As Label
    Friend WithEvents pbAddAccount As PictureBox
    Friend WithEvents pbAddTransaction As PictureBox
    Friend WithEvents tbMemoFilter As TextBox
    Friend WithEvents checkFilter As Timer
    Friend WithEvents pbDarkmode As PictureBox
    Friend WithEvents btnNotes As Button
    Friend WithEvents pnlNotes As Panel
    Friend WithEvents rtbNotes As RichTextBox
    Friend WithEvents pnlNotesNav As Panel
    Friend WithEvents lblNotes As Label
End Class
