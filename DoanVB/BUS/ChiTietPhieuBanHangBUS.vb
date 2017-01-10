Imports DAO
Imports DTO

Public Class ChiTietPhieuBanHangBUS
    Public Shared Function LoadDSChiTietPhieuBanHang() As DataTable
        Return ChiTietPhieuBanHangDAO.LoadDSChiTietPhieuBanHang()
    End Function
    Public Shared Function ThemChiTietPhieuBanHang(ByVal CTPBHDTO As ChiTietPhieuBanHangDTO) As Boolean
        Return ChiTietPhieuBanHangDAO.ThemChiTietPhieuBanHang(CTPBHDTO)
    End Function
    Public Shared Function XoaChiTietPhieuBanHang(ByVal maphieu As String, ByVal mahanghoa As String) As Boolean
        Return ChiTietPhieuBanHangDAO.XoaChiTietPhieuBanHang(maphieu, mahanghoa)
    End Function
    Public Shared Function SuaChiTietPhieuBanHang(ByVal CTPBHDTO As ChiTietPhieuBanHangDTO) As Boolean
        Return ChiTietPhieuBanHangDAO.SuaChiTietPhieuBanHang(CTPBHDTO)
    End Function
End Class
