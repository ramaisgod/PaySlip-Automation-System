<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompanyDetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CompanyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Payroll = New WindowsApp1.DS_Payroll()
        Me.CompanyDetailsTableAdapter = New WindowsApp1.DS_PayrollTableAdapters.CompanyDetailsTableAdapter()
        Me.Label38 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.ShortNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CompanyDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1004, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'CompanyIDDataGridViewTextBoxColumn
        '
        Me.CompanyIDDataGridViewTextBoxColumn.DataPropertyName = "Company_ID"
        Me.CompanyIDDataGridViewTextBoxColumn.HeaderText = "Company_ID"
        Me.CompanyIDDataGridViewTextBoxColumn.Name = "CompanyIDDataGridViewTextBoxColumn"
        Me.CompanyIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompanyIDDataGridViewTextBoxColumn.Width = 80
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FullNameDataGridViewTextBoxColumn.Width = 300
        '
        'ShortNameDataGridViewTextBoxColumn
        '
        Me.ShortNameDataGridViewTextBoxColumn.DataPropertyName = "Short_Name"
        Me.ShortNameDataGridViewTextBoxColumn.HeaderText = "Short_Name"
        Me.ShortNameDataGridViewTextBoxColumn.Name = "ShortNameDataGridViewTextBoxColumn"
        Me.ShortNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShortNameDataGridViewTextBoxColumn.Width = 70
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 500
        '
        'CompanyDetailsBindingSource
        '
        Me.CompanyDetailsBindingSource.DataMember = "CompanyDetails"
        Me.CompanyDetailsBindingSource.DataSource = Me.DS_Payroll
        '
        'DS_Payroll
        '
        Me.DS_Payroll.DataSetName = "DS_Payroll"
        Me.DS_Payroll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyDetailsTableAdapter
        '
        Me.CompanyDetailsTableAdapter.ClearBeforeFill = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(426, 29)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(187, 26)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "Company Details"
        '
        'FormCompanyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1038, 550)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCompanyDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormCompanyDetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Payroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DS_Payroll As DS_Payroll
    Friend WithEvents CompanyDetailsBindingSource As BindingSource
    Friend WithEvents CompanyDetailsTableAdapter As DS_PayrollTableAdapters.CompanyDetailsTableAdapter
    Friend WithEvents CompanyIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label38 As Label
End Class
