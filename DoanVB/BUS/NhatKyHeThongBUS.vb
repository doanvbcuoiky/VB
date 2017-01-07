Imports DTO
Imports DAO
Public Class NhatKyHeThongBUS
    Public Shared Function LoadDSNhatKy() As DataTable
        Return NhatKyHeThongDAO.LoadDSNhatKy()
    End Function
End Class
