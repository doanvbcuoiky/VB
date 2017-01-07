Imports DAO
Imports DTO

Public Class NguoiDungBUS

    Public Shared Sub CapNhatMatKhau(ByVal user As String, ByVal NewPass As String)
        NguoiDungDAO.CapNhatMatKhau(user, NewPass)
    End Sub
    Public Shared Sub LuuThongTinDangNhap(ByVal manguoidung As String)
        NguoiDungDAO.LuuThongTinDangNhap(manguoidung)
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
    Public Sub ThemNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim NDDAO As New NguoiDungDAO
        NDDAO.ThemNguoiDung(NDDTO)
    End Sub
    Public Sub XoaNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim NDDAO As New NguoiDungDAO
        NDDAO.XoaNguoiDung(NDDTO)
    End Sub
    Public Sub SuaNguoiDung(ByVal NDDTO As NguoiDungDTO)
        Dim NDDAO As New NguoiDungDAO
        NDDAO.SuaNguoiDung(NDDTO)
    End Sub
End Class
