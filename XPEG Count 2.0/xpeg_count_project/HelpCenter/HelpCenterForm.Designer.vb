<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpCenterForm
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
        Me.CategorysListPanel = New System.Windows.Forms.Panel()
        Me.PagesControlsPanel = New System.Windows.Forms.Panel()
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.BorderRight = New System.Windows.Forms.Panel()
        Me.BorderLeft = New System.Windows.Forms.Panel()
        Me.BorderBottom = New System.Windows.Forms.Panel()
        Me.BorderTop = New System.Windows.Forms.Panel()
        Me.DialogOptionsBackgroundPanel = New System.Windows.Forms.Panel()
        Me.ControlsDialogPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_CountLogo = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BordersPanel.SuspendLayout()
        Me.DialogOptionsBackgroundPanel.SuspendLayout()
        Me.ControlsDialogPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel_CountLogo.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategorysListPanel
        '
        Me.CategorysListPanel.AutoScroll = True
        Me.CategorysListPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategorysListPanel.Location = New System.Drawing.Point(10, 10)
        Me.CategorysListPanel.Name = "CategorysListPanel"
        Me.CategorysListPanel.Size = New System.Drawing.Size(965, 30)
        Me.CategorysListPanel.TabIndex = 1
        '
        'PagesControlsPanel
        '
        Me.PagesControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagesControlsPanel.Location = New System.Drawing.Point(10, 50)
        Me.PagesControlsPanel.Name = "PagesControlsPanel"
        Me.PagesControlsPanel.Size = New System.Drawing.Size(965, 318)
        Me.PagesControlsPanel.TabIndex = 1
        '
        'BordersPanel
        '
        Me.BordersPanel.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.BordersPanel.Controls.Add(Me.BorderRight)
        Me.BordersPanel.Controls.Add(Me.BorderLeft)
        Me.BordersPanel.Controls.Add(Me.BorderBottom)
        Me.BordersPanel.Controls.Add(Me.BorderTop)
        Me.BordersPanel.Controls.Add(Me.DialogOptionsBackgroundPanel)
        Me.BordersPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BordersPanel.Location = New System.Drawing.Point(0, 0)
        Me.BordersPanel.Name = "BordersPanel"
        Me.BordersPanel.Size = New System.Drawing.Size(985, 488)
        Me.BordersPanel.TabIndex = 92
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(984, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 486)
        Me.BorderRight.TabIndex = 89
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 1)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 486)
        Me.BorderLeft.TabIndex = 88
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 487)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(985, 1)
        Me.BorderBottom.TabIndex = 86
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(985, 1)
        Me.BorderTop.TabIndex = 85
        '
        'DialogOptionsBackgroundPanel
        '
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.ControlsDialogPanel)
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.DialogOptionsPanel)
        Me.DialogOptionsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DialogOptionsBackgroundPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsBackgroundPanel.Name = "DialogOptionsBackgroundPanel"
        Me.DialogOptionsBackgroundPanel.Size = New System.Drawing.Size(985, 488)
        Me.DialogOptionsBackgroundPanel.TabIndex = 90
        '
        'ControlsDialogPanel
        '
        Me.ControlsDialogPanel.Controls.Add(Me.Panel4)
        Me.ControlsDialogPanel.Controls.Add(Me.Panel_CountLogo)
        Me.ControlsDialogPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ControlsDialogPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsDialogPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlsDialogPanel.Name = "ControlsDialogPanel"
        Me.ControlsDialogPanel.Size = New System.Drawing.Size(985, 448)
        Me.ControlsDialogPanel.TabIndex = 90
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PagesControlsPanel)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.CategorysListPanel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(985, 378)
        Me.Panel4.TabIndex = 80
        '
        'Panel_CountLogo
        '
        Me.Panel_CountLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_CountLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_CountLogo.Controls.Add(Me.SearchTextBox)
        Me.Panel_CountLogo.Controls.Add(Me.Panel3)
        Me.Panel_CountLogo.Controls.Add(Me.LabelTitle)
        Me.Panel_CountLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_CountLogo.ForeColor = System.Drawing.Color.Black
        Me.Panel_CountLogo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_CountLogo.Name = "Panel_CountLogo"
        Me.Panel_CountLogo.Size = New System.Drawing.Size(985, 70)
        Me.Panel_CountLogo.TabIndex = 79
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 1)
        Me.Panel3.TabIndex = 82
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LabelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitle.Location = New System.Drawing.Point(20, 21)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(195, 29)
        Me.LabelTitle.TabIndex = 74
        Me.LabelTitle.Text = "Central de Ajuda"
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Close)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 448)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(985, 40)
        Me.DialogOptionsPanel.TabIndex = 89
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Close.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Close.Location = New System.Drawing.Point(874, 5)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(100, 30)
        Me.Button_Close.TabIndex = 73
        Me.Button_Close.Text = "&Fechar"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(985, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SearchTextBox.Location = New System.Drawing.Point(660, 23)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(300, 25)
        Me.SearchTextBox.TabIndex = 0
        Me.SearchTextBox.Text = "Pesquisar"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 10)
        Me.Panel1.TabIndex = 2
        '
        'HelpCenterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 488)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HelpCenterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Central de Ajuda"
        Me.BordersPanel.ResumeLayout(False)
        Me.DialogOptionsBackgroundPanel.ResumeLayout(False)
        Me.ControlsDialogPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel_CountLogo.ResumeLayout(False)
        Me.Panel_CountLogo.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategorysListPanel As System.Windows.Forms.Panel
    Friend WithEvents PagesControlsPanel As System.Windows.Forms.Panel
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents BorderRight As System.Windows.Forms.Panel
    Friend WithEvents BorderLeft As System.Windows.Forms.Panel
    Friend WithEvents BorderBottom As System.Windows.Forms.Panel
    Friend WithEvents BorderTop As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlsDialogPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel_CountLogo As System.Windows.Forms.Panel
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
End Class
