Imports DAO
Imports DTO

Public Class DonViTinhBUS
    Public Function LoadDSDonViTinh() As DataTable
        Dim DVTDAO As New DonViTinhDAO
        Dim dt As DataTable
        dt = DVTDAO.LoadDSDonViTinh()
        Return dt
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
