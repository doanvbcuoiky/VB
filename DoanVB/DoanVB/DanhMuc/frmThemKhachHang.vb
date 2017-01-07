Imports BUS
Imports DTO
Public Class frmThemKhachHang

    Private Sub frmThemKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loaikhachhang As DataTable = LoaiKhachHangBUS.LoadDSLoaiKhachHang()
        Dim khuvuc As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.cboLoai.DataSource = loaikhachhang
        Me.cboLoai.DisplayMember = "TenLoaiKhachHang"
        Me.cboLoai.ValueMember = "MaLoaiKhachHang"
        Me.cboKhuVuc.DataSource = khuvuc
        Me.cboKhuVuc.DisplayMember = "TenKhuVuc"
        Me.cboKhuVuc.ValueMember = "MaKhuVuc"
        Me.ckTinhTrang.Checked = True
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim kh As New KhachHangDTO(Me.txtMa.Text, Me.txtTen.Text, Me.txtLienHe.Text, Me.txtDiaChi.Text, _
                                   Me.cboLoai.SelectedValue.ToString(), Me.cboKhuVuc.SelectedValue.ToString(), _
                                   Me.txtDienThoai.Text, Me.txtFax.Text, Me.txtEmail.Text, Me.txtWebSite.Text, _
                                   Me.txtThue.Text, Me.txtSoTK.Text, Me.txtNganHang.Text, Me.ckTinhTrang.Checked)
        Dim kq As Boolean = KhachHangBUS.ThemKhachHang(kh)
        If kq = True Then
            MessageBox.Show("Thêm thành công.")
        Else
            MessageBox.Show("Không thêm đưuọc")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class