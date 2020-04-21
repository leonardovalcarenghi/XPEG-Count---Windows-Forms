Imports System.IO

Public Class ViewQuestionsOfTopicSelectedControl

    Public TopicSelected_Path As DirectoryInfo

    Private Sub ViewQuestionsOfTopicSelectedControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.Transparent
    End Sub

    Public Sub ImportQuestions()
        Dim ListOfQuestions = _SOFTWARE.GetQuestionsOfTopic(TopicSelected_Path)
        For Each QUESTION As FileInfo In ListOfQuestions
            Dim ItemQuestion As New QuestionHelpItemList
            ItemQuestion.QuestionFile = QUESTION
            Me.Controls.Add(ItemQuestion)
        Next
    End Sub
End Class
