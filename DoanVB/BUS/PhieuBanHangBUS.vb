Imports DAO
Imports DTO

Public Class PhieuBanHangBUS
    Public Function LoadDSPhieuBanHang() As DataTable
        Dim PBHDAO As New PhieuBanHangDAO
        Dim dt As DataTable
        dt = PBHDAO.LoadDSPhieuBanHang()
        Return dt
    End Function
    Public Sub ThemPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO)
        Dim PBHDAO As New PhieuBanHangDAO
        PBHDAO.ThemPhieuBanHang(PBHDTO)
    End Sub
    Public Sub XoaPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO)
        Dim PBHDAO As New PhieuBanHangDAO
        PBHDAO.XoaPhieuBanHang(PBHDTO)
    End Sub
    Public Sub SuaPhieuBanHang(ByVal PBHDTO As PhieuBanHangDTO)
        Dim PBHDAO As New PhieuBanHangDAO
        PBHDAO.SuaPhieuBanHang(PBHDTO)
    End Sub
End Class
