Public Class PhieuChuyenKhoDTO
    Private MaPhieuChuyen As String
    Private NgayChuyen As DateTime
    Private KhoXuat As String
    Private KhoNhap As String
    Private NguoiChuyen As String
    Private NguoiNhan As String
    Private GhiChu As String
    Private TongTien As Double
    Private TinhTrang As Boolean

    Public Sub New(ByVal maPhieuChuyen As String, ByVal ngayChuyen As DateTime, ByVal khoXuat As String, ByVal khoNhap As String, ByVal nguoiChuyen As String, ByVal nguoiNhan As String, ByVal ghiChu As String, ByVal tongTien As Double, ByVal tinhTrang As Boolean)
        Me.MaPhieuChuyen = maPhieuChuyen
        Me.NgayChuyen = ngayChuyen
        Me.KhoXuat = khoXuat
        Me.KhoNhap = khoNhap
        Me.NguoiChuyen = nguoiChuyen
        Me.NguoiNhan = nguoiNhan
        Me.GhiChu = ghiChu
        Me.TongTien = tongTien
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaPhieuChuyen1 As String
        Get
            Return MaPhieuChuyen
        End Get
        Set(value As String)
            MaPhieuChuyen = value
        End Set
    End Property

    Public Property NgayChuyen1 As Date
        Get
            Return NgayChuyen
        End Get
        Set(value As Date)
            NgayChuyen = value
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

    Public Property KhoNhap1 As String
        Get
            Return KhoNhap
        End Get
        Set(value As String)
            KhoNhap = value
        End Set
    End Property

    Public Property NguoiChuyen1 As String
        Get
            Return NguoiChuyen
        End Get
        Set(value As String)
            NguoiChuyen = value
        End Set
    End Property

    Public Property NguoiNhan1 As String
        Get
            Return NguoiNhan
        End Get
        Set(value As String)
            NguoiNhan = value
        End Set
    End Property

    Public Property GhiChu1 As String
        Get
            Return GhiChu
        End Get
        Set(value As String)
            GhiChu = value
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
