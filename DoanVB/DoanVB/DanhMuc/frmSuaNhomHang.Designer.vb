<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaNhomHang
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
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.ckTinhTrang = New System.Windows.Forms.CheckBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTenNhomHang = New System.Windows.Forms.TextBox()
        Me.txtMaNhomHang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(100, 111)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(83, 28)
        Me.btnLuu.TabIndex = 11
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(189, 111)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(83, 28)
        Me.btnDong.TabIndex = 12
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'ckTinhTrang
        '
        Me.ckTinhTrang.AutoSize = True
        Me.ckTinhTrang.Location = New System.Drawing.Point(72, 89)
        Me.ckTinhTrang.Name = "ckTinhTrang"
        Me.ckTinhTrang.Size = New System.Drawing.Size(82, 17)
        Me.ckTinhTrang.TabIndex = 10
        Me.ckTinhTrang.Text = "Còn quản lý"
        Me.ckTinhTrang.UseVisualStyleBackColor = True
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(72, 63)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(200, 20)
        Me.txtGhiChu.TabIndex = 7
        '
        'txtTenNhomHang
        '
        Me.txtTenNhomHang.Location = New System.Drawing.Point(72, 38)
        Me.txtTenNhomHang.Name = "txtTenNhomHang"
        Me.txtTenNhomHang.Size = New System.Drawing.Size(200, 20)
        Me.txtTenNhomHang.TabIndex = 8
        '
        'txtMaNhomHang
        '
        Me.txtMaNhomHang.Location = New System.Drawing.Point(72, 10)
        Me.txtMaNhomHang.Name = "txtMaNhomHang"
        Me.txtMaNhomHang.Size = New System.Drawing.Size(200, 20)
        Me.txtMaNhomHang.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ghi chú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã"
        '
        'frmSuaNhomHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 145)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.ckTinhTrang)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTenNhomHang)
        Me.Controls.Add(Me.txtMaNhomHang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSuaNhomHang"
        Me.Text = "frmSuaNhomHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents ckTinhTrang As System.Windows.Forms.CheckBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents txtTenNhomHang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaNhomHang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
