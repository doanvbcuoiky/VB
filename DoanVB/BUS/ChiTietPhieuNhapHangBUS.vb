Imports DAO
Imports DTO

Public Class ChiTietPhieuNhapHangBUS
    Public Shared Function LoadDSChiTietPhieuNhapHang() As DataTable
        Return ChiTietPhieuNhapHangDAO.LoadDSChiTietPhieuNhapHang()
    End Function
    Public Shared Function ThemChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO) As Boolean
        Return ChiTietPhieuNhapHangDAO.ThemChiTietPhieuNhapHang(CTPNHDTO)
    End Function
    Public Shared Function XoaChiTietPhieuNhapHang(ByVal maphieu As String, ByVal mahanghoa As String) As Boolean
        Return ChiTietPhieuNhapHangDAO.XoaChiTietPhieuNhapHang(maphieu, mahanghoa)
    End Function
    Public Shared Function SuaChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO) As Boolean
        Return ChiTietPhieuNhapHangDAO.SuaChiTietPhieuNhapHang(CTPNHDTO)
    End Function
End Class
