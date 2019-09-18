Imports System.Data
Imports System.Data.OleDb
Public Class FormAddNew
    Dim OLEDBConn As New OleDbConnection
    Dim OLEDBComm As New OleDbCommand
    Dim ConStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
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

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try

            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            OLEDBComm.CommandTimeout = 10
            Dim DR As OleDb.OleDbDataReader
            Dim cmd As String
            '--------------------- Check if data is already exist ---------------------
            OLEDBConn.Open()
            cmd = "SELECT Count(*) FROM MasterPayrollData Where Emp_ID = '" & Trim(CB_EmployeeID.Text) & "' and Employee_Name = '" & Trim(CB_EmployeeName.Text) & "' and Company = '" & Trim(CB_CompanyName.Text) & "'"
            OLEDBComm.CommandText = cmd
            If OLEDBComm.ExecuteScalar > 0 Then

                MessageBox.Show("Record already exist in Database.!!!", "Payroll Management System", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                '--------------------------------------------------------------------------

                '-------Get Maximum Serial Number -----------------------------------------
                Dim newNumber As Integer
                cmd = "SELECT MAX(S_No) AS MAXIMUM FROM MasterPayrollData"
                OLEDBComm.CommandText = cmd

                DR = OLEDBComm.ExecuteReader
                If DR.HasRows Then
                    While DR.Read()
                        newNumber = CInt(DR("MAXIMUM"))
                    End While
                End If
                DR.Close()
                '---------------------------------------------------------------------------

                OLEDBComm.CommandText = "INSERT INTO MasterPayrollData
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
            Annual_CTC,
            Monthly_CTC,
            Performance_Bonus,
            Tenure_Bonus,
            Total_CTC,
            Basic,
            House_Rent_Allowance,
            PF_Employer_Contribution,
            ESIC_Employer_Contribution,
            Transport_Allowance,
            Communication_Allowance,
            Apparel_Allowance,
            Research_Allowance,
            Medical_Allowance,
            Leave_Travel_Allowance,
            Meal_Allowance_Sodexo_Coupons,
            Conveyance_Allowance,
            Special_Allowance,
            Laptop_Allowance,
            Gross_Salary,
            PF_Employee_Deduction,
            ESIC_Employee_Deduction,
            Sodexo_Coupons_Deduction,
            Net_Salary,
            Basic_Percentage,
            Basic_For_PF,
            HRA_Percentage,
            PF_Employer_Percentage,
            PF_Employee_Percentage,
            ESIC_Employee_Percentage,
            ESIC_Employer_Percentage,
            Transport,
            Communication_Percentage,
            Apparel_Percentage,
            Research_Percentage,
            Medical,
            Leave_Travel_Percentage,
            Conveyance_Percentage,
            Laptop,
            Date_of_Leaving,
            Status
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
            @Annual_CTC,
            @Monthly_CTC,
            @Performance_Bonus,
            @Tenure_Bonus,
            @Total_CTC,
            @Basic,
            @House_Rent_Allowance,
            @PF_Employer_Contribution,
            @ESIC_Employer_Contribution,
            @Transport_Allowance,
            @Communication_Allowance,
            @Apparel_Allowance,
            @Research_Allowance,
            @Medical_Allowance,
            @Leave_Travel_Allowance,
            @Meal_Allowance_Sodexo_Coupons,
            @Conveyance_Allowance,
            @Special_Allowance,
            @Laptop_Allowance,
            @Gross_Salary,
            @PF_Employee_Deduction,
            @ESIC_Employee_Deduction,
            @Sodexo_Coupons_Deduction,
            @Net_Salary,
            @Basic_Percentage,
            @Basic_For_PF,
            @HRA_Percentage,
            @PF_Employer_Percentage,
            @PF_Employee_Percentage,
            @ESIC_Employee_Percentage,
            @ESIC_Employer_Percentage,
            @Transport,
            @Communication_Percentage,
            @Apparel_Percentage,
            @Research_Percentage,
            @Medical,
            @Leave_Travel_Percentage,
            @Conveyance_Percentage,
            @Laptop,
            @Date_of_Leaving,
            @Status

        )"

                OLEDBComm.Parameters.AddWithValue("S_No", CInt(newNumber) + 1)
                OLEDBComm.Parameters.AddWithValue("Emp_ID", CStr(CB_EmployeeID.Text))
                OLEDBComm.Parameters.AddWithValue("Employee_Name", StrConv(Trim(CB_EmployeeName.Text), VbStrConv.ProperCase))
                OLEDBComm.Parameters.AddWithValue("Company", Trim(CB_CompanyName.Text))
                OLEDBComm.Parameters.AddWithValue("Designation", Trim(txt_Designation.Text))
                OLEDBComm.Parameters.AddWithValue("DOJ", dtp_DOJ.Value)
                OLEDBComm.Parameters.AddWithValue("PF_No", CStr(Trim(txt_PF.Text)))
                OLEDBComm.Parameters.AddWithValue("UAN_No", CStr(Trim(txt_UAN.Text)))
                OLEDBComm.Parameters.AddWithValue("E_mail", CStr(Trim(txt_Email.Text)))
                OLEDBComm.Parameters.AddWithValue("Annual_CTC", CDbl(txt_Annual_CTC.Text))
                OLEDBComm.Parameters.AddWithValue("Monthly_CTC", CDbl(txt_MonthlyCTC.Text))
                OLEDBComm.Parameters.AddWithValue("Performance_Bonus", CDbl(txt_Performance_Bonus.Text))
                OLEDBComm.Parameters.AddWithValue("Tenure_Bonus", CDbl(txt_Tenure_Bonus.Text))
                OLEDBComm.Parameters.AddWithValue("Total_CTC", CDbl(txt_Total_CTC.Text))
                OLEDBComm.Parameters.AddWithValue("Basic", CDbl(txt_BasicSalary.Text))
                OLEDBComm.Parameters.AddWithValue("House_Rent_Allowance", CDbl(txt_HRA_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("PF_Employer_Contribution", CDbl(txt_PF_Employer.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employer_Contribution", CDbl(txt_ESIC_Employer.Text))
                OLEDBComm.Parameters.AddWithValue("Transport_Allowance", CDbl(txt_Transport_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Communication_Allowance", CDbl(txt_Communication_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Apparel_Allowance", CDbl(txt_Apparel_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Research_Allowance", CDbl(txt_Research_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Medical_Allowance", CDbl(txt_Medical_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Leave_Travel_Allowance", CDbl(txt_LeaveTravel_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Meal_Allowance_Sodexo_Coupons", CDbl(txt_Meal_Sodexo_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Conveyance_Allowance", CDbl(txt_Conveyance_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Special_Allowance", CDbl(txt_Special.Text))
                OLEDBComm.Parameters.AddWithValue("Laptop_Allowance", CDbl(txt_Laptop_Earnings.Text))
                OLEDBComm.Parameters.AddWithValue("Gross_Salary", CDbl(txt_GrossSalary.Text))
                OLEDBComm.Parameters.AddWithValue("PF_Employee_Deduction", CDbl(txt_PF_Employee_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employee_Deduction", CDbl(txt_ESIC_Employee_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Sodexo_Coupons_Deduction", CDbl(txt_Sodexo_Deductions.Text))
                OLEDBComm.Parameters.AddWithValue("Net_Salary", CDbl(txt_NetSalary.Text))
                OLEDBComm.Parameters.AddWithValue("Basic_Percentage", CDbl(Basic_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Basic_For_PF", CDbl(BasicForPF_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("HRA_Percentage", CDbl(HRA_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("PF_Employer_Percentage", CDbl(PF_Employer_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("PF_Employee_Percentage", CDbl(PF_Employee_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employee_Percentage", CDbl(ESIC_Employee_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("ESIC_Employer_Percentage", CDbl(ESIC_Employer_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Transport", CDbl(Transport_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Communication_Percentage", CDbl(Communication_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Apparel_Percentage", CDbl(Apparel_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Research_Percentage", CDbl(Research_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Medical", CDbl(Medical_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Leave_Travel_Percentage", CDbl(Leave_Travel_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Conveyance_Percentage", CDbl(Conveyance_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Laptop", CDbl(Laptop_Criteria.Text))
                OLEDBComm.Parameters.AddWithValue("Date_of_Leaving", dtp_DOL.Value)
                OLEDBComm.Parameters.AddWithValue("Status", CB_EmpStatus.Text)


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

    Private Sub FormAddNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            Dim dr As OleDbDataReader
            Dim cmd As String

            '----------------  add Employee Name in Combobox-----------
            cmd = "Select Distinct Company from MasterPayrollData"
            OLEDBComm.CommandText = cmd
            OLEDBConn.Open()
            dr = OLEDBComm.ExecuteReader
            'CB_CompanyName.Items.Clear()
            If dr.HasRows = True Then
                While dr.Read
                    CB_CompanyName.Items.Add(dr("Company"))
                End While
            Else
            End If
            dr.Close()

            OLEDBConn.Dispose()

            CB_EmpStatus.SelectedIndex = 0
            dtp_DOJ.Text = #1/1/1900#
            dtp_DOL.Text = #1/1/1900#

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
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

    Private Sub btn_GetDefault_Click(sender As Object, e As EventArgs) Handles btn_GetDefault.Click
        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            Dim cmd As String
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            cmd = "Select * from SalaryCriteria"
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

            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
            da.Dispose()
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

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()

        End Try
    End Sub

End Class