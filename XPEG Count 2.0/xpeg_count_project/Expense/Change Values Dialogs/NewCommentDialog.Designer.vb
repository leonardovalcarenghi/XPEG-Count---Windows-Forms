<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCommentDialog
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox_Comment = New System.Windows.Forms.TextBox()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(590, 269)
        Me.Panel5.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(30, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 21)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Título"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TextBox_Title)
        Me.Panel6.Location = New System.Drawing.Point(34, 59)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(400, 25)
        Me.Panel6.TabIndex = 63
        '
        'TextBox_Title
        '
        Me.TextBox_Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Title.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_Title.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Title.MaxLength = 140
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.Size = New System.Drawing.Size(400, 25)
        Me.TextBox_Title.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 269)
        Me.Panel4.TabIndex = 85
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(591, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 269)
        Me.Panel3.TabIndex = 84
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 1)
        Me.Panel2.TabIndex = 83
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 1)
        Me.Panel1.TabIndex = 82
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 230)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(590, 40)
        Me.DialogOptionsPanel.TabIndex = 87
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(479, 5)
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
        Me.Button_OK.Location = New System.Drawing.Point(373, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(100, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Criar"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(590, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(30, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Comentário"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.TextBox_Comment)
        Me.Panel7.Location = New System.Drawing.Point(34, 116)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(523, 76)
        Me.Panel7.TabIndex = 66
        '
        'TextBox_Comment
        '
        Me.TextBox_Comment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Comment.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_Comment.Location = New System.Drawing.Point(0, 0)
        Me.TextBox_Comment.MaxLength = 140
        Me.TextBox_Comment.Multiline = True
        Me.TextBox_Comment.Name = "TextBox_Comment"
        Me.TextBox_Comment.Size = New System.Drawing.Size(523, 76)
        Me.TextBox_Comment.TabIndex = 8
        '
        'NewCommentDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 271)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewCommentDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_Comment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_Title As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel

End Class
