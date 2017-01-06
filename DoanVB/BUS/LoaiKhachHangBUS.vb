Imports DAO
Imports DTO

Public Class LoaiKhachHangBUS
    Public Function LoadDSLoaiKhachHang() As DataTable
        Dim LKHDAO As New LoaiKhachHangDAO
        Dim dt As DataTable
        dt = LKHDAO.LoadDSLoaiKhachHang()
        Return dt
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
