Imports BUS
Public Class frmKhuVuc

    Private Sub DockPanel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.GridControl1.DataSource = dt
    End Sub
End Class