<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        lbl_1 = New Label()
        lbl_2 = New Label()
        txtId_pengguna = New TextBox()
        lbl_3 = New Label()
        txtKata_laluan = New TextBox()
        BtnLogin = New Button()
        SuspendLayout()
        ' 
        ' lbl_1
        ' 
        lbl_1.AutoSize = True
        lbl_1.Location = New Point(126, 40)
        lbl_1.Name = "lbl_1"
        lbl_1.Size = New Size(90, 20)
        lbl_1.TabIndex = 0
        lbl_1.Text = "LOG MASUK"
        ' 
        ' lbl_2
        ' 
        lbl_2.AutoSize = True
        lbl_2.Location = New Point(41, 86)
        lbl_2.Name = "lbl_2"
        lbl_2.Size = New Size(93, 20)
        lbl_2.TabIndex = 1
        lbl_2.Text = "ID Pengguna"
        ' 
        ' txtId_pengguna
        ' 
        txtId_pengguna.Location = New Point(140, 79)
        txtId_pengguna.Name = "txtId_pengguna"
        txtId_pengguna.Size = New Size(177, 27)
        txtId_pengguna.TabIndex = 2
        ' 
        ' lbl_3
        ' 
        lbl_3.AutoSize = True
        lbl_3.Location = New Point(41, 138)
        lbl_3.Name = "lbl_3"
        lbl_3.Size = New Size(86, 20)
        lbl_3.TabIndex = 3
        lbl_3.Text = "Kata Laluan"
        ' 
        ' txtKata_laluan
        ' 
        txtKata_laluan.Location = New Point(140, 131)
        txtKata_laluan.Name = "txtKata_laluan"
        txtKata_laluan.Size = New Size(177, 27)
        txtKata_laluan.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(126, 183)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(351, 229)
        Controls.Add(BtnLogin)
        Controls.Add(txtKata_laluan)
        Controls.Add(lbl_3)
        Controls.Add(txtId_pengguna)
        Controls.Add(lbl_2)
        Controls.Add(lbl_1)
        Name = "Form1"
        Text = "Log in"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents txtId_pengguna As TextBox
    Friend WithEvents lbl_3 As Label
    Friend WithEvents txtKata_laluan As TextBox
    Friend WithEvents BtnLogin As Button

End Class
