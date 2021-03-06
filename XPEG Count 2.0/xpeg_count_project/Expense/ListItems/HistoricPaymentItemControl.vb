﻿Imports System.IO

Public Class HistoricPaymentItemControl

    ''' <summary>
    ''' Arquivo do Histórico de Pagamento:
    ''' </summary>
    Public HistoricPaymentFile As FileInfo

    Private Sub HistoricPaymentItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Dock Top:
        Me.Dock = DockStyle.Top

        ''Background Transparent:
        Me.BackColor = Color.Transparent

        ''Fazer Controle Ficar Com Bordas Arredondadas:
        ' _FUNCTIONS.Interfaces.MakeRoundedEdges(BaseItemBackgroundPanel)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotStatusColorPanel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PaidValueLabel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(Btn_ShowQuickOptions, 2)

        ''Carregar Informações da Parcela:
        LoadInformations()
    End Sub

    ''Valor do Pagamento:
    Protected Historic_Value As Decimal
    ''Data do Pagamento:
    Protected Historic_Date As Date
    ''Tipo de Pagamento:
    Protected Historic_Type
    ''Comentários:
    Protected Historic_Comments As String

    Sub LoadInformations()
        ''Obter Valor do Pagamento:
        Historic_Value = _EXPENSE.Plot.Historic.Value(HistoricPaymentFile)
        PaidValueLabel.Text = _FormatNumberStringToMoney(Historic_Value)

        ''Obter Data do Pagamento:
        Historic_Date = _EXPENSE.Plot.Historic.PayDate(HistoricPaymentFile)
        PaymentDateLabel.Text = _TwoNumber(Historic_Date.Day) & " de " & _FUNCTIONS.GetMonthName(Historic_Date.Month) & " de " & Historic_Date.Year ' _DateByExtenso(Historic_Date)

        PaymentDayLabel.Text = "" '_TwoNumber(Historic_Date.Day)
        PaymentDayLabel.Left = (PlotStatusColorPanel.Width - PaymentDayLabel.Width) / 2

        '' ObterTipo de Pagamento:
        Historic_Type = _EXPENSE.Plot.Historic.Type(HistoricPaymentFile)

        ''Obter Comentários:
        Historic_Comments = _EXPENSE.Plot.Historic.Comments(HistoricPaymentFile)
    End Sub

  

    Private Sub Btn_ShowQuickOptions_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_ShowQuickOptions.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ContextMenuStrip_QuickOptions.Show(Btn_ShowQuickOptions, New Point(Btn_ShowQuickOptions.Width - ContextMenuStrip_QuickOptions.Width, Btn_ShowQuickOptions.Height))
        End If
    End Sub

    Private Sub Btn_ShowQuickOptions_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ShowQuickOptions.MouseEnter
        Btn_ShowQuickOptions.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub Btn_ShowQuickOptions_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ShowQuickOptions.MouseLeave
        Btn_ShowQuickOptions.BackColor = Color.Transparent
    End Sub


    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Select Case MessageBox.Show("Deseja realmente remover esse pagamento?" & vbNewLine & "Esta ação não pode ser desfeita!", "XPEG Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Case DialogResult.Yes
                If _EXPENSE.Plot.Historic.Delete(HistoricPaymentFile) = True Then
                    MsgBox("Pagamento removido com sucesso!", MsgBoxStyle.Information, "XPEG Count") : Me.Hide()
                Else
                    MsgBox("Houve um erro ao tentar remover esse pagamento da sua parcela..." & vbNewLine & "Tente novamente mais tarde...", MsgBoxStyle.Critical, "XPEG Count")
                End If
        End Select
    End Sub


    Private Sub BaseItemBackgroundPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseClick, PlotStatusColorPanel.MouseClick, PlotInformationsPanel.MouseClick, PaymentDayLabel.MouseClick, PaymentDateLabel.MouseClick, PaidValueLabel.MouseClick, ExpenseNameLabel.MouseClick, Col03_Panel.MouseClick, Col02_Panel.MouseClick, Col01_Panel.MouseClick, BaseItemBackgroundPanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Historic_Comments = "" Then
                MsgBox("Este Histórico de Pagamento não possui comentários.", MsgBoxStyle.Critical, "XPEG Count")
            Else
                Dim ViewComment As ViewCommentDialog = New ViewCommentDialog
                ViewComment.CommentTitleLabel.Text = "Comentário do Pagamento" : ViewComment.CommentTextLabel.Text = Historic_Comments
                ViewComment.ShowDialog()
            End If
        End If
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseDown, PlotStatusColorPanel.MouseDown, PlotInformationsPanel.MouseDown, PaymentDayLabel.MouseDown, PaymentDateLabel.MouseDown, PaidValueLabel.MouseDown, ExpenseNameLabel.MouseDown, Col03_Panel.MouseDown, Col02_Panel.MouseDown, Col01_Panel.MouseDown, BaseItemBackgroundPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then BaseItemBackgroundPanel.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseEnter(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseEnter, PlotStatusColorPanel.MouseEnter, PlotInformationsPanel.MouseEnter, PaymentDayLabel.MouseEnter, PaymentDateLabel.MouseEnter, PaidValueLabel.MouseEnter, ExpenseNameLabel.MouseEnter, Col03_Panel.MouseEnter, Col02_Panel.MouseEnter, Col01_Panel.MouseEnter, BaseItemBackgroundPanel.MouseEnter
        BaseItemBackgroundPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseLeave(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseLeave, PlotStatusColorPanel.MouseLeave, PlotInformationsPanel.MouseLeave, PaymentDayLabel.MouseLeave, PaymentDateLabel.MouseLeave, PaidValueLabel.MouseLeave, ExpenseNameLabel.MouseLeave, Col03_Panel.MouseLeave, Col02_Panel.MouseLeave, Col01_Panel.MouseLeave, BaseItemBackgroundPanel.MouseLeave
        BaseItemBackgroundPanel.BackColor = Color.Transparent
    End Sub
End Class
