<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoricPaymentItemControl
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.Btn_ShowQuickOptions = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip_QuickOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseItemBackgroundPanel = New System.Windows.Forms.Panel()
        Me.Col02_Panel = New System.Windows.Forms.Panel()
        Me.PlotInformationsPanel = New System.Windows.Forms.Panel()
        Me.PaymentDateLabel = New System.Windows.Forms.Label()
        Me.ExpenseNameLabel = New System.Windows.Forms.Label()
        Me.Col03_Panel = New System.Windows.Forms.Panel()
        Me.PlotValuesPanel = New System.Windows.Forms.Panel()
        Me.PaidValueLabel = New System.Windows.Forms.Label()
        Me.Col01_Panel = New System.Windows.Forms.Panel()
        Me.PlotStatusColorPanel = New System.Windows.Forms.Panel()
        Me.PaymentDayLabel = New System.Windows.Forms.Label()
        CType(Me.Btn_ShowQuickOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip_QuickOptions.SuspendLayout()
        Me.BaseItemBackgroundPanel.SuspendLayout()
        Me.Col02_Panel.SuspendLayout()
        Me.PlotInformationsPanel.SuspendLayout()
        Me.Col03_Panel.SuspendLayout()
        Me.PlotValuesPanel.SuspendLayout()
        Me.Col01_Panel.SuspendLayout()
        Me.PlotStatusColorPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_ShowQuickOptions
        '
        Me.Btn_ShowQuickOptions.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_ShowQuickOptions.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Menu_20x20
        Me.Btn_ShowQuickOptions.Location = New System.Drawing.Point(131, 8)
        Me.Btn_ShowQuickOptions.Name = "Btn_ShowQuickOptions"
        Me.Btn_ShowQuickOptions.Size = New System.Drawing.Size(24, 24)
        Me.Btn_ShowQuickOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_ShowQuickOptions.TabIndex = 65
        Me.Btn_ShowQuickOptions.TabStop = False
        '
        'ContextMenuStrip_QuickOptions
        '
        Me.ContextMenuStrip_QuickOptions.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip_QuickOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip_QuickOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirToolStripMenuItem})
        Me.ContextMenuStrip_QuickOptions.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip_QuickOptions.Size = New System.Drawing.Size(211, 52)
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_DeleteExpense_20x20
        Me.ExcluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ExcluirToolStripMenuItem.Text = "Remover Pagamento"
        '
        'BaseItemBackgroundPanel
        '
        Me.BaseItemBackgroundPanel.BackColor = System.Drawing.Color.White
        Me.BaseItemBackgroundPanel.Controls.Add(Me.Col02_Panel)
        Me.BaseItemBackgroundPanel.Controls.Add(Me.Col03_Panel)
        Me.BaseItemBackgroundPanel.Controls.Add(Me.Col01_Panel)
        Me.BaseItemBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseItemBackgroundPanel.Location = New System.Drawing.Point(5, 5)
        Me.BaseItemBackgroundPanel.Name = "BaseItemBackgroundPanel"
        Me.BaseItemBackgroundPanel.Size = New System.Drawing.Size(565, 60)
        Me.BaseItemBackgroundPanel.TabIndex = 73
        '
        'Col02_Panel
        '
        Me.Col02_Panel.Controls.Add(Me.PlotInformationsPanel)
        Me.Col02_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Col02_Panel.Location = New System.Drawing.Point(55, 0)
        Me.Col02_Panel.Name = "Col02_Panel"
        Me.Col02_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Col02_Panel.Size = New System.Drawing.Size(335, 60)
        Me.Col02_Panel.TabIndex = 66
        '
        'PlotInformationsPanel
        '
        Me.PlotInformationsPanel.Controls.Add(Me.PaymentDateLabel)
        Me.PlotInformationsPanel.Controls.Add(Me.ExpenseNameLabel)
        Me.PlotInformationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotInformationsPanel.Location = New System.Drawing.Point(0, 10)
        Me.PlotInformationsPanel.Name = "PlotInformationsPanel"
        Me.PlotInformationsPanel.Size = New System.Drawing.Size(325, 40)
        Me.PlotInformationsPanel.TabIndex = 0
        '
        'PaymentDateLabel
        '
        Me.PaymentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PaymentDateLabel.AutoSize = True
        Me.PaymentDateLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.PaymentDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PaymentDateLabel.Location = New System.Drawing.Point(0, 22)
        Me.PaymentDateLabel.Name = "PaymentDateLabel"
        Me.PaymentDateLabel.Size = New System.Drawing.Size(81, 15)
        Me.PaymentDateLabel.TabIndex = 58
        Me.PaymentDateLabel.Text = "Março de 2019"
        '
        'ExpenseNameLabel
        '
        Me.ExpenseNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExpenseNameLabel.AutoSize = True
        Me.ExpenseNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ExpenseNameLabel.Location = New System.Drawing.Point(0, 3)
        Me.ExpenseNameLabel.Name = "ExpenseNameLabel"
        Me.ExpenseNameLabel.Size = New System.Drawing.Size(144, 19)
        Me.ExpenseNameLabel.TabIndex = 57
        Me.ExpenseNameLabel.Text = "Pagamento Realizado"
        '
        'Col03_Panel
        '
        Me.Col03_Panel.Controls.Add(Me.PlotValuesPanel)
        Me.Col03_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Col03_Panel.Location = New System.Drawing.Point(390, 0)
        Me.Col03_Panel.Name = "Col03_Panel"
        Me.Col03_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Col03_Panel.Size = New System.Drawing.Size(175, 60)
        Me.Col03_Panel.TabIndex = 65
        '
        'PlotValuesPanel
        '
        Me.PlotValuesPanel.Controls.Add(Me.Btn_ShowQuickOptions)
        Me.PlotValuesPanel.Controls.Add(Me.PaidValueLabel)
        Me.PlotValuesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotValuesPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotValuesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.PlotValuesPanel.Name = "PlotValuesPanel"
        Me.PlotValuesPanel.Size = New System.Drawing.Size(155, 40)
        Me.PlotValuesPanel.TabIndex = 63
        '
        'PaidValueLabel
        '
        Me.PaidValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PaidValueLabel.BackColor = System.Drawing.Color.Black
        Me.PaidValueLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaidValueLabel.ForeColor = System.Drawing.Color.White
        Me.PaidValueLabel.Location = New System.Drawing.Point(4, 4)
        Me.PaidValueLabel.Name = "PaidValueLabel"
        Me.PaidValueLabel.Size = New System.Drawing.Size(120, 32)
        Me.PaidValueLabel.TabIndex = 62
        Me.PaidValueLabel.Text = "R$ 99.999,99"
        Me.PaidValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Col01_Panel
        '
        Me.Col01_Panel.Controls.Add(Me.PlotStatusColorPanel)
        Me.Col01_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Col01_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Col01_Panel.Name = "Col01_Panel"
        Me.Col01_Panel.Padding = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.Col01_Panel.Size = New System.Drawing.Size(55, 60)
        Me.Col01_Panel.TabIndex = 64
        '
        'PlotStatusColorPanel
        '
        Me.PlotStatusColorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.PlotStatusColorPanel.Controls.Add(Me.PaymentDayLabel)
        Me.PlotStatusColorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotStatusColorPanel.ForeColor = System.Drawing.Color.White
        Me.PlotStatusColorPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotStatusColorPanel.Name = "PlotStatusColorPanel"
        Me.PlotStatusColorPanel.Size = New System.Drawing.Size(40, 40)
        Me.PlotStatusColorPanel.TabIndex = 65
        '
        'PaymentDayLabel
        '
        Me.PaymentDayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PaymentDayLabel.AutoSize = True
        Me.PaymentDayLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PaymentDayLabel.Location = New System.Drawing.Point(6, 10)
        Me.PaymentDayLabel.Name = "PaymentDayLabel"
        Me.PaymentDayLabel.Size = New System.Drawing.Size(28, 21)
        Me.PaymentDayLabel.TabIndex = 65
        Me.PaymentDayLabel.Text = "07"
        '
        'HistoricPaymentItemControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BaseItemBackgroundPanel)
        Me.Name = "HistoricPaymentItemControl"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(575, 70)
        CType(Me.Btn_ShowQuickOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip_QuickOptions.ResumeLayout(False)
        Me.BaseItemBackgroundPanel.ResumeLayout(False)
        Me.Col02_Panel.ResumeLayout(False)
        Me.PlotInformationsPanel.ResumeLayout(False)
        Me.PlotInformationsPanel.PerformLayout()
        Me.Col03_Panel.ResumeLayout(False)
        Me.PlotValuesPanel.ResumeLayout(False)
        Me.Col01_Panel.ResumeLayout(False)
        Me.PlotStatusColorPanel.ResumeLayout(False)
        Me.PlotStatusColorPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_ShowQuickOptions As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip_QuickOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseItemBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents Col02_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotInformationsPanel As System.Windows.Forms.Panel
    Friend WithEvents PaymentDateLabel As System.Windows.Forms.Label
    Friend WithEvents ExpenseNameLabel As System.Windows.Forms.Label
    Friend WithEvents Col03_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotValuesPanel As System.Windows.Forms.Panel
    Friend WithEvents PaidValueLabel As System.Windows.Forms.Label
    Friend WithEvents Col01_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotStatusColorPanel As System.Windows.Forms.Panel
    Friend WithEvents PaymentDayLabel As System.Windows.Forms.Label
End Class
