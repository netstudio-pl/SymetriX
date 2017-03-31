Imports System.IO
Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Media

Public Class formSzukaj
    Private Function start_DataWedge() As Boolean
        '********************************************** funkcja sprawdzająca czy proces DataWedge jest uruchomiony
        Dim proc As OpenNETCF.ToolHelp.ProcessEntry() = OpenNETCF.ToolHelp.ProcessEntry.GetProcesses()
        Dim wynik As Boolean

        If proc.Length > 0 Then
            For Cnt As Integer = 0 To proc.Length - 1
                If proc(Cnt).ExeFile = "DataWedge.exe" Then
                    wynik = False 'proces uruchomiony
                Else
                    wynik = True 'proces nie uruchomiony
                End If
            Next Cnt
        End If
        Return wynik
    End Function

    Private Sub formSzukaj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If start_DataWedge() Then 'uruchamia proces DataWedge jeżeli nie był uruchomiony
            Dim info As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
            info.FileName = "\Windows\DataWedge.exe"
            info.UseShellExecute = True
            System.Diagnostics.Process.Start(info)
        End If
        txtSzukaj.Focus()
    End Sub

    Private Sub txtSzukaj_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSzukaj.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)

        If KeyAscii = 13 Then 'skaner wysłał kod klawisza Enter
            Dim plikDatabase As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) & "\symetrix-db.sdf"
            Dim conn As New SqlCeConnection()
            conn.ConnectionString = "Persist Security Info=False; Data Source = " & plikDatabase & "; Password = power-sql;"
            conn.Open()

            'przeszukiwanie tabeli
            Dim SelectCmd As SqlCeCommand = New SqlCeCommand("SELECT * FROM tbl_symetrix_lista WHERE kod='" & txtSzukaj.Text & "'", conn)
            Dim dr As SqlCeDataReader = SelectCmd.ExecuteReader()

            Do While dr.Read()
                SystemSounds.Exclamation.Play()

                'usuwa znaleziony numer z tabeli
                Dim DeleteCmd As SqlCeCommand = New SqlCeCommand("DELETE FROM tbl_symetrix_lista WHERE kod='" & txtSzukaj.Text & "'", conn)
                DeleteCmd.ExecuteNonQuery()

                formZnaleziono.lbl_INFO.Text = "Numer " & vbNewLine & txtSzukaj.Text & vbNewLine & " znaleziono na liście"
                txtSzukaj.Text = ""
                formZnaleziono.cbZamknij.Checked = False
                formZnaleziono.Show()
                formZnaleziono.Focus()

                Exit Sub
            Loop

            dr.Close()
            conn.Close()
            txtSzukaj.Text = ""
            txtSzukaj.Focus()
        End If
    End Sub

    Private Sub btnPowrot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPowrot.Click
        formMain.Show()
    End Sub
End Class