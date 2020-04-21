Public Class SimplePayPlotDialog

    Public Property PlotPath As IO.DirectoryInfo

    Private Sub SimplePayPlotDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Atribuir Data de Hoje como Pagamento:
        DateTimePicker_PayDate.Value = Now.Date

        ''Data de Vencimento na Label:
        Dim MaturityDate As Date = _EXPENSE.Plot.MaturityDate(PlotPath)
        Label_MaturityDate.Text = "Vencimento: " & MaturityDate.Date

    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class