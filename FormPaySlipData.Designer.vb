<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPayslipData
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UANNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicForPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployerPFContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunicationAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApparelAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResearchAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseRentAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaptopAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VariablePayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeePFDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDSDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDeductionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDeductionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAllowancesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetSalaryInWordsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaySlipStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofLeavingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayrollDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Payroll = New WindowsApp1.DS_Payroll()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_PaySlipFolderPath = New System.Windows.Forms.TextBox()
        Me.Btn_GenereatePayslip = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label_PaySlipPathMessage = New System.Windows.Forms.Label()
        Me.Button_PaySlip = New System.Windows.Forms.Button()
        Me.Btn_BrowsePaySlipFolderPath = New System.Windows.Forms.Button()
        Me.PayrollDataTableAdapter = New WindowsApp1.DS_PayrollTableAdapters.PayrollDataTableAdapter()
        Me.Btn_Export2XL = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_RowsCount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEmpName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCompany = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(421, 15)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(249, 26)
        Me.Label38.TabIndex = 60
        Me.Label38.Text = "Employee Payslip Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNoDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.CompanyDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.DOJDataGridViewTextBoxColumn, Me.PFNoDataGridViewTextBoxColumn, Me.UANNoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PaymentMonthDataGridViewTextBoxColumn, Me.StandardMonthlyCTCDataGridViewTextBoxColumn, Me.STDDaysDataGridViewTextBoxColumn, Me.DaysPayDataGridViewTextBoxColumn, Me.GrossCTCDataGridViewTextBoxColumn, Me.BasicDataGridViewTextBoxColumn, Me.BasicForPFDataGridViewTextBoxColumn, Me.EmployerPFContributionDataGridViewTextBoxColumn, Me.ESICEmployerDataGridViewTextBoxColumn, Me.TransportAllowanceDataGridViewTextBoxColumn, Me.CommunicationAllowanceDataGridViewTextBoxColumn, Me.ApparelAllowanceDataGridViewTextBoxColumn, Me.ResearchAllowanceDataGridViewTextBoxColumn, Me.MedicalAllowanceDataGridViewTextBoxColumn, Me.HouseRentAllowanceDataGridViewTextBoxColumn, Me.LeaveTravelAllowanceDataGridViewTextBoxColumn, Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn, Me.ConveyanceAllowanceDataGridViewTextBoxColumn, Me.SpecialAllowanceDataGridViewTextBoxColumn, Me.LaptopAllowanceDataGridViewTextBoxColumn, Me.BonusDataGridViewTextBoxColumn, Me.ArrearsDataGridViewTextBoxColumn, Me.VariablePayDataGridViewTextBoxColumn, Me.GrossSalaryDataGridViewTextBoxColumn, Me.EmployeePFDeductionDataGridViewTextBoxColumn, Me.ESICEmployeeDataGridViewTextBoxColumn, Me.TDSDeductionDataGridViewTextBoxColumn, Me.SodexoCouponsDeductionDataGridViewTextBoxColumn, Me.OtherDeductionsDataGridViewTextBoxColumn, Me.TotalDeductionsDataGridViewTextBoxColumn, Me.NetSalaryDataGridViewTextBoxColumn, Me.TotalAllowancesDataGridViewTextBoxColumn, Me.NetSalaryInWordsDataGridViewTextBoxColumn, Me.PaySlipStatusDataGridViewTextBoxColumn, Me.DateofLeavingDataGridViewTextBoxColumn, Me.SalaryStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PayrollDataBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.Location = New System.Drawing.Point(29, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1039, 436)
        Me.DataGridView1.TabIndex = 65
        '
        'SNoDataGridViewTextBoxColumn
        '
        Me.SNoDataGridViewTextBoxColumn.DataPropertyName = "S_No"
        Me.SNoDataGridViewTextBoxColumn.Frozen = True
        Me.SNoDataGridViewTextBoxColumn.HeaderText = "S_No"
        Me.SNoDataGridViewTextBoxColumn.Name = "SNoDataGridViewTextBoxColumn"
        Me.SNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SNoDataGridViewTextBoxColumn.Width = 59
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Frozen = True
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Width = 70
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Frozen = True
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeNameDataGridViewTextBoxColumn.Width = 112
        '
        'CompanyDataGridViewTextBoxColumn
        '
        Me.CompanyDataGridViewTextBoxColumn.DataPropertyName = "Company"
        Me.CompanyDataGridViewTextBoxColumn.HeaderText = "Company"
        Me.CompanyDataGridViewTextBoxColumn.Name = "CompanyDataGridViewTextBoxColumn"
        Me.CompanyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyDataGridViewTextBoxColumn.Width = 76
        '
        'DesignationDataGridViewTextBoxColumn
        '
        Me.DesignationDataGridViewTextBoxColumn.DataPropertyName = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.HeaderText = "Designation"
        Me.DesignationDataGridViewTextBoxColumn.Name = "DesignationDataGridViewTextBoxColumn"
        Me.DesignationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesignationDataGridViewTextBoxColumn.Width = 88
        '
        'DOJDataGridViewTextBoxColumn
        '
        Me.DOJDataGridViewTextBoxColumn.DataPropertyName = "DOJ"
        DataGridViewCellStyle7.Format = "dd-MMM-yyyy"
        Me.DOJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DOJDataGridViewTextBoxColumn.HeaderText = "DOJ"
        Me.DOJDataGridViewTextBoxColumn.Name = "DOJDataGridViewTextBoxColumn"
        Me.DOJDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOJDataGridViewTextBoxColumn.Width = 53
        '
        'PFNoDataGridViewTextBoxColumn
        '
        Me.PFNoDataGridViewTextBoxColumn.DataPropertyName = "PF_No"
        Me.PFNoDataGridViewTextBoxColumn.HeaderText = "PF_No"
        Me.PFNoDataGridViewTextBoxColumn.Name = "PFNoDataGridViewTextBoxColumn"
        Me.PFNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFNoDataGridViewTextBoxColumn.Width = 65
        '
        'UANNoDataGridViewTextBoxColumn
        '
        Me.UANNoDataGridViewTextBoxColumn.DataPropertyName = "UAN_No"
        Me.UANNoDataGridViewTextBoxColumn.HeaderText = "UAN_No"
        Me.UANNoDataGridViewTextBoxColumn.Name = "UANNoDataGridViewTextBoxColumn"
        Me.UANNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UANNoDataGridViewTextBoxColumn.Width = 75
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E_mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E_mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 63
        '
        'PaymentMonthDataGridViewTextBoxColumn
        '
        Me.PaymentMonthDataGridViewTextBoxColumn.DataPropertyName = "Payment_Month"
        Me.PaymentMonthDataGridViewTextBoxColumn.HeaderText = "Payment_Month"
        Me.PaymentMonthDataGridViewTextBoxColumn.Name = "PaymentMonthDataGridViewTextBoxColumn"
        Me.PaymentMonthDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaymentMonthDataGridViewTextBoxColumn.Width = 109
        '
        'StandardMonthlyCTCDataGridViewTextBoxColumn
        '
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn.DataPropertyName = "Standard_Monthly_CTC"
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn.HeaderText = "Standard_Monthly_CTC"
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn.Name = "StandardMonthlyCTCDataGridViewTextBoxColumn"
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.StandardMonthlyCTCDataGridViewTextBoxColumn.Width = 145
        '
        'STDDaysDataGridViewTextBoxColumn
        '
        Me.STDDaysDataGridViewTextBoxColumn.DataPropertyName = "STD_Days"
        Me.STDDaysDataGridViewTextBoxColumn.HeaderText = "STD_Days"
        Me.STDDaysDataGridViewTextBoxColumn.Name = "STDDaysDataGridViewTextBoxColumn"
        Me.STDDaysDataGridViewTextBoxColumn.ReadOnly = True
        Me.STDDaysDataGridViewTextBoxColumn.Width = 84
        '
        'DaysPayDataGridViewTextBoxColumn
        '
        Me.DaysPayDataGridViewTextBoxColumn.DataPropertyName = "Days_Pay"
        Me.DaysPayDataGridViewTextBoxColumn.HeaderText = "Days_Pay"
        Me.DaysPayDataGridViewTextBoxColumn.Name = "DaysPayDataGridViewTextBoxColumn"
        Me.DaysPayDataGridViewTextBoxColumn.ReadOnly = True
        Me.DaysPayDataGridViewTextBoxColumn.Width = 80
        '
        'GrossCTCDataGridViewTextBoxColumn
        '
        Me.GrossCTCDataGridViewTextBoxColumn.DataPropertyName = "Gross_CTC"
        Me.GrossCTCDataGridViewTextBoxColumn.HeaderText = "Gross_CTC"
        Me.GrossCTCDataGridViewTextBoxColumn.Name = "GrossCTCDataGridViewTextBoxColumn"
        Me.GrossCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrossCTCDataGridViewTextBoxColumn.Width = 86
        '
        'BasicDataGridViewTextBoxColumn
        '
        Me.BasicDataGridViewTextBoxColumn.DataPropertyName = "Basic"
        Me.BasicDataGridViewTextBoxColumn.HeaderText = "Basic"
        Me.BasicDataGridViewTextBoxColumn.Name = "BasicDataGridViewTextBoxColumn"
        Me.BasicDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasicDataGridViewTextBoxColumn.Width = 58
        '
        'BasicForPFDataGridViewTextBoxColumn
        '
        Me.BasicForPFDataGridViewTextBoxColumn.DataPropertyName = "Basic_For_PF"
        Me.BasicForPFDataGridViewTextBoxColumn.HeaderText = "Basic_For_PF"
        Me.BasicForPFDataGridViewTextBoxColumn.Name = "BasicForPFDataGridViewTextBoxColumn"
        Me.BasicForPFDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasicForPFDataGridViewTextBoxColumn.Width = 98
        '
        'EmployerPFContributionDataGridViewTextBoxColumn
        '
        Me.EmployerPFContributionDataGridViewTextBoxColumn.DataPropertyName = "Employer_PF_Contribution"
        Me.EmployerPFContributionDataGridViewTextBoxColumn.HeaderText = "Employer_PF_Contribution"
        Me.EmployerPFContributionDataGridViewTextBoxColumn.Name = "EmployerPFContributionDataGridViewTextBoxColumn"
        Me.EmployerPFContributionDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployerPFContributionDataGridViewTextBoxColumn.Width = 156
        '
        'ESICEmployerDataGridViewTextBoxColumn
        '
        Me.ESICEmployerDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employer"
        Me.ESICEmployerDataGridViewTextBoxColumn.HeaderText = "ESIC_Employer"
        Me.ESICEmployerDataGridViewTextBoxColumn.Name = "ESICEmployerDataGridViewTextBoxColumn"
        Me.ESICEmployerDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployerDataGridViewTextBoxColumn.Width = 105
        '
        'TransportAllowanceDataGridViewTextBoxColumn
        '
        Me.TransportAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Transport_Allowance"
        Me.TransportAllowanceDataGridViewTextBoxColumn.HeaderText = "Transport_Allowance"
        Me.TransportAllowanceDataGridViewTextBoxColumn.Name = "TransportAllowanceDataGridViewTextBoxColumn"
        Me.TransportAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransportAllowanceDataGridViewTextBoxColumn.Width = 132
        '
        'CommunicationAllowanceDataGridViewTextBoxColumn
        '
        Me.CommunicationAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Communication_Allowance"
        Me.CommunicationAllowanceDataGridViewTextBoxColumn.HeaderText = "Communication_Allowance"
        Me.CommunicationAllowanceDataGridViewTextBoxColumn.Name = "CommunicationAllowanceDataGridViewTextBoxColumn"
        Me.CommunicationAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommunicationAllowanceDataGridViewTextBoxColumn.Width = 159
        '
        'ApparelAllowanceDataGridViewTextBoxColumn
        '
        Me.ApparelAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Apparel_Allowance"
        Me.ApparelAllowanceDataGridViewTextBoxColumn.HeaderText = "Apparel_Allowance"
        Me.ApparelAllowanceDataGridViewTextBoxColumn.Name = "ApparelAllowanceDataGridViewTextBoxColumn"
        Me.ApparelAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApparelAllowanceDataGridViewTextBoxColumn.Width = 123
        '
        'ResearchAllowanceDataGridViewTextBoxColumn
        '
        Me.ResearchAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Research_Allowance"
        Me.ResearchAllowanceDataGridViewTextBoxColumn.HeaderText = "Research_Allowance"
        Me.ResearchAllowanceDataGridViewTextBoxColumn.Name = "ResearchAllowanceDataGridViewTextBoxColumn"
        Me.ResearchAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResearchAllowanceDataGridViewTextBoxColumn.Width = 133
        '
        'MedicalAllowanceDataGridViewTextBoxColumn
        '
        Me.MedicalAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Medical_Allowance"
        Me.MedicalAllowanceDataGridViewTextBoxColumn.HeaderText = "Medical_Allowance"
        Me.MedicalAllowanceDataGridViewTextBoxColumn.Name = "MedicalAllowanceDataGridViewTextBoxColumn"
        Me.MedicalAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicalAllowanceDataGridViewTextBoxColumn.Width = 124
        '
        'HouseRentAllowanceDataGridViewTextBoxColumn
        '
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.DataPropertyName = "House_Rent_Allowance"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.HeaderText = "House_Rent_Allowance"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.Name = "HouseRentAllowanceDataGridViewTextBoxColumn"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.Width = 147
        '
        'LeaveTravelAllowanceDataGridViewTextBoxColumn
        '
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Leave_Travel_Allowance"
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn.HeaderText = "Leave_Travel_Allowance"
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn.Name = "LeaveTravelAllowanceDataGridViewTextBoxColumn"
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn.Width = 153
        '
        'MealAllowanceSodexoCouponsDataGridViewTextBoxColumn
        '
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn.DataPropertyName = "Meal_Allowance_Sodexo_Coupons"
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn.HeaderText = "Meal_Allowance_Sodexo_Coupons"
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn.Name = "MealAllowanceSodexoCouponsDataGridViewTextBoxColumn"
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn.ReadOnly = True
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn.Width = 200
        '
        'ConveyanceAllowanceDataGridViewTextBoxColumn
        '
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Conveyance_Allowance"
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn.HeaderText = "Conveyance_Allowance"
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn.Name = "ConveyanceAllowanceDataGridViewTextBoxColumn"
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn.Width = 147
        '
        'SpecialAllowanceDataGridViewTextBoxColumn
        '
        Me.SpecialAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Special_Allowance"
        Me.SpecialAllowanceDataGridViewTextBoxColumn.HeaderText = "Special_Allowance"
        Me.SpecialAllowanceDataGridViewTextBoxColumn.Name = "SpecialAllowanceDataGridViewTextBoxColumn"
        Me.SpecialAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SpecialAllowanceDataGridViewTextBoxColumn.Width = 122
        '
        'LaptopAllowanceDataGridViewTextBoxColumn
        '
        Me.LaptopAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Laptop_Allowance"
        Me.LaptopAllowanceDataGridViewTextBoxColumn.HeaderText = "Laptop_Allowance"
        Me.LaptopAllowanceDataGridViewTextBoxColumn.Name = "LaptopAllowanceDataGridViewTextBoxColumn"
        Me.LaptopAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.LaptopAllowanceDataGridViewTextBoxColumn.Width = 120
        '
        'BonusDataGridViewTextBoxColumn
        '
        Me.BonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.HeaderText = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.Name = "BonusDataGridViewTextBoxColumn"
        Me.BonusDataGridViewTextBoxColumn.ReadOnly = True
        Me.BonusDataGridViewTextBoxColumn.Width = 62
        '
        'ArrearsDataGridViewTextBoxColumn
        '
        Me.ArrearsDataGridViewTextBoxColumn.DataPropertyName = "Arrears"
        Me.ArrearsDataGridViewTextBoxColumn.HeaderText = "Arrears"
        Me.ArrearsDataGridViewTextBoxColumn.Name = "ArrearsDataGridViewTextBoxColumn"
        Me.ArrearsDataGridViewTextBoxColumn.ReadOnly = True
        Me.ArrearsDataGridViewTextBoxColumn.Width = 65
        '
        'VariablePayDataGridViewTextBoxColumn
        '
        Me.VariablePayDataGridViewTextBoxColumn.DataPropertyName = "Variable_Pay"
        Me.VariablePayDataGridViewTextBoxColumn.HeaderText = "Variable_Pay"
        Me.VariablePayDataGridViewTextBoxColumn.Name = "VariablePayDataGridViewTextBoxColumn"
        Me.VariablePayDataGridViewTextBoxColumn.ReadOnly = True
        Me.VariablePayDataGridViewTextBoxColumn.Width = 94
        '
        'GrossSalaryDataGridViewTextBoxColumn
        '
        Me.GrossSalaryDataGridViewTextBoxColumn.DataPropertyName = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.HeaderText = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.Name = "GrossSalaryDataGridViewTextBoxColumn"
        Me.GrossSalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrossSalaryDataGridViewTextBoxColumn.Width = 94
        '
        'EmployeePFDeductionDataGridViewTextBoxColumn
        '
        Me.EmployeePFDeductionDataGridViewTextBoxColumn.DataPropertyName = "Employee_PF_Deduction"
        Me.EmployeePFDeductionDataGridViewTextBoxColumn.HeaderText = "Employee_PF_Deduction"
        Me.EmployeePFDeductionDataGridViewTextBoxColumn.Name = "EmployeePFDeductionDataGridViewTextBoxColumn"
        Me.EmployeePFDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeePFDeductionDataGridViewTextBoxColumn.Width = 152
        '
        'ESICEmployeeDataGridViewTextBoxColumn
        '
        Me.ESICEmployeeDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employee"
        Me.ESICEmployeeDataGridViewTextBoxColumn.HeaderText = "ESIC_Employee"
        Me.ESICEmployeeDataGridViewTextBoxColumn.Name = "ESICEmployeeDataGridViewTextBoxColumn"
        Me.ESICEmployeeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployeeDataGridViewTextBoxColumn.Width = 108
        '
        'TDSDeductionDataGridViewTextBoxColumn
        '
        Me.TDSDeductionDataGridViewTextBoxColumn.DataPropertyName = "TDS_Deduction"
        Me.TDSDeductionDataGridViewTextBoxColumn.HeaderText = "TDS_Deduction"
        Me.TDSDeductionDataGridViewTextBoxColumn.Name = "TDSDeductionDataGridViewTextBoxColumn"
        Me.TDSDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TDSDeductionDataGridViewTextBoxColumn.Width = 109
        '
        'SodexoCouponsDeductionDataGridViewTextBoxColumn
        '
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.DataPropertyName = "Sodexo_Coupons_Deduction"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.HeaderText = "Sodexo_Coupons_Deduction"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.Name = "SodexoCouponsDeductionDataGridViewTextBoxColumn"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.Width = 171
        '
        'OtherDeductionsDataGridViewTextBoxColumn
        '
        Me.OtherDeductionsDataGridViewTextBoxColumn.DataPropertyName = "Other_Deductions"
        Me.OtherDeductionsDataGridViewTextBoxColumn.HeaderText = "Other_Deductions"
        Me.OtherDeductionsDataGridViewTextBoxColumn.Name = "OtherDeductionsDataGridViewTextBoxColumn"
        Me.OtherDeductionsDataGridViewTextBoxColumn.ReadOnly = True
        Me.OtherDeductionsDataGridViewTextBoxColumn.Width = 118
        '
        'TotalDeductionsDataGridViewTextBoxColumn
        '
        Me.TotalDeductionsDataGridViewTextBoxColumn.DataPropertyName = "Total_Deductions"
        Me.TotalDeductionsDataGridViewTextBoxColumn.HeaderText = "Total_Deductions"
        Me.TotalDeductionsDataGridViewTextBoxColumn.Name = "TotalDeductionsDataGridViewTextBoxColumn"
        Me.TotalDeductionsDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDeductionsDataGridViewTextBoxColumn.Width = 116
        '
        'NetSalaryDataGridViewTextBoxColumn
        '
        Me.NetSalaryDataGridViewTextBoxColumn.DataPropertyName = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.HeaderText = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.Name = "NetSalaryDataGridViewTextBoxColumn"
        Me.NetSalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.NetSalaryDataGridViewTextBoxColumn.Width = 84
        '
        'TotalAllowancesDataGridViewTextBoxColumn
        '
        Me.TotalAllowancesDataGridViewTextBoxColumn.DataPropertyName = "Total_Allowances"
        Me.TotalAllowancesDataGridViewTextBoxColumn.HeaderText = "Total_Allowances"
        Me.TotalAllowancesDataGridViewTextBoxColumn.Name = "TotalAllowancesDataGridViewTextBoxColumn"
        Me.TotalAllowancesDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalAllowancesDataGridViewTextBoxColumn.Width = 116
        '
        'NetSalaryInWordsDataGridViewTextBoxColumn
        '
        Me.NetSalaryInWordsDataGridViewTextBoxColumn.DataPropertyName = "Net_Salary_In_Words"
        Me.NetSalaryInWordsDataGridViewTextBoxColumn.HeaderText = "Net_Salary_In_Words"
        Me.NetSalaryInWordsDataGridViewTextBoxColumn.Name = "NetSalaryInWordsDataGridViewTextBoxColumn"
        Me.NetSalaryInWordsDataGridViewTextBoxColumn.ReadOnly = True
        Me.NetSalaryInWordsDataGridViewTextBoxColumn.Width = 136
        '
        'PaySlipStatusDataGridViewTextBoxColumn
        '
        Me.PaySlipStatusDataGridViewTextBoxColumn.DataPropertyName = "PaySlip_Status"
        Me.PaySlipStatusDataGridViewTextBoxColumn.HeaderText = "PaySlip_Status"
        Me.PaySlipStatusDataGridViewTextBoxColumn.Name = "PaySlipStatusDataGridViewTextBoxColumn"
        Me.PaySlipStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.PaySlipStatusDataGridViewTextBoxColumn.Width = 103
        '
        'DateofLeavingDataGridViewTextBoxColumn
        '
        Me.DateofLeavingDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Leaving"
        DataGridViewCellStyle8.Format = "dd-MMM-yyyy"
        Me.DateofLeavingDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DateofLeavingDataGridViewTextBoxColumn.HeaderText = "Date_of_Leaving"
        Me.DateofLeavingDataGridViewTextBoxColumn.Name = "DateofLeavingDataGridViewTextBoxColumn"
        Me.DateofLeavingDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofLeavingDataGridViewTextBoxColumn.Width = 114
        '
        'SalaryStatusDataGridViewTextBoxColumn
        '
        Me.SalaryStatusDataGridViewTextBoxColumn.DataPropertyName = "Salary_Status"
        Me.SalaryStatusDataGridViewTextBoxColumn.HeaderText = "Salary_Status"
        Me.SalaryStatusDataGridViewTextBoxColumn.Name = "SalaryStatusDataGridViewTextBoxColumn"
        Me.SalaryStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryStatusDataGridViewTextBoxColumn.Width = 97
        '
        'PayrollDataBindingSource
        '
        Me.PayrollDataBindingSource.DataMember = "PayrollData"
        Me.PayrollDataBindingSource.DataSource = Me.DS_Payroll
        '
        'DS_Payroll
        '
        Me.DS_Payroll.DataSetName = "DS_Payroll"
        Me.DS_Payroll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_PaySlipFolderPath)
        Me.GroupBox1.Controls.Add(Me.Btn_GenereatePayslip)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label_PaySlipPathMessage)
        Me.GroupBox1.Controls.Add(Me.Button_PaySlip)
        Me.GroupBox1.Controls.Add(Me.Btn_BrowsePaySlipFolderPath)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 100)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PaySlip"
        '
        'Label_PaySlipFolderPath
        '
        Me.Label_PaySlipFolderPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label_PaySlipFolderPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PaySlipFolderPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_PaySlipFolderPath.Location = New System.Drawing.Point(196, 56)
        Me.Label_PaySlipFolderPath.Multiline = True
        Me.Label_PaySlipFolderPath.Name = "Label_PaySlipFolderPath"
        Me.Label_PaySlipFolderPath.ReadOnly = True
        Me.Label_PaySlipFolderPath.Size = New System.Drawing.Size(539, 38)
        Me.Label_PaySlipFolderPath.TabIndex = 72
        '
        'Btn_GenereatePayslip
        '
        Me.Btn_GenereatePayslip.Enabled = False
        Me.Btn_GenereatePayslip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_GenereatePayslip.Location = New System.Drawing.Point(151, 19)
        Me.Btn_GenereatePayslip.Name = "Btn_GenereatePayslip"
        Me.Btn_GenereatePayslip.Size = New System.Drawing.Size(176, 28)
        Me.Btn_GenereatePayslip.TabIndex = 72
        Me.Btn_GenereatePayslip.Text = "&Generate Payslip"
        Me.Btn_GenereatePayslip.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(530, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(205, 28)
        Me.ProgressBar1.TabIndex = 70
        Me.ProgressBar1.Visible = False
        '
        'Label_PaySlipPathMessage
        '
        Me.Label_PaySlipPathMessage.AutoSize = True
        Me.Label_PaySlipPathMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PaySlipPathMessage.Location = New System.Drawing.Point(67, 57)
        Me.Label_PaySlipPathMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_PaySlipPathMessage.Name = "Label_PaySlipPathMessage"
        Me.Label_PaySlipPathMessage.Size = New System.Drawing.Size(115, 16)
        Me.Label_PaySlipPathMessage.TabIndex = 69
        Me.Label_PaySlipPathMessage.Text = "PaySlip Location :"
        '
        'Button_PaySlip
        '
        Me.Button_PaySlip.Enabled = False
        Me.Button_PaySlip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PaySlip.Location = New System.Drawing.Point(333, 19)
        Me.Button_PaySlip.Name = "Button_PaySlip"
        Me.Button_PaySlip.Size = New System.Drawing.Size(176, 28)
        Me.Button_PaySlip.TabIndex = 70
        Me.Button_PaySlip.Text = "&Send PaySlip Email"
        Me.Button_PaySlip.UseVisualStyleBackColor = True
        '
        'Btn_BrowsePaySlipFolderPath
        '
        Me.Btn_BrowsePaySlipFolderPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BrowsePaySlipFolderPath.Location = New System.Drawing.Point(70, 19)
        Me.Btn_BrowsePaySlipFolderPath.Name = "Btn_BrowsePaySlipFolderPath"
        Me.Btn_BrowsePaySlipFolderPath.Size = New System.Drawing.Size(75, 28)
        Me.Btn_BrowsePaySlipFolderPath.TabIndex = 69
        Me.Btn_BrowsePaySlipFolderPath.Text = "&Browse"
        Me.Btn_BrowsePaySlipFolderPath.UseVisualStyleBackColor = True
        '
        'PayrollDataTableAdapter
        '
        Me.PayrollDataTableAdapter.ClearBeforeFill = True
        '
        'Btn_Export2XL
        '
        Me.Btn_Export2XL.FlatAppearance.BorderSize = 0
        Me.Btn_Export2XL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Btn_Export2XL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Export2XL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Export2XL.ForeColor = System.Drawing.Color.Black
        Me.Btn_Export2XL.Location = New System.Drawing.Point(949, 648)
        Me.Btn_Export2XL.Name = "Btn_Export2XL"
        Me.Btn_Export2XL.Size = New System.Drawing.Size(119, 23)
        Me.Btn_Export2XL.TabIndex = 70
        Me.Btn_Export2XL.Text = "Export To Excel"
        Me.Btn_Export2XL.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(824, 648)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(119, 23)
        Me.ProgressBar2.TabIndex = 71
        Me.ProgressBar2.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label_RowsCount)
        Me.GroupBox4.Location = New System.Drawing.Point(887, 155)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 45)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(10, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Count :"
        '
        'Label_RowsCount
        '
        Me.Label_RowsCount.AutoSize = True
        Me.Label_RowsCount.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RowsCount.ForeColor = System.Drawing.Color.Blue
        Me.Label_RowsCount.Location = New System.Drawing.Point(90, 16)
        Me.Label_RowsCount.Name = "Label_RowsCount"
        Me.Label_RowsCount.Size = New System.Drawing.Size(21, 22)
        Me.Label_RowsCount.TabIndex = 8
        Me.Label_RowsCount.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBoxEmpName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboBoxCompany)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBoxMonth)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1039, 57)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'ComboBoxEmpName
        '
        Me.ComboBoxEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEmpName.FormattingEnabled = True
        Me.ComboBoxEmpName.Location = New System.Drawing.Point(721, 22)
        Me.ComboBoxEmpName.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEmpName.Name = "ComboBoxEmpName"
        Me.ComboBoxEmpName.Size = New System.Drawing.Size(247, 26)
        Me.ComboBoxEmpName.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(587, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Employee Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Company :"
        '
        'ComboBoxCompany
        '
        Me.ComboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCompany.FormattingEnabled = True
        Me.ComboBoxCompany.Location = New System.Drawing.Point(393, 22)
        Me.ComboBoxCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCompany.Name = "ComboBoxCompany"
        Me.ComboBoxCompany.Size = New System.Drawing.Size(177, 26)
        Me.ComboBoxCompany.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Month :"
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Items.AddRange(New Object() {"November-2017", "December-2017", "January-2018", "Feb-2018", "Mar-2018", "Apr-2018", "May-2018", "Jun-2018", "Jul-2018", "Aug-2018", "Sep-2018", "Oct-2018", "Nov-2018", "Dec-2018", "Jan-2019", "Feb-2019", "Mar-2019"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(137, 22)
        Me.ComboBoxMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(160, 26)
        Me.ComboBoxMonth.TabIndex = 71
        '
        'FormPayrollData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1091, 677)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Btn_Export2XL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label38)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPayrollData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormPayrollData"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label38 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_PaySlip As Button
    Friend WithEvents Btn_BrowsePaySlipFolderPath As Button
    Friend WithEvents Label_PaySlipPathMessage As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DS_Payroll As DS_Payroll
    Friend WithEvents PayrollDataBindingSource As BindingSource
    Friend WithEvents PayrollDataTableAdapter As DS_PayrollTableAdapters.PayrollDataTableAdapter
    Friend WithEvents Btn_GenereatePayslip As Button
    Friend WithEvents Btn_Export2XL As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label_PaySlipFolderPath As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_RowsCount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBoxEmpName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCompany As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents SNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UANNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StandardMonthlyCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STDDaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DaysPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicForPFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployerPFContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommunicationAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApparelAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResearchAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseRentAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveTravelAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MealAllowanceSodexoCouponsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConveyanceAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaptopAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BonusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArrearsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VariablePayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeePFDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployeeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDSDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SodexoCouponsDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherDeductionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDeductionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAllowancesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryInWordsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaySlipStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofLeavingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
