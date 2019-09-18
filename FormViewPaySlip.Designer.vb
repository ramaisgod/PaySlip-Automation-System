<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewPaySlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCompany = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxEmpName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Button_SaveAsPDF = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Company :"
        '
        'ComboBoxCompany
        '
        Me.ComboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCompany.FormattingEnabled = True
        Me.ComboBoxCompany.Location = New System.Drawing.Point(332, 23)
        Me.ComboBoxCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCompany.Name = "ComboBoxCompany"
        Me.ComboBoxCompany.Size = New System.Drawing.Size(177, 26)
        Me.ComboBoxCompany.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Employee Name :"
        '
        'ComboBoxEmpName
        '
        Me.ComboBoxEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEmpName.FormattingEnabled = True
        Me.ComboBoxEmpName.Location = New System.Drawing.Point(651, 23)
        Me.ComboBoxEmpName.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEmpName.Name = "ComboBoxEmpName"
        Me.ComboBoxEmpName.Size = New System.Drawing.Size(222, 26)
        Me.ComboBoxEmpName.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Month :"
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Items.AddRange(New Object() {"November-2017", "December-2017", "January-2018", "Feb-2018", "Mar-2018", "Apr-2018", "May-2018", "Jun-2018", "Jul-2018", "Aug-2018", "Sep-2018", "Oct-2018", "Nov-2018", "Dec-2018", "Jan-2019", "Feb-2019", "Mar-2019"})
        Me.ComboBoxMonth.Location = New System.Drawing.Point(76, 23)
        Me.ComboBoxMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(160, 26)
        Me.ComboBoxMonth.TabIndex = 19
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(394, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(148, 26)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "View PaySlip"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMonth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxEmpName)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCompany)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(913, 61)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 124)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(913, 510)
        Me.CrystalReportViewer1.TabIndex = 63
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button_SaveAsPDF
        '
        Me.Button_SaveAsPDF.Location = New System.Drawing.Point(838, 24)
        Me.Button_SaveAsPDF.Name = "Button_SaveAsPDF"
        Me.Button_SaveAsPDF.Size = New System.Drawing.Size(87, 23)
        Me.Button_SaveAsPDF.TabIndex = 64
        Me.Button_SaveAsPDF.Text = "Save As PDF"
        Me.Button_SaveAsPDF.UseVisualStyleBackColor = True
        '
        'FormViewPaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(937, 670)
        Me.Controls.Add(Me.Button_SaveAsPDF)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label38)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(70, 10)
        Me.Name = "FormViewPaySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PaySlip"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCompany As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxEmpName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxMonth As ComboBox
    'Friend WithEvents CrystalReport1 As CrystalReport1
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button_SaveAsPDF As Button
End Class
