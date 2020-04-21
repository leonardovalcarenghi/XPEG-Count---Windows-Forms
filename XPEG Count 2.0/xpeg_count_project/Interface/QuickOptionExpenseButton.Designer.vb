<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuickOptionExpenseButton
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
        Me.components = New System.ComponentModel.Container()
        Me.QuickButtonIcon = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.QuickButtonIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuickButtonIcon
        '
        Me.QuickButtonIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.QuickButtonIcon.Dock = System.Windows.Forms.DockStyle.Right
        Me.QuickButtonIcon.Location = New System.Drawing.Point(5, 0)
        Me.QuickButtonIcon.Name = "QuickButtonIcon"
        Me.QuickButtonIcon.Padding = New System.Windows.Forms.Padding(10)
        Me.QuickButtonIcon.Size = New System.Drawing.Size(26, 26)
        Me.QuickButtonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QuickButtonIcon.TabIndex = 3
        Me.QuickButtonIcon.TabStop = False
        '
        'QuickOptionExpenseButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.QuickButtonIcon)
        Me.Name = "QuickOptionExpenseButton"
        Me.Size = New System.Drawing.Size(31, 26)
        CType(Me.QuickButtonIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents QuickButtonIcon As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
