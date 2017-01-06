Imports DAO
Imports DTO

Public Class ChiTietPhieuChuyenKhoBUS
    Public Function LoadDSChiTietPhieuChuyenKho() As DataTable
        Dim CTPCKDAO As New ChiTietPhieuChuyenKhoDAO
        Dim dt As DataTable
        dt = CTPCKDAO.LoadDSChiTietPhieuChuyenKho()
        Return dt
    End Function
    Public Sub ThemChiTietPhieuChuyenKho(ByVal CTPCKDTO As ChiTietPhieuChuyenKhoDTO)
        Dim CTPCKDAO As New ChiTietPhieuChuyenKhoDAO
        CTPCKDAO.ThemChiTietPhieuChuyenKho(CTPCKDTO)
    End Sub
    Public Sub XoaChiTietPhieuChuyenKho(ByVal CTPCKDTO As ChiTietPhieuChuyenKhoDTO)
        Dim CTPCKDAO As New ChiTietPhieuChuyenKhoDAO
        CTPCKDAO.XoaChiTietPhieuChuyenKho(CTPCKDTO)
    End Sub
    Public Sub SuaChiTietPhieuChuyenKho(ByVal CTPCKDTO As ChiTietPhieuChuyenKhoDTO)
        Dim CTPCKDAO As New ChiTietPhieuChuyenKhoDAO
        CTPCKDAO.SuaChiTietPhieuChuyenKho(CTPCKDTO)
    End Sub
End Class
