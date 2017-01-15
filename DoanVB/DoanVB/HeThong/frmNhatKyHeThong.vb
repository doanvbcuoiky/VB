Imports BUS
Public Class frmNhatKyHeThong

    Private Sub frmNhatKyHeThong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NhatKyHeThongBUS.LoadDSNhatKy()
        Me.GridControl1.DataSource = dt
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        frmNhatKyHeThong_Load(sender, e)
    End Sub
End Class