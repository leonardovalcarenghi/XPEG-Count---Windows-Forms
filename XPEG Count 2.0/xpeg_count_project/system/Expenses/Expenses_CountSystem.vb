Imports System.IO

Public Class Expenses_CountSystem

    ''' <summary>
    ''' Obter Lista com Todas as Despesas Cadastradas | RETORNA UM LIST OF COM OS CÓDIGOS DAS DESPESAS
    ''' </summary>
    Public Function GetExpenses(Optional ByVal importCreditCards As Boolean = False) As List(Of String)
        ''Diretório das Despesas:
        Dim ExpensesPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        ''Pastas de Despesas:
        Dim ExpensesList() As DirectoryInfo = ExpensesPath.GetDirectories()

        ''Lista de Códigos de Despesas:
        Dim ListOfExpenses As New List(Of String)
        For Each EXPENSE As DirectoryInfo In ExpensesList
            If IO.File.Exists(EXPENSE.FullName & "\expense.xcf") Then
                Dim ExpenseCategory = _INI.ReadIniFile(EXPENSE.FullName & "\expense.xcf", "EXPENSE", "category", "")
                Select Case importCreditCards
                    Case False : If Not ExpenseCategory = "XC.CATEGORY_CREDITCARD" Then ListOfExpenses.Add(EXPENSE.Name)
                    Case True : ListOfExpenses.Add(EXPENSE.Name)
                End Select
            End If

        Next

        Return ListOfExpenses
        'DEPOIS VERIFICAR SE A DESPESA NÃO É UM CARTÃO DE CRÉDITO
    End Function

    ''' <summary>
    ''' Obter Lista com Nomes de Despesas Já Utilizadas
    ''' </summary>
    Public Function GetNames() As List(Of String)
        Dim ListOfExpenses = GetExpenses(False)
        Dim ListOfNames As New List(Of String)
        For Each EXPENSE As String In ListOfExpenses
            Dim ExpenseName As String = _EXPENSE.Name(EXPENSE)
            If Not ListOfNames.Contains(ExpenseName) Then ListOfNames.Add(ExpenseName)
        Next
        Return ListOfNames
    End Function

    ''' <summary>
    ''' Obter Despesas que possuem Parcelas no Ano Selecionado | RETORNA UM LIST OF COM OS CÓDIGOS DAS DESPESAS
    ''' </summary>
    Public Function GetExpensesOfDate(ByVal year_selected As Integer) As List(Of String)
        ''Obter Lista de Todas as Despesas:
        Dim ExpensesList = GetExpenses(False)

        ''Lista de Retorno:
        Dim ListOfExpenses As New List(Of String)

        ''Loop das Despesas:
        For Each EXPENSE As String In ExpensesList
            'Obter diretórios das parcelas da Despesa
            Dim Plots As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(EXPENSE)
            ''Loop das Parcelas:
            For Each PLOT_OF_EXPENSE As DirectoryInfo In Plots
                'Data da Parcela:
                Dim Plot_Date As Date = _EXPENSE.Plot.MaturityDate(PLOT_OF_EXPENSE)
                'Adicionar Despesa à Lista:
                If Plot_Date.Year = year_selected Then
                    If Not ListOfExpenses.Contains(EXPENSE) Then ListOfExpenses.Add(EXPENSE)
                End If

            Next
        Next
        ''Retorno:
        Return ListOfExpenses
    End Function


    ''' <summary>
    ''' Obter Despesas que possuem Parcelas no Ano e Mês Selecionado | RETORNA UM LIST OF COM OS CÓDIGOS DAS DESPESAS
    ''' </summary>
    Public Function GetExpensesOfDate(ByVal year_selected As Integer, ByVal month_selected As Integer) As List(Of String)
        ''Obter Lista de Todas as Despesas:
        Dim ExpensesList = GetExpenses(False)

        ''Lista de Retorno:
        Dim ListOfExpenses As New List(Of String)

        ''Loop das Despesas:
        For Each EXPENSE As String In ExpensesList
            'Obter diretórios das parcelas da Despesa
            Dim Plots As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(EXPENSE)
            ''Loop das Parcelas:
            For Each PLOT_OF_EXPENSE As DirectoryInfo In Plots
                'Data da Parcela:
                Dim Plot_Date As Date = _EXPENSE.Plot.MaturityDate(PLOT_OF_EXPENSE)
                'Adicionar Despesa à Lista:
                If Plot_Date.Year = year_selected And Plot_Date.Month = month_selected Then
                    If Not ListOfExpenses.Contains(EXPENSE) Then ListOfExpenses.Add(EXPENSE)
                End If
            Next
        Next
        ''Retorno:
        Return ListOfExpenses
    End Function

    ''' <summary>
    ''' Obter Anos de Despesas Disponíveis
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetAvailableYears() As List(Of String)
        ''Obter Lista de Todas as Despesas:
        Dim ExpensesList = GetExpenses(False)

        ''Lista de Retorno:
        Dim ListOfYear As New List(Of String)

        ''Loop das Despesas:
        For Each EXPENSE As String In ExpensesList
            'Obter diretórios das parcelas da Despesa
            Dim Plots As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(EXPENSE)
            ''Loop das Parcelas:
            For Each PLOT_OF_EXPENSE As DirectoryInfo In Plots
                'Data da Parcela:
                Dim Plot_Date As Date = _EXPENSE.Plot.MaturityDate(PLOT_OF_EXPENSE)
                'Adicionar Ano à Lista:
                If Not ListOfYear.Contains(Plot_Date.Year.ToString) Then ListOfYear.Add(Plot_Date.Year.ToString)
            Next
        Next

        ''Não não for encontrado nenhuma despesa, então apenas retornar um item referente ao ano atual:
        If ListOfYear.Count = 0 Then ListOfYear.Add(Now.Date.Year)

        ''Retorno:
        Return ListOfYear
    End Function


    ''' <summary>
    ''' Filtragem de Despesas
    ''' </summary>
    ''' <remarks></remarks>
    Public Filters As New Filters_CountSystem

End Class
