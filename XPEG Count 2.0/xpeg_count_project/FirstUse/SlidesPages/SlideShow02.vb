Public Class SlideShow02

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub SlideShow02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Select Case My.Settings.oldUser
            Case True 'Usuários de Atualização
                TitleMenuLabel.Text = "Vamos começar do início mais uma vez!"

                ' CalendarMode_OldUser.Show()
                Dashboard_OldUser.Show()


            Case False 'Usuários Novos
                TitleMenuLabel.Text = "Vamos começar do início!"

                Dashboard_NewUser.Show()
                'CalendarMode_NewUser.show()
        End Select
    End Sub
End Class
