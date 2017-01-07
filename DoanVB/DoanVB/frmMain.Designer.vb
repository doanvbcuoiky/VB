Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbtKetThuc = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtThongTin = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtPhanQuyen = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtDoiMatKhau = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtNhatKyHeThong = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtSaoLuu = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtPhucHoi = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtSuaChua = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtKetChuyen = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtnNhapDanhMucTuExel = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtKhuVuc = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtKhachHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtNhaCungCap = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtKhoHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtDonViTinh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtNhomHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtHangHoa = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtInMaVach = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtTyGia = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtBoPhan = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtNhanVien = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtMuaHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtBanHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtTonKho = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtChuyenKho = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtNhapSoDuDauKy = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtThuTien = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtTraTien = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtBaoCaoKhoHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtBaoCaoBanHang = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtChungTu = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtHoTroTrucTuyen = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtHuongDanSuDung = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtLienHe = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtDangKy = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtThongTin1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtCapNhat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbtKetThuc, Me.bbtThongTin, Me.bbtPhanQuyen, Me.bbtDoiMatKhau, Me.bbtNhatKyHeThong, Me.bbtSaoLuu, Me.bbtPhucHoi, Me.bbtSuaChua, Me.bbtKetChuyen, Me.bbtnNhapDanhMucTuExel, Me.bbtKhuVuc, Me.bbtKhachHang, Me.bbtNhaCungCap, Me.bbtKhoHang, Me.bbtDonViTinh, Me.bbtNhomHang, Me.bbtHangHoa, Me.bbtInMaVach, Me.bbtTyGia, Me.bbtBoPhan, Me.bbtNhanVien, Me.bbtMuaHang, Me.bbtBanHang, Me.bbtTonKho, Me.bbtChuyenKho, Me.bbtNhapSoDuDauKy, Me.bbtThuTien, Me.bbtTraTien, Me.bbtBaoCaoKhoHang, Me.bbtBaoCaoBanHang, Me.bbtChungTu, Me.bbtHoTroTrucTuyen, Me.bbtHuongDanSuDung, Me.bbtLienHe, Me.bbtDangKy, Me.bbtThongTin1, Me.bbtCapNhat, Me.BarSubItem1})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 39
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(758, 143)
        '
        'bbtKetThuc
        '
        Me.bbtKetThuc.Caption = "Kết Thúc"
        Me.bbtKetThuc.Glyph = CType(resources.GetObject("bbtKetThuc.Glyph"), System.Drawing.Image)
        Me.bbtKetThuc.Id = 1
        Me.bbtKetThuc.LargeGlyph = CType(resources.GetObject("bbtKetThuc.LargeGlyph"), System.Drawing.Image)
        Me.bbtKetThuc.Name = "bbtKetThuc"
        '
        'bbtThongTin
        '
        Me.bbtThongTin.Caption = "Thông Tin"
        Me.bbtThongTin.Glyph = CType(resources.GetObject("bbtThongTin.Glyph"), System.Drawing.Image)
        Me.bbtThongTin.Id = 2
        Me.bbtThongTin.LargeGlyph = CType(resources.GetObject("bbtThongTin.LargeGlyph"), System.Drawing.Image)
        Me.bbtThongTin.Name = "bbtThongTin"
        '
        'bbtPhanQuyen
        '
        Me.bbtPhanQuyen.Caption = "Phân Quyền"
        Me.bbtPhanQuyen.Glyph = CType(resources.GetObject("bbtPhanQuyen.Glyph"), System.Drawing.Image)
        Me.bbtPhanQuyen.Id = 3
        Me.bbtPhanQuyen.LargeGlyph = CType(resources.GetObject("bbtPhanQuyen.LargeGlyph"), System.Drawing.Image)
        Me.bbtPhanQuyen.Name = "bbtPhanQuyen"
        '
        'bbtDoiMatKhau
        '
        Me.bbtDoiMatKhau.Caption = "Đổi Mật Khẩu"
        Me.bbtDoiMatKhau.Glyph = CType(resources.GetObject("bbtDoiMatKhau.Glyph"), System.Drawing.Image)
        Me.bbtDoiMatKhau.Id = 4
        Me.bbtDoiMatKhau.LargeGlyph = CType(resources.GetObject("bbtDoiMatKhau.LargeGlyph"), System.Drawing.Image)
        Me.bbtDoiMatKhau.Name = "bbtDoiMatKhau"
        '
        'bbtNhatKyHeThong
        '
        Me.bbtNhatKyHeThong.Caption = "Nhật Ký Hệ Thống"
        Me.bbtNhatKyHeThong.Glyph = CType(resources.GetObject("bbtNhatKyHeThong.Glyph"), System.Drawing.Image)
        Me.bbtNhatKyHeThong.Id = 5
        Me.bbtNhatKyHeThong.LargeGlyph = CType(resources.GetObject("bbtNhatKyHeThong.LargeGlyph"), System.Drawing.Image)
        Me.bbtNhatKyHeThong.Name = "bbtNhatKyHeThong"
        '
        'bbtSaoLuu
        '
        Me.bbtSaoLuu.Caption = "Sao Lưu"
        Me.bbtSaoLuu.Glyph = CType(resources.GetObject("bbtSaoLuu.Glyph"), System.Drawing.Image)
        Me.bbtSaoLuu.Id = 6
        Me.bbtSaoLuu.LargeGlyph = CType(resources.GetObject("bbtSaoLuu.LargeGlyph"), System.Drawing.Image)
        Me.bbtSaoLuu.Name = "bbtSaoLuu"
        '
        'bbtPhucHoi
        '
        Me.bbtPhucHoi.Caption = "Phục Hồi"
        Me.bbtPhucHoi.Glyph = CType(resources.GetObject("bbtPhucHoi.Glyph"), System.Drawing.Image)
        Me.bbtPhucHoi.Id = 7
        Me.bbtPhucHoi.LargeGlyph = CType(resources.GetObject("bbtPhucHoi.LargeGlyph"), System.Drawing.Image)
        Me.bbtPhucHoi.Name = "bbtPhucHoi"
        '
        'bbtSuaChua
        '
        Me.bbtSuaChua.Caption = "Sửa Chữa"
        Me.bbtSuaChua.Glyph = CType(resources.GetObject("bbtSuaChua.Glyph"), System.Drawing.Image)
        Me.bbtSuaChua.Id = 8
        Me.bbtSuaChua.LargeGlyph = CType(resources.GetObject("bbtSuaChua.LargeGlyph"), System.Drawing.Image)
        Me.bbtSuaChua.Name = "bbtSuaChua"
        '
        'bbtKetChuyen
        '
        Me.bbtKetChuyen.Caption = "Kết Chuyển"
        Me.bbtKetChuyen.Glyph = CType(resources.GetObject("bbtKetChuyen.Glyph"), System.Drawing.Image)
        Me.bbtKetChuyen.Id = 9
        Me.bbtKetChuyen.LargeGlyph = CType(resources.GetObject("bbtKetChuyen.LargeGlyph"), System.Drawing.Image)
        Me.bbtKetChuyen.Name = "bbtKetChuyen"
        '
        'bbtnNhapDanhMucTuExel
        '
        Me.bbtnNhapDanhMucTuExel.Caption = "Nhập Danh Mục Từ Exel"
        Me.bbtnNhapDanhMucTuExel.Glyph = CType(resources.GetObject("bbtnNhapDanhMucTuExel.Glyph"), System.Drawing.Image)
        Me.bbtnNhapDanhMucTuExel.Id = 10
        Me.bbtnNhapDanhMucTuExel.LargeGlyph = CType(resources.GetObject("bbtnNhapDanhMucTuExel.LargeGlyph"), System.Drawing.Image)
        Me.bbtnNhapDanhMucTuExel.Name = "bbtnNhapDanhMucTuExel"
        '
        'bbtKhuVuc
        '
        Me.bbtKhuVuc.Caption = "Khu Vực"
        Me.bbtKhuVuc.Glyph = CType(resources.GetObject("bbtKhuVuc.Glyph"), System.Drawing.Image)
        Me.bbtKhuVuc.Id = 11
        Me.bbtKhuVuc.LargeGlyph = CType(resources.GetObject("bbtKhuVuc.LargeGlyph"), System.Drawing.Image)
        Me.bbtKhuVuc.Name = "bbtKhuVuc"
        '
        'bbtKhachHang
        '
        Me.bbtKhachHang.Caption = "Khách Hàng"
        Me.bbtKhachHang.Glyph = CType(resources.GetObject("bbtKhachHang.Glyph"), System.Drawing.Image)
        Me.bbtKhachHang.Id = 12
        Me.bbtKhachHang.LargeGlyph = CType(resources.GetObject("bbtKhachHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtKhachHang.Name = "bbtKhachHang"
        '
        'bbtNhaCungCap
        '
        Me.bbtNhaCungCap.Caption = "Nhà Cung Cấp"
        Me.bbtNhaCungCap.Glyph = CType(resources.GetObject("bbtNhaCungCap.Glyph"), System.Drawing.Image)
        Me.bbtNhaCungCap.Id = 13
        Me.bbtNhaCungCap.LargeGlyph = CType(resources.GetObject("bbtNhaCungCap.LargeGlyph"), System.Drawing.Image)
        Me.bbtNhaCungCap.Name = "bbtNhaCungCap"
        '
        'bbtKhoHang
        '
        Me.bbtKhoHang.Caption = "Kho Hàng"
        Me.bbtKhoHang.Glyph = CType(resources.GetObject("bbtKhoHang.Glyph"), System.Drawing.Image)
        Me.bbtKhoHang.Id = 14
        Me.bbtKhoHang.LargeGlyph = CType(resources.GetObject("bbtKhoHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtKhoHang.Name = "bbtKhoHang"
        '
        'bbtDonViTinh
        '
        Me.bbtDonViTinh.Caption = "Đơn Vị Tính"
        Me.bbtDonViTinh.Id = 15
        Me.bbtDonViTinh.LargeGlyph = CType(resources.GetObject("bbtDonViTinh.LargeGlyph"), System.Drawing.Image)
        Me.bbtDonViTinh.Name = "bbtDonViTinh"
        '
        'bbtNhomHang
        '
        Me.bbtNhomHang.Caption = "Nhóm Hàng"
        Me.bbtNhomHang.Id = 16
        Me.bbtNhomHang.LargeGlyph = CType(resources.GetObject("bbtNhomHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtNhomHang.Name = "bbtNhomHang"
        '
        'bbtHangHoa
        '
        Me.bbtHangHoa.Caption = "Hàng Hóa"
        Me.bbtHangHoa.Id = 17
        Me.bbtHangHoa.LargeGlyph = CType(resources.GetObject("bbtHangHoa.LargeGlyph"), System.Drawing.Image)
        Me.bbtHangHoa.Name = "bbtHangHoa"
        '
        'bbtInMaVach
        '
        Me.bbtInMaVach.Caption = "In Mã Vạch"
        Me.bbtInMaVach.Id = 18
        Me.bbtInMaVach.LargeGlyph = CType(resources.GetObject("bbtInMaVach.LargeGlyph"), System.Drawing.Image)
        Me.bbtInMaVach.Name = "bbtInMaVach"
        '
        'bbtTyGia
        '
        Me.bbtTyGia.Caption = "Tỷ Giá"
        Me.bbtTyGia.Id = 19
        Me.bbtTyGia.LargeGlyph = CType(resources.GetObject("bbtTyGia.LargeGlyph"), System.Drawing.Image)
        Me.bbtTyGia.Name = "bbtTyGia"
        '
        'bbtBoPhan
        '
        Me.bbtBoPhan.Caption = "Bộ Phận"
        Me.bbtBoPhan.Id = 20
        Me.bbtBoPhan.LargeGlyph = CType(resources.GetObject("bbtBoPhan.LargeGlyph"), System.Drawing.Image)
        Me.bbtBoPhan.Name = "bbtBoPhan"
        '
        'bbtNhanVien
        '
        Me.bbtNhanVien.Caption = "Nhân Viên"
        Me.bbtNhanVien.Id = 21
        Me.bbtNhanVien.LargeGlyph = CType(resources.GetObject("bbtNhanVien.LargeGlyph"), System.Drawing.Image)
        Me.bbtNhanVien.Name = "bbtNhanVien"
        '
        'bbtMuaHang
        '
        Me.bbtMuaHang.Caption = "Mua Hàng"
        Me.bbtMuaHang.Id = 22
        Me.bbtMuaHang.LargeGlyph = CType(resources.GetObject("bbtMuaHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtMuaHang.Name = "bbtMuaHang"
        '
        'bbtBanHang
        '
        Me.bbtBanHang.Caption = "Bán Hàng"
        Me.bbtBanHang.Id = 23
        Me.bbtBanHang.LargeGlyph = CType(resources.GetObject("bbtBanHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtBanHang.Name = "bbtBanHang"
        '
        'bbtTonKho
        '
        Me.bbtTonKho.Caption = "Tồn Kho"
        Me.bbtTonKho.Id = 24
        Me.bbtTonKho.LargeGlyph = CType(resources.GetObject("bbtTonKho.LargeGlyph"), System.Drawing.Image)
        Me.bbtTonKho.Name = "bbtTonKho"
        '
        'bbtChuyenKho
        '
        Me.bbtChuyenKho.Caption = "Chuyển Kho"
        Me.bbtChuyenKho.Id = 25
        Me.bbtChuyenKho.LargeGlyph = CType(resources.GetObject("bbtChuyenKho.LargeGlyph"), System.Drawing.Image)
        Me.bbtChuyenKho.Name = "bbtChuyenKho"
        '
        'bbtNhapSoDuDauKy
        '
        Me.bbtNhapSoDuDauKy.Caption = "Nhập Số Dư Đầu Kỳ"
        Me.bbtNhapSoDuDauKy.Id = 26
        Me.bbtNhapSoDuDauKy.LargeGlyph = CType(resources.GetObject("bbtNhapSoDuDauKy.LargeGlyph"), System.Drawing.Image)
        Me.bbtNhapSoDuDauKy.Name = "bbtNhapSoDuDauKy"
        '
        'bbtThuTien
        '
        Me.bbtThuTien.Caption = "Thu Tiền"
        Me.bbtThuTien.Id = 27
        Me.bbtThuTien.LargeGlyph = CType(resources.GetObject("bbtThuTien.LargeGlyph"), System.Drawing.Image)
        Me.bbtThuTien.Name = "bbtThuTien"
        '
        'bbtTraTien
        '
        Me.bbtTraTien.Caption = "Trả Tiền"
        Me.bbtTraTien.Id = 28
        Me.bbtTraTien.LargeGlyph = CType(resources.GetObject("bbtTraTien.LargeGlyph"), System.Drawing.Image)
        Me.bbtTraTien.Name = "bbtTraTien"
        '
        'bbtBaoCaoKhoHang
        '
        Me.bbtBaoCaoKhoHang.Caption = "Báo Cáo Kho Hàng"
        Me.bbtBaoCaoKhoHang.Id = 29
        Me.bbtBaoCaoKhoHang.LargeGlyph = CType(resources.GetObject("bbtBaoCaoKhoHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtBaoCaoKhoHang.Name = "bbtBaoCaoKhoHang"
        '
        'bbtBaoCaoBanHang
        '
        Me.bbtBaoCaoBanHang.Caption = "Báo Cáo Bán Hàng"
        Me.bbtBaoCaoBanHang.Id = 30
        Me.bbtBaoCaoBanHang.LargeGlyph = CType(resources.GetObject("bbtBaoCaoBanHang.LargeGlyph"), System.Drawing.Image)
        Me.bbtBaoCaoBanHang.Name = "bbtBaoCaoBanHang"
        '
        'bbtChungTu
        '
        Me.bbtChungTu.Caption = "Chứng Từ"
        Me.bbtChungTu.Id = 31
        Me.bbtChungTu.LargeGlyph = CType(resources.GetObject("bbtChungTu.LargeGlyph"), System.Drawing.Image)
        Me.bbtChungTu.Name = "bbtChungTu"
        '
        'bbtHoTroTrucTuyen
        '
        Me.bbtHoTroTrucTuyen.Caption = "Hỗ Trợ Trực Tuyến"
        Me.bbtHoTroTrucTuyen.Id = 32
        Me.bbtHoTroTrucTuyen.LargeGlyph = CType(resources.GetObject("bbtHoTroTrucTuyen.LargeGlyph"), System.Drawing.Image)
        Me.bbtHoTroTrucTuyen.Name = "bbtHoTroTrucTuyen"
        '
        'bbtHuongDanSuDung
        '
        Me.bbtHuongDanSuDung.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbtHuongDanSuDung.Caption = "Hướng Dẫn Sử Dụng"
        Me.bbtHuongDanSuDung.Id = 33
        Me.bbtHuongDanSuDung.LargeGlyph = CType(resources.GetObject("bbtHuongDanSuDung.LargeGlyph"), System.Drawing.Image)
        Me.bbtHuongDanSuDung.Name = "bbtHuongDanSuDung"
        '
        'bbtLienHe
        '
        Me.bbtLienHe.Caption = "Liên Hệ"
        Me.bbtLienHe.Id = 34
        Me.bbtLienHe.LargeGlyph = CType(resources.GetObject("bbtLienHe.LargeGlyph"), System.Drawing.Image)
        Me.bbtLienHe.Name = "bbtLienHe"
        '
        'bbtDangKy
        '
        Me.bbtDangKy.Caption = "Đăng Ký"
        Me.bbtDangKy.Id = 35
        Me.bbtDangKy.LargeGlyph = CType(resources.GetObject("bbtDangKy.LargeGlyph"), System.Drawing.Image)
        Me.bbtDangKy.Name = "bbtDangKy"
        '
        'bbtThongTin1
        '
        Me.bbtThongTin1.Caption = "Thông Tin"
        Me.bbtThongTin1.Id = 36
        Me.bbtThongTin1.LargeGlyph = CType(resources.GetObject("bbtThongTin1.LargeGlyph"), System.Drawing.Image)
        Me.bbtThongTin1.Name = "bbtThongTin1"
        '
        'bbtCapNhat
        '
        Me.bbtCapNhat.Caption = "Cập Nhật"
        Me.bbtCapNhat.Id = 37
        Me.bbtCapNhat.LargeGlyph = CType(resources.GetObject("bbtCapNhat.LargeGlyph"), System.Drawing.Image)
        Me.bbtCapNhat.Name = "bbtCapNhat"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 38
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Hệ Thống"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbtKetThuc)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbtThongTin)
        Me.ribbonPageGroup1.MergeOrder = 0
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Hệ Thống"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbtPhanQuyen)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbtDoiMatKhau)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.bbtNhatKyHeThong)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Bảo Mật"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bbtSaoLuu)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bbtPhucHoi)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bbtSuaChua)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.bbtKetChuyen)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Dữ Liệu"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup7, Me.RibbonPageGroup8, Me.RibbonPageGroup13})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Danh Mục "
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbtnNhapDanhMucTuExel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Exel"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bbtKhuVuc)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bbtKhachHang)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.bbtNhaCungCap)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Đối Tác"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtKhoHang)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtDonViTinh)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtNhomHang)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtHangHoa)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtInMaVach)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.bbtTyGia)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "Kho Hàng"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.bbtBoPhan)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.bbtNhanVien)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        Me.RibbonPageGroup13.Text = "Tổ Chức"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup9, Me.RibbonPageGroup10, Me.RibbonPageGroup14})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Chức Năng"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbtMuaHang)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.bbtBanHang)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Nhập - Xuất"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.bbtTonKho)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.bbtChuyenKho)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.bbtNhapSoDuDauKy)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.Text = "Kho Hàng"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bbtThuTien)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bbtTraTien)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.Text = "Công Nợ"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bbtBaoCaoKhoHang)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bbtBaoCaoBanHang)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.bbtChungTu)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        Me.RibbonPageGroup14.Text = "Báo Cáo"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup11})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Trợ Giúp"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbtHoTroTrucTuyen)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbtHuongDanSuDung)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.bbtLienHe)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Trợ Giúp"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bbtDangKy)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bbtThongTin1)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bbtCapNhat)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.Text = "Thông Tin"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 360)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lí Bán Hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbtKetThuc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtThongTin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtPhanQuyen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtDoiMatKhau As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtNhatKyHeThong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtSaoLuu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtPhucHoi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtSuaChua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtKetChuyen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtnNhapDanhMucTuExel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtKhuVuc As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtKhachHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtNhaCungCap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtKhoHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtDonViTinh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtNhomHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtHangHoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtInMaVach As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtTyGia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtBoPhan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtNhanVien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtMuaHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtBanHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtTonKho As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtChuyenKho As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtNhapSoDuDauKy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtThuTien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtTraTien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtBaoCaoKhoHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtBaoCaoBanHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtChungTu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtHoTroTrucTuyen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtHuongDanSuDung As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtLienHe As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtDangKy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtThongTin1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtCapNhat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
End Class
