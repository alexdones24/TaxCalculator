<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        dgvTaxResult = New DataGridView()
        ColumnTax = New DataGridViewTextBoxColumn()
        ColumnTaxRate = New DataGridViewTextBoxColumn()
        ColumnTotal = New DataGridViewTextBoxColumn()
        lblIncome = New Label()
        lblTaxRate = New Label()
        txtIncome = New TextBox()
        txtTaxRate = New TextBox()
        btnTax = New Button()
        btnExit = New Button()
        btnReset = New Button()
        CType(dgvTaxResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTaxResult
        ' 
        dgvTaxResult.AllowUserToAddRows = False
        dgvTaxResult.AllowUserToDeleteRows = False
        dgvTaxResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTaxResult.Columns.AddRange(New DataGridViewColumn() {ColumnTax, ColumnTaxRate, ColumnTotal})
        dgvTaxResult.Location = New Point(32, 214)
        dgvTaxResult.Name = "dgvTaxResult"
        dgvTaxResult.ReadOnly = True
        dgvTaxResult.RowTemplate.Height = 25
        dgvTaxResult.Size = New Size(343, 202)
        dgvTaxResult.TabIndex = 0
        ' 
        ' ColumnTax
        ' 
        ColumnTax.HeaderText = "Income"
        ColumnTax.Name = "ColumnTax"
        ColumnTax.ReadOnly = True
        ' 
        ' ColumnTaxRate
        ' 
        ColumnTaxRate.HeaderText = "Tax Rate (%)"
        ColumnTaxRate.Name = "ColumnTaxRate"
        ColumnTaxRate.ReadOnly = True
        ' 
        ' ColumnTotal
        ' 
        ColumnTotal.HeaderText = "Total Tax"
        ColumnTotal.Name = "ColumnTotal"
        ColumnTotal.ReadOnly = True
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblIncome.Location = New Point(32, 31)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(149, 30)
        lblIncome.TabIndex = 1
        lblIncome.Text = "Enter Income:"
        ' 
        ' lblTaxRate
        ' 
        lblTaxRate.AutoSize = True
        lblTaxRate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTaxRate.Location = New Point(32, 94)
        lblTaxRate.Name = "lblTaxRate"
        lblTaxRate.Size = New Size(199, 30)
        lblTaxRate.TabIndex = 2
        lblTaxRate.Text = "Enter Tax Rate (%):"
        ' 
        ' txtIncome
        ' 
        txtIncome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtIncome.Location = New Point(181, 31)
        txtIncome.Name = "txtIncome"
        txtIncome.Size = New Size(194, 35)
        txtIncome.TabIndex = 3
        ' 
        ' txtTaxRate
        ' 
        txtTaxRate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtTaxRate.Location = New Point(231, 94)
        txtTaxRate.Name = "txtTaxRate"
        txtTaxRate.Size = New Size(144, 35)
        txtTaxRate.TabIndex = 4
        ' 
        ' btnTax
        ' 
        btnTax.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnTax.Location = New Point(210, 152)
        btnTax.Name = "btnTax"
        btnTax.Size = New Size(165, 41)
        btnTax.TabIndex = 5
        btnTax.Text = "Calculate Tax"
        btnTax.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Location = New Point(32, 152)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(64, 41)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(102, 152)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(102, 41)
        btnReset.TabIndex = 7
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(414, 450)
        Controls.Add(btnReset)
        Controls.Add(btnExit)
        Controls.Add(btnTax)
        Controls.Add(txtTaxRate)
        Controls.Add(txtIncome)
        Controls.Add(lblTaxRate)
        Controls.Add(lblIncome)
        Controls.Add(dgvTaxResult)
        Name = "Form1"
        Text = "Tax Calculator Windows Form"
        CType(dgvTaxResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTaxResult As DataGridView
    Friend WithEvents ColumnTax As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTaxRate As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblIncome As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtTaxRate As TextBox
    Friend WithEvents btnTax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
End Class
