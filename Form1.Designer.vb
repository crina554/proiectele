<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCronometru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblOre = New Label()
        lblMinute = New Label()
        lblSecunde = New Label()
        lblZecimi = New Label()
        txtOra = New TextBox()
        txtZecimi = New TextBox()
        txtSecunde = New TextBox()
        txtMinute = New TextBox()
        btnStart = New Button()
        btnReset = New Button()
        prgOre = New ProgressBar()
        prgSecunde = New ProgressBar()
        prgMinute = New ProgressBar()
        btnCeas = New Button()
        tmrCronometru = New Timer(components)
        tmrCeas = New Timer(components)
        SuspendLayout()
        ' 
        ' lblOre
        ' 
        lblOre.AutoSize = True
        lblOre.Location = New Point(27, 38)
        lblOre.Name = "lblOre"
        lblOre.Size = New Size(26, 15)
        lblOre.TabIndex = 0
        lblOre.Text = "Ore"
        ' 
        ' lblMinute
        ' 
        lblMinute.AutoSize = True
        lblMinute.Location = New Point(132, 38)
        lblMinute.Name = "lblMinute"
        lblMinute.Size = New Size(45, 15)
        lblMinute.TabIndex = 1
        lblMinute.Text = "Minute"
        ' 
        ' lblSecunde
        ' 
        lblSecunde.AutoSize = True
        lblSecunde.Location = New Point(254, 38)
        lblSecunde.Name = "lblSecunde"
        lblSecunde.Size = New Size(52, 15)
        lblSecunde.TabIndex = 2
        lblSecunde.Text = "Secunde"
        ' 
        ' lblZecimi
        ' 
        lblZecimi.AutoSize = True
        lblZecimi.Location = New Point(359, 38)
        lblZecimi.Name = "lblZecimi"
        lblZecimi.Size = New Size(43, 15)
        lblZecimi.TabIndex = 3
        lblZecimi.Text = "Zecimi"
        ' 
        ' txtOra
        ' 
        txtOra.Location = New Point(27, 56)
        txtOra.Name = "txtOra"
        txtOra.Size = New Size(81, 23)
        txtOra.TabIndex = 4
        ' 
        ' txtZecimi
        ' 
        txtZecimi.Location = New Point(359, 56)
        txtZecimi.Name = "txtZecimi"
        txtZecimi.Size = New Size(81, 23)
        txtZecimi.TabIndex = 5
        ' 
        ' txtSecunde
        ' 
        txtSecunde.Location = New Point(254, 56)
        txtSecunde.Name = "txtSecunde"
        txtSecunde.Size = New Size(81, 23)
        txtSecunde.TabIndex = 6
        ' 
        ' txtMinute
        ' 
        txtMinute.Location = New Point(132, 56)
        txtMinute.Name = "txtMinute"
        txtMinute.Size = New Size(81, 23)
        txtMinute.TabIndex = 7
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(144, 118)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(175, 27)
        btnStart.TabIndex = 8
        btnStart.Text = "Pornire cronomteru"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(144, 160)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(175, 27)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' prgOre
        ' 
        prgOre.Location = New Point(61, 211)
        prgOre.Maximum = 24
        prgOre.Name = "prgOre"
        prgOre.Size = New Size(100, 23)
        prgOre.TabIndex = 11
        ' 
        ' prgSecunde
        ' 
        prgSecunde.Location = New Point(302, 211)
        prgSecunde.Maximum = 60
        prgSecunde.Name = "prgSecunde"
        prgSecunde.Size = New Size(100, 23)
        prgSecunde.TabIndex = 12
        ' 
        ' prgMinute
        ' 
        prgMinute.Location = New Point(185, 211)
        prgMinute.Maximum = 60
        prgMinute.Name = "prgMinute"
        prgMinute.Size = New Size(100, 23)
        prgMinute.TabIndex = 13
        ' 
        ' btnCeas
        ' 
        btnCeas.Location = New Point(163, 266)
        btnCeas.Name = "btnCeas"
        btnCeas.Size = New Size(143, 23)
        btnCeas.TabIndex = 14
        btnCeas.Text = "Afisare ceas"
        btnCeas.UseVisualStyleBackColor = True
        ' 
        ' tmrCronometru
        ' 
        ' 
        ' tmrCeas
        ' 
        tmrCeas.Interval = 1000
        ' 
        ' frmCronometru
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(471, 331)
        Controls.Add(btnCeas)
        Controls.Add(prgMinute)
        Controls.Add(prgSecunde)
        Controls.Add(prgOre)
        Controls.Add(btnReset)
        Controls.Add(btnStart)
        Controls.Add(txtMinute)
        Controls.Add(txtSecunde)
        Controls.Add(txtZecimi)
        Controls.Add(txtOra)
        Controls.Add(lblZecimi)
        Controls.Add(lblSecunde)
        Controls.Add(lblMinute)
        Controls.Add(lblOre)
        Name = "frmCronometru"
        Text = "Cronometru"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblOre As Label
    Friend WithEvents lblMinute As Label
    Friend WithEvents lblSecunde As Label
    Friend WithEvents lblZecimi As Label
    Friend WithEvents txtOra As TextBox
    Friend WithEvents txtZecimi As TextBox
    Friend WithEvents txtSecunde As TextBox
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents prgOre As ProgressBar
    Friend WithEvents prgSecunde As ProgressBar
    Friend WithEvents prgMinute As ProgressBar
    Friend WithEvents btnCeas As Button
    Friend WithEvents tmrCronometru As Timer
    Friend WithEvents tmrCeas As Timer

End Class
