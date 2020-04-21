<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewExpenseForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewExpenseForm))
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.ExpenseEndLabel = New System.Windows.Forms.Label()
        Me.SeparatorTitleForm = New System.Windows.Forms.Panel()
        Me.QuickOptionsButtons = New System.Windows.Forms.Panel()
        Me.PlaceBuy_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ChangeName_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ChangeDescription_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ChangeIcon_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ModeView_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.AddTag_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.Search_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.LinkCreditCard_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.QuickOptionExpenseButton2 = New xpeg_count_project.QuickOptionExpenseButton()
        Me.MenuQuickOptions_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ExpenseTitleIconPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ExpenseNameLabel = New System.Windows.Forms.Label()
        Me.ExpenseDescriptionLabel = New System.Windows.Forms.Label()
        Me.ExpenseColorPanel = New System.Windows.Forms.Panel()
        Me.ExpenseIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusPanelBackGround = New System.Windows.Forms.Panel()
        Me.StatusSeparatorLinePanel = New System.Windows.Forms.Panel()
        Me.StatusBarPanel = New System.Windows.Forms.Panel()
        Me.FlowLabelsStatusPlots = New System.Windows.Forms.FlowLayoutPanel()
        Me.NumbeOfPlotsSelectedsLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalSelectedLabel = New System.Windows.Forms.Label()
        Me.QuickOptionsPanel = New System.Windows.Forms.Panel()
        Me.AddNewPlot_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.PlotsSelectedOptionsPanel = New System.Windows.Forms.Panel()
        Me.SelectAll_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.SelectNone_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.PayPlots_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ChangeMaturidyDay_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.DeletePlots_QuickButton = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ExpenseControlsForm = New System.Windows.Forms.Panel()
        Me.TabControlPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_Informations = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel_BlocksInfos = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BLOCK_Category = New System.Windows.Forms.Panel()
        Me.BlockIcon_Category = New System.Windows.Forms.PictureBox()
        Me.Label_CategoriaDaDespesa = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Status = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.PorcentProgressLabel = New System.Windows.Forms.Label()
        Me.ProgressBarCircle_ExpenseProgress = New xpeg_count_project.DashboardProgressBarCircle()
        Me.BlockIcon_Status = New System.Windows.Forms.PictureBox()
        Me.BLOCK_BuyDate = New System.Windows.Forms.Panel()
        Me.BlockIcon_BuyDate = New System.Windows.Forms.PictureBox()
        Me.Label_DataDaCompra = New System.Windows.Forms.Label()
        Me.BuyDateLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Location = New System.Windows.Forms.Panel()
        Me.BlockIcon_Location = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BLOCK_Total = New System.Windows.Forms.Panel()
        Me.BlockIcon_Total = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.BLOCK_TotalNoIncludes = New System.Windows.Forms.Panel()
        Me.BlockIcon_TotalNoIncludes = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TotalNoIncludeLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Paid = New System.Windows.Forms.Panel()
        Me.BlockIcon_Paid = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaidLabel = New System.Windows.Forms.Label()
        Me.BLOCK_RestToPay = New System.Windows.Forms.Panel()
        Me.BlockIcon_RestToPay = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RestToPayLabel = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BLOCK_StartDate = New System.Windows.Forms.Panel()
        Me.BlockIcon_StartDate = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.StartDateLabel = New System.Windows.Forms.Label()
        Me.BLOCK_EndDate = New System.Windows.Forms.Panel()
        Me.BlockIcon_EndDate = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EndDateLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Duration = New System.Windows.Forms.Panel()
        Me.BlockIcon_Duration = New System.Windows.Forms.PictureBox()
        Me.Label_DuraçãoDaDespesa = New System.Windows.Forms.Label()
        Me.DurationLabel = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BLOCK_Plots = New System.Windows.Forms.Panel()
        Me.BlockIcon_Plots = New System.Windows.Forms.PictureBox()
        Me.Label_Parcelas = New System.Windows.Forms.Label()
        Me.PlotsCountLabel = New System.Windows.Forms.Label()
        Me.BLOCK_CardLink = New System.Windows.Forms.Panel()
        Me.BlockIcon_CardLink = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkCardLabel = New System.Windows.Forms.Label()
        Me.BLOCK_WhiteSpace = New System.Windows.Forms.Panel()
        Me.BLOCK_Discounts = New System.Windows.Forms.Panel()
        Me.BlockIcon_Discounts = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiscountsLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Interest = New System.Windows.Forms.Panel()
        Me.BlockIcon_Interests = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InterestLabel = New System.Windows.Forms.Label()
        Me.TabPage_Plots = New System.Windows.Forms.TabPage()
        Me.PlotsFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.EmptyPanel = New System.Windows.Forms.Panel()
        Me.TabPage_PaymentHistoric = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage_Comments = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage_Graphic = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CreditCardBackgroundPanel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip_QuickOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AlterarNomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorDeDestaqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IconeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarIconeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverIconeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlterarEstiloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpçõesDaDespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VincularComCartãoDeCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HabilitarPagamentosParciaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoDeVisualizaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArquivarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FeedBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BuscarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarLocalDeCompraDaDespesaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FixarNoInicioRecursoEmBreveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.FUNÇÕESPROCARTÃOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FileWatcherSystem = New System.IO.FileSystemWatcher()
        Me.HeaderPanel.SuspendLayout()
        Me.QuickOptionsButtons.SuspendLayout()
        Me.ExpenseTitleIconPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ExpenseColorPanel.SuspendLayout()
        CType(Me.ExpenseIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusPanelBackGround.SuspendLayout()
        Me.StatusBarPanel.SuspendLayout()
        Me.FlowLabelsStatusPlots.SuspendLayout()
        Me.QuickOptionsPanel.SuspendLayout()
        Me.PlotsSelectedOptionsPanel.SuspendLayout()
        Me.ExpenseControlsForm.SuspendLayout()
        Me.TabControlPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_Informations.SuspendLayout()
        Me.FlowLayoutPanel_BlocksInfos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BLOCK_Category.SuspendLayout()
        CType(Me.BlockIcon_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Status.SuspendLayout()
        CType(Me.BlockIcon_Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_BuyDate.SuspendLayout()
        CType(Me.BlockIcon_BuyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Location.SuspendLayout()
        CType(Me.BlockIcon_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.BLOCK_Total.SuspendLayout()
        CType(Me.BlockIcon_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_TotalNoIncludes.SuspendLayout()
        CType(Me.BlockIcon_TotalNoIncludes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Paid.SuspendLayout()
        CType(Me.BlockIcon_Paid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_RestToPay.SuspendLayout()
        CType(Me.BlockIcon_RestToPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.BLOCK_StartDate.SuspendLayout()
        CType(Me.BlockIcon_StartDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_EndDate.SuspendLayout()
        CType(Me.BlockIcon_EndDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Duration.SuspendLayout()
        CType(Me.BlockIcon_Duration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.BLOCK_Plots.SuspendLayout()
        CType(Me.BlockIcon_Plots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_CardLink.SuspendLayout()
        CType(Me.BlockIcon_CardLink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Discounts.SuspendLayout()
        CType(Me.BlockIcon_Discounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Interest.SuspendLayout()
        CType(Me.BlockIcon_Interests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Plots.SuspendLayout()
        Me.PlotsFlowPanel.SuspendLayout()
        Me.TabPage_PaymentHistoric.SuspendLayout()
        Me.TabPage_Comments.SuspendLayout()
        Me.TabPage_Graphic.SuspendLayout()
        Me.ContextMenuStrip_QuickOptions.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.ExpenseEndLabel)
        Me.HeaderPanel.Controls.Add(Me.SeparatorTitleForm)
        Me.HeaderPanel.Controls.Add(Me.QuickOptionsButtons)
        Me.HeaderPanel.Controls.Add(Me.ExpenseTitleIconPanel)
        Me.HeaderPanel.Controls.Add(Me.Panel2)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1233, 120)
        Me.HeaderPanel.TabIndex = 0
        '
        'ExpenseEndLabel
        '
        Me.ExpenseEndLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ExpenseEndLabel.AutoSize = True
        Me.ExpenseEndLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseEndLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseEndLabel.ForeColor = System.Drawing.Color.White
        Me.ExpenseEndLabel.Location = New System.Drawing.Point(1035, 46)
        Me.ExpenseEndLabel.Name = "ExpenseEndLabel"
        Me.ExpenseEndLabel.Size = New System.Drawing.Size(188, 28)
        Me.ExpenseEndLabel.TabIndex = 59
        Me.ExpenseEndLabel.Text = "Despesa Finalizada!"
        Me.ExpenseEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ExpenseEndLabel.Visible = False
        '
        'SeparatorTitleForm
        '
        Me.SeparatorTitleForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SeparatorTitleForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.SeparatorTitleForm.Location = New System.Drawing.Point(0, 0)
        Me.SeparatorTitleForm.Name = "SeparatorTitleForm"
        Me.SeparatorTitleForm.Size = New System.Drawing.Size(1233, 1)
        Me.SeparatorTitleForm.TabIndex = 80
        '
        'QuickOptionsButtons
        '
        Me.QuickOptionsButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuickOptionsButtons.BackColor = System.Drawing.Color.Transparent
        Me.QuickOptionsButtons.Controls.Add(Me.PlaceBuy_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.ChangeName_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.ChangeDescription_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.ChangeIcon_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.ModeView_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.AddTag_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.Search_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.LinkCreditCard_Button)
        Me.QuickOptionsButtons.Controls.Add(Me.QuickOptionExpenseButton2)
        Me.QuickOptionsButtons.Controls.Add(Me.MenuQuickOptions_Button)
        Me.QuickOptionsButtons.Location = New System.Drawing.Point(685, -2)
        Me.QuickOptionsButtons.Name = "QuickOptionsButtons"
        Me.QuickOptionsButtons.Size = New System.Drawing.Size(536, 26)
        Me.QuickOptionsButtons.TabIndex = 0
        '
        'PlaceBuy_Button
        '
        Me.PlaceBuy_Button.BackColor = System.Drawing.Color.Transparent
        Me.PlaceBuy_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.PlaceBuy_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PlaceBuy_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PlaceBuy_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_EditLocation_20x20
        Me.PlaceBuy_Button.ButtonText = "Local da Compra"
        Me.PlaceBuy_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.PlaceBuy_Button.Location = New System.Drawing.Point(226, 0)
        Me.PlaceBuy_Button.Name = "PlaceBuy_Button"
        Me.PlaceBuy_Button.Size = New System.Drawing.Size(31, 26)
        Me.PlaceBuy_Button.TabIndex = 9
        Me.PlaceBuy_Button.Tag = ""
        Me.PlaceBuy_Button.Visible = False
        '
        'ChangeName_Button
        '
        Me.ChangeName_Button.BackColor = System.Drawing.Color.Transparent
        Me.ChangeName_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ChangeName_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ChangeName_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ChangeName_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_RenameExpense_20x20
        Me.ChangeName_Button.ButtonText = "Alterar Nome"
        Me.ChangeName_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeName_Button.Location = New System.Drawing.Point(257, 0)
        Me.ChangeName_Button.Name = "ChangeName_Button"
        Me.ChangeName_Button.Size = New System.Drawing.Size(31, 26)
        Me.ChangeName_Button.TabIndex = 4
        Me.ChangeName_Button.Tag = ""
        Me.ChangeName_Button.Visible = False
        '
        'ChangeDescription_Button
        '
        Me.ChangeDescription_Button.BackColor = System.Drawing.Color.Transparent
        Me.ChangeDescription_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ChangeDescription_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ChangeDescription_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ChangeDescription_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_ChangeDescription_20x20
        Me.ChangeDescription_Button.ButtonText = "Alterar Descrição"
        Me.ChangeDescription_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeDescription_Button.Location = New System.Drawing.Point(288, 0)
        Me.ChangeDescription_Button.Name = "ChangeDescription_Button"
        Me.ChangeDescription_Button.Size = New System.Drawing.Size(31, 26)
        Me.ChangeDescription_Button.TabIndex = 3
        Me.ChangeDescription_Button.Tag = ""
        Me.ChangeDescription_Button.Visible = False
        '
        'ChangeIcon_Button
        '
        Me.ChangeIcon_Button.BackColor = System.Drawing.Color.Transparent
        Me.ChangeIcon_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ChangeIcon_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ChangeIcon_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ChangeIcon_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_ChangeIcon_20x20
        Me.ChangeIcon_Button.ButtonText = "Alterar Icone"
        Me.ChangeIcon_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeIcon_Button.Location = New System.Drawing.Point(319, 0)
        Me.ChangeIcon_Button.Name = "ChangeIcon_Button"
        Me.ChangeIcon_Button.Size = New System.Drawing.Size(31, 26)
        Me.ChangeIcon_Button.TabIndex = 2
        Me.ChangeIcon_Button.Tag = ""
        Me.ChangeIcon_Button.Visible = False
        '
        'ModeView_Button
        '
        Me.ModeView_Button.BackColor = System.Drawing.Color.Transparent
        Me.ModeView_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ModeView_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ModeView_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ModeView_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_ModeViewList_20x20
        Me.ModeView_Button.ButtonText = "Modo de Visualização"
        Me.ModeView_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.ModeView_Button.Location = New System.Drawing.Point(350, 0)
        Me.ModeView_Button.Name = "ModeView_Button"
        Me.ModeView_Button.Size = New System.Drawing.Size(31, 26)
        Me.ModeView_Button.TabIndex = 5
        Me.ModeView_Button.Tag = ""
        Me.ModeView_Button.Visible = False
        '
        'AddTag_Button
        '
        Me.AddTag_Button.BackColor = System.Drawing.Color.Transparent
        Me.AddTag_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.AddTag_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddTag_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AddTag_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_AddTag_20x20
        Me.AddTag_Button.ButtonText = "Adicionar Tag"
        Me.AddTag_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddTag_Button.Location = New System.Drawing.Point(381, 0)
        Me.AddTag_Button.Name = "AddTag_Button"
        Me.AddTag_Button.Size = New System.Drawing.Size(31, 26)
        Me.AddTag_Button.TabIndex = 10
        Me.AddTag_Button.Tag = ""
        Me.AddTag_Button.Visible = False
        '
        'Search_Button
        '
        Me.Search_Button.BackColor = System.Drawing.Color.Transparent
        Me.Search_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Search_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Search_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Search_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_Search_20x20
        Me.Search_Button.ButtonText = "Pesquisar"
        Me.Search_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.Search_Button.Location = New System.Drawing.Point(412, 0)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(31, 26)
        Me.Search_Button.TabIndex = 7
        Me.Search_Button.Tag = ""
        Me.Search_Button.Visible = False
        '
        'LinkCreditCard_Button
        '
        Me.LinkCreditCard_Button.BackColor = System.Drawing.Color.Transparent
        Me.LinkCreditCard_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.LinkCreditCard_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LinkCreditCard_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.LinkCreditCard_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_LinkWithCreditCard_20x20
        Me.LinkCreditCard_Button.ButtonText = "Vincular com Cartão de Crédito"
        Me.LinkCreditCard_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkCreditCard_Button.Location = New System.Drawing.Point(443, 0)
        Me.LinkCreditCard_Button.Name = "LinkCreditCard_Button"
        Me.LinkCreditCard_Button.Size = New System.Drawing.Size(31, 26)
        Me.LinkCreditCard_Button.TabIndex = 12
        Me.LinkCreditCard_Button.Tag = ""
        Me.LinkCreditCard_Button.Visible = False
        '
        'QuickOptionExpenseButton2
        '
        Me.QuickOptionExpenseButton2.BackColor = System.Drawing.Color.Transparent
        Me.QuickOptionExpenseButton2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.QuickOptionExpenseButton2.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.QuickOptionExpenseButton2.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.QuickOptionExpenseButton2.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_UnPin_20x20
        Me.QuickOptionExpenseButton2.ButtonText = "Fixar"
        Me.QuickOptionExpenseButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.QuickOptionExpenseButton2.Location = New System.Drawing.Point(474, 0)
        Me.QuickOptionExpenseButton2.Name = "QuickOptionExpenseButton2"
        Me.QuickOptionExpenseButton2.Size = New System.Drawing.Size(31, 26)
        Me.QuickOptionExpenseButton2.TabIndex = 8
        Me.QuickOptionExpenseButton2.Tag = ""
        Me.QuickOptionExpenseButton2.Visible = False
        '
        'MenuQuickOptions_Button
        '
        Me.MenuQuickOptions_Button.BackColor = System.Drawing.Color.Transparent
        Me.MenuQuickOptions_Button.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.MenuQuickOptions_Button.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.MenuQuickOptions_Button.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.MenuQuickOptions_Button.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_QuickMenu_20x20
        Me.MenuQuickOptions_Button.ButtonText = "Menu"
        Me.MenuQuickOptions_Button.Dock = System.Windows.Forms.DockStyle.Right
        Me.MenuQuickOptions_Button.Location = New System.Drawing.Point(505, 0)
        Me.MenuQuickOptions_Button.Name = "MenuQuickOptions_Button"
        Me.MenuQuickOptions_Button.Size = New System.Drawing.Size(31, 26)
        Me.MenuQuickOptions_Button.TabIndex = 0
        Me.MenuQuickOptions_Button.Tag = ""
        '
        'ExpenseTitleIconPanel
        '
        Me.ExpenseTitleIconPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpenseTitleIconPanel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseTitleIconPanel.Controls.Add(Me.Panel5)
        Me.ExpenseTitleIconPanel.Controls.Add(Me.ExpenseColorPanel)
        Me.ExpenseTitleIconPanel.ForeColor = System.Drawing.Color.White
        Me.ExpenseTitleIconPanel.Location = New System.Drawing.Point(40, 30)
        Me.ExpenseTitleIconPanel.Name = "ExpenseTitleIconPanel"
        Me.ExpenseTitleIconPanel.Size = New System.Drawing.Size(667, 60)
        Me.ExpenseTitleIconPanel.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.ExpenseNameLabel)
        Me.Panel5.Controls.Add(Me.ExpenseDescriptionLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(60, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(607, 60)
        Me.Panel5.TabIndex = 3
        '
        'ExpenseNameLabel
        '
        Me.ExpenseNameLabel.AutoSize = True
        Me.ExpenseNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseNameLabel.Location = New System.Drawing.Point(6, 2)
        Me.ExpenseNameLabel.Name = "ExpenseNameLabel"
        Me.ExpenseNameLabel.Size = New System.Drawing.Size(105, 32)
        Me.ExpenseNameLabel.TabIndex = 0
        Me.ExpenseNameLabel.Text = "Despesa"
        '
        'ExpenseDescriptionLabel
        '
        Me.ExpenseDescriptionLabel.AutoSize = True
        Me.ExpenseDescriptionLabel.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.ExpenseDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ExpenseDescriptionLabel.Location = New System.Drawing.Point(9, 36)
        Me.ExpenseDescriptionLabel.Name = "ExpenseDescriptionLabel"
        Me.ExpenseDescriptionLabel.Size = New System.Drawing.Size(155, 19)
        Me.ExpenseDescriptionLabel.TabIndex = 1
        Me.ExpenseDescriptionLabel.Text = "Descrição desta Despesa."
        '
        'ExpenseColorPanel
        '
        Me.ExpenseColorPanel.Controls.Add(Me.ExpenseIconPictureBox)
        Me.ExpenseColorPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpenseColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ExpenseColorPanel.Name = "ExpenseColorPanel"
        Me.ExpenseColorPanel.Size = New System.Drawing.Size(60, 60)
        Me.ExpenseColorPanel.TabIndex = 2
        '
        'ExpenseIconPictureBox
        '
        Me.ExpenseIconPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpenseIconPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.ExpenseIconPictureBox.Name = "ExpenseIconPictureBox"
        Me.ExpenseIconPictureBox.Size = New System.Drawing.Size(60, 60)
        Me.ExpenseIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ExpenseIconPictureBox.TabIndex = 0
        Me.ExpenseIconPictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1233, 1)
        Me.Panel2.TabIndex = 0
        '
        'StatusPanelBackGround
        '
        Me.StatusPanelBackGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StatusPanelBackGround.Controls.Add(Me.StatusSeparatorLinePanel)
        Me.StatusPanelBackGround.Controls.Add(Me.StatusBarPanel)
        Me.StatusPanelBackGround.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanelBackGround.Location = New System.Drawing.Point(0, 531)
        Me.StatusPanelBackGround.Name = "StatusPanelBackGround"
        Me.StatusPanelBackGround.Size = New System.Drawing.Size(1233, 30)
        Me.StatusPanelBackGround.TabIndex = 1
        '
        'StatusSeparatorLinePanel
        '
        Me.StatusSeparatorLinePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.StatusSeparatorLinePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusSeparatorLinePanel.Location = New System.Drawing.Point(0, 0)
        Me.StatusSeparatorLinePanel.Name = "StatusSeparatorLinePanel"
        Me.StatusSeparatorLinePanel.Size = New System.Drawing.Size(1233, 1)
        Me.StatusSeparatorLinePanel.TabIndex = 2
        '
        'StatusBarPanel
        '
        Me.StatusBarPanel.Controls.Add(Me.FlowLabelsStatusPlots)
        Me.StatusBarPanel.Controls.Add(Me.QuickOptionsPanel)
        Me.StatusBarPanel.Controls.Add(Me.PlotsSelectedOptionsPanel)
        Me.StatusBarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusBarPanel.ForeColor = System.Drawing.Color.White
        Me.StatusBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPanel.Name = "StatusBarPanel"
        Me.StatusBarPanel.Size = New System.Drawing.Size(1233, 30)
        Me.StatusBarPanel.TabIndex = 3
        '
        'FlowLabelsStatusPlots
        '
        Me.FlowLabelsStatusPlots.Controls.Add(Me.NumbeOfPlotsSelectedsLabel)
        Me.FlowLabelsStatusPlots.Controls.Add(Me.Label6)
        Me.FlowLabelsStatusPlots.Controls.Add(Me.TotalSelectedLabel)
        Me.FlowLabelsStatusPlots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLabelsStatusPlots.Location = New System.Drawing.Point(0, 0)
        Me.FlowLabelsStatusPlots.Name = "FlowLabelsStatusPlots"
        Me.FlowLabelsStatusPlots.Padding = New System.Windows.Forms.Padding(10, 7, 0, 0)
        Me.FlowLabelsStatusPlots.Size = New System.Drawing.Size(869, 30)
        Me.FlowLabelsStatusPlots.TabIndex = 59
        Me.FlowLabelsStatusPlots.Visible = False
        '
        'NumbeOfPlotsSelectedsLabel
        '
        Me.NumbeOfPlotsSelectedsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NumbeOfPlotsSelectedsLabel.AutoSize = True
        Me.NumbeOfPlotsSelectedsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NumbeOfPlotsSelectedsLabel.ForeColor = System.Drawing.Color.White
        Me.NumbeOfPlotsSelectedsLabel.Location = New System.Drawing.Point(13, 7)
        Me.NumbeOfPlotsSelectedsLabel.Name = "NumbeOfPlotsSelectedsLabel"
        Me.NumbeOfPlotsSelectedsLabel.Size = New System.Drawing.Size(135, 15)
        Me.NumbeOfPlotsSelectedsLabel.TabIndex = 58
        Me.NumbeOfPlotsSelectedsLabel.Text = "Parcelas Selecionadas: 0"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(154, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "|"
        '
        'TotalSelectedLabel
        '
        Me.TotalSelectedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TotalSelectedLabel.AutoSize = True
        Me.TotalSelectedLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TotalSelectedLabel.ForeColor = System.Drawing.Color.White
        Me.TotalSelectedLabel.Location = New System.Drawing.Point(170, 7)
        Me.TotalSelectedLabel.Name = "TotalSelectedLabel"
        Me.TotalSelectedLabel.Size = New System.Drawing.Size(148, 15)
        Me.TotalSelectedLabel.TabIndex = 60
        Me.TotalSelectedLabel.Text = "Total Selecionado: R$ 0,00"
        '
        'QuickOptionsPanel
        '
        Me.QuickOptionsPanel.BackColor = System.Drawing.Color.Transparent
        Me.QuickOptionsPanel.Controls.Add(Me.AddNewPlot_QuickButton)
        Me.QuickOptionsPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.QuickOptionsPanel.Location = New System.Drawing.Point(869, 0)
        Me.QuickOptionsPanel.Name = "QuickOptionsPanel"
        Me.QuickOptionsPanel.Padding = New System.Windows.Forms.Padding(0, 2, 10, 2)
        Me.QuickOptionsPanel.Size = New System.Drawing.Size(166, 30)
        Me.QuickOptionsPanel.TabIndex = 60
        Me.QuickOptionsPanel.Visible = False
        '
        'AddNewPlot_QuickButton
        '
        Me.AddNewPlot_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.AddNewPlot_QuickButton.ButtonColor = System.Drawing.Color.Blue
        Me.AddNewPlot_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.AddNewPlot_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.AddNewPlot_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.Resources.Icon_AddPlot_20x20
        Me.AddNewPlot_QuickButton.ButtonText = "Adicionar Parcela"
        Me.AddNewPlot_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddNewPlot_QuickButton.Location = New System.Drawing.Point(125, 2)
        Me.AddNewPlot_QuickButton.Name = "AddNewPlot_QuickButton"
        Me.AddNewPlot_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.AddNewPlot_QuickButton.TabIndex = 1
        Me.AddNewPlot_QuickButton.Tag = ""
        '
        'PlotsSelectedOptionsPanel
        '
        Me.PlotsSelectedOptionsPanel.BackColor = System.Drawing.Color.Transparent
        Me.PlotsSelectedOptionsPanel.Controls.Add(Me.SelectAll_QuickButton)
        Me.PlotsSelectedOptionsPanel.Controls.Add(Me.SelectNone_QuickButton)
        Me.PlotsSelectedOptionsPanel.Controls.Add(Me.PayPlots_QuickButton)
        Me.PlotsSelectedOptionsPanel.Controls.Add(Me.ChangeMaturidyDay_QuickButton)
        Me.PlotsSelectedOptionsPanel.Controls.Add(Me.DeletePlots_QuickButton)
        Me.PlotsSelectedOptionsPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PlotsSelectedOptionsPanel.Location = New System.Drawing.Point(1035, 0)
        Me.PlotsSelectedOptionsPanel.Name = "PlotsSelectedOptionsPanel"
        Me.PlotsSelectedOptionsPanel.Padding = New System.Windows.Forms.Padding(0, 2, 10, 2)
        Me.PlotsSelectedOptionsPanel.Size = New System.Drawing.Size(198, 30)
        Me.PlotsSelectedOptionsPanel.TabIndex = 1
        Me.PlotsSelectedOptionsPanel.Visible = False
        '
        'SelectAll_QuickButton
        '
        Me.SelectAll_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.SelectAll_QuickButton.ButtonColor = System.Drawing.Color.Indigo
        Me.SelectAll_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SelectAll_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SelectAll_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_SelectAll_20px
        Me.SelectAll_QuickButton.ButtonText = "Selecionar Tudo"
        Me.SelectAll_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SelectAll_QuickButton.Location = New System.Drawing.Point(33, 2)
        Me.SelectAll_QuickButton.Name = "SelectAll_QuickButton"
        Me.SelectAll_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.SelectAll_QuickButton.TabIndex = 5
        Me.SelectAll_QuickButton.Tag = ""
        '
        'SelectNone_QuickButton
        '
        Me.SelectNone_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.SelectNone_QuickButton.ButtonColor = System.Drawing.SystemColors.HotTrack
        Me.SelectNone_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.SelectNone_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.SelectNone_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_SelectNone_20px
        Me.SelectNone_QuickButton.ButtonText = "Desmarcar Tudo"
        Me.SelectNone_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SelectNone_QuickButton.Location = New System.Drawing.Point(64, 2)
        Me.SelectNone_QuickButton.Name = "SelectNone_QuickButton"
        Me.SelectNone_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.SelectNone_QuickButton.TabIndex = 4
        Me.SelectNone_QuickButton.Tag = ""
        '
        'PayPlots_QuickButton
        '
        Me.PayPlots_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.PayPlots_QuickButton.ButtonColor = System.Drawing.Color.LightCoral
        Me.PayPlots_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PayPlots_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PayPlots_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_Pay_20px
        Me.PayPlots_QuickButton.ButtonText = "Pagar Parcelas"
        Me.PayPlots_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.PayPlots_QuickButton.Location = New System.Drawing.Point(95, 2)
        Me.PayPlots_QuickButton.Name = "PayPlots_QuickButton"
        Me.PayPlots_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.PayPlots_QuickButton.TabIndex = 2
        Me.PayPlots_QuickButton.Tag = ""
        Me.PayPlots_QuickButton.Visible = False
        '
        'ChangeMaturidyDay_QuickButton
        '
        Me.ChangeMaturidyDay_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.ChangeMaturidyDay_QuickButton.ButtonColor = System.Drawing.Color.Blue
        Me.ChangeMaturidyDay_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ChangeMaturidyDay_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ChangeMaturidyDay_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeMaturityDay_20x20
        Me.ChangeMaturidyDay_QuickButton.ButtonText = "Alterar Dia de Vencimento"
        Me.ChangeMaturidyDay_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ChangeMaturidyDay_QuickButton.Location = New System.Drawing.Point(126, 2)
        Me.ChangeMaturidyDay_QuickButton.Name = "ChangeMaturidyDay_QuickButton"
        Me.ChangeMaturidyDay_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.ChangeMaturidyDay_QuickButton.TabIndex = 1
        Me.ChangeMaturidyDay_QuickButton.Tag = ""
        Me.ChangeMaturidyDay_QuickButton.Visible = False
        '
        'DeletePlots_QuickButton
        '
        Me.DeletePlots_QuickButton.BackColor = System.Drawing.Color.Transparent
        Me.DeletePlots_QuickButton.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DeletePlots_QuickButton.ButtonColor_MouseDown = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.DeletePlots_QuickButton.ButtonColor_MouseEnter = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DeletePlots_QuickButton.ButtonIcon = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.Icon_Delete_20x20
        Me.DeletePlots_QuickButton.ButtonText = "Excluir Parcelas"
        Me.DeletePlots_QuickButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeletePlots_QuickButton.Location = New System.Drawing.Point(157, 2)
        Me.DeletePlots_QuickButton.Name = "DeletePlots_QuickButton"
        Me.DeletePlots_QuickButton.Size = New System.Drawing.Size(31, 26)
        Me.DeletePlots_QuickButton.TabIndex = 0
        Me.DeletePlots_QuickButton.Tag = ""
        '
        'ExpenseControlsForm
        '
        Me.ExpenseControlsForm.Controls.Add(Me.TabControlPanel)
        Me.ExpenseControlsForm.Controls.Add(Me.CreditCardBackgroundPanel)
        Me.ExpenseControlsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpenseControlsForm.Location = New System.Drawing.Point(0, 120)
        Me.ExpenseControlsForm.Name = "ExpenseControlsForm"
        Me.ExpenseControlsForm.Size = New System.Drawing.Size(1233, 411)
        Me.ExpenseControlsForm.TabIndex = 2
        '
        'TabControlPanel
        '
        Me.TabControlPanel.Controls.Add(Me.TabControl1)
        Me.TabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel.Name = "TabControlPanel"
        Me.TabControlPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.TabControlPanel.Size = New System.Drawing.Size(1223, 411)
        Me.TabControlPanel.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Informations)
        Me.TabControl1.Controls.Add(Me.TabPage_Plots)
        Me.TabControl1.Controls.Add(Me.TabPage_PaymentHistoric)
        Me.TabControl1.Controls.Add(Me.TabPage_Comments)
        Me.TabControl1.Controls.Add(Me.TabPage_Graphic)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(30, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1203, 391)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage_Informations
        '
        Me.TabPage_Informations.Controls.Add(Me.FlowLayoutPanel_BlocksInfos)
        Me.TabPage_Informations.Location = New System.Drawing.Point(4, 43)
        Me.TabPage_Informations.Name = "TabPage_Informations"
        Me.TabPage_Informations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Informations.Size = New System.Drawing.Size(1195, 344)
        Me.TabPage_Informations.TabIndex = 0
        Me.TabPage_Informations.Text = "Despesa"
        Me.TabPage_Informations.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel_BlocksInfos
        '
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Category)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Status)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_BuyDate)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Location)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Total)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_TotalNoIncludes)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Paid)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_RestToPay)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_StartDate)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_EndDate)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Duration)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Plots)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_CardLink)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_WhiteSpace)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Discounts)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Interest)
        Me.FlowLayoutPanel_BlocksInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel_BlocksInfos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel_BlocksInfos.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel_BlocksInfos.Name = "FlowLayoutPanel_BlocksInfos"
        Me.FlowLayoutPanel_BlocksInfos.Padding = New System.Windows.Forms.Padding(30, 20, 30, 10)
        Me.FlowLayoutPanel_BlocksInfos.Size = New System.Drawing.Size(1189, 338)
        Me.FlowLayoutPanel_BlocksInfos.TabIndex = 67
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(30, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 20)
        Me.Panel1.TabIndex = 76
        Me.Panel1.Visible = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(180, 17)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "INFORMAÇÕES DA DESPESA"
        '
        'BLOCK_Category
        '
        Me.BLOCK_Category.Controls.Add(Me.BlockIcon_Category)
        Me.BLOCK_Category.Controls.Add(Me.Label_CategoriaDaDespesa)
        Me.BLOCK_Category.Controls.Add(Me.CategoryLabel)
        Me.BLOCK_Category.Location = New System.Drawing.Point(30, 45)
        Me.BLOCK_Category.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Category.Name = "BLOCK_Category"
        Me.BLOCK_Category.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Category.TabIndex = 1
        Me.BLOCK_Category.Visible = False
        '
        'BlockIcon_Category
        '
        Me.BlockIcon_Category.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Category.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockCategory_100x100
        Me.BlockIcon_Category.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Category.Name = "BlockIcon_Category"
        Me.BlockIcon_Category.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Category.TabIndex = 1
        Me.BlockIcon_Category.TabStop = False
        '
        'Label_CategoriaDaDespesa
        '
        Me.Label_CategoriaDaDespesa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_CategoriaDaDespesa.AutoSize = True
        Me.Label_CategoriaDaDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_CategoriaDaDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label_CategoriaDaDespesa.Location = New System.Drawing.Point(50, 8)
        Me.Label_CategoriaDaDespesa.Name = "Label_CategoriaDaDespesa"
        Me.Label_CategoriaDaDespesa.Size = New System.Drawing.Size(57, 15)
        Me.Label_CategoriaDaDespesa.TabIndex = 58
        Me.Label_CategoriaDaDespesa.Text = "Categoria"
        '
        'CategoryLabel
        '
        Me.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CategoryLabel.Location = New System.Drawing.Point(49, 23)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(35, 20)
        Me.CategoryLabel.TabIndex = 57
        Me.CategoryLabel.Text = "text"
        '
        'BLOCK_Status
        '
        Me.BLOCK_Status.Controls.Add(Me.Label19)
        Me.BLOCK_Status.Controls.Add(Me.StatusLabel)
        Me.BLOCK_Status.Controls.Add(Me.PorcentProgressLabel)
        Me.BLOCK_Status.Controls.Add(Me.ProgressBarCircle_ExpenseProgress)
        Me.BLOCK_Status.Controls.Add(Me.BlockIcon_Status)
        Me.BLOCK_Status.Location = New System.Drawing.Point(30, 100)
        Me.BLOCK_Status.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Status.Name = "BLOCK_Status"
        Me.BLOCK_Status.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Status.TabIndex = 2
        Me.BLOCK_Status.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(50, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 15)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Status"
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.StatusLabel.Location = New System.Drawing.Point(49, 23)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(35, 20)
        Me.StatusLabel.TabIndex = 57
        Me.StatusLabel.Text = "text"
        '
        'PorcentProgressLabel
        '
        Me.PorcentProgressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PorcentProgressLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 7.0!)
        Me.PorcentProgressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PorcentProgressLabel.Location = New System.Drawing.Point(15, 19)
        Me.PorcentProgressLabel.Name = "PorcentProgressLabel"
        Me.PorcentProgressLabel.Size = New System.Drawing.Size(21, 15)
        Me.PorcentProgressLabel.TabIndex = 59
        Me.PorcentProgressLabel.Text = "100"
        Me.PorcentProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarCircle_ExpenseProgress
        '
        Me.ProgressBarCircle_ExpenseProgress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProgressBarCircle_ExpenseProgress.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBarCircle_ExpenseProgress.BaseColour = System.Drawing.Color.Gainsboro
        Me.ProgressBarCircle_ExpenseProgress.BorderColour = System.Drawing.Color.Transparent
        Me.ProgressBarCircle_ExpenseProgress.Location = New System.Drawing.Point(6, 6)
        Me.ProgressBarCircle_ExpenseProgress.Maximum = 100
        Me.ProgressBarCircle_ExpenseProgress.Name = "ProgressBarCircle_ExpenseProgress"
        Me.ProgressBarCircle_ExpenseProgress.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ProgressBarCircle_ExpenseProgress.RotationAngle = 360
        Me.ProgressBarCircle_ExpenseProgress.ShowPorcent = False
        Me.ProgressBarCircle_ExpenseProgress.Size = New System.Drawing.Size(40, 40)
        Me.ProgressBarCircle_ExpenseProgress.StartingAngle = 265
        Me.ProgressBarCircle_ExpenseProgress.TabIndex = 2
        Me.ProgressBarCircle_ExpenseProgress.Value = 0
        '
        'BlockIcon_Status
        '
        Me.BlockIcon_Status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Status.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockStatus_100x100
        Me.BlockIcon_Status.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Status.Name = "BlockIcon_Status"
        Me.BlockIcon_Status.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Status.TabIndex = 1
        Me.BlockIcon_Status.TabStop = False
        Me.BlockIcon_Status.Visible = False
        '
        'BLOCK_BuyDate
        '
        Me.BLOCK_BuyDate.Controls.Add(Me.BlockIcon_BuyDate)
        Me.BLOCK_BuyDate.Controls.Add(Me.Label_DataDaCompra)
        Me.BLOCK_BuyDate.Controls.Add(Me.BuyDateLabel)
        Me.BLOCK_BuyDate.Location = New System.Drawing.Point(30, 155)
        Me.BLOCK_BuyDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_BuyDate.Name = "BLOCK_BuyDate"
        Me.BLOCK_BuyDate.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_BuyDate.TabIndex = 3
        Me.BLOCK_BuyDate.Visible = False
        '
        'BlockIcon_BuyDate
        '
        Me.BlockIcon_BuyDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_BuyDate.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.BuyDate_100px
        Me.BlockIcon_BuyDate.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_BuyDate.Name = "BlockIcon_BuyDate"
        Me.BlockIcon_BuyDate.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_BuyDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_BuyDate.TabIndex = 1
        Me.BlockIcon_BuyDate.TabStop = False
        '
        'Label_DataDaCompra
        '
        Me.Label_DataDaCompra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_DataDaCompra.AutoSize = True
        Me.Label_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_DataDaCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label_DataDaCompra.Location = New System.Drawing.Point(50, 8)
        Me.Label_DataDaCompra.Name = "Label_DataDaCompra"
        Me.Label_DataDaCompra.Size = New System.Drawing.Size(91, 15)
        Me.Label_DataDaCompra.TabIndex = 58
        Me.Label_DataDaCompra.Text = "Data da Compra"
        '
        'BuyDateLabel
        '
        Me.BuyDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BuyDateLabel.AutoSize = True
        Me.BuyDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.BuyDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BuyDateLabel.Location = New System.Drawing.Point(49, 23)
        Me.BuyDateLabel.Name = "BuyDateLabel"
        Me.BuyDateLabel.Size = New System.Drawing.Size(35, 20)
        Me.BuyDateLabel.TabIndex = 57
        Me.BuyDateLabel.Text = "text"
        '
        'BLOCK_Location
        '
        Me.BLOCK_Location.Controls.Add(Me.BlockIcon_Location)
        Me.BLOCK_Location.Controls.Add(Me.Label7)
        Me.BLOCK_Location.Controls.Add(Me.LocationLabel)
        Me.BLOCK_Location.Location = New System.Drawing.Point(30, 210)
        Me.BLOCK_Location.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Location.Name = "BLOCK_Location"
        Me.BLOCK_Location.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Location.TabIndex = 4
        Me.BLOCK_Location.Visible = False
        '
        'BlockIcon_Location
        '
        Me.BlockIcon_Location.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Location.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockLocation_100x100
        Me.BlockIcon_Location.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Location.Name = "BlockIcon_Location"
        Me.BlockIcon_Location.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Location.TabIndex = 1
        Me.BlockIcon_Location.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(50, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Local"
        '
        'LocationLabel
        '
        Me.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.LocationLabel.Location = New System.Drawing.Point(49, 23)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(35, 20)
        Me.LocationLabel.TabIndex = 57
        Me.LocationLabel.Text = "text"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(30, 265)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 20)
        Me.Panel3.TabIndex = 77
        Me.Panel3.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(3, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 17)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "FINANCEIRO"
        '
        'BLOCK_Total
        '
        Me.BLOCK_Total.Controls.Add(Me.BlockIcon_Total)
        Me.BLOCK_Total.Controls.Add(Me.Label13)
        Me.BLOCK_Total.Controls.Add(Me.TotalLabel)
        Me.BLOCK_Total.Location = New System.Drawing.Point(380, 20)
        Me.BLOCK_Total.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Total.Name = "BLOCK_Total"
        Me.BLOCK_Total.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Total.TabIndex = 5
        Me.BLOCK_Total.Visible = False
        '
        'BlockIcon_Total
        '
        Me.BlockIcon_Total.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Total.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockTotal_100x100
        Me.BlockIcon_Total.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Total.Name = "BlockIcon_Total"
        Me.BlockIcon_Total.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Total.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Total.TabIndex = 1
        Me.BlockIcon_Total.TabStop = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(50, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 15)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Total"
        '
        'TotalLabel
        '
        Me.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TotalLabel.Location = New System.Drawing.Point(49, 23)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(35, 20)
        Me.TotalLabel.TabIndex = 57
        Me.TotalLabel.Text = "text"
        '
        'BLOCK_TotalNoIncludes
        '
        Me.BLOCK_TotalNoIncludes.Controls.Add(Me.BlockIcon_TotalNoIncludes)
        Me.BLOCK_TotalNoIncludes.Controls.Add(Me.Label1)
        Me.BLOCK_TotalNoIncludes.Controls.Add(Me.TotalNoIncludeLabel)
        Me.BLOCK_TotalNoIncludes.Location = New System.Drawing.Point(380, 75)
        Me.BLOCK_TotalNoIncludes.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_TotalNoIncludes.Name = "BLOCK_TotalNoIncludes"
        Me.BLOCK_TotalNoIncludes.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_TotalNoIncludes.TabIndex = 6
        Me.BLOCK_TotalNoIncludes.Visible = False
        '
        'BlockIcon_TotalNoIncludes
        '
        Me.BlockIcon_TotalNoIncludes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_TotalNoIncludes.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockNoIncludes_100x100
        Me.BlockIcon_TotalNoIncludes.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_TotalNoIncludes.Name = "BlockIcon_TotalNoIncludes"
        Me.BlockIcon_TotalNoIncludes.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_TotalNoIncludes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_TotalNoIncludes.TabIndex = 1
        Me.BlockIcon_TotalNoIncludes.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Total (Sem Inclusões)"
        '
        'TotalNoIncludeLabel
        '
        Me.TotalNoIncludeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TotalNoIncludeLabel.AutoSize = True
        Me.TotalNoIncludeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TotalNoIncludeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TotalNoIncludeLabel.Location = New System.Drawing.Point(49, 23)
        Me.TotalNoIncludeLabel.Name = "TotalNoIncludeLabel"
        Me.TotalNoIncludeLabel.Size = New System.Drawing.Size(35, 20)
        Me.TotalNoIncludeLabel.TabIndex = 57
        Me.TotalNoIncludeLabel.Text = "text"
        '
        'BLOCK_Paid
        '
        Me.BLOCK_Paid.Controls.Add(Me.BlockIcon_Paid)
        Me.BLOCK_Paid.Controls.Add(Me.Label3)
        Me.BLOCK_Paid.Controls.Add(Me.PaidLabel)
        Me.BLOCK_Paid.Location = New System.Drawing.Point(380, 130)
        Me.BLOCK_Paid.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Paid.Name = "BLOCK_Paid"
        Me.BLOCK_Paid.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Paid.TabIndex = 7
        Me.BLOCK_Paid.Visible = False
        '
        'BlockIcon_Paid
        '
        Me.BlockIcon_Paid.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Paid.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockValuePaid_100x100
        Me.BlockIcon_Paid.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Paid.Name = "BlockIcon_Paid"
        Me.BlockIcon_Paid.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Paid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Paid.TabIndex = 1
        Me.BlockIcon_Paid.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Pago"
        '
        'PaidLabel
        '
        Me.PaidLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PaidLabel.AutoSize = True
        Me.PaidLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.PaidLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PaidLabel.Location = New System.Drawing.Point(49, 23)
        Me.PaidLabel.Name = "PaidLabel"
        Me.PaidLabel.Size = New System.Drawing.Size(35, 20)
        Me.PaidLabel.TabIndex = 57
        Me.PaidLabel.Text = "text"
        '
        'BLOCK_RestToPay
        '
        Me.BLOCK_RestToPay.Controls.Add(Me.BlockIcon_RestToPay)
        Me.BLOCK_RestToPay.Controls.Add(Me.Label15)
        Me.BLOCK_RestToPay.Controls.Add(Me.RestToPayLabel)
        Me.BLOCK_RestToPay.Location = New System.Drawing.Point(380, 185)
        Me.BLOCK_RestToPay.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_RestToPay.Name = "BLOCK_RestToPay"
        Me.BLOCK_RestToPay.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_RestToPay.TabIndex = 8
        Me.BLOCK_RestToPay.Visible = False
        '
        'BlockIcon_RestToPay
        '
        Me.BlockIcon_RestToPay.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_RestToPay.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockRestToPay_100x100
        Me.BlockIcon_RestToPay.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_RestToPay.Name = "BlockIcon_RestToPay"
        Me.BlockIcon_RestToPay.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_RestToPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_RestToPay.TabIndex = 1
        Me.BlockIcon_RestToPay.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(50, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 15)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Falta"
        '
        'RestToPayLabel
        '
        Me.RestToPayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RestToPayLabel.AutoSize = True
        Me.RestToPayLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.RestToPayLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.RestToPayLabel.Location = New System.Drawing.Point(49, 23)
        Me.RestToPayLabel.Name = "RestToPayLabel"
        Me.RestToPayLabel.Size = New System.Drawing.Size(35, 20)
        Me.RestToPayLabel.TabIndex = 57
        Me.RestToPayLabel.Text = "text"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Location = New System.Drawing.Point(380, 240)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 20)
        Me.Panel4.TabIndex = 78
        Me.Panel4.Visible = False
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(3, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 17)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "DATAS"
        '
        'BLOCK_StartDate
        '
        Me.BLOCK_StartDate.Controls.Add(Me.BlockIcon_StartDate)
        Me.BLOCK_StartDate.Controls.Add(Me.Label9)
        Me.BLOCK_StartDate.Controls.Add(Me.StartDateLabel)
        Me.BLOCK_StartDate.Location = New System.Drawing.Point(380, 265)
        Me.BLOCK_StartDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_StartDate.Name = "BLOCK_StartDate"
        Me.BLOCK_StartDate.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_StartDate.TabIndex = 9
        Me.BLOCK_StartDate.Visible = False
        '
        'BlockIcon_StartDate
        '
        Me.BlockIcon_StartDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_StartDate.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockStartDate_100x100
        Me.BlockIcon_StartDate.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_StartDate.Name = "BlockIcon_StartDate"
        Me.BlockIcon_StartDate.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_StartDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_StartDate.TabIndex = 1
        Me.BlockIcon_StartDate.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(50, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Data Inicial"
        '
        'StartDateLabel
        '
        Me.StartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StartDateLabel.AutoSize = True
        Me.StartDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.StartDateLabel.Location = New System.Drawing.Point(49, 23)
        Me.StartDateLabel.Name = "StartDateLabel"
        Me.StartDateLabel.Size = New System.Drawing.Size(35, 20)
        Me.StartDateLabel.TabIndex = 57
        Me.StartDateLabel.Text = "text"
        '
        'BLOCK_EndDate
        '
        Me.BLOCK_EndDate.Controls.Add(Me.BlockIcon_EndDate)
        Me.BLOCK_EndDate.Controls.Add(Me.Label11)
        Me.BLOCK_EndDate.Controls.Add(Me.EndDateLabel)
        Me.BLOCK_EndDate.Location = New System.Drawing.Point(730, 20)
        Me.BLOCK_EndDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_EndDate.Name = "BLOCK_EndDate"
        Me.BLOCK_EndDate.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_EndDate.TabIndex = 10
        Me.BLOCK_EndDate.Visible = False
        '
        'BlockIcon_EndDate
        '
        Me.BlockIcon_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_EndDate.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockEndDate_100x100
        Me.BlockIcon_EndDate.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_EndDate.Name = "BlockIcon_EndDate"
        Me.BlockIcon_EndDate.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_EndDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_EndDate.TabIndex = 1
        Me.BlockIcon_EndDate.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(50, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Data Final"
        '
        'EndDateLabel
        '
        Me.EndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.EndDateLabel.AutoSize = True
        Me.EndDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.EndDateLabel.Location = New System.Drawing.Point(49, 23)
        Me.EndDateLabel.Name = "EndDateLabel"
        Me.EndDateLabel.Size = New System.Drawing.Size(35, 20)
        Me.EndDateLabel.TabIndex = 57
        Me.EndDateLabel.Text = "text"
        '
        'BLOCK_Duration
        '
        Me.BLOCK_Duration.Controls.Add(Me.BlockIcon_Duration)
        Me.BLOCK_Duration.Controls.Add(Me.Label_DuraçãoDaDespesa)
        Me.BLOCK_Duration.Controls.Add(Me.DurationLabel)
        Me.BLOCK_Duration.Location = New System.Drawing.Point(730, 75)
        Me.BLOCK_Duration.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Duration.Name = "BLOCK_Duration"
        Me.BLOCK_Duration.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Duration.TabIndex = 11
        Me.BLOCK_Duration.Visible = False
        '
        'BlockIcon_Duration
        '
        Me.BlockIcon_Duration.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Duration.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockDuration_100x100
        Me.BlockIcon_Duration.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Duration.Name = "BlockIcon_Duration"
        Me.BlockIcon_Duration.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Duration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Duration.TabIndex = 1
        Me.BlockIcon_Duration.TabStop = False
        '
        'Label_DuraçãoDaDespesa
        '
        Me.Label_DuraçãoDaDespesa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_DuraçãoDaDespesa.AutoSize = True
        Me.Label_DuraçãoDaDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_DuraçãoDaDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label_DuraçãoDaDespesa.Location = New System.Drawing.Point(50, 8)
        Me.Label_DuraçãoDaDespesa.Name = "Label_DuraçãoDaDespesa"
        Me.Label_DuraçãoDaDespesa.Size = New System.Drawing.Size(50, 15)
        Me.Label_DuraçãoDaDespesa.TabIndex = 58
        Me.Label_DuraçãoDaDespesa.Text = "Duração"
        '
        'DurationLabel
        '
        Me.DurationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DurationLabel.AutoSize = True
        Me.DurationLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DurationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.DurationLabel.Location = New System.Drawing.Point(49, 23)
        Me.DurationLabel.Name = "DurationLabel"
        Me.DurationLabel.Size = New System.Drawing.Size(35, 20)
        Me.DurationLabel.TabIndex = 57
        Me.DurationLabel.Text = "text"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Location = New System.Drawing.Point(730, 130)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(350, 20)
        Me.Panel6.TabIndex = 79
        Me.Panel6.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.25!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(3, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(154, 17)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "OUTRAS INFORMAÇÕES"
        '
        'BLOCK_Plots
        '
        Me.BLOCK_Plots.Controls.Add(Me.BlockIcon_Plots)
        Me.BLOCK_Plots.Controls.Add(Me.Label_Parcelas)
        Me.BLOCK_Plots.Controls.Add(Me.PlotsCountLabel)
        Me.BLOCK_Plots.Location = New System.Drawing.Point(730, 155)
        Me.BLOCK_Plots.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Plots.Name = "BLOCK_Plots"
        Me.BLOCK_Plots.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Plots.TabIndex = 12
        Me.BLOCK_Plots.Visible = False
        '
        'BlockIcon_Plots
        '
        Me.BlockIcon_Plots.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Plots.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockCountPlots_100x100
        Me.BlockIcon_Plots.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Plots.Name = "BlockIcon_Plots"
        Me.BlockIcon_Plots.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Plots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Plots.TabIndex = 1
        Me.BlockIcon_Plots.TabStop = False
        '
        'Label_Parcelas
        '
        Me.Label_Parcelas.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Parcelas.AutoSize = True
        Me.Label_Parcelas.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_Parcelas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label_Parcelas.Location = New System.Drawing.Point(50, 8)
        Me.Label_Parcelas.Name = "Label_Parcelas"
        Me.Label_Parcelas.Size = New System.Drawing.Size(49, 15)
        Me.Label_Parcelas.TabIndex = 58
        Me.Label_Parcelas.Text = "Parcelas"
        '
        'PlotsCountLabel
        '
        Me.PlotsCountLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlotsCountLabel.AutoSize = True
        Me.PlotsCountLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.PlotsCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PlotsCountLabel.Location = New System.Drawing.Point(49, 23)
        Me.PlotsCountLabel.Name = "PlotsCountLabel"
        Me.PlotsCountLabel.Size = New System.Drawing.Size(35, 20)
        Me.PlotsCountLabel.TabIndex = 57
        Me.PlotsCountLabel.Text = "text"
        '
        'BLOCK_CardLink
        '
        Me.BLOCK_CardLink.Controls.Add(Me.BlockIcon_CardLink)
        Me.BLOCK_CardLink.Controls.Add(Me.Label4)
        Me.BLOCK_CardLink.Controls.Add(Me.LinkCardLabel)
        Me.BLOCK_CardLink.Location = New System.Drawing.Point(730, 210)
        Me.BLOCK_CardLink.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_CardLink.Name = "BLOCK_CardLink"
        Me.BLOCK_CardLink.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_CardLink.TabIndex = 13
        Me.BLOCK_CardLink.Visible = False
        '
        'BlockIcon_CardLink
        '
        Me.BlockIcon_CardLink.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_CardLink.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockCardLink_100x100
        Me.BlockIcon_CardLink.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_CardLink.Name = "BlockIcon_CardLink"
        Me.BlockIcon_CardLink.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_CardLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_CardLink.TabIndex = 1
        Me.BlockIcon_CardLink.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Vinculado com"
        '
        'LinkCardLabel
        '
        Me.LinkCardLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LinkCardLabel.AutoSize = True
        Me.LinkCardLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LinkCardLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.LinkCardLabel.Location = New System.Drawing.Point(49, 23)
        Me.LinkCardLabel.Name = "LinkCardLabel"
        Me.LinkCardLabel.Size = New System.Drawing.Size(35, 20)
        Me.LinkCardLabel.TabIndex = 57
        Me.LinkCardLabel.Text = "text"
        '
        'BLOCK_WhiteSpace
        '
        Me.BLOCK_WhiteSpace.Location = New System.Drawing.Point(730, 265)
        Me.BLOCK_WhiteSpace.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_WhiteSpace.Name = "BLOCK_WhiteSpace"
        Me.BLOCK_WhiteSpace.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_WhiteSpace.TabIndex = 75
        '
        'BLOCK_Discounts
        '
        Me.BLOCK_Discounts.Controls.Add(Me.BlockIcon_Discounts)
        Me.BLOCK_Discounts.Controls.Add(Me.Label5)
        Me.BLOCK_Discounts.Controls.Add(Me.DiscountsLabel)
        Me.BLOCK_Discounts.Location = New System.Drawing.Point(1080, 20)
        Me.BLOCK_Discounts.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Discounts.Name = "BLOCK_Discounts"
        Me.BLOCK_Discounts.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Discounts.TabIndex = 67
        Me.BLOCK_Discounts.Visible = False
        '
        'BlockIcon_Discounts
        '
        Me.BlockIcon_Discounts.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Discounts.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockLowPrice_100x100
        Me.BlockIcon_Discounts.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Discounts.Name = "BlockIcon_Discounts"
        Me.BlockIcon_Discounts.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Discounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Discounts.TabIndex = 1
        Me.BlockIcon_Discounts.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(249, 15)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Descontos [NÃO DISPONÍVEL NESSA VERSÃO]"
        '
        'DiscountsLabel
        '
        Me.DiscountsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DiscountsLabel.AutoSize = True
        Me.DiscountsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DiscountsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.DiscountsLabel.Location = New System.Drawing.Point(49, 23)
        Me.DiscountsLabel.Name = "DiscountsLabel"
        Me.DiscountsLabel.Size = New System.Drawing.Size(35, 20)
        Me.DiscountsLabel.TabIndex = 57
        Me.DiscountsLabel.Text = "text"
        '
        'BLOCK_Interest
        '
        Me.BLOCK_Interest.Controls.Add(Me.BlockIcon_Interests)
        Me.BLOCK_Interest.Controls.Add(Me.Label2)
        Me.BLOCK_Interest.Controls.Add(Me.InterestLabel)
        Me.BLOCK_Interest.Location = New System.Drawing.Point(1080, 75)
        Me.BLOCK_Interest.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Interest.Name = "BLOCK_Interest"
        Me.BLOCK_Interest.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Interest.TabIndex = 66
        Me.BLOCK_Interest.Visible = False
        '
        'BlockIcon_Interests
        '
        Me.BlockIcon_Interests.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_Interests.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockInterest_100x100
        Me.BlockIcon_Interests.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_Interests.Name = "BlockIcon_Interests"
        Me.BlockIcon_Interests.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_Interests.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_Interests.TabIndex = 1
        Me.BlockIcon_Interests.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Juros [NÃO DISPONÍVEL NESSA VERSÃO]"
        '
        'InterestLabel
        '
        Me.InterestLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.InterestLabel.AutoSize = True
        Me.InterestLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.InterestLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.InterestLabel.Location = New System.Drawing.Point(49, 23)
        Me.InterestLabel.Name = "InterestLabel"
        Me.InterestLabel.Size = New System.Drawing.Size(35, 20)
        Me.InterestLabel.TabIndex = 57
        Me.InterestLabel.Text = "text"
        '
        'TabPage_Plots
        '
        Me.TabPage_Plots.Controls.Add(Me.PlotsFlowPanel)
        Me.TabPage_Plots.Location = New System.Drawing.Point(4, 43)
        Me.TabPage_Plots.Name = "TabPage_Plots"
        Me.TabPage_Plots.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Plots.Size = New System.Drawing.Size(1195, 344)
        Me.TabPage_Plots.TabIndex = 1
        Me.TabPage_Plots.Text = "Parcelas"
        Me.TabPage_Plots.UseVisualStyleBackColor = True
        '
        'PlotsFlowPanel
        '
        Me.PlotsFlowPanel.AutoScroll = True
        Me.PlotsFlowPanel.Controls.Add(Me.EmptyPanel)
        Me.PlotsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.PlotsFlowPanel.Location = New System.Drawing.Point(3, 3)
        Me.PlotsFlowPanel.Name = "PlotsFlowPanel"
        Me.PlotsFlowPanel.Padding = New System.Windows.Forms.Padding(30)
        Me.PlotsFlowPanel.Size = New System.Drawing.Size(1189, 338)
        Me.PlotsFlowPanel.TabIndex = 68
        '
        'EmptyPanel
        '
        Me.EmptyPanel.Location = New System.Drawing.Point(30, 30)
        Me.EmptyPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.EmptyPanel.Name = "EmptyPanel"
        Me.EmptyPanel.Size = New System.Drawing.Size(500, 70)
        Me.EmptyPanel.TabIndex = 76
        '
        'TabPage_PaymentHistoric
        '
        Me.TabPage_PaymentHistoric.Controls.Add(Me.Label8)
        Me.TabPage_PaymentHistoric.Location = New System.Drawing.Point(4, 43)
        Me.TabPage_PaymentHistoric.Name = "TabPage_PaymentHistoric"
        Me.TabPage_PaymentHistoric.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PaymentHistoric.Size = New System.Drawing.Size(1195, 344)
        Me.TabPage_PaymentHistoric.TabIndex = 3
        Me.TabPage_PaymentHistoric.Text = "Pagamentos"
        Me.TabPage_PaymentHistoric.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(10, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(359, 15)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Todos os históricos de pagamentos realizados devem aparecer aqui."
        '
        'TabPage_Comments
        '
        Me.TabPage_Comments.Controls.Add(Me.Label10)
        Me.TabPage_Comments.Location = New System.Drawing.Point(4, 43)
        Me.TabPage_Comments.Name = "TabPage_Comments"
        Me.TabPage_Comments.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Comments.Size = New System.Drawing.Size(1195, 344)
        Me.TabPage_Comments.TabIndex = 4
        Me.TabPage_Comments.Text = "Comentários"
        Me.TabPage_Comments.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(355, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Todos os comentários realizados nas parcelas devem aparecer aqui."
        '
        'TabPage_Graphic
        '
        Me.TabPage_Graphic.Controls.Add(Me.Label12)
        Me.TabPage_Graphic.Location = New System.Drawing.Point(4, 43)
        Me.TabPage_Graphic.Name = "TabPage_Graphic"
        Me.TabPage_Graphic.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Graphic.Size = New System.Drawing.Size(1195, 344)
        Me.TabPage_Graphic.TabIndex = 2
        Me.TabPage_Graphic.Text = "Gráfico"
        Me.TabPage_Graphic.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 15)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "Em Planejamento..."
        '
        'CreditCardBackgroundPanel
        '
        Me.CreditCardBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.CreditCardBackgroundPanel.Location = New System.Drawing.Point(1223, 0)
        Me.CreditCardBackgroundPanel.Name = "CreditCardBackgroundPanel"
        Me.CreditCardBackgroundPanel.Size = New System.Drawing.Size(10, 411)
        Me.CreditCardBackgroundPanel.TabIndex = 1
        Me.CreditCardBackgroundPanel.Visible = False
        '
        'ContextMenuStrip_QuickOptions
        '
        Me.ContextMenuStrip_QuickOptions.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip_QuickOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip_QuickOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarNomeToolStripMenuItem, Me.DescriçãoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.CorDeDestaqueToolStripMenuItem, Me.LocalToolStripMenuItem, Me.DataDaCompraToolStripMenuItem, Me.IconeToolStripMenuItem, Me.ToolStripMenuItem2, Me.OpçõesDaDespesaToolStripMenuItem, Me.ModoDeVisualizaçãoToolStripMenuItem, Me.ToolStripMenuItem4, Me.ArquivarToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.ToolStripMenuItem3, Me.FeedBackToolStripMenuItem})
        Me.ContextMenuStrip_QuickOptions.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip_QuickOptions.Size = New System.Drawing.Size(360, 356)
        '
        'AlterarNomeToolStripMenuItem
        '
        Me.AlterarNomeToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeExpenseName_20x20
        Me.AlterarNomeToolStripMenuItem.Name = "AlterarNomeToolStripMenuItem"
        Me.AlterarNomeToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.AlterarNomeToolStripMenuItem.Text = "Nome                                                            "
        '
        'DescriçãoToolStripMenuItem
        '
        Me.DescriçãoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Comments_20x20
        Me.DescriçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DescriçãoToolStripMenuItem.Name = "DescriçãoToolStripMenuItem"
        Me.DescriçãoToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.DescriçãoToolStripMenuItem.Text = "Descrição"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_CategoryExpense_20x20
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'CorDeDestaqueToolStripMenuItem
        '
        Me.CorDeDestaqueToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeColor_20x20
        Me.CorDeDestaqueToolStripMenuItem.Name = "CorDeDestaqueToolStripMenuItem"
        Me.CorDeDestaqueToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.CorDeDestaqueToolStripMenuItem.Text = "Cor"
        '
        'LocalToolStripMenuItem
        '
        Me.LocalToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Place_20x20
        Me.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem"
        Me.LocalToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.LocalToolStripMenuItem.Text = "Local"
        '
        'DataDaCompraToolStripMenuItem
        '
        Me.DataDaCompraToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeDate_20px
        Me.DataDaCompraToolStripMenuItem.Name = "DataDaCompraToolStripMenuItem"
        Me.DataDaCompraToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.DataDaCompraToolStripMenuItem.Text = "Data"
        '
        'IconeToolStripMenuItem
        '
        Me.IconeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarIconeToolStripMenuItem, Me.RemoverIconeToolStripMenuItem1, Me.ToolStripMenuItem6, Me.AlterarEstiloToolStripMenuItem})
        Me.IconeToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeIcon_20px
        Me.IconeToolStripMenuItem.Name = "IconeToolStripMenuItem"
        Me.IconeToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.IconeToolStripMenuItem.Text = "Icone"
        '
        'AlterarIconeToolStripMenuItem
        '
        Me.AlterarIconeToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeSets_20px
        Me.AlterarIconeToolStripMenuItem.Name = "AlterarIconeToolStripMenuItem"
        Me.AlterarIconeToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.AlterarIconeToolStripMenuItem.Text = "Escolher Icone                              "
        '
        'RemoverIconeToolStripMenuItem1
        '
        Me.RemoverIconeToolStripMenuItem1.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Remove_20px
        Me.RemoverIconeToolStripMenuItem1.Name = "RemoverIconeToolStripMenuItem1"
        Me.RemoverIconeToolStripMenuItem1.Size = New System.Drawing.Size(289, 26)
        Me.RemoverIconeToolStripMenuItem1.Text = "Remover"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(286, 6)
        Me.ToolStripMenuItem6.Visible = False
        '
        'AlterarEstiloToolStripMenuItem
        '
        Me.AlterarEstiloToolStripMenuItem.Name = "AlterarEstiloToolStripMenuItem"
        Me.AlterarEstiloToolStripMenuItem.Size = New System.Drawing.Size(289, 26)
        Me.AlterarEstiloToolStripMenuItem.Text = "Alterar Estilo"
        Me.AlterarEstiloToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(356, 6)
        '
        'OpçõesDaDespesaToolStripMenuItem
        '
        Me.OpçõesDaDespesaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VincularComCartãoDeCréditoToolStripMenuItem, Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem, Me.ToolStripMenuItem1, Me.HabilitarPagamentosParciaisToolStripMenuItem, Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem})
        Me.OpçõesDaDespesaToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Options_20px
        Me.OpçõesDaDespesaToolStripMenuItem.Name = "OpçõesDaDespesaToolStripMenuItem"
        Me.OpçõesDaDespesaToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.OpçõesDaDespesaToolStripMenuItem.Text = "Opções"
        '
        'VincularComCartãoDeCréditoToolStripMenuItem
        '
        Me.VincularComCartãoDeCréditoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_LinkCard_20x20
        Me.VincularComCartãoDeCréditoToolStripMenuItem.Name = "VincularComCartãoDeCréditoToolStripMenuItem"
        Me.VincularComCartãoDeCréditoToolStripMenuItem.Size = New System.Drawing.Size(378, 26)
        Me.VincularComCartãoDeCréditoToolStripMenuItem.Text = "Vincular com Cartão de Crédito"
        '
        'PersonalizarMenuDeAcessoRápidoToolStripMenuItem
        '
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_CustomQuickMenu_20x20
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Name = "PersonalizarMenuDeAcessoRápidoToolStripMenuItem"
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Size = New System.Drawing.Size(378, 26)
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Text = "Personalizar Menu de Acesso Rápido"
        Me.PersonalizarMenuDeAcessoRápidoToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(375, 6)
        '
        'HabilitarPagamentosParciaisToolStripMenuItem
        '
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Checked = True
        Me.HabilitarPagamentosParciaisToolStripMenuItem.CheckOnClick = True
        Me.HabilitarPagamentosParciaisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_AllowPartialPayment_20px
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Name = "HabilitarPagamentosParciaisToolStripMenuItem"
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Size = New System.Drawing.Size(378, 26)
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Text = "Habilitar Pagamentos Parciais"
        Me.HabilitarPagamentosParciaisToolStripMenuItem.Visible = False
        '
        'HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem
        '
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Checked = True
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.CheckOnClick = True
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_AllowColorInHeader_20px
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Name = "HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem"
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Size = New System.Drawing.Size(378, 26)
        Me.HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem.Text = "Habilitar Cor de Destaque no Cabeçalho/Rodapé"
        '
        'ModoDeVisualizaçãoToolStripMenuItem
        '
        Me.ModoDeVisualizaçãoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlocosToolStripMenuItem, Me.ListaToolStripMenuItem})
        Me.ModoDeVisualizaçãoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ViewMode_20px
        Me.ModoDeVisualizaçãoToolStripMenuItem.Name = "ModoDeVisualizaçãoToolStripMenuItem"
        Me.ModoDeVisualizaçãoToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.ModoDeVisualizaçãoToolStripMenuItem.Text = "Visualização"
        '
        'BlocosToolStripMenuItem
        '
        Me.BlocosToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_BlocksBiewMode_20px
        Me.BlocosToolStripMenuItem.Name = "BlocosToolStripMenuItem"
        Me.BlocosToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.BlocosToolStripMenuItem.Text = "Blocos"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ListViewMode_20px
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.ListaToolStripMenuItem.Text = "Lista"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(356, 6)
        '
        'ArquivarToolStripMenuItem
        '
        Me.ArquivarToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Filed_20x20
        Me.ArquivarToolStripMenuItem.Name = "ArquivarToolStripMenuItem"
        Me.ArquivarToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.ArquivarToolStripMenuItem.Text = "Arquivar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_DeleteExpense_20x20
        Me.ExcluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(356, 6)
        '
        'FeedBackToolStripMenuItem
        '
        Me.FeedBackToolStripMenuItem.Name = "FeedBackToolStripMenuItem"
        Me.FeedBackToolStripMenuItem.Size = New System.Drawing.Size(359, 26)
        Me.FeedBackToolStripMenuItem.Text = "FeedBack"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem1, Me.FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem, Me.AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem, Me.EditarLocalDeCompraDaDespesaToolStripMenuItem, Me.FixarNoInicioRecursoEmBreveToolStripMenuItem, Me.ToolStripMenuItem5, Me.FUNÇÕESPROCARTÃOToolStripMenuItem, Me.VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem, Me.DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(560, 202)
        '
        'BuscarToolStripMenuItem1
        '
        Me.BuscarToolStripMenuItem1.Name = "BuscarToolStripMenuItem1"
        Me.BuscarToolStripMenuItem1.Size = New System.Drawing.Size(559, 24)
        Me.BuscarToolStripMenuItem1.Text = "Buscar"
        '
        'FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem
        '
        Me.FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem.Name = "FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem"
        Me.FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem.Text = "Finalizar Despesa (Marcar Todas as Parcelas Como Pagas)"
        '
        'AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem
        '
        Me.AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem.Name = "AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem"
        Me.AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem.Text = "Adicionar TAG (Tags para descrever melhor a despesa [recurso mais pra frente])"
        '
        'EditarLocalDeCompraDaDespesaToolStripMenuItem
        '
        Me.EditarLocalDeCompraDaDespesaToolStripMenuItem.Name = "EditarLocalDeCompraDaDespesaToolStripMenuItem"
        Me.EditarLocalDeCompraDaDespesaToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.EditarLocalDeCompraDaDespesaToolStripMenuItem.Text = "Editar Local de Compra da Despesa"
        '
        'FixarNoInicioRecursoEmBreveToolStripMenuItem
        '
        Me.FixarNoInicioRecursoEmBreveToolStripMenuItem.Name = "FixarNoInicioRecursoEmBreveToolStripMenuItem"
        Me.FixarNoInicioRecursoEmBreveToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.FixarNoInicioRecursoEmBreveToolStripMenuItem.Text = "Fixar No Inicio (Recurso Em Breve)"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(556, 6)
        '
        'FUNÇÕESPROCARTÃOToolStripMenuItem
        '
        Me.FUNÇÕESPROCARTÃOToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FUNÇÕESPROCARTÃOToolStripMenuItem.Name = "FUNÇÕESPROCARTÃOToolStripMenuItem"
        Me.FUNÇÕESPROCARTÃOToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.FUNÇÕESPROCARTÃOToolStripMenuItem.Text = "FUNÇÕES PRO CARTÃO"
        '
        'VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem
        '
        Me.VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem.Name = "VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem"
        Me.VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem.Text = "Visualizar Despesas Vinculadas nesse Cartão"
        '
        'DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem
        '
        Me.DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem.Name = "DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem"
        Me.DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem.Size = New System.Drawing.Size(559, 24)
        Me.DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem.Text = "Desvincular Todas as Despesas desse cartão"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Novo Recurso do XPEG Count"
        '
        'FileWatcherSystem
        '
        Me.FileWatcherSystem.EnableRaisingEvents = True
        Me.FileWatcherSystem.IncludeSubdirectories = True
        Me.FileWatcherSystem.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileWatcherSystem.SynchronizingObject = Me
        '
        'ViewExpenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1233, 561)
        Me.Controls.Add(Me.ExpenseControlsForm)
        Me.Controls.Add(Me.StatusPanelBackGround)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 550)
        Me.Name = "ViewExpenseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "expense form"
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.QuickOptionsButtons.ResumeLayout(False)
        Me.ExpenseTitleIconPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ExpenseColorPanel.ResumeLayout(False)
        CType(Me.ExpenseIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusPanelBackGround.ResumeLayout(False)
        Me.StatusBarPanel.ResumeLayout(False)
        Me.FlowLabelsStatusPlots.ResumeLayout(False)
        Me.FlowLabelsStatusPlots.PerformLayout()
        Me.QuickOptionsPanel.ResumeLayout(False)
        Me.PlotsSelectedOptionsPanel.ResumeLayout(False)
        Me.ExpenseControlsForm.ResumeLayout(False)
        Me.TabControlPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_Informations.ResumeLayout(False)
        Me.FlowLayoutPanel_BlocksInfos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BLOCK_Category.ResumeLayout(False)
        Me.BLOCK_Category.PerformLayout()
        CType(Me.BlockIcon_Category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Status.ResumeLayout(False)
        Me.BLOCK_Status.PerformLayout()
        CType(Me.BlockIcon_Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_BuyDate.ResumeLayout(False)
        Me.BLOCK_BuyDate.PerformLayout()
        CType(Me.BlockIcon_BuyDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Location.ResumeLayout(False)
        Me.BLOCK_Location.PerformLayout()
        CType(Me.BlockIcon_Location, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.BLOCK_Total.ResumeLayout(False)
        Me.BLOCK_Total.PerformLayout()
        CType(Me.BlockIcon_Total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_TotalNoIncludes.ResumeLayout(False)
        Me.BLOCK_TotalNoIncludes.PerformLayout()
        CType(Me.BlockIcon_TotalNoIncludes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Paid.ResumeLayout(False)
        Me.BLOCK_Paid.PerformLayout()
        CType(Me.BlockIcon_Paid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_RestToPay.ResumeLayout(False)
        Me.BLOCK_RestToPay.PerformLayout()
        CType(Me.BlockIcon_RestToPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.BLOCK_StartDate.ResumeLayout(False)
        Me.BLOCK_StartDate.PerformLayout()
        CType(Me.BlockIcon_StartDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_EndDate.ResumeLayout(False)
        Me.BLOCK_EndDate.PerformLayout()
        CType(Me.BlockIcon_EndDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Duration.ResumeLayout(False)
        Me.BLOCK_Duration.PerformLayout()
        CType(Me.BlockIcon_Duration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.BLOCK_Plots.ResumeLayout(False)
        Me.BLOCK_Plots.PerformLayout()
        CType(Me.BlockIcon_Plots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_CardLink.ResumeLayout(False)
        Me.BLOCK_CardLink.PerformLayout()
        CType(Me.BlockIcon_CardLink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Discounts.ResumeLayout(False)
        Me.BLOCK_Discounts.PerformLayout()
        CType(Me.BlockIcon_Discounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Interest.ResumeLayout(False)
        Me.BLOCK_Interest.PerformLayout()
        CType(Me.BlockIcon_Interests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Plots.ResumeLayout(False)
        Me.PlotsFlowPanel.ResumeLayout(False)
        Me.TabPage_PaymentHistoric.ResumeLayout(False)
        Me.TabPage_PaymentHistoric.PerformLayout()
        Me.TabPage_Comments.ResumeLayout(False)
        Me.TabPage_Comments.PerformLayout()
        Me.TabPage_Graphic.ResumeLayout(False)
        Me.TabPage_Graphic.PerformLayout()
        Me.ContextMenuStrip_QuickOptions.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ExpenseTitleIconPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ExpenseNameLabel As Label
    Friend WithEvents ExpenseDescriptionLabel As Label
    Friend WithEvents ExpenseColorPanel As Panel
    Friend WithEvents ExpenseIconPictureBox As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents QuickOptionsButtons As Panel
    Friend WithEvents StatusPanelBackGround As Panel
    Friend WithEvents StatusBarPanel As Panel
    Friend WithEvents StatusSeparatorLinePanel As Panel
    Friend WithEvents ExpenseControlsForm As Panel
    Friend WithEvents MenuQuickOptions_Button As QuickOptionExpenseButton
    Friend WithEvents ChangeName_Button As QuickOptionExpenseButton
    Friend WithEvents ChangeDescription_Button As QuickOptionExpenseButton
    Friend WithEvents ChangeIcon_Button As QuickOptionExpenseButton
    Friend WithEvents ContextMenuStrip_QuickOptions As ContextMenuStrip
    Friend WithEvents AlterarNomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescriçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorDeDestaqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ModoDeVisualizaçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlocosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArquivarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeView_Button As QuickOptionExpenseButton
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BuscarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FinalizarDespesaMarcarTodasAsParcelasComoPagasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarTAGTagsParaDescreverMelhorADespesarecursoMaisPraFrenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarLocalDeCompraDaDespesaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FixarNoInicioRecursoEmBreveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Search_Button As QuickOptionExpenseButton
    Friend WithEvents QuickOptionExpenseButton2 As QuickOptionExpenseButton
    Friend WithEvents PlaceBuy_Button As QuickOptionExpenseButton
    Friend WithEvents AddTag_Button As QuickOptionExpenseButton
    Friend WithEvents LinkCreditCard_Button As QuickOptionExpenseButton
    Friend WithEvents TabControlPanel As Panel
    Friend WithEvents CreditCardBackgroundPanel As Panel
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents VisualizarDespesasVinculadasNesseCartãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Informations As TabPage
    Friend WithEvents TabPage_Plots As TabPage
    Friend WithEvents TabPage_Graphic As TabPage
    Friend WithEvents FlowLayoutPanel_BlocksInfos As FlowLayoutPanel
    Friend WithEvents BLOCK_Category As Panel
    Friend WithEvents BlockIcon_Category As PictureBox
    Friend WithEvents Label_CategoriaDaDespesa As Label
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents BLOCK_Duration As Panel
    Friend WithEvents BlockIcon_Duration As PictureBox
    Friend WithEvents Label_DuraçãoDaDespesa As Label
    Friend WithEvents DurationLabel As Label
    Friend WithEvents BLOCK_TotalNoIncludes As Panel
    Friend WithEvents BlockIcon_TotalNoIncludes As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalNoIncludeLabel As Label
    Friend WithEvents BLOCK_Paid As Panel
    Friend WithEvents BlockIcon_Paid As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PaidLabel As Label
    Friend WithEvents BLOCK_Interest As Panel
    Friend WithEvents BlockIcon_Interests As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InterestLabel As Label
    Friend WithEvents BLOCK_Discounts As Panel
    Friend WithEvents BlockIcon_Discounts As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DiscountsLabel As Label
    Friend WithEvents BLOCK_Location As Panel
    Friend WithEvents BlockIcon_Location As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LocationLabel As Label
    Friend WithEvents BLOCK_StartDate As Panel
    Friend WithEvents BlockIcon_StartDate As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents StartDateLabel As Label
    Friend WithEvents BLOCK_EndDate As Panel
    Friend WithEvents BlockIcon_EndDate As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EndDateLabel As Label
    Friend WithEvents BLOCK_Total As Panel
    Friend WithEvents BlockIcon_Total As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents BLOCK_RestToPay As Panel
    Friend WithEvents BlockIcon_RestToPay As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RestToPayLabel As Label
    Friend WithEvents BLOCK_Plots As Panel
    Friend WithEvents BlockIcon_Plots As PictureBox
    Friend WithEvents Label_Parcelas As Label
    Friend WithEvents PlotsCountLabel As Label
    Friend WithEvents BLOCK_Status As Panel
    Friend WithEvents BlockIcon_Status As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents BLOCK_WhiteSpace As Panel
    Friend WithEvents BLOCK_CardLink As Panel
    Friend WithEvents BlockIcon_CardLink As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkCardLabel As Label
    Friend WithEvents PlotsSelectedOptionsPanel As Panel
    Friend WithEvents PlotsFlowPanel As FlowLayoutPanel
    Friend WithEvents FUNÇÕESPROCARTÃOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesvincularTodasAsDespesasDesseCartãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBarCircle_ExpenseProgress As DashboardProgressBarCircle
    Friend WithEvents ExpenseEndLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FileWatcherSystem As IO.FileSystemWatcher
    Friend WithEvents NumbeOfPlotsSelectedsLabel As Label
    Friend WithEvents FlowLabelsStatusPlots As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TotalSelectedLabel As Label
    Friend WithEvents LocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarIconeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoverIconeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlterarEstiloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents QuickOptionsPanel As Panel
    Friend WithEvents AddNewPlot_QuickButton As QuickOptionExpenseButton
    Friend WithEvents SelectAll_QuickButton As QuickOptionExpenseButton
    Friend WithEvents SelectNone_QuickButton As QuickOptionExpenseButton
    Friend WithEvents PayPlots_QuickButton As QuickOptionExpenseButton
    Friend WithEvents ChangeMaturidyDay_QuickButton As QuickOptionExpenseButton
    Friend WithEvents DeletePlots_QuickButton As QuickOptionExpenseButton
    Friend WithEvents TabPage_PaymentHistoric As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage_Comments As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SeparatorTitleForm As System.Windows.Forms.Panel
    Friend WithEvents OpçõesDaDespesaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizarMenuDeAcessoRápidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VincularComCartãoDeCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabilitarPagamentosParciaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataDaCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HabilitarCorDeDestaqueNoCabeçalhoRodapéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BLOCK_BuyDate As System.Windows.Forms.Panel
    Friend WithEvents BlockIcon_BuyDate As System.Windows.Forms.PictureBox
    Friend WithEvents Label_DataDaCompra As System.Windows.Forms.Label
    Friend WithEvents BuyDateLabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PorcentProgressLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmptyPanel As System.Windows.Forms.Panel
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FeedBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
