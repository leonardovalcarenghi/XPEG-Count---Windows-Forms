<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionHelpItemList
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
        Me.QuestionDescriptionLabel = New System.Windows.Forms.Label()
        Me.QuestionNameLabel = New System.Windows.Forms.Label()
        Me.ItemPanel.SuspendLayout()
        CType(Me.TopicIconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemPanel
        '
        Me.ItemPanel.Controls.Add(Me.TopicIconPictureBox)
        Me.ItemPanel.Controls.Add(Me.QuestionNameLabel)
        Me.ItemPanel.Controls.Add(Me.QuestionDescriptionLabel)
        Me.ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemPanel.Location = New System.Drawing.Point(0, 0)
        Me.ItemPanel.Name = "ItemPanel"
        Me.ItemPanel.Size = New System.Drawing.Size(400, 34)
        Me.ItemPanel.TabIndex = 5
        '
        'TopicIconPictureBox
        '
        Me.TopicIconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TopicIconPictureBox.BackColor = System.Drawing.Color.Coral
        Me.TopicIconPictureBox.Location = New System.Drawing.Point(15, 5)
        Me.TopicIconPictureBox.Name = "TopicIconPictureBox"
        Me.TopicIconPictureBox.Size = New System.Drawing.Size(5, 25)
        Me.TopicIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.TopicIconPictureBox.TabIndex = 6
        Me.TopicIconPictureBox.TabStop = False
        '
        'QuestionDescriptionLabel
        '
        Me.QuestionDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QuestionDescriptionLabel.AutoSize = True
        Me.QuestionDescriptionLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.QuestionDescriptionLabel.Location = New System.Drawing.Point(30, 19)
        Me.QuestionDescriptionLabel.Name = "QuestionDescriptionLabel"
        Me.QuestionDescriptionLabel.Size = New System.Drawing.Size(89, 15)
        Me.QuestionDescriptionLabel.TabIndex = 4
        Me.QuestionDescriptionLabel.Text = "a little response"
        Me.QuestionDescriptionLabel.Visible = False
        '
        'QuestionNameLabel
        '
        Me.QuestionNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QuestionNameLabel.AutoSize = True
        Me.QuestionNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.QuestionNameLabel.Location = New System.Drawing.Point(23, 8)
        Me.QuestionNameLabel.Name = "QuestionNameLabel"
        Me.QuestionNameLabel.Size = New System.Drawing.Size(66, 19)
        Me.QuestionNameLabel.TabIndex = 3
        Me.QuestionNameLabel.Text = "Question"
        '
        'QuestionHelpItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ItemPanel)
        Me.Name = "QuestionHelpItemList"
        Me.Size = New System.Drawing.Size(400, 34)
        Me.ItemPanel.ResumeLayout(False)
        Me.ItemPanel.PerformLayout()
        CType(Me.TopicIconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ItemPanel As System.Windows.Forms.Panel
    Friend WithEvents QuestionDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionNameLabel As System.Windows.Forms.Label
    Friend WithEvents TopicIconPictureBox As System.Windows.Forms.PictureBox

End Class
