Imports DAO
Imports DTO

Public Class BoPhanBUS
    Public Function LoadDSBoPhan() As DataTable
        Dim BPDAO As New BoPhanDAO
        Dim dt As DataTable
        dt = BPDAO.LoadDSBoPhan()
        Return dt
    End Function
    Public Sub ThemBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim BPDAO As New BoPhanDAO
        BPDAO.ThemBoPhan(BPDTO)
    End Sub
    Public Sub XoaBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim BPDAO As New BoPhanDAO
        BPDAO.XoaBoPhan(BPDTO)
    End Sub
    Public Sub SuaBoPhan(ByVal BPDTO As BoPhanDTO)
        Dim BPDAO As New BoPhanDAO
        BPDAO.SuaBoPhan(BPDTO)
    End Sub

End Class
