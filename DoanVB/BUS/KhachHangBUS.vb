Imports DAO
Imports DTO

Public Class KhachHangBUS
    Public Shared Function ThongTinKhachHang(ByVal makh As String) As KhachHangDTO
        Return KhachHangDAO.ThongTinKhachHang(makh)
    End Function
    Public Shared Function LoadDSKhachHang() As DataTable
        Dim dt As DataTable = KhachHangDAO.LoadDSKhachHang()
        Return dt
    End Function
    Public Shared Function ThemKhachHang(ByVal KHDTO As KhachHangDTO) As Boolean
        Return KhachHangDAO.ThemKhachHang(KHDTO)
    End Function
    Public Shared Function XoaKhachHang(ByVal makhachhang As String) As Boolean
        Return KhachHangDAO.XoaKhachHang(makhachhang)
    End Function
    Public Shared Function SuaKhachHang(ByVal KHDTO As KhachHangDTO) As Boolean
        Return KhachHangDAO.SuaKhachHang(KHDTO)
    End Function
End Class
