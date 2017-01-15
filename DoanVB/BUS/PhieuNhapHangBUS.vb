Imports DAO
Imports DTO

Public Class PhieuNhapHangBUS

    Public Shared Sub CapNhatTongTien(ByVal maphieu As String, ByVal TongTien As Double)
        PhieuNhapHangDAO.CapnhatTongTien(maphieu, TongTien)
    End Sub
    Public Shared Function LoadDSPhieuNhapHang() As DataTable
        Return PhieuNhapHangDAO.LoadDSPhieuNhapHang()
    End Function
    Public Shared Function ThemPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO) As Boolean
        Return PhieuNhapHangDAO.ThemPhieuNhapHang(PNHDTO)
    End Function
    Public Shared Function XoaPhieuNhapHang(ByVal maphieu As String) As Boolean
        Return PhieuNhapHangDAO.XoaPhieuNhapHang(maphieu)
    End Function
    Public Shared Function SuaPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO) As Boolean
        Return PhieuNhapHangDAO.SuaPhieuNhapHang(PNHDTO)
    End Function
End Class
