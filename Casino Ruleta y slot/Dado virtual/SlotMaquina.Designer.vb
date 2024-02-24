<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMaquina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlotMaquina))
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.lblJackpot = New System.Windows.Forms.Label()
        Me.lblJackpotCantidad = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtApuesta = New System.Windows.Forms.TextBox()
        Me.lblDineroDisponible = New System.Windows.Forms.Label()
        Me.lblDineroDisponibleCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnApostar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReiniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDepositar
        '
        Me.btnDepositar.BackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositar.FlatAppearance.BorderSize = 0
        Me.btnDepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositar.Font = New System.Drawing.Font("Stencil", 15.0!)
        Me.btnDepositar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDepositar.Location = New System.Drawing.Point(62, 279)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(134, 30)
        Me.btnDepositar.TabIndex = 1
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = False
        '
        'txtDeposito
        '
        Me.txtDeposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeposito.Font = New System.Drawing.Font("Stencil", 17.0!)
        Me.txtDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtDeposito.Location = New System.Drawing.Point(68, 233)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(121, 27)
        Me.txtDeposito.TabIndex = 2
        '
        'lblJackpot
        '
        Me.lblJackpot.AutoSize = True
        Me.lblJackpot.BackColor = System.Drawing.Color.Transparent
        Me.lblJackpot.Font = New System.Drawing.Font("Stencil", 20.0!)
        Me.lblJackpot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJackpot.Location = New System.Drawing.Point(34, 121)
        Me.lblJackpot.Name = "lblJackpot"
        Me.lblJackpot.Size = New System.Drawing.Size(132, 32)
        Me.lblJackpot.TabIndex = 4
        Me.lblJackpot.Text = "JACKPOT"
        '
        'lblJackpotCantidad
        '
        Me.lblJackpotCantidad.AutoSize = True
        Me.lblJackpotCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblJackpotCantidad.Font = New System.Drawing.Font("Stencil", 18.0!)
        Me.lblJackpotCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJackpotCantidad.Location = New System.Drawing.Point(169, 124)
        Me.lblJackpotCantidad.Name = "lblJackpotCantidad"
        Me.lblJackpotCantidad.Size = New System.Drawing.Size(27, 29)
        Me.lblJackpotCantidad.TabIndex = 5
        Me.lblJackpotCantidad.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(321, 338)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(414, 338)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(508, 338)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'txtApuesta
        '
        Me.txtApuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtApuesta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApuesta.Font = New System.Drawing.Font("Stencil", 15.0!)
        Me.txtApuesta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtApuesta.Location = New System.Drawing.Point(412, 566)
        Me.txtApuesta.Name = "txtApuesta"
        Me.txtApuesta.Size = New System.Drawing.Size(101, 24)
        Me.txtApuesta.TabIndex = 10
        '
        'lblDineroDisponible
        '
        Me.lblDineroDisponible.AutoSize = True
        Me.lblDineroDisponible.BackColor = System.Drawing.Color.Transparent
        Me.lblDineroDisponible.Font = New System.Drawing.Font("Stencil", 12.0!)
        Me.lblDineroDisponible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblDineroDisponible.Location = New System.Drawing.Point(30, 372)
        Me.lblDineroDisponible.Name = "lblDineroDisponible"
        Me.lblDineroDisponible.Size = New System.Drawing.Size(161, 19)
        Me.lblDineroDisponible.TabIndex = 11
        Me.lblDineroDisponible.Text = "Dinero Disponible"
        '
        'lblDineroDisponibleCantidad
        '
        Me.lblDineroDisponibleCantidad.AutoSize = True
        Me.lblDineroDisponibleCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblDineroDisponibleCantidad.Font = New System.Drawing.Font("Stencil", 18.0!)
        Me.lblDineroDisponibleCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblDineroDisponibleCantidad.Location = New System.Drawing.Point(35, 400)
        Me.lblDineroDisponibleCantidad.Name = "lblDineroDisponibleCantidad"
        Me.lblDineroDisponibleCantidad.Size = New System.Drawing.Size(27, 29)
        Me.lblDineroDisponibleCantidad.TabIndex = 12
        Me.lblDineroDisponibleCantidad.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(49, 500)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Multiplicadores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Stencil", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 133)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "7 7 7 = JACKPOT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 1 1 = x10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 2 3 = x7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 2 1 = x7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 1 5 = x5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 4 6 = x5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 3" & _
            " 5 = x5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnApostar
        '
        Me.btnApostar.BackColor = System.Drawing.Color.Transparent
        Me.btnApostar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApostar.FlatAppearance.BorderSize = 0
        Me.btnApostar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnApostar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnApostar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApostar.Font = New System.Drawing.Font("Stencil", 15.0!)
        Me.btnApostar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApostar.Location = New System.Drawing.Point(394, 625)
        Me.btnApostar.Name = "btnApostar"
        Me.btnApostar.Size = New System.Drawing.Size(134, 30)
        Me.btnApostar.TabIndex = 16
        Me.btnApostar.Text = "Apostar"
        Me.btnApostar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReiniciar.FlatAppearance.BorderSize = 0
        Me.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciar.Font = New System.Drawing.Font("Broadway", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnReiniciar.Location = New System.Drawing.Point(22, 21)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(53, 54)
        Me.btnReiniciar.TabIndex = 22
        Me.btnReiniciar.Text = "          "
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'SlotMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(738, 693)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnApostar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDineroDisponibleCantidad)
        Me.Controls.Add(Me.lblDineroDisponible)
        Me.Controls.Add(Me.txtApuesta)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblJackpotCantidad)
        Me.Controls.Add(Me.lblJackpot)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.btnDepositar)
        Me.DoubleBuffered = True
        Me.Name = "SlotMaquina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TragaMonedas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDepositar As System.Windows.Forms.Button
    Friend WithEvents txtDeposito As System.Windows.Forms.TextBox
    Friend WithEvents lblJackpot As System.Windows.Forms.Label
    Friend WithEvents lblJackpotCantidad As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtApuesta As System.Windows.Forms.TextBox
    Friend WithEvents lblDineroDisponible As System.Windows.Forms.Label
    Friend WithEvents lblDineroDisponibleCantidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnApostar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
End Class
