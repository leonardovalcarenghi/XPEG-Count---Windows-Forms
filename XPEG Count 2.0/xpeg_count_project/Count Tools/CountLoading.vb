Public Class CountLoading

    Dim Int = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Int += 1
        Select Case Int
            Case 1 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_1
            Case 2 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_2
            Case 3 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_3
            Case 4 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_4
            Case 5 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_5
            Case 6 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_6
            Case 7 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_7
            Case 8 : PictureBox1.Image = My.Resources.LoadingIconsResource.Loading_8
            Case 9 : Int = 0
        End Select
    End Sub
End Class
