Imports DTO
Imports BUS
Public Class frmThemKhoHang

    Private Sub frmThemKhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim quanli As DataTable = NhanVienBUS.LoadDSNhanVien()
        Dim lienhe As DataTable = NhanVienBUS.LoadDSNhanVien()

        Me.cboNguoiQuanLi.DataSource = quanli
        Me.cboNguoiLienHe.DataSource = lienhe

        Me.cboNguoiQuanLi.DisplayMember = "TenNhanVien"
        Me.cboNguoiLienHe.DisplayMember = "TenNhanVien"

        Me.cboNguoiQuanLi.ValueMember = "MaNhanVien"
        Me.cboNguoiLienHe.ValueMember = "MaNhanVien"

        Me.cboNguoiQuanLi.SelectedIndex = 0
        Me.cboNguoiLienHe.SelectedIndex = 0

    End Sub

    Private Sub cboNguoiLienHe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNguoiLienHe.SelectedIndexChanged
    End Sub

    Private Sub cboNguoiLienHe_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNguoiLienHe.SelectedValueChanged
        Dim nhanvien As NhanVienDTO = NhanVienBUS.ThongTinNhanVien(Me.cboNguoiLienHe.SelectedValue.ToString())
        Me.txtDienThoai.Text = nhanvien.DienThoai1
        Me.txtEmail.Text = nhanvien.Email1
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim khohang As New KhoHangDTO(Me.txtMaKhoHang.Text, Me.txtKiHieu.Text, Me.txtTenKhoHang.Text, _
                                      Me.cboNguoiQuanLi.SelectedValue.ToString(), _
                                      Me.cboNguoiLienHe.SelectedValue.ToString(), _
                                      Me.txtDiaChi.Text, Me.txtDienThoai.Text, Me.txtFax.Text, _
                                      Me.txtEmail.Text, Me.txtDienGiai.Text, True)
        If KhoHangBUS.ThemKhoHang(khohang) = True Then
            MessageBox.Show("Thêm thành công.")
        Else
            MessageBox.Show("Không thêm được.")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class