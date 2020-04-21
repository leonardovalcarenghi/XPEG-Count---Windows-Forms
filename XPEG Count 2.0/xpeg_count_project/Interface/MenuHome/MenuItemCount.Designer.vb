<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItemCount
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
        Me.MenuTitleLabel = New System.Windows.Forms.Label()
        Me.FileWatcherSystem = New System.IO.FileSystemWatcher()
        Me.BaseItemBackgroundPanel = New System.Windows.Forms.Panel()
        Me.Col02_Panel = New System.Windows.Forms.Panel()
        Me.MenuInformationsPanel = New System.Windows.Forms.Panel()
        Me.Col01_Panel = New System.Windows.Forms.Panel()
        Me.MenuIconPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseItemBackgroundPanel.SuspendLayout()
        Me.Col02_Panel.SuspendLayout()
        Me.MenuInformationsPanel.SuspendLayout()
        Me.Col01_Panel.SuspendLayout()
        CType(Me.MenuIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTitleLabel
        '
        Me.MenuTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuTitleLabel.AutoSize = True
        Me.MenuTitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuTitleLabel.ForeColor = System.Drawing.Color.White
        Me.MenuTitleLabel.Location = New System.Drawing.Point(0, 4)
        Me.MenuTitleLabel.Name = "MenuTitleLabel"
        Me.MenuTitleLabel.Size = New System.Drawing.Size(139, 19)
        Me.MenuTitleLabel.TabIndex = 57
        Me.MenuTitleLabel.Text = "Item do Menu Count"
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
        Me.BaseItemBackgroundPanel.Controls.Add(Me.Col02_Panel)
        Me.BaseItemBackgroundPanel.Controls.Add(Me.Col01_Panel)
        Me.BaseItemBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BaseItemBackgroundPanel.Location = New System.Drawing.Point(0, 2)
        Me.BaseItemBackgroundPanel.Name = "BaseItemBackgroundPanel"
        Me.BaseItemBackgroundPanel.Size = New System.Drawing.Size(395, 46)
        Me.BaseItemBackgroundPanel.TabIndex = 65
        '
        'Col02_Panel
        '
        Me.Col02_Panel.Controls.Add(Me.MenuInformationsPanel)
        Me.Col02_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Col02_Panel.Location = New System.Drawing.Point(66, 0)
        Me.Col02_Panel.Name = "Col02_Panel"
        Me.Col02_Panel.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Col02_Panel.Size = New System.Drawing.Size(329, 46)
        Me.Col02_Panel.TabIndex = 66
        '
        'MenuInformationsPanel
        '
        Me.MenuInformationsPanel.Controls.Add(Me.MenuTitleLabel)
        Me.MenuInformationsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuInformationsPanel.Location = New System.Drawing.Point(0, 10)
        Me.MenuInformationsPanel.Name = "MenuInformationsPanel"
        Me.MenuInformationsPanel.Size = New System.Drawing.Size(319, 26)
        Me.MenuInformationsPanel.TabIndex = 0
        '
        'Col01_Panel
        '
        Me.Col01_Panel.Controls.Add(Me.MenuIconPictureBox)
        Me.Col01_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Col01_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Col01_Panel.Name = "Col01_Panel"
        Me.Col01_Panel.Padding = New System.Windows.Forms.Padding(12, 2, 12, 2)
        Me.Col01_Panel.Size = New System.Drawing.Size(66, 46)
        Me.Col01_Panel.TabIndex = 64
        '
        'MenuIconPictureBox
        '
        Me.MenuIconPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuIconPictureBox.Location = New System.Drawing.Point(12, 2)
        Me.MenuIconPictureBox.Name = "MenuIconPictureBox"
        Me.MenuIconPictureBox.Size = New System.Drawing.Size(42, 42)
        Me.MenuIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuIconPictureBox.TabIndex = 58
        Me.MenuIconPictureBox.TabStop = False
        '
        'MenuItemCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BaseItemBackgroundPanel)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "MenuItemCount"
        Me.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Size = New System.Drawing.Size(395, 50)
        CType(Me.FileWatcherSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseItemBackgroundPanel.ResumeLayout(False)
        Me.Col02_Panel.ResumeLayout(False)
        Me.MenuInformationsPanel.ResumeLayout(False)
        Me.MenuInformationsPanel.PerformLayout()
        Me.Col01_Panel.ResumeLayout(False)
        CType(Me.MenuIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuTitleLabel As System.Windows.Forms.Label
    Friend WithEvents FileWatcherSystem As System.IO.FileSystemWatcher
    Friend WithEvents BaseItemBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents Col02_Panel As System.Windows.Forms.Panel
    Friend WithEvents MenuInformationsPanel As System.Windows.Forms.Panel
    Friend WithEvents Col01_Panel As System.Windows.Forms.Panel
    Friend WithEvents MenuIconPictureBox As System.Windows.Forms.PictureBox

End Class
