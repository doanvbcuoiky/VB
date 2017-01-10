Imports DAO
Imports DTO

Public Class KhoHangBUS
    Public Shared Function LoadDSKhoHang() As DataTable
        Return KhoHangDAO.LoadDSKhoHang()
    End Function
    Public Shared Function ThemKhoHang(ByVal KHDTO As KhoHangDTO) As Boolean
        Return KhoHangDAO.ThemKhoHang(KHDTO)
    End Function
    Public Shared Function XoaKhoHang(ByVal makhohang As String) As Boolean
        Return KhoHangDAO.XoaKhoHang(makhohang)
    End Function
    Public Shared Function SuaKhoHang(ByVal KHDTO As KhoHangDTO) As Boolean
        Return KhoHangDAO.SuaKhoHang(KHDTO)
    End Function
End Class
