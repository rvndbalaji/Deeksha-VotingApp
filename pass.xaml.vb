Public Class pass

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ok.Click

        If pw.Password = "akar@128" Then


            Dim win As New win
            win.Show()
            Me.Close()

        Else
            Me.Opacity = 0.5
            MessageBox.Show("Security Breach!" & vbNewLine & "Please enter the correct password!", "Incorrect Password", MessageBoxButton.OK, MessageBoxImage.Exclamation)
            pw.Clear()
            pw.Focus()
            Me.Opacity = 1
        End If
    End Sub


    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        pw.Focus()
    End Sub

    Private Sub hlp_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles hlp.MouseUp
        Me.Opacity = 0.5

        MessageBox.Show("Forgot the password? Ok, here's a hint : " & vbNewLine & vbNewLine & "HINT: Name of creators & date of creation!" & vbNewLine & vbNewLine & "Forgotten absolutely? Then please contact:" & vbNewLine & "Akshith Narayan :  9449303421  (mob)" & vbNewLine & "Aravind Balaji      :  8762315968  (mob)", "Forgot password", MessageBoxButton.OK, MessageBoxImage.Question)

        Me.Opacity = 1
    End Sub
End Class
