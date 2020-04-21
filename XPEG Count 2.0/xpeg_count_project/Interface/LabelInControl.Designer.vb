<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabelInControl
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
        Me.LabelText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelText
        '
        Me.LabelText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelText.AutoSize = True
        Me.LabelText.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelText.Location = New System.Drawing.Point(10, 7)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(203, 17)
        Me.LabelText.TabIndex = 0
        Me.LabelText.Text = "Nenhuma despesa encontrada..."
        '
        'LabelInControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelText)
        Me.Name = "LabelInControl"
        Me.Size = New System.Drawing.Size(500, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelText As System.Windows.Forms.Label

End Class
