<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTopicsOfCategorySelectedControl
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
        Me.ListItensPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ListItensPanel
        '
        Me.ListItensPanel.AutoScroll = True
        Me.ListItensPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListItensPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListItensPanel.Name = "ListItensPanel"
        Me.ListItensPanel.Padding = New System.Windows.Forms.Padding(30)
        Me.ListItensPanel.Size = New System.Drawing.Size(1028, 474)
        Me.ListItensPanel.TabIndex = 0
        '
        'ViewTopicsOfCategorySelectedControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListItensPanel)
        Me.Name = "ViewTopicsOfCategorySelectedControl"
        Me.Size = New System.Drawing.Size(1028, 474)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListItensPanel As System.Windows.Forms.Panel

End Class
