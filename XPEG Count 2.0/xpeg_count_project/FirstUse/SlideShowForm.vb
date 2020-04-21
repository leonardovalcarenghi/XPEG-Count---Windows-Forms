Public Class SlideShowForm

    Dim SLIDES As New List(Of Control)
    Dim ActualSlide As Integer = 0


    Dim SLIDE1 As New SlideShow01
    Dim SLIDE2 As New SlideShow02
    Dim SLIDE3 As New SlideShow03
    Dim SLIDE4 As New SlideShow04

    Private Sub SlideShowForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.oldUser = True
        SLIDES.Add(SLIDE1)
        SLIDES.Add(SLIDE2)
        SLIDES.Add(SLIDE3)
        SLIDES.Add(SLIDE4)
        ActualSlide = 0

        SlideShowPagesPanel.Controls.Add(SLIDES.Item(ActualSlide))

    End Sub



    Public Sub NextSlide()
        ''Exibir Button "Voltar":
        BackButton.Show()
        ''Texto Botão "Próximo":
        If ActualSlide = (SLIDES.Count - 2) Then NextButton.Text = "Concluir"


        ''Trocar de Slides:
        ActualSlide += 1
        SlideShowPagesPanel.Controls.Clear() : SlideShowPagesPanel.Controls.Add(SLIDES.Item(ActualSlide))
    End Sub

    Public Sub BackSlide()
        ''Ocultar Button "Voltar":
        If ActualSlide = 1 Then BackButton.Hide()
        ''Texto Botão "Próximo":
        NextButton.Text = "&Próximo"

        ''Trocar de Slides:
        ActualSlide -= 1
        SlideShowPagesPanel.Controls.Clear() : SlideShowPagesPanel.Controls.Add(SLIDES.Item(ActualSlide))
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        BackSlide()
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        NextSlide()
    End Sub
End Class