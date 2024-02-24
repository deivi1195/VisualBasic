Public Class PortadaRuleta

    Private Sub btnEmpezar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpezar.Click
        Me.Hide()
        RuletaMaquina.Show()
    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Me.Hide()
        PortadaCasino.Show()
    End Sub
End Class