Imports System.Data.SqlClient
Imports BUS
Public Class frmSaoLuu
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If (txtName.Text = "" Or txtPath.Text = "") Then
            MsgBox("Dữ liệu thiếu!")
        Else
            Try
                SaoLuuPhucHoiBUS.SaoLuu(txtName.Text, txtPath.Text)
                MessageBox.Show("Sao lưu thành công.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(txtPath.Text)
                btnLocal.Enabled = True
            Catch ex As SqlException
                MessageBox.Show("Sao lưu thất bại.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Process.Start(txtPath.Text)
    End Sub
End Class