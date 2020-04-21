<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DonateDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DonateDialog))
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_CountLogo = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ControlsDialogPanel = New System.Windows.Forms.Panel()
        Me.BorderRight = New System.Windows.Forms.Panel()
        Me.BorderLeft = New System.Windows.Forms.Panel()
        Me.BorderBottom = New System.Windows.Forms.Panel()
        Me.BorderTop = New System.Windows.Forms.Panel()
        Me.DialogOptionsBackgroundPanel = New System.Windows.Forms.Panel()
        Me.BordersPanel = New System.Windows.Forms.Panel()
        Me.TabPage_Donate = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Panel_CountLogo.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ControlsDialogPanel.SuspendLayout()
        Me.DialogOptionsBackgroundPanel.SuspendLayout()
        Me.BordersPanel.SuspendLayout()
        Me.TabPage_Donate.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(888, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Close)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(0, 414)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(888, 40)
        Me.DialogOptionsPanel.TabIndex = 89
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Close.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Close.Location = New System.Drawing.Point(777, 5)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(100, 30)
        Me.Button_Close.TabIndex = 73
        Me.Button_Close.Text = "&Fechar"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(888, 1)
        Me.Panel3.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 15)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Um novo jeito de gerenciar suas despesas"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Black", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(30, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 29)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Xpeg"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Light", 24.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(90, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 38)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Count"
        '
        'Panel_CountLogo
        '
        Me.Panel_CountLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel_CountLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_CountLogo.Controls.Add(Me.Panel3)
        Me.Panel_CountLogo.Controls.Add(Me.Label1)
        Me.Panel_CountLogo.Controls.Add(Me.Label5)
        Me.Panel_CountLogo.Controls.Add(Me.Label7)
        Me.Panel_CountLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_CountLogo.ForeColor = System.Drawing.Color.Black
        Me.Panel_CountLogo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_CountLogo.Name = "Panel_CountLogo"
        Me.Panel_CountLogo.Size = New System.Drawing.Size(888, 100)
        Me.Panel_CountLogo.TabIndex = 79
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel4.Size = New System.Drawing.Size(888, 314)
        Me.Panel4.TabIndex = 80
        '
        'ControlsDialogPanel
        '
        Me.ControlsDialogPanel.Controls.Add(Me.Panel4)
        Me.ControlsDialogPanel.Controls.Add(Me.Panel_CountLogo)
        Me.ControlsDialogPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ControlsDialogPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlsDialogPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlsDialogPanel.Name = "ControlsDialogPanel"
        Me.ControlsDialogPanel.Size = New System.Drawing.Size(888, 414)
        Me.ControlsDialogPanel.TabIndex = 90
        '
        'BorderRight
        '
        Me.BorderRight.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.BorderRight.Location = New System.Drawing.Point(887, 1)
        Me.BorderRight.Name = "BorderRight"
        Me.BorderRight.Size = New System.Drawing.Size(1, 452)
        Me.BorderRight.TabIndex = 89
        '
        'BorderLeft
        '
        Me.BorderLeft.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.BorderLeft.Location = New System.Drawing.Point(0, 1)
        Me.BorderLeft.Name = "BorderLeft"
        Me.BorderLeft.Size = New System.Drawing.Size(1, 452)
        Me.BorderLeft.TabIndex = 88
        '
        'BorderBottom
        '
        Me.BorderBottom.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BorderBottom.Location = New System.Drawing.Point(0, 453)
        Me.BorderBottom.Name = "BorderBottom"
        Me.BorderBottom.Size = New System.Drawing.Size(888, 1)
        Me.BorderBottom.TabIndex = 86
        '
        'BorderTop
        '
        Me.BorderTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTop.Location = New System.Drawing.Point(0, 0)
        Me.BorderTop.Name = "BorderTop"
        Me.BorderTop.Size = New System.Drawing.Size(888, 1)
        Me.BorderTop.TabIndex = 85
        '
        'DialogOptionsBackgroundPanel
        '
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.ControlsDialogPanel)
        Me.DialogOptionsBackgroundPanel.Controls.Add(Me.DialogOptionsPanel)
        Me.DialogOptionsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DialogOptionsBackgroundPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsBackgroundPanel.Name = "DialogOptionsBackgroundPanel"
        Me.DialogOptionsBackgroundPanel.Size = New System.Drawing.Size(888, 454)
        Me.DialogOptionsBackgroundPanel.TabIndex = 90
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
        Me.BordersPanel.Size = New System.Drawing.Size(888, 454)
        Me.BordersPanel.TabIndex = 91
        '
        'TabPage_Donate
        '
        Me.TabPage_Donate.Controls.Add(Me.Label6)
        Me.TabPage_Donate.Controls.Add(Me.Label2)
        Me.TabPage_Donate.Controls.Add(Me.PictureBox1)
        Me.TabPage_Donate.Controls.Add(Me.Label4)
        Me.TabPage_Donate.Controls.Add(Me.Label3)
        Me.TabPage_Donate.Location = New System.Drawing.Point(4, 28)
        Me.TabPage_Donate.Name = "TabPage_Donate"
        Me.TabPage_Donate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Donate.Size = New System.Drawing.Size(860, 262)
        Me.TabPage_Donate.TabIndex = 0
        Me.TabPage_Donate.Text = "Doação"
        Me.TabPage_Donate.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_Donate)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(12, 5)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(868, 294)
        Me.TabControl1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(396, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Pedimos humildemente uma contribuição para o XPEG Count."
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(592, 150)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.xpeg_count_project.My.Resources.Resources.WalletBitcoin
        Me.PictureBox1.Location = New System.Drawing.Point(640, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 15)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Endereço da Carteira para Doação:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(21, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "1CHeHbE94ZPDNJFfpu4AdCQD3bv63DEPDd"
        '
        'DonateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(888, 454)
        Me.Controls.Add(Me.BordersPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DonateDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Doação"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Panel_CountLogo.ResumeLayout(False)
        Me.Panel_CountLogo.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ControlsDialogPanel.ResumeLayout(False)
        Me.DialogOptionsBackgroundPanel.ResumeLayout(False)
        Me.BordersPanel.ResumeLayout(False)
        Me.TabPage_Donate.ResumeLayout(False)
        Me.TabPage_Donate.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel_CountLogo As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Donate As System.Windows.Forms.TabPage
    Friend WithEvents ControlsDialogPanel As System.Windows.Forms.Panel
    Friend WithEvents BorderRight As System.Windows.Forms.Panel
    Friend WithEvents BorderLeft As System.Windows.Forms.Panel
    Friend WithEvents BorderBottom As System.Windows.Forms.Panel
    Friend WithEvents BorderTop As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents BordersPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
