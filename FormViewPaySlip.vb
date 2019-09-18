Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument


Public Class FormViewPaySlip
    Dim OLEDBConn As New OleDb.OleDbConnection
    Dim OLEDBComm As New OleDb.OleDbCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DR As OleDb.OleDbDataReader
            OLEDBConn.ConnectionString = WindowsApp1.My.Settings.PayrollConnectionString.ToString

            OLEDBComm.Connection = OLEDBConn
            OLEDBConn.Open()
            '------- Add List Item in Company
            OLEDBComm = New OleDb.OleDbCommand("SELECT Short_Name FROM CompanyDetails", OLEDBConn)
            OLEDBComm.CommandTimeout = 30
            DR = OLEDBComm.ExecuteReader()
            If DR.HasRows = True Then
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
                'Me.ComboBoxMonth.Items.Add("ALL")
                While DR.Read()
                    Me.ComboBoxMonth.Items.Add(DR("Payment_Month"))
                End While
            End If
            OLEDBComm.ResetCommandTimeout()
            DR.Close()
            OLEDBConn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
        End Try

    End Sub



    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCompany.SelectedIndexChanged
        Try
            Dim DR As OleDb.OleDbDataReader
            OLEDBConn.ConnectionString = WindowsApp1.My.Settings.PayrollConnectionString.ToString

            OLEDBComm.Connection = OLEDBConn
            OLEDBConn.Open()
            '------- Add List Item in Employee Name
            OLEDBComm = New OleDb.OleDbCommand("SELECT Employee_Name FROM PayrollData Where Payment_Month = '" & ComboBoxMonth.Text & "' and Company='" & ComboBoxCompany.Text & "'", OLEDBConn)
            OLEDBComm.CommandTimeout = 30
            ComboBoxEmpName.Items.Clear()
            ComboBoxEmpName.SelectedIndex = -1
            ComboBoxEmpName.Text = ""
            DR = OLEDBComm.ExecuteReader()
            If DR.HasRows = True Then
                While DR.Read()
                    Me.ComboBoxEmpName.Items.Add(DR("Employee_Name"))
                End While
            End If
            OLEDBComm.ResetCommandTimeout()
            OLEDBConn.Dispose()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
        End Try

    End Sub

    Private Sub ComboBoxEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEmpName.SelectedIndexChanged


        Try

            OLEDBComm.Dispose()
            Dim ConnStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            OLEDBConn.ConnectionString = ConnStr
            OLEDBComm.Connection = OLEDBConn

            Dim DA As New OleDbDataAdapter
            Dim DS As New DataSet
            Dim cmd As String
            cmd = "SELECT * FROM PayrollData Where Company='" & ComboBoxCompany.Text & "' and Payment_Month = '" & ComboBoxMonth.Text & "' AND Employee_Name='" & ComboBoxEmpName.Text & "'"

            DS.Clear()

            OLEDBConn = New OleDbConnection(ConnStr)
            OLEDBConn.Open()
            OLEDBComm = New OleDbCommand(cmd, OLEDBConn)
            DA.SelectCommand = OLEDBComm

            DA.Fill(DS, "PayrollData")

            DA = New OleDbDataAdapter(OLEDBComm)
            Dim report As New ReportDocument

            'Dim path As String
            'path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)
            'Dim fullpath As String = path & "\slip.rpt "

            If ComboBoxCompany.Text = "Carryage" Then
                'Dim report As New CrystalReport1
                report.Load("Reports/CrystalReport1.rpt")
                ' report.Database.Tables(0).SetDataSource(DS.Tables(0))
                report.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = report

            ElseIf ComboBoxCompany.Text = "HandyTrain" Then
                'Dim report As New CrystalReport1_HandyTrain
                report.Load("Reports/CrystalReport1_HandyTrain.rpt")
                report.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = report
            ElseIf ComboBoxCompany.Text = "Mobiefit" Then
                'Dim report As New CrystalReport1_Mobiefit
                report.Load("Reports/CrystalReport1_Mobiefit.rpt")
                report.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = report
            ElseIf ComboBoxCompany.Text = "MondeArt" Then
                'Dim report As New CrystalReport1_MondeArt
                report.Load("Reports/CrystalReport1_MondeArt.rpt") 'E:\MyProject\PaySlip Automation System\PaySlip Automation System\CrystalReport1_MondeArt.rpt
                report.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = report

            ElseIf ComboBoxCompany.Text = "Seynse" Then
                'Dim report As New CrystalReport1_Seynse
                report.Load("Reports/CrystalReport1_Seynse.rpt")
                'report.Database.Tables(0).SetDataSource(DS.Tables(0))
                report.SetDataSource(DS)
                CrystalReportViewer1.ReportSource = report
            End If

            Dim path As String = "E:\MyProject\PaySlip Automation System\" & ComboBoxEmpName.Text & ".pdf"
            report.ExportToDisk(formatType:=CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, fileName:=path)
            MessageBox.Show("Payslip saved !!!")
            DA.Dispose()
            DS.Dispose()
            OLEDBComm.Dispose()
            OLEDBConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBComm.Dispose()
            OLEDBConn.Close()

        End Try


    End Sub

    Private Sub Button_SaveAsPDF_Click(sender As Object, e As EventArgs) Handles Button_SaveAsPDF.Click

        With CrystalReportViewer1
            .AllowedExportFormats = 1

            .ExportReport()
        End With


        'CrReport.ExportToDisk(ExportFormatType.PortableDocFormat, Label_PaySlipFolderPath.Text & "PaySlip_" & Trim(DataGridView1.Rows(i).Cells.Item(2).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(3).Value) & "_" & Trim(DataGridView1.Rows(i).Cells.Item(9).Value) & ".pdf") '"E:\MyProject\PaySlip Automation System\crystalExport.pdf"
        'CrReport.ExportToStream(ExportFormatType.PortableDocFormat)

    End Sub
End Class

