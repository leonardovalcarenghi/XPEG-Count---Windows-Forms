<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayPlotDialog
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
        Me.Panel_Value = New System.Windows.Forms.Panel()
        Me.Label_PlotValue = New System.Windows.Forms.Label()
        Me.Label_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox_Value = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelTIP_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.Panel_Date = New System.Windows.Forms.Panel()
        Me.Label_MaturityDate = New System.Windows.Forms.Label()
        Me.DateTimePicker_PayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_DataDaCompra = New System.Windows.Forms.Label()
        Me.LabelTIP_DataCompra = New System.Windows.Forms.Label()
        Me.Panel_Type = New System.Windows.Forms.Panel()
        Me.Label_ChangeValueWarning = New System.Windows.Forms.Label()
        Me.Label_VinsularDespesa = New System.Windows.Forms.Label()
        Me.LabelTIP_VincularDespesa = New System.Windows.Forms.Label()
        Me.ComboBox_TypePay = New System.Windows.Forms.ComboBox()
        Me.Panel_Comment = New System.Windows.Forms.Panel()
        Me.Label_DescriçãoDaDespesa = New System.Windows.Forms.Label()
        Me.TextBox_PaymentComment = New System.Windows.Forms.TextBox()
        Me.LabelTIP_Desrição = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel_ChangeValue = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_NewValue = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_ActualValue = New System.Windows.Forms.Label()
        Me.Panel_InterestValues = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_DaysInLate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_InteresTaxPerDay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_InterestValue = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel_Value.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_Date.SuspendLayout()
        Me.Panel_Type.SuspendLayout()
        Me.Panel_Comment.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel_ChangeValue.SuspendLayout()
        Me.Panel_InterestValues.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Value
        '
        Me.Panel_Value.Controls.Add(Me.Label_PlotValue)
        Me.Panel_Value.Controls.Add(Me.Label_TotalDaDespesa)
        Me.Panel_Value.Controls.Add(Me.Panel4)
        Me.Panel_Value.Controls.Add(Me.LabelTIP_TotalDaDespesa)
        Me.Panel_Value.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Value.Location = New System.Drawing.Point(30, 30)
        Me.Panel_Value.Name = "Panel_Value"
        Me.Panel_Value.Size = New System.Drawing.Size(521, 80)
        Me.Panel_Value.TabIndex = 72
        '
        'Label_PlotValue
        '
        Me.Label_PlotValue.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label_PlotValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_PlotValue.Location = New System.Drawing.Point(163, 30)
        Me.Label_PlotValue.Name = "Label_PlotValue"
        Me.Label_PlotValue.Size = New System.Drawing.Size(344, 25)
        Me.Label_PlotValue.TabIndex = 61
        Me.Label_PlotValue.Text = "Total: R$ 0,00 / Falta: R$ 0,00"
        Me.Label_PlotValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_TotalDaDespesa
        '
        Me.Label_TotalDaDespesa.AutoSize = True
        Me.Label_TotalDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_TotalDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_TotalDaDespesa.Name = "Label_TotalDaDespesa"
        Me.Label_TotalDaDespesa.Size = New System.Drawing.Size(41, 19)
        Me.Label_TotalDaDespesa.TabIndex = 57
        Me.Label_TotalDaDespesa.Text = "&Valor"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox_Value)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(7, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 25)
        Me.Panel4.TabIndex = 38
        '
        'TextBox_Value
        '
        Me.TextBox_Value.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Value.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_Value.Location = New System.Drawing.Point(26, 0)
        Me.TextBox_Value.MaxLength = 9
        Me.TextBox_Value.Name = "TextBox_Value"
        Me.TextBox_Value.Size = New System.Drawing.Size(124, 25)
        Me.TextBox_Value.TabIndex = 7
        Me.TextBox_Value.Text = "0,00"
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
        Me.LabelTIP_TotalDaDespesa.Size = New System.Drawing.Size(186, 15)
        Me.LabelTIP_TotalDaDespesa.TabIndex = 58
        Me.LabelTIP_TotalDaDespesa.Text = "Quanto você vai pagar na parcela?"
        '
        'Panel_Date
        '
        Me.Panel_Date.Controls.Add(Me.Label_MaturityDate)
        Me.Panel_Date.Controls.Add(Me.DateTimePicker_PayDate)
        Me.Panel_Date.Controls.Add(Me.Label_DataDaCompra)
        Me.Panel_Date.Controls.Add(Me.LabelTIP_DataCompra)
        Me.Panel_Date.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Date.Location = New System.Drawing.Point(30, 110)
        Me.Panel_Date.Name = "Panel_Date"
        Me.Panel_Date.Size = New System.Drawing.Size(521, 80)
        Me.Panel_Date.TabIndex = 73
        '
        'Label_MaturityDate
        '
        Me.Label_MaturityDate.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label_MaturityDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_MaturityDate.Location = New System.Drawing.Point(213, 30)
        Me.Label_MaturityDate.Name = "Label_MaturityDate"
        Me.Label_MaturityDate.Size = New System.Drawing.Size(294, 25)
        Me.Label_MaturityDate.TabIndex = 60
        Me.Label_MaturityDate.Text = "Vencimento: 01/01/2019"
        Me.Label_MaturityDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker_PayDate
        '
        Me.DateTimePicker_PayDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_PayDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_PayDate.Location = New System.Drawing.Point(7, 30)
        Me.DateTimePicker_PayDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_PayDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_PayDate.Name = "DateTimePicker_PayDate"
        Me.DateTimePicker_PayDate.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker_PayDate.TabIndex = 4
        Me.DateTimePicker_PayDate.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label_DataDaCompra
        '
        Me.Label_DataDaCompra.AutoSize = True
        Me.Label_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DataDaCompra.Location = New System.Drawing.Point(3, 5)
        Me.Label_DataDaCompra.Name = "Label_DataDaCompra"
        Me.Label_DataDaCompra.Size = New System.Drawing.Size(132, 19)
        Me.Label_DataDaCompra.TabIndex = 57
        Me.Label_DataDaCompra.Text = "&Data do Pagamento"
        '
        'LabelTIP_DataCompra
        '
        Me.LabelTIP_DataCompra.AutoSize = True
        Me.LabelTIP_DataCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DataCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DataCompra.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DataCompra.Name = "LabelTIP_DataCompra"
        Me.LabelTIP_DataCompra.Size = New System.Drawing.Size(222, 15)
        Me.LabelTIP_DataCompra.TabIndex = 58
        Me.LabelTIP_DataCompra.Text = "Informe a data do pagamento da parcela."
        '
        'Panel_Type
        '
        Me.Panel_Type.Controls.Add(Me.Label_ChangeValueWarning)
        Me.Panel_Type.Controls.Add(Me.Label_VinsularDespesa)
        Me.Panel_Type.Controls.Add(Me.LabelTIP_VincularDespesa)
        Me.Panel_Type.Controls.Add(Me.ComboBox_TypePay)
        Me.Panel_Type.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Type.Location = New System.Drawing.Point(30, 190)
        Me.Panel_Type.Name = "Panel_Type"
        Me.Panel_Type.Size = New System.Drawing.Size(521, 80)
        Me.Panel_Type.TabIndex = 74
        Me.Panel_Type.Visible = False
        '
        'Label_ChangeValueWarning
        '
        Me.Label_ChangeValueWarning.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label_ChangeValueWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_ChangeValueWarning.Location = New System.Drawing.Point(363, 18)
        Me.Label_ChangeValueWarning.Name = "Label_ChangeValueWarning"
        Me.Label_ChangeValueWarning.Size = New System.Drawing.Size(144, 45)
        Me.Label_ChangeValueWarning.TabIndex = 61
        Me.Label_ChangeValueWarning.Text = "O valor pago será igual ao novo valor."
        Me.Label_ChangeValueWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_ChangeValueWarning.Visible = False
        '
        'Label_VinsularDespesa
        '
        Me.Label_VinsularDespesa.AutoSize = True
        Me.Label_VinsularDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_VinsularDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_VinsularDespesa.Name = "Label_VinsularDespesa"
        Me.Label_VinsularDespesa.Size = New System.Drawing.Size(79, 19)
        Me.Label_VinsularDespesa.TabIndex = 57
        Me.Label_VinsularDespesa.Text = "&Pagamento"
        '
        'LabelTIP_VincularDespesa
        '
        Me.LabelTIP_VincularDespesa.AutoSize = True
        Me.LabelTIP_VincularDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_VincularDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_VincularDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_VincularDespesa.Name = "LabelTIP_VincularDespesa"
        Me.LabelTIP_VincularDespesa.Size = New System.Drawing.Size(295, 15)
        Me.LabelTIP_VincularDespesa.TabIndex = 58
        Me.LabelTIP_VincularDespesa.Text = "Informe o tipo de pagamento que você está efetuando."
        '
        'ComboBox_TypePay
        '
        Me.ComboBox_TypePay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_TypePay.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox_TypePay.FormattingEnabled = True
        Me.ComboBox_TypePay.Items.AddRange(New Object() {"Valor Total"})
        Me.ComboBox_TypePay.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_TypePay.Name = "ComboBox_TypePay"
        Me.ComboBox_TypePay.Size = New System.Drawing.Size(350, 25)
        Me.ComboBox_TypePay.TabIndex = 13
        '
        'Panel_Comment
        '
        Me.Panel_Comment.Controls.Add(Me.Label_DescriçãoDaDespesa)
        Me.Panel_Comment.Controls.Add(Me.TextBox_PaymentComment)
        Me.Panel_Comment.Controls.Add(Me.LabelTIP_Desrição)
        Me.Panel_Comment.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Comment.Location = New System.Drawing.Point(30, 270)
        Me.Panel_Comment.Name = "Panel_Comment"
        Me.Panel_Comment.Size = New System.Drawing.Size(521, 80)
        Me.Panel_Comment.TabIndex = 75
        Me.Panel_Comment.Visible = False
        '
        'Label_DescriçãoDaDespesa
        '
        Me.Label_DescriçãoDaDespesa.AutoSize = True
        Me.Label_DescriçãoDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DescriçãoDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_DescriçãoDaDespesa.Name = "Label_DescriçãoDaDespesa"
        Me.Label_DescriçãoDaDespesa.Size = New System.Drawing.Size(82, 19)
        Me.Label_DescriçãoDaDespesa.TabIndex = 57
        Me.Label_DescriçãoDaDespesa.Text = "&Comentário"
        '
        'TextBox_PaymentComment
        '
        Me.TextBox_PaymentComment.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_PaymentComment.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_PaymentComment.MaxLength = 200
        Me.TextBox_PaymentComment.Name = "TextBox_PaymentComment"
        Me.TextBox_PaymentComment.Size = New System.Drawing.Size(500, 25)
        Me.TextBox_PaymentComment.TabIndex = 2
        '
        'LabelTIP_Desrição
        '
        Me.LabelTIP_Desrição.AutoSize = True
        Me.LabelTIP_Desrição.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_Desrição.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_Desrição.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_Desrição.Name = "LabelTIP_Desrição"
        Me.LabelTIP_Desrição.Size = New System.Drawing.Size(267, 15)
        Me.LabelTIP_Desrição.TabIndex = 58
        Me.LabelTIP_Desrição.Text = "Escreva um breve comentário sobre o pagamento."
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.AutoScrollMargin = New System.Drawing.Size(30, 10)
        Me.Panel5.Controls.Add(Me.Panel_ChangeValue)
        Me.Panel5.Controls.Add(Me.Panel_InterestValues)
        Me.Panel5.Controls.Add(Me.Panel_Comment)
        Me.Panel5.Controls.Add(Me.Panel_Type)
        Me.Panel5.Controls.Add(Me.Panel_Date)
        Me.Panel5.Controls.Add(Me.Panel_Value)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel5.Size = New System.Drawing.Size(598, 229)
        Me.Panel5.TabIndex = 89
        '
        'Panel_ChangeValue
        '
        Me.Panel_ChangeValue.Controls.Add(Me.Panel8)
        Me.Panel_ChangeValue.Controls.Add(Me.Label6)
        Me.Panel_ChangeValue.Controls.Add(Me.Label_NewValue)
        Me.Panel_ChangeValue.Controls.Add(Me.Label8)
        Me.Panel_ChangeValue.Controls.Add(Me.Label_ActualValue)
        Me.Panel_ChangeValue.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ChangeValue.Location = New System.Drawing.Point(30, 430)
        Me.Panel_ChangeValue.Name = "Panel_ChangeValue"
        Me.Panel_ChangeValue.Size = New System.Drawing.Size(521, 60)
        Me.Panel_ChangeValue.TabIndex = 77
        Me.Panel_ChangeValue.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(521, 1)
        Me.Panel8.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Novo Valor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_NewValue
        '
        Me.Label_NewValue.AutoSize = True
        Me.Label_NewValue.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_NewValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_NewValue.Location = New System.Drawing.Point(82, 36)
        Me.Label_NewValue.Name = "Label_NewValue"
        Me.Label_NewValue.Size = New System.Drawing.Size(44, 15)
        Me.Label_NewValue.TabIndex = 63
        Me.Label_NewValue.Text = "R$ 0,00"
        Me.Label_NewValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(3, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Valor Atual:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_ActualValue
        '
        Me.Label_ActualValue.AutoSize = True
        Me.Label_ActualValue.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_ActualValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_ActualValue.Location = New System.Drawing.Point(81, 12)
        Me.Label_ActualValue.Name = "Label_ActualValue"
        Me.Label_ActualValue.Size = New System.Drawing.Size(44, 15)
        Me.Label_ActualValue.TabIndex = 60
        Me.Label_ActualValue.Text = "R$ 0,00"
        Me.Label_ActualValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_InterestValues
        '
        Me.Panel_InterestValues.Controls.Add(Me.Panel6)
        Me.Panel_InterestValues.Controls.Add(Me.Label2)
        Me.Panel_InterestValues.Controls.Add(Me.Label_DaysInLate)
        Me.Panel_InterestValues.Controls.Add(Me.Label5)
        Me.Panel_InterestValues.Controls.Add(Me.Label_InteresTaxPerDay)
        Me.Panel_InterestValues.Controls.Add(Me.Label3)
        Me.Panel_InterestValues.Controls.Add(Me.Label_InterestValue)
        Me.Panel_InterestValues.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_InterestValues.Location = New System.Drawing.Point(30, 350)
        Me.Panel_InterestValues.Name = "Panel_InterestValues"
        Me.Panel_InterestValues.Size = New System.Drawing.Size(521, 80)
        Me.Panel_InterestValues.TabIndex = 76
        Me.Panel_InterestValues.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(521, 1)
        Me.Panel6.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Dias em Atraso:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_DaysInLate
        '
        Me.Label_DaysInLate.AutoSize = True
        Me.Label_DaysInLate.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_DaysInLate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_DaysInLate.Location = New System.Drawing.Point(106, 58)
        Me.Label_DaysInLate.Name = "Label_DaysInLate"
        Me.Label_DaysInLate.Size = New System.Drawing.Size(38, 15)
        Me.Label_DaysInLate.TabIndex = 65
        Me.Label_DaysInLate.Text = "0 Dias"
        Me.Label_DaysInLate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(3, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Taxa ao dia:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_InteresTaxPerDay
        '
        Me.Label_InteresTaxPerDay.AutoSize = True
        Me.Label_InteresTaxPerDay.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_InteresTaxPerDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_InteresTaxPerDay.Location = New System.Drawing.Point(82, 34)
        Me.Label_InteresTaxPerDay.Name = "Label_InteresTaxPerDay"
        Me.Label_InteresTaxPerDay.Size = New System.Drawing.Size(23, 15)
        Me.Label_InteresTaxPerDay.TabIndex = 63
        Me.Label_InteresTaxPerDay.Text = "0%"
        Me.Label_InteresTaxPerDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Juros:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_InterestValue
        '
        Me.Label_InterestValue.AutoSize = True
        Me.Label_InterestValue.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label_InterestValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_InterestValue.Location = New System.Drawing.Point(45, 10)
        Me.Label_InterestValue.Name = "Label_InterestValue"
        Me.Label_InterestValue.Size = New System.Drawing.Size(44, 15)
        Me.Label_InterestValue.TabIndex = 60
        Me.Label_InterestValue.Text = "R$ 0,00"
        Me.Label_InterestValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.BackButton)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.PayButton)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 230)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(598, 40)
        Me.DialogOptionsPanel.TabIndex = 90
        '
        'BackButton
        '
        Me.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.BackButton.Location = New System.Drawing.Point(275, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(100, 30)
        Me.BackButton.TabIndex = 74
        Me.BackButton.Text = "&Voltar"
        Me.BackButton.UseVisualStyleBackColor = True
        Me.BackButton.Visible = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(487, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'PayButton
        '
        Me.PayButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PayButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.PayButton.Location = New System.Drawing.Point(381, 5)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(100, 30)
        Me.PayButton.TabIndex = 72
        Me.PayButton.Text = "&Próximo"
        Me.PayButton.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(598, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 269)
        Me.Panel1.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(599, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel3.Size = New System.Drawing.Size(1, 269)
        Me.Panel3.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 1)
        Me.Panel2.TabIndex = 86
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(600, 1)
        Me.Panel7.TabIndex = 85
        '
        'PayPlotDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 271)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayPlotDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pagar Parcelar"
        Me.Panel_Value.ResumeLayout(False)
        Me.Panel_Value.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel_Date.ResumeLayout(False)
        Me.Panel_Date.PerformLayout()
        Me.Panel_Type.ResumeLayout(False)
        Me.Panel_Type.PerformLayout()
        Me.Panel_Comment.ResumeLayout(False)
        Me.Panel_Comment.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel_ChangeValue.ResumeLayout(False)
        Me.Panel_ChangeValue.PerformLayout()
        Me.Panel_InterestValues.ResumeLayout(False)
        Me.Panel_InterestValues.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_Value As Panel
    Friend WithEvents Label_TotalDaDespesa As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox_Value As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LabelTIP_TotalDaDespesa As Label
    Friend WithEvents Panel_Date As Panel
    Friend WithEvents DateTimePicker_PayDate As DateTimePicker
    Friend WithEvents Label_DataDaCompra As Label
    Friend WithEvents LabelTIP_DataCompra As Label
    Friend WithEvents Panel_Type As Panel
    Friend WithEvents Label_VinsularDespesa As Label
    Friend WithEvents LabelTIP_VincularDespesa As Label
    Friend WithEvents ComboBox_TypePay As ComboBox
    Friend WithEvents Panel_Comment As Panel
    Friend WithEvents Label_DescriçãoDaDespesa As Label
    Friend WithEvents TextBox_PaymentComment As TextBox
    Friend WithEvents LabelTIP_Desrição As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DialogOptionsPanel As Panel
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents PayButton As Button
    Friend WithEvents DialogOptionsSeparatorPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel_ChangeValue As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_NewValue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_ActualValue As Label
    Friend WithEvents Panel_InterestValues As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_DaysInLate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_InteresTaxPerDay As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_InterestValue As Label
    Friend WithEvents Label_MaturityDate As Label
    Friend WithEvents Label_PlotValue As Label
    Friend WithEvents Label_ChangeValueWarning As Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
