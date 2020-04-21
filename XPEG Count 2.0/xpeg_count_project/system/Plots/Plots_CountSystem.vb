Imports System.IO

Public Class Plots_CountSystem

    ''' <summary>
    ''' Obter Lista das Parcelas da Despesa | RETORNA UM LIST OF DIRECTORYINFO COM OS CAMINHOS (PATH'S) DAS PARCELAS
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function GetPlots(ByVal expense_code As String) As List(Of DirectoryInfo)
        Dim ExpensePath As DirectoryInfo = _EXPENSE.Path(expense_code) 'Drietório da despesa
        Dim PlotsFolderPath As DirectoryInfo = New DirectoryInfo(ExpensePath.FullName & "\plots\") 'Diretório das Parcelas na Despesa
        Dim PlotsFolders() As DirectoryInfo = PlotsFolderPath.GetDirectories 'Obter Pastas das Parcelas
        Dim ListPlots As New List(Of DirectoryInfo) 'Lista de Diretórios das Parcelas

        Dim LIST As New Dictionary(Of Date, DirectoryInfo)
        For Each A As DirectoryInfo In PlotsFolders : LIST.Add(_EXPENSE.Plot.MaturityDate(A), A) : Next

        ' Get list of values
        Dim LIST_DateKeys As List(Of Date) = LIST.Keys.ToList

        ''Ordenar Por Data Crescente:
        LIST_DateKeys.Sort()

        For Each ABC As Date In LIST_DateKeys
            Dim Item_PlotPath As DirectoryInfo
            Item_PlotPath = LIST.Item(ABC)

            ListPlots.Add(Item_PlotPath)
        Next


        '  Dim ListPlotsPath As New List(Of DirectoryInfo)

        ' For Each PLOT As PlotsListJSON In ListPlots : ListPlotsPath.Add(PLOT.PlotPath) : Next


        Return ListPlots
    End Function

    ''' <summary>
    ''' Obter Diretório de uma parcela por seu Número (1 a X) | RETORNA DIRECTORYINFO
    ''' </summary>
    ''' <param name="plot_number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetPlotByNumber(ByVal expense_code As String, ByVal plot_number As Integer) As DirectoryInfo
        Dim ListOfPlots = GetPlots(expense_code)
        Try
            Dim ItemSelected = ListOfPlots.Item(plot_number + 1)
            Return ItemSelected
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Obter Lista de Datas já utilizadas nas parcelas
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DatesOfPlotsUsed(ByVal expense_code As String) As List(Of Date)
        Dim ListOfPlots = GetPlots(expense_code)
        Dim ListDates As New List(Of Date)
        For Each PLOT As DirectoryInfo In ListOfPlots : ListDates.Add(_EXPENSE.Plot.MaturityDate(PLOT)) : Next
        Return ListDates
    End Function

    ''' <summary>
    ''' Obter o Número Total de Parcelas
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function NumberOfPlots(ByVal expense_code As String) As Integer
        Dim ListOfPlots = GetPlots(expense_code)
        Try : Return ListOfPlots.Count : Catch : Return 0 : End Try
    End Function

    ''' <summary>
    ''' Obter o Número Total de Parcelas Finalizadas
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function NumberOfPlotsFinallized(ByVal expense_code As String) As Integer
        Dim ListOfPlots = _EXPENSE.Plots.GetPlots(expense_code)
        Dim Number As Integer = 0
        For Each PLOT As DirectoryInfo In ListOfPlots
            If _EXPENSE.Plot.Status(PLOT) = Plot_CountSystem.StatusPlot.Paid Then Number += 1
        Next
        Return Number
    End Function

    ''' <summary>
    ''' Obter a Primeira Parcela da Despesa | RETORNA O CAMINHO (PATH) DA PARCELA
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function FirstPlot(ByVal expense_code As String) As DirectoryInfo
        Dim ListOfPlots = GetPlots(expense_code)
        Dim FirstItem As DirectoryInfo = ListOfPlots(0)
        Return FirstItem
    End Function

    ''' <summary>
    '''  Obter a Última Parcela da Despesa | RETORNA O CAMINHO (PATH) DA PARCELA
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function LastPlot(ByVal expense_code As String) As DirectoryInfo
        Dim ListOfPlots = GetPlots(expense_code)
        Dim LastItem As DirectoryInfo = ListOfPlots(ListOfPlots.Count - 1)
        Return LastItem
    End Function

    ''' <summary>
    ''' Obter a Parcela mais Cara | RETORNA O PATH DA PARCELA MAIS CARA
    ''' </summary>
    ''' <returns></returns>
    Public Function HigherPlot(ByVal expense_code As String) As DirectoryInfo
        ''Lista de Parcelas da Despesa
        Dim ListOfPlots = GetPlots(expense_code)

        ''Lista com Valores
        Dim ListOfValues As New Dictionary(Of Decimal, DirectoryInfo)

        ''Adicionar na Lista de Valores os valores:
        For Each A As DirectoryInfo In ListOfPlots
            Dim PlotValue As Decimal = _EXPENSE.Plot.TotalValue(A)
            Dim PlotPath As DirectoryInfo = A
            ListOfValues.Add(PlotValue, PlotPath)
        Next

        ''Obter Lista somentos dos 'keys' de ListOfValues
        Dim LIST_ValuesKeys As List(Of Decimal) = ListOfValues.Keys.ToList

        ''Ordenar Por Valor Crescente:
        LIST_ValuesKeys.Sort()
        ''Inverter Lista:
        LIST_ValuesKeys.Reverse()

        ''Valor e Diretório:
        Dim HighValue As Decimal = LIST_ValuesKeys.Item(0)
        Dim HightPath As DirectoryInfo = ListOfValues.Item(HighValue)

        ''Retornar Parcela:
        Return HightPath
    End Function

    ''' <summary>
    ''' Obter a Parcela Mais Baixa
    ''' </summary>
    ''' <returns></returns>
    Public Function LowerPlot(ByVal expense_code As String) As DirectoryInfo
        ''Lista de Parcelas da Despesa
        Dim ListOfPlots = GetPlots(expense_code)

        ''Lista com Valores
        Dim ListOfValues As New Dictionary(Of Decimal, DirectoryInfo)

        ''Adicionar na Lista de Valores os valores:
        For Each A As DirectoryInfo In ListOfPlots
            Dim PlotValue As Decimal = _EXPENSE.Plot.TotalValue(A)
            Dim PlotPath As DirectoryInfo = A
            ListOfValues.Add(PlotValue, PlotPath)
        Next

        ''Obter Lista somentos dos 'keys' de ListOfValues
        Dim LIST_ValuesKeys As List(Of Decimal) = ListOfValues.Keys.ToList

        ''Ordenar Por Valor Crescente:
        LIST_ValuesKeys.Sort()
        ''Inverter Lista:
        'LIST_ValuesKeys.Reverse()

        ''Valor e Diretório:
        Dim LowValue As Decimal = LIST_ValuesKeys.Item(0)
        Dim LowPath As DirectoryInfo = ListOfValues.Item(LowValue)

        ''Retornar Parcela:
        Return LowPath
    End Function

End Class
