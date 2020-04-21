<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpCategoryItemList
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
        Me.CategoryOfHelpNameLabel = New System.Windows.Forms.Label()
        Me.ItemPanel = New System.Windows.Forms.Panel()
        Me.ItemPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoryOfHelpNameLabel
        '
        Me.CategoryOfHelpNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategoryOfHelpNameLabel.AutoSize = True
        Me.CategoryOfHelpNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryOfHelpNameLabel.Location = New System.Drawing.Point(21, 5)
        Me.CategoryOfHelpNameLabel.Name = "CategoryOfHelpNameLabel"
        Me.CategoryOfHelpNameLabel.Size = New System.Drawing.Size(32, 19)
        Me.CategoryOfHelpNameLabel.TabIndex = 3
        Me.CategoryOfHelpNameLabel.Text = "text"
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.CategoryOfHelpNameLabel)
        Me.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(150, 30)
        Me.ItemPanel.TabIndex = 4
        '
        'HelpCategoryItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.ItemPanel)
        Me.Name = "HelpCategoryItemList"
        Me.Size = New System.Drawing.Size(150, 30)
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoryOfHelpNameLabel As System.Windows.Forms.Label
    Friend WithEvents ItemPanel As System.Windows.Forms.Panel

End Class
