Imports DAO
Imports DTO

Public Class LoaiKhachHangBUS
    Public Shared Function LoadDSLoaiKhachHang() As DataTable
        Return LoaiKhachHangDAO.LoadDSLoaiKhachHang()
    End Function
    Public Shared Function ThemLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO) As Boolean
        Return LoaiKhachHangDAO.ThemLoaiKhachHang(LKHDTO)
    End Function
    Public Shared Function XoaLoaiKhachHang(ByVal maloai As String) As Boolean
        Return LoaiKhachHangDAO.XoaLoaiKhachHang(maloai)
    End Function
    Public Shared Function SuaLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO) As Boolean
        Return LoaiKhachHangDAO.SuaLoaiKhachHang(LKHDTO)
    End Function
End Class
