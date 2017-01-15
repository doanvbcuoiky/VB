Imports BUS
Public Class frmNhomHang

    Public Shared manhomhang As String
    Private Sub frmNhomHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = NhomHangHoaBUS.LoadDSNhomHangHoa()
        Me.GridControl1.DataSource = dt
        Me.lblMaNhomHang.DataBindings.Clear()
        Me.lblMaNhomHang.DataBindings.Add("Text", dt, "MaNhomHang")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemNhomHang()
        frmThem.ShowDialog()
        frmNhomHang_Load(sender, e)
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaNhomHang()
        manhomhang = Me.lblMaNhomHang.Text
        frmSua.ShowDialog()
        frmNhomHang_Load(sender, e)
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaNhomHang.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If NhomHangHoaBUS.XoaNhomHangHoa(Me.lblMaNhomHang.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmNhomHang_Load(sender, e)
            End If
        End If
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmNhomHang_Load(sender, e)
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Me.Close()
    End Sub
End Class