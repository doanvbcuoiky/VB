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
        Dim n As Integer = Me.ChiTietNhapHang.Select().Count()
        Dim phieunhap As New PhieuNhapHangDTO("maphieu", _
                                              "ngayfnhap", _
                                              "nhanvien", _
                                              "kho", _
                                              "hanthanhtoan", _
                                              "nhacungcap", _
                                              "hinhthuc", _
                                              "tongtien", _
                                              "tinhtrang")
        If PhieuNhapHangBUS.ThemPhieuNhapHang(phieunhap) = True Then
            For i As Integer = 0 To n Step 1
                Dim ct As New ChiTietPhieuNhapHangDTO("ma", _
                                                      "Mahang", _
                                                      "Donvi", _
                                                      "soluong", _
                                                      "dongia", _
                                                      "chietkhau")
                ChiTietPhieuNhapHangBUS.ThemChiTietPhieuNhapHang(ct)
            Next
        Else
            MessageBox.Show("Không lưu đưuọc.")
        End If
        
    End Sub
End Class