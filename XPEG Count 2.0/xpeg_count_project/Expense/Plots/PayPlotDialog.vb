Imports System.IO
Imports System.Windows.Forms

Public Class PayPlotDialog

    ''' <summary>
    ''' Diretório da Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Property PlotPath As DirectoryInfo

    ''' <summary>
    ''' Valor Total da Parcela
    ''' </summary>
    Public Plot_Total As Decimal

    ''' <summary>
    ''' Valor Restante para Quitar Parcela
    ''' </summary>
    Public Plot_RestToPay As Decimal

    ''' <summary>
    ''' Data de Vencimento da Parcela
    ''' </summary>
    Public Plot_MaturityDate As Date

    Private Sub PayPlotDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Importar Informações da Parcela:
        ImportPlot()

        ''Data de Pagamento (Hj):
        DateTimePicker_PayDate.Value = Now.Date
    End Sub

    ''' <summary>
    ''' Histórico de Pagamento da Parcela:
    ''' </summary>
    Dim PaymentHistoric As List(Of FileInfo)

    ''' <summary>
    ''' Valor Total da Parcela:
    ''' </summary>
    Dim TotalValue As Decimal = 0

    ''' <summary>
    ''' Valor Pago:
    ''' </summary>
    Dim PaidValue As Decimal = 0

    ''' <summary>
    ''' Valor Restante
    ''' </summary>
    Dim RestToPay As Decimal = 0

    ''' <summary>
    ''' Data de Vencimento
    ''' </summary>
    Dim MaturityDate As Date



    Private Sub ImportPlot()
        ''Importar Histórico de Pagamento da Parcela:
        PaymentHistoric = _EXPENSE.Plot.GetHistoricPayment(PlotPath)

        ''Valor Total:
        TotalValue = _EXPENSE.Plot.TotalValue(PlotPath)

        ''Valor Pago:
        PaidValue = _EXPENSE.Plot.PaidValue(PlotPath)

        ''Valor que Falta:
        RestToPay = _EXPENSE.Plot.RestToPay(PlotPath)

        ''Dia de Vencimento:
        MaturityDate = _EXPENSE.Plot.MaturityDate(PlotPath)

        ''Display Informations:
        SetFields()
    End Sub

    Sub SetFields()
        ''Valor 'Falta' / 'Pago' / 'Total':
        Label_PlotValue.Text = "Falta: " & _StringToMoney(RestToPay) & " / Pago: " & _StringToMoney(PaidValue) & " / Total: " & _StringToMoney(TotalValue)

        ''Dia de Vencimento:
        Label_MaturityDate.Text = "Vencimento: " & MaturityDate
    End Sub

    Private Sub NextSection()
        ''Limpar Caixa de Seleção:
        ComboBox_TypePay.Items.Clear()

        ''Obter Valor que o Usuário está Pagando:
        Dim ValuePaing As Decimal = TextBox_Value.Text

        ''Verificar Valor Informado:
        Select Case ValuePaing

            Case RestToPay 'Pagamento Total / Pagando Valor Que Falta

                ''Se o Valor que Está Sendo Pago, é igual ao Valor da Parcela:
                If TotalValue = ValuePaing Then : ComboBox_TypePay.Items.Add("Valor Total")
                Else
                    ''Se o Valor que está sendo pago é igual ao Valor que falta:
                    If RestToPay = ValuePaing Then : ComboBox_TypePay.Items.Add("Valor Restante [Quitar Parcela]")
                    Else
                        ComboBox_TypePay.Items.Add("outro...")
                    End If
                End If


            Case Is < RestToPay 'Pagamento Menor que o que Falta
                MsgBox("--Falta: " & RestToPay & vbNewLine & "Pagamento: " & ValuePaing)

                If PaymentHistoric.Count = 0 Then ComboBox_TypePay.Items.Add("Reajuste de Valor [Valor Total]") : ComboBox_TypePay.Items.Add("Desconto no Pagamento [Valor Total c/ Desconto]")
                ComboBox_TypePay.Items.Add("Pagamento Parcial")


            Case Is > RestToPay 'Pagando a Mais do que Deve
                MsgBox("++Falta: " & RestToPay & vbNewLine & "Pagamento: " & ValuePaing)

                If PaymentHistoric.Count = 0 Then ComboBox_TypePay.Items.Add("Reajuste de Valor [Valor Total]")


                If ValuePaing >= TotalValue Then : ComboBox_TypePay.Items.Add("Pagamento com Juros [Valor Total c/ Juros]")
                Else
                    ComboBox_TypePay.Items.Add("Pagamento com Juros [Valor Parcial c/ Juros]")
                End If


        End Select
    End Sub

    Private Sub BackSection()

    End Sub




    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        Panel_Value.Hide() : Panel_Date.Hide() : Panel_Type.Show() : Panel_Comment.Show()
        BackButton.Show() : PayButton.Text = "Pagar"
        NextSection()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Panel_Value.Show() : Panel_Date.Show() : Panel_Type.Hide() : Panel_Comment.Hide()
        BackButton.Hide() : PayButton.Text = "Próximo"
        BackSection()
    End Sub






    Sub CheckFieldsToPay()
        If TextBox_Value.Text = Nothing Then
            MessageBox.Show("Digite o valor que você quer pagar na parcela.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox_Value.Select() : TextBox_Value.Focus()
        Else
            If Not IsNumeric(TextBox_Value.Text) Then
                MessageBox.Show("O Valor digitado não é válido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox_Value.Select() : TextBox_Value.Focus()
            Else
                If TextBox_Value.Text <= 0 Then
                    MessageBox.Show("O Valor digitado não é válido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TextBox_Value.Select() : TextBox_Value.Focus()
                Else
                    If ComboBox_TypePay.SelectedItem = Nothing Then
                        MessageBox.Show("Selecione um Tipo de Pagamento.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ComboBox_TypePay.Select() : ComboBox_TypePay.Focus()
                    Else
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Sub CalcInterest()
        'Exibir Painel:
        'Panel_InterestValues.Show()

        ''Data de Pagamento Selecionada:
        Dim DateSelected As DateTime = DateTimePicker_PayDate.Value.Date

        '' > > > CALCULAR < < < ''
        ''Valor de Juros Pago (Valor Pago - Valor da Total da Parcela)
        Dim InterestTotalValue = Val(TextBox_Value.Text - Plot_Total)

        ''Quantidade de Dias de Atraso (Data de Vencimento - Data Selecionada)
        Dim DateCalc = DateDiff(DateInterval.Day, Plot_MaturityDate, DateSelected)

        ''Resultado da Quantidade de Dias Após:
        Dim DaysAfter As Integer = CInt(DateCalc)

        ''Resultado dos Juros:
        Dim Result As Decimal
        If DaysAfter > 0 Then Result = Val(InterestTotalValue / DaysAfter) _
        Else Result = InterestTotalValue


        ''Total de Juros:
        Label_InterestValue.Text = _FormatNumberStringToMoney(InterestTotalValue)

        ''Taxa ao Dia:
        Dim InterestTotalTax, InterestPerDayTax

        If ComboBox_TypePay.SelectedIndex = 1 Then : InterestTotalTax = _FUNCTIONS.CalcInteresTax(InterestTotalValue, Plot_Total) 'Juros Normal
        Else : If ComboBox_TypePay.SelectedIndex = 2 Then InterestTotalTax = _FUNCTIONS.CalcInteresTax(InterestTotalValue, TextBox_Value.Text) 'Juros Recursivos
        End If
        InterestPerDayTax = Val(InterestTotalTax / DaysAfter)

        If InterestPerDayTax <= 0 Then
            Label_InteresTaxPerDay.Text = "Taxa não aplicavel"
        Else
            Label_InteresTaxPerDay.Text = String.Format("{0:N2}", InterestPerDayTax) & "%"
        End If



        ''Dias em Atraso:
        If DaysAfter <= 0 Then
            Label_DaysInLate.Text = "Nenhum"
        Else
            If DaysAfter = 1 Then
                Label_DaysInLate.Text = (DaysAfter) & " dia"
            Else
                Label_DaysInLate.Text = (DaysAfter) & " dias"
            End If
        End If
    End Sub

    Sub CalcNewValue()
        'Exibir Painel:
        'Panel_ChangeValue.Show()

        ''Valor da Caixa:
        Dim ValueInBox As Decimal = TextBox_Value.Text

        ''Valor da Diferença:
        Dim ResultCalc = Val(ValueInBox - Plot_Total)

        Dim Signal As String
        If ResultCalc > 0 Then Signal = "+"

        ''Novo Valor:
        Label_NewValue.Text = _FormatNumberStringToMoney(ValueInBox) & " (" & Signal & _FormatNumberStringToMoney(ResultCalc) & ")"
    End Sub

    Sub CheckFields()
        ''Salvar Seleção da Caixa:
        Dim SelectedItemIndex = ComboBox_TypePay.SelectedIndex

        ''Limpar Caixa de Lista:
        ComboBox_TypePay.Items.Clear()

        ''Esconde Painels:
        Panel_ChangeValue.Hide() : Panel_InterestValues.Hide()

        ''Verificar se Número Digitado é um Número:
        Dim ValueInBox = TextBox_Value.Text
        If IsNumeric(ValueInBox) Then

            Select Case ValueInBox
                Case Plot_Total 'Valor Total
                    ComboBox_TypePay.Items.Add("Valor Total")

                Case Is > Plot_Total 'Maior de Valor Total
                    ComboBox_TypePay.Items.Add("Reajuste de Valor")
                    If DateTimePicker_PayDate.Value.Date > Plot_MaturityDate Then
                        ComboBox_TypePay.Items.Add("Juros") 'Calcula sempre no valor da parcela.
                        'ComboBox_TypePay.Items.Add("Juros Recursivos") 'calcular sempre no valor informado.
                    End If

                Case Is < Plot_Total 'Menor que Valor Total
                    ComboBox_TypePay.Items.Add("Reajuste de Valor")
                    ComboBox_TypePay.Items.Add("Pagamento Parcial")
                    If DateTimePicker_PayDate.Value.Date < Plot_MaturityDate Then ComboBox_TypePay.Items.Add("Valor Total c/ Desconto no Pagamento")


            End Select
            Try : ComboBox_TypePay.SelectedIndex = SelectedItemIndex : Catch : End Try


        Else
            ComboBox_TypePay.Items.Add("Número Digitado é Inválido...")
        End If
    End Sub

    Enum PaymentTypeEnum : TotalValue : PartialValue : DiscountValue : TotalWithInterest : TotalWithInterestRecursive : End Enum

    Private Sub TextBox_Value_LostFocus(sender As Object, e As EventArgs) Handles TextBox_Value.LostFocus
        CheckFields()
    End Sub

    Private Sub TextBox_Value_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Value.TextChanged
        If IsNumeric(TextBox_Value.Text) Then CalcInterest()
        If IsNumeric(TextBox_Value.Text) Then CalcNewValue()
    End Sub

    Private Sub DateTimePicker_PayDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_PayDate.ValueChanged
        CheckFields()
        CalcInterest()
        CalcNewValue()
    End Sub


    
End Class
