Public Class TopicItemList

    Public TopicPath As IO.DirectoryInfo
    Public FormFather As HelpCenterForm

    Private Sub TopicItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        TopicNameLabel.Text = TopicPath.Name
    End Sub


    Private Sub ItemPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TopicNameLabel.MouseClick, TopicIconPictureBox.MouseClick, TopicDescriptionLabel.MouseClick, ItemPanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormFather.PagesControlsPanel.Controls.Clear()
            Dim QuestionsPage As New ViewQuestionsOfTopicSelectedControl
            QuestionsPage.TopicSelected_Path = Me.TopicPath
            QuestionsPage.ImportQuestions()
            FormFather.PagesControlsPanel.Controls.Add(QuestionsPage)
            MyBase.OnMouseClick(e)
        End If
    End Sub

    Private Sub ItemPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopicNameLabel.MouseDown, TopicIconPictureBox.MouseDown, TopicDescriptionLabel.MouseDown, ItemPanel.MouseDown
           If e.Button = Windows.Forms.MouseButtons.Left Then ItemPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub ItemPanel_MouseEnter(sender As Object, e As EventArgs) Handles TopicNameLabel.MouseEnter, TopicIconPictureBox.MouseEnter, TopicDescriptionLabel.MouseEnter, ItemPanel.MouseEnter
        ItemPanel.BackColor = Color.FromArgb(235, 235, 235)
    End Sub

    Private Sub ItemPanel_MouseLeave(sender As Object, e As EventArgs) Handles TopicNameLabel.MouseLeave, TopicIconPictureBox.MouseLeave, TopicDescriptionLabel.MouseLeave, ItemPanel.MouseLeave
        ItemPanel.BackColor = Color.Transparent
    End Sub
End Class
