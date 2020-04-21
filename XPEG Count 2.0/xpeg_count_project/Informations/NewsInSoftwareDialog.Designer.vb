<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewsInSoftwareDialog
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
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.BorderRight = New System.Windows.Forms.Panel()
        Me.BorderLeft = New System.Windows.Forms.Panel()
        Me.BorderBottom = New System.Windows.Forms.Panel()
        Me.BorderTop = New System.Windows.Forms.Panel()
        Me.DialogOptionsBackgroundPanel = New System.Windows.Forms.Panel()
        Me.ControlsDialogPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.VersionLog_RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.BordersPanel.SuspendLayout()
        Me.DialogOptionsBackgroundPanel.SuspendLayout()
        Me.ControlsDialogPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BordersPanel.Size = New System.Drawing.Size(680, 400)
        Me.BordersPanel.TabIndex = 91
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(679, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 398)
        Me.BorderRight.TabIndex = 89
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 1)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 398)
        Me.BorderLeft.TabIndex = 88
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 399)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(680, 1)
        Me.BorderBottom.TabIndex = 86
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(680, 1)
        Me.BorderTop.TabIndex = 85
        '
        'DialogOptionsBackgroundPanel
        '
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.ControlsDialogPanel)
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.DialogOptionsPanel)
        Me.DialogOptionsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DialogOptionsBackgroundPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsBackgroundPanel.Name = "DialogOptionsBackgroundPanel"
        Me.DialogOptionsBackgroundPanel.Size = New System.Drawing.Size(680, 400)
        Me.DialogOptionsBackgroundPanel.TabIndex = 90
        '
        'ControlsDialogPanel
        '
        Me.ControlsDialogPanel.Controls.Add(Me.Panel4)
        Me.ControlsDialogPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ControlsDialogPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsDialogPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlsDialogPanel.Name = "ControlsDialogPanel"
        Me.ControlsDialogPanel.Size = New System.Drawing.Size(680, 360)
        Me.ControlsDialogPanel.TabIndex = 90
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.VersionLog_RichTextBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(680, 360)
        Me.Panel4.TabIndex = 80
        '
        'VersionLog_RichTextBox
        '
        Me.VersionLog_RichTextBox.BackColor = System.Drawing.Color.White
        Me.VersionLog_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VersionLog_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionLog_RichTextBox.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.VersionLog_RichTextBox.Location = New System.Drawing.Point(10, 10)
        Me.VersionLog_RichTextBox.Name = "VersionLog_RichTextBox"
        Me.VersionLog_RichTextBox.ReadOnly = True
        Me.VersionLog_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.VersionLog_RichTextBox.ShowSelectionMargin = True
        Me.VersionLog_RichTextBox.Size = New System.Drawing.Size(660, 340)
        Me.VersionLog_RichTextBox.TabIndex = 0
        Me.VersionLog_RichTextBox.Text = "Atualização 2.0"
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Close)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 360)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(680, 40)
        Me.DialogOptionsPanel.TabIndex = 89
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Close.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Close.Location = New System.Drawing.Point(569, 5)
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
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(680, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'NewsInSoftwareDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(680, 400)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewsInSoftwareDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Novidades"
        Me.BordersPanel.ResumeLayout(False)
        Me.DialogOptionsBackgroundPanel.ResumeLayout(False)
        Me.ControlsDialogPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents BorderRight As System.Windows.Forms.Panel
    Friend WithEvents BorderLeft As System.Windows.Forms.Panel
    Friend WithEvents BorderBottom As System.Windows.Forms.Panel
    Friend WithEvents BorderTop As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents ControlsDialogPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents VersionLog_RichTextBox As System.Windows.Forms.RichTextBox

End Class
