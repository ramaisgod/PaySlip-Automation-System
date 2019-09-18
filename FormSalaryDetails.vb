Imports System.Data
Imports System.Data.OleDb
Public Class FormSalaryDetails

    Dim OLEDBConn As New OleDbConnection
    Dim OLEDBComm As New OleDbCommand
    Dim ConStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            Dim dr As OleDbDataReader
            Dim cmd As String

            '----------------  add Company Name in Combobox-----------
            cmd = "Select Distinct Company from MasterPayrollData"
            OLEDBComm.CommandText = cmd
            OLEDBConn.Open()
            dr = OLEDBComm.ExecuteReader
            CB_CompanyName.Items.Clear()
            If dr.HasRows = True Then
                While dr.Read
                    CB_CompanyName.Items.Add(dr("Company"))
                End While
            Else
            End If
            dr.Close()
            OLEDBConn.Dispose()

            CB_SalaryMonth.SelectedIndex = Date.Now.Month - 1
            CB_SalaryYear.Text = Date.Now.Year
            CB_CompanyName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()

        End Try
    End Sub

    Private Sub CB_EmployeeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_EmployeeName.SelectedIndexChanged
        '------------ Clear Text Boxes ----------------------
        txt_Designation.Text = ""
        dtp_DOJ.Text = #1/1/1900#
        dtp_DOL.Text = #1/1/1900#
        CB_EmpStatus.Text = ""
        txt_PF.Text = ""
        txt_UAN.Text = ""
        txt_Email.Text = ""
        txt_StandardMonthlyCTC.Text = ""
        txt_DaysPay.Text = ""
        'txt_STDDays.Text = ""
        txt_GrossCTC.Text = ""
        txt_BasicForPF.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_PF_Employer_Earnings.Text = ""
        txt_ESIC_Employer_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_Arrears.Text = ""
        txt_VariablePay.Text = ""
        txt_Bonus.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_TDS_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_Others_Deductions.Text = ""
        txt_Total_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_TotalAllowances.Text = ""
        'txt_Total_Earnings.Text=""
        txt_GrossSalary.Text = ""
        '-----------------------------------------------------
        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim dr As OleDbDataReader
        Dim cmd As String

        '----------------  add EmployeeID in Combobox-----------
        cmd = "Select Distinct Emp_ID from MasterPayrollData Where Employee_Name = '" & CB_EmployeeName.Text & "'"
        OLEDBComm.CommandText = cmd
        OLEDBConn.Open()
        dr = OLEDBComm.ExecuteReader
        CB_EmployeeID.Text = ""
        'PaymentMonth.Text = ""
        CB_EmployeeID.Items.Clear()
        If dr.HasRows = True Then
            While dr.Read
                CB_EmployeeID.Items.Add(dr("Emp_ID"))
            End While
        Else
        End If
        dr.Close()

        OLEDBConn.Dispose()

    End Sub

    Private Sub CB_EmployeeID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_EmployeeID.SelectedIndexChanged

        '------------ Clear Text Boxes ----------------------
        txt_Designation.Text = ""
        dtp_DOJ.Text = #1/1/1900#
        dtp_DOL.Text = #1/1/1900#
        CB_EmpStatus.Text = ""
        txt_PF.Text = ""
        txt_UAN.Text = ""
        txt_Email.Text = ""
        txt_StandardMonthlyCTC.Text = ""
        txt_DaysPay.Text = ""
        'txt_STDDays.Text = ""
        txt_GrossCTC.Text = ""
        txt_BasicForPF.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_PF_Employer_Earnings.Text = ""
        txt_ESIC_Employer_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_Arrears.Text = ""
        txt_VariablePay.Text = ""
        txt_Bonus.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_TDS_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_Others_Deductions.Text = ""
        txt_Total_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_TotalAllowances.Text = ""
        'txt_Total_Earnings.Text=""
        txt_GrossSalary.Text = ""
        Amount_In_Words.Text = ""

        '----------------------------------------------------
        On Error Resume Next

        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
            Dim cmd As String
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            cmd = "Select * from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
            OLEDBConn.Open()
            da = New OleDbDataAdapter(cmd, ConStr)
            da.Fill(dt)
            txt_Designation.DataBindings.Add("Text", dt, "Designation")
            dtp_DOJ.DataBindings.Add("Value", dt, "DOJ")
            dtp_DOL.DataBindings.Add("Value", dt, "Date_of_Leaving")
            CB_EmpStatus.DataBindings.Add("Text", dt, "Status")
            txt_PF.DataBindings.Add("Text", dt, "PF_No")
            txt_UAN.DataBindings.Add("Text", dt, "UAN_No")
            txt_Email.DataBindings.Add("Text", dt, "E_mail")
            txt_StandardMonthlyCTC.DataBindings.Add("Text", dt, "Monthly_CTC")
            'txt_STDDays.DataBindings.Add("Text", dt, "STD_Days")
            'txt_DaysPay.DataBindings.Add("Text", dt, "Days_Pay")
            'txt_GrossCTC.DataBindings.Add("Text", dt, "Gross_CTC")
            'txt_BasicForPF.DataBindings.Add("Text", dt, "Basic_For_PF")
            'txt_BasicSalary.DataBindings.Add("Text", dt, "Basic")
            'txt_HRA_Earnings.DataBindings.Add("Text", dt, "House_Rent_Allowance")
            'txt_Special.DataBindings.Add("Text", dt, "Special_Allowance")
            'txt_Transport_Earnings.DataBindings.Add("Text", dt, "Transport_Allowance")
            'txt_Medical_Earnings.DataBindings.Add("Text", dt, "Medical_Allowance")
            'txt_Conveyance_Earnings.DataBindings.Add("Text", dt, "Conveyance_Allowance")
            'txt_Communication_Earnings.DataBindings.Add("Text", dt, "Communication_Allowance")
            'txt_PF_Employer_Earnings.DataBindings.Add("Text", dt, "Employer_PF_Contribution")
            'txt_ESIC_Employer_Earnings.DataBindings.Add("Text", dt, "ESIC_Employer")
            'txt_Apparel_Earnings.DataBindings.Add("Text", dt, "Apparel_Allowance")
            'txt_LeaveTravel_Earnings.DataBindings.Add("Text", dt, "Leave_Travel_Allowance")
            'txt_Laptop_Earnings.DataBindings.Add("Text", dt, "Laptop_Allowance")
            'txt_Research_Earnings.DataBindings.Add("Text", dt, "Research_Allowance")
            'txt_Meal_Sodexo_Earnings.DataBindings.Add("Text", dt, "Meal_Allowance_Sodexo_Coupons")
            'txt_Arrears.DataBindings.Add("Text", dt, "Arrears")
            'txt_VariablePay.DataBindings.Add("Text", dt, "Variable_Pay")
            'txt_Bonus.DataBindings.Add("Text", dt, "Bonus")
            'txt_PF_Employee_Deductions.DataBindings.Add("Text", dt, "Employee_PF_Deduction")
            'txt_TDS_Deductions.DataBindings.Add("Text", dt, "TDS_Deduction")
            'txt_Sodexo_Deductions.DataBindings.Add("Text", dt, "Sodexo_Coupons_Deduction")
            'txt_ESIC_Employee_Deductions.DataBindings.Add("Text", dt, "ESIC_Employee")
            'txt_Others_Deductions.DataBindings.Add("Text", dt, "Other_Deductions")
            'txt_Total_Deductions.DataBindings.Add("Text", dt, "Total_Deductions")
            'txt_NetSalary.DataBindings.Add("Text", dt, "Net_Salary")
            'txt_TotalAllowances.DataBindings.Add("Text", dt, "Total_Allowances")
            ''txt_Total_Earnings.DataBindings.Add("Text", dt, "")
            'txt_GrossSalary.DataBindings.Add("Text", dt, "Gross_Salary")
            'Amount_In_Words.DataBindings.Add("Text", dt, "Net_Salary_In_Words")
            OLEDBConn.Dispose()
            da.Dispose()
            OLEDBComm.Dispose()
            dt.Dispose()

            '--------------- Clear Data Binding ----------------------
            txt_Designation.DataBindings.Clear()
            dtp_DOJ.DataBindings.Clear()
            dtp_DOL.DataBindings.Clear()
            CB_EmpStatus.DataBindings.Clear()
            txt_PF.DataBindings.Clear()
            txt_UAN.DataBindings.Clear()
            txt_Email.DataBindings.Clear()
            txt_StandardMonthlyCTC.DataBindings.Clear()
            txt_STDDays.DataBindings.Clear()
            txt_DaysPay.DataBindings.Clear()
            txt_GrossCTC.DataBindings.Clear()
            txt_BasicForPF.DataBindings.Clear()
            txt_BasicSalary.DataBindings.Clear()
            txt_HRA_Earnings.DataBindings.Clear()
            txt_Special.DataBindings.Clear()
            txt_Transport_Earnings.DataBindings.Clear()
            txt_Medical_Earnings.DataBindings.Clear()
            txt_Conveyance_Earnings.DataBindings.Clear()
            txt_Communication_Earnings.DataBindings.Clear()
            txt_PF_Employer_Earnings.DataBindings.Clear()
            txt_ESIC_Employer_Earnings.DataBindings.Clear()
            txt_Apparel_Earnings.DataBindings.Clear()
            txt_LeaveTravel_Earnings.DataBindings.Clear()
            txt_Laptop_Earnings.DataBindings.Clear()
            txt_Research_Earnings.DataBindings.Clear()
            txt_Meal_Sodexo_Earnings.DataBindings.Clear()
            txt_Arrears.DataBindings.Clear()
            txt_VariablePay.DataBindings.Clear()
            txt_Bonus.DataBindings.Clear()
            txt_PF_Employee_Deductions.DataBindings.Clear()
            txt_TDS_Deductions.DataBindings.Clear()
            txt_Sodexo_Deductions.DataBindings.Clear()
            txt_ESIC_Employee_Deductions.DataBindings.Clear()
            txt_Others_Deductions.DataBindings.Clear()
            txt_Total_Deductions.DataBindings.Clear()
            txt_NetSalary.DataBindings.Clear()
            txt_TotalAllowances.DataBindings.Clear()
            'txt_Total_Earnings.DataBindings.clear()
            txt_GrossSalary.DataBindings.Clear()
            Amount_In_Words.DataBindings.Clear()
        '---------------------------------------------------------
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'OLEDBComm.Dispose()
        'OLEDBConn.Dispose()

        'End Try


        'Try

        '-------------------- Fetch Criteria --------------------------
        '----------Clear Values ------------------
        BasicForPF_Criteria.Text = ""
            Basic_Criteria.Text = ""
            HRA_Criteria.Text = ""
            PF_Employer_Criteria.Text = ""
            PF_Employee_Criteria.Text = ""
            ESIC_Employee_Criteria.Text = ""
            ESIC_Employer_Criteria.Text = ""
            Transport_Criteria.Text = ""
            Communication_Criteria.Text = ""
            Apparel_Criteria.Text = ""
            Research_Criteria.Text = ""
            Medical_Criteria.Text = ""
            Leave_Travel_Criteria.Text = ""
            Conveyance_Criteria.Text = ""
            Laptop_Criteria.Text = ""
            '-----------------------------------------

            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            dt = New DataTable
            da = New OleDbDataAdapter
            'Dim dt As New DataTable
            'Dim da As New OleDbDataAdapter
            'Dim cmd As String
            cmd = "Select * from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
            OLEDBConn.Open()
            OLEDBComm.CommandText = cmd
            da = New OleDbDataAdapter(cmd, ConStr)
            da.Fill(dt)
            BasicForPF_Criteria.DataBindings.Add("Text", dt, "Basic_For_PF")
            Basic_Criteria.DataBindings.Add("Text", dt, "Basic_Percentage")
            HRA_Criteria.DataBindings.Add("Text", dt, "HRA_Percentage")
            PF_Employer_Criteria.DataBindings.Add("Text", dt, "PF_Employer_Percentage")
            PF_Employee_Criteria.DataBindings.Add("Text", dt, "PF_Employee_Percentage")
            ESIC_Employee_Criteria.DataBindings.Add("Text", dt, "ESIC_Employee_Percentage")
            ESIC_Employer_Criteria.DataBindings.Add("Text", dt, "ESIC_Employer_Percentage")
            Transport_Criteria.DataBindings.Add("Text", dt, "Transport")
            Communication_Criteria.DataBindings.Add("Text", dt, "Communication_Percentage")
            Apparel_Criteria.DataBindings.Add("Text", dt, "Apparel_Percentage")
            Research_Criteria.DataBindings.Add("Text", dt, "Research_Percentage")
            Medical_Criteria.DataBindings.Add("Text", dt, "Medical")
            Leave_Travel_Criteria.DataBindings.Add("Text", dt, "Leave_Travel_Percentage")
            Conveyance_Criteria.DataBindings.Add("Text", dt, "Conveyance_Percentage")
            Laptop_Criteria.DataBindings.Add("Text", dt, "Laptop")

            BasicForPF_Criteria.DataBindings.Clear()
            Basic_Criteria.DataBindings.Clear()
            HRA_Criteria.DataBindings.Clear()
            PF_Employer_Criteria.DataBindings.Clear()
            PF_Employee_Criteria.DataBindings.Clear()
            ESIC_Employee_Criteria.DataBindings.Clear()
            ESIC_Employer_Criteria.DataBindings.Clear()
            Transport_Criteria.DataBindings.Clear()
            Communication_Criteria.DataBindings.Clear()
            Apparel_Criteria.DataBindings.Clear()
            Research_Criteria.DataBindings.Clear()
            Medical_Criteria.DataBindings.Clear()
            Leave_Travel_Criteria.DataBindings.Clear()
            Conveyance_Criteria.DataBindings.Clear()
            Laptop_Criteria.DataBindings.Clear()
            OLEDBConn.Close()
            '--------------------------------------------------------------
            OLEDBComm.Dispose()

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try


    End Sub

    Private Sub CB_CompanyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_CompanyName.SelectedIndexChanged
        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim dr As OleDbDataReader
        Dim cmd As String

        '----------------  add Payment Month in Combobox-----------
        cmd = "Select Employee_Name from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "'"
        OLEDBComm.CommandText = cmd
        OLEDBConn.Open()
        dr = OLEDBComm.ExecuteReader
        CB_EmployeeName.Text = ""
        CB_EmployeeID.Text = ""
        CB_EmployeeName.Items.Clear()
        If dr.HasRows = True Then
            While dr.Read
                CB_EmployeeName.Items.Add(dr("Employee_Name"))
                'CB_CriteriaMonth.Items.Add(dr("Payment_Month"))
            End While
        Else
        End If
        dr.Close()

        OLEDBConn.Dispose()
    End Sub

    Private Sub PaymentMonth_SelectedIndexChanged(sender As Object, e As EventArgs)
        '------------ Clear Text Boxes ----------------------
        txt_Designation.Text = ""
        dtp_DOJ.Text = #1/1/1900#
        dtp_DOL.Text = #1/1/1900#
        CB_EmpStatus.Text = ""
        txt_PF.Text = ""
        txt_UAN.Text = ""
        txt_Email.Text = ""
        txt_StandardMonthlyCTC.Text = ""
        txt_DaysPay.Text = ""
        txt_STDDays.Text = ""
        txt_GrossCTC.Text = ""
        txt_BasicForPF.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_PF_Employer_Earnings.Text = ""
        txt_ESIC_Employer_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_Arrears.Text = ""
        txt_VariablePay.Text = ""
        txt_Bonus.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_TDS_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_Others_Deductions.Text = ""
        txt_Total_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_TotalAllowances.Text = ""
        'txt_Total_Earnings.Text=""
        txt_GrossSalary.Text = ""
        Amount_In_Words.Text = ""

        '----------------------------------------------------
        ' On Error Resume Next
        '        Try
        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim cmd As String
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        cmd = "Select * from PayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
        OLEDBConn.Open()
        da = New OleDbDataAdapter(cmd, ConStr)
        da.Fill(dt)
        txt_Designation.DataBindings.Add("Text", dt, "Designation")
        dtp_DOJ.DataBindings.Add("Value", dt, "DOJ")
        dtp_DOL.DataBindings.Add("Value", dt, "Date_of_Leaving")
        CB_EmpStatus.DataBindings.Add("Text", dt, "Salary_Status")
        txt_PF.DataBindings.Add("Text", dt, "PF_No")
        txt_UAN.DataBindings.Add("Text", dt, "UAN_No")
        txt_Email.DataBindings.Add("Text", dt, "E_mail")
        txt_StandardMonthlyCTC.DataBindings.Add("Text", dt, "Standard_Monthly_CTC")
        txt_STDDays.DataBindings.Add("Text", dt, "STD_Days")
        txt_DaysPay.DataBindings.Add("Text", dt, "Days_Pay")
        txt_GrossCTC.DataBindings.Add("Text", dt, "Gross_CTC")
        txt_BasicForPF.DataBindings.Add("Text", dt, "Basic_For_PF")
        txt_BasicSalary.DataBindings.Add("Text", dt, "Basic")
        txt_HRA_Earnings.DataBindings.Add("Text", dt, "House_Rent_Allowance")
        txt_Special.DataBindings.Add("Text", dt, "Special_Allowance")
        txt_Transport_Earnings.DataBindings.Add("Text", dt, "Transport_Allowance")
        txt_Medical_Earnings.DataBindings.Add("Text", dt, "Medical_Allowance")
        txt_Conveyance_Earnings.DataBindings.Add("Text", dt, "Conveyance_Allowance")
        txt_Communication_Earnings.DataBindings.Add("Text", dt, "Communication_Allowance")
        txt_PF_Employer_Earnings.DataBindings.Add("Text", dt, "Employer_PF_Contribution")
        txt_ESIC_Employer_Earnings.DataBindings.Add("Text", dt, "ESIC_Employer")
        txt_Apparel_Earnings.DataBindings.Add("Text", dt, "Apparel_Allowance")
        txt_LeaveTravel_Earnings.DataBindings.Add("Text", dt, "Leave_Travel_Allowance")
        txt_Laptop_Earnings.DataBindings.Add("Text", dt, "Laptop_Allowance")
        txt_Research_Earnings.DataBindings.Add("Text", dt, "Research_Allowance")
        txt_Meal_Sodexo_Earnings.DataBindings.Add("Text", dt, "Meal_Allowance_Sodexo_Coupons")
        txt_Arrears.DataBindings.Add("Text", dt, "Arrears")
        txt_VariablePay.DataBindings.Add("Text", dt, "Variable_Pay")
        txt_Bonus.DataBindings.Add("Text", dt, "Bonus")
        txt_PF_Employee_Deductions.DataBindings.Add("Text", dt, "Employee_PF_Deduction")
        txt_TDS_Deductions.DataBindings.Add("Text", dt, "TDS_Deduction")
        txt_Sodexo_Deductions.DataBindings.Add("Text", dt, "Sodexo_Coupons_Deduction")
        txt_ESIC_Employee_Deductions.DataBindings.Add("Text", dt, "ESIC_Employee")
        txt_Others_Deductions.DataBindings.Add("Text", dt, "Other_Deductions")
        txt_Total_Deductions.DataBindings.Add("Text", dt, "Total_Deductions")
        txt_NetSalary.DataBindings.Add("Text", dt, "Net_Salary")
        txt_TotalAllowances.DataBindings.Add("Text", dt, "Total_Allowances")
        'txt_Total_Earnings.DataBindings.Add("Text", dt, "")
        txt_GrossSalary.DataBindings.Add("Text", dt, "Gross_Salary")
        Amount_In_Words.DataBindings.Add("Text", dt, "Net_Salary_In_Words")
        OLEDBConn.Dispose()
        da.Dispose()
        OLEDBComm.Dispose()
        dt.Dispose()

        '--------------- Clear Data Binding ----------------------
        txt_Designation.DataBindings.Clear()
        dtp_DOJ.DataBindings.Clear()
        dtp_DOL.DataBindings.Clear()
        CB_EmpStatus.DataBindings.Clear()
        txt_PF.DataBindings.Clear()
        txt_UAN.DataBindings.Clear()
        txt_Email.DataBindings.Clear()
        txt_StandardMonthlyCTC.DataBindings.Clear()
        txt_STDDays.DataBindings.Clear()
        txt_DaysPay.DataBindings.Clear()
        txt_GrossCTC.DataBindings.Clear()
        txt_BasicForPF.DataBindings.Clear()
        txt_BasicSalary.DataBindings.Clear()
        txt_HRA_Earnings.DataBindings.Clear()
        txt_Special.DataBindings.Clear()
        txt_Transport_Earnings.DataBindings.Clear()
        txt_Medical_Earnings.DataBindings.Clear()
        txt_Conveyance_Earnings.DataBindings.Clear()
        txt_Communication_Earnings.DataBindings.Clear()
        txt_PF_Employer_Earnings.DataBindings.Clear()
        txt_ESIC_Employer_Earnings.DataBindings.Clear()
        txt_Apparel_Earnings.DataBindings.Clear()
        txt_LeaveTravel_Earnings.DataBindings.Clear()
        txt_Laptop_Earnings.DataBindings.Clear()
        txt_Research_Earnings.DataBindings.Clear()
        txt_Meal_Sodexo_Earnings.DataBindings.Clear()
        txt_Arrears.DataBindings.Clear()
        txt_VariablePay.DataBindings.Clear()
        txt_Bonus.DataBindings.Clear()
        txt_PF_Employee_Deductions.DataBindings.Clear()
        txt_TDS_Deductions.DataBindings.Clear()
        txt_Sodexo_Deductions.DataBindings.Clear()
        txt_ESIC_Employee_Deductions.DataBindings.Clear()
        txt_Others_Deductions.DataBindings.Clear()
        txt_Total_Deductions.DataBindings.Clear()
        txt_NetSalary.DataBindings.Clear()
        txt_TotalAllowances.DataBindings.Clear()
        'txt_Total_Earnings.DataBindings.clear()
        txt_GrossSalary.DataBindings.Clear()
        Amount_In_Words.DataBindings.Clear()
        '---------------------------------------------------------
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        OLEDBComm.Dispose()
        OLEDBConn.Dispose()

        'End Try

        '-------------------- Fetch Criteria --------------------------
        '----------Clear Values ------------------
        BasicForPF_Criteria.Text = ""
        Basic_Criteria.Text = ""
        HRA_Criteria.Text = ""
        PF_Employer_Criteria.Text = ""
        PF_Employee_Criteria.Text = ""
        ESIC_Employee_Criteria.Text = ""
        ESIC_Employer_Criteria.Text = ""
        Transport_Criteria.Text = ""
        Communication_Criteria.Text = ""
        Apparel_Criteria.Text = ""
        Research_Criteria.Text = ""
        Medical_Criteria.Text = ""
        Leave_Travel_Criteria.Text = ""
        Conveyance_Criteria.Text = ""
        Laptop_Criteria.Text = ""
        '-----------------------------------------

        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        dt = New DataTable
        da = New OleDbDataAdapter
        'Dim dt As New DataTable
        'Dim da As New OleDbDataAdapter
        'Dim cmd As String
        cmd = "Select * from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
        OLEDBConn.Open()
        OLEDBComm.CommandText = cmd
        da = New OleDbDataAdapter(cmd, ConStr)
        da.Fill(dt)
        BasicForPF_Criteria.DataBindings.Add("Text", dt, "Basic_For_PF")
        Basic_Criteria.DataBindings.Add("Text", dt, "Basic_Percentage")
        HRA_Criteria.DataBindings.Add("Text", dt, "HRA_Percentage")
        PF_Employer_Criteria.DataBindings.Add("Text", dt, "PF_Employer_Percentage")
        PF_Employee_Criteria.DataBindings.Add("Text", dt, "PF_Employee_Percentage")
        ESIC_Employee_Criteria.DataBindings.Add("Text", dt, "ESIC_Employee_Percentage")
        ESIC_Employer_Criteria.DataBindings.Add("Text", dt, "ESIC_Employer_Percentage")
        Transport_Criteria.DataBindings.Add("Text", dt, "Transport")
        Communication_Criteria.DataBindings.Add("Text", dt, "Communication_Percentage")
        Apparel_Criteria.DataBindings.Add("Text", dt, "Apparel_Percentage")
        Research_Criteria.DataBindings.Add("Text", dt, "Research_Percentage")
        Medical_Criteria.DataBindings.Add("Text", dt, "Medical")
        Leave_Travel_Criteria.DataBindings.Add("Text", dt, "Leave_Travel_Percentage")
        Conveyance_Criteria.DataBindings.Add("Text", dt, "Conveyance_Percentage")
        Laptop_Criteria.DataBindings.Add("Text", dt, "Laptop")

        BasicForPF_Criteria.DataBindings.Clear()
        Basic_Criteria.DataBindings.Clear()
        HRA_Criteria.DataBindings.Clear()
        PF_Employer_Criteria.DataBindings.Clear()
        PF_Employee_Criteria.DataBindings.Clear()
        ESIC_Employee_Criteria.DataBindings.Clear()
        ESIC_Employer_Criteria.DataBindings.Clear()
        Transport_Criteria.DataBindings.Clear()
        Communication_Criteria.DataBindings.Clear()
        Apparel_Criteria.DataBindings.Clear()
        Research_Criteria.DataBindings.Clear()
        Medical_Criteria.DataBindings.Clear()
        Leave_Travel_Criteria.DataBindings.Clear()
        Conveyance_Criteria.DataBindings.Clear()
        Laptop_Criteria.DataBindings.Clear()
        OLEDBConn.Close()
        '--------------------------------------------------------------
        OLEDBComm.Dispose()
    End Sub



    Private Sub CB_CriteriaMonth_SelectedIndexChanged(sender As Object, e As EventArgs)
        '----------Clear Values ------------------
        BasicForPF_Criteria.Text = ""
        Basic_Criteria.Text = ""
        HRA_Criteria.Text = ""
        PF_Employer_Criteria.Text = ""
        PF_Employee_Criteria.Text = ""
        ESIC_Employee_Criteria.Text = ""
        ESIC_Employer_Criteria.Text = ""
        Transport_Criteria.Text = ""
        Communication_Criteria.Text = ""
        Apparel_Criteria.Text = ""
        Research_Criteria.Text = ""
        Medical_Criteria.Text = ""
        Leave_Travel_Criteria.Text = ""
        Conveyance_Criteria.Text = ""
        Laptop_Criteria.Text = ""
        '-----------------------------------------

        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim cmd As String
        cmd = "Select * from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
        OLEDBConn.Open()
        OLEDBComm.CommandText = cmd
        da = New OleDbDataAdapter(cmd, ConStr)
        da.Fill(dt)
        BasicForPF_Criteria.DataBindings.Add("Text", dt, "Basic_For_PF")
        Basic_Criteria.DataBindings.Add("Text", dt, "Basic_Percentage")
        HRA_Criteria.DataBindings.Add("Text", dt, "HRA_Percentage")
        PF_Employer_Criteria.DataBindings.Add("Text", dt, "PF_Employer_Percentage")
        PF_Employee_Criteria.DataBindings.Add("Text", dt, "PF_Employee_Percentage")
        ESIC_Employee_Criteria.DataBindings.Add("Text", dt, "ESIC_Employee_Percentage")
        ESIC_Employer_Criteria.DataBindings.Add("Text", dt, "ESIC_Employer_Percentage")
        Transport_Criteria.DataBindings.Add("Text", dt, "Transport")
        Communication_Criteria.DataBindings.Add("Text", dt, "Communication_Percentage")
        Apparel_Criteria.DataBindings.Add("Text", dt, "Apparel_Percentage")
        Research_Criteria.DataBindings.Add("Text", dt, "Research_Percentage")
        Medical_Criteria.DataBindings.Add("Text", dt, "Medical")
        Leave_Travel_Criteria.DataBindings.Add("Text", dt, "Leave_Travel_Percentage")
        Conveyance_Criteria.DataBindings.Add("Text", dt, "Conveyance_Percentage")
        Laptop_Criteria.DataBindings.Add("Text", dt, "Laptop")

        BasicForPF_Criteria.DataBindings.Clear()
        Basic_Criteria.DataBindings.Clear()
        HRA_Criteria.DataBindings.Clear()
        PF_Employer_Criteria.DataBindings.Clear()
        PF_Employee_Criteria.DataBindings.Clear()
        ESIC_Employee_Criteria.DataBindings.Clear()
        ESIC_Employer_Criteria.DataBindings.Clear()
        Transport_Criteria.DataBindings.Clear()
        Communication_Criteria.DataBindings.Clear()
        Apparel_Criteria.DataBindings.Clear()
        Research_Criteria.DataBindings.Clear()
        Medical_Criteria.DataBindings.Clear()
        Leave_Travel_Criteria.DataBindings.Clear()
        Conveyance_Criteria.DataBindings.Clear()
        Laptop_Criteria.DataBindings.Clear()
        OLEDBConn.Close()
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        '------------ Clear Text Boxes ----------------------
        txt_Designation.Text = ""
        dtp_DOJ.Text = #1/1/1900#
        dtp_DOL.Text = #1/1/1900#
        CB_EmpStatus.Text = ""
        txt_PF.Text = ""
        txt_UAN.Text = ""
        txt_Email.Text = ""
        txt_StandardMonthlyCTC.Text = ""
        txt_DaysPay.Text = ""
        txt_STDDays.Text = ""
        txt_GrossCTC.Text = ""
        txt_BasicForPF.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_PF_Employer_Earnings.Text = ""
        txt_ESIC_Employer_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_Arrears.Text = ""
        txt_VariablePay.Text = ""
        txt_Bonus.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_TDS_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_Others_Deductions.Text = ""
        txt_Total_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_TotalAllowances.Text = ""
        'txt_Total_Earnings.Text=""
        txt_GrossSalary.Text = ""
    End Sub


    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click
        Try

            If RadioButton_Auto.Checked = True Then
                'Standard Monthly CTC
                Dim StandardMonthlyCTC As Double = txt_StandardMonthlyCTC.Text
                txt_StandardMonthlyCTC.Text = FormatNumber(StandardMonthlyCTC, NumDigitsAfterDecimal:=0)
                'STD Days in Month
                Dim STDDays As Double
                'txt_STDDays.Text = BasicForPF_Criteria.Text
                STDDays = txt_STDDays.Text
                'Days Pay
                Dim DaysPay As Double = txt_DaysPay.Text
                'Gross CTC
                txt_GrossCTC.Text = FormatNumber((StandardMonthlyCTC / STDDays) * DaysPay, NumDigitsAfterDecimal:=0)
                Dim GrossCTC As Double = txt_GrossCTC.Text
                'Basic
                Dim Basic As Double = Basic_Criteria.Text
                txt_BasicSalary.Text = FormatNumber((GrossCTC * Basic) / 100, NumDigitsAfterDecimal:=0)
                Dim BasicSalary As Double = txt_BasicSalary.Text
                'Basic for PF
                Dim BasicForPF As Double = BasicForPF_Criteria.Text
                txt_BasicForPF.Text = FormatNumber(If(BasicForPF > 0, BasicForPF, BasicSalary), NumDigitsAfterDecimal:=0)
                Dim BasicForPF_Final As Double = txt_BasicForPF.Text
                'Employer PF Contribution
                Dim PF_Employer As Double = PF_Employer_Criteria.Text
                txt_PF_Employer_Earnings.Text = FormatNumber((BasicForPF_Final * PF_Employer) / 100, NumDigitsAfterDecimal:=0)
                Dim PF_Employer_Contr As Double = txt_PF_Employer_Earnings.Text
                'Employer ESIC Contribution
                Dim ESIC_Employer As Double = ESIC_Employer_Criteria.Text
                txt_ESIC_Employer_Earnings.Text = FormatNumber(If(StandardMonthlyCTC <= 21000, (GrossCTC * ESIC_Employer) / 100, 0), NumDigitsAfterDecimal:=0)
                'Transport Allowance
                Dim TransportCriteria As Double = Transport_Criteria.Text
                txt_Transport_Earnings.Text = FormatNumber((TransportCriteria / STDDays) * DaysPay, NumDigitsAfterDecimal:=0)
                Dim Transport As Double = txt_Transport_Earnings.Text
                'Communication Allowance
                Dim Communication As Double = Communication_Criteria.Text
                txt_Communication_Earnings.Text = FormatNumber((BasicSalary * Communication) / 100, NumDigitsAfterDecimal:=0)
                Dim Communication_Allow As Double = txt_Communication_Earnings.Text
                'Apparel Allowance
                Dim Apparel As Double = Apparel_Criteria.Text
                txt_Apparel_Earnings.Text = FormatNumber((BasicSalary * Apparel) / 100, NumDigitsAfterDecimal:=0)
                Dim Apparel_Allow As Double = txt_Apparel_Earnings.Text
                'Research Allowance
                Dim Research As Double = Research_Criteria.Text
                txt_Research_Earnings.Text = FormatNumber((BasicSalary * Research) / 100, NumDigitsAfterDecimal:=0)
                Dim Research_Allow As Double = txt_Research_Earnings.Text
                'Medical Allowance
                Dim MedicalCriteria As Double = Medical_Criteria.Text
                txt_Medical_Earnings.Text = FormatNumber((MedicalCriteria / STDDays) * DaysPay, NumDigitsAfterDecimal:=0)
                Dim Medical As Double = txt_Medical_Earnings.Text
                'House Rent Allowance
                Dim HRA As Double = HRA_Criteria.Text
                txt_HRA_Earnings.Text = FormatNumber((BasicSalary * HRA) / 100, NumDigitsAfterDecimal:=0)
                Dim HouseRent As Double = txt_HRA_Earnings.Text
                'Leave Travel Allowance
                Dim Leave As Double = Leave_Travel_Criteria.Text
                txt_LeaveTravel_Earnings.Text = FormatNumber((BasicSalary * Leave) / 100, NumDigitsAfterDecimal:=0)
                Dim Leave_Allow As Double = txt_LeaveTravel_Earnings.Text
                'Meal_Allowance_Earnings
                Dim Meal_Allow As Double = FormatNumber(CDbl(txt_Meal_Sodexo_Earnings.Text), NumDigitsAfterDecimal:=0)
                'Conveyance Allowance
                Dim Conveyance As Double = Conveyance_Criteria.Text
                txt_Conveyance_Earnings.Text = FormatNumber((BasicSalary * Conveyance) / 100, NumDigitsAfterDecimal:=0)
                Dim Conveyance_Allow As Double = txt_Conveyance_Earnings.Text
                ' Total Allowance Except Laptop
                Dim Total_Allow As Double
                Total_Allow = FormatNumber(Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow, NumDigitsAfterDecimal:=0)
                'txt_TotalAllowances.Text = Total_Allow

                'Special Allowance
                txt_Special.Text = FormatNumber(GrossCTC - (Total_Allow + BasicSalary + PF_Employer_Contr), NumDigitsAfterDecimal:=0)
                Dim Special_Allow As Double = txt_Special.Text
                'Laptop Allowance
                Dim LaptopCriteria As Double = Laptop_Criteria.Text
                txt_Laptop_Earnings.Text = FormatNumber((LaptopCriteria / STDDays) * DaysPay, NumDigitsAfterDecimal:=0)
                Dim Laptop_Allow As Double = txt_Laptop_Earnings.Text
                'Bonus
                Dim Bonus As Double = FormatNumber(CDbl(txt_Bonus.Text), NumDigitsAfterDecimal:=0)
                'Arrears
                Dim Arrears As Double = FormatNumber(CDbl(txt_Arrears.Text), NumDigitsAfterDecimal:=0)
                'VariablePay
                Dim VariablePay As Double = FormatNumber(CDbl(txt_VariablePay.Text), NumDigitsAfterDecimal:=0)
                'GrossSalary
                txt_GrossSalary.Text = FormatNumber(BasicSalary + Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow + Bonus + Arrears + VariablePay, NumDigitsAfterDecimal:=0)
                Dim GrossSalary As Double = CDbl(txt_GrossSalary.Text)

                'PF_Employee_Deductions
                Dim PFEmployeeCriteria As Double = PF_Employee_Criteria.Text
                txt_PF_Employee_Deductions.Text = FormatNumber((BasicForPF_Final * PFEmployeeCriteria) / 100, NumDigitsAfterDecimal:=0)
                Dim PF_Employee_Deductions As Double = txt_PF_Employee_Deductions.Text
                'ESIC_Employee_Deductions
                Dim ESIC_Employee As Double = ESIC_Employee_Criteria.Text
                txt_ESIC_Employee_Deductions.Text = FormatNumber(If(StandardMonthlyCTC <= 21000, (GrossCTC * ESIC_Employee) / 100, 0), NumDigitsAfterDecimal:=0)
                Dim ESIC_Employee_Deductions As Double = txt_ESIC_Employee_Deductions.Text
                'TDS_Deductions
                Dim TDS_Deductions As Double = FormatNumber(CDbl(txt_TDS_Deductions.Text), NumDigitsAfterDecimal:=0)
                'Sodexo_Deductions
                txt_Sodexo_Deductions.Text = FormatNumber(Meal_Allow, NumDigitsAfterDecimal:=0)
                Dim Sodexo_Deductions As Double = FormatNumber(CDbl(txt_Sodexo_Deductions.Text), NumDigitsAfterDecimal:=0)
                'Others_Deductions
                Dim Others_Deductions As Double = FormatNumber(CDbl(txt_Others_Deductions.Text), NumDigitsAfterDecimal:=0)
                'Total_Deductions
                Dim Total_Deductions As Double = FormatNumber(PF_Employee_Deductions + TDS_Deductions + Sodexo_Deductions + Others_Deductions + ESIC_Employee_Deductions, NumDigitsAfterDecimal:=0)
                txt_Total_Deductions.Text = FormatNumber(Total_Deductions, NumDigitsAfterDecimal:=0)
                'TotalAllowances
                txt_TotalAllowances.Text = FormatNumber(Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow, NumDigitsAfterDecimal:=0)
                'NetSalary
                txt_NetSalary.Text = FormatNumber(GrossSalary - Total_Deductions, NumDigitsAfterDecimal:=0)

                btn_Save.Enabled = True
            ElseIf RadioButton_Manual.Checked = True Then
                'Standard Monthly CTC
                Dim StandardMonthlyCTC As Double = txt_StandardMonthlyCTC.Text
                'STD Days in Month
                Dim STDDays As Double = txt_STDDays.Text
                'Days Pay
                Dim DaysPay As Double = txt_DaysPay.Text
                'Gross CTC
                txt_GrossCTC.Text = (StandardMonthlyCTC / STDDays) * DaysPay
                Dim GrossCTC As Double = txt_GrossCTC.Text
                'Basic
                Dim Basic As Double = txt_BasicSalary.Text
                'Basic for PF
                Dim BasicForPF As Double = txt_BasicForPF.Text
                'Employer PF Contribution
                Dim PF_Employer As Double = txt_PF_Employer_Earnings.Text
                'Employer ESIC Contribution
                Dim ESIC_Employer As Double = txt_ESIC_Employer_Earnings.Text
                'Transport Allowance
                Dim Transport As Double = txt_Transport_Earnings.Text
                'Communication Allowance
                Dim Communication_Allow As Double = txt_Communication_Earnings.Text
                'Apparel Allowance
                Dim Apparel_Allow As Double = txt_Apparel_Earnings.Text
                'Research Allowance
                Dim Research_Allow As Double = txt_Research_Earnings.Text
                'Medical Allowance
                Dim Medical As Double = txt_Medical_Earnings.Text
                'House Rent Allowance
                Dim HouseRent As Double = txt_HRA_Earnings.Text
                'Leave Travel Allowance
                Dim Leave_Allow As Double = txt_LeaveTravel_Earnings.Text
                'Meal_Allowance
                Dim Meal_Allow As Double = txt_Meal_Sodexo_Earnings.Text
                'Conveyance Allowance
                Dim Conveyance_Allow As Double = txt_Conveyance_Earnings.Text
                ' Total Allowance Except Laptop
                Dim Total_Allow As Double
                Total_Allow = Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow
                txt_TotalAllowances.Text = Total_Allow
                'Special Allowance
                'txt_Special.Text = GrossCTC - (Total_Allow + Basic + PF_Employer)
                Dim Special_Allow As Double = txt_Special.Text
                'Laptop Allowance
                Dim Laptop_Allow As Double = txt_Laptop_Earnings.Text
                'Bonus
                Dim Bonus As Double = txt_Bonus.Text
                'Arrears
                Dim Arrears As Double = txt_Arrears.Text
                'VariablePay
                Dim VariablePay As Double = txt_VariablePay.Text
                'GrossSalary
                Dim GrossSalary As Double
                GrossSalary = Basic + Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow + Bonus + Arrears + VariablePay
                txt_GrossSalary.Text = GrossSalary
                Dim GrossSalary_Earnling As Double = txt_GrossSalary.Text
                'PF_Employee_Deductions
                Dim PF_Employee_Deductions As Double = txt_PF_Employee_Deductions.Text
                'ESIC_Employee_Deductions
                Dim ESIC_Employee_Deductions As Double = txt_ESIC_Employee_Deductions.Text
                'TDS_Deductions
                Dim TDS_Deductions As Double = txt_TDS_Deductions.Text
                'Sodexo_Deductions
                Dim Sodexo_Deductions As Double = txt_Sodexo_Deductions.Text
                'Others_Deductions
                Dim Others_Deductions As Double = txt_Others_Deductions.Text
                'Total_Deductions
                Dim Total_Deductions As Double = PF_Employee_Deductions + TDS_Deductions + Sodexo_Deductions + Others_Deductions + ESIC_Employee_Deductions
                txt_Total_Deductions.Text = Total_Deductions
                'TotalAllowances
                txt_TotalAllowances.Text = Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow
                'NetSalary
                txt_NetSalary.Text = GrossSalary_Earnling - Total_Deductions

                btn_Save.Enabled = True
            Else

            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Missing Input !!!", "Input Required !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btn_Save.Enabled = False
        End Try

    End Sub

    Private Sub RadioButton_Auto_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Auto.CheckedChanged
        If RadioButton_Auto.Checked = True Then
            txt_GrossCTC.Enabled = False
            txt_BasicForPF.Enabled = False
            txt_BasicSalary.Enabled = False
            txt_HRA_Earnings.Enabled = False
            txt_Special.Enabled = False
            txt_Transport_Earnings.Enabled = False
            txt_Medical_Earnings.Enabled = False
            txt_Conveyance_Earnings.Enabled = False
            txt_Communication_Earnings.Enabled = False
            txt_PF_Employer_Earnings.Enabled = False
            txt_ESIC_Employer_Earnings.Enabled = False
            txt_Apparel_Earnings.Enabled = False
            txt_LeaveTravel_Earnings.Enabled = False
            txt_Laptop_Earnings.Enabled = False
            txt_Research_Earnings.Enabled = False
            txt_PF_Employee_Deductions.Enabled = False
            txt_Sodexo_Deductions.Enabled = False
            txt_ESIC_Employee_Deductions.Enabled = False
            txt_Total_Deductions.Enabled = False
            txt_NetSalary.Enabled = False
            txt_TotalAllowances.Enabled = False
            Amount_In_Words.Enabled = False
        Else
            txt_GrossCTC.Enabled = True
            txt_BasicForPF.Enabled = True
            txt_BasicSalary.Enabled = True
            txt_HRA_Earnings.Enabled = True
            txt_Special.Enabled = True
            txt_Transport_Earnings.Enabled = True
            txt_Medical_Earnings.Enabled = True
            txt_Conveyance_Earnings.Enabled = True
            txt_Communication_Earnings.Enabled = True
            txt_PF_Employer_Earnings.Enabled = True
            txt_ESIC_Employer_Earnings.Enabled = True
            txt_Apparel_Earnings.Enabled = True
            txt_LeaveTravel_Earnings.Enabled = True
            txt_Laptop_Earnings.Enabled = True
            txt_Research_Earnings.Enabled = True
            txt_PF_Employee_Deductions.Enabled = True
            txt_Sodexo_Deductions.Enabled = True
            txt_ESIC_Employee_Deductions.Enabled = True
            txt_Total_Deductions.Enabled = True
            txt_NetSalary.Enabled = True
            txt_TotalAllowances.Enabled = True
            Amount_In_Words.Enabled = True
        End If
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try

            If CB_SalaryMonth.Text = "" Then
                MessageBox.Show("Please Select Month !!!")
                CB_SalaryMonth.Focus()
                Exit Sub
            ElseIf CB_SalaryYear.Text = "" Then
                MessageBox.Show("Please Select Year !!!")
                CB_SalaryYear.Focus()
                Exit Sub
            End If

            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            OLEDBComm.CommandTimeout = 10
            Dim DR As OleDb.OleDbDataReader
            Dim cmd As String
            '--------------------- Check if data is already exist ---------------------
            OLEDBConn.Open()
            cmd = "SELECT Count(*) FROM PayrollData Where Emp_ID = '" & CB_EmployeeID.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Company = '" & CB_CompanyName.Text & "' and Payment_Month  = '" & CB_SalaryMonth.Text & "-" & CB_SalaryYear.Text & "'"
            OLEDBComm.CommandText = cmd
            If OLEDBComm.ExecuteScalar > 0 Then

                If MessageBox.Show("Record already exist in Database.!!! Do you want to updated existing records ?.", "Payroll Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then

                    OLEDBComm.CommandText = ("UPDATE PayrollData SET
        Designation = @Designation,
        DOJ = @DOJ,
        PF_No = @PF_No,
        UAN_No = @UAN_No,
        E_mail = @E_mail,
        Standard_Monthly_CTC = @Standard_Monthly_CTC,
        STD_Days = @STD_Days,
        Days_Pay = @Days_Pay,
        Gross_CTC = @Gross_CTC,
        Basic = @Basic,
        Basic_For_PF = @Basic_For_PF,
        Employer_PF_Contribution = @Employer_PF_Contribution,
        ESIC_Employer = @ESIC_Employer,
        Transport_Allowance = @Transport_Allowance,
        Communication_Allowance = @Communication_Allowance,
        Apparel_Allowance = @Apparel_Allowance,
        Research_Allowance = @Research_Allowance,
        Medical_Allowance = @Medical_Allowance,
        House_Rent_Allowance = @House_Rent_Allowance,
        Leave_Travel_Allowance = @Leave_Travel_Allowance,
        Meal_Allowance_Sodexo_Coupons = @Meal_Allowance_Sodexo_Coupons,
        Conveyance_Allowance = @Conveyance_Allowance,
        Special_Allowance = @Special_Allowance,
        Laptop_Allowance = @Laptop_Allowance,
        Bonus = @Bonus,
        Arrears = @Arrears,
        Variable_Pay = @Variable_Pay,
        Gross_Salary = @Gross_Salary,
        Employee_PF_Deduction = @Employee_PF_Deduction,
        ESIC_Employee = @ESIC_Employee,
        TDS_Deduction = @TDS_Deduction,
        Sodexo_Coupons_Deduction = @Sodexo_Coupons_Deduction,
        Other_Deductions = @Other_Deductions,
        Total_Deductions = @Total_Deductions,
        Net_Salary = @Net_Salary,
        Total_Allowances = @Total_Allowances,
        Net_Salary_In_Words = @Net_Salary_In_Words,
        Date_of_Leaving = @Date_of_Leaving,
        Salary_Status = @Salary_Status

        Where Emp_ID = '" & CB_EmployeeID.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Company = '" & CB_CompanyName.Text & "' and Payment_Month  = '" & CB_SalaryMonth.Text & "-" & CB_SalaryYear.Text & "'")

                    OLEDBComm.Parameters.Add("@Designation", OleDb.OleDbType.Char).Value = txt_Designation.Text
                    OLEDBComm.Parameters.Add("@DOJ", OleDb.OleDbType.Date).Value = dtp_DOJ.Value
                    OLEDBComm.Parameters.Add("@PF_No", OleDb.OleDbType.Char).Value = CStr(txt_PF.Text)
                    OLEDBComm.Parameters.Add("@UAN_No", OleDb.OleDbType.Char).Value = CStr(txt_UAN.Text)
                    OLEDBComm.Parameters.Add("@E_mail", OleDb.OleDbType.Char).Value = txt_Email.Text
                    OLEDBComm.Parameters.Add("@Standard_Monthly_CTC", OleDb.OleDbType.Double).Value = CDbl(txt_StandardMonthlyCTC.Text)
                    OLEDBComm.Parameters.Add("@STD_Days", OleDb.OleDbType.Double).Value = CDbl(txt_STDDays.Text)
                    OLEDBComm.Parameters.Add("@Days_Pay", OleDb.OleDbType.Double).Value = CDbl(txt_DaysPay.Text)
                    OLEDBComm.Parameters.Add("@Gross_CTC", OleDb.OleDbType.Double).Value = CDbl(txt_GrossCTC.Text)
                    OLEDBComm.Parameters.Add("@Basic", OleDb.OleDbType.Double).Value = CDbl(txt_BasicSalary.Text)
                    OLEDBComm.Parameters.Add("@Basic_For_PF", OleDb.OleDbType.Double).Value = CDbl(txt_BasicForPF.Text)
                    OLEDBComm.Parameters.Add("@Employer_PF_Contribution", OleDb.OleDbType.Double).Value = CDbl(txt_PF_Employer_Earnings.Text)
                    OLEDBComm.Parameters.Add("@ESIC_Employer", OleDb.OleDbType.Double).Value = CDbl(txt_ESIC_Employer_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Transport_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Transport_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Communication_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Communication_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Apparel_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Apparel_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Research_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Research_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Medical_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Medical_Earnings.Text)
                    OLEDBComm.Parameters.Add("@House_Rent_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_HRA_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Leave_Travel_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_LeaveTravel_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Meal_Allowance_Sodexo_Coupons", OleDb.OleDbType.Double).Value = CDbl(txt_Meal_Sodexo_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Conveyance_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Conveyance_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Special_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Special.Text)
                    OLEDBComm.Parameters.Add("@Laptop_Allowance", OleDb.OleDbType.Double).Value = CDbl(txt_Laptop_Earnings.Text)
                    OLEDBComm.Parameters.Add("@Bonus", OleDb.OleDbType.Double).Value = CDbl(txt_Bonus.Text)
                    OLEDBComm.Parameters.Add("@Arrears", OleDb.OleDbType.Double).Value = CDbl(txt_Arrears.Text)
                    OLEDBComm.Parameters.Add("@Variable_Pay", OleDb.OleDbType.Double).Value = CDbl(txt_VariablePay.Text)
                    OLEDBComm.Parameters.Add("@Gross_Salary", OleDb.OleDbType.Double).Value = CDbl(txt_GrossSalary.Text)
                    OLEDBComm.Parameters.Add("@Employee_PF_Deduction", OleDb.OleDbType.Double).Value = CDbl(txt_PF_Employee_Deductions.Text)
                    OLEDBComm.Parameters.Add("@ESIC_Employee", OleDb.OleDbType.Double).Value = CDbl(txt_ESIC_Employee_Deductions.Text)
                    OLEDBComm.Parameters.Add("@TDS_Deduction", OleDb.OleDbType.Double).Value = CDbl(txt_TDS_Deductions.Text)
                    OLEDBComm.Parameters.Add("@Sodexo_Coupons_Deduction", OleDb.OleDbType.Double).Value = CDbl(txt_Sodexo_Deductions.Text)
                    OLEDBComm.Parameters.Add("@Other_Deductions", OleDb.OleDbType.Double).Value = CDbl(txt_Others_Deductions.Text)
                    OLEDBComm.Parameters.Add("@Total_Deductions", OleDb.OleDbType.Double).Value = CDbl(txt_Total_Deductions.Text)
                    OLEDBComm.Parameters.Add("@Net_Salary", OleDb.OleDbType.Double).Value = CDbl(txt_NetSalary.Text)
                    OLEDBComm.Parameters.Add("@Total_Allowances", OleDb.OleDbType.Double).Value = CDbl(txt_TotalAllowances.Text)
                    OLEDBComm.Parameters.Add("@Net_Salary_In_Words", OleDb.OleDbType.Char).Value = Amount_In_Words.Text
                    OLEDBComm.Parameters.Add("@Date_of_Leaving", OleDb.OleDbType.Date).Value = dtp_DOL.Value
                    OLEDBComm.Parameters.Add("@Salary_Status", OleDb.OleDbType.Char).Value = CB_EmpStatus.Text

                    OLEDBComm.ExecuteNonQuery()
                    OLEDBComm.Parameters.Clear()
                    MessageBox.Show("Updated Successfully !!!", "Payroll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    OLEDBConn.Close()

                End If

            Else
                '--------------------------------------------------------------------------

                '-------Get Maximum Serial Number -----------------------------------------
                Dim newNumber As Integer
                cmd = "SELECT MAX(S_No) AS MAXIMUM FROM PayrollData"
                OLEDBComm.CommandText = cmd

                DR = OLEDBComm.ExecuteReader
                If DR.HasRows Then
                    While DR.Read()
                        newNumber = CInt(DR("MAXIMUM"))
                    End While
                End If
                DR.Close()
                '---------------------------------------------------------------------------

                OLEDBComm.CommandText = "INSERT INTO PayrollData
        (
        S_No,
        Emp_ID,
        Employee_Name,
        Company,
        Designation,
        DOJ,
        PF_No,
        UAN_No,
        E_mail,
        Payment_Month,
        Standard_Monthly_CTC,
        STD_Days,
        Days_Pay,
        Gross_CTC,
        Basic,
        Basic_For_PF,
        Employer_PF_Contribution,
        ESIC_Employer,
        Transport_Allowance,
        Communication_Allowance,
        Apparel_Allowance,
        Research_Allowance,
        Medical_Allowance,
        House_Rent_Allowance,
        Leave_Travel_Allowance,
        Meal_Allowance_Sodexo_Coupons,
        Conveyance_Allowance,
        Special_Allowance,
        Laptop_Allowance,
        Bonus,
        Arrears,
        Variable_Pay,
        Gross_Salary,
        Employee_PF_Deduction,
        ESIC_Employee,
        TDS_Deduction,
        Sodexo_Coupons_Deduction,
        Other_Deductions,
        Total_Deductions,
        Net_Salary,
        Total_Allowances,
        Net_Salary_In_Words,
        PaySlip_Status,
        Date_of_Leaving,
        Salary_Status
        )      
        VALUES
        (
        @S_No,
        @Emp_ID,
        @Employee_Name,
        @Company,
        @Designation,
        @DOJ,
        @PF_No,
        @UAN_No,
        @E_mail,
        @Payment_Month,
        @Standard_Monthly_CTC,
        @STD_Days,
        @Days_Pay,
        @Gross_CTC,
        @Basic,
        @Basic_For_PF,
        @Employer_PF_Contribution,
        @ESIC_Employer,
        @Transport_Allowance,
        @Communication_Allowance,
        @Apparel_Allowance,
        @Research_Allowance,
        @Medical_Allowance,
        @House_Rent_Allowance,
        @Leave_Travel_Allowance,
        @Meal_Allowance_Sodexo_Coupons,
        @Conveyance_Allowance,
        @Special_Allowance,
        @Laptop_Allowance,
        @Bonus,
        @Arrears,
        @Variable_Pay,
        @Gross_Salary,
        @Employee_PF_Deduction,
        @ESIC_Employee,
        @TDS_Deduction,
        @Sodexo_Coupons_Deduction,
        @Other_Deductions,
        @Total_Deductions,
        @Net_Salary,
        @Total_Allowances,
        @Net_Salary_In_Words,
        @PaySlip_Status,
        @Date_of_Leaving,
        @Salary_Status
        )"

                OLEDBComm.Parameters.AddWithValue("S_No", CInt(newNumber) + 1)
                OLEDBComm.Parameters.AddWithValue("Emp_ID", CStr(CB_EmployeeID.Text))
                OLEDBComm.Parameters.AddWithValue("Employee_Name", CB_EmployeeName.Text)
                OLEDBComm.Parameters.AddWithValue("Company", CB_CompanyName.Text)
                OLEDBComm.Parameters.AddWithValue("Designation", txt_Designation.Text)
                OLEDBComm.Parameters.AddWithValue("DOJ", dtp_DOJ.Value)
                OLEDBComm.Parameters.AddWithValue("PF_No", CStr(txt_PF.Text))
                OLEDBComm.Parameters.AddWithValue("UAN_No", CStr(txt_UAN.Text))
                OLEDBComm.Parameters.AddWithValue("E_mail", txt_Email.Text)
                OLEDBComm.Parameters.AddWithValue("Payment_Month", CStr(CB_SalaryMonth.Text & "-" & CB_SalaryYear.Text))
                OLEDBComm.Parameters.AddWithValue("Standard_Monthly_CTC", CDbl(txt_StandardMonthlyCTC.Text))
                OLEDBComm.Parameters.AddWithValue("STD_Days", CDbl(txt_STDDays.Text))
                OLEDBComm.Parameters.AddWithValue("Days_Pay", CDbl(txt_DaysPay.Text))
                OLEDBComm.Parameters.AddWithValue("Gross_CTC", CDbl(txt_GrossCTC.Text))
                OLEDBComm.Parameters.AddWithValue("Basic", CDbl(txt_BasicSalary.Text))
                OLEDBComm.Parameters.AddWithValue("Basic_For_PF", CDbl(txt_BasicForPF.Text))
                OLEDBComm.Parameters.AddWithValue("Employer_PF_Contribution", CDbl(txt_PF_Employer_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employer", CDbl(txt_ESIC_Employer_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Transport_Allowance", CDbl(txt_Transport_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Communication_Allowance", CDbl(txt_Communication_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Apparel_Allowance", CDbl(txt_Apparel_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Research_Allowance", CDbl(txt_Research_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Medical_Allowance", CDbl(txt_Medical_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("House_Rent_Allowance", CDbl(txt_HRA_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Leave_Travel_Allowance", CDbl(txt_LeaveTravel_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Meal_Allowance_Sodexo_Coupons", CDbl(txt_Meal_Sodexo_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Conveyance_Allowance", CDbl(txt_Conveyance_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Special_Allowance", CDbl(txt_Special.Text))
                OLEDBComm.Parameters.AddWithValue("Laptop_Allowance", CDbl(txt_Laptop_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Bonus", CDbl(txt_Bonus.Text))
                OLEDBComm.Parameters.AddWithValue("Arrears", CDbl(txt_Arrears.Text))
                OLEDBComm.Parameters.AddWithValue("Variable_Pay", CDbl(txt_VariablePay.Text))
                OLEDBComm.Parameters.AddWithValue("Gross_Salary", CDbl(txt_GrossSalary.Text))
                OLEDBComm.Parameters.AddWithValue("Employee_PF_Deduction", CDbl(txt_PF_Employee_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employee", CDbl(txt_ESIC_Employee_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("TDS_Deduction", CDbl(txt_TDS_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Sodexo_Coupons_Deduction", CDbl(txt_Sodexo_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Other_Deductions", CDbl(txt_Others_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Total_Deductions", CDbl(txt_Total_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Net_Salary", CDbl(txt_NetSalary.Text))
                OLEDBComm.Parameters.AddWithValue("Total_Allowances", CDbl(txt_TotalAllowances.Text))
                OLEDBComm.Parameters.AddWithValue("Net_Salary_In_Words", Amount_In_Words.Text)
                OLEDBComm.Parameters.AddWithValue("PaySlip_Status", DBNull.Value)
                OLEDBComm.Parameters.AddWithValue("Date_of_Leaving", dtp_DOL.Value)
                OLEDBComm.Parameters.AddWithValue("Salary_Status", CB_EmpStatus.Text)

                OLEDBComm.ExecuteNonQuery()
                MessageBox.Show("Saved Successfully !!!", "Payroll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OLEDBConn.Close()
            End If
            OLEDBConn.Close()
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
            OLEDBConn.Close()
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
        End Try

    End Sub

End Class
