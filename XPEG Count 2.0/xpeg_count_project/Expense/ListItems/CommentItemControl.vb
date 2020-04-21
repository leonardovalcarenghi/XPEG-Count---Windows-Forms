Imports System.IO

Public Class CommentItemControl

    Public CommentFile As FileInfo

    Private Sub CommentItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Dock:
        Me.Dock = DockStyle.Top

        ''BackColor:
        Me.BackColor = Color.Transparent

        ''Arredondar Elementos:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CommentDateLabel, 2)
        '_FUNCTIONS.Interfaces.MakeRoundedEdges(BaseItemBackgroundPanel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(Btn_ShowQuickOptions, 2)

        ''Importar Informações do Comentário:
        ImportInformations()
    End Sub

    Dim TitleComment
    Dim TextComment
    Dim DateComment

    Private Sub ImportInformations()
        ''Título:
        TitleComment = _EXPENSE.Plot.Comment.Title(CommentFile)
        CommentTitleLabel.Text = TitleComment

        ''Texto:
        TextComment = _EXPENSE.Plot.Comment.Text(CommentFile)
        CommentTextLabel.Text = TextComment

        ''Data:
        DateComment = _EXPENSE.Plot.Comment.DateComment(CommentFile)
        CommentDateLabel.Text = DateComment
    End Sub


    Private Sub Btn_ShowQuickOptions_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_ShowQuickOptions.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ContextMenuStrip_QuickOptions.Show(Btn_ShowQuickOptions, New Point(Btn_ShowQuickOptions.Width - ContextMenuStrip_QuickOptions.Width, Btn_ShowQuickOptions.Height))
        End If
    End Sub

    Private Sub Btn_ShowQuickOptions_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ShowQuickOptions.MouseEnter
        Btn_ShowQuickOptions.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub Btn_ShowQuickOptions_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ShowQuickOptions.MouseLeave
        Btn_ShowQuickOptions.BackColor = Color.Transparent
    End Sub


    Private Sub BaseItemBackgroundPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseClick, PlotStatusColorPanel.MouseClick, PlotInformationsPanel.MouseClick, CommentTitleLabel.MouseClick, CommentTextLabel.MouseClick, CommentDateLabel.MouseClick, Col03_Panel.MouseClick, Col02_Panel.MouseClick, Col01_Panel.MouseClick, BaseItemBackgroundPanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim ViewComment As ViewCommentDialog = New ViewCommentDialog
            ViewComment.CommentTitleLabel.Text = TitleComment : ViewComment.CommentTextLabel.Text = TextComment
            ViewComment.ShowDialog()
        End If
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseDown, PlotStatusColorPanel.MouseDown, PlotInformationsPanel.MouseDown, CommentTitleLabel.MouseDown, CommentTextLabel.MouseDown, CommentDateLabel.MouseDown, Col03_Panel.MouseDown, Col02_Panel.MouseDown, Col01_Panel.MouseDown, BaseItemBackgroundPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then BaseItemBackgroundPanel.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseEnter(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseEnter, PlotStatusColorPanel.MouseEnter, PlotInformationsPanel.MouseEnter, CommentTitleLabel.MouseEnter, CommentTextLabel.MouseEnter, CommentDateLabel.MouseEnter, Col03_Panel.MouseEnter, Col02_Panel.MouseEnter, Col01_Panel.MouseEnter, BaseItemBackgroundPanel.MouseEnter
        BaseItemBackgroundPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub BaseItemBackgroundPanel_MouseLeave(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseLeave, PlotStatusColorPanel.MouseLeave, PlotInformationsPanel.MouseLeave, CommentTitleLabel.MouseLeave, CommentTextLabel.MouseLeave, CommentDateLabel.MouseLeave, Col03_Panel.MouseLeave, Col02_Panel.MouseLeave, Col01_Panel.MouseLeave, BaseItemBackgroundPanel.MouseLeave
        BaseItemBackgroundPanel.BackColor = Color.White
    End Sub

   
    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Select Case MessageBox.Show("Deseja realmente remover esse comentário da parcela?", "XPEG Count", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Case DialogResult.Yes
                If _EXPENSE.Plot.Comment.Delete(CommentFile) = True Then
                    MsgBox("Comentário removido com sucesso!", MsgBoxStyle.Information, "XPEG Count")
                    Me.Hide()
                Else
                    MsgBox("Houve um problema ao remover esse comentário.", MsgBoxStyle.Critical, "XPEG Count")
                End If
        End Select
    End Sub
End Class
