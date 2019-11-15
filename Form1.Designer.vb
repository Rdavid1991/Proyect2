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
        Me.lblVidas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRecarga = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.lancha = New System.Windows.Forms.PictureBox()
        Me.Buque = New System.Windows.Forms.PictureBox()
        Me.TimerTiburon = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSobrevivientes = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBuque = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.lancha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(646, 439)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(119, 57)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'TimerLancha
        '
        Me.TimerLancha.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Vidas :"
        '
        'lblVidas
        '
        Me.lblVidas.AutoSize = True
        Me.lblVidas.Location = New System.Drawing.Point(70, 8)
        Me.lblVidas.Name = "lblVidas"
        Me.lblVidas.Size = New System.Drawing.Size(13, 13)
        Me.lblVidas.TabIndex = 4
        Me.lblVidas.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Recarga"
        '
        'lblRecarga
        '
        Me.lblRecarga.AutoSize = True
        Me.lblRecarga.Location = New System.Drawing.Point(205, 8)
        Me.lblRecarga.Name = "lblRecarga"
        Me.lblRecarga.Size = New System.Drawing.Size(13, 13)
        Me.lblRecarga.TabIndex = 6
        Me.lblRecarga.Text = "0"
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
        Me.lancha.Location = New System.Drawing.Point(624, 299)
        Me.lancha.Name = "lancha"
        Me.lancha.Size = New System.Drawing.Size(173, 134)
        Me.lancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.lancha.TabIndex = 2
        Me.lancha.TabStop = False
        Me.lancha.Visible = False
        '
        'Buque
        '
        Me.Buque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buque.Image = Global._1LS_231_Centeno_1349_Proy2.My.Resources.Resources.buque
        Me.Buque.Location = New System.Drawing.Point(12, 617)
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
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNivel)
        Me.Panel1.Controls.Add(Me.lblVidas)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblRecarga)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 30)
        Me.Panel1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
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

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents Buque As PictureBox
    Friend WithEvents lancha As PictureBox
    Friend WithEvents TimerLancha As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVidas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRecarga As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNivel As Label
    Friend WithEvents TimerTiburon As Timer
    Friend WithEvents TimerSobrevivientes As Timer
    Friend WithEvents TimerBuque As Timer
    Friend WithEvents Panel1 As Panel
End Class
