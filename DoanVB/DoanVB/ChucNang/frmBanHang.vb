Imports DTO
Imports BUS
Public Class frmBanHang

    Private chitietbanhang As DataTable
    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboTenHang_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboMaHang_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboMaHang_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboMaNCC_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboTenNCC_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KH As DataTable = KhachHangBUS.LoadDSKhachHang()
        Dim KH2 As DataTable = KhachHangBUS.LoadDSKhachHang()
        Dim KhoHang As DataTable = KhoHangBUS.LoadDSKhoHang()
        Dim NV As DataTable = NhanVienBUS.LoadDSNhanVien()

        Me.cboTenKH.DataSource = KH
        Me.cboMaKh.DataSource = KH2
        Me.cboKhoXuat.DataSource = KhoHang
        Me.cboNhanVien.DataSource = NV

        Me.cboTenKH.DisplayMember = "TenKhachHang"
        Me.cboTenKH.ValueMember = "MaKhachHang"
        Me.cboTenKH.SelectedIndex = 0


        Me.cboMaKh.DisplayMember = "MaKhachHang"
        Me.cboMaKh.ValueMember = "MaKhachHang"
        Me.cboMaKh.SelectedIndex = 0

        Me.cboKhoXuat.DisplayMember = "TenKhoHang"
        Me.cboKhoXuat.ValueMember = "MaKhoHang"
        Me.cboKhoXuat.SelectedIndex = 0

        Me.cboNhanVien.DisplayMember = "TenNhanVien"
        Me.cboNhanVien.ValueMember = "MaNhanVien"
        Me.cboNhanVien.SelectedIndex = 0

        Me.txtDiaChi.DataBindings.Clear()
        Me.txtDiaChi.DataBindings.Add("Text", KH, "DiaChi")
        Me.txtDienThoai.DataBindings.Clear()
        Me.txtDienThoai.DataBindings.Add("Text", KH, "DienThoai")


        Dim hanghoa As DataTable = HangHoaBUS.LoadDSHangHoa()
        Dim hanghoa2 As DataTable = HangHoaBUS.LoadDSHangHoa()

        Me.cboMaHang.DataSource = hanghoa
        Me.cboTenHang.DataSource = hanghoa2

        Me.cboMaHang.DisplayMember = "MaHangHoa"
        Me.cboMaHang.ValueMember = "DonVi"
        Me.cboTenHang.DisplayMember = "TenHangHoa"
        Me.cboTenHang.ValueMember = "MaHangHoa"

        Me.cboMaHang.SelectedIndex = 0
        Me.cboMaHang.SelectedIndex = 0

        'khởi tạo chitietphieunhap
        Me.chitietbanhang = New DataTable()

        Me.chitietbanhang.Columns.Add("MaHangHoa")
        Me.chitietbanhang.Columns.Add("TenHangHoa")
        Me.chitietbanhang.Columns.Add("DonVi")
        Me.chitietbanhang.Columns.Add("SoLuong")
        Me.chitietbanhang.Columns.Add("DonGia")
        Me.chitietbanhang.Columns.Add("ChietKhau")
        Me.GridControl1.DataSource = Me.chitietbanhang
    End Sub

    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim n As Integer = Me.chitietbanhang.Select().Count() - 1
        For i As Integer = 0 To n Step 1
            If Me.chitietbanhang.Select()(i).Item("MaHangHoa").ToString() = Me.cboMaHang.Text.ToString() Then
                Return
            End If
        Next
        Dim dr As DataRow = Me.chitietbanhang.NewRow()
        dr("MaHangHoa") = Me.cboMaHang.Text.ToString()
        dr("TenHangHoa") = Me.cboTenHang.Text.ToString()
        dr("DonVi") = Me.cboMaHang.SelectedValue.ToString()
        dr("SoLuong") = Me.numSoLuong.Value
        dr("DonGia") = 0
        dr("ChietKhau") = 0
        Me.chitietbanhang.Rows.Add(dr)
        GridControl1.DataSource = Me.chitietbanhang
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim n As Integer = Me.chitietbanhang.Select().Count() - 1
        Dim phieuban As New PhieuBanHangDTO(Me.txtMaPhieu.Text, _
                                             Me.cboMaKh.Text.ToString(), _
                                             Me.dtNgayNhap.Value, _
                                             Me.cboNhanVien.SelectedValue.ToString(), _
                                             Me.cboKhoXuat.SelectedValue.ToString(), _
                                             Me.txtHinhThucThanhToan.Text, _
                                             0, _
                                             False)
        If PhieuBanHangBUS.ThemPhieuBanHang(phieuban) = True Then
            Dim TongTien As Double = 0
            For i As Integer = 0 To n Step 1
                Dim sl As Integer = System.Convert.ToInt32(Me.chitietbanhang.Select()(0).Item("SoLuong").ToString())
                Dim dongia As Double = System.Convert.ToDouble(Me.chitietbanhang.Select()(0).Item("DonGia").ToString())
                Dim ck As Double = System.Convert.ToDouble(Me.chitietbanhang.Select()(0).Item("ChietKhau").ToString())
                Dim ma As String = Me.chitietbanhang.Select()(0).Item("MaHangHoa").ToString()
                Dim dv As String = Me.chitietbanhang.Select()(i).Item("DonVi").ToString()
                Dim ct As New ChiTietPhieuBanHangDTO(Me.txtMaPhieu.Text, _
                                                      ma, _
                                                      dv, _
                                                      sl, dongia, ck)
                Dim kq As Boolean = ChiTietPhieuBanHangBUS.ThemChiTietPhieuBanHang(ct)
                'Cập nhật số lượng tồn kho hiện tại.
                HangHoaBUS.CapNhatSoLuong_Giam(ma, sl)
                'Tính tổng tiền
                TongTien += 1.0 * sl * dongia * (ck / 100.0)
            Next
            'Cập nhật tổng tiền cho phiếu nhập.
            PhieuBanHangBUS.CapNhatTongTien(Me.txtMaPhieu.Text, TongTien)
            MessageBox.Show("Đã lưu hóa đơn.")
        Else
            MessageBox.Show("Không lưu đưuọc.")
        End If
        Me.chitietbanhang.Clear()
        Me.chitietbanhang = New DataTable()
        Me.chitietbanhang.Columns.Add("MaHangHoa")
        Me.chitietbanhang.Columns.Add("TenHangHoa")
        Me.chitietbanhang.Columns.Add("DonVi")
        Me.chitietbanhang.Columns.Add("SoLuong")
        Me.chitietbanhang.Columns.Add("DonGia")
        Me.chitietbanhang.Columns.Add("ChietKhau")
        Me.GridControl1.DataSource = Me.chitietbanhang
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        frmBanHang_Load(sender, e)
    End Sub

    Private Sub cboTenKH_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTenKH.SelectedValueChanged
        Try
            Me.cboMaKh.SelectedValue = cboTenKH.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboMaKh_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMaKh.SelectedValueChanged

    End Sub

    Private Sub cboMaKh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaKh.SelectedIndexChanged
        Try
            Me.cboTenKH.SelectedValue = cboMaKh.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboMaHang_SelectedValueChanged_1(sender As Object, e As EventArgs) Handles cboMaHang.SelectedValueChanged
        Try
            Me.cboTenHang.SelectedValue = cboMaHang.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboTenHang_SelectedValueChanged_1(sender As Object, e As EventArgs) Handles cboTenHang.SelectedValueChanged
        Try
            Me.cboMaHang.Text = cboTenHang.SelectedValue.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class