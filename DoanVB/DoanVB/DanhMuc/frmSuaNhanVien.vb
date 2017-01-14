Imports DTO
Imports BUS
Public Class frmSuaNhanVien

    Private Sub frmSuaNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bophan As DataTable = BoPhanBUS.LoadDSBoPhan()
        Dim quanli As DataTable = NhanVienBUS.LoadDSNhanVien()

        Me.cboBoPhan.DataSource = bophan
        Me.cboNguoiQuanLi.DataSource = quanli

        Me.cboBoPhan.DisplayMember = "TenBoPhan"
        Me.cboNguoiQuanLi.DisplayMember = "TenNhanVien"

        Me.cboBoPhan.ValueMember = "MaBoPhan"
        Me.cboNguoiQuanLi.ValueMember = "MaNhanVien"

        Dim nhanvien As NhanVienDTO = NhanVienBUS.ThongTinNhanVien(frmNhanVien.manhanvien)
        Me.txtMa.Text = nhanvien.MaNhanVien1
        Me.txtTen.Text = nhanvien.TenNhanVien1
        Me.txtChucVu.Text = nhanvien.ChucVu1
        Me.txtEmail.Text = nhanvien.Email1
        Me.txtDiaChi.Text = nhanvien.DiaChi1
        Me.txtDienThoai.Text = nhanvien.DienThoai1
        Me.ckTinhTrang.Checked = nhanvien.TinhTrang1

        Me.cboBoPhan.SelectedValue = nhanvien.BoPhan1
        Me.cboNguoiQuanLi.SelectedValue = nhanvien.NguoiQuanLi1


    End Sub
End Class