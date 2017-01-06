Imports DAO
Imports DTO

Public Class ChiTietKhoBUS
    Public Function LoadDSChiTietKho() As DataTable
        Dim CTKDAO As New ChiTietKhoDAO
        Dim dt As DataTable
        dt = CTKDAO.LoadDSChiTietKho()
        Return dt
    End Function
    Public Sub ThemChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim CTKDAO As New ChiTietKhoDAO
        CTKDAO.ThemChiTietKho(CTKDTO)
    End Sub
    Public Sub XoaChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim CTKDAO As New ChiTietKhoDAO
        CTKDAO.XoaChiTietKho(CTKDTO)
    End Sub
    Public Sub SuaChiTietKho(ByVal CTKDTO As ChiTietKhoDTO)
        Dim CTKDAO As New ChiTietKhoDAO
        CTKDAO.SuaChiTietKho(CTKDTO)
    End Sub
End Class
