Public Class PortadaCasino

    Private Sub btnRuleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuleta.Click
        Me.Hide()
        PortadaRuleta.Show()
    End Sub

    Private Sub btnSlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlot.Click
        Me.Hide()
        PortadaSlot.Show()
    End Sub
End Class