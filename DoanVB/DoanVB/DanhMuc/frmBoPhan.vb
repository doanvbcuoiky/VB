Imports BUS
Public Class frmBoPhan

    Public Shared mabophan As String
    Private Sub frmBoPhan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = BoPhanBUS.LoadDSBoPhan()
        Me.GridControl1.DataSource = dt
        Me.lblMaBoPhan.DataBindings.Clear()
        Me.lblMaBoPhan.DataBindings.Add("Text", dt, "MaBoPhan")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemBoPhan()
        frmThem.ShowDialog()
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaBoPhan()
        mabophan = Me.lblMaBoPhan.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaBoPhan.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If BoPhanBUS.XoaBoPhan(Me.lblMaBoPhan.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmBoPhan_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmBoPhan_Load(sender, e)
    End Sub
End Class