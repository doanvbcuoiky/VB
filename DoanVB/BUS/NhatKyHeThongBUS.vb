Imports DTO
Imports DAO
Public Class NhatKyHeThongBUS
    Public Shared Function LoadDSNhatKy() As DataTable
        Return NhatKyHeThongDAO.LoadDSNhatKy()
    End Function
    Public Shared Sub ThemNhatKy(ByVal user As String, ByVal chucnang As String, ByVal hanhdong As String)
        NhatKyHeThongDAO.ThemNhatKy(user, chucnang, hanhdong)
    End Sub
End Class
