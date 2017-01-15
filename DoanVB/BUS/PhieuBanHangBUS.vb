Imports DAO
Imports DTO

Public Class PhieuBanHangBUS
    Public Shared Sub CapNhatTongTien(ByVal maphieu As String, ByVal TongTien As Double)
        PhieuBanHangDAO.CapnhatTongTien(maphieu, TongTien)
    End Sub
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
