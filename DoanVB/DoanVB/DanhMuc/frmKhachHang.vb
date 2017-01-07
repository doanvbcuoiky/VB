Imports DTO
Imports BUS

Public Class frmKhachHang

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs)
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
End Class