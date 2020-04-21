<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorSelectItemControl
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
        Me.PictureBox_Color = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_Color, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Color
        '
        Me.PictureBox_Color.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox_Color.Name = "PictureBox_Color"
        Me.PictureBox_Color.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox_Color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_Color.TabIndex = 1
        Me.PictureBox_Color.TabStop = False
        '
        'ColorSelectItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox_Color)
        Me.Name = "ColorSelectItemControl"
        Me.Size = New System.Drawing.Size(40, 40)
        CType(Me.PictureBox_Color, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox_Color As System.Windows.Forms.PictureBox

End Class
