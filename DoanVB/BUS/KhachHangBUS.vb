Imports DAO
Imports DTO

Public Class KhachHangBUS
    Public Shared Function LoadDSKhachHang() As DataTable
        Dim dt As DataTable = KhachHangDAO.LoadDSKhachHang()
        Return dt
    End Function
    Public Sub ThemKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim KHDAO As New KhachHangDAO
        KHDAO.ThemKhachHang(KHDTO)
    End Sub
    Public Sub XoaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim KHDAO As New KhachHangDAO
        KHDAO.XoaKhachHang(KHDTO)
    End Sub
    Public Sub SuaKhachHang(ByVal KHDTO As KhachHangDTO)
        Dim KHDAO As New KhachHangDAO
        KHDAO.SuaKhachHang(KHDTO)
    End Sub
End Class
