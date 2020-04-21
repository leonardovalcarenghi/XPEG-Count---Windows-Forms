<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardsGraphicsDialog
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Me.HomeCount_DashboardPage_Control1 = New xpeg_count_project.HomeCount_DashboardPage_Control()
        Me.SuspendLayout()
        '
        'HomeCount_DashboardPage_Control1
        '
        Me.HomeCount_DashboardPage_Control1.BackColor = System.Drawing.Color.Transparent
        Me.HomeCount_DashboardPage_Control1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HomeCount_DashboardPage_Control1.Location = New System.Drawing.Point(0, 0)
        Me.HomeCount_DashboardPage_Control1.Name = "HomeCount_DashboardPage_Control1"
        Me.HomeCount_DashboardPage_Control1.Size = New System.Drawing.Size(730, 342)
        Me.HomeCount_DashboardPage_Control1.TabIndex = 0
        '
        'DashboardsGraphicsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 342)
        Me.Controls.Add(Me.HomeCount_DashboardPage_Control1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DashboardsGraphicsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatórios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeCount_DashboardPage_Control1 As HomeCount_DashboardPage_Control
End Class
