Public Class PhieuBanHangDTO
    Private MaPhieuBan As String
    Private MaKhachHang As String
    Private NgayBan As DateTime
    Private NhanVienBan As String
    Private KhoXuat As String
    Private HinhThucThanhToan As String
    Private TongTien As Double
    Private TinhTrang As Boolean

    Public Sub New(ByVal maPhieuBan As String, ByVal maKhachHang As String, ByVal ngayBan As DateTime, ByVal nhanVienBan As String, ByVal khoXuat As String, ByVal hinhThucThanhToan As String, ByVal tongTien As Double, ByVal tinhTrang As Boolean)
        Me.MaPhieuBan = maPhieuBan
        Me.MaKhachHang = maKhachHang
        Me.NgayBan = ngayBan
        Me.NhanVienBan = nhanVienBan
        Me.KhoXuat = khoXuat
        Me.HinhThucThanhToan = hinhThucThanhToan
        Me.TongTien = tongTien
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaPhieuBan1 As String
        Get
            Return MaPhieuBan
        End Get
        Set(value As String)
            MaPhieuBan = value
        End Set
    End Property

    Public Property MaKhachHang1 As String
        Get
            Return MaKhachHang
        End Get
        Set(value As String)
            MaKhachHang = value
        End Set
    End Property

    Public Property NgayBan1 As Date
        Get
            Return NgayBan
        End Get
        Set(value As Date)
            NgayBan = value
        End Set
    End Property

    Public Property NhanVienBan1 As String
        Get
            Return NhanVienBan
        End Get
        Set(value As String)
            NhanVienBan = value
        End Set
    End Property

    Public Property KhoXuat1 As String
        Get
            Return KhoXuat
        End Get
        Set(value As String)
            KhoXuat = value
        End Set
    End Property

    Public Property HinhThucThanhToan1 As String
        Get
            Return HinhThucThanhToan
        End Get
        Set(value As String)
            HinhThucThanhToan = value
        End Set
    End Property

    Public Property TongTien1 As Double
        Get
            Return TongTien
        End Get
        Set(value As Double)
            TongTien = value
        End Set
    End Property

    Public Property TinhTrang1 As Boolean
        Get
            Return TinhTrang
        End Get
        Set(value As Boolean)
            TinhTrang = value
        End Set
    End Property
End Class
