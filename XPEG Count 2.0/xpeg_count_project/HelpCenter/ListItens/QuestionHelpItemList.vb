Public Class QuestionHelpItemList

    Public QuestionFile As IO.FileInfo

    Dim FileHelp As IO.FileInfo

    Private Sub TopicItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top

        ReadThisFile()

    End Sub

    Private Sub ReadThisFile()
        ''Título:
        QuestionNameLabel.Text = _INI.ReadIniFile(QuestionFile.FullName, "INFORMATIONS", "title", "ajuda")

        ''Descrição:
        QuestionDescriptionLabel.Text = _INI.ReadIniFile(QuestionFile.FullName, "INFORMATIONS", "description", "ajuda")

        ''Arquivo:
        Dim F = _INI.ReadIniFile(QuestionFile.FullName, "HELP", "file", "")
        FileHelp = New IO.FileInfo(QuestionFile.Directory.FullName & "\" & F)

    End Sub



    Private Sub ItemPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TopicIconPictureBox.MouseClick, QuestionNameLabel.MouseClick, QuestionDescriptionLabel.MouseClick, ItemPanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim ViewHelp As New ViewHelpDialog
            ViewHelp.Text = Me.QuestionNameLabel.Text
            ViewHelp.FileQuestion = Me.FileHelp
            ViewHelp.ShowDialog()
        End If
    End Sub

    Private Sub ItemPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopicIconPictureBox.MouseDown, QuestionNameLabel.MouseDown, QuestionDescriptionLabel.MouseDown, ItemPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then ItemPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub ItemPanel_MouseEnter(sender As Object, e As EventArgs) Handles TopicIconPictureBox.MouseEnter, QuestionNameLabel.MouseEnter, QuestionDescriptionLabel.MouseEnter, ItemPanel.MouseEnter
        ItemPanel.BackColor = Color.FromArgb(235, 235, 235)
    End Sub

    Private Sub ItemPanel_MouseLeave(sender As Object, e As EventArgs) Handles TopicIconPictureBox.MouseLeave, QuestionNameLabel.MouseLeave, QuestionDescriptionLabel.MouseLeave, ItemPanel.MouseLeave
        ItemPanel.BackColor = Color.Transparent
    End Sub
End Class
