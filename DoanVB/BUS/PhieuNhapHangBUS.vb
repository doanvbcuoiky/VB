Imports DAO
Imports DTO

Public Class PhieuNhapHangBUS
    Public Function LoadDSPhieuNhapHang() As DataTable
        Dim PNHDAO As New PhieuNhapHangDAO
        Dim dt As DataTable
        dt = PNHDAO.LoadDSPhieuNhapHang()
        Return dt
    End Function
    Public Sub ThemPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim PNHDAO As New PhieuNhapHangDAO
        PNHDAO.ThemPhieuNhapHang(PNHDTO)
    End Sub
    Public Sub XoaPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim PNHDAO As New PhieuNhapHangDAO
        PNHDAO.XoaPhieuNhapHang(PNHDTO)
    End Sub
    Public Sub SuaPhieuNhapHang(ByVal PNHDTO As PhieuNhapHangDTO)
        Dim PNHDAO As New PhieuNhapHangDAO
        PNHDAO.SuaPhieuNhapHang(PNHDTO)
    End Sub
End Class
