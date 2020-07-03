Public Class cand

    Private Sub subm_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.MouseEnter
        sv.Opacity = 1
    End Sub

    Private Sub submtlick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.MouseLeave
        sv.Opacity = 0.6
    End Sub

    Private Sub slicfk(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles sv.MouseEnter
        sv.Opacity = 1
    End Sub

    Private Sub subck(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles sv.MouseLeave
        sv.Opacity = 0.6
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.MouseEnter
        clr.Opacity = 1
    End Sub

    Private Sub submitlick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.MouseLeave
        clr.Opacity = 0.6
    End Sub

    Private Sub slick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clr.MouseEnter
        clr.Opacity = 1
    End Sub

    Private Sub submick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clr.MouseLeave
        clr.Opacity = 0.6
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.Click

        My.Settings.gcr1 = cgcr1.Text
        My.Settings.gcr2 = cgcr2.Text
        My.Settings.gcr3 = cgcr3.Text
        My.Settings.gcr4 = cgcr4.Text
        My.Settings.gcr5 = cgcr5.Text
        My.Settings.gcr6 = cgcr6.Text

        My.Settings.gcl1 = cgcl1.Text
        My.Settings.gcl2 = cgcl2.Text
        My.Settings.gcl3 = cgcl3.Text
        My.Settings.gcl4 = cgcl4.Text
        My.Settings.gcl5 = cgcl5.Text
        My.Settings.gcl6 = cgcl6.Text

        My.Settings.gsr1 = cgsr1.Text
        My.Settings.gsr2 = cgsr2.Text
        My.Settings.gsr3 = cgsr3.Text
        My.Settings.gsr4 = cgsr4.Text
        My.Settings.gsr5 = cgsr5.Text
        My.Settings.gsr6 = cgsr6.Text

        '____________________________________________

        My.Settings.bcr1 = cbcr1.Text
        My.Settings.bcr2 = cbcr2.Text
        My.Settings.bcr3 = cbcr3.Text
        My.Settings.bcr4 = cbcr4.Text
        My.Settings.bcr5 = cbcr5.Text
        My.Settings.bcr6 = cbcr6.Text


        My.Settings.Save()
        save.IsEnabled = False
        save.Content = "List Saved        "
        sv.IsEnabled = False

        Me.Opacity = 0.4
        MessageBox.Show("Candidates list has been saved!", "Saved", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1

        Me.Close()
    End Sub

    Private Sub cand_Loadd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        cgcr1.Text = My.Settings.gcr1
        cgcr2.Text = My.Settings.gcr2
        cgcr3.Text = My.Settings.gcr3
        cgcr4.Text = My.Settings.gcr4
        cgcr5.Text = My.Settings.gcr5
        cgcr6.Text = My.Settings.gcr6

        cgcl1.Text = My.Settings.gcl1
        cgcl2.Text = My.Settings.gcl2
        cgcl3.Text = My.Settings.gcl3
        cgcl4.Text = My.Settings.gcl4
        cgcl5.Text = My.Settings.gcl5
        cgcl6.Text = My.Settings.gcl6

        cgsr1.Text = My.Settings.gsr1
        cgsr2.Text = My.Settings.gsr2
        cgsr3.Text = My.Settings.gsr3
        cgsr4.Text = My.Settings.gsr4
        cgsr5.Text = My.Settings.gsr5
        cgsr6.Text = My.Settings.gsr6

        '____________________________________________

        cbcr1.Text = My.Settings.bcr1
        cbcr2.Text = My.Settings.bcr2
        cbcr3.Text = My.Settings.bcr3
        cbcr4.Text = My.Settings.bcr4
        cbcr5.Text = My.Settings.bcr5
        cbcr6.Text = My.Settings.bcr6

        Me.Activate()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.Click
        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to clear all the names in the list?", "Clear Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbNo Then

        Else


            cgcr1.Clear()
            cgcr2.Clear()
            cgcr3.Clear()
            cgcr4.Clear()
            cgcr5.Clear()
            cgcr6.Clear()

            cgcl1.Clear()
            cgcl2.Clear()
            cgcl3.Clear()
            cgcl4.Clear()
            cgcl5.Clear()
            cgcl6.Clear()

            cgsr1.Clear()
            cgsr2.Clear()
            cgsr3.Clear()
            cgsr4.Clear()
            cgsr5.Clear()
            cgsr6.Clear()

            '____________________________________________

            cbcr1.Clear()
            cbcr2.Clear()
            cbcr3.Clear()
            cbcr4.Clear()
            cbcr5.Clear()
            cbcr6.Clear()


            '_________________________________________________________________

            My.Settings.gcr1 = cgcr1.Text
            My.Settings.gcr2 = cgcr2.Text
            My.Settings.gcr3 = cgcr3.Text
            My.Settings.gcr4 = cgcr4.Text
            My.Settings.gcr5 = cgcr5.Text
            My.Settings.gcr6 = cgcr6.Text

            My.Settings.gcl1 = cgcl1.Text
            My.Settings.gcl2 = cgcl2.Text
            My.Settings.gcl3 = cgcl3.Text
            My.Settings.gcl4 = cgcl4.Text
            My.Settings.gcl5 = cgcl5.Text
            My.Settings.gcl6 = cgcl6.Text

            My.Settings.gsr1 = cgsr1.Text
            My.Settings.gsr2 = cgsr2.Text
            My.Settings.gsr3 = cgsr3.Text
            My.Settings.gsr4 = cgsr4.Text
            My.Settings.gsr5 = cgsr5.Text
            My.Settings.gsr6 = cgsr6.Text

            '____________________________________________

            My.Settings.bcr1 = cbcr1.Text
            My.Settings.bcr2 = cbcr2.Text
            My.Settings.bcr3 = cbcr3.Text
            My.Settings.bcr4 = cbcr4.Text
            My.Settings.bcr5 = cbcr5.Text
            My.Settings.bcr6 = cbcr6.Text


            My.Settings.Save()
            save.IsEnabled = False
            save.Content = "List Saved        "
            sv.IsEnabled = False

        End If
        Me.Opacity = 1
    End Sub

    Private Sub cand_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles cgcl1.TextChanged, cgcl2.TextChanged, cgcl3.TextChanged, cgcl4.TextChanged, cgcl5.TextChanged, cgcl6.TextChanged, cgcr1.TextChanged, cgcr2.TextChanged, cgcr3.TextChanged, cgcr4.TextChanged, cgcr5.TextChanged, cgcr6.TextChanged, cgsr1.TextChanged, cgsr2.TextChanged, cgsr3.TextChanged, cgsr4.TextChanged, cgsr5.TextChanged, cgsr6.TextChanged
        save.IsEnabled = True
        save.Content = "Save List          "
        sv.IsEnabled = False
        sv.IsEnabled = True
    End Sub

    Private Sub cand_Laded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closing
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)

        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub
End Class
