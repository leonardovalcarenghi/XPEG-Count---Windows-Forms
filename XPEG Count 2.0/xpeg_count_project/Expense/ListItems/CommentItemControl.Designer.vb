<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommentItemControl
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
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
        Me.ContextMenuStrip_QuickOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DescriçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseItemBackgroundPanel = New System.Windows.Forms.Panel()
        Me.Col02_Panel = New System.Windows.Forms.Panel()
        Me.PlotInformationsPanel = New System.Windows.Forms.Panel()
        Me.CommentTextLabel = New System.Windows.Forms.Label()
        Me.CommentTitleLabel = New System.Windows.Forms.Label()
        Me.Col03_Panel = New System.Windows.Forms.Panel()
        Me.PlotValuesPanel = New System.Windows.Forms.Panel()
        Me.Btn_ShowQuickOptions = New System.Windows.Forms.PictureBox()
        Me.CommentDateLabel = New System.Windows.Forms.Label()
        Me.Col01_Panel = New System.Windows.Forms.Panel()
        Me.PlotStatusColorPanel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip_QuickOptions.SuspendLayout()
        Me.BaseItemBackgroundPanel.SuspendLayout()
        Me.Col02_Panel.SuspendLayout()
        Me.PlotInformationsPanel.SuspendLayout()
        Me.Col03_Panel.SuspendLayout()
        Me.PlotValuesPanel.SuspendLayout()
        CType(Me.Btn_ShowQuickOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Col01_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip_QuickOptions
        '
        Me.ContextMenuStrip_QuickOptions.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ContextMenuStrip_QuickOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip_QuickOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescriçãoToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.ContextMenuStrip_QuickOptions.Name = "ContextMenuStrip_QuickOptions"
        Me.ContextMenuStrip_QuickOptions.Size = New System.Drawing.Size(157, 78)
        '
        'DescriçãoToolStripMenuItem
        '
        Me.DescriçãoToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Comments_20x20
        Me.DescriçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DescriçãoToolStripMenuItem.Name = "DescriçãoToolStripMenuItem"
        Me.DescriçãoToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.DescriçãoToolStripMenuItem.Text = "Editar"
        Me.DescriçãoToolStripMenuItem.Visible = False
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_DeleteExpense_20x20
        Me.ExcluirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
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
        Me.BaseItemBackgroundPanel.Size = New System.Drawing.Size(590, 60)
        Me.BaseItemBackgroundPanel.TabIndex = 74
        '
        'Col02_Panel
        '
        Me.Col02_Panel.Controls.Add(Me.PlotInformationsPanel)
        Me.Col02_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Col02_Panel.Location = New System.Drawing.Point(23, 0)
        Me.Col02_Panel.Name = "Col02_Panel"
        Me.Col02_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Col02_Panel.Size = New System.Drawing.Size(392, 60)
        Me.Col02_Panel.TabIndex = 66
        '
        'PlotInformationsPanel
        '
        Me.PlotInformationsPanel.Controls.Add(Me.CommentTextLabel)
        Me.PlotInformationsPanel.Controls.Add(Me.CommentTitleLabel)
        Me.PlotInformationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotInformationsPanel.Location = New System.Drawing.Point(0, 10)
        Me.PlotInformationsPanel.Name = "PlotInformationsPanel"
        Me.PlotInformationsPanel.Size = New System.Drawing.Size(382, 40)
        Me.PlotInformationsPanel.TabIndex = 0
        '
        'CommentTextLabel
        '
        Me.CommentTextLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommentTextLabel.AutoEllipsis = True
        Me.CommentTextLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.CommentTextLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.CommentTextLabel.Location = New System.Drawing.Point(0, 22)
        Me.CommentTextLabel.Name = "CommentTextLabel"
        Me.CommentTextLabel.Size = New System.Drawing.Size(379, 15)
        Me.CommentTextLabel.TabIndex = 58
        Me.CommentTextLabel.Text = "Isto é um teste de comentário para testar apenas a responsividade deste elmento e" & _
    " para dizer que ta ficando fodah essa versão do Count. Cada dia que passa eu me " & _
    "supero mais na interface."
        '
        'CommentTitleLabel
        '
        Me.CommentTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CommentTitleLabel.AutoSize = True
        Me.CommentTitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CommentTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.CommentTitleLabel.Location = New System.Drawing.Point(0, 3)
        Me.CommentTitleLabel.Name = "CommentTitleLabel"
        Me.CommentTitleLabel.Size = New System.Drawing.Size(143, 19)
        Me.CommentTitleLabel.TabIndex = 57
        Me.CommentTitleLabel.Text = "Título do Comentário"
        '
        'Col03_Panel
        '
        Me.Col03_Panel.Controls.Add(Me.PlotValuesPanel)
        Me.Col03_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Col03_Panel.Location = New System.Drawing.Point(415, 0)
        Me.Col03_Panel.Name = "Col03_Panel"
        Me.Col03_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Col03_Panel.Size = New System.Drawing.Size(175, 60)
        Me.Col03_Panel.TabIndex = 65
        '
        'PlotValuesPanel
        '
        Me.PlotValuesPanel.Controls.Add(Me.Btn_ShowQuickOptions)
        Me.PlotValuesPanel.Controls.Add(Me.CommentDateLabel)
        Me.PlotValuesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotValuesPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotValuesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.PlotValuesPanel.Name = "PlotValuesPanel"
        Me.PlotValuesPanel.Size = New System.Drawing.Size(155, 40)
        Me.PlotValuesPanel.TabIndex = 63
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
        'CommentDateLabel
        '
        Me.CommentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CommentDateLabel.BackColor = System.Drawing.Color.Black
        Me.CommentDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentDateLabel.ForeColor = System.Drawing.Color.White
        Me.CommentDateLabel.Location = New System.Drawing.Point(4, 4)
        Me.CommentDateLabel.Name = "CommentDateLabel"
        Me.CommentDateLabel.Size = New System.Drawing.Size(120, 32)
        Me.CommentDateLabel.TabIndex = 62
        Me.CommentDateLabel.Text = "07/04/2019"
        Me.CommentDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Col01_Panel
        '
        Me.Col01_Panel.Controls.Add(Me.PlotStatusColorPanel)
        Me.Col01_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Col01_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Col01_Panel.Name = "Col01_Panel"
        Me.Col01_Panel.Padding = New System.Windows.Forms.Padding(10, 10, 5, 10)
        Me.Col01_Panel.Size = New System.Drawing.Size(23, 60)
        Me.Col01_Panel.TabIndex = 64
        '
        'PlotStatusColorPanel
        '
        Me.PlotStatusColorPanel.BackColor = System.Drawing.Color.DarkBlue
        Me.PlotStatusColorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotStatusColorPanel.ForeColor = System.Drawing.Color.White
        Me.PlotStatusColorPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotStatusColorPanel.Name = "PlotStatusColorPanel"
        Me.PlotStatusColorPanel.Size = New System.Drawing.Size(8, 40)
        Me.PlotStatusColorPanel.TabIndex = 65
        '
        'CommentItemControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BaseItemBackgroundPanel)
        Me.Name = "CommentItemControl"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(600, 70)
        Me.ContextMenuStrip_QuickOptions.ResumeLayout(False)
        Me.BaseItemBackgroundPanel.ResumeLayout(False)
        Me.Col02_Panel.ResumeLayout(False)
        Me.PlotInformationsPanel.ResumeLayout(False)
        Me.PlotInformationsPanel.PerformLayout()
        Me.Col03_Panel.ResumeLayout(False)
        Me.PlotValuesPanel.ResumeLayout(False)
        CType(Me.Btn_ShowQuickOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Col01_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_ShowQuickOptions As System.Windows.Forms.PictureBox
    Friend WithEvents ContextMenuStrip_QuickOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DescriçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseItemBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents Col02_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotInformationsPanel As System.Windows.Forms.Panel
    Friend WithEvents CommentTextLabel As System.Windows.Forms.Label
    Friend WithEvents CommentTitleLabel As System.Windows.Forms.Label
    Friend WithEvents Col03_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotValuesPanel As System.Windows.Forms.Panel
    Friend WithEvents CommentDateLabel As System.Windows.Forms.Label
    Friend WithEvents Col01_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotStatusColorPanel As System.Windows.Forms.Panel

End Class
