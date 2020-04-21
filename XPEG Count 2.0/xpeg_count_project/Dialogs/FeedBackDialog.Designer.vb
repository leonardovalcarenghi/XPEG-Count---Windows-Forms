<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedBackDialog
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BorderTitleTop = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_Complemento = New System.Windows.Forms.Label()
        Me.ComplementSubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.Label_Assunto = New System.Windows.Forms.Label()
        Me.LabelTIP_NomeDaDespesa = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"Bugs", "Melhorias", "Reclamações", "Sugestões", "Outros"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(7, 30)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(300, 25)
        Me.SubjectComboBox.TabIndex = 2
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.FullNameTextBox.Location = New System.Drawing.Point(7, 30)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(300, 25)
        Me.FullNameTextBox.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 399)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 1)
        Me.Panel2.TabIndex = 85
        '
        'BorderTitleTop
        '
        Me.BorderTitleTop.BackColor = System.Drawing.Color.DarkBlue
        Me.BorderTitleTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BorderTitleTop.Location = New System.Drawing.Point(1, 0)
        Me.BorderTitleTop.Name = "BorderTitleTop"
        Me.BorderTitleTop.Size = New System.Drawing.Size(728, 1)
        Me.BorderTitleTop.TabIndex = 84
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 400)
        Me.Panel7.TabIndex = 87
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(729, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 400)
        Me.Panel3.TabIndex = 86
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(728, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 359)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(728, 40)
        Me.DialogOptionsPanel.TabIndex = 89
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(617, 5)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Button_Cancel.TabIndex = 73
        Me.Button_Cancel.Text = "&Cancelar"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'Button_OK
        '
        Me.Button_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_OK.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_OK.Location = New System.Drawing.Point(511, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(100, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Enviar"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.AutoScrollMargin = New System.Drawing.Size(30, 30)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel5.Size = New System.Drawing.Size(730, 400)
        Me.Panel5.TabIndex = 88
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.MessageTextBox)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(30, 190)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(670, 150)
        Me.Panel6.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Escreva a mensagem que gostaria de enviar ao desenvolvedor."
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.MessageTextBox.Location = New System.Drawing.Point(7, 27)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.Size = New System.Drawing.Size(656, 100)
        Me.MessageTextBox.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Mensagem"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.EmailTextBox)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.FullNameTextBox)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(30, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(670, 80)
        Me.Panel4.TabIndex = 71
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.EmailTextBox.Location = New System.Drawing.Point(313, 30)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(350, 25)
        Me.EmailTextBox.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(309, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "&E-mail"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Nome Completo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(4, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(323, 15)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Informe o seu nome e seu e-mail para retornamos o contato."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label_Complemento)
        Me.Panel1.Controls.Add(Me.ComplementSubjectComboBox)
        Me.Panel1.Controls.Add(Me.Label_Assunto)
        Me.Panel1.Controls.Add(Me.LabelTIP_NomeDaDespesa)
        Me.Panel1.Controls.Add(Me.SubjectComboBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(30, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 80)
        Me.Panel1.TabIndex = 70
        '
        'Label_Complemento
        '
        Me.Label_Complemento.AutoSize = True
        Me.Label_Complemento.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_Complemento.Location = New System.Drawing.Point(309, 5)
        Me.Label_Complemento.Name = "Label_Complemento"
        Me.Label_Complemento.Size = New System.Drawing.Size(97, 19)
        Me.Label_Complemento.TabIndex = 60
        Me.Label_Complemento.Text = "&Complemento"
        Me.Label_Complemento.Visible = False
        '
        'ComplementSubjectComboBox
        '
        Me.ComplementSubjectComboBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ComplementSubjectComboBox.FormattingEnabled = True
        Me.ComplementSubjectComboBox.Location = New System.Drawing.Point(313, 30)
        Me.ComplementSubjectComboBox.Name = "ComplementSubjectComboBox"
        Me.ComplementSubjectComboBox.Size = New System.Drawing.Size(350, 25)
        Me.ComplementSubjectComboBox.TabIndex = 59
        Me.ComplementSubjectComboBox.Visible = False
        '
        'Label_Assunto
        '
        Me.Label_Assunto.AutoSize = True
        Me.Label_Assunto.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_Assunto.Location = New System.Drawing.Point(3, 5)
        Me.Label_Assunto.Name = "Label_Assunto"
        Me.Label_Assunto.Size = New System.Drawing.Size(59, 19)
        Me.Label_Assunto.TabIndex = 57
        Me.Label_Assunto.Text = "&Assunto"
        '
        'LabelTIP_NomeDaDespesa
        '
        Me.LabelTIP_NomeDaDespesa.AutoSize = True
        Me.LabelTIP_NomeDaDespesa.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_NomeDaDespesa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_NomeDaDespesa.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_NomeDaDespesa.Name = "LabelTIP_NomeDaDespesa"
        Me.LabelTIP_NomeDaDespesa.Size = New System.Drawing.Size(289, 15)
        Me.LabelTIP_NomeDaDespesa.TabIndex = 58
        Me.LabelTIP_NomeDaDespesa.Text = "Selecione o Tipo de FeedBack que você está enviando."
        '
        'FeedBackDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 400)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BorderTitleTop)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FeedBackDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FeedBack"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BorderTitleTop As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label_Complemento As System.Windows.Forms.Label
    Friend WithEvents ComplementSubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Assunto As System.Windows.Forms.Label
    Friend WithEvents LabelTIP_NomeDaDespesa As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MessageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
