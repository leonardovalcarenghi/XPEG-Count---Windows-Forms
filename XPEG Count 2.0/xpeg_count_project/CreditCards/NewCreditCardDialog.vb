Imports System.Windows.Forms

Public Class NewCreditCardDialog
    Private Sub TextBox_CardName_TextChanged(sender As Object, e As EventArgs) Handles TextBox_CardName.TextChanged
        If TextBox_CardName.Text <> "" Then
            CardName_Label.Text = TextBox_CardName.Text
        Else
            CardName_Label.Text = "Meu Cartão"
        End If
    End Sub

    Private Sub TextBox_UserNamePrintedInCard_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UserNamePrintedInCard.TextChanged
        If TextBox_UserNamePrintedInCard.Text <> "" Then
            Dim N As String = TextBox_UserNamePrintedInCard.Text
            CardUserName_Label.Text = N.ToUpper
        Else
            CardUserName_Label.Text = "Seu Nome Completo"
        End If
    End Sub

    Private Sub TextBox_FinallyNumbers_TextChanged(sender As Object, e As EventArgs) Handles TextBox_FinallyNumbers.TextChanged
        If TextBox_FinallyNumbers.Text <> "" Then
            Dim N As String = "XXXX XXXX XXXX XXXX " & TextBox_FinallyNumbers.Text
            CardNumbes_Label.Text = N
        Else
            CardNumbes_Label.Text = "XXXX XXXX XXXX XXXX 0000"
        End If

    End Sub

    Private Sub NewCreditCardDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Borda Arredondada na Pré-Visualização do Cartão:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CardPreview_Panel, 8)

        'Borda Arredondada na 'Bandeira' do Cartão:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CardBandeira_Panel, 5)

        'Imagem do Calendário
        STYLE_CalendarImg.Image = _FUNCTIONS.Images.ChangeImageResolution(My.Resources.FormStyleImagesResource.StyleImage_Calendar_500px, 230)
    End Sub

    Private Sub PreviewCreditCard_MouseClick(sender As Object, e As MouseEventArgs) Handles CardPreview_Panel.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim SelectColor As New SelectColorDialog
            If SelectColor.ShowDialog = DialogResult.OK Then
                CardPreview_Panel.BackColor = SelectColor.SelectedColor
            End If
        End If
    End Sub

    Private Sub CardIcon_PictureBox_MouseClick(sender As Object, e As MouseEventArgs) Handles CardIcon_PictureBox.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim SelectIcon As New SelectIconDialog
            If SelectIcon.ShowDialog = DialogResult.OK Then
                Dim IMG = Image.FromFile(SelectIcon.SelectIconFile)
                IMG = _FUNCTIONS.Images.ChangeImageResolution(IMG, 50)
                IMG = _FUNCTIONS.Images.InvertColorFromImage(IMG, Color.White)
                CardIcon_PictureBox.Image = IMG
            End If
        End If
    End Sub

    Dim FONT1 As Font = New Font("Segoe UI Semibold", 15)
    Dim FONT2 As Font = New Font("Roboto Medium", 15, FontStyle.Bold)
    Dim FONT3 As Font = New Font("Arial", 15)
    Dim FONT4 As Font = New Font("Impact", 15)
    Dim FONT5 As Font = New Font("Kristen ITC", 15)
    Dim FONT6 As Font = New Font("Nirmala UI", 15)

    Dim fontActual = 1
    Private Sub CardName_Label_MouseClick(sender As Object, e As MouseEventArgs) Handles CardName_Label.MouseClick
        fontActual += 1
        If fontActual = 1 Then
            CardName_Label.Font = FONT1
        Else
            If fontActual = 2 Then
                CardName_Label.Font = FONT2
            Else
                If fontActual = 3 Then
                    CardName_Label.Font = FONT3
                Else
                    If fontActual = 4 Then
                        CardName_Label.Font = FONT4
                    Else
                        If fontActual = 5 Then
                            CardName_Label.Font = FONT5
                        Else
                            If fontActual = 6 Then
                                CardName_Label.Font = FONT6
                                fontActual = 0
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub CardNumbes_Label_Click(sender As Object, e As EventArgs) Handles CardNumbes_Label.Click
        MsgBox("Este Elemento não tem personalização ainda", MsgBoxStyle.Critical, "XPEG Count")

    End Sub

    Private Sub CardUserName_Label_Click(sender As Object, e As EventArgs) Handles CardUserName_Label.Click
        MsgBox("Este Elemento não tem personalização ainda", MsgBoxStyle.Critical, "XPEG Count")

    End Sub

    Private Sub CardBandeira_Panel_MouseClick(sender As Object, e As MouseEventArgs) Handles CardBandeira_Panel.MouseClick
        MsgBox("Este Elemento não tem personalização ainda", MsgBoxStyle.Critical, "XPEG Count")

    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        CheckFields()
    End Sub

    Private Sub CheckFields()
        If TextBox_CardName.Text = "" Then
            MsgBox("Digite o nome do seu Cartão de Crédito.", MsgBoxStyle.Critical, "XPEG Count")
            TabControl1.SelectedTab = TabPage_CreditCard
            TextBox_CardName.Select() : TextBox_CardName.Focus()
        Else
            If TextBox_UserNamePrintedInCard.Text = "" Then
                MsgBox("Digite o nome impresso no cartão.", MsgBoxStyle.Critical, "XPEG Count")
                TabControl1.SelectedTab = TabPage_CreditCard
                TextBox_UserNamePrintedInCard.Select() : TextBox_UserNamePrintedInCard.Focus()
            Else
                If TextBox_FinallyNumbers.Text = "" Then
                    MsgBox("Infome os digitos finais do cartão. Pode ser 0000.", MsgBoxStyle.Critical, "XPEG Count")
                    TabControl1.SelectedTab = TabPage_CreditCard
                    TextBox_FinallyNumbers.Select() : TextBox_FinallyNumbers.Focus()
                Else
                    If TextBox_FinallyNumbers.Text.Length < 4 Then
                        MsgBox("Quantidade de digitos informada é inválida.", MsgBoxStyle.Critical, "XPEG Count")
                        TabControl1.SelectedTab = TabPage_CreditCard
                        TextBox_FinallyNumbers.Select() : TextBox_FinallyNumbers.Focus()
                    Else
                        If ComboBox_CloseInvoice.Text = "" Then
                            MsgBox("Informe o dia de fechamento da Fatura", MsgBoxStyle.Critical, "XPEG Count")
                            TabControl1.SelectedTab = TabPage_Dates
                            ComboBox_CloseInvoice.Select() : ComboBox_CloseInvoice.Focus()
                        Else
                            If Not IsNumeric(ComboBox_CloseInvoice.Text) Then
                                MsgBox("Informe um dia válido para o fechamento da fatura.", MsgBoxStyle.Critical, "XPEG Count")
                                TabControl1.SelectedTab = TabPage_Dates
                                ComboBox_CloseInvoice.Select() : ComboBox_CloseInvoice.Focus()

                            Else
                                If (ComboBox_CloseInvoice.Text <= 0) Or (ComboBox_CloseInvoice.Text >= 29) Then
                                    MsgBox("Informe um dia válido para o fechamento da fatura.", MsgBoxStyle.Critical, "XPEG Count")
                                    TabControl1.SelectedTab = TabPage_Dates
                                    ComboBox_CloseInvoice.Select() : ComboBox_CloseInvoice.Focus()

                                Else
                                    If ComboBox_MaturityDay.Text = "" Then
                                        MsgBox("Digite o dia de vencimento de sua fatura.", MsgBoxStyle.Critical, "XPEG Count")
                                        TabControl1.SelectedTab = TabPage_Dates
                                        ComboBox_MaturityDay.Select() : ComboBox_MaturityDay.Focus()

                                    Else
                                        If Not IsNumeric(ComboBox_MaturityDay.Text) Then
                                            MsgBox("Informe um dia válido para o vencimento da fatura.", MsgBoxStyle.Critical, "XPEG Count")
                                            TabControl1.SelectedTab = TabPage_Dates
                                            ComboBox_MaturityDay.Select() : ComboBox_MaturityDay.Focus()

                                        Else
                                            If (ComboBox_MaturityDay.Text <= 0) Or (ComboBox_MaturityDay.Text >= 29) Then
                                                MsgBox("Informe um dia válido para o vencimento da fatura.", MsgBoxStyle.Critical, "XPEG Count")
                                                TabControl1.SelectedTab = TabPage_Dates
                                                ComboBox_MaturityDay.Select() : ComboBox_MaturityDay.Focus()
                                            Else
                                                AddNewCreditCard()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub



    Dim CreditCardCode, CreditCardPath, PlotsPath
    Private Sub AddNewCreditCard()
        ''CÓDIGO DO CARTÃO''
        CreditCardCode = _FUNCTIONS.Codes.GenerateCreditCardCode

        ''DIRETÓRIO DO CARTÃO''
        CreditCardPath = _DIRECTORIES.ExpensesPath & CreditCardCode & "\"

        ''DIRETÓRIO DAS FATURAS''
        PlotsPath = CreditCardPath & "plots\"

        ' = = = = = = = = = = = = = = = = = = = = = = = = = '

        'Criar Diretório da Despesa
        IO.Directory.CreateDirectory(CreditCardPath)

        'Criar Diretório das Parcelas
        IO.Directory.CreateDirectory(PlotsPath)

        ' = = = = = = = = = = = = = = = = = = = = = = = = = '

        '' = = = = = ARQIVO 'EXPENSE.INI' = = = = = ''

        ''ARQUIVO''
        Dim CreditCardFile = CreditCardPath & "expense.xcf"

        '[EXPENSE]'
        'Nome da Despesa
        _INI.WriteIniFile(CreditCardFile, "EXPENSE", "name", TextBox_CardName.Text)

        'Descrição da Despesa
        _INI.WriteIniFile(CreditCardFile, "EXPENSE", "description", "") ''CARTÕES NÃO TEM DESCRIÇÃO

        'Categoria da Despesa
        _INI.WriteIniFile(CreditCardFile, "EXPENSE", "category", "XC.CATEGORY_CREDITCARD" & vbNewLine & vbNewLine)


        '[DATES]'
        'Data da Compra
        _INI.WriteIniFile(CreditCardFile, "DATES", "buy", "01/01/2019") ''CARTÕES NÃO TEM 'DATA DE COMPRA'

        'Data Inicial
        _INI.WriteIniFile(CreditCardFile, "DATES", "startdate", "01/01/2019" & vbNewLine & vbNewLine)

        '[LINK]'
        _INI.WriteIniFile(CreditCardFile, "LINK", "creditcard", "" & vbNewLine & vbNewLine) ''CARTÕES NÃO TEM VINCULOS COM CARTÕES


        '[HIGHLIGHT]'
        'Cor de Destaque
        _INI.WriteIniFile(CreditCardFile, "HIGHLIGHT", "color", "" & vbNewLine & vbNewLine)


        '[ICONE]'
        'Arquivo do Icone
        _INI.WriteIniFile(CreditCardFile, "ICON", "file", "" & vbNewLine & vbNewLine)


        '[SOFTWARE]'
        'Nome do Update
        _INI.WriteIniFile(CreditCardFile, "SOFTWARE", "update", "XPEG.COUNT.2")

        'Versão do Software
        _INI.WriteIniFile(CreditCardFile, "SOFTWARE", "version", My.Settings.SOFTWARE_Version & vbNewLine & vbNewLine)

        '' = = = = = CRIAR PASTAS DAS PARCELAS = = = = = ''
        'CreatePlots()


        '' = = = = = FINALIZAR CRIAÇÃO DA DESPESA = = = = = ''
        MessageBox.Show("Seu Cartão de Crédito foi adicionado com exito!", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub



End Class
