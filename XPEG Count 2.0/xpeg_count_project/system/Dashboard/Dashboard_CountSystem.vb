Imports System.IO

Public Class Dashboard_CountSystem

    ''' <summary>
    ''' Valores Pagos
    ''' </summary>
    Public PaidValue As New DashboardPaid_CountSystem

    ''' <summary>
    ''' Valor Que Falta
    ''' </summary>
    Public RestToPay As New DashboardRestToPay_CountSystem

    ''' <summary>
    ''' Valores de Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Public Expenses As New DashboardExpenses_CountSystem

    ''' <summary>
    ''' Valores dos Cartões de Créditos
    ''' </summary>
    Public CreditCards As New DashboardCreditCards_CountSystem

End Class

Public Class DashboardPaid_CountSystem
    ''' <summary>
    ''' Valores Pagos no Mês
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ByMonth(ByVal date_ As Date) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim TotalPaid As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If date_.Month = PlotDate.Month And date_.Year = PlotDate.Year Then TotalPaid += _EXPENSE.Plot.PaidValue(PLOT)
        Next

        ''Retornar:
        Return TotalPaid
    End Function

    ''' <summary>
    ''' Valores Pagos no Ano
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ByYear(ByVal year As Integer) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim TotalPaid As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If year = PlotDate.Year Then TotalPaid += _EXPENSE.Plot.PaidValue(PLOT)
        Next

        ''Retornar:
        Return TotalPaid
    End Function

    ''' <summary>
    ''' Total de Valores Pago
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AllTime() As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim TotalPaid As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots : TotalPaid += _EXPENSE.Plot.PaidValue(PLOT) : Next

        ''Retornar:
        Return TotalPaid
    End Function
End Class


Public Class DashboardRestToPay_CountSystem

    ''' <summary>
    ''' Valores Pagos no Mês
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ByMonth(ByVal date_ As Date) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim RestToPay As Decimal = 0

        ''Coletar Valores Restantes:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If date_.Month = PlotDate.Month And date_.Year = PlotDate.Year Then RestToPay += _EXPENSE.Plot.RestToPay(PLOT)
        Next
        ''Retornar:
        If RestToPay < 0 Then Return 0 Else Return RestToPay
    End Function

    ''' <summary>
    ''' Valores Pagos no Ano
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ByYear(ByVal year As Integer) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim RestToPay As Decimal = 0

        ''Coletar Valores Restantes:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If year = PlotDate.Year Then RestToPay += _EXPENSE.Plot.RestToPay(PLOT)
        Next

        ''Retornar:
        If RestToPay < 0 Then Return 0 Else Return RestToPay
    End Function

    ''' <summary>
    ''' Total de Valores Pago
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AllTime() As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses(True)

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim RestToPay As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots : RestToPay += _EXPENSE.Plot.RestToPay(PLOT) : Next

        ''Retornar:
        If RestToPay < 0 Then Return 0 Else Return RestToPay
    End Function
End Class


Public Class DashboardExpenses_CountSystem

    ''' <summary>
    ''' Total de Despesas no Mês Solicitado
    ''' </summary>
    Public Function ByMonth(ByVal date_ As Date) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses()

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If date_.Year = PlotDate.Year And date_.Month = PlotDate.Month Then ExpensesTotal += _EXPENSE.Plot.TotalValue(PLOT)
        Next

        ''Retornar:
        Return ExpensesTotal
    End Function

    ''' <summary>
    ''' Valores Pagos no Ano
    ''' </summary>
    Public Function ByYear(ByVal year As Integer) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses()

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores das Despesas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ExpenseDate As Date = _EXPENSE.StartDate(EXPENSE)
            If year = ExpenseDate.Year Then ExpensesTotal += _EXPENSE.Values.Total(EXPENSE)
        Next

        ''Retornar:
        Return ExpensesTotal
    End Function

    ''' <summary>
    ''' Total de Valores Pago
    ''' </summary>
    Public Function AllTime() As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _EXPENSES.GetExpenses()

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores das Despesas:
        For Each EXPENSE As String In ListOfExpenses : ExpensesTotal += _EXPENSE.Values.Total(EXPENSE) : Next

        ''Retornar:
        Return ExpensesTotal
    End Function
End Class


Public Class DashboardCreditCards_CountSystem

    ''' <summary>
    ''' Valores Pagos no Mês
    ''' </summary>
    Public Function ByMonth(ByVal date_ As Date) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _CREDITCARDS.GetCards

        ''Lista de Todas as Parcelas de Todas as Despesas:
        Dim ListOfAllPlots As New List(Of DirectoryInfo)

        ''Coletar todas as Parcelas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ListOfExpensePlots = _EXPENSE.Plots.GetPlots(EXPENSE)
            For Each PLOT As DirectoryInfo In ListOfExpensePlots : ListOfAllPlots.Add(PLOT) : Next
        Next

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores Pagos:
        For Each PLOT As DirectoryInfo In ListOfAllPlots
            Dim PlotDate = _EXPENSE.Plot.MaturityDate(PLOT)
            If date_.Year = PlotDate.Year And date_.Month = PlotDate.Month Then ExpensesTotal += _EXPENSE.Plot.TotalValue(PLOT)
        Next

        ''Retornar:
        Return ExpensesTotal
    End Function

    ''' <summary>
    ''' Valores Pagos no Ano
    ''' </summary>
    Public Function ByYear(ByVal year As Integer) As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _CREDITCARDS.GetCards

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores das Despesas:
        For Each EXPENSE As String In ListOfExpenses
            Dim ExpenseDate As Date = _EXPENSE.StartDate(EXPENSE)
            If year = ExpenseDate.Year Then ExpensesTotal += _EXPENSE.Values.Total(EXPENSE)
        Next

        ''Retornar:
        Return ExpensesTotal
    End Function

    ''' <summary>
    ''' Total de Valores Pago
    ''' </summary>
    Public Function AllTime() As Decimal
        ''Obter Lista de Todas as Despesas:
        Dim ListOfExpenses = _CREDITCARDS.GetCards

        ''Declaração de Variável:
        Dim ExpensesTotal As Decimal = 0

        ''Coletar Valores das Despesas:
        For Each EXPENSE As String In ListOfExpenses : ExpensesTotal += _EXPENSE.Values.Total(EXPENSE) : Next

        ''Retornar:
        Return ExpensesTotal
    End Function
End Class