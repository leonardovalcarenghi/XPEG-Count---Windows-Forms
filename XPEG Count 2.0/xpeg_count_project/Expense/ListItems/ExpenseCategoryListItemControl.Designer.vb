<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseCategoryListItemControl
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
        Me.CategoryPanel = New System.Windows.Forms.Panel()
        Me.CategoryTitle_Label = New System.Windows.Forms.Label()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.CategoryIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.CategoryPanel.SuspendLayout()
        Me.PanelColor.SuspendLayout()
        CType(Me.CategoryIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryPanel
        '
        Me.CategoryPanel.Controls.Add(Me.CategoryTitle_Label)
        Me.CategoryPanel.Controls.Add(Me.PanelColor)
        Me.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryPanel.Location = New System.Drawing.Point(0, 3)
        Me.CategoryPanel.Name = "CategoryPanel"
        Me.CategoryPanel.Size = New System.Drawing.Size(332, 36)
        Me.CategoryPanel.TabIndex = 1
        '
        'CategoryTitle_Label
        '
        Me.CategoryTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategoryTitle_Label.AutoSize = True
        Me.CategoryTitle_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.CategoryTitle_Label.Location = New System.Drawing.Point(49, 9)
        Me.CategoryTitle_Label.Name = "CategoryTitle_Label"
        Me.CategoryTitle_Label.Size = New System.Drawing.Size(67, 19)
        Me.CategoryTitle_Label.TabIndex = 4
        Me.CategoryTitle_Label.Text = "Categoria"
        '
        'PanelColor
        '
        Me.PanelColor.Controls.Add(Me.CategoryIcon_PictureBox)
        Me.PanelColor.Location = New System.Drawing.Point(15, 4)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(28, 28)
        Me.PanelColor.TabIndex = 2
        '
        'CategoryIcon_PictureBox
        '
        Me.CategoryIcon_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategoryIcon_PictureBox.Location = New System.Drawing.Point(2, 2)
        Me.CategoryIcon_PictureBox.Name = "CategoryIcon_PictureBox"
        Me.CategoryIcon_PictureBox.Size = New System.Drawing.Size(24, 24)
        Me.CategoryIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CategoryIcon_PictureBox.TabIndex = 2
        Me.CategoryIcon_PictureBox.TabStop = False
        '
        'ExpenseCategoryListItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CategoryPanel)
        Me.Name = "ExpenseCategoryListItemControl"
        Me.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Size = New System.Drawing.Size(332, 42)
        Me.CategoryPanel.ResumeLayout(False)
        Me.CategoryPanel.PerformLayout()
        Me.PanelColor.ResumeLayout(False)
        CType(Me.CategoryIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoryPanel As System.Windows.Forms.Panel
    Friend WithEvents CategoryIcon_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CategoryTitle_Label As System.Windows.Forms.Label
    Friend WithEvents PanelColor As Panel
End Class
