<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculDeducereTVA
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtValFTVA = New TextBox()
        Label2 = New Label()
        txtTVA = New TextBox()
        btnCalcul = New Button()
        Label3 = New Label()
        txtValCuTVA = New TextBox()
        GroupBox2 = New GroupBox()
        txtDValFTVA = New TextBox()
        Label6 = New Label()
        btnDeducere = New Button()
        txtDTVA = New TextBox()
        Label5 = New Label()
        txtDValCuTVA = New TextBox()
        Label4 = New Label()
        btnClear = New Button()
        btnClose = New Button()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(12, 29)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(306, 177)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Calcul TVA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 15)
        Label1.TabIndex = 1
        Label1.Text = "Valoare fara TVA"
        ' 
        ' txtValFTVA
        ' 
        txtValFTVA.Location = New Point(109, 69)
        txtValFTVA.Name = "txtValFTVA"
        txtValFTVA.Size = New Size(188, 23)
        txtValFTVA.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 3
        Label2.Text = "TVA"
        ' 
        ' txtTVA
        ' 
        txtTVA.Location = New Point(109, 112)
        txtTVA.Name = "txtTVA"
        txtTVA.Size = New Size(94, 23)
        txtTVA.TabIndex = 4
        ' 
        ' btnCalcul
        ' 
        btnCalcul.Location = New Point(222, 112)
        btnCalcul.Name = "btnCalcul"
        btnCalcul.Size = New Size(75, 23)
        btnCalcul.TabIndex = 5
        btnCalcul.Text = "Calcul TVA"
        btnCalcul.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 6
        Label3.Text = "Valoare cu TVA"
        ' 
        ' txtValCuTVA
        ' 
        txtValCuTVA.Location = New Point(109, 154)
        txtValCuTVA.Name = "txtValCuTVA"
        txtValCuTVA.Size = New Size(188, 23)
        txtValCuTVA.TabIndex = 7
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtDValFTVA)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(btnDeducere)
        GroupBox2.Controls.Add(txtDTVA)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(txtDValCuTVA)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(12, 212)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(306, 226)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Deducere TVA"
        ' 
        ' txtDValFTVA
        ' 
        txtDValFTVA.Location = New Point(95, 124)
        txtDValFTVA.Name = "txtDValFTVA"
        txtDValFTVA.Size = New Size(188, 23)
        txtDValFTVA.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(0, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 9
        Label6.Text = "Valoare fara TVA"
        ' 
        ' btnDeducere
        ' 
        btnDeducere.Location = New Point(210, 79)
        btnDeducere.Name = "btnDeducere"
        btnDeducere.Size = New Size(75, 23)
        btnDeducere.TabIndex = 12
        btnDeducere.Text = "Deducere TVA"
        btnDeducere.UseVisualStyleBackColor = True
        ' 
        ' txtDTVA
        ' 
        txtDTVA.Location = New Point(97, 80)
        txtDTVA.Name = "txtDTVA"
        txtDTVA.Size = New Size(94, 23)
        txtDTVA.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(0, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(27, 15)
        Label5.TabIndex = 10
        Label5.Text = "TVA"
        ' 
        ' txtDValCuTVA
        ' 
        txtDValCuTVA.Location = New Point(97, 39)
        txtDValCuTVA.Name = "txtDValCuTVA"
        txtDValCuTVA.Size = New Size(188, 23)
        txtDValCuTVA.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 15)
        Label4.TabIndex = 9
        Label4.Text = "Valoare cu TVA"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(12, 394)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 9
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(220, 394)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 10
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmCalculDeducereTVA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 450)
        Controls.Add(btnClose)
        Controls.Add(btnClear)
        Controls.Add(GroupBox2)
        Controls.Add(txtValCuTVA)
        Controls.Add(Label3)
        Controls.Add(btnCalcul)
        Controls.Add(txtTVA)
        Controls.Add(Label2)
        Controls.Add(txtValFTVA)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "frmCalculDeducereTVA"
        Text = "Calcul & Deducere TVA"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValFTVA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTVA As TextBox
    Friend WithEvents btnCalcul As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValCuTVA As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDTVA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDValCuTVA As TextBox
    Friend WithEvents txtDValFTVA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDeducere As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button

End Class
