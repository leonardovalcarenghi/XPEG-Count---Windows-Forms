<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IconSelectItemControl
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
        Me.PictureBox_Icone = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox_Icone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Icone
        '
        Me.PictureBox_Icone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_Icone.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox_Icone.Name = "PictureBox_Icone"
        Me.PictureBox_Icone.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox_Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox_Icone.TabIndex = 0
        Me.PictureBox_Icone.TabStop = False
        '
        'IconSelectItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox_Icone)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "IconSelectItemControl"
        Me.Size = New System.Drawing.Size(50, 50)
        CType(Me.PictureBox_Icone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox_Icone As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
