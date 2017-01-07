Imports DAO
Imports DTO

Public Class DonViTinhBUS
    Public Shared Function LoadDSDonViTinh() As DataTable
        Return DonViTinhDAO.LoadDSDonViTinh()
    End Function
    Public Sub ThemDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim DVTDAO As New DonViTinhDAO
        DVTDAO.ThemDonViTinh(DVTDTO)
    End Sub
    Public Sub XoaDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim DVTDAO As New DonViTinhDAO
        DVTDAO.XoaDonViTinh(DVTDTO)
    End Sub
    Public Sub SuaDonViTinh(ByVal DVTDTO As DonViTinhDTO)
        Dim DVTDAO As New DonViTinhDAO
        DVTDAO.SuaDonViTinh(DVTDTO)
    End Sub
End Class
