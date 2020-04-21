Imports System.IO

Public Class ExpenseBlockItemControl

    ''' <summary>
    ''' Código da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Public EXPENSE_Code As String


    Public WithEvents FlowPanel As FlowLayoutPanel

    ''' <summary>
    ''' Nome da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseName As String

    ''' <summary>
    ''' Descrição da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseDescription As String

    ''' <summary>
    ''' Valor da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseValue As Decimal

    ''' <summary>
    ''' Falta Para Quitar
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseRestToPay As Decimal = 0

    ''' <summary>
    ''' Cor de Destaque
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseHightColor As Color

    ''' <summary>
    ''' Icone da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Dim ExpenseIcon As Image



    Public Sub ImportInformations()
        ''Nome da Despesa:
        ExpenseName = _EXPENSE.Name(EXPENSE_Code)
        ExpenseName_Label.Text = ExpenseName

        ''Descrição da Despesa:
        ExpenseDescription = _EXPENSE.Description(EXPENSE_Code)
        If ExpenseDescription = Nothing Then
            ExpenseName_Label.Top = (ExpensePanel.Height - ExpenseName_Label.Height) / 2
        Else
            ExpenseName_Label.Top = 21
        End If
        ExpenseDescription_Label.Text = ExpenseDescription

        ''Valor da Despesa:
        ExpenseValue = _EXPENSE.Values.Total(EXPENSE_Code)
        ExpenseValue_Label.Text = _StringToMoney(ExpenseValue)

        ''Falta para Pagar:7
        ExpenseRestToPay = _EXPENSE.Values.RestToPay(EXPENSE_Code)
        RestToPay_Label.Text = "Falta " & _StringToMoney(ExpenseRestToPay)

        ''Cor de Destaque:
        ExpenseHightColor = _EXPENSE.HightColor(EXPENSE_Code)
        ExpenseIcon_PictureBox.BackColor = ExpenseHightColor

        ''Icone:
        ExpenseIcon = _EXPENSE.Icon(EXPENSE_Code)
        If Not IsNothing(ExpenseIcon) Then
            ExpenseIcon = _FUNCTIONS.Images.InvertColorFromImage(ExpenseIcon, Color.White)
            ExpenseIcon = _FUNCTIONS.Images.ChangeImageResolution(ExpenseIcon, 32)
            ExpenseIcon_PictureBox.Image = ExpenseIcon
        End If
    
    End Sub

    Private Sub ExpenseBlockItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Habilitar FileWatcher
        FileWatcher_Values.Path = _EXPENSE.Path(EXPENSE_Code).FullName

        'Arredondar Panel de Cor de Destaque
        _FUNCTIONS.Interfaces.MakeRoundedEdges(ExpenseIcon_PictureBox, 2)

        Me.BackColor = Color.Transparent
        ImportInformations()
    End Sub

    Private Sub FlowPanel_ControlAdded(sender As Object, e As ControlEventArgs) Handles FlowPanel.ControlAdded
        ResizeMe()
    End Sub

    Private Sub FlowPanel_SizeChanged(sender As Object, e As EventArgs) Handles FlowPanel.SizeChanged
        ResizeMe()
    End Sub

    Private Sub ResizeMe()
        Dim NumberOfItems = 3
        Select Case FlowPanel.Width
            Case <= 1200
                NumberOfItems = 2
            Case <= 1400
                NumberOfItems = 3
            Case Else
                NumberOfItems = 4
        End Select

        If FlowPanel.VerticalScroll.Visible Then
            Me.Width = (FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right - 20) / NumberOfItems
        Else
            Me.Width = (FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right - 2) / NumberOfItems
        End If
    End Sub

   


   


   

    Private Sub ExpensePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles RestToPay_Label.MouseClick, ExpenseValue_Label.MouseClick, ExpensePanel.MouseClick, ExpenseName_Label.MouseClick, ExpenseIcon_PictureBox.MouseClick, ExpenseDescription_Label.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then _EXPENSE.OpenExpense(EXPENSE_Code)
    End Sub

    Private Sub ExpensePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles RestToPay_Label.MouseDown, ExpenseValue_Label.MouseDown, ExpensePanel.MouseDown, ExpenseName_Label.MouseDown, ExpenseIcon_PictureBox.MouseDown, ExpenseDescription_Label.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then ExpensePanel.BackColor = Color.FromArgb(235, 233, 240)
    End Sub

    Private Sub ExpensePanel_MouseEnter(sender As Object, e As EventArgs) Handles RestToPay_Label.MouseEnter, ExpenseValue_Label.MouseEnter, ExpensePanel.MouseEnter, ExpenseName_Label.MouseEnter, ExpenseIcon_PictureBox.MouseEnter, ExpenseDescription_Label.MouseEnter
        ExpensePanel.BackColor = Color.FromArgb(230, 238, 245)
    End Sub

    Private Sub ExpensePanel_MouseLeave(sender As Object, e As EventArgs) Handles RestToPay_Label.MouseLeave, ExpenseValue_Label.MouseLeave, ExpensePanel.MouseLeave, ExpenseName_Label.MouseLeave, ExpenseIcon_PictureBox.MouseLeave, ExpenseDescription_Label.MouseLeave
        ExpensePanel.BackColor = Color.FromArgb(240, 248, 255)
    End Sub

    Private Sub FileWatcher_Values_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcher_Values.Changed
        If e.ChangeType = WatcherChangeTypes.Changed Then ImportInformations()
    End Sub
End Class
