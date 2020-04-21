Imports System.IO

Public Class HelpCategoryItemList

    Public CategoryOfHelp_Path As DirectoryInfo
    Public FormFather As HelpCenterForm

    Private Sub HelpCategoryItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Left
        Me.BackColor = Color.Transparent

        ''Obter Nome:
        CategoryOfHelpNameLabel.Text = CategoryOfHelp_Path.Name


        Me.Width = Val(21 + CategoryOfHelpNameLabel.Width + 10)
        CategoryOfHelpNameLabel.Left = (Me.Width - CategoryOfHelpNameLabel.Width) / 2
    End Sub

    Private Sub ItemPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles ItemPanel.MouseClick, CategoryOfHelpNameLabel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FormFather.PagesControlsPanel.Controls.Clear()
            Dim TopicsPage As New ViewTopicsOfCategorySelectedControl
            TopicsPage.FormFather = Me.FormFather
            TopicsPage.CategoryOfHelp_Selected = Me.CategoryOfHelp_Path
            TopicsPage.ImportTopics()
            FormFather.PagesControlsPanel.Controls.Add(TopicsPage)
            MyBase.OnMouseClick(e)
        End If
    End Sub

    Private Sub ItemPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles ItemPanel.MouseDown, CategoryOfHelpNameLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then ItemPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub ItemPanel_MouseEnter(sender As Object, e As EventArgs) Handles ItemPanel.MouseEnter, CategoryOfHelpNameLabel.MouseEnter
        ItemPanel.BackColor = Color.FromArgb(235, 235, 235)
    End Sub

    Private Sub ItemPanel_MouseLeave(sender As Object, e As EventArgs) Handles ItemPanel.MouseLeave, CategoryOfHelpNameLabel.MouseLeave
        ItemPanel.BackColor = Color.Transparent
    End Sub
End Class
