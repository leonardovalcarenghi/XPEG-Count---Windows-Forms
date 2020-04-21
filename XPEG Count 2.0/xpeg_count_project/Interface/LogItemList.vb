Imports System.IO

Public Class LogItemList

    Public LOG_File As FileInfo

    Private Sub LogItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '_FUNCTIONS.Interfaces.MakeRoundedEdges(Me, 5)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PanelControl, 5)

        Label_Version.Text = LOG_File.Name.Replace(".rtf", "")
    End Sub

    Private Sub PanelControl_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseClick, PanelControl.MouseClick, Label14.MouseClick, Label_Version.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                Dim ViewLogFile As New NewsInSoftwareDialog
                ViewLogFile.VersionLog_RichTextBox.LoadFile(LOG_File.FullName)
                ViewLogFile.ShowDialog()
            Catch ex As Exception
                MsgBox("Falha ao Carregar Arquivo de Log", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub PanelControl_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox7.MouseEnter, PanelControl.MouseEnter, Label14.MouseEnter, Label_Version.MouseEnter
        PanelControl.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub PanelControl_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave, PanelControl.MouseLeave, Label14.MouseLeave, Label_Version.MouseLeave
        PanelControl.BackColor = Color.FromArgb(230, 230, 230)
    End Sub
End Class


'Public Class ShadowPanel
'    Inherits Panel

'    Declare Function GetWindowDC Lib "user32" Alias "GetWindowDC" (ByValhwnd As IntPtr) As IntPtr
'    Declare Function ReleaseDC Lib "user32" Alias "ReleaseDC" (ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Integer

'    Public Sub New()
'        Me.BorderStyle = BorderStyle.Fixed3D
'    End Sub

'    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
'        Const WM_NCPAINT = &H85

'        If m.Msg = WM_NCPAINT Then
'            Dim hdc As IntPtr = GetWindowDC(m.HWnd)
'            Dim g As Graphics = Graphics.FromHdc(hdc)
'            Dim rDraw As Rectangle = New Rectangle(0, 0, Me.Width - 1,
'            Me.Height - 1)

'            Dim pBottom As Pen = New Pen(Color.Gray, 2)
'            Dim pTop As Pen = New Pen(Color.White, 2)

'            g.DrawRectangle(pBottom, rDraw)

'            Dim pts(2) As Point

'            pts(0) = New Point(0, Me.Height - 1)
'            pts(1) = New Point(0, 0)
'            pts(2) = New Point(Me.Width - 1, 0)

'            g.DrawLines(pTop, pts)
'            ReleaseDC(Me.Handle, hdc)
'        Else
'            MyBase.WndProc(m)

'        End If

'    End Sub
'End Class
