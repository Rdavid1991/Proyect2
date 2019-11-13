Public Class Form1


    Dim vAxy(9, 2) As Integer
    Dim atmp As PictureBox
    Dim rnd As New Random()

    Dim VectorTiburon(9) As PictureBox
    Dim suma As Integer = 0
    Public Property X_Lancha As Integer = 0
    Public Property Y_Lancha As Integer = 0

    Dim lc
    Dim sv
    Dim tb
    Dim bq

    Dim tiempoSobreviviente As Integer = 0
    Dim segundos As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        lc = New Lancha()
        sv = New Sobrevivientes()
        tb = New Tiburones()
        bq = New Buque()

        btnIniciar.Visible = False
        Buque.Visible = True

        'Inicio de timers
        TimerLancha.Start()



        ' Timer_Sobreviviente.Enabled = True
        ' Timer_Tiburon.Enabled = True
        'Lvl_Mensaje.Visible = False
        Dim i As Integer
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                Y_Lancha -= 1
                lancha.Image = My.Resources.lancha
            Case Keys.Down
                Y_Lancha += 1
                lancha.Image = My.Resources.lancha
            Case Keys.Left
                X_Lancha -= 1
                lancha.Image = My.Resources.lancha
            Case Keys.Right
                X_Lancha += 1
                lancha.Image = My.Resources.lancha
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub TimerLancha_Tick(sender As Object, e As EventArgs) Handles TimerLancha.Tick

        lc.mover(X_Lancha, Y_Lancha)

        If lblVidas.Text = 0 And lblVidas.Text < 5 Then
            'Lvl_Mensaje.Text = "Has Perdido!"
            'Lvl_Mensaje.Visible = True
            'Btn_Jugar.Text = "Jugar Denuevo"
            'Btn_Jugar.Visible = True
            'LimpiarTodo()
        End If

        If lblNivel.Text = 5 Then
            'Lvl_Mensaje.Text = "Has Ganado!"
            'Lvl_Mensaje.Visible = True
            'Btn_Jugar.Text = "Jugar Denuevo"
            'Btn_Jugar.Visible = True
            'LimpiarTodo()
        End If
        lblRecarga.Text = suma



        'For i = 0 To 9
        'Try
        ' If lancha.Bounds.IntersectsWith(VectorSobreviviente(i).Bounds) Then
        'If VectorSobreviviente(i).Tag = 0 And suma < 3 Then
        'VectorSobreviviente(i).Tag = 1
        'VectorSobreviviente(i).Visible = False
        'suma += Val(VectorSobreviviente(i).Tag)
        'End If
        'End If
        'If lancha.Bounds.IntersectsWith(VectorTiburon(i).Bounds) Then
        'lancha.Visible = False
        ' Lvl_Val_Vidas.Text -= 1
        'lancha.Location = New Point(473, 302)
        'X = 0
        'Y = 0
        'lancha.Image = My.Resources.lancha
        'lancha.Visible = True
        'End If
        'Catch ex As Exception
        'End Try
        'Next
        'If lancha.Bounds.IntersectsWith(Buque.Bounds) Then
        'If suma >= 1 And suma <= 3 Then
        'For i = 0 To 9
        'If VectorSobreviviente(i).Tag = 1 Then
        'VectorSobreviviente(i).Tag = 0
        'Lvl_Val_Puntos.Text += 10
        'End If
        'Next
        'If Lvl_Val_Puntos.Text >= 100 Then
        'lblNivel.Text += 1
        'Lvl_Val_Puntos.Text = 0
        'Timer_Sobreviviente.Interval = Timer_Sobreviviente.Interval - 100
        'Timer_Tiburon.Interval = Timer_Tiburon.Interval - 100
        'End If
        'suma = 0
        'End If
        'End If
    End Sub

    Private Sub TimerTiburon_Tick(sender As Object, e As EventArgs) Handles TimerTiburon.Tick
        tb.mover()
    End Sub

    Private Sub TimerSobrevivientes_Tick(sender As Object, e As EventArgs) Handles TimerSobrevivientes.Tick

        If tiempoSobreviviente <= 9 Then
            If segundos = 10 Then
                tiempoSobreviviente += 1
                segundos = 0
            End If
            segundos += 1
        End If

        sv.mover(tiempoSobreviviente)

        sv.choqueBordes(tb.v_tiburon)
    End Sub

    Private Sub TimerBuque_Tick(sender As Object, e As EventArgs) Handles TimerBuque.Tick
        bq.mover()
    End Sub
End Class

