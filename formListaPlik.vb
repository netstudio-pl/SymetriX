Imports System.IO
Imports System.Data
Imports System.Data.SqlServerCe

Public Class formListaPlik
    Public Function CzyscListe() As Boolean
        'każdorazowe czyszczenie listy
        For index As Integer = 0 To lbLista.Items.Count - 1
            lbLista.Items.RemoveAt(0)
        Next
        Return True
    End Function

    Public Function LadujListe() As Boolean
        Dim plikLista As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\lista.txt"

        If System.IO.File.Exists(plikLista) = True Then
            Dim objReader As New System.IO.StreamReader(plikLista)

            Do While objReader.Peek() <> -1
                lbLista.Items.Add(objReader.ReadLine())
            Loop
        Else
            MsgBox("Nie można załadować pliku lista.txt", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Błąd programu")
        End If
        Return True
    End Function

    Private Sub formLista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub lbLista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbLista.SelectedIndexChanged
        If lbLista.SelectedIndex >= 0 Then
            Dim Result As MsgBoxResult
            Result = MsgBox("Usunąć element " & vbNewLine & lbLista.Items.Item(lbLista.SelectedIndex), vbOKCancel + MsgBoxStyle.Question, "Potwierdź usunięcie")

            If Result = MsgBoxResult.Ok Then
                lbLista.Items.RemoveAt(lbLista.SelectedIndex)
            End If
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
    End Sub

    Private Sub btnPowrot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowrot.Click
        formMain.Show()
    End Sub
End Class