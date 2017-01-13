Imports DTO
Imports BUS
Public Class frmThemHangHoa

    Private Sub frmThemHangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim donvi As DataTable = DonViTinhBUS.LoadDSDonViTinh()
        Dim nhacungcap As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Dim loaitien As DataTable = TyGiaBUS.LoadDSTyGia()
        Dim nhomhang As DataTable = NhomHangHoaBUS.LoadDSNhomHangHoa()

        Me.cboDonVi.DataSource = donvi
        Me.cboNhaCungCap.DataSource = nhacungcap
        Me.cboLoaiTien.DataSource = loaitien
        Me.cboNhomHang.DataSource = nhomhang

        Me.cboDonVi.DisplayMember = "TenDonVi"
        Me.cboLoaiTien.DisplayMember = "TenTienTe"
        Me.cboNhaCungCap.DisplayMember = "TenNhaCungCap"
        Me.cboNhomHang.DisplayMember = "TenNhomHang"

        Me.cboDonVi.ValueMember = "MaDonvi"
        Me.cboLoaiTien.ValueMember = "MaTienTe"
        Me.cboNhaCungCap.ValueMember = "MaNhaCungCap"
        Me.cboNhomHang.ValueMember = "MaNhomHang"

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class