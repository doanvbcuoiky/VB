Imports DTO
Imports BUS
Public Class frmSuaHangHoa

    Private Sub frmSuaHangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim donvi As DataTable = DonViTinhBUS.LoadDSDonViTinh()
        Dim nhacungcap As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Dim loaitien As DataTable = TyGiaBUS.LoadDSTyGia()
        Dim nhomhang As DataTable = NhomHangHoaBUS.LoadDSNhomHangHoa()

        Me.cboDonVi.DataSource = donvi
        Me.cboNhaCungCap.DataSource = nhacungcap
        Me.cboLoaiTien.DataSource = loaitien
        Me.cboNhomHang.DataSource = nhomhang

        Me.cboDonVi.DisplayMember = "TenDonVi"
        Me.cboNhaCungCap.DisplayMember = "TenNhaCungCap"
        Me.cboLoaiTien.DisplayMember = "TenTienTe"
        Me.cboNhomHang.DisplayMember = "TenNhomHang"

        Me.cboDonVi.ValueMember = "MaDonVi"
        Me.cboNhaCungCap.ValueMember = "MaNhaCungCap"
        Me.cboLoaiTien.ValueMember = "MaTienTe"
        Me.cboNhomHang.ValueMember = "MaNhomHang"

        Dim hanghoa As HangHoaDTO = HangHoaBUS.ThongTinHangHoa(frmHangHoa.lblmahang)
        Me.cboDonVi.SelectedValue = hanghoa.DonVi1
        Me.cboNhaCungCap.SelectedValue = hanghoa.NhaCungCap1
        Me.cboLoaiTien.SelectedValue = hanghoa.LoaiTien1
        Me.cboNhomHang.SelectedValue = hanghoa.NhomHang1
        Me.txtMaHangHoa.Text = hanghoa.MaHangHoa1
        Me.txtTenHangHoa.Text = hanghoa.TenHangHoa1
        Me.txtKieuHangHoa.Text = hanghoa.KieuHangHoa1
        Me.txtMaVach.Text = hanghoa.MaVach1
        Me.txtXuatXu.Text = hanghoa.XuatXu1
        Me.ckTinhTrang.Checked = hanghoa.TinhTrang1

    End Sub
End Class