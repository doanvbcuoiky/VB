Imports DTO
Imports BUS
Public Class frmSuaKhoHang

    Private Sub frmSuaKhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim quanli As DataTable = NhanVienBUS.LoadDSNhanVien()
        Dim lienhe As DataTable = NhanVienBUS.LoadDSNhanVien()

        Me.cboNguoiQuanLi.DataSource = quanli
        Me.cboNguoiLienHe.DataSource = lienhe

        Me.cboNguoiQuanLi.DisplayMember = "TenNhanVien"
        Me.cboNguoiLienHe.DisplayMember = "TenNhanVien"

        Me.cboNguoiQuanLi.ValueMember = "MaNhanVien"
        Me.cboNguoiLienHe.ValueMember = "MaNhanVien"

        Dim khohang As KhoHangDTO = KhoHangBUS.ThongTinKhoHang(frmKhoHang.makhohang)

        Me.cboNguoiQuanLi.SelectedValue = khohang.NguoiQuanLi1
        Me.cboNguoiLienHe.SelectedValue = khohang.NguoiLienHe1
        Me.txtMaKhoHang.Text = khohang.MaKhoHang1
        Me.txtTenKhoHang.Text = khohang.TenKhoHang1
        Me.txtKiHieu.Text = khohang.KiHieu1
        Me.txtDienThoai.Text = khohang.DienThoai1
        Me.txtEmail.Text = khohang.Email1
        Me.txtFax.Text = khohang.Fax1
        Me.txtDiaChi.Text = khohang.DiaChi1
        Me.txtDienGiai.Text = khohang.DienGiai1
        Me.ckTinhTrang.Checked = khohang.TinhTrang1

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Kho hàng", "Sửa kho hàng: " & Me.txtMaKhoHang.Text.ToString())
        Dim khohang As New KhoHangDTO(Me.txtMaKhoHang.Text, Me.txtKiHieu.Text, Me.txtTenKhoHang.Text, _
                                      Me.cboNguoiQuanLi.SelectedValue.ToString(), _
                                      Me.cboNguoiLienHe.SelectedValue.ToString(), _
                                      Me.txtDiaChi.Text, Me.txtDienThoai.Text, Me.txtFax.Text, _
                                      Me.txtEmail.Text, Me.txtDienGiai.Text, Me.ckTinhTrang.Checked)
        If KhoHangBUS.SuaKhoHang(khohang) = True Then
            MessageBox.Show("Sửa thành công.")
            Me.Close()
        Else
            MessageBox.Show("Không sửa được.")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class