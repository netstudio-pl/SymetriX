<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class formZnaleziono
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formZnaleziono))
        Me.btnZamknij = New System.Windows.Forms.Button
        Me.lbl_INFO = New System.Windows.Forms.Label
        Me.cbZamknij = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnZamknij
        '
        Me.btnZamknij.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnZamknij.Location = New System.Drawing.Point(15, 210)
        Me.btnZamknij.Name = "btnZamknij"
        Me.btnZamknij.Size = New System.Drawing.Size(290, 50)
        Me.btnZamknij.TabIndex = 0
        Me.btnZamknij.Text = "Zamknij"
        '
        'lbl_INFO
        '
        Me.lbl_INFO.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_INFO.Location = New System.Drawing.Point(15, 10)
        Me.lbl_INFO.Name = "lbl_INFO"
        Me.lbl_INFO.Size = New System.Drawing.Size(290, 159)
        Me.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbZamknij
        '
        Me.cbZamknij.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.cbZamknij.Location = New System.Drawing.Point(49, 172)
        Me.cbZamknij.Name = "cbZamknij"
        Me.cbZamknij.Size = New System.Drawing.Size(256, 32)
        Me.cbZamknij.TabIndex = 1
        Me.cbZamknij.Text = "Potwierdź zamknięcie okna"
        '
        'formZnaleziono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 275)
        Me.Controls.Add(Me.cbZamknij)
        Me.Controls.Add(Me.lbl_INFO)
        Me.Controls.Add(Me.btnZamknij)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formZnaleziono"
        Me.Text = "Symetrix"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnZamknij As System.Windows.Forms.Button
    Friend WithEvents lbl_INFO As System.Windows.Forms.Label
    Friend WithEvents cbZamknij As System.Windows.Forms.CheckBox
End Class
