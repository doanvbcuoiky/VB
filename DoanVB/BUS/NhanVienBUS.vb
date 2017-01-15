Imports DAO
Imports DTO

Public Class NhanVienBUS

    Public Shared Function ThongTinNhanVien(ByVal MaNhanVien As String) As NhanVienDTO
        Dim dt As DataTable = NhanVienDAO.ThongTinNhanVien(MaNhanVien)
        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = False
            If dt.Select()(0).Item("TinhTrang").ToString = "True" Then
                ck = True
            End If
            Dim nhanvien As New NhanVienDTO(dt.Select()(0).Item(columnName:="MaNhanVien").ToString(), _
                                            dt.Select()(0).Item(columnName:="TenNhanVien").ToString(), _
                                            dt.Select()(0).Item(columnName:="ChucVu").ToString(), _
                                            dt.Select()(0).Item(columnName:="DiaChi").ToString(), _
                                            dt.Select()(0).Item(columnName:="Emai").ToString(), _
                                            dt.Select()(0).Item(columnName:="DienThoai").ToString(), _
                                            dt.Select()(0).Item(columnName:="BoPhan").ToString(), _
                                            dt.Select()(0).Item(columnName:="NguoiQuanLi").ToString(), _
                                            ck)
            Return nhanvien
        End If
        Dim nhanvien2 As New NhanVienDTO()
        Return nhanvien2
    End Function
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
