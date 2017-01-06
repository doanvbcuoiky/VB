Imports DAO
Imports DTO

Public Class PhieuChuyenKhoBUS
    Public Function LoadDSPhieuChuyenKho() As DataTable
        Dim PCKDAO As New PhieuChuyenKhoDAO
        Dim dt As DataTable
        dt = PCKDAO.LoadDSPhieuChuyenKho()
        Return dt
    End Function
    Public Sub ThemPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Dim PCKDAO As New PhieuChuyenKhoDAO
        PCKDAO.ThemPhieuChuyenKho(PCKDTO)
    End Sub
    Public Sub XoaPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Dim PCKDAO As New PhieuChuyenKhoDAO
        PCKDAO.XoaPhieuChuyenKho(PCKDTO)
    End Sub
    Public Sub SuaPhieuChuyenKho(ByVal PCKDTO As PhieuChuyenKhoDTO)
        Dim PCKDAO As New PhieuChuyenKhoDAO
        PCKDAO.SuaPhieuChuyenKho(PCKDTO)
    End Sub
End Class
