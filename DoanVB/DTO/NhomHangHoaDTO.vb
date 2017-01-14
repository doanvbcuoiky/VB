Public Class NhomHangHoaDTO
    Private MaNhomHang As String
    Private TenNhomHang As String
    Private GhiChu As String
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaNhomHang = ""
        Me.TenNhomHang = ""
        Me.GhiChu = ""
        Me.TinhTrang = True
    End Sub
    Public Sub New(ByVal maNhomHang As String, ByVal tenNhomHang As String, ByVal ghiChu As String, ByVal tinhTrang As Boolean)
        Me.MaNhomHang = maNhomHang
        Me.TenNhomHang = tenNhomHang
        Me.GhiChu = ghiChu
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaNhomHang1 As String
        Get
            Return MaNhomHang
        End Get
        Set(value As String)
            MaNhomHang = value
        End Set
    End Property

    Public Property TenNhomHang1 As String
        Get
            Return TenNhomHang
        End Get
        Set(value As String)
            TenNhomHang = value
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
