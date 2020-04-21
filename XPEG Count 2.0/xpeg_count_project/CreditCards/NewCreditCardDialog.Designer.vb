<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCreditCardDialog
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
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Label_File = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_CreditCard = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_FinallyNumbers = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CardPreview_Panel = New System.Windows.Forms.Panel()
        Me.CardIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.CardBandeira_Panel = New System.Windows.Forms.Panel()
        Me.CardUserName_Label = New System.Windows.Forms.Label()
        Me.CardNumbes_Label = New System.Windows.Forms.Label()
        Me.CardName_Label = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_UserNamePrintedInCard = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_CardName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage_Dates = New System.Windows.Forms.TabPage()
        Me.STYLE_CalendarImg = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ComboBox_MaturityDay = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox_CloseInvoice = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_StartIn = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Controls_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_CreditCard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CardPreview_Panel.SuspendLayout()
        CType(Me.CardIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage_Dates.SuspendLayout()
        CType(Me.STYLE_CalendarImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DialogOptionsPanel.TabIndex = 85
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
        Me.Button_OK.Location = New System.Drawing.Point(717, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(150, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Adicionar Cartão"
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
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.TabControl1)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Controls_Panel.Size = New System.Drawing.Size(984, 421)
        Me.Controls_Panel.TabIndex = 86
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_CreditCard)
        Me.TabControl1.Controls.Add(Me.TabPage_Dates)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(964, 401)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage_CreditCard
        '
        Me.TabPage_CreditCard.Controls.Add(Me.Panel1)
        Me.TabPage_CreditCard.Controls.Add(Me.CardPreview_Panel)
        Me.TabPage_CreditCard.Controls.Add(Me.Panel6)
        Me.TabPage_CreditCard.Controls.Add(Me.Panel5)
        Me.TabPage_CreditCard.Controls.Add(Me.Panel8)
        Me.TabPage_CreditCard.Location = New System.Drawing.Point(4, 39)
        Me.TabPage_CreditCard.Name = "TabPage_CreditCard"
        Me.TabPage_CreditCard.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CreditCard.Size = New System.Drawing.Size(956, 358)
        Me.TabPage_CreditCard.TabIndex = 2
        Me.TabPage_CreditCard.Text = "Cartão"
        Me.TabPage_CreditCard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TextBox_FinallyNumbers)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(25, 197)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 80)
        Me.Panel1.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(3, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 19)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "&Digitos Finais"
        '
        'TextBox_FinallyNumbers
        '
        Me.TextBox_FinallyNumbers.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_FinallyNumbers.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_FinallyNumbers.MaxLength = 4
        Me.TextBox_FinallyNumbers.Name = "TextBox_FinallyNumbers"
        Me.TextBox_FinallyNumbers.Size = New System.Drawing.Size(350, 25)
        Me.TextBox_FinallyNumbers.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(4, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(480, 15)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Quais os quatro digitos finais do cartão? (Caso não queira informar, apenas coloq" & _
    "ue '0000')"
        '
        'CardPreview_Panel
        '
        Me.CardPreview_Panel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CardPreview_Panel.BackColor = System.Drawing.Color.Black
        Me.CardPreview_Panel.Controls.Add(Me.CardIcon_PictureBox)
        Me.CardPreview_Panel.Controls.Add(Me.CardBandeira_Panel)
        Me.CardPreview_Panel.Controls.Add(Me.CardUserName_Label)
        Me.CardPreview_Panel.Controls.Add(Me.CardNumbes_Label)
        Me.CardPreview_Panel.Controls.Add(Me.CardName_Label)
        Me.CardPreview_Panel.ForeColor = System.Drawing.Color.White
        Me.CardPreview_Panel.Location = New System.Drawing.Point(598, 84)
        Me.CardPreview_Panel.Name = "CardPreview_Panel"
        Me.CardPreview_Panel.Size = New System.Drawing.Size(320, 190)
        Me.CardPreview_Panel.TabIndex = 71
        '
        'CardIcon_PictureBox
        '
        Me.CardIcon_PictureBox.Image = Global.xpeg_count_project.My.Resources.DashboardtIconsResource.Icon_Dashboard_CreditCard_30x30
        Me.CardIcon_PictureBox.Location = New System.Drawing.Point(250, 10)
        Me.CardIcon_PictureBox.Name = "CardIcon_PictureBox"
        Me.CardIcon_PictureBox.Size = New System.Drawing.Size(60, 60)
        Me.CardIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CardIcon_PictureBox.TabIndex = 73
        Me.CardIcon_PictureBox.TabStop = False
        '
        'CardBandeira_Panel
        '
        Me.CardBandeira_Panel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CardBandeira_Panel.BackColor = System.Drawing.Color.White
        Me.CardBandeira_Panel.ForeColor = System.Drawing.Color.White
        Me.CardBandeira_Panel.Location = New System.Drawing.Point(250, 140)
        Me.CardBandeira_Panel.Name = "CardBandeira_Panel"
        Me.CardBandeira_Panel.Size = New System.Drawing.Size(60, 40)
        Me.CardBandeira_Panel.TabIndex = 72
        '
        'CardUserName_Label
        '
        Me.CardUserName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.CardUserName_Label.Location = New System.Drawing.Point(22, 142)
        Me.CardUserName_Label.Name = "CardUserName_Label"
        Me.CardUserName_Label.Size = New System.Drawing.Size(213, 19)
        Me.CardUserName_Label.TabIndex = 60
        Me.CardUserName_Label.Text = "Seu Nome Completo"
        Me.CardUserName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNumbes_Label
        '
        Me.CardNumbes_Label.AutoSize = True
        Me.CardNumbes_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.CardNumbes_Label.Location = New System.Drawing.Point(21, 118)
        Me.CardNumbes_Label.Name = "CardNumbes_Label"
        Me.CardNumbes_Label.Size = New System.Drawing.Size(222, 21)
        Me.CardNumbes_Label.TabIndex = 59
        Me.CardNumbes_Label.Text = "XXXX XXXX XXXX XXXX 0000"
        '
        'CardName_Label
        '
        Me.CardName_Label.AutoSize = True
        Me.CardName_Label.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardName_Label.Location = New System.Drawing.Point(20, 20)
        Me.CardName_Label.Name = "CardName_Label"
        Me.CardName_Label.Size = New System.Drawing.Size(115, 28)
        Me.CardName_Label.TabIndex = 58
        Me.CardName_Label.Text = "Meu Cartão"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TextBox_UserNamePrintedInCard)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(25, 111)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(400, 80)
        Me.Panel6.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 19)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "&Nome Impresso no Cartão"
        '
        'TextBox_UserNamePrintedInCard
        '
        Me.TextBox_UserNamePrintedInCard.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_UserNamePrintedInCard.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_UserNamePrintedInCard.MaxLength = 25
        Me.TextBox_UserNamePrintedInCard.Name = "TextBox_UserNamePrintedInCard"
        Me.TextBox_UserNamePrintedInCard.Size = New System.Drawing.Size(350, 25)
        Me.TextBox_UserNamePrintedInCard.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(4, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(272, 15)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Escreva seu nome (Não precisa ser igual ao cartão)."
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.TextBox_CardName)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(25, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 80)
        Me.Panel5.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "&Nome do Cartão"
        '
        'TextBox_CardName
        '
        Me.TextBox_CardName.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_CardName.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_CardName.MaxLength = 25
        Me.TextBox_CardName.Name = "TextBox_CardName"
        Me.TextBox_CardName.Size = New System.Drawing.Size(350, 25)
        Me.TextBox_CardName.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 15)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Digite o nome do Cartão."
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label16)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Location = New System.Drawing.Point(598, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(320, 80)
        Me.Panel8.TabIndex = 74
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(85, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 19)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "&Personalize seu Cartão"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.Label17.Location = New System.Drawing.Point(50, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(220, 30)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Clique em qualquer elemento dentro do cartão para personaliza-lo."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage_Dates
        '
        Me.TabPage_Dates.Controls.Add(Me.STYLE_CalendarImg)
        Me.TabPage_Dates.Controls.Add(Me.Panel7)
        Me.TabPage_Dates.Controls.Add(Me.Panel3)
        Me.TabPage_Dates.Controls.Add(Me.Panel2)
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
        Me.STYLE_CalendarImg.TabIndex = 76
        Me.STYLE_CalendarImg.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ComboBox_MaturityDay)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Location = New System.Drawing.Point(25, 197)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(400, 80)
        Me.Panel7.TabIndex = 74
        '
        'ComboBox_MaturityDay
        '
        Me.ComboBox_MaturityDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox_MaturityDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_MaturityDay.FormattingEnabled = True
        Me.ComboBox_MaturityDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"})
        Me.ComboBox_MaturityDay.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_MaturityDay.Name = "ComboBox_MaturityDay"
        Me.ComboBox_MaturityDay.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox_MaturityDay.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 19)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "&Dia de Vencimento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(4, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Em qual dia do mês sua fatura vence?"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox_CloseInvoice)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(25, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 80)
        Me.Panel3.TabIndex = 73
        '
        'ComboBox_CloseInvoice
        '
        Me.ComboBox_CloseInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox_CloseInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox_CloseInvoice.FormattingEnabled = True
        Me.ComboBox_CloseInvoice.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"})
        Me.ComboBox_CloseInvoice.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_CloseInvoice.Name = "ComboBox_CloseInvoice"
        Me.ComboBox_CloseInvoice.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox_CloseInvoice.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 19)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "&Fechamento da Fatura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(4, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 15)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Em qual dia do mês sua fatura fecha?"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DateTimePicker_StartIn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(25, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 80)
        Me.Panel2.TabIndex = 72
        '
        'DateTimePicker_StartIn
        '
        Me.DateTimePicker_StartIn.CustomFormat = "MM/yyyy"
        Me.DateTimePicker_StartIn.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_StartIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_StartIn.Location = New System.Drawing.Point(7, 30)
        Me.DateTimePicker_StartIn.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_StartIn.Name = "DateTimePicker_StartIn"
        Me.DateTimePicker_StartIn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker_StartIn.ShowUpDown = True
        Me.DateTimePicker_StartIn.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker_StartIn.TabIndex = 71
        Me.DateTimePicker_StartIn.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "&Começar em"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(355, 15)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "A partir de quando você quer o Count gere as faturas deste cartão?"
        '
        'NewCreditCardDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Controls_Panel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCreditCardDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Cartão de Crédito"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Controls_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_CreditCard.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CardPreview_Panel.ResumeLayout(False)
        Me.CardPreview_Panel.PerformLayout()
        CType(Me.CardIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabPage_Dates.ResumeLayout(False)
        CType(Me.STYLE_CalendarImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DialogOptionsPanel As Panel
    Friend WithEvents Label_File As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_OK As Button
    Friend WithEvents DialogOptionsSeparatorPanel As Panel
    Friend WithEvents Controls_Panel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_CreditCard As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_CardName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage_Dates As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_FinallyNumbers As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CardPreview_Panel As Panel
    Friend WithEvents CardBandeira_Panel As Panel
    Friend WithEvents CardUserName_Label As Label
    Friend WithEvents CardNumbes_Label As Label
    Friend WithEvents CardName_Label As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_UserNamePrintedInCard As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CardIcon_PictureBox As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ComboBox_MaturityDay As ComboBox
    Friend WithEvents ComboBox_CloseInvoice As ComboBox
    Friend WithEvents STYLE_CalendarImg As PictureBox
    Private WithEvents DateTimePicker_StartIn As System.Windows.Forms.DateTimePicker
End Class
