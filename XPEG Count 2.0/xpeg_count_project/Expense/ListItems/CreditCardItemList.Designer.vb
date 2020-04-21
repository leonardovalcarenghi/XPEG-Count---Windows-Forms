<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCardItemList
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
        Me.CategoryPanel = New System.Windows.Forms.Panel()
        Me.CardTitle_Label = New System.Windows.Forms.Label()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.CardIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.CategoryPanel.SuspendLayout()
        Me.PanelColor.SuspendLayout()
        CType(Me.CardIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryPanel
        '
        Me.CategoryPanel.Controls.Add(Me.CardTitle_Label)
        Me.CategoryPanel.Controls.Add(Me.PanelColor)
        Me.CategoryPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryPanel.Location = New System.Drawing.Point(0, 3)
        Me.CategoryPanel.Name = "CategoryPanel"
        Me.CategoryPanel.Size = New System.Drawing.Size(332, 36)
        Me.CategoryPanel.TabIndex = 2
        '
        'CardTitle_Label
        '
        Me.CardTitle_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CardTitle_Label.AutoSize = True
        Me.CardTitle_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.CardTitle_Label.Location = New System.Drawing.Point(49, 9)
        Me.CardTitle_Label.Name = "CardTitle_Label"
        Me.CardTitle_Label.Size = New System.Drawing.Size(116, 19)
        Me.CardTitle_Label.TabIndex = 4
        Me.CardTitle_Label.Text = "Cartão de Crédito"
        '
        'PanelColor
        '
        Me.PanelColor.Controls.Add(Me.CardIcon_PictureBox)
        Me.PanelColor.Location = New System.Drawing.Point(15, 4)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(28, 28)
        Me.PanelColor.TabIndex = 2
        '
        'CardIcon_PictureBox
        '
        Me.CardIcon_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CardIcon_PictureBox.Location = New System.Drawing.Point(2, 2)
        Me.CardIcon_PictureBox.Name = "CardIcon_PictureBox"
        Me.CardIcon_PictureBox.Size = New System.Drawing.Size(23, 24)
        Me.CardIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CardIcon_PictureBox.TabIndex = 2
        Me.CardIcon_PictureBox.TabStop = False
        '
        'CreditCardItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CategoryPanel)
        Me.Name = "CreditCardItemList"
        Me.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Size = New System.Drawing.Size(332, 42)
        Me.CategoryPanel.ResumeLayout(False)
        Me.CategoryPanel.PerformLayout()
        Me.PanelColor.ResumeLayout(False)
        CType(Me.CardIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CategoryPanel As Panel
    Friend WithEvents CardTitle_Label As Label
    Friend WithEvents PanelColor As Panel
    Friend WithEvents CardIcon_PictureBox As PictureBox
End Class
