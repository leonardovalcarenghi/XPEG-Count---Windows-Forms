Imports System.IO
Public Class CreditCards_CountSystem
    ''' <summary>
    ''' Obter o Nome do Cartão de Crédito Cadastrado
    ''' </summary>
    ''' <param name="card_code">Código do Cartão</param>
    ''' <returns></returns>
    Public Function GetName(ByVal card_code As String) As String
        Dim FileCardPath = _DIRECTORIES.ExpensesPath & "\" & card_code & "\expense.xcf"
        Return _INI.ReadIniFile(FileCardPath, "EXPENSE", "name", "error")
    End Function

    ''' <summary>
    ''' Obter Todas os Cartões de Crédito Cadastradas no Sistema | RETORNA OS CÓDIGOS DOS CARTÕES CADASTRADOS
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCards() As List(Of String)

        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim ExpensesFolders() As DirectoryInfo : ExpensesFolders = DirPath.GetDirectories()
        Dim LIST_CreditCards As New List(Of String)

        For Each A As DirectoryInfo In ExpensesFolders
            Dim CategoryCode = _INI.ReadIniFile(A.FullName & "\expense.xcf", "EXPENSE", "category")
            If CategoryCode = "XC.CATEGORY_CREDITCARD" Then LIST_CreditCards.Add(A.Name)
        Next

        'Retornar um ListOf com os Cartões do Sistema
        Return LIST_CreditCards
    End Function



    ''' <summary>
    ''' Obter Cartões de Crédito que possuem Faturas no Ano Selecionado | RETORNA UM LIST OF COM OS CÓDIGOS DOS CARTÕES (DESPESAS)
    ''' </summary>
    Public Function GetCreditCardsOfDate(ByVal year_selected As Integer) As List(Of String)
        ''Obter Lista de Todas as Despesas:
        Dim CreditCardsList = GetCards()

        ''Lista de Retorno:
        Dim ListOfCards As New List(Of String)

        ''Loop das Despesas:
        For Each CARD As String In CreditCardsList
            'Obter diretórios das parcelas da Despesa
            Dim Invoices As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(CARD)
            ''Loop das Parcelas:
            For Each INVOICE_OF_CARD As DirectoryInfo In Invoices
                'Data da Parcela:
                Dim InvoiceDate As Date = _EXPENSE.Plot.MaturityDate(INVOICE_OF_CARD)
                'Adicionar Despesa à Lista:
                If InvoiceDate.Year = year_selected Then
                    If Not ListOfCards.Contains(CARD) Then ListOfCards.Add(CARD)
                End If

            Next
        Next
        ''Retorno:
        Return ListOfCards
    End Function


    ''' <summary>
    ''' Obter Cartões de Crédito que possuem Faturas no Ano e Mês Selecionado | RETORNA UM LIST OF COM OS CÓDIGOS DOS CARTÕES (DESPESAS)
    ''' </summary>
    Public Function GetCreditCardsOfDate(ByVal year_selected As Integer, ByVal month_selected As Integer) As List(Of String)
        ''Obter Lista de Todas as Despesas:
        Dim CreditCardsList = GetCards()

        ''Lista de Retorno:
        Dim ListOfCards As New List(Of String)

        ''Loop das Despesas:
        For Each CARD As String In CreditCardsList
            'Obter diretórios das parcelas da Despesa
            Dim Invoices As List(Of DirectoryInfo) = _EXPENSE.Plots.GetPlots(CARD)
            ''Loop das Parcelas:
            For Each INVOICE_OF_CARD As DirectoryInfo In Invoices
                'Data da Parcela:
                Dim InvoiceDate As Date = _EXPENSE.Plot.MaturityDate(INVOICE_OF_CARD)
                'Adicionar Despesa à Lista:
                If InvoiceDate.Year = year_selected And InvoiceDate.Month = month_selected Then
                    If Not ListOfCards.Contains(CARD) Then ListOfCards.Add(CARD)
                End If

            Next
        Next
        ''Retorno:
        Return ListOfCards
    End Function
End Class
