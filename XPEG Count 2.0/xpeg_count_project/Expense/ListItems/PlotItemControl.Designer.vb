<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlotItemControl
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
        Me.PlotValuesPanel = New System.Windows.Forms.Panel()
        Me.PlotValuePaidLabel = New System.Windows.Forms.Label()
        Me.PlotValueLabel = New System.Windows.Forms.Label()
        Me.PlotDateLabel = New System.Windows.Forms.Label()
        Me.PlotStatusLabel = New System.Windows.Forms.Label()
        Me.FileWatcherSystem = New System.IO.FileSystemWatcher()
        Me.BaseItemBackgroundPanel = New System.Windows.Forms.Panel()
        Me.Col02_Panel = New System.Windows.Forms.Panel()
        Me.PlotInformationsPanel = New System.Windows.Forms.Panel()
        Me.Col03_Panel = New System.Windows.Forms.Panel()
        Me.Col01_Panel = New System.Windows.Forms.Panel()
        Me.PlotStatusColorPanel = New System.Windows.Forms.Panel()
        Me.CheckBoxPicture = New System.Windows.Forms.PictureBox()
        Me.PlotNumberLabel = New System.Windows.Forms.Label()
        Me.PlotValuesPanel.SuspendLayout()
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseItemBackgroundPanel.SuspendLayout()
        Me.Col02_Panel.SuspendLayout()
        Me.PlotInformationsPanel.SuspendLayout()
        Me.Col03_Panel.SuspendLayout()
        Me.Col01_Panel.SuspendLayout()
        Me.PlotStatusColorPanel.SuspendLayout()
        CType(Me.CheckBoxPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlotValuesPanel
        '
        Me.PlotValuesPanel.Controls.Add(Me.PlotValuePaidLabel)
        Me.PlotValuesPanel.Controls.Add(Me.PlotValueLabel)
        Me.PlotValuesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotValuesPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotValuesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.PlotValuesPanel.Name = "PlotValuesPanel"
        Me.PlotValuesPanel.Size = New System.Drawing.Size(220, 40)
        Me.PlotValuesPanel.TabIndex = 63
        '
        'PlotValuePaidLabel
        '
        Me.PlotValuePaidLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlotValuePaidLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PlotValuePaidLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PlotValuePaidLabel.ForeColor = System.Drawing.Color.White
        Me.PlotValuePaidLabel.Location = New System.Drawing.Point(2, 4)
        Me.PlotValuePaidLabel.Name = "PlotValuePaidLabel"
        Me.PlotValuePaidLabel.Size = New System.Drawing.Size(90, 32)
        Me.PlotValuePaidLabel.TabIndex = 63
        Me.PlotValuePaidLabel.Text = "R$ 99.999,99"
        Me.PlotValuePaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PlotValuePaidLabel.Visible = False
        '
        'PlotValueLabel
        '
        Me.PlotValueLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlotValueLabel.BackColor = System.Drawing.Color.Black
        Me.PlotValueLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlotValueLabel.ForeColor = System.Drawing.Color.White
        Me.PlotValueLabel.Location = New System.Drawing.Point(98, 4)
        Me.PlotValueLabel.Name = "PlotValueLabel"
        Me.PlotValueLabel.Size = New System.Drawing.Size(120, 32)
        Me.PlotValueLabel.TabIndex = 62
        Me.PlotValueLabel.Text = "R$ 99.999,99"
        Me.PlotValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlotDateLabel
        '
        Me.PlotDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlotDateLabel.AutoSize = True
        Me.PlotDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PlotDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PlotDateLabel.Location = New System.Drawing.Point(0, 3)
        Me.PlotDateLabel.Name = "PlotDateLabel"
        Me.PlotDateLabel.Size = New System.Drawing.Size(102, 19)
        Me.PlotDateLabel.TabIndex = 57
        Me.PlotDateLabel.Text = "Março de 2019"
        '
        'PlotStatusLabel
        '
        Me.PlotStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlotStatusLabel.AutoSize = True
        Me.PlotStatusLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.PlotStatusLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PlotStatusLabel.Location = New System.Drawing.Point(0, 22)
        Me.PlotStatusLabel.Name = "PlotStatusLabel"
        Me.PlotStatusLabel.Size = New System.Drawing.Size(145, 15)
        Me.PlotStatusLabel.TabIndex = 58
        Me.PlotStatusLabel.Text = "Aguardando pagamento..."
        '
        'FileWatcherSystem
        '
        Me.FileWatcherSystem.EnableRaisingEvents = True
        Me.FileWatcherSystem.IncludeSubdirectories = True
        Me.FileWatcherSystem.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileWatcherSystem.SynchronizingObject = Me
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
        Me.BaseItemBackgroundPanel.Size = New System.Drawing.Size(490, 60)
        Me.BaseItemBackgroundPanel.TabIndex = 64
        '
        'Col02_Panel
        '
        Me.Col02_Panel.Controls.Add(Me.PlotInformationsPanel)
        Me.Col02_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Col02_Panel.Location = New System.Drawing.Point(55, 0)
        Me.Col02_Panel.Name = "Col02_Panel"
        Me.Col02_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Col02_Panel.Size = New System.Drawing.Size(195, 60)
        Me.Col02_Panel.TabIndex = 66
        '
        'PlotInformationsPanel
        '
        Me.PlotInformationsPanel.Controls.Add(Me.PlotStatusLabel)
        Me.PlotInformationsPanel.Controls.Add(Me.PlotDateLabel)
        Me.PlotInformationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotInformationsPanel.Location = New System.Drawing.Point(0, 10)
        Me.PlotInformationsPanel.Name = "PlotInformationsPanel"
        Me.PlotInformationsPanel.Size = New System.Drawing.Size(185, 40)
        Me.PlotInformationsPanel.TabIndex = 0
        '
        'Col03_Panel
        '
        Me.Col03_Panel.Controls.Add(Me.PlotValuesPanel)
        Me.Col03_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.Col03_Panel.Location = New System.Drawing.Point(250, 0)
        Me.Col03_Panel.Name = "Col03_Panel"
        Me.Col03_Panel.Padding = New System.Windows.Forms.Padding(10)
        Me.Col03_Panel.Size = New System.Drawing.Size(240, 60)
        Me.Col03_Panel.TabIndex = 65
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
        Me.PlotStatusColorPanel.Controls.Add(Me.CheckBoxPicture)
        Me.PlotStatusColorPanel.Controls.Add(Me.PlotNumberLabel)
        Me.PlotStatusColorPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotStatusColorPanel.ForeColor = System.Drawing.Color.White
        Me.PlotStatusColorPanel.Location = New System.Drawing.Point(10, 10)
        Me.PlotStatusColorPanel.Name = "PlotStatusColorPanel"
        Me.PlotStatusColorPanel.Size = New System.Drawing.Size(40, 40)
        Me.PlotStatusColorPanel.TabIndex = 65
        '
        'CheckBoxPicture
        '
        Me.CheckBoxPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBoxPicture.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_CheckPlot_32px
        Me.CheckBoxPicture.Location = New System.Drawing.Point(0, 0)
        Me.CheckBoxPicture.Name = "CheckBoxPicture"
        Me.CheckBoxPicture.Size = New System.Drawing.Size(40, 40)
        Me.CheckBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CheckBoxPicture.TabIndex = 66
        Me.CheckBoxPicture.TabStop = False
        Me.CheckBoxPicture.Visible = False
        '
        'PlotNumberLabel
        '
        Me.PlotNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlotNumberLabel.AutoSize = True
        Me.PlotNumberLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PlotNumberLabel.Location = New System.Drawing.Point(6, 10)
        Me.PlotNumberLabel.Name = "PlotNumberLabel"
        Me.PlotNumberLabel.Size = New System.Drawing.Size(28, 21)
        Me.PlotNumberLabel.TabIndex = 65
        Me.PlotNumberLabel.Text = "99"
        '
        'PlotItemControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BaseItemBackgroundPanel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "PlotItemControl"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(500, 70)
        Me.PlotValuesPanel.ResumeLayout(False)
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseItemBackgroundPanel.ResumeLayout(False)
        Me.Col02_Panel.ResumeLayout(False)
        Me.PlotInformationsPanel.ResumeLayout(False)
        Me.PlotInformationsPanel.PerformLayout()
        Me.Col03_Panel.ResumeLayout(False)
        Me.Col01_Panel.ResumeLayout(False)
        Me.PlotStatusColorPanel.ResumeLayout(False)
        Me.PlotStatusColorPanel.PerformLayout()
        CType(Me.CheckBoxPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlotValuesPanel As Panel
    Friend WithEvents PlotDateLabel As Label
    Friend WithEvents PlotStatusLabel As Label
    Friend WithEvents FileWatcherSystem As System.IO.FileSystemWatcher
    Friend WithEvents PlotValueLabel As System.Windows.Forms.Label
    Friend WithEvents PlotValuePaidLabel As System.Windows.Forms.Label
    Friend WithEvents BaseItemBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents Col01_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotStatusColorPanel As System.Windows.Forms.Panel
    Friend WithEvents PlotNumberLabel As System.Windows.Forms.Label
    Friend WithEvents Col02_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlotInformationsPanel As System.Windows.Forms.Panel
    Friend WithEvents Col03_Panel As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxPicture As System.Windows.Forms.PictureBox
End Class
