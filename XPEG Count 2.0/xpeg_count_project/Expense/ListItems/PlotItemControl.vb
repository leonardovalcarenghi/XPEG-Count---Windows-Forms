Imports System.IO

Public Class PlotItemControl

    Dim VAR_PlotTotalValue = 93.17
    Dim VAR_PlotDate = "01/01/2018"
    Dim VAR_PlotPaidValue = 0

    ''' <summary>
    ''' Diz se é uma Cartão de Crédito
    ''' </summary>
    ''' <remarks></remarks>
    Public isCreditCard As Boolean = False

    ''' <summary>
    ''' Form Pai
    ''' </summary>
    ''' <returns></returns>
    Public Property FormParent As ViewExpenseForm

    ''' <summary>
    ''' Código da Despesa da Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Property ExpenseCode As String

    ''' <summary>
    ''' Diretório (Path) da Pasta da Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Property PlotPath As DirectoryInfo

    ''' <summary>
    ''' Status da Parcela
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PlotStatus




    Private Sub PlotItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Vigiar:
        FileWatcherSystem.Path = PlotPath.Parent.FullName

        ''Fazer Controle Ficar Com Bordas Arredondadas:
        '_FUNCTIONS.Interfaces.MakeRoundedEdges(BaseItemBackgroundPanel)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotValueLabel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotValuePaidLabel, 2)


        ''Cor e Tamanho do Checked:
        ImageChecked = _FUNCTIONS.Images.InvertColorFromImage(CheckBoxPicture.Image, Color.White)
        ImageChecked = _FUNCTIONS.Images.ChangeImageResolution(CheckBoxPicture.Image, 24)

        ''Carregar Informações da Parcela:
        LoadInformations()

    End Sub

    

    Private Sub LoadInformations()
        ''Valor da Parcela:
        PlotTotalValue = _EXPENSE.Plot.TotalValue(PlotPath)

        ''Valor Pago na Parcela:
        PlotPaidValue = _EXPENSE.Plot.PaidValue(PlotPath)

        ''Mes e Ano da Parcela:
        Dim PlotYear = _EXPENSE.Plot.Year(PlotPath) : Dim PlotMonth = _EXPENSE.Plot.Month(PlotPath)
        PlotDate = "01/" & PlotMonth & "/" & PlotYear

        ''Número da Parcela:
        PlotNumberLabel.Text = _EXPENSE.Plot.Number(PlotPath)

        ''Status:
        PlotStatus = _EXPENSE.Plot.Status(PlotPath)

        ''Cor do Status:
        PlotStatusColorPanel.BackColor = _EXPENSE.Plot.StatusColor(PlotPath)

        ''Status [escrito]
        PlotStatusLabel.Text = _EXPENSE.Plot.StatusString(PlotPath)

        ''Adaptar Interface:
        InterfaceControl()
    End Sub

    Dim ImageChecked As Image
    Private Sub InterfaceControl()

        ''Arredondar Painel da Cor de Status da Parcela:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotStatusColorPanel, 3)

        ''Centralizar Label de Número da Parcela
        PlotNumberLabel.Top = (PlotStatusColorPanel.Height - PlotNumberLabel.Height) / 2
        PlotNumberLabel.Left = (PlotStatusColorPanel.Width - PlotNumberLabel.Width) / 2

    
        CheckBoxPicture.Image = Nothing
    End Sub

    Dim VAR_CheckedPlot As Boolean = False
    Public Property CheckedPlot As Boolean
        Get
            Return VAR_CheckedPlot
        End Get
        Set(value As Boolean)
            VAR_CheckedPlot = value

            Select Case value
                Case True
                    ChangeForSelectMode()
                    FormParent.AddPlotOnSelectedList(Me)
                    CheckBoxPicture.Image = ImageChecked
                    BaseItemBackgroundPanel.BackColor = Color.FromArgb(230, 230, 230)

                Case False : ChangeForNormalMode()
                    FormParent.RemovePlotOnSelectedList(Me)
                    CheckBoxPicture.Image = Nothing
                    BaseItemBackgroundPanel.BackColor = Color.Transparent
            End Select
        End Set
    End Property

    ''' <summary>
    ''' Valor Total da Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Property PlotTotalValue As Decimal
        Get
            Return VAR_PlotTotalValue
        End Get
        Set(value As Decimal)
            VAR_PlotTotalValue = value
            PlotValueLabel.Text = _FormatNumberStringToMoney(value)
        End Set
    End Property

    Public Property PlotPaidValue As Decimal
        Get
            Return VAR_PlotPaidValue
        End Get
        Set(value As Decimal)
            VAR_PlotPaidValue = value
            If value = 0 Then PlotValuePaidLabel.Hide() Else PlotValuePaidLabel.Show()
            PlotValuePaidLabel.Text = _FormatNumberStringToMoney(value)
        End Set
    End Property

    ''' <summary>
    ''' Data da Parcela
    ''' </summary>
    ''' <returns></returns>
    Public Property PlotDate As Date
        Get
            Return VAR_PlotDate
        End Get
        Set(value As Date)
            VAR_PlotDate = value
            PlotDateLabel.Text = _FUNCTIONS.GetMonthName(value.Month) & " de " & value.Year
        End Set
    End Property



    Private Sub FileWatcherSystem_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcherSystem.Changed
        If e.ChangeType = WatcherChangeTypes.Changed Then
            If IO.Directory.Exists(PlotPath.FullName) Then LoadInformations() Else FileWatcherSystem.EnableRaisingEvents = False : Me.Hide()
        End If
    End Sub

    Private Sub BaseItem_MouseClick(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseClick, PlotValuePaidLabel.MouseClick, PlotValueLabel.MouseClick, PlotStatusLabel.MouseClick, PlotInformationsPanel.MouseClick, PlotDateLabel.MouseClick, Col03_Panel.MouseClick, Col02_Panel.MouseClick, Col01_Panel.MouseClick, BaseItemBackgroundPanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If FormParent.LIST_PlotsSelecteds.Count = 0 Then
                If CheckedPlot = False Then _EXPENSE.Plot.Open(PlotPath)
            Else
                Select Case CheckedPlot
                    Case False : CheckedPlot = True
                    Case True : CheckedPlot = False
                End Select
            End If
        End If

    End Sub

    Private Sub BaseItem_MouseDown(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseDown, PlotValuePaidLabel.MouseDown, PlotValueLabel.MouseDown, PlotStatusLabel.MouseDown, PlotInformationsPanel.MouseDown, PlotDateLabel.MouseDown, Col03_Panel.MouseDown, Col02_Panel.MouseDown, Col01_Panel.MouseDown, BaseItemBackgroundPanel.MouseDown, PlotStatusColorPanel.MouseDown, PlotNumberLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then If CheckedPlot = False Then BaseItemBackgroundPanel.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub BaseItem_MouseEnter(sender As Object, e As EventArgs) Handles CheckBoxPicture.MouseEnter, PlotValuesPanel.MouseEnter, PlotValuePaidLabel.MouseEnter, PlotValueLabel.MouseEnter, PlotStatusLabel.MouseEnter, PlotInformationsPanel.MouseEnter, PlotDateLabel.MouseEnter, Col03_Panel.MouseEnter, Col02_Panel.MouseEnter, Col01_Panel.MouseEnter, BaseItemBackgroundPanel.MouseEnter, PlotStatusColorPanel.MouseEnter, PlotNumberLabel.MouseEnter
        If CheckedPlot = False Then BaseItemBackgroundPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub BaseItem_MouseLeave(sender As Object, e As EventArgs) Handles CheckBoxPicture.MouseLeave, PlotValuesPanel.MouseLeave, PlotValuePaidLabel.MouseLeave, PlotValueLabel.MouseLeave, PlotStatusLabel.MouseLeave, PlotInformationsPanel.MouseLeave, PlotDateLabel.MouseLeave, Col03_Panel.MouseLeave, Col02_Panel.MouseLeave, Col01_Panel.MouseLeave, BaseItemBackgroundPanel.MouseLeave, PlotStatusColorPanel.MouseLeave, PlotNumberLabel.MouseLeave
        If CheckedPlot = False Then BaseItemBackgroundPanel.BackColor = Color.White
    End Sub



    Private Sub PlotCheckBox_MouseClick(sender As Object, e As MouseEventArgs) Handles PlotStatusColorPanel.MouseClick, PlotNumberLabel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then CheckedPlot = True
    End Sub

    Private Sub CheckBoxPicture_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckBoxPicture.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Select Case CheckedPlot
                Case False : CheckedPlot = True
                Case True : CheckedPlot = False
            End Select
        End If

    End Sub

    Private Sub PlotCheckBox_MouseEnter(sender As Object, e As EventArgs) Handles PlotStatusColorPanel.MouseEnter, PlotNumberLabel.MouseEnter, CheckBoxPicture.MouseEnter
        'CheckBoxPicture.Show()
    End Sub

    Private Sub PlotCheckBox_MouseLeave(sender As Object, e As EventArgs) Handles PlotStatusColorPanel.MouseLeave, PlotNumberLabel.MouseLeave, CheckBoxPicture.MouseEnter
        'If CheckedPlot = False Then CheckBoxPicture.Hide()
    End Sub



#Region "Seleção de Parcelas"


    Public Sub ChangeForSelectMode()
        PlotNumberLabel.Hide() 'Esconder Numero da Parcela
        PlotStatusColorPanel.BackColor = Color.FromArgb(130, 130, 130) 'Alterar Cor para modo de Seleção
        CheckBoxPicture.Show() 'Exibir CheckBox
    End Sub


    Public Sub ChangeForNormalMode()
        PlotNumberLabel.Show() 'Esconder Numero da Parcela
        PlotStatusColorPanel.BackColor = _EXPENSE.Plot.StatusColor(PlotPath) 'Alterar Cor para cor de Status
        CheckBoxPicture.Hide() 'Esconder CheckBox
    End Sub

#End Region


   
End Class
