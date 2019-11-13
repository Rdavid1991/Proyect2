Public Class Sobrevivientes

    Dim rnd As New Random()
    Dim v_sobreviviente(9) As PictureBox
    Dim v_x(9)
    Dim v_y(9)
    Public Sub New()

        Dim vBxy(9, 2) As Integer
        Dim pb_sobreviviente

        For i = 0 To 9
            pb_sobreviviente = New PictureBox()
            pb_sobreviviente.Size = New Size(30, 30)
            pb_sobreviviente.Image = My.Resources.sobreviviente
            pb_sobreviviente.BackColor = Color.Transparent
            pb_sobreviviente.SizeMode = PictureBoxSizeMode.StretchImage
            pb_sobreviviente.Location = New Point(rnd.Next(30, Form1.Width - 30), rnd.Next(30, Form1.Height - 30))
            pb_sobreviviente.Visible = False
            pb_sobreviviente.Tag = 0
            v_sobreviviente(i) = pb_sobreviviente
            Form1.Controls.Add(pb_sobreviviente)
            v_x(i) = 10
            v_y(i) = 10
        Next

        Form1.TimerSobrevivientes.Start()

    End Sub

    Public Function mover(tiempo)



        For i = 0 To tiempo

            v_sobreviviente(i).Visible = True

            If v_sobreviviente(i).Location.X < 10 Or v_sobreviviente(i).Location.X > Form1.Width - 40 Then
                v_x(i) *= -1
            End If
            If v_sobreviviente(i).Location.Y < 10 Or v_sobreviviente(i).Location.Y > Form1.Height - 40 Then
                v_y(i) *= -1
            End If

            v_sobreviviente(i).Location = New Point(v_sobreviviente(i).Location.X + v_x(i), v_sobreviviente(i).Location.Y + v_y(i))

        Next

    End Function

    Public Function choqueBordes(tiburon)
        For i = 0 To 9

            If v_sobreviviente(i).Bounds.IntersectsWith(Form1.Buque.Bounds) Then
                If v_sobreviviente(i).Location.X <= Form1.Buque.Location.X Or v_sobreviviente(i).Location.X + v_sobreviviente(i).Width + 30 >= Form1.Buque.Location.X Then
                    v_x(i) *= -1
                End If
                If v_sobreviviente(i).Location.Y <= Form1.Buque.Location.Y Or v_sobreviviente(i).Location.Y + v_sobreviviente(i).Height + 30 >= Form1.Buque.Location.Y Then
                    v_y(i) *= -1
                End If
            End If

            For j = 0 To Form1.lblNivel.Text - 1
                If v_sobreviviente(i).Bounds.IntersectsWith(tiburon(j).Bounds) Then
                    v_sobreviviente(i).Visible = False
                End If
            Next
        Next
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
