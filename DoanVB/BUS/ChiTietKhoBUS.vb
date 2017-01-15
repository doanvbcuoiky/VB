Imports DAO
Imports DTO

Public Class ChiTietKhoBUS
    Public Function LoadDSChiTietKho() As DataTable
        Return ChiTietKhoDAO.LoadDSChiTietKho()
    End Function
    Public Shared Function ThemChiTietKho(ByVal CTKDTO As ChiTietKhoDTO) As Boolean
        Return ChiTietKhoDAO.ThemChiTietKho(CTKDTO)
    End Function
    Public Shared Function GiamChiTietKho(ByVal CTKDTO As ChiTietKhoDTO) As Boolean
        Return ChiTietKhoDAO.GiamChiTietKho(CTKDTO)
    End Function
    Public Function XoaChiTietKho(ByVal machitiet As String, ByVal mahanghoa As String) As Boolean
        Return ChiTietKhoDAO.XoaChiTietKho(machitiet, MaHanghoa)
    End Function
    Public Function SuaChiTietKho(ByVal CTKDTO As ChiTietKhoDTO) As Boolean
        Return ChiTietKhoDAO.SuaChiTietKho(CTKDTO)
    End Function
End Class
