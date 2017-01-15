Imports DAO
Imports DTO

Public Class NguoiDungBUS

    Public Shared Sub CapNhatMatKhau(ByVal user As String, ByVal NewPass As String)
        NguoiDungDAO.CapNhatMatKhau(user, NewPass)
    End Sub
    Public Shared Sub LuuThongTinDangNhap(ByVal manguoidung As String)
        NguoiDungDAO.LuuThongTinDangNhap(manguoidung)
    End Sub
    Public Shared Sub KhongLuuThongTinDangNhap(ByVal manguoidung As String)
        NguoiDungDAO.KhongLuuThongTinDangNhap(manguoidung)
    End Sub
    Public Shared Function KiemTraDangNhap(ByVal manguoidung As String, ByVal matkhau As String) As Boolean
        Return NguoiDungDAO.KiemTraDangNhap(manguoidung, matkhau)
    End Function
    Public Shared Function LoadDSNguoiDung() As DataTable
        Dim dt As DataTable
        dt = NguoiDungDAO.LoadDSNguoiDung()
        Return dt
    End Function
    Public Shared Function LayMatKhau(ByVal manguoidung As String) As String
        Return NguoiDungDAO.LayMatKhau(manguoidung)
    End Function
    Public Shared Function ThemNguoiDung(ByVal NDDTO As NguoiDungDTO) As Boolean
        Return NguoiDungDAO.ThemNguoiDung(NDDTO)
    End Function
    Public Shared Function XoaNguoiDung(ByVal manguoidung As String) As Boolean
        Return NguoiDungDAO.XoaNguoiDung(manguoidung)
    End Function
    Public Shared Function SuaNguoiDung(ByVal NDDTO As NguoiDungDTO) As Boolean
        Return NguoiDungDAO.SuaNguoiDung(NDDTO)
    End Function
End Class
