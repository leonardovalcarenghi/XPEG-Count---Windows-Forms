<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabPageButton
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
        Me.TabPageButtonTextLabel = New System.Windows.Forms.Label()
        Me.TabPageButtonControl = New System.Windows.Forms.Panel()
        Me.TabPageButtonControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageButtonTextLabel
        '
        Me.TabPageButtonTextLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPageButtonTextLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.TabPageButtonTextLabel.Location = New System.Drawing.Point(0, 0)
        Me.TabPageButtonTextLabel.Name = "TabPageButtonTextLabel"
        Me.TabPageButtonTextLabel.Size = New System.Drawing.Size(200, 40)
        Me.TabPageButtonTextLabel.TabIndex = 2
        Me.TabPageButtonTextLabel.Text = "Informações"
        Me.TabPageButtonTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPageButtonControl
        '
        Me.TabPageButtonControl.Controls.Add(Me.TabPageButtonTextLabel)
        Me.TabPageButtonControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPageButtonControl.Location = New System.Drawing.Point(0, 0)
        Me.TabPageButtonControl.Name = "TabPageButtonControl"
        Me.TabPageButtonControl.Size = New System.Drawing.Size(200, 40)
        Me.TabPageButtonControl.TabIndex = 3
        '
        'TabPageButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabPageButtonControl)
        Me.Name = "TabPageButton"
        Me.Size = New System.Drawing.Size(200, 40)
        Me.TabPageButtonControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPageButtonTextLabel As System.Windows.Forms.Label
    Friend WithEvents TabPageButtonControl As System.Windows.Forms.Panel

End Class
