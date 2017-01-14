Public Class TyGiaDTO
    Private MaTienTe As String
    Private TenTienTe As String
    Private TyGiaQuyDoi As Double
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaTienTe = ""
        Me.TenTienTe = ""
        Me.TyGiaQuyDoi = 0
        Me.TinhTrang = True
    End Sub
    Public Sub New(ByVal maTienTe As String, ByVal tenTienTe As String, ByVal tyGiaQuyDoi As Double, ByVal tinhTrang As Boolean)
        Me.MaTienTe = maTienTe
        Me.TenTienTe = tenTienTe
        Me.TyGiaQuyDoi = tyGiaQuyDoi
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaTienTe1 As String
        Get
            Return MaTienTe
        End Get
        Set(value As String)
            MaTienTe = value
        End Set
    End Property

    Public Property TenTienTe1 As String
        Get
            Return TenTienTe
        End Get
        Set(value As String)
            TenTienTe = value
        End Set
    End Property

    Public Property TyGiaQuyDoi1 As Double
        Get
            Return TyGiaQuyDoi
        End Get
        Set(value As Double)
            TyGiaQuyDoi = value
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
