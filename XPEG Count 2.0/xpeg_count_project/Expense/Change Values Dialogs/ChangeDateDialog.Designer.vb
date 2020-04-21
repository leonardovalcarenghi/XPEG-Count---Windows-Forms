<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeDateDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Date = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel5.SuspendLayout()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.DateTimePicker_Date)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(598, 188)
        Me.Panel5.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 26)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Pressione a tecla 'Enter' para confirmar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tecla 'Esc' para cancelar."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(30, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 21)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "&Alterar Data"
        '
        'DateTimePicker_Date
        '
        Me.DateTimePicker_Date.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_Date.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Date.Location = New System.Drawing.Point(34, 59)
        Me.DateTimePicker_Date.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_Date.Name = "DateTimePicker_Date"
        Me.DateTimePicker_Date.Size = New System.Drawing.Size(244, 25)
        Me.DateTimePicker_Date.TabIndex = 65
        Me.DateTimePicker_Date.Value = New Date(2019, 1, 1, 0, 0, 0, 0)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 188)
        Me.Panel4.TabIndex = 82
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(599, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 188)
        Me.Panel3.TabIndex = 81
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 189)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 1)
        Me.Panel2.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 1)
        Me.Panel1.TabIndex = 79
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.Button_Cancel)
        Me.DialogOptionsPanel.Controls.Add(Me.Button_OK)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 149)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(598, 40)
        Me.DialogOptionsPanel.TabIndex = 84
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button_Cancel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Cancel.Location = New System.Drawing.Point(487, 5)
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
        Me.Button_OK.Location = New System.Drawing.Point(381, 5)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(100, 30)
        Me.Button_OK.TabIndex = 72
        Me.Button_OK.Text = "&Concluído"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'DialogOptionsSeparatorPanel
        '
        Me.DialogOptionsSeparatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.DialogOptionsSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DialogOptionsSeparatorPanel.Location = New System.Drawing.Point(0, 0)
        Me.DialogOptionsSeparatorPanel.Name = "DialogOptionsSeparatorPanel"
        Me.DialogOptionsSeparatorPanel.Size = New System.Drawing.Size(598, 1)
        Me.DialogOptionsSeparatorPanel.TabIndex = 40
        '
        'ChangeDateDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 190)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeDateDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangeDateDialog"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents Button_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel

End Class
