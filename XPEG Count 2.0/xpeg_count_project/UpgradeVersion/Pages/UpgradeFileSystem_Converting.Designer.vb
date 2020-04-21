<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpgradeFileSystem_Converting
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TitleMenuLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer_Convert = New System.Windows.Forms.Timer(Me.components)
        Me.CountLoading1 = New xpeg_count_project.CountLoading()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleMenuLabel
        '
        Me.TitleMenuLabel.AutoSize = True
        Me.TitleMenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.TitleMenuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TitleMenuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleMenuLabel.Location = New System.Drawing.Point(43, -1)
        Me.TitleMenuLabel.Name = "TitleMenuLabel"
        Me.TitleMenuLabel.Size = New System.Drawing.Size(458, 37)
        Me.TitleMenuLabel.TabIndex = 29
        Me.TitleMenuLabel.Text = "Estamos convertendo suas despesas..."
        Me.TitleMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CountLoading1)
        Me.Panel1.Controls.Add(Me.TitleMenuLabel)
        Me.Panel1.Location = New System.Drawing.Point(30, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 40)
        Me.Panel1.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(30, 100)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(843, 317)
        Me.TextBox1.TabIndex = 33
        '
        'Timer_Convert
        '
        Me.Timer_Convert.Interval = 1000
        '
        'CountLoading1
        '
        Me.CountLoading1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CountLoading1.Location = New System.Drawing.Point(0, 0)
        Me.CountLoading1.MaximumSize = New System.Drawing.Size(40, 40)
        Me.CountLoading1.MinimumSize = New System.Drawing.Size(40, 40)
        Me.CountLoading1.Name = "CountLoading1"
        Me.CountLoading1.Size = New System.Drawing.Size(40, 40)
        Me.CountLoading1.TabIndex = 31
        '
        'UpgradeFileSystem_Converting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UpgradeFileSystem_Converting"
        Me.Size = New System.Drawing.Size(876, 417)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleMenuLabel As Label
    Friend WithEvents CountLoading1 As CountLoading
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer_Convert As Timer
End Class
