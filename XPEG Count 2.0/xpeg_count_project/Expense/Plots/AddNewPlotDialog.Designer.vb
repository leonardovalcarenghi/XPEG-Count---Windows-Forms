<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewPlotDialog
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.NewPlotMaturityDate_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label_DataDaCompra = New System.Windows.Forms.Label()
        Me.LabelTIP_DataCompra = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.NewPlotValue_TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LabelTIP_TotalDaDespesa = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel5.Size = New System.Drawing.Size(598, 218)
        Me.Panel5.TabIndex = 92
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.NewPlotMaturityDate_DateTimePicker)
        Me.Panel6.Controls.Add(Me.Label_DataDaCompra)
        Me.Panel6.Controls.Add(Me.LabelTIP_DataCompra)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(30, 110)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(538, 80)
        Me.Panel6.TabIndex = 71
        '
        'NewPlotMaturityDate_DateTimePicker
        '
        Me.NewPlotMaturityDate_DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.NewPlotMaturityDate_DateTimePicker.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.NewPlotMaturityDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.NewPlotMaturityDate_DateTimePicker.Location = New System.Drawing.Point(7, 30)
        Me.NewPlotMaturityDate_DateTimePicker.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.NewPlotMaturityDate_DateTimePicker.Name = "NewPlotMaturityDate_DateTimePicker"
        Me.NewPlotMaturityDate_DateTimePicker.Size = New System.Drawing.Size(200, 25)
        Me.NewPlotMaturityDate_DateTimePicker.TabIndex = 4
        Me.NewPlotMaturityDate_DateTimePicker.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label_DataDaCompra
        '
        Me.Label_DataDaCompra.AutoSize = True
        Me.Label_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DataDaCompra.Location = New System.Drawing.Point(3, 5)
        Me.Label_DataDaCompra.Name = "Label_DataDaCompra"
        Me.Label_DataDaCompra.Size = New System.Drawing.Size(127, 19)
        Me.Label_DataDaCompra.TabIndex = 57
        Me.Label_DataDaCompra.Text = "&Dia de Vencimento"
        '
        'LabelTIP_DataCompra
        '
        Me.LabelTIP_DataCompra.AutoSize = True
        Me.LabelTIP_DataCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DataCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DataCompra.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DataCompra.Name = "LabelTIP_DataCompra"
        Me.LabelTIP_DataCompra.Size = New System.Drawing.Size(238, 15)
        Me.LabelTIP_DataCompra.TabIndex = 58
        Me.LabelTIP_DataCompra.Text = "Informe a data de vencimento dessa parcela."
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label_TotalDaDespesa)
        Me.Panel8.Controls.Add(Me.Panel7)
        Me.Panel8.Controls.Add(Me.LabelTIP_TotalDaDespesa)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(30, 30)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(538, 80)
        Me.Panel8.TabIndex = 72
        '
        'Label_TotalDaDespesa
        '
        Me.Label_TotalDaDespesa.AutoSize = True
        Me.Label_TotalDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_TotalDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_TotalDaDespesa.Name = "Label_TotalDaDespesa"
        Me.Label_TotalDaDespesa.Size = New System.Drawing.Size(109, 19)
        Me.Label_TotalDaDespesa.TabIndex = 57
        Me.Label_TotalDaDespesa.Text = "&Valor da Parcela"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.NewPlotValue_TextBox)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Location = New System.Drawing.Point(7, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(150, 25)
        Me.Panel7.TabIndex = 38
        '
        'NewPlotValue_TextBox
        '
        Me.NewPlotValue_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewPlotValue_TextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.NewPlotValue_TextBox.Location = New System.Drawing.Point(26, 0)
        Me.NewPlotValue_TextBox.MaxLength = 9
        Me.NewPlotValue_TextBox.Name = "NewPlotValue_TextBox"
        Me.NewPlotValue_TextBox.Size = New System.Drawing.Size(124, 25)
        Me.NewPlotValue_TextBox.TabIndex = 7
        Me.NewPlotValue_TextBox.Text = "0,00"
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
        Me.LabelTIP_TotalDaDespesa.Size = New System.Drawing.Size(161, 15)
        Me.LabelTIP_TotalDaDespesa.TabIndex = 58
        Me.LabelTIP_TotalDaDespesa.Text = "Qual o valor da nova parcela?"
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.ButtonCreate)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 219)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(598, 40)
        Me.DialogOptionsPanel.TabIndex = 93
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.ButtonCreate.Location = New System.Drawing.Point(336, 5)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(145, 30)
        Me.ButtonCreate.TabIndex = 74
        Me.ButtonCreate.Text = "&Adicionar Parcela"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(487, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 258)
        Me.Panel4.TabIndex = 91
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(599, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 258)
        Me.Panel3.TabIndex = 90
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 1)
        Me.Panel2.TabIndex = 89
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 1)
        Me.Panel1.TabIndex = 88
        '
        'AddNewPlotDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 260)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewPlotDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar Parcela"
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents ButtonCreate As System.Windows.Forms.Button
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents NewPlotMaturityDate_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_DataDaCompra As System.Windows.Forms.Label
    Friend WithEvents LabelTIP_DataCompra As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label_TotalDaDespesa As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents NewPlotValue_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LabelTIP_TotalDaDespesa As System.Windows.Forms.Label

End Class
