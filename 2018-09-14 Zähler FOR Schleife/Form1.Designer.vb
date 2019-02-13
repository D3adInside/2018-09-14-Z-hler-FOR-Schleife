<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdZähler = New System.Windows.Forms.Button()
        Me.cmdEingabe = New System.Windows.Forms.Button()
        Me.txtAnfang = New System.Windows.Forms.TextBox()
        Me.txtSchritt = New System.Windows.Forms.TextBox()
        Me.txtEnde = New System.Windows.Forms.TextBox()
        Me.Anfang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdZähler
        '
        Me.cmdZähler.Location = New System.Drawing.Point(299, 172)
        Me.cmdZähler.Name = "cmdZähler"
        Me.cmdZähler.Size = New System.Drawing.Size(396, 180)
        Me.cmdZähler.TabIndex = 0
        Me.cmdZähler.Text = "Zähler"
        Me.cmdZähler.UseVisualStyleBackColor = True
        '
        'cmdEingabe
        '
        Me.cmdEingabe.Location = New System.Drawing.Point(475, 51)
        Me.cmdEingabe.Name = "cmdEingabe"
        Me.cmdEingabe.Size = New System.Drawing.Size(150, 47)
        Me.cmdEingabe.TabIndex = 1
        Me.cmdEingabe.Text = "Eingabe"
        Me.cmdEingabe.UseVisualStyleBackColor = True
        '
        'txtAnfang
        '
        Me.txtAnfang.Location = New System.Drawing.Point(86, 72)
        Me.txtAnfang.Name = "txtAnfang"
        Me.txtAnfang.Size = New System.Drawing.Size(100, 26)
        Me.txtAnfang.TabIndex = 2
        '
        'txtSchritt
        '
        Me.txtSchritt.Location = New System.Drawing.Point(86, 145)
        Me.txtSchritt.Name = "txtSchritt"
        Me.txtSchritt.Size = New System.Drawing.Size(100, 26)
        Me.txtSchritt.TabIndex = 3
        '
        'txtEnde
        '
        Me.txtEnde.Location = New System.Drawing.Point(86, 223)
        Me.txtEnde.Name = "txtEnde"
        Me.txtEnde.Size = New System.Drawing.Size(100, 26)
        Me.txtEnde.TabIndex = 4
        '
        'Anfang
        '
        Me.Anfang.AutoSize = True
        Me.Anfang.Location = New System.Drawing.Point(10, 75)
        Me.Anfang.Name = "Anfang"
        Me.Anfang.Size = New System.Drawing.Size(61, 20)
        Me.Anfang.TabIndex = 5
        Me.Anfang.Text = "Anfang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Schritt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ende"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Anfang)
        Me.Controls.Add(Me.txtEnde)
        Me.Controls.Add(Me.txtSchritt)
        Me.Controls.Add(Me.txtAnfang)
        Me.Controls.Add(Me.cmdEingabe)
        Me.Controls.Add(Me.cmdZähler)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdZähler As Button
    Friend WithEvents cmdEingabe As Button
    Friend WithEvents txtAnfang As TextBox
    Friend WithEvents txtSchritt As TextBox
    Friend WithEvents txtEnde As TextBox
    Friend WithEvents Anfang As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
