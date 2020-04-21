<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class XpegCountForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XpegCountForm))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.ModeViewSelectorPanel = New System.Windows.Forms.Panel()
        Me.FiltersButton = New System.Windows.Forms.PictureBox()
        Me.SelectorYear_Panel = New System.Windows.Forms.Panel()
        Me.SelectedFilter_Label = New System.Windows.Forms.Label()
        Me.Btn_BackYear = New System.Windows.Forms.PictureBox()
        Me.Btn_NextYear = New System.Windows.Forms.PictureBox()
        Me.MenuStripKeys = New System.Windows.Forms.MenuStrip()
        Me.TeclasDeAtalhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewExpenseKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCreditCardKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenSettingsKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenHelpCenterKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInfoSoftwareKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenMenuKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFiltersKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindSearchKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeViewModeKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl_ExpensesMonths = New System.Windows.Forms.TabControl()
        Me.TabPage01_Janeiro = New System.Windows.Forms.TabPage()
        Me.TabPage02_Fevereiro = New System.Windows.Forms.TabPage()
        Me.TabPage03_Março = New System.Windows.Forms.TabPage()
        Me.TabPage04_Abril = New System.Windows.Forms.TabPage()
        Me.TabPage05_Maio = New System.Windows.Forms.TabPage()
        Me.TabPage06_Junho = New System.Windows.Forms.TabPage()
        Me.TabPage07_Julho = New System.Windows.Forms.TabPage()
        Me.TabPage08_Agosto = New System.Windows.Forms.TabPage()
        Me.TabPage09_Setembro = New System.Windows.Forms.TabPage()
        Me.TabPage10_Outubro = New System.Windows.Forms.TabPage()
        Me.TabPage11_Novembro = New System.Windows.Forms.TabPage()
        Me.TabPage12_Dezembro = New System.Windows.Forms.TabPage()
        Me.FileWatcher_Expenses = New System.IO.FileSystemWatcher()
        Me.FileWatcher_Values = New System.IO.FileSystemWatcher()
        Me.DashboradPanel = New System.Windows.Forms.Panel()
        Me.Separator01 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DashboardPanel_CreditCards = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.DashboardIcon_CreditCards = New System.Windows.Forms.PictureBox()
        Me.Label_Cartões = New System.Windows.Forms.Label()
        Me.TotalValue_AllCreditCards_Label = New System.Windows.Forms.Label()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.NumberOfCards_Label = New System.Windows.Forms.Label()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.DashboardPanel_ExpensesValue = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.DashboradIcon_Expenses = New System.Windows.Forms.PictureBox()
        Me.Label_Despesas = New System.Windows.Forms.Label()
        Me.TotalValue_AllExpenses_Label = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.NumberOfExpenses_Label = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.DashboardPanel_RestToPayValue = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.DashboardIcon_RestToPay = New System.Windows.Forms.PictureBox()
        Me.Label_FaltaParaQuitar = New System.Windows.Forms.Label()
        Me.TotalValue_RestToPay_Label = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DashboardProgressBar_Rest = New xpeg_count_project.DashboardProgressBarCircle()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.DashboardPanel_ValuePaid = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DashboardIcon_ValuePaid = New System.Windows.Forms.PictureBox()
        Me.Label_ValorPago = New System.Windows.Forms.Label()
        Me.TotalValue_Paid_Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DashboardProgressBar_Paid = New xpeg_count_project.DashboardProgressBarCircle()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FormBackground = New System.Windows.Forms.Panel()
        Me.ControlsPanel = New System.Windows.Forms.Panel()
        Me.CalendarModePanel = New System.Windows.Forms.Panel()
        Me.BlocksModePanel = New System.Windows.Forms.Panel()
        Me.ExpenseBlocksFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ExpenseCategoryItemControl1 = New xpeg_count_project.ExpenseCategoryItemControl()
        Me.ExpenseCategoryItemControl2 = New xpeg_count_project.ExpenseCategoryItemControl()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalendarViewModeButton = New System.Windows.Forms.PictureBox()
        Me.BlocksViewModeButton = New System.Windows.Forms.PictureBox()
        Me.CloseFiltersButton = New System.Windows.Forms.PictureBox()
        Me.DisplayAllFiltersBlocksButton = New System.Windows.Forms.PictureBox()
        Me.FiltersBackgroundPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FiltersPanel = New System.Windows.Forms.Panel()
        Me.FiltersBlocksPanel = New System.Windows.Forms.Panel()
        Me.ApplyFiltersButton = New System.Windows.Forms.Button()
        Me.NoFilterAvailabledLabel = New System.Windows.Forms.Label()
        Me.FilterByOrder_BlockFilter = New System.Windows.Forms.Panel()
        Me.FilterByOrder_BlockFilterContainer = New System.Windows.Forms.Panel()
        Me.Panel38 = New System.Windows.Forms.Panel()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.MdComboBox2 = New xpeg_count_project.MDComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.FilterByOrder_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.FilterByOrder_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.FilterByValue_BlockFilter = New System.Windows.Forms.Panel()
        Me.FilterByValue_BlockFilterContainer = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.FilterByValue_BlockFilterSeparator = New System.Windows.Forms.Panel()
        Me.FilterByValue_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.FilterByValue_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.FilterByCategory_BlockFilter = New System.Windows.Forms.Panel()
        Me.FilterByCategory_BlockFilterContainer = New System.Windows.Forms.Panel()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.MdComboBox_Categorys = New xpeg_count_project.MDComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FilterByCategory_BlockFilterSeparator = New System.Windows.Forms.Panel()
        Me.FilterByCategory_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.FilterByCategory_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.FilterByDate_BlockFilter = New System.Windows.Forms.Panel()
        Me.FilterByDate_BlockFilterContainer = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.MonthFilterComboBox = New xpeg_count_project.MDComboBox()
        Me.Label_DiaDeVencimento = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.YearFilterComboBox = New xpeg_count_project.MDComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.FilterByDate_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.FilterByDate_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.DashboardOptions_BlockFilter = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel45 = New System.Windows.Forms.Panel()
        Me.AllTime_DashboardPeriodRadioButton = New xpeg_count_project.MDRadioButton()
        Me.ByMonth_DashboardPeriodRadioButton = New xpeg_count_project.MDRadioButton()
        Me.ByYear_DashboardPeriodRadioButton = New xpeg_count_project.MDRadioButton()
        Me.Panel46 = New System.Windows.Forms.Panel()
        Me.DashboardOptions_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.DashboardOptions_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.ModeView_BlockFilter = New System.Windows.Forms.Panel()
        Me.ModeView_BlockFilterContainer = New System.Windows.Forms.Panel()
        Me.ModeView_BlockFilterSeparator = New System.Windows.Forms.Panel()
        Me.ModeView_BlockFilterPanelTitle = New System.Windows.Forms.Panel()
        Me.ModeView_BlockFilterLabelTitle = New System.Windows.Forms.Label()
        Me.HeaderFiltersPanel = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label_Filtros = New System.Windows.Forms.Label()
        Me.MenuHomeBackground = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.MenuHomeElements = New System.Windows.Forms.Panel()
        Me.ExitMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.InfSoftwareMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.DonateMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.FeedBackMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.HelpCenterMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.SettingsMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.ExpensesArchiveMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.AddCreditCardMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.NewExpenseMenuItem = New xpeg_count_project.MenuItemListControl()
        Me.MenuHeader = New System.Windows.Forms.Panel()
        Me.MenuButton = New System.Windows.Forms.PictureBox()
        Me.CountLogoPanel = New System.Windows.Forms.Panel()
        Me.xpegTitleLabel = New System.Windows.Forms.Label()
        Me.CountTitleLabel = New System.Windows.Forms.Label()
        Me.HeaderPanel.SuspendLayout()
        Me.ModeViewSelectorPanel.SuspendLayout()
        CType(Me.FiltersButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SelectorYear_Panel.SuspendLayout()
        CType(Me.Btn_BackYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NextYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripKeys.SuspendLayout()
        Me.TabControl_ExpensesMonths.SuspendLayout()
        CType(Me.FileWatcher_Expenses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileWatcher_Values, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DashboradPanel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.DashboardPanel_CreditCards.SuspendLayout()
        Me.Panel31.SuspendLayout()
        CType(Me.DashboardIcon_CreditCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel32.SuspendLayout()
        Me.DashboardPanel_ExpensesValue.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.DashboradIcon_Expenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        Me.DashboardPanel_RestToPayValue.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.DashboardIcon_RestToPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.DashboardPanel_ValuePaid.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DashboardIcon_ValuePaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FormBackground.SuspendLayout()
        Me.ControlsPanel.SuspendLayout()
        Me.CalendarModePanel.SuspendLayout()
        Me.BlocksModePanel.SuspendLayout()
        Me.ExpenseBlocksFlowPanel.SuspendLayout()
        CType(Me.CalendarViewModeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlocksViewModeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseFiltersButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayAllFiltersBlocksButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltersBackgroundPanel.SuspendLayout()
        Me.FiltersPanel.SuspendLayout()
        Me.FiltersBlocksPanel.SuspendLayout()
        Me.FilterByOrder_BlockFilter.SuspendLayout()
        Me.FilterByOrder_BlockFilterContainer.SuspendLayout()
        Me.Panel39.SuspendLayout()
        Me.FilterByOrder_BlockFilterPanelTitle.SuspendLayout()
        Me.FilterByValue_BlockFilter.SuspendLayout()
        Me.FilterByValue_BlockFilterContainer.SuspendLayout()
        Me.FilterByValue_BlockFilterPanelTitle.SuspendLayout()
        Me.FilterByCategory_BlockFilter.SuspendLayout()
        Me.FilterByCategory_BlockFilterContainer.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.FilterByCategory_BlockFilterPanelTitle.SuspendLayout()
        Me.FilterByDate_BlockFilter.SuspendLayout()
        Me.FilterByDate_BlockFilterContainer.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.FilterByDate_BlockFilterPanelTitle.SuspendLayout()
        Me.DashboardOptions_BlockFilter.SuspendLayout()
        Me.Panel41.SuspendLayout()
        Me.Panel45.SuspendLayout()
        Me.DashboardOptions_BlockFilterPanelTitle.SuspendLayout()
        Me.ModeView_BlockFilter.SuspendLayout()
        Me.ModeView_BlockFilterContainer.SuspendLayout()
        Me.ModeView_BlockFilterPanelTitle.SuspendLayout()
        Me.HeaderFiltersPanel.SuspendLayout()
        Me.MenuHomeBackground.SuspendLayout()
        Me.MenuHomeElements.SuspendLayout()
        Me.MenuHeader.SuspendLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CountLogoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.HeaderPanel.Controls.Add(Me.ModeViewSelectorPanel)
        Me.HeaderPanel.Controls.Add(Me.SelectorYear_Panel)
        Me.HeaderPanel.Controls.Add(Me.MenuStripKeys)
        resources.ApplyResources(Me.HeaderPanel, "HeaderPanel")
        Me.HeaderPanel.Name = "HeaderPanel"
        '
        'ModeViewSelectorPanel
        '
        Me.ModeViewSelectorPanel.Controls.Add(Me.FiltersButton)
        resources.ApplyResources(Me.ModeViewSelectorPanel, "ModeViewSelectorPanel")
        Me.ModeViewSelectorPanel.Name = "ModeViewSelectorPanel"
        '
        'FiltersButton
        '
        resources.ApplyResources(Me.FiltersButton, "FiltersButton")
        Me.FiltersButton.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_BlockModeFilter_Normal_24x24
        Me.FiltersButton.Name = "FiltersButton"
        Me.FiltersButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.FiltersButton, resources.GetString("FiltersButton.ToolTip"))
        '
        'SelectorYear_Panel
        '
        Me.SelectorYear_Panel.Controls.Add(Me.SelectedFilter_Label)
        Me.SelectorYear_Panel.Controls.Add(Me.Btn_BackYear)
        Me.SelectorYear_Panel.Controls.Add(Me.Btn_NextYear)
        resources.ApplyResources(Me.SelectorYear_Panel, "SelectorYear_Panel")
        Me.SelectorYear_Panel.Name = "SelectorYear_Panel"
        '
        'SelectedFilter_Label
        '
        resources.ApplyResources(Me.SelectedFilter_Label, "SelectedFilter_Label")
        Me.SelectedFilter_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SelectedFilter_Label.Name = "SelectedFilter_Label"
        '
        'Btn_BackYear
        '
        resources.ApplyResources(Me.Btn_BackYear, "Btn_BackYear")
        Me.Btn_BackYear.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_BackYear_Normal_20x20
        Me.Btn_BackYear.Name = "Btn_BackYear"
        Me.Btn_BackYear.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_BackYear, resources.GetString("Btn_BackYear.ToolTip"))
        '
        'Btn_NextYear
        '
        resources.ApplyResources(Me.Btn_NextYear, "Btn_NextYear")
        Me.Btn_NextYear.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_NextYear_Normal_20x20
        Me.Btn_NextYear.Name = "Btn_NextYear"
        Me.Btn_NextYear.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_NextYear, resources.GetString("Btn_NextYear.ToolTip"))
        '
        'MenuStripKeys
        '
        resources.ApplyResources(Me.MenuStripKeys, "MenuStripKeys")
        Me.MenuStripKeys.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripKeys.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeclasDeAtalhoToolStripMenuItem})
        Me.MenuStripKeys.Name = "MenuStripKeys"
        '
        'TeclasDeAtalhoToolStripMenuItem
        '
        Me.TeclasDeAtalhoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewExpenseKeyToolStripMenuItem, Me.AddCreditCardKeyToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpenSettingsKeyToolStripMenuItem, Me.OpenHelpCenterKeyToolStripMenuItem, Me.OpenInfoSoftwareKeyToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpenMenuKeyToolStripMenuItem, Me.OpenFiltersKeyToolStripMenuItem, Me.FindSearchKeyToolStripMenuItem, Me.ToolStripMenuItem3, Me.ChangeViewModeKeyToolStripMenuItem})
        Me.TeclasDeAtalhoToolStripMenuItem.Name = "TeclasDeAtalhoToolStripMenuItem"
        resources.ApplyResources(Me.TeclasDeAtalhoToolStripMenuItem, "TeclasDeAtalhoToolStripMenuItem")
        '
        'NewExpenseKeyToolStripMenuItem
        '
        Me.NewExpenseKeyToolStripMenuItem.Name = "NewExpenseKeyToolStripMenuItem"
        resources.ApplyResources(Me.NewExpenseKeyToolStripMenuItem, "NewExpenseKeyToolStripMenuItem")
        '
        'AddCreditCardKeyToolStripMenuItem
        '
        Me.AddCreditCardKeyToolStripMenuItem.Name = "AddCreditCardKeyToolStripMenuItem"
        resources.ApplyResources(Me.AddCreditCardKeyToolStripMenuItem, "AddCreditCardKeyToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'OpenSettingsKeyToolStripMenuItem
        '
        Me.OpenSettingsKeyToolStripMenuItem.Name = "OpenSettingsKeyToolStripMenuItem"
        resources.ApplyResources(Me.OpenSettingsKeyToolStripMenuItem, "OpenSettingsKeyToolStripMenuItem")
        '
        'OpenHelpCenterKeyToolStripMenuItem
        '
        Me.OpenHelpCenterKeyToolStripMenuItem.Name = "OpenHelpCenterKeyToolStripMenuItem"
        resources.ApplyResources(Me.OpenHelpCenterKeyToolStripMenuItem, "OpenHelpCenterKeyToolStripMenuItem")
        '
        'OpenInfoSoftwareKeyToolStripMenuItem
        '
        Me.OpenInfoSoftwareKeyToolStripMenuItem.Name = "OpenInfoSoftwareKeyToolStripMenuItem"
        resources.ApplyResources(Me.OpenInfoSoftwareKeyToolStripMenuItem, "OpenInfoSoftwareKeyToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'OpenMenuKeyToolStripMenuItem
        '
        Me.OpenMenuKeyToolStripMenuItem.Name = "OpenMenuKeyToolStripMenuItem"
        resources.ApplyResources(Me.OpenMenuKeyToolStripMenuItem, "OpenMenuKeyToolStripMenuItem")
        '
        'OpenFiltersKeyToolStripMenuItem
        '
        Me.OpenFiltersKeyToolStripMenuItem.Name = "OpenFiltersKeyToolStripMenuItem"
        resources.ApplyResources(Me.OpenFiltersKeyToolStripMenuItem, "OpenFiltersKeyToolStripMenuItem")
        '
        'FindSearchKeyToolStripMenuItem
        '
        Me.FindSearchKeyToolStripMenuItem.Name = "FindSearchKeyToolStripMenuItem"
        resources.ApplyResources(Me.FindSearchKeyToolStripMenuItem, "FindSearchKeyToolStripMenuItem")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        '
        'ChangeViewModeKeyToolStripMenuItem
        '
        Me.ChangeViewModeKeyToolStripMenuItem.Name = "ChangeViewModeKeyToolStripMenuItem"
        resources.ApplyResources(Me.ChangeViewModeKeyToolStripMenuItem, "ChangeViewModeKeyToolStripMenuItem")
        '
        'TabControl_ExpensesMonths
        '
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage01_Janeiro)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage02_Fevereiro)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage03_Março)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage04_Abril)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage05_Maio)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage06_Junho)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage07_Julho)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage08_Agosto)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage09_Setembro)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage10_Outubro)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage11_Novembro)
        Me.TabControl_ExpensesMonths.Controls.Add(Me.TabPage12_Dezembro)
        resources.ApplyResources(Me.TabControl_ExpensesMonths, "TabControl_ExpensesMonths")
        Me.TabControl_ExpensesMonths.Multiline = True
        Me.TabControl_ExpensesMonths.Name = "TabControl_ExpensesMonths"
        Me.TabControl_ExpensesMonths.SelectedIndex = 0
        '
        'TabPage01_Janeiro
        '
        resources.ApplyResources(Me.TabPage01_Janeiro, "TabPage01_Janeiro")
        Me.TabPage01_Janeiro.BackColor = System.Drawing.Color.White
        Me.TabPage01_Janeiro.Name = "TabPage01_Janeiro"
        '
        'TabPage02_Fevereiro
        '
        resources.ApplyResources(Me.TabPage02_Fevereiro, "TabPage02_Fevereiro")
        Me.TabPage02_Fevereiro.Name = "TabPage02_Fevereiro"
        Me.TabPage02_Fevereiro.UseVisualStyleBackColor = True
        '
        'TabPage03_Março
        '
        resources.ApplyResources(Me.TabPage03_Março, "TabPage03_Março")
        Me.TabPage03_Março.Name = "TabPage03_Março"
        Me.TabPage03_Março.UseVisualStyleBackColor = True
        '
        'TabPage04_Abril
        '
        resources.ApplyResources(Me.TabPage04_Abril, "TabPage04_Abril")
        Me.TabPage04_Abril.Name = "TabPage04_Abril"
        Me.TabPage04_Abril.UseVisualStyleBackColor = True
        '
        'TabPage05_Maio
        '
        resources.ApplyResources(Me.TabPage05_Maio, "TabPage05_Maio")
        Me.TabPage05_Maio.Name = "TabPage05_Maio"
        Me.TabPage05_Maio.UseVisualStyleBackColor = True
        '
        'TabPage06_Junho
        '
        resources.ApplyResources(Me.TabPage06_Junho, "TabPage06_Junho")
        Me.TabPage06_Junho.Name = "TabPage06_Junho"
        Me.TabPage06_Junho.UseVisualStyleBackColor = True
        '
        'TabPage07_Julho
        '
        resources.ApplyResources(Me.TabPage07_Julho, "TabPage07_Julho")
        Me.TabPage07_Julho.Name = "TabPage07_Julho"
        Me.TabPage07_Julho.UseVisualStyleBackColor = True
        '
        'TabPage08_Agosto
        '
        resources.ApplyResources(Me.TabPage08_Agosto, "TabPage08_Agosto")
        Me.TabPage08_Agosto.Name = "TabPage08_Agosto"
        Me.TabPage08_Agosto.UseVisualStyleBackColor = True
        '
        'TabPage09_Setembro
        '
        resources.ApplyResources(Me.TabPage09_Setembro, "TabPage09_Setembro")
        Me.TabPage09_Setembro.Name = "TabPage09_Setembro"
        Me.TabPage09_Setembro.UseVisualStyleBackColor = True
        '
        'TabPage10_Outubro
        '
        resources.ApplyResources(Me.TabPage10_Outubro, "TabPage10_Outubro")
        Me.TabPage10_Outubro.Name = "TabPage10_Outubro"
        Me.TabPage10_Outubro.UseVisualStyleBackColor = True
        '
        'TabPage11_Novembro
        '
        resources.ApplyResources(Me.TabPage11_Novembro, "TabPage11_Novembro")
        Me.TabPage11_Novembro.Name = "TabPage11_Novembro"
        Me.TabPage11_Novembro.UseVisualStyleBackColor = True
        '
        'TabPage12_Dezembro
        '
        resources.ApplyResources(Me.TabPage12_Dezembro, "TabPage12_Dezembro")
        Me.TabPage12_Dezembro.Name = "TabPage12_Dezembro"
        Me.TabPage12_Dezembro.UseVisualStyleBackColor = True
        '
        'FileWatcher_Expenses
        '
        Me.FileWatcher_Expenses.EnableRaisingEvents = True
        Me.FileWatcher_Expenses.SynchronizingObject = Me
        '
        'FileWatcher_Values
        '
        Me.FileWatcher_Values.EnableRaisingEvents = True
        Me.FileWatcher_Values.IncludeSubdirectories = True
        Me.FileWatcher_Values.SynchronizingObject = Me
        '
        'DashboradPanel
        '
        Me.DashboradPanel.BackColor = System.Drawing.Color.White
        Me.DashboradPanel.Controls.Add(Me.Separator01)
        Me.DashboradPanel.Controls.Add(Me.TableLayoutPanel2)
        resources.ApplyResources(Me.DashboradPanel, "DashboradPanel")
        Me.DashboradPanel.Name = "DashboradPanel"
        '
        'Separator01
        '
        Me.Separator01.BackColor = System.Drawing.Color.WhiteSmoke
        resources.ApplyResources(Me.Separator01, "Separator01")
        Me.Separator01.Name = "Separator01"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_CreditCards, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_ExpensesValue, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_RestToPayValue, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DashboardPanel_ValuePaid, 0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'DashboardPanel_CreditCards
        '
        resources.ApplyResources(Me.DashboardPanel_CreditCards, "DashboardPanel_CreditCards")
        Me.DashboardPanel_CreditCards.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Label4)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel31)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel32)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel33)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel34)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel35)
        Me.DashboardPanel_CreditCards.Controls.Add(Me.Panel36)
        Me.DashboardPanel_CreditCards.Name = "DashboardPanel_CreditCards"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.Transparent
        Me.Panel31.Controls.Add(Me.DashboardIcon_CreditCards)
        Me.Panel31.Controls.Add(Me.Label_Cartões)
        Me.Panel31.Controls.Add(Me.TotalValue_AllCreditCards_Label)
        resources.ApplyResources(Me.Panel31, "Panel31")
        Me.Panel31.Name = "Panel31"
        '
        'DashboardIcon_CreditCards
        '
        resources.ApplyResources(Me.DashboardIcon_CreditCards, "DashboardIcon_CreditCards")
        Me.DashboardIcon_CreditCards.Image = Global.xpeg_count_project.My.Resources.DashboardtIconsResource.Icon_Dashboard_CreditCard_30x30
        Me.DashboardIcon_CreditCards.Name = "DashboardIcon_CreditCards"
        Me.DashboardIcon_CreditCards.TabStop = False
        '
        'Label_Cartões
        '
        resources.ApplyResources(Me.Label_Cartões, "Label_Cartões")
        Me.Label_Cartões.BackColor = System.Drawing.Color.Transparent
        Me.Label_Cartões.ForeColor = System.Drawing.Color.White
        Me.Label_Cartões.Name = "Label_Cartões"
        '
        'TotalValue_AllCreditCards_Label
        '
        resources.ApplyResources(Me.TotalValue_AllCreditCards_Label, "TotalValue_AllCreditCards_Label")
        Me.TotalValue_AllCreditCards_Label.BackColor = System.Drawing.Color.Transparent
        Me.TotalValue_AllCreditCards_Label.ForeColor = System.Drawing.Color.White
        Me.TotalValue_AllCreditCards_Label.Name = "TotalValue_AllCreditCards_Label"
        '
        'Panel32
        '
        Me.Panel32.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel32.Controls.Add(Me.NumberOfCards_Label)
        resources.ApplyResources(Me.Panel32, "Panel32")
        Me.Panel32.Name = "Panel32"
        Me.ToolTip1.SetToolTip(Me.Panel32, resources.GetString("Panel32.ToolTip"))
        '
        'NumberOfCards_Label
        '
        resources.ApplyResources(Me.NumberOfCards_Label, "NumberOfCards_Label")
        Me.NumberOfCards_Label.BackColor = System.Drawing.Color.Transparent
        Me.NumberOfCards_Label.ForeColor = System.Drawing.Color.White
        Me.NumberOfCards_Label.Name = "NumberOfCards_Label"
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        resources.ApplyResources(Me.Panel33, "Panel33")
        Me.Panel33.Name = "Panel33"
        '
        'Panel34
        '
        Me.Panel34.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        resources.ApplyResources(Me.Panel34, "Panel34")
        Me.Panel34.Name = "Panel34"
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        resources.ApplyResources(Me.Panel35, "Panel35")
        Me.Panel35.Name = "Panel35"
        '
        'Panel36
        '
        Me.Panel36.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        resources.ApplyResources(Me.Panel36, "Panel36")
        Me.Panel36.Name = "Panel36"
        '
        'DashboardPanel_ExpensesValue
        '
        resources.ApplyResources(Me.DashboardPanel_ExpensesValue, "DashboardPanel_ExpensesValue")
        Me.DashboardPanel_ExpensesValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel22)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel21)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel12)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel17)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel18)
        Me.DashboardPanel_ExpensesValue.Controls.Add(Me.Panel19)
        Me.DashboardPanel_ExpensesValue.Name = "DashboardPanel_ExpensesValue"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Transparent
        Me.Panel22.Controls.Add(Me.DashboradIcon_Expenses)
        Me.Panel22.Controls.Add(Me.Label_Despesas)
        Me.Panel22.Controls.Add(Me.TotalValue_AllExpenses_Label)
        resources.ApplyResources(Me.Panel22, "Panel22")
        Me.Panel22.Name = "Panel22"
        '
        'DashboradIcon_Expenses
        '
        resources.ApplyResources(Me.DashboradIcon_Expenses, "DashboradIcon_Expenses")
        Me.DashboradIcon_Expenses.Image = Global.xpeg_count_project.My.Resources.DashboardtIconsResource.Icon_Dashboard_Expenses_30x30
        Me.DashboradIcon_Expenses.Name = "DashboradIcon_Expenses"
        Me.DashboradIcon_Expenses.TabStop = False
        '
        'Label_Despesas
        '
        resources.ApplyResources(Me.Label_Despesas, "Label_Despesas")
        Me.Label_Despesas.BackColor = System.Drawing.Color.Transparent
        Me.Label_Despesas.ForeColor = System.Drawing.Color.White
        Me.Label_Despesas.Name = "Label_Despesas"
        '
        'TotalValue_AllExpenses_Label
        '
        resources.ApplyResources(Me.TotalValue_AllExpenses_Label, "TotalValue_AllExpenses_Label")
        Me.TotalValue_AllExpenses_Label.BackColor = System.Drawing.Color.Transparent
        Me.TotalValue_AllExpenses_Label.ForeColor = System.Drawing.Color.White
        Me.TotalValue_AllExpenses_Label.Name = "TotalValue_AllExpenses_Label"
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Panel21.Controls.Add(Me.NumberOfExpenses_Label)
        resources.ApplyResources(Me.Panel21, "Panel21")
        Me.Panel21.Name = "Panel21"
        Me.ToolTip1.SetToolTip(Me.Panel21, resources.GetString("Panel21.ToolTip"))
        '
        'NumberOfExpenses_Label
        '
        resources.ApplyResources(Me.NumberOfExpenses_Label, "NumberOfExpenses_Label")
        Me.NumberOfExpenses_Label.BackColor = System.Drawing.Color.Transparent
        Me.NumberOfExpenses_Label.ForeColor = System.Drawing.Color.White
        Me.NumberOfExpenses_Label.Name = "NumberOfExpenses_Label"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.Panel12, "Panel12")
        Me.Panel12.Name = "Panel12"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.Panel17, "Panel17")
        Me.Panel17.Name = "Panel17"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.Panel18, "Panel18")
        Me.Panel18.Name = "Panel18"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(68, Byte), Integer))
        resources.ApplyResources(Me.Panel19, "Panel19")
        Me.Panel19.Name = "Panel19"
        '
        'DashboardPanel_RestToPayValue
        '
        resources.ApplyResources(Me.DashboardPanel_RestToPayValue, "DashboardPanel_RestToPayValue")
        Me.DashboardPanel_RestToPayValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel20)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel7)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel13)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel14)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel15)
        Me.DashboardPanel_RestToPayValue.Controls.Add(Me.Panel16)
        Me.DashboardPanel_RestToPayValue.Name = "DashboardPanel_RestToPayValue"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Transparent
        Me.Panel20.Controls.Add(Me.DashboardIcon_RestToPay)
        Me.Panel20.Controls.Add(Me.Label_FaltaParaQuitar)
        Me.Panel20.Controls.Add(Me.TotalValue_RestToPay_Label)
        resources.ApplyResources(Me.Panel20, "Panel20")
        Me.Panel20.Name = "Panel20"
        '
        'DashboardIcon_RestToPay
        '
        resources.ApplyResources(Me.DashboardIcon_RestToPay, "DashboardIcon_RestToPay")
        Me.DashboardIcon_RestToPay.Image = Global.xpeg_count_project.My.Resources.DashboardtIconsResource.Icon_Dashboard_RestToPay_30x30
        Me.DashboardIcon_RestToPay.Name = "DashboardIcon_RestToPay"
        Me.DashboardIcon_RestToPay.TabStop = False
        '
        'Label_FaltaParaQuitar
        '
        resources.ApplyResources(Me.Label_FaltaParaQuitar, "Label_FaltaParaQuitar")
        Me.Label_FaltaParaQuitar.BackColor = System.Drawing.Color.Transparent
        Me.Label_FaltaParaQuitar.ForeColor = System.Drawing.Color.White
        Me.Label_FaltaParaQuitar.Name = "Label_FaltaParaQuitar"
        '
        'TotalValue_RestToPay_Label
        '
        resources.ApplyResources(Me.TotalValue_RestToPay_Label, "TotalValue_RestToPay_Label")
        Me.TotalValue_RestToPay_Label.BackColor = System.Drawing.Color.Transparent
        Me.TotalValue_RestToPay_Label.ForeColor = System.Drawing.Color.White
        Me.TotalValue_RestToPay_Label.Name = "TotalValue_RestToPay_Label"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel7.Controls.Add(Me.DashboardProgressBar_Rest)
        resources.ApplyResources(Me.Panel7, "Panel7")
        Me.Panel7.Name = "Panel7"
        '
        'DashboardProgressBar_Rest
        '
        resources.ApplyResources(Me.DashboardProgressBar_Rest, "DashboardProgressBar_Rest")
        Me.DashboardProgressBar_Rest.BackColor = System.Drawing.Color.Transparent
        Me.DashboardProgressBar_Rest.BaseColour = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DashboardProgressBar_Rest.BorderColour = System.Drawing.Color.Transparent
        Me.DashboardProgressBar_Rest.Maximum = 100
        Me.DashboardProgressBar_Rest.Name = "DashboardProgressBar_Rest"
        Me.DashboardProgressBar_Rest.ProgressColour = System.Drawing.Color.White
        Me.DashboardProgressBar_Rest.RotationAngle = 360
        Me.DashboardProgressBar_Rest.ShowPorcent = True
        Me.DashboardProgressBar_Rest.StartingAngle = 265
        Me.DashboardProgressBar_Rest.Value = 0
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        resources.ApplyResources(Me.Panel13, "Panel13")
        Me.Panel13.Name = "Panel13"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        resources.ApplyResources(Me.Panel14, "Panel14")
        Me.Panel14.Name = "Panel14"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        resources.ApplyResources(Me.Panel15, "Panel15")
        Me.Panel15.Name = "Panel15"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer))
        resources.ApplyResources(Me.Panel16, "Panel16")
        Me.Panel16.Name = "Panel16"
        '
        'DashboardPanel_ValuePaid
        '
        resources.ApplyResources(Me.DashboardPanel_ValuePaid, "DashboardPanel_ValuePaid")
        Me.DashboardPanel_ValuePaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel6)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel1)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel11)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel10)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel9)
        Me.DashboardPanel_ValuePaid.Controls.Add(Me.Panel8)
        Me.DashboardPanel_ValuePaid.Name = "DashboardPanel_ValuePaid"
        Me.DashboardPanel_ValuePaid.Tag = "0; 168; 255"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.DashboardIcon_ValuePaid)
        Me.Panel6.Controls.Add(Me.Label_ValorPago)
        Me.Panel6.Controls.Add(Me.TotalValue_Paid_Label)
        resources.ApplyResources(Me.Panel6, "Panel6")
        Me.Panel6.Name = "Panel6"
        '
        'DashboardIcon_ValuePaid
        '
        resources.ApplyResources(Me.DashboardIcon_ValuePaid, "DashboardIcon_ValuePaid")
        Me.DashboardIcon_ValuePaid.Image = Global.xpeg_count_project.My.Resources.DashboardtIconsResource.Icon_Dashboard_ValuePaid_30x30
        Me.DashboardIcon_ValuePaid.Name = "DashboardIcon_ValuePaid"
        Me.DashboardIcon_ValuePaid.TabStop = False
        '
        'Label_ValorPago
        '
        resources.ApplyResources(Me.Label_ValorPago, "Label_ValorPago")
        Me.Label_ValorPago.BackColor = System.Drawing.Color.Transparent
        Me.Label_ValorPago.ForeColor = System.Drawing.Color.White
        Me.Label_ValorPago.Name = "Label_ValorPago"
        '
        'TotalValue_Paid_Label
        '
        resources.ApplyResources(Me.TotalValue_Paid_Label, "TotalValue_Paid_Label")
        Me.TotalValue_Paid_Label.BackColor = System.Drawing.Color.Transparent
        Me.TotalValue_Paid_Label.ForeColor = System.Drawing.Color.White
        Me.TotalValue_Paid_Label.Name = "TotalValue_Paid_Label"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DashboardProgressBar_Paid)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'DashboardProgressBar_Paid
        '
        resources.ApplyResources(Me.DashboardProgressBar_Paid, "DashboardProgressBar_Paid")
        Me.DashboardProgressBar_Paid.BackColor = System.Drawing.Color.Transparent
        Me.DashboardProgressBar_Paid.BaseColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DashboardProgressBar_Paid.BorderColour = System.Drawing.Color.Transparent
        Me.DashboardProgressBar_Paid.Maximum = 100
        Me.DashboardProgressBar_Paid.Name = "DashboardProgressBar_Paid"
        Me.DashboardProgressBar_Paid.ProgressColour = System.Drawing.Color.White
        Me.DashboardProgressBar_Paid.RotationAngle = 360
        Me.DashboardProgressBar_Paid.ShowPorcent = True
        Me.DashboardProgressBar_Paid.StartingAngle = 265
        Me.DashboardProgressBar_Paid.Value = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.Panel11, "Panel11")
        Me.Panel11.Name = "Panel11"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.Panel10, "Panel10")
        Me.Panel10.Name = "Panel10"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.Panel9, "Panel9")
        Me.Panel9.Name = "Panel9"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.Panel8, "Panel8")
        Me.Panel8.Name = "Panel8"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.HeaderPanel)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DashboradPanel)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'FormBackground
        '
        Me.FormBackground.Controls.Add(Me.ControlsPanel)
        Me.FormBackground.Controls.Add(Me.Panel2)
        resources.ApplyResources(Me.FormBackground, "FormBackground")
        Me.FormBackground.Name = "FormBackground"
        '
        'ControlsPanel
        '
        Me.ControlsPanel.Controls.Add(Me.CalendarModePanel)
        Me.ControlsPanel.Controls.Add(Me.BlocksModePanel)
        resources.ApplyResources(Me.ControlsPanel, "ControlsPanel")
        Me.ControlsPanel.Name = "ControlsPanel"
        '
        'CalendarModePanel
        '
        Me.CalendarModePanel.Controls.Add(Me.TabControl_ExpensesMonths)
        resources.ApplyResources(Me.CalendarModePanel, "CalendarModePanel")
        Me.CalendarModePanel.Name = "CalendarModePanel"
        '
        'BlocksModePanel
        '
        Me.BlocksModePanel.Controls.Add(Me.ExpenseBlocksFlowPanel)
        resources.ApplyResources(Me.BlocksModePanel, "BlocksModePanel")
        Me.BlocksModePanel.Name = "BlocksModePanel"
        '
        'ExpenseBlocksFlowPanel
        '
        resources.ApplyResources(Me.ExpenseBlocksFlowPanel, "ExpenseBlocksFlowPanel")
        Me.ExpenseBlocksFlowPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ExpenseBlocksFlowPanel.Controls.Add(Me.ExpenseCategoryItemControl1)
        Me.ExpenseBlocksFlowPanel.Controls.Add(Me.ExpenseCategoryItemControl2)
        Me.ExpenseBlocksFlowPanel.Name = "ExpenseBlocksFlowPanel"
        '
        'ExpenseCategoryItemControl1
        '
        Me.ExpenseCategoryItemControl1.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseCategoryItemControl1.CategoryText = "Categoria A"
        Me.ExpenseCategoryItemControl1.FlowPanel = Nothing
        resources.ApplyResources(Me.ExpenseCategoryItemControl1, "ExpenseCategoryItemControl1")
        Me.ExpenseCategoryItemControl1.Name = "ExpenseCategoryItemControl1"
        Me.ExpenseCategoryItemControl1.SubCategory = False
        '
        'ExpenseCategoryItemControl2
        '
        Me.ExpenseCategoryItemControl2.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseCategoryItemControl2.CategoryText = "Sub-Categoria AA"
        Me.ExpenseCategoryItemControl2.FlowPanel = Nothing
        resources.ApplyResources(Me.ExpenseCategoryItemControl2, "ExpenseCategoryItemControl2")
        Me.ExpenseCategoryItemControl2.Name = "ExpenseCategoryItemControl2"
        Me.ExpenseCategoryItemControl2.SubCategory = True
        '
        'CalendarViewModeButton
        '
        resources.ApplyResources(Me.CalendarViewModeButton, "CalendarViewModeButton")
        Me.CalendarViewModeButton.BackColor = System.Drawing.Color.Transparent
        Me.CalendarViewModeButton.Image = Global.xpeg_count_project.My.Resources.FiltersHome.CalendarMode_24px
        Me.CalendarViewModeButton.Name = "CalendarViewModeButton"
        Me.CalendarViewModeButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CalendarViewModeButton, resources.GetString("CalendarViewModeButton.ToolTip"))
        '
        'BlocksViewModeButton
        '
        resources.ApplyResources(Me.BlocksViewModeButton, "BlocksViewModeButton")
        Me.BlocksViewModeButton.BackColor = System.Drawing.Color.Transparent
        Me.BlocksViewModeButton.Image = Global.xpeg_count_project.My.Resources.FiltersHome.BlocksMode_24px
        Me.BlocksViewModeButton.Name = "BlocksViewModeButton"
        Me.BlocksViewModeButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BlocksViewModeButton, resources.GetString("BlocksViewModeButton.ToolTip"))
        '
        'CloseFiltersButton
        '
        resources.ApplyResources(Me.CloseFiltersButton, "CloseFiltersButton")
        Me.CloseFiltersButton.Image = Global.xpeg_count_project.My.Resources.FiltersHome.CloseFilters_20px
        Me.CloseFiltersButton.Name = "CloseFiltersButton"
        Me.CloseFiltersButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.CloseFiltersButton, resources.GetString("CloseFiltersButton.ToolTip"))
        '
        'DisplayAllFiltersBlocksButton
        '
        resources.ApplyResources(Me.DisplayAllFiltersBlocksButton, "DisplayAllFiltersBlocksButton")
        Me.DisplayAllFiltersBlocksButton.Image = Global.xpeg_count_project.My.Resources.FiltersHome.ExpandAll_20px
        Me.DisplayAllFiltersBlocksButton.Name = "DisplayAllFiltersBlocksButton"
        Me.DisplayAllFiltersBlocksButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DisplayAllFiltersBlocksButton, resources.GetString("DisplayAllFiltersBlocksButton.ToolTip"))
        '
        'FiltersBackgroundPanel
        '
        Me.FiltersBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FiltersBackgroundPanel.Controls.Add(Me.Panel5)
        Me.FiltersBackgroundPanel.Controls.Add(Me.FiltersPanel)
        resources.ApplyResources(Me.FiltersBackgroundPanel, "FiltersBackgroundPanel")
        Me.FiltersBackgroundPanel.Name = "FiltersBackgroundPanel"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'FiltersPanel
        '
        Me.FiltersPanel.Controls.Add(Me.FiltersBlocksPanel)
        Me.FiltersPanel.Controls.Add(Me.HeaderFiltersPanel)
        resources.ApplyResources(Me.FiltersPanel, "FiltersPanel")
        Me.FiltersPanel.ForeColor = System.Drawing.Color.White
        Me.FiltersPanel.Name = "FiltersPanel"
        '
        'FiltersBlocksPanel
        '
        Me.FiltersBlocksPanel.Controls.Add(Me.ApplyFiltersButton)
        Me.FiltersBlocksPanel.Controls.Add(Me.NoFilterAvailabledLabel)
        Me.FiltersBlocksPanel.Controls.Add(Me.FilterByOrder_BlockFilter)
        Me.FiltersBlocksPanel.Controls.Add(Me.FilterByValue_BlockFilter)
        Me.FiltersBlocksPanel.Controls.Add(Me.FilterByCategory_BlockFilter)
        Me.FiltersBlocksPanel.Controls.Add(Me.FilterByDate_BlockFilter)
        Me.FiltersBlocksPanel.Controls.Add(Me.DashboardOptions_BlockFilter)
        Me.FiltersBlocksPanel.Controls.Add(Me.ModeView_BlockFilter)
        resources.ApplyResources(Me.FiltersBlocksPanel, "FiltersBlocksPanel")
        Me.FiltersBlocksPanel.Name = "FiltersBlocksPanel"
        '
        'ApplyFiltersButton
        '
        resources.ApplyResources(Me.ApplyFiltersButton, "ApplyFiltersButton")
        Me.ApplyFiltersButton.ForeColor = System.Drawing.Color.Black
        Me.ApplyFiltersButton.Name = "ApplyFiltersButton"
        Me.ApplyFiltersButton.UseVisualStyleBackColor = True
        '
        'NoFilterAvailabledLabel
        '
        resources.ApplyResources(Me.NoFilterAvailabledLabel, "NoFilterAvailabledLabel")
        Me.NoFilterAvailabledLabel.Name = "NoFilterAvailabledLabel"
        '
        'FilterByOrder_BlockFilter
        '
        Me.FilterByOrder_BlockFilter.Controls.Add(Me.FilterByOrder_BlockFilterContainer)
        Me.FilterByOrder_BlockFilter.Controls.Add(Me.Panel27)
        Me.FilterByOrder_BlockFilter.Controls.Add(Me.FilterByOrder_BlockFilterPanelTitle)
        resources.ApplyResources(Me.FilterByOrder_BlockFilter, "FilterByOrder_BlockFilter")
        Me.FilterByOrder_BlockFilter.Name = "FilterByOrder_BlockFilter"
        '
        'FilterByOrder_BlockFilterContainer
        '
        Me.FilterByOrder_BlockFilterContainer.Controls.Add(Me.Panel38)
        Me.FilterByOrder_BlockFilterContainer.Controls.Add(Me.Panel39)
        resources.ApplyResources(Me.FilterByOrder_BlockFilterContainer, "FilterByOrder_BlockFilterContainer")
        Me.FilterByOrder_BlockFilterContainer.Name = "FilterByOrder_BlockFilterContainer"
        '
        'Panel38
        '
        resources.ApplyResources(Me.Panel38, "Panel38")
        Me.Panel38.Name = "Panel38"
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.MdComboBox2)
        Me.Panel39.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.Panel39, "Panel39")
        Me.Panel39.Name = "Panel39"
        '
        'MdComboBox2
        '
        Me.MdComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MdComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.MdComboBox2, "MdComboBox2")
        Me.MdComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MdComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MdComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MdComboBox2.FormattingEnabled = True
        Me.MdComboBox2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MdComboBox2.Items.AddRange(New Object() {resources.GetString("MdComboBox2.Items"), resources.GetString("MdComboBox2.Items1"), resources.GetString("MdComboBox2.Items2"), resources.GetString("MdComboBox2.Items3"), resources.GetString("MdComboBox2.Items4"), resources.GetString("MdComboBox2.Items5"), resources.GetString("MdComboBox2.Items6")})
        Me.MdComboBox2.LightTheme = False
        Me.MdComboBox2.Name = "MdComboBox2"
        Me.MdComboBox2.Tag = "Parcelas Pagas [exibir isso se o user selecionar algum mês]"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.Panel27, "Panel27")
        Me.Panel27.Name = "Panel27"
        '
        'FilterByOrder_BlockFilterPanelTitle
        '
        Me.FilterByOrder_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FilterByOrder_BlockFilterPanelTitle.Controls.Add(Me.FilterByOrder_BlockFilterLabelTitle)
        resources.ApplyResources(Me.FilterByOrder_BlockFilterPanelTitle, "FilterByOrder_BlockFilterPanelTitle")
        Me.FilterByOrder_BlockFilterPanelTitle.Name = "FilterByOrder_BlockFilterPanelTitle"
        '
        'FilterByOrder_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.FilterByOrder_BlockFilterLabelTitle, "FilterByOrder_BlockFilterLabelTitle")
        Me.FilterByOrder_BlockFilterLabelTitle.Name = "FilterByOrder_BlockFilterLabelTitle"
        '
        'FilterByValue_BlockFilter
        '
        Me.FilterByValue_BlockFilter.Controls.Add(Me.FilterByValue_BlockFilterContainer)
        Me.FilterByValue_BlockFilter.Controls.Add(Me.FilterByValue_BlockFilterSeparator)
        Me.FilterByValue_BlockFilter.Controls.Add(Me.FilterByValue_BlockFilterPanelTitle)
        resources.ApplyResources(Me.FilterByValue_BlockFilter, "FilterByValue_BlockFilter")
        Me.FilterByValue_BlockFilter.Name = "FilterByValue_BlockFilter"
        '
        'FilterByValue_BlockFilterContainer
        '
        Me.FilterByValue_BlockFilterContainer.Controls.Add(Me.Label10)
        Me.FilterByValue_BlockFilterContainer.Controls.Add(Me.ComboBox3)
        resources.ApplyResources(Me.FilterByValue_BlockFilterContainer, "FilterByValue_BlockFilterContainer")
        Me.FilterByValue_BlockFilterContainer.Name = "FilterByValue_BlockFilterContainer"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'ComboBox3
        '
        resources.ApplyResources(Me.ComboBox3, "ComboBox3")
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DropDownHeight = 80
        Me.ComboBox3.DropDownWidth = 100
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {resources.GetString("ComboBox3.Items"), resources.GetString("ComboBox3.Items1"), resources.GetString("ComboBox3.Items2")})
        Me.ComboBox3.Name = "ComboBox3"
        '
        'FilterByValue_BlockFilterSeparator
        '
        Me.FilterByValue_BlockFilterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.FilterByValue_BlockFilterSeparator, "FilterByValue_BlockFilterSeparator")
        Me.FilterByValue_BlockFilterSeparator.Name = "FilterByValue_BlockFilterSeparator"
        '
        'FilterByValue_BlockFilterPanelTitle
        '
        Me.FilterByValue_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FilterByValue_BlockFilterPanelTitle.Controls.Add(Me.FilterByValue_BlockFilterLabelTitle)
        resources.ApplyResources(Me.FilterByValue_BlockFilterPanelTitle, "FilterByValue_BlockFilterPanelTitle")
        Me.FilterByValue_BlockFilterPanelTitle.Name = "FilterByValue_BlockFilterPanelTitle"
        '
        'FilterByValue_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.FilterByValue_BlockFilterLabelTitle, "FilterByValue_BlockFilterLabelTitle")
        Me.FilterByValue_BlockFilterLabelTitle.Name = "FilterByValue_BlockFilterLabelTitle"
        '
        'FilterByCategory_BlockFilter
        '
        Me.FilterByCategory_BlockFilter.Controls.Add(Me.FilterByCategory_BlockFilterContainer)
        Me.FilterByCategory_BlockFilter.Controls.Add(Me.FilterByCategory_BlockFilterSeparator)
        Me.FilterByCategory_BlockFilter.Controls.Add(Me.FilterByCategory_BlockFilterPanelTitle)
        resources.ApplyResources(Me.FilterByCategory_BlockFilter, "FilterByCategory_BlockFilter")
        Me.FilterByCategory_BlockFilter.Name = "FilterByCategory_BlockFilter"
        '
        'FilterByCategory_BlockFilterContainer
        '
        Me.FilterByCategory_BlockFilterContainer.Controls.Add(Me.Panel37)
        Me.FilterByCategory_BlockFilterContainer.Controls.Add(Me.Panel30)
        resources.ApplyResources(Me.FilterByCategory_BlockFilterContainer, "FilterByCategory_BlockFilterContainer")
        Me.FilterByCategory_BlockFilterContainer.Name = "FilterByCategory_BlockFilterContainer"
        '
        'Panel37
        '
        resources.ApplyResources(Me.Panel37, "Panel37")
        Me.Panel37.Name = "Panel37"
        '
        'Panel30
        '
        Me.Panel30.Controls.Add(Me.MdComboBox_Categorys)
        Me.Panel30.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel30, "Panel30")
        Me.Panel30.Name = "Panel30"
        '
        'MdComboBox_Categorys
        '
        Me.MdComboBox_Categorys.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MdComboBox_Categorys.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.MdComboBox_Categorys, "MdComboBox_Categorys")
        Me.MdComboBox_Categorys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MdComboBox_Categorys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MdComboBox_Categorys.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MdComboBox_Categorys.FormattingEnabled = True
        Me.MdComboBox_Categorys.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MdComboBox_Categorys.LightTheme = False
        Me.MdComboBox_Categorys.Name = "MdComboBox_Categorys"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'FilterByCategory_BlockFilterSeparator
        '
        Me.FilterByCategory_BlockFilterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.FilterByCategory_BlockFilterSeparator, "FilterByCategory_BlockFilterSeparator")
        Me.FilterByCategory_BlockFilterSeparator.Name = "FilterByCategory_BlockFilterSeparator"
        '
        'FilterByCategory_BlockFilterPanelTitle
        '
        Me.FilterByCategory_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FilterByCategory_BlockFilterPanelTitle.Controls.Add(Me.FilterByCategory_BlockFilterLabelTitle)
        resources.ApplyResources(Me.FilterByCategory_BlockFilterPanelTitle, "FilterByCategory_BlockFilterPanelTitle")
        Me.FilterByCategory_BlockFilterPanelTitle.Name = "FilterByCategory_BlockFilterPanelTitle"
        '
        'FilterByCategory_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.FilterByCategory_BlockFilterLabelTitle, "FilterByCategory_BlockFilterLabelTitle")
        Me.FilterByCategory_BlockFilterLabelTitle.Name = "FilterByCategory_BlockFilterLabelTitle"
        '
        'FilterByDate_BlockFilter
        '
        Me.FilterByDate_BlockFilter.Controls.Add(Me.FilterByDate_BlockFilterContainer)
        Me.FilterByDate_BlockFilter.Controls.Add(Me.Panel25)
        Me.FilterByDate_BlockFilter.Controls.Add(Me.FilterByDate_BlockFilterPanelTitle)
        resources.ApplyResources(Me.FilterByDate_BlockFilter, "FilterByDate_BlockFilter")
        Me.FilterByDate_BlockFilter.Name = "FilterByDate_BlockFilter"
        '
        'FilterByDate_BlockFilterContainer
        '
        Me.FilterByDate_BlockFilterContainer.Controls.Add(Me.Panel26)
        Me.FilterByDate_BlockFilterContainer.Controls.Add(Me.Panel24)
        Me.FilterByDate_BlockFilterContainer.Controls.Add(Me.Panel29)
        Me.FilterByDate_BlockFilterContainer.Controls.Add(Me.Panel28)
        resources.ApplyResources(Me.FilterByDate_BlockFilterContainer, "FilterByDate_BlockFilterContainer")
        Me.FilterByDate_BlockFilterContainer.Name = "FilterByDate_BlockFilterContainer"
        '
        'Panel26
        '
        resources.ApplyResources(Me.Panel26, "Panel26")
        Me.Panel26.Name = "Panel26"
        '
        'Panel24
        '
        Me.Panel24.Controls.Add(Me.MonthFilterComboBox)
        Me.Panel24.Controls.Add(Me.Label_DiaDeVencimento)
        resources.ApplyResources(Me.Panel24, "Panel24")
        Me.Panel24.Name = "Panel24"
        '
        'MonthFilterComboBox
        '
        Me.MonthFilterComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MonthFilterComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.MonthFilterComboBox, "MonthFilterComboBox")
        Me.MonthFilterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MonthFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthFilterComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.MonthFilterComboBox.FormattingEnabled = True
        Me.MonthFilterComboBox.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MonthFilterComboBox.Items.AddRange(New Object() {resources.GetString("MonthFilterComboBox.Items"), resources.GetString("MonthFilterComboBox.Items1"), resources.GetString("MonthFilterComboBox.Items2"), resources.GetString("MonthFilterComboBox.Items3"), resources.GetString("MonthFilterComboBox.Items4"), resources.GetString("MonthFilterComboBox.Items5"), resources.GetString("MonthFilterComboBox.Items6"), resources.GetString("MonthFilterComboBox.Items7"), resources.GetString("MonthFilterComboBox.Items8"), resources.GetString("MonthFilterComboBox.Items9"), resources.GetString("MonthFilterComboBox.Items10"), resources.GetString("MonthFilterComboBox.Items11"), resources.GetString("MonthFilterComboBox.Items12")})
        Me.MonthFilterComboBox.LightTheme = False
        Me.MonthFilterComboBox.Name = "MonthFilterComboBox"
        '
        'Label_DiaDeVencimento
        '
        resources.ApplyResources(Me.Label_DiaDeVencimento, "Label_DiaDeVencimento")
        Me.Label_DiaDeVencimento.Name = "Label_DiaDeVencimento"
        '
        'Panel29
        '
        resources.ApplyResources(Me.Panel29, "Panel29")
        Me.Panel29.Name = "Panel29"
        '
        'Panel28
        '
        Me.Panel28.Controls.Add(Me.YearFilterComboBox)
        Me.Panel28.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.Panel28, "Panel28")
        Me.Panel28.Name = "Panel28"
        '
        'YearFilterComboBox
        '
        Me.YearFilterComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.YearFilterComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.YearFilterComboBox, "YearFilterComboBox")
        Me.YearFilterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.YearFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearFilterComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.YearFilterComboBox.FormattingEnabled = True
        Me.YearFilterComboBox.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.YearFilterComboBox.Items.AddRange(New Object() {resources.GetString("YearFilterComboBox.Items"), resources.GetString("YearFilterComboBox.Items1")})
        Me.YearFilterComboBox.LightTheme = False
        Me.YearFilterComboBox.Name = "YearFilterComboBox"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.Panel25, "Panel25")
        Me.Panel25.Name = "Panel25"
        '
        'FilterByDate_BlockFilterPanelTitle
        '
        Me.FilterByDate_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FilterByDate_BlockFilterPanelTitle.Controls.Add(Me.FilterByDate_BlockFilterLabelTitle)
        resources.ApplyResources(Me.FilterByDate_BlockFilterPanelTitle, "FilterByDate_BlockFilterPanelTitle")
        Me.FilterByDate_BlockFilterPanelTitle.Name = "FilterByDate_BlockFilterPanelTitle"
        '
        'FilterByDate_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.FilterByDate_BlockFilterLabelTitle, "FilterByDate_BlockFilterLabelTitle")
        Me.FilterByDate_BlockFilterLabelTitle.Name = "FilterByDate_BlockFilterLabelTitle"
        '
        'DashboardOptions_BlockFilter
        '
        Me.DashboardOptions_BlockFilter.Controls.Add(Me.Panel41)
        Me.DashboardOptions_BlockFilter.Controls.Add(Me.Panel46)
        Me.DashboardOptions_BlockFilter.Controls.Add(Me.DashboardOptions_BlockFilterPanelTitle)
        resources.ApplyResources(Me.DashboardOptions_BlockFilter, "DashboardOptions_BlockFilter")
        Me.DashboardOptions_BlockFilter.Name = "DashboardOptions_BlockFilter"
        '
        'Panel41
        '
        Me.Panel41.Controls.Add(Me.Panel45)
        resources.ApplyResources(Me.Panel41, "Panel41")
        Me.Panel41.Name = "Panel41"
        '
        'Panel45
        '
        Me.Panel45.Controls.Add(Me.AllTime_DashboardPeriodRadioButton)
        Me.Panel45.Controls.Add(Me.ByMonth_DashboardPeriodRadioButton)
        Me.Panel45.Controls.Add(Me.ByYear_DashboardPeriodRadioButton)
        resources.ApplyResources(Me.Panel45, "Panel45")
        Me.Panel45.Name = "Panel45"
        '
        'AllTime_DashboardPeriodRadioButton
        '
        Me.AllTime_DashboardPeriodRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.AllTime_DashboardPeriodRadioButton.Checked = False
        Me.AllTime_DashboardPeriodRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.AllTime_DashboardPeriodRadioButton, "AllTime_DashboardPeriodRadioButton")
        Me.AllTime_DashboardPeriodRadioButton.Name = "AllTime_DashboardPeriodRadioButton"
        Me.AllTime_DashboardPeriodRadioButton.Options = xpeg_count_project.MDRadioButton._Options.Style1
        '
        'ByMonth_DashboardPeriodRadioButton
        '
        Me.ByMonth_DashboardPeriodRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.ByMonth_DashboardPeriodRadioButton.Checked = False
        Me.ByMonth_DashboardPeriodRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ByMonth_DashboardPeriodRadioButton, "ByMonth_DashboardPeriodRadioButton")
        Me.ByMonth_DashboardPeriodRadioButton.Name = "ByMonth_DashboardPeriodRadioButton"
        Me.ByMonth_DashboardPeriodRadioButton.Options = xpeg_count_project.MDRadioButton._Options.Style1
        '
        'ByYear_DashboardPeriodRadioButton
        '
        Me.ByYear_DashboardPeriodRadioButton.BackColor = System.Drawing.Color.Transparent
        Me.ByYear_DashboardPeriodRadioButton.Checked = False
        Me.ByYear_DashboardPeriodRadioButton.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.ByYear_DashboardPeriodRadioButton, "ByYear_DashboardPeriodRadioButton")
        Me.ByYear_DashboardPeriodRadioButton.Name = "ByYear_DashboardPeriodRadioButton"
        Me.ByYear_DashboardPeriodRadioButton.Options = xpeg_count_project.MDRadioButton._Options.Style1
        '
        'Panel46
        '
        Me.Panel46.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.Panel46, "Panel46")
        Me.Panel46.Name = "Panel46"
        '
        'DashboardOptions_BlockFilterPanelTitle
        '
        Me.DashboardOptions_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DashboardOptions_BlockFilterPanelTitle.Controls.Add(Me.DashboardOptions_BlockFilterLabelTitle)
        resources.ApplyResources(Me.DashboardOptions_BlockFilterPanelTitle, "DashboardOptions_BlockFilterPanelTitle")
        Me.DashboardOptions_BlockFilterPanelTitle.Name = "DashboardOptions_BlockFilterPanelTitle"
        '
        'DashboardOptions_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.DashboardOptions_BlockFilterLabelTitle, "DashboardOptions_BlockFilterLabelTitle")
        Me.DashboardOptions_BlockFilterLabelTitle.Name = "DashboardOptions_BlockFilterLabelTitle"
        '
        'ModeView_BlockFilter
        '
        Me.ModeView_BlockFilter.Controls.Add(Me.ModeView_BlockFilterContainer)
        Me.ModeView_BlockFilter.Controls.Add(Me.ModeView_BlockFilterSeparator)
        Me.ModeView_BlockFilter.Controls.Add(Me.ModeView_BlockFilterPanelTitle)
        resources.ApplyResources(Me.ModeView_BlockFilter, "ModeView_BlockFilter")
        Me.ModeView_BlockFilter.Name = "ModeView_BlockFilter"
        '
        'ModeView_BlockFilterContainer
        '
        Me.ModeView_BlockFilterContainer.Controls.Add(Me.BlocksViewModeButton)
        Me.ModeView_BlockFilterContainer.Controls.Add(Me.CalendarViewModeButton)
        resources.ApplyResources(Me.ModeView_BlockFilterContainer, "ModeView_BlockFilterContainer")
        Me.ModeView_BlockFilterContainer.Name = "ModeView_BlockFilterContainer"
        '
        'ModeView_BlockFilterSeparator
        '
        Me.ModeView_BlockFilterSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        resources.ApplyResources(Me.ModeView_BlockFilterSeparator, "ModeView_BlockFilterSeparator")
        Me.ModeView_BlockFilterSeparator.Name = "ModeView_BlockFilterSeparator"
        '
        'ModeView_BlockFilterPanelTitle
        '
        Me.ModeView_BlockFilterPanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ModeView_BlockFilterPanelTitle.Controls.Add(Me.ModeView_BlockFilterLabelTitle)
        resources.ApplyResources(Me.ModeView_BlockFilterPanelTitle, "ModeView_BlockFilterPanelTitle")
        Me.ModeView_BlockFilterPanelTitle.Name = "ModeView_BlockFilterPanelTitle"
        '
        'ModeView_BlockFilterLabelTitle
        '
        resources.ApplyResources(Me.ModeView_BlockFilterLabelTitle, "ModeView_BlockFilterLabelTitle")
        Me.ModeView_BlockFilterLabelTitle.Name = "ModeView_BlockFilterLabelTitle"
        '
        'HeaderFiltersPanel
        '
        Me.HeaderFiltersPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.HeaderFiltersPanel.Controls.Add(Me.DisplayAllFiltersBlocksButton)
        Me.HeaderFiltersPanel.Controls.Add(Me.CloseFiltersButton)
        Me.HeaderFiltersPanel.Controls.Add(Me.Panel23)
        Me.HeaderFiltersPanel.Controls.Add(Me.Label_Filtros)
        resources.ApplyResources(Me.HeaderFiltersPanel, "HeaderFiltersPanel")
        Me.HeaderFiltersPanel.Name = "HeaderFiltersPanel"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        resources.ApplyResources(Me.Panel23, "Panel23")
        Me.Panel23.Name = "Panel23"
        '
        'Label_Filtros
        '
        resources.ApplyResources(Me.Label_Filtros, "Label_Filtros")
        Me.Label_Filtros.Name = "Label_Filtros"
        '
        'MenuHomeBackground
        '
        Me.MenuHomeBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuHomeBackground.Controls.Add(Me.Panel42)
        Me.MenuHomeBackground.Controls.Add(Me.MenuHomeElements)
        resources.ApplyResources(Me.MenuHomeBackground, "MenuHomeBackground")
        Me.MenuHomeBackground.Name = "MenuHomeBackground"
        '
        'Panel42
        '
        Me.Panel42.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        resources.ApplyResources(Me.Panel42, "Panel42")
        Me.Panel42.Name = "Panel42"
        '
        'MenuHomeElements
        '
        Me.MenuHomeElements.Controls.Add(Me.ExitMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.InfSoftwareMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.DonateMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.FeedBackMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.HelpCenterMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.SettingsMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.ExpensesArchiveMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.AddCreditCardMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.NewExpenseMenuItem)
        Me.MenuHomeElements.Controls.Add(Me.MenuHeader)
        resources.ApplyResources(Me.MenuHomeElements, "MenuHomeElements")
        Me.MenuHomeElements.ForeColor = System.Drawing.Color.White
        Me.MenuHomeElements.Name = "MenuHomeElements"
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ExitMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.ExitMenuItem, "ExitMenuItem")
        Me.ExitMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitMenuItem.MenuIcon = CType(resources.GetObject("ExitMenuItem.MenuIcon"), System.Drawing.Image)
        Me.ExitMenuItem.MenuText = "Sair"
        Me.ExitMenuItem.Name = "ExitMenuItem"
        '
        'InfSoftwareMenuItem
        '
        Me.InfSoftwareMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InfSoftwareMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.InfSoftwareMenuItem, "InfSoftwareMenuItem")
        Me.InfSoftwareMenuItem.ForeColor = System.Drawing.Color.White
        Me.InfSoftwareMenuItem.MenuIcon = CType(resources.GetObject("InfSoftwareMenuItem.MenuIcon"), System.Drawing.Image)
        Me.InfSoftwareMenuItem.MenuText = "Sobre"
        Me.InfSoftwareMenuItem.Name = "InfSoftwareMenuItem"
        '
        'DonateMenuItem
        '
        Me.DonateMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DonateMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.DonateMenuItem, "DonateMenuItem")
        Me.DonateMenuItem.ForeColor = System.Drawing.Color.White
        Me.DonateMenuItem.MenuIcon = Global.xpeg_count_project.My.Resources.MenuHome.Donate_30px
        Me.DonateMenuItem.MenuText = "Doação"
        Me.DonateMenuItem.Name = "DonateMenuItem"
        '
        'FeedBackMenuItem
        '
        Me.FeedBackMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FeedBackMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.FeedBackMenuItem, "FeedBackMenuItem")
        Me.FeedBackMenuItem.ForeColor = System.Drawing.Color.White
        Me.FeedBackMenuItem.MenuIcon = Global.xpeg_count_project.My.Resources.MenuHome.FeedBack_30px
        Me.FeedBackMenuItem.MenuText = "FeedBack"
        Me.FeedBackMenuItem.Name = "FeedBackMenuItem"
        '
        'HelpCenterMenuItem
        '
        Me.HelpCenterMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HelpCenterMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.HelpCenterMenuItem, "HelpCenterMenuItem")
        Me.HelpCenterMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpCenterMenuItem.MenuIcon = CType(resources.GetObject("HelpCenterMenuItem.MenuIcon"), System.Drawing.Image)
        Me.HelpCenterMenuItem.MenuText = "Central de Ajuda"
        Me.HelpCenterMenuItem.Name = "HelpCenterMenuItem"
        '
        'SettingsMenuItem
        '
        Me.SettingsMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SettingsMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.SettingsMenuItem, "SettingsMenuItem")
        Me.SettingsMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsMenuItem.MenuIcon = CType(resources.GetObject("SettingsMenuItem.MenuIcon"), System.Drawing.Image)
        Me.SettingsMenuItem.MenuText = "Configurações"
        Me.SettingsMenuItem.Name = "SettingsMenuItem"
        '
        'ExpensesArchiveMenuItem
        '
        Me.ExpensesArchiveMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ExpensesArchiveMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.ExpensesArchiveMenuItem, "ExpensesArchiveMenuItem")
        Me.ExpensesArchiveMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExpensesArchiveMenuItem.MenuIcon = Global.xpeg_count_project.My.Resources.MenuHome.ExpensesArchive_30px
        Me.ExpensesArchiveMenuItem.MenuText = "Despesas Arquivadas"
        Me.ExpensesArchiveMenuItem.Name = "ExpensesArchiveMenuItem"
        '
        'AddCreditCardMenuItem
        '
        Me.AddCreditCardMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AddCreditCardMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.AddCreditCardMenuItem, "AddCreditCardMenuItem")
        Me.AddCreditCardMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddCreditCardMenuItem.MenuIcon = CType(resources.GetObject("AddCreditCardMenuItem.MenuIcon"), System.Drawing.Image)
        Me.AddCreditCardMenuItem.MenuText = "Adicionar Cartão de Crédito"
        Me.AddCreditCardMenuItem.Name = "AddCreditCardMenuItem"
        '
        'NewExpenseMenuItem
        '
        Me.NewExpenseMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.NewExpenseMenuItem.ClickAndClose = True
        resources.ApplyResources(Me.NewExpenseMenuItem, "NewExpenseMenuItem")
        Me.NewExpenseMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewExpenseMenuItem.MenuIcon = CType(resources.GetObject("NewExpenseMenuItem.MenuIcon"), System.Drawing.Image)
        Me.NewExpenseMenuItem.MenuText = "Nova Despesa"
        Me.NewExpenseMenuItem.Name = "NewExpenseMenuItem"
        '
        'MenuHeader
        '
        Me.MenuHeader.Controls.Add(Me.MenuButton)
        Me.MenuHeader.Controls.Add(Me.CountLogoPanel)
        resources.ApplyResources(Me.MenuHeader, "MenuHeader")
        Me.MenuHeader.Name = "MenuHeader"
        '
        'MenuButton
        '
        resources.ApplyResources(Me.MenuButton, "MenuButton")
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.TabStop = False
        '
        'CountLogoPanel
        '
        resources.ApplyResources(Me.CountLogoPanel, "CountLogoPanel")
        Me.CountLogoPanel.Controls.Add(Me.xpegTitleLabel)
        Me.CountLogoPanel.Controls.Add(Me.CountTitleLabel)
        Me.CountLogoPanel.Name = "CountLogoPanel"
        '
        'xpegTitleLabel
        '
        resources.ApplyResources(Me.xpegTitleLabel, "xpegTitleLabel")
        Me.xpegTitleLabel.Name = "xpegTitleLabel"
        '
        'CountTitleLabel
        '
        resources.ApplyResources(Me.CountTitleLabel, "CountTitleLabel")
        Me.CountTitleLabel.Name = "CountTitleLabel"
        '
        'XpegCountForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MenuHomeBackground)
        Me.Controls.Add(Me.FiltersBackgroundPanel)
        Me.Controls.Add(Me.FormBackground)
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStripKeys
        Me.Name = "XpegCountForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ModeViewSelectorPanel.ResumeLayout(False)
        CType(Me.FiltersButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SelectorYear_Panel.ResumeLayout(False)
        CType(Me.Btn_BackYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NextYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripKeys.ResumeLayout(False)
        Me.MenuStripKeys.PerformLayout()
        Me.TabControl_ExpensesMonths.ResumeLayout(False)
        CType(Me.FileWatcher_Expenses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileWatcher_Values, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DashboradPanel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.DashboardPanel_CreditCards.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        CType(Me.DashboardIcon_CreditCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel32.ResumeLayout(False)
        Me.DashboardPanel_ExpensesValue.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        CType(Me.DashboradIcon_Expenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        Me.DashboardPanel_RestToPayValue.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        CType(Me.DashboardIcon_RestToPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.DashboardPanel_ValuePaid.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DashboardIcon_ValuePaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.FormBackground.ResumeLayout(False)
        Me.ControlsPanel.ResumeLayout(False)
        Me.CalendarModePanel.ResumeLayout(False)
        Me.BlocksModePanel.ResumeLayout(False)
        Me.ExpenseBlocksFlowPanel.ResumeLayout(False)
        CType(Me.CalendarViewModeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlocksViewModeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseFiltersButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayAllFiltersBlocksButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltersBackgroundPanel.ResumeLayout(False)
        Me.FiltersPanel.ResumeLayout(False)
        Me.FiltersBlocksPanel.ResumeLayout(False)
        Me.FilterByOrder_BlockFilter.ResumeLayout(False)
        Me.FilterByOrder_BlockFilterContainer.ResumeLayout(False)
        Me.Panel39.ResumeLayout(False)
        Me.FilterByOrder_BlockFilterPanelTitle.ResumeLayout(False)
        Me.FilterByOrder_BlockFilterPanelTitle.PerformLayout()
        Me.FilterByValue_BlockFilter.ResumeLayout(False)
        Me.FilterByValue_BlockFilterContainer.ResumeLayout(False)
        Me.FilterByValue_BlockFilterContainer.PerformLayout()
        Me.FilterByValue_BlockFilterPanelTitle.ResumeLayout(False)
        Me.FilterByValue_BlockFilterPanelTitle.PerformLayout()
        Me.FilterByCategory_BlockFilter.ResumeLayout(False)
        Me.FilterByCategory_BlockFilterContainer.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.FilterByCategory_BlockFilterPanelTitle.ResumeLayout(False)
        Me.FilterByCategory_BlockFilterPanelTitle.PerformLayout()
        Me.FilterByDate_BlockFilter.ResumeLayout(False)
        Me.FilterByDate_BlockFilterContainer.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel28.ResumeLayout(False)
        Me.FilterByDate_BlockFilterPanelTitle.ResumeLayout(False)
        Me.FilterByDate_BlockFilterPanelTitle.PerformLayout()
        Me.DashboardOptions_BlockFilter.ResumeLayout(False)
        Me.Panel41.ResumeLayout(False)
        Me.Panel45.ResumeLayout(False)
        Me.DashboardOptions_BlockFilterPanelTitle.ResumeLayout(False)
        Me.DashboardOptions_BlockFilterPanelTitle.PerformLayout()
        Me.ModeView_BlockFilter.ResumeLayout(False)
        Me.ModeView_BlockFilterContainer.ResumeLayout(False)
        Me.ModeView_BlockFilterPanelTitle.ResumeLayout(False)
        Me.ModeView_BlockFilterPanelTitle.PerformLayout()
        Me.HeaderFiltersPanel.ResumeLayout(False)
        Me.HeaderFiltersPanel.PerformLayout()
        Me.MenuHomeBackground.ResumeLayout(False)
        Me.MenuHomeElements.ResumeLayout(False)
        Me.MenuHeader.ResumeLayout(False)
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CountLogoPanel.ResumeLayout(False)
        Me.CountLogoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents TabControl_ExpensesMonths As System.Windows.Forms.TabControl
    Friend WithEvents TabPage01_Janeiro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage02_Fevereiro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage03_Março As System.Windows.Forms.TabPage
    Friend WithEvents TabPage04_Abril As System.Windows.Forms.TabPage
    Friend WithEvents TabPage05_Maio As System.Windows.Forms.TabPage
    Friend WithEvents TabPage06_Junho As System.Windows.Forms.TabPage
    Friend WithEvents TabPage07_Julho As System.Windows.Forms.TabPage
    Friend WithEvents TabPage08_Agosto As System.Windows.Forms.TabPage
    Friend WithEvents TabPage09_Setembro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10_Outubro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11_Novembro As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12_Dezembro As System.Windows.Forms.TabPage
    Friend WithEvents FileWatcher_Expenses As System.IO.FileSystemWatcher
    Friend WithEvents FileWatcher_Values As System.IO.FileSystemWatcher
    Friend WithEvents DashboardPanel_ValuePaid As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents DashboradPanel As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DashboardPanel_RestToPayValue As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents TotalValue_Paid_Label As System.Windows.Forms.Label
    Friend WithEvents Label_ValorPago As System.Windows.Forms.Label
    Friend WithEvents DashboardPanel_ExpensesValue As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Separator01 As System.Windows.Forms.Panel
    Friend WithEvents NumberOfExpenses_Label As System.Windows.Forms.Label
    Friend WithEvents Btn_BackYear As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_NextYear As System.Windows.Forms.PictureBox
    Friend WithEvents FormBackground As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SelectorYear_Panel As System.Windows.Forms.Panel
    Friend WithEvents ModeViewSelectorPanel As System.Windows.Forms.Panel
    Friend WithEvents BlocksViewModeButton As System.Windows.Forms.PictureBox
    Friend WithEvents CalendarViewModeButton As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ControlsPanel As System.Windows.Forms.Panel
    Friend WithEvents CalendarModePanel As System.Windows.Forms.Panel
    Friend WithEvents BlocksModePanel As System.Windows.Forms.Panel
    Friend WithEvents ExpenseBlocksFlowPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ExpenseCategoryItemControl1 As xpeg_count_project.ExpenseCategoryItemControl
    Friend WithEvents ExpenseCategoryItemControl2 As xpeg_count_project.ExpenseCategoryItemControl
    Friend WithEvents FiltersButton As System.Windows.Forms.PictureBox
    Friend WithEvents DashboardProgressBar_Paid As DashboardProgressBarCircle
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DashboardProgressBar_Rest As DashboardProgressBarCircle
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Label_FaltaParaQuitar As Label
    Friend WithEvents TotalValue_RestToPay_Label As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Label_Despesas As Label
    Friend WithEvents TotalValue_AllExpenses_Label As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents DashboardPanel_CreditCards As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label_Cartões As Label
    Friend WithEvents TotalValue_AllCreditCards_Label As Label
    Friend WithEvents Panel32 As Panel
    Friend WithEvents NumberOfCards_Label As Label
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents DashboardIcon_ValuePaid As PictureBox
    Friend WithEvents DashboardIcon_CreditCards As PictureBox
    Friend WithEvents DashboradIcon_Expenses As PictureBox
    Friend WithEvents DashboardIcon_RestToPay As PictureBox
    Friend WithEvents SelectedFilter_Label As Label
    Friend WithEvents FiltersBackgroundPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FiltersPanel As Panel
    Friend WithEvents HeaderFiltersPanel As Panel
    Friend WithEvents Label_Filtros As Label
    Friend WithEvents FiltersBlocksPanel As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label_DiaDeVencimento As System.Windows.Forms.Label
    Friend WithEvents ModeView_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents ModeView_BlockFilterContainer As System.Windows.Forms.Panel
    Friend WithEvents ModeView_BlockFilterSeparator As System.Windows.Forms.Panel
    Friend WithEvents ModeView_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents ModeView_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents FilterByDate_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents FilterByDate_BlockFilterContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents FilterByDate_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents FilterByDate_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents FilterByCategory_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents FilterByCategory_BlockFilterContainer As System.Windows.Forms.Panel
    Friend WithEvents FilterByCategory_BlockFilterSeparator As System.Windows.Forms.Panel
    Friend WithEvents FilterByCategory_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents FilterByCategory_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents FilterByValue_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents FilterByValue_BlockFilterContainer As System.Windows.Forms.Panel
    Friend WithEvents FilterByValue_BlockFilterSeparator As System.Windows.Forms.Panel
    Friend WithEvents FilterByValue_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents FilterByValue_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents FilterByOrder_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents FilterByOrder_BlockFilterContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents FilterByOrder_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents FilterByOrder_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents CloseFiltersButton As System.Windows.Forms.PictureBox
    Friend WithEvents MonthFilterComboBox As xpeg_count_project.MDComboBox
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents YearFilterComboBox As xpeg_count_project.MDComboBox
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents MdComboBox_Categorys As xpeg_count_project.MDComboBox
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents MdComboBox2 As xpeg_count_project.MDComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NoFilterAvailabledLabel As System.Windows.Forms.Label
    Friend WithEvents ApplyFiltersButton As System.Windows.Forms.Button
    Friend WithEvents DashboardOptions_BlockFilter As System.Windows.Forms.Panel
    Friend WithEvents Panel41 As System.Windows.Forms.Panel
    Friend WithEvents AllTime_DashboardPeriodRadioButton As xpeg_count_project.MDRadioButton
    Friend WithEvents ByMonth_DashboardPeriodRadioButton As xpeg_count_project.MDRadioButton
    Friend WithEvents Panel45 As System.Windows.Forms.Panel
    Friend WithEvents ByYear_DashboardPeriodRadioButton As xpeg_count_project.MDRadioButton
    Friend WithEvents Panel46 As System.Windows.Forms.Panel
    Friend WithEvents DashboardOptions_BlockFilterPanelTitle As System.Windows.Forms.Panel
    Friend WithEvents DashboardOptions_BlockFilterLabelTitle As System.Windows.Forms.Label
    Friend WithEvents MenuHomeBackground As System.Windows.Forms.Panel
    Friend WithEvents Panel42 As System.Windows.Forms.Panel
    Friend WithEvents MenuHomeElements As System.Windows.Forms.Panel
    Friend WithEvents MenuHeader As System.Windows.Forms.Panel
    Friend WithEvents CountLogoPanel As System.Windows.Forms.Panel
    Friend WithEvents xpegTitleLabel As System.Windows.Forms.Label
    Friend WithEvents CountTitleLabel As System.Windows.Forms.Label
    Friend WithEvents NewExpenseMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents ExpensesArchiveMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents AddCreditCardMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents ExitMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents InfSoftwareMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents HelpCenterMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents SettingsMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents MenuButton As System.Windows.Forms.PictureBox
    Friend WithEvents FeedBackMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents DonateMenuItem As xpeg_count_project.MenuItemListControl
    Friend WithEvents DisplayAllFiltersBlocksButton As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStripKeys As System.Windows.Forms.MenuStrip
    Friend WithEvents TeclasDeAtalhoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewExpenseKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCreditCardKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenSettingsKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenHelpCenterKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenInfoSoftwareKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFiltersKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMenuKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindSearchKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChangeViewModeKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
