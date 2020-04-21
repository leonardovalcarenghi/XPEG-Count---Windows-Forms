Public Class TabButtonsContainer
    Inherits ContainerControl

    Dim WithEvents TabSelector As New Panel
    'Dim SelectorBackground As New Panel



    Sub New()
        MyBase.New()
        MyBase.Dock = DockStyle.Top
        MyBase.Height = 40
        'MyBase.BackColor = Color.Transparent
        CreateTabSelector()
    End Sub

    Sub CreateTabSelector()
        ''Fundo:
        'SelectorBackground = New Panel
        'SelectorBackground.Dock = DockStyle.Bottom
        'SelectorBackground.Height = 5
        '' SelectorBackground.BackColor = Color.FromArgb(230, 230, 230)
        'MyBase.Controls.Add(SelectorBackground) : SelectorBackground.SendToBack()

        ''Seletor:
        TabSelector = New Panel
        TabSelector.BackColor = TabSelectorColor
        TabSelector.Size = New Size(100, 5)
        TabSelector.Location = New Point(0, Height - TabSelector.Height)
        MyBase.Controls.Add(TabSelector)
    End Sub




#Region "Propriedades"
    Public Property TabSelectorColor As Color = Color.DarkBlue
    Public Property TabPageContainer As Control
#End Region

    Dim StartLeft, BtnWidth
    Dim BtnColor As Color

    Dim Rt, Gt, Bt As Integer
    Dim Rb, Gb, Bb As Integer
    Dim NewR, NewG, NewB As Integer

    Public Sub SelectTab(ByVal ButtonTab As TabPageButton)
        ''Obter Informações
        StartLeft = ButtonTab.Left : BtnWidth = ButtonTab.Width : BtnColor = ButtonTab.ButtonColor
       





        If Not TabPageContainer.Controls.Contains(ButtonTab.PageCtrl) Then

            ''Cores:
            Rt = TabSelector.BackColor.R
            Gt = TabSelector.BackColor.G
            Bt = TabSelector.BackColor.B

            Rb = BtnColor.R
            Gb = BtnColor.G
            Bb = BtnColor.B

            NewR = Rt
            NewG = Gt
            NewB = Bt

            'TimerEffects_ChangeColor.Start()

            ''Cor do Seletor:
            TabSelector.BackColor = BtnColor

            ''Tamanho do Selector:
            If BtnWidth < TabSelector.Width Then TimerEffect_SizeMenos.Start() Else TimerEffect_SizeMais.Start()

            ''Posição:
            If StartLeft < TabSelector.Left Then TimerEffect_MoveLeft.Start() Else TimerEffect_MoveRight.Start()

            Try : For Each A As TabPageButton In Me.Controls : A.ButtonSelected = False : Next : Catch : End Try

            ''Limpar Container:
            TabPageContainer.Controls.Clear()

            ''Adicionar Controle:
            TabPageContainer.Controls.Add(ButtonTab.PageCtrl)

            ''Slecionar Button:
            ButtonTab.ButtonSelected = True

        End If


    End Sub

    Dim WithEvents TimerEffect_MoveLeft As New Timer
    Dim WithEvents TimerEffect_MoveRight As New Timer


    Private Sub TimerEffect_MoveLeft_Tick(sender As Object, e As EventArgs) Handles TimerEffect_MoveLeft.Tick
        TimerEffect_MoveLeft.Interval = 1 : TimerEffect_MoveRight.Stop()
        TabSelector.Left = TabSelector.Left - 10

        If TabSelector.Left < StartLeft Then TabSelector.Left = StartLeft : TimerEffect_MoveLeft.Stop()
    End Sub

    Private Sub TimerEffect_MoveRight_Tick(sender As Object, e As EventArgs) Handles TimerEffect_MoveRight.Tick
        TimerEffect_MoveRight.Interval = 1 : TimerEffect_MoveLeft.Stop()
        TabSelector.Left = TabSelector.Left + 10

        If TabSelector.Left > StartLeft Then TabSelector.Left = StartLeft : TimerEffect_MoveRight.Stop()
    End Sub


    Dim WithEvents TimerEffect_SizeMais As New Timer
    Dim WithEvents TimerEffect_SizeMenos As New Timer

    Private Sub TimerEffect_SizeMais_Tick(sender As Object, e As EventArgs) Handles TimerEffect_SizeMais.Tick
        TimerEffect_SizeMais.Interval = 1 : TimerEffect_SizeMenos.Stop()
        TabSelector.Width = TabSelector.Width + 10

        If TabSelector.Width > BtnWidth Then TabSelector.Width = BtnWidth : TimerEffect_SizeMais.Stop()
    End Sub

    Private Sub TimerEffect_SizeMenos_Tick(sender As Object, e As EventArgs) Handles TimerEffect_SizeMenos.Tick
        TimerEffect_SizeMenos.Interval = 1 : TimerEffect_SizeMais.Stop()
        TabSelector.Width = TabSelector.Width - 10

        If TabSelector.Width < BtnWidth Then TabSelector.Width = BtnWidth : TimerEffect_SizeMenos.Stop()
    End Sub


    Dim WithEvents TimerEffects_ChangeColor As New Timer
    Private Sub TimmerEffects_ChangeColor(sender As Object, e As EventArgs) Handles TimerEffects_ChangeColor.Tick
        TimerEffects_ChangeColor.Interval = 1


        Try : If Rt < Rb Then NewR += 5 Else If Rt > Rb Then NewR -= 5 Else NewR = Rb
        Catch : End Try

        Try : If Gt < Gb Then NewG += 5 Else If Gt > Gb Then NewG -= 5 Else NewG = Gb
        Catch : End Try

        Try : If Bt < Bb Then NewB += 5 Else If Bt > Bb Then NewB -= 5 Else NewB = Bb
        Catch : End Try

        Try : TabSelector.BackColor = Color.FromArgb(NewR, NewG, NewB) : Catch : End Try

        If NewR = BtnColor.R And NewG = BtnColor.G And NewB = BtnColor.B Then
            MsgBox("Parou")
            TimerEffects_ChangeColor.Stop()
            TabSelector.BackColor = Color.FromArgb(Rb, Gb, Bb)
        End If

    End Sub





End Class
