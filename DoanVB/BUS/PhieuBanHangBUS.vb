Imports DAO
Imports DTO

Public Class PhieuBanHangBUS
    Public Shared Function LoadDSPhieuBanHang() As DataTable
        Return PhieuBanHangDAO.LoadDSPhieuBanHang()
    End Function
    Public Shared Function ThemPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO) As Boolean
        Return PhieuBanHangDAO.ThemPhieuBanHang(PBHDTO)
    End Function
    Public Shared Function XoaPhieuBanHang(ByVal maphieu As String) As Boolean
        Return PhieuBanHangDAO.XoaPhieuBanHang(maphieu)
    End Function
    Public Shared Function SuaPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO) As Boolean
        Return PhieuBanHangDAO.SuaPhieuBanHang(PBHDTO)
    End Function
End Class
