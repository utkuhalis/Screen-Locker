Class MainWindow
    Dim VB As New VisualBrush
    Dim MediaE As New MediaElement
    Dim TimeTimer As New Threading.DispatcherTimer()
    Dim WaiterTimer As New Threading.DispatcherTimer()
    Dim MouseDetect As Integer = 0
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        MediaE.Stretch = Stretch.Fill
        MediaE.Width = 100
        MediaE.Height = 100
        MediaE.LoadedBehavior = MediaState.Manual
        MediaE.Source = New Uri(IO.Directory.GetCurrentDirectory() & "\Locked.mp4", UriKind.Relative)
        VB.Visual = MediaE
        MyApp.Background = VB
        AddHandler MediaE.MediaEnded, AddressOf MediaE_MediaEnded
        MediaE.Play()

        TimeTimer.Interval = New TimeSpan(0, 0, 0, 0, 500)
        AddHandler TimeTimer.Tick, AddressOf UpdateTime
        TimeTimer.Start()

        WaiterTimer.Interval = New TimeSpan(0, 0, 10)
        AddHandler WaiterTimer.Tick, AddressOf WaitTime
        WaiterTimer.Start()
        Me.Visibility = False
    End Sub

    Sub MediaE_MediaEnded(sender As Object, e As RoutedEventArgs)
        MediaE.Position = TimeSpan.Zero
        MediaE.Play()
    End Sub

    Private Sub UpdateTime(sender As Object, e As EventArgs)
        TimeShower.Content = Now.Hour.ToString("00") & ":" & Now.Minute.ToString("00") & ":" & Now.Second.ToString("00")
    End Sub

    Private Sub WaitTime(sender As Object, e As EventArgs)
        If MouseDetect = 1 Then
            Me.Visibility = True
        End If
    End Sub

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseDetect = 0
        Me.Visibility = False
    End Sub
End Class
