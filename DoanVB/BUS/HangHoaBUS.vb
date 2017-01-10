Imports DAO
Imports DTO

Public Class HangHoaBUS
    Public Shared Function LoadDSHangHoa() As DataTable
        Dim dt As DataTable = HangHoaDAO.LoadDSHangHoa()
        Return dt
    End Function
    Public Shared Function ThemHangHoa(ByVal HHDTO As HangHoaDTO)
        Return HangHoaDAO.ThemHangHoa(HHDTO)
    End Function
    Public Shared Function XoaHangHoa(ByVal mahanghoa As String)
        Return HangHoaDAO.XoaHangHoa(mahanghoa)
    End Function
    Public Shared Function SuaHangHoa(ByVal HHDTO As HangHoaDTO)
        Return HangHoaDAO.SuaHangHoa(HHDTO)
    End Function
End Class
