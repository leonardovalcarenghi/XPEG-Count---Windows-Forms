<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlideShowForm
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
        Me.NextButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BorderTitleTop = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SlideShowPagesPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NextButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.NextButton.Location = New System.Drawing.Point(981, 5)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(100, 30)
        Me.NextButton.TabIndex = 72
        Me.NextButton.Text = "&Próximo"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.CloseButton.Location = New System.Drawing.Point(1087, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(100, 30)
        Me.CloseButton.TabIndex = 73
        Me.CloseButton.Text = "&Fechar"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.BackButton)
        Me.DialogOptionsPanel.Controls.Add(Me.CloseButton)
        Me.DialogOptionsPanel.Controls.Add(Me.NextButton)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 559)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(1198, 40)
        Me.DialogOptionsPanel.TabIndex = 95
        '
        'BackButton
        '
        Me.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BackButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.BackButton.Location = New System.Drawing.Point(11, 5)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(60, 30)
        Me.BackButton.TabIndex = 74
        Me.BackButton.Text = "Voltar"
        Me.BackButton.UseVisualStyleBackColor = True
        Me.BackButton.Visible = False
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(1198, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 599)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1198, 1)
        Me.Panel2.TabIndex = 91
        '
        'BorderTitleTop
        '
        Me.BorderTitleTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTitleTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTitleTop.Location = New System.Drawing.Point(1, 0)
        Me.BorderTitleTop.Name = "BorderTitleTop"
        Me.BorderTitleTop.Size = New System.Drawing.Size(1198, 1)
        Me.BorderTitleTop.TabIndex = 90
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 600)
        Me.Panel7.TabIndex = 93
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1199, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 600)
        Me.Panel3.TabIndex = 92
        '
        'SlideShowPagesPanel
        '
        Me.SlideShowPagesPanel.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.SlideShowPagesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlideShowPagesPanel.Location = New System.Drawing.Point(1, 1)
        Me.SlideShowPagesPanel.Name = "SlideShowPagesPanel"
        Me.SlideShowPagesPanel.Size = New System.Drawing.Size(1198, 558)
        Me.SlideShowPagesPanel.TabIndex = 94
        '
        'SlideShowForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.SlideShowPagesPanel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BorderTitleTop)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SlideShowForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SlideShowForm"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BorderTitleTop As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SlideShowPagesPanel As System.Windows.Forms.Panel
End Class
