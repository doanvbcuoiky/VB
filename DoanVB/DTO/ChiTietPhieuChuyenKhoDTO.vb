Public Class ChiTietPhieuChuyenKhoDTO
    Private MaPhieuChuyen As String
    Private MaHangHoa As String
    Private DonVi As String
    Private SoLuong As Integer
    Private DonGia As Double

    Public Sub New(ByVal maPhieuChuyen As String, ByVal maHangHoa As String, ByVal donVi As String, ByVal soLuong As Integer, ByVal donGia As Double)
        Me.MaPhieuChuyen = maPhieuChuyen
        Me.MaHangHoa = maHangHoa
        Me.DonVi = donVi
        Me.SoLuong = soLuong
        Me.DonGia = donGia
    End Sub

    Public Property MaPhieuChuyen1 As String
        Get
            Return MaPhieuChuyen
        End Get
        Set(value As String)
            MaPhieuChuyen = value
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

    Public Property DonVi1 As String
        Get
            Return DonVi
        End Get
        Set(value As String)
            DonVi = value
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

    Public Property DonGia1 As Double
        Get
            Return DonGia
        End Get
        Set(value As Double)
            DonGia = value
        End Set
    End Property
End Class
