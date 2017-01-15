<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemNhomHang
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
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtGhiChu = New System.Windows.Forms.TextBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtMa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(101, 109)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(83, 28)
        Me.btnThem.TabIndex = 20
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Đóng"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtGhiChu
        '
        Me.txtGhiChu.Location = New System.Drawing.Point(73, 61)
        Me.txtGhiChu.Name = "txtGhiChu"
        Me.txtGhiChu.Size = New System.Drawing.Size(200, 20)
        Me.txtGhiChu.TabIndex = 16
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(73, 36)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(200, 20)
        Me.txtTen.TabIndex = 17
        '
        'txtMa
        '
        Me.txtMa.Location = New System.Drawing.Point(73, 8)
        Me.txtMa.Name = "txtMa"
        Me.txtMa.Size = New System.Drawing.Size(200, 20)
        Me.txtMa.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Ghi chú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Mã"
        '
        'frmThemNhomHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 145)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGhiChu)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtMa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThemNhomHang"
        Me.Text = "frmThemNhomHang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtGhiChu As System.Windows.Forms.TextBox
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents txtMa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
