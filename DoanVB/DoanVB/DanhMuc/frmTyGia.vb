Imports BUS
Public Class frmTyGia

    Private Sub frmTyGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = TyGiaBUS.LoadDSTyGia()
        Me.GridControl1.DataSource = dt
        Me.lblMaTienTe.DataBindings.Clear()
        Me.lblMaTienTe.DataBindings.Add("Text", dt, "MaTienTe")
    End Sub

    Private Sub btnThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        Dim frmThem = New frmThemTyGia()
        frmThem.ShowDialog()
    End Sub

    Private Sub btnSua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSua.ItemClick
        Dim frmSua = New frmTyGia()
        frmKhuVuc.lblmakh = Me.lblMaTienTe.Text
        frmSua.ShowDialog()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaTienTe.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If TyGiaBUS.XoaTyGia(Me.lblMaTienTe.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmTyGia_Load(sender, e)
            End If
        End If
    End Sub
End Class