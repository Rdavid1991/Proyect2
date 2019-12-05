Public Class Lancha

    Dim lancha = Form1.lancha

    Public Sub New()
        lancha.Visible = True
    End Sub

    Function Reversa()
        If lancha.Location.X <= 0 Then
            lancha.Image = My.Resources.lanchaDerecha
        End If
        If lancha.Location.X + lancha.Width >= Form1.Width Then
            lancha.Image = My.Resources.lanchaIzquierda
        End If
        If lancha.Location.Y <= 0 Then
            lancha.Image = My.Resources.lanchaAbajo
        End If
        If lancha.Location.Y + lancha.Height >= Form1.Height - 40 Then
            lancha.Image = My.Resources.lanchaArriba
        End If
    End Function

    Function mover(X, Y)

        lancha.Location = New Point(lancha.Location.X + X, lancha.Location.Y + Y)

        If lancha.Location.X < 0 Or lancha.Location.X + lancha.Width > Form1.Width Then
            Form1.X_Lancha *= -1
            Reversa()
        End If
        If lancha.Location.Y < 60 Or lancha.Location.Y + lancha.Height > Form1.Height Then
            Form1.Y_Lancha *= -1
            Reversa()
        End If
        choqueBuque()
    End Function

    Public Function choqueBuque()

        If lancha.Bounds.IntersectsWith(Form1.Buque.Bounds) Then

            If lancha.Location.X < Form1.Buque.Location.X + Form1.Buque.Width Or lancha.Location.X + lancha.Width > Form1.Buque.Location.X Then
                Form1.X_Lancha *= -1
            End If
            If lancha.Location.Y + lancha.Height > Form1.Buque.Location.Y Then
                Form1.Y_Lancha *= -1
            End If
            Form1.lbl_puntos.Text += Form1.lbl_nSobrevivientes.Text * 10
            Form1.lbl_nSobrevivientes.Text = 0
            Form1.lbl_gasolina.Text = 60
        End If

    End Function

    Public Function choqueSobeviviente(v_sobreviviente)
        For i = 0 To 9

            If Form1.lbl_nSobrevivientes.Text < 3 Then
                If lancha.Bounds.IntersectsWith(v_sobreviviente(i).Bounds) And v_sobreviviente(i).Visible = True Then
                    v_sobreviviente(i).Visible = False
                    v_sobreviviente(i).Tag = 1
                    Form1.lbl_nSobrevivientes.Text += 1
                End If
            End If

        Next
    End Function

    Public Function choqueTiburon(tiburon)

        For j = 0 To Form1.nivel - 1
            If lancha.Bounds.IntersectsWith(tiburon(j).Bounds) Then

                Form1.lbl_vidas.Text -= 1
                lancha.Location = New Point(473, 302)
                lancha.Image = My.Resources.lanchaArriba
                Form1.X_Lancha = 0
                Form1.Y_Lancha = 0

            End If
        Next

    End Function
End Class
