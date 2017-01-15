Imports DAO
Imports DTO

Public Class KhuVucBUS
    Public Shared Function LoadDSKhuVuc() As DataTable
        Return KhuVucDAO.LoadDSKhuVuc()
    End Function
    Public Shared Function ThemKhuVuc(ByVal KVDTO As KhuVucDTO) As Boolean
        Return KhuVucDAO.ThemKhuVuc(KVDTO)
    End Function
    Public Shared Function XoaKhuVuc(ByVal makhuvuc As String) As Boolean
        Return KhuVucDAO.XoaKhuVuc(makhuvuc)
    End Function
    Public Shared Function SuaKhuVuc(ByVal KVDTO As KhuVucDTO) As Boolean
        Return KhuVucDAO.SuaKhuVuc(KVDTO)
    End Function
    Public Shared Function ThongTinKhuVuc(ByVal makhuvuc As String) As DataTable
        Return KhuVucDAO.ThongTinKhuVuc(makhuvuc)
    End Function
End Class
