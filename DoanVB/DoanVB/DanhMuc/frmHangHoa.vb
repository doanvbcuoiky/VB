Imports BUS

Public Class frmHangHoa
    Private Sub frmHangHoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuanLyBanHangDataSet.HANGHOA' table. You can move, or remove it, as needed.
        'Me.HANGHOATableAdapter.Fill(Me.QuanLyBanHangDataSet.HANGHOA)
        'Dim dt As DataTable = HangHoaBUS.LoadDSHangHoa()
        'Me.GridControl1.DataSource = dt
        Dim dt As DataTable = HangHoaBUS.LoadDSHangHoa()
        Me.GridControl1.DataSource = dt
        Me.lblMaHangHoa.DataBindings.Clear()
        Me.lblMaHangHoa.DataBindings.Add("Text", dt, "MaHangHoa")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemHangHoa()
        frmThem.ShowDialog()
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmSuaKhuVuc()
        frmKhuVuc.lblmakh = Me.lblMaHangHoa.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaHangHoa.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If HangHoaBUS.XoaHangHoa(Me.lblMaHangHoa.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmHangHoa_Load(sender, e)
            End If
        End If
    End Sub
End Class