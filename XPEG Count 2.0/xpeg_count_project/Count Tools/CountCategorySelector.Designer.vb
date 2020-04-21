<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountCategorySelector
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
        Me.CategoryName_Label = New System.Windows.Forms.Label()
        Me.Btn_Select = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CategoryIcon_PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Btn_Select, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryName_Label
        '
        Me.CategoryName_Label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoryName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.CategoryName_Label.Location = New System.Drawing.Point(5, 0)
        Me.CategoryName_Label.Name = "CategoryName_Label"
        Me.CategoryName_Label.Size = New System.Drawing.Size(367, 28)
        Me.CategoryName_Label.TabIndex = 61
        Me.CategoryName_Label.Text = "nenhuma categoria selecionada..."
        Me.CategoryName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_Select
        '
        Me.Btn_Select.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Btn_Select.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Select.Image = Global.xpeg_count_project.My.Resources.ToolsCountIconsResource.Icon_Categoryzar_24x24
        Me.Btn_Select.Location = New System.Drawing.Point(372, 0)
        Me.Btn_Select.Name = "Btn_Select"
        Me.Btn_Select.Size = New System.Drawing.Size(28, 28)
        Me.Btn_Select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_Select.TabIndex = 62
        Me.Btn_Select.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_Select, "Selecionar Categoria")
        '
        'CategoryIcon_PictureBox
        '
        Me.CategoryIcon_PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.CategoryIcon_PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.CategoryIcon_PictureBox.Name = "CategoryIcon_PictureBox"
        Me.CategoryIcon_PictureBox.Size = New System.Drawing.Size(5, 28)
        Me.CategoryIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CategoryIcon_PictureBox.TabIndex = 1
        Me.CategoryIcon_PictureBox.TabStop = False
        Me.CategoryIcon_PictureBox.Visible = False
        '
        'CountCategorySelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.CategoryName_Label)
        Me.Controls.Add(Me.Btn_Select)
        Me.Controls.Add(Me.CategoryIcon_PictureBox)
        Me.Name = "CountCategorySelector"
        Me.Size = New System.Drawing.Size(400, 28)
        CType(Me.Btn_Select, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoryName_Label As Label
    Friend WithEvents Btn_Select As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CategoryIcon_PictureBox As PictureBox
End Class
