Imports DAO
Imports DTO

Public Class NhaCungCapBUS
    Public Shared Function LoadDSNhaCungCap() As DataTable
        Return NhaCungCapDAO.LoadDSNhaCungCap()
    End Function
    Public Shared Function ThemNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Return NhaCungCapDAO.ThemNhaCungCap(NCCDTO)
    End Function
    Public Shared Function XoaNhaCungCap(ByVal mancc As String) As Boolean
        Return NhaCungCapDAO.XoaNhaCungCap(mancc)
    End Function
    Public Shared Function SuaNhaCungCap(ByVal NCCDTO As NhaCungCapDTO) As Boolean
        Return NhaCungCapDAO.SuaNhaCungCap(NCCDTO)
    End Function
End Class
