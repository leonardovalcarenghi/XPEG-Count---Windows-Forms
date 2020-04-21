Public Class ExpenseCategoryItemControl
    Public WithEvents FlowPanel As FlowLayoutPanel

    Private Sub ExpenseCategoryItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub FlowPanel_ControlAdded(sender As Object, e As ControlEventArgs) Handles FlowPanel.ControlAdded
        AjustarTamanho()
    End Sub

    Private Sub FlowPanel_SizeChanged(sender As Object, e As EventArgs) Handles FlowPanel.SizeChanged
        AjustarTamanho()
    End Sub

    Sub AjustarTamanho()
        If FlowPanel.VerticalScroll.Visible Then
            Me.Width = (FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right - 20)
        Else
            Me.Width = (FlowPanel.Width - FlowPanel.Padding.Left - FlowPanel.Padding.Right)
        End If

    End Sub


    Public Property CategoryText As String
        Get
            Return CategoryName_Label.Text
        End Get
        Set(value As String)
            CategoryName_Label.Text = value
        End Set
    End Property

    Dim VAR_SubCategory As Boolean = False
    Public Property SubCategory As Boolean
        Get
            Return VAR_SubCategory
        End Get
        Set(value As Boolean)
            VAR_SubCategory = value
            Select Case value

                Case False
                    CategoryName_Label.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
                    CategoryName_Label.ForeColor = Color.FromArgb(50, 50, 50)

                Case True
                    CategoryName_Label.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
                    CategoryName_Label.ForeColor = Color.FromArgb(80, 80, 80)
            End Select
        End Set
    End Property

    'Private Sub CategoryName_Label_Click(sender As Object, e As EventArgs) Handles CategoryName_Label.Click
    '    Select Case SubCategory
    '        Case True
    '            SubCategory = False
    '        Case Else
    '            SubCategory = True
    '    End Select
    'End Sub
End Class
