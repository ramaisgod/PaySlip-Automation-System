Public Class FormMain
    Private Sub btn_process_Click(sender As Object, e As EventArgs) Handles btn_View_PaySlip.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormViewPaySlip.MdiParent = Me
        FormViewPaySlip.Show()

        btn_View_PaySlip.BackColor = SystemColors.GradientInactiveCaption
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub Btn_DataBackup_Click(sender As Object, e As EventArgs) Handles Btn_SalaryDetails.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormSalaryDetails.MdiParent = Me
        FormSalaryDetails.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = SystemColors.GradientInactiveCaption
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub btn_PayrollData_Click(sender As Object, e As EventArgs) Handles btn_Payslip_Processing.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormPayslipData.MdiParent = Me
        FormPayslipData.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = SystemColors.GradientInactiveCaption
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

        Try
            For i As Integer = 0 To FormPayslipData.DataGridView1.Rows.Count - 1
                If FormPayslipData.DataGridView1.Item(FormPayslipData.DataGridView1.ColumnCount - 1, i).Value <> "Active" Then
                    ' FormPayrollData.DataGridView1.Item(FormPayrollData.DataGridView1.ColumnCount - 1, i).Style.BackColor = Color.OrangeRed
                    FormPayslipData.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_UploadPayrollData_Click(sender As Object, e As EventArgs) Handles btn_UploadPayrollData.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormUploadData.MdiParent = Me
        FormUploadData.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = SystemColors.GradientInactiveCaption

        Try
            For i As Integer = 0 To FormUploadData.DataGridView1.Rows.Count - 1
                If FormUploadData.DataGridView1.Item(FormUploadData.DataGridView1.ColumnCount - 1, i).Value <> "Active" Then
                    ' FormPayrollData.DataGridView1.Item(FormPayrollData.DataGridView1.ColumnCount - 1, i).Style.BackColor = Color.OrangeRed
                    FormUploadData.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Else
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_CompanyDetails_Click(sender As Object, e As EventArgs) Handles btn_CompanyDetails.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormCompanyDetails.MdiParent = Me
        FormCompanyDetails.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = SystemColors.GradientInactiveCaption
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub btn_Add_PayRoll_Click(sender As Object, e As EventArgs) Handles btn_Add_New.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormAddNew.MdiParent = Me
        FormAddNew.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = SystemColors.GradientInactiveCaption
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub Btn_SalaryStructure_Click(sender As Object, e As EventArgs) Handles Btn_SalaryStructure.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormSalaryStructure.MdiParent = Me
        FormSalaryStructure.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = SystemColors.GradientInactiveCaption
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = Color.Honeydew
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub btn_PayrollData_Click_1(sender As Object, e As EventArgs) Handles btn_PayrollData.Click
        For Each frm As Form In Me.MdiChildren
            'If frm.Name <> "FormTop" Then
            frm.Close()
            'Else
            'End If
        Next
        FormPayrollData.MdiParent = Me
        FormPayrollData.Show()

        btn_View_PaySlip.BackColor = Color.Honeydew
        btn_Payslip_Processing.BackColor = Color.Honeydew
        Btn_SalaryDetails.BackColor = Color.Honeydew
        Btn_SalaryStructure.BackColor = Color.Honeydew
        btn_Add_New.BackColor = Color.Honeydew
        btn_PayrollData.BackColor = SystemColors.GradientInactiveCaption
        btn_CompanyDetails.BackColor = Color.Honeydew
        btn_UploadPayrollData.BackColor = Color.Honeydew

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim screenHeight As Integer = My.Computer.Screen.Bounds.Height
        Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width

    End Sub
End Class