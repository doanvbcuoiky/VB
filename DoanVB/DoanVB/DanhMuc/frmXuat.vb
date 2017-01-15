Imports BUS

Public Class frmXuat
    Public Property name As String
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnXuat_Click(sender As Object, e As EventArgs) Handles btnXuat.Click
        If txtName.Text = "" Or txtSetPath.Text = "" Then
            MsgBox("Dữ liệu thiếu!")
        Else
            Try
                Dim bus As New xuatBUS
                bus.xuat(name, txtSetPath.Text + "\" + txtName.Text + ".csv")
                Process.Start(txtSetPath.Text)

            Catch ex As Exception
                MsgBox("Thất bại")
            End Try
        End If
    End Sub

    Private Sub btnSetPath_Click(sender As Object, e As EventArgs) Handles btnSetPath.Click
        Dim folder As New FolderBrowserDialog
        folder.ShowDialog()
        txtSetPath.Text = folder.SelectedPath

    End Sub

    Private Sub frmXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class