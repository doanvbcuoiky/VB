Imports DAO
Imports DTO

Public Class DonViTinhBUS

    Public Shared Function ThongTinDonVi(ByVal Madonvi As String) As DonViTinhDTO
        Dim dt As DataTable = DonViTinhDAO.ThongTindonVi(Madonvi)

        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = False
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "True" Then
                ck = True
            End If
            Dim donvi As New DonViTinhDTO(dt.Select()(0).Item(columnName:="MaDonVi").ToString(), _
                                          dt.Select()(0).Item(columnName:="TenDonVi").ToString(), _
                                          dt.Select()(0).Item(columnName:="GhiChu").ToString(), _
                                          ck)
            Return donvi
        Else
            Dim donvi2 As New DonViTinhDTO()
            Return donvi2
        End If
    End Function
    Public Shared Function LoadDSDonViTinh() As DataTable
        Return DonViTinhDAO.LoadDSDonViTinh()
    End Function
    Public Shared Function ThemDonViTinh(ByVal DVTDTO As DonViTinhDTO) As Boolean
        Return DonViTinhDAO.ThemDonViTinh(DVTDTO)
    End Function
    Public Shared Function XoaDonViTinh(ByVal madonvi As String) As Boolean
        Return DonViTinhDAO.XoaDonViTinh(madonvi)
    End Function
    Public Shared Function SuaDonViTinh(ByVal DVTDTO As DonViTinhDTO) As Boolean
        Return DonViTinhDAO.SuaDonViTinh(DVTDTO)
    End Function
End Class
