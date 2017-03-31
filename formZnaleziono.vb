Public Class formZnaleziono
    Private Sub btnZamknij_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZamknij.Click
        If cbZamknij.Checked = True Then
            formSzukaj.Show()
            formSzukaj.txtSzukaj.Focus()
        End If
    End Sub
End Class