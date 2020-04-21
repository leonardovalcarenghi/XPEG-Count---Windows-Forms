<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsCountDialog
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
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GeneralSettings_TabPage = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label_VinsularDespesa = New System.Windows.Forms.Label()
        Me.LabelTIP_VincularDespesa = New System.Windows.Forms.Label()
        Me.ComboBox_ConfirmClosing = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox_AutoTabInCalendar = New System.Windows.Forms.ComboBox()
        Me.ExpensesSettings_TabPage = New System.Windows.Forms.TabPage()
        Me.IconesSettings_TabPage = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LanguageSettings_TabPage = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox_ChangeStatusInXDaysBefore = New System.Windows.Forms.ComboBox()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Controls_Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GeneralSettings_TabPage.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ExpensesSettings_TabPage.SuspendLayout()
        Me.IconesSettings_TabPage.SuspendLayout()
        Me.LanguageSettings_TabPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(873, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Fechar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 471)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(984, 40)
        Me.DialogOptionsPanel.TabIndex = 83
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.TabControl1)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Controls_Panel.Size = New System.Drawing.Size(984, 471)
        Me.Controls_Panel.TabIndex = 85
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.GeneralSettings_TabPage)
        Me.TabControl1.Controls.Add(Me.ExpensesSettings_TabPage)
        Me.TabControl1.Controls.Add(Me.IconesSettings_TabPage)
        Me.TabControl1.Controls.Add(Me.LanguageSettings_TabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 10)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(964, 451)
        Me.TabControl1.TabIndex = 5
        '
        'GeneralSettings_TabPage
        '
        Me.GeneralSettings_TabPage.Controls.Add(Me.Panel1)
        Me.GeneralSettings_TabPage.Controls.Add(Me.Panel12)
        Me.GeneralSettings_TabPage.Controls.Add(Me.Panel3)
        Me.GeneralSettings_TabPage.Controls.Add(Me.Panel2)
        Me.GeneralSettings_TabPage.Location = New System.Drawing.Point(4, 39)
        Me.GeneralSettings_TabPage.Name = "GeneralSettings_TabPage"
        Me.GeneralSettings_TabPage.Padding = New System.Windows.Forms.Padding(25)
        Me.GeneralSettings_TabPage.Size = New System.Drawing.Size(956, 408)
        Me.GeneralSettings_TabPage.TabIndex = 5
        Me.GeneralSettings_TabPage.Text = "Software"
        Me.GeneralSettings_TabPage.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(25, 195)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 10)
        Me.Panel1.TabIndex = 72
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label_VinsularDespesa)
        Me.Panel12.Controls.Add(Me.LabelTIP_VincularDespesa)
        Me.Panel12.Controls.Add(Me.ComboBox_ConfirmClosing)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(25, 115)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(906, 80)
        Me.Panel12.TabIndex = 71
        '
        'Label_VinsularDespesa
        '
        Me.Label_VinsularDespesa.AutoSize = True
        Me.Label_VinsularDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_VinsularDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_VinsularDespesa.Name = "Label_VinsularDespesa"
        Me.Label_VinsularDespesa.Size = New System.Drawing.Size(110, 19)
        Me.Label_VinsularDespesa.TabIndex = 57
        Me.Label_VinsularDespesa.Text = "&Confirmar Saída"
        '
        'LabelTIP_VincularDespesa
        '
        Me.LabelTIP_VincularDespesa.AutoSize = True
        Me.LabelTIP_VincularDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_VincularDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_VincularDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_VincularDespesa.Name = "LabelTIP_VincularDespesa"
        Me.LabelTIP_VincularDespesa.Size = New System.Drawing.Size(193, 15)
        Me.LabelTIP_VincularDespesa.TabIndex = 58
        Me.LabelTIP_VincularDespesa.Text = "Confirmar fechamento do software?"
        '
        'ComboBox_ConfirmClosing
        '
        Me.ComboBox_ConfirmClosing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ConfirmClosing.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox_ConfirmClosing.FormattingEnabled = True
        Me.ComboBox_ConfirmClosing.Items.AddRange(New Object() {"Não", "Sim"})
        Me.ComboBox_ConfirmClosing.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_ConfirmClosing.Name = "ComboBox_ConfirmClosing"
        Me.ComboBox_ConfirmClosing.Size = New System.Drawing.Size(200, 25)
        Me.ComboBox_ConfirmClosing.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(25, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(906, 10)
        Me.Panel3.TabIndex = 74
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.ComboBox_AutoTabInCalendar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(25, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 80)
        Me.Panel2.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "&Selecionar Mês e Ano Atual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(4, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(314, 15)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "[Modo Calendário] Selecionar ao iniciar o mês e ano atuais."
        '
        'ComboBox_AutoTabInCalendar
        '
        Me.ComboBox_AutoTabInCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_AutoTabInCalendar.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox_AutoTabInCalendar.FormattingEnabled = True
        Me.ComboBox_AutoTabInCalendar.Items.AddRange(New Object() {"Desativado", "Selecionar Guia Atual"})
        Me.ComboBox_AutoTabInCalendar.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_AutoTabInCalendar.Name = "ComboBox_AutoTabInCalendar"
        Me.ComboBox_AutoTabInCalendar.Size = New System.Drawing.Size(286, 25)
        Me.ComboBox_AutoTabInCalendar.TabIndex = 13
        '
        'ExpensesSettings_TabPage
        '
        Me.ExpensesSettings_TabPage.Controls.Add(Me.Panel4)
        Me.ExpensesSettings_TabPage.Location = New System.Drawing.Point(4, 39)
        Me.ExpensesSettings_TabPage.Name = "ExpensesSettings_TabPage"
        Me.ExpensesSettings_TabPage.Padding = New System.Windows.Forms.Padding(25)
        Me.ExpensesSettings_TabPage.Size = New System.Drawing.Size(956, 408)
        Me.ExpensesSettings_TabPage.TabIndex = 8
        Me.ExpensesSettings_TabPage.Text = "Despesas"
        Me.ExpensesSettings_TabPage.UseVisualStyleBackColor = True
        '
        'IconesSettings_TabPage
        '
        Me.IconesSettings_TabPage.Controls.Add(Me.Button2)
        Me.IconesSettings_TabPage.Controls.Add(Me.Button1)
        Me.IconesSettings_TabPage.Controls.Add(Me.ComboBox2)
        Me.IconesSettings_TabPage.Controls.Add(Me.Label5)
        Me.IconesSettings_TabPage.Controls.Add(Me.Label6)
        Me.IconesSettings_TabPage.Controls.Add(Me.Label7)
        Me.IconesSettings_TabPage.Controls.Add(Me.Label8)
        Me.IconesSettings_TabPage.Location = New System.Drawing.Point(4, 39)
        Me.IconesSettings_TabPage.Name = "IconesSettings_TabPage"
        Me.IconesSettings_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.IconesSettings_TabPage.Size = New System.Drawing.Size(956, 408)
        Me.IconesSettings_TabPage.TabIndex = 6
        Me.IconesSettings_TabPage.Text = "Icones"
        Me.IconesSettings_TabPage.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(265, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Remover Tudo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(29, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Atualizar Biblioteca de Icones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Novo Icone..."})
        Me.ComboBox2.Location = New System.Drawing.Point(29, 130)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(300, 25)
        Me.ComboBox2.TabIndex = 27
        Me.ComboBox2.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(25, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(388, 38)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Amplie sua imaginação e a personalização do XPEG Count. Importe seus próprios ico" & _
    "nes para o Count."
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(25, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Meus Icones"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(25, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 38)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Agora os icones são atualizados automáticamente assim que casa atualização é efet" & _
    "uada."
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(25, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Lista de Icones"
        '
        'LanguageSettings_TabPage
        '
        Me.LanguageSettings_TabPage.Controls.Add(Me.Label3)
        Me.LanguageSettings_TabPage.Location = New System.Drawing.Point(4, 39)
        Me.LanguageSettings_TabPage.Name = "LanguageSettings_TabPage"
        Me.LanguageSettings_TabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LanguageSettings_TabPage.Size = New System.Drawing.Size(956, 408)
        Me.LanguageSettings_TabPage.TabIndex = 7
        Me.LanguageSettings_TabPage.Text = "Idiomas"
        Me.LanguageSettings_TabPage.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Configurações de Idiomas não disponível nessa versão..."
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.ComboBox_ChangeStatusInXDaysBefore)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(25, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(906, 80)
        Me.Panel4.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 19)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "&Alteração de Status p/ ""Aguardando Pagamento"" em"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Mudar Status em quantos dias antes de vencer a parcela?"
        '
        'ComboBox_ChangeStatusInXDaysBefore
        '
        Me.ComboBox_ChangeStatusInXDaysBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ChangeStatusInXDaysBefore.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox_ChangeStatusInXDaysBefore.FormattingEnabled = True
        Me.ComboBox_ChangeStatusInXDaysBefore.Items.AddRange(New Object() {"Um dia antes", "2 dias antes", "3 dias antes", "4 dias antes", "5 dias antes", "6 dias antes", "1 Semana antes"})
        Me.ComboBox_ChangeStatusInXDaysBefore.Location = New System.Drawing.Point(7, 30)
        Me.ComboBox_ChangeStatusInXDaysBefore.Name = "ComboBox_ChangeStatusInXDaysBefore"
        Me.ComboBox_ChangeStatusInXDaysBefore.Size = New System.Drawing.Size(380, 25)
        Me.ComboBox_ChangeStatusInXDaysBefore.TabIndex = 13
        '
        'SettingsCountDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 511)
        Me.Controls.Add(Me.Controls_Panel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsCountDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configurações"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Controls_Panel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.GeneralSettings_TabPage.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ExpensesSettings_TabPage.ResumeLayout(False)
        Me.IconesSettings_TabPage.ResumeLayout(False)
        Me.IconesSettings_TabPage.PerformLayout()
        Me.LanguageSettings_TabPage.ResumeLayout(False)
        Me.LanguageSettings_TabPage.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Controls_Panel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents GeneralSettings_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents ExpensesSettings_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents IconesSettings_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LanguageSettings_TabPage As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label_VinsularDespesa As System.Windows.Forms.Label
    Friend WithEvents LabelTIP_VincularDespesa As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ConfirmClosing As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_AutoTabInCalendar As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ChangeStatusInXDaysBefore As System.Windows.Forms.ComboBox

End Class
