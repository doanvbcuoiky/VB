Imports DAO
Imports DTO

Public Class TyGiaBUS
    Public Shared Function LoadDSTyGia() As DataTable
        Return TyGiaDAO.LoadDSTyGia()
    End Function
    Public Shared Function ThemTyGia(ByVal TGDTO As TyGiaDTO) As Boolean
        Return TyGiaDAO.ThemTyGia(TGDTO)
    End Function
    Public Shared Function XoaTyGia(ByVal matygia As String) As Boolean
        Return TyGiaDAO.XoaTyGia(matygia)
    End Function
    Public Shared Function SuaTyGia(ByVal TGDTO As TyGiaDTO) As Boolean
        Return TyGiaDAO.SuaTyGia(TGDTO)
    End Function
End Class
