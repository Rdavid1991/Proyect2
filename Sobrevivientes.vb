Public Class Sobrevivientes

    Dim rnd As New Random()
    Public v_sobreviviente(9) As PictureBox
    Dim v_x(9)
    Dim v_y(9)

    Dim s_alto As Integer = 30
    Dim s_ancho As Integer = 30
    Public Sub New(velocidad)

        Dim vBxy(9, 2) As Integer
        Dim pb_sobreviviente

        For i = 0 To 9
            pb_sobreviviente = New PictureBox()
            pb_sobreviviente.Size = New Size(s_ancho, s_alto)
            pb_sobreviviente.Image = My.Resources.sobreviviente
            pb_sobreviviente.BackColor = Color.Transparent
            pb_sobreviviente.SizeMode = PictureBoxSizeMode.StretchImage
            pb_sobreviviente.Location = New Point(rnd.Next(30, Form1.Width - 30), rnd.Next(30, Form1.Height - 30))
            pb_sobreviviente.Visible = False
            pb_sobreviviente.Name = "sobrevivientes"
            pb_sobreviviente.Tag = 0
            v_sobreviviente(i) = pb_sobreviviente
            Form1.Controls.Add(pb_sobreviviente)
            v_x(i) = velocidad
            v_y(i) = velocidad
        Next

        Form1.TimerSobrevivientes.Start()

    End Sub

    Public Function mover(tiempo)

        For i = 0 To tiempo

            If v_sobreviviente(i).Tag <> 1 Then
                v_sobreviviente(i).Visible = True

                If v_sobreviviente(i).Location.X < 0 Or v_sobreviviente(i).Location.X + s_ancho > Form1.Width Then
                    v_x(i) *= -1
                End If
                If v_sobreviviente(i).Location.Y < 0 Or v_sobreviviente(i).Location.Y + s_alto > Form1.Height Then
                    v_y(i) *= -1
                End If

                v_sobreviviente(i).Location = New Point(v_sobreviviente(i).Location.X + v_x(i), v_sobreviviente(i).Location.Y + v_y(i))

                choqueSobreviviente(i)
                choqueBuque(i)

            End If

        Next

    End Function

    Public Function choqueSobreviviente(i)
        For j = 0 To 9
            If v_sobreviviente(i).Bounds.IntersectsWith(v_sobreviviente(j).Bounds) And v_sobreviviente(j).Visible = True Then
                If v_sobreviviente(i).Location.X < v_sobreviviente(j).Location.X + s_ancho Or v_sobreviviente(i).Location.X + s_ancho > v_sobreviviente(j).Location.X Then
                    v_x(i) *= -1
                    v_x(j) *= -1
                End If
                If v_sobreviviente(i).Location.Y < v_sobreviviente(j).Location.Y + s_alto Or v_sobreviviente(i).Location.Y + s_alto > v_sobreviviente(j).Location.Y Then
                    v_y(i) *= -1
                    v_y(j) *= -1
                End If
            End If
        Next
    End Function

    Public Function choqueBuque(i)

        If v_sobreviviente(i).Bounds.IntersectsWith(Form1.Buque.Bounds) Then
            If v_sobreviviente(i).Location.X < Form1.Buque.Location.X + Form1.Buque.Width Or v_sobreviviente(i).Location.X + s_ancho > Form1.Buque.Location.X Then
                v_x(i) *= -1
            End If
            If v_sobreviviente(i).Location.Y + s_alto > Form1.Buque.Location.Y Then
                v_y(i) *= -1
            End If
        End If

    End Function

    Public Function choqueTiburon(tiburon)
        For i = 0 To 9
            For j = 0 To Form1.nivel - 1
                If v_sobreviviente(i).Bounds.IntersectsWith(tiburon(j).Bounds) And v_sobreviviente(i).Visible = True Then
                    v_sobreviviente(i).Visible = False
                    v_sobreviviente(i).Tag = 1
                End If
            Next
        Next
    End Function

End Class
