Imports DAO
Imports DTO

Public Class DonViTinhBUS
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
