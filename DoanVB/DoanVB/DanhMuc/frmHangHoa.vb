﻿Imports BUS

Public Class frmHangHoa
    Public Shared lblmahang As String
    Private Sub frmHangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyBanHangDataSet.HANGHOA' table. You can move, or remove it, as needed.
        'Me.HANGHOATableAdapter.Fill(Me.QuanLyBanHangDataSet.HANGHOA)
        'Dim dt As DataTable = HangHoaBUS.LoadDSHangHoa()
        'Me.GridControl1.DataSource = dt
        Dim dt As DataTable = HangHoaBUS.LoadDSHangHoa()
        Me.GridControl1.DataSource = dt
        Me.lblMaHangHoa.DataBindings.Clear()
        Me.lblMaHangHoa.DataBindings.Add("Text", dt, "MaHangHoa")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemHangHoa()
        frmThem.ShowDialog()
        frmHangHoa_Load(sender, e)
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaHangHoa()
        lblmahang = Me.lblMaHangHoa.Text
        frmSua.ShowDialog()
        frmHangHoa_Load(sender, e)
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        NhatKyHeThongBUS.ThemNhatKy(frmMain.USER, "Hàng hóa", "Xóa")
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa hàng hóa có mã  " & Me.lblMaHangHoa.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If HangHoaBUS.XoaHangHoa(Me.lblMaHangHoa.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmHangHoa_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmHangHoa_Load(sender, e)
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim f As New frmXuat
        f.name = "hanghoa"
        f.ShowDialog()
    End Sub
End Class