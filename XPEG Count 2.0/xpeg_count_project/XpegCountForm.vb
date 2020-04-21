Imports System.IO

Public Class XpegCountForm

    ''' <summary>
    ''' Data Selecionada na Tela Home
    ''' </summary>
    ''' <remarks></remarks>
    Public DateSelected As Date = "01/01/" & Now.Date.Year

    ''' <summary>
    ''' Modo de Visualização da Tela Inicial [ Calendário / Blocos ]
    ''' </summary>
    Public ViewMode As ViewModeHomeScreen = ViewModeHomeScreen.Blocks




    ''' <summary>
    ''' Lista de Códigos das Despesas Cadastradas
    ''' </summary>
    ''' <remarks></remarks>
    Private ExpensesList As New List(Of String)

    ''' <summary>
    ''' Lista de Categorias
    ''' </summary>
    ''' <remarks></remarks>
    Private CategorysList As New List(Of String)

    ''' <summary>
    ''' Lista de Anos das Exchanges Existentes
    ''' </summary>
    Private ExpensesYearList As New List(Of String)

#Region "Eventos Padrões da Janela"

    'Iniciar o Count:
    Private Sub XpegCount_Starting(sender As Object, e As EventArgs) Handles Me.Shown
        ''CRIAR DIRETÓRIOS''
        _DIRECTORIES.CreateDirectories() 'O software detectar se algum diretório não está presente e cria-o automáticamente

        ''Importar Despesas:
        ImportExpensesList()

        ''DEIXAR COMPONENTES COM PREENCHIMENTO COMPLETO (DOCK = FILL)''
        DockFillComponents()

        ''DIZER AOS FILE WATCHER QUAL DIRETÓRIO DEVEM FICAR VIGIANDO''
        'FileWatcher()
    End Sub

    'Fechando o Count:
    Private Sub XpegCount_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ''Mensagem Perguntando se o Usuário quer Fechar o Software:
        If XpegCountSettings.Default.ConfirmClose = True Then
            Select Case MessageBox.Show("Deseja realmente sair do XPEG Count?", "XPEG Count", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                Case Windows.Forms.DialogResult.Yes
                    e.Cancel = False
                    End 'Encerrar Todo o Processo do Software
                Case Windows.Forms.DialogResult.No
                    e.Cancel = True
            End Select
        Else
            e.Cancel = False
            End
        End If
    End Sub

    'Ao redimencionar a Janela:
    Private Sub XpegCount_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

#End Region



#Region "Importar Despesas"

    ''' <summary>
    ''' Importar Lista de Despesas e Categorias
    ''' </summary>
    Private Sub ImportExpensesList()
        ''Limpar Lista de Categorias:
        CategorysList.Clear()

        ''Limpar Lista [TEMPORÁRIO (DEPOIS ELE VAI APENAS REMOVER OS ITENS MODIFICADOS)]:
        ExpensesList.Clear()

        Dim filters As New FiltersClass With
            {
                .enabledFilters = True,
                .dateMode = FiltersClass.dateModeEnum.YearMode,
                .dateSelected = "01/01/2019",
                .categorysSelecteds = Nothing
             }

        ''Importar Categorias:
        CategorysList = _CATEGORYS.GetAllCategorys()

        ''Importar e Adicionar as Despesas na Lista:
        ExpensesList = _EXPENSES.GetExpenses(True) ' _EXPENSES.Filters.ApplyFilters(filters) '

        ''Anos Disponíveis para Despesa:
        ExpensesYearList = _EXPENSES.GetAvailableYears
        'YearFilterComboBox.Items.Clear()
        'For Each Y As String In ExpensesYearList : YearFilterComboBox.Items.Add(Y) : Next

        ''Montar e Exibir Despesas:
        MountExpensesList()
    End Sub

    Private Sub MountExpensesList()
        MountBlocksList() : MountCalendarList()

        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks : MountBlocksList()
            Case ViewModeHomeScreen.Calendar
                SelectedFilter_Label.Text = _FUNCTIONS.GetMonthName(TabControl_ExpensesMonths.SelectedIndex + 1) & " de " & CalendarYear.Date.Year
                YearFilterComboBox.SelectedItem = CalendarYear.Date.Year
                MonthFilterComboBox.SelectedIndex = TabControl_ExpensesMonths.SelectedIndex
        End Select
    End Sub

    Sub MountCalendarList()
        ''Limpar Listas dos Calendários:
        ClearContainers()

        'Loop da Lista de Despesas:
        For Each EXPENSE As String In ExpensesList
            'Obter diretórios das parcelas da Despesa
            Dim Plots As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(EXPENSE)

            For Each PLOTS_OF_EXPENSE As DirectoryInfo In Plots
                'Data da Parcela
                Dim Plot_Date As Date = _EXPENSE.Plot.MaturityDate(PLOTS_OF_EXPENSE)

                Dim PlotItem As ExpensePlotItemControl = New ExpensePlotItemControl
                PlotItem.PlotPath = PLOTS_OF_EXPENSE
                PlotItem.ExpenseCode = EXPENSE


                'Adicionar parcela ao calendário:
                If Plot_Date.Year = CalendarYear.Year Then AddElementInCalendar(PlotItem, Plot_Date.Month)
            Next
        Next

        NoItensInCalendar()
    End Sub

    Sub MountBlocksList()
        ''Limpar Lista de Blocos:
        ExpenseBlocksFlowPanel.Controls.Clear()

        For Each CATEGORY As String In CategorysList
            ''Obter Despesas da Categoria:
            Dim ExpensesOfCategory = _CATEGORYS.GetExpensesOfCategory(CATEGORY)

            ''Se a Categoria Possuir Alguma Despesa:
            If ExpensesOfCategory.Count > 0 Then

                ''Adicionar Categoria:
                Dim CategoryItem As New ExpenseCategoryItemControl With {.FlowPanel = ExpenseBlocksFlowPanel, .CategoryText = _CATEGORYS.GetName(CATEGORY)}
                ExpenseBlocksFlowPanel.Controls.Add(CategoryItem)

                ''Loop das Despesas da Categoria:
                For Each EXPENSE As String In ExpensesOfCategory
                    Dim BlockItem As ExpenseBlockItemControl = New ExpenseBlockItemControl
                    BlockItem.FlowPanel = ExpenseBlocksFlowPanel : BlockItem.EXPENSE_Code = EXPENSE
                    ExpenseBlocksFlowPanel.Controls.Add(BlockItem)
                Next

            End If

        Next

        If ExpenseBlocksFlowPanel.Controls.Count = 0 Then
            Dim NoItem As LabelInControl = New LabelInControl With {.Description = "Nenhuma despesa encontrada...", .DockTop = False}
            ExpenseBlocksFlowPanel.Controls.Add(NoItem)
        End If


     
    End Sub


    Sub AddElementInCalendar(ByVal element As Control, ByVal plot_month As Integer)
        'Obter guia referente ao mês da parcela que será adicionada ao calendário
        Dim TabP As TabPage = TabControl_ExpensesMonths.TabPages.Item(plot_month - 1)

        'Adicionar na guia referente ao mês
        TabP.Controls.Add(element)
    End Sub

    Sub NoItensInCalendar()

        For Each TAB As TabPage In TabControl_ExpensesMonths.TabPages
            Dim NoItem As LabelInControl = New LabelInControl With {.Description = "Nenhuma despesa disponível na data selecionada...", .DockTop = True}
            If TAB.Controls.Count = 0 Then TAB.Controls.Add(NoItem)
        Next

    End Sub

    ''' <summary>
    ''' Limpar Containers de Elementos [Blocks / Calendar]
    ''' </summary>
    Sub ClearContainers()
        'Limpar No Modo Blocos
        ' ExpenseBlocksFlowPanel.Controls.Clear()

        'Limpar no Modo Calendário
        TabPage01_Janeiro.Controls.Clear()
        TabPage02_Fevereiro.Controls.Clear()
        TabPage03_Março.Controls.Clear()
        TabPage04_Abril.Controls.Clear()
        TabPage05_Maio.Controls.Clear()
        TabPage06_Junho.Controls.Clear()
        TabPage07_Julho.Controls.Clear()
        TabPage08_Agosto.Controls.Clear()
        TabPage09_Setembro.Controls.Clear()
        TabPage10_Outubro.Controls.Clear()
        TabPage11_Novembro.Controls.Clear()
        TabPage12_Dezembro.Controls.Clear()
    End Sub


#End Region








#Region "DashBoard"
    ''' <summary>
    ''' Período de Exibição dos Valores da DashBoard [ Tudo / Do Mês / Do Ano ]
    ''' </summary>
    Public DashBoardPeriod As DashboardPeriodEnum = DashboardPeriodEnum.AllTime


#Region "Métodos de Alteração do Período"
    ''' <summary>
    ''' DASHBOARD: Todos os Períodos
    ''' </summary>
    Sub DashBoardPeriod_AllTime()
        ''Definir Período da Dashboard:
        DashBoardPeriod = DashboardPeriodEnum.AllTime


        ''Opções de Periodo:
        ByYear_DashboardPeriodRadioButton.Checked = False
        ByMonth_DashboardPeriodRadioButton.Checked = False
        AllTime_DashboardPeriodRadioButton.Checked = True

        'AllTime_DashboardPeriodMenuItem.Enabled = False
        'ByMonth_DashboardPeriodMenuItem.Enabled = True
        'ByYear_DashboardPeriodMenuItem.Enabled = True

        ''Atualizar Dashboard:
        DashBoardRefresh()
    End Sub

    ''' <summary>
    ''' DASHBOARD: Período Do Mês
    ''' </summary>
    Sub DashBoardPeriod_ByMonth()
        ''Definir Período da Dashboard:
        DashBoardPeriod = DashboardPeriodEnum.ByMonth

        ''Opções de Periodo:
        ByYear_DashboardPeriodRadioButton.Checked = False
        ByMonth_DashboardPeriodRadioButton.Checked = True
        AllTime_DashboardPeriodRadioButton.Checked = False
        ''Menu Suspenso:
        'AllTime_DashboardPeriodMenuItem.Enabled = True
        'ByMonth_DashboardPeriodMenuItem.Enabled = False
        'ByYear_DashboardPeriodMenuItem.Enabled = True

        ''Atualizar Dashboard:
        DashBoardRefresh()
    End Sub

    ''' <summary>
    ''' DASHBOARD: Período Do Ano
    ''' </summary>
    Sub DashBoardPeriod_ByYear()
        ''Definir Período da Dashboard:
        DashBoardPeriod = DashboardPeriodEnum.ByYear

        ''Opções de Periodo:
        ByYear_DashboardPeriodRadioButton.Checked = True
        ByMonth_DashboardPeriodRadioButton.Checked = False
        AllTime_DashboardPeriodRadioButton.Checked = False
        'AllTime_DashboardPeriodMenuItem.Enabled = True
        'ByMonth_DashboardPeriodMenuItem.Enabled = True
        'ByYear_DashboardPeriodMenuItem.Enabled = False

        ''Atualizar Dashboard:
        DashBoardRefresh()
    End Sub
#End Region

#Region "Atualizar DashBoard"

    ''' <summary>
    ''' Atualizar Valores da DashBoard
    ''' </summary>
    Private Sub DashBoardRefresh()
        Dim DashValue_Paid As Decimal = 0
        Dim DashValue_RestToPay As Decimal = 0
        Dim DashValue_TotalExpenses As Decimal = 0
        Dim DashValue_TotalCards As Decimal = 0

        Dim NumberOfExpenses As List(Of String)
        Dim NumberOfCards As List(Of String)

        Select Case DashBoardPeriod
            Case DashboardPeriodEnum.AllTime
                DashValue_Paid = _DASHBOARD.PaidValue.AllTime
                DashValue_RestToPay = _DASHBOARD.RestToPay.AllTime
                DashValue_TotalExpenses = _DASHBOARD.Expenses.AllTime
                DashValue_TotalCards = _DASHBOARD.CreditCards.AllTime

                NumberOfExpenses = _EXPENSES.GetExpenses(True)
                NumberOfCards = _CREDITCARDS.GetCards

            Case DashboardPeriodEnum.ByMonth
                Dim DateEmulated As Date = "01/" & (TabControl_ExpensesMonths.SelectedIndex + 1) & "/" & CalendarYear.Year

                DashValue_Paid = _DASHBOARD.PaidValue.ByMonth(DateEmulated)
                DashValue_RestToPay = _DASHBOARD.RestToPay.ByMonth(DateEmulated)
                DashValue_TotalExpenses = _DASHBOARD.Expenses.ByMonth(DateEmulated)
                DashValue_TotalCards = _DASHBOARD.CreditCards.ByMonth(DateEmulated)

                NumberOfExpenses = _EXPENSES.GetExpensesOfDate(DateEmulated.Year, DateEmulated.Month)
                NumberOfCards = _CREDITCARDS.GetCreditCardsOfDate(DateEmulated.Year, DateEmulated.Month)

            Case DashboardPeriodEnum.ByYear
                DashValue_Paid = _DASHBOARD.PaidValue.ByYear(CalendarYear.Year)
                DashValue_RestToPay = _DASHBOARD.RestToPay.ByYear(CalendarYear.Year)
                DashValue_TotalExpenses = _DASHBOARD.Expenses.ByYear(CalendarYear.Year)
                DashValue_TotalCards = _DASHBOARD.CreditCards.ByYear(CalendarYear.Year)

                NumberOfExpenses = _EXPENSES.GetExpensesOfDate(CalendarYear.Year)
                NumberOfCards = _CREDITCARDS.GetCreditCardsOfDate(CalendarYear.Year)
        End Select

        ''Porcentagem do Valor Pago:
        Dim PaidValue_Porcentage = _FUNCTIONS.GetPorcentage(DashValue_Paid, Val(DashValue_TotalExpenses + DashValue_TotalCards))
        ChangePorcentageValue_PaidValue(PaidValue_Porcentage)

        ''Porcentagem do Valor Restante:
        Dim RestToPay_Porcentage = _FUNCTIONS.GetPorcentage(DashValue_RestToPay, Val(DashValue_TotalExpenses + DashValue_TotalCards))
        ChangePorcentageValue_RestToPay(RestToPay_Porcentage)

        ''Atribuir na Label [Total Pago]:
        TotalValue_Paid_Label.Text = _StringToMoney(DashValue_Paid)
        ''Atribuir na Label [Falta]:
        TotalValue_RestToPay_Label.Text = _StringToMoney(DashValue_RestToPay)
        ''Atribuir na Label [Total das Despesas]:
        TotalValue_AllExpenses_Label.Text = _StringToMoney(DashValue_TotalExpenses)
        ''Atribuir na Label [Total dos Cartões]:
        TotalValue_AllCreditCards_Label.Text = _StringToMoney(DashValue_TotalCards)

        ''Atribuir na Label [Número de Despesas]:
        NumberOfExpenses_Label.Text = NumberOfExpenses.Count()
        ''Atribuir na Label [Número de Cartões]:
        NumberOfCards_Label.Text = NumberOfCards.Count
    End Sub

#End Region

#Region "Enum"
    Enum DashboardPeriodEnum : AllTime : ByYear : ByMonth : End Enum
#End Region
#End Region










#Region "Enum's"
    Enum ViewModeHomeScreen : Calendar : Blocks : End Enum
    Enum FilterEN : DateAndCategory : OnlyCategory : OnlyDate : None : End Enum
    Enum DashboardValuesEN : All : ForYear : ForMonth : End Enum
#End Region


#Region "Controle de Filtros dos Blocos das Despesas"



    ''' <summary>
    ''' Filtro de Exibição dos Blocos
    ''' </summary>
    Public Filter As FilterEN = FilterEN.None

    ''' <summary>
    ''' Código da Categoria Selecionada para o Filtro
    ''' </summary>
    Public FilterParameters_Category As String = ""

    ''' <summary>
    ''' Data Selecionada para Filtro
    ''' </summary>
    Public FilterParameters_Date As Date = Nothing

#End Region


#Region "Controle do Modo Calendário"

    ''' <summary>
    ''' Ano Selecionado para exibição no modo calendário
    ''' </summary>
    Public CalendarYear As Date = "01/01/" & Now.Date.Year

#End Region


#Region "Controle de Valores da Dashboard"

    ''' <summary>
    ''' Qual valor ser exibido na dashboard (Todos / Do Mês / Do Ano)
    ''' </summary>
    Public DashboardValuesMode As DashboardValuesEN = DashboardValuesEN.All

#End Region

#Region "Inicialização do XPEG Count"
    Sub DockFillComponents()
        CalendarModePanel.Dock = DockStyle.Fill
        BlocksModePanel.Dock = DockStyle.Fill
    End Sub

    Sub FileWatcher()
        FileWatcher_Expenses.Path = _DIRECTORIES.ExpensesPath
        FileWatcher_Values.Path = _DIRECTORIES.ExpensesPath
    End Sub
#End Region





    '================================================================================================================='

#Region "Despesas"

    '  Public ExpensesList As New List(Of String)


    Public Sub ImportExpenses()
        'Limpar Listas
        ClearContainers()

        'Importar Todas as Despesas Cadastradas no Sistema
        ExpensesList = _EXPENSES.GetExpenses()

        'Adicionar no modo selecionado (Bloco ou Calendário)
        ' Select Case ModeView
        '  Case ViewModeEN.Blocks : Expenses_AddInBlock()
        ' Case ViewModeEN.Calendar : Expenses_AddInCalendar()
        'End Select
    End Sub

    Private Sub Expenses_AddInCalendar()
        'Loop da Lista de Despesas:
        For Each A As String In ExpensesList
            'Obter diretórios das parcelas da Despesa
            Dim Plots As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(A)

            For Each B As DirectoryInfo In Plots
                'Data da Parcela
                Dim Plot_Date As Date = _EXPENSE.Plot.MaturityDate(B)

                Dim PlotItem As ExpensePlotItemControl = New ExpensePlotItemControl
                PlotItem.PlotPath = B
                PlotItem.ExpenseCode = A

                'Adicionar parcela ao calendário:
                If Plot_Date.Year = CalendarYear.Year Then AddElementInCalendar(PlotItem, Plot_Date.Month)
            Next
        Next


    End Sub


    


#End Region

    Private Sub LoadPlotsFromExpense(ByVal expense_path As String)
        Dim ListOfPlots As New List(Of String)
        Try
            Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(expense_path & "\plots\")
            Dim oFileInfoCollection() As DirectoryInfo
            Dim oFileInfo As FileInfo
            Dim i As Integer

            '### Preenche o FileCollection com um Array de objetos FileInfo
            oFileInfoCollection = DirDiretorio.GetDirectories()

            '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
            For i = 0 To oFileInfoCollection.Length() - 1
                oFileInfo = oFileInfoCollection.GetValue(i)
                ListOfPlots.Add(oFileInfo.FullName)
            Next

            For Each b As String In ListOfPlots
                'Ler mês da parcela
                Dim PlotMonth As Integer = _INI.ReadIniFile(b & "\plot.xcf", "DATES", "month", "01")
                Dim PlotYear As Integer = _INI.ReadIniFile(b & "\plot.xcf", "DATES", "YEAR", "2019")

                Dim CategorySeparator_Despesas As New CategoryIconsSeparatorControl
                CategorySeparator_Despesas.Dock = DockStyle.Top
                CategorySeparator_Despesas.CategoryName = "Despesas"

                Dim CategorySeparator_Cartoes As New CategoryIconsSeparatorControl
                CategorySeparator_Cartoes.Dock = DockStyle.Top
                CategorySeparator_Cartoes.CategoryName = "Cartões de Crédito"

                'Adicionar parcela a lista
                Dim ItemPlot As New ExpensePlotItemControl
                'ItemPlot = New ExpensePlotItemControl
                'ItemPlot.PLOT_File = b
                'ItemPlot.EXPENSE_Path = expense_path

                Dim ExpenseCategory = _INI.ReadIniFile(expense_path & "\expense.xcf", "EXPENSE", "category", "")

                If PlotYear = CalendarYear.Date.Year Then

                    Select Case PlotMonth
                        Case 1 'Janeiro
                            ' If _ParOuImpar(TabPage01_Janeiro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            ItemPlot.BringToFront()
                            'TabPage01_Janeiro.Controls.Add(CategorySeparator_Cartoes)

                        Case 2 'Fevereiro
                            ' If _ParOuImpar(TabPage02_Fevereiro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage02_Fevereiro.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 3 'Março
                            '  If _ParOuImpar(TabPage03_Março.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage03_Março.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 4 'Abril
                            '  If _ParOuImpar(TabPage04_Abril.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage04_Abril.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 5 'Maio
                            ' If _ParOuImpar(TabPage05_Maio.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage05_Maio.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 6 'Junho 
                            'If _ParOuImpar(TabPage06_Junho.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage06_Junho.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 7 'Julho
                            ' If _ParOuImpar(TabPage07_Julho.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage07_Julho.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 8 'Agosto        
                            '     If _ParOuImpar(TabPage08_Agosto.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage08_Agosto.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 9 'Setembro 
                            '   If _ParOuImpar(TabPage09_Setembro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage09_Setembro.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 10 'Outubro
                            '    If _ParOuImpar(TabPage10_Outubro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage10_Outubro.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 11 'Novembro
                            '    If _ParOuImpar(TabPage11_Novembro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)
                            TabPage11_Novembro.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()

                        Case 12 'Dezembro
                            '   If _ParOuImpar(TabPage12_Dezembro.Controls.Count + 1) = True Then ItemPlot.BackColor = Color.FromArgb(220, 220, 220)

                            TabPage12_Dezembro.Controls.Add(CategorySeparator_Despesas)
                            If ExpenseCategory <> "XC.CATEGORY_CREDITCARD" Then TabPage12_Dezembro.Controls.Add(ItemPlot)
                            ItemPlot.BringToFront()
                            TabPage12_Dezembro.Controls.Add(CategorySeparator_Cartoes)
                    End Select
                End If
            Next
        Catch ex As Exception

        End Try



    End Sub








    Private Sub XpegCountForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown


        ''CARREGAR AS CONFIGURAÇÕES DO USUÁRIO''
        '_SETTINGS.LoadSettings()


        ''APLICAR IDIOMA''
        'ApplyLanguage()

        ''PRIMEIRO ACESSO''
        'If My.Settings.FIRST_USE = True Then
        'FirstUseDialog.ShowDialog()
        'End If

        ''CHECAR POR ATUALIZAÇÕES DE SOFTWARE''
        'CheckVersionOnServer()

        ''ADAPTAR MENU''
        LoadSetting_MenuMode()
        ' MenuPanel.Width = 50 ' : MenuPanel.BringToFront()

        ''MANTER TODOS OS PANELS DE "MODO DE VISUALIZAÇÃO" EM DOCK = FILL''


        ''CONFIGURAR MODO DE VISUALIZAÇÃO''
        ViewMode = XpegCountSettings.Default.ViewMode

        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks : ModeViewerDashboard_Blocks()
            Case ViewModeHomeScreen.Calendar : CalendarModeView() : DashBoardPeriod_ByMonth()
        End Select

        ''CONFIGURAÇÃO: ABRIR NA TAB DO MÊS ATUAL''
        AutoTabPageMonth()



        ''IMPORTAR TODAS AS CATEGORIAS DO COUNT''
        'ImportCategorys()

        ''IMPORTAR DESPESAS CADASTRADAS NO SISTEMA''
        'ImportExpenses() '
        'LoadExpensesFromYear(Now.Date.Year)

        ''ATUALIZAR VALORES DA DASHBOARD''
        'RefreshDashboard()
    End Sub

    Public Sub LoadSetting_MenuMode()
        'Select Case _SETTINGS.Customization.MenuCountMode

        '    Case SettingsClass_Customization.SettingMenuCountModeEnum.AlwaysVisible
        '        ButtonMenuPanel.Controls.Add(Btn_OpenMenu)
        ' Btn_OpenMenu.Location = New Point(8, 8)

        FormBackground.Padding = New Padding(50, 0, 0, 0)
        '   MenuPanel.Width = 50

        ' Btn_OpenMenu.Image = _FUNCTIONS.Images.InvertColorFromImage(Btn_OpenMenu.Image, Color.White)
        '   Panel_CountLogo.Hide()
        '  Btn_OpenMenu.BringToFront()

        'ChangeMenuIconsSize(0)

        '    Case Else
        'HeaderPanel.Controls.Add(Btn_OpenMenu)
        'Btn_OpenMenu.Location = New Point(16, 5)

        'FormBackground.Padding = New Padding(0, 0, 0, 0)
        'MenuPanel.Width = 0 'Botão vai abrir menu

        'Btn_OpenMenu.Image = _FUNCTIONS.Images.InvertColorFromImage(Btn_OpenMenu.Image, MenuPanel.BackColor)
        'Panel_CountLogo.Show()
        'Btn_OpenMenu.BringToFront()

        ChangeMenuIconsSize(28)
        'End Select
    End Sub


    Private Sub ChangeMenuIconsSize(ByVal sz As Integer)
        Dim IconsS As Integer
        If sz = 0 Then
            IconsS = _PROPERTY_MENU_ICONS_SIZE.Width
        Else
            IconsS = sz
        End If

        'MenuItemList_NewExpense.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_AddExpense_28x28, IconsS)
        ' MenuItemList_AddCreditCard.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_AddCreditCard_28x28, IconsS)
        'MenuItemList_Dashboard.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_Dashboard_28x28, IconsS)
        ' MenuItemListControl_Categorys.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_Categorys_28x28, IconsS)
        ' MenuItemList_SoftwareSettings.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_Settings_28x28, IconsS)
        'MenuItemList_CheckForUptdates.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_CheckForUpdates_28x28, IconsS)
        ' MenuItemList_AboutSoftwares.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_Informations_28x28, IconsS)
        'MenuItemList_CloseCount.MenuIcon = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.MenuCountIconsResource.IconMenu_Close_28x28, IconsS)
    End Sub

#Region "Year Control"
    Public Sub Dashboard_BackYear()
        If CalendarYear.Date.Year = 2010 Then
            MsgBox("Desculpe, mas o limite é até aqui!", MsgBoxStyle.Critical)
        Else
            CalendarYear = CalendarYear.AddYears(-1)
            ImportExpensesList()
            If ViewMode = ViewModeHomeScreen.Calendar Then
                SelectedFilter_Label.Text = CalendarYear.Date.Year
                YearFilterComboBox.SelectedItem = CalendarYear.Date.Year
            End If

        End If
    End Sub

    Public Sub Dashboard_NextYear()
        CalendarYear = CalendarYear.AddYears(1)
        ImportExpensesList()
        If ViewMode = ViewModeHomeScreen.Calendar Then
            SelectedFilter_Label.Text = CalendarYear.Date.Year
            YearFilterComboBox.SelectedItem = CalendarYear.Date.Year
        End If

    End Sub

#Region "Button - Back Year"
    Private Sub Btn_BackYear_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_BackYear.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dashboard_BackYear()
        End If
    End Sub

    Private Sub Btn_BackYear_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_BackYear.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Btn_BackYear.Image = My.Resources.Icon_BackYear_Down_20x20
        End If
    End Sub

    Private Sub Btn_BackYear_MouseEnter(sender As Object, e As EventArgs) Handles Btn_BackYear.MouseEnter
        Btn_BackYear.Image = My.Resources.Icon_BackYear_Enter_20x20
    End Sub

    Private Sub Btn_BackYear_MouseLeave(sender As Object, e As EventArgs) Handles Btn_BackYear.MouseLeave
        Btn_BackYear.Image = My.Resources.Icon_BackYear_Normal_20x20
    End Sub

#Region "Button - Next Year"

    Private Sub Btn_NextYear_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_NextYear.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dashboard_NextYear()
        End If
    End Sub

    Private Sub Btn_NextYear_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_NextYear.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Btn_NextYear.Image = My.Resources.Icon_NextYear_Down_20x20
        End If
    End Sub

    Private Sub Btn_NextYear_MouseEnter(sender As Object, e As EventArgs) Handles Btn_NextYear.MouseEnter
        Btn_NextYear.Image = My.Resources.Icon_NextYear_Enter_20x20
    End Sub

    Private Sub Btn_NextYear_MouseLeave(sender As Object, e As EventArgs) Handles Btn_NextYear.MouseLeave
        Btn_NextYear.Image = My.Resources.Icon_NextYear_Normal_20x20
    End Sub

#End Region

#End Region


#End Region


    Dim LIST_ExpensesOfYearSelected As New List(Of String)

    Public Sub LoadExpensesFromYear(ByVal _year As Integer)
        'limpar lista
        LIST_ExpensesOfYearSelected.Clear()



        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo
        Dim oFileInfo As DirectoryInfo
        Dim i As Integer

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i) : LIST_ExpensesOfYearSelected.Add(oFileInfo.FullName)

            Dim ItemExpense As New ExpenseBlockItemControl : ItemExpense = New ExpenseBlockItemControl
            ' ItemExpense.EXPENSE_Path = oFileInfo.FullName
            ItemExpense.FlowPanel = ExpenseBlocksFlowPanel
            ExpenseBlocksFlowPanel.Controls.Add(ItemExpense) : ItemExpense.BringToFront()


        Next

        For Each a As String In LIST_ExpensesOfYearSelected
            LoadPlotsFromExpense(a)
        Next
        NoExpensesForMonth()
    End Sub



    Private Sub NoExpensesForMonth()
        If TabPage01_Janeiro.Controls.Count = 0 Then AddLabel(TabPage01_Janeiro)
        If TabPage02_Fevereiro.Controls.Count = 0 Then AddLabel(TabPage02_Fevereiro)
        If TabPage03_Março.Controls.Count = 0 Then AddLabel(TabPage03_Março)
        If TabPage04_Abril.Controls.Count = 0 Then AddLabel(TabPage04_Abril)
        If TabPage05_Maio.Controls.Count = 0 Then AddLabel(TabPage05_Maio)
        If TabPage06_Junho.Controls.Count = 0 Then AddLabel(TabPage06_Junho)
        If TabPage07_Julho.Controls.Count = 0 Then AddLabel(TabPage07_Julho)
        If TabPage08_Agosto.Controls.Count = 0 Then AddLabel(TabPage08_Agosto)
        If TabPage09_Setembro.Controls.Count = 0 Then AddLabel(TabPage09_Setembro)
        If TabPage10_Outubro.Controls.Count = 0 Then AddLabel(TabPage10_Outubro)
        If TabPage11_Novembro.Controls.Count = 0 Then AddLabel(TabPage11_Novembro)
        If TabPage12_Dezembro.Controls.Count = 0 Then AddLabel(TabPage12_Dezembro)
    End Sub

    Private Sub AddLabel(tabpage_ As TabPage)
        Dim LB As New Label
        LB = New Label
        LB.Dock = DockStyle.Top
        LB.AutoSize = False
        LB.Height = 30
        LB.Text = "Nenhuma despesa para mostrar aqui..."
        tabpage_.Controls.Add(LB)
    End Sub




    'Private Sub SelectedYear_Label_MouseClick(sender As Object, e As MouseEventArgs) Handles SelectedFilter_Label.MouseClick
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        If ViewMode = ViewModeHomeScreen.Calendar Then
    '            Dim SelectYear As New SelectYearDialog : SelectYear.DateTimePicker_Year.Value = CalendarYear
    '            If SelectYear.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                CalendarYear = "01/01/" & SelectYear.DateTimePicker_Year.Value.Date.Year : ImportExpensesList()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub SelectedYear_Label_MouseEnter(sender As Object, e As EventArgs) Handles SelectedFilter_Label.MouseEnter
        '   If ViewMode = ViewModeHomeScreen.Calendar Then SelectedFilter_Label.ForeColor = Color.FromArgb(30, 30, 30)
    End Sub

    Private Sub SelectedYear_Label_MouseLeave(sender As Object, e As EventArgs) Handles SelectedFilter_Label.MouseLeave
        '  If ViewMode = ViewModeHomeScreen.Calendar Then SelectedFilter_Label.ForeColor = Color.FromArgb(80, 80, 80)
    End Sub

    Private Sub FileWatcher_Expenses_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcher_Expenses.Changed
        LoadExpensesFromYear(CalendarYear.Date.Year)
    End Sub


    Private Sub FileWatcher_Values_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcher_Values.Changed
        RefreshDashboard()
    End Sub

    Private Value_AllCreditCards As Decimal = 0
    Private Value_AllExpenses As Decimal = 0

    Private Value_TotalPaid As Decimal = 0
    Private Value_RestToPay As Decimal = 0


    Private Sub RefreshDashboard()

        'Importar Valores da Dashboard:
        DashboardValues_AllCreditCards()
        DashboardValues_AllExpenses()
        DashboardValues_RestToPay()
        DashboardValues_Paid()

        'Aplicar Valores nos Blocos:
        TotalValue_AllExpenses_Label.Text = _FormatNumberStringToMoney(Value_AllExpenses) 'String.Format("{0:c}", Double.Parse(Value_AllExpenses)))
        TotalValue_AllCreditCards_Label.Text = _FormatNumberStringToMoney(Value_AllCreditCards) '("R$ " & String.Format("{0:f}", Double.Parse(Value_AllCreditCards)))

        TotalValue_Paid_Label.Text = _FormatNumberStringToMoney(Value_TotalPaid) '("R$ " & String.Format("{0:f}", Double.Parse(Value_TotalPaid)))
        TotalValue_RestToPay_Label.Text = _FormatNumberStringToMoney(Value_RestToPay) '("R$ " & String.Format("{0:f}", Double.Parse(Value_RestToPay)))










        'Total de Todos os Cartões de Crédito


        'Total ja pago de todas as depesas


        '' > Valor que falta para ser pago < ''

        'Dim Total_OfExpensesAndCards As Decimal = Val(TotalAll_Expenses + TotalAll_CreditCards)
        'Dim Total_Paid As Decimal = Val(TotalValuePaidFromAllExpenses + 0)
        'Dim Total_RestToPay As Decimal = Val(Total_OfExpensesAndCards - Total_Paid)

        'TotalValue_RestToPay_Label.Text = "R$ " & String.Format("{0:f}", Double.Parse(Total_RestToPay))

        'Número de Despesas

        'Select Case DashboardMode
        '    Case DashboardModeEnum.Values_All
        '        NumberOfExpenses_Label.Text = _DASHBOARD.Get_CountOfExpenses(SystemClass_Dashboard.Enum_WhereImportValues.AllTime, "01/01/2018")

        '    Case DashboardModeEnum.Values_Month
        '        NumberOfExpenses_Label.Text = _DASHBOARD.Get_CountOfExpenses(SystemClass_Dashboard.Enum_WhereImportValues.AllTime, "01/" & TabControl_ExpensesMonths.SelectedIndex + 1 & "/" & CalendarYear.Year)

        '    Case DashboardModeEnum.Values_Year
        '        NumberOfExpenses_Label.Text = _DASHBOARD.Get_CountOfExpenses(SystemClass_Dashboard.Enum_WhereImportValues.AllTime, "01/01/" & CalendarYear.Year)

        'End Select


        Try
            ''Porcentagem do Valor Pago
            'Dim Porcentage_ValuePaid = _FUNCTIONS.GetPorcentage(TotalValuePaidFromAllExpenses, TotalAll_Expenses)
            'ChangePorcentageValue_PaidValue(Porcentage_ValuePaid)
            '' PaidPorcentage_Label.Text = DashboardProgressBar_Paid.Value & "%"

            ''Porcentagem do Valor que Falta
            'Dim Porcentage_RestoToPay = _FUNCTIONS.GetPorcentage(Total_RestToPay, TotalAll_Expenses)
            'ChangePorcentageValue_RestToPay(Porcentage_RestoToPay)
            ''RestPorcentage_LAbel.Text = DashboardProgressBar_Rest.Value & "%"
        Catch ex As Exception

        End Try

    End Sub



    Sub DashboardValues_AllExpenses()
        'Zerar Valor na Variável:
        Value_AllExpenses = _DASHBOARD.Expenses.AllTime()

        'Obter Valor Total de Todas as Despesas :
        Select Case DashboardValuesMode
            Case DashboardValuesEN.All
                ' Value_AllExpenses = _DASHBOARD.GetValue_TotalOfAllExpenses(SystemClass_Dashboard.Enum_WhereImportValues.AllTime, "01/01/2018")

            Case DashboardValuesEN.ForMonth
                '  Value_AllExpenses = _DASHBOARD.GetValue_TotalOfAllExpenses(SystemClass_Dashboard.Enum_WhereImportValues.OfMonth, "01/" & TabControl_ExpensesMonths.SelectedIndex + 1 & "/" & CalendarYear.Year)

            Case DashboardValuesEN.ForYear
                ' Value_AllExpenses = _DASHBOARD.GetValue_TotalOfAllExpenses(SystemClass_Dashboard.Enum_WhereImportValues.OfMonth, "01/01/" & CalendarYear.Year)
        End Select
    End Sub

    Sub DashboardValues_AllCreditCards()
        Value_AllCreditCards = 0

        'Select Case DashboardValuesMode
        '    Case DashboardValuesEN.All
        '        Value_AllCreditCards = 4999
        '    Case DashboardValuesEN.ForMonth
        '        Value_AllCreditCards = 1000

        '    Case DashboardValuesEN.ForYear
        '        Value_AllCreditCards = 1859
        'End Select
    End Sub

    Sub DashboardValues_Paid()
        Value_TotalPaid = 0
        Value_TotalPaid = _DASHBOARD.PaidValue.AllTime()

        Select Case DashboardValuesMode
            Case DashboardValuesEN.All
                ' Value_TotalPaid = _DASHBOARD.GetValue_TotalPaid(SystemClass_Dashboard.Enum_WhereImportValues.AllTime, "01/01/2018")

            Case DashboardValuesEN.ForMonth
                ' Value_TotalPaid = _DASHBOARD.GetValue_TotalPaid(SystemClass_Dashboard.Enum_WhereImportValues.OfMonth, "01/" & TabControl_ExpensesMonths.SelectedIndex + 1 & "/" & CalendarYear.Year)

            Case DashboardValuesEN.ForYear
                'Value_TotalPaid = _DASHBOARD.GetValue_TotalPaid(SystemClass_Dashboard.Enum_WhereImportValues.OfYear, "01/01/" & CalendarYear.Year)
        End Select
    End Sub

    Sub DashboardValues_RestToPay()

        Value_RestToPay = _DASHBOARD.RestToPay.AllTime()

    End Sub

















    Private Sub TabControl_ExpensesMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_ExpensesMonths.SelectedIndexChanged
        ''Alterar Mês no Filtro:
        MonthFilterComboBox.SelectedIndex = TabControl_ExpensesMonths.SelectedIndex

        ''Atualizar Label:
        SelectedFilter_Label.Text = _FUNCTIONS.GetMonthName(TabControl_ExpensesMonths.SelectedIndex + 1) & " de " & CalendarYear.Date.Year

        ''Atualizar Valores da Dashboard:
        DashBoardRefresh()
    End Sub

#Region "Eventos do Mouse - Modo de Visualização da Dashboard"

    
#End Region

#Region "Ações no Form"

#Region "Configurações - Abrir na Guia Mês Atual"
    Private Sub AutoTabPageMonth()
        If XpegCountSettings.Default.AutoTabInCalendar = True Then

            Select Case Now.Date.Month
                Case 1 'Janeiro
                    TabControl_ExpensesMonths.SelectedTab = TabPage01_Janeiro

                Case 2 'Fevereiro
                    TabControl_ExpensesMonths.SelectedTab = TabPage02_Fevereiro

                Case 3 'Março
                    TabControl_ExpensesMonths.SelectedTab = TabPage03_Março

                Case 4 'Abril
                    TabControl_ExpensesMonths.SelectedTab = TabPage04_Abril

                Case 5 'Maio
                    TabControl_ExpensesMonths.SelectedTab = TabPage05_Maio

                Case 6 'Junho 
                    TabControl_ExpensesMonths.SelectedTab = TabPage06_Junho

                Case 7 'Julho
                    TabControl_ExpensesMonths.SelectedTab = TabPage07_Julho

                Case 8 'Agosto        
                    TabControl_ExpensesMonths.SelectedTab = TabPage08_Agosto

                Case 9 'Setembro 
                    TabControl_ExpensesMonths.SelectedTab = TabPage09_Setembro

                Case 10 'Outubro
                    TabControl_ExpensesMonths.SelectedTab = TabPage10_Outubro

                Case 11 'Novembro
                    TabControl_ExpensesMonths.SelectedTab = TabPage11_Novembro

                Case 12 'Dezembro
                    TabControl_ExpensesMonths.SelectedTab = TabPage12_Dezembro
            End Select

        End If

    End Sub
#End Region


#Region "Modo de Visualização da Dashboard"
    'Enum ExpensesFilterTypeEnum : None : ForDate : ForCategory : DateAndCategory : End Enum
    'Enum ModeViewEnum : Blocks : Mode_Calendar : End Enum

#End Region


#Region "Modo dos Calculos da Dashboard"
    Public Enum DashboardModeEnum : Values_Year : Values_Month : Values_All : End Enum
    Public Sub ModeValuesDashboard_ForYear()
        'AllTime_DashboardPeriodMenuItem.Checked = False
        'ByMonth_DashboardPeriodMenuItem.Checked = False
        'NumberOfExpenses_Label.Hide()
        'DashboardMode = DashboardModeEnum.Values_Year
        RefreshDashboard()
    End Sub

    Public Sub ModeValuesDashboard_ForMonth()
        'AllTime_DashboardPeriodMenuItem.Checked = False
        'ByYear_DashboardPeriodMenuItem.Checked = False
        'NumberOfExpenses_Label.Hide()
        'DashboardMode = DashboardModeEnum.Values_Month
        RefreshDashboard()
    End Sub

    Public Sub ModeValuesDashboard_All()
        'ByMonth_DashboardPeriodMenuItem.Checked = False
        'ByYear_DashboardPeriodMenuItem.Checked = False
        'NumberOfExpenses_Label.Show()
        'Dashboardva = DashboardModeEnum.Values_All
        'DashboardValuesMode = 
        RefreshDashboard()
    End Sub
#End Region
#End Region


#Region "Categorias"


    Public LIST_CategorysName As New List(Of String)
    Public LIST_CategorysCode As New List(Of String)
    Public Sub ImportCategorys() 'REMOVER ESSE CÓDIGO MAIS TARDE <<<<<<<<<<<<
        'Importa todas as categorias cadastradas para a LIST_Categorys
        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.CategorysPath)
        Dim CategorysFolders() As DirectoryInfo : CategorysFolders = DirPath.GetDirectories()
        For Each A As DirectoryInfo In CategorysFolders
            If Not LIST_Expenses.Contains(A.FullName) Then
                LIST_CategorysCode.Add(A.Name)
                LIST_CategorysName.Add(_INI.ReadIniFile(A.FullName & "\category.ini", "CATEGORY", "name", 0))
            End If
        Next
        LIST_CategorysCode.Add("")
        LIST_CategorysName.Add("despesas sem categoria")
    End Sub

#End Region

#Region "Despesas"

    Public LIST_Expenses As New List(Of String) 'Path
    Public LIST_ExpensesCode As New List(Of String)
    Public LIST_Expenses_BlockItem As New List(Of ExpenseBlockItemControl) : Public LIST_Expenses_ListItem As New List(Of ExpensePlotItemControl)

    ''' <summary>
    ''' Remover todos os itens das listas de blocos e calendário.
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Private Sub ClearListControls()
        'BLOCOS'
        ExpenseBlocksFlowPanel.Controls.Clear()

        'CALENDÁRIO'
        TabPage01_Janeiro.Controls.Clear()
        TabPage02_Fevereiro.Controls.Clear()
        TabPage03_Março.Controls.Clear()
        TabPage04_Abril.Controls.Clear()
        TabPage05_Maio.Controls.Clear()
        TabPage06_Junho.Controls.Clear()
        TabPage07_Julho.Controls.Clear()
        TabPage08_Agosto.Controls.Clear()
        TabPage09_Setembro.Controls.Clear()
        TabPage10_Outubro.Controls.Clear()
        TabPage11_Novembro.Controls.Clear()
        TabPage12_Dezembro.Controls.Clear()
    End Sub


    ''' <summary>
    ''' Importar TODAS as despesas cadastradas no sistema (Idempedente de qual for o ano, mês ou categoria selecionada)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ImportExpense2()
        'Importa todas as despesas cadastradas para a LIST_Expenses
        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim ExpensesFolders() As DirectoryInfo : ExpensesFolders = DirPath.GetDirectories()
        For Each A As DirectoryInfo In ExpensesFolders
            If Not LIST_Expenses.Contains(A.FullName) Then
                LIST_Expenses.Add(A.FullName)
                LIST_ExpensesCode.Add(_INI.ReadIniFile(A.FullName & "\expense.ini", "EXPENSE", "code", 0))
            End If

        Next

        'Adicionar despesas nas suas listas'
        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks : Expenses_AddInBlock()
            Case ViewModeHomeScreen.Calendar : Expenses_AddInCalendar()
        End Select
    End Sub

    ''' <summary>
    ''' Remover da Lista uma despesa que foi Deletada ou Arquivada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RemoveExpense()

    End Sub



    Private Sub Expenses_AddInBlock()
        ClearListControls()

        'Select Case ViewFilterSelected

        '    Case ExpensesFilterTypeEnum.None 'Sem Filtro
        '        For Each a As String In LIST_CategorysCode : Add_ForCategory(a) : Next

        '    Case ExpensesFilterTypeEnum.ForDate 'Por Data
        '        Add_ForDate(CalendarYear.Date)

        '    Case ExpensesFilterTypeEnum.ForCategory 'Por Categoria
        '        Add_ForCategory(SELECTED_CategoryCode)

        '    Case ExpensesFilterTypeEnum.DateAndCategory 'Data e Categoria

        'End Select
    End Sub


    Sub Add_ForCategory(ByVal Category_Code As String)
        Dim ItemCategory As ExpenseCategoryItemControl : ItemCategory = New ExpenseCategoryItemControl
        ItemCategory.FlowPanel = Me.ExpenseBlocksFlowPanel
        ItemCategory.CategoryText = _CATEGORYS.GetName(Category_Code)
        ExpenseBlocksFlowPanel.Controls.Add(ItemCategory) ': ItemCategory.BringToFront()

        Dim ListOfExpensesFromCategorySelected As New List(Of String)


        For Each a As String In LIST_Expenses
            Dim ExpenseCategory As String = _INI.ReadIniFile(a & "\expense.ini", "EXPENSE", "category")
            If ExpenseCategory = Category_Code Then
                ListOfExpensesFromCategorySelected.Add(a)
            End If
        Next


        If ListOfExpensesFromCategorySelected.Count = 0 Then
            Dim ItemNothing As ExpenseCategoryItemControl : ItemNothing = New ExpenseCategoryItemControl
            ItemNothing.FlowPanel = Me.ExpenseBlocksFlowPanel : ItemNothing.SubCategory = True
            ItemNothing.CategoryText = "Nenhuma despesa foi encontrada para a categoria selecionada..."
            ExpenseBlocksFlowPanel.Controls.Add(ItemNothing) ': ItemCategory.BringToFront()
        Else

            For Each b As String In ListOfExpensesFromCategorySelected
                Dim ItemExpense As New ExpenseBlockItemControl : ItemExpense = New ExpenseBlockItemControl
                ' ItemExpense.EXPENSE_Path = b
                ItemExpense.FlowPanel = ExpenseBlocksFlowPanel
                ExpenseBlocksFlowPanel.Controls.Add(ItemExpense) ': ItemExpense.BringToFront()
            Next


        End If


    End Sub

    Sub Add_ForDate(ByVal Date_Selected As Date)

        Dim ListOfExpensesFromDateSelected As New List(Of String)

        For Each a As String In LIST_Expenses
            Dim ExpenseDate As Date
            Dim file_date = _INI.ReadIniFile(a & "\expense.ini", "EXPENSE", "date")

            If IsDate(file_date) Then
                ExpenseDate = file_date
                If ExpenseDate = "01/" & Date_Selected.Month & "/" & Date_Selected.Year Then
                    ListOfExpensesFromDateSelected.Add(a)
                End If
            End If

        Next

        If ListOfExpensesFromDateSelected.Count = 0 Then
            Dim ItemNothing As ExpenseCategoryItemControl : ItemNothing = New ExpenseCategoryItemControl
            ItemNothing.FlowPanel = Me.ExpenseBlocksFlowPanel : ItemNothing.SubCategory = True
            ItemNothing.CategoryText = "Nenhuma despesa foi encontrada para a data selecionada..."
            ExpenseBlocksFlowPanel.Controls.Add(ItemNothing) ': ItemCategory.BringToFront()
        Else

            For Each b As String In ListOfExpensesFromDateSelected
                Dim ItemExpense As New ExpenseBlockItemControl : ItemExpense = New ExpenseBlockItemControl
                'ItemExpense.EXPENSE_Path = b
                ItemExpense.FlowPanel = ExpenseBlocksFlowPanel
                ExpenseBlocksFlowPanel.Controls.Add(ItemExpense) ': ItemExpense.BringToFront()
            Next


        End If

    End Sub
#End Region




#Region "Responsividade da DashBoard"
    Private Sub DashboardPanel_ValuePaid_SizeChanged(sender As Object, e As EventArgs) Handles DashboardPanel_ValuePaid.SizeChanged
        Try
            Dim SizeFont As Integer = DashboardPanel_ValuePaid.Width / 15
            If SizeFont >= 23 Then SizeFont = 22
            TotalValue_Paid_Label.Font = New Font(TotalValue_Paid_Label.Font.Name, SizeFont)
        Catch : End Try
    End Sub

    Private Sub DashboardPanel_RestToPayValue_SizeChanged(sender As Object, e As EventArgs) Handles DashboardPanel_RestToPayValue.SizeChanged
        Try
            Dim SizeFont As Integer = DashboardPanel_ValuePaid.Width / 15
            If SizeFont >= 23 Then SizeFont = 22
            TotalValue_RestToPay_Label.Font = New Font(TotalValue_RestToPay_Label.Font.Name, SizeFont)
        Catch : End Try
    End Sub

    Private Sub DashboardPanel_ExpensesValue_SizeChanged(sender As Object, e As EventArgs) Handles DashboardPanel_ExpensesValue.SizeChanged
        Try
            Dim SizeFont As Integer = DashboardPanel_ValuePaid.Width / 15
            If SizeFont >= 23 Then SizeFont = 22
            TotalValue_AllExpenses_Label.Font = New Font(TotalValue_AllExpenses_Label.Font.Name, SizeFont)
        Catch : End Try
    End Sub

    Private Sub DashboardPanel_CreditCards_SizeChanged(sender As Object, e As EventArgs) Handles DashboardPanel_CreditCards.SizeChanged
        Try
            Dim SizeFont As Integer = DashboardPanel_ValuePaid.Width / 15
            If SizeFont >= 23 Then SizeFont = 22
            TotalValue_AllCreditCards_Label.Font = New Font(TotalValue_AllCreditCards_Label.Font.Name, SizeFont)
        Catch : End Try
    End Sub
#End Region







#Region "DashBoard Animation"
    Private WithEvents AnimationTimerPaidValue_Subir As New Timer
    Private WithEvents AnimationTimerPaidValue_Descer As New Timer

    Private WithEvents AnimationTimerRestToPay_Subir As New Timer
    Private WithEvents AnimationTimerRestToPay_Descer As New Timer

    Private NewPorcentage_PaidValue As Decimal
    Private NewPorcentage_RestToPay As Decimal


    Private Sub ChangePorcentageValue_PaidValue(ByVal new_value As Decimal)
        NewPorcentage_PaidValue = new_value
        If DashboardProgressBar_Paid.Value > new_value Then
            AnimationTimerPaidValue_Descer.Start() : AnimationTimerPaidValue_Subir.Stop()
        Else
            AnimationTimerPaidValue_Subir.Start() : AnimationTimerPaidValue_Descer.Stop()
        End If
    End Sub

    Private Sub AnimationTimerPaidValue_Subir_Tick(sender As Object, e As EventArgs) Handles AnimationTimerPaidValue_Subir.Tick
        AnimationTimerPaidValue_Subir.Interval = _PROPERTY_DASHBOARD_ANIMATION_SPEED

        DashboardProgressBar_Paid.Increment(1)
        If DashboardProgressBar_Paid.Value >= NewPorcentage_PaidValue Then
            DashboardProgressBar_Paid.Value = NewPorcentage_PaidValue
            AnimationTimerPaidValue_Subir.Stop()
        End If
    End Sub

    Private Sub AnimationTimerPaidValue_Descer_Tick(sender As Object, e As EventArgs) Handles AnimationTimerPaidValue_Descer.Tick
        AnimationTimerPaidValue_Descer.Interval = _PROPERTY_DASHBOARD_ANIMATION_SPEED

        DashboardProgressBar_Paid.Value -= 1
        If DashboardProgressBar_Paid.Value <= NewPorcentage_PaidValue Then
            DashboardProgressBar_Paid.Value = NewPorcentage_PaidValue
            AnimationTimerPaidValue_Descer.Stop()
        End If
    End Sub



    Private Sub ChangePorcentageValue_RestToPay(ByVal new_value As Decimal)
        NewPorcentage_RestToPay = new_value
        If DashboardProgressBar_Rest.Value > new_value Then
            AnimationTimerRestToPay_Descer.Start() : AnimationTimerRestToPay_Subir.Stop()
        Else
            AnimationTimerRestToPay_Subir.Start() : AnimationTimerRestToPay_Descer.Stop()
        End If
    End Sub

    Private Sub AnimationTimerRestToPay_Subir_Tick(sender As Object, e As EventArgs) Handles AnimationTimerRestToPay_Subir.Tick
        AnimationTimerRestToPay_Subir.Interval = _PROPERTY_DASHBOARD_ANIMATION_SPEED

        DashboardProgressBar_Rest.Increment(1)
        If DashboardProgressBar_Rest.Value >= NewPorcentage_RestToPay Then
            DashboardProgressBar_Rest.Value = NewPorcentage_RestToPay
            AnimationTimerRestToPay_Subir.Stop()
        End If
    End Sub

    Private Sub AnimationTimerRestToPay_Descer_Tick(sender As Object, e As EventArgs) Handles AnimationTimerRestToPay_Descer.Tick
        AnimationTimerRestToPay_Descer.Interval = _PROPERTY_DASHBOARD_ANIMATION_SPEED

        DashboardProgressBar_Rest.Value -= 1
        If DashboardProgressBar_Rest.Value <= NewPorcentage_RestToPay Then
            DashboardProgressBar_Rest.Value = NewPorcentage_RestToPay
            AnimationTimerRestToPay_Descer.Stop()
        End If
    End Sub


#End Region






#Region "PACOTE DE IDIOMAS"

    ''' <summary>
    ''' Aplicar Idioma no Form
    ''' </summary>
    Private Sub ApplyLanguage()

        ''TAB PAGES MONTHS''
        TabPage01_Janeiro.Text = _LANGUAGE.RESOURCES.Dates.Month01
        TabPage02_Fevereiro.Text = _LANGUAGE.RESOURCES.Dates.Month02
        TabPage03_Março.Text = _LANGUAGE.RESOURCES.Dates.Month03
        TabPage04_Abril.Text = _LANGUAGE.RESOURCES.Dates.Month04
        TabPage05_Maio.Text = _LANGUAGE.RESOURCES.Dates.Month05
        TabPage06_Junho.Text = _LANGUAGE.RESOURCES.Dates.Month06
        TabPage07_Julho.Text = _LANGUAGE.RESOURCES.Dates.Month07
        TabPage08_Agosto.Text = _LANGUAGE.RESOURCES.Dates.Month08
        TabPage09_Setembro.Text = _LANGUAGE.RESOURCES.Dates.Month09
        TabPage10_Outubro.Text = _LANGUAGE.RESOURCES.Dates.Month10
        TabPage11_Novembro.Text = _LANGUAGE.RESOURCES.Dates.Month11
        TabPage12_Dezembro.Text = _LANGUAGE.RESOURCES.Dates.Month12


        ''MENU''
        ' MenuItemList_NewExpense.MenuText = _LANGUAGE.SCREENS.S_Home.MENU01_NovaDespesa
        '  MenuItemList_AddCreditCard.MenuText = _LANGUAGE.SCREENS.S_Home.MENU02_AddCartão
        'MenuItemList_Dashboard.MenuText = _LANGUAGE.SCREENS.S_Home.MENU03_Dashborad
        ' MenuItemListControl_Categorys.MenuText = _LANGUAGE.SCREENS.S_Home.MENU04_Categorias
        ' MenuItemList_SoftwareSettings.MenuText = _LANGUAGE.SCREENS.S_Home.MENU05_Configurações
        ' MenuItemList_CheckForUptdates.MenuText = _LANGUAGE.SCREENS.S_Home.MENU06_Atualizações
        ' MenuItemList_AboutSoftwares.MenuText = _LANGUAGE.SCREENS.S_Home.MENU07_Info
        '  MenuItemList_CloseCount.MenuText = _LANGUAGE.SCREENS.S_Home.MENU08_Sair

        ''DASHBOARD''
        Label_ValorPago.Text = _LANGUAGE.SCREENS.S_Home.Dashboard01_Pago
        Label_FaltaParaQuitar.Text = _LANGUAGE.SCREENS.S_Home.Dashboard02_Falta
        Label_Despesas.Text = _LANGUAGE.SCREENS.S_Home.Dashboard03_Despesa
        Label_Cartões.Text = _LANGUAGE.SCREENS.S_Home.Dashboard04_Cartão

        ''TOOL TIP''
        ToolTip1.SetToolTip(CalendarViewModeButton, _LANGUAGE.SCREENS.S_Home.Tip01_ModoCalendario)
        ToolTip1.SetToolTip(BlocksViewModeButton, _LANGUAGE.SCREENS.S_Home.Tip02_ModoBlocos)
        ToolTip1.SetToolTip(FiltersButton, _LANGUAGE.SCREENS.S_Home.Tip03_SelecionarTipoDeFiltro)
        ToolTip1.SetToolTip(SelectedFilter_Label, _LANGUAGE.SCREENS.S_Home.Tip04_Filtro)
    End Sub








#End Region




    Private Sub XpegCountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Iniciando o XPEG Count")

        ''Imagens:
        'Inverter Hori/Vert
        'Trocar a Cor 
        'Inverter a Cor
        'Girar <->
        'Alterar o Tamanho

        ''Interface:
        'Arredondar Bordas de um Objeto (Panels / UserControls)

        ''Layout:
        'Front(object)
        'Back(object)


        '_Layout.Back(Me)

        ' _Layout.Front(Me)


        _FUNCTIONS.Interfaces.MakeRoundedEdges(BlocksViewModeButton)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CalendarViewModeButton)

        '(object).BringToFront()
        '(object).SendToBack()


        AdjustMenuIcons() : CloseMenu()


        FiltersBackgroundPanel.Width = 0
        Dim CategorysList = _CATEGORYS.GetAllCategorys
        MdComboBox_Categorys.Items.Add("")
        For Each CATEGORY As String In CategorysList : MdComboBox_Categorys.Items.Add(_CATEGORYS.GetName(CATEGORY)) : Next
        HideAllBlocksFilters()
    End Sub

  
  
    Private Sub Button_ApplyFilters_Click(sender As Object, e As EventArgs) Handles ApplyFiltersButton.Click

    End Sub


    Private Sub Btn_BlocksFilter_MouseClick(sender As Object, e As MouseEventArgs) Handles FiltersButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FiltersBackgroundPanel.Width > 0 Then FiltersBackgroundPanel.Width = 0 Else FiltersBackgroundPanel.Width = 280
        End If
    End Sub

    Private Sub Btn_BlocksFilter_MouseDown(sender As Object, e As MouseEventArgs) Handles FiltersButton.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then FiltersButton.Image = My.Resources.Icon_BlockModeFilter_Down_24x24
    End Sub

    Private Sub Btn_BlocksFilter_MouseEnter(sender As Object, e As EventArgs) Handles FiltersButton.MouseEnter
        FiltersButton.Image = My.Resources.Icon_BlockModeFilter_Enter_24x24
    End Sub

    Private Sub Btn_BlocksFilter_MouseLeave(sender As Object, e As EventArgs) Handles FiltersButton.MouseLeave
        FiltersButton.Image = My.Resources.Icon_BlockModeFilter_Normal_24x24
    End Sub

 


#Region "Clique dos Itens do Menu Principal"

    Private Sub NewExpenseMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles NewExpenseMenuItem.MouseClick
        Dim NewExpense As New NewExpenseDialog
        NewExpense.ShowDialog()
    End Sub

    Private Sub AddCreditCardMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles AddCreditCardMenuItem.MouseClick
        Dim AddCreditCard As New NewCreditCardDialog
        AddCreditCard.ShowDialog()
    End Sub

    Private Sub ExpensesArchiveMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles ExpensesArchiveMenuItem.MouseClick

    End Sub

    Private Sub SettingsMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingsMenuItem.MouseClick
        SettingsCountDialog.ShowDialog()
    End Sub

    Private Sub HelpCenterMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles HelpCenterMenuItem.MouseClick
        HelpCenterForm.ShowDialog()
    End Sub

    Private Sub FeedBackMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles FeedBackMenuItem.MouseClick
        Dim FeedBack As New FeedBackDialog
        FeedBack.ShowDialog()
    End Sub

    Private Sub DonateMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles DonateMenuItem.MouseClick
        DonateDialog.ShowDialog()
    End Sub

    Private Sub InfSoftwareMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles InfSoftwareMenuItem.MouseClick
        AboutSoftwareDialog.ShowDialog()
    End Sub

    Private Sub ExitMenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles ExitMenuItem.MouseClick
        Me.Close()
    End Sub

#End Region

#Region "Teclas de Atalho para Comandos"

    Private Sub NewExpenseKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewExpenseKeyToolStripMenuItem.Click
        Dim NewExpense As New NewExpenseDialog
        NewExpense.ShowDialog()
    End Sub

    Private Sub AddCreditCardKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCreditCardKeyToolStripMenuItem.Click
        Dim AddCreditCard As New NewCreditCardDialog
        AddCreditCard.ShowDialog()
    End Sub

    Private Sub OpenSettingsKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSettingsKeyToolStripMenuItem.Click
        SettingsCountDialog.ShowDialog()
    End Sub

    Private Sub OpenHelpCenterKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenHelpCenterKeyToolStripMenuItem.Click
        HelpCenterForm.ShowDialog()
    End Sub

    Private Sub OpenInfoSoftwareKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInfoSoftwareKeyToolStripMenuItem.Click
        AboutSoftwareDialog.ShowDialog()
    End Sub

    Private Sub OpenFiltersKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFiltersKeyToolStripMenuItem.Click
        If FiltersBackgroundPanel.Width > 0 Then FiltersBackgroundPanel.Width = 0 Else FiltersBackgroundPanel.Width = 280
    End Sub

    Private Sub OpenMenuKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMenuKeyToolStripMenuItem.Click
        If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then OpenMenu() Else CloseMenu()
    End Sub

    Private Sub FindSearchKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindSearchKeyToolStripMenuItem.Click

    End Sub

    Private Sub ChangeViewModeKeyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeViewModeKeyToolStripMenuItem.Click
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar : BlocksModeView()
            Case ViewModeHomeScreen.Blocks : CalendarModeView()
        End Select
    End Sub
#End Region


#Region "Filtros das Exchanges"

#Region "Modo de Visualização"

    Private Sub BlocksViewModeButton_MouseClick(sender As Object, e As MouseEventArgs) Handles BlocksViewModeButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then ModeViewerDashboard_Blocks()
    End Sub
    Private Sub BlocksViewModeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles BlocksViewModeButton.MouseDown
        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks
            Case Else : BlocksViewModeButton.BackColor = Color.FromArgb(80, 80, 80)
        End Select
    End Sub
    Private Sub BlocksViewModeButton_MouseEnter(sender As Object, e As EventArgs) Handles BlocksViewModeButton.MouseEnter
        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks : BlocksViewModeButton.BackColor = Color.FromArgb(245, 194, 73)
            Case Else : BlocksViewModeButton.BackColor = Color.FromArgb(70, 70, 70)
        End Select
    End Sub
    Private Sub BlocksViewModeButton_MouseLeave(sender As Object, e As EventArgs) Handles BlocksViewModeButton.MouseLeave
        Select Case ViewMode
            Case ViewModeHomeScreen.Blocks : BlocksViewModeButton.BackColor = Color.FromArgb(240, 189, 68)
            Case Else : BlocksViewModeButton.BackColor = Color.Transparent
        End Select
    End Sub


    Private Sub CalendarViewModeButton_MouseClick(sender As Object, e As MouseEventArgs) Handles CalendarViewModeButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then CalendarModeView()
    End Sub
    Private Sub CalendarViewModeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CalendarViewModeButton.MouseDown
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar
            Case Else : CalendarViewModeButton.BackColor = Color.FromArgb(80, 80, 80)
        End Select
    End Sub
    Private Sub CalendarViewModeButton_MouseEnter(sender As Object, e As EventArgs) Handles CalendarViewModeButton.MouseEnter
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar : CalendarViewModeButton.BackColor = Color.FromArgb(5, 173, 250)
            Case Else : CalendarViewModeButton.BackColor = Color.FromArgb(70, 70, 70)
        End Select
    End Sub
    Private Sub CalendarViewModeButton_MouseLeave(sender As Object, e As EventArgs) Handles CalendarViewModeButton.MouseLeave
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar : CalendarViewModeButton.BackColor = Color.FromArgb(0, 168, 255)
            Case Else : CalendarViewModeButton.BackColor = Color.Transparent
        End Select
    End Sub

    'Private Sub Btn_ModeView_Blocks_MouseClick(sender As Object, e As MouseEventArgs) Handles BlocksModeButton.MouseClick
    '    
    'End Sub

    'Private Sub Btn_ModeView_Blocks_MouseDown(sender As Object, e As MouseEventArgs) Handles BlocksModeButton.MouseDown
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        Select Case ViewMode
    '            Case ViewModeHomeScreen.Blocks : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.DarkBlue)
    '            Case Else : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.FromArgb(240, 240, 240))
    '        End Select
    '    End If
    'End Sub

    'Private Sub Btn_ModeView_Blocks_MouseEnter(sender As Object, e As EventArgs) Handles BlocksModeButton.MouseEnter
    '    Select Case ViewMode
    '        Case ViewModeHomeScreen.Blocks : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.DarkBlue)
    '        Case Else : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.FromArgb(245, 245, 245))
    '    End Select
    'End Sub

    'Private Sub Btn_ModeView_Blocks_MouseLeave(sender As Object, e As EventArgs) Handles BlocksModeButton.MouseLeave
    '    Select Case ViewMode
    '        Case ViewModeHomeScreen.Blocks : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.DarkBlue)
    '        Case Else : BlocksModeButton.Image = _FUNCTIONS.Images.InvertColorFromImage(ModeViewBlocksIcon, Color.FromArgb(255, 255, 255))
    '    End Select
    'End Sub



    'Private Sub Btn_ModeView_Calendar_MouseClick(sender As Object, e As MouseEventArgs) Handles CalendarModeButton.MouseClick
    '    
    'End Sub

    'Private Sub Btn_ModeView_Calendar_MouseDown(sender As Object, e As MouseEventArgs) Handles CalendarModeButton.MouseDown
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        Select Case ViewMode
    '            Case ViewModeHomeScreen.Calendar : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Selected_24x24
    '            Case Else : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Down_24x24
    '        End Select
    '    End If
    'End Sub

    'Private Sub Btn_ModeView_Calendar_MouseEnter(sender As Object, e As EventArgs) Handles CalendarModeButton.MouseEnter
    '    Select Case ViewMode
    '        Case ViewModeHomeScreen.Calendar : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Selected_24x24
    '        Case Else : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Enter_24x24
    '    End Select
    'End Sub

    'Private Sub Btn_ModeView_Calendar_MouseLeave(sender As Object, e As EventArgs) Handles CalendarModeButton.MouseLeave
    '    Select Case ViewMode
    '        Case ViewModeHomeScreen.Calendar : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Selected_24x24
    '        Case Else : CalendarModeButton.Image = My.Resources.Icon_ModeView_Calendar_Normal_24x24
    '    End Select
    'End Sub

#End Region

#Region "Dashboard - Seleção de Periodos"
    Private Sub ByYear_DashboardPeriodRadioButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ByYear_DashboardPeriodRadioButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then DashBoardPeriod_ByYear()
    End Sub

    Private Sub ByMonth_DashboardPeriodRadioButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ByMonth_DashboardPeriodRadioButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then DashBoardPeriod_ByMonth()
    End Sub

    Private Sub AllTime_DashboardPeriodRadioButton_MouseClick(sender As Object, e As MouseEventArgs) Handles AllTime_DashboardPeriodRadioButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then DashBoardPeriod_AllTime()
    End Sub
#End Region

#Region "Filtros de Data"

    Private Sub YearFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearFilterComboBox.SelectedIndexChanged
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar
                CalendarYear = "01/01/" & YearFilterComboBox.SelectedItem : ImportExpensesList()
        End Select
    End Sub

    Private Sub MonthFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthFilterComboBox.SelectedIndexChanged
        Select Case ViewMode
            Case ViewModeHomeScreen.Calendar
                TabControl_ExpensesMonths.SelectedIndex = MonthFilterComboBox.SelectedIndex
        End Select
    End Sub

#End Region

#End Region

#Region "Modo de Visualização da Tela Principal"


    Public Sub ModeViewerDashboard_Blocks()
        ''Limpar Listas de Anos:
        YearFilterComboBox.Items.Clear()
        ''Adicionar Lista de Anos:
        For Each Y As String In ExpensesYearList : YearFilterComboBox.Items.Add(Y) : Next

        ''Limpar Lista de Meses:
        MonthFilterComboBox.Items.Clear()
        ''Adicionar Lista de Meses:
        MonthFilterComboBox.Items.AddRange({"", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})



        ''Exibir Botão "Aplicar Filtros:
        ApplyFiltersButton.Show()

        ''Exibir Filtros desse Modo de Visualização:
        FilterByDate_BlockFilter.Show()
        FilterByCategory_BlockFilter.Show()
        'FilterByValue_BlockFilter.Show() [NÃO DISPONÍVEL NESSA VERSÃO]
        FilterByOrder_BlockFilter.Show()

        ''Esconder Legenda de Filtros não disponível:
        NoFilterAvailabledLabel.Hide()

        ''Alterar Cores dos Botões Seletores:
        CalendarViewModeButton.BackColor = Color.Transparent
        BlocksViewModeButton.BackColor = Color.FromArgb(240, 189, 68)


        'Alterar Modo na VAR
        ViewMode = ViewModeHomeScreen.Blocks
        'Exibir Opções de filtro
        'BackgroundSeparatorPanel.Show() : Btn_BlocksFilter.Show()
        'Alterar Seletores
        DashboardOptions_BlockFilter.Hide() : Btn_BackYear.Hide() : Btn_NextYear.Hide()
        SelectedFilter_Label.Text = "Despesas" '_FUNCTIONS.GetMonthName(CalendarYear.Date.Month) & " de " & CalendarYear.Date.Year
        'Alterar Visualização:
        BlocksModePanel.Show() : CalendarModePanel.Hide()

        'Alterar Modo de Calculos da Dashboard
        ModeValuesDashboard_All()

        'Salvar Modo de Visualização Escolhido pelo Usuário
        XpegCountSettings.Default.ViewMode = ViewMode
        XpegCountSettings.Default.Save()
    End Sub

 

    ''' <summary>
    ''' Habilitar Modo Calendário
    ''' </summary>
    Private Sub CalendarModeView()
        '':::::::::::::::::::::::::::::: FILTROS ::::::::::::::::::::::::::::::''

        ''-------------------- ALTERAR SELETORES --------------------''
        ''Selecionar Botão de "Calendário":
        CalendarViewModeButton.BackColor = Color.FromArgb(0, 168, 255)
        ''Descarmar Botão de "Blocos":
        BlocksViewModeButton.BackColor = Color.Transparent

        ''-------------------- EXIBIR FILTROS --------------------''
        ''Filtro de Data:
        FilterByDate_BlockFilter.Show()
        ''Opções de Dashboard:
        DashboardOptions_BlockFilter.Show()

        ''-------------------- OCULTAR FILTROS --------------------''
        ''Filtro de Categoria:
        FilterByCategory_BlockFilter.Hide()
        ''Filtro de Valores:
        FilterByValue_BlockFilter.Hide() '[NÃO DISPONÍVEL NESSA VERSÃO]
        ''Filtro de Ordem de Prioridade:
        FilterByOrder_BlockFilter.Hide()
        ''Botão de "Aplicar Filtros":
        ApplyFiltersButton.Hide()

        ''-------------------- AJUSTAR FILTROS POR DATA --------------------''
        ''Limpar ComboBox de Anos:
        YearFilterComboBox.Items.Clear()
        ''Limpar ComboBox de Meses:
        MonthFilterComboBox.Items.Clear()
        ''Adicionar 'Anos' ao ComboBox: 
        For Each Y As String In ExpensesYearList : YearFilterComboBox.Items.Add(Y) : Next
        ''Adicionar 'Meses' ao ComboBox: 
        MonthFilterComboBox.Items.AddRange({"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        ''Selecionar Ano no ComboBox (de acordo com o ano selecionado):
        YearFilterComboBox.SelectedItem = CalendarYear.Date.Year.ToString()
        ''Selecionar Mês no ComboBox (de acordo com a guia de mês selecionada):
        MonthFilterComboBox.SelectedIndex = TabControl_ExpensesMonths.SelectedIndex

        ''::::::::::::::::::::::::::::: DASHBOARD :::::::::::::::::::::::::::::''
        ''Alterar Modo de Visualização no Sistema:
        ViewMode = ViewModeHomeScreen.Calendar

        ''Alterar Modo de Calculos da Dashboard:
        ModeValuesDashboard_ForMonth()

        ''::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::''
        ''Salvar Configuração de Modo de Visualização:
        XpegCountSettings.Default.ViewMode = ViewMode
        XpegCountSettings.Default.Save()
        ''Atribuir na Label o Mês e Ano Selecionados:
        SelectedFilter_Label.Text = MonthFilterComboBox.SelectedItem & " de " & CalendarYear.Date.Year
        ''Alterar Modo de Visualização para o Modo Calendário:
        BlocksModePanel.Hide() : CalendarModePanel.Show()

    End Sub

    ''' <summary>
    ''' Habilitar Modo Blocos
    ''' </summary>
    Private Sub BlocksModeView()
        ModeViewerDashboard_Blocks() ''temporario
    End Sub

#End Region




    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: ELEMENTOS DA INTERFACE ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::'

#Region "Blocos de Filtros"

    Private Sub CloseFiltersButton_MouseClick(sender As Object, e As MouseEventArgs) Handles CloseFiltersButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then FiltersBackgroundPanel.Width = 0
    End Sub

    Private Sub DisplayAllFiltersBlocksButton_MouseClick(sender As Object, e As MouseEventArgs) Handles DisplayAllFiltersBlocksButton.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then ShowAllBlocksFilters()
    End Sub

    Private Sub ModeView_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles ModeView_BlockFilterPanelTitle.MouseClick, ModeView_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If ModeView_BlockFilter.Height = 31 Then ModeView_BlockFilter.Height = ModeView_BlockFilter.MaximumSize.Height Else ModeView_BlockFilter.Height = 31
        End If
    End Sub
    Private Sub ModeView_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles ModeView_BlockFilterPanelTitle.MouseEnter, ModeView_BlockFilterLabelTitle.MouseEnter
        ModeView_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub ModeView_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles ModeView_BlockFilterPanelTitle.MouseLeave, ModeView_BlockFilterLabelTitle.MouseLeave
        ModeView_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub



    Private Sub FilterByDate_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles FilterByDate_BlockFilterPanelTitle.MouseClick, FilterByDate_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FilterByDate_BlockFilter.Height = 31 Then FilterByDate_BlockFilter.Height = FilterByDate_BlockFilter.MaximumSize.Height Else FilterByDate_BlockFilter.Height = 31
        End If
    End Sub

    Private Sub FilterByDate_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles FilterByDate_BlockFilterPanelTitle.MouseEnter, FilterByDate_BlockFilterLabelTitle.MouseEnter
        FilterByDate_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub FilterByDate_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles FilterByDate_BlockFilterPanelTitle.MouseLeave, FilterByDate_BlockFilterLabelTitle.MouseLeave
        FilterByDate_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub



    Private Sub FilterByCategory_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles FilterByCategory_BlockFilterPanelTitle.MouseClick, FilterByCategory_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FilterByCategory_BlockFilter.Height = 31 Then FilterByCategory_BlockFilter.Height = FilterByCategory_BlockFilter.MaximumSize.Height Else FilterByCategory_BlockFilter.Height = 31
        End If
    End Sub
    Private Sub FilterByCategory_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles FilterByCategory_BlockFilterPanelTitle.MouseEnter, FilterByCategory_BlockFilterLabelTitle.MouseEnter
        FilterByCategory_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub FilterByCategory_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles FilterByCategory_BlockFilterPanelTitle.MouseLeave, FilterByCategory_BlockFilterLabelTitle.MouseLeave
        FilterByCategory_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub


    Private Sub FilterByValue_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles FilterByValue_BlockFilterPanelTitle.MouseClick, FilterByValue_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FilterByValue_BlockFilter.Height = 31 Then FilterByValue_BlockFilter.Height = FilterByValue_BlockFilter.MaximumSize.Height Else FilterByValue_BlockFilter.Height = 31
        End If
    End Sub
    Private Sub FilterByValue_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles FilterByValue_BlockFilterPanelTitle.MouseEnter, FilterByValue_BlockFilterLabelTitle.MouseEnter
        FilterByValue_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub FilterByValue_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles FilterByValue_BlockFilterPanelTitle.MouseLeave, FilterByValue_BlockFilterLabelTitle.MouseLeave
        FilterByValue_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub



    Private Sub FilterByOrder_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles FilterByOrder_BlockFilterPanelTitle.MouseClick, FilterByOrder_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FilterByOrder_BlockFilter.Height = 31 Then FilterByOrder_BlockFilter.Height = FilterByOrder_BlockFilter.MaximumSize.Height Else FilterByOrder_BlockFilter.Height = 31
        End If
    End Sub
    Private Sub FilterByOrder_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles FilterByOrder_BlockFilterPanelTitle.MouseEnter, FilterByOrder_BlockFilterLabelTitle.MouseEnter
        FilterByOrder_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub FilterByOrder_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles FilterByOrder_BlockFilterPanelTitle.MouseLeave, FilterByOrder_BlockFilterLabelTitle.MouseLeave
        FilterByOrder_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub



    Private Sub DashboardOptions_BlockFilterPanelTitle_MouseClick(sender As Object, e As MouseEventArgs) Handles DashboardOptions_BlockFilterPanelTitle.MouseClick, DashboardOptions_BlockFilterLabelTitle.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If DashboardOptions_BlockFilter.Height = 31 Then DashboardOptions_BlockFilter.Height = DashboardOptions_BlockFilter.MaximumSize.Height Else DashboardOptions_BlockFilter.Height = 31
        End If
    End Sub
    Private Sub DashboardOptions_BlockFilterPanelTitle_MouseEnter(sender As Object, e As EventArgs) Handles DashboardOptions_BlockFilterPanelTitle.MouseEnter, DashboardOptions_BlockFilterLabelTitle.MouseEnter
        DashboardOptions_BlockFilterPanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub
    Private Sub DashboardOptions_BlockFilterPanelTitle_MouseLeave(sender As Object, e As EventArgs) Handles DashboardOptions_BlockFilterPanelTitle.MouseLeave, DashboardOptions_BlockFilterLabelTitle.MouseLeave
        DashboardOptions_BlockFilterPanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub

    Private Sub HideAllBlocksFilters()
        For Each BLOCK_FILTER As Object In FiltersBlocksPanel.Controls : BLOCK_FILTER.Height = 31 : Next
    End Sub

    Private Sub ShowAllBlocksFilters()
        For Each BLOCK_FILTER As Object In FiltersBlocksPanel.Controls : BLOCK_FILTER.Height = BLOCK_FILTER.MaximumSize.Height : Next
    End Sub
#End Region

#Region "Menu do Count"

#Region "Ajustes dos Icones do Menu"
    ''' <summary>
    ''' Ajustar Icones do Menu
    ''' </summary>
    Private Sub AdjustMenuIcons()
        ''Ajustar Icone do Botão do Menu:
        'MenuButton.Image = _FUNCTIONS.Images.ChangeImageResolution(MenuButton.Image, 28)
    End Sub
#End Region

#Region "Animação do Menu"
    Dim WithEvents OpeningMenuAnimation As New Timer
    Dim WithEvents ClosingMenuAnimation As New Timer
    Private Sub OpeningMenuAnimation_Tick(sender As Object, e As EventArgs) Handles OpeningMenuAnimation.Tick
        OpeningMenuAnimation.Interval = 1 : ClosingMenuAnimation.Stop()
        MenuHomeBackground.Width += 10
        If MenuHomeBackground.Width >= MenuHomeBackground.MaximumSize.Width Then OpeningMenuAnimation.Stop()
    End Sub
    Private Sub ClosingMenuAnimation_Tick(sender As Object, e As EventArgs) Handles ClosingMenuAnimation.Tick
        ClosingMenuAnimation.Interval = 1 : OpeningMenuAnimation.Stop()
        MenuHomeBackground.Width -= 20
        If MenuHomeBackground.Width <= MenuHomeBackground.MinimumSize.Width Then ClosingMenuAnimation.Stop()
    End Sub

#End Region

#Region "Botão do Menu"
    Private Sub MenuButton_MouseClick(sender As Object, e As MouseEventArgs) Handles MenuButton.MouseClick, MenuHeader.MouseClick, CountLogoPanel.MouseClick, CountTitleLabel.MouseClick, xpegTitleLabel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then OpenMenu() Else CloseMenu()
        End If
    End Sub
    Private Sub MenuButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuButton.MouseDown, MenuHeader.MouseDown, CountLogoPanel.MouseDown, CountTitleLabel.MouseDown, xpegTitleLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then
                MenuHeader.BackColor = Color.FromArgb(25, 25, 25)
            Else
                MenuHeader.BackColor = Color.FromArgb(20, 20, 20)
            End If
        End If
    End Sub
    Private Sub MenuButton_MouseEnter(sender As Object, e As EventArgs) Handles MenuButton.MouseEnter, MenuHeader.MouseEnter, CountLogoPanel.MouseEnter, CountTitleLabel.MouseEnter, xpegTitleLabel.MouseEnter
        If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then
            MenuHeader.BackColor = Color.FromArgb(20, 20, 20)
        Else
            MenuHeader.BackColor = Color.FromArgb(25, 25, 25)
        End If
    End Sub
    Private Sub MenuButton_MouseLeave(sender As Object, e As EventArgs) Handles MenuButton.MouseLeave, MenuHeader.MouseLeave, CountLogoPanel.MouseLeave, CountTitleLabel.MouseLeave, xpegTitleLabel.MouseLeave
        If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then
            MenuHeader.BackColor = Color.FromArgb(15, 15, 15)
        Else
            MenuHeader.BackColor = Color.Transparent
        End If
    End Sub
#End Region

#Region "Abrir e Fechar Menu"

    ''' <summary>
    ''' Abrir Menu do XPEG Count
    ''' </summary>
    Public Sub OpenMenu()
        If MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width Then MenuHomeBackground.Width = MenuHomeBackground.MaximumSize.Width
        MenuButton.Dock = DockStyle.None : MenuHeader.BackColor = Color.Transparent
        CountLogoPanel.Show()
    End Sub

    ''' <summary>
    ''' Fechar Menu do XPEG Count
    ''' </summary>
    Public Sub CloseMenu()
        If MenuHomeBackground.Width > MenuHomeBackground.MinimumSize.Width Then MenuHomeBackground.Width = MenuHomeBackground.MinimumSize.Width
        MenuButton.Dock = DockStyle.Fill : MenuHeader.BackColor = Color.FromArgb(15, 15, 15)
        CountLogoPanel.Hide()
    End Sub

#End Region

#End Region





  

    

  
  
  
   

    Private Sub SelectedFilter_Label_Click(sender As Object, e As EventArgs) Handles SelectedFilter_Label.Click
        'UpgradeFileSystemDialog.ShowDialog()
        SlideShowForm.ShowDialog()
    End Sub
End Class
