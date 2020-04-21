Imports System.IO
Imports System.Globalization

Public Class Software_CountSystem


    ''' <summary>
    ''' Obter Todos os Logs do Software | RETORNA UMA LISTA COM O CAMINHO COMPLETO DOS ARQUIVOS
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetLogs() As List(Of FileInfo)
        Dim LogsPathSystem As DirectoryInfo = New DirectoryInfo(My.Application.Info.DirectoryPath & "\logs\")
        Dim LogFiles() As FileInfo = LogsPathSystem.GetFiles()
        Dim ListOfLogs As New List(Of FileInfo)
        For Each A As FileInfo In LogFiles : ListOfLogs.Add(A) : Next
        Return ListOfLogs
    End Function

    ''' <summary>
    ''' Obter Categorias de Ajuda
    ''' </summary>
    Function GetHelpCategorys() As List(Of DirectoryInfo)
        Dim HelpPathSystem As DirectoryInfo = _DIRECTORIES.HelpPath
        Dim CategorysFolders() As DirectoryInfo = HelpPathSystem.GetDirectories()
        Dim ListOfCategorys As New List(Of DirectoryInfo)
        For Each FOLDER As DirectoryInfo In CategorysFolders : ListOfCategorys.Add(FOLDER) : Next
        Return ListOfCategorys
    End Function

    ''' <summary>
    ''' Obter Topicos da Categoria Selecionada
    ''' </summary>
    Function GetTopicsOfCategory(ByVal category_selected As DirectoryInfo) As List(Of DirectoryInfo)
        Dim HelpPathSystem As DirectoryInfo = category_selected
        Dim TopicsFolders() As DirectoryInfo = HelpPathSystem.GetDirectories()
        Dim ListOfTopics As New List(Of DirectoryInfo)
        For Each FOLDER As DirectoryInfo In TopicsFolders : ListOfTopics.Add(FOLDER) : Next
        Return ListOfTopics
    End Function

    ''' <summary>
    ''' Obter Questões de Ajuda do Tópico Selecionado
    ''' </summary>
    Function GetQuestionsOfTopic(ByVal topic_selected As DirectoryInfo) As List(Of FileInfo)
        Dim TopicPath As DirectoryInfo = topic_selected
        Dim QuestionsFiles() As FileInfo = TopicPath.GetFiles()
        Dim ListOfQuestions As New List(Of FileInfo)
        For Each QUESTION As FileInfo In QuestionsFiles : If QUESTION.Extension = ".xcf" Then ListOfQuestions.Add(QUESTION)
        Next
        Return ListOfQuestions
    End Function

    ''' <summary>
    ''' Verificar se as Configurações de Data e Hora do Windows são compatíveis com o XPEG Count.
    ''' </summary>
    Function CheckCulture() As Boolean
        ''Obter Configuração de Cultura do Windows:
        Dim CultureOfWindows As New CultureInfo(CultureInfo.CurrentCulture.ToString)
        ''Formato de Data e Hora Selecionados no Windows:
        Dim FormatDateRegion = CultureOfWindows.DateTimeFormat.ShortDatePattern
        ''Verificar se a Data e Hora do Windows são compativeis com o Count:
        If FormatDateRegion <> "dd/MM/yyyy" Then Return False Else Return True
    End Function

End Class
