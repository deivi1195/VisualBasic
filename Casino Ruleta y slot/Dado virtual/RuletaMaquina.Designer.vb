<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuletaMaquina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RuletaMaquina))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGirar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtDineroDepositado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDineroDisponible = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.RadioButtonPar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonImpar = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBoxColores = New System.Windows.Forms.GroupBox()
        Me.GroupBoxPares = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxColores.SuspendLayout()
        Me.GroupBoxPares.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(470, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnGirar
        '
        Me.btnGirar.BackColor = System.Drawing.Color.Transparent
        Me.btnGirar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGirar.FlatAppearance.BorderSize = 0
        Me.btnGirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGirar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.btnGirar.Location = New System.Drawing.Point(383, 622)
        Me.btnGirar.Name = "btnGirar"
        Me.btnGirar.Size = New System.Drawing.Size(107, 41)
        Me.btnGirar.TabIndex = 1
        Me.btnGirar.Text = "GIRAR"
        Me.btnGirar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Broadway", 17.75!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(289, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RULETA"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(413, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NUMERO"
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.txtNumero.Location = New System.Drawing.Point(442, 459)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(48, 24)
        Me.txtNumero.TabIndex = 8
        '
        'txtDineroDepositado
        '
        Me.txtDineroDepositado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDineroDepositado.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.txtDineroDepositado.Location = New System.Drawing.Point(87, 189)
        Me.txtDineroDepositado.Name = "txtDineroDepositado"
        Me.txtDineroDepositado.Size = New System.Drawing.Size(139, 24)
        Me.txtDineroDepositado.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(78, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ingrese el dinero"
        '
        'btnDepositar
        '
        Me.btnDepositar.BackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDepositar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.btnDepositar.FlatAppearance.BorderSize = 0
        Me.btnDepositar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositar.Location = New System.Drawing.Point(82, 291)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(139, 32)
        Me.btnDepositar.TabIndex = 15
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.Label4.Location = New System.Drawing.Point(70, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Dinero Disponible"
        '
        'lblDineroDisponible
        '
        Me.lblDineroDisponible.AutoSize = True
        Me.lblDineroDisponible.BackColor = System.Drawing.Color.Transparent
        Me.lblDineroDisponible.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.lblDineroDisponible.Location = New System.Drawing.Point(83, 432)
        Me.lblDineroDisponible.Name = "lblDineroDisponible"
        Me.lblDineroDisponible.Size = New System.Drawing.Size(24, 24)
        Me.lblDineroDisponible.TabIndex = 17
        Me.lblDineroDisponible.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Broadway", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Minimo 300"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.btnLimpiar.Location = New System.Drawing.Point(554, 622)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 41)
        Me.btnLimpiar.TabIndex = 19
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRetirar
        '
        Me.btnRetirar.BackColor = System.Drawing.Color.Transparent
        Me.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetirar.FlatAppearance.BorderSize = 0
        Me.btnRetirar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRetirar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.btnRetirar.Location = New System.Drawing.Point(90, 540)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(122, 41)
        Me.btnRetirar.TabIndex = 20
        Me.btnRetirar.Text = "RETIRAR"
        Me.btnRetirar.UseVisualStyleBackColor = False
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
        Me.btnReiniciar.Location = New System.Drawing.Point(12, 12)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(53, 54)
        Me.btnReiniciar.TabIndex = 21
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'RadioButtonPar
        '
        Me.RadioButtonPar.AutoSize = True
        Me.RadioButtonPar.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonPar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.RadioButtonPar.Location = New System.Drawing.Point(17, 27)
        Me.RadioButtonPar.Name = "RadioButtonPar"
        Me.RadioButtonPar.Size = New System.Drawing.Size(76, 28)
        Me.RadioButtonPar.TabIndex = 22
        Me.RadioButtonPar.TabStop = True
        Me.RadioButtonPar.Text = "PAR"
        Me.RadioButtonPar.UseVisualStyleBackColor = False
        '
        'RadioButtonImpar
        '
        Me.RadioButtonImpar.AutoSize = True
        Me.RadioButtonImpar.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonImpar.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.RadioButtonImpar.Location = New System.Drawing.Point(17, 61)
        Me.RadioButtonImpar.Name = "RadioButtonImpar"
        Me.RadioButtonImpar.Size = New System.Drawing.Size(105, 28)
        Me.RadioButtonImpar.TabIndex = 23
        Me.RadioButtonImpar.TabStop = True
        Me.RadioButtonImpar.Text = "IMPAR"
        Me.RadioButtonImpar.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.RadioButton1.Location = New System.Drawing.Point(19, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(105, 28)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.Text = "NEGRO"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Italic)
        Me.RadioButton2.Location = New System.Drawing.Point(19, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 28)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ROJO"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'GroupBoxColores
        '
        Me.GroupBoxColores.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxColores.Controls.Add(Me.RadioButton2)
        Me.GroupBoxColores.Controls.Add(Me.RadioButton1)
        Me.GroupBoxColores.Font = New System.Drawing.Font("Broadway", 10.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBoxColores.Location = New System.Drawing.Point(530, 354)
        Me.GroupBoxColores.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxColores.Name = "GroupBoxColores"
        Me.GroupBoxColores.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBoxColores.Size = New System.Drawing.Size(126, 78)
        Me.GroupBoxColores.TabIndex = 24
        Me.GroupBoxColores.TabStop = False
        '
        'GroupBoxPares
        '
        Me.GroupBoxPares.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxPares.Controls.Add(Me.RadioButtonImpar)
        Me.GroupBoxPares.Controls.Add(Me.RadioButtonPar)
        Me.GroupBoxPares.Font = New System.Drawing.Font("Broadway", 10.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBoxPares.Location = New System.Drawing.Point(530, 452)
        Me.GroupBoxPares.Name = "GroupBoxPares"
        Me.GroupBoxPares.Size = New System.Drawing.Size(119, 90)
        Me.GroupBoxPares.TabIndex = 25
        Me.GroupBoxPares.TabStop = False
        '
        'RuletaMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 699)
        Me.Controls.Add(Me.GroupBoxPares)
        Me.Controls.Add(Me.GroupBoxColores)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDineroDisponible)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDineroDepositado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGirar)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RuletaMaquina"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETRO RULETA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxColores.ResumeLayout(False)
        Me.GroupBoxColores.PerformLayout()
        Me.GroupBoxPares.ResumeLayout(False)
        Me.GroupBoxPares.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGirar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtDineroDepositado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDepositar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDineroDisponible As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnRetirar As System.Windows.Forms.Button
    Friend WithEvents btnReiniciar As System.Windows.Forms.Button
    Friend WithEvents RadioButtonPar As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonImpar As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxColores As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxPares As System.Windows.Forms.GroupBox

End Class
