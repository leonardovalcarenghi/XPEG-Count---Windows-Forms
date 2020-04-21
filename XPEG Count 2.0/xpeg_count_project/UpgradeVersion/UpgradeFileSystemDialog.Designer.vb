<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpgradeFileSystemDialog
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
        Me.PagesCtrlPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.BorderBottom = New System.Windows.Forms.Panel()
        Me.BorderTop = New System.Windows.Forms.Panel()
        Me.BorderLeft = New System.Windows.Forms.Panel()
        Me.BorderRight = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PagesCtrlPanel
        '
        Me.PagesCtrlPanel.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.PagesCtrlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagesCtrlPanel.Location = New System.Drawing.Point(1, 1)
        Me.PagesCtrlPanel.Name = "PagesCtrlPanel"
        Me.PagesCtrlPanel.Size = New System.Drawing.Size(876, 417)
        Me.PagesCtrlPanel.TabIndex = 94
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Next)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Back)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 418)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(876, 40)
        Me.DialogOptionsPanel.TabIndex = 95
        '
        'Button_Next
        '
        Me.Button_Next.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Next.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Next.Location = New System.Drawing.Point(659, 5)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(100, 30)
        Me.Button_Next.TabIndex = 74
        Me.Button_Next.Text = "&Avançar"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(876, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(765, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Back.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Back.Location = New System.Drawing.Point(553, 5)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(100, 30)
        Me.Button_Back.TabIndex = 72
        Me.Button_Back.Text = "&Voltar"
        Me.Button_Back.UseVisualStyleBackColor = True
        Me.Button_Back.Visible = False
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(1, 458)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(876, 1)
        Me.BorderBottom.TabIndex = 91
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(1, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(876, 1)
        Me.BorderTop.TabIndex = 90
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 0)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 459)
        Me.BorderLeft.TabIndex = 93
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(877, 0)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 459)
        Me.BorderRight.TabIndex = 92
        '
        'UpgradeFileSystemDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 459)
        Me.Controls.Add(Me.PagesCtrlPanel)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.BorderBottom)
        Me.Controls.Add(Me.BorderTop)
        Me.Controls.Add(Me.BorderLeft)
        Me.Controls.Add(Me.BorderRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpgradeFileSystemDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UpgradeFileSystemDialog"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PagesCtrlPanel As Panel
    Friend WithEvents DialogOptionsPanel As Panel
    Friend WithEvents Button_Next As Button
    Friend WithEvents DialogOptionsSeparatorPanel As Panel
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Back As Button
    Friend WithEvents BorderBottom As Panel
    Friend WithEvents BorderTop As Panel
    Friend WithEvents BorderLeft As Panel
    Friend WithEvents BorderRight As Panel
End Class
