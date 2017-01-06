Public Class PhanQuyenDTO
    Private TenNhom As String
    Private TenChucNang As String
    Private MaNguoiDung As String
    Private ChoPhepThem As Boolean
    Private ChoPhepXoa As Boolean
    Private ChoPhepSua As Boolean
    Private ChoPhepTruyCap As Boolean
    Private ChoPhepIn As Boolean
    Private TinhTrang As Boolean

    Public Sub New(ByVal tenNhom As String, ByVal tenChucNang As String, ByVal maNguoiDung As String, ByVal choPhepThem As Boolean, ByVal choPhepXoa As Boolean, ByVal choPhepSua As Boolean, ByVal choPhepTruyCap As Boolean, ByVal choPhepIn As Boolean, ByVal tinhTrang As Boolean)
        Me.TenNhom = tenNhom
        Me.TenChucNang = tenChucNang
        Me.MaNguoiDung = maNguoiDung
        Me.ChoPhepThem = choPhepThem
        Me.ChoPhepXoa = choPhepXoa
        Me.ChoPhepSua = choPhepSua
        Me.ChoPhepTruyCap = choPhepTruyCap
        Me.ChoPhepIn = choPhepIn
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property TenNhom1 As String
        Get
            Return TenNhom
        End Get
        Set(value As String)
            TenNhom = value
        End Set
    End Property

    Public Property TenChucNang1 As String
        Get
            Return TenChucNang
        End Get
        Set(value As String)
            TenChucNang = value
        End Set
    End Property

    Public Property MaNguoiDung1 As String
        Get
            Return MaNguoiDung
        End Get
        Set(value As String)
            MaNguoiDung = value
        End Set
    End Property

    Public Property ChoPhepThem1 As Boolean
        Get
            Return ChoPhepThem
        End Get
        Set(value As Boolean)
            ChoPhepThem = value
        End Set
    End Property

    Public Property ChoPhepXoa1 As Boolean
        Get
            Return ChoPhepXoa
        End Get
        Set(value As Boolean)
            ChoPhepXoa = value
        End Set
    End Property

    Public Property ChoPhepSua1 As Boolean
        Get
            Return ChoPhepSua
        End Get
        Set(value As Boolean)
            ChoPhepSua = value
        End Set
    End Property

    Public Property ChoPhepTruyCap1 As Boolean
        Get
            Return ChoPhepTruyCap
        End Get
        Set(value As Boolean)
            ChoPhepTruyCap = value
        End Set
    End Property

    Public Property ChoPhepIn1 As Boolean
        Get
            Return ChoPhepIn
        End Get
        Set(value As Boolean)
            ChoPhepIn = value
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
