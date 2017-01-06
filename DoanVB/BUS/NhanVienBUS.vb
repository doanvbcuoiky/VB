Imports DAO
Imports DTO

Public Class NhanVienBUS
    Public Function LoadDSNhanVien() As DataTable
        Dim NVDAO As New NhanVienDAO
        Dim dt As DataTable
        dt = NVDAO.LoadDSNhanVien()
        Return dt
    End Function
    Public Sub ThemNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim NVDAO As New NhanVienDAO
        NVDAO.ThemNhanVien(NVDTO)
    End Sub
    Public Sub XoaNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim NVDAO As New NhanVienDAO
        NVDAO.XoaNhanVien(NVDTO)
    End Sub
    Public Sub SuaNhanVien(ByVal NVDTO As NhanVienDTO)
        Dim NVDAO As New NhanVienDAO
        NVDAO.SuaNhanVien(NVDTO)
    End Sub
End Class
