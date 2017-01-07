Imports DAO
Imports DTO

Public Class LoaiKhachHangBUS
    Public Shared Function LoadDSLoaiKhachHang() As DataTable
        Return LoaiKhachHangDAO.LoadDSLoaiKhachHang()
    End Function
    Public Sub ThemLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO)
        Dim LKHDAO As New LoaiKhachHangDAO
        LKHDAO.ThemLoaiKhachHang(LKHDTO)
    End Sub
    Public Sub XoaLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO)
        Dim LKHDAO As New LoaiKhachHangDAO
        LKHDAO.XoaLoaiKhachHang(LKHDTO)
    End Sub
    Public Sub SuaLoaiKhachHang(ByVal LKHDTO As LoaiKhachHangDTO)
        Dim LKHDAO As New LoaiKhachHangDAO
        LKHDAO.SuaLoaiKhachHang(LKHDTO)
    End Sub
End Class
