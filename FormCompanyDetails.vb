Public Class FormCompanyDetails
    Private Sub FormCompanyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Payroll.CompanyDetails' table. You can move, or remove it, as needed.
        Me.CompanyDetailsTableAdapter.Fill(Me.DS_Payroll.CompanyDetails)

    End Sub
End Class