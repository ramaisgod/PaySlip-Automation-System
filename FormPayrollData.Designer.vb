<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayrollData
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_EmpName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_CompanyName = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_RowsCount = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PayrollMasterDataSet = New WindowsApp1.PayrollMasterDataSet()
        Me.MasterPayrollDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterPayrollDataTableAdapter = New WindowsApp1.PayrollMasterDataSetTableAdapters.MasterPayrollDataTableAdapter()
        Me.SNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOJDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UANNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnualCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PerformanceBonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenureBonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCTCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseRentAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFEmployerContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployerContributionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunicationAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApparelAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResearchAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveTravelAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConveyanceAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaptopAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicForPFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRAPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFEmployerPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFEmployeePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommunicationPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApparelPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResearchPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConveyancePercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaptopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofLeavingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Btn_Export2XL = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollMasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterPayrollDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(442, 19)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(250, 26)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "Employee Payroll Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.CB_EmpName)
        Me.GroupBox2.Controls.Add(Me.Btn_Export2XL)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CB_CompanyName)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1079, 57)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'CB_EmpName
        '
        Me.CB_EmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_EmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_EmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_EmpName.FormattingEnabled = True
        Me.CB_EmpName.Location = New System.Drawing.Point(457, 22)
        Me.CB_EmpName.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_EmpName.Name = "CB_EmpName"
        Me.CB_EmpName.Size = New System.Drawing.Size(247, 26)
        Me.CB_EmpName.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 25)
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
        Me.Label1.Location = New System.Drawing.Point(41, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Company :"
        '
        'CB_CompanyName
        '
        Me.CB_CompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CB_CompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_CompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CB_CompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_CompanyName.FormattingEnabled = True
        Me.CB_CompanyName.Location = New System.Drawing.Point(129, 22)
        Me.CB_CompanyName.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_CompanyName.Name = "CB_CompanyName"
        Me.CB_CompanyName.Size = New System.Drawing.Size(177, 26)
        Me.CB_CompanyName.TabIndex = 69
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label_RowsCount)
        Me.GroupBox4.Location = New System.Drawing.Point(933, 620)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(181, 45)
        Me.GroupBox4.TabIndex = 76
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNoDataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.CompanyDataGridViewTextBoxColumn, Me.DesignationDataGridViewTextBoxColumn, Me.DOJDataGridViewTextBoxColumn, Me.PFNoDataGridViewTextBoxColumn, Me.UANNoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AnnualCTCDataGridViewTextBoxColumn, Me.MonthlyCTCDataGridViewTextBoxColumn, Me.PerformanceBonusDataGridViewTextBoxColumn, Me.TenureBonusDataGridViewTextBoxColumn, Me.TotalCTCDataGridViewTextBoxColumn, Me.BasicDataGridViewTextBoxColumn, Me.HouseRentAllowanceDataGridViewTextBoxColumn, Me.PFEmployerContributionDataGridViewTextBoxColumn, Me.ESICEmployerContributionDataGridViewTextBoxColumn, Me.TransportAllowanceDataGridViewTextBoxColumn, Me.CommunicationAllowanceDataGridViewTextBoxColumn, Me.ApparelAllowanceDataGridViewTextBoxColumn, Me.ResearchAllowanceDataGridViewTextBoxColumn, Me.MedicalAllowanceDataGridViewTextBoxColumn, Me.LeaveTravelAllowanceDataGridViewTextBoxColumn, Me.MealAllowanceSodexoCouponsDataGridViewTextBoxColumn, Me.ConveyanceAllowanceDataGridViewTextBoxColumn, Me.SpecialAllowanceDataGridViewTextBoxColumn, Me.LaptopAllowanceDataGridViewTextBoxColumn, Me.GrossSalaryDataGridViewTextBoxColumn, Me.PFEmployeeDeductionDataGridViewTextBoxColumn, Me.ESICEmployeeDeductionDataGridViewTextBoxColumn, Me.SodexoCouponsDeductionDataGridViewTextBoxColumn, Me.NetSalaryDataGridViewTextBoxColumn, Me.BasicPercentageDataGridViewTextBoxColumn, Me.BasicForPFDataGridViewTextBoxColumn, Me.HRAPercentageDataGridViewTextBoxColumn, Me.PFEmployerPercentageDataGridViewTextBoxColumn, Me.PFEmployeePercentageDataGridViewTextBoxColumn, Me.ESICEmployeePercentageDataGridViewTextBoxColumn, Me.ESICEmployerPercentageDataGridViewTextBoxColumn, Me.TransportDataGridViewTextBoxColumn, Me.CommunicationPercentageDataGridViewTextBoxColumn, Me.ApparelPercentageDataGridViewTextBoxColumn, Me.ResearchPercentageDataGridViewTextBoxColumn, Me.MedicalDataGridViewTextBoxColumn, Me.LeaveTravelPercentageDataGridViewTextBoxColumn, Me.ConveyancePercentageDataGridViewTextBoxColumn, Me.LaptopDataGridViewTextBoxColumn, Me.DateofLeavingDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MasterPayrollDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1079, 484)
        Me.DataGridView1.TabIndex = 78
        '
        'PayrollMasterDataSet
        '
        Me.PayrollMasterDataSet.DataSetName = "PayrollMasterDataSet"
        Me.PayrollMasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasterPayrollDataBindingSource
        '
        Me.MasterPayrollDataBindingSource.DataMember = "MasterPayrollData"
        Me.MasterPayrollDataBindingSource.DataSource = Me.PayrollMasterDataSet
        '
        'MasterPayrollDataTableAdapter
        '
        Me.MasterPayrollDataTableAdapter.ClearBeforeFill = True
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
        DataGridViewCellStyle5.Format = "dd-MMM-yyyy"
        Me.DOJDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
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
        'AnnualCTCDataGridViewTextBoxColumn
        '
        Me.AnnualCTCDataGridViewTextBoxColumn.DataPropertyName = "Annual_CTC"
        Me.AnnualCTCDataGridViewTextBoxColumn.HeaderText = "Annual_CTC"
        Me.AnnualCTCDataGridViewTextBoxColumn.Name = "AnnualCTCDataGridViewTextBoxColumn"
        Me.AnnualCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnnualCTCDataGridViewTextBoxColumn.Width = 92
        '
        'MonthlyCTCDataGridViewTextBoxColumn
        '
        Me.MonthlyCTCDataGridViewTextBoxColumn.DataPropertyName = "Monthly_CTC"
        Me.MonthlyCTCDataGridViewTextBoxColumn.HeaderText = "Monthly_CTC"
        Me.MonthlyCTCDataGridViewTextBoxColumn.Name = "MonthlyCTCDataGridViewTextBoxColumn"
        Me.MonthlyCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonthlyCTCDataGridViewTextBoxColumn.Width = 96
        '
        'PerformanceBonusDataGridViewTextBoxColumn
        '
        Me.PerformanceBonusDataGridViewTextBoxColumn.DataPropertyName = "Performance_Bonus"
        Me.PerformanceBonusDataGridViewTextBoxColumn.HeaderText = "Performance_Bonus"
        Me.PerformanceBonusDataGridViewTextBoxColumn.Name = "PerformanceBonusDataGridViewTextBoxColumn"
        Me.PerformanceBonusDataGridViewTextBoxColumn.ReadOnly = True
        Me.PerformanceBonusDataGridViewTextBoxColumn.Width = 128
        '
        'TenureBonusDataGridViewTextBoxColumn
        '
        Me.TenureBonusDataGridViewTextBoxColumn.DataPropertyName = "Tenure_Bonus"
        Me.TenureBonusDataGridViewTextBoxColumn.HeaderText = "Tenure_Bonus"
        Me.TenureBonusDataGridViewTextBoxColumn.Name = "TenureBonusDataGridViewTextBoxColumn"
        Me.TenureBonusDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenureBonusDataGridViewTextBoxColumn.Width = 102
        '
        'TotalCTCDataGridViewTextBoxColumn
        '
        Me.TotalCTCDataGridViewTextBoxColumn.DataPropertyName = "Total_CTC"
        Me.TotalCTCDataGridViewTextBoxColumn.HeaderText = "Total_CTC"
        Me.TotalCTCDataGridViewTextBoxColumn.Name = "TotalCTCDataGridViewTextBoxColumn"
        Me.TotalCTCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalCTCDataGridViewTextBoxColumn.Width = 83
        '
        'BasicDataGridViewTextBoxColumn
        '
        Me.BasicDataGridViewTextBoxColumn.DataPropertyName = "Basic"
        Me.BasicDataGridViewTextBoxColumn.HeaderText = "Basic"
        Me.BasicDataGridViewTextBoxColumn.Name = "BasicDataGridViewTextBoxColumn"
        Me.BasicDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasicDataGridViewTextBoxColumn.Width = 58
        '
        'HouseRentAllowanceDataGridViewTextBoxColumn
        '
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.DataPropertyName = "House_Rent_Allowance"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.HeaderText = "House_Rent_Allowance"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.Name = "HouseRentAllowanceDataGridViewTextBoxColumn"
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.HouseRentAllowanceDataGridViewTextBoxColumn.Width = 147
        '
        'PFEmployerContributionDataGridViewTextBoxColumn
        '
        Me.PFEmployerContributionDataGridViewTextBoxColumn.DataPropertyName = "PF_Employer_Contribution"
        Me.PFEmployerContributionDataGridViewTextBoxColumn.HeaderText = "PF_Employer_Contribution"
        Me.PFEmployerContributionDataGridViewTextBoxColumn.Name = "PFEmployerContributionDataGridViewTextBoxColumn"
        Me.PFEmployerContributionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFEmployerContributionDataGridViewTextBoxColumn.Width = 156
        '
        'ESICEmployerContributionDataGridViewTextBoxColumn
        '
        Me.ESICEmployerContributionDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employer_Contribution"
        Me.ESICEmployerContributionDataGridViewTextBoxColumn.HeaderText = "ESIC_Employer_Contribution"
        Me.ESICEmployerContributionDataGridViewTextBoxColumn.Name = "ESICEmployerContributionDataGridViewTextBoxColumn"
        Me.ESICEmployerContributionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployerContributionDataGridViewTextBoxColumn.Width = 167
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
        'GrossSalaryDataGridViewTextBoxColumn
        '
        Me.GrossSalaryDataGridViewTextBoxColumn.DataPropertyName = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.HeaderText = "Gross_Salary"
        Me.GrossSalaryDataGridViewTextBoxColumn.Name = "GrossSalaryDataGridViewTextBoxColumn"
        Me.GrossSalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrossSalaryDataGridViewTextBoxColumn.Width = 94
        '
        'PFEmployeeDeductionDataGridViewTextBoxColumn
        '
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn.DataPropertyName = "PF_Employee_Deduction"
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn.HeaderText = "PF_Employee_Deduction"
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn.Name = "PFEmployeeDeductionDataGridViewTextBoxColumn"
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFEmployeeDeductionDataGridViewTextBoxColumn.Width = 152
        '
        'ESICEmployeeDeductionDataGridViewTextBoxColumn
        '
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employee_Deduction"
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn.HeaderText = "ESIC_Employee_Deduction"
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn.Name = "ESICEmployeeDeductionDataGridViewTextBoxColumn"
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployeeDeductionDataGridViewTextBoxColumn.Width = 163
        '
        'SodexoCouponsDeductionDataGridViewTextBoxColumn
        '
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.DataPropertyName = "Sodexo_Coupons_Deduction"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.HeaderText = "Sodexo_Coupons_Deduction"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.Name = "SodexoCouponsDeductionDataGridViewTextBoxColumn"
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SodexoCouponsDeductionDataGridViewTextBoxColumn.Width = 171
        '
        'NetSalaryDataGridViewTextBoxColumn
        '
        Me.NetSalaryDataGridViewTextBoxColumn.DataPropertyName = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.HeaderText = "Net_Salary"
        Me.NetSalaryDataGridViewTextBoxColumn.Name = "NetSalaryDataGridViewTextBoxColumn"
        Me.NetSalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.NetSalaryDataGridViewTextBoxColumn.Width = 84
        '
        'BasicPercentageDataGridViewTextBoxColumn
        '
        Me.BasicPercentageDataGridViewTextBoxColumn.DataPropertyName = "Basic_Percentage"
        Me.BasicPercentageDataGridViewTextBoxColumn.HeaderText = "Basic_Percentage"
        Me.BasicPercentageDataGridViewTextBoxColumn.Name = "BasicPercentageDataGridViewTextBoxColumn"
        Me.BasicPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasicPercentageDataGridViewTextBoxColumn.Width = 119
        '
        'BasicForPFDataGridViewTextBoxColumn
        '
        Me.BasicForPFDataGridViewTextBoxColumn.DataPropertyName = "Basic_For_PF"
        Me.BasicForPFDataGridViewTextBoxColumn.HeaderText = "Basic_For_PF"
        Me.BasicForPFDataGridViewTextBoxColumn.Name = "BasicForPFDataGridViewTextBoxColumn"
        Me.BasicForPFDataGridViewTextBoxColumn.ReadOnly = True
        Me.BasicForPFDataGridViewTextBoxColumn.Width = 98
        '
        'HRAPercentageDataGridViewTextBoxColumn
        '
        Me.HRAPercentageDataGridViewTextBoxColumn.DataPropertyName = "HRA_Percentage"
        Me.HRAPercentageDataGridViewTextBoxColumn.HeaderText = "HRA_Percentage"
        Me.HRAPercentageDataGridViewTextBoxColumn.Name = "HRAPercentageDataGridViewTextBoxColumn"
        Me.HRAPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.HRAPercentageDataGridViewTextBoxColumn.Width = 116
        '
        'PFEmployerPercentageDataGridViewTextBoxColumn
        '
        Me.PFEmployerPercentageDataGridViewTextBoxColumn.DataPropertyName = "PF_Employer_Percentage"
        Me.PFEmployerPercentageDataGridViewTextBoxColumn.HeaderText = "PF_Employer_Percentage"
        Me.PFEmployerPercentageDataGridViewTextBoxColumn.Name = "PFEmployerPercentageDataGridViewTextBoxColumn"
        Me.PFEmployerPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFEmployerPercentageDataGridViewTextBoxColumn.Width = 155
        '
        'PFEmployeePercentageDataGridViewTextBoxColumn
        '
        Me.PFEmployeePercentageDataGridViewTextBoxColumn.DataPropertyName = "PF_Employee_Percentage"
        Me.PFEmployeePercentageDataGridViewTextBoxColumn.HeaderText = "PF_Employee_Percentage"
        Me.PFEmployeePercentageDataGridViewTextBoxColumn.Name = "PFEmployeePercentageDataGridViewTextBoxColumn"
        Me.PFEmployeePercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.PFEmployeePercentageDataGridViewTextBoxColumn.Width = 158
        '
        'ESICEmployeePercentageDataGridViewTextBoxColumn
        '
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employee_Percentage"
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn.HeaderText = "ESIC_Employee_Percentage"
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn.Name = "ESICEmployeePercentageDataGridViewTextBoxColumn"
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployeePercentageDataGridViewTextBoxColumn.Width = 169
        '
        'ESICEmployerPercentageDataGridViewTextBoxColumn
        '
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn.DataPropertyName = "ESIC_Employer_Percentage"
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn.HeaderText = "ESIC_Employer_Percentage"
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn.Name = "ESICEmployerPercentageDataGridViewTextBoxColumn"
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ESICEmployerPercentageDataGridViewTextBoxColumn.Width = 166
        '
        'TransportDataGridViewTextBoxColumn
        '
        Me.TransportDataGridViewTextBoxColumn.DataPropertyName = "Transport"
        Me.TransportDataGridViewTextBoxColumn.HeaderText = "Transport"
        Me.TransportDataGridViewTextBoxColumn.Name = "TransportDataGridViewTextBoxColumn"
        Me.TransportDataGridViewTextBoxColumn.ReadOnly = True
        Me.TransportDataGridViewTextBoxColumn.Width = 77
        '
        'CommunicationPercentageDataGridViewTextBoxColumn
        '
        Me.CommunicationPercentageDataGridViewTextBoxColumn.DataPropertyName = "Communication_Percentage"
        Me.CommunicationPercentageDataGridViewTextBoxColumn.HeaderText = "Communication_Percentage"
        Me.CommunicationPercentageDataGridViewTextBoxColumn.Name = "CommunicationPercentageDataGridViewTextBoxColumn"
        Me.CommunicationPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommunicationPercentageDataGridViewTextBoxColumn.Width = 165
        '
        'ApparelPercentageDataGridViewTextBoxColumn
        '
        Me.ApparelPercentageDataGridViewTextBoxColumn.DataPropertyName = "Apparel_Percentage"
        Me.ApparelPercentageDataGridViewTextBoxColumn.HeaderText = "Apparel_Percentage"
        Me.ApparelPercentageDataGridViewTextBoxColumn.Name = "ApparelPercentageDataGridViewTextBoxColumn"
        Me.ApparelPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApparelPercentageDataGridViewTextBoxColumn.Width = 129
        '
        'ResearchPercentageDataGridViewTextBoxColumn
        '
        Me.ResearchPercentageDataGridViewTextBoxColumn.DataPropertyName = "Research_Percentage"
        Me.ResearchPercentageDataGridViewTextBoxColumn.HeaderText = "Research_Percentage"
        Me.ResearchPercentageDataGridViewTextBoxColumn.Name = "ResearchPercentageDataGridViewTextBoxColumn"
        Me.ResearchPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ResearchPercentageDataGridViewTextBoxColumn.Width = 139
        '
        'MedicalDataGridViewTextBoxColumn
        '
        Me.MedicalDataGridViewTextBoxColumn.DataPropertyName = "Medical"
        Me.MedicalDataGridViewTextBoxColumn.HeaderText = "Medical"
        Me.MedicalDataGridViewTextBoxColumn.Name = "MedicalDataGridViewTextBoxColumn"
        Me.MedicalDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicalDataGridViewTextBoxColumn.Width = 69
        '
        'LeaveTravelPercentageDataGridViewTextBoxColumn
        '
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn.DataPropertyName = "Leave_Travel_Percentage"
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn.HeaderText = "Leave_Travel_Percentage"
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn.Name = "LeaveTravelPercentageDataGridViewTextBoxColumn"
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.LeaveTravelPercentageDataGridViewTextBoxColumn.Width = 159
        '
        'ConveyancePercentageDataGridViewTextBoxColumn
        '
        Me.ConveyancePercentageDataGridViewTextBoxColumn.DataPropertyName = "Conveyance_Percentage"
        Me.ConveyancePercentageDataGridViewTextBoxColumn.HeaderText = "Conveyance_Percentage"
        Me.ConveyancePercentageDataGridViewTextBoxColumn.Name = "ConveyancePercentageDataGridViewTextBoxColumn"
        Me.ConveyancePercentageDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConveyancePercentageDataGridViewTextBoxColumn.Width = 153
        '
        'LaptopDataGridViewTextBoxColumn
        '
        Me.LaptopDataGridViewTextBoxColumn.DataPropertyName = "Laptop"
        Me.LaptopDataGridViewTextBoxColumn.HeaderText = "Laptop"
        Me.LaptopDataGridViewTextBoxColumn.Name = "LaptopDataGridViewTextBoxColumn"
        Me.LaptopDataGridViewTextBoxColumn.ReadOnly = True
        Me.LaptopDataGridViewTextBoxColumn.Width = 65
        '
        'DateofLeavingDataGridViewTextBoxColumn
        '
        Me.DateofLeavingDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Leaving"
        DataGridViewCellStyle6.Format = "dd-MMM-yyyy"
        Me.DateofLeavingDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DateofLeavingDataGridViewTextBoxColumn.HeaderText = "Date_of_Leaving"
        Me.DateofLeavingDataGridViewTextBoxColumn.Name = "DateofLeavingDataGridViewTextBoxColumn"
        Me.DateofLeavingDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofLeavingDataGridViewTextBoxColumn.Width = 114
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 62
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(829, 22)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(119, 23)
        Me.ProgressBar2.TabIndex = 80
        Me.ProgressBar2.Visible = False
        '
        'Btn_Export2XL
        '
        Me.Btn_Export2XL.FlatAppearance.BorderSize = 0
        Me.Btn_Export2XL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Btn_Export2XL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Export2XL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Export2XL.ForeColor = System.Drawing.Color.Black
        Me.Btn_Export2XL.Location = New System.Drawing.Point(954, 22)
        Me.Btn_Export2XL.Name = "Btn_Export2XL"
        Me.Btn_Export2XL.Size = New System.Drawing.Size(119, 23)
        Me.Btn_Export2XL.TabIndex = 79
        Me.Btn_Export2XL.Text = "Export To Excel"
        Me.Btn_Export2XL.UseVisualStyleBackColor = True
        '
        'FormPayrollData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1135, 677)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label38)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPayrollData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormPayrollData"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollMasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterPayrollDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CB_EmpName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_CompanyName As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_RowsCount As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PayrollMasterDataSet As PayrollMasterDataSet
    Friend WithEvents MasterPayrollDataBindingSource As BindingSource
    Friend WithEvents MasterPayrollDataTableAdapter As PayrollMasterDataSetTableAdapters.MasterPayrollDataTableAdapter
    Friend WithEvents SNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesignationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UANNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnnualCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PerformanceBonusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenureBonusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCTCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseRentAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFEmployerContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployerContributionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommunicationAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApparelAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResearchAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveTravelAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MealAllowanceSodexoCouponsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConveyanceAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaptopAllowanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFEmployeeDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployeeDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SodexoCouponsDeductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicForPFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HRAPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFEmployerPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PFEmployeePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployeePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESICEmployerPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransportDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommunicationPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApparelPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResearchPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeaveTravelPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConveyancePercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaptopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofLeavingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Btn_Export2XL As Button
End Class
