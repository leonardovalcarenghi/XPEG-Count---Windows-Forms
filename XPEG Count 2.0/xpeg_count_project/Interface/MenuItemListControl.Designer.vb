<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItemListControl
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
        Me.ItemBaseBackgroundPanel = New System.Windows.Forms.Panel()
        Me.TitleBasePanel = New System.Windows.Forms.Panel()
        Me.MenuTextLabel = New System.Windows.Forms.Label()
        Me.IconBasePanel = New System.Windows.Forms.Panel()
        Me.MenuIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.ItemMenuToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ItemBaseBackgroundPanel.SuspendLayout()
        Me.TitleBasePanel.SuspendLayout()
        Me.IconBasePanel.SuspendLayout()
        CType(Me.MenuIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemBaseBackgroundPanel
        '
        Me.ItemBaseBackgroundPanel.Controls.Add(Me.TitleBasePanel)
        Me.ItemBaseBackgroundPanel.Controls.Add(Me.IconBasePanel)
        Me.ItemBaseBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemBaseBackgroundPanel.Location = New System.Drawing.Point(0, 2)
        Me.ItemBaseBackgroundPanel.Name = "ItemBaseBackgroundPanel"
        Me.ItemBaseBackgroundPanel.Size = New System.Drawing.Size(350, 46)
        Me.ItemBaseBackgroundPanel.TabIndex = 0
        '
        'TitleBasePanel
        '
        Me.TitleBasePanel.Controls.Add(Me.MenuTextLabel)
        Me.TitleBasePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleBasePanel.Location = New System.Drawing.Point(70, 0)
        Me.TitleBasePanel.Name = "TitleBasePanel"
        Me.TitleBasePanel.Size = New System.Drawing.Size(280, 46)
        Me.TitleBasePanel.TabIndex = 2
        '
        'MenuTextLabel
        '
        Me.MenuTextLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuTextLabel.AutoSize = True
        Me.MenuTextLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuTextLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuTextLabel.Location = New System.Drawing.Point(3, 14)
        Me.MenuTextLabel.Name = "MenuTextLabel"
        Me.MenuTextLabel.Size = New System.Drawing.Size(77, 19)
        Me.MenuTextLabel.TabIndex = 2
        Me.MenuTextLabel.Text = "menu_item"
        '
        'IconBasePanel
        '
        Me.IconBasePanel.Controls.Add(Me.MenuIconPictureBox)
        Me.IconBasePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconBasePanel.Location = New System.Drawing.Point(0, 0)
        Me.IconBasePanel.Name = "IconBasePanel"
        Me.IconBasePanel.Size = New System.Drawing.Size(70, 46)
        Me.IconBasePanel.TabIndex = 1
        '
        'MenuIconPictureBox
        '
        Me.MenuIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MenuIconPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuIconPictureBox.Location = New System.Drawing.Point(30, 3)
        Me.MenuIconPictureBox.Name = "MenuIconPictureBox"
        Me.MenuIconPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.MenuIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MenuIconPictureBox.TabIndex = 1
        Me.MenuIconPictureBox.TabStop = False
        '
        'MenuItemListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.ItemBaseBackgroundPanel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MenuItemListControl"
        Me.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.Size = New System.Drawing.Size(350, 50)
        Me.ItemBaseBackgroundPanel.ResumeLayout(False)
        Me.TitleBasePanel.ResumeLayout(False)
        Me.TitleBasePanel.PerformLayout()
        Me.IconBasePanel.ResumeLayout(False)
        CType(Me.MenuIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemBaseBackgroundPanel As System.Windows.Forms.Panel
    Friend WithEvents IconBasePanel As System.Windows.Forms.Panel
    Friend WithEvents MenuIconPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TitleBasePanel As System.Windows.Forms.Panel
    Friend WithEvents MenuTextLabel As System.Windows.Forms.Label
    Friend WithEvents ItemMenuToolTip As System.Windows.Forms.ToolTip
End Class
