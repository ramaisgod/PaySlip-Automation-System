<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUploadData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.Btn_BrowsePaySlipFolderPath = New System.Windows.Forms.Button()
        Me.Btn_UploadData = New System.Windows.Forms.Button()
        Me.Btn_Format = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label_PaySlipPathMessage = New System.Windows.Forms.Label()
        Me.Label_RowsCount = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label_SelectedFilePath = New System.Windows.Forms.Label()
        Me.PayrollDataTableAdapter = New WindowsApp1.DS_PayrollTableAdapters.PayrollDataTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(44, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(906, 429)
        Me.DataGridView1.TabIndex = 0
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
        'Btn_BrowsePaySlipFolderPath
        '
        Me.Btn_BrowsePaySlipFolderPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BrowsePaySlipFolderPath.Location = New System.Drawing.Point(6, 18)
        Me.Btn_BrowsePaySlipFolderPath.Name = "Btn_BrowsePaySlipFolderPath"
        Me.Btn_BrowsePaySlipFolderPath.Size = New System.Drawing.Size(95, 35)
        Me.Btn_BrowsePaySlipFolderPath.TabIndex = 1
        Me.Btn_BrowsePaySlipFolderPath.Text = "Browse"
        Me.Btn_BrowsePaySlipFolderPath.UseVisualStyleBackColor = True
        '
        'Btn_UploadData
        '
        Me.Btn_UploadData.Enabled = False
        Me.Btn_UploadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UploadData.Location = New System.Drawing.Point(123, 18)
        Me.Btn_UploadData.Name = "Btn_UploadData"
        Me.Btn_UploadData.Size = New System.Drawing.Size(95, 35)
        Me.Btn_UploadData.TabIndex = 2
        Me.Btn_UploadData.Text = "Import"
        Me.Btn_UploadData.UseVisualStyleBackColor = True
        '
        'Btn_Format
        '
        Me.Btn_Format.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Format.Location = New System.Drawing.Point(755, 18)
        Me.Btn_Format.Name = "Btn_Format"
        Me.Btn_Format.Size = New System.Drawing.Size(145, 35)
        Me.Btn_Format.TabIndex = 3
        Me.Btn_Format.Text = "Download Format"
        Me.Btn_Format.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(428, 9)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(139, 26)
        Me.Label38.TabIndex = 62
        Me.Label38.Text = "Import Data"
        '
        'Label_PaySlipPathMessage
        '
        Me.Label_PaySlipPathMessage.AutoSize = True
        Me.Label_PaySlipPathMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PaySlipPathMessage.Location = New System.Drawing.Point(7, 59)
        Me.Label_PaySlipPathMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_PaySlipPathMessage.Name = "Label_PaySlipPathMessage"
        Me.Label_PaySlipPathMessage.Size = New System.Drawing.Size(66, 16)
        Me.Label_PaySlipPathMessage.TabIndex = 72
        Me.Label_PaySlipPathMessage.Text = "File Path :"
        '
        'Label_RowsCount
        '
        Me.Label_RowsCount.AutoSize = True
        Me.Label_RowsCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RowsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_RowsCount.Location = New System.Drawing.Point(785, 568)
        Me.Label_RowsCount.Name = "Label_RowsCount"
        Me.Label_RowsCount.Size = New System.Drawing.Size(116, 18)
        Me.Label_RowsCount.TabIndex = 73
        Me.Label_RowsCount.Text = "Rows Count = 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_SelectedFilePath)
        Me.GroupBox1.Controls.Add(Me.Btn_UploadData)
        Me.GroupBox1.Controls.Add(Me.Btn_BrowsePaySlipFolderPath)
        Me.GroupBox1.Controls.Add(Me.Label_PaySlipPathMessage)
        Me.GroupBox1.Controls.Add(Me.Btn_Format)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(906, 82)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'Label_SelectedFilePath
        '
        Me.Label_SelectedFilePath.AutoSize = True
        Me.Label_SelectedFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SelectedFilePath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_SelectedFilePath.Location = New System.Drawing.Point(73, 59)
        Me.Label_SelectedFilePath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_SelectedFilePath.Name = "Label_SelectedFilePath"
        Me.Label_SelectedFilePath.Size = New System.Drawing.Size(0, 16)
        Me.Label_SelectedFilePath.TabIndex = 73
        '
        'PayrollDataTableAdapter
        '
        Me.PayrollDataTableAdapter.ClearBeforeFill = True
        '
        'FormUploadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(975, 607)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_RowsCount)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUploadData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormUploadData"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_BrowsePaySlipFolderPath As Button
    Friend WithEvents Btn_UploadData As Button
    Friend WithEvents Btn_Format As Button
    Friend WithEvents Label38 As Label
    Friend WithEvents Label_PaySlipPathMessage As Label
    Friend WithEvents Label_RowsCount As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label_SelectedFilePath As Label
    Friend WithEvents GrossMonthlyCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossCTCThisMonthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DS_Payroll As DS_Payroll
    Friend WithEvents PayrollDataBindingSource As BindingSource
    Friend WithEvents PayrollDataTableAdapter As DS_PayrollTableAdapters.PayrollDataTableAdapter
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
