<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCreditCardDialog
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
        Me.ListCards_Panel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_NoResults = New System.Windows.Forms.Label()
        Me.ListCards_Panel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListCards_Panel
        '
        Me.ListCards_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListCards_Panel.AutoScroll = True
        Me.ListCards_Panel.Controls.Add(Me.Label_NoResults)
        Me.ListCards_Panel.Location = New System.Drawing.Point(34, 81)
        Me.ListCards_Panel.Name = "ListCards_Panel"
        Me.ListCards_Panel.Size = New System.Drawing.Size(332, 371)
        Me.ListCards_Panel.TabIndex = 73
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(399, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 498)
        Me.Panel3.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(1, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 1)
        Me.Panel2.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 1)
        Me.Panel1.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 500)
        Me.Panel4.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button_Close)
        Me.Panel5.Controls.Add(Me.ListCards_Panel)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 500)
        Me.Panel5.TabIndex = 29
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Close.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Button_Close.Location = New System.Drawing.Point(318, 458)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(70, 30)
        Me.Button_Close.TabIndex = 74
        Me.Button_Close.Text = "&Fechar"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(30, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 21)
        Me.Label6.TabIndex = 61
        Me.Label6.Tag = ""
        Me.Label6.Text = "Selecione o Cartão de Crédito"
        '
        'Label_NoResults
        '
        Me.Label_NoResults.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_NoResults.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label_NoResults.Location = New System.Drawing.Point(0, 0)
        Me.Label_NoResults.Name = "Label_NoResults"
        Me.Label_NoResults.Size = New System.Drawing.Size(332, 23)
        Me.Label_NoResults.TabIndex = 0
        Me.Label_NoResults.Text = "Nenhum Cartão de Crédito encontrado..."
        Me.Label_NoResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectCreditCardDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectCreditCardDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SelectCreditCardDialog"
        Me.ListCards_Panel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListCards_Panel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button_Close As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label_NoResults As Label
End Class
