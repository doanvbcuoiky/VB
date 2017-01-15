Imports DAO
Imports DTO

Public Class PhanQuyenBUS
    Public Shared Function LoadDSPhanQuyen(ByVal manguoidung As String) As DataTable
        Dim dt As DataTable
        dt = PhanQuyenDAO.LoadDSPhanQuyen(manguoidung)
        Return dt
    End Function
    Public Shared Function ThemPhanQuyen(ByVal PQDTO As PhanQuyenDTO) As Boolean
        Return PhanQuyenDAO.ThemPhanQuyen(PQDTO)
    End Function
    Public Shared Function XoaPhanQuyen(ByVal mapq As String) As Boolean
        'Return PhanQuyenDAO.XoaPhanQuyen(mapq)
        Return False
    End Function
    Public Shared Function SuaPhanQuyen(ByVal PQDTO As PhanQuyenDTO) As Boolean
        Return PhanQuyenDAO.SuaPhanQuyen(PQDTO)
    End Function
End Class
