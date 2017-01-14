Imports DAO
Imports DTO

Public Class NhomHangHoaBUS
    Public Shared Function ThongTinNhomHang(ByVal manhom As String) As NhomHangHoaDTO
        Dim dt As DataTable = NhomHangHoaDAO.ThongTinNhomHang(manhom)

        If dt.Select().Count() > 0 Then
            Dim ck As Boolean = False
            If dt.Select()(0).Item(columnName:="TinhTrang").ToString() = "True" Then
                ck = True
            End If
            Dim nhomhang As New NhomHangHoaDTO(dt.Select()(0).Item(columnName:="MaNhomHang").ToString(), _
                                          dt.Select()(0).Item(columnName:="TenNhomHang").ToString(), _
                                          dt.Select()(0).Item(columnName:="GhiChu").ToString(), _
                                          ck)
            Return nhomhang
        Else
            Dim donvi2 As New NhomHangHoaDTO()
            Return donvi2
        End If

    End Function
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
