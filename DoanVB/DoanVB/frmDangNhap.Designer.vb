<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckGhiNho = New System.Windows.Forms.CheckBox()
        Me.cboTaiKhoan = New System.Windows.Forms.ComboBox()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnKetThuc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ĐĂNG NHẬP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tài khoản"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật khẩu"
        '
        'ckGhiNho
        '
        Me.ckGhiNho.AutoSize = True
        Me.ckGhiNho.Location = New System.Drawing.Point(97, 134)
        Me.ckGhiNho.Name = "ckGhiNho"
        Me.ckGhiNho.Size = New System.Drawing.Size(155, 17)
        Me.ckGhiNho.TabIndex = 3
        Me.ckGhiNho.Text = "Nhớ tài khoản và mật khẩu"
        Me.ckGhiNho.UseVisualStyleBackColor = True
        '
        'cboTaiKhoan
        '
        Me.cboTaiKhoan.FormattingEnabled = True
        Me.cboTaiKhoan.Location = New System.Drawing.Point(97, 67)
        Me.cboTaiKhoan.Name = "cboTaiKhoan"
        Me.cboTaiKhoan.Size = New System.Drawing.Size(161, 21)
        Me.cboTaiKhoan.TabIndex = 4
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(97, 98)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(161, 20)
        Me.txtMatKhau.TabIndex = 5
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(97, 167)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(75, 23)
        Me.btnDangNhap.TabIndex = 6
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnKetThuc
        '
        Me.btnKetThuc.Location = New System.Drawing.Point(183, 167)
        Me.btnKetThuc.Name = "btnKetThuc"
        Me.btnKetThuc.Size = New System.Drawing.Size(75, 23)
        Me.btnKetThuc.TabIndex = 7
        Me.btnKetThuc.Text = "Kết thúc"
        Me.btnKetThuc.UseVisualStyleBackColor = True
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 207)
        Me.Controls.Add(Me.btnKetThuc)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.cboTaiKhoan)
        Me.Controls.Add(Me.ckGhiNho)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDangNhap"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmDangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckGhiNho As System.Windows.Forms.CheckBox
    Friend WithEvents cboTaiKhoan As System.Windows.Forms.ComboBox
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnKetThuc As System.Windows.Forms.Button
End Class
