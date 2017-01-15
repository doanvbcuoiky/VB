Imports System.Data.SqlClient
Imports System.Data
Public Class SaoLuuPhucHoiDAO
    Public Shared Sub SaoLuu(name As String, path As String)

        Dim cn As New SqlConnection()
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cn.Open()
        Dim str = String.Format("BACKUP DATABASE [QuanLyBanHang] TO DISK = N'{0}' WITH  NAME = N'{1}',  NOFORMAT, NOINIT, SKIP,  STATS = 5", path + "\" + name, name)
        cmd.CommandText = str

        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub

    Public Shared Sub PhucHoi(path As String)


        Dim cn As New SqlConnection()
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"

        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cn.Open()
        Dim str = String.Format("use master RESTORE DATABASE [QuanLyBanHang] FROM  DISK = N'{0}' WITH  FILE = 1,  RECOVERY,  STATS = 5", path)


        cmd.CommandText = str

        cmd.ExecuteNonQuery()
        cn.Close()

    End Sub
End Class
