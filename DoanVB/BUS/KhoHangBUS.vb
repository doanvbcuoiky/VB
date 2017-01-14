Imports DAO
Imports DTO

Public Class KhoHangBUS
    Public Shared Function ThongTinKhoHang(ByVal ma As String) As KhoHangDTO
        Dim dt As DataTable = KhoHangDAO.ThongTinKhoHang(ma)
        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = True
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "False" Then
                ck = False
            End If
            Dim khohang As New KhoHangDTO(dt.Select()(0).Item(columnName:="MaKhoHang").ToString(), _
                                          dt.Select()(0).Item(columnName:="KiHieu").ToString(), _
                                          dt.Select()(0).Item(columnName:="TenKhoHang").ToString(), _
                                          dt.Select()(0).Item(columnName:="NguoiQuanLi").ToString(), _
                                          dt.Select()(0).Item(columnName:="NguoiLienHe").ToString(), _
                                          dt.Select()(0).Item(columnName:="DiaChi").ToString(), _
                                          dt.Select()(0).Item(columnName:="DienThoai").ToString(), _
                                          dt.Select()(0).Item(columnName:="Fax").ToString(), _
                                          dt.Select()(0).Item(columnName:="Email").ToString(), _
                                          dt.Select()(0).Item(columnName:="DienGiai").ToString(), _
                                          ck)
            Return khohang
        Else
            Dim khohang2 As New KhoHangDTO()
            Return khohang2
        End If
    End Function
    Public Shared Function LoadDSKhoHang() As DataTable
        Return KhoHangDAO.LoadDSKhoHang()
    End Function
    Public Shared Function ThemKhoHang(ByVal KHDTO As KhoHangDTO) As Boolean
        Return KhoHangDAO.ThemKhoHang(KHDTO)
    End Function
    Public Shared Function XoaKhoHang(ByVal makhohang As String) As Boolean
        Return KhoHangDAO.XoaKhoHang(makhohang)
    End Function
    Public Shared Function SuaKhoHang(ByVal KHDTO As KhoHangDTO) As Boolean
        Return KhoHangDAO.SuaKhoHang(KHDTO)
    End Function
End Class
