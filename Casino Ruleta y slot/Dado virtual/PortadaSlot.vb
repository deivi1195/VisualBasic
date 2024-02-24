Public Class PortadaSlot

    Private Sub btnEmpezar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpezar.Click
        Me.Hide()
        SlotMaquina.Show()
    End Sub

    Private Sub btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReiniciar.Click
        Me.Hide()
        PortadaCasino.Show()
    End Sub
End Class