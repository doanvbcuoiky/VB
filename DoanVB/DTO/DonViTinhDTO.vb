Public Class DonViTinhDTO
    Private MaDonVi As String
    Private TenDonVi As String
    Private GhiChu As String
    Private TinhTrang As Boolean

    Public Sub New(ByVal maDonVi As String, ByVal tenDonVi As String, ByVal ghiChu As String, ByVal tinhTrang As Boolean)
        Me.MaDonVi = maDonVi
        Me.TenDonVi = tenDonVi
        Me.GhiChu = ghiChu
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaDonVi1 As String
        Get
            Return MaDonVi
        End Get
        Set(value As String)
            MaDonVi = value
        End Set
    End Property

    Public Property TenDonVi1 As String
        Get
            Return TenDonVi
        End Get
        Set(value As String)
            TenDonVi = value
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
