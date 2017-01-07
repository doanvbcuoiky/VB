Imports BUS

Public Class frmHangHoa
    Private Sub frmHangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyBanHangDataSet.HANGHOA' table. You can move, or remove it, as needed.
        'Me.HANGHOATableAdapter.Fill(Me.QuanLyBanHangDataSet.HANGHOA)
        Dim dt As DataTable = HangHoaBUS.LoadDSHangHoa()
        Me.GridControl1.DataSource = dt
    End Sub
End Class