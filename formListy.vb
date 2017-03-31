Public Class formListy
    Private Sub btnListaP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaP.Click
        formListaPlik.Show()
        formListaPlik.CzyscListe()
        formListaPlik.LadujListe()
    End Sub

    Private Sub btnListaS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaS.Click
        formListaSkaner.Show()
        formListaSkaner.CzyscListe()
        formListaSkaner.txtSkanujLista.Focus()
    End Sub

    Private Sub btnPowrot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowrot.Click
        formMain.Show()
    End Sub
End Class