﻿Imports BUS
Public Class frmKhuVuc

    Private Sub DockPanel4_Click(sender As Object, e As EventArgs)
    End Sub
    Public Sub frmKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.GridControl1.DataSource = dt
        Me.lblMaKhuVuc.DataBindings.Clear()
        Me.lblMaKhuVuc.DataBindings.Add("Text", dt, "MaKhuVuc")
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Dim frmThem = New frmThemKhuVuc()
        frmThem.ShowDialog()
    End Sub
    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaKhuVuc.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If KhuVucBUS.XoaKhuVuc(Me.lblMaKhuVuc.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmKhuVuc_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub GridControl1_Load(sender As Object, e As EventArgs) Handles GridControl1.Load

    End Sub
End Class