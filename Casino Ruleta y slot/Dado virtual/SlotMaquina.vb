Public Class SlotMaquina


    Dim dinero_depositado, dinero_disponible, apuesta, jackpot As Integer

    Private Sub btnApostar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApostar.Click
        apuesta = Val(txtApuesta.Text)

        If IsNumeric(txtApuesta.Text) Then 'validando que el valor del textbox sea de tipo numerico
            If apuesta > 0 Then
                If apuesta <= dinero_disponible Then
                    dinero_disponible -= apuesta
                    lblDineroDisponibleCantidad.Text = dinero_disponible
                    Timer1.Enabled = True
                    btnApostar.Enabled = False
                Else
                    MsgBox("La cantidad de Apuesta no puede superar el dinero disponible", vbInformation, "Error de Apuesta")
                End If
            Else
                MsgBox("La cantidad minima para apostar es de 1", vbInformation, "Error de Apuesta")
            End If
        Else
            MsgBox("Solo se permiten números en este campo.", vbInformation, "Error de Datos")
        End If

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static cont As Integer = 0
        Dim num1, num2, num3, ganancia As Integer
        Dim cadena1, cadena2, cadena3 As String
        Dim ganador As Boolean

        num1 = Int(9 * Rnd() + 0)
        num2 = Int(9 * Rnd() + 0)
        num3 = Int(9 * Rnd() + 0)

        cadena1 = "C:\Users\deivi\OneDrive\Pictures\compress slot\c" & CStr(num1) & ".jpg"
        cadena2 = "C:\Users\deivi\OneDrive\Pictures\compress slot\c" & CStr(num2) & ".jpg"
        cadena3 = "C:\Users\deivi\OneDrive\Pictures\compress slot\c" & CStr(num3) & ".jpg"

        PictureBox1.Image = Image.FromFile(cadena1)

        PictureBox2.Image = Image.FromFile(cadena2)

        PictureBox3.Image = Image.FromFile(cadena3)

        cont += 1

        If cont = 15 Then
            Timer1.Enabled = False
            btnApostar.Enabled = True
            cont = 0
            ganador = False

            If num1 = 7 And num2 = 7 And num3 = 7 Then
                dinero_disponible += jackpot
                lblDineroDisponibleCantidad.Text = dinero_disponible
                jackpot = 0
                lblJackpotCantidad.Text = jackpot
                MsgBox("HAS GANADO EL JACKPOT DE ", vbInformation, "Apuesta" & jackpot & "!!!!!!!")
                ganador = True
            End If

            If num1 = num2 And num2 = num3 Then
                ganancia = apuesta * 10
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR NUMERO IGUALES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If num1 = (num2 - 1) And num2 = (num3 - 1) Then
                ganancia = apuesta * 7
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR ESCALERA DE NUMEROS ASCENDENTES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If num3 = (num2 - 1) And num2 = (num1 - 1) Then
                ganancia = apuesta * 7
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR ESCALERA DE NUMEROS DESCENDENTES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If num1 Mod 2 = 0 And num2 Mod 2 = 0 And num3 Mod 2 = 0 Then
                ganancia = apuesta * 7
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR NUMEROS PARES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If num1 Mod 2 <> 0 And num2 Mod 2 <> 0 And num3 Mod 2 <> 0 Then
                ganancia = apuesta * 7
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR NUMEROS IMPARES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If num1 = num2 Or num1 = num2 Or num2 = num3 Then
                ganancia = apuesta * 5
                dinero_disponible += ganancia
                lblDineroDisponibleCantidad.Text = dinero_disponible
                MsgBox("HAS GANADO POR DOS NUMEROS IGUALES ", vbInformation, "Apuesta" & ganancia)
                ganador = True
            End If

            If ganador = False Then
                jackpot += (apuesta * 0.2)
                lblJackpotCantidad.Text = jackpot
                MsgBox("HAS PERDIDO " & apuesta)
            End If
        End If

        If dinero_disponible <= 0 Then
            txtApuesta.Enabled = False
            btnApostar.Enabled = False
        Else
            txtApuesta.Enabled = True
            btnApostar.Enabled = True
        End If

    End Sub

    Private Sub btnDepositar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositar.Click

        dinero_depositado = Val(txtDeposito.Text)

        If IsNumeric(txtDeposito.Text) Then 'validando que el valor del textbox sea de tipo numerico
            If dinero_depositado >= 1000 Then 'validando que el valor del textbox sea mayor o igual a 1000
                dinero_disponible += dinero_depositado

                lblDineroDisponibleCantidad.Text = dinero_disponible
            Else
                MsgBox("Ingrese un monto mayor a 1000.", vbInformation, "Error de Datos")
            End If
        Else
            MsgBox("Solo se permiten números en este campo.", vbInformation, "Error de Datos")
        End If

        txtDeposito.Clear()

        If dinero_disponible < 1000 Then
            txtApuesta.Enabled = False
            btnApostar.Enabled = False
        Else
            txtApuesta.Enabled = True
            btnApostar.Enabled = True
        End If

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtApuesta.Enabled = False
        btnApostar.Enabled = False
        txtApuesta.MaxLength = 4
        txtDeposito.MaxLength = 5

    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Me.Hide()
        PortadaCasino.Show()
        txtApuesta.Clear()
        dinero_disponible = 0
        lblDineroDisponibleCantidad.Text = 0
        jackpot = 0
        lblJackpotCantidad.Text = 0
    End Sub
End Class