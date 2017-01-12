Imports DTO
Imports BUS
Public Class frmSuaKhachHang

    Private Sub frmSuaKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtMa.Text = frmKhachHang.MaKhachHang
        Dim kh As KhachHangDTO = KhachHangBUS.ThongTinKhachHang(Me.txtMa.Text)
        'Load loại khách hàng
        'Load khu vực
        Dim loaikhachhang As DataTable = LoaiKhachHangBUS.LoadDSLoaiKhachHang()
        Dim khuvuc As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.cboLoai.DataSource = loaikhachhang
        Me.cboLoai.DisplayMember = "TenLoaiKhachHang"
        Me.cboLoai.ValueMember = "MaLoaiKhachHang"
        Me.cboKhuVuc.DataSource = khuvuc
        Me.cboKhuVuc.DisplayMember = "TenKhuVuc"
        Me.cboKhuVuc.ValueMember = "MaKhuVuc"
        'Đổ dữ liệu
        Me.txtLienHe.Text = kh.NguoiLienHe1
        Me.txtNganHang.Text = kh.NganHang1
        Me.txtSoTK.Text = kh.SoTaiKhoan1
        Me.txtFax.Text = kh.Fax1
        Me.txtEmail.Text = kh.Email1
        Me.txtDienThoai.Text = kh.DienThoai1
        Me.txtDiaChi.Text = kh.DiaChi1
        Me.txtThue.Text = kh.MaSoThue1
        Me.txtWebSite.Text = kh.Website1
        Me.txtTen.Text = kh.TenKhachHang1
        Me.cboKhuVuc.SelectedValue = kh.KhuVuc1
        Me.cboLoai.SelectedValue = kh.LoaiKhachHang1
        Me.ckTinhTrang.Checked = kh.TinhTrang1

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Dim dlgresult = MessageBox.Show("Lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            btnLuu_Click(sender, e)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim kh As New KhachHangDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtLienHe.Text, Me.txtDiaChi.Text, _
                                   Me.cboLoai.SelectedValue.ToString(), Me.cboKhuVuc.SelectedValue.ToString(), _
                                   Me.txtDienThoai.Text, Me.txtFax.Text, Me.txtEmail.Text, Me.txtWebSite.Text, _
                                   Me.txtThue.Text, Me.txtSoTK.Text, Me.txtNganHang.Text, Me.ckTinhTrang.Checked)
        Dim kq As Boolean = KhachHangBUS.SuaKhachHang(kh)
        If kq = True Then
            MessageBox.Show("Sửa thành công.")
            Me.Close()
        Else
            MessageBox.Show("Không Sửa đưuọc")
        End If
    End Sub
End Class