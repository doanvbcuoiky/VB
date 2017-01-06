Imports DAO
Imports DTO

Public Class ChiTietPhieuNhapHangBUS
    Public Function LoadDSChiTietPhieuNhapHang() As DataTable
        Dim CTPNHDAO As New ChiTietPhieuNhapHangDAO
        Dim dt As DataTable
        dt = CTPNHDAO.LoadDSChiTietPhieuNhapHang()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Dim CTPNHDAO As New ChiTietPhieuNhapHangDAO
        CTPNHDAO.ThemChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
    Public Sub XoaChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Dim CTPNHDAO As New ChiTietPhieuNhapHangDAO
        CTPNHDAO.XoaChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
    Public Sub SuaChiTietPhieuNhapHang(ByVal CTPNHDTO As ChiTietPhieuNhapHangDTO)
        Dim CTPNHDAO As New ChiTietPhieuNhapHangDAO
        CTPNHDAO.SuaChiTietPhieuNhapHang(CTPNHDTO)
    End Sub
End Class
