Public Class Lancha

    Dim lancha = Form1.lancha

    Public Sub New()
        lancha.Visible = True
        lancha.BackColor = Color.Red
    End Sub

    Function Reversa()
        If lancha.Location.X <= 0 Then
            lancha.Image = My.Resources.lancha
        End If
        If lancha.Location.X + lancha.Width >= Form1.Width Then
            lancha.Image = My.Resources.lancha
        End If
        If lancha.Location.Y <= 0 Then
            lancha.Image = My.Resources.lancha
        End If
        If lancha.Location.Y + lancha.Height >= Form1.Height - 40 Then
            lancha.Image = My.Resources.lancha
        End If
    End Function

    Function mover(X, Y)

        lancha.Location = New Point(lancha.Location.X + X, lancha.Location.Y + Y)

        If lancha.Location.X <= 0 Or lancha.Location.X + lancha.Width >= Form1.Width - 20 Then
            Form1.X_Lancha *= -1
            Reversa()
        End If
        If lancha.Location.Y <= 0 Or lancha.Location.Y + lancha.Height >= Form1.Height - 75 Then
            Form1.Y_Lancha *= -1
            Reversa()
        End If

    End Function

End Class
