Imports DAO
Imports DTO

Public Class HangHoaBUS
    Public Shared Function LoadDSHangHoa() As DataTable
        Dim dt As DataTable = HangHoaDAO.LoadDSHangHoa()
        Return dt
    End Function
    Public Sub ThemHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim HHDAO As New HangHoaDAO
        HHDAO.ThemHangHoa(HHDTO)
    End Sub
    Public Sub XoaHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim HHDAO As New HangHoaDAO
        HHDAO.XoaHangHoa(HHDTO)
    End Sub
    Public Sub SuaHangHoa(ByVal HHDTO As HangHoaDTO)
        Dim HHDAO As New HangHoaDAO
        HHDAO.SuaHangHoa(HHDTO)
    End Sub
End Class
