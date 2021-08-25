Imports MySql.Data.MySqlClient

Module bukakoneksi
    Public Conn As New MySql.Data.MySqlClient.MySqlConnection
    Public daData As New MySqlDataAdapter
    Public dsData As New DataSet
    Public Query As String
    Public baca As MySqlDataReader
    Public str As String
    Public cmd As New MySqlCommand
    Public rd As MySqlDataReader

    Public Sub KoneksikeDatabase()
        Try
            Dim str As String = "Server=localhost;user id=root;database=db_nilai1"
            Conn = New MySqlConnection(str)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MsgBox("Koneksi ke server gagal")
        End Try
    End Sub
End Module
