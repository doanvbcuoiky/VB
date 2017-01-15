Imports DAO
Imports DTO

Public Class PhieuChuyenKhoBUS
    Public Shared Function LoadDSPhieuChuyenKho() As DataTable
        Return PhieuChuyenKhoDAO.LoadDSPhieuChuyenKho()
    End Function
    Public Shared Function ThemPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Return PhieuChuyenKhoDAO.ThemPhieuChuyenKho(PCKDTO)
    End Function
    Public Shared Function XoaPhieuChuyenKho(ByVal maphieuchuyen As String)
        Return PhieuChuyenKhoDAO.XoaPhieuChuyenKho(maphieuchuyen)
    End Function
    Public Shared Function SuaPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Return PhieuChuyenKhoDAO.SuaPhieuChuyenKho(PCKDTO)
    End Function
End Class
