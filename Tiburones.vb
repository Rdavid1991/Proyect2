Public Class Tiburones


    Dim rnd As New Random()
    Public v_tiburon(9) As PictureBox
    Dim v_x(9) As Integer
    Dim v_y(9) As Integer

    Dim pb_tiburon
    Dim Y_Tiburon
    Dim x_Tiburon

    Public Sub New()
        For i = 0 To 9
            pb_tiburon = New PictureBox()
            pb_tiburon.Size = New Size(30, 30)
            pb_tiburon.Image = My.Resources.tiburon ' Imagen de Resources para los asteroides
            pb_tiburon.BackColor = Color.Transparent
            pb_tiburon.SizeMode = PictureBoxSizeMode.StretchImage
            pb_tiburon = salida(i, pb_tiburon)
            pb_tiburon.Visible = False
            v_tiburon(i) = pb_tiburon
            Form1.Controls.Add(pb_tiburon)
            v_x(i) = 10
            v_y(i) = 10
        Next

        Form1.TimerTiburon.Start()

    End Sub

    Public Function mover()

        For i = 0 To Form1.lblNivel.Text - 1

            v_tiburon(i).Visible = True

            If v_tiburon(i).Location.X < -30 Or v_tiburon(i).Location.X > Form1.Width + 30 Then
                v_x(i) *= -1
                'Reversa()
            End If

            If v_tiburon(i).Location.Y < -30 Or v_tiburon(i).Location.Y > Form1.Height + 30 Then
                v_y(i) *= -1
                'Reversa()
            End If

            v_tiburon(i).Location = New Point(v_tiburon(i).Location.X + v_x(i), v_tiburon(i).Location.Y + v_y(i))
            choqueBordes(i)
        Next
    End Function

    Private Function choqueBordes(i)
        If v_tiburon(i).Bounds.IntersectsWith(Form1.Buque.Bounds) Then
            If v_tiburon(i).Location.X <= Form1.Buque.Location.X Or v_tiburon(i).Location.X + v_tiburon(i).Width >= Form1.Buque.Location.X Then
                v_x(i) *= -1
            End If
            If v_tiburon(i).Location.Y <= Form1.Buque.Location.Y Or v_tiburon(i).Location.Y + v_tiburon(i).Height >= Form1.Buque.Location.Y Then
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
