<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogItemList
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
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.PanelControl.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelControl.Controls.Add(Me.PictureBox7)
        Me.PanelControl.Controls.Add(Me.Label14)
        Me.PanelControl.Controls.Add(Me.Label_Version)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(350, 50)
        Me.PanelControl.TabIndex = 65
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox7.Image = Global.xpeg_count_project.My.Resources.Resources.Icon_LogVersion_34px
        Me.PictureBox7.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(50, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 15)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Log da Versão"
        '
        'Label_Version
        '
        Me.Label_Version.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label_Version.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Label_Version.Location = New System.Drawing.Point(49, 23)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(35, 20)
        Me.Label_Version.TabIndex = 57
        Me.Label_Version.Text = "text"
        '
        'LogItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl)
        Me.DoubleBuffered = True
        Me.Name = "LogItemList"
        Me.Size = New System.Drawing.Size(350, 50)
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label_Version As System.Windows.Forms.Label

End Class
