Imports DAO
Imports DTO

Public Class ChiTietPhieuNhapHangBUS
    Public Function LoadDSChiTietPhieuNhapHang() As DataTable
        Return ChiTietPhieuNhapHangBUS.LoadDSChiTietPhieuNhapHang()
    End Function
    Public Sub ThemChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Return ChiTietPhieuNhapHangBUS.ThemChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
    Public Sub XoaChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Return ChiTietPhieuNhapHangBUS.XoaChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
    Public Sub SuaChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Return ChiTietPhieuNhapHangBUS.SuaChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
End Class
