﻿Imports DTO
Imports BUS

Public Class frmKhachHang

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs)
        Dim dt As DataTable = KhachHangBUS.LoadDSKhachHang()
        Me.GridControl1.DataSource = dt
        Me.lblMaKhachHang.DataBindings.Clear()
        Me.lblMaKhachHang.DataBindings.Add("Text", dt, "MaKhachHang")
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub GridControl1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmKhachHang_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyBanHangDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
        'Me.KHACHHANGTableAdapter.Fill(Me.QuanLyBanHangDataSet1.KHACHHANG)
        Dim dt As DataTable = KhachHangBUS.LoadDSKhachHang()
        Me.GridControl1.DataSource = dt
    End Sub

    Private Sub GridControl1_Click_2(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub bbtThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmkh As New frmThemKhachHang()
        frmkh.ShowDialog()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaKhachHang()
        frmKhuVuc.lblmakh = Me.lblMaKhachHang.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaKhachHang.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If KhachHangBUS.XoaKhachHang(Me.lblMaKhachHang.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmKhachHang_Load(sender, e)
            End If
        End If
    End Sub
End Class