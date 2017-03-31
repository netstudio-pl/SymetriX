<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class formListy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formListy))
        Me.lbl_INFO = New System.Windows.Forms.Label
        Me.btnListaS = New System.Windows.Forms.Button
        Me.btnListaP = New System.Windows.Forms.Button
        Me.btnPowrot = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbl_INFO
        '
        Me.lbl_INFO.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_INFO.Location = New System.Drawing.Point(15, 10)
        Me.lbl_INFO.Name = "lbl_INFO"
        Me.lbl_INFO.Size = New System.Drawing.Size(290, 30)
        Me.lbl_INFO.Text = "SymetriX - Wybierz listę"
        Me.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnListaS
        '
        Me.btnListaS.BackColor = System.Drawing.Color.Silver
        Me.btnListaS.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnListaS.Location = New System.Drawing.Point(15, 130)
        Me.btnListaS.Name = "btnListaS"
        Me.btnListaS.Size = New System.Drawing.Size(290, 50)
        Me.btnListaS.TabIndex = 19
        Me.btnListaS.Text = "Utwórz listę ze skanera"
        '
        'btnListaP
        '
        Me.btnListaP.BackColor = System.Drawing.Color.Silver
        Me.btnListaP.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnListaP.Location = New System.Drawing.Point(15, 50)
        Me.btnListaP.Name = "btnListaP"
        Me.btnListaP.Size = New System.Drawing.Size(290, 50)
        Me.btnListaP.TabIndex = 18
        Me.btnListaP.Text = "Importuj listę z pliku"
        '
        'btnPowrot
        '
        Me.btnPowrot.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnPowrot.Location = New System.Drawing.Point(15, 210)
        Me.btnPowrot.Name = "btnPowrot"
        Me.btnPowrot.Size = New System.Drawing.Size(290, 50)
        Me.btnPowrot.TabIndex = 21
        Me.btnPowrot.Text = "Powrót"
        '
        'formListy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.btnPowrot)
        Me.Controls.Add(Me.btnListaS)
        Me.Controls.Add(Me.btnListaP)
        Me.Controls.Add(Me.lbl_INFO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formListy"
        Me.Text = "SymetriX"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_INFO As System.Windows.Forms.Label
    Friend WithEvents btnListaS As System.Windows.Forms.Button
    Friend WithEvents btnListaP As System.Windows.Forms.Button
    Friend WithEvents btnPowrot As System.Windows.Forms.Button
End Class
