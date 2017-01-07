Imports DAO
Imports DTO

Public Class KhoHangBUS
    Public Shared Function LoadDSKhoHang() As DataTable
        Return KhoHangDAO.LoadDSKhoHang()
    End Function
    Public Sub ThemKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim KHDAO As New KhoHangDAO
        KHDAO.ThemKhoHang(KHDTO)
    End Sub
    Public Sub XoaKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim KHDAO As New KhoHangDAO
        KHDAO.XoaKhoHang(KHDTO)
    End Sub
    Public Sub SuaKhoHang(ByVal KHDTO As KhoHangDTO)
        Dim KHDAO As New KhoHangDAO
        KHDAO.SuaKhoHang(KHDTO)
    End Sub
End Class
