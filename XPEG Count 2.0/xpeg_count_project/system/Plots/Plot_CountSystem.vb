Imports System.IO
Public Class Plot_CountSystem

    ''' <summary>
    ''' Acessar Informações do Histórico de Pagamento
    ''' </summary>
    Public Historic As New HistoricPayment_CountSystem

    ''' <summary>
    ''' Acessar Comentário da Parcela
    ''' </summary>
    ''' <remarks></remarks>
    Public Comment As New ExpenseComment_CountSystem

    ''' <summary>
    ''' Abrir Janela de Visualização da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    Public Sub Open(ByVal plot_path As DirectoryInfo, Optional ByVal show_name As Boolean = False)
        If IO.Directory.Exists(plot_path.FullName) Then
            Dim ViewPlot As ViewPlotSelectedDialog = New ViewPlotSelectedDialog
            ViewPlot.isCreditCard = _EXPENSE.isCreditCard(_EXPENSE.Plot.ExpenseOfPlot(plot_path))
            ViewPlot.BLOCK_ExpenseName.Visible = show_name
            If show_name = True Then ViewPlot.AlterarDataToolStripMenuItem.Visible = False
            ViewPlot.Plot_Path = plot_path
            ViewPlot.ShowDialog()
        Else
            MsgBox("A Parcela que você está tentando acessar, está corrompida ou foi excluida", MsgBoxStyle.Critical, "XPEG Count")
        End If
    End Sub

    ''' <summary>
    ''' Remover Parcela do Sistema | Se Foi Deletada Retorna True
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Delete(ByVal plot_path As DirectoryInfo) As Boolean
        Try
            plot_path.Delete(True)
            Return True
        Catch ex As Exception

            Return False

        End Try
    End Function


    ''' <summary>
    ''' Obter o Código da Despesa que essa parcela pertence
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExpenseOfPlot(ByVal plot_path As DirectoryInfo) As String
        Dim PlotPath = plot_path.Parent.Parent
        Return PlotPath.Name
    End Function

    ''' <summary>
    ''' Obter Valor Total da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function TotalValue(ByVal plot_path As DirectoryInfo) As Decimal
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        Dim Total = _INI.ReadIniFile(PlotInfoFile.FullName, "PLOT", "value", 0)
        Return Total
    End Function

    ''' <summary>
    ''' Alterar Valor da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <param name="new_value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChangeTotalValue(ByVal plot_path As DirectoryInfo, ByVal new_value As Decimal)
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        _INI.WriteIniFile(PlotInfoFile.FullName, "PLOT", "value", new_value)
    End Function


    '' <summary>
    ''' Incluir ou não Valor dessa parcela na soma final. | True = Não Incluir / False = Incluir Calculo
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <param name="includes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChangeIncludeValue(ByVal plot_path As DirectoryInfo, ByVal includes As Boolean)
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        _INI.WriteIniFile(PlotInfoFile.FullName, "PLOT", "noInclude", includes)
    End Function

    ''' <summary>
    ''' Obter se é para não incluir o calculo da parcela | True = Não Incluir Valor
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function NoIncludeValue(ByVal plot_path As DirectoryInfo)
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        Dim Include = _INI.ReadIniFile(PlotInfoFile.FullName, "PLOT", "noInclude", False)
        Return Include
    End Function

    ''' <summary>
    ''' Obter o Número da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function Number(ByVal plot_path As DirectoryInfo) As String
        ''Obter o Código da Despesa:
        Dim ExpenseCode = ExpenseOfPlot(plot_path)
        ''Obter Lista de Parcelas:
        Dim ExpensePlots = _EXPENSE.Plots.GetPlots(ExpenseCode)

        ''Converter Lista para uma Lista String:
        Dim ListOfString As New List(Of String)
        For Each A As DirectoryInfo In ExpensePlots : ListOfString.Add(A.Name) : Next

        ''Verificar se Existe:
        Dim PositionIndex As Integer
        If ListOfString.Contains(plot_path.Name) Then PositionIndex = ListOfString.IndexOf(plot_path.Name) Else PositionIndex = -1

        Dim NumberOfPlot = Val(PositionIndex + 1)
        If NumberOfPlot <= 9 Then Return "0" & NumberOfPlot Else Return NumberOfPlot
    End Function


    ''' <summary>
    ''' Obter a Data de Vencimento da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function MaturityDate(ByVal plot_path As DirectoryInfo) As Date
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        Dim MaturityD = _INI.ReadIniFile(PlotInfoFile.FullName, "DATES", "maturity", "01/01/2019")
        Return MaturityD
    End Function

    ''' <summary>
    ''' Alterar Data de Vencimento da Parcela (Isso Também Altera o Mês e o Ano)
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <param name="new_date"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ChangeMaturityDate(ByVal plot_path As DirectoryInfo, ByVal new_date As Date)
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        _INI.WriteIniFile(PlotInfoFile.FullName, "DATES", "maturity", new_date)
        Dim M = new_date.Month : _INI.WriteIniFile(PlotInfoFile.FullName, "DATES", "month", M)
        Dim Y = new_date.Year : _INI.WriteIniFile(PlotInfoFile.FullName, "DATES", "year", Y)
    End Function

    ''' <summary>
    ''' Obter Mês de Referencia da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function Month(ByVal plot_path As DirectoryInfo) As Integer
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        Dim MonthNumber = _INI.ReadIniFile(PlotInfoFile.FullName, "DATES", "month", 1)
        Return MonthNumber
    End Function

    ''' <summary>
    ''' Obter Ano de Referencia da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function Year(ByVal plot_path As DirectoryInfo) As Integer
        Dim PlotInfoFile As FileInfo = New FileInfo(plot_path.FullName & "\plot.xcf")
        Dim YearNumber = _INI.ReadIniFile(PlotInfoFile.FullName, "DATES", "year", 1)
        Return YearNumber
    End Function

    ''' <summary>
    ''' Obter Lista com os Arquivos do Histórico de Pagamento da Parcela | RETORNA O CAMINHO (PATH) DOS ARQUIVOS DE HISTÓRICO
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function GetHistoricPayment(ByVal plot_path As DirectoryInfo) As List(Of FileInfo)
        Dim HistoricFolderPath As DirectoryInfo = New DirectoryInfo(plot_path.FullName & "\historic")
        Dim ListHistoric As New List(Of FileInfo)
        If HistoricFolderPath.Exists Then
            Dim HistoricFiles() As FileInfo = HistoricFolderPath.GetFiles
            For Each A As FileInfo In HistoricFiles : ListHistoric.Add(A) : Next
        End If
        Return ListHistoric
    End Function

    ''' <summary>
    ''' Valor Pago na Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function PaidValue(ByVal plot_path As DirectoryInfo) As Decimal
        Dim HistoricPaymentList = GetHistoricPayment(plot_path)
        Dim Total As Decimal = 0
        If Not HistoricPaymentList.Count = 0 Then For Each A As FileInfo In HistoricPaymentList : Total += _INI.ReadIniFile(A.FullName, "HISTORIC", "value", 0) : Next
        Return Total
    End Function

    ''' <summary>
    ''' Valor que falta para quitar a Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function RestToPay(ByVal plot_path As DirectoryInfo) As Decimal
        Dim Plot_PaidValue = PaidValue(plot_path)
        Dim Plot_TotalValue = TotalValue(plot_path)
        Dim Total = Val(Plot_TotalValue - Plot_PaidValue)
        Return Total
    End Function

    ''' <summary>
    ''' Obter Lista de Comentários da Parcela | RETORNA O CAMINHO (PATH) DOS ARQUIVOS DE COMENTÁRIOS.
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function GetComments(ByVal plot_path As DirectoryInfo) As List(Of FileInfo)
        Dim NotesFolderPath As DirectoryInfo = New DirectoryInfo(plot_path.FullName & "\notes")
        Dim NotesFiles() As FileInfo = NotesFolderPath.GetFiles
        Dim ListNotes As New List(Of FileInfo)
        For Each A As FileInfo In NotesFiles : ListNotes.Add(A) : Next
        Return ListNotes
    End Function




    ''' <summary>
    ''' Obter Valor de Descontos Obtidos na Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Function Discounts(ByVal plot_path As DirectoryInfo) As Decimal
        Return 0
    End Function

    ''' <summary>
    ''' Obter o Valor de Juros Pago na Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function InterestValue(ByVal plot_path As DirectoryInfo) As Decimal
        Dim HistoricPlot = GetHistoricPayment(plot_path)
        Dim TotalInterest As Decimal = 0
        For Each Historic As FileInfo In HistoricPlot
            Dim HistoricType As PaymentTypeEnum = _INI.ReadIniFile(Historic.FullName, "HISTORIC", "type", 0)
            Dim HistoricValue As Decimal = _INI.ReadIniFile(Historic.FullName, "HISTORIC", "value", 0)
            Dim PlotValue = TotalValue(plot_path)

            If HistoricType = PaymentTypeEnum.TotalWithInterest Then
                TotalInterest += Val(HistoricValue - PlotValue)
            End If
        Next

        Return TotalInterest
    End Function


    ''' <summary>
    ''' Obter a Taxa de Juros da Parcela por Atraso [POR DIA / MÊS / ANO]
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function InterestTax(ByVal plot_path As DirectoryInfo, ByVal typeTax As TypeTaxEnum) As Decimal
        Select Case typeTax
            Case TypeTaxEnum.PerDay
            Case TypeTaxEnum.PerMonth
            Case TypeTaxEnum.PerYear
        End Select
        Return 999
    End Function


    ''' <summary>
    ''' Parcela Está Vencida ou Não | True = Sim / False = Não
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function IsDue(ByVal plot_path As DirectoryInfo) As Boolean
        Dim TodayDate As Date = Now.Date
        Dim Plot_MaturityDate As Date = MaturityDate(plot_path)
        If TodayDate < Plot_MaturityDate Then : Return False ''Não Está Vencida
        Else
            If TodayDate = Plot_MaturityDate Then : Return False ''Vence Hj (Não vencida ainda teoricamente)
            Else
                If TodayDate > Plot_MaturityDate Then : Return True 'Vencida
                End If : End If : End If
    End Function

    ''' <summary>
    ''' Obter o Status da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function Status(ByVal plot_path As DirectoryInfo) As StatusPlot
        Dim TodayDate As Date = Now.Date

        Dim Plot_Total As Decimal = TotalValue(plot_path)
        Dim Plot_Paid As Decimal = PaidValue(plot_path)
        Dim Plot_MaturityDate As Date = MaturityDate(plot_path)
        Dim Plot_Interest As Decimal = InterestValue(plot_path)
        Dim Plot_Discount As Decimal = Discounts(plot_path)

        Dim ListDatesWatingStatus As New List(Of Date)

        For i = 0 To XpegCountSettings.Default.ChangeStatusInXBeforeDays '_SETTINGS.ChangePlotStatusChangeHowManyDaysBefore
            Dim DateDay = Plot_MaturityDate.AddDays(-i) : ListDatesWatingStatus.Add(DateDay)
        Next


        ''Verificar Se a Parcela Já Venceu ou Não:
        Select Case IsDue(plot_path)
            Case False 'Não Venceu a Parcela / Dia de Vencimento
                If Plot_Paid = 0 And ListDatesWatingStatus.Contains(TodayDate) Then 'Não Pago e falta X dias para vencer = Aguardando Pagamento
                    Return StatusPlot.WaitingPayment
                Else
                    If Plot_Paid <= 0 Then 'Nada foi pago = Parcela Pendente
                        Return StatusPlot.Pending
                    Else
                        If Plot_Paid > 0 And Plot_Paid < Plot_Total Then 'Pago mais que nada e menos q o total = Pagamento Parcial
                            Return StatusPlot.PaidPartial
                        Else
                            If Plot_Paid >= Plot_Total Then 'Valor pago igual ou superior ao total = Pago
                                Return StatusPlot.Paid
                            Else
                                Return StatusPlot.OutherStatus_
                            End If
                        End If
                    End If
                End If

            Case True 'Vencida

                If Plot_Paid <= 0 Then 'Não Pago após Vencimento = Pagamento Atrasado
                    Return StatusPlot.LatePayment
                Else
                    If Plot_Paid > 0 And Plot_Paid < Plot_Total Then 'Pago uma parte após o vencimento = Pago Parcialmente
                        Return StatusPlot.PaidPartial
                    Else
                        If Plot_Paid >= Plot_Total Then 'Se foi pago o valor total ou superior após o vencimento = Pago
                            Return StatusPlot.Paid
                        Else
                            Return StatusPlot.OutherStatus_
                        End If
                    End If
                End If

        End Select
    End Function


    ''' <summary>
    ''' Obter a Cor de Status da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function StatusColor(ByRef plot_path As DirectoryInfo) As Color
        Dim PlotStatus = Status(plot_path)
        Select Case PlotStatus
            Case StatusPlot.Pending : Return Color.FromArgb(210, 210, 210)
            Case StatusPlot.WaitingPayment : Return Color.FromArgb(32, 114, 69)
            Case StatusPlot.Paid : Return Color.FromArgb(54, 120, 219)
            Case StatusPlot.PaidPartial : Return Color.FromArgb(255, 236, 139)
            Case StatusPlot.LatePayment : Return Color.FromArgb(255, 20, 20) 'oficial color
            Case Else : Return Color.Transparent
        End Select
    End Function
    ''' <summary>
    ''' Status em Texto da Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function StatusString(ByVal plot_path As DirectoryInfo) As String
        Dim ThisStatus = Status(plot_path)
        Dim isCreditCard As Boolean = _EXPENSE.isCreditCard(ExpenseOfPlot(plot_path))

        Select Case ThisStatus
            Case StatusPlot.Pending : Return "Pagamento Pendente" ' If isCreditCard = False Then Return "Parcela Pendente" Else Return "Fatura Pendente"
            Case StatusPlot.WaitingPayment : Return "Aguardando Pagamento..."
            Case StatusPlot.Paid : Return "Pagamento Realizado"
            Case StatusPlot.PaidPartial : Return "Pagamento Parcial Realizado"
            Case StatusPlot.LatePayment : Return "Pagamento Atrasado"
            Case Else : Return "error getting status..."
        End Select
    End Function


    ''' <summary>
    ''' Pagar Parcela
    ''' </summary>
    ''' <param name="plot_path"></param>
    ''' <returns></returns>
    Public Function Pay(ByVal plot_path As DirectoryInfo, ByVal valueToPay As Decimal, ByVal paymentDate As Date, ByVal paymentType As Integer, ByVal paymentComments As String)
        ''Gerar Código do Histórico do Pagamento
        Dim HistoricCode As String = _FUNCTIONS.Codes.GenerateHistoricPaymentCode()
        ''Caminho do Arquivo:
        Dim HistoricPaymentFilePath As FileInfo = New FileInfo(plot_path.FullName & "\historic\" & HistoricCode & ".xcf")

        ''Criar Arquivo:
        My.Computer.FileSystem.WriteAllText(HistoricPaymentFilePath.FullName, "---", False)

        ''Salvar Código:
        _INI.WriteIniFile(HistoricPaymentFilePath.FullName, "HISTORIC", "code", HistoricCode)

        ''Salvar Valor:
        _INI.WriteIniFile(HistoricPaymentFilePath.FullName, "HISTORIC", "value", valueToPay)

        ''Salvar Data do Pagamento:
        _INI.WriteIniFile(HistoricPaymentFilePath.FullName, "HISTORIC", "date", paymentDate.Date)

        ''Salvar Tipo de Pagamento:
        _INI.WriteIniFile(HistoricPaymentFilePath.FullName, "HISTORIC", "type", paymentType)

        ''Salvar Comentários:
        _INI.WriteIniFile(HistoricPaymentFilePath.FullName, "HISTORIC", "comments", paymentComments)
    End Function












    ''' <summary>
    ''' Adicionar Nova Parcela
    ''' </summary>
    Public Function Add(ByVal expense_code As String, ByVal totalValue As Decimal, ByVal maturityDate As Date) As Boolean
        ''Gerar Código da Parcela:
        Dim PlotCode = _FUNCTIONS.Codes.GeneratePlotCode
        ''Path da Parcela:
        Dim Path As String = _DIRECTORIES.ExpensesPath & expense_code & "\plots\" & PlotCode & "\"

        ''Criar Diretórios:
        IO.Directory.CreateDirectory(Path)
        IO.Directory.CreateDirectory(Path & "historic\")
        IO.Directory.CreateDirectory(Path & "notes\")

        'Criar Arquivo da Parcela:
        IO.File.WriteAllText(Path & "plot.xcf", "")


        '''''[PLOT]'''''
        _INI.WriteIniFile(Path & "plot.xcf", "PLOT", "value", totalValue)
        _INI.WriteIniFile(Path & "plot.xcf", "PLOT", "noInclude", "false")

        '''''[DATES]'''''
        _INI.WriteIniFile(Path & "plot.xcf", "DATES", "maturity", maturityDate)
        _INI.WriteIniFile(Path & "plot.xcf", "DATES", "month", maturityDate.Month)
        _INI.WriteIniFile(Path & "plot.xcf", "DATES", "year", maturityDate.Year)

        Return True

    End Function







    Enum TypeTaxEnum : PerDay : PerMonth : PerYear : End Enum

    Enum StatusPlot
        Pending
        WaitingPayment
        Paid
        PaidPartial
        LatePayment

        OutherStatus_
    End Enum


    Enum PaymentTypeEnum : TotalValue : PartialValue : DiscountValue : TotalWithInterest : End Enum

    Enum HistoricPaymentType
        DefaultType
        TotalType
        PartialType
        DiscountType
        InterestType
    End Enum

    Public Enum PaymentType
        none            '0
        totalPayment    '1
        partialPayment  '2
        interestPayment '3
        discountPayment '4
        restPayment     '5
    End Enum
End Class






Public Class ExpenseComment_CountSystem

    ''' <summary>
    ''' Adicionar Novo Comentário para essa Parcela
    ''' </summary>
    Public Function NewComment(ByVal plot_path As DirectoryInfo, ByVal comment_title As String, ByVal comment_text As String)
        ''Arquivo de Comentário:
        Dim FileComment As FileInfo = New FileInfo(plot_path.FullName & "\notes\" & _FUNCTIONS.Codes.GenerateCommentCode() & ".xcf")

        ''Criar Arquivo:
        'IO.File.CreateText(FileComment.FullName)
        IO.File.WriteAllText(FileComment.FullName, "[COMMENT]")

        ''Escrever Título:
        _INI.WriteIniFile(FileComment.FullName, "COMMENT", "title", comment_title)

        ''Escrever Texto:
        _INI.WriteIniFile(FileComment.FullName, "COMMENT", "text", comment_text)

        ''Escrever Data:
        _INI.WriteIniFile(FileComment.FullName, "COMMENT", "date", Now.Date)
    End Function

    ''' <summary>
    ''' Obter Título do Comentário
    ''' </summary>
    Public Function Title(ByVal comment_file As FileInfo) As String
        Dim CommentFile As String = comment_file.FullName
        Dim TheTitle = _INI.ReadIniFile(CommentFile, "COMMENT", "title", "")
        Return TheTitle
    End Function

    ''' <summary>
    ''' Obter Texto do Comentário
    ''' </summary>
    Public Function Text(ByVal comment_file As FileInfo) As String
        Dim CommentFile As String = comment_file.FullName
        Dim TheText = _INI.ReadIniFile(CommentFile, "COMMENT", "text", "")
        Return TheText
    End Function

    ''' <summary>
    ''' Obter Texto do Comentário
    ''' </summary>
    Public Function DateComment(ByVal comment_file As FileInfo) As Date
        Dim CommentFile As String = comment_file.FullName
        Dim TheDate = _INI.ReadIniFile(CommentFile, "COMMENT", "date", "01/01/2018")
        Return TheDate
    End Function

    ''' <summary>
    ''' Excluir Comentário
    ''' </summary>
    ''' <param name="comment_file"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Delete(ByVal comment_file As FileInfo) As Boolean
        Dim CommentFile As String = comment_file.FullName
        Try
            IO.File.Delete(CommentFile)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class