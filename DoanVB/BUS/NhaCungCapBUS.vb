Imports DAO
Imports DTO

Public Class NhaCungCapBUS
    Public Shared Function LoadDSNhaCungCap() As DataTable
        Return NhaCungCapDAO.LoadDSNhaCungCap()
    End Function
    Public Sub ThemNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim NCCDAO As New NhaCungCapDAO
        NCCDAO.ThemNhaCungCap(NCCDTO)
    End Sub
    Public Sub XoaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim NCCDAO As New NhaCungCapDAO
        NCCDAO.XoaNhaCungCap(NCCDTO)
    End Sub
    Public Sub SuaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO)
        Dim NCCDAO As New NhaCungCapDAO
        NCCDAO.SuaNhaCungCap(NCCDTO)
    End Sub
End Class
