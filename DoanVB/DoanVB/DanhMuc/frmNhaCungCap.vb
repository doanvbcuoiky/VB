Imports DTO
Imports BUS

Public Class frmNhaCungCap

    Private Sub frmNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NhaCungCapBUS.LoadDSNhaCungCap()
        Me.GridControl1.DataSource = dt
    End Sub
End Class