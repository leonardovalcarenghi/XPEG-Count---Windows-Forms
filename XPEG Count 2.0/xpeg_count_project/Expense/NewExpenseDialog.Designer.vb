<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewExpenseDialog
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_GeneralInformations = New System.Windows.Forms.TabPage()
        Me.STYLE_ExpenseImg = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Selector_ExpenseCategory = New xpeg_count_project.CountCategorySelector()
        Me.Label_CategoriaDaDespesa = New System.Windows.Forms.Label()
        Me.LabelTIP_Categoria = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label_DescriçãoDaDespesa = New System.Windows.Forms.Label()
        Me.TextBox_ExpenseDescription = New System.Windows.Forms.TextBox()
        Me.LabelTIP_Desrição = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label_NomaDaDespesa = New System.Windows.Forms.Label()
        Me.TextBox_ExpenseName = New System.Windows.Forms.TextBox()
        Me.LabelTIP_NomeDaDespesa = New System.Windows.Forms.Label()
        Me.TabPage_Dates = New System.Windows.Forms.TabPage()
        Me.STYLE_CalendarImg = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_DiaDeVencimento = New System.Windows.Forms.Label()
        Me.LabelTIP_DiaDeVencimento = New System.Windows.Forms.Label()
        Me.ComboBox_MaturityDay = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_DataInicial = New System.Windows.Forms.Label()
        Me.LabelTIP_DataInicial = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_BuyDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_DataDaCompra = New System.Windows.Forms.Label()
        Me.LabelTIP_DataCompra = New System.Windows.Forms.Label()
        Me.TabPage_Values = New System.Windows.Forms.TabPage()
        Me.STYLE_ValuesImg = New System.Windows.Forms.PictureBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label_QuantidadeDeParcelas = New System.Windows.Forms.Label()
        Me.TextBox_NumberOfPlots = New System.Windows.Forms.TextBox()
        Me.LabelTIP_QuantidadeDeParcelas = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label_ValorDaParcela = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TextBox_PlotValue = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LabelTIP_ValorDaParcelas = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TotalOfExpenseLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelTIP_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.TabPage_Interest = New System.Windows.Forms.TabPage()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.STYLE_InterestImg = New System.Windows.Forms.PictureBox()
        Me.TabPage_Custom = New System.Windows.Forms.TabPage()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox_ExpenseIcon = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox_HighColorExpense = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.STYLE_CustomImg = New System.Windows.Forms.PictureBox()
        Me.TabPage_Outhers = New System.Windows.Forms.TabPage()
        Me.STYLE_LinkImg = New System.Windows.Forms.PictureBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label_VinsularDespesa = New System.Windows.Forms.Label()
        Me.LabelTIP_VincularDespesa = New System.Windows.Forms.Label()
        Me.ComboBox_LinkCard = New System.Windows.Forms.ComboBox()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Label_File = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Controls_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_GeneralInformations.SuspendLayout()
        CType(Me.STYLE_ExpenseImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage_Dates.SuspendLayout()
        CType(Me.STYLE_CalendarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage_Values.SuspendLayout()
        CType(Me.STYLE_ValuesImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage_Interest.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.STYLE_InterestImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Custom.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox_ExpenseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox_HighColorExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STYLE_CustomImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Outhers.SuspendLayout()
        CType(Me.STYLE_LinkImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.TabControl1)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Controls_Panel.Size = New System.Drawing.Size(984, 421)
        Me.Controls_Panel.TabIndex = 30
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_GeneralInformations)
        Me.TabControl1.Controls.Add(Me.TabPage_Dates)
        Me.TabControl1.Controls.Add(Me.TabPage_Values)
        Me.TabControl1.Controls.Add(Me.TabPage_Interest)
        Me.TabControl1.Controls.Add(Me.TabPage_Custom)
        Me.TabControl1.Controls.Add(Me.TabPage_Outhers)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(964, 401)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage_GeneralInformations
        '
        Me.TabPage_GeneralInformations.Controls.Add(Me.STYLE_ExpenseImg)
        Me.TabPage_GeneralInformations.Controls.Add(Me.Panel7)
        Me.TabPage_GeneralInformations.Controls.Add(Me.Panel6)
        Me.TabPage_GeneralInformations.Controls.Add(Me.Panel5)
        Me.TabPage_GeneralInformations.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_GeneralInformations.Name = "TabPage_GeneralInformations"
        Me.TabPage_GeneralInformations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_GeneralInformations.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_GeneralInformations.TabIndex = 2
        Me.TabPage_GeneralInformations.Text = "Informações Gerais"
        Me.TabPage_GeneralInformations.UseVisualStyleBackColor = True
        '
        'STYLE_ExpenseImg
        '
        Me.STYLE_ExpenseImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_ExpenseImg.Location = New System.Drawing.Point(680, 54)
        Me.STYLE_ExpenseImg.Name = "STYLE_ExpenseImg"
        Me.STYLE_ExpenseImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_ExpenseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_ExpenseImg.TabIndex = 78
        Me.STYLE_ExpenseImg.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Selector_ExpenseCategory)
        Me.Panel7.Controls.Add(Me.Label_CategoriaDaDespesa)
        Me.Panel7.Controls.Add(Me.LabelTIP_Categoria)
        Me.Panel7.Location = New System.Drawing.Point(25, 197)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(600, 80)
        Me.Panel7.TabIndex = 70
        '
        'Selector_ExpenseCategory
        '
        Me.Selector_ExpenseCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Selector_ExpenseCategory.Location = New System.Drawing.Point(7, 30)
        Me.Selector_ExpenseCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.Selector_ExpenseCategory.Name = "Selector_ExpenseCategory"
        Me.Selector_ExpenseCategory.SelectedCategoryCode = Nothing
        Me.Selector_ExpenseCategory.Size = New System.Drawing.Size(399, 28)
        Me.Selector_ExpenseCategory.TabIndex = 3
        '
        'Label_CategoriaDaDespesa
        '
        Me.Label_CategoriaDaDespesa.AutoSize = True
        Me.Label_CategoriaDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_CategoriaDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_CategoriaDaDespesa.Name = "Label_CategoriaDaDespesa"
        Me.Label_CategoriaDaDespesa.Size = New System.Drawing.Size(143, 19)
        Me.Label_CategoriaDaDespesa.TabIndex = 57
        Me.Label_CategoriaDaDespesa.Text = "&Categoria da Despesa"
        '
        'LabelTIP_Categoria
        '
        Me.LabelTIP_Categoria.AutoSize = True
        Me.LabelTIP_Categoria.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_Categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_Categoria.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_Categoria.Name = "LabelTIP_Categoria"
        Me.LabelTIP_Categoria.Size = New System.Drawing.Size(296, 15)
        Me.LabelTIP_Categoria.TabIndex = 58
        Me.LabelTIP_Categoria.Text = "Diga-nos em qual categoria a sua despesa se enquadra."
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label_DescriçãoDaDespesa)
        Me.Panel6.Controls.Add(Me.TextBox_ExpenseDescription)
        Me.Panel6.Controls.Add(Me.LabelTIP_Desrição)
        Me.Panel6.Location = New System.Drawing.Point(25, 111)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(600, 80)
        Me.Panel6.TabIndex = 70
        '
        'Label_DescriçãoDaDespesa
        '
        Me.Label_DescriçãoDaDespesa.AutoSize = True
        Me.Label_DescriçãoDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DescriçãoDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_DescriçãoDaDespesa.Name = "Label_DescriçãoDaDespesa"
        Me.Label_DescriçãoDaDespesa.Size = New System.Drawing.Size(70, 19)
        Me.Label_DescriçãoDaDespesa.TabIndex = 57
        Me.Label_DescriçãoDaDespesa.Text = "&Descrição"
        '
        'TextBox_ExpenseDescription
        '
        Me.TextBox_ExpenseDescription.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_ExpenseDescription.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_ExpenseDescription.MaxLength = 200
        Me.TextBox_ExpenseDescription.Name = "TextBox_ExpenseDescription"
        Me.TextBox_ExpenseDescription.Size = New System.Drawing.Size(550, 25)
        Me.TextBox_ExpenseDescription.TabIndex = 2
        '
        'LabelTIP_Desrição
        '
        Me.LabelTIP_Desrição.AutoSize = True
        Me.LabelTIP_Desrição.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_Desrição.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_Desrição.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_Desrição.Name = "LabelTIP_Desrição"
        Me.LabelTIP_Desrição.Size = New System.Drawing.Size(258, 15)
        Me.LabelTIP_Desrição.TabIndex = 58
        Me.LabelTIP_Desrição.Text = "Escreva uma breve descrição para a sua despesa."
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label_NomaDaDespesa)
        Me.Panel5.Controls.Add(Me.TextBox_ExpenseName)
        Me.Panel5.Controls.Add(Me.LabelTIP_NomeDaDespesa)
        Me.Panel5.Location = New System.Drawing.Point(25, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(600, 80)
        Me.Panel5.TabIndex = 69
        '
        'Label_NomaDaDespesa
        '
        Me.Label_NomaDaDespesa.AutoSize = True
        Me.Label_NomaDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_NomaDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_NomaDaDespesa.Name = "Label_NomaDaDespesa"
        Me.Label_NomaDaDespesa.Size = New System.Drawing.Size(121, 19)
        Me.Label_NomaDaDespesa.TabIndex = 57
        Me.Label_NomaDaDespesa.Text = "&Nome da Despesa"
        '
        'TextBox_ExpenseName
        '
        Me.TextBox_ExpenseName.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_ExpenseName.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_ExpenseName.MaxLength = 60
        Me.TextBox_ExpenseName.Name = "TextBox_ExpenseName"
        Me.TextBox_ExpenseName.Size = New System.Drawing.Size(350, 25)
        Me.TextBox_ExpenseName.TabIndex = 1
        '
        'LabelTIP_NomeDaDespesa
        '
        Me.LabelTIP_NomeDaDespesa.AutoSize = True
        Me.LabelTIP_NomeDaDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_NomeDaDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_NomeDaDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_NomeDaDespesa.Name = "LabelTIP_NomeDaDespesa"
        Me.LabelTIP_NomeDaDespesa.Size = New System.Drawing.Size(173, 15)
        Me.LabelTIP_NomeDaDespesa.TabIndex = 58
        Me.LabelTIP_NomeDaDespesa.Text = "Escreva o nome da sua despesa."
        '
        'TabPage_Dates
        '
        Me.TabPage_Dates.Controls.Add(Me.STYLE_CalendarImg)
        Me.TabPage_Dates.Controls.Add(Me.Panel3)
        Me.TabPage_Dates.Controls.Add(Me.Panel2)
        Me.TabPage_Dates.Controls.Add(Me.Panel1)
        Me.TabPage_Dates.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_Dates.Name = "TabPage_Dates"
        Me.TabPage_Dates.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Dates.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_Dates.TabIndex = 3
        Me.TabPage_Dates.Text = "Datas"
        Me.TabPage_Dates.UseVisualStyleBackColor = True
        '
        'STYLE_CalendarImg
        '
        Me.STYLE_CalendarImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_CalendarImg.Location = New System.Drawing.Point(680, 54)
        Me.STYLE_CalendarImg.Name = "STYLE_CalendarImg"
        Me.STYLE_CalendarImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_CalendarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_CalendarImg.TabIndex = 77
        Me.STYLE_CalendarImg.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_DiaDeVencimento)
        Me.Panel3.Controls.Add(Me.LabelTIP_DiaDeVencimento)
        Me.Panel3.Controls.Add(Me.ComboBox_MaturityDay)
        Me.Panel3.Location = New System.Drawing.Point(25, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(600, 80)
        Me.Panel3.TabIndex = 73
        '
        'Label_DiaDeVencimento
        '
        Me.Label_DiaDeVencimento.AutoSize = True
        Me.Label_DiaDeVencimento.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DiaDeVencimento.Location = New System.Drawing.Point(3, 5)
        Me.Label_DiaDeVencimento.Name = "Label_DiaDeVencimento"
        Me.Label_DiaDeVencimento.Size = New System.Drawing.Size(127, 19)
        Me.Label_DiaDeVencimento.TabIndex = 57
        Me.Label_DiaDeVencimento.Text = "&Dia de Vencimento"
        '
        'LabelTIP_DiaDeVencimento
        '
        Me.LabelTIP_DiaDeVencimento.AutoSize = True
        Me.LabelTIP_DiaDeVencimento.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DiaDeVencimento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DiaDeVencimento.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DiaDeVencimento.Name = "LabelTIP_DiaDeVencimento"
        Me.LabelTIP_DiaDeVencimento.Size = New System.Drawing.Size(196, 15)
        Me.LabelTIP_DiaDeVencimento.TabIndex = 58
        Me.LabelTIP_DiaDeVencimento.Text = "Em qual dia do mês a parcela vence?"
        '
        'ComboBox_MaturityDay
        '
        Me.ComboBox_MaturityDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox_MaturityDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_MaturityDay.DropDownHeight = 80
        Me.ComboBox_MaturityDay.DropDownWidth = 100
        Me.ComboBox_MaturityDay.FormattingEnabled = True
        Me.ComboBox_MaturityDay.IntegralHeight = False
        Me.ComboBox_MaturityDay.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox_MaturityDay.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_MaturityDay.Name = "ComboBox_MaturityDay"
        Me.ComboBox_MaturityDay.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox_MaturityDay.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTimePicker_StartDate)
        Me.Panel2.Controls.Add(Me.Label_DataInicial)
        Me.Panel2.Controls.Add(Me.LabelTIP_DataInicial)
        Me.Panel2.Location = New System.Drawing.Point(25, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 80)
        Me.Panel2.TabIndex = 72
        '
        'DateTimePicker_StartDate
        '
        Me.DateTimePicker_StartDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_StartDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_StartDate.Location = New System.Drawing.Point(7, 30)
        Me.DateTimePicker_StartDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_StartDate.Name = "DateTimePicker_StartDate"
        Me.DateTimePicker_StartDate.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker_StartDate.TabIndex = 5
        Me.DateTimePicker_StartDate.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label_DataInicial
        '
        Me.Label_DataInicial.AutoSize = True
        Me.Label_DataInicial.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DataInicial.Location = New System.Drawing.Point(3, 5)
        Me.Label_DataInicial.Name = "Label_DataInicial"
        Me.Label_DataInicial.Size = New System.Drawing.Size(80, 19)
        Me.Label_DataInicial.TabIndex = 57
        Me.Label_DataInicial.Text = "&Data Inicial"
        '
        'LabelTIP_DataInicial
        '
        Me.LabelTIP_DataInicial.AutoSize = True
        Me.LabelTIP_DataInicial.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DataInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DataInicial.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DataInicial.Name = "LabelTIP_DataInicial"
        Me.LabelTIP_DataInicial.Size = New System.Drawing.Size(393, 15)
        Me.LabelTIP_DataInicial.TabIndex = 58
        Me.LabelTIP_DataInicial.Text = "Informe a data inicial da despesa para o Count começar a fazer os calcúlos."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker_BuyDate)
        Me.Panel1.Controls.Add(Me.Label_DataDaCompra)
        Me.Panel1.Controls.Add(Me.LabelTIP_DataCompra)
        Me.Panel1.Location = New System.Drawing.Point(25, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 80)
        Me.Panel1.TabIndex = 70
        '
        'DateTimePicker_BuyDate
        '
        Me.DateTimePicker_BuyDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_BuyDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_BuyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_BuyDate.Location = New System.Drawing.Point(7, 30)
        Me.DateTimePicker_BuyDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_BuyDate.Name = "DateTimePicker_BuyDate"
        Me.DateTimePicker_BuyDate.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker_BuyDate.TabIndex = 4
        Me.DateTimePicker_BuyDate.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label_DataDaCompra
        '
        Me.Label_DataDaCompra.AutoSize = True
        Me.Label_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DataDaCompra.Location = New System.Drawing.Point(3, 5)
        Me.Label_DataDaCompra.Name = "Label_DataDaCompra"
        Me.Label_DataDaCompra.Size = New System.Drawing.Size(110, 19)
        Me.Label_DataDaCompra.TabIndex = 57
        Me.Label_DataDaCompra.Text = "&Data da Compra"
        '
        'LabelTIP_DataCompra
        '
        Me.LabelTIP_DataCompra.AutoSize = True
        Me.LabelTIP_DataCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DataCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DataCompra.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DataCompra.Name = "LabelTIP_DataCompra"
        Me.LabelTIP_DataCompra.Size = New System.Drawing.Size(263, 15)
        Me.LabelTIP_DataCompra.TabIndex = 58
        Me.LabelTIP_DataCompra.Text = "Informe a data da compra do produto ou serviço."
        '
        'TabPage_Values
        '
        Me.TabPage_Values.Controls.Add(Me.STYLE_ValuesImg)
        Me.TabPage_Values.Controls.Add(Me.Panel11)
        Me.TabPage_Values.Controls.Add(Me.Panel9)
        Me.TabPage_Values.Controls.Add(Me.Panel8)
        Me.TabPage_Values.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_Values.Name = "TabPage_Values"
        Me.TabPage_Values.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Values.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_Values.TabIndex = 4
        Me.TabPage_Values.Text = "Valores"
        Me.TabPage_Values.UseVisualStyleBackColor = True
        '
        'STYLE_ValuesImg
        '
        Me.STYLE_ValuesImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_ValuesImg.Location = New System.Drawing.Point(679, 54)
        Me.STYLE_ValuesImg.Name = "STYLE_ValuesImg"
        Me.STYLE_ValuesImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_ValuesImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_ValuesImg.TabIndex = 78
        Me.STYLE_ValuesImg.TabStop = False
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label_QuantidadeDeParcelas)
        Me.Panel11.Controls.Add(Me.TextBox_NumberOfPlots)
        Me.Panel11.Controls.Add(Me.LabelTIP_QuantidadeDeParcelas)
        Me.Panel11.Location = New System.Drawing.Point(25, 111)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(600, 80)
        Me.Panel11.TabIndex = 73
        '
        'Label_QuantidadeDeParcelas
        '
        Me.Label_QuantidadeDeParcelas.AutoSize = True
        Me.Label_QuantidadeDeParcelas.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_QuantidadeDeParcelas.Location = New System.Drawing.Point(3, 5)
        Me.Label_QuantidadeDeParcelas.Name = "Label_QuantidadeDeParcelas"
        Me.Label_QuantidadeDeParcelas.Size = New System.Drawing.Size(156, 19)
        Me.Label_QuantidadeDeParcelas.TabIndex = 57
        Me.Label_QuantidadeDeParcelas.Text = "&Quantidade de Parcelas"
        '
        'TextBox_NumberOfPlots
        '
        Me.TextBox_NumberOfPlots.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_NumberOfPlots.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_NumberOfPlots.MaxLength = 3
        Me.TextBox_NumberOfPlots.Name = "TextBox_NumberOfPlots"
        Me.TextBox_NumberOfPlots.Size = New System.Drawing.Size(150, 25)
        Me.TextBox_NumberOfPlots.TabIndex = 9
        '
        'LabelTIP_QuantidadeDeParcelas
        '
        Me.LabelTIP_QuantidadeDeParcelas.AutoSize = True
        Me.LabelTIP_QuantidadeDeParcelas.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_QuantidadeDeParcelas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_QuantidadeDeParcelas.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_QuantidadeDeParcelas.Name = "LabelTIP_QuantidadeDeParcelas"
        Me.LabelTIP_QuantidadeDeParcelas.Size = New System.Drawing.Size(254, 15)
        Me.LabelTIP_QuantidadeDeParcelas.TabIndex = 58
        Me.LabelTIP_QuantidadeDeParcelas.Text = "Em quantas vezes você parcelou a sua despesa?"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label_ValorDaParcela)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.LabelTIP_ValorDaParcelas)
        Me.Panel9.Location = New System.Drawing.Point(25, 25)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(600, 80)
        Me.Panel9.TabIndex = 72
        '
        'Label_ValorDaParcela
        '
        Me.Label_ValorDaParcela.AutoSize = True
        Me.Label_ValorDaParcela.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_ValorDaParcela.Location = New System.Drawing.Point(3, 5)
        Me.Label_ValorDaParcela.Name = "Label_ValorDaParcela"
        Me.Label_ValorDaParcela.Size = New System.Drawing.Size(109, 19)
        Me.Label_ValorDaParcela.TabIndex = 57
        Me.Label_ValorDaParcela.Text = "&Valor da Parcela"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.TextBox_PlotValue)
        Me.Panel10.Controls.Add(Me.Label17)
        Me.Panel10.Location = New System.Drawing.Point(7, 30)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(150, 25)
        Me.Panel10.TabIndex = 38
        '
        'TextBox_PlotValue
        '
        Me.TextBox_PlotValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_PlotValue.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_PlotValue.Location = New System.Drawing.Point(26, 0)
        Me.TextBox_PlotValue.MaxLength = 9
        Me.TextBox_PlotValue.Name = "TextBox_PlotValue"
        Me.TextBox_PlotValue.Size = New System.Drawing.Size(124, 25)
        Me.TextBox_PlotValue.TabIndex = 11
        Me.TextBox_PlotValue.Text = "0,00"
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 25)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "R$"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTIP_ValorDaParcelas
        '
        Me.LabelTIP_ValorDaParcelas.AutoSize = True
        Me.LabelTIP_ValorDaParcelas.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_ValorDaParcelas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_ValorDaParcelas.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_ValorDaParcelas.Name = "LabelTIP_ValorDaParcelas"
        Me.LabelTIP_ValorDaParcelas.Size = New System.Drawing.Size(267, 15)
        Me.LabelTIP_ValorDaParcelas.TabIndex = 58
        Me.LabelTIP_ValorDaParcelas.Text = "Quanto ficou o valor parcelado para cada parcela?"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label_TotalDaDespesa)
        Me.Panel8.Controls.Add(Me.Panel4)
        Me.Panel8.Controls.Add(Me.LabelTIP_TotalDaDespesa)
        Me.Panel8.Location = New System.Drawing.Point(25, 197)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(600, 80)
        Me.Panel8.TabIndex = 71
        '
        'Label_TotalDaDespesa
        '
        Me.Label_TotalDaDespesa.AutoSize = True
        Me.Label_TotalDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_TotalDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_TotalDaDespesa.Name = "Label_TotalDaDespesa"
        Me.Label_TotalDaDespesa.Size = New System.Drawing.Size(114, 19)
        Me.Label_TotalDaDespesa.TabIndex = 57
        Me.Label_TotalDaDespesa.Text = "&Total da Despesa"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TotalOfExpenseLabel)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(7, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 25)
        Me.Panel4.TabIndex = 38
        '
        'TotalOfExpenseLabel
        '
        Me.TotalOfExpenseLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TotalOfExpenseLabel.Location = New System.Drawing.Point(21, 0)
        Me.TotalOfExpenseLabel.Name = "TotalOfExpenseLabel"
        Me.TotalOfExpenseLabel.Size = New System.Drawing.Size(124, 25)
        Me.TotalOfExpenseLabel.TabIndex = 34
        Me.TotalOfExpenseLabel.Text = "0,00"
        Me.TotalOfExpenseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 25)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "R$"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTIP_TotalDaDespesa
        '
        Me.LabelTIP_TotalDaDespesa.AutoSize = True
        Me.LabelTIP_TotalDaDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_TotalDaDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_TotalDaDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_TotalDaDespesa.Name = "LabelTIP_TotalDaDespesa"
        Me.LabelTIP_TotalDaDespesa.Size = New System.Drawing.Size(124, 15)
        Me.LabelTIP_TotalDaDespesa.TabIndex = 58
        Me.LabelTIP_TotalDaDespesa.Text = "Valor total da despesa." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage_Interest
        '
        Me.TabPage_Interest.Controls.Add(Me.Panel18)
        Me.TabPage_Interest.Controls.Add(Me.Panel19)
        Me.TabPage_Interest.Controls.Add(Me.Panel14)
        Me.TabPage_Interest.Controls.Add(Me.STYLE_InterestImg)
        Me.TabPage_Interest.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_Interest.Name = "TabPage_Interest"
        Me.TabPage_Interest.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Interest.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_Interest.TabIndex = 7
        Me.TabPage_Interest.Text = "Juros"
        Me.TabPage_Interest.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.LinkLabel6)
        Me.Panel18.Controls.Add(Me.Label12)
        Me.Panel18.Controls.Add(Me.Panel21)
        Me.Panel18.Controls.Add(Me.Label19)
        Me.Panel18.Location = New System.Drawing.Point(25, 111)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(600, 80)
        Me.Panel18.TabIndex = 84
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel6.Location = New System.Drawing.Point(158, 30)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(80, 25)
        Me.LinkLabel6.TabIndex = 8
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Calcular"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel6.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(3, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 19)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "&Taxa de Juros Por Dia"
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.TextBox3)
        Me.Panel21.Controls.Add(Me.Label14)
        Me.Panel21.Location = New System.Drawing.Point(7, 30)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(150, 25)
        Me.Panel21.TabIndex = 38
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox3.Location = New System.Drawing.Point(26, 0)
        Me.TextBox3.MaxLength = 9
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 25)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "0,00"
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 25)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "%"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(4, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(308, 15)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Qual a taxa de juros caso o pagamento da parcela atrasar?"
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.LinkLabel7)
        Me.Panel19.Controls.Add(Me.Label15)
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Label18)
        Me.Panel19.Location = New System.Drawing.Point(25, 197)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(600, 80)
        Me.Panel19.TabIndex = 83
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel7.Location = New System.Drawing.Point(158, 30)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(80, 25)
        Me.LinkLabel7.TabIndex = 8
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Calcular"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel7.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(3, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(212, 19)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "&Juros Cobrado Por Dia de Atraso"
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.TextBox4)
        Me.Panel20.Controls.Add(Me.Label16)
        Me.Panel20.Location = New System.Drawing.Point(7, 30)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(150, 25)
        Me.Panel20.TabIndex = 38
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox4.Location = New System.Drawing.Point(26, 0)
        Me.TextBox4.MaxLength = 9
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 25)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "0,00"
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 25)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "R$"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(4, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(243, 15)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Existe algum valor cobrado por dia de atraso?"
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.LinkLabel4)
        Me.Panel14.Controls.Add(Me.Label4)
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Location = New System.Drawing.Point(25, 25)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(600, 80)
        Me.Panel14.TabIndex = 80
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel4.Location = New System.Drawing.Point(158, 30)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(80, 25)
        Me.LinkLabel4.TabIndex = 8
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Calcular"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "&Juro Base Por Atraso"
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.TextBox1)
        Me.Panel16.Controls.Add(Me.Label5)
        Me.Panel16.Location = New System.Drawing.Point(7, 30)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(150, 25)
        Me.Panel16.TabIndex = 38
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(26, 0)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 25)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "0,00"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "R$"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(505, 15)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Se ao vencer a parcela existir um valor de base que é cobrado, informe aqui para " & _
    "o Cout calcular."
        '
        'STYLE_InterestImg
        '
        Me.STYLE_InterestImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_InterestImg.Location = New System.Drawing.Point(680, 54)
        Me.STYLE_InterestImg.Name = "STYLE_InterestImg"
        Me.STYLE_InterestImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_InterestImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_InterestImg.TabIndex = 79
        Me.STYLE_InterestImg.TabStop = False
        '
        'TabPage_Custom
        '
        Me.TabPage_Custom.Controls.Add(Me.Panel15)
        Me.TabPage_Custom.Controls.Add(Me.Panel13)
        Me.TabPage_Custom.Controls.Add(Me.STYLE_CustomImg)
        Me.TabPage_Custom.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_Custom.Name = "TabPage_Custom"
        Me.TabPage_Custom.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Custom.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_Custom.TabIndex = 6
        Me.TabPage_Custom.Text = "Personalização"
        Me.TabPage_Custom.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label7)
        Me.Panel15.Controls.Add(Me.PictureBox_ExpenseIcon)
        Me.Panel15.Controls.Add(Me.Label8)
        Me.Panel15.Controls.Add(Me.Label9)
        Me.Panel15.Location = New System.Drawing.Point(25, 111)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(600, 80)
        Me.Panel15.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(35, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 25)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Icone Selecionado"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_ExpenseIcon
        '
        Me.PictureBox_ExpenseIcon.BackColor = System.Drawing.Color.DarkBlue
        Me.PictureBox_ExpenseIcon.Location = New System.Drawing.Point(7, 30)
        Me.PictureBox_ExpenseIcon.Name = "PictureBox_ExpenseIcon"
        Me.PictureBox_ExpenseIcon.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_ExpenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_ExpenseIcon.TabIndex = 81
        Me.PictureBox_ExpenseIcon.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "&Icone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Escolha um icone para sua despesa."
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label3)
        Me.Panel13.Controls.Add(Me.PictureBox_HighColorExpense)
        Me.Panel13.Controls.Add(Me.Label1)
        Me.Panel13.Controls.Add(Me.Label2)
        Me.Panel13.Location = New System.Drawing.Point(25, 25)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(600, 80)
        Me.Panel13.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Cor Selecionada"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_HighColorExpense
        '
        Me.PictureBox_HighColorExpense.BackColor = System.Drawing.Color.DarkBlue
        Me.PictureBox_HighColorExpense.Location = New System.Drawing.Point(7, 30)
        Me.PictureBox_HighColorExpense.Name = "PictureBox_HighColorExpense"
        Me.PictureBox_HighColorExpense.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox_HighColorExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_HighColorExpense.TabIndex = 81
        Me.PictureBox_HighColorExpense.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 19)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "&Cor de Destaque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Escolha uma cor de destaque para sua despesa."
        '
        'STYLE_CustomImg
        '
        Me.STYLE_CustomImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_CustomImg.Location = New System.Drawing.Point(679, 54)
        Me.STYLE_CustomImg.Name = "STYLE_CustomImg"
        Me.STYLE_CustomImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_CustomImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_CustomImg.TabIndex = 79
        Me.STYLE_CustomImg.TabStop = False
        '
        'TabPage_Outhers
        '
        Me.TabPage_Outhers.Controls.Add(Me.STYLE_LinkImg)
        Me.TabPage_Outhers.Controls.Add(Me.Panel12)
        Me.TabPage_Outhers.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_Outhers.Name = "TabPage_Outhers"
        Me.TabPage_Outhers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Outhers.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_Outhers.TabIndex = 5
        Me.TabPage_Outhers.Text = "Outros"
        Me.TabPage_Outhers.UseVisualStyleBackColor = True
        '
        'STYLE_LinkImg
        '
        Me.STYLE_LinkImg.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.STYLE_LinkImg.Location = New System.Drawing.Point(679, 54)
        Me.STYLE_LinkImg.Name = "STYLE_LinkImg"
        Me.STYLE_LinkImg.Size = New System.Drawing.Size(250, 250)
        Me.STYLE_LinkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.STYLE_LinkImg.TabIndex = 78
        Me.STYLE_LinkImg.TabStop = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label_VinsularDespesa)
        Me.Panel12.Controls.Add(Me.LabelTIP_VincularDespesa)
        Me.Panel12.Controls.Add(Me.ComboBox_LinkCard)
        Me.Panel12.Location = New System.Drawing.Point(25, 25)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(600, 80)
        Me.Panel12.TabIndex = 70
        '
        'Label_VinsularDespesa
        '
        Me.Label_VinsularDespesa.AutoSize = True
        Me.Label_VinsularDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_VinsularDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_VinsularDespesa.Name = "Label_VinsularDespesa"
        Me.Label_VinsularDespesa.Size = New System.Drawing.Size(116, 19)
        Me.Label_VinsularDespesa.TabIndex = 57
        Me.Label_VinsularDespesa.Text = "&Vincular Despesa"
        '
        'LabelTIP_VincularDespesa
        '
        Me.LabelTIP_VincularDespesa.AutoSize = True
        Me.LabelTIP_VincularDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_VincularDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_VincularDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_VincularDespesa.Name = "LabelTIP_VincularDespesa"
        Me.LabelTIP_VincularDespesa.Size = New System.Drawing.Size(294, 15)
        Me.LabelTIP_VincularDespesa.TabIndex = 58
        Me.LabelTIP_VincularDespesa.Text = "Deseja vincular esta despesa com um cartão de crédito?"
        '
        'ComboBox_LinkCard
        '
        Me.ComboBox_LinkCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_LinkCard.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox_LinkCard.FormattingEnabled = True
        Me.ComboBox_LinkCard.Items.AddRange(New Object() {"Não Vincular", "Cartão de Crédito NuBank"})
        Me.ComboBox_LinkCard.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_LinkCard.Name = "ComboBox_LinkCard"
        Me.ComboBox_LinkCard.Size = New System.Drawing.Size(350, 25)
        Me.ComboBox_LinkCard.TabIndex = 13
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Label_File)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 421)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(984, 40)
        Me.DialogOptionsPanel.TabIndex = 84
        '
        'Label_File
        '
        Me.Label_File.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_File.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_File.Location = New System.Drawing.Point(44, 2)
        Me.Label_File.Name = "Label_File"
        Me.Label_File.Size = New System.Drawing.Size(31, 36)
        Me.Label_File.TabIndex = 75
        Me.Label_File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(873, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_OK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Button_OK.Location = New System.Drawing.Point(737, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(130, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Criar Despesa"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(984, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'NewExpenseDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Controls_Panel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewExpenseDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nova Despesa"
        Me.Controls_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_GeneralInformations.ResumeLayout(False)
        CType(Me.STYLE_ExpenseImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage_Dates.ResumeLayout(False)
        CType(Me.STYLE_CalendarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage_Values.ResumeLayout(False)
        CType(Me.STYLE_ValuesImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TabPage_Interest.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        CType(Me.STYLE_InterestImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Custom.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.PictureBox_ExpenseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox_HighColorExpense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STYLE_CustomImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Outhers.ResumeLayout(False)
        CType(Me.STYLE_LinkImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Controls_Panel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_GeneralInformations As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_Dates As TabPage
    Friend WithEvents DialogOptionsPanel As Panel
    Friend WithEvents Label_File As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_OK As Button
    Friend WithEvents DialogOptionsSeparatorPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label_DescriçãoDaDespesa As Label
    Friend WithEvents TextBox_ExpenseDescription As TextBox
    Friend WithEvents LabelTIP_Desrição As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label_NomaDaDespesa As Label
    Friend WithEvents TextBox_ExpenseName As TextBox
    Friend WithEvents LabelTIP_NomeDaDespesa As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label_CategoriaDaDespesa As Label
    Friend WithEvents LabelTIP_Categoria As Label
    Friend WithEvents Selector_ExpenseCategory As CountCategorySelector
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label_DataDaCompra As Label
    Friend WithEvents LabelTIP_DataCompra As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker_StartDate As DateTimePicker
    Friend WithEvents Label_DataInicial As Label
    Friend WithEvents LabelTIP_DataInicial As Label
    Friend WithEvents DateTimePicker_BuyDate As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label_DiaDeVencimento As Label
    Friend WithEvents LabelTIP_DiaDeVencimento As Label
    Friend WithEvents TabPage_Values As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label_TotalDaDespesa As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelTIP_TotalDaDespesa As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label_ValorDaParcela As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox_PlotValue As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LabelTIP_ValorDaParcelas As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label_QuantidadeDeParcelas As Label
    Friend WithEvents TextBox_NumberOfPlots As TextBox
    Friend WithEvents LabelTIP_QuantidadeDeParcelas As Label
    Friend WithEvents TabPage_Outhers As TabPage
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label_VinsularDespesa As Label
    Friend WithEvents LabelTIP_VincularDespesa As Label
    Friend WithEvents ComboBox_LinkCard As ComboBox
    Friend WithEvents ComboBox_MaturityDay As ComboBox
    Friend WithEvents STYLE_CalendarImg As PictureBox
    Friend WithEvents STYLE_ValuesImg As PictureBox
    Friend WithEvents STYLE_LinkImg As PictureBox
    Friend WithEvents STYLE_ExpenseImg As PictureBox
    Friend WithEvents TabPage_Custom As TabPage
    Friend WithEvents STYLE_CustomImg As PictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox_HighColorExpense As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox_ExpenseIcon As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage_Interest As TabPage
    Friend WithEvents Panel18 As Panel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel21 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents STYLE_InterestImg As PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TotalOfExpenseLabel As System.Windows.Forms.Label
End Class
