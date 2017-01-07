Imports DAO
Imports DTO

Public Class KhachHangBUS
    Public Shared Function LoadDSKhachHang() As DataTable
        Dim dt As DataTable = KhachHangDAO.LoadDSKhachHang()
        Return dt
    End Function
    Public Shared Function ThemKhachHang(ByVal KHDTO As KhachHangDTO) As Boolean
        Return KhachHangDAO.ThemKhachHang(KHDTO)
    End Function
    Public Sub XoaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim KHDAO As New KhachHangDAO
        KHDAO.XoaKhachHang(KHDTO)
    End Sub
    Public Sub SuaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim KHDAO As New KhachHangDAO
        KHDAO.SuaKhachHang(KHDTO)
    End Sub
End Class
