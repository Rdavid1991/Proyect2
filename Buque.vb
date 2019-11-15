Public Class Buque

    Dim buque = Form1.Buque

    Public Sub New()
        Form1.TimerBuque.Start()
    End Sub

    Public Function mover()
        If buque.Location.X >= Form1.Width Then
            buque.Location = New Point(-300, buque.Location.Y)
        End If

        buque.Location = New Point(buque.Location.X + 1, buque.Location.Y)
    End Function

End Class
