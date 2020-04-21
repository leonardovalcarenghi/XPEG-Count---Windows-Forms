Imports System.IO

Public Class UpgradeFileSystem_Converting

    Public WithEvents FORM_Parent As UpgradeFileSystemDialog
    Private Sub UpgradeFileSystem_Converting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.Transparent
    End Sub
    Private Sub WriteInConsole(ByVal message As String)
        TextBox1.Text += vbNewLine + message

        'Threading.Thread.Sleep(time_sleep)
    End Sub

    Dim i = 0
    Private Sub Timer_Convert_Tick(sender As Object, e As EventArgs) Handles Timer_Convert.Tick
        i += 1
        If i = 5 Then
            WriteInConsole("Iniciando Conversões das Despesas...")
            WriteInConsole("------------------------------------------------------------------------------")
            WriteInConsole("")
        Else
            If i = 10 Then
                Timer_Convert.Stop()
                StartConvert()
            End If
        End If
    End Sub

    Dim Item As Integer = 0

    Public Sub StartConvert()
        Dim ListOfExpenses As List(Of String) = FORM_Parent.LIST_ExpensesToConvert


        WriteInConsole("CÓDIGO(S) DA(S) DESPESA(S) PARA CONVERSÃO")
        For Each A As String In ListOfExpenses
            WriteInConsole(A)
        Next
        WriteInConsole("")
        WriteInConsole("==============================================================================")
        WriteInConsole("")

        For Each B As String In ListOfExpenses
            ConvertExpense(B)
            Item += 1
        Next

    End Sub


    Dim PathExpenseOld As DirectoryInfo
    Dim FileExpenseOld As String

    Dim EXPENSE_Name As String
    Dim EXPENSE_Description As String
    Dim EXPENSE_Category As String
    Dim EXPENSE_Date As Date
    Dim EXPENSE_Color As Color
    Dim EXPENSE_Icon As String

    Dim EXPENSE_NumberOfPlots As Integer

    Private Sub ConvertExpense(ByVal expense_code As String)
        WriteInConsole("DIRECTORYS" & vbNewLine)

        PathExpenseOld = New DirectoryInfo(_DIRECTORIES.PrimaryPath & "old_system\" & expense_code)
        WriteInConsole("Path: " & PathExpenseOld.FullName)

        FileExpenseOld = PathExpenseOld.FullName & "\expense.ini"
        WriteInConsole("File:   " & FileExpenseOld)


        WriteInConsole(vbNewLine & "INFORMAÇÕES DA DESPESA" & vbNewLine)

        '[EXPENSE]'
        EXPENSE_Name = _INI.ReadIniFile(FileExpenseOld, "EXPENSE", "name")
        WriteInConsole("> Nome: " & EXPENSE_Name)

        EXPENSE_Description = _INI.ReadIniFile(FileExpenseOld, "EXPENSE", "description", "sem descrição.")
        WriteInConsole("> Descrição: " & EXPENSE_Description)

        EXPENSE_Category = _INI.ReadIniFile(FileExpenseOld, "EXPENSE", "category")
        WriteInConsole("> Categoria: " & _CATEGORYS.GetName(EXPENSE_Category) & " [ " & EXPENSE_Category & " ]")

        EXPENSE_Date = _INI.ReadIniFile(FileExpenseOld, "EXPENSE", "date")
        WriteInConsole("> Data: " & EXPENSE_Date.Date)

        EXPENSE_Color = Color.FromArgb(_INI.ReadIniFile(FileExpenseOld, "EXPENSE", "color", 1))
        WriteInConsole("> Cor: " & EXPENSE_Color.ToArgb)

        EXPENSE_Icon = _INI.ReadIniFile(FileExpenseOld, "EXPENSE", "icon")

        'PLOTS
        Dim PlotsPath As DirectoryInfo = New DirectoryInfo(PathExpenseOld.FullName & "\plots\")
        Dim FilesPlots() As FileInfo = PlotsPath.GetFiles
        EXPENSE_NumberOfPlots = FilesPlots.Length

        WriteInConsole("> Quantidade de Parcelas: " & FilesPlots.Length)

        For Each PLOT As FileInfo In FilesPlots

        Next



        CreateExpense()

        WriteInConsole("")
        WriteInConsole("==============================================================================")
        WriteInConsole("")
    End Sub



    Dim ExpenseCode, ExpensePath, PlotsPath
    Private Sub CreateExpense()
        ''CÓDIGO DA DESPESA''
        ExpenseCode = _FUNCTIONS.Codes.GenerateExpenseCode

        ''DIRETÓRIO DA DESPESA''
        ExpensePath = _DIRECTORIES.ExpensesPath & ExpenseCode & "\"

        ''DIRETÓRIO DAS PARCELAS''
        PlotsPath = ExpensePath & "plots\"

        ' = = = = = = = = = = = = = = = = = = = = = = = = = '

        'Criar Diretório da Despesa
        IO.Directory.CreateDirectory(ExpensePath)

        'Criar Diretório das Parcelas
        IO.Directory.CreateDirectory(PlotsPath)

        ' = = = = = = = = = = = = = = = = = = = = = = = = = '

        '' = = = = = ARQIVO 'EXPENSE.INI' = = = = = ''

        ''ARQUIVO''
        Dim ExpenseFile = ExpensePath & "expense.xcf"

        '[EXPENSE]'
        'Nome da Despesa
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "name", EXPENSE_Name)

        'Descrição da Despesa
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "description", EXPENSE_Description)

        'Categoria da Despesa
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "category", EXPENSE_Category & vbNewLine & vbNewLine)


        '[DATES]'
        'Data da Compra
        _INI.WriteIniFile(ExpenseFile, "DATES", "buy", EXPENSE_Date.Date)

        'Data Inicial
        _INI.WriteIniFile(ExpenseFile, "DATES", "startdate", EXPENSE_Date.Date & vbNewLine & vbNewLine)

        '[LINK]'
        Dim CreditCode = 0
        'Vincular Despesa
        _INI.WriteIniFile(ExpenseFile, "LINK", "creditcard", CreditCode & vbNewLine & vbNewLine)


        '[HIGHLIGHT]'
        'Cor de Destaque
        _INI.WriteIniFile(ExpenseFile, "HIGHLIGHT", "color", EXPENSE_Color.ToArgb & vbNewLine & vbNewLine)


        '[ICONE]'
        'Arquivo do Icone
        _INI.WriteIniFile(ExpenseFile, "ICON", "file", EXPENSE_Icon & vbNewLine & vbNewLine)


        '[SOFTWARE]'
        'Nome do Update
        _INI.WriteIniFile(ExpenseFile, "SOFTWARE", "update", "XPEG.COUNT.2")

        'Versão do Software
        _INI.WriteIniFile(ExpenseFile, "SOFTWARE", "version", My.Settings.SOFTWARE_Version & vbNewLine & vbNewLine)


        '' = = = = = CRIAR PASTAS DAS PARCELAS = = = = = ''
        CreatePlots()
    End Sub



    Private Sub CreatePlots()
        Dim NumberOfPlots As Integer = 1 'TextBox_NumberOfPlots.Text

        Dim StartMonth As Date = "01/12/2018" 'DateTimePicker_StartDate.Value.Date

        For i = 1 To NumberOfPlots Step 1
            'Diretório da Parcela
            Dim ThisPlotPath As String = PlotsPath & i & "\"

            'Criar Diretório da Parcela
            IO.Directory.CreateDirectory(ThisPlotPath)

            'Criar SubDiretorios
            IO.Directory.CreateDirectory(ThisPlotPath & "historic")
            IO.Directory.CreateDirectory(ThisPlotPath & "notes")

            Dim PlotFile = ThisPlotPath & "plot.xcf"

            '[PLOT]'
            'Número da Parcela
            _INI.WriteIniFile(PlotFile, "PLOT", "number", i & vbNewLine & vbNewLine)


            If i <> 1 Then StartMonth = StartMonth.AddMonths(1)
            Dim MaturityDayOfMonth As Integer = 15 'ComboBox_MaturityDay.Text
            Dim MaturityDay = TheMaturityDay(MaturityDayOfMonth, StartMonth.Date.Month, StartMonth.Date.Year)

            '[DATES]'
            'Dia de Vencimento
            _INI.WriteIniFile(PlotFile, "DATES", "maturity", MaturityDay)

            'Mês da Parcela
            _INI.WriteIniFile(PlotFile, "DATES", "month", StartMonth.Month)

            'Ano da Parcela
            _INI.WriteIniFile(PlotFile, "DATES", "year", StartMonth.Year)
        Next


        WriteInConsole("> > > DESPESA CONVERTIDA COM SUCESSO!")
    End Sub

    Function TheMaturityDay(ByVal dt_day As Integer, ByVal dt_month As Integer, ByVal dt_year As Integer) As Date
        Dim _Day = dt_day
        Dim _Month = dt_month
        Dim _Year = dt_year

        Dim FakeDate As Date = "01/" & _Month & "/" & _Year

        'Número de Dias No Mês
        Dim NumberOfDaysInMonth As Integer = Date.DaysInMonth(_Year, _Month)

        'Se o Dia De vencimento for maior que a quantidade de dias do mês, add um dia
        If _Day > NumberOfDaysInMonth Then
            FakeDate = NumberOfDaysInMonth & "/" & _Month & "/" & _Year
            FakeDate = FakeDate.AddDays(1)
        End If




        If FakeDate.DayOfWeek = DayOfWeek.Saturday Then
            FakeDate = FakeDate.AddDays(2)
        Else
            If FakeDate.DayOfWeek = DayOfWeek.Sunday Then
                FakeDate = FakeDate.AddDays(1)
            End If
        End If


        Return FakeDate

    End Function
End Class
