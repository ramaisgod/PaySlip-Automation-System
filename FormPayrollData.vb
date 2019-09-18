Imports System.Data
Imports System.Data.OleDb
Public Class FormPayrollData
    Dim OLEDBConn As New OleDbConnection
    Dim OLEDBComm As New OleDbCommand
    Dim ConStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
    Private Sub FormPayrollData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollMasterDataSet.MasterPayrollData' table. You can move, or remove it, as needed.

        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            Dim dr As OleDbDataReader
            Dim cmd As String
            OLEDBConn.Open()
            '----------------  add Company Name in Combobox-----------
            cmd = "Select Distinct Company from MasterPayrollData"
            OLEDBComm.CommandText = cmd
            dr = OLEDBComm.ExecuteReader
            CB_CompanyName.Items.Clear()
            CB_CompanyName.Items.Add("ALL")
            If dr.HasRows = True Then
                While dr.Read
                    CB_CompanyName.Items.Add(dr("Company"))
                End While
            Else
            End If
            dr.Close()

            '----------------  add Company Name in Combobox-----------
            cmd = "Select Distinct Employee_Name from MasterPayrollData"
            OLEDBComm.CommandText = cmd
            dr = OLEDBComm.ExecuteReader
            CB_EmpName.Items.Clear()
            CB_EmpName.Items.Add("ALL")
            If dr.HasRows = True Then
                While dr.Read
                    CB_EmpName.Items.Add(dr("Employee_Name"))
                End While
            Else
            End If
            dr.Close()

            CB_CompanyName.SelectedIndex = 0
            CB_EmpName.SelectedIndex = 0
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()

            Me.MasterPayrollDataTableAdapter.Fill(Me.PayrollMasterDataSet.MasterPayrollData)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
        End Try
    End Sub

    Private Sub CB_CompanyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_CompanyName.SelectedIndexChanged
        Try
            OLEDBConn.ConnectionString = ConStr
            OLEDBComm.Connection = OLEDBConn
            Dim dr As OleDbDataReader
            Dim cmd As String

            '----------------  add Payment Month in Combobox-----------
            cmd = "Select Employee_Name from MasterPayrollData Where Company = '" & CB_CompanyName.Text & "'"
            OLEDBComm.CommandText = cmd
            OLEDBConn.Open()
            dr = OLEDBComm.ExecuteReader

            CB_EmpName.Items.Clear()
            CB_EmpName.Items.Add("ALL")
            If dr.HasRows = True Then
                While dr.Read
                    CB_EmpName.Items.Add(dr("Employee_Name"))
                    'CB_CriteriaMonth.Items.Add(dr("Payment_Month"))
                End While
            Else
            End If
            dr.Close()
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
        Catch ex As Exception

            OLEDBConn.Dispose()
        End Try

        Try
            If CB_CompanyName.Text = "" Then
                ' OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData", OLEDBConn)
            ElseIf CB_CompanyName.Text = "ALL" And CB_EmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData", OLEDBConn)
            ElseIf CB_CompanyName.Text <> "ALL" And CB_EmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Company='" & CB_CompanyName.Text & "'", OLEDBConn)
            ElseIf CB_CompanyName.Text = "ALL" And CB_EmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Employee_Name='" & CB_EmpName.Text & "'", OLEDBConn)
            Else
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Employee_Name='" & CB_EmpName.Text & "' and Company = " & "'" & CB_CompanyName.Text & "'", OLEDBConn)
            End If

            Dim DS As New DataSet
            OLEDBComm.CommandTimeout = 30
            Dim DA As New OleDb.OleDbDataAdapter(OLEDBComm.CommandText, ConStr)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            OLEDBConn.Dispose()
            '------------------------ Rows Count-------------------------
            Label_RowsCount.Text = DataGridView1.RowCount
            '------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
        End Try

    End Sub

    Private Sub CB_EmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_EmpName.SelectedIndexChanged
        Try

            If CB_CompanyName.Text = "" Then
                ' OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData", OLEDBConn)
            ElseIf CB_CompanyName.Text = "ALL" And CB_EmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData", OLEDBConn)
            ElseIf CB_CompanyName.Text <> "ALL" And CB_EmpName.Text = "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Company='" & CB_CompanyName.Text & "'", OLEDBConn)
            ElseIf CB_CompanyName.Text = "ALL" And CB_EmpName.Text <> "ALL" Then
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Employee_Name='" & CB_EmpName.Text & "'", OLEDBConn)
            Else
                OLEDBComm = New OleDb.OleDbCommand("SELECT * FROM MasterPayrollData WHERE Employee_Name='" & CB_EmpName.Text & "' and Company = " & "'" & CB_CompanyName.Text & "'", OLEDBConn)
            End If

            Dim DS As New DataSet
            OLEDBComm.CommandTimeout = 30
            Dim DA As New OleDb.OleDbDataAdapter(OLEDBComm.CommandText, ConStr)
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
            OLEDBConn.Dispose()
            '------------------------ Rows Count-------------------------
            Label_RowsCount.Text = DataGridView1.RowCount
            '------------------------------------------------------------
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OLEDBConn.Dispose()
            OLEDBComm.Dispose()
        End Try

    End Sub

    Private Sub Btn_Export2XL_Click(sender As Object, e As EventArgs) Handles Btn_Export2XL.Click
        Try
            Dim default_location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Payroll_Data_Export_On_" & DateTime.Now.ToString("dd-MMM-yyyy HH_mm_ss") & ".xlsx"
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
                .Sheets(1).Name = "PayrollData_" & CB_CompanyName.Text
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
End Class