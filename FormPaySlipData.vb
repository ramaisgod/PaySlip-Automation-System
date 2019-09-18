Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportClass
Imports CrystalDecisions.Shared
Imports Microsoft.Office.Interop
Imports CrystalDecisions.ReportSource
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Microsoft.WindowsAPICodePack.Shell
Imports Microsoft.Office.Interop.Excel
Imports CrystalDecisions.Web


Public Class FormPayslipData
    Dim OLEDBConn As New OleDb.OleDbConnection
    Dim OLEDBComm As New OleDb.OleDbCommand
    Private Sub FormPayrollData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Payroll.PayrollData' table. You can move, or remove it, as needed.
        Me.PayrollDataTableAdapter.Fill(Me.DS_Payroll.PayrollData)

        '        Try
        Dim DR As OleDb.OleDbDataReader
            OLEDBConn.ConnectionString = WindowsApp1.My.Settings.PayrollConnectionString.ToString

            OLEDBComm.Connection = OLEDBConn
            OLEDBConn.Open()
            '------- Add List Item in Company
            OLEDBComm = New OleDb.OleDbCommand("SELECT Short_Name FROM CompanyDetails", OLEDBConn)
            OLEDBComm.CommandTimeout = 30
            DR = OLEDBComm.ExecuteReader()
            Me.ComboBoxCompany.Items.Clear()
            If DR.HasRows = True Then
                Me.ComboBoxCompany.Items.Add("ALL")
                While DR.Read()
                    Me.ComboBoxCompany.Items.Add(DR("Short_Name"))
                End While
            End If
            OLEDBComm.ResetCommandTimeout()
            DR.Close()
            '------- Add List Item in Company
            OLEDBComm = New OleDb.OleDbCommand("SELECT distinct Payment_Month FROM PayrollData", OLEDBConn)
            OLEDBComm.CommandTimeout = 30
            DR = OLEDBComm.ExecuteReader()
            Me.ComboBoxMonth.Items.Clear()
            If DR.HasRows = True Then
                Me.ComboBoxMonth.Items.Add("ALL")
                While DR.Read()
                    Me.ComboBoxMonth.Items.Add(DR("Payment_Month"))
                End While
            End If
            OLEDBComm.ResetCommandTimeout()
            DR.Close()

            OLEDBConn.Dispose()
            ComboBoxMonth.SelectedIndex = 0
            ComboBoxCompany.SelectedIndex = 0
        '       Catch ex As Exception
        '      MessageBox.Show(ex.Message)
        OLEDBConn.Dispose()
        '     End Try

        'Try
        '    Dim i As Long
        '    OLEDBConn.ConnectionString = WindowsApp1.My.Settings.PayrollConnectionString.ToString
        '    OLEDBComm.Connection = OLEDBConn
        '    OLEDBConn.Open()

        '    For i = 0 To DataGridView1.Rows.Count - 1

        '        OLEDBComm.CommandText = ("UPDATE PayrollData SET Net_Salary_In_Words = @Net_Salary_In_Words  Where S_No = " & DataGridView1.Rows.Item(i).Cells(0).Value)
        '        OLEDBComm.Parameters.Add("@Net_Salary_In_Words", OleDbType.Char).Value = ConvertNumberToWords(Trim(DataGridView1.Rows.Item(i).Cells(37).Value))
        '        OLEDBComm.ExecuteNonQuery()
        '        OLEDBComm.Parameters.Clear()
        '    Next
        '    OLEDBConn.Dispose()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    OLEDBConn.Dispose()
        'End Try

        'Me.PayrollDataTableAdapter.Fill(Me.PayrollDataSet.PayrollData)

    End Sub


    Private Sub Button_PaySlip_Click(sender As Object, e As EventArgs) Handles Button_PaySlip.Click
        Try
            If MessageBox.Show("Are you sure to send Payslip ?", "Confirmation !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Else
                Exit Sub
            End If

            Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn

            Dim DA As New OleDbDataAdapter
            Dim DS As New DataSet
            'Dim cmd As String
            Dim i As Long
            Dim count As Integer = 0
            Dim oApp, oMail As Object
            oApp = CreateObject("Outlook.Application")
            ProgressBar1.Visible = True
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = DataGridView1.RowCount - 1
            For i = 0 To DataGridView1.RowCount - 1
                If Not Trim(DataGridView1.Rows(i).Cells.Item(DataGridView1.ColumnCount - 1).Value) = "Active" Then
                    OLEDBConn.ConnectionString = ConnStr
                    OLEDBComm.Connection = OLEDBConn
                    OLEDBConn.Open()
                    OLEDBComm.CommandText = ("UPDATE PayrollData SET PaySlip_Status = @PaySlip_Status  Where S_No = " & Trim(DataGridView1.Rows.Item(i).Cells(0).Value))
                    OLEDBComm.Parameters.Add("@PaySlip_Status", OleDbType.Char).Value = "Not Sent"
                    OLEDBComm.ExecuteNonQuery()
                    OLEDBComm.Parameters.Clear()
                    OLEDBConn.Dispose()
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.Red
                ElseIf DataGridView1.Rows(i).Cells.Item(8).Value = "" Then
                    OLEDBConn.ConnectionString = ConnStr
                    OLEDBComm.Connection = OLEDBConn
                    OLEDBConn.Open()
                    OLEDBComm.CommandText = ("UPDATE PayrollData SET PaySlip_Status = @PaySlip_Status  Where S_No = " & Trim(DataGridView1.Rows.Item(i).Cells(0).Value))
                    OLEDBComm.Parameters.Add("@PaySlip_Status", OleDbType.Char).Value = "Not Sent"
                    OLEDBComm.ExecuteNonQuery()
                    OLEDBComm.Parameters.Clear()
                    OLEDBConn.Dispose()
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.Red
                ElseIf Not IO.File.Exists(Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf") Then
                    OLEDBConn.ConnectionString = ConnStr
                    OLEDBComm.Connection = OLEDBConn
                    OLEDBConn.Open()
                    OLEDBComm.CommandText = ("UPDATE PayrollData SET PaySlip_Status = @PaySlip_Status  Where S_No = " & Trim(DataGridView1.Rows.Item(i).Cells(0).Value))
                    OLEDBComm.Parameters.Add("@PaySlip_Status", OleDbType.Char).Value = "Payslip Not Found"
                    OLEDBComm.ExecuteNonQuery()
                    OLEDBComm.Parameters.Clear()
                    OLEDBConn.Dispose()
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.Red
                Else

                    'cmd = "SELECT * FROM PayrollData Where Company='" & DataGridView1.Rows(i).Cells.Item(3).Value & "' and Payment_Month = '" & DataGridView1.Rows(i).Cells.Item(9).Value & "' AND Employee_Name='" & DataGridView1.Rows(i).Cells.Item(2).Value & "'"

                    ''cmd = "SELECT * FROM PayrollData Where Company='" & DataGridView1.SelectedCells.Item(3).Value & "' and Payment_Month = '" & DataGridView1.SelectedCells.Item(9).Value & "' AND Employee_Name='" & DataGridView1.SelectedCells.Item(2).Value & "'"

                    'DS.Clear()
                    'OLEDBConn = New OleDbConnection(ConnStr)
                    'OLEDBConn.Open()
                    'OLEDBComm = New OleDbCommand(cmd, OLEDBConn)
                    'DA.SelectCommand = OLEDBComm
                    'DA.Fill(DS, "PayrollData")
                    'DA = New OleDbDataAdapter(OLEDBComm)

                    'If ComboBoxCompany.Text = "Carryage" Then
                    '    Dim report As New CrystalReport1
                    '    report.SetDataSource(DS)
                    '    FormPaySlip.CrystalReportViewer1.ReportSource = report

                    'ElseIf ComboBoxCompany.Text = "HandyTrain" Then
                    '    Dim report As New CrystalReport1_HandyTrain
                    '    report.SetDataSource(DS)
                    '    FormPaySlip.CrystalReportViewer1.ReportSource = report

                    'ElseIf ComboBoxCompany.Text = "Mobiefit" Then
                    '    Dim report As New CrystalReport1_Mobiefit
                    '    report.SetDataSource(DS)
                    '    FormPaySlip.CrystalReportViewer1.ReportSource = report

                    'ElseIf ComboBoxCompany.Text = "MondeArt" Then
                    '    Dim report As New CrystalReport1_MondeArt
                    '    report.SetDataSource(DS)
                    '    FormPaySlip.CrystalReportViewer1.ReportSource = report

                    'ElseIf ComboBoxCompany.Text = "Seynse" Then
                    '    Dim report As New CrystalReport1_Seynse
                    '    report.SetDataSource(DS)
                    '    FormPaySlip.CrystalReportViewer1.ReportSource = report
                    'End If

                    'DA.Dispose()
                    'DS.Dispose()
                    'OLEDBComm.Dispose()
                    'OLEDBConn.Dispose()

                    'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportClass
                    'CrReport = FormPaySlip.CrystalReportViewer1.ReportSource
                    'CrReport.ExportToDisk(ExportFormatType.PortableDocFormat, Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf") '"E:\MyProject\PaySlip Automation System\crystalExport.pdf"

                    '-------------------Below code for send email via outlook ------------------------------------------------
                    oMail = oApp.CreateItem(Outlook.OlItemType.olMailItem)
                    Dim FirstName As String() = StrConv(Trim(DataGridView1.Rows(i).Cells.Item(2).Value), vbProperCase).Split(New Char() {" "})

                    With oMail
                        .To = DataGridView1.Rows(i).Cells.Item(8).Value
                        .Subject = "Salary Slip - " & DataGridView1.Rows(i).Cells.Item(9).Value & " - " & DataGridView1.Rows(i).Cells.Item(3).Value
                        .Body = "Hi " & FirstName(0) & "," & vbNewLine & vbNewLine & "Please find attached Salary slip for the month of " & DataGridView1.Rows(i).Cells.Item(9).Value & " for " & DataGridView1.Rows(i).Cells.Item(3).Value & "." & vbNewLine & vbNewLine & vbNewLine & vbNewLine & "Regards" & vbNewLine & "Payroll Team"
                        .Attachments.Add(Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf")
                        '.Display()
                        .send
                    End With
                    count = count + 1

                    OLEDBConn.ConnectionString = ConnStr
                    OLEDBComm.Connection = OLEDBConn
                    OLEDBConn.Open()
                    OLEDBComm.CommandText = ("UPDATE PayrollData SET PaySlip_Status = @PaySlip_Status  Where S_No = " & Trim(DataGridView1.Rows.Item(i).Cells(0).Value))
                    OLEDBComm.Parameters.Add("@PaySlip_Status", OleDbType.Char).Value = "Sent on " & Format(Date.Today, "dd-MMM-yyyy")
                    OLEDBComm.ExecuteNonQuery()
                    OLEDBComm.Parameters.Clear()
                    OLEDBConn.Dispose()
                    DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.Green
                End If
                ProgressBar1.Value = i

            Next i
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False

            oApp = Nothing
            oMail = Nothing

            DA.Dispose()
            DS.Dispose()
            OLEDBComm.Dispose()
            OLEDBConn.Close()

            ComboBoxEmpName_SelectedIndexChanged(sender, e)

            MessageBox.Show(count & " PaySlips has been sent successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProgressBar1.Visible = False
            ProgressBar1.Minimum = 0
        End Try
        '--------------- Refresh in Datagridview --------------------------

        'OLEDBConn.ConnectionString = ConnStr
        'OLEDBComm.Connection = OLEDBConn
        'OLEDBComm.Connection = OLEDBConn
        'OLEDBConn.Open()

        'If ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
        'ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Payment_Month='" & ComboBoxMonth.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
        'ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
        '    OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)

        'End If

        'OLEDBComm.CommandTimeout = 30
        'DA.SelectCommand = OLEDBComm
        'DA.Fill(DS)
        'DataGridView1.DataSource = DS.Tables(0)
        'OLEDBConn.Dispose()
        ''------------------------ Rows Count-------------------------
        'Label_RowsCount.Text =  DataGridView1.RowCount
        ''------------------------------------------------------------

        '------------------------------------------------------------------

    End Sub

    Private Sub Btn_BrowsePaySlipFolderPath_Click(sender As Object, e As EventArgs) Handles Btn_BrowsePaySlipFolderPath.Click

        'Dim fldr As New OpenFileDialog
        'fldr.ValidateNames = False
        'fldr.CheckFileExists = False
        'fldr.CheckPathExists = False
        'fldr.Title = "Select Folder"
        'fldr.FileName = "Folder Selection"
        'fldr.Filter = "SelectFolder|*.Folder" '"Text files (*.txt)|*.txt|All files (*.*)|*.*"'

        'Dim fldr As New FolderBrowserDialog
        'fldr.Description = "Select Destination Folder to Save PaySlip"
        'fldr.ShowNewFolderButton = True
        Dim fldr As New CommonOpenFileDialog
        fldr.IsFolderPicker = True

        If fldr.ShowDialog = DialogResult.OK Then
            Label_PaySlipPathMessage.Visible = True
            ' Label_PaySlipFolderPath.Text = fldr.SelectedPath & "\"
            Label_PaySlipFolderPath.Text = fldr.FileName & "\"
            Button_PaySlip.Enabled = True
            Btn_GenereatePayslip.Enabled = True
        Else
            Button_PaySlip.Enabled = False
            Btn_GenereatePayslip.Enabled = False
            'Label_PaySlipPathMessage.Visible = False
            Label_PaySlipFolderPath.Text = ""
            Exit Sub
        End If

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Me.Hide()
        FormViewPaySlip.MdiParent = FormMain
        FormViewPaySlip.Show()
        FormViewPaySlip.ComboBoxMonth.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(9).Value
        FormViewPaySlip.ComboBoxCompany.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(3).Value
        FormViewPaySlip.ComboBoxEmpName.Text = Me.DataGridView1.SelectedRows.Item(0).Cells(2).Value

        FormMain.btn_Payslip_Processing.BackColor = Color.Honeydew
        FormMain.btn_Add_New.BackColor = Color.Honeydew
        FormMain.btn_View_PaySlip.BackColor = Color.Honeydew
        FormMain.Btn_SalaryDetails.BackColor = Color.Honeydew
        FormMain.btn_View_PaySlip.BackColor = SystemColors.GradientInactiveCaption

    End Sub

    Private Sub DataGridView1_DataSourceChanged(sender As Object, e As EventArgs) Handles DataGridView1.DataSourceChanged
        '------------------------------- Datagridview color formatting -----------------------------------------------------
        DataGridView1.RowsDefaultCellStyle.BackColor = Nothing
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(DataGridView1.ColumnCount - 1, i).Value <> "Active" Then
                    ' FormPayrollData.DataGridView1.Item(FormPayrollData.DataGridView1.ColumnCount - 1, i).Style.BackColor = Color.OrangeRed
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles DataGridView1.Sorted
        '------------------------------- Datagridview color formatting -----------------------------------------------------
        DataGridView1.RowsDefaultCellStyle.BackColor = Nothing
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Item(DataGridView1.ColumnCount - 1, i).Value <> "Active" Then
                    ' FormPayrollData.DataGridView1.Item(FormPayrollData.DataGridView1.ColumnCount - 1, i).Style.BackColor = Color.OrangeRed
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Btn_GenereatePayslip_Click(sender As Object, e As EventArgs) Handles Btn_GenereatePayslip.Click
        'Try

        Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn

            Dim DA As New OleDbDataAdapter
            Dim DS As New DataSet
            Dim cmd As String
            Dim i As Long
            Dim count As Integer = 0
            ProgressBar1.Visible = True
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = DataGridView1.RowCount - 1
        For i = 0 To DataGridView1.RowCount - 1
            If Not Trim(DataGridView1.Rows(i).Cells.Item(DataGridView1.ColumnCount - 1).Value) = "Active" Then
                DataGridView1.Rows.Item(i).DefaultCellStyle.BackColor = Color.Red
            Else

                cmd = "SELECT * FROM PayrollData Where Company='" & DataGridView1.Rows(i).Cells.Item(3).Value & "' and Payment_Month = '" & DataGridView1.Rows(i).Cells.Item(9).Value & "' AND Employee_Name='" & DataGridView1.Rows(i).Cells.Item(2).Value & "'"

                'cmd = "SELECT * FROM PayrollData Where Company='" & DataGridView1.SelectedCells.Item(3).Value & "' and Payment_Month = '" & DataGridView1.SelectedCells.Item(9).Value & "' AND Employee_Name='" & DataGridView1.SelectedCells.Item(2).Value & "'"

                DS.Clear()
                OLEDBConn = New OleDbConnection(ConnStr)
                OLEDBConn.Open()
                OLEDBComm = New OleDbCommand(cmd, OLEDBConn)
                DA.SelectCommand = OLEDBComm
                DA.Fill(DS, "PayrollData")
                DA = New OleDbDataAdapter(OLEDBComm)
                Dim report As New ReportDocument

                If Trim(DataGridView1.Rows(i).Cells.Item(3).Value) = "Carryage" Then
                    'Dim report As New CrystalReport1
                    report.Load("Reports/CrystalReport1.rpt")
                    report.SetDataSource(DS)
                    FormViewPaySlip.CrystalReportViewer1.ReportSource = report

                ElseIf Trim(DataGridView1.Rows(i).Cells.Item(3).Value) = "HandyTrain" Then
                    'Dim report As New CrystalReport1_HandyTrain
                    report.Load("Reports/CrystalReport1_HandyTrain.rpt")
                    report.SetDataSource(DS)
                    FormViewPaySlip.CrystalReportViewer1.ReportSource = report

                ElseIf Trim(DataGridView1.Rows(i).Cells.Item(3).Value) = "Mobiefit" Then
                    'Dim report As New CrystalReport1_Mobiefit
                    report.Load("Reports/CrystalReport1_Mobiefit.rpt")
                    report.SetDataSource(DS)
                    FormViewPaySlip.CrystalReportViewer1.ReportSource = report

                ElseIf Trim(DataGridView1.Rows(i).Cells.Item(3).Value) = "MondeArt" Then
                    'Dim report As New CrystalReport1_MondeArt
                    report.Load("Reports/CrystalReport1_MondeArt.rpt")
                    report.SetDataSource(DS)
                    FormViewPaySlip.CrystalReportViewer1.ReportSource = report

                ElseIf Trim(DataGridView1.Rows(i).Cells.Item(3).Value) = "Seynse" Then
                    'Dim report As New CrystalReport1_Seynse
                    report.Load("Reports/CrystalReport1_Seynse.rpt")
                    report.SetDataSource(DS)
                    FormViewPaySlip.CrystalReportViewer1.ReportSource = report
                End If

                DA.Dispose()
                '                    DS.Dispose()
                OLEDBComm.Dispose()
                OLEDBConn.Dispose()

                '------------close opended file ---------------


                'IO.File.Open(Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf", mode:=IO.FileMode.Open).Close()
                '---------------------------------------------
                Dim CrReport As New ReportClass
                FormViewPaySlip.Show()
                FormViewPaySlip.Hide()

                CrReport = FormViewPaySlip.CrystalReportViewer1.ReportSource
                CrReport.ExportToDisk(ExportFormatType.PortableDocFormat, Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf") '"E:\MyProject\PaySlip Automation System\crystalExport.pdf"
                CrReport.ExportToStream(ExportFormatType.PortableDocFormat)
                count = count + 1
                OLEDBConn.Dispose()



            End If
            ProgressBar1.Value = i

        Next i

        FormViewPaySlip.Close()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
            DA.Dispose()
            DS.Dispose()
            OLEDBComm.Dispose()
            OLEDBConn.Close()

            ComboBoxEmpName_SelectedIndexChanged(sender, e)


            MessageBox.Show(count & " PaySlips has been generated successfully !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    ProgressBar1.Visible = False
        '    ProgressBar1.Minimum = 0
        'End Try

    End Sub

    Private Sub Btn_Export2XL_Click(sender As Object, e As EventArgs) Handles Btn_Export2XL.Click
        Try
            Dim default_location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Payslip_Data_Export_On_" & DateTime.Now.ToString("dd-MMM-yyyy HH_mm_ss") & ".xlsx"
            'Creating dataset to export
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
            Next
            'add rows to the table
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridView1.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    dr1(j) = DataGridView1.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            excel.Visible = False
            excel.UserControl = True

            wBook = excel.Workbooks.Add(System.Reflection.Missing.Value)
            wSheet = wBook.Sheets("sheet1")
            'excel.Sheets("Sheet1").EntireColumn.AutoFit()
            'excel.Range("A50:I50").EntireColumn.AutoFit()
            With wBook
                .Sheets("Sheet1").Select()
                .Sheets(1).Name = ComboBoxMonth.Text & "_" & ComboBoxCompany.Text
            End With

            Dim dt As System.Data.DataTable = dset.Tables(0)
            'wSheet.Cells(1).value = "Recruitment Data"


            For j = 0 To DataGridView1.ColumnCount - 1
                wSheet.Cells(1, j + 1).value = DataGridView1.Columns(j).HeaderText
                wSheet.Cells(1, j + 1).interior.color = Color.LightCyan
                wSheet.Cells(1, j + 1).Font.Bold = True

            Next j


            ProgressBar2.Minimum = 0
            ProgressBar2.Maximum = DataGridView1.RowCount
            ProgressBar2.Show()
            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    wSheet.Cells(i + 2, j + 1).value = DataGridView1.Rows(i).Cells(j).Value.ToString
                Next j
                ProgressBar2.Value = i
            Next i

            wSheet.Columns.AutoFit()
            wSheet.Cells.WrapText = False
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(default_location) Then
                System.IO.File.Delete(default_location)
            End If

            wBook.SaveAs(default_location)
            excel.Workbooks.Open(default_location)
            excel.Visible = True

            ProgressBar2.Value = 0
            ProgressBar2.Hide()

            'MessageBox.Show("Successful")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
        End Try
    End Sub


    Private Sub ComboBoxEmpName_SelectedIndexChanged(sender, e) Handles ComboBoxEmpName.SelectedIndexChanged
        Try
            Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn
            OLEDBConn.Open()

            If ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Payment_Month='" & ComboBoxMonth.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text <> "ALL" AndAlso ComboBoxEmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData Where Employee_Name = '" & ComboBoxEmpName.Text & "' and Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)

            End If

            Dim DS As New DataSet
            OLEDBComm.CommandTimeout = 30
            Dim DA As New OleDb.OleDbDataAdapter(OLEDBComm.CommandText, ConnStr)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            OLEDBConn.Dispose()
            '------------------------ Rows Count-------------------------
            Label_RowsCount.Text = DataGridView1.RowCount
            '------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBoxCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompany.SelectedIndexChanged
        Try
            ComboBoxEmpName.SelectedIndex = -1

            Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn
            If ComboBoxCompany.Text = "" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData WHERE Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData WHERE Payment_Month='" & ComboBoxMonth.Text & "'", OLEDBConn)
            Else
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData WHERE Payment_Month='" & ComboBoxMonth.Text & "' and Company = " & "'" & ComboBoxCompany.Text & "'", OLEDBConn)
            End If

            Dim DS As New DataSet
            OLEDBComm.CommandTimeout = 30
            Dim DA As New OleDb.OleDbDataAdapter(OLEDBComm.CommandText, ConnStr)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            OLEDBConn.Close()
            '------------------------ Rows Count-------------------------
            Label_RowsCount.Text = DataGridView1.RowCount
            '------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OLEDBConn.Dispose()
        End Try

        Try
            Dim DR As OleDb.OleDbDataReader
            OLEDBConn.ConnectionString = WindowsApp1.My.Settings.PayrollConnectionString.ToString

            OLEDBComm.Connection = OLEDBConn
            OLEDBConn.Open()
            '------- Add List Item in Employee Name
            If ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT Employee_Name FROM PayrollData", OLEDBConn)
            ElseIf ComboBoxCompany.Text <> "ALL" And ComboBoxMonth.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT Employee_Name FROM PayrollData Where Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            ElseIf ComboBoxCompany.Text = "ALL" And ComboBoxMonth.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT Employee_Name FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "'", OLEDBConn)
            Else
                OLEDBComm = New OleDb.OleDbCommand("SELECT Employee_Name FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            End If

            OLEDBComm.CommandTimeout = 30
            ComboBoxEmpName.Items.Clear()
            ComboBoxEmpName.SelectedIndex = -1
            ComboBoxEmpName.Text = ""
            DR = OLEDBComm.ExecuteReader()
            Me.ComboBoxEmpName.Items.Clear()
            If DR.HasRows = True Then
                Me.ComboBoxEmpName.Items.Add("ALL")
                While DR.Read()
                    Me.ComboBoxEmpName.Items.Add(DR("Employee_Name"))
                End While
            End If
            OLEDBComm.ResetCommandTimeout()
            OLEDBConn.Dispose()
            ComboBoxEmpName.SelectedIndex = 0
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
        End Try

    End Sub

    Private Sub ComboBoxMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMonth.SelectedIndexChanged
        Try
            ComboBoxCompany.SelectedIndex = -1
            ComboBoxEmpName.SelectedIndex = -1

            Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn
            If ComboBoxMonth.Text = "" Then
                'OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
            ElseIf ComboBoxMonth.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData", OLEDBConn)
            Else
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM PayrollData WHERE  Payment_Month = " & "'" & ComboBoxMonth.Text & "'", OLEDBConn)
            End If

            Dim DS As New DataSet
            OLEDBComm.CommandTimeout = 30
            Dim DA As New OleDb.OleDbDataAdapter(OLEDBComm.CommandText, ConnStr)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            OLEDBConn.Close()
            '------------------------ Rows Count-------------------------
            Label_RowsCount.Text = DataGridView1.RowCount
            '------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OLEDBConn.Dispose()
        End Try
    End Sub
End Class