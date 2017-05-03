Imports VBClassLibrary

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the focus for txtTotalGals
        txtTotalGals.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Variables for text boxes to hold values
        Dim totGals As Decimal = CDbl(txtTotalGals.Text)
        Dim numMiles As Decimal = CDbl(txtTotalMiles.Text)

        If IsValidData() Then
            ' Calculate the total MPG
            txtTotalMpg.Text = numMiles / totGals
        Else
            MessageBox.Show("You didn't enter a valid number. Try again", "Input Error")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all text boxes
        txtTotalGals.Clear()
        txtTotalMiles.Clear()
        txtTotalMpg.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window
        Me.Close()
    End Sub

    Private Function IsValidData() As Boolean
        Return WindowsValidator.IsDouble(txtTotalGals) AndAlso
            WindowsValidator.IsDouble(txtTotalMiles)
    End Function
End Class
