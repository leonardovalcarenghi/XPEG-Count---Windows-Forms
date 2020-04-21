<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryIconsSeparatorControl
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
        Me.CategoryIcon_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CategoryIcon_Label
        '
        Me.CategoryIcon_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CategoryIcon_Label.AutoSize = True
        Me.CategoryIcon_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.CategoryIcon_Label.Location = New System.Drawing.Point(3, 5)
        Me.CategoryIcon_Label.Name = "CategoryIcon_Label"
        Me.CategoryIcon_Label.Size = New System.Drawing.Size(57, 15)
        Me.CategoryIcon_Label.TabIndex = 76
        Me.CategoryIcon_Label.Text = "Categoria"
        '
        'CategoryIconsSeparatorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CategoryIcon_Label)
        Me.Name = "CategoryIconsSeparatorControl"
        Me.Size = New System.Drawing.Size(550, 25)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoryIcon_Label As Label
End Class
