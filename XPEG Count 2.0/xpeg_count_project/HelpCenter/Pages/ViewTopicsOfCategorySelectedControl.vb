Imports System.IO

Public Class ViewTopicsOfCategorySelectedControl

    Public CategoryOfHelp_Selected As DirectoryInfo
    Public FormFather As HelpCenterForm

    Private Sub ViewTopicsOfCategorySelectedControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.Transparent
    End Sub

    Public Sub ImportTopics()
        Dim ListOfTopics = _SOFTWARE.GetTopicsOfCategory(CategoryOfHelp_Selected)
        For Each TOPIC_PATH As DirectoryInfo In ListOfTopics
            Dim Topic As New TopicItemList
            Topic.TopicPath = TOPIC_PATH
            Topic.FormFather = Me.FormFather
            Me.ListItensPanel.Controls.Add(Topic)
        Next
    End Sub
End Class
