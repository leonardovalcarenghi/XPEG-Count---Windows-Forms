<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseBlockItemControl
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
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
        Me.ExpensePanel = New System.Windows.Forms.Panel()
        Me.RestToPay_Label = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ExpenseValue_Label = New System.Windows.Forms.Label()
        Me.ExpenseName_Label = New System.Windows.Forms.Label()
        Me.ExpenseIcon_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ExpenseDescription_Label = New System.Windows.Forms.Label()
        Me.FileWatcher_Values = New System.IO.FileSystemWatcher()
        Me.ExpensePanel.SuspendLayout()
        CType(Me.ExpenseIcon_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileWatcher_Values, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpensePanel
        '
        Me.ExpensePanel.BackColor = System.Drawing.Color.AliceBlue
        Me.ExpensePanel.Controls.Add(Me.RestToPay_Label)
        Me.ExpensePanel.Controls.Add(Me.Panel4)
        Me.ExpensePanel.Controls.Add(Me.Panel1)
        Me.ExpensePanel.Controls.Add(Me.Panel3)
        Me.ExpensePanel.Controls.Add(Me.Panel2)
        Me.ExpensePanel.Controls.Add(Me.ExpenseValue_Label)
        Me.ExpensePanel.Controls.Add(Me.ExpenseName_Label)
        Me.ExpensePanel.Controls.Add(Me.ExpenseIcon_PictureBox)
        Me.ExpensePanel.Controls.Add(Me.ExpenseDescription_Label)
        Me.ExpensePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpensePanel.Location = New System.Drawing.Point(5, 5)
        Me.ExpensePanel.Name = "ExpensePanel"
        Me.ExpensePanel.Size = New System.Drawing.Size(490, 80)
        Me.ExpensePanel.TabIndex = 3
        '
        'RestToPay_Label
        '
        Me.RestToPay_Label.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RestToPay_Label.AutoSize = True
        Me.RestToPay_Label.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestToPay_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.RestToPay_Label.Location = New System.Drawing.Point(362, 46)
        Me.RestToPay_Label.Name = "RestToPay_Label"
        Me.RestToPay_Label.Size = New System.Drawing.Size(85, 15)
        Me.RestToPay_Label.TabIndex = 18
        Me.RestToPay_Label.Text = "Falta: R$ 999,99"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(489, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 78)
        Me.Panel4.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 78)
        Me.Panel1.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(490, 1)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(490, 1)
        Me.Panel2.TabIndex = 14
        '
        'ExpenseValue_Label
        '
        Me.ExpenseValue_Label.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ExpenseValue_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseValue_Label.Location = New System.Drawing.Point(361, 19)
        Me.ExpenseValue_Label.Name = "ExpenseValue_Label"
        Me.ExpenseValue_Label.Size = New System.Drawing.Size(122, 30)
        Me.ExpenseValue_Label.TabIndex = 13
        Me.ExpenseValue_Label.Text = "R$ 999,99"
        Me.ExpenseValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpenseName_Label
        '
        Me.ExpenseName_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpenseName_Label.AutoEllipsis = True
        Me.ExpenseName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ExpenseName_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ExpenseName_Label.Location = New System.Drawing.Point(68, 29)
        Me.ExpenseName_Label.Name = "ExpenseName_Label"
        Me.ExpenseName_Label.Size = New System.Drawing.Size(281, 21)
        Me.ExpenseName_Label.TabIndex = 7
        Me.ExpenseName_Label.Text = "Nome da minha Despesa"
        '
        'ExpenseIcon_PictureBox
        '
        Me.ExpenseIcon_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ExpenseIcon_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpenseIcon_PictureBox.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_Category_Money_32x32
        Me.ExpenseIcon_PictureBox.Location = New System.Drawing.Point(15, 15)
        Me.ExpenseIcon_PictureBox.Name = "ExpenseIcon_PictureBox"
        Me.ExpenseIcon_PictureBox.Size = New System.Drawing.Size(50, 50)
        Me.ExpenseIcon_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ExpenseIcon_PictureBox.TabIndex = 1
        Me.ExpenseIcon_PictureBox.TabStop = False
        '
        'ExpenseDescription_Label
        '
        Me.ExpenseDescription_Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExpenseDescription_Label.AutoEllipsis = True
        Me.ExpenseDescription_Label.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpenseDescription_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ExpenseDescription_Label.Location = New System.Drawing.Point(69, 45)
        Me.ExpenseDescription_Label.Name = "ExpenseDescription_Label"
        Me.ExpenseDescription_Label.Size = New System.Drawing.Size(280, 15)
        Me.ExpenseDescription_Label.TabIndex = 8
        Me.ExpenseDescription_Label.Text = "Descrição"
        '
        'FileWatcher_Values
        '
        Me.FileWatcher_Values.EnableRaisingEvents = True
        Me.FileWatcher_Values.IncludeSubdirectories = True
        Me.FileWatcher_Values.NotifyFilter = System.IO.NotifyFilters.LastWrite
        Me.FileWatcher_Values.SynchronizingObject = Me
        '
        'ExpenseBlockItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.ExpensePanel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ExpenseBlockItemControl"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Size = New System.Drawing.Size(500, 90)
        Me.ExpensePanel.ResumeLayout(False)
        Me.ExpensePanel.PerformLayout()
        CType(Me.ExpenseIcon_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileWatcher_Values, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExpensePanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ExpenseValue_Label As System.Windows.Forms.Label
    Friend WithEvents ExpenseDescription_Label As System.Windows.Forms.Label
    Friend WithEvents ExpenseName_Label As System.Windows.Forms.Label
    Friend WithEvents ExpenseIcon_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RestToPay_Label As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FileWatcher_Values As IO.FileSystemWatcher
End Class
