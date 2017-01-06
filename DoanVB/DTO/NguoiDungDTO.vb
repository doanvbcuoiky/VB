Public Class NguoiDungDTO
    Private MaNguoiDung As String
    Private TenNguoiDung As String
    Private MatKhau As String
    Private TinhTrang As Boolean
    Private NhoMatKhau As Boolean
    Private MaNhanVien As String

    Public Sub New(ByVal maNguoiDung As String, ByVal tenNguoiDung As String, ByVal matKhau As String, ByVal tinhTrang As Boolean, ByVal nhoMatKhau As Boolean, ByVal maNhanVien As String)
        Me.MaNguoiDung = maNguoiDung
        Me.TenNguoiDung = tenNguoiDung
        Me.MatKhau = matKhau
        Me.TinhTrang = tinhTrang
        Me.NhoMatKhau = nhoMatKhau
        Me.MaNhanVien = maNhanVien
    End Sub

    Public Property MaNguoiDung1 As String
        Get
            Return MaNguoiDung
        End Get
        Set(value As String)
            MaNguoiDung = value
        End Set
    End Property

    Public Property TenNguoiDung1 As String
        Get
            Return TenNguoiDung
        End Get
        Set(value As String)
            TenNguoiDung = value
        End Set
    End Property

    Public Property MatKhau1 As String
        Get
            Return MatKhau
        End Get
        Set(value As String)
            MatKhau = value
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

    Public Property NhoMatKhau1 As Boolean
        Get
            Return NhoMatKhau
        End Get
        Set(value As Boolean)
            NhoMatKhau = value
        End Set
    End Property

    Public Property MaNhanVien1 As String
        Get
            Return MaNhanVien
        End Get
        Set(value As String)
            MaNhanVien = value
        End Set
    End Property
End Class
