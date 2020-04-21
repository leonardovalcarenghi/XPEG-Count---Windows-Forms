Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Design
Module LogInThemeModule



#Region "Functions"

    Dim Height As Integer
        Dim Width As Integer

        Public Function RoundRectangle(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
            Dim P As GraphicsPath = New GraphicsPath()
            Dim ArcRectangleWidth As Integer = Curve * 2
            P.AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            P.AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            P.AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            P.AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
            Return P
        End Function

        Public Function RoundRect(x!, y!, w!, h!, Optional r! = 0.3, Optional TL As Boolean = True, Optional TR As Boolean = True, Optional BR As Boolean = True, Optional BL As Boolean = True) As GraphicsPath
            Dim d! = Math.Min(w, h) * r, xw = x + w, yh = y + h
            RoundRect = New GraphicsPath

            With RoundRect
                If TL Then .AddArc(x, y, d, d, 180, 90) Else .AddLine(x, y, x, y)
                If TR Then .AddArc(xw - d, y, d, d, 270, 90) Else .AddLine(xw, y, xw, y)
                If BR Then .AddArc(xw - d, yh - d, d, d, 0, 90) Else .AddLine(xw, yh, xw, yh)
                If BL Then .AddArc(x, yh - d, d, d, 90, 90) Else .AddLine(x, yh, x, yh)

                .CloseFigure()
            End With
        End Function

        Enum MouseState As Byte
            None = 0
            Over = 1
            Down = 2
            Block = 3
        End Enum

#End Region

    End Module




Public Class LogInContextMenu
    Inherits ContextMenuStrip

#Region "Declarations"

    Private _FontColour As Color = Color.FromArgb(255, 255, 255)

#End Region

#Region "Properties"

    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"

    Sub New()
        'Renderer = New ToolStripProfessionalRenderer(New LogInColourTable())
        ShowCheckMargin = False
        ShowImageMargin = False
        ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        MyBase.OnPaint(e)
    End Sub

#End Region

End Class




Public Class LogInGroupBox
    Inherits ContainerControl

#Region "Declarations"
    Private _MainColour As Color = Color.FromArgb(47, 47, 47)
    Private _HeaderColour As Color = Color.FromArgb(42, 42, 42)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
#End Region

#Region "Properties"

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
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property HeaderColour As Color
        Get
            Return _HeaderColour
        End Get
        Set(value As Color)
            _HeaderColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property MainColour As Color
        Get
            Return _MainColour
        End Get
        Set(value As Color)
            _MainColour = value
        End Set
    End Property

#End Region

#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(160, 110)
        Font = New Font("Segoe UI", 10, FontStyle.Bold)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim Circle As New Rectangle(8, 8, 10, 10)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_MainColour), New Rectangle(0, 28, Width, Height))
            .FillRectangle(New SolidBrush(_HeaderColour), New Rectangle(0, 0, .MeasureString(Text, Font).Width + 7, 28))
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Point(5, 5))
            Dim P() As Point = {New Point(0, 0), New Point(.MeasureString(Text, Font).Width + 7, 0), New Point(.MeasureString(Text, Font).Width + 7, 28),
                                New Point(Width - 1, 28), New Point(Width - 1, Height - 1), New Point(1, Height - 1), New Point(1, 1)}
            .DrawLines(New Pen(_BorderColour), P)
            .DrawLine(New Pen(_BorderColour, 2), New Point(0, 28), New Point(.MeasureString(Text, Font).Width + 7, 28))
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region

End Class





Public Class LogInComboBox
    Inherits ComboBox

#Region "Declarations"
    Private _StartIndex As Integer = 0
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BaseColour As Color = Color.FromArgb(42, 42, 42)
    Private _FontColour As Color = Color.FromArgb(255, 255, 255)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _SqaureColour As Color = Color.FromArgb(47, 47, 47)
    Private _ArrowColour As Color = Color.FromArgb(30, 30, 30)
    Private _SqaureHoverColour As Color = Color.FromArgb(52, 52, 52)
    Private State As MouseState = MouseState.None
#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureColour As Color
        Get
            Return _SqaureColour
        End Get
        Set(value As Color)
            _SqaureColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SqaureHoverColour As Color
        Get
            Return _SqaureHoverColour
        End Get
        Set(value As Color)
            _SqaureHoverColour = value
        End Set
    End Property

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over : Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
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
    Public Property BaseColour As Color
        Get
            Return _BaseColour
        End Get
        Set(value As Color)
            _BaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _FontColour
        End Get
        Set(value As Color)
            _FontColour = value
        End Set
    End Property

    Public Property StartIndex As Integer
        Get
            Return _StartIndex
        End Get
        Set(ByVal value As Integer)
            _StartIndex = value
            Try
                MyBase.SelectedIndex = value
            Catch
            End Try
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnTextChanged(e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.Invalidate()
        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As System.Windows.Forms.MouseEventArgs)
        MyBase.Invalidate()
        MyBase.OnMouseUp(e)
    End Sub

#End Region

#Region "Draw Control"

    Sub ReplaceItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles Me.DrawItem
        e.DrawBackground()
        e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
        Dim Rect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 1, e.Bounds.Height + 1)
        Try
            With e.Graphics
                If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                    .FillRectangle(New SolidBrush(_SqaureColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                Else
                    .FillRectangle(New SolidBrush(_BaseColour), Rect)
                    .DrawString(MyBase.GetItemText(MyBase.Items(e.Index)), Font, New SolidBrush(_FontColour), 1, e.Bounds.Top + 2)
                End If
            End With
        Catch
        End Try
        e.DrawFocusRectangle()
        Me.Invalidate()

    End Sub

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or
               ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or
               ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        DropDownStyle = ComboBoxStyle.DropDownList
        Me.Width = 163
        Font = New Font("Segoe UI", 10)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            Try
                Dim Square As New Rectangle(Width - 25, 0, Width, Height)
                .FillRectangle(New SolidBrush(_BaseColour), New Rectangle(0, 0, Width - 25, Height))
                Select Case State
                    Case MouseState.None
                        .FillRectangle(New SolidBrush(_SqaureColour), Square)
                    Case MouseState.Over
                        .FillRectangle(New SolidBrush(_SqaureHoverColour), Square)
                End Select
                .DrawLine(New Pen(_LineColour, 2), New Point(Width - 26, 1), New Point(Width - 26, Height - 1))
                Try
                    .DrawString(Text, Font, New SolidBrush(_FontColour), New Rectangle(3, 0, Width - 20, Height), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Near})
                Catch : End Try
                .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(0, 0, Width, Height))
                Dim P() As Point = {New Point(Width - 17, 11), New Point(Width - 13, 5), New Point(Width - 9, 11)}
                .FillPolygon(New SolidBrush(_BorderColour), P)
                .DrawPolygon(New Pen(_ArrowColour), P)
                Dim P1() As Point = {New Point(Width - 17, 15), New Point(Width - 13, 21), New Point(Width - 9, 15)}
                .FillPolygon(New SolidBrush(_BorderColour), P1)
                .DrawPolygon(New Pen(_ArrowColour), P1)
            Catch
            End Try
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class



Public Class LogInTrackBar
    Inherits Control

#Region "Declaration"
    Private _Maximum As Integer = 10
    Private _Value As Integer = 0
    Private CaptureMovement As Boolean = False
    Private Bar As Rectangle = New Rectangle(0, 10, Width - 21, Height - 21)
    Private Track As Size = New Size(25, 14)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
    Private _BorderColour As Color = Color.FromArgb(35, 35, 35)
    Private _BarBaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _StripColour As Color = Color.FromArgb(42, 42, 42)
    Private _StripAmountColour As Color = Color.FromArgb(23, 119, 151)
#End Region

#Region "Properties"

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
    Public Property BarBaseColour As Color
        Get
            Return _BarBaseColour
        End Get
        Set(value As Color)
            _BarBaseColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property StripColour As Color
        Get
            Return _StripColour
        End Get
        Set(value As Color)
            _StripColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property TextColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property StripAmountColour As Color
        Get
            Return _StripAmountColour
        End Get
        Set(value As Color)
            _StripAmountColour = value
        End Set
    End Property

    Public Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then _Maximum = value
            If value < _Value Then _Value = value
            Invalidate()
        End Set
    End Property

    Event ValueChanged()

    Public Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < 0
                    _Value = 0
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            Invalidate()
            RaiseEvent ValueChanged()
        End Set
    End Property

    Protected Overrides Sub OnHandleCreated(ByVal e As System.EventArgs)
        Me.BackColor = Color.Transparent
        MyBase.OnHandleCreated(e)
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim MovementPoint = New Rectangle(New Point(e.Location.X, e.Location.Y), New Size(1, 1))
        Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
        If New Rectangle(New Point(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2 - 1), 0), New Size(Track.Width, Height)).IntersectsWith(MovementPoint) Then
            CaptureMovement = True
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        CaptureMovement = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If CaptureMovement Then
            Dim MovementPoint As Point = New Point(e.X, e.Y)
            Dim Bar As Rectangle = New Rectangle(10, 10, Width - 21, Height - 21)
            Value = CInt(Maximum * ((MovementPoint.X - Bar.X) / Bar.Width))
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e) : CaptureMovement = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or
                    ControlStyles.UserPaint Or ControlStyles.Selectable Or
                    ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            Bar = New Rectangle(13, 11, Width - 27, Height - 21)
            .Clear(Parent.FindForm.BackColor)
            .SmoothingMode = SmoothingMode.AntiAlias
            .TextRenderingHint = TextRenderingHint.AntiAliasGridFit
            .FillRectangle(New SolidBrush(_StripColour), New Rectangle(3, CInt((Height / 2) - 4), Width - 5, 8))
            .DrawRectangle(New Pen(_BorderColour, 2), New Rectangle(4, CInt((Height / 2) - 4), Width - 5, 8))
            .FillRectangle(New SolidBrush(_StripAmountColour), New Rectangle(4, CInt((Height / 2) - 4), CInt(Bar.Width * (Value / Maximum)) + CInt(Track.Width / 2), 8))
            .FillRectangle(New SolidBrush(_BarBaseColour), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawRectangle(New Pen(_BorderColour, 2), Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width, Track.Height)
            .DrawString(_Value, New Font("Segoe UI", 6.5, FontStyle.Regular), New SolidBrush(_TextColour), New Rectangle(Bar.X + CInt(Bar.Width * (Value / Maximum)) - CInt(Track.Width / 2), Bar.Y + CInt((Bar.Height / 2)) - CInt(Track.Height / 2), Track.Width - 1, Track.Height), New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")>
Public Class LogInVerticalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private TSA As Rectangle
    Private BSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)

#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
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

    <Category("Colours")>
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        TSA = New Rectangle(0, 1, Width, 0)
        Shaft = New Rectangle(0, TSA.Bottom - 1, Width, Height - 3)
        ShowThumb = ((_Maximum - _Minimum))
        If ShowThumb Then
            Thumb = New Rectangle(1, 0, Width - 3, _ThumbSize)
        End If
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.Y = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Height - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If TSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf BSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbPressed = True
                    Return
                Else
                    If e.Y < Thumb.Y Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbPressed AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.Y - TSA.Height - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Height - _ThumbSize
            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbPressed = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or
                            ControlStyles.UserPaint Or ControlStyles.Selectable Or
                            ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Size = New Size(24, 50)
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Height, Height)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(_BaseColour)
            Dim P() As Point = {New Point(Width / 2, 5), New Point(Width / 4, 13), New Point(Width / 2 - 2, 13), New Point(Width / 2 - 2, Height - 13),
                                New Point(Width / 4, Height - 13), New Point(Width / 2, Height - 5), New Point(Width - Width / 4 - 1, Height - 13), New Point(Width / 2 + 2, Height - 13),
                                New Point(Width / 2 + 2, 13), New Point(Width - Width / 4 - 1, 13)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen(_LineColour, 2), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Y + 4), New Point(CInt(Thumb.Width / 2 + 1), Thumb.Bottom - 4))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class

<DefaultEvent("Scroll")>
Public Class LogInHorizontalScrollBar
    Inherits Control

#Region "Declarations"

    Private ThumbMovement As Integer
    Private LSA As Rectangle
    Private RSA As Rectangle
    Private Shaft As Rectangle
    Private Thumb As Rectangle
    Private ShowThumb As Boolean
    Private ThumbPressed As Boolean
    Private _ThumbSize As Integer = 24
    Private _Minimum As Integer = 0
    Private _Maximum As Integer = 100
    Private _Value As Integer = 0
    Private _SmallChange As Integer = 1
    Private _ButtonSize As Integer = 16
    Private _LargeChange As Integer = 10
    Private _ThumbBorder As Color = Color.FromArgb(35, 35, 35)
    Private _LineColour As Color = Color.FromArgb(23, 119, 151)
    Private _ArrowColour As Color = Color.FromArgb(37, 37, 37)
    Private _BaseColour As Color = Color.FromArgb(47, 47, 47)
    Private _ThumbColour As Color = Color.FromArgb(55, 55, 55)
    Private _ThumbSecondBorder As Color = Color.FromArgb(65, 65, 65)
    Private _FirstBorder As Color = Color.FromArgb(55, 55, 55)
    Private _SecondBorder As Color = Color.FromArgb(35, 35, 35)
    Private ThumbDown As Boolean = False
#End Region

#Region "Properties & Events"

    <Category("Colours")>
    Public Property ThumbBorder As Color
        Get
            Return _ThumbBorder
        End Get
        Set(value As Color)
            _ThumbBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property LineColour As Color
        Get
            Return _LineColour
        End Get
        Set(value As Color)
            _LineColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ArrowColour As Color
        Get
            Return _ArrowColour
        End Get
        Set(value As Color)
            _ArrowColour = value
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

    <Category("Colours")>
    Public Property ThumbColour As Color
        Get
            Return _ThumbColour
        End Get
        Set(value As Color)
            _ThumbColour = value
        End Set
    End Property

    <Category("Colours")>
    Public Property ThumbSecondBorder As Color
        Get
            Return _ThumbSecondBorder
        End Get
        Set(value As Color)
            _ThumbSecondBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property FirstBorder As Color
        Get
            Return _FirstBorder
        End Get
        Set(value As Color)
            _FirstBorder = value
        End Set
    End Property

    <Category("Colours")>
    Public Property SecondBorder As Color
        Get
            Return _SecondBorder
        End Get
        Set(value As Color)
            _SecondBorder = value
        End Set
    End Property

    Event Scroll(ByVal sender As Object)

    Property Minimum() As Integer
        Get
            Return _Minimum
        End Get
        Set(ByVal value As Integer)
            _Minimum = value
            If value > _Value Then _Value = value
            If value > _Maximum Then _Maximum = value
            InvalidateLayout()
        End Set
    End Property

    Property Maximum() As Integer
        Get
            Return _Maximum
        End Get
        Set(ByVal value As Integer)
            If value < _Value Then _Value = value
            If value < _Minimum Then _Minimum = value
        End Set
    End Property

    Property Value() As Integer
        Get
            Return _Value
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is = _Value
                    Exit Property
                Case Is < _Minimum
                    _Value = _Minimum
                Case Is > _Maximum
                    _Value = _Maximum
                Case Else
                    _Value = value
            End Select
            InvalidatePosition()
            RaiseEvent Scroll(Me)
        End Set
    End Property

    Public Property SmallChange() As Integer
        Get
            Return _SmallChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Is >
                    _SmallChange = value
            End Select
        End Set
    End Property

    Public Property LargeChange() As Integer
        Get
            Return _LargeChange
        End Get
        Set(ByVal value As Integer)
            Select Case value
                Case Is < 1
                Case Else
                    _LargeChange = value
            End Select
        End Set
    End Property

    Public Property ButtonSize As Integer
        Get
            Return _ButtonSize
        End Get
        Set(value As Integer)
            Select Case value
                Case Is < 16
                    _ButtonSize = 16
                Case Else
                    _ButtonSize = value
            End Select
        End Set
    End Property

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        InvalidateLayout()
    End Sub

    Private Sub InvalidateLayout()
        LSA = New Rectangle(0, 1, 0, Height)
        Shaft = New Rectangle(LSA.Right + 1, 0, Width - 3, Height)
        ShowThumb = ((_Maximum - _Minimum))
        Thumb = New Rectangle(0, 1, _ThumbSize, Height - 3)
        RaiseEvent Scroll(Me)
        InvalidatePosition()
    End Sub

    Private Sub InvalidatePosition()
        Thumb.X = CInt(((_Value - _Minimum) / (_Maximum - _Minimum)) * (Shaft.Width - _ThumbSize) + 1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ShowThumb Then
            If LSA.Contains(e.Location) Then
                ThumbMovement = _Value - _SmallChange
            ElseIf RSA.Contains(e.Location) Then
                ThumbMovement = _Value + _SmallChange
            Else
                If Thumb.Contains(e.Location) Then
                    ThumbDown = True
                    Return
                Else
                    If e.X < Thumb.X Then
                        ThumbMovement = _Value - _LargeChange
                    Else
                        ThumbMovement = _Value + _LargeChange
                    End If
                End If
            End If
            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If ThumbDown AndAlso ShowThumb Then
            Dim ThumbPosition As Integer = e.X - LSA.Width - (_ThumbSize \ 2)
            Dim ThumbBounds As Integer = Shaft.Width - _ThumbSize

            ThumbMovement = CInt((ThumbPosition / ThumbBounds) * (_Maximum - _Minimum)) + _Minimum

            Value = Math.Min(Math.Max(ThumbMovement, _Minimum), _Maximum)
            InvalidatePosition()
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        ThumbDown = False
    End Sub

#End Region

#Region "Draw Control"

    Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or
                           ControlStyles.UserPaint Or ControlStyles.Selectable Or
                           ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Height = 18
    End Sub

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Width)
        Dim G = Graphics.FromImage(B)
        With G
            .TextRenderingHint = TextRenderingHint.ClearTypeGridFit
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(Color.FromArgb(47, 47, 47))
            Dim P() As Point = {New Point(5, Height / 2), New Point(13, Height / 4), New Point(13, Height / 2 - 2), New Point(Width - 13, Height / 2 - 2),
                    New Point(Width - 13, Height / 4), New Point(Width - 5, Height / 2), New Point(Width - 13, Height - Height / 4 - 1), New Point(Width - 13, Height / 2 + 2),
                               New Point(13, Height / 2 + 2), New Point(13, Height - Height / 4 - 1)}
            .FillPolygon(New SolidBrush(_ArrowColour), P)
            .FillRectangle(New SolidBrush(_ThumbColour), Thumb)
            .DrawRectangle(New Pen(_ThumbBorder), Thumb)
            .DrawRectangle(New Pen(_ThumbSecondBorder), Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2)
            .DrawLine(New Pen((_LineColour), 2), New Point(Thumb.X + 4, (CInt(Thumb.Height / 2 + 1))), New Point(Thumb.Right - 4, (CInt(Thumb.Height / 2 + 1))))
            .DrawRectangle(New Pen(_FirstBorder), 0, 0, Width - 1, Height - 1)
            .DrawRectangle(New Pen(_SecondBorder), 1, 1, Width - 3, Height - 3)
        End With
        MyBase.OnPaint(e)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

#End Region

End Class