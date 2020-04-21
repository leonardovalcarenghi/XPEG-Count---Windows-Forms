<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewPlotSelectedDialog
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

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusPanelBackGround = New System.Windows.Forms.Panel()
        Me.StatusSeparatorLinePanel = New System.Windows.Forms.Panel()
        Me.StatusBarPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.QuickOptionsButtons = New System.Windows.Forms.Panel()
        Me.MenuQuickOptions_Button = New xpeg_count_project.QuickOptionExpenseButton()
        Me.ExpenseTitleIconPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PlotDateLabel = New System.Windows.Forms.Label()
        Me.StatusPlotLabel = New System.Windows.Forms.Label()
        Me.ExpenseColorPanel = New System.Windows.Forms.Panel()
        Me.PlotNumberLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControlPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_PlotInformation = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel_BlocksInfos = New System.Windows.Forms.FlowLayoutPanel()
        Me.BLOCK_ExpenseName = New System.Windows.Forms.Panel()
        Me.BlockIcon_ExpenseName = New System.Windows.Forms.PictureBox()
        Me.Label_Despesa = New System.Windows.Forms.Label()
        Me.ExpenseNameLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Total = New System.Windows.Forms.Panel()
        Me.BlockIcon_Total = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Paid = New System.Windows.Forms.Panel()
        Me.BlockIcon_Paid = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaidLabel = New System.Windows.Forms.Label()
        Me.BLOCK_RestToPay = New System.Windows.Forms.Panel()
        Me.BlockIcon_RestToPay = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RestToPayLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Discounts = New System.Windows.Forms.Panel()
        Me.BlockIcon_Discounts = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiscountsLabel = New System.Windows.Forms.Label()
        Me.BLOCK_Interest = New System.Windows.Forms.Panel()
        Me.BlockIcon_Interests = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InterestLabel = New System.Windows.Forms.Label()
        Me.BLOCK_MaturityDate = New System.Windows.Forms.Panel()
        Me.BlockIcon_MaturityDate = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaturityDateLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage_InvoicePostings = New System.Windows.Forms.TabPage()
        Me.InvoicePostingsListPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage_Historic = New System.Windows.Forms.TabPage()
        Me.HistoricPaymentListPanel = New System.Windows.Forms.Panel()
        Me.Label_NoHistoricPayment = New System.Windows.Forms.Label()
        Me.TabPage_Comments = New System.Windows.Forms.TabPage()
        Me.CommentsListPanel = New System.Windows.Forms.Panel()
        Me.Label_NoComments = New System.Windows.Forms.Label()
        Me.ContextMenuStrip_QuickOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescriçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarValorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.IncluirValorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FeedBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileWatcherSystem = New System.IO.FileSystemWatcher()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaisOpçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JurosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusPanelBackGround.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.QuickOptionsButtons.SuspendLayout()
        Me.ExpenseTitleIconPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.ExpenseColorPanel.SuspendLayout()
        Me.TabControlPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_PlotInformation.SuspendLayout()
        Me.FlowLayoutPanel_BlocksInfos.SuspendLayout()
        Me.BLOCK_ExpenseName.SuspendLayout()
        CType(Me.BlockIcon_ExpenseName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Total.SuspendLayout()
        CType(Me.BlockIcon_Total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Paid.SuspendLayout()
        CType(Me.BlockIcon_Paid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_RestToPay.SuspendLayout()
        CType(Me.BlockIcon_RestToPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Discounts.SuspendLayout()
        CType(Me.BlockIcon_Discounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_Interest.SuspendLayout()
        CType(Me.BlockIcon_Interests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BLOCK_MaturityDate.SuspendLayout()
        CType(Me.BlockIcon_MaturityDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_InvoicePostings.SuspendLayout()
        Me.InvoicePostingsListPanel.SuspendLayout()
        Me.TabPage_Historic.SuspendLayout()
        Me.HistoricPaymentListPanel.SuspendLayout()
        Me.TabPage_Comments.SuspendLayout()
        Me.CommentsListPanel.SuspendLayout()
        Me.ContextMenuStrip_QuickOptions.SuspendLayout()
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusPanelBackGround
        '
        Me.StatusPanelBackGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StatusPanelBackGround.Controls.Add(Me.StatusSeparatorLinePanel)
        Me.StatusPanelBackGround.Controls.Add(Me.StatusBarPanel)
        Me.StatusPanelBackGround.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusPanelBackGround.Location = New System.Drawing.Point(0, 413)
        Me.StatusPanelBackGround.Name = "StatusPanelBackGround"
        Me.StatusPanelBackGround.Size = New System.Drawing.Size(794, 30)
        Me.StatusPanelBackGround.TabIndex = 2
        Me.StatusPanelBackGround.Visible = False
        '
        'StatusSeparatorLinePanel
        '
        Me.StatusSeparatorLinePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.StatusSeparatorLinePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusSeparatorLinePanel.Location = New System.Drawing.Point(0, 0)
        Me.StatusSeparatorLinePanel.Name = "StatusSeparatorLinePanel"
        Me.StatusSeparatorLinePanel.Size = New System.Drawing.Size(794, 1)
        Me.StatusSeparatorLinePanel.TabIndex = 2
        '
        'StatusBarPanel
        '
        Me.StatusBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.StatusBarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusBarPanel.ForeColor = System.Drawing.Color.White
        Me.StatusBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPanel.Name = "StatusBarPanel"
        Me.StatusBarPanel.Size = New System.Drawing.Size(794, 30)
        Me.StatusBarPanel.TabIndex = 3
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.QuickOptionsButtons)
        Me.HeaderPanel.Controls.Add(Me.ExpenseTitleIconPanel)
        Me.HeaderPanel.Controls.Add(Me.Panel2)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(794, 70)
        Me.HeaderPanel.TabIndex = 3
        '
        'QuickOptionsButtons
        '
        Me.QuickOptionsButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuickOptionsButtons.BackColor = System.Drawing.Color.Transparent
        Me.QuickOptionsButtons.Controls.Add(Me.MenuQuickOptions_Button)
        Me.QuickOptionsButtons.Location = New System.Drawing.Point(501, -2)
        Me.QuickOptionsButtons.Name = "QuickOptionsButtons"
        Me.QuickOptionsButtons.Size = New System.Drawing.Size(281, 26)
        Me.QuickOptionsButtons.TabIndex = 0
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
        Me.MenuQuickOptions_Button.Location = New System.Drawing.Point(250, 0)
        Me.MenuQuickOptions_Button.Name = "MenuQuickOptions_Button"
        Me.MenuQuickOptions_Button.Size = New System.Drawing.Size(31, 26)
        Me.MenuQuickOptions_Button.TabIndex = 0
        Me.MenuQuickOptions_Button.Tag = ""
        '
        'ExpenseTitleIconPanel
        '
        Me.ExpenseTitleIconPanel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExpenseTitleIconPanel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseTitleIconPanel.Controls.Add(Me.Panel5)
        Me.ExpenseTitleIconPanel.Controls.Add(Me.ExpenseColorPanel)
        Me.ExpenseTitleIconPanel.ForeColor = System.Drawing.Color.White
        Me.ExpenseTitleIconPanel.Location = New System.Drawing.Point(20, 10)
        Me.ExpenseTitleIconPanel.Name = "ExpenseTitleIconPanel"
        Me.ExpenseTitleIconPanel.Size = New System.Drawing.Size(380, 50)
        Me.ExpenseTitleIconPanel.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.PlotDateLabel)
        Me.Panel5.Controls.Add(Me.StatusPlotLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(50, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(330, 50)
        Me.Panel5.TabIndex = 3
        '
        'PlotDateLabel
        '
        Me.PlotDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlotDateLabel.AutoSize = True
        Me.PlotDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.PlotDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PlotDateLabel.Location = New System.Drawing.Point(6, 1)
        Me.PlotDateLabel.Name = "PlotDateLabel"
        Me.PlotDateLabel.Size = New System.Drawing.Size(57, 30)
        Me.PlotDateLabel.TabIndex = 0
        Me.PlotDateLabel.Text = "date"
        '
        'StatusPlotLabel
        '
        Me.StatusPlotLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StatusPlotLabel.AutoSize = True
        Me.StatusPlotLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.StatusPlotLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.StatusPlotLabel.Location = New System.Drawing.Point(8, 31)
        Me.StatusPlotLabel.Name = "StatusPlotLabel"
        Me.StatusPlotLabel.Size = New System.Drawing.Size(39, 15)
        Me.StatusPlotLabel.TabIndex = 1
        Me.StatusPlotLabel.Text = "Status"
        '
        'ExpenseColorPanel
        '
        Me.ExpenseColorPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.ExpenseColorPanel.Controls.Add(Me.PlotNumberLabel)
        Me.ExpenseColorPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpenseColorPanel.Location = New System.Drawing.Point(0, 0)
        Me.ExpenseColorPanel.Name = "ExpenseColorPanel"
        Me.ExpenseColorPanel.Size = New System.Drawing.Size(50, 50)
        Me.ExpenseColorPanel.TabIndex = 2
        '
        'PlotNumberLabel
        '
        Me.PlotNumberLabel.AutoSize = True
        Me.PlotNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.PlotNumberLabel.Location = New System.Drawing.Point(7, 10)
        Me.PlotNumberLabel.Name = "PlotNumberLabel"
        Me.PlotNumberLabel.Size = New System.Drawing.Size(37, 30)
        Me.PlotNumberLabel.TabIndex = 1
        Me.PlotNumberLabel.Text = "00"
        Me.PlotNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 1)
        Me.Panel2.TabIndex = 0
        '
        'TabControlPanel
        '
        Me.TabControlPanel.Controls.Add(Me.TabControl1)
        Me.TabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel.Location = New System.Drawing.Point(0, 70)
        Me.TabControlPanel.Name = "TabControlPanel"
        Me.TabControlPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.TabControlPanel.Size = New System.Drawing.Size(794, 343)
        Me.TabControlPanel.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_PlotInformation)
        Me.TabControl1.Controls.Add(Me.TabPage_InvoicePostings)
        Me.TabControl1.Controls.Add(Me.TabPage_Historic)
        Me.TabControl1.Controls.Add(Me.TabPage_Comments)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 323)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage_PlotInformation
        '
        Me.TabPage_PlotInformation.Controls.Add(Me.FlowLayoutPanel_BlocksInfos)
        Me.TabPage_PlotInformation.Location = New System.Drawing.Point(4, 32)
        Me.TabPage_PlotInformation.Name = "TabPage_PlotInformation"
        Me.TabPage_PlotInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_PlotInformation.Size = New System.Drawing.Size(766, 287)
        Me.TabPage_PlotInformation.TabIndex = 0
        Me.TabPage_PlotInformation.Text = "Parcela"
        Me.TabPage_PlotInformation.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel_BlocksInfos
        '
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_ExpenseName)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Total)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Paid)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_RestToPay)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Discounts)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_Interest)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.BLOCK_MaturityDate)
        Me.FlowLayoutPanel_BlocksInfos.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel_BlocksInfos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel_BlocksInfos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel_BlocksInfos.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel_BlocksInfos.Name = "FlowLayoutPanel_BlocksInfos"
        Me.FlowLayoutPanel_BlocksInfos.Padding = New System.Windows.Forms.Padding(30)
        Me.FlowLayoutPanel_BlocksInfos.Size = New System.Drawing.Size(760, 281)
        Me.FlowLayoutPanel_BlocksInfos.TabIndex = 67
        '
        'BLOCK_ExpenseName
        '
        Me.BLOCK_ExpenseName.Controls.Add(Me.BlockIcon_ExpenseName)
        Me.BLOCK_ExpenseName.Controls.Add(Me.Label_Despesa)
        Me.BLOCK_ExpenseName.Controls.Add(Me.ExpenseNameLabel)
        Me.BLOCK_ExpenseName.Location = New System.Drawing.Point(30, 30)
        Me.BLOCK_ExpenseName.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_ExpenseName.Name = "BLOCK_ExpenseName"
        Me.BLOCK_ExpenseName.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_ExpenseName.TabIndex = 74
        Me.BLOCK_ExpenseName.Visible = False
        '
        'BlockIcon_ExpenseName
        '
        Me.BlockIcon_ExpenseName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_ExpenseName.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockExpenseName_100x100
        Me.BlockIcon_ExpenseName.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_ExpenseName.Name = "BlockIcon_ExpenseName"
        Me.BlockIcon_ExpenseName.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_ExpenseName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_ExpenseName.TabIndex = 1
        Me.BlockIcon_ExpenseName.TabStop = False
        '
        'Label_Despesa
        '
        Me.Label_Despesa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Despesa.AutoSize = True
        Me.Label_Despesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_Despesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label_Despesa.Location = New System.Drawing.Point(50, 8)
        Me.Label_Despesa.Name = "Label_Despesa"
        Me.Label_Despesa.Size = New System.Drawing.Size(50, 15)
        Me.Label_Despesa.TabIndex = 58
        Me.Label_Despesa.Text = "Despesa"
        '
        'ExpenseNameLabel
        '
        Me.ExpenseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExpenseNameLabel.AutoSize = True
        Me.ExpenseNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ExpenseNameLabel.Location = New System.Drawing.Point(49, 23)
        Me.ExpenseNameLabel.Name = "ExpenseNameLabel"
        Me.ExpenseNameLabel.Size = New System.Drawing.Size(132, 20)
        Me.ExpenseNameLabel.TabIndex = 57
        Me.ExpenseNameLabel.Text = "Nome da Despesa"
        '
        'BLOCK_Total
        '
        Me.BLOCK_Total.Controls.Add(Me.BlockIcon_Total)
        Me.BLOCK_Total.Controls.Add(Me.Label13)
        Me.BLOCK_Total.Controls.Add(Me.TotalLabel)
        Me.BLOCK_Total.Location = New System.Drawing.Point(30, 85)
        Me.BLOCK_Total.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Total.Name = "BLOCK_Total"
        Me.BLOCK_Total.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Total.TabIndex = 71
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
        Me.TotalLabel.Size = New System.Drawing.Size(46, 20)
        Me.TotalLabel.TabIndex = 57
        Me.TotalLabel.Text = "value"
        '
        'BLOCK_Paid
        '
        Me.BLOCK_Paid.Controls.Add(Me.BlockIcon_Paid)
        Me.BLOCK_Paid.Controls.Add(Me.Label3)
        Me.BLOCK_Paid.Controls.Add(Me.PaidLabel)
        Me.BLOCK_Paid.Location = New System.Drawing.Point(30, 140)
        Me.BLOCK_Paid.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_Paid.Name = "BLOCK_Paid"
        Me.BLOCK_Paid.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_Paid.TabIndex = 65
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
        Me.PaidLabel.Size = New System.Drawing.Size(46, 20)
        Me.PaidLabel.TabIndex = 57
        Me.PaidLabel.Text = "value"
        '
        'BLOCK_RestToPay
        '
        Me.BLOCK_RestToPay.Controls.Add(Me.BlockIcon_RestToPay)
        Me.BLOCK_RestToPay.Controls.Add(Me.Label15)
        Me.BLOCK_RestToPay.Controls.Add(Me.RestToPayLabel)
        Me.BLOCK_RestToPay.Location = New System.Drawing.Point(30, 195)
        Me.BLOCK_RestToPay.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_RestToPay.Name = "BLOCK_RestToPay"
        Me.BLOCK_RestToPay.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_RestToPay.TabIndex = 72
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
        Me.RestToPayLabel.Size = New System.Drawing.Size(46, 20)
        Me.RestToPayLabel.TabIndex = 57
        Me.RestToPayLabel.Text = "value"
        '
        'BLOCK_Discounts
        '
        Me.BLOCK_Discounts.Controls.Add(Me.BlockIcon_Discounts)
        Me.BLOCK_Discounts.Controls.Add(Me.Label5)
        Me.BLOCK_Discounts.Controls.Add(Me.DiscountsLabel)
        Me.BLOCK_Discounts.Location = New System.Drawing.Point(380, 30)
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
        Me.DiscountsLabel.Size = New System.Drawing.Size(58, 20)
        Me.DiscountsLabel.TabIndex = 57
        Me.DiscountsLabel.Text = "R$ 3,22"
        '
        'BLOCK_Interest
        '
        Me.BLOCK_Interest.Controls.Add(Me.BlockIcon_Interests)
        Me.BLOCK_Interest.Controls.Add(Me.Label2)
        Me.BLOCK_Interest.Controls.Add(Me.InterestLabel)
        Me.BLOCK_Interest.Location = New System.Drawing.Point(380, 85)
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
        Me.InterestLabel.Size = New System.Drawing.Size(63, 20)
        Me.InterestLabel.TabIndex = 57
        Me.InterestLabel.Text = "2% a.m."
        '
        'BLOCK_MaturityDate
        '
        Me.BLOCK_MaturityDate.Controls.Add(Me.BlockIcon_MaturityDate)
        Me.BLOCK_MaturityDate.Controls.Add(Me.Label9)
        Me.BLOCK_MaturityDate.Controls.Add(Me.MaturityDateLabel)
        Me.BLOCK_MaturityDate.Location = New System.Drawing.Point(380, 140)
        Me.BLOCK_MaturityDate.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.BLOCK_MaturityDate.Name = "BLOCK_MaturityDate"
        Me.BLOCK_MaturityDate.Size = New System.Drawing.Size(350, 50)
        Me.BLOCK_MaturityDate.TabIndex = 69
        Me.BLOCK_MaturityDate.Visible = False
        '
        'BlockIcon_MaturityDate
        '
        Me.BlockIcon_MaturityDate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockIcon_MaturityDate.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockStartDate_100x100
        Me.BlockIcon_MaturityDate.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_MaturityDate.Name = "BlockIcon_MaturityDate"
        Me.BlockIcon_MaturityDate.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_MaturityDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_MaturityDate.TabIndex = 1
        Me.BlockIcon_MaturityDate.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(50, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Data de Vencimento"
        '
        'MaturityDateLabel
        '
        Me.MaturityDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MaturityDateLabel.AutoSize = True
        Me.MaturityDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.MaturityDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.MaturityDateLabel.Location = New System.Drawing.Point(49, 23)
        Me.MaturityDateLabel.Name = "MaturityDateLabel"
        Me.MaturityDateLabel.Size = New System.Drawing.Size(149, 20)
        Me.MaturityDateLabel.TabIndex = 57
        Me.MaturityDateLabel.Text = "20 de Março de 2019"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(380, 195)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 50)
        Me.Panel1.TabIndex = 73
        Me.Panel1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = Global.xpeg_count_project.My.Resources.BlockInformationIconsResource.Icon_BlockLowPrice_100x100
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Primeiro Pagamento [Caso haja mais de um histórico]"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(49, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "5 de fevereiro de 2019"
        '
        'TabPage_InvoicePostings
        '
        Me.TabPage_InvoicePostings.Controls.Add(Me.InvoicePostingsListPanel)
        Me.TabPage_InvoicePostings.Location = New System.Drawing.Point(4, 32)
        Me.TabPage_InvoicePostings.Name = "TabPage_InvoicePostings"
        Me.TabPage_InvoicePostings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_InvoicePostings.Size = New System.Drawing.Size(766, 287)
        Me.TabPage_InvoicePostings.TabIndex = 4
        Me.TabPage_InvoicePostings.Text = "Lançamentos"
        Me.TabPage_InvoicePostings.UseVisualStyleBackColor = True
        '
        'InvoicePostingsListPanel
        '
        Me.InvoicePostingsListPanel.AutoScroll = True
        Me.InvoicePostingsListPanel.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.InvoicePostingsListPanel.Controls.Add(Me.Label6)
        Me.InvoicePostingsListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InvoicePostingsListPanel.Location = New System.Drawing.Point(3, 3)
        Me.InvoicePostingsListPanel.Name = "InvoicePostingsListPanel"
        Me.InvoicePostingsListPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.InvoicePostingsListPanel.Size = New System.Drawing.Size(760, 281)
        Me.InvoicePostingsListPanel.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(740, 15)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Nenhuma despesa vinculada com esta fatura..."
        '
        'TabPage_Historic
        '
        Me.TabPage_Historic.Controls.Add(Me.HistoricPaymentListPanel)
        Me.TabPage_Historic.Location = New System.Drawing.Point(4, 32)
        Me.TabPage_Historic.Name = "TabPage_Historic"
        Me.TabPage_Historic.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Historic.Size = New System.Drawing.Size(766, 287)
        Me.TabPage_Historic.TabIndex = 2
        Me.TabPage_Historic.Text = "Pagamentos"
        Me.TabPage_Historic.UseVisualStyleBackColor = True
        '
        'HistoricPaymentListPanel
        '
        Me.HistoricPaymentListPanel.AutoScroll = True
        Me.HistoricPaymentListPanel.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.HistoricPaymentListPanel.Controls.Add(Me.Label_NoHistoricPayment)
        Me.HistoricPaymentListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoricPaymentListPanel.Location = New System.Drawing.Point(3, 3)
        Me.HistoricPaymentListPanel.Name = "HistoricPaymentListPanel"
        Me.HistoricPaymentListPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.HistoricPaymentListPanel.Size = New System.Drawing.Size(760, 281)
        Me.HistoricPaymentListPanel.TabIndex = 69
        '
        'Label_NoHistoricPayment
        '
        Me.Label_NoHistoricPayment.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_NoHistoricPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NoHistoricPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label_NoHistoricPayment.Location = New System.Drawing.Point(10, 10)
        Me.Label_NoHistoricPayment.Name = "Label_NoHistoricPayment"
        Me.Label_NoHistoricPayment.Size = New System.Drawing.Size(740, 15)
        Me.Label_NoHistoricPayment.TabIndex = 58
        Me.Label_NoHistoricPayment.Text = "Não existem pagamentos realizados nesta parcela..."
        '
        'TabPage_Comments
        '
        Me.TabPage_Comments.Controls.Add(Me.CommentsListPanel)
        Me.TabPage_Comments.Location = New System.Drawing.Point(4, 32)
        Me.TabPage_Comments.Name = "TabPage_Comments"
        Me.TabPage_Comments.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Comments.Size = New System.Drawing.Size(766, 287)
        Me.TabPage_Comments.TabIndex = 3
        Me.TabPage_Comments.Text = "Comentários"
        Me.TabPage_Comments.UseVisualStyleBackColor = True
        '
        'CommentsListPanel
        '
        Me.CommentsListPanel.AutoScroll = True
        Me.CommentsListPanel.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.CommentsListPanel.Controls.Add(Me.Label_NoComments)
        Me.CommentsListPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentsListPanel.Location = New System.Drawing.Point(3, 3)
        Me.CommentsListPanel.Name = "CommentsListPanel"
        Me.CommentsListPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.CommentsListPanel.Size = New System.Drawing.Size(760, 281)
        Me.CommentsListPanel.TabIndex = 70
        '
        'Label_NoComments
        '
        Me.Label_NoComments.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_NoComments.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_NoComments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label_NoComments.Location = New System.Drawing.Point(10, 10)
        Me.Label_NoComments.Name = "Label_NoComments"
        Me.Label_NoComments.Size = New System.Drawing.Size(740, 15)
        Me.Label_NoComments.TabIndex = 58
        Me.Label_NoComments.Text = "Você ainda não adicionou nenhum comentário..."
        '
        'ContextMenuStrip_QuickOptions
        '
        Me.ContextMenuStrip_QuickOptions.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip_QuickOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip_QuickOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarToolStripMenuItem, Me.ToolStripMenuItem2, Me.StatusInfoToolStripMenuItem, Me.DescriçãoToolStripMenuItem, Me.AlterarDataToolStripMenuItem, Me.EditarValorToolStripMenuItem, Me.ToolStripMenuItem3, Me.IncluirValorToolStripMenuItem, Me.ToolStripMenuItem5, Me.ExcluirToolStripMenuItem, Me.ToolStripMenuItem1, Me.FeedBackToolStripMenuItem})
        Me.ContextMenuStrip_QuickOptions.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip_QuickOptions.Size = New System.Drawing.Size(327, 258)
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.PagarToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_PayPlot_20px
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.PagarToolStripMenuItem.Text = "Pagar Parcela                                        "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(323, 6)
        '
        'StatusInfoToolStripMenuItem
        '
        Me.StatusInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem})
        Me.StatusInfoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.ContextMenuStatusPlotIconsResource.IconStatus_Status_20x20
        Me.StatusInfoToolStripMenuItem.Name = "StatusInfoToolStripMenuItem"
        Me.StatusInfoToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.StatusInfoToolStripMenuItem.Text = "Status"
        '
        'CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem
        '
        Me.CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem.Name = "CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem"
        Me.CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem.Size = New System.Drawing.Size(360, 24)
        Me.CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem.Text = "Onde estão as opções de Alteração de Status?"
        '
        'DescriçãoToolStripMenuItem
        '
        Me.DescriçãoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Comments_20x20
        Me.DescriçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DescriçãoToolStripMenuItem.Name = "DescriçãoToolStripMenuItem"
        Me.DescriçãoToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.DescriçãoToolStripMenuItem.Text = "Novo Comentário"
        '
        'AlterarDataToolStripMenuItem
        '
        Me.AlterarDataToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeMaturityDay_20x20
        Me.AlterarDataToolStripMenuItem.Name = "AlterarDataToolStripMenuItem"
        Me.AlterarDataToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.AlterarDataToolStripMenuItem.Text = "Data de Vencimento"
        '
        'EditarValorToolStripMenuItem
        '
        Me.EditarValorToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_ChangeValuePlot_20x20
        Me.EditarValorToolStripMenuItem.Name = "EditarValorToolStripMenuItem"
        Me.EditarValorToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.EditarValorToolStripMenuItem.Text = "Valor"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(323, 6)
        '
        'IncluirValorToolStripMenuItem
        '
        Me.IncluirValorToolStripMenuItem.CheckOnClick = True
        Me.IncluirValorToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_InclueValue_20x20
        Me.IncluirValorToolStripMenuItem.Name = "IncluirValorToolStripMenuItem"
        Me.IncluirValorToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.IncluirValorToolStripMenuItem.Text = "Não Incluir"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(323, 6)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_DeleteExpense_20x20
        Me.ExcluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(323, 6)
        '
        'FeedBackToolStripMenuItem
        '
        Me.FeedBackToolStripMenuItem.Name = "FeedBackToolStripMenuItem"
        Me.FeedBackToolStripMenuItem.Size = New System.Drawing.Size(326, 26)
        Me.FeedBackToolStripMenuItem.Text = "FeedBack"
        '
        'FileWatcherSystem
        '
        Me.FileWatcherSystem.EnableRaisingEvents = True
        Me.FileWatcherSystem.IncludeSubdirectories = True
        Me.FileWatcherSystem.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileWatcherSystem.SynchronizingObject = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem16, Me.MaisOpçõesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 52)
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(157, 24)
        Me.ToolStripMenuItem16.Text = "Clonar"
        Me.ToolStripMenuItem16.Visible = False
        '
        'MaisOpçõesToolStripMenuItem
        '
        Me.MaisOpçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem, Me.JurosToolStripMenuItem})
        Me.MaisOpçõesToolStripMenuItem.Name = "MaisOpçõesToolStripMenuItem"
        Me.MaisOpçõesToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.MaisOpçõesToolStripMenuItem.Text = "Mais Opções"
        '
        'AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem
        '
        Me.AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem.Name = "AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem"
        Me.AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem.Size = New System.Drawing.Size(411, 24)
        Me.AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem.Text = "Alterar Status Para Aguardando Pagamento em X Dias"
        '
        'JurosToolStripMenuItem
        '
        Me.JurosToolStripMenuItem.Name = "JurosToolStripMenuItem"
        Me.JurosToolStripMenuItem.Size = New System.Drawing.Size(411, 24)
        Me.JurosToolStripMenuItem.Text = "Juros Manual"
        '
        'ViewPlotSelectedDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 443)
        Me.Controls.Add(Me.TabControlPanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.StatusPanelBackGround)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewPlotSelectedDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizar Parcela"
        Me.StatusPanelBackGround.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.QuickOptionsButtons.ResumeLayout(False)
        Me.ExpenseTitleIconPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ExpenseColorPanel.ResumeLayout(False)
        Me.ExpenseColorPanel.PerformLayout()
        Me.TabControlPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_PlotInformation.ResumeLayout(False)
        Me.FlowLayoutPanel_BlocksInfos.ResumeLayout(False)
        Me.BLOCK_ExpenseName.ResumeLayout(False)
        Me.BLOCK_ExpenseName.PerformLayout()
        CType(Me.BlockIcon_ExpenseName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Total.ResumeLayout(False)
        Me.BLOCK_Total.PerformLayout()
        CType(Me.BlockIcon_Total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Paid.ResumeLayout(False)
        Me.BLOCK_Paid.PerformLayout()
        CType(Me.BlockIcon_Paid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_RestToPay.ResumeLayout(False)
        Me.BLOCK_RestToPay.PerformLayout()
        CType(Me.BlockIcon_RestToPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Discounts.ResumeLayout(False)
        Me.BLOCK_Discounts.PerformLayout()
        CType(Me.BlockIcon_Discounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_Interest.ResumeLayout(False)
        Me.BLOCK_Interest.PerformLayout()
        CType(Me.BlockIcon_Interests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BLOCK_MaturityDate.ResumeLayout(False)
        Me.BLOCK_MaturityDate.PerformLayout()
        CType(Me.BlockIcon_MaturityDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_InvoicePostings.ResumeLayout(False)
        Me.InvoicePostingsListPanel.ResumeLayout(False)
        Me.TabPage_Historic.ResumeLayout(False)
        Me.HistoricPaymentListPanel.ResumeLayout(False)
        Me.TabPage_Comments.ResumeLayout(False)
        Me.CommentsListPanel.ResumeLayout(False)
        Me.ContextMenuStrip_QuickOptions.ResumeLayout(False)
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StatusPanelBackGround As Panel
    Friend WithEvents StatusSeparatorLinePanel As Panel
    Friend WithEvents StatusBarPanel As Panel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents QuickOptionsButtons As Panel
    Friend WithEvents MenuQuickOptions_Button As QuickOptionExpenseButton
    Friend WithEvents ExpenseTitleIconPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PlotDateLabel As Label
    Friend WithEvents StatusPlotLabel As Label
    Friend WithEvents ExpenseColorPanel As Panel
    Friend WithEvents PlotNumberLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControlPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_PlotInformation As TabPage
    Friend WithEvents FlowLayoutPanel_BlocksInfos As FlowLayoutPanel
    Friend WithEvents BLOCK_Total As Panel
    Friend WithEvents BlockIcon_Total As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents BLOCK_Paid As Panel
    Friend WithEvents BlockIcon_Paid As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PaidLabel As Label
    Friend WithEvents BLOCK_RestToPay As Panel
    Friend WithEvents BlockIcon_RestToPay As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RestToPayLabel As Label
    Friend WithEvents BLOCK_Discounts As Panel
    Friend WithEvents BlockIcon_Discounts As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DiscountsLabel As Label
    Friend WithEvents BLOCK_Interest As Panel
    Friend WithEvents BlockIcon_Interests As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InterestLabel As Label
    Friend WithEvents BLOCK_MaturityDate As Panel
    Friend WithEvents BlockIcon_MaturityDate As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MaturityDateLabel As Label
    Friend WithEvents TabPage_Historic As TabPage
    Friend WithEvents TabPage_Comments As TabPage
    Friend WithEvents ContextMenuStrip_QuickOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarValorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescriçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncluirValorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileWatcherSystem As System.IO.FileSystemWatcher
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadêAsOpçõesDeAlteraçãoDeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_NoHistoricPayment As System.Windows.Forms.Label
    Friend WithEvents BLOCK_ExpenseName As System.Windows.Forms.Panel
    Friend WithEvents BlockIcon_ExpenseName As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Despesa As System.Windows.Forms.Label
    Friend WithEvents ExpenseNameLabel As System.Windows.Forms.Label
    Friend WithEvents HistoricPaymentListPanel As System.Windows.Forms.Panel
    Friend WithEvents CommentsListPanel As System.Windows.Forms.Panel
    Friend WithEvents Label_NoComments As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaisOpçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarStatusParaAguardandoPagamentoEmXDiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JurosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage_InvoicePostings As System.Windows.Forms.TabPage
    Friend WithEvents InvoicePostingsListPanel As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FeedBackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
