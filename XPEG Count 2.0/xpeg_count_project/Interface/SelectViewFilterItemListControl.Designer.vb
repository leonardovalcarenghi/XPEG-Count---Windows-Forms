<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectViewFilterItemListControl
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
        Me.FilterName_Label = New System.Windows.Forms.Label()
        Me.FilterPanel = New System.Windows.Forms.Panel()
        Me.FilterDescription_Label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox_Selected = New System.Windows.Forms.PictureBox()
        Me.FilterIcon1_PictureBox = New System.Windows.Forms.PictureBox()
        Me.FilterIcon2_PictureBox = New System.Windows.Forms.PictureBox()
        Me.FilterPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox_Selected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterIcon1_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilterIcon2_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterName_Label
        '
        Me.FilterName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FilterName_Label.AutoSize = True
        Me.FilterName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.FilterName_Label.Location = New System.Drawing.Point(48, 8)
        Me.FilterName_Label.Name = "FilterName_Label"
        Me.FilterName_Label.Size = New System.Drawing.Size(100, 19)
        Me.FilterName_Label.TabIndex = 76
        Me.FilterName_Label.Text = "Nome do Filtro"
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.FilterIcon2_PictureBox)
        Me.FilterPanel.Controls.Add(Me.Panel1)
        Me.FilterPanel.Controls.Add(Me.FilterDescription_Label)
        Me.FilterPanel.Controls.Add(Me.FilterName_Label)
        Me.FilterPanel.Controls.Add(Me.FilterIcon1_PictureBox)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(450, 50)
        Me.FilterPanel.TabIndex = 77
        '
        'FilterDescription_Label
        '
        Me.FilterDescription_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FilterDescription_Label.AutoSize = True
        Me.FilterDescription_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.FilterDescription_Label.Location = New System.Drawing.Point(49, 28)
        Me.FilterDescription_Label.Name = "FilterDescription_Label"
        Me.FilterDescription_Label.Size = New System.Drawing.Size(391, 15)
        Me.FilterDescription_Label.TabIndex = 78
        Me.FilterDescription_Label.Text = "Exibe todas as despesas independente da data ou da categoria da mesma."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox_Selected)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Size = New System.Drawing.Size(10, 50)
        Me.Panel1.TabIndex = 79
        '
        'PictureBox_Selected
        '
        Me.PictureBox_Selected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox_Selected.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox_Selected.Name = "PictureBox_Selected"
        Me.PictureBox_Selected.Size = New System.Drawing.Size(4, 40)
        Me.PictureBox_Selected.TabIndex = 80
        Me.PictureBox_Selected.TabStop = False
        '
        'FilterIcon1_PictureBox
        '
        Me.FilterIcon1_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FilterIcon1_PictureBox.Location = New System.Drawing.Point(10, 9)
        Me.FilterIcon1_PictureBox.Name = "FilterIcon1_PictureBox"
        Me.FilterIcon1_PictureBox.Size = New System.Drawing.Size(32, 32)
        Me.FilterIcon1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FilterIcon1_PictureBox.TabIndex = 77
        Me.FilterIcon1_PictureBox.TabStop = False
        '
        'FilterIcon2_PictureBox
        '
        Me.FilterIcon2_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FilterIcon2_PictureBox.Location = New System.Drawing.Point(26, 25)
        Me.FilterIcon2_PictureBox.Name = "FilterIcon2_PictureBox"
        Me.FilterIcon2_PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.FilterIcon2_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FilterIcon2_PictureBox.TabIndex = 80
        Me.FilterIcon2_PictureBox.TabStop = False
        Me.FilterIcon2_PictureBox.Visible = False
        '
        'SelectViewFilterItemListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FilterPanel)
        Me.Name = "SelectViewFilterItemListControl"
        Me.Size = New System.Drawing.Size(450, 50)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox_Selected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterIcon1_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilterIcon2_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FilterName_Label As System.Windows.Forms.Label
    Friend WithEvents FilterPanel As System.Windows.Forms.Panel
    Friend WithEvents FilterIcon1_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FilterDescription_Label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox_Selected As System.Windows.Forms.PictureBox
    Friend WithEvents FilterIcon2_PictureBox As System.Windows.Forms.PictureBox

End Class
