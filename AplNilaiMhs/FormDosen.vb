Imports MySql.Data.MySqlClient

Public Class Formdosen

    Private Sub Posisilist()
        With ListView1.Columns
            .Add("NIDN", 80)
            .Add("Nama Dosen", 150)
            .Add("E-mail", 150)
            .Add("Telepon HP", 100)
        End With
    End Sub

    Private Sub bersih()
        txtnidn.Text = ""
        txtnamadosen.Text = ""
        txtemail.Text = ""
        txttelp.Text = ""
        txtcaridata.Text = ""
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        bersih()
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

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If txtnidn.Text = "" Or txtnamadosen.Text = "" Or txtemail.Text = "" Or txttelp.Text = "" Then
                MsgBox("Silahkan Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "error")
                txtnidn.Focus()
            Else
                Query = "INSERT INTO tbl_dosen VALUES('" & txtnidn.Text & "','" & txtnamadosen.Text & "','" & txtemail.Text & "','" & txttelp.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                txtnidn.Focus()
                MsgBox("data berhasil disimpan", MsgBoxStyle.Critical, "SAVE")
                Isilist()
                bersih()
            End If
        Catch ex As Exception
            MsgBox("nim ini sudah ada", MsgBoxStyle.Exclamation, "error")
            txtnidn.Focus()
        End Try
    End Sub

    Private Sub Formdosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        Posisilist()
        Isilist()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            If txtnidn.Text = "" Or txtnamadosen.Text = "" Or txtemail.Text = "" Or txttelp.Text = "" Then
                MsgBox("Silahkan Silahkan Pilih Data Yang Akan Di Edit", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtnidn.Focus()
            Else
                Query = "UPDATE tbl_dosen SET nm_dosen ='" & txtnamadosen.Text & "' ,email='" & txtemail.Text & "',telp='" & txttelp.Text & " ' WHERE nidn='" & txtnidn.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                Isilist()
                bersih()
                txtnidn.Focus()
                MsgBox("Data Berhasil Di Edit", MsgBoxStyle.Critical, "Edit Data")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar Data Akan Di Hapus", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtnidn.Focus()
                    Exit Sub
                Case vbOK
                    If txtnidn.Text = "" Then
                        MsgBox("Input NIM Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtnidn.Focus()
                    Else
                        Query = "DELETE from tbl_dosen WHERE nidn='" & txtnidn.Text & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        Isilist()
                        bersih()
                        MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")

                    End If
            End Select

        Catch ex As Exception
            MsgBox("Data Tidak Bisa Di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub ambildatadarilistview()
        With ListView1.SelectedItems
            Try
                txtnidn.Text = .Item(0).SubItems(0).Text
                txtnamadosen.Text = .Item(0).SubItems(1).Text
                txtemail.Text = .Item(0).SubItems(2).Text
                txttelp.Text = .Item(0).SubItems(3).Text
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ambildatadarilistview()
    End Sub
End Class