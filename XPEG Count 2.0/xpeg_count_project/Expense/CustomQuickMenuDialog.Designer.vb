<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomQuickMenuDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(168, 423)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Salvar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Button 01"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox1.Location = New System.Drawing.Point(24, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(20, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Button 02"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Button 03"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(20, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Button 04"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(20, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 19)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Button 05"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(20, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Button 06"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(20, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Button 07"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox2.Location = New System.Drawing.Point(24, 95)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 72
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox3.Location = New System.Drawing.Point(24, 148)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox3.Sorted = True
        Me.ComboBox3.TabIndex = 73
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox4.Location = New System.Drawing.Point(24, 201)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox4.Sorted = True
        Me.ComboBox4.TabIndex = 74
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox5.Location = New System.Drawing.Point(24, 254)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox5.Sorted = True
        Me.ComboBox5.TabIndex = 75
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox6.Location = New System.Drawing.Point(24, 307)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox6.Sorted = True
        Me.ComboBox6.TabIndex = 76
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"Adicionar Parcela", "Arquivar", "Bloquear Despesa", "Categoria", "Cor de Destaque", "Descrição", "Editar Nome", "Finalizar Despesa", "Fixar Despesa", "Icone", "Local da Compra", "Modo de Visualização", "Pesquisar"})
        Me.ComboBox7.Location = New System.Drawing.Point(24, 360)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(280, 25)
        Me.ComboBox7.Sorted = True
        Me.ComboBox7.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(21, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 30)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "A Personalização é afetada apenas na Despesa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aberta Atualmente."
        '
        'CustomQuickMenuDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(326, 464)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomQuickMenuDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Personalizar Menu de Acesso Rápido"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label8 As Label
End Class
