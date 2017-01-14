Imports DTO
Imports BUS
Public Class frmSuaDonViTinh

    Private Sub frmSuaDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim donvi As DonViTinhDTO = DonViTinhBUS.ThongTinDonVi(frmDonViTinh.madonvi)

        Me.txtMaDonVi.Text = donvi.MaDonVi1
        Me.txtTenDonVi.Text = donvi.TenDonVi1
        Me.txtGhiChu.Text = donvi.GhiChu1
        Me.ckTinhTrang.Checked = donvi.TinhTrang1

    End Sub
End Class