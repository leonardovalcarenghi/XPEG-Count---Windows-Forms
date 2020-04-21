<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimplePayPlotDialog
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DialogOptionsPanel = New System.Windows.Forms.Panel()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.DialogOptionsSeparatorPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel_Date = New System.Windows.Forms.Panel()
        Me.Label_MaturityDate = New System.Windows.Forms.Label()
        Me.DateTimePicker_PayDate = New System.Windows.Forms.DateTimePicker()
        Me.Label_DataDaCompra = New System.Windows.Forms.Label()
        Me.LabelTIP_DataCompra = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel_Comment = New System.Windows.Forms.Panel()
        Me.Label_DescriçãoDaDespesa = New System.Windows.Forms.Label()
        Me.TextBox_PaymentComment = New System.Windows.Forms.TextBox()
        Me.LabelTIP_Desrição = New System.Windows.Forms.Label()
        Me.DialogOptionsPanel.SuspendLayout()
        Me.Panel_Date.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel_Comment.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 1)
        Me.Panel2.TabIndex = 92
        '
        'DialogOptionsPanel
        '
        Me.DialogOptionsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.DialogOptionsPanel.Controls.Add(Me.CancelButton)
        Me.DialogOptionsPanel.Controls.Add(Me.PayButton)
        Me.DialogOptionsPanel.Controls.Add(Me.DialogOptionsSeparatorPanel)
        Me.DialogOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DialogOptionsPanel.Location = New System.Drawing.Point(1, 229)
        Me.DialogOptionsPanel.Name = "DialogOptionsPanel"
        Me.DialogOptionsPanel.Size = New System.Drawing.Size(598, 40)
        Me.DialogOptionsPanel.TabIndex = 96
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.CancelButton.Location = New System.Drawing.Point(487, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(100, 30)
        Me.CancelButton.TabIndex = 73
        Me.CancelButton.Text = "&Cancelar"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PayButton
        '
        Me.PayButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PayButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.PayButton.Location = New System.Drawing.Point(381, 5)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(100, 30)
        Me.PayButton.TabIndex = 72
        Me.PayButton.Text = "&Pagar"
        Me.PayButton.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(599, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel3.Size = New System.Drawing.Size(1, 269)
        Me.Panel3.TabIndex = 93
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 269)
        Me.Panel1.TabIndex = 94
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(600, 1)
        Me.Panel7.TabIndex = 91
        '
        'Panel_Date
        '
        Me.Panel_Date.Controls.Add(Me.Label_MaturityDate)
        Me.Panel_Date.Controls.Add(Me.DateTimePicker_PayDate)
        Me.Panel_Date.Controls.Add(Me.Label_DataDaCompra)
        Me.Panel_Date.Controls.Add(Me.LabelTIP_DataCompra)
        Me.Panel_Date.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Date.Location = New System.Drawing.Point(30, 30)
        Me.Panel_Date.Name = "Panel_Date"
        Me.Panel_Date.Size = New System.Drawing.Size(540, 80)
        Me.Panel_Date.TabIndex = 73
        '
        'Label_MaturityDate
        '
        Me.Label_MaturityDate.Font = New System.Drawing.Font("Segoe UI Semilight", 8.25!)
        Me.Label_MaturityDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label_MaturityDate.Location = New System.Drawing.Point(213, 30)
        Me.Label_MaturityDate.Name = "Label_MaturityDate"
        Me.Label_MaturityDate.Size = New System.Drawing.Size(294, 25)
        Me.Label_MaturityDate.TabIndex = 60
        Me.Label_MaturityDate.Text = "Vencimento: 01/01/2019"
        Me.Label_MaturityDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker_PayDate
        '
        Me.DateTimePicker_PayDate.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker_PayDate.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.DateTimePicker_PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_PayDate.Location = New System.Drawing.Point(7, 30)
        Me.DateTimePicker_PayDate.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_PayDate.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_PayDate.Name = "DateTimePicker_PayDate"
        Me.DateTimePicker_PayDate.Size = New System.Drawing.Size(200, 25)
        Me.DateTimePicker_PayDate.TabIndex = 4
        Me.DateTimePicker_PayDate.Value = New Date(2018, 12, 12, 0, 0, 0, 0)
        '
        'Label_DataDaCompra
        '
        Me.Label_DataDaCompra.AutoSize = True
        Me.Label_DataDaCompra.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DataDaCompra.Location = New System.Drawing.Point(3, 5)
        Me.Label_DataDaCompra.Name = "Label_DataDaCompra"
        Me.Label_DataDaCompra.Size = New System.Drawing.Size(132, 19)
        Me.Label_DataDaCompra.TabIndex = 57
        Me.Label_DataDaCompra.Text = "&Data do Pagamento"
        '
        'LabelTIP_DataCompra
        '
        Me.LabelTIP_DataCompra.AutoSize = True
        Me.LabelTIP_DataCompra.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_DataCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_DataCompra.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_DataCompra.Name = "LabelTIP_DataCompra"
        Me.LabelTIP_DataCompra.Size = New System.Drawing.Size(222, 15)
        Me.LabelTIP_DataCompra.TabIndex = 58
        Me.LabelTIP_DataCompra.Text = "Informe a data do pagamento da parcela."
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.AutoScrollMargin = New System.Drawing.Size(30, 10)
        Me.Panel5.Controls.Add(Me.Panel_Comment)
        Me.Panel5.Controls.Add(Me.Panel_Date)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel5.Size = New System.Drawing.Size(600, 270)
        Me.Panel5.TabIndex = 95
        '
        'Panel_Comment
        '
        Me.Panel_Comment.Controls.Add(Me.Label_DescriçãoDaDespesa)
        Me.Panel_Comment.Controls.Add(Me.TextBox_PaymentComment)
        Me.Panel_Comment.Controls.Add(Me.LabelTIP_Desrição)
        Me.Panel_Comment.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Comment.Location = New System.Drawing.Point(30, 110)
        Me.Panel_Comment.Name = "Panel_Comment"
        Me.Panel_Comment.Size = New System.Drawing.Size(540, 80)
        Me.Panel_Comment.TabIndex = 75
        '
        'Label_DescriçãoDaDespesa
        '
        Me.Label_DescriçãoDaDespesa.AutoSize = True
        Me.Label_DescriçãoDaDespesa.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label_DescriçãoDaDespesa.Location = New System.Drawing.Point(3, 5)
        Me.Label_DescriçãoDaDespesa.Name = "Label_DescriçãoDaDespesa"
        Me.Label_DescriçãoDaDespesa.Size = New System.Drawing.Size(82, 19)
        Me.Label_DescriçãoDaDespesa.TabIndex = 57
        Me.Label_DescriçãoDaDespesa.Text = "&Comentário"
        '
        'TextBox_PaymentComment
        '
        Me.TextBox_PaymentComment.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox_PaymentComment.Location = New System.Drawing.Point(7, 30)
        Me.TextBox_PaymentComment.MaxLength = 200
        Me.TextBox_PaymentComment.Name = "TextBox_PaymentComment"
        Me.TextBox_PaymentComment.Size = New System.Drawing.Size(500, 25)
        Me.TextBox_PaymentComment.TabIndex = 2
        '
        'LabelTIP_Desrição
        '
        Me.LabelTIP_Desrição.AutoSize = True
        Me.LabelTIP_Desrição.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LabelTIP_Desrição.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.LabelTIP_Desrição.Location = New System.Drawing.Point(4, 60)
        Me.LabelTIP_Desrição.Name = "LabelTIP_Desrição"
        Me.LabelTIP_Desrição.Size = New System.Drawing.Size(267, 15)
        Me.LabelTIP_Desrição.TabIndex = 58
        Me.LabelTIP_Desrição.Text = "Escreva um breve comentário sobre o pagamento."
        '
        'SimplePayPlotDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 270)
        Me.Controls.Add(Me.DialogOptionsPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SimplePayPlotDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SimplePayPlotDialog"
        Me.DialogOptionsPanel.ResumeLayout(False)
        Me.Panel_Date.ResumeLayout(False)
        Me.Panel_Date.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel_Comment.ResumeLayout(False)
        Me.Panel_Comment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DialogOptionsPanel As System.Windows.Forms.Panel
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents PayButton As System.Windows.Forms.Button
    Friend WithEvents DialogOptionsSeparatorPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Date As System.Windows.Forms.Panel
    Friend WithEvents Label_MaturityDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_PayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label_DataDaCompra As System.Windows.Forms.Label
    Friend WithEvents LabelTIP_DataCompra As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Comment As System.Windows.Forms.Panel
    Friend WithEvents Label_DescriçãoDaDespesa As System.Windows.Forms.Label
    Friend WithEvents TextBox_PaymentComment As System.Windows.Forms.TextBox
    Friend WithEvents LabelTIP_Desrição As System.Windows.Forms.Label
End Class
