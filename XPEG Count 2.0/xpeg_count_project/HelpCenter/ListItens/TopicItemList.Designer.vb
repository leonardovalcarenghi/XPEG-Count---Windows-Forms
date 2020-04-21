<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopicItemList
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
        Me.ItemPanel = New System.Windows.Forms.Panel()
        Me.TopicIconPictureBox = New System.Windows.Forms.PictureBox()
        Me.TopicDescriptionLabel = New System.Windows.Forms.Label()
        Me.TopicNameLabel = New System.Windows.Forms.Label()
        Me.ItemPanel.SuspendLayout()
        CType(Me.TopicIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.TopicIconPictureBox)
        Me.ItemPanel.Controls.Add(Me.TopicDescriptionLabel)
        Me.ItemPanel.Controls.Add(Me.TopicNameLabel)
        Me.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(400, 50)
        Me.ItemPanel.TabIndex = 5
        '
        'TopicIconPictureBox
        '
        Me.TopicIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TopicIconPictureBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TopicIconPictureBox.Location = New System.Drawing.Point(15, 5)
        Me.TopicIconPictureBox.Name = "TopicIconPictureBox"
        Me.TopicIconPictureBox.Size = New System.Drawing.Size(40, 40)
        Me.TopicIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TopicIconPictureBox.TabIndex = 6
        Me.TopicIconPictureBox.TabStop = False
        '
        'TopicDescriptionLabel
        '
        Me.TopicDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TopicDescriptionLabel.AutoSize = True
        Me.TopicDescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.TopicDescriptionLabel.Location = New System.Drawing.Point(62, 27)
        Me.TopicDescriptionLabel.Name = "TopicDescriptionLabel"
        Me.TopicDescriptionLabel.Size = New System.Drawing.Size(65, 15)
        Me.TopicDescriptionLabel.TabIndex = 4
        Me.TopicDescriptionLabel.Text = "description"
        '
        'TopicNameLabel
        '
        Me.TopicNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TopicNameLabel.AutoSize = True
        Me.TopicNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TopicNameLabel.Location = New System.Drawing.Point(61, 8)
        Me.TopicNameLabel.Name = "TopicNameLabel"
        Me.TopicNameLabel.Size = New System.Drawing.Size(43, 19)
        Me.TopicNameLabel.TabIndex = 3
        Me.TopicNameLabel.Text = "Topic"
        '
        'TopicItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ItemPanel)
        Me.Name = "TopicItemList"
        Me.Size = New System.Drawing.Size(400, 50)
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        CType(Me.TopicIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemPanel As System.Windows.Forms.Panel
    Friend WithEvents TopicDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents TopicNameLabel As System.Windows.Forms.Label
    Friend WithEvents TopicIconPictureBox As System.Windows.Forms.PictureBox

End Class
