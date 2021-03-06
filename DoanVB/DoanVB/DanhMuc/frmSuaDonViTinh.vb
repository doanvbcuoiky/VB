﻿Imports DTO
Imports BUS
Public Class frmSuaDonViTinh

    Private Sub frmSuaDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim donvi As DonViTinhDTO = DonViTinhBUS.ThongTinDonVi(frmDonViTinh.madonvi)

        Me.txtMaDonVi.Text = donvi.MaDonVi1
        Me.txtTenDonVi.Text = donvi.TenDonVi1
        Me.txtGhiChu.Text = donvi.GhiChu1
        Me.ckTinhTrang.Checked = donvi.TinhTrang1

    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Đơn vụi tính", "Sửa đơn vị" & Me.txtMaDonVi.Text.ToString())
        Dim donvitinh As New DonViTinhDTO(Me.txtMaDonVi.Text, Me.txtTenDonVi.Text, Me.txtGhiChu.Text, Me.ckTinhTrang.Checked)
        If DonViTinhBUS.SuaDonViTinh(donvitinh) = True Then
            MessageBox.Show("Sửa thành công.")
            Me.Close()
        Else
            MessageBox.Show("Không sửa được.")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub
End Class