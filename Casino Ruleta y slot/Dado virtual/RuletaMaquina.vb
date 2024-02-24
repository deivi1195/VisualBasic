Public Class RuletaMaquina
    'Declaracion de variables generales
    Dim numApuesta, num, dinero_depositado, dinero_disponible As Integer

    Private Sub btnGirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGirar.Click
        numApuesta = Val(txtNumero.Text)
        'condiciones de validaciones para poder girar la ruleta
        If numApuesta <= 14 And numApuesta >= 0 Then 'validando que numero de la apuesta sea menor a 14 y mayor a 0
            If IsNumeric(txtNumero.Text) Or txtNumero.Text = "" Then 'que ese numero sea  de tipo numerico o tambien pueda estar vacio
                If txtNumero.Text.Length Or RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButtonPar.Checked = True Or RadioButtonImpar.Checked = True Then 'que alguno de los 3 este activo, active el timer y bloquee los botones
                    Timer1.Enabled = True
                    btnGirar.Enabled = False
                    btnDepositar.Enabled = False
                    btnLimpiar.Enabled = False
                    btnReiniciar.Enabled = False
                    btnRetirar.Enabled = False
                Else
                    MsgBox("Ingrese o Seleccione una apuesta", vbInformation, "Error")
                End If
            Else
                MsgBox("Solo se permiten números en este campo.", vbInformation, "Error de Datos")
            End If
        Else
            MsgBox("Ingrese un numero del 0 al 14.", vbInformation, "Error de Datos")
        End If
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static cont As Integer = 0
        Dim cadena As String = "C:\Users\deivi\OneDrive\Pictures\numeros 1-14\"
        Dim color As Integer

        numApuesta = Val(txtNumero.Text)
        Randomize()

        'Generacion de numeros aleatorios paralos numeros y los colores
        num = Int(14 * Rnd() + 0)
        color = Int(2 * Rnd() + 1) '1 = Rojo / 2 = Negro

        'si el color es rojo y el numero es menor que 15 en la variable cadena se concatena el numero random de la variable num 
        'convertido a string y se concatena con la terminacion de la ruta de la imagen y en caso contrario se hace lo mismo para las rojas
        If color = 1 And num < 15 Then
            cadena += CStr(num) + ".png"
            PictureBox1.Image = Image.FromFile(cadena)
        Else
            cadena += CStr(num) + "n.png"
            PictureBox1.Image = Image.FromFile(cadena)
        End If

        'contador que se usa con el timer para ir aumentado su valor y con ese valor crear un condicional que pare el timer y active el boton
        'de girar
        cont += 1 'contador de caras

        If cont = 28 Then
            Timer1.Enabled = False
            btnGirar.Enabled = True
            btnDepositar.Enabled = True
            btnLimpiar.Enabled = True
            btnReiniciar.Enabled = True
            btnRetirar.Enabled = True
            cont = 0

            If txtNumero.Text.Length <> 0 Then 'validando que lo que se escriba en el textbox tenga algo
                If num = numApuesta Then 'numero random y numero de apuesta son iguales
                    dinero_disponible += 1000
                    MsgBox("HAS GANADO 1000", vbInformation, "APUESTA DE NUMEROS")
                    lblDineroDisponible.Text = dinero_disponible

                Else
                    dinero_disponible -= 100
                    MsgBox("HAS PERDIDO 100", vbInformation, "APUESTA DE NUMEROS")
                    lblDineroDisponible.Text = dinero_disponible
                End If
            Else
                dinero_disponible = dinero_disponible
            End If

            If RadioButton1.Checked = True Then 'si el radiobutton negro esta seleccionado
                If color = 2 Then 'si selecciona el  color rojo
                    dinero_disponible += 200
                    MsgBox("HAS GANADO 200", vbInformation, "APUESTA DE COLOR")
                    lblDineroDisponible.Text = dinero_disponible
                Else
                    dinero_disponible -= 100
                    MsgBox("HAS PERDIDO 100", vbInformation, "APUESTA DE COLOR")
                    lblDineroDisponible.Text = dinero_disponible
                End If
            End If

            If RadioButton2.Checked = True Then 'si el radiobutton rojo esta seleccionado
                If color = 1 Then 'si selecciona el  color rojo
                    dinero_disponible += 200
                    MsgBox("HAS GANADO 200", vbInformation, "APUESTA DE COLOR")
                    lblDineroDisponible.Text = dinero_disponible
                Else
                    dinero_disponible -= 100
                    MsgBox("HAS PERDIDO 100", vbInformation, "APUESTA DE COLOR")
                    lblDineroDisponible.Text = dinero_disponible
                End If
            End If

            If RadioButtonPar.Checked = True Then 'si el radiobutton PAR esta seleccionado
                If num Mod 2 = 0 Then 'si el numero es par
                    dinero_disponible += 200
                    MsgBox("HAS GANADO 200", vbInformation, "APUESTA DE PARES")
                    lblDineroDisponible.Text = dinero_disponible
                Else
                    dinero_disponible -= 100
                    MsgBox("HAS PERDIDO 100", vbInformation, "APUESTA DE PARES")
                    lblDineroDisponible.Text = dinero_disponible
                End If
            End If

            If RadioButtonImpar.Checked = True Then 'si el radiobutton IMPAR esta seleccionado
                If num Mod 2 <> 0 Then 'si el numero es impar
                    dinero_disponible += 200
                    MsgBox("HAS GANADO 200", vbInformation, "APUESTA DE PARES")
                    lblDineroDisponible.Text = dinero_disponible
                Else
                    dinero_disponible -= 100
                    MsgBox("HAS PERDIDO 100", vbInformation, "APUESTA DE PARES")
                    lblDineroDisponible.Text = dinero_disponible
                End If
            End If
        End If

        'verificar que al momento de que termine de girar la ruleta, si se tiene menos de 200 en la cuenta no poder girar la ruleta
        If dinero_disponible < 300 Then
            btnGirar.Enabled = False
        Else
            btnGirar.Enabled = True
        End If
    End Sub

    Private Sub btnDepositar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositar.Click
        dinero_depositado = Val(txtDineroDepositado.Text)

        If IsNumeric(txtDineroDepositado.Text) Then 'validando que el valor del textbox sea de tipo numerico
            If dinero_depositado >= 300 Then 'validando que el valor del textbox sea mayor o igual a 1000
                dinero_disponible += dinero_depositado

                lblDineroDisponible.Text = dinero_disponible
            Else
                MsgBox("Ingrese un monto mayor a 300.", vbInformation, "Error de Datos")
            End If
        Else
            MsgBox("Solo se permiten números en este campo.", vbInformation, "Error de Datos")
        End If

        If dinero_disponible >= 300 Then
            btnGirar.Enabled = True
        Else
            btnGirar.Enabled = False
        End If

        txtDineroDepositado.Clear()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtNumero.MaxLength = 2
        txtDineroDepositado.MaxLength = 6

        btnGirar.Enabled = False

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtNumero.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButtonPar.Checked = False
        RadioButtonImpar.Checked = False
    End Sub

    Private Sub btnRetirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirar.Click
        dinero_disponible = 0
        lblDineroDisponible.Text = 0
    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Me.Hide()
        PortadaCasino.Show()
        txtNumero.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButtonPar.Checked = False
        RadioButtonImpar.Checked = False
        dinero_disponible = 0
        lblDineroDisponible.Text = 0
    End Sub

    

End Class
