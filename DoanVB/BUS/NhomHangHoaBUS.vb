Imports DAO
Imports DTO

Public Class NhomHangHoaBUS
    Public Shared Function LoadDSNhomHangHoa() As DataTable
        Return NhomHangHoaDAO.LoadDSNhomHangHoa()
    End Function
    Public Shared Function ThemNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO) As Boolean
        Return NhomHangHoaDAO.ThemNhomHangHoa(NHHDTO)
    End Function
    Public Shared Function XoaNhomHangHoa(ByVal manhomhang As String) As Boolean
        Return NhomHangHoaDAO.XoaNhomHangHoa(manhomhang)
    End Function
    Public Shared Function SuaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO) As Boolean
        Return NhomHangHoaDAO.SuaNhomHangHoa(NHHDTO)
    End Function
End Class
