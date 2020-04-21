<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseCategoryItemControl
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
        Me.CategoryName_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CategoryName_Label
        '
        Me.CategoryName_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CategoryName_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CategoryName_Label.Location = New System.Drawing.Point(0, 0)
        Me.CategoryName_Label.Name = "CategoryName_Label"
        Me.CategoryName_Label.Size = New System.Drawing.Size(763, 28)
        Me.CategoryName_Label.TabIndex = 8
        Me.CategoryName_Label.Text = "Categoria A"
        Me.CategoryName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpenseCategoryItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CategoryName_Label)
        Me.Name = "ExpenseCategoryItemControl"
        Me.Size = New System.Drawing.Size(763, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoryName_Label As System.Windows.Forms.Label

End Class
