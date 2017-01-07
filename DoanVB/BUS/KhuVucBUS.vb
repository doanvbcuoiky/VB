Imports DAO
Imports DTO

Public Class KhuVucBUS
    Public Shared Function LoadDSKhuVuc() As DataTable
        Return KhuVucDAO.LoadDSKhuVuc()
    End Function
    Public Shared Function ThemKhuVuc(ByVal KVDTO As KhuVucDTO) As Boolean
        Return KhuVucDAO.ThemKhuVuc(KVDTO)
    End Function
    Public Sub XoaKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim KVDAO As New KhuVucDAO
        KVDAO.XoaKhuVuc(KVDTO)
    End Sub
    Public Sub SuaKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim KVDAO As New KhuVucDAO
        KVDAO.SuaKhuVuc(KVDTO)
    End Sub
End Class
