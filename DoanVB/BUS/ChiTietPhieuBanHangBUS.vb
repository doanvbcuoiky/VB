Imports DAO
Imports DTO

Public Class ChiTietPhieuBanHangBUS
    Public Function LoadDSChiTietPhieuBanHang() As DataTable
        Dim CTPBHDAO As New ChiTietPhieuBanHangDAO
        Dim dt As DataTable
        dt = CTPBHDAO.LoadDSChiTietPhieuBanHang()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuBanHang(ByVal CTPBHDTO As ChiTietPhieuBanHangDTO)
        Dim CTPBHDAO As New ChiTietPhieuBanHangDAO
        CTPBHDAO.ThemChiTietPhieuBanHang(CTPBHDTO)
    End Sub
    Public Sub XoaChiTietPhieuBanHang(ByVal CTPBHDTO As ChiTietPhieuBanHangDTO)
        Dim CTPBHDAO As New ChiTietPhieuBanHangDAO
        CTPBHDAO.XoaChiTietPhieuBanHang(CTPBHDTO)
    End Sub
    Public Sub SuaChiTietPhieuBanHang(ByVal CTPBHDTO As ChiTietPhieuBanHangDTO)
        Dim CTPBHDAO As New ChiTietPhieuBanHangDAO
        CTPBHDAO.SuaChiTietPhieuBanHang(CTPBHDTO)
    End Sub
End Class
