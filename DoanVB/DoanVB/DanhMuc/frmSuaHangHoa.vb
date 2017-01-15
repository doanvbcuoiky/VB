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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hanghoa As New HangHoaDTO(Me.txtMaHangHoa.Text, Me.txtTenHangHoa.Text, Me.txtKieuHangHoa.Text, _
                                     Me.cboNhomHang.SelectedValue.ToString(), Me.txtMaVach.Text, _
                                     Me.cboDonVi.SelectedValue.ToString(), Me.txtXuatXu.Text, _
                                     System.Convert.ToInt32(Me.numTonKhoToiThieu.Value.ToString()), _
                                     System.Convert.ToInt32(Me.numTonKhoHienTai.Value.ToString()), _
                                     Me.cboNhaCungCap.SelectedValue.ToString(), _
                                     System.Convert.ToDouble(Me.numGiaMua.Value.ToString()), _
                                     System.Convert.ToDouble(Me.numGiaBanLe.Value.ToString()), _
                                     System.Convert.ToDouble(Me.numGiaBanSi.Value.ToString()), _
                                     Me.cboLoaiTien.SelectedValue.ToString(), "", Me.ckTinhTrang.Checked)
        If HangHoaBUS.SuaHangHoa(hanghoa) = True Then
            MessageBox.Show("Sửa thành công.")
            frmSuaHangHoa_Load(sender, e)
        Else
            MessageBox.Show("Không sửa đưuọc")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class