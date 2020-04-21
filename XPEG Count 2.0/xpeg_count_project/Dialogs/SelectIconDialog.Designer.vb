<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectIconDialog
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Label_File = New System.Windows.Forms.Label()
        Me.PictureBox_SelectedIcon = New System.Windows.Forms.PictureBox()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayout_IconsList = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelSeparator = New System.Windows.Forms.Panel()
        Me.CategoryIconList_SemIcones = New System.Windows.Forms.Label()
        Me.MenuCategorysBackground = New System.Windows.Forms.Panel()
        Me.IconsCategoryMenu = New System.Windows.Forms.Panel()
        Me.CategoryIconList2 = New xpeg_count_project.CategoryIconList()
        Me.Separator01 = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel.SuspendLayout()
        CType(Me.PictureBox_SelectedIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.FlowLayout_IconsList.SuspendLayout()
        Me.MenuCategorysBackground.SuspendLayout()
        Me.IconsCategoryMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(860, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Label_File)
        Me.DialogOptionsPanel.Controls.Add(Me.PictureBox_SelectedIcon)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 459)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(860, 40)
        Me.DialogOptionsPanel.TabIndex = 77
        '
        'Label_File
        '
        Me.Label_File.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_File.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_File.Location = New System.Drawing.Point(44, 2)
        Me.Label_File.Name = "Label_File"
        Me.Label_File.Size = New System.Drawing.Size(593, 36)
        Me.Label_File.TabIndex = 75
        Me.Label_File.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_SelectedIcon
        '
        Me.PictureBox_SelectedIcon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox_SelectedIcon.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox_SelectedIcon.Name = "PictureBox_SelectedIcon"
        Me.PictureBox_SelectedIcon.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox_SelectedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_SelectedIcon.TabIndex = 74
        Me.PictureBox_SelectedIcon.TabStop = False
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(749, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_OK.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_OK.Location = New System.Drawing.Point(643, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(100, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Selecionar"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(860, 1)
        Me.Panel2.TabIndex = 73
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(1, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(860, 1)
        Me.Panel6.TabIndex = 72
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 500)
        Me.Panel7.TabIndex = 75
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(861, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 500)
        Me.Panel3.TabIndex = 74
        '
        'Panel5
        '
        Me.Panel5.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.Panel5.Controls.Add(Me.FlowLayout_IconsList)
        Me.Panel5.Controls.Add(Me.MenuCategorysBackground)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(860, 458)
        Me.Panel5.TabIndex = 76
        '
        'FlowLayout_IconsList
        '
        Me.FlowLayout_IconsList.AutoScroll = True
        Me.FlowLayout_IconsList.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.FlowLayout_IconsList.AutoScrollMinSize = New System.Drawing.Size(30, 30)
        Me.FlowLayout_IconsList.Controls.Add(Me.PanelSeparator)
        Me.FlowLayout_IconsList.Controls.Add(Me.CategoryIconList_SemIcones)
        Me.FlowLayout_IconsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayout_IconsList.Location = New System.Drawing.Point(230, 0)
        Me.FlowLayout_IconsList.Name = "FlowLayout_IconsList"
        Me.FlowLayout_IconsList.Padding = New System.Windows.Forms.Padding(30)
        Me.FlowLayout_IconsList.Size = New System.Drawing.Size(630, 458)
        Me.FlowLayout_IconsList.TabIndex = 0
        '
        'PanelSeparator
        '
        Me.PanelSeparator.Location = New System.Drawing.Point(33, 33)
        Me.PanelSeparator.Name = "PanelSeparator"
        Me.PanelSeparator.Size = New System.Drawing.Size(567, 50)
        Me.PanelSeparator.TabIndex = 1
        '
        'CategoryIconList_SemIcones
        '
        Me.CategoryIconList_SemIcones.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.CategoryIconList_SemIcones.Location = New System.Drawing.Point(33, 86)
        Me.CategoryIconList_SemIcones.Name = "CategoryIconList_SemIcones"
        Me.CategoryIconList_SemIcones.Size = New System.Drawing.Size(567, 33)
        Me.CategoryIconList_SemIcones.TabIndex = 3
        Me.CategoryIconList_SemIcones.Text = "Nenhum icone disponível para ser exibido." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vá em Configurações e Clique no botão " &
    """Atualizar Lista de Icones"" e despois retorne a esta tela."
        '
        'MenuCategorysBackground
        '
        Me.MenuCategorysBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.MenuCategorysBackground.Controls.Add(Me.IconsCategoryMenu)
        Me.MenuCategorysBackground.Controls.Add(Me.Separator01)
        Me.MenuCategorysBackground.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuCategorysBackground.Location = New System.Drawing.Point(0, 0)
        Me.MenuCategorysBackground.Name = "MenuCategorysBackground"
        Me.MenuCategorysBackground.Size = New System.Drawing.Size(230, 458)
        Me.MenuCategorysBackground.TabIndex = 3
        '
        'IconsCategoryMenu
        '
        Me.IconsCategoryMenu.AutoScroll = True
        Me.IconsCategoryMenu.Controls.Add(Me.CategoryIconList2)
        Me.IconsCategoryMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconsCategoryMenu.Location = New System.Drawing.Point(0, 0)
        Me.IconsCategoryMenu.Name = "IconsCategoryMenu"
        Me.IconsCategoryMenu.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.IconsCategoryMenu.Size = New System.Drawing.Size(229, 458)
        Me.IconsCategoryMenu.TabIndex = 3
        '
        'CategoryIconList2
        '
        Me.CategoryIconList2.BackColor = System.Drawing.Color.Transparent
        Me.CategoryIconList2.CategoryName = "Categoria ABCDE"
        Me.CategoryIconList2.CategorySelected = False
        Me.CategoryIconList2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategoryIconList2.Location = New System.Drawing.Point(0, 30)
        Me.CategoryIconList2.Name = "CategoryIconList2"
        Me.CategoryIconList2.Size = New System.Drawing.Size(229, 25)
        Me.CategoryIconList2.TabIndex = 1
        '
        'Separator01
        '
        Me.Separator01.BackColor = System.Drawing.Color.Gainsboro
        Me.Separator01.Dock = System.Windows.Forms.DockStyle.Right
        Me.Separator01.Location = New System.Drawing.Point(229, 0)
        Me.Separator01.Name = "Separator01"
        Me.Separator01.Size = New System.Drawing.Size(1, 458)
        Me.Separator01.TabIndex = 4
        '
        'SelectIconDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(862, 500)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectIconDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar Icone"
        Me.DialogOptionsPanel.ResumeLayout(False)
        CType(Me.PictureBox_SelectedIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.FlowLayout_IconsList.ResumeLayout(False)
        Me.MenuCategorysBackground.ResumeLayout(False)
        Me.IconsCategoryMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayout_IconsList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox_SelectedIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label_File As System.Windows.Forms.Label
    Friend WithEvents PanelSeparator As Panel
    Friend WithEvents CategoryIconList_SemIcones As Label
    Friend WithEvents MenuCategorysBackground As Panel
    Friend WithEvents IconsCategoryMenu As Panel
    Friend WithEvents Separator01 As Panel
    Friend WithEvents CategoryIconList2 As CategoryIconList
End Class
