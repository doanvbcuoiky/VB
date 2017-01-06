Imports DAO
Imports DTO

Public Class TyGiaBUS
    Public Function LoadDSTyGia() As DataTable
        Dim TGDAO As New TyGiaDAO
        Dim dt As DataTable
        dt = TGDAO.LoadDSTyGia()
        Return dt
    End Function
    Public Sub ThemTyGia(ByVal TGDTO As TyGiaDTO)
        Dim TGDAO As New TyGiaDAO
        TGDAO.ThemTyGia(TGDTO)
    End Sub
    Public Sub XoaTyGia(ByVal TGDTO As TyGiaDTO)
        Dim TGDAO As New TyGiaDAO
        TGDAO.XoaTyGia(TGDTO)
    End Sub
    Public Sub SuaTyGia(ByVal TGDTO As TyGiaDTO)
        Dim TGDAO As New TyGiaDAO
        TGDAO.SuaTyGia(TGDTO)
    End Sub
End Class
