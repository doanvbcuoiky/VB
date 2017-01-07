Imports BUS
Imports DTO
Public Class frmDonViTinh

    Private Sub frmDonViTinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = DonViTinhBUS.LoadDSDonViTinh()
        Me.GridControl1.DataSource = dt
    End Sub
End Class