Imports DAO
Imports DTO

Public Class PhanQuyenBUS
    Public Shared Function LoadDSPhanQuyen(ByVal manguoidung As String) As DataTable
        Dim dt As DataTable
        dt = PhanQuyenDAO.LoadDSPhanQuyen(manguoidung)
        Return dt
    End Function
    Public Sub ThemPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim PQDAO As New PhanQuyenDAO
        PQDAO.ThemPhanQuyen(PQDTO)
    End Sub
    Public Sub XoaPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim PQDAO As New PhanQuyenDAO
        PQDAO.XoaPhanQuyen(PQDTO)
    End Sub
    Public Sub SuaPhanQuyen(ByVal PQDTO As PhanQuyenDTO)
        Dim PQDAO As New PhanQuyenDAO
        PQDAO.SuaPhanQuyen(PQDTO)
    End Sub
End Class
