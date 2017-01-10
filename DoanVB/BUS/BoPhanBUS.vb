Imports DAO
Imports DTO

Public Class BoPhanBUS
    Public Shared Function LoadDSBoPhan() As DataTable
        ' Dim dt As DataTable
        'dt = BoPhanDAO.LoadDSBoPhan()
        'Return dt
        Return BoPhanDAO.LoadDSBoPhan()
    End Function
    Public Shared Function ThemBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Return BoPhanDAO.ThemBoPhan(BPDTO)
    End Function
    Public Shared Function XoaBoPhan(ByVal mabophan As String) As Boolean
        Return BoPhanDAO.XoaBoPhan(mabophan)
    End Function
    Public Function SuaBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Return BoPhanDAO.SuaBoPhan(BPDTO)
    End Function

End Class
