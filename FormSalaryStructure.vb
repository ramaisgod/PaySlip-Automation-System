Imports System.Data
Imports System.Data.OleDb
Public Class FormSalaryStructure
    Dim OLEDBConn As New OleDbConnection
    Dim OLEDBComm As New OleDbCommand
    Dim ConStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
    Private Sub FormSalaryStructure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim dr As OleDbDataReader
        Dim cmd As String

        '----------------  add Employee Name in Combobox-----------
        cmd = "Select Distinct Employee_Name from MasterPayrollData"
        OLEDBComm.CommandText = cmd
        OLEDBConn.Open()
        dr = OLEDBComm.ExecuteReader
        If dr.HasRows = True Then
            While dr.Read
                CB_EmployeeName.Items.Add(dr("Employee_Name"))
            End While
        Else
        End If
        dr.Close()

        OLEDBConn.Dispose()

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
        txt_Annual_CTC.Text = ""
        txt_MonthlyCTC.Text = ""
        txt_Performance_Bonus.Text = ""
        txt_Tenure_Bonus.Text = ""
        txt_Total_CTC.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_PF_Employer.Text = ""
        txt_ESIC_Employer.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_GrossSalary.Text = ""
        Basic_Criteria.Text = ""
        BasicForPF_Criteria.Text = ""
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
        CB_CompanyName.Text = ""
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
        OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim dr As OleDbDataReader
        Dim cmd As String

        '----------------  add Company in Combobox-----------
        cmd = "Select Distinct Company from MasterPayrollData Where Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
        OLEDBComm.CommandText = cmd
        OLEDBConn.Open()
        dr = OLEDBComm.ExecuteReader
        CB_CompanyName.Text = ""
        CB_CompanyName.Items.Clear()
        If dr.HasRows = True Then
            While dr.Read
                CB_CompanyName.Items.Add(dr("Company"))
            End While
        Else
        End If
        dr.Close()
        OLEDBConn.Dispose()
    End Sub

    Private Sub CB_CompanyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_CompanyName.SelectedIndexChanged

        '----------Clear Values ------------------
        txt_Designation.Text = ""
        dtp_DOJ.Text = #1/1/1900#
        dtp_DOL.Text = #1/1/1900#
        CB_EmpStatus.Text = ""
        txt_PF.Text = ""
        txt_UAN.Text = ""
        txt_Email.Text = ""
        txt_Annual_CTC.Text = ""
        txt_MonthlyCTC.Text = ""
        txt_Performance_Bonus.Text = ""
        txt_Tenure_Bonus.Text = ""
        txt_Total_CTC.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_PF_Employer.Text = ""
        txt_ESIC_Employer.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_GrossSalary.Text = ""
        Basic_Criteria.Text = ""
        BasicForPF_Criteria.Text = ""
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

        Try
            OLEDBConn.ConnectionString = ConStr
        OLEDBComm.Connection = OLEDBConn
        Dim cmd As String
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        cmd = "Select * from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Emp_ID = '" & CB_EmployeeID.Text & "'"
        OLEDBConn.Open()
        da = New OleDbDataAdapter(cmd, ConStr)
        da.Fill(dt)

        Basic_Criteria.DataBindings.Add("Text", dt, "Basic_Percentage")
        BasicForPF_Criteria.DataBindings.Add("Text", dt, "Basic_For_PF")
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

            txt_Designation.DataBindings.Add("Text", dt, "Designation")
            dtp_DOJ.DataBindings.Add("Value", dt, "DOJ")
        dtp_DOL.DataBindings.Add("Value", dt, "Date_of_Leaving")
        CB_EmpStatus.DataBindings.Add("Text", dt, "Status")
        txt_PF.DataBindings.Add("Text", dt, "PF_No")
        txt_UAN.DataBindings.Add("Text", dt, "UAN_No")
        txt_Email.DataBindings.Add("Text", dt, "E_mail")
        txt_Annual_CTC.DataBindings.Add("Text", dt, "Annual_CTC")
        txt_MonthlyCTC.DataBindings.Add("Text", dt, "Monthly_CTC")
        txt_Performance_Bonus.DataBindings.Add("Text", dt, "Performance_Bonus")
        txt_Tenure_Bonus.DataBindings.Add("Text", dt, "Tenure_Bonus")
        txt_Total_CTC.DataBindings.Add("Text", dt, "Total_CTC")
        txt_BasicSalary.DataBindings.Add("Text", dt, "Basic")
        txt_HRA_Earnings.DataBindings.Add("Text", dt, "House_Rent_Allowance")
        txt_PF_Employer.DataBindings.Add("Text", dt, "PF_Employer_Contribution")
        txt_ESIC_Employer.DataBindings.Add("Text", dt, "ESIC_Employer_Contribution")
        txt_Transport_Earnings.DataBindings.Add("Text", dt, "Transport_Allowance")
        txt_Communication_Earnings.DataBindings.Add("Text", dt, "Communication_Allowance")
        txt_Apparel_Earnings.DataBindings.Add("Text", dt, "Apparel_Allowance")
        txt_Research_Earnings.DataBindings.Add("Text", dt, "Research_Allowance")
        txt_Medical_Earnings.DataBindings.Add("Text", dt, "Medical_Allowance")
        txt_LeaveTravel_Earnings.DataBindings.Add("Text", dt, "Leave_Travel_Allowance")
        txt_Meal_Sodexo_Earnings.DataBindings.Add("Text", dt, "Meal_Allowance_Sodexo_Coupons")
        txt_Conveyance_Earnings.DataBindings.Add("Text", dt, "Conveyance_Allowance")
        txt_Special.DataBindings.Add("Text", dt, "Special_Allowance")
        txt_Laptop_Earnings.DataBindings.Add("Text", dt, "Laptop_Allowance")
        txt_GrossSalary.DataBindings.Add("Text", dt, "Gross_Salary")
        txt_PF_Employee_Deductions.DataBindings.Add("Text", dt, "PF_Employee_Deduction")
        txt_Sodexo_Deductions.DataBindings.Add("Text", dt, "Sodexo_Coupons_Deduction")
        txt_ESIC_Employee_Deductions.DataBindings.Add("Text", dt, "ESIC_Employee_Deduction")
        txt_NetSalary.DataBindings.Add("Text", dt, "Net_Salary")

        OLEDBConn.Dispose()
        da.Dispose()
        OLEDBComm.Dispose()
        dt.Dispose()

        '--------------- Clear Data Binding ----------------------
        Basic_Criteria.DataBindings.Clear()
        BasicForPF_Criteria.DataBindings.Clear()
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
        txt_Designation.DataBindings.Clear()
        dtp_DOJ.DataBindings.Clear()
        dtp_DOL.DataBindings.Clear()
        CB_EmpStatus.DataBindings.Clear()
        txt_PF.DataBindings.Clear()
        txt_UAN.DataBindings.Clear()
        txt_Email.DataBindings.Clear()
        txt_Annual_CTC.DataBindings.Clear()
        txt_MonthlyCTC.DataBindings.Clear()
        txt_Performance_Bonus.DataBindings.Clear()
        txt_Tenure_Bonus.DataBindings.Clear()
        txt_Total_CTC.DataBindings.Clear()
        txt_MonthlyCTC.DataBindings.Clear()
        txt_GrossSalary.DataBindings.Clear()
        txt_BasicSalary.DataBindings.Clear()
        txt_HRA_Earnings.DataBindings.Clear()
        txt_Special.DataBindings.Clear()
        txt_Transport_Earnings.DataBindings.Clear()
        txt_Medical_Earnings.DataBindings.Clear()
        txt_Conveyance_Earnings.DataBindings.Clear()
        txt_Communication_Earnings.DataBindings.Clear()
        txt_PF_Employer.DataBindings.Clear()
        txt_ESIC_Employer.DataBindings.Clear()
        txt_Apparel_Earnings.DataBindings.Clear()
        txt_LeaveTravel_Earnings.DataBindings.Clear()
        txt_Laptop_Earnings.DataBindings.Clear()
        txt_Research_Earnings.DataBindings.Clear()
        txt_Meal_Sodexo_Earnings.DataBindings.Clear()
        txt_PF_Employee_Deductions.DataBindings.Clear()
        txt_Sodexo_Deductions.DataBindings.Clear()
        txt_ESIC_Employee_Deductions.DataBindings.Clear()
        txt_NetSalary.DataBindings.Clear()
        txt_GrossSalary.DataBindings.Clear()

            '---------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBComm.Dispose()
            OLEDBConn.Dispose()

        End Try

    End Sub

    Private Sub Btn_Calculate_Click(sender As Object, e As EventArgs) Handles Btn_Calculate.Click
        Try
            'Annual CTC
            Dim Annual_CTC As Double = txt_Annual_CTC.Text
            'Monthly CTC
            txt_MonthlyCTC.Text = FormatNumber(Annual_CTC / 12, NumDigitsAfterDecimal:=0)
            Dim MonthlyCTC As Double = txt_MonthlyCTC.Text
            'Performance_Bonus
            Dim Performance_Bonus As Double = txt_Performance_Bonus.Text
            'Tenure_Bonus
            Dim Tenure_Bonus As Double = txt_Tenure_Bonus.Text
            'Total_CTC
            Dim TotalCTC As Double = Annual_CTC + Performance_Bonus + Tenure_Bonus
            txt_Total_CTC.Text = FormatNumber(TotalCTC, NumDigitsAfterDecimal:=0)
            'Basic
            Dim Basic As Double = Basic_Criteria.Text
            txt_BasicSalary.Text = FormatNumber((MonthlyCTC * Basic) / 100, NumDigitsAfterDecimal:=0)
            Dim BasicSalary As Double = txt_BasicSalary.Text
            'House Rent Allowance
            Dim HRA As Double = HRA_Criteria.Text
            txt_HRA_Earnings.Text = FormatNumber((BasicSalary * HRA) / 100, NumDigitsAfterDecimal:=0)
            Dim HouseRent As Double = txt_HRA_Earnings.Text
            'Employer PF Contribution
            Dim PF_Employer As Double = PF_Employer_Criteria.Text
            Dim BasicForPF As Double = BasicForPF_Criteria.Text
            txt_PF_Employer.Text = FormatNumber(If(BasicForPF > 0, (BasicForPF * PF_Employer) / 100, (BasicSalary * PF_Employer) / 100), NumDigitsAfterDecimal:=0)
            Dim PF_Employer_Contr As Double = txt_PF_Employer.Text

            'Transport Allowance
            txt_Transport_Earnings.Text = Transport_Criteria.Text
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
            txt_Medical_Earnings.Text = Medical_Criteria.Text
            Dim Medical As Double = txt_Medical_Earnings.Text

            'Leave Travel Allowance
            Dim Leave As Double = Leave_Travel_Criteria.Text
            txt_LeaveTravel_Earnings.Text = FormatNumber((BasicSalary * Leave) / 100, NumDigitsAfterDecimal:=0)
            Dim Leave_Allow As Double = txt_LeaveTravel_Earnings.Text
            'Meal_Allowance
            Dim Meal_Allow As Double = txt_Meal_Sodexo_Earnings.Text
            'Conveyance Allowance
            Dim Conveyance As Double = Conveyance_Criteria.Text
            txt_Conveyance_Earnings.Text = FormatNumber((BasicSalary * Conveyance) / 100, NumDigitsAfterDecimal:=0)
            Dim Conveyance_Allow As Double = txt_Conveyance_Earnings.Text
            ' Total Allowance Except Laptop
            Dim Total_Allow As Double
            Total_Allow = Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow
            'txt_TotalAllowances.Text = Total_Allow

            'Special Allowance
            txt_Special.Text = FormatNumber(MonthlyCTC - (Total_Allow + BasicSalary + PF_Employer_Contr), NumDigitsAfterDecimal:=0)
            Dim Special_Allow As Double = txt_Special.Text
            'Laptop Allowance
            txt_Laptop_Earnings.Text = Laptop_Criteria.Text
            Dim Laptop_Allow As Double = txt_Laptop_Earnings.Text
            'GrossSalary
            Dim GrossSalary As Double
            GrossSalary = BasicSalary + Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + HouseRent + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow
            txt_GrossSalary.Text = FormatNumber(GrossSalary, NumDigitsAfterDecimal:=0)
            Dim GrossSalary_Earnling As Double = txt_GrossSalary.Text
            'Employer ESIC Contribution
            Dim ESIC_Employer As Double = ESIC_Employer_Criteria.Text
            txt_ESIC_Employer.Text = FormatNumber(If(MonthlyCTC <= 21000, (GrossSalary * ESIC_Employer) / 100, 0), NumDigitsAfterDecimal:=0)
            'PF_Employee_Deductions
            Dim PFEmployeeCriteria As Double = PF_Employee_Criteria.Text
            txt_PF_Employee_Deductions.Text = FormatNumber(If(BasicForPF > 0, (BasicForPF * PFEmployeeCriteria) / 100, (BasicSalary * PFEmployeeCriteria) / 100), NumDigitsAfterDecimal:=0)
            Dim PF_Employee_Deductions As Double = txt_PF_Employee_Deductions.Text
            'ESIC_Employee_Deductions
            Dim ESIC_Employee As Double = ESIC_Employee_Criteria.Text
            txt_ESIC_Employee_Deductions.Text = FormatNumber(If(MonthlyCTC <= 21000, (GrossSalary * ESIC_Employee) / 100, 0), NumDigitsAfterDecimal:=0)
            Dim ESIC_Employee_Deductions As Double = txt_ESIC_Employee_Deductions.Text
            'Sodexo_Deductions
            txt_Sodexo_Deductions.Text = txt_Meal_Sodexo_Earnings.Text
            Dim Sodexo_Deductions As Double = txt_Sodexo_Deductions.Text
            'Total_Deductions
            Dim Total_Deductions As Double = PF_Employee_Deductions + Sodexo_Deductions + ESIC_Employee_Deductions
            'txt_Total_Deductions.Text = Total_Deductions
            'TotalAllowances
            'txt_TotalAllowances.Text = Transport + Communication_Allow + Apparel_Allow + Research_Allow + Medical + Leave_Allow + Meal_Allow + Conveyance_Allow + Special_Allow + Laptop_Allow
            'NetSalary
            txt_NetSalary.Text = FormatNumber(GrossSalary_Earnling - Total_Deductions, NumDigitsAfterDecimal:=0)

        Catch ex As Exception
            MessageBox.Show("Missing Input !!!", "Input Required !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            OLEDBComm.CommandText = ("UPDATE MasterPayrollData SET
        Annual_CTC=@Annual_CTC,
        Monthly_CTC = @Monthly_CTC,
        Performance_Bonus=@Performance_Bonus,
        Tenure_Bonus=@Tenure_Bonus,
        Total_CTC=@Total_CTC,
        Basic = @Basic,
        House_Rent_Allowance=@House_Rent_Allowance,
        PF_Employer_Contribution=@PF_Employer_Contribution,
        ESIC_Employer_Contribution=@ESIC_Employer_Contribution,
        Transport_Allowance = @Transport_Allowance,
        Communication_Allowance = @Communication_Allowance,
        Apparel_Allowance = @Apparel_Allowance,
        Research_Allowance = @Research_Allowance,
        Medical_Allowance = @Medical_Allowance,
        Leave_Travel_Allowance = @Leave_Travel_Allowance,
        Meal_Allowance_Sodexo_Coupons = @Meal_Allowance_Sodexo_Coupons,
        Conveyance_Allowance = @Conveyance_Allowance,
        Special_Allowance = @Special_Allowance,
        Laptop_Allowance = @Laptop_Allowance,
        Gross_Salary=@Gross_Salary,
        PF_Employee_Deduction = @PF_Employee_Deduction,
        ESIC_Employee_Deduction = @ESIC_Employee_Deduction,
        Sodexo_Coupons_Deduction = @Sodexo_Coupons_Deduction,
        Net_Salary = @Net_Salary

        Where Emp_ID = '" & CB_EmployeeID.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Company = '" & CB_CompanyName.Text & "'")
            OLEDBConn.Open()
            OLEDBComm.Parameters.Add("@Annual_CTC", OleDb.OleDbType.Double).Value = txt_Annual_CTC.Text
            OLEDBComm.Parameters.Add("@Monthly_CTC", OleDb.OleDbType.Double).Value = txt_MonthlyCTC.Text
            OLEDBComm.Parameters.Add("@Performance_Bonus", OleDb.OleDbType.Double).Value = txt_Performance_Bonus.Text
            OLEDBComm.Parameters.Add("@Tenure_Bonus", OleDb.OleDbType.Double).Value = txt_Tenure_Bonus.Text
            OLEDBComm.Parameters.Add("@Total_CTC", OleDb.OleDbType.Double).Value = txt_Total_CTC.Text
            OLEDBComm.Parameters.Add("@Basic", OleDb.OleDbType.Double).Value = txt_BasicSalary.Text
            OLEDBComm.Parameters.Add("@House_Rent_Allowance", OleDb.OleDbType.Double).Value = txt_HRA_Earnings.Text
            OLEDBComm.Parameters.Add("@PF_Employer_Contribution", OleDb.OleDbType.Double).Value = txt_PF_Employer.Text
            OLEDBComm.Parameters.Add("@ESIC_Employer_Contribution", OleDb.OleDbType.Double).Value = txt_ESIC_Employer.Text
            OLEDBComm.Parameters.Add("@Transport_Allowance", OleDb.OleDbType.Double).Value = txt_Transport_Earnings.Text
            OLEDBComm.Parameters.Add("@Communication_Allowance", OleDb.OleDbType.Double).Value = txt_Communication_Earnings.Text
            OLEDBComm.Parameters.Add("@Apparel_Allowance", OleDb.OleDbType.Double).Value = txt_Apparel_Earnings.Text
            OLEDBComm.Parameters.Add("@Research_Allowance", OleDb.OleDbType.Double).Value = txt_Research_Earnings.Text
            OLEDBComm.Parameters.Add("@Medical_Allowance", OleDb.OleDbType.Double).Value = txt_Medical_Earnings.Text
            OLEDBComm.Parameters.Add("@Leave_Travel_Allowance", OleDb.OleDbType.Double).Value = txt_LeaveTravel_Earnings.Text
            OLEDBComm.Parameters.Add("@Meal_Allowance_Sodexo_Coupons", OleDb.OleDbType.Double).Value = txt_Meal_Sodexo_Earnings.Text
            OLEDBComm.Parameters.Add("@Conveyance_Allowance", OleDb.OleDbType.Double).Value = txt_Conveyance_Earnings.Text
            OLEDBComm.Parameters.Add("@Special_Allowance", OleDb.OleDbType.Double).Value = txt_Sodexo_Deductions.Text
            OLEDBComm.Parameters.Add("@Laptop_Allowance", OleDb.OleDbType.Double).Value = txt_Laptop_Earnings.Text
            OLEDBComm.Parameters.Add("@Gross_Salary", OleDb.OleDbType.Double).Value = txt_GrossSalary.Text
            OLEDBComm.Parameters.Add("@PF_Employee_Deduction", OleDb.OleDbType.Double).Value = txt_PF_Employee_Deductions.Text
            OLEDBComm.Parameters.Add("@ESIC_Employee_Deduction", OleDb.OleDbType.Double).Value = txt_ESIC_Employee_Deductions.Text
            OLEDBComm.Parameters.Add("@Sodexo_Coupons_Deduction", OleDb.OleDbType.Double).Value = txt_Sodexo_Deductions.Text
            OLEDBComm.Parameters.Add("@Net_Salary", OleDb.OleDbType.Double).Value = txt_NetSalary.Text


            OLEDBComm.ExecuteNonQuery()
            OLEDBConn.Close()
            OLEDBConn.Dispose()
            MessageBox.Show("Updated Successfully !!!", "Payroll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBComm.Dispose()
            OLEDBConn.Dispose()
        End Try
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
        txt_Annual_CTC.Text = ""
        txt_MonthlyCTC.Text = ""
        txt_Performance_Bonus.Text = ""
        txt_Tenure_Bonus.Text = ""
        txt_Total_CTC.Text = ""
        txt_BasicSalary.Text = ""
        txt_HRA_Earnings.Text = ""
        txt_PF_Employer.Text = ""
        txt_ESIC_Employer.Text = ""
        txt_Special.Text = ""
        txt_Transport_Earnings.Text = ""
        txt_Medical_Earnings.Text = ""
        txt_Conveyance_Earnings.Text = ""
        txt_Communication_Earnings.Text = ""
        txt_Apparel_Earnings.Text = ""
        txt_LeaveTravel_Earnings.Text = ""
        txt_Laptop_Earnings.Text = ""
        txt_Research_Earnings.Text = ""
        txt_Meal_Sodexo_Earnings.Text = ""
        txt_PF_Employee_Deductions.Text = ""
        txt_Sodexo_Deductions.Text = ""
        txt_ESIC_Employee_Deductions.Text = ""
        txt_NetSalary.Text = ""
        txt_GrossSalary.Text = ""
        Basic_Criteria.Text = ""
        BasicForPF_Criteria.Text = ""
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
        '-----------------------------------------------------
    End Sub


    Private Sub Btn_SaveParameter_Click(sender As Object, e As EventArgs) Handles Btn_SaveParameter.Click

        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            OLEDBComm.CommandText = ("UPDATE MasterPayrollData SET
        Basic_Percentage=@Basic_Percentage,
        Basic_For_PF = @Basic_For_PF,
        HRA_Percentage=@HRA_Percentage,
        PF_Employer_Percentage=@PF_Employer_Percentage,
        PF_Employee_Percentage=@PF_Employee_Percentage,
        ESIC_Employee_Percentage = @ESIC_Employee_Percentage,
        ESIC_Employer_Percentage=@ESIC_Employer_Percentage,
        Transport=@Transport,
        Communication_Percentage=@Communication_Percentage,
        Apparel_Percentage = @Apparel_Percentage,
        Research_Percentage = @Research_Percentage,
        Medical = @Medical,
        Leave_Travel_Percentage = @Leave_Travel_Percentage,
        Conveyance_Percentage = @Conveyance_Percentage,
        Laptop = @Laptop
       
        Where Emp_ID = '" & CB_EmployeeID.Text & "' and Employee_Name = '" & CB_EmployeeName.Text & "' and Company = '" & CB_CompanyName.Text & "'")
            OLEDBConn.Open()
            OLEDBComm.Parameters.Add("@Basic_Percentage", OleDb.OleDbType.Double).Value = Basic_Criteria.Text
            OLEDBComm.Parameters.Add("@Basic_For_PF", OleDb.OleDbType.Double).Value = BasicForPF_Criteria.Text
            OLEDBComm.Parameters.Add("@HRA_Percentage", OleDb.OleDbType.Double).Value = HRA_Criteria.Text
            OLEDBComm.Parameters.Add("@PF_Employer_Percentage", OleDb.OleDbType.Double).Value = PF_Employer_Criteria.Text
            OLEDBComm.Parameters.Add("@PF_Employee_Percentage", OleDb.OleDbType.Double).Value = PF_Employee_Criteria.Text
            OLEDBComm.Parameters.Add("@ESIC_Employee_Percentage", OleDb.OleDbType.Double).Value = ESIC_Employee_Criteria.Text
            OLEDBComm.Parameters.Add("@ESIC_Employer_Percentage", OleDb.OleDbType.Double).Value = ESIC_Employer_Criteria.Text
            OLEDBComm.Parameters.Add("@Transport", OleDb.OleDbType.Double).Value = Transport_Criteria.Text
            OLEDBComm.Parameters.Add("@Communication_Percentage", OleDb.OleDbType.Double).Value = Communication_Criteria.Text
            OLEDBComm.Parameters.Add("@Apparel_Percentage", OleDb.OleDbType.Double).Value = Apparel_Criteria.Text
            OLEDBComm.Parameters.Add("@Research_Percentage", OleDb.OleDbType.Double).Value = Research_Criteria.Text
            OLEDBComm.Parameters.Add("@Medical", OleDb.OleDbType.Double).Value = Medical_Criteria.Text
            OLEDBComm.Parameters.Add("@Leave_Travel_Percentage", OleDb.OleDbType.Double).Value = Leave_Travel_Criteria.Text
            OLEDBComm.Parameters.Add("@Conveyance_Percentage", OleDb.OleDbType.Double).Value = Conveyance_Criteria.Text
            OLEDBComm.Parameters.Add("@Laptop", OleDb.OleDbType.Double).Value = Laptop_Criteria.Text

            OLEDBComm.ExecuteNonQuery()
            OLEDBConn.Close()
            OLEDBConn.Dispose()
            MessageBox.Show("Updated Successfully !!!", "Payroll Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CheckBox_Edit.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBComm.Dispose()
            OLEDBConn.Dispose()
        End Try

    End Sub

    Private Sub CheckBox_Edit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Edit.CheckedChanged
        If CheckBox_Edit.Checked = True Then
            Basic_Criteria.Enabled = True
            BasicForPF_Criteria.Enabled = True
            HRA_Criteria.Enabled = True
            PF_Employer_Criteria.Enabled = True
            PF_Employee_Criteria.Enabled = True
            ESIC_Employee_Criteria.Enabled = True
            ESIC_Employer_Criteria.Enabled = True
            Transport_Criteria.Enabled = True
            Communication_Criteria.Enabled = True
            Apparel_Criteria.Enabled = True
            Research_Criteria.Enabled = True
            Medical_Criteria.Enabled = True
            Leave_Travel_Criteria.Enabled = True
            Conveyance_Criteria.Enabled = True
            Laptop_Criteria.Enabled = True
            Btn_SaveParameter.Enabled = True
        Else
            Basic_Criteria.Enabled = False
            BasicForPF_Criteria.Enabled = False
            HRA_Criteria.Enabled = False
            PF_Employer_Criteria.Enabled = False
            PF_Employee_Criteria.Enabled = False
            ESIC_Employee_Criteria.Enabled = False
            ESIC_Employer_Criteria.Enabled = False
            Transport_Criteria.Enabled = False
            Communication_Criteria.Enabled = False
            Apparel_Criteria.Enabled = False
            Research_Criteria.Enabled = False
            Medical_Criteria.Enabled = False
            Leave_Travel_Criteria.Enabled = False
            Conveyance_Criteria.Enabled = False
            Laptop_Criteria.Enabled = False
            Btn_SaveParameter.Enabled = False
        End If
    End Sub
End Class