Imports System.IO
Imports System.Windows.Forms

Public Class ViewPlotSelectedDialog
    Public Property Plot_Path As DirectoryInfo
    Public Property isCreditCard As Boolean = False
    Private Sub ViewPlotSelectedDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Vigiar:
        FileWatcherSystem.Path = Plot_Path.FullName

        ''Arredondar Número da Parcela:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(ExpenseColorPanel, 2)

        ''Esconder Guia "Lançamentos":
        TabControl1.TabPages.Remove(TabPage_InvoicePostings)

        Dim IconSize = 38

        BlockIcon_Total.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Total.Image, IconSize)
        BlockIcon_Paid.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Paid.Image, IconSize)
        BlockIcon_RestToPay.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_RestToPay.Image, IconSize)
        BlockIcon_Discounts.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Discounts.Image, IconSize)
        BlockIcon_Interests.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Interests.Image, IconSize)
        BlockIcon_MaturityDate.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_MaturityDate.Image, IconSize)

        ''Ocultar/Exibir Status:
        StatusInfoToolStripMenuItem.Visible = My.Settings.showStatusOption


        ''Importar Informações da Parcela:
        ImportInformations()
    End Sub

    ''Número da Parcela:
    Protected Plot_Number As String

    ''Mês da Parcela:
    Protected Plot_Month As Integer

    ''Ano da Parcela:
    Protected Plot_Year As Integer

    ''Status da Parcela:
    Protected Plot_Status As Plot_CountSystem.StatusPlot
    Protected Plot_StatusText As String

    ''Não Incluir:
    Protected Plot_NoIncludes As Boolean

    ''Valor da Parcela:
    Protected Plot_Total As Decimal

    ''Valor Pago:
    Protected Plot_Paid As Decimal

    ''Valor Que Falta:
    Protected Plot_RestToPay As Decimal

    ''Data de Vencimento:
    Protected Plot_MaturityDate As Date

    ''Valor de Taxa:
    Protected Plot_InterestValue As Decimal

    ''Valor de Desconto:
    Protected Plot_DiscountsValue As Decimal

    ''Histórico de Pagamentos:
    Protected Plot_HistoricPayments As List(Of FileInfo)

    ''Comentários da Parcela:
    Protected Plot_Comments As List(Of FileInfo)

    Private Sub ImportInformations()
        ''Numero da Parcela:
        Plot_Number = _EXPENSE.Plot.Number(Plot_Path)
        PlotNumberLabel.Text = Plot_Number
        PlotNumberLabel.Left = ((ExpenseColorPanel.Width - PlotNumberLabel.Width) / 2) + 2

        ''Mês e Ano da Parcela:
        Plot_Month = _EXPENSE.Plot.Month(Plot_Path)
        Plot_Year = _EXPENSE.Plot.Year(Plot_Path)
        PlotDateLabel.Text = _FUNCTIONS.GetMonthName(Plot_Month) & " de " & Plot_Year

        ''Status da Parcela:
        Plot_Status = _EXPENSE.Plot.Status(Plot_Path)
        Plot_StatusText = _EXPENSE.Plot.StatusString(Plot_Path)
        ExpenseColorPanel.BackColor = _EXPENSE.Plot.StatusColor(Plot_Path)
        StatusPlotLabel.Text = Plot_StatusText

        ''Não incluir Valor:
        Plot_NoIncludes = _EXPENSE.Plot.NoIncludeValue(Plot_Path)
        Try : IncluirValorToolStripMenuItem.Checked = Plot_NoIncludes : Catch : End Try

        ''Nome da Despesa:
        Import_ExpenseName()

        ''Valor Total:
        Import_TotalValue()

        ''Valor Pago:
        Import_PaidValue()

        ''Valor Restante:
        Import_RestToPay()

        ''Data de Vencimento0:
        Import_MaturityDate()

        ''Valor de Juros:
        Import_InterestValue()

        ''Valor de Descontos:
        Import_DiscountsValue()

        ''Histórico de Pagamentos:
        Import_HistoricPayments()

        ''Comentários:
        Import_Comments()

        ''Modo Cartão de Crédito:
        If isCreditCard = True Then CreditCardMode()
    End Sub

    Sub Import_ExpenseName()
        ''Código da Despesa:
        Dim ExpenseCode = _EXPENSE.Plot.ExpenseOfPlot(Plot_Path)

        ''Nome da Despesa:
        Dim ExpenseName = _EXPENSE.Name(ExpenseCode)
        ''Cor de Destaque da Despesa:
        Dim ExpenseHightColor = _EXPENSE.HightColor(ExpenseCode)
        ''Icone da Despesa:
        Dim ExpenseIcon = _EXPENSE.Icon(ExpenseCode)

        If IsNothing(ExpenseIcon) Then
            BlockIcon_ExpenseName.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.BlockInformationIconsResource.Icon_BlockExpenseName_100x100, 38)
        Else
            ''Atribuir Cor de Destaque:
            BlockIcon_ExpenseName.BackColor = ExpenseHightColor
            _FUNCTIONS.Interfaces.MakeRoundedEdges(BlockIcon_ExpenseName, 3)

            ''Formatar Imagem:
            ExpenseIcon = _FUNCTIONS.Images.ChangeImageResolution(ExpenseIcon, 30)
            ExpenseIcon = _FUNCTIONS.Images.InvertColorFromImage(ExpenseIcon, Color.White)

            ''Atribuir Imagem:
            BlockIcon_ExpenseName.Image = ExpenseIcon
        End If

        ''Atribuir na Label [Nome da Despesa]:
        ExpenseNameLabel.Text = ExpenseName

    End Sub

    Sub Import_TotalValue()
        ''Obter Valor Total:
        Plot_Total = _EXPENSE.Plot.TotalValue(Plot_Path)
        ''Atribuir na Label:
        TotalLabel.Text = _FormatNumberStringToMoney(Plot_Total)
        ''Exibir Bloco:
        BLOCK_Total.Show()
    End Sub


    Sub Import_PaidValue()
        ''Obter Valor Pago:
        Plot_Paid = _EXPENSE.Plot.PaidValue(Plot_Path)
        ''Atribuir na Label:
        PaidLabel.Text = _FormatNumberStringToMoney(Plot_Paid)
        ''Exibir/Ocultar Bloco:      
        If Plot_Paid <= 0 Then BLOCK_Paid.Hide() Else BLOCK_Paid.Show()
    End Sub

    Sub Import_RestToPay()
        ''Obter Valor Que Falta:
        Plot_RestToPay = _EXPENSE.Plot.RestToPay(Plot_Path)
        ''Atribuir na Label:
        RestToPayLabel.Text = _FormatNumberStringToMoney(Plot_RestToPay)
        ''Exibir/Ocultar Bloco:      
        If Plot_RestToPay <= 0 Then BLOCK_RestToPay.Hide() Else BLOCK_RestToPay.Show()
    End Sub

    Sub Import_MaturityDate()
        ''Obter Data de Vencimento:
        Plot_MaturityDate = _EXPENSE.Plot.MaturityDate(Plot_Path)
        ''Atribuir na Label:
        MaturityDateLabel.Text = Plot_MaturityDate.Day & " de " & _FUNCTIONS.GetMonthName(Plot_MaturityDate.Month) & " de " & Plot_MaturityDate.Year
        ''Exibir Bloco:
        BLOCK_MaturityDate.Show()

        _EXPENSE.Plot.IsDue(Plot_Path)
    End Sub

    Sub Import_InterestValue()
        ''Obter Valor de Juros:
        Plot_InterestValue = _EXPENSE.Plot.InterestValue(Plot_Path)
        ''Atribuir na Label:
        InterestLabel.Text = _FormatNumberStringToMoney(Plot_InterestValue)
        ''Exibir/Ocultar Bloco:
        Select Case Plot_InterestValue : Case 0 : BLOCK_Interest.Hide() : Case Else : BLOCK_Interest.Show() : End Select
    End Sub


    Sub Import_DiscountsValue()
        ''Obter Valor de Juros:
        Plot_DiscountsValue = _EXPENSE.Plot.Discounts(Plot_Path)
        ''Atribuir na Label:
        DiscountsLabel.Text = _FormatNumberStringToMoney(Plot_DiscountsValue)
        ''Exibir/Ocultar Bloco:
        Select Case Plot_DiscountsValue : Case 0 : BLOCK_Discounts.Hide() : Case Else : BLOCK_Discounts.Show() : End Select
    End Sub

    Sub Import_HistoricPayments()
        ''Obter Histórico:
        Plot_HistoricPayments = _EXPENSE.Plot.GetHistoricPayment(Plot_Path)

        ''Limpar Lista:
        HistoricPaymentListPanel.Controls.Clear()

        ''Montar Lista:
        For Each HISTORIC As FileInfo In Plot_HistoricPayments
            Dim HistoricItem As HistoricPaymentItemControl = New HistoricPaymentItemControl
            HistoricItem.HistoricPaymentFile = HISTORIC
            HistoricPaymentListPanel.Controls.Add(HistoricItem)
        Next
        ''Caso a lista esteja zerada
        Try : If Plot_HistoricPayments.Count = 0 Then : HistoricPaymentListPanel.Controls.Add(Label_NoHistoricPayment) : End If : Catch : End Try

    End Sub

    Sub Import_Comments()
        ''Obter Lista de Comentários:
        Plot_Comments = _EXPENSE.Plot.GetComments(Plot_Path)

        ''Limpar Lista:
        CommentsListPanel.Controls.Clear()

        ''Montar Lista:
        For Each COMMENT As FileInfo In Plot_Comments
            Dim CommentItem As CommentItemControl = New CommentItemControl
            CommentItem.CommentFile = COMMENT
            CommentsListPanel.Controls.Add(CommentItem)
        Next

        ''Caso a Lista Esteja Zerada:
        If Plot_Comments.Count = 0 Then CommentsListPanel.Controls.Add(label_NoComments)
    End Sub

    Sub CreditCardMode()
        ''Guia de Informações:
        TabPage_PlotInformation.Text = "Fatura"

        ''Label "Nome da Despesa":
        Label_Despesa.Text = "Cartão de Crédito"

        ''Menu "Pagar Parcela":
        PagarToolStripMenuItem.Text = "Pagar Fatura                                        "

        ''Sem Histórico de Pagamentos:
        Label_NoHistoricPayment.Text = "Não existem pagamentos realizados nesta fatura..."

        ''"Data de Vencimento":
        AlterarDataToolStripMenuItem.Text = "Dia de Vencimento"

        ''Adicionar Guia de "Lançamentos":
        If Not TabControl1.TabPages.Contains(TabPage_InvoicePostings) Then TabControl1.TabPages.Add(TabPage_InvoicePostings)
    End Sub

    Private Sub MenuQuickOptions_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuQuickOptions_Button.MouseClick
        ContextMenuStrip_QuickOptions.Show(MenuQuickOptions_Button, Val(MenuQuickOptions_Button.Width - ContextMenuStrip_QuickOptions.Width), MenuQuickOptions_Button.Height)
    End Sub


    Private Sub PagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagarToolStripMenuItem.Click
        If Plot_RestToPay <= 0 Then
            'MessageBox.Show("Esta parcela já tem valor pago igual ou maior que o valor total. Você não pode lançar mais nenhum valor nela.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox("Esta parcela já está paga.", MsgBoxStyle.Exclamation, "XPEG Count")

        Else
            CallPayDialog()
        End If
    End Sub

    Sub CallPayDialog()
        Dim PayPlot As SimplePayPlotDialog = New SimplePayPlotDialog With {.PlotPath = Me.Plot_Path}

        If PayPlot.ShowDialog = DialogResult.OK Then
            Dim Pay_Value As Decimal = Plot_Total
            Dim Pay_Date As Date = PayPlot.DateTimePicker_PayDate.Value.Date
            'Dim Pay_Type = PayPlot.PaymentType
            Dim Pay_Comments As String = PayPlot.TextBox_PaymentComment.Text

            'If Pay_Type = REAJUSTES Then
            'Reajustar Valor
            'End If


            _EXPENSE.Plot.Pay(Plot_Path, Pay_Value, Pay_Date, 0, Pay_Comments)
            MsgBox("Pagamento realizado com sucesso!", MsgBoxStyle.Information, "XPEG Count")

        End If
    End Sub

    Private Sub EditarValorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarValorToolStripMenuItem.Click
        If Plot_RestToPay <= 0 Then
            MsgBox("Você não pode alterar o valor desta parcela, porque ela já se encontra paga.", MsgBoxStyle.Exclamation, "XPEG Count")
        Else
            Dim ChangeValue As New ChangePlotValueDialog
            ChangeValue.TextBox_Value.Text = Plot_Total
            If ChangeValue.ShowDialog = Windows.Forms.DialogResult.OK Then
                _INI.WriteIniFile(Plot_Path.FullName & "\plot.xcf", "PLOT", "value", ChangeValue.TextBox_Value.Text)
            End If
        End If
    
    End Sub

    Private Sub AlterarDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarDataToolStripMenuItem.Click
        Dim ChangeMaturityDate As New ChangeMaturityDayDialog
        ChangeMaturityDate.DateTimePicker_MaturityDate.Value = Plot_MaturityDate
        If isCreditCard = True Then
            ChangeMaturityDate.Label6.Text = "Dia de Vencimento"
            ChangeMaturityDate.DateTimePicker_MaturityDate.CustomFormat = "dd"
            ChangeMaturityDate.DateTimePicker_MaturityDate.ShowUpDown = True
        End If

        If ChangeMaturityDate.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ExpenseCode = _EXPENSE.Plot.ExpenseOfPlot(Plot_Path)
            Dim DatesUsed = _EXPENSE.Plots.DatesOfPlotsUsed(ExpenseCode)
            Dim NewMaturityDate As Date = ChangeMaturityDate.DateTimePicker_MaturityDate.Value.Date


            If DatesUsed.Contains(NewMaturityDate) Then
                MsgBox("Desculpe, mas a data escolhida, já está sendo utlizado por outra parcela.", MsgBoxStyle.Critical, "XPEG Count")
            Else
                _INI.WriteIniFile(Plot_Path.FullName & "\plot.xcf", "DATES", "maturity", NewMaturityDate)
                _INI.WriteIniFile(Plot_Path.FullName & "\plot.xcf", "DATES", "month", NewMaturityDate.Month)
                _INI.WriteIniFile(Plot_Path.FullName & "\plot.xcf", "DATES", "year", NewMaturityDate.Year)


                'If Plot_MaturityDate.Year <> NewMaturityDate.Year Xor Plot_MaturityDate.Month <> NewMaturityDate.Month Then
                Dim ParentF As ViewExpenseForm = _EXPENSE.GetForm(ExpenseCode) : ParentF.LoadExpense(True)
                '  End If

            End If
            
        End If

    End Sub

    Private Sub DescriçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescriçãoToolStripMenuItem.Click
        Dim NewComment As New NewCommentDialog
        If NewComment.ShowDialog = Windows.Forms.DialogResult.OK Then
            _EXPENSE.Plot.Comment.NewComment(Plot_Path, NewComment.TextBox_Title.Text, NewComment.TextBox_Comment.Text)
        End If
    End Sub


    Private Sub IncluirValorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncluirValorToolStripMenuItem.Click
        _EXPENSE.Plot.ChangeIncludeValue(Plot_Path, IncluirValorToolStripMenuItem.Checked)
    End Sub

    Private Sub ClonarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim ExpenseCode As String = _EXPENSE.Plot.ExpenseOfPlot(Plot_Path)
        Dim FirtsP = _EXPENSE.Plots.FirstPlot(ExpenseCode)
        Dim LastP = _EXPENSE.Plots.LastPlot(ExpenseCode)

        If FirtsP.FullName = LastP.FullName Then
            MsgBox("Você não pode excluir a única parcela da despesa.", MsgBoxStyle.Critical, "XPEG Count")
        Else
            Select Case MessageBox.Show("Deseja realmente remover essa parcela de sua despesa?" & vbNewLine & "Essa ação não pode ser desfeita!", "XPEG Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                Case Windows.Forms.DialogResult.Yes
                    FileWatcherSystem.EnableRaisingEvents = False
                    If _EXPENSE.Plot.Delete(Plot_Path) = True Then
                        MsgBox("Parcela foi removida com sucesso!", MsgBoxStyle.Information, "XPEG Count")
                        Me.Close()
                    Else
                        MsgBox("Ops, houve um erro ao tentar deletar a sua despesa.", MsgBoxStyle.Information, "XPEG Count")
                    End If
            End Select
        End If

      
    End Sub

    Private Sub FileWatcherSystem_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcherSystem.Changed
        '  If e.ChangeType = WatcherChangeTypes.Changed Then
        If Plot_Path.Exists Then ImportInformations()
        ' End If
    End Sub

    Private Sub CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem.Click
        MsgBox("O XPEG Count mudou e muito nessa versão e mudou para melhor!" & vbNewLine &
                "Agora seu sistema está mais inteligente que é capaz de identificar automáticamente o status de sua parcela e de sua despesa." & vbNewLine &
                "Por isso os recursos de ""Alteração de Status"" foram removidos.", MsgBoxStyle.Information)
        StatusInfoToolStripMenuItem.Visible = False
        My.Settings.showStatusOption = False : My.Settings.Save()
    End Sub

    Private Sub FeedBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedBackToolStripMenuItem.Click
        Dim FeedBack As New FeedBackDialog
        FeedBack.ShowDialog()
    End Sub
End Class
