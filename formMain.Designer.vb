<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class formMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.lbl_INFO = New System.Windows.Forms.Label
        Me.btnLista = New System.Windows.Forms.Button
        Me.btnSzukaj = New System.Windows.Forms.Button
        Me.btnWyjscie = New System.Windows.Forms.Button
        Me.pbSplash = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.SuspendLayout()
        '
        'lbl_INFO
        '
        Me.lbl_INFO.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_INFO.Location = New System.Drawing.Point(15, 10)
        Me.lbl_INFO.Name = "lbl_INFO"
        Me.lbl_INFO.Size = New System.Drawing.Size(290, 30)
        Me.lbl_INFO.Text = "SymetriX - Menu główne"
        Me.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLista
        '
        Me.btnLista.BackColor = System.Drawing.Color.Silver
        Me.btnLista.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnLista.Location = New System.Drawing.Point(15, 50)
        Me.btnLista.Name = "btnLista"
        Me.btnLista.Size = New System.Drawing.Size(290, 50)
        Me.btnLista.TabIndex = 16
        Me.btnLista.Text = "Lista"
        '
        'btnSzukaj
        '
        Me.btnSzukaj.BackColor = System.Drawing.Color.Silver
        Me.btnSzukaj.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnSzukaj.Location = New System.Drawing.Point(15, 130)
        Me.btnSzukaj.Name = "btnSzukaj"
        Me.btnSzukaj.Size = New System.Drawing.Size(290, 50)
        Me.btnSzukaj.TabIndex = 17
        Me.btnSzukaj.Text = "Szukaj"
        '
        'btnWyjscie
        '
        Me.btnWyjscie.BackColor = System.Drawing.Color.Silver
        Me.btnWyjscie.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnWyjscie.Location = New System.Drawing.Point(15, 210)
        Me.btnWyjscie.Name = "btnWyjscie"
        Me.btnWyjscie.Size = New System.Drawing.Size(290, 50)
        Me.btnWyjscie.TabIndex = 18
        Me.btnWyjscie.Text = "Wyjście"
        '
        'pbSplash
        '
        Me.pbSplash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbSplash.Location = New System.Drawing.Point(0, 0)
        Me.pbSplash.Name = "pbSplash"
        Me.pbSplash.Size = New System.Drawing.Size(318, 275)
        Me.pbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.btnWyjscie)
        Me.Controls.Add(Me.btnSzukaj)
        Me.Controls.Add(Me.btnLista)
        Me.Controls.Add(Me.lbl_INFO)
        Me.Controls.Add(Me.pbSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.Text = "SymetriX"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_INFO As System.Windows.Forms.Label
    Friend WithEvents btnLista As System.Windows.Forms.Button
    Friend WithEvents btnSzukaj As System.Windows.Forms.Button
    Friend WithEvents btnWyjscie As System.Windows.Forms.Button
    Friend WithEvents pbSplash As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
