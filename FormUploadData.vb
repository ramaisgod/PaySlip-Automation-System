Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel
Public Class FormUploadData
    Private Sub FormUploadData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Payroll.PayrollData' table. You can move, or remove it, as needed.
        Me.PayrollDataTableAdapter.Fill(Me.DS_Payroll.PayrollData)

        Label_RowsCount.Text = "Rows Count = " & DataGridView1.RowCount
    End Sub

    Private Sub Btn_Format_Click(sender As Object, e As EventArgs) Handles Btn_Format.Click
        Try
            'FilePath = Path.GetTempPath.ToString & "RecruitmentDataExport_" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & ".xls"

            'Dim default_location As String = Path.GetTempPath.ToString & "Recruitment_Applications_DataExport_" & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & ".xlsx"
            Dim default_location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\PayrollDataFormat.xlsx"

            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'add column to that table
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
            Next

            Dim excel As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            excel.Visible = False
            excel.UserControl = True

            wBook = excel.Workbooks.Add(System.Reflection.Missing.Value)
            wSheet = wBook.Sheets("sheet1")
            'excel.Range("A50:I50").EntireColumn.AutoFit()
            'With wBook
            '    .Sheets("Sheet1").Select()
            '    .Sheets(1).Name = "PayrollData"
            'End With

            For j = 0 To DataGridView1.ColumnCount - 1
                wSheet.Cells(1, j + 1).value = DataGridView1.Columns(j).HeaderText
                wSheet.Cells(1, j + 1).interior.color = Color.LightCyan
                wSheet.Cells(1, j + 1).Font.Bold = True

            Next j

            wSheet.Columns.AutoFit()

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

            'MessageBox.Show("Successful")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_UploadData_Click(sender As Object, e As EventArgs) Handles Btn_UploadData.Click
        Try
            Dim ConStr As String = WindowsApp1.My.Settings.PayrollConnectionString.ToString
            Dim AccessDatabaseFilePath As String = Mid(ConStr, ConStr.IndexOf("Data Source=") + 13, Len(ConStr) - ConStr.IndexOf("Data Source="))

            Dim Access As String = AccessDatabaseFilePath

            Dim Excel As String = Label_SelectedFilePath.Text

            Dim connect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=""Excel 12.0 Xml;HRD=YES"""

            Dim cmd As New OleDbCommand

            Using conn As New OleDbConnection(connect)
                Using cmd 'As New OleDbCommand()
                    cmd.Connection = conn
                    cmd.CommandText = "INSERT INTO [MS Access;Database=" & Access & "].[PayrollData] SELECT * FROM [Sheet1$]"
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using


            Dim ds As New DataSet
            Dim con As OleDbConnection = New OleDbConnection(connect)
            Dim da As OleDbDataAdapter = New OleDbDataAdapter()
            cmd = New OleDbCommand()
            con.ConnectionString = connect
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM [Sheet1$]"
            da.SelectCommand = cmd
            con.Open()
            cmd.ExecuteNonQuery()
            da.Fill(ds, "Sheet1$")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Sheet1$"
            con.Dispose()
            Label_RowsCount.Text = "Rows Count = " & DataGridView1.RowCount
            MessageBox.Show("Data has been imported successfully. !!!")


        Catch e1 As Exception

            MessageBox.Show("Import Failed !!!" & e1.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try




    End Sub

    Private Sub Btn_BrowsePaySlipFolderPath_Click(sender As Object, e As EventArgs) Handles Btn_BrowsePaySlipFolderPath.Click
        Try
            Using FileDialog As New OpenFileDialog
                FileDialog.Title = "Select Payroll Data Excel File"
                FileDialog.Filter = "All Excel Files|*.xls;*.xlsx;*.xlsb;*.xlsm"

                If FileDialog.ShowDialog() <> DialogResult.OK Then
                    Label_SelectedFilePath.Text = "Not Selected"
                    Btn_UploadData.Enabled = False
                    Exit Sub
                Else
                    Label_SelectedFilePath.Text = FileDialog.FileName
                    Btn_UploadData.Enabled = True
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class