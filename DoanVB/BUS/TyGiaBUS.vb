Imports DAO
Imports DTO

Public Class TyGiaBUS
    Public Shared Function ThongTinTyGia(ByVal ma As String) As TyGiaDTO
        Dim dt As DataTable = TyGiaDAO.ThongTinTyGia(ma)
        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = True
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "False" Then
                ck = False
            End If
            Dim tygia As New TyGiaDTO(dt.Select()(0).Item(columnName:="MaTienTe").ToString(), _
                                      dt.Select()(0).Item(columnName:="TenTienTe").ToString(), _
                                      System.Convert.ToDouble(dt.Select()(0).Item(columnName:="TyGiaquyDoi").ToString()), _
                                      ck)
            Return tygia
        Else
            Dim tygia2 As New TyGiaDTO()
            Return tygia2
        End If
    End Function
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
