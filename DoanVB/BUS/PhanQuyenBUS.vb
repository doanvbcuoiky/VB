Imports DAO
Imports DTO

Public Class PhanQuyenBUS
    Public Function LoadDSPhanQuyen() As DataTable
        Dim PQDAO As New PhanQuyenDAO
        Dim dt As DataTable
        dt = PQDAO.LoadDSPhanQuyen()
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
