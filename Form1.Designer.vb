<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.TimerLancha = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_vidas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_gasolina = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lancha = New System.Windows.Forms.PictureBox()
        Me.Buque = New System.Windows.Forms.PictureBox()
        Me.TimerTiburon = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSobrevivientes = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBuque = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_puntos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_nSobrevivientes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        CType(Me.lancha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(365, 350)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(119, 57)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'TimerLancha
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vidas :"
        '
        'lbl_vidas
        '
        Me.lbl_vidas.AutoSize = True
        Me.lbl_vidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vidas.Location = New System.Drawing.Point(73, 4)
        Me.lbl_vidas.Name = "lbl_vidas"
        Me.lbl_vidas.Size = New System.Drawing.Size(19, 20)
        Me.lbl_vidas.TabIndex = 4
        Me.lbl_vidas.Text = "5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(604, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Gasolina :"
        '
        'lbl_gasolina
        '
        Me.lbl_gasolina.AutoSize = True
        Me.lbl_gasolina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gasolina.Location = New System.Drawing.Point(700, 4)
        Me.lbl_gasolina.Name = "lbl_gasolina"
        Me.lbl_gasolina.Size = New System.Drawing.Size(29, 20)
        Me.lbl_gasolina.TabIndex = 6
        Me.lbl_gasolina.Text = "60"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(298, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nivel : "
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNivel.Location = New System.Drawing.Point(358, 0)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(20, 24)
        Me.lblNivel.TabIndex = 8
        Me.lblNivel.Text = "1"
        '
        'lancha
        '
        Me.lancha.Image = Global._1LS_231_Centeno_1349_Proy2.My.Resources.Resources.lancha
        Me.lancha.Location = New System.Drawing.Point(365, 229)
        Me.lancha.Name = "lancha"
        Me.lancha.Size = New System.Drawing.Size(40, 40)
        Me.lancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lancha.TabIndex = 2
        Me.lancha.TabStop = False
        Me.lancha.Visible = False
        '
        'Buque
        '
        Me.Buque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buque.Image = Global._1LS_231_Centeno_1349_Proy2.My.Resources.Resources.buque
        Me.Buque.Location = New System.Drawing.Point(3, 564)
        Me.Buque.Name = "Buque"
        Me.Buque.Size = New System.Drawing.Size(300, 100)
        Me.Buque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buque.TabIndex = 1
        Me.Buque.TabStop = False
        Me.Buque.Visible = False
        '
        'TimerTiburon
        '
        '
        'TimerSobrevivientes
        '
        '
        'TimerBuque
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.lbl_puntos)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_nSobrevivientes)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNivel)
        Me.Panel1.Controls.Add(Me.lbl_vidas)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_gasolina)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 50)
        Me.Panel1.TabIndex = 9
        '
        'lbl_puntos
        '
        Me.lbl_puntos.AutoSize = True
        Me.lbl_puntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_puntos.Location = New System.Drawing.Point(829, 24)
        Me.lbl_puntos.Name = "lbl_puntos"
        Me.lbl_puntos.Size = New System.Drawing.Size(19, 20)
        Me.lbl_puntos.TabIndex = 12
        Me.lbl_puntos.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(745, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Puntos :"
        '
        'lbl_nSobrevivientes
        '
        Me.lbl_nSobrevivientes.AutoSize = True
        Me.lbl_nSobrevivientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nSobrevivientes.Location = New System.Drawing.Point(829, 4)
        Me.lbl_nSobrevivientes.Name = "lbl_nSobrevivientes"
        Me.lbl_nSobrevivientes.Size = New System.Drawing.Size(19, 20)
        Me.lbl_nSobrevivientes.TabIndex = 10
        Me.lbl_nSobrevivientes.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(745, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lancha :"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mensaje.Location = New System.Drawing.Point(288, 303)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(126, 29)
        Me.lbl_mensaje.TabIndex = 10
        Me.lbl_mensaje.Text = "mensaje1"
        Me.lbl_mensaje.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lancha)
        Me.Controls.Add(Me.Buque)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.lancha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents Buque As PictureBox
    Friend WithEvents lancha As PictureBox
    Friend WithEvents TimerLancha As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_vidas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_gasolina As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents TimerTiburon As Timer
    Friend WithEvents TimerSobrevivientes As Timer
    Friend WithEvents TimerBuque As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_nSobrevivientes As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_puntos As Label
    Friend WithEvents lbl_mensaje As Label
End Class
