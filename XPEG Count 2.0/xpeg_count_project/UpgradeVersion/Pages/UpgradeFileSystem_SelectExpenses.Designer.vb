<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpgradeFileSystem_SelectExpenses
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
        Me.TitleMenuLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox_Expenses = New System.Windows.Forms.CheckedListBox()
        Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel_SelectNone = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
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
        Me.TitleMenuLabel.Size = New System.Drawing.Size(256, 37)
        Me.TitleMenuLabel.TabIndex = 28
        Me.TitleMenuLabel.Text = "OK, vamos começar!"
        Me.TitleMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(33, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(740, 38)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Abaixo tem uma lista com todas as despesa que encontramos da versão antiga do XPE" &
    "G Count, selecione quais despesas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "você quer migrar para o novo sistema."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(33, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "O QUE VOCÊ PRECISA FAZER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(33, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Mas Atenção:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(33, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(692, 38)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "As despesas que você não optar por atualizar o sistema delas, não poderam ser ace" &
    "ssadas no novo Count, então" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "serão removidadas de seu computador."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(33, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "DESPESAS ENCONTRADAS"
        '
        'CheckedListBox_Expenses
        '
        Me.CheckedListBox_Expenses.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.CheckedListBox_Expenses.FormattingEnabled = True
        Me.CheckedListBox_Expenses.Location = New System.Drawing.Point(37, 253)
        Me.CheckedListBox_Expenses.Name = "CheckedListBox_Expenses"
        Me.CheckedListBox_Expenses.Size = New System.Drawing.Size(300, 144)
        Me.CheckedListBox_Expenses.TabIndex = 39
        '
        'LinkLabel_SelectAll
        '
        Me.LinkLabel_SelectAll.ActiveLinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel_SelectAll.AutoSize = True
        Me.LinkLabel_SelectAll.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LinkLabel_SelectAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_SelectAll.LinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel_SelectAll.Location = New System.Drawing.Point(343, 253)
        Me.LinkLabel_SelectAll.Name = "LinkLabel_SelectAll"
        Me.LinkLabel_SelectAll.Size = New System.Drawing.Size(89, 15)
        Me.LinkLabel_SelectAll.TabIndex = 40
        Me.LinkLabel_SelectAll.TabStop = True
        Me.LinkLabel_SelectAll.Text = "Selecionar Tudo"
        '
        'LinkLabel_SelectNone
        '
        Me.LinkLabel_SelectNone.ActiveLinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel_SelectNone.AutoSize = True
        Me.LinkLabel_SelectNone.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.LinkLabel_SelectNone.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel_SelectNone.LinkColor = System.Drawing.Color.DarkBlue
        Me.LinkLabel_SelectNone.Location = New System.Drawing.Point(343, 271)
        Me.LinkLabel_SelectNone.Name = "LinkLabel_SelectNone"
        Me.LinkLabel_SelectNone.Size = New System.Drawing.Size(109, 15)
        Me.LinkLabel_SelectNone.TabIndex = 41
        Me.LinkLabel_SelectNone.TabStop = True
        Me.LinkLabel_SelectNone.Text = "Selecionar Nenhum"
        '
        'UpgradeFileSystem_SelectExpenses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.Controls.Add(Me.LinkLabel_SelectNone)
        Me.Controls.Add(Me.LinkLabel_SelectAll)
        Me.Controls.Add(Me.CheckedListBox_Expenses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleMenuLabel)
        Me.Name = "UpgradeFileSystem_SelectExpenses"
        Me.Size = New System.Drawing.Size(876, 417)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleMenuLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckedListBox_Expenses As CheckedListBox
    Friend WithEvents LinkLabel_SelectAll As LinkLabel
    Friend WithEvents LinkLabel_SelectNone As LinkLabel
End Class
