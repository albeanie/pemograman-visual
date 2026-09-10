<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        lblRole = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        txtNIM = New TextBox()
        lblNim = New Label()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(313, 53)
        picImage.Name = "picImage"
        picImage.Size = New Size(156, 107)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(318, 213)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(151, 28)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(197, 221)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(39, 20)
        lblRole.TabIndex = 2
        lblRole.Text = "Role"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(318, 286)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(151, 27)
        txtNama.TabIndex = 4
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(195, 289)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 5
        lblNama.Text = "Nama"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(314, 342)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(154, 27)
        txtNIM.TabIndex = 6
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(196, 341)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(37, 20)
        lblNim.TabIndex = 7
        lblNim.Text = "Nim"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(342, 399)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(lblNim)
        Controls.Add(txtNIM)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Aplikasi pajak"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents btnLogin As Button

End Class
