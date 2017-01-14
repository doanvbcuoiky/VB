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
End Class