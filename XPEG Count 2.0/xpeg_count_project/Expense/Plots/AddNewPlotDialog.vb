Imports System.Windows.Forms

Public Class AddNewPlotDialog

    Public ExpenseCode As String
    Public isCreditCard As Boolean

    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Focar no Controle:
        NewPlotValue_TextBox.Focus() : NewPlotValue_TextBox.Select()

        ''Adaptar Para Cartão de Crédito:
        If isCreditCard = True Then
            '   Label_TotalDaDespesa
        End If
    End Sub


    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        CheckFields()
    End Sub

    Private Sub CheckFields()
        If NewPlotValue_TextBox.Text = Nothing Then
            MsgBox("Digite o valor de sua nova parcela.", MsgBoxStyle.Critical, "XPEG Count")
        Else
            If Not IsNumeric(NewPlotValue_TextBox.Text) Then
                MsgBox("Digite um valor válido para a parcela.", MsgBoxStyle.Critical, "XPEG Count")
            Else
                If NewPlotValue_TextBox.Text <= 0 Then
                    MsgBox("Digite um valor válido para a parcela.", MsgBoxStyle.Critical, "XPEG Count")
                Else
                    If _EXPENSE.Plots.DatesOfPlotsUsed(ExpenseCode).Contains(NewPlotMaturityDate_DateTimePicker.Value.Date) Then
                        MsgBox("Já existe uma outra parcela com essa mesma data de vencimento." & vbNewLine & "Por favor, escolha outra.", MsgBoxStyle.Critical, "XPEG Count")
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub
End Class
