Imports System.IO

Public Class Expense_CountSystem

    Dim ExpensesOpenedCodeList As New List(Of String)
    Dim ExpensesOpenedFormList As New List(Of ViewExpenseForm)

    ''' <summary>
    ''' Abrir Janela da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    Public Sub OpenExpense(ByVal expense_code As String)
        If Not ExpensesOpenedCodeList.Contains(expense_code) Then
            Dim ViewExpense As ViewExpenseForm = New ViewExpenseForm
            With ViewExpense : .EXPENSE_Code = expense_code : .LoadExpense(True) : .Show() : End With
            ExpensesOpenedCodeList.Add(expense_code) : ExpensesOpenedFormList.Add(ViewExpense)
        Else
            Dim ItemExpense As Integer = ExpensesOpenedCodeList.IndexOf(expense_code)
            With ExpensesOpenedFormList.Item(ItemExpense)
                .TopMost = True : .Show() : .WindowState = FormWindowState.Normal : .Focus() : .Select() : .TopMost = False
            End With
        End If
    End Sub

    ''' <summary>
    ''' Obter a Janela da Despesa Aberta
    ''' </summary>
    Public Function GetForm(ByVal expense_code As String) As ViewExpenseForm
        Dim ItemExpense As Integer = ExpensesOpenedCodeList.IndexOf(expense_code)
        Return ExpensesOpenedFormList.Item(ItemExpense)
    End Function

    ''' <summary>
    ''' Fechar Janela da Despesa
    ''' </summary>
    ''' <param name="expense_form"></param>
    Public Sub CloseExpense(ByVal expense_form As ViewExpenseForm)
        Dim ItemExpenseForm As Integer = ExpensesOpenedFormList.IndexOf(expense_form)
        ExpensesOpenedCodeList.RemoveAt(ItemExpenseForm) : ExpensesOpenedFormList.RemoveAt(ItemExpenseForm)
    End Sub

    ''' <summary>
    ''' Diz se a Despesa é um Cartão de Crédito
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isCreditCard(ByVal expense_code As String) As Boolean
        ''Obter Categoria:
        If Category(expense_code) = "XC.CATEGORY_CREDITCARD" Then Return True Else Return False
    End Function

    ''' <summary>
    ''' Obter o Diretório da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Path(ByVal expense_code As String) As DirectoryInfo
        Dim DirectoriExpense As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath & "\" & expense_code & "\")
        Return DirectoriExpense
    End Function


    ''' <summary>
    ''' Deletar Despesa
    ''' </summary>
    Public Function Delete(ByVal expense_code As String) As Boolean
        Dim PathOfExpense As DirectoryInfo = Path(expense_code)
        Try
            IO.Directory.Delete(PathOfExpense.FullName, True)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Obter o Nome da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Name(ByVal expense_code As String) As String
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        Return _INI.ReadIniFile(FileExpenseXCF, "EXPENSE", "name", "error")
    End Function

    ''' <summary>
    ''' Obter a Descrição da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Description(ByVal expense_code As String) As String
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & "\" & expense_code & "\expense.xcf"
        Return _INI.ReadIniFile(FileExpenseXCF, "EXPENSE", "description", "")
    End Function

    ''' <summary>
    ''' Obter o Icone da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Icon(ByVal expense_code As String) As Image
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        Dim ImgFile = _DIRECTORIES.IconsPath & _INI.ReadIniFile(FileExpenseXCF, "ICON", "file")
        If IO.File.Exists(ImgFile) Then Return Image.FromFile(ImgFile) Else Return Nothing
    End Function

    ''' <summary>
    ''' Obter a Cor de Destaque da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function HightColor(ByVal expense_code As String) As Color
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & "\" & expense_code & "\expense.xcf"
        Dim GetHightColor As Color
        Try : GetHightColor = Color.FromArgb(_INI.ReadIniFile(FileExpenseXCF, "HIGHLIGHT", "color"))
        Catch : GetHightColor = Color.DarkBlue : End Try
        Return GetHightColor
    End Function

    ''' <summary>
    ''' Obter o Código da Categoria da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Category(ByVal expense_code As String) As String
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        Return _INI.ReadIniFile(FileExpenseXCF, "EXPENSE", "category", "error")
    End Function

    ''' <summary>
    ''' Obter Data de Inicio da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function StartDate(ByVal expense_code As String) As Date
        Dim FirstPlotPath As DirectoryInfo = Plots.FirstPlot(expense_code)
        Dim PlotDate As Date = Plot.MaturityDate(FirstPlotPath)
        Return PlotDate
    End Function

    ''' <summary>
    ''' Obter Data Final da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function EndDate(ByVal expense_code As String) As Date
        Dim LastPlotPath As DirectoryInfo = Plots.LastPlot(expense_code)
        Dim PlotDate As Date = Plot.MaturityDate(LastPlotPath)
        Return PlotDate
    End Function

    ''' <summary>
    ''' Obter Duração da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function Duration(ByVal expense_code As String) As String
        Dim ExpenseStartDate As Date = StartDate(expense_code)
        Dim ExpenseEndDate As Date = EndDate(expense_code)

        ''Descrição das Datas:
        Dim DescriptionDays, DescriptionMonths, DescriptionsYears As String


        ''Obter Duração:
        Dim CalcDuration_Years = DateDiff(DateInterval.Year, ExpenseStartDate, ExpenseEndDate)
        Dim CalcDuration_Months = DateDiff(DateInterval.Month, ExpenseStartDate, ExpenseEndDate)
        Dim CalcDuration_Days = DateDiff(DateInterval.Day, ExpenseStartDate, ExpenseEndDate)



        ''Obter Anos de Duração:
        Dim Duration_Years As Integer = CalcDuration_Years


        ''Duração em Meses
        Dim Duration_Months As Integer = CalcDuration_Months


        ''Duração em Dias
        Dim Duration_Days As Integer = CalcDuration_Days



        Return "Anos:  " & Duration_Years & " / Meses: " & Duration_Months & " / Dias: " & Duration_Days




    End Function

    ''' <summary>
    ''' Verificar se Despesa tem Vinculo com Cartão de Crédito e Retornar o Código do Cartão
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function LinkCreditCard(ByVal expense_code As String) As String
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        Dim LinkCardCode = _INI.ReadIniFile(FileExpenseXCF, "LINK", "creditcard", Nothing)
        If LinkCardCode = "" Then LinkCardCode = Nothing
        Return LinkCardCode
    End Function

    ''' <summary>
    ''' Local da Compra
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function BuyPlace(ByVal expense_code As String) As String
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        Return _INI.ReadIniFile(FileExpenseXCF, "EXPENSE", "buyPlace", "")
    End Function

    ''' <summary>
    ''' Data da Compra
    ''' </summary>
    Public Property BuyDate(ByVal expense_code As String) As Date
        Get
            Return _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "DATES", "buy", "")
        End Get
        Set(value As Date)
            _INI.WriteIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "DATES", "buy", value)
        End Set
    End Property

    ''' <summary>
    ''' Aplicar Cor de Destaque no Header da Tela
    ''' </summary>
    Public Property ApplyColorInHeader(ByVal expense_code As String) As Boolean
        Get
            Return _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "HIGHLIGHT", "header", False)
        End Get
        Set(value As Boolean)
            _INI.WriteIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "HIGHLIGHT", "header", value)
        End Set
    End Property

    ''' <summary>
    ''' Habilitar Pagamento Parcial na Despesa
    ''' </summary>
    Public Property AllowPartialPayments(ByVal expense_code As String) As Boolean
        Get
            Return _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "EXPENSE", "partialPayment", False)
        End Get
        Set(value As Boolean)
            _INI.WriteIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "EXPENSE", "partialPayment", value)
        End Set
    End Property

    Public Property ModeView(ByVal expense_code As String) As ModeViewEnum
        Get
            Return _INI.ReadIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "EXPENSE", "modeView", 0)
        End Get
        Set(value As ModeViewEnum)
            _INI.WriteIniFile(_DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf", "EXPENSE", "modeView", value)
        End Set
    End Property

    Enum ModeViewEnum : BlocksMode : ListMode : End Enum


    ''' <summary>
    ''' Obter Status da Despesa com Base nos Status das Parcelas
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Status(ByVal expense_code As String) As String
        Dim ListOfPlots = Plots.GetPlots(expense_code)

        Dim ListOfStatusOfPlots As New List(Of Integer)

        For Each THIS_PLOT As DirectoryInfo In ListOfPlots : ListOfStatusOfPlots.Add(Plot.Status(THIS_PLOT)) : Next

        If ListOfStatusOfPlots.Contains(4) Then
            Return "Pagamento Atrasado"
        Else
            If Values.RestToPay(expense_code) <= 0 Then
                Return "Despesa Paga"
            Else
                Return "Pagamentos em Dia"
            End If
            'If ListOfStatusOfPlots.Contains(3) Then
            'Return "Pagamento Total não Realizadoe Paga."
            'Else



            'End If
        End If
        'Plot.StatusPlot.LatePayment() '4
        'Plot.StatusPlot.PaidPartial '3
        'Plot.StatusPlot.Pending '0
    End Function

    ''' <summary>
    ''' Salvar o Nome da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeName(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "EXPENSE", "name", valueToSave)
    End Function

    ''' <summary>
    ''' Salvar a Descrição da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeDescription(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & "\" & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "EXPENSE", "description", valueToSave)
    End Function

    ''' <summary>
    ''' Salvar o Icone da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeIcon(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "ICON", "file", valueToSave)
    End Function

    ''' <summary>
    ''' Salvar a Cor de Destaque da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeHightColor(ByVal expense_code As String, ByVal valueToSave As Color)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & "\" & expense_code & "\expense.xcf"
        Dim HightColorString As String = valueToSave.ToArgb
        _INI.WriteIniFile(FileExpenseXCF, "HIGHLIGHT", "color", HightColorString)
    End Function

    ''' <summary>
    ''' Salvar o Código da Categoria da Despesa
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeCategory(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "EXPENSE", "category", valueToSave)
    End Function

    ''' <summary>
    ''' Salvar Vinculo com Cartão de Crédito
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeLinkCreditCard(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "LINK", "creditcard", valueToSave)
    End Function

    ''' <summary>
    ''' Salvar Local da Compra
    ''' </summary>
    ''' <param name="expense_code"></param>
    ''' <returns></returns>
    Public Function ChangeBuyPlace(ByVal expense_code As String, ByVal valueToSave As String)
        Dim FileExpenseXCF = _DIRECTORIES.ExpensesPath & expense_code & "\expense.xcf"
        _INI.WriteIniFile(FileExpenseXCF, "EXPENSE", "buyPlace", valueToSave)
    End Function
    ''===========================================================================================''


    ''' <summary>
    ''' Obter Valores da Despesa
    ''' </summary>
    Public Values As New ExpenseValues_CountSystem

    ''' <summary>
    ''' Obter Informações e Valores de Parcelas
    ''' </summary>
    Public Plots As New Plots_CountSystem

    ''' <summary>
    ''' Obter Informações e Valores de uma Parcela Especifica
    ''' </summary>
    Public Plot As New Plot_CountSystem

End Class