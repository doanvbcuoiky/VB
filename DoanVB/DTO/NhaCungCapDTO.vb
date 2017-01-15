Public Class NhaCungCapDTO
    Private MaNhaCungCap As String
    Private TenNhaCungCap As String
    Private DiaChi As String
    Private KhuVuc As String
    Private DienTHoai As String
    Private Fax As String
    Private Email As String
    Private Website As String
    Private MaSoThue As String
    Private SoTaiKhoan As String
    Private NganHang As String
    Private NoHienTai As Double
    Private TinhTrang As Boolean

    Public Sub New(ByVal maNhaCungCap As String, ByVal tenNhaCungCap As String, ByVal diaChi As String, ByVal khuVuc As String, ByVal dienTHoai As String, ByVal fax As String, ByVal email As String, ByVal website As String, ByVal maSoThue As String, ByVal soTaiKhoan As String, ByVal nganHang As String, ByVal noHienTai As Double, ByVal tinhTrang As Boolean)
        Me.MaNhaCungCap = maNhaCungCap
        Me.TenNhaCungCap = tenNhaCungCap
        Me.DiaChi = diaChi
        Me.KhuVuc = khuVuc
        Me.DienTHoai = dienTHoai
        Me.Fax = fax
        Me.Email = email
        Me.Website = website
        Me.MaSoThue = maSoThue
        Me.SoTaiKhoan = soTaiKhoan
        Me.NganHang = nganHang
        Me.NoHienTai = noHienTai
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaNhaCungCap1 As String
        Get
            Return MaNhaCungCap
        End Get
        Set(value As String)
            MaNhaCungCap = value
        End Set
    End Property

    Public Property TenNhaCungCap1 As String
        Get
            Return TenNhaCungCap
        End Get
        Set(value As String)
            TenNhaCungCap = value
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

    Public Property KhuVuc1 As String
        Get
            Return KhuVuc
        End Get
        Set(value As String)
            KhuVuc = value
        End Set
    End Property

    Public Property DienTHoai1 As String
        Get
            Return DienTHoai
        End Get
        Set(value As String)
            DienTHoai = value
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

    Public Property NoHienTai1 As Double
        Get
            Return NoHienTai
        End Get
        Set(value As Double)
            NoHienTai = value
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
