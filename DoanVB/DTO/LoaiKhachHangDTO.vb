Public Class LoaiKhachHangDTO
    Private MaLoaiKhachHang As String
    Private TenLoaiKhachHang As String
    Private GhiChu As String
    Private TinhTrang As Boolean

    Public Sub New(ByVal maLoaiKhachHang As String, ByVal tenLoaiKhachHang As String, ByVal ghiChu As String, ByVal tinhTrang As Boolean)
        Me.MaLoaiKhachHang = maLoaiKhachHang
        Me.TenLoaiKhachHang = tenLoaiKhachHang
        Me.GhiChu = ghiChu
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaLoaiKhachHang1 As String
        Get
            Return MaLoaiKhachHang
        End Get
        Set(value As String)
            MaLoaiKhachHang = value
        End Set
    End Property

    Public Property TenLoaiKhachHang1 As String
        Get
            Return TenLoaiKhachHang
        End Get
        Set(value As String)
            TenLoaiKhachHang = value
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

    Public Property TinhTrang1 As Boolean
        Get
            Return TinhTrang
        End Get
        Set(value As Boolean)
            TinhTrang = value
        End Set
    End Property
End Class
