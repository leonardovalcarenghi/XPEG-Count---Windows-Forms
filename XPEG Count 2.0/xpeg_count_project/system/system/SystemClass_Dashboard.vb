Imports System.IO

Public Class SystemClass_Dashboard

    Enum Enum_WhereImportValues : OfMonth : OfYear : AllTime : End Enum

    ''' <summary>
    ''' Obter o numero total de despesas por época
    ''' </summary>
    ''' <param name="whereImport"></param>
    ''' <param name="forDate"></param>
    ''' <returns></returns>
    Public Function Get_CountOfExpenses(ByVal whereImport As Enum_WhereImportValues, ByVal forDate As Date) As Integer
        Dim ExpensesList = _EXPENSES.GetExpenses
        Dim Total As Decimal = 0

        Select Case whereImport
            Case Enum_WhereImportValues.AllTime
                Total = ExpensesList.Count

            Case Enum_WhereImportValues.OfMonth

            Case Enum_WhereImportValues.OfYear

        End Select

        'Retornar o Valor Total das Despesas
        Return Total
    End Function

    ''' <summary>
    ''' Obter Valor Total de Todas as Despesas Cadastradas no Sistema
    ''' </summary>
    ''' <returns></returns>
    Public Function GetValue_TotalOfAllExpenses(ByVal whereImport As Enum_WhereImportValues, ByVal forDate As Date) As Decimal
        Dim ExpensesList = _EXPENSES.GetExpenses
        Dim Total As Decimal = 0

        Select Case whereImport
            Case Enum_WhereImportValues.AllTime
                For Each C As String In ExpensesList
                    ' Total += _EXPENSES.GetTotalValue(C)
                Next

            Case Enum_WhereImportValues.OfMonth

            Case Enum_WhereImportValues.OfYear

        End Select

        'Retornar o Valor Total das Despesas
        Return Total
    End Function

    ''' <summary>
    ''' Obter Valor Total Pago
    ''' </summary>
    ''' <param name="type">Escolher em qual filtro de pagamento (Por mes / Por Ano / Tudo)</param>
    ''' <param name="forDate">Data para obter (Se estiver selecionado 'AllTime' coloque qualquer data só para não dar erro na chamada.)</param>
    ''' <returns></returns>
    Public Function GetValue_TotalPaid(ByVal type As Enum_WhereImportValues, ByVal forDate As Date) As Decimal

        Dim ExpensesList = _EXPENSES.GetExpenses
        Dim Total As Decimal = 0

        Select Case type
            Case Enum_WhereImportValues.OfYear
                For Each A As String In ExpensesList
                    Dim YearOfExpenses As Date = _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & A & "\expense.xcf", "DATES", "startdate")
                    'If YearOfExpenses.Year = forDate.Year Then Total += _EXPENSES.GetTotalValue(A)
                Next

            Case Enum_WhereImportValues.OfMonth
                For Each B As String In ExpensesList
                    Dim YearMonthOfExpense As Date = _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & B & "\expense.xcf", "DATES", "startdate")
                    ' If YearMonthOfExpense.Year = forDate.Year And YearMonthOfExpense.Month = forDate.Month Then Total += _EXPENSES.GetTotalValue(B)
                Next

            Case Enum_WhereImportValues.AllTime
                For Each C As String In ExpensesList
                    '  Total += _EXPENSES.GetTotalValue(C)
                Next
        End Select

        'Retornar o Valor Pago
        Return Total

    End Function

End Class
