Imports BUS
Public Class frmKhuVuc

    Public Shared lblmakh As String
    Private Sub DockPanel4_Click(sender As Object, e As EventArgs)
    End Sub
    Public Sub frmKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = KhuVucBUS.LoadDSKhuVuc()
        Me.GridControl1.DataSource = dt
        Me.lblMaKhuVuc.DataBindings.Clear()
        Me.lblMaKhuVuc.DataBindings.Add("Text", dt, "MaKhuVuc")
    End Sub
    'Them khu vuc
    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Dim frmThem = New frmThemKhuVuc()
        frmThem.ShowDialog()
    End Sub
    'Xoa khu vuc
    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim dlgresult = MessageBox.Show("Bạn muốn xóa nhân viên có mã  " & Me.lblMaKhuVuc.Text & " không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgresult = Windows.Forms.DialogResult.Yes Then
            If KhuVucBUS.XoaKhuVuc(Me.lblMaKhuVuc.Text) = True Then
                MessageBox.Show("Đã xóa.")
                Me.frmKhuVuc_Load(sender, e)
            End If
        End If
    End Sub
    'Sua khu vuc
    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Dim frmSua = New frmSuaKhuVuc()
        lblmakh = Me.lblMaKhuVuc.Text
        frmSua.ShowDialog()
    End Sub
    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
   

    Private Sub GridControl1_Load(sender As Object, e As EventArgs) Handles GridControl1.Load

    End Sub
   
End Class