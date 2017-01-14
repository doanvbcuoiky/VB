Public Class KhoHangDTO
    Private MaKhoHang As String
    Private KiHieu As String
    Private TenKhoHang As String
    Private NguoiQuanLi As String
    Private NguoiLienHe As String
    Private DiaChi As String
    Private DienThoai As String
    Private Fax As String
    Private Email As String
    Private DienGiai As String
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaKhoHang = ""
        Me.KiHieu = ""
        Me.TenKhoHang = ""
        Me.NguoiQuanLi = ""
        Me.NguoiLienHe = ""
        Me.DiaChi = ""
        Me.DienThoai = ""
        Me.Fax = ""
        Me.Email = ""
        Me.DienGiai = ""
        Me.TinhTrang = True
    End Sub
    Public Sub New(ByVal maKhoHang As String, ByVal kiHieu As String, ByVal tenKhoHang As String, ByVal nguoiQuanLi As String, ByVal nguoiLienHe As String, ByVal diaChi As String, ByVal dienThoai As String, ByVal fax As String, ByVal email As String, ByVal dienGiai As String, ByVal tinhTrang As Boolean)
        Me.MaKhoHang = maKhoHang
        Me.KiHieu = kiHieu
        Me.TenKhoHang = tenKhoHang
        Me.NguoiQuanLi = nguoiQuanLi
        Me.NguoiLienHe = nguoiLienHe
        Me.DiaChi = diaChi
        Me.DienThoai = dienThoai
        Me.Fax = fax
        Me.Email = email
        Me.DienGiai = dienGiai
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaKhoHang1 As String
        Get
            Return MaKhoHang
        End Get
        Set(value As String)
            MaKhoHang = value
        End Set
    End Property

    Public Property KiHieu1 As String
        Get
            Return KiHieu
        End Get
        Set(value As String)
            KiHieu = value
        End Set
    End Property

    Public Property TenKhoHang1 As String
        Get
            Return TenKhoHang
        End Get
        Set(value As String)
            TenKhoHang = value
        End Set
    End Property

    Public Property NguoiQuanLi1 As String
        Get
            Return NguoiQuanLi
        End Get
        Set(value As String)
            NguoiQuanLi = value
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

    Public Property DienGiai1 As String
        Get
            Return DienGiai
        End Get
        Set(value As String)
            DienGiai = value
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
