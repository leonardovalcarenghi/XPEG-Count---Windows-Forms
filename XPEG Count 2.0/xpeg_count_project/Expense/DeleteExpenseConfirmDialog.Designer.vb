<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteExpenseConfirmDialog
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExpenseValueLabel = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ExpenseCategoryLabel = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExpenseNameLabel = New System.Windows.Forms.Label()
        Me.TitleMenuLabel = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.TitleMenuLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(698, 258)
        Me.Panel5.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(31, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Esta ação não pode ser desfeita, uma vez excluida não é possível restaura-la."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(31, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "IMPORTANTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.ExpenseValueLabel)
        Me.Panel8.Location = New System.Drawing.Point(35, 140)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(276, 19)
        Me.Panel8.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Valor:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpenseValueLabel
        '
        Me.ExpenseValueLabel.AutoEllipsis = True
        Me.ExpenseValueLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseValueLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpenseValueLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ExpenseValueLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExpenseValueLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExpenseValueLabel.Location = New System.Drawing.Point(76, 0)
        Me.ExpenseValueLabel.Name = "ExpenseValueLabel"
        Me.ExpenseValueLabel.Size = New System.Drawing.Size(200, 19)
        Me.ExpenseValueLabel.TabIndex = 36
        Me.ExpenseValueLabel.Text = "R$ 0,00"
        Me.ExpenseValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.ExpenseCategoryLabel)
        Me.Panel7.Location = New System.Drawing.Point(35, 113)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(276, 19)
        Me.Panel7.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Categoria:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpenseCategoryLabel
        '
        Me.ExpenseCategoryLabel.AutoEllipsis = True
        Me.ExpenseCategoryLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseCategoryLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpenseCategoryLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ExpenseCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExpenseCategoryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExpenseCategoryLabel.Location = New System.Drawing.Point(76, 0)
        Me.ExpenseCategoryLabel.Name = "ExpenseCategoryLabel"
        Me.ExpenseCategoryLabel.Size = New System.Drawing.Size(200, 19)
        Me.ExpenseCategoryLabel.TabIndex = 34
        Me.ExpenseCategoryLabel.Text = "Test"
        Me.ExpenseCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.ExpenseNameLabel)
        Me.Panel6.Location = New System.Drawing.Point(35, 86)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(276, 19)
        Me.Panel6.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Despesa:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpenseNameLabel
        '
        Me.ExpenseNameLabel.AutoEllipsis = True
        Me.ExpenseNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ExpenseNameLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpenseNameLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.ExpenseNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ExpenseNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ExpenseNameLabel.Location = New System.Drawing.Point(76, 0)
        Me.ExpenseNameLabel.Name = "ExpenseNameLabel"
        Me.ExpenseNameLabel.Size = New System.Drawing.Size(200, 19)
        Me.ExpenseNameLabel.TabIndex = 32
        Me.ExpenseNameLabel.Text = "Renner Test"
        Me.ExpenseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TitleMenuLabel
        '
        Me.TitleMenuLabel.AutoSize = True
        Me.TitleMenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.TitleMenuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TitleMenuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleMenuLabel.Location = New System.Drawing.Point(30, 30)
        Me.TitleMenuLabel.Name = "TitleMenuLabel"
        Me.TitleMenuLabel.Size = New System.Drawing.Size(313, 37)
        Me.TitleMenuLabel.TabIndex = 30
        Me.TitleMenuLabel.Text = "Deseja realmente excluir?"
        Me.TitleMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.CancelButton)
        Me.DialogOptionsPanel.Controls.Add(Me.DeleteButton)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 259)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(698, 40)
        Me.DialogOptionsPanel.TabIndex = 90
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.CancelButton.Location = New System.Drawing.Point(587, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(100, 30)
        Me.CancelButton.TabIndex = 73
        Me.CancelButton.Text = "&Cancelar"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DeleteButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.DeleteButton.Location = New System.Drawing.Point(461, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(120, 30)
        Me.DeleteButton.TabIndex = 72
        Me.DeleteButton.Text = "&Excluir Despesa"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(698, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 298)
        Me.Panel4.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(699, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 298)
        Me.Panel3.TabIndex = 87
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 299)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 1)
        Me.Panel2.TabIndex = 86
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 1)
        Me.Panel1.TabIndex = 85
        '
        'DeleteExpenseConfirmDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 300)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteExpenseConfirmDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ExpenseValueLabel As System.Windows.Forms.Label
    Friend WithEvents ExpenseCategoryLabel As System.Windows.Forms.Label
    Friend WithEvents ExpenseNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TitleMenuLabel As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
