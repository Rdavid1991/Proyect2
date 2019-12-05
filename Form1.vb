Public Class Form1

    Dim vAxy(9, 2) As Integer
    Dim atmp As PictureBox
    Dim rnd As New Random()

    Dim VectorTiburon(9) As PictureBox
    Public Property X_Lancha As Integer = 0
    Public Property Y_Lancha As Integer = 0

    Dim lc
    Dim sv
    Dim tb
    Dim bq

    Public nivel As Integer
    Public puntos As Integer
    Dim tiempoSobreviviente As Integer = 0
    Dim segundos As Integer = 1
    Dim ms_gasolina As Integer = 0
    Dim velocidad As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        If lblNivel.Text < 10 Then
            nivel = lblNivel.Text
        End If

        lbl_mensaje.Visible = False
        lbl_puntos_obtenidos.Visible = False

        velocidad = 1

        velocidad *= lblNivel.Text

        lc = New Lancha()
        sv = New Sobrevivientes(velocidad)
        tb = New Tiburones(velocidad)
        bq = New Buque()

        btnIniciar.Visible = False
        Buque.Visible = True

        TimerLancha.Start()
        Timer_mostrarSobrevivientes.Start()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If X_Lancha >= 5 Then
            X_Lancha = 5
        End If

        If X_Lancha <= -5 Then
            X_Lancha = -5
        End If

        If Y_Lancha >= 5 Then
            Y_Lancha = 5
        End If

        If Y_Lancha <= -5 Then
            Y_Lancha = -5
        End If


        If lbl_gasolina.Text > 0 Then

            Select Case keyData
                Case Keys.Up
                    Y_Lancha -= 1
                    lancha.Image = My.Resources.lanchaArriba
                Case Keys.Down
                    Y_Lancha += 1
                    lancha.Image = My.Resources.lanchaAbajo
                Case Keys.Left
                    X_Lancha -= 1
                    lancha.Image = My.Resources.lanchaIzquierda
                Case Keys.Right
                    X_Lancha += 1
                    lancha.Image = My.Resources.lanchaDerecha
            End Select

        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub TimerLancha_Tick(sender As Object, e As EventArgs) Handles TimerLancha.Tick

        If lbl_gasolina.Text > 0 Then
            If ms_gasolina = 10 Then
                lbl_gasolina.Text = lbl_gasolina.Text - 1
                ms_gasolina = 0
            End If
            ms_gasolina += 1
        End If

        lc.mover(X_Lancha, Y_Lancha)

        lc.choqueSobeviviente(sv.v_sobreviviente)
        lc.choqueTiburon(tb.v_tiburon)

    End Sub

    Private Sub TimerTiburon_Tick(sender As Object, e As EventArgs) Handles TimerTiburon.Tick
        tb.mover()
    End Sub

    Private Sub TimerSobrevivientes_Tick(sender As Object, e As EventArgs) Handles TimerSobrevivientes.Tick
        sv.mover(tiempoSobreviviente)
        sv.choqueTiburon(tb.v_tiburon)
    End Sub

    Private Sub TimerBuque_Tick(sender As Object, e As EventArgs) Handles TimerBuque.Tick
        bq.mover()

        If lbl_puntos.Text > 90 Then
            Controls.Clear()

            lancha.Visible = False
            Buque.Visible = False

            X_Lancha = 0
            Y_Lancha = 0

            tiempoSobreviviente = 0
            segundos = 1
            ms_gasolina = 0

            TimerLancha.Stop()
            TimerSobrevivientes.Stop()
            TimerTiburon.Stop()
            TimerBuque.Stop()

            puntos += lbl_puntos.Text

            InitializeComponent()

            If lblNivel.Text < 10 Then
                lblNivel.Text = lblNivel.Text + nivel
            End If

            lbl_mensaje.Text = "Ganaste, listo para el nivel " + Str(lblNivel.Text) + " ?"
            lbl_mensaje.Visible = True

            lbl_puntos_obtenidos.Text = "Puntos total" + Str(puntos)
            lbl_puntos_obtenidos.Visible = True

        End If

        If lbl_vidas.Text = 0 Or lbl_gasolina.Text = 0 Then

            Controls.Clear()

            lancha.Visible = False
            Buque.Visible = False

            X_Lancha = 0
            Y_Lancha = 0

            tiempoSobreviviente = 0
            segundos = 1
            ms_gasolina = 0
            nivel = 0

            TimerLancha.Stop()
            TimerSobrevivientes.Stop()
            TimerTiburon.Stop()
            TimerBuque.Stop()

            puntos += lbl_puntos.Text

            InitializeComponent()

            lbl_mensaje.Text = "Perdiste intentalo de nuevo "
            lbl_mensaje.Visible = True

            lbl_puntos_obtenidos.Text = "Puntos total" + Str(puntos)
            lbl_puntos_obtenidos.Visible = True
        End If

    End Sub

    Private Sub Timer_mostrarSobrevivientes_Tick(sender As Object, e As EventArgs) Handles Timer_mostrarSobrevivientes.Tick

        sv.v_sobreviviente(rnd.Next(9)).Visible = True

        sv.v_sobreviviente(rnd.Next(9)).Visible = False

    End Sub
End Class

