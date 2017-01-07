Imports DTO
Imports BUS

Public Class frmKhachHang

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs)
        Dim dt As DataTable = KhachHangBUS.LoadDSKhachHang()
        Me.GridControl1.DataSource = dt
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub GridControl1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class