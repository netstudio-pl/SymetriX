Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Data.SqlServerCe

Public Class formMain
    Private Sub formMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        splashLoad()
    End Sub

    Private Sub splashLoad()
        'ładowany jest obraz z pliku zewnętrznego (splash.jpg)
        pbSplash.BringToFront()
        Dim plikSplash As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\splash.jpg"

        If System.IO.File.Exists(plikSplash) = True Then
            Dim splashImage As Image = New Bitmap(plikSplash)
            pbSplash.Image = splashImage
        Else
            MsgBox("Plik splash.jpg nie istnieje", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Błąd programu")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'po 5 sekundach ekran splash jest ukrywany
        Timer1.Enabled = False
        pbSplash.Visible = False
        pbSplash.SendToBack()
    End Sub

    Private Sub btnLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLista.Click
        formListy.Show()
    End Sub

    Private Sub btnSzukaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSzukaj.Click
        formSzukaj.Show()
        formSzukaj.txtSzukaj.Focus()
    End Sub

    Private Sub btnWyjscie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWyjscie.Click
        'eksportuje dane z tabeli do pliku tekstowego
        Dim plikLista As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\lista.txt"
        Dim objWriter As New System.IO.StreamWriter(plikLista)

        Dim plikDatabase As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\symetrix-db.sdf"
        Dim conn As New SqlCeConnection()
        conn.ConnectionString = "Persist Security Info=False; Data Source = " & plikDatabase & "; Password = power-sql;"
        conn.Open()

        'przeszukiwanie tabeli
        Dim SelectCmd As SqlCeCommand = New SqlCeCommand("SELECT kod FROM tbl_symetrix_lista", conn)
        Dim dr As SqlCeDataReader = SelectCmd.ExecuteReader()

        Do While dr.Read()
            objWriter.WriteLine(dr.GetString(0))
        Loop

        objWriter.Dispose()
        objWriter.Close()
        dr.Close()
        conn.Close()
        Me.Close()
    End Sub
End Class

