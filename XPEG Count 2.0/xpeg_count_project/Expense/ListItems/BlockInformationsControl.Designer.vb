<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockInformationsControl
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
        Me.PanelIcon = New System.Windows.Forms.Panel()
        Me.BlockIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.PanelInformations = New System.Windows.Forms.Panel()
        Me.BlockText_Label = New System.Windows.Forms.Label()
        Me.BlockTitle_Label = New System.Windows.Forms.Label()
        Me.PanelIcon.SuspendLayout()
        CType(Me.BlockIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInformations.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelIcon
        '
        Me.PanelIcon.Controls.Add(Me.BlockIcon_PictureBox)
        Me.PanelIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIcon.Location = New System.Drawing.Point(0, 0)
        Me.PanelIcon.Name = "PanelIcon"
        Me.PanelIcon.Size = New System.Drawing.Size(50, 50)
        Me.PanelIcon.TabIndex = 74
        '
        'BlockIcon_PictureBox
        '
        Me.BlockIcon_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BlockIcon_PictureBox.Location = New System.Drawing.Point(6, 6)
        Me.BlockIcon_PictureBox.Name = "BlockIcon_PictureBox"
        Me.BlockIcon_PictureBox.Size = New System.Drawing.Size(38, 38)
        Me.BlockIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BlockIcon_PictureBox.TabIndex = 1
        Me.BlockIcon_PictureBox.TabStop = False
        '
        'PanelInformations
        '
        Me.PanelInformations.Controls.Add(Me.BlockText_Label)
        Me.PanelInformations.Controls.Add(Me.BlockTitle_Label)
        Me.PanelInformations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInformations.Location = New System.Drawing.Point(50, 0)
        Me.PanelInformations.Name = "PanelInformations"
        Me.PanelInformations.Size = New System.Drawing.Size(300, 50)
        Me.PanelInformations.TabIndex = 75
        '
        'BlockText_Label
        '
        Me.BlockText_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockText_Label.AutoSize = True
        Me.BlockText_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BlockText_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BlockText_Label.Location = New System.Drawing.Point(2, 22)
        Me.BlockText_Label.Name = "BlockText_Label"
        Me.BlockText_Label.Size = New System.Drawing.Size(37, 20)
        Me.BlockText_Label.TabIndex = 57
        Me.BlockText_Label.Text = "Text"
        '
        'BlockTitle_Label
        '
        Me.BlockTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BlockTitle_Label.AutoSize = True
        Me.BlockTitle_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!)
        Me.BlockTitle_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BlockTitle_Label.Location = New System.Drawing.Point(3, 8)
        Me.BlockTitle_Label.Name = "BlockTitle_Label"
        Me.BlockTitle_Label.Size = New System.Drawing.Size(29, 13)
        Me.BlockTitle_Label.TabIndex = 58
        Me.BlockTitle_Label.Text = "Title"
        '
        'BlockInformationsControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.PanelInformations)
        Me.Controls.Add(Me.PanelIcon)
        Me.Name = "BlockInformationsControl"
        Me.Size = New System.Drawing.Size(350, 50)
        Me.PanelIcon.ResumeLayout(False)
        CType(Me.BlockIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInformations.ResumeLayout(False)
        Me.PanelInformations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelIcon As Panel
    Friend WithEvents BlockIcon_PictureBox As PictureBox
    Friend WithEvents PanelInformations As Panel
    Friend WithEvents BlockText_Label As Label
    Friend WithEvents BlockTitle_Label As Label
End Class
