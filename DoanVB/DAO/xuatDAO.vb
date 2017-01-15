Imports System.Data.SqlClient
Imports System.IO
Public Class xuatDAO
    Public Sub xuat(name As String, path As String)
        Dim con As New Connect

        Dim cn As New SqlConnection
        cn = con.connect()

        Dim query = String.Format("select * from {0}", name)

        Dim ad As New SqlDataAdapter(query, cn)

        Dim tb As New DataTable
        ad.Fill(tb)
        cn.Close()

        Dim f As New StreamWriter(path)
        For Each r As DataRow In tb.Rows
            For Each cl As DataColumn In r.Table.Columns
                Dim str = String.Format("{0},", r.Item(cl.ToString).ToString)
                f.Write(str)
            Next
            f.WriteLine("")
        Next
        f.Close()
    End Sub
End Class
