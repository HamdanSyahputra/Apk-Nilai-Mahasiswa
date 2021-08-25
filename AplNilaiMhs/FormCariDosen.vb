Imports MySql.Data.MySqlClient
Public Class FormCariDosen
    Private Sub Posisilist()
        With ListView1.Columns
            .Add("NIDN", 80)
            .Add("Nama Dosen", 150)
            .Add("E-mail", 150)
            .Add("Telepon HP", 100)
        End With
    End Sub

    Private Sub Isilist()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_dosen ORDER BY nidn"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    If (a Mod 2 = 0) Then
                        .Items(a).BackColor = Color.LightBlue
                    Else
                        .Items(a).BackColor = Color.Lavender
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub caridatamhs()
        Dim a As Integer
        Try
            Query = "SELECT * FROM tbl_dosen Where nidn like '%" & Trim(txtcaridata.Text) & "%' or nmdosen like '%" & Trim(txtcaridata.Text) & "%'"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(3))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(4))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(5))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(6))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(7))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(8))
                End With
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ambildatadarilistview()
        With ListView1.SelectedItems
            Try
                FormNilai.txtnidn.Text = .Item(0).SubItems(0).Text
                FormNilai.txtnamadosen.Text = .Item(0).SubItems(1).Text
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ambildatadarilistview()
        Me.Close()
    End Sub

    Private Sub txtcaridata_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcaridata.TextChanged
        caridatamhs()
    End Sub

    Private Sub btncaridata_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaridata.Click
        caridatamhs()
    End Sub

    Private Sub FormCariDosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        Posisilist()
        Isilist()
    End Sub
End Class