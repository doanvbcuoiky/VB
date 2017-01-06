Public Class PhieuNhapHangDTO
    Private MaPhieuNhap As String
    Private NgayNhap As DateTime
    Private NhanVienNhap As String
    Private KhoNhap As String
    Private HanThanhToan As DateTime
    Private NhaCungCap As String
    Private HinhThucThanhToan As String
    Private TongTien As Double
    Private TinhTrang As Boolean

    Public Sub New(ByVal maPhieuNhap As String, ByVal ngayNhap As DateTime, ByVal nhanVienNhap As String, ByVal khoNhap As String, ByVal hanThanhToan As DateTime, ByVal nhaCungCap As String, ByVal hinhThucThanhToan As String, ByVal tongTien As Double, ByVal tinhTrang As Boolean)
        Me.MaPhieuNhap = maPhieuNhap
        Me.NgayNhap = ngayNhap
        Me.NhanVienNhap = nhanVienNhap
        Me.KhoNhap = khoNhap
        Me.HanThanhToan = hanThanhToan
        Me.NhaCungCap = nhaCungCap
        Me.HinhThucThanhToan = hinhThucThanhToan
        Me.TongTien = tongTien
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaPhieuNhap1 As String
        Get
            Return MaPhieuNhap
        End Get
        Set(value As String)
            MaPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap1 As Date
        Get
            Return NgayNhap
        End Get
        Set(value As Date)
            NgayNhap = value
        End Set
    End Property

    Public Property NhanVienNhap1 As String
        Get
            Return NhanVienNhap
        End Get
        Set(value As String)
            NhanVienNhap = value
        End Set
    End Property

    Public Property KhoNhap1 As String
        Get
            Return KhoNhap
        End Get
        Set(value As String)
            KhoNhap = value
        End Set
    End Property

    Public Property HanThanhToan1 As Date
        Get
            Return HanThanhToan
        End Get
        Set(value As Date)
            HanThanhToan = value
        End Set
    End Property

    Public Property NhaCungCap1 As String
        Get
            Return NhaCungCap
        End Get
        Set(value As String)
            NhaCungCap = value
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
