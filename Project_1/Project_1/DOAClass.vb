Imports System.Data.SqlClient
Public Class DAOClass
    Private conn As SqlConnection

    Public Sub New()
        Try
            conn = New SqlConnection("Data Source=DHRUVPRAJAPATI\SQLEXPRESS;Initial Catalog=project_1;Integrated Security=True;Pooling=False")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub closeconnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function getdata(ByVal str As String) As SqlDataReader
        Dim obj As SqlDataReader
        Dim cmd As New SqlCommand(str, conn)
        conn.Open()
        obj = cmd.ExecuteReader
        Return obj
    End Function

    Public Sub adddata(ByVal STR As String)
        Dim CMD As New SqlCommand(STR, conn)
        conn.Open()
        CMD.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function loaddata(ByVal str As String) As Data.DataSet
        Dim ds As New Data.DataSet
        Dim da As New SqlDataAdapter(str, conn)
        conn.Open()
        da.SelectCommand.ExecuteNonQuery()
        conn.Close()
        da.Fill(ds)
        Return ds
    End Function
End Class
