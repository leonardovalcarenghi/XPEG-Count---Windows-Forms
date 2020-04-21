Imports System.IO

Public Class ExpenseValues_CountSystem

    ''' <summary>
    ''' Obter Valor Total da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <param name="IncludeNoValues"> True = Incluir Valores que estão marcados para não calcular </param>
    ''' <returns></returns>
    Public Function Total(ByVal expense_code As String, Optional ByVal IncludeNoValues As Boolean = True) As Decimal
        Dim PlotsList = _EXPENSE.Plots.GetPlots(expense_code)
        Dim TotalOfPlotsList As Decimal = 0

        For Each PLOT As DirectoryInfo In PlotsList
            Dim PlotValue As Decimal = _INI.ReadIniFile(PLOT.FullName & "\plot.xcf", "PLOT", "value", 0)
            Dim noIncludeValue As Boolean = _INI.ReadIniFile(PLOT.FullName & "\plot.xcf", "PLOT", "noInclude", False)

            Select Case IncludeNoValues
                Case True : TotalOfPlotsList += PlotValue
                Case False : If noIncludeValue = False Then TotalOfPlotsList += PlotValue
            End Select

        Next
        Return TotalOfPlotsList
    End Function


    ''' <summary>
    ''' Obter Valor Já Pago na Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <param name="include_values"></param>
    ''' <returns></returns>
    Public Function Paid(ByVal expense_code As String, Optional ByVal include_values As Boolean = False) As Decimal
        Dim PlotsList = _EXPENSE.Plots.GetPlots(expense_code)
        Dim TotalPaid As Decimal = 0
        For Each PLOT As DirectoryInfo In PlotsList
            Dim PlotHistoricList = _EXPENSE.Plot.GetHistoricPayment(PLOT)
            Dim PlotPaid As Decimal = 0
            For Each Historic As FileInfo In PlotHistoricList : PlotPaid += _INI.ReadIniFile(Historic.FullName, "HISTORIC", "value", 0) : Next
            TotalPaid += PlotPaid
        Next
        Return TotalPaid
    End Function


    ''' <summary>
    ''' Obter Valor que Falta Para Quitar a Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function RestToPay(ByVal expense_code As String) As Decimal
        Dim Expense_Total = Total(expense_code, True)
        Dim Expense_Paid = Paid(expense_code)
        Dim Expense_InterestValue = InterestValue(expense_code)
        Dim Rest = Val(Expense_InterestValue + (Expense_Total - Expense_Paid))
        Return Rest
    End Function

    ''' <summary>
    ''' Obter Valor de Descontos Obtidos na Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Discounts(ByVal expense_code As String) As Decimal
        Dim ExpensePlots = _EXPENSE.Plots.GetPlots(expense_code)
        Dim TotalDiscounts As Decimal = 0
        For Each PLOT As DirectoryInfo In ExpensePlots : TotalDiscounts += _EXPENSE.Plot.Discounts(PLOT) : Next
        Return TotalDiscounts
    End Function

    ''' <summary>
    ''' Obter Valor de Juros Pagos Na Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function InterestValue(ByVal expense_code As String) As Decimal
        Dim ExpensePlots = _EXPENSE.Plots.GetPlots(expense_code)
        Dim TotalInterest As Decimal = 0
        For Each PLOT As DirectoryInfo In ExpensePlots : TotalInterest += _EXPENSE.Plot.InterestValue(PLOT) : Next
        Return TotalInterest
    End Function

    ''' <summary>
    ''' Obter Taxas de Juros da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function InterestTax(ByVal expense_code As String, ByVal typeTax As TypeTaxEnum) As Decimal
        Return 1.8
    End Function
    Enum TypeTaxEnum : PerDay : PerMonth : PerYear : End Enum
End Class
