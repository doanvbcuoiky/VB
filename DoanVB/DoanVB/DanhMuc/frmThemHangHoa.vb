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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim hanghoa As New HangHoaDTO(Me.txtMaHangHoa.Text, Me.txtTenHangHoa.Text, Me.txtKieuHangHoa.Text, _
                                      Me.cboNhomHang.SelectedValue.ToString(), Me.txtMaVach.Text, _
                                      Me.cboDonVi.SelectedValue.ToString(), Me.txtXuatXu.Text, _
                                      System.Convert.ToInt32(Me.numTonKhoToiThieu.Value.ToString()), _
                                      System.Convert.ToInt32(Me.numTonKhoHienTai.Value.ToString()), _
                                      Me.cboNhaCungCap.SelectedValue.ToString(), _
                                      System.Convert.ToDouble(Me.numGiaMua.Value.ToString()), _
                                      System.Convert.ToDouble(Me.numGiaBanLe.Value.ToString()), _
                                      System.Convert.ToDouble(Me.numGiaBanSi.Value.ToString()), _
                                      Me.cboLoaiTien.SelectedValue.ToString(), "", True)
        If HangHoaBUS.ThemHangHoa(hanghoa) = True Then
            MessageBox.Show("Thêm thành công.")
        Else
            MessageBox.Show("Không thêm đưuọc")
        End If
    End Sub

    Private Sub btndong_Click(sender As Object, e As EventArgs) Handles btndong.Click
        Me.Close()
    End Sub
End Class