Public Class KhachHangDTO
    Private MaKhachHang As String
    Private TenKhachHang As String
    Private NguoiLienHe As String
    Private DiaChi As String
    Private LoaiKhachHang As String
    Private KhuVuc As String
    Private DienThoai As String
    Private Fax As String
    Private Email As String
    Private Website As String
    Private MaSoThue As String
    Private SoTaiKhoan As String
    Private NganHang As String
    Private TinhTrang As Boolean

    Public Sub New(ByVal maKhachHang As String, ByVal tenKhachHang As String, ByVal nguoiLienHe As String, ByVal diaChi As String, ByVal loaiKhachHang As String, ByVal khuVuc As String, ByVal dienThoai As String, ByVal fax As String, ByVal email As String, ByVal website As String, ByVal maSoThue As String, ByVal soTaiKhoan As String, ByVal nganHang As String, ByVal tinhTrang As Boolean)
        Me.MaKhachHang = maKhachHang
        Me.TenKhachHang = tenKhachHang
        Me.NguoiLienHe = nguoiLienHe
        Me.DiaChi = diaChi
        Me.LoaiKhachHang = loaiKhachHang
        Me.KhuVuc = khuVuc
        Me.DienThoai = dienThoai
        Me.Fax = fax
        Me.Email = email
        Me.Website = website
        Me.MaSoThue = maSoThue
        Me.SoTaiKhoan = soTaiKhoan
        Me.NganHang = nganHang
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaKhachHang1 As String
        Get
            Return MaKhachHang
        End Get
        Set(value As String)
            MaKhachHang = value
        End Set
    End Property

    Public Property TenKhachHang1 As String
        Get
            Return TenKhachHang
        End Get
        Set(value As String)
            TenKhachHang = value
        End Set
    End Property

    Public Property NguoiLienHe1 As String
        Get
            Return NguoiLienHe
        End Get
        Set(value As String)
            NguoiLienHe = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return DiaChi
        End Get
        Set(value As String)
            DiaChi = value
        End Set
    End Property

    Public Property LoaiKhachHang1 As String
        Get
            Return LoaiKhachHang
        End Get
        Set(value As String)
            LoaiKhachHang = value
        End Set
    End Property

    Public Property KhuVuc1 As String
        Get
            Return KhuVuc
        End Get
        Set(value As String)
            KhuVuc = value
        End Set
    End Property

    Public Property DienThoai1 As String
        Get
            Return DienThoai
        End Get
        Set(value As String)
            DienThoai = value
        End Set
    End Property

    Public Property Fax1 As String
        Get
            Return Fax
        End Get
        Set(value As String)
            Fax = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property

    Public Property Website1 As String
        Get
            Return Website
        End Get
        Set(value As String)
            Website = value
        End Set
    End Property

    Public Property MaSoThue1 As String
        Get
            Return MaSoThue
        End Get
        Set(value As String)
            MaSoThue = value
        End Set
    End Property

    Public Property SoTaiKhoan1 As String
        Get
            Return SoTaiKhoan
        End Get
        Set(value As String)
            SoTaiKhoan = value
        End Set
    End Property

    Public Property NganHang1 As String
        Get
            Return NganHang
        End Get
        Set(value As String)
            NganHang = value
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
