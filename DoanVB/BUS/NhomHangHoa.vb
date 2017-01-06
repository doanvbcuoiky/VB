Imports DAO
Imports DTO

Public Class NhomHangHoa
    Public Function LoadDSNhomHangHoa() As DataTable
        Dim NHHDAO As New NhomHangHoaDAO
        Dim dt As DataTable
        dt = NHHDAO.LoadDSNhomHangHoa()
        Return dt
    End Function
    Public Sub ThemNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim NHHDAO As New NhomHangHoaDAO
        NHHDAO.ThemNhomHangHoa(NHHDTO)
    End Sub
    Public Sub XoaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim NHHDAO As New NhomHangHoaDAO
        NHHDAO.XoaNhomHangHoa(NHHDTO)
    End Sub
    Public Sub SuaNhomHangHoa(ByVal NHHDTO As NhomHangHoaDTO)
        Dim NHHDAO As New NhomHangHoaDAO
        NHHDAO.SuaNhomHangHoa(NHHDTO)
    End Sub
End Class
