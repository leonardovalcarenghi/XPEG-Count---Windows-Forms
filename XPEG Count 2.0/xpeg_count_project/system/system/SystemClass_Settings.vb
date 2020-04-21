Public Class SystemClass_Settings

    Public General As New SettingsClass_General

    Public Customization As New SettingsClass_Customization

    ''' <summary>
    ''' Alterar o Status da Parcela para 'Aguardando Pagamento' em X dias antes de vencer
    ''' </summary>
    Public ChangePlotStatusChangeHowManyDaysBefore As Integer = 7

    Sub LoadSettings()
        'Carregar Configurações da Seção "Geral"
        General.LoadSettings()

        'Carregar Configurações da Seção "Personalização"
        Customization.LoadSettings()

    End Sub

    Sub SaveSettings()

    End Sub



    ''' <summary>
    ''' Performace do Count
    ''' </summary>
    Public Performace As SettingPerformaceEnum













#Region "Enums"

    Enum SettingPerformaceEnum
        Normal
        Custom
        Economic
    End Enum




#End Region
End Class




Public Class SettingsClass_General
    ''' <summary>
    ''' Busca por Atualizações Automaticas
    ''' </summary>
    Public AutoSoftwareCheckForUpdates As Boolean = False

    ''' <summary>
    ''' Mover Para o mês atual no Modo Blocos
    ''' </summary>
    Public MoveToActualMonth As Boolean = True


    ''' <summary>
    ''' Simbolo do Dinheiro (Padrão 'R$')
    ''' </summary>
    Public MoneySymbol As String = "R$"

    Public Sub LoadSettings()
        'Atualizações Automáticas:
        SettingLoad_AutoSoftwareCheckForUpdates()

        'Mover para o mes atual:
        SettingLoad_MoveToActualMonth()

        'Simbolo do dinheiro
        SettingLoad_MoneySymbol()

    End Sub


    ''' <summary>
    ''' Buscar Atualizações Automaticamente
    ''' </summary>
    Sub SettingLoad_AutoSoftwareCheckForUpdates()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\ascfu.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            AutoSoftwareCheckForUpdates = txt
        Else
            AutoSoftwareCheckForUpdates = False
        End If
    End Sub

    ''' <summary>
    ''' Mover para o mes atual no modo calendario
    ''' </summary>
    Sub SettingLoad_MoveToActualMonth()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\mtam.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            MoveToActualMonth = txt
        Else
            MoveToActualMonth = False
        End If
    End Sub

    ''' <summary>
    ''' Simbolo do Dinheiro
    ''' </summary>
    Sub SettingLoad_MoneySymbol()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\mys.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            MoneySymbol = txt
        Else
            MoneySymbol = "R$"
        End If
    End Sub


End Class



Public Class SettingsClass_Customization

    ''' <summary>
    ''' Modo de Visualização do Menu do Count
    ''' </summary>
    Public MenuCountMode As SettingMenuCountModeEnum = SettingMenuCountModeEnum.AlwaysVisible

    ''' <summary>
    ''' Fazer os elementos das interfaces terem as bordas arredondadas
    ''' </summary>
    Public MakeControlsRoundedEdge As Boolean = False


    ''' <summary>
    ''' Cor de Destaque da despesa vai ser no Icone ou no bloco
    ''' </summary>
    Public BlockHighlight As BlockHighlightEnum = BlockHighlightEnum.ColorInIcon



    Enum SettingMenuCountModeEnum : AlwaysVisible : Hidden : End Enum
    Enum BlockHighlightEnum : ColorInBlock : ColorInIcon : End Enum

    Public Sub LoadSettings()
        'Estilo do Menu do Count
        SettingLoad_MenuCountMode()

        'Fazer os elementos das interfaces terem as bordas arredondadas
        SettingLoad_MakeControlsRoundedEdge()

        'Estilo da cor dos blocos de informação
        SettingLoad_BlockHighlight()
    End Sub


    ''' <summary>
    ''' Estilo do Menu do Count
    ''' </summary>
    Sub SettingLoad_MenuCountMode()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\mcm.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            MenuCountMode = txt
        Else
            MenuCountMode = SettingMenuCountModeEnum.AlwaysVisible
        End If
    End Sub

    'Fazer os elementos das interfaces terem as bordas arredondadas
    Sub SettingLoad_MakeControlsRoundedEdge()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\mcre.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            MakeControlsRoundedEdge = txt
        Else
            MakeControlsRoundedEdge = False
        End If
    End Sub

    'Estilo da cor dos blocos de informação
    Sub SettingLoad_BlockHighlight()
        Dim FileSetting = _DIRECTORIES.SettingsPath & "\bhl.xcs"
        If IO.File.Exists(FileSetting) Then
            Dim txt = My.Computer.FileSystem.ReadAllText(FileSetting)
            BlockHighlight = txt
        Else
            BlockHighlight = BlockHighlightEnum.ColorInIcon
        End If
    End Sub
End Class