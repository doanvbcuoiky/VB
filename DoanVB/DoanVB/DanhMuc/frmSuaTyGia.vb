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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim tygia As New TyGiaDTO(Me.txtMatienTe.Text, Me.txtTenTienTe.Text, _
                                 System.Convert.ToDouble(Me.numTyGia.Value.ToString()), True)
        If TyGiaBUS.SuaTyGia(tygia) = True Then
            MessageBox.Show("Sửa thành công")
        Else
            MessageBox.Show("Không sửa đưuọc")
        End If
    End Sub
End Class