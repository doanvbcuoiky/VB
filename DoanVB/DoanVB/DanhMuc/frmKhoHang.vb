Imports BUS
Imports DTO
Public Class frmKhoHang

    Private Sub frmKhoHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhoHangBUS.LoadDSKhoHang()
        Me.GridControl1.DataSource = dt
    End Sub
End Class