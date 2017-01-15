Public Class KhuVucDTO
    Private MaKhuVuc As String
    Private TenKhuVuc As String
    Private GhiChu As String
    Private TinhTrang As Boolean

    Public Sub New(ByVal maKhuVuc As String, ByVal tenKhuVuc As String, ByVal ghiChu As String, ByVal tinhTrang As Boolean)
        Me.MaKhuVuc = maKhuVuc
        Me.TenKhuVuc = tenKhuVuc
        Me.GhiChu = ghiChu
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaKhuVuc1 As String
        Get
            Return MaKhuVuc
        End Get
        Set(value As String)
            MaKhuVuc = value
        End Set
    End Property

    Public Property TenKhuVuc1 As String
        Get
            Return TenKhuVuc
        End Get
        Set(value As String)
            TenKhuVuc = value
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
