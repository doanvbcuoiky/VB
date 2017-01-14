Imports DTO
Imports BUS

Public Class frmSuaTyGia

    Private Sub frmSuaTyGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tygia As TyGiaDTO = TyGiaBUS.ThongTinTyGia(frmTyGia.matiente)

        Me.txtMatienTe.Text = tygia.MaTienTe1
        Me.txtTenTienTe.Text = tygia.TenTienTe1
        Me.numTyGia.Value = System.Convert.ToDecimal(tygia.TyGiaQuyDoi1)
        Me.ckTinhTrang.Checked = tygia.TinhTrang1

    End Sub
End Class