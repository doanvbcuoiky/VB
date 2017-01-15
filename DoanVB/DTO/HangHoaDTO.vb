Public Class HangHoaDTO
    Private MaHangHoa As String
    Private TenHangHoa As String
    Private KieuHangHoa As String
    Private NhomHang As String
    Private MaVach As String
    Private DonVi As String
    Private XuatXu As String
    Private TonKhoToiThieu As Integer
    Private TonHienTai As Integer
    Private NhaCungCap As String
    Private GiaMua As Double
    Private GiaBanLe As Double
    Private GiaBanSi As Double
    Private LoaiTien As String
    Private HinhAnh As String
    Private TinhTrang As Boolean

    Public Sub New()
        Me.MaHangHoa = ""
        Me.TenHangHoa = ""
        Me.KieuHangHoa = ""
        Me.NhomHang = ""
        Me.MaVach = ""
        Me.DonVi = ""
        Me.XuatXu = ""
        Me.TonKhoToiThieu = 0
        Me.TonHienTai = 0
        Me.NhaCungCap = ""
        Me.GiaMua = 0
        Me.GiaBanLe = 0
        Me.GiaBanSi = 0
        Me.LoaiTien = ""
        Me.HinhAnh = ""
        Me.TinhTrang = True
    End Sub
    Public Sub New(ByVal maHangHoa As String, ByVal tenHangHoa As String, ByVal kieuHangHoa As String, ByVal nhomHang As String, ByVal maVach As String, ByVal donVi As String, ByVal xuatXu As String, ByVal tonKhoToiThieu As Integer, ByVal tonHienTai As Integer, ByVal nhaCungCap As String, ByVal giaMua As Double, ByVal giaBanLe As Double, ByVal giaBanSi As Double, ByVal loaiTien As String, ByVal hinhAnh As String, ByVal tinhTrang As Boolean)
        Me.MaHangHoa = maHangHoa
        Me.TenHangHoa = tenHangHoa
        Me.KieuHangHoa = kieuHangHoa
        Me.NhomHang = nhomHang
        Me.MaVach = maVach
        Me.DonVi = donVi
        Me.XuatXu = xuatXu
        Me.TonKhoToiThieu = tonKhoToiThieu
        Me.TonHienTai = tonHienTai
        Me.NhaCungCap = nhaCungCap
        Me.GiaMua = giaMua
        Me.GiaBanLe = giaBanLe
        Me.GiaBanSi = giaBanSi
        Me.LoaiTien = loaiTien
        Me.HinhAnh = hinhAnh
        Me.TinhTrang = tinhTrang
    End Sub

    Public Property MaHangHoa1 As String
        Get
            Return MaHangHoa
        End Get
        Set(value As String)
            MaHangHoa = value
        End Set
    End Property

    Public Property TenHangHoa1 As String
        Get
            Return TenHangHoa
        End Get
        Set(value As String)
            TenHangHoa = value
        End Set
    End Property

    Public Property KieuHangHoa1 As String
        Get
            Return KieuHangHoa
        End Get
        Set(value As String)
            KieuHangHoa = value
        End Set
    End Property

    Public Property NhomHang1 As String
        Get
            Return NhomHang
        End Get
        Set(value As String)
            NhomHang = value
        End Set
    End Property

    Public Property MaVach1 As String
        Get
            Return MaVach
        End Get
        Set(value As String)
            MaVach = value
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

    Public Property XuatXu1 As String
        Get
            Return XuatXu
        End Get
        Set(value As String)
            XuatXu = value
        End Set
    End Property

    Public Property TonKhoToiThieu1 As Integer
        Get
            Return TonKhoToiThieu
        End Get
        Set(value As Integer)
            TonKhoToiThieu = value
        End Set
    End Property

    Public Property TonHienTai1 As Integer
        Get
            Return TonHienTai
        End Get
        Set(value As Integer)
            TonHienTai = value
        End Set
    End Property

    Public Property NhaCungCap1 As String
        Get
            Return NhaCungCap
        End Get
        Set(value As String)
            NhaCungCap = value
        End Set
    End Property

    Public Property GiaMua1 As Double
        Get
            Return GiaMua
        End Get
        Set(value As Double)
            GiaMua = value
        End Set
    End Property

    Public Property GiaBanLe1 As Double
        Get
            Return GiaBanLe
        End Get
        Set(value As Double)
            GiaBanLe = value
        End Set
    End Property

    Public Property GiaBanSi1 As Double
        Get
            Return GiaBanSi
        End Get
        Set(value As Double)
            GiaBanSi = value
        End Set
    End Property

    Public Property LoaiTien1 As String
        Get
            Return LoaiTien
        End Get
        Set(value As String)
            LoaiTien = value
        End Set
    End Property

    Public Property HinhAnh1 As String
        Get
            Return HinhAnh
        End Get
        Set(value As String)
            HinhAnh = value
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
