<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThemHangHoa
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
        Me.btndong = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMaHangHoa = New System.Windows.Forms.TextBox()
        Me.txtTenHangHoa = New System.Windows.Forms.TextBox()
        Me.txtKieuHangHoa = New System.Windows.Forms.TextBox()
        Me.txtMaVach = New System.Windows.Forms.TextBox()
        Me.txtXuatXu = New System.Windows.Forms.TextBox()
        Me.cboNhomHang = New System.Windows.Forms.ComboBox()
        Me.cboDonVi = New System.Windows.Forms.ComboBox()
        Me.cboNhaCungCap = New System.Windows.Forms.ComboBox()
        Me.cboLoaiTien = New System.Windows.Forms.ComboBox()
        Me.numTonKhoToiThieu = New System.Windows.Forms.NumericUpDown()
        Me.numTonKhoHienTai = New System.Windows.Forms.NumericUpDown()
        Me.numGiaBanLe = New System.Windows.Forms.NumericUpDown()
        Me.numGiaBanSi = New System.Windows.Forms.NumericUpDown()
        Me.numGiaMua = New System.Windows.Forms.NumericUpDown()
        CType(Me.numTonKhoToiThieu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTonKhoHienTai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGiaBanLe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGiaBanSi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGiaMua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndong
        '
        Me.btndong.Location = New System.Drawing.Point(394, 205)
        Me.btndong.Name = "btndong"
        Me.btndong.Size = New System.Drawing.Size(82, 23)
        Me.btndong.TabIndex = 2
        Me.btndong.Text = "Đóng"
        Me.btndong.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(274, 205)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(82, 23)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã hàng hóa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên hàng hóa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kiểu hàng hóa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nhóm hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mã vạch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Đơn vị"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Xuất xứ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tồn kho tối thiểu"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Tồn kho hiện tại"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(254, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nhà cung cấp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Giá mua"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(255, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Giá bản lẻ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(255, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Giá bán sĩ"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(255, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Loại tiền"
        '
        'txtMaHangHoa
        '
        Me.txtMaHangHoa.Location = New System.Drawing.Point(118, 14)
        Me.txtMaHangHoa.Name = "txtMaHangHoa"
        Me.txtMaHangHoa.Size = New System.Drawing.Size(120, 20)
        Me.txtMaHangHoa.TabIndex = 18
        '
        'txtTenHangHoa
        '
        Me.txtTenHangHoa.Location = New System.Drawing.Point(118, 46)
        Me.txtTenHangHoa.Name = "txtTenHangHoa"
        Me.txtTenHangHoa.Size = New System.Drawing.Size(120, 20)
        Me.txtTenHangHoa.TabIndex = 19
        '
        'txtKieuHangHoa
        '
        Me.txtKieuHangHoa.Location = New System.Drawing.Point(118, 77)
        Me.txtKieuHangHoa.Name = "txtKieuHangHoa"
        Me.txtKieuHangHoa.Size = New System.Drawing.Size(120, 20)
        Me.txtKieuHangHoa.TabIndex = 21
        '
        'txtMaVach
        '
        Me.txtMaVach.Location = New System.Drawing.Point(118, 105)
        Me.txtMaVach.Name = "txtMaVach"
        Me.txtMaVach.Size = New System.Drawing.Size(120, 20)
        Me.txtMaVach.TabIndex = 22
        '
        'txtXuatXu
        '
        Me.txtXuatXu.Location = New System.Drawing.Point(118, 154)
        Me.txtXuatXu.Name = "txtXuatXu"
        Me.txtXuatXu.Size = New System.Drawing.Size(120, 20)
        Me.txtXuatXu.TabIndex = 23
        '
        'cboNhomHang
        '
        Me.cboNhomHang.FormattingEnabled = True
        Me.cboNhomHang.Location = New System.Drawing.Point(335, 44)
        Me.cboNhomHang.Name = "cboNhomHang"
        Me.cboNhomHang.Size = New System.Drawing.Size(142, 21)
        Me.cboNhomHang.TabIndex = 30
        '
        'cboDonVi
        '
        Me.cboDonVi.FormattingEnabled = True
        Me.cboDonVi.Location = New System.Drawing.Point(118, 130)
        Me.cboDonVi.Name = "cboDonVi"
        Me.cboDonVi.Size = New System.Drawing.Size(121, 21)
        Me.cboDonVi.TabIndex = 31
        '
        'cboNhaCungCap
        '
        Me.cboNhaCungCap.FormattingEnabled = True
        Me.cboNhaCungCap.Location = New System.Drawing.Point(335, 12)
        Me.cboNhaCungCap.Name = "cboNhaCungCap"
        Me.cboNhaCungCap.Size = New System.Drawing.Size(142, 21)
        Me.cboNhaCungCap.TabIndex = 32
        '
        'cboLoaiTien
        '
        Me.cboLoaiTien.FormattingEnabled = True
        Me.cboLoaiTien.Location = New System.Drawing.Point(335, 155)
        Me.cboLoaiTien.Name = "cboLoaiTien"
        Me.cboLoaiTien.Size = New System.Drawing.Size(142, 21)
        Me.cboLoaiTien.TabIndex = 33
        '
        'numTonKhoToiThieu
        '
        Me.numTonKhoToiThieu.Location = New System.Drawing.Point(118, 182)
        Me.numTonKhoToiThieu.Name = "numTonKhoToiThieu"
        Me.numTonKhoToiThieu.Size = New System.Drawing.Size(120, 20)
        Me.numTonKhoToiThieu.TabIndex = 34
        '
        'numTonKhoHienTai
        '
        Me.numTonKhoHienTai.Location = New System.Drawing.Point(118, 208)
        Me.numTonKhoHienTai.Name = "numTonKhoHienTai"
        Me.numTonKhoHienTai.Size = New System.Drawing.Size(120, 20)
        Me.numTonKhoHienTai.TabIndex = 35
        '
        'numGiaBanLe
        '
        Me.numGiaBanLe.DecimalPlaces = 5
        Me.numGiaBanLe.Location = New System.Drawing.Point(335, 106)
        Me.numGiaBanLe.Name = "numGiaBanLe"
        Me.numGiaBanLe.Size = New System.Drawing.Size(141, 20)
        Me.numGiaBanLe.TabIndex = 36
        '
        'numGiaBanSi
        '
        Me.numGiaBanSi.DecimalPlaces = 5
        Me.numGiaBanSi.Location = New System.Drawing.Point(335, 131)
        Me.numGiaBanSi.Name = "numGiaBanSi"
        Me.numGiaBanSi.Size = New System.Drawing.Size(141, 20)
        Me.numGiaBanSi.TabIndex = 37
        '
        'numGiaMua
        '
        Me.numGiaMua.DecimalPlaces = 5
        Me.numGiaMua.Location = New System.Drawing.Point(335, 76)
        Me.numGiaMua.Name = "numGiaMua"
        Me.numGiaMua.Size = New System.Drawing.Size(141, 20)
        Me.numGiaMua.TabIndex = 38
        '
        'frmThemHangHoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 257)
        Me.Controls.Add(Me.numGiaMua)
        Me.Controls.Add(Me.numGiaBanSi)
        Me.Controls.Add(Me.numGiaBanLe)
        Me.Controls.Add(Me.numTonKhoHienTai)
        Me.Controls.Add(Me.numTonKhoToiThieu)
        Me.Controls.Add(Me.cboLoaiTien)
        Me.Controls.Add(Me.cboNhaCungCap)
        Me.Controls.Add(Me.cboDonVi)
        Me.Controls.Add(Me.cboNhomHang)
        Me.Controls.Add(Me.txtXuatXu)
        Me.Controls.Add(Me.txtMaVach)
        Me.Controls.Add(Me.txtKieuHangHoa)
        Me.Controls.Add(Me.txtTenHangHoa)
        Me.Controls.Add(Me.txtMaHangHoa)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btndong)
        Me.Name = "frmThemHangHoa"
        Me.Text = "frmThemHangHoa"
        CType(Me.numTonKhoToiThieu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTonKhoHienTai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGiaBanLe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGiaBanSi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGiaMua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndong As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMaHangHoa As System.Windows.Forms.TextBox
    Friend WithEvents txtTenHangHoa As System.Windows.Forms.TextBox
    Friend WithEvents txtKieuHangHoa As System.Windows.Forms.TextBox
    Friend WithEvents txtMaVach As System.Windows.Forms.TextBox
    Friend WithEvents txtXuatXu As System.Windows.Forms.TextBox
    Friend WithEvents cboNhomHang As System.Windows.Forms.ComboBox
    Friend WithEvents cboDonVi As System.Windows.Forms.ComboBox
    Friend WithEvents cboNhaCungCap As System.Windows.Forms.ComboBox
    Friend WithEvents cboLoaiTien As System.Windows.Forms.ComboBox
    Friend WithEvents numTonKhoToiThieu As System.Windows.Forms.NumericUpDown
    Friend WithEvents numTonKhoHienTai As System.Windows.Forms.NumericUpDown
    Friend WithEvents numGiaBanLe As System.Windows.Forms.NumericUpDown
    Friend WithEvents numGiaBanSi As System.Windows.Forms.NumericUpDown
    Friend WithEvents numGiaMua As System.Windows.Forms.NumericUpDown
End Class
