<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthsLabelsForCalendarMode
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
        Me.MonthNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthNameLabel
        '
        Me.MonthNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonthNameLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.MonthNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MonthNameLabel.Location = New System.Drawing.Point(0, 0)
        Me.MonthNameLabel.Name = "MonthNameLabel"
        Me.MonthNameLabel.Size = New System.Drawing.Size(80, 40)
        Me.MonthNameLabel.TabIndex = 77
        Me.MonthNameLabel.Text = "Janeiro"
        Me.MonthNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthsLabelsForCalendarMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MonthNameLabel)
        Me.Name = "MonthsLabelsForCalendarMode"
        Me.Size = New System.Drawing.Size(80, 40)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthNameLabel As System.Windows.Forms.Label

End Class
