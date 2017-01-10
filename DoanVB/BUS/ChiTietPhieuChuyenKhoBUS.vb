Imports DAO
Imports DTO

Public Class ChiTietPhieuChuyenKhoBUS
    Public Function LoadDSChiTietPhieuChuyenKho() As DataTable
        Return ChiTietPhieuChuyenKhoDAO.LoadDSChiTietPhieuChuyenKho()
    End Function
    Public Shared Function ThemChiTietPhieuChuyenKho(ByVal CTPCKDTO As ChiTietPhieuChuyenKhoDTO) As Boolean
        Return ChiTietPhieuChuyenKhoDAO.ThemChiTietPhieuChuyenKho(CTPCKDTO)
    End Function
    Public Shared Function XoaChiTietPhieuChuyenKho(ByVal maphieu As String, ByVal mahanghoa As String) As Boolean
        Return ChiTietPhieuChuyenKhoDAO.XoaChiTietPhieuChuyenKho(maphieu, mahanghoa)
    End Function
    Public Shared Function SuaChiTietPhieuChuyenKho(ByVal CTPCKDTO As ChiTietPhieuChuyenKhoDTO) As Boolean
        Return ChiTietPhieuChuyenKhoDAO.SuaChiTietPhieuChuyenKho(CTPCKDTO)
    End Function
End Class
