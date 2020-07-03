Imports System.IO
Imports Microsoft.Win32
Imports System.Drawing

Class win


    Dim a1, a2, a3, a4, a5, a6, b1, b2, b3, b4, b5, b6, c1, c2, c3, c4, c5, c6, d1, d2, d3, d4, d5, d6 As Integer

    Private Sub _Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        dte.Text = Date.Today.Date()

        gcr1.Text = My.Settings.gcr1
        gcr2.Text = My.Settings.gcr2
        gcr3.Text = My.Settings.gcr3
        gcr4.Text = My.Settings.gcr4
        gcr5.Text = My.Settings.gcr5
        gcr6.Text = My.Settings.gcr6

        gcl1.Text = My.Settings.gcl1
        gcl2.Text = My.Settings.gcl2
        gcl3.Text = My.Settings.gcl3
        gcl4.Text = My.Settings.gcl4
        gcl5.Text = My.Settings.gcl5
        gcl6.Text = My.Settings.gcl6

        gsr1.Text = My.Settings.gsr1
        gsr2.Text = My.Settings.gsr2
        gsr3.Text = My.Settings.gsr3
        gsr4.Text = My.Settings.gsr4
        gsr5.Text = My.Settings.gsr5
        gsr6.Text = My.Settings.gsr6


        bcr1.Text = My.Settings.bcr1
        bcr2.Text = My.Settings.bcr2
        bcr3.Text = My.Settings.bcr3
        bcr4.Text = My.Settings.bcr4
        bcr5.Text = My.Settings.bcr5
        bcr6.Text = My.Settings.bcr6

        '____________________________________
        cgcr1.Text = My.Settings.cgcr1
        cgcr2.Text = My.Settings.cgcr2
        cgcr3.Text = My.Settings.cgcr3
        cgcr4.Text = My.Settings.cgcr4
        cgcr5.Text = My.Settings.cgcr5
        cgcr6.Text = My.Settings.cgcr6

        cgcl1.Text = My.Settings.cgcl1
        cgcl2.Text = My.Settings.cgcl2
        cgcl3.Text = My.Settings.cgcl3
        cgcl4.Text = My.Settings.cgcl4
        cgcl5.Text = My.Settings.cgcl5
        cgcl6.Text = My.Settings.cgcl6

        cgsr1.Text = My.Settings.cgsr1
        cgsr2.Text = My.Settings.cgsr2
        cgsr3.Text = My.Settings.cgsr3
        cgsr4.Text = My.Settings.cgsr4
        cgsr5.Text = My.Settings.cgsr5
        cgsr6.Text = My.Settings.cgsr6


        cbcr1.Text = My.Settings.cbcr1
        cbcr2.Text = My.Settings.cbcr2
        cbcr3.Text = My.Settings.cbcr3
        cbcr4.Text = My.Settings.cbcr4
        cbcr5.Text = My.Settings.cbcr5
        cbcr6.Text = My.Settings.cbcr6

        '____________________________________________________________________

        Dim a(6) As Integer
        Dim d(6) As Integer
        Dim b(6) As Integer
        Dim c(6) As Integer

        'Girls CR
        a(0) = My.Settings.cgcr1
        a(1) = My.Settings.cgcr2
        a(2) = My.Settings.cgcr3
        a(3) = My.Settings.cgcr4
        a(4) = My.Settings.cgcr5
        a(5) = My.Settings.cgcr6

        'Boys CR
        d(0) = My.Settings.cbcr1
        d(1) = My.Settings.cbcr2
        d(2) = My.Settings.cbcr3
        d(3) = My.Settings.cbcr4
        d(4) = My.Settings.cbcr5
        d(5) = My.Settings.cbcr6

        'Cult Rep
        b(0) = My.Settings.cgcl1
        b(1) = My.Settings.cgcl2
        b(2) = My.Settings.cgcl3
        b(3) = My.Settings.cgcl4
        b(4) = My.Settings.cgcl5
        b(5) = My.Settings.cgcl6

        'Sport Rep
        c(0) = My.Settings.cgsr1
        c(1) = My.Settings.cgsr2
        c(2) = My.Settings.cgsr3
        c(3) = My.Settings.cgsr4
        c(4) = My.Settings.cgsr5
        c(5) = My.Settings.cgsr6



        Me.Activate()


        '____________________________________________________________________________________________________________
        '____________________________________________________________________________________________________________


        Dim i As Integer
        Dim h As Integer
        h = a(0)

        For i = 0 To 5

            If h < a(i) Then

                h = a(i)
            End If

        Next i

        If h = a(0) Then
            w1.Text = gcr1.Text

        ElseIf h = a(1) Then
            w1.Text = gcr2.Text
        ElseIf h = a(2) Then
            w1.Text = gcr3.Text
        ElseIf h = a(3) Then
            w1.Text = gcr4.Text
        ElseIf h = a(4) Then
            w1.Text = gcr5.Text
        ElseIf h = a(5) Then
            w1.Text = gcr6.Text
        Else
            w1.Text = ">> DRAW <<"
        End If




    End Sub

    Private Sub rst_Cick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles rst.Click

        Me.Opacity = 0.4
        If MessageBox.Show("This will reset the names of candidates & the number of votes. Are you sure you want to reset these?", "Reset Names & Counter", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then

            My.Settings.Reset()
            My.Settings.Save()
            My.Settings.Reload()

            gcr1.Text = My.Settings.gcr1
            gcr2.Text = My.Settings.gcr2
            gcr3.Text = My.Settings.gcr3
            gcr4.Text = My.Settings.gcr4
            gcr5.Text = My.Settings.gcr5
            gcr6.Text = My.Settings.gcr6

            gcl1.Text = My.Settings.gcl1
            gcl2.Text = My.Settings.gcl2
            gcl3.Text = My.Settings.gcl3
            gcl4.Text = My.Settings.gcl4
            gcl5.Text = My.Settings.gcl5
            gcl6.Text = My.Settings.gcl6

            gsr1.Text = My.Settings.gsr1
            gsr2.Text = My.Settings.gsr2
            gsr3.Text = My.Settings.gsr3
            gsr4.Text = My.Settings.gsr4
            gsr5.Text = My.Settings.gsr5
            gsr6.Text = My.Settings.gsr6


            bcr1.Text = My.Settings.bcr1
            bcr2.Text = My.Settings.bcr2
            bcr3.Text = My.Settings.bcr3
            bcr4.Text = My.Settings.bcr4
            bcr5.Text = My.Settings.bcr5
            bcr6.Text = My.Settings.bcr6

            '____________________________________
            cgcr1.Text = My.Settings.cgcr1
            cgcr2.Text = My.Settings.cgcr2
            cgcr3.Text = My.Settings.cgcr3
            cgcr4.Text = My.Settings.cgcr4
            cgcr5.Text = My.Settings.cgcr5
            cgcr6.Text = My.Settings.cgcr6

            cgcl1.Text = My.Settings.cgcl1
            cgcl2.Text = My.Settings.cgcl2
            cgcl3.Text = My.Settings.cgcl3
            cgcl4.Text = My.Settings.cgcl4
            cgcl5.Text = My.Settings.cgcl5
            cgcl6.Text = My.Settings.cgcl6

            cgsr1.Text = My.Settings.cgsr1
            cgsr2.Text = My.Settings.cgsr2
            cgsr3.Text = My.Settings.cgsr3
            cgsr4.Text = My.Settings.cgsr4
            cgsr5.Text = My.Settings.cgsr5
            cgsr6.Text = My.Settings.cgsr6


            cbcr1.Text = My.Settings.cbcr1
            cbcr2.Text = My.Settings.cbcr2
            cbcr3.Text = My.Settings.cbcr3
            cbcr4.Text = My.Settings.cbcr4
            cbcr5.Text = My.Settings.cbcr5
            cbcr6.Text = My.Settings.cbcr6

            '____________________________________________________________________

            a1 = My.Settings.cgcr1
            a2 = My.Settings.cgcr2
            a3 = My.Settings.cgcr3
            a3 = My.Settings.cgcr3
            a3 = My.Settings.cgcr3
            a4 = My.Settings.cgcr4
            a5 = My.Settings.cgcr5
            a6 = My.Settings.cgcr6

            b1 = My.Settings.cgcl1
            b2 = My.Settings.cgcl2
            b3 = My.Settings.cgcl3
            b4 = My.Settings.cgcl4
            b5 = My.Settings.cgcl5
            b6 = My.Settings.cgcl6

            c1 = My.Settings.cgsr1
            c2 = My.Settings.cgsr2
            c3 = My.Settings.cgsr3
            c4 = My.Settings.cgsr4
            c5 = My.Settings.cgsr5
            c6 = My.Settings.cgsr6


            d1 = My.Settings.cbcr1
            d2 = My.Settings.cbcr2
            d3 = My.Settings.cbcr3
            d4 = My.Settings.cbcr4
            d5 = My.Settings.cbcr5
            d6 = My.Settings.cbcr6

            MessageBox.Show("The Names & Counters have been reset", "Reset successful", MessageBoxButton.OK, MessageBoxImage.Information)
        Else

        End If
        Me.Opacity = 1

    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles save.Click

        Dim graph As Graphics = Nothing
        Dim p As New SaveFileDialog
        Dim path As String
        Dim rpath As String
        Try
            Dim bmp As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            graph = Graphics.FromImage(bmp)
            graph.CopyFromScreen(0, 0, 0, 0, bmp.Size)

            If p.ShowDialog = False Then

            Else
                path = p.FileName
                rpath = path & ".jpg"
                Dim i As Integer

                For i = 0 To 1


                    If My.Computer.FileSystem.FileExists(path) = True Then

                        My.Computer.FileSystem.DeleteFile(path)

                    Else

                        bmp.Save(rpath)
                        i = 2
                    End If


                Next i

            End If
        Catch ex As Exception
            
        End Try


    End Sub

End Class