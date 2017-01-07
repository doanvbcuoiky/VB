Imports BUS
Public Class frmNhatKyHeThong

    Private Sub frmNhatKyHeThong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NhatKyHeThongBUS.LoadDSNhatKi()
        Me.GridControl1.DataSource = dt
    End Sub
End Class