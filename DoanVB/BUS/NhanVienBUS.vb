Imports DAO
Imports DTO

Public Class NhanVienBUS
    Public Shared Function LoadDSNhanVien() As DataTable
        Return NhanVienDAO.LoadDSNhanVien()
    End Function
    Public Shared Function ThemNhanVien(ByVal NVDTO As NhanVienDTO) As Boolean
        Return NhanVienDAO.ThemNhanVien(NVDTO)
    End Function
    Public Shared Function XoaNhanVien(ByVal manv As String) As Boolean
        Return NhanVienDAO.XoaNhanVien(manv)
    End Function
    Public Shared Function SuaNhanVien(ByVal NVDTO As NhanVienDTO) As Boolean
        Return NhanVienDAO.SuaNhanVien(NVDTO)
    End Function
End Class
