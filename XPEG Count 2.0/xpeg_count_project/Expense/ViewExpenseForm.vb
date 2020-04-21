Imports System.IO

Public Class ViewExpenseForm

    ''' <summary>
    ''' Código da Despesa
    ''' </summary>
    Public EXPENSE_Code As String

    ''' <summary>
    ''' Diretório da Despesa
    ''' </summary>
    Public EXPENSE_Path As DirectoryInfo


    ''' <summary>
    ''' Diz se está despesa é um Cartão de Crédito
    ''' </summary>
    ''' <remarks></remarks>
    Protected isCreditCard As Boolean = False

    ''Nome da Despesa:
    Protected Expense_Name As String

    ''Descrição da Despesa
    Protected Expense_Description As String

    ''Icone da Depesa:
    Protected Expense_Icon As Image

    ''Cor de Destaque:
    Protected Expense_HightColor As Color

    ''Código da Categoria:
    Protected Expense_CategoryCode As String

    ''Nome da Categoria:
    Protected Expense_CategoryName As String

    ''Local da Compra:
    Protected Expense_Place As String

    ''Status da Despesa:
    Protected Expense_StatusText As String

    ''Valor Total:
    Protected Expense_Total As Decimal

    ''Valor Total (Sem inclusões):
    Protected Expense_TotalNoIncludes As Decimal

    ''Valor Pago:
    Protected Expense_Paid As Decimal

    ''Valor Restante:
    Protected Expense_RestToPay As Decimal

    ''Descontos da Despesa:
    Protected Expense_Discounts As Decimal

    ''Valor de Juros:
    Protected Expense_Interest As Decimal

    ''Porcentagem de Juros:
    Protected Expense_InterestPorcentage As Decimal

    ''Duração da Despesa:
    Protected Expense_Duration As String

    ''Data Inicial:
    Protected Expense_StartDate As Date

    ''Data Final:
    Protected Expense_EndDate As Date

    ''Número Total de Parcelas:
    Protected Expense_NumberOfPlots As Integer

    ''Numero de Parcelas Finalizadas:
    Protected Expense_NumberOfPlotsFinallized As Integer = 0

    ''Vinculado com:
    Protected Expense_LinkCreditCardCode As String

    ''Nome do Cartão Vinculado:
    Protected Expense_LinkCreditCardName As String

    ''Data da Compra:
    Protected Expense_BuyDate As Date

    ''Lista de Parcelas (Paths):
    Protected Expense_PlotsList As List(Of DirectoryInfo)

    Public Sub LoadExpense(Optional ByVal importPlots As Boolean = False)
        ''Nome da Despesa:
        Expense_Name = _EXPENSE.Name(EXPENSE_Code)
        ExpenseNameLabel.Text = Expense_Name
        Me.Text = Expense_Name

        ''Descrição da Despesa:
        Expense_Description = _EXPENSE.Description(EXPENSE_Code)
        ExpenseDescriptionLabel.Text = Expense_Description
        If Not Expense_Description = Nothing Then ExpenseNameLabel.Top = 2 : ExpenseDescriptionLabel.Top = 36 _
        Else ExpenseNameLabel.Top = (Panel5.Height - ExpenseNameLabel.Height) / 2 : ExpenseDescriptionLabel.Text = ""

        ''Icone da Despesa:
        Expense_Icon = _EXPENSE.Icon(EXPENSE_Code)
        If Not IsNothing(Expense_Icon) Then
            Expense_Icon = _FUNCTIONS.Images.InvertColorFromImage(Expense_Icon, Color.White)
            ExpenseIconPictureBox.Image = _FUNCTIONS.Images.ChangeImageResolution(Expense_Icon, 40)
            ExpenseColorPanel.Width = ExpenseColorPanel.Height
            _FUNCTIONS.Interfaces.MakeRoundedEdges(ExpenseColorPanel)
        Else
            ExpenseColorPanel.Width = 10
            ExpenseIconPictureBox.Image = Nothing
            _FUNCTIONS.Interfaces.MakeRoundedEdges(ExpenseColorPanel, 0)
        End If


        ''Cor de Destaque:
        Expense_HightColor = _EXPENSE.HightColor(EXPENSE_Code)
        ExpenseColorPanel.BackColor = Expense_HightColor

        ''Atribuir cor no Header e no Footer:
        If _EXPENSE.ApplyColorInHeader(EXPENSE_Code) = True Then
            HeaderPanel.BackColor = _FUNCTIONS.Interfaces.ColorTone(Expense_HightColor)

            StatusPanelBackGround.BackColor = _FUNCTIONS.Interfaces.ColorTone(Expense_HightColor)
            StatusSeparatorLinePanel.BackColor = Expense_HightColor
        Else
            HeaderPanel.BackColor = Color.FromArgb(250, 11, 23, 29)

            StatusPanelBackGround.BackColor = Color.FromArgb(16, 16, 16)
            StatusSeparatorLinePanel.BackColor = Color.FromArgb(30, 30, 30)
        End If

        ''Atribuir na Opção do Menu [Habilitar Cor no Header]:
        HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Checked = _EXPENSE.ApplyColorInHeader(EXPENSE_Code)

        ''Atricuir Cor na Barra de Progresso:
        ProgressBarCircle_ExpenseProgress.ProgressColour = Expense_HightColor
        'ProgressBarCircle_ExpenseProgress.BaseColour = _FUNCTIONS.Interfaces.ColorTone(Expense_HightColor)

        ''Categoria:
        Load_Category()

        ''Local da Compra:
        Expense_Place = _EXPENSE.BuyPlace(EXPENSE_Code)
        LocationLabel.Text = Expense_Place
        If Expense_Place = Nothing Then BLOCK_Location.Hide() Else BLOCK_Location.Show()

        ''Modo de Visualização:
        Select Case _EXPENSE.ModeView(EXPENSE_Code)
            Case Expense_CountSystem.ModeViewEnum.BlocksMode : BlockMode()
            Case Expense_CountSystem.ModeViewEnum.ListMode : ListMode()
        End Select

        ''Status da Despesa:
        Load_Status() '[SISTEMA NÃO PRONTO]

        ''Valor Total:
        Load_Total()

        ''Valor Pago:
        Load_Paid()

        ''Valor Restante:
        Load_RestToPay()

        ''Valor de Descontos:
        'Load_Discounts() [NÃO DISPONÍVEL NESSA VERSÃO]

        ''Valor e Taxas de Juros:
        'Load_Tax() [NÃO DISPONÍVEL NESSA VERSÃO]

        ''Duração:
        'Load_Duration() [COM BUG, ENTÃO NÃO EXIBIR]

        ''Data Inicial:
        Load_StartDate()

        ''Data Final:
        Load_EndDate()

        ''Numero de Parcelas:
        Load_NumberOfPlots()

        ''Vinculado com:
        'Load_LinkCredtCard() [SISTEMA NÃO PRONTO]

        ''Data da Compra:
        Load_BuyDate()

        ''Importar Lista de Parcelas:
        If importPlots = True Then Import_PlotsList()
    End Sub

    Sub Load_Category()
        ''Obter Código da Categoria:
        Expense_CategoryCode = _EXPENSE.Category(EXPENSE_Code)
        ''Verificar se é Cartão de Crédito:
        If Expense_CategoryCode = "XC.CATEGORY_CREDITCARD" Then isCreditCard = True : CreditCardMode() Else isCreditCard = False
        ''Obter Nome da Categoria:
        Expense_CategoryName = _CATEGORYS.GetName(Expense_CategoryCode)
        ''Atribuir na Label:
        CategoryLabel.Text = Expense_CategoryName
        ''Exibir Bloco:
        If isCreditCard = False Then BLOCK_Category.Show()
    End Sub

    Sub Load_Status()
        ''Obter Status da Parcela:
        Expense_StatusText = _EXPENSE.Status(EXPENSE_Code)
        ''Atribuir na Label:
        StatusLabel.Text = Expense_StatusText
        ''Exibir Block:
        BLOCK_Status.Show()
    End Sub

    Sub Load_Total()
        ''Obter Valor Total:
        Expense_Total = _EXPENSE.Values.Total(EXPENSE_Code, True)
        Expense_TotalNoIncludes = _EXPENSE.Values.Total(EXPENSE_Code, False)

        ''Atribuir na Label:
        TotalLabel.Text = _FormatNumberStringToMoney(Expense_Total)
        BLOCK_Total.Show()

        ''Verificar Valor Total Sem Inclusões:
        Select Case Expense_TotalNoIncludes
            Case 0 : TotalNoIncludeLabel.Text = "Nenhum Valor" : BLOCK_TotalNoIncludes.Show()
            Case Expense_Total : BLOCK_TotalNoIncludes.Hide()
            Case Else : TotalNoIncludeLabel.Text = _FormatNumberStringToMoney(Expense_TotalNoIncludes) : BLOCK_TotalNoIncludes.Show()
        End Select
    End Sub

    Sub Load_Paid()
        ''Obter Valor Pago:
        Expense_Paid = _EXPENSE.Values.Paid(EXPENSE_Code)
        ''Atribuir na Label:
        PaidLabel.Text = _FormatNumberStringToMoney(Expense_Paid)
        ''Exibir ou Ocultar Bloco:
        Select Case Expense_Paid : Case 0 : BLOCK_Paid.Hide() : Case Else : BLOCK_Paid.Show() : End Select
    End Sub

    Sub Load_RestToPay()
        ''Obter Valor Restante:
        Expense_RestToPay = _EXPENSE.Values.RestToPay(EXPENSE_Code)
        ''Atribuir na Label:
        RestToPayLabel.Text = _FormatNumberStringToMoney(Expense_RestToPay)
        ''Exibir ou Ocultar Bloco:
        Select Case Expense_RestToPay : Case Is < 0, 0 : BLOCK_RestToPay.Hide() : Case Else : BLOCK_RestToPay.Show() : End Select

        ''Complementar ProgressBar
        ProgressComplement()
    End Sub

    Sub ProgressComplement()
        ''Obter Porcentagem:
        Dim PorcentagePaid As Integer = _FUNCTIONS.GetPorcentage(Expense_Paid, Expense_Total)
        ''Atribuir
        ProgressBarCircle_ExpenseProgress.Value = PorcentagePaid
        PorcentProgressLabel.Text = _TwoNumber(PorcentagePaid)
        'PorcentagePaidLabel.Text = DashboardProgressBarCircle1.Value & "%"

        ''Exibir/Ocultar 'Despesa Finalizada'
        If PorcentagePaid = 100 Then ExpenseEndLabel.Show() Else ExpenseEndLabel.Hide()
    End Sub

    Sub Load_Discounts()
        ''Obter Valor de Descontos
        Expense_Discounts = _EXPENSE.Values.Discounts(EXPENSE_Code)
        ''Atribuir na Label:
        DiscountsLabel.Text = _FormatNumberStringToMoney(Expense_Discounts)
        ''Exibir ou Ocultar Bloco:
        Select Case Expense_Discounts : Case 0 : BLOCK_Discounts.Hide() : Case Else : BLOCK_Discounts.Show() : End Select
    End Sub

    Sub Load_Tax()
        ''Obter Valor de Juros Pagos:
        Expense_Interest = _EXPENSE.Values.InterestValue(EXPENSE_Code)
        ''Obter Taxa de Juros:
        Expense_InterestPorcentage = _EXPENSE.Values.InterestTax(EXPENSE_Code, ExpenseValues_CountSystem.TypeTaxEnum.PerDay)
        ''Atribuir na Label:
        InterestLabel.Text = _FormatNumberStringToMoney(Expense_Interest) '& " (" & Expense_InterestPorcentage & "%)"
        ''Exibir ou Ocultar Bloco:
        Select Case Expense_Interest : Case 0 : BLOCK_Interest.Hide() : Case Else : BLOCK_Interest.Show() : End Select
    End Sub

    Sub Load_Duration()
        ''Obter Duração da Despesa:
        Expense_Duration = _EXPENSE.Duration(EXPENSE_Code)
        ''Atribuir na Label:
        DurationLabel.Text = Expense_Duration
        ''Exibir Bloco:
        BLOCK_Duration.Show()
    End Sub

    Sub Load_StartDate()
        ''Obter Data Inicial:
        Expense_StartDate = _EXPENSE.StartDate(EXPENSE_Code)
        ''Atribuir da Label:
        StartDateLabel.Text = _FUNCTIONS.GetMonthName(Expense_StartDate.Month) & " de " & Expense_StartDate.Year
        ''Exibir Bloco:
        If isCreditCard = False Then BLOCK_StartDate.Show()
    End Sub

    Sub Load_EndDate()
        ''Obter Data Final:
        Expense_EndDate = _EXPENSE.EndDate(EXPENSE_Code)
        ''Atribuir da Label:
        EndDateLabel.Text = _FUNCTIONS.GetMonthName(Expense_EndDate.Month) & " de " & Expense_EndDate.Year
        ''Exibir Bloco:
        If isCreditCard = False Then BLOCK_EndDate.Show()
    End Sub


    Sub Load_NumberOfPlots()
        ''Obter Numero de Parcelas:
        Expense_NumberOfPlots = _EXPENSE.Plots.NumberOfPlots(EXPENSE_Code)

        ''Obter Numero de Parcelas Finalizadas:
        Expense_NumberOfPlotsFinallized = _EXPENSE.Plots.NumberOfPlotsFinallized(EXPENSE_Code)

        ''Atribuir na Label:
        If Expense_NumberOfPlotsFinallized = 0 Then
            PlotsCountLabel.Text = Expense_NumberOfPlots
        Else
            PlotsCountLabel.Text = Expense_NumberOfPlotsFinallized & " de " & Expense_NumberOfPlots & " pagas"
        End If


        ''Exibir Bloco:
        BLOCK_Plots.Show()
    End Sub

    Sub Load_LinkCredtCard()
        ''Obter Vinculo:
        Expense_LinkCreditCardCode = _EXPENSE.LinkCreditCard(EXPENSE_Code)
        ''Obter nome do Cartão:
        If Expense_LinkCreditCardCode <> Nothing Then Expense_LinkCreditCardName = _CREDITCARDS.GetName(Expense_LinkCreditCardCode)
        ''Atribuir nome na Label:
        LinkCardLabel.Text = Expense_LinkCreditCardName
        ''Exibir ou Ocultar Bloco:
        Select Case Expense_LinkCreditCardCode : Case Nothing : BLOCK_CardLink.Hide() : Case Else : BLOCK_CardLink.Show() : End Select
    End Sub

    Sub Load_BuyDate()
        ''Obter Data de Compra:
        Expense_BuyDate = _EXPENSE.BuyDate(EXPENSE_Code)
        ''Atribuir na Label:
        BuyDateLabel.Text = _DateByExtenso(Expense_BuyDate)
        ''Exibir Bloco:
        BLOCK_BuyDate.Show()
    End Sub

    Sub Import_PlotsList()
        ''Obter Parcelas:
        Expense_PlotsList = _EXPENSE.Plots.GetPlots(EXPENSE_Code)

        ''Limpar Lista de Parcela:
        PlotsFlowPanel.Controls.Clear()

        ''Adicionar Parcelas:
        For Each PLOT As DirectoryInfo In Expense_PlotsList
            Dim PlotItem As PlotItemControl = New PlotItemControl
            PlotItem.FormParent = Me
            PlotItem.isCreditCard = Me.isCreditCard
            PlotItem.ExpenseCode = EXPENSE_Code
            PlotItem.PlotPath = PLOT
            PlotsFlowPanel.Controls.Add(PlotItem)
        Next

        PlotsFlowPanel.Controls.Add(EmptyPanel)

    End Sub

    Sub CreditCardMode()
        ''Guia de Informações:
        TabPage_Informations.Text = "Cartão de Crédito"
        ''Guia de Parcelas:
        TabPage_Plots.Text = "Faturas"

        ''Desabilitar Opções do Menu:
        LocalToolStripMenuItem.Visible = False
        CategoriaToolStripMenuItem.Visible = False
        IconeToolStripMenuItem.Visible = False
        VincularComCartãoDeCréditoToolStripMenuItem.Visible = False

        ''Bloco "Parcelas":
        Label_Parcelas.Text = "Faturas"

        ''Bloco "Data da Compra":
        BLOCK_BuyDate.Hide()

        ''Desabilitar Botão "Adicionar Parcelas":
        AddNewPlot_QuickButton.Hide()

        ''Dabilitar Botão de Excluir Parcelas:
        DeletePlots_QuickButton.Hide()

        ''Desabilitar Botão de "Pagar Parcelas":
        PayPlots_QuickButton.Hide()

        ''Esconder Barra de Porcentagem:
        ProgressBarCircle_ExpenseProgress.Hide() : PorcentProgressLabel.Hide()
        BlockIcon_Status.Show()
    End Sub





    Function testCalls()
        'Nome da Despesa:
        _EXPENSE.Name(EXPENSE_Code)

        'Categoria:
        _EXPENSE.Category(EXPENSE_Code)

        'Descrição:
        _EXPENSE.Description(EXPENSE_Code)

        'Icon:
        _EXPENSE.Icon(EXPENSE_Code)

        'Cor de Destaque:
        _EXPENSE.HightColor(EXPENSE_Code)

        'Data Inicial:
        _EXPENSE.StartDate(EXPENSE_Code)

        'Data Final:
        _EXPENSE.EndDate(EXPENSE_Code)

        'Duração:
        _EXPENSE.Duration(EXPENSE_Code)

        'PARCELAS ------------------------------

        'Obter Lista de Parcelas da Despesa (Path):
        _EXPENSE.Plots.GetPlots(EXPENSE_Code) ' levar esta função para o escopo pricipal.

        'Primeira Parcela (Path):
        _EXPENSE.Plots.FirstPlot(EXPENSE_Code)

        'Última Parcela (Path):
        _EXPENSE.Plots.LastPlot(EXPENSE_Code)

        'Parcela Mais Cara (Path):
        _EXPENSE.Plots.HigherPlot(EXPENSE_Code)

        'Parcela Mais Barata (Path):
        _EXPENSE.Plots.LowerPlot(EXPENSE_Code)

        'Quantidade de Parcelas
        _EXPENSE.Plots.NumberOfPlots(EXPENSE_Code)

        'VALORES ------------------------------

        'Valor Total da Depesa:
        _EXPENSE.Values.Total(EXPENSE_Code, True)

        'Valor Pago na Despesa:
        _EXPENSE.Values.Paid(EXPENSE_Code, True)

        'Valor Que falta Para Quitar:
        _EXPENSE.Values.RestToPay(EXPENSE_Code)

        'Valor de Descontos:
        _EXPENSE.Values.Discounts(EXPENSE_Code)

        'Valor de Juros:
        _EXPENSE.Values.InterestValue(EXPENSE_Code)

        'Taxa de Juros:
        'EXPENSE.Values.InterestTax(EXPENSE_Code)




        '_EXPENSES.GetPlo
    End Function


    Sub ImportInfo_Category()
        'Código da Categoria:
        Expense_CategoryCode = _EXPENSE.Category(EXPENSE_Code)

        MsgBox("Despesa: " & EXPENSE_Code)

        'Nome da Categoria:
        Expense_CategoryName = _CATEGORYS.GetName(Expense_CategoryCode)

        'Atribuir na Variável:
        CategoryLabel.Text = Expense_CategoryName

        'Posição da Label
        If Not Expense_CategoryCode = "XC.CATEGORY_CREDITCARD" Then
            CategoryLabel.Top = 23
        Else
            CategoryLabel.Top = (BLOCK_Category.Height - CategoryLabel.Height) / 2
        End If


    End Sub



    Private Sub MenuQuickOptions_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuQuickOptions_Button.MouseClick
        ContextMenuStrip_QuickOptions.Show(MenuQuickOptions_Button, Val(MenuQuickOptions_Button.Width - ContextMenuStrip_QuickOptions.Width), MenuQuickOptions_Button.Height)
    End Sub

    Private Sub PersonalizarMenuDeAcessoRápidoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CustomQuickMenuDialog.ShowDialog()
    End Sub

 

    Private Sub ViewExpenseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' TabPageButton1.SelectThisPage()

        Dim IconSize = 38

        FileWatcherSystem.Path = _DIRECTORIES.ExpensesPath & "\" & EXPENSE_Code

        ' ImportInfo_Category()

        BlockIcon_Category.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Category.Image, IconSize)
        BlockIcon_Status.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Status.Image, IconSize)
        BlockIcon_Total.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Total.Image, IconSize)
        BlockIcon_TotalNoIncludes.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_TotalNoIncludes.Image, IconSize)
        BlockIcon_Paid.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Paid.Image, IconSize)
        BlockIcon_RestToPay.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_RestToPay.Image, IconSize)

        BlockIcon_Discounts.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Discounts.Image, IconSize)
        BlockIcon_Interests.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Interests.Image, IconSize)
        BlockIcon_Duration.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Duration.Image, IconSize)
        BlockIcon_StartDate.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_StartDate.Image, IconSize)
        BlockIcon_EndDate.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_EndDate.Image, IconSize)
        BlockIcon_Plots.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Plots.Image, IconSize)
        BlockIcon_Location.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_Location.Image, IconSize)
        BlockIcon_CardLink.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_CardLink.Image, IconSize)
        BlockIcon_BuyDate.Image = _FUNCTIONS.Images.ChangeImageResolution(BlockIcon_BuyDate.Image, IconSize)


        DeletePlots_QuickButton.ButtonIcon = _FUNCTIONS.Images.ChangeImageResolution(DeletePlots_QuickButton.ButtonIcon, 16)

        ChangeMaturidyDay_QuickButton.ButtonIcon = _FUNCTIONS.Images.InvertColorFromImage(ChangeMaturidyDay_QuickButton.ButtonIcon, Color.White)
        AddNewPlot_QuickButton.ButtonIcon = _FUNCTIONS.Images.InvertColorFromImage(AddNewPlot_QuickButton.ButtonIcon, Color.White)

        'FiledExpense_QuickButton.ButtonIcon = _FUNCTIONS.Images.InvertColorFromImage(FiledExpense_QuickButton.ButtonIcon, Color.White)



        ''Remover TabPages:
        TabControl1.TabPages.Remove(TabPage_PaymentHistoric)
        TabControl1.TabPages.Remove(TabPage_Comments)
        TabControl1.TabPages.Remove(TabPage_Graphic)

    End Sub

    Private Sub ViewExpenseForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _EXPENSE.CloseExpense(Me)
    End Sub

    Private Sub FileWatcher_Values_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcherSystem.Changed
        If e.ChangeType = WatcherChangeTypes.Changed Then LoadExpense(False)
    End Sub


#Region "MENU DE OPÇÕES RÁPIDAS"

    Private Sub AlterarNomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarNomeToolStripMenuItem.Click
        Dim ChangeName As ChangeNameDialog = New ChangeNameDialog
        ChangeName.ExpenseCode = EXPENSE_Code : ChangeName.TextBox_Value.Text = Expense_Name
        If ChangeName.ShowDialog = DialogResult.OK Then _EXPENSE.ChangeName(EXPENSE_Code, ChangeName.TextBox_Value.Text)
    End Sub

    Private Sub DescriçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescriçãoToolStripMenuItem.Click
        Dim ChangeDescription As DescriptionPlotDialog = New DescriptionPlotDialog
        ChangeDescription.TextBox_Value.Text = Expense_Description
        If ChangeDescription.ShowDialog = DialogResult.OK Then _EXPENSE.ChangeDescription(EXPENSE_Code, ChangeDescription.TextBox_Value.Text)
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Dim SelectCategory As SelectExpenseCategoryDialog = New SelectExpenseCategoryDialog : SelectCategory.ShowCreditCard = False
        If SelectCategory.ShowDialog = Windows.Forms.DialogResult.OK Then _EXPENSE.ChangeCategory(EXPENSE_Code, SelectCategory.SelectCategoryCode)
    End Sub

    Private Sub CorDeDestaqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorDeDestaqueToolStripMenuItem.Click
        Dim ChangeColor As SelectColorDialog = New SelectColorDialog
        If ChangeColor.ShowDialog = Windows.Forms.DialogResult.OK Then _EXPENSE.ChangeHightColor(EXPENSE_Code, ChangeColor.SelectedColor)
    End Sub

    Private Sub LocalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalToolStripMenuItem.Click
        Dim ChangeLocation As DescriptionPlotDialog = New DescriptionPlotDialog
        ChangeLocation.Label6.Text = "Local da Compra"
        ChangeLocation.TextBox_Value.Text = Expense_Place
        If ChangeLocation.ShowDialog = DialogResult.OK Then _EXPENSE.ChangeBuyPlace(EXPENSE_Code, ChangeLocation.TextBox_Value.Text)
    End Sub

    Private Sub DataDaCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDaCompraToolStripMenuItem.Click
        Dim ChangeDate As ChangeDateDialog = New ChangeDateDialog
        ChangeDate.DateTimePicker_Date.Value = Expense_BuyDate
        If ChangeDate.ShowDialog = Windows.Forms.DialogResult.OK Then
            _EXPENSE.BuyDate(EXPENSE_Code) = ChangeDate.DateTimePicker_Date.Value.Date
        End If
    End Sub

#Region "Icone"
    Private Sub AlterarIconeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarIconeToolStripMenuItem.Click
        Dim ChangeIcon As SelectIconDialog = New SelectIconDialog
        If ChangeIcon.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim FileIcon = ChangeIcon.SelectIconFile.Replace(_DIRECTORIES.IconsPath, "")
            _EXPENSE.ChangeIcon(EXPENSE_Code, FileIcon)
        End If
    End Sub

    Private Sub RemoverIconeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverIconeToolStripMenuItem1.Click
        Select Case MessageBox.Show("Quer mesmo remover o icone de sua despesa?", "XPEG Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes : _EXPENSE.ChangeIcon(EXPENSE_Code, "")
        End Select
    End Sub
#End Region


#Region "Opções"

    Private Sub VincularComCartãoDeCréditoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VincularComCartãoDeCréditoToolStripMenuItem.Click

    End Sub

    Private Sub PersonalizarMenuDeAcessoRápidoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Click

    End Sub

    Private Sub HabilitarPagamentosParciaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabilitarPagamentosParciaisToolStripMenuItem.Click
        _EXPENSE.AllowPartialPayments(EXPENSE_Code) = HabilitarPagamentosParciaisToolStripMenuItem.Checked
    End Sub

    Private Sub HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Click
        _EXPENSE.ApplyColorInHeader(EXPENSE_Code) = HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Checked
    End Sub

#End Region


#Region "Modo de Visualização"

    Private Sub BlocosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocosToolStripMenuItem.Click
        BlockMode(True)
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        ListMode(True)
    End Sub

#End Region


#Region "Arquivar e Excluir"

    Private Sub ArquivarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivarToolStripMenuItem.Click
        MsgBox("Desculpe, mas nos preciptamos..." & vbNewLine & "Este recurso está sendo exibido por engano, porque ele ainda não está disponível.", MsgBoxStyle.Critical, "XPEG Count")
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim ConfirmDelete As DeleteExpenseConfirmDialog = New DeleteExpenseConfirmDialog With {.ExpenseCode = Me.EXPENSE_Code}
        If ConfirmDelete.ShowDialog = Windows.Forms.DialogResult.Yes Then
            FileWatcherSystem.EnableRaisingEvents = False
            If _EXPENSE.Delete(EXPENSE_Code) = True Then

                If isCreditCard Then
                    MsgBox("O cartão foi excluido com sucesso!", MsgBoxStyle.Information, "XPEG Count")
                Else
                    MsgBox("A despesa foi excluida com sucesso!", MsgBoxStyle.Information, "XPEG Count")
                End If

                Me.Close()
            End If

        End If

    End Sub

#End Region

    Private Sub FeedBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedBackToolStripMenuItem.Click
        Dim FeedBack As New FeedBackDialog
        FeedBack.ShowDialog()
    End Sub
#End Region


    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage_Plots Then
            If LIST_PlotsSelecteds.Count = 0 Then
                If isCreditCard = False Then QuickOptionsPanel.Show() 'Somente Despesas vão exibir essa opção, cartões não vão.
            Else
                FlowLabelsStatusPlots.Show() : PlotsSelectedOptionsPanel.Show()
            End If

        Else
            QuickOptionsPanel.Hide()
            FlowLabelsStatusPlots.Hide() : PlotsSelectedOptionsPanel.Hide()
        End If
    End Sub



#Region "Modo de Visualização"

    ''' <summary>
    ''' Modo Bloco
    ''' </summary>
    Private Sub BlockMode(Optional ByVal saveConfig As Boolean = False)
        ''Marcar e Desmarcar Menu:
        BlocosToolStripMenuItem.Checked = True
        ListaToolStripMenuItem.Checked = False

        ''Aplicar Mudanças:
        Dim BlockWidth As Integer = Val(FlowLayoutPanel_BlocksInfos.Width - FlowLayoutPanel_BlocksInfos.Padding.Left - FlowLayoutPanel_BlocksInfos.Padding.Right) / 3

        For Each BLOCK As Panel In FlowLayoutPanel_BlocksInfos.Controls : BLOCK.Width = BlockWidth : Next
        For Each PLOT As Control In PlotsFlowPanel.Controls : PLOT.Width = 500 : Next

        ''Modo de Direção:
        FlowLayoutPanel_BlocksInfos.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel_BlocksInfos.AutoScroll = False

        PlotsFlowPanel.FlowDirection = FlowDirection.TopDown
        PlotsFlowPanel.AutoScroll = False

        ''Salvar:
        If saveConfig Then _EXPENSE.ModeView(EXPENSE_Code) = Expense_CountSystem.ModeViewEnum.BlocksMode
    End Sub


    ''' <summary>
    ''' Modo Lista
    ''' </summary>
    Private Sub ListMode(Optional ByVal saveConfig As Boolean = False)
        ''Marcar e Desmarcar Menu:
        ListaToolStripMenuItem.Checked = True
        BlocosToolStripMenuItem.Checked = False

        ''Aplicar Mudanças:
        Dim BlockWidth As Integer = Val(FlowLayoutPanel_BlocksInfos.Width - FlowLayoutPanel_BlocksInfos.Padding.Left - FlowLayoutPanel_BlocksInfos.Padding.Right)
        For Each BLOCK As Panel In FlowLayoutPanel_BlocksInfos.Controls : BLOCK.Width = BlockWidth : Next

        Dim PlotWidth As Integer = Val(PlotsFlowPanel.Width - PlotsFlowPanel.Padding.Left - PlotsFlowPanel.Padding.Right)
        For Each PLOT As Control In PlotsFlowPanel.Controls
            '_FUNCTIONS.Interfaces.MakeRoundedEdges(PLOT.BaseItemBackgroundPanel, 0)
            'PLOT.Invalidate() : PLOT.Refresh()
            PLOT.Width = PlotWidth
        Next

        ''Modo de Direção:
        FlowLayoutPanel_BlocksInfos.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPanel_BlocksInfos.AutoScroll = True

        PlotsFlowPanel.FlowDirection = FlowDirection.LeftToRight
        PlotsFlowPanel.AutoScroll = True

        ''Salvar:
        If saveConfig Then _EXPENSE.ModeView(EXPENSE_Code) = Expense_CountSystem.ModeViewEnum.ListMode
    End Sub

 
#End Region

#Region "MULTI SELEÇÃO DE PARCELAS"


    Public LIST_PlotsSelecteds As New List(Of PlotItemControl)


    ''' <summary>
    ''' Exibir o ComboBox em todas as Parcelas
    ''' </summary>
    Public Sub ShowComboBoxInAllPlots()
        For Each PLOT As Object In PlotsFlowPanel.Controls : Try : PLOT.ChangeForSelectMode() : Catch : End Try : Next
    End Sub

    ''' <summary>
    ''' Ocultar o ComboBox em todas as Parcelas
    ''' </summary>
    Public Sub HideComboBoxInAllPlots()
        For Each PLOT As Object In PlotsFlowPanel.Controls : Try : PLOT.ChangeForNormalMode() : Catch : End Try : Next
    End Sub

    ''' <summary>
    ''' Selecionar Todas as Parcelas
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectAllPlots()
        For Each PLOT As Object In PlotsFlowPanel.Controls
            Try
                PLOT.CheckedPlot = True
            Catch ex As Exception

            End Try

        Next
    End Sub

    ''' <summary>
    ''' Desmarcar Todas as Parcelas
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectNonePlots()
        For Each PLOT As Object In PlotsFlowPanel.Controls
            Try
                PLOT.CheckedPlot = False
            Catch ex As Exception

            End Try
        Next
        LIST_PlotsSelecteds.Clear()
    End Sub

    ''' <summary>
    ''' Adicionar Parcela na Lista de Selecionados
    ''' </summary>
    Public Sub AddPlotOnSelectedList(ByVal plotControl As PlotItemControl)
        If Not LIST_PlotsSelecteds.Contains(plotControl) Then LIST_PlotsSelecteds.Add(plotControl) : plotControl.CheckedPlot = True
        RefreshPlotsSelected()
    End Sub

    ''' <summary>
    ''' Remover Parcela na Lista de Selecionados
    ''' </summary>
    Public Sub RemovePlotOnSelectedList(ByVal plotControl As PlotItemControl)
        If LIST_PlotsSelecteds.Contains(plotControl) Then LIST_PlotsSelecteds.Remove(plotControl) : plotControl.CheckedPlot = False
        RefreshPlotsSelected()
    End Sub

    ''' <summary>
    ''' Atualizar Lista de Parcelar Selecionadas
    ''' </summary>
    Public Sub RefreshPlotsSelected()

        ''Exibir/Ocultar Todos os CheckBox
        If LIST_PlotsSelecteds.Count = 0 Then
            HideComboBoxInAllPlots() : FlowLabelsStatusPlots.Hide() : PlotsSelectedOptionsPanel.Hide() : QuickOptionsPanel.Show()
        Else
            ShowComboBoxInAllPlots() : FlowLabelsStatusPlots.Show() : PlotsSelectedOptionsPanel.Show() : QuickOptionsPanel.Hide()
        End If




        ''Quantidade de Parcelas Selecionadas:
        If isCreditCard = False Then
            NumbeOfPlotsSelectedsLabel.Text = "Parcelas Selecionadas: " & LIST_PlotsSelecteds.Count
        Else
            NumbeOfPlotsSelectedsLabel.Text = "Faturas Selecionadas: " & LIST_PlotsSelecteds.Count
        End If



        ''Valor Total de Parcelas Selecionadas:
        Dim TotalSelected As Decimal
        For Each PLOT As PlotItemControl In LIST_PlotsSelecteds : TotalSelected += PLOT.PlotTotalValue : Next
        TotalSelectedLabel.Text = "Total Selecionado: " & _FormatNumberStringToMoney(TotalSelected)
    End Sub

    Private Sub VincularComCartãoDeCréditoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LinkWithCard As New SelectCreditCardDialog
        LinkWithCard.ShowDialog()
    End Sub








#End Region

#Region "Opções de MultiSeleção das Parcelas"


    Private Sub SelectAll_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles SelectAll_QuickButton.MouseClick
        SelectAllPlots()
    End Sub

    Private Sub SelectNone_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles SelectNone_QuickButton.MouseClick
        SelectNonePlots()
    End Sub

    Private Sub PayPlots_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles PayPlots_QuickButton.MouseClick

    End Sub

    Private Sub ChangeMaturidyDay_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ChangeMaturidyDay_QuickButton.MouseClick

    End Sub

    Private Sub DeletePlots_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles DeletePlots_QuickButton.MouseClick
        If Expense_NumberOfPlots = 1 Then
            MsgBox("Você não pode excluir essa parcela, porque ela é única nessa despesa", MsgBoxStyle.Critical, "XPEG Count")
        Else
            If LIST_PlotsSelecteds.Count = Expense_NumberOfPlots Then
                MsgBox("Você não pode excluir todas as parcelas da despesa." & vbNewLine & "Mantenha pelo menos uma.", MsgBoxStyle.Critical, "XPEG Count")
            Else
                Select Case MessageBox.Show("Deseja realmente excluir todas as parcelas selecionadas?", "XPEG Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                    Case Windows.Forms.DialogResult.Yes
                        For Each PLOT As PlotItemControl In LIST_PlotsSelecteds
                            PLOT.FileWatcherSystem.EnableRaisingEvents = False
                            _EXPENSE.Plot.Delete(PLOT.PlotPath)
                            PlotsFlowPanel.Controls.Remove(PLOT)
                        Next
                        MsgBox("As Parcelas selecionadas foram removidas com sucesso.", MsgBoxStyle.Information, "XPEG Count")
                        SelectNonePlots()
                End Select
            End If
        End If
    End Sub

    Private Sub AddNewPlot_QuickButton_MouseClick(sender As Object, e As MouseEventArgs) Handles AddNewPlot_QuickButton.MouseClick
        Dim AddPlot As New AddNewPlotDialog
        AddPlot.ExpenseCode = Me.EXPENSE_Code : AddPlot.isCreditCard = Me.isCreditCard
        If AddPlot.ShowDialog = Windows.Forms.DialogResult.OK Then
            If _EXPENSE.Plot.Add(EXPENSE_Code, AddPlot.NewPlotValue_TextBox.Text, AddPlot.NewPlotMaturityDate_DateTimePicker.Value.Date) = True Then
                MsgBox("Nova Parcela adicionada com sucesso!", MsgBoxStyle.Information, "XPEG Count")
                Import_PlotsList()
            End If
        End If
    End Sub
#End Region

    Private Sub ViewExpenseForm_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        If _EXPENSE.ModeView(EXPENSE_Code) = Expense_CountSystem.ModeViewEnum.ListMode Then ListMode()
    End Sub
End Class