Public Class ChiTietKhoDTO
    Private MaKhoHang As String
    Private MaHangHoa As String
    Private SoLuong As Integer

    Public Sub New(ByVal maKhoHang As String, ByVal maHangHoa As String, ByVal soLuong As Integer)
        Me.MaKhoHang = maKhoHang
        Me.MaHangHoa = maHangHoa
        Me.SoLuong = soLuong
    End Sub

    Public Property MaKhoHang1 As String
        Get
            Return MaKhoHang
        End Get
        Set(value As String)
            MaKhoHang = value
        End Set
    End Property

    Public Property MaHangHoa1 As String
        Get
            Return MaHangHoa
        End Get
        Set(value As String)
            MaHangHoa = value
        End Set
    End Property

    Public Property SoLuong1 As Integer
        Get
            Return SoLuong
        End Get
        Set(value As Integer)
            SoLuong = value
        End Set
    End Property


End Class
