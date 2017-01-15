Public Class NhanVienDTO
    Private MaNhanVien As String
    Private TenNhanVien As String
    Private ChucVu As String
    Private DiaChi As String
    Private Email As String
    Private DienThoai As String
    Private BoPhan As String
    Private NguoiQuanLi As String
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaNhanVien = ""
        Me.TenNhanVien = ""
        Me.ChucVu = ""
        Me.DiaChi = ""
        Me.Email = ""
        Me.DienThoai = ""
        Me.BoPhan = ""
        Me.NguoiQuanLi = ""
        Me.TinhTrang = False
    End Sub
    Public Sub New(ByVal maNhanVien As String, ByVal tenNhanVien As String, ByVal chucVu As String, ByVal diaChi As String, ByVal email As String, ByVal dienThoai As String, ByVal boPhan As String, ByVal nguoiQuanLi As String, ByVal tinhTrang As Boolean)
        Me.MaNhanVien = maNhanVien
        Me.TenNhanVien = tenNhanVien
        Me.ChucVu = chucVu
        Me.DiaChi = diaChi
        Me.Email = email
        Me.DienThoai = dienThoai
        Me.BoPhan = boPhan
        Me.NguoiQuanLi = nguoiQuanLi
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaNhanVien1 As String
        Get
            Return MaNhanVien
        End Get
        Set(value As String)
            MaNhanVien = value
        End Set
    End Property

    Public Property TenNhanVien1 As String
        Get
            Return TenNhanVien
        End Get
        Set(value As String)
            TenNhanVien = value
        End Set
    End Property

    Public Property ChucVu1 As String
        Get
            Return ChucVu
        End Get
        Set(value As String)
            ChucVu = value
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

    Public Property Email1 As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
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

    Public Property BoPhan1 As String
        Get
            Return BoPhan
        End Get
        Set(value As String)
            BoPhan = value
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

    Public Property TinhTrang1 As Boolean
        Get
            Return TinhTrang
        End Get
        Set(value As Boolean)
            TinhTrang = value
        End Set
    End Property
End Class
