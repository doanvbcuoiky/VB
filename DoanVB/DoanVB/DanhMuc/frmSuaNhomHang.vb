Imports DTO
Imports BUS
Public Class frmSuaNhomHang

    Private Sub frmSuaNhomHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nhomhang As NhomHangHoaDTO = NhomHangHoaBUS.ThongTinNhomHang(frmNhomHang.manhomhang)

        Me.txtMaNhomHang.Text = nhomhang.MaNhomHang1
        Me.txtTenNhomHang.Text = nhomhang.TenNhomHang1
        Me.txtGhiChu.Text = nhomhang.GhiChu1
        Me.ckTinhTrang.Checked = nhomhang.TinhTrang1
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim nhomhang As New NhomHangHoaDTO(Me.txtMaNhomHang.Text, Me.txtTenNhomHang.Text, _
                                           Me.txtGhiChu.Text, True)
        If NhomHangHoaBUS.SuaNhomHangHoa(nhomhang) = True Then
            MessageBox.Show("Sửa thành công")
        Else
            MessageBox.Show("Không sửa đưuọc")
        End If
    End Sub
End Class