Imports DAO
Imports DTO

Public Class BoPhanBUS
    Public Function LoadDSBoPhan() As DataTable
        Dim dt As DataTable
        dt = BoPhanDAO.LoadDSBoPhan()
        Return dt
    End Function
    Public Shared Function ThemBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        BoPhanDAO.ThemBoPhan(BPDTO)
    End Function
    Public Shared Function XoaBoPhan(ByVal mabophan As String) As Boolean
        Return BoPhanDAO.XoaBoPhan(mabophan)
    End Function
    Public Function SuaBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Return BoPhanDAO.SuaBoPhan(BPDTO)
    End Function

End Class
