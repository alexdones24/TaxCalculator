Imports System.Diagnostics.Tracing
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        ' Validate user input. Decimal is used in financial calculation
        Dim income As Decimal
        Dim taxRate As Decimal

        If Decimal.TryParse(txtIncome.Text, income) AndAlso Decimal.TryParse(txtTaxRate.Text, taxRate) Then
            ' Calculate tax
            Dim Tax As Decimal = (income * taxRate) / 100

            ' Display the calculated tax in the DataGridView
            dgvTaxResult.Rows.Add(income, taxRate, Tax)

        Else
            ' Implementing error handling
            MessageBox.Show("Please enter valid numeric values for income and tax rate.", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTaxResult.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtIncome.Text = ""
        txtTaxRate.Text = ""

    End Sub
End Class
