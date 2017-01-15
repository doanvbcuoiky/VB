Imports DAO
Imports DTO

Public Class BoPhanBUS
    Public Shared Function ThongTinBoPhan(ByVal ma As String) As BoPhanDTO
        Dim dt As DataTable = BoPhanDAO.ThongTinBoPhan(ma)
        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = True
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "False" Then
                ck = False
            End If
            Dim bophan As New BoPhanDTO(dt.Select()(0).Item(columnName:="MaBoPhan").ToString(), _
                                        dt.Select()(0).Item(columnName:="TenBoPhan").ToString(), _
                                        dt.Select()(0).Item(columnName:="GhiChu").ToString(), _
                                        ck)
            Return bophan
        Else
            Dim bophan2 As New BoPhanDTO()
            Return bophan2
        End If
    End Function
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
    Public Shared Function SuaBoPhan(ByVal BPDTO As BoPhanDTO) As Boolean
        Return BoPhanDAO.SuaBoPhan(BPDTO)
    End Function

End Class
