Public Class vote
    Public Property AutoScaleMode As System.Windows.Forms.AutoScaleMode


    Private Sub qt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        My.Settings.Save()

    End Sub


    Private Sub clr_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clr.Click

        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to clear all selections?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
            gcr1.IsChecked = False
            gcr2.IsChecked = False
            gcr3.IsChecked = False
            gcr4.IsChecked = False
            gcr5.IsChecked = False
            gcr6.IsChecked = False

            gcl1.IsChecked = False
            gcl2.IsChecked = False
            gcl3.IsChecked = False
            gcl4.IsChecked = False
            gcl5.IsChecked = False
            gcl6.IsChecked = False

            gsr1.IsChecked = False
            gsr2.IsChecked = False
            gsr3.IsChecked = False
            gsr4.IsChecked = False
            gsr5.IsChecked = False
            gsr6.IsChecked = False

            bcr1.IsChecked = False
            bcr2.IsChecked = False
            bcr3.IsChecked = False
            bcr4.IsChecked = False
            bcr5.IsChecked = False
            bcr6.IsChecked = False


        Else


        End If
        Me.Opacity = 1
    End Sub

    Private Sub sub_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles submit.Click


        If g.IsChecked = True Then

            If gcr1.IsChecked = False And gcr2.IsChecked = False And gcr3.IsChecked = False And gcr4.IsChecked = False And gcr5.IsChecked = False And gcr6.IsChecked = False Then
                MessageBox.Show("Please select a Girls Class Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)


            ElseIf gcl1.IsChecked = False And gcl2.IsChecked = False And gcl3.IsChecked = False And gcl4.IsChecked = False And gcl5.IsChecked = False And gcl6.IsChecked = False Then
                MessageBox.Show("Please select a Cultural Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)

            ElseIf gsr1.IsChecked = False And gsr2.IsChecked = False And gsr3.IsChecked = False And gsr4.IsChecked = False And gsr5.IsChecked = False And gsr6.IsChecked = False Then
                MessageBox.Show("Please select a Sports Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)

                '_____________BOYS_____________

            Else

                'COUNTING BEGINS____________________________________________________





                'Girls Class Representatives--------------------------------

                If gcr1.IsChecked = True Then

                    My.Settings.cgcr1 = My.Settings.cgcr1 + 1


                ElseIf gcr2.IsChecked = True Then

                    My.Settings.cgcr2 = My.Settings.cgcr2 + 1


                ElseIf gcr3.IsChecked = True Then

                    My.Settings.cgcr3 = My.Settings.cgcr3 + 1


                ElseIf gcr4.IsChecked = True Then

                    My.Settings.cgcr4 = My.Settings.cgcr4 + 1


                ElseIf gcr5.IsChecked = True Then

                    My.Settings.cgcr5 = My.Settings.cgcr5 + 1


                ElseIf gcr6.IsChecked = True Then

                    My.Settings.cgcr6 = My.Settings.cgcr6 + 1
                Else
                    My.Settings.cbcr6 = My.Settings.cbcr6 + 0
                End If

                'Girls Cultural Representatives--------------------------------


                If gcl1.IsChecked = True Then

                    My.Settings.cgcl1 = My.Settings.cgcl1 + 1


                ElseIf gcl2.IsChecked = True Then

                    My.Settings.cgcl2 = My.Settings.cgcl2 + 1


                ElseIf gcl3.IsChecked = True Then

                    My.Settings.cgcl3 = My.Settings.cgcl3 + 1


                ElseIf gcl4.IsChecked = True Then

                    My.Settings.cgcl4 = My.Settings.cgcl4 + 1


                ElseIf gcl5.IsChecked = True Then

                    My.Settings.cgcl5 = My.Settings.cgcl5 + 1


                ElseIf gcl6.IsChecked = True Then

                    My.Settings.cgcl6 = My.Settings.cgcl6 + 1

                Else
                    My.Settings.cbcr6 = My.Settings.cbcr6 + 0
                End If
                'Girls Sports Representative----------------------------------


                If gsr1.IsChecked = True Then

                    My.Settings.cgsr1 = My.Settings.cgsr1 + 1


                ElseIf gsr2.IsChecked = True Then

                    My.Settings.cgsr2 = My.Settings.cgsr2 + 1


                ElseIf gsr3.IsChecked = True Then

                    My.Settings.cgsr3 = My.Settings.cgsr3 + 1


                ElseIf gsr4.IsChecked = True Then

                    My.Settings.cgsr4 = My.Settings.cgsr4 + 1


                ElseIf gsr5.IsChecked = True Then

                    My.Settings.cgsr5 = My.Settings.cgsr5 + 1


                ElseIf gsr6.IsChecked = True Then

                    My.Settings.cgsr6 = My.Settings.cgsr6 + 1

                Else
                    My.Settings.cbcr6 = My.Settings.cbcr6 + 0
                End If


                ch.Visibility = Windows.Visibility.Visible
                g.Visibility = Windows.Visibility.Visible
                b.Visibility = Windows.Visibility.Visible
                ok.Visibility = Windows.Visibility.Visible

                cont.Visibility = Windows.Visibility.Hidden

                bt.IsEnabled = True
                bcr1.IsEnabled = True
                bcr2.IsEnabled = True
                bcr3.IsEnabled = True
                bcr4.IsEnabled = True
                bcr5.IsEnabled = True
                bcr6.IsEnabled = True

                gt.IsEnabled = True
                gcr1.IsEnabled = True
                gcr2.IsEnabled = True
                gcr3.IsEnabled = True
                gcr4.IsEnabled = True
                gcr5.IsEnabled = True
                gcr6.IsEnabled = True
                gcr1.IsChecked = False
                gcr2.IsChecked = False
                gcr3.IsChecked = False
                gcr4.IsChecked = False
                gcr5.IsChecked = False
                gcr6.IsChecked = False

                gcl1.IsChecked = False
                gcl2.IsChecked = False
                gcl3.IsChecked = False
                gcl4.IsChecked = False
                gcl5.IsChecked = False
                gcl6.IsChecked = False

                gsr1.IsChecked = False
                gsr2.IsChecked = False
                gsr3.IsChecked = False
                gsr4.IsChecked = False
                gsr5.IsChecked = False
                gsr6.IsChecked = False

                bcr1.IsChecked = False
                bcr2.IsChecked = False
                bcr3.IsChecked = False
                bcr4.IsChecked = False
                bcr5.IsChecked = False
                bcr6.IsChecked = False


            End If



        ElseIf b.IsChecked = True Then

            If bcr1.IsChecked = False And bcr2.IsChecked = False And bcr3.IsChecked = False And bcr4.IsChecked = False And bcr5.IsChecked = False And bcr6.IsChecked = False Then
                MessageBox.Show("Please select a Boys Class Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)


            ElseIf gcl1.IsChecked = False And gcl2.IsChecked = False And gcl3.IsChecked = False And gcl4.IsChecked = False And gcl5.IsChecked = False And gcl6.IsChecked = False Then
                MessageBox.Show("Please select a Cultural Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)

            ElseIf gsr1.IsChecked = False And gsr2.IsChecked = False And gsr3.IsChecked = False And gsr4.IsChecked = False And gsr5.IsChecked = False And gsr6.IsChecked = False Then
                MessageBox.Show("Please select a Sports Representative", "No selection!", MessageBoxButton.OK, MessageBoxImage.Exclamation)



            Else

                'COUNTING BEGINS____________________________________________________


                '
                'Girls Cultural Representatives--------------------------------


                If gcl1.IsChecked = True Then

                    My.Settings.cgcl1 = My.Settings.cgcl1 + 1


                ElseIf gcl2.IsChecked = True Then

                    My.Settings.cgcl2 = My.Settings.cgcl2 + 1


                ElseIf gcl3.IsChecked = True Then

                    My.Settings.cgcl3 = My.Settings.cgcl3 + 1


                ElseIf gcl4.IsChecked = True Then

                    My.Settings.cgcl4 = My.Settings.cgcl4 + 1


                ElseIf gcl5.IsChecked = True Then

                    My.Settings.cgcl5 = My.Settings.cgcl5 + 1


                ElseIf gcl6.IsChecked = True Then

                    My.Settings.cgcl6 = My.Settings.cgcl6 + 1

                Else
                    My.Settings.cbcr6 = My.Settings.cbcr6 + 0
                End If
                'Girls Sports Representative----------------------------------


                If gsr1.IsChecked = True Then

                    My.Settings.cgsr1 = My.Settings.cgsr1 + 1


                ElseIf gsr2.IsChecked = True Then

                    My.Settings.cgsr2 = My.Settings.cgsr2 + 1


                ElseIf gsr3.IsChecked = True Then

                    My.Settings.cgsr3 = My.Settings.cgsr3 + 1


                ElseIf gsr4.IsChecked = True Then

                    My.Settings.cgsr4 = My.Settings.cgsr4 + 1


                ElseIf gsr5.IsChecked = True Then

                    My.Settings.cgsr5 = My.Settings.cgsr5 + 1


                ElseIf gsr6.IsChecked = True Then

                    My.Settings.cgsr6 = My.Settings.cgsr6 + 1

                Else
                    My.Settings.cbcr6 = My.Settings.cbcr6 + 0
                End If

                'Boys Class Representatives--------------------------------

                If bcr1.IsChecked = True Then

                    My.Settings.cbcr1 = My.Settings.cbcr1 + 1


                ElseIf bcr2.IsChecked = True Then

                    My.Settings.cbcr2 = My.Settings.cbcr2 + 1


                ElseIf bcr3.IsChecked = True Then

                    My.Settings.cbcr3 = My.Settings.cbcr3 + 1


                ElseIf bcr4.IsChecked = True Then

                    My.Settings.cbcr4 = My.Settings.cbcr4 + 1


                ElseIf bcr5.IsChecked = True Then

                    My.Settings.cbcr5 = My.Settings.cbcr5 + 1


                ElseIf bcr6.IsChecked = True Then

                    My.Settings.cbcr6 = My.Settings.cbcr6 + 1

                Else


                End If

                ch.Visibility = Windows.Visibility.Visible
                g.Visibility = Windows.Visibility.Visible
                b.Visibility = Windows.Visibility.Visible
                ok.Visibility = Windows.Visibility.Visible

                cont.Visibility = Windows.Visibility.Hidden

                bt.IsEnabled = True
                bcr1.IsEnabled = True
                bcr2.IsEnabled = True
                bcr3.IsEnabled = True
                bcr4.IsEnabled = True
                bcr5.IsEnabled = True
                bcr6.IsEnabled = True

                gt.IsEnabled = True
                gcr1.IsEnabled = True
                gcr2.IsEnabled = True
                gcr3.IsEnabled = True
                gcr4.IsEnabled = True
                gcr5.IsEnabled = True
                gcr6.IsEnabled = True

                gcr1.IsChecked = False
                gcr2.IsChecked = False
                gcr3.IsChecked = False
                gcr4.IsChecked = False
                gcr5.IsChecked = False
                gcr6.IsChecked = False

                gcl1.IsChecked = False
                gcl2.IsChecked = False
                gcl3.IsChecked = False
                gcl4.IsChecked = False
                gcl5.IsChecked = False
                gcl6.IsChecked = False

                gsr1.IsChecked = False
                gsr2.IsChecked = False
                gsr3.IsChecked = False
                gsr4.IsChecked = False
                gsr5.IsChecked = False
                gsr6.IsChecked = False

                bcr1.IsChecked = False
                bcr2.IsChecked = False
                bcr3.IsChecked = False
                bcr4.IsChecked = False
                bcr5.IsChecked = False
                bcr6.IsChecked = False

            End If


        Else

        End If



        My.Settings.Save()
        My.Settings.Reload()


    End Sub

    Private Sub vm_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded





        '  Me.AutoScaleMode = Forms.AutoScaleMode.Dpi
        Me.AutoScaleMode = Forms.AutoSizeMode.GrowAndShrink

        gcr1.Content = My.Settings.gcr1
        gcr2.Content = My.Settings.gcr2
        gcr3.Content = My.Settings.gcr3
        gcr4.Content = My.Settings.gcr4
        gcr5.Content = My.Settings.gcr5
        gcr6.Content = My.Settings.gcr6

        gcl1.Content = My.Settings.gcl1
        gcl2.Content = My.Settings.gcl2
        gcl3.Content = My.Settings.gcl3
        gcl4.Content = My.Settings.gcl4
        gcl5.Content = My.Settings.gcl5
        gcl6.Content = My.Settings.gcl6

        gsr1.Content = My.Settings.gsr1
        gsr2.Content = My.Settings.gsr2
        gsr3.Content = My.Settings.gsr3
        gsr4.Content = My.Settings.gsr4
        gsr5.Content = My.Settings.gsr5
        gsr6.Content = My.Settings.gsr6

        '____________________________________________

        bcr1.Content = My.Settings.bcr1
        bcr2.Content = My.Settings.bcr2
        bcr3.Content = My.Settings.bcr3
        bcr4.Content = My.Settings.bcr4
        bcr5.Content = My.Settings.bcr5
        bcr6.Content = My.Settings.bcr6

        Me.Activate()
    End Sub


    Private Sub res_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles res.Click

        ' Me.Opacity = 0.4
        '  Dim pass As New pass
        '  pass.ShowDialog()
        ' Me.Opacity = 1
        Dim win As New win
        win.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ok.Click

        If g.IsChecked = True Then


            bt.IsEnabled = False
            bcr1.IsEnabled = False
            bcr2.IsEnabled = False
            bcr3.IsEnabled = False
            bcr4.IsEnabled = False
            bcr5.IsEnabled = False
            bcr6.IsEnabled = False

            cont.Visibility = Windows.Visibility.Visible

            ch.Visibility = Windows.Visibility.Hidden
            g.Visibility = Windows.Visibility.Hidden
            b.Visibility = Windows.Visibility.Hidden
            ok.Visibility = Windows.Visibility.Hidden

        ElseIf b.IsChecked = True Then


            gt.IsEnabled = False
            gcr1.IsEnabled = False
            gcr2.IsEnabled = False
            gcr3.IsEnabled = False
            gcr4.IsEnabled = False
            gcr5.IsEnabled = False
            gcr6.IsEnabled = False

            cont.Visibility = Windows.Visibility.Visible

            ch.Visibility = Windows.Visibility.Hidden
            g.Visibility = Windows.Visibility.Hidden
            b.Visibility = Windows.Visibility.Hidden
            ok.Visibility = Windows.Visibility.Hidden

        Else

            MessageBox.Show("Please select your Gender!", "Gender", MessageBoxButton.OK, MessageBoxImage.Exclamation)

        End If

    End Sub

    Private Sub cand_Laded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closing
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)

        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub
End Class
