Imports System.IO
Imports System.Data
Imports System.Data.SqlServerCe

Public Class formListaSkaner
    Public Function CzyscListe() As Boolean
        'każdorazowe czyszczenie listy
        For index As Integer = 0 To lbLista.Items.Count - 1
            lbLista.Items.RemoveAt(0)
        Next
        txtSkanujLista.Focus()
        Return True
    End Function

    Private Sub formListaSkaner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSkanujLista.Focus()
    End Sub

    Private Sub txtSkanujLista_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSkanujLista.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = 13 Then 'skaner wysłał kod klawisza Enter
            lbLista.Items.Add(txtSkanujLista.Text)
            txtSkanujLista.Text = ""
            txtSkanujLista.Focus()
        End If
    End Sub

    Private Sub btnZapisz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZapisz.Click
        Dim plikDatabase As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\symetrix-db.sdf"
        Dim conn As New SqlCeConnection()
        conn.ConnectionString = "Persist Security Info=False; Data Source = " & plikDatabase & "; Password = power-sql;"
        conn.Open()

        'czyszczenie tabeli
        Dim DeleteCmd As SqlCeCommand = New SqlCeCommand("DELETE FROM tbl_symetrix_lista", conn)
        DeleteCmd.ExecuteNonQuery()

        'zapis elementów z listy do bazy danych
        For index As Integer = 0 To lbLista.Items.Count - 1
            Dim InsertCmd As SqlCeCommand = New SqlCeCommand("INSERT INTO tbl_symetrix_lista (kod) VALUES ('" & lbLista.Items.Item(index) & "')", conn)
            InsertCmd.ExecuteNonQuery()
        Next
        conn.Close()
        txtSkanujLista.Focus()
    End Sub

    Private Sub lbLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbLista.SelectedIndexChanged
        If lbLista.SelectedIndex >= 0 Then
            Dim Result As MsgBoxResult
            Result = MsgBox("Usunąć element " & vbNewLine & lbLista.Items.Item(lbLista.SelectedIndex), vbOKCancel + MsgBoxStyle.Question, "Potwierdź usunięcie")

            If Result = MsgBoxResult.Ok Then
                lbLista.Items.RemoveAt(lbLista.SelectedIndex)
            End If
        End If
        txtSkanujLista.Focus()
    End Sub

    Private Sub btnPowrot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowrot.Click
        formMain.Show()
    End Sub
End Class