Module LanguageModule

    ''' <summary>
    ''' IDIOMA SELECIONADO NO COUNT
    ''' </summary>
    Public _LANGUAGE_SELECTED = "pt-br"

    Public _LANGUAGE As New LanguageClass
End Module

Public Class LanguageClass

    ''' <summary>
    ''' ACESSAR RECURSOS DO PACOTE DE IDIOMAS
    ''' </summary>
    Public RESOURCES As New RESOURCES_Class
    ''' <summary>
    ''' ACESSAR MENSAGENS DO PACOTE DE IDIOMAS
    ''' </summary>
    Public MESSAGES As New MESSAGES_Class
    ''' <summary>
    ''' ACESSAR TITULOS E LEGENDAS DAS TELAS DO PACOTE DE IDIOMAS
    ''' </summary>
    Public SCREENS As New SCREENS_Class

End Class

Public Class RESOURCES_Class

    ''' <summary>
    ''' RECURSOS TRADUZIDOS - Datas (Mês e Dias da Semana)
    ''' </summary>
    Public Dates As New LanguageFile_ResourcesDates

    ''' <summary>
    ''' RECURSOS TRADUZIDOS - Nomes das Categorias Padrões
    ''' </summary>
    Public CategorysDefaultName As New LanguageFile_ResourcesCategorys

End Class
Public Class MESSAGES_Class

End Class
Public Class SCREENS_Class
    ''' <summary>
    ''' TELA - Visualizar Informações das Despesas (ViewExpenseInformations)
    ''' </summary>
    Public S_ViewExpenseInformations As New LanguageFile_ScreenViewExpenseInformations

    ''' <summary>
    ''' TELA - Informações do Software
    ''' </summary>
    Public S_SoftwareAbout As New LanguageFile_Screen_SoftwareAbout

    ''' <summary>
    ''' TELA - Início
    ''' </summary>
    Public S_Home As New LanguageFile_Screen_Home

    ''' <summary>
    ''' TELA - VISUALIZAÇÃO DO FILTRO
    ''' </summary>
    Public S_ViewFilter As New LanguageFile_Screen_ViewFilter
End Class


Public Class LanguageFile_ResourcesDates
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\resources_dates.ini"

    Function GetMonth(ByVal month_number As Integer) As String
        Select Case month_number
            Case 1 : Return Month01
            Case 2 : Return Month02
            Case 3 : Return Month03
            Case 4 : Return Month04
            Case 5 : Return Month05
            Case 6 : Return Month06
            Case 7 : Return Month07
            Case 8 : Return Month08
            Case 9 : Return Month09
            Case 10 : Return Month10
            Case 11 : Return Month11
            Case 12 : Return Month12
            Case Else : Return "error"
        End Select
    End Function

    Public Month01 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "1", "Janeiro")
    Public Month02 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "2", "Fevereiro")
    Public Month03 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "3", "Março")
    Public Month04 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "4", "Abril")
    Public Month05 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "5", "Maio")
    Public Month06 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "6", "Junho")
    Public Month07 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "7", "Julho")
    Public Month08 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "8", "Agosto")
    Public Month09 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "9", "Setembro")
    Public Month10 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "10", "Outubro")
    Public Month11 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "11", "Novembro")
    Public Month12 As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "12", "Dezembro")
    Public MonthComplement As String = _INI.ReadIniFile(FileLanguage, "MONTHS", "complement", "de ")

    Public Day01 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "1", "Domingo")
    Public Day02 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "2", "Segunda")
    Public Day03 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "3", "Terça")
    Public Day04 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "4", "Quarta")
    Public Day05 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "5", "Quinta")
    Public Day06 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "6", "Sexta")
    Public Day07 As String = _INI.ReadIniFile(FileLanguage, "DAYS", "7", "Sábado")
End Class

Public Class LanguageFile_ResourcesCategorys
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\resources_category.ini"

    Function CategoryName(ByVal code As String) As String
        Return _INI.ReadIniFile(FileLanguage, "CATEGORYS", code, "error")
    End Function
End Class

Public Class LanguageFile_ScreenViewExpenseInformations
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\screen_viewexpenseinformations.ini"

    ''TAB CONTROL PAGES''
    Public TabControl01E As String = _INI.ReadIniFile(FileLanguage, "TABCONTROL", "page01_E", "Despesa")
    Public TabControl01C As String = _INI.ReadIniFile(FileLanguage, "TABCONTROL", "page01_C", "Cartão de Crédito")

    Public TabControl02E As String = _INI.ReadIniFile(FileLanguage, "TABCONTROL", "page02_E", "Parcelas")
    Public TabControl02C As String = _INI.ReadIniFile(FileLanguage, "TABCONTROL", "page02_C", "Faturas")

    ''BLOCKS''
    Public Block01_Categoria As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block01", "Categoria")
    Public Block02_ValorDaDespesa As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block02", "Valor da Despesa")
    Public Block03_ValorPago As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block03", "Valor Pago")
    Public Block04_FaltaParaQuitar As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block04", "Falta para Quitar")
    Public Block05_QuantidadeDeParcelas As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block05", "Quantidade de Parcelas")
    Public Block06A_DataInicial As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block06A", "Data Inicial")
    Public Block06B_DataInicial As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block06B", "Data")
    Public Block07_DataFinal As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block07", "Data Final")
    Public Block08_DuracaoDaDespesa As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block08", "Duração da Despesa")
    Public Block09 As String = _INI.ReadIniFile(FileLanguage, "BLOCKS", "block09", "Parcelas Pagas")


    ''QUICK OPTIONS''
    Public OPTIONS01_Nome As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option01", "Nome                                                                  ")
    Public Options02_Descricao As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option02", "Descrição")
    Public Options03_Icone As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option03", "Icone")
    Public Options04_RemoverIcone As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option04", "Remover Icone")
    Public Options05_Categoria As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option05", "Categoria")
    Public Options06_CorDeDestaque As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option06", "Cor de Destaque")
    Public Options07_AdicionarParcela As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option07", "Adicionar Parcela")
    Public Options08_RemoverParcela As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option08", "Remover Parcela")
    Public Options09_Arquivar As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option09", "Arquivar")
    Public Options10_Excluir As String = _INI.ReadIniFile(FileLanguage, "QUICKOPTIONS", "option10", "Excluir")










    ''STATUS''
    Public Status_DespesaFinalizada = _INI.ReadIniFile(FileLanguage, "STATUS", "status01", "Despesa Finalizada")
End Class

Public Class LanguageFile_Screen_SoftwareAbout
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\screen_softwareabout.ini"

    ''LABELS INFORMATIONS''
    Public Label01_Versão As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label01", "Versão")
    Public Label02_Desenvolvedor As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label02", "Desenvolvedor")
    Public Label03A_AnoDeDesenvolvimento As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label03A", "Ano de Desenvolvimento")
    Public Label03B_DesenvolvidoEm As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label03B", "Desenvolvido em 2018")
    Public Label04A_Icones As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label04A", "Icones")
    Public Label04B_FonteDosIcones As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label04B", "Os icones utilizados neste software foram todos disponibilizados por:")
    Public Label05_DireitosAutorais As String = _INI.ReadIniFile(FileLanguage, "INFORMATIONS", "label05", "Direitos Autorais")

    ''BANNER''
    Public BANNER_Label01 As String = _INI.ReadIniFile(FileLanguage, "BANNER", "label01", "Avalie o XPEG Count na Microsoft Store")
    Public BANNER_Label02 As String = _INI.ReadIniFile(FileLanguage, "BANNER", "label02", "Conte-nos como foi sua experiência com o XPEG Count lá na Microsoft Store.")

    ''INSTAGRAM''
    Public INSTA_Label01 As String = _INI.ReadIniFile(FileLanguage, "INSTAGRAM", "label01", "Sugestões? Comentários?" & vbNewLine & "Mande ser Feedback por Direct").Replace("<br/>", vbNewLine)
    Public INSTA_Label02 As String = _INI.ReadIniFile(FileLanguage, "INSTAGRAM", "label02", "Use a câmera do Instagram para ler a TagName e acessar o perfil do desenvolvedor.")

    ''BOTÃO''
    Public Button01_Fechar As String = _INI.ReadIniFile(FileLanguage, "BUTTONS", "button01", "Fechar")

End Class


Public Class LanguageFile_Screen_Home
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\screen_home.ini"

    ''MENU''
    Public MENU01_NovaDespesa As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu01", "Nova Despesa")
    Public MENU02_AddCartão As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu02", "Adicionar Cartão de Crédito")
    Public MENU03_Dashborad As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu03", "Dashboard")
    Public MENU04_Categorias As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu04", "Categorias")
    Public MENU05_Configurações As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu05", "Configurações")
    Public MENU06_Atualizações As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu06", "Verificar Atualizações")
    Public MENU07_Info As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu07", "Sobre")
    Public MENU08_Sair As String = _INI.ReadIniFile(FileLanguage, "MENU", "menu08", "Sair")


    ''DASHBOARD''
    Public Dashboard01_Pago As String = _INI.ReadIniFile(FileLanguage, "DASHBOARD", "dashboard01", "Pago")
    Public Dashboard02_Falta As String = _INI.ReadIniFile(FileLanguage, "DASHBOARD", "dashboard02", "Falta")
    Public Dashboard03_Despesa As String = _INI.ReadIniFile(FileLanguage, "DASHBOARD", "dashboard03", "Despesas")
    Public Dashboard04_Cartão As String = _INI.ReadIniFile(FileLanguage, "DASHBOARD", "dashboard04", "Cartões")


    ''TOOLTIP''
    Public Tip01_ModoCalendario As String = _INI.ReadIniFile(FileLanguage, "TOOLTIP", "tip01", "Mode de Visualização: Calendário")
    Public Tip02_ModoBlocos As String = _INI.ReadIniFile(FileLanguage, "TOOLTIP", "tip02", "Mode de Visualização: Blocos")
    Public Tip03_SelecionarTipoDeFiltro As String = _INI.ReadIniFile(FileLanguage, "TOOLTIP", "tip03", "Selecionar Tipo de Filtro")
    Public Tip04_Filtro As String = _INI.ReadIniFile(FileLanguage, "TOOLTIP", "tip04", "Filtro")

End Class



Public Class LanguageFile_Screen_ViewFilter
    Dim FileLanguage = _DIRECTORIES.LanguagesPath & _LANGUAGE_SELECTED & "\screen_viewfilter.ini"

    ''FORM''
    Public FormTitle As String = _INI.ReadIniFile(FileLanguage, "FORM", "title", "Filtro de Visualização")

    ''FILTER 01''
    Public Filter01_Title As String = _INI.ReadIniFile(FileLanguage, "FILTER01", "title", "Sem Filtro")
    Public Filter01_Description As String = _INI.ReadIniFile(FileLanguage, "FILTER01", "description", "")

    ''FILTER 02''
    Public Filter02_Title As String = _INI.ReadIniFile(FileLanguage, "FILTER02", "title", "Por Categoria")
    Public Filter02_Description As String = _INI.ReadIniFile(FileLanguage, "FILTER02", "description", "")

    ''FILTER 03''
    Public Filter03_Title As String = _INI.ReadIniFile(FileLanguage, "FILTER03", "title", "Por Data")
    Public Filter03_Description As String = _INI.ReadIniFile(FileLanguage, "FILTER03", "description", "")

    ''FILTER 04''
    Public Filter04_Title As String = _INI.ReadIniFile(FileLanguage, "FILTER04", "title", "Data e Categoria")
    Public Filter04_Description As String = _INI.ReadIniFile(FileLanguage, "FILTER04", "description", "")

End Class

