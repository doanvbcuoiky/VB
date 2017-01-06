Imports DAO
Imports DTO

Public Class KhuVucBUS
    Public Function LoadDSKhuVuc() As DataTable
        Dim KVDAO As New KhuVucDAO
        Dim dt As DataTable
        dt = KVDAO.LoadDSKhuVuc()
        Return dt
    End Function
    Public Sub ThemKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim KVDAO As New KhuVucDAO
        KVDAO.ThemKhuVuc(KVDTO)
    End Sub
    Public Sub XoaKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim KVDAO As New KhuVucDAO
        KVDAO.XoaKhuVuc(KVDTO)
    End Sub
    Public Sub SuaKhuVuc(ByVal KVDTO As KhuVucDTO)
        Dim KVDAO As New KhuVucDAO
        KVDAO.SuaKhuVuc(KVDTO)
    End Sub
End Class
