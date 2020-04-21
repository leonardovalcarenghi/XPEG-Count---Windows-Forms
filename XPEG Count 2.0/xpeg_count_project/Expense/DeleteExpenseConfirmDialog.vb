Imports System.Windows.Forms

Public Class DeleteExpenseConfirmDialog

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes : Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No : Me.Close()
    End Sub

    Public Property ExpenseCode As String
        Get
            Return Nothing
        End Get
        Set(value As String)
            ExpenseNameLabel.Text = _EXPENSE.Name(value)
            ExpenseCategoryLabel.Text = _CATEGORYS.GetName(_EXPENSE.Category(value))
            ExpenseValueLabel.Text = _StringToMoney(_EXPENSE.Values.Total(value))

            If _EXPENSE.isCreditCard(value) Then
                Label2.Text = "Cartão:"
                DeleteButton.Text = "&Excluir Cartão"
                ExpenseCategoryLabel.Text = "-" : Panel7.Enabled = False
            End If
        End Set
    End Property

    Private Sub DeleteExpenseConfirmDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Beep()
    End Sub
End Class
