Class MainWindow 
    Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles edit.Click



        rootWindow.WindowState = Windows.WindowState.Minimized

        Dim cand As New cand
        cand.Show()


    End Sub

    Private Sub begin_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles begin.Click
        rootWindow.WindowState = Windows.WindowState.Minimized
        Dim vote As New vote
        vote.Show()
    End Sub

    Private Sub main_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Me.Activate()
    End Sub

    Private Sub hlp2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles hlp2.Click
        Me.Opacity = 0.4

        Dim abt As New abt
        abt.ShowDialog()

        Me.Opacity = 1
    End Sub
End Class
