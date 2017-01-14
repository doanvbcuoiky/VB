Public Class BoPhanDTO
    Private MaBoPhan As String
    Private TenBoPhan As String
    Private GhiChu As String
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaBoPhan = ""
        Me.TenBoPhan = ""
        Me.GhiChu = ""
        Me.TinhTrang = True
    End Sub
    Public Sub New(ByVal maBoPhan As String, ByVal tenBoPhan As String, ByVal ghiChu As String, ByVal tinhTrang As Boolean)
        Me.MaBoPhan = maBoPhan
        Me.TenBoPhan = tenBoPhan
        Me.GhiChu = ghiChu
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaBoPhan1 As String
        Get
            Return MaBoPhan
        End Get
        Set(value As String)
            MaBoPhan = value
        End Set
    End Property

    Public Property TenBoPhan1 As String
        Get
            Return TenBoPhan
        End Get
        Set(value As String)
            TenBoPhan = value
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
