<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class formListaSkaner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formListaSkaner))
        Me.btnZapisz = New System.Windows.Forms.Button
        Me.lbLista = New System.Windows.Forms.ListBox
        Me.lbl_INFO = New System.Windows.Forms.Label
        Me.btnPowrot = New System.Windows.Forms.Button
        Me.txtSkanujLista = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnZapisz
        '
        Me.btnZapisz.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnZapisz.Location = New System.Drawing.Point(14, 212)
        Me.btnZapisz.Name = "btnZapisz"
        Me.btnZapisz.Size = New System.Drawing.Size(140, 50)
        Me.btnZapisz.TabIndex = 10
        Me.btnZapisz.Text = "Zapisz"
        '
        'lbLista
        '
        Me.lbLista.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lbLista.Location = New System.Drawing.Point(14, 88)
        Me.lbLista.Name = "lbLista"
        Me.lbLista.Size = New System.Drawing.Size(290, 117)
        Me.lbLista.TabIndex = 9
        '
        'lbl_INFO
        '
        Me.lbl_INFO.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_INFO.Location = New System.Drawing.Point(15, 10)
        Me.lbl_INFO.Name = "lbl_INFO"
        Me.lbl_INFO.Size = New System.Drawing.Size(290, 30)
        Me.lbl_INFO.Text = "SymetriX - Utwórz listę"
        Me.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPowrot
        '
        Me.btnPowrot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnPowrot.Location = New System.Drawing.Point(164, 212)
        Me.btnPowrot.Name = "btnPowrot"
        Me.btnPowrot.Size = New System.Drawing.Size(140, 50)
        Me.btnPowrot.TabIndex = 8
        Me.btnPowrot.Text = "Powrót"
        '
        'txtSkanujLista
        '
        Me.txtSkanujLista.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.txtSkanujLista.Location = New System.Drawing.Point(15, 43)
        Me.txtSkanujLista.Name = "txtSkanujLista"
        Me.txtSkanujLista.Size = New System.Drawing.Size(289, 29)
        Me.txtSkanujLista.TabIndex = 12
        '
        'formListaSkaner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.txtSkanujLista)
        Me.Controls.Add(Me.btnZapisz)
        Me.Controls.Add(Me.lbLista)
        Me.Controls.Add(Me.lbl_INFO)
        Me.Controls.Add(Me.btnPowrot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formListaSkaner"
        Me.Text = "SymetriX"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnZapisz As System.Windows.Forms.Button
    Friend WithEvents lbLista As System.Windows.Forms.ListBox
    Friend WithEvents lbl_INFO As System.Windows.Forms.Label
    Friend WithEvents btnPowrot As System.Windows.Forms.Button
    Friend WithEvents txtSkanujLista As System.Windows.Forms.TextBox
End Class
