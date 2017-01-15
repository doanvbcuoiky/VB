Public Class ChiTietPhieuNhapHangDTO
    Private MaPhieuNhap As String
    Private MaHangHoa As String
    Private DonVi As String
    Private SoLuong As Integer
    Private DonGia As Double
    Private ChietKhau As Double

    Public Sub New(ByVal maPhieuNhap As String, ByVal maHangHoa As String, ByVal donVi As String, ByVal soLuong As Integer, ByVal donGia As Double, ByVal chietKhau As Double)
        Me.MaPhieuNhap = maPhieuNhap
        Me.MaHangHoa = maHangHoa
        Me.DonVi = donVi
        Me.SoLuong = soLuong
        Me.DonGia = donGia
        Me.ChietKhau = chietKhau
    End Sub

    Public Property MaPhieuNhap1 As String
        Get
            Return MaPhieuNhap
        End Get
        Set(value As String)
            MaPhieuNhap = value
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

    Public Property ChietKhau1 As Double
        Get
            Return ChietKhau
        End Get
        Set(value As Double)
            ChietKhau = value
        End Set
    End Property
End Class
