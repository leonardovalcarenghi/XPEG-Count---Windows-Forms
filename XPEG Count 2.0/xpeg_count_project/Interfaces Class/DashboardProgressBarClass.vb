Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class DashboardProgressBarCircle
    Inherits Control

#Region "Declarations"
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _ProgressColour As Color = Color.FromArgb(0, 160, 199)
    Private _Value As Integer = 0
    Private _Maximum As Integer = 100
    Private _StartingAngle As Integer = 110
    Private _RotationAngle As Integer = 255
    Private _Font As Font = New Font("Segoe UI", 16)
#End Region

#Region "Properties"
    Dim _ShowPorcent As Boolean = True

    <Category("Control")>
    Public Property ShowPorcent As Boolean
        Get
            Return _ShowPorcent
        End Get
        Set(value As Boolean)
            _ShowPorcent = value
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(V As Integer)
            Select Case V
                Case Is < _Value
                    _Value = V
            End Select
            _Maximum = V
            Invalidate()
        End Set
    End Property

    <Category("Control")>
    Public Property Value() As Integer
        Get
            Select Case _Value
                Case 0
                    Return 0
                    Invalidate()
                Case Else
                    Return _Value
                    Invalidate()
            End Select
        End Get

        Set(V As Integer)
            Select Case V
                Case Is > _Maximum
                    V = _Maximum
                    Invalidate()
            End Select
            _Value = V
            Invalidate()
        End Set
    End Property

    Public Sub Increment(ByVal Amount As Integer)
        Value += Amount
    End Sub

    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ProgressColour As Color
        Get
            Return _ProgressColour
        End Get
        Set(value As Color)
            _ProgressColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Control")>
    Public Property StartingAngle As Integer
        Get
            Return _StartingAngle
        End Get
        Set(value As Integer)
            _StartingAngle = value
        End Set
    End Property

    <Category("Control")>
    Public Property RotationAngle As Integer
        Get
            Return _RotationAngle
        End Get
        Set(value As Integer)
            _RotationAngle = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
                ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
                ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(78, 78)
        BackColor = Color.Transparent
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Select Case _Value
                Case 0
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    If _ShowPorcent Then .DrawString(_Value & "%", _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case _Maximum
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    If _ShowPorcent Then .DrawString(_Value & "%", _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
                Case Else
                    .DrawArc(New Pen(New SolidBrush(_BorderColour), 1 + 5), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle - 3, _RotationAngle + 5)
                    .DrawArc(New Pen(New SolidBrush(_BaseColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, _RotationAngle)
                    .DrawArc(New Pen(New SolidBrush(_ProgressColour), 1 + 3), CInt(3 / 2) + 1, CInt(3 / 2) + 1, Width - 3 - 4, Height - 3 - 3, _StartingAngle, CInt((_RotationAngle / _Maximum) * _Value))
                    If _ShowPorcent Then .DrawString(_Value & "%", _Font, Brushes.White, New Point(Width / 2, Height / 2 - 1), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            End Select
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class


