Public Class Filters_CountSystem

    ''' <summary>
    ''' Aplica os Filtros Selecionados pelo Usuário e Retorna uma Lista com os Resultados | RETORNA LIST OF DE STRING DOS CÓDIGOS DAS DESPESAS
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ApplyFilters(filters As FiltersClass) As List(Of String)
        If filters.enabledFilters = False Then Return _EXPENSES.GetExpenses()

        ''Filtrar Por Data:
        Dim FiltredByDate As List(Of String)
        Select Case filters.dateMode
            Case FiltersClass.dateModeEnum.YearMode : FiltredByDate = FilterBy_SelectedDate(filters.dateSelected.Year)
            Case FiltersClass.dateModeEnum.YearAndMonthMonth : FiltredByDate = FilterBy_SelectedDate(filters.dateSelected.Year, filters.dateSelected.Month)
            Case FiltersClass.dateModeEnum.CompleteDateMode : FiltredByDate = FilterBy_SelectedDate(filters.dateSelected.Year, filters.dateSelected.Month, filters.dateSelected.Day)
            Case FiltersClass.dateModeEnum.PeriodOfTimeMode : FiltredByDate = FilterBy_PeriodOfTime(filters.dateStart, filters.dateEnd)
        End Select

        ''Filtrar por Categoria:
        Dim FiltredByCategory As List(Of String)
        FiltredByCategory = FilterBy_Category(FiltredByDate, filters.categorysSelecteds)


        ''Retorno:
        Return FiltredByCategory
    End Function


#Region "FILTRAR POR DATA"

    Private Function FilterBy_SelectedDate(ByVal year_ As Integer) As List(Of String)
        ''Lista de Despesas:
        Dim ExpensesList = _EXPENSES.GetExpenses()

        ''Lista para Retornar:
        Dim FilterReturnList As New List(Of String)

        ''Loop na Lista de Despesas:
        For Each CODE As String In ExpensesList
            Dim ExpenseDate As Date = _EXPENSE.StartDate(CODE)
            If ExpenseDate.Year = year_ Then FilterReturnList.Add(CODE)
        Next

        ''Retornar Lista Filtrada:
        Return FilterReturnList
    End Function

    Private Function FilterBy_SelectedDate(ByVal year_ As Integer, ByVal month_ As Integer) As List(Of String)
        ''Lista de Despesas:
        Dim ExpensesList = _EXPENSES.GetExpenses()

        ''Lista para Retornar:
        Dim FilterReturnList As New List(Of String)

        ''Loop na Lista de Despesas:
        For Each CODE As String In ExpensesList
            Dim ExpenseDate As Date = _EXPENSE.StartDate(CODE)
            If ExpenseDate.Year = year_ And ExpenseDate.Month = month_ Then FilterReturnList.Add(CODE)
        Next

        ''Retornar Lista Filtrada:
        Return FilterReturnList
    End Function

    Private Function FilterBy_SelectedDate(ByVal year_ As Integer, ByVal month_ As Integer, ByVal day_ As Integer) As List(Of String)
        ''Lista de Despesas:
        Dim ExpensesList = _EXPENSES.GetExpenses()

        ''Lista para Retornar:
        Dim FilterReturnList As New List(Of String)

        ''Loop na Lista de Despesas:
        For Each CODE As String In ExpensesList
            Dim ExpenseDate As Date = _EXPENSE.StartDate(CODE)
            If ExpenseDate.Year = year_ And ExpenseDate.Month = month_ And ExpenseDate.Day = day_ Then FilterReturnList.Add(CODE)
        Next

        ''Retornar Lista Filtrada:
        Return FilterReturnList
    End Function

#End Region

#Region "FILTRAR POR PERIODO DE TEMPO"

    Private Function FilterBy_PeriodOfTime(ByVal dateStart As Date, ByVal dateEnd As Date) As List(Of String)
        ''Lista de Despesas:
        Dim ExpensesList = _EXPENSES.GetExpenses()

        ''Lista para Retornar:
        Dim FilterReturnList As New List(Of String)

        ''Loop na Lista de Despesas:
        For Each CODE As String In ExpensesList
            Dim ExpenseDate As Date = _EXPENSE.StartDate(CODE)
            If ExpenseDate >= dateStart And ExpenseDate >= dateEnd Then FilterReturnList.Add(CODE)
        Next

        ''Retornar Lista Filtrada:
        Return FilterReturnList
    End Function

#End Region

#Region "FILTRAR POR CATEGORIA"

    Private Function FilterBy_Category(ByVal expensesList As List(Of String), ByVal categorysList As List(Of String)) As List(Of String)
        ''Lista para Retornar:
        Dim FilterReturnList As New List(Of String)

        ''Loop na Lista de Despesas:
        For Each CODE As String In ExpensesList
            Dim ExpenseCategory As String = _EXPENSE.Category(CODE)
            If categorysList.Contains(ExpenseCategory) Then FilterReturnList.Add(CODE)
        Next

        If categorysList.Count = 0 Then
            ''Retornar Lista Direto [pois não tem parametros de filtragem]:
            Return expensesList
        Else
            ''Retornar Lista Filtrada:
            Return FilterReturnList
        End If
    End Function

#End Region

End Class


Public Class FiltersClass

    ''' <summary>
    ''' Habilitar Filtros [True = Sim / False = Não]
    ''' </summary>
    ''' <remarks></remarks>
    Public enabledFilters As Boolean = False

    ''' <summary>
    ''' Modo de Data Selecionado para Filtragem
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property dateMode As dateModeEnum
    Enum dateModeEnum : YearMode : YearAndMonthMonth : CompleteDateMode : PeriodOfTimeMode : End Enum

    ''' <summary>
    ''' Data Selecionada [CASO O 'dateMode' SEJA POR YEAR / YEAR MONTH / DATE COMPLETE]
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property dateSelected As Date

    ''' <summary>
    ''' Data Inicial do Periodo [CASO O 'dateMode' SEJA PERIOD OF TIME]
    ''' </summary>
    Public Property dateStart As Date

    ''' <summary>
    ''' Data Final do Periodo [CASO O 'dateMode' SEJA PERIOD OF TIME]
    ''' </summary>
    Public Property dateEnd As Date

    '''<summary>Lista de Categorias Selecionadas | VALOR PODE SER = NULL</summary>'''
    Public Property categorysSelecteds As List(Of String)

End Class