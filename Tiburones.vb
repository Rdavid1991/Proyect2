Public Class Tiburones


    Dim rnd As New Random()
    Public v_tiburon(9) As PictureBox
    Dim v_x(9) As Integer
    Dim v_y(9) As Integer

    Dim pb_tiburon
    Dim Y_Tiburon
    Dim x_Tiburon

    Dim t_alto As Integer = 30
    Dim t_ancho As Integer = 30

    Public Sub New(velocidad)
        For i = 0 To 9
            pb_tiburon = New PictureBox()
            pb_tiburon.Size = New Size(t_ancho, t_alto)
            pb_tiburon.Image = My.Resources.tiburon ' Imagen de Resources para los asteroides
            pb_tiburon.BackColor = Color.Transparent
            pb_tiburon.SizeMode = PictureBoxSizeMode.StretchImage
            pb_tiburon = salida(i, pb_tiburon)
            pb_tiburon.Name = "tiburones"
            pb_tiburon.Visible = False
            v_tiburon(i) = pb_tiburon
            Form1.Controls.Add(pb_tiburon)
            v_x(i) = velocidad
            v_y(i) = velocidad
        Next
        Form1.TimerTiburon.Start()

    End Sub

    Public Function mover()

        For i = 0 To Form1.nivel - 1

            v_tiburon(i).Visible = True

            If v_tiburon(i).Location.X < (t_ancho * -1) Or v_tiburon(i).Location.X + t_ancho > Form1.Width + t_ancho Then
                v_x(i) *= -1
                'Reversa()
            End If

            If v_tiburon(i).Location.Y < (t_alto * -1) Or v_tiburon(i).Location.Y + t_alto > Form1.Height + t_alto Then
                v_y(i) *= -1
                'Reversa()
            End If

            v_tiburon(i).Location = New Point(v_tiburon(i).Location.X + v_x(i), v_tiburon(i).Location.Y + v_y(i))
            choqueBuque(i)
            choquetiburon(i)
        Next
    End Function

    Public Function choquetiburon(i)
        For j = 0 To 9
            If v_tiburon(i).Bounds.IntersectsWith(v_tiburon(j).Bounds) And v_tiburon(j).Visible = True Then
                If v_tiburon(i).Location.X < v_tiburon(j).Location.X + t_ancho Or v_tiburon(i).Location.X + t_ancho > v_tiburon(j).Location.X Then
                    v_x(i) *= -1
                    v_x(j) *= -1
                End If
                If v_tiburon(i).Location.Y < v_tiburon(j).Location.Y + t_alto Or v_tiburon(i).Location.Y + t_alto > v_tiburon(j).Location.Y Then
                    v_y(i) *= -1
                    v_y(j) *= -1
                End If
            End If
        Next
    End Function

    Public Function choqueBuque(i)

        If v_tiburon(i).Bounds.IntersectsWith(Form1.Buque.Bounds) Then
            If v_tiburon(i).Location.X < Form1.Buque.Location.X + Form1.Buque.Width Or v_tiburon(i).Location.X + t_ancho > Form1.Buque.Location.X Then
                v_x(i) *= -1
            End If
            If v_tiburon(i).Location.Y + t_alto > Form1.Buque.Location.Y Then
                v_y(i) *= -1
            End If
        End If

    End Function

    Private Function salida(i, pb_tiburon)
        Dim ancho = 100, alto = 100

        If i = 0 Then
            pb_tiburon.Location = New Point(0, 0)
        ElseIf i = 1 Then
            pb_tiburon.Location = New Point(0, Form1.Height)
        ElseIf i = 2 Then
            pb_tiburon.Location = New Point(Form1.Width, Form1.Height)
        ElseIf i = 3 Then
            pb_tiburon.Location = New Point(Form1.Width, 0)
        ElseIf i = 4 Then
            pb_tiburon.Location = New Point(0, Form1.Height / 2)
        ElseIf i = 5 Then
            pb_tiburon.Location = New Point(Form1.Width / 2, 0)
        ElseIf i = 6 Then
            pb_tiburon.Location = New Point(Form1.Width / 2, Form1.Height)
        ElseIf i = 7 Then
            pb_tiburon.Location = New Point(Form1.Width, Form1.Height / 2)
        ElseIf i = 8 Then
            pb_tiburon.Location = New Point(0, Form1.Height / 4)
        ElseIf i = 9 Then
            pb_tiburon.Location = New Point(Form1.Width / 4, Form1.Height)
        End If

        Return pb_tiburon
    End Function

End Class
