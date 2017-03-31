<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class formListaPlik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formListaPlik))
        Me.btnPowrot = New System.Windows.Forms.Button
        Me.lbl_INFO = New System.Windows.Forms.Label
        Me.lbLista = New System.Windows.Forms.ListBox
        Me.btnZapisz = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPowrot
        '
        Me.btnPowrot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnPowrot.Location = New System.Drawing.Point(165, 210)
        Me.btnPowrot.Name = "btnPowrot"
        Me.btnPowrot.Size = New System.Drawing.Size(140, 50)
        Me.btnPowrot.TabIndex = 1
        Me.btnPowrot.Text = "Powrót"
        '
        'lbl_INFO
        '
        Me.lbl_INFO.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_INFO.Location = New System.Drawing.Point(15, 10)
        Me.lbl_INFO.Name = "lbl_INFO"
        Me.lbl_INFO.Size = New System.Drawing.Size(290, 30)
        Me.lbl_INFO.Text = "SymetriX - Importuj listę"
        Me.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbLista
        '
        Me.lbLista.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lbLista.Location = New System.Drawing.Point(15, 40)
        Me.lbLista.Name = "lbLista"
        Me.lbLista.Size = New System.Drawing.Size(290, 163)
        Me.lbLista.TabIndex = 5
        '
        'btnZapisz
        '
        Me.btnZapisz.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnZapisz.Location = New System.Drawing.Point(15, 210)
        Me.btnZapisz.Name = "btnZapisz"
        Me.btnZapisz.Size = New System.Drawing.Size(140, 50)
        Me.btnZapisz.TabIndex = 6
        Me.btnZapisz.Text = "Zapisz"
        '
        'formListaPlik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.btnZapisz)
        Me.Controls.Add(Me.lbLista)
        Me.Controls.Add(Me.lbl_INFO)
        Me.Controls.Add(Me.btnPowrot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formListaPlik"
        Me.Text = "SymetriX"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPowrot As System.Windows.Forms.Button
    Friend WithEvents lbl_INFO As System.Windows.Forms.Label
    Friend WithEvents lbLista As System.Windows.Forms.ListBox
    Friend WithEvents btnZapisz As System.Windows.Forms.Button
End Class
