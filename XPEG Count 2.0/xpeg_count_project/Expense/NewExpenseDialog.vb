Imports System.Windows.Forms

Public Class NewExpenseDialog
    Dim LIST_CreditCards As New List(Of String)


    Private Sub NewExpenseDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Remover TabPage:
        TabControl1.TabPages.Remove(TabPage_Interest)
        TabControl1.TabPages.Remove(TabPage_Outhers)

        'Carregar Imagens de Implementação da Interface:
        STYLE_ExpenseImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Expense_500px, 230)
        STYLE_CalendarImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Calendar_500px, 230)
        STYLE_ValuesImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Money_500px, 230)
        STYLE_CustomImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Custom_500px, 230)
        STYLE_LinkImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Link_500px, 230)

        'Obter Lista de Cartões de Crédito:
        GetList_CreditCards()

        'Dia de Hoje nas Caixas:
        DateTimePicker_BuyDate.Value = Now.Date : DateTimePicker_StartDate.Value = Now.Date
        ComboBox_MaturityDay.Text = Now.Date.Day

        'Focar no Primeiro Controle:
        FocusOnControl(TextBox_ExpenseName, TabPage_GeneralInformations)
    End Sub

    Private Sub GetList_CreditCards()
        ComboBox_LinkCard.Items.Clear() 'Limpar Lista
        Dim Cards = _CREDITCARDS.GetCards 'Obter lista de Cartões
        ComboBox_LinkCard.Items.Add("Não vincular")

        LIST_CreditCards.Add("none")
        For Each A As String In Cards
            ComboBox_LinkCard.Items.Add(_CREDITCARDS.GetName(A))
            LIST_CreditCards.Add(A)
        Next
        'Add Cartões

        ComboBox_LinkCard.SelectedIndex = 0
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        'Iniciar Verificações de Campos Preenchidos
        CheckFilledFields_GeneralInformations()
    End Sub

#Region "Guia - Personalização"
    Private Sub PictureBox_HighColorExpense_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox_HighColorExpense.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim SelectColor As New SelectColorDialog
            If SelectColor.ShowDialog = DialogResult.OK Then
                PictureBox_HighColorExpense.BackColor = SelectColor.SelectedColor
                PictureBox_ExpenseIcon.BackColor = SelectColor.SelectedColor
            End If
        End If
    End Sub

    Dim IconFile As String
    Private Sub PictureBox_ExpenseIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox_ExpenseIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim SelectIcon As New SelectIconDialog
            If SelectIcon.ShowDialog = DialogResult.OK Then
                Dim IMG = Image.FromFile(SelectIcon.SelectIconFile)
                IconFile = SelectIcon.SelectIconFile.Replace(_DIRECTORIES.IconsPath, "")
                IMG = _FUNCTIONS.Images.ChangeImageResolution(IMG, 24)
                IMG = _FUNCTIONS.Images.InvertColorFromImage(IMG, Color.White)
                PictureBox_ExpenseIcon.Image = IMG
            End If
        End If
    End Sub
#End Region


#Region "KeyDowns para Pular ao Proximo Campo"

#Region "KeyDown - General Informations"
    Private Sub TextBox_ExpenseName_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_ExpenseName.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(TextBox_ExpenseDescription, TabPage_GeneralInformations)

            Case Keys.Escape
                e.SuppressKeyPress = True
                TextBox_ExpenseName.Text = ""
        End Select
    End Sub

    Private Sub TextBox_ExpenseDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_ExpenseDescription.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(Selector_ExpenseCategory, TabPage_GeneralInformations)

            Case Keys.Escape
                e.SuppressKeyPress = True
                TextBox_ExpenseDescription.Text = ""
        End Select
    End Sub

    Private Sub Selector_ExpenseCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles Selector_ExpenseCategory.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(DateTimePicker_BuyDate, TabPage_Dates)

            Case Keys.Escape
                e.SuppressKeyPress = True
                Selector_ExpenseCategory.SelectedCategoryCode = Nothing
        End Select
    End Sub
#End Region


#Region "KeyDown - Dates"

    Private Sub DateTimePicker_BuyDate_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker_BuyDate.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(DateTimePicker_StartDate, TabPage_Dates)

            Case Keys.Escape
                e.SuppressKeyPress = True
                DateTimePicker_BuyDate.Value = Now.Date
        End Select
    End Sub

    Private Sub DateTimePicker_StartDate_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker_StartDate.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(ComboBox_MaturityDay, TabPage_Dates)

            Case Keys.Escape
                e.SuppressKeyPress = True
                DateTimePicker_StartDate.Value = Now.Date
        End Select
    End Sub

    Private Sub ComboBox_MaturityDay_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox_MaturityDay.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(TextBox_PlotValue, TabPage_Values)

            Case Keys.Escape
                e.SuppressKeyPress = True
                ComboBox_MaturityDay.Text = ""
        End Select
    End Sub
#End Region


#Region "KeyDown - Values"
    'Private Sub TextBox_TotalValue_KeyDown(sender As Object, e As KeyEventArgs)
    '    Select Case e.KeyCode
    '        Case Keys.Enter
    '            e.SuppressKeyPress = True
    '            FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)

    '        Case Keys.Escape
    '            e.SuppressKeyPress = True
    '            'TextBox_TotalValue.Text = ""
    '    End Select
    'End Sub

    Private Sub TextBox_PlotValue_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_PlotValue.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)

            Case Keys.Escape
                e.SuppressKeyPress = True
                TextBox_PlotValue.Text = ""
        End Select
    End Sub

    Private Sub TextBox_NumberOfPlots_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_NumberOfPlots.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.SuppressKeyPress = True
                FocusOnControl(PictureBox_HighColorExpense, TabPage_Custom)

            Case Keys.Escape
                e.SuppressKeyPress = True
                TextBox_NumberOfPlots.Text = ""
        End Select
    End Sub



#End Region

#End Region


#Region "Verificar Campos Preenchidos Para Criação da Despesa"

    ''' <summary>
    ''' Abrir Guia onde O Control está e foca-lo
    ''' </summary>
    ''' <param name="ctrl"></param>
    ''' <param name="tabP"></param>
    Private Sub FocusOnControl(ByVal ctrl As Control, tabP As TabPage)
        TabControl1.SelectTab(tabP) 'Selecionar Guia
        ctrl.Focus() : ctrl.Select() 'Focar No Item
    End Sub



    Private Sub CheckFilledFields_GeneralInformations()
        If TextBox_ExpenseName.Text = Nothing Then
            MessageBox.Show("Você precisa digitar um nome para a sua despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FocusOnControl(TextBox_ExpenseName, TabPage_GeneralInformations)
        Else
            If _EXPENSES.GetNames().Contains(TextBox_ExpenseName.Text) Then
                MessageBox.Show("O nome digitado para a Despesa já se encontra em uso." & vbNewLine & "Por favor, escolha outro nome.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FocusOnControl(TextBox_ExpenseName, TabPage_GeneralInformations)
            Else
                If Selector_ExpenseCategory.SelectedCategoryCode = Nothing Then
                    MessageBox.Show("Você precisa selecionar uma categoria que se enquadre com a sua despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    FocusOnControl(Selector_ExpenseCategory, TabPage_GeneralInformations)
                Else
                    If Selector_ExpenseCategory.SelectedCategoryCode = "XC.CATEGORY_CREDITCARD" Then
                        MessageBox.Show("Você não pode selecionar a categoria ""Cartão de Crédito"" para esta despesa." & vbNewLine & "Por favor, escolha outra.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        FocusOnControl(Selector_ExpenseCategory, TabPage_GeneralInformations)
                    Else
                        CheckFilledFields_Dates()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CheckFilledFields_Dates()
        'Verificar se a Data Inicial é igual ou superior a Data da Compra
        If DateTimePicker_StartDate.Value.Date < DateTimePicker_BuyDate.Value.Date Then
            MessageBox.Show("A data inicial da despesa não pode ser anterior a data da compra. Precisa ser igual ou superior.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FocusOnControl(DateTimePicker_StartDate, TabPage_Dates)
        Else
            If Not IsNumeric(ComboBox_MaturityDay.Text) Then
                MessageBox.Show("O dia de vencimento é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                FocusOnControl(ComboBox_MaturityDay, TabPage_Dates)
            Else
                Dim MD = ComboBox_MaturityDay.Text
                If MD <= 0 Or MD >= 32 Then
                    MessageBox.Show("O dia de vencimento é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    FocusOnControl(ComboBox_MaturityDay, TabPage_Dates)
                Else
                    CheckFilledFields_Value()
                End If
            End If
        End If
    End Sub



    Private Sub CheckFilledFields_Value()
        'If TextBox_TotalValue.Text = Nothing Then
        '    MessageBox.Show("Informe o valor total da sua despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    FocusOnControl(TextBox_TotalValue, TabPage_Values)
        'Else
        '    If Not IsNumeric(TextBox_TotalValue.Text) Then
        '        MessageBox.Show("Informe um valor valído para o total da despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        TextBox_TotalValue.Text = ""
        '        FocusOnControl(TextBox_TotalValue, TabPage_Values)
        '    Else
        '        If TextBox_TotalValue.Text <= 0 Then
        '            MessageBox.Show("O valor total da despesa não pode ser inferior ou igual a 0.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            TextBox_TotalValue.Text = ""
        '            FocusOnControl(TextBox_TotalValue, TabPage_Values)
        '        Else

        If TextBox_PlotValue.Text = Nothing Then
            MessageBox.Show("Informe o valor das parcelas da despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FocusOnControl(TextBox_PlotValue, TabPage_Values)
        Else
            If Not IsNumeric(TextBox_PlotValue.Text) Then
                MessageBox.Show("Informe um valor valído para o valor das parcelas da despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox_PlotValue.Text = ""
                FocusOnControl(TextBox_PlotValue, TabPage_Values)
            Else
                If TextBox_PlotValue.Text <= 0 Then
                    MessageBox.Show("O valor das parcelas da despesa não pode ser inferior ou igual a 0.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TextBox_PlotValue.Text = ""
                    FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)
                Else
                    If TextBox_NumberOfPlots.Text = Nothing Then
                        MessageBox.Show("Informe em quantas vezes você parcelou a sua despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)
                    Else
                        If Not IsNumeric(TextBox_NumberOfPlots.Text) Then
                            MessageBox.Show("Informe um valor valído para a quantidade de parcelas da despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            TextBox_NumberOfPlots.Text = ""
                            FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)
                        Else
                            If TextBox_NumberOfPlots.Text <= 0 Then
                                MessageBox.Show("A quantidade de parcelas da despesa não pode ser inferior ou igual a 0.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                TextBox_NumberOfPlots.Text = ""
                                FocusOnControl(TextBox_NumberOfPlots, TabPage_Values)
                            Else
                                CreateExpense()
                            End If
                        End If

                    End If
                End If
            End If
        End If
        '        End If
        '    End If
        'End If

    End Sub



#End Region


#Region "Gerar Arquivos e depois Criar a Despesa"


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
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "name", TextBox_ExpenseName.Text)

        'Descrição da Despesa
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "description", TextBox_ExpenseDescription.Text)

        'Categoria da Despesa
        _INI.WriteIniFile(ExpenseFile, "EXPENSE", "category", Selector_ExpenseCategory.SelectedCategoryCode & vbNewLine & vbNewLine)


        '[DATES]'
        'Data da Compra
        _INI.WriteIniFile(ExpenseFile, "DATES", "buy", DateTimePicker_BuyDate.Value.Date)

        'Data Inicial
        _INI.WriteIniFile(ExpenseFile, "DATES", "startdate", DateTimePicker_StartDate.Value.Date & vbNewLine & vbNewLine)

        '[LINK]'
        Dim CreditCode = LIST_CreditCards.Item(ComboBox_LinkCard.SelectedIndex)
        'Vincular Despesa
        _INI.WriteIniFile(ExpenseFile, "LINK", "creditcard", CreditCode & vbNewLine & vbNewLine)


        '[HIGHLIGHT]'
        'Cor de Destaque
        _INI.WriteIniFile(ExpenseFile, "HIGHLIGHT", "color", PictureBox_HighColorExpense.BackColor.ToArgb & vbNewLine & vbNewLine)


        '[ICONE]'
        'Arquivo do Icone
        _INI.WriteIniFile(ExpenseFile, "ICON", "file", IconFile & vbNewLine & vbNewLine)


        '[SOFTWARE]'
        'Nome do Update
        _INI.WriteIniFile(ExpenseFile, "SOFTWARE", "update", "XPEG.COUNT.2")

        'Versão do Software
        _INI.WriteIniFile(ExpenseFile, "SOFTWARE", "version", My.Settings.SOFTWARE_Version & vbNewLine & vbNewLine)

        '' = = = = = CRIAR PASTAS DAS PARCELAS = = = = = ''
        CreatePlots()



        '' = = = = = FINALIZAR CRIAÇÃO DA DESPESA = = = = = ''
        MessageBox.Show("Sua despesa foi criada com exito!", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub CreatePlots()
        Dim NumberOfPlots As Integer = TextBox_NumberOfPlots.Text

        Dim StartMonth As Date = DateTimePicker_StartDate.Value.Date

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
            _INI.WriteIniFile(PlotFile, "PLOT", "number", i)

            'Valor da Parcela
            _INI.WriteIniFile(PlotFile, "PLOT", "value", TextBox_PlotValue.Text & vbNewLine & vbNewLine)


            If i <> 1 Then StartMonth = StartMonth.AddMonths(1)
            Dim MaturityDayOfMonth As Integer = ComboBox_MaturityDay.Text
            Dim MaturityDay As Date = MaturityDayOfMonth & "/" & StartMonth.Month & "/" & StartMonth.Year ' TheMaturityDay(MaturityDayOfMonth, StartMonth.Date.Month, StartMonth.Date.Year)

            '[DATES]'
            'Dia de Vencimento
            _INI.WriteIniFile(PlotFile, "DATES", "maturity", MaturityDay)

            'Mês da Parcela
            _INI.WriteIniFile(PlotFile, "DATES", "month", StartMonth.Month)

            'Ano da Parcela
            _INI.WriteIniFile(PlotFile, "DATES", "year", StartMonth.Year)
        Next
    End Sub

    Function TheMaturityDay(ByVal dt_day As Integer, ByVal dt_month As Integer, ByVal dt_year As Integer) As Date
        Dim _Day = dt_day
        Dim _Month = dt_month
        Dim _Year = dt_year

        Dim FakeDate As Date = dt_day & "/" & _Month & "/" & _Year

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




    Private Sub TextBox_ExpenseName_LostFocus(sender As Object, e As EventArgs) Handles TextBox_ExpenseName.LostFocus
        TextBox_ExpenseName.Text = Strings.StrConv(TextBox_ExpenseName.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub TextBox_ExpenseDescription_LostFocus(sender As Object, e As EventArgs) Handles TextBox_ExpenseDescription.LostFocus
        If TextBox_ExpenseDescription.Text <> Nothing Then
            Dim FirstLetter As String = TextBox_ExpenseDescription.Text(0)
            FirstLetter = FirstLetter.ToUpper()

            Dim TXT As String = FirstLetter
            For i = 1 To TextBox_ExpenseDescription.Text.Length - 1 : TXT += TextBox_ExpenseDescription.Text(i) : Next
            TextBox_ExpenseDescription.Text = TXT
        End If
    End Sub

    Private Sub ComboBox_MaturityDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_MaturityDay.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TextBox_TotalValue_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox_NumberOfPlots_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_NumberOfPlots.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TextBox_PlotValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_PlotValue.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar)) Then
            e.Handled = True

        End If
    End Sub

    Private Sub DateTimePicker_StartDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_StartDate.ValueChanged
        Dim QuantyOnDaysInMonth As Integer = Date.DaysInMonth(DateTimePicker_StartDate.Value.Date.Year, DateTimePicker_StartDate.Value.Date.Month)
        ComboBox_MaturityDay.Items.Clear()
        For i = 1 To QuantyOnDaysInMonth : ComboBox_MaturityDay.Items.Add(_TwoNumber(i)) : Next
        ComboBox_MaturityDay.Text = DateTimePicker_StartDate.Value.Date.Day
    End Sub

    Private Sub TextBox_ExpenseName_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ExpenseName.TextChanged
        _FUNCTIONS.ReplaceChars(TextBox_ExpenseName)
    End Sub

    Private Sub TextBox_PlotValue_TextChanged(sender As Object, e As EventArgs) Handles TextBox_PlotValue.TextChanged
        _FUNCTIONS.ReplaceChars(TextBox_PlotValue)
        Try
            Dim ValuePlot = (TextBox_PlotValue.Text) : Dim NumberOfPlots = (TextBox_NumberOfPlots.Text)
            Dim Result As Decimal = (ValuePlot * NumberOfPlots)
            TotalOfExpenseLabel.Text = _StringToMoney(Result).Replace("R$ ", "")
        Catch : End Try
    End Sub

    Private Sub TextBox_NumberOfPlots_TextChanged(sender As Object, e As EventArgs) Handles TextBox_NumberOfPlots.TextChanged
        _FUNCTIONS.ReplaceChars(TextBox_NumberOfPlots)
        Try
            Dim ValuePlot = (TextBox_PlotValue.Text) : Dim NumberOfPlots = (TextBox_NumberOfPlots.Text)
            Dim Result As Decimal = (ValuePlot * NumberOfPlots)
            TotalOfExpenseLabel.Text = _StringToMoney(Result).Replace("R$ ", "")
        Catch : End Try
    End Sub

    'Private Sub TextBox_TotalValue_TextChanged(sender As Object, e As EventArgs)
    '    _FUNCTIONS.ReplaceChars(TextBox_TotalValue)
    'End Sub

#End Region

    Private Sub NewExpenseDialog_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.HelpButtonClicked
        e.Cancel = True
        Dim FeedBack As New FeedBackDialog
        FeedBack.ShowDialog()
    End Sub


End Class
