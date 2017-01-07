<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemKhuVuc
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
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.ckTinhTrang = New System.Windows.Forms.CheckBox()
        Me.btbLuu = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên"
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(62, 21)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(210, 20)
        Me.txtMa.TabIndex = 2
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(62, 51)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(210, 20)
        Me.txtTen.TabIndex = 3
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(62, 85)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(210, 20)
        Me.txtGhiChu.TabIndex = 4
        '
        'ckTinhTrang
        '
        Me.ckTinhTrang.AutoSize = True
        Me.ckTinhTrang.Location = New System.Drawing.Point(62, 111)
        Me.ckTinhTrang.Name = "ckTinhTrang"
        Me.ckTinhTrang.Size = New System.Drawing.Size(81, 17)
        Me.ckTinhTrang.TabIndex = 5
        Me.ckTinhTrang.Text = "Còn quản lí"
        Me.ckTinhTrang.UseVisualStyleBackColor = True
        '
        'btbLuu
        '
        Me.btbLuu.Location = New System.Drawing.Point(104, 134)
        Me.btbLuu.Name = "btbLuu"
        Me.btbLuu.Size = New System.Drawing.Size(75, 23)
        Me.btbLuu.TabIndex = 6
        Me.btbLuu.Text = "Lưu"
        Me.btbLuu.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(197, 134)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(75, 23)
        Me.btnDong.TabIndex = 7
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ghi chú"
        '
        'frmThemKhuVuc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 172)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btbLuu)
        Me.Controls.Add(Me.ckTinhTrang)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemKhuVuc"
        Me.Text = "frmThemKhuVuc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents ckTinhTrang As System.Windows.Forms.CheckBox
    Friend WithEvents btbLuu As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
