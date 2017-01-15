Imports DTO
Imports BUS
Public Class frmMuaHang

    Private ChiTietNhapHang As DataTable
    Private Sub frmMuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NCC As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Dim NCC2 As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Dim KhoHang As DataTable = KhoHangBUS.LoadDSKhoHang()
        Me.cboTenNCC.DataSource = NCC
        Me.cboMaNCC.DataSource = NCC2
        Me.cboKhoNhap.DataSource = KhoHang

        Dim NV As DataTable = NhanVienBUS.LoadDSNhanVien()
        Me.cboNhanVien.DataSource = NV

        Me.cboTenNCC.DisplayMember = "TenNhaCungCap"
        Me.cboTenNCC.ValueMember = "MaNhaCungCap"
        Me.cboTenNCC.SelectedIndex = 0


        Me.cboMaNCC.DisplayMember = "MaNhaCungCap"
        Me.cboMaNCC.ValueMember = "MaNhaCungCap"
        Me.cboMaNCC.SelectedIndex = 0

        Me.cboKhoNhap.DisplayMember = "TenKhoHang"
        Me.cboKhoNhap.ValueMember = "MaKhoHang"
        Me.cboKhoNhap.SelectedIndex = 0

        Me.cboNhanVien.DisplayMember = "TenNhanVien"
        Me.cboNhanVien.ValueMember = "MaNhanVien"
        Me.cboNhanVien.SelectedIndex = 0

        Me.txtDiaChi.DataBindings.Clear()
        Me.txtDiaChi.DataBindings.Add("Text", NCC, "DiaChi")
        Me.txtDienThoai.DataBindings.Clear()
        Me.txtDienThoai.DataBindings.Add("Text", NCC, "DienThoai")


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
        ChiTietNhapHang = New DataTable()

        Me.ChiTietNhapHang.Columns.Add("MaHangHoa")
        Me.ChiTietNhapHang.Columns.Add("TenHangHoa")
        Me.ChiTietNhapHang.Columns.Add("DonVi")
        Me.ChiTietNhapHang.Columns.Add("SoLuong")
        Me.ChiTietNhapHang.Columns.Add("DonGia")
        Me.ChiTietNhapHang.Columns.Add("ChietKhau")
        Me.ChiTietNhapHang.Columns.Add("ThanhTien")
        Me.GridControl1.DataSource = Me.ChiTietNhapHang
    End Sub

    Private Sub cboTenNCC_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTenNCC.SelectedValueChanged
        Try
            Me.cboMaNCC.SelectedValue = cboTenNCC.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboMaNCC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaNCC.SelectedIndexChanged
        Try
            Me.cboTenNCC.SelectedValue = cboMaNCC.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub cboMaHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaHang.SelectedIndexChanged
        
    End Sub

    Private Sub cboMaHang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMaHang.SelectedValueChanged
        Try
            Me.cboTenHang.SelectedValue = cboMaHang.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboTenHang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTenHang.SelectedValueChanged
        Try
            Me.cboMaHang.Text = cboTenHang.SelectedValue.ToString()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim n As Integer = Me.ChiTietNhapHang.Select().Count() - 1
        For i As Integer = 0 To n Step 1
            If Me.ChiTietNhapHang.Select()(i).Item("MaHangHoa").ToString() = Me.cboMaHang.Text.ToString() Then
                Return
            End If
        Next
        Dim dr As DataRow = Me.ChiTietNhapHang.NewRow()
        dr("MaHangHoa") = Me.cboMaHang.Text.ToString()
        dr("TenHangHoa") = Me.cboTenHang.Text.ToString()
        dr("DonVi") = Me.cboMaHang.SelectedValue.ToString()
        dr("SoLuong") = Me.numSoLuong.Value
        dr("DonGia") = 0
        dr("ChietKhau") = 0
        Me.ChiTietNhapHang.Rows.Add(dr)
        GridControl1.DataSource = Me.ChiTietNhapHang
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim n As Integer = Me.ChiTietNhapHang.Select().Count() - 1
        Dim phieunhap As New PhieuNhapHangDTO(Me.txtMaPhieu.Text, _
                                              Me.dtNgayNhap.Value, _
                                              Me.cboNhanVien.SelectedValue.ToString(), _
                                              Me.cboKhoNhap.SelectedValue.ToString(), _
                                              Me.dtHanThanhToan.Value, _
                                              Me.cboMaNCC.Text, _
                                              Me.txtHinhThucThanhToan.Text, _
                                              0, _
                                              False)
        If PhieuNhapHangBUS.ThemPhieuNhapHang(phieunhap) = True Then
            Dim TongTien As Double = 0
            For i As Integer = 0 To n Step 1
                Dim sl As Integer = System.Convert.ToInt32(Me.ChiTietNhapHang.Select()(0).Item("SoLuong").ToString())
                Dim dongia As Double = System.Convert.ToDouble(Me.ChiTietNhapHang.Select()(0).Item("DonGia").ToString())
                Dim ck As Double = System.Convert.ToDouble(Me.ChiTietNhapHang.Select()(0).Item("ChietKhau").ToString())
                Dim ma As String = Me.ChiTietNhapHang.Select()(0).Item("MaHangHoa").ToString()
                Dim dv As String = Me.ChiTietNhapHang.Select()(i).Item("DonVi").ToString()
                Dim ct As New ChiTietPhieuNhapHangDTO(Me.txtMaPhieu.Text, _
                                                      ma, _
                                                      dv, _
                                                      sl, dongia, ck)
                Dim kq As Boolean = ChiTietPhieuNhapHangBUS.ThemChiTietPhieuNhapHang(ct)
                'Cập nhật số lượng tồn kho hiện tại.
                HangHoaBUS.CapNhatSoLuong_Tang(ma, sl)
                'Tính tổng tiền
                TongTien += 1.0 * sl * dongia * (ck / 100.0)
            Next
            'Cập nhật tổng tiền cho phiếu nhập.
            PhieuNhapHangBUS.CapNhatTongTien(Me.txtMaPhieu.Text, TongTien)
            MessageBox.Show("Đã duyệt xong. Cập nhật tổng tiền.")
        Else
            MessageBox.Show("Không lưu đưuọc.")
        End If
        Me.ChiTietNhapHang.Clear()
        Me.ChiTietNhapHang = New DataTable()
        Me.ChiTietNhapHang.Columns.Add("MaHangHoa")
        Me.ChiTietNhapHang.Columns.Add("TenHangHoa")
        Me.ChiTietNhapHang.Columns.Add("DonVi")
        Me.ChiTietNhapHang.Columns.Add("SoLuong")
        Me.ChiTietNhapHang.Columns.Add("DonGia")
        Me.ChiTietNhapHang.Columns.Add("ChietKhau")
        Me.ChiTietNhapHang.Columns.Add("ThanhTien")
        Me.GridControl1.DataSource = Me.ChiTietNhapHang
    End Sub
End Class