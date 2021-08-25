Imports MySql.Data.MySqlClient

Public Class FormMatakuliah
    Private Sub Posisilist()
        With ListView1.Columns
            .Add("Kode MTK", 80)
            .Add("Nama MTK", 150)
            .Add("SKS", 150)
        End With
    End Sub

    Private Sub bersih()
        txtkdmtk.Text = ""
        txtnamamtk.Text = ""
        txtsks.Text = ""
        txtcaridata.Text = ""
    End Sub
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        bersih()
    End Sub

    Private Sub Isilist()
        Dim a As Integer
        Try
            Query = "SELECT *FROM tblmatakuliah ORDER BY kdmtk"
            daData = New MySqlDataAdapter(Query, Conn)
            dsData = New DataSet
            daData.Fill(dsData)
            ListView1.Items.Clear()
            For a = 0 To dsData.Tables(0).Rows.Count - 1
                With ListView1
                    .Items.Add(dsData.Tables(0).Rows(a).Item(0))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(1))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(2))
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
            If txtkdmtk.Text = "" Or txtnamamtk.Text = "" Or txtsks.Text = "" Then
                MsgBox("Silahkan Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "error")
                txtkdmtk.Focus()
            Else
                Query = "INSERT INTO tblmatakuliah VALUES('" & txtkdmtk.Text & "','" & txtnamamtk.Text & "','" & txtsks.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                txtkdmtk.Focus()
                MsgBox("data berhasil disimpan", MsgBoxStyle.Critical, "SAVE")
                Isilist()
                bersih()
            End If
        Catch ex As Exception
            MsgBox("Kode ini sudah ada", MsgBoxStyle.Exclamation, "error")
            txtkdmtk.Focus()
        End Try
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            If txtkdmtk.Text = "" Or txtnamamtk.Text = "" Or txtsks.Text = "" Then
                MsgBox("Silahkan Silahkan Pilih Data Yang Akan Di Edit", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtkdmtk.Focus()
            Else
                Query = "UPDATE tblmatakuliah SET nmmtk='" & txtnamamtk.Text & "' ,sks='" & txtsks.Text & " ' WHERE kdmtk='" & txtkdmtk.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                Isilist()
                bersih()
                txtkdmtk.Focus()
                MsgBox("Data Berhasil Di Edit", MsgBoxStyle.Critical, "Edit Data")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Try
            Dim A As String
            A = MsgBox("Benar Data Akan Di Hapus", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Hapus Data")
            Select Case A
                Case vbCancel
                    txtkdmtk.Focus()
                    Exit Sub
                Case vbOK
                    If txtkdmtk.Text = "" Then
                        MsgBox("Input Kode Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtkdmtk.Focus()
                    Else
                        Query = "DELETE from tblmatakuliah WHERE kdmtk='" & txtkdmtk.Text & "'"
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

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub FormMatakuliah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        Posisilist()
        Isilist()
    End Sub

    Private Sub ambildatadarilistview()
        With ListView1.SelectedItems
            Try
                txtkdmtk.Text = .Item(0).SubItems(0).Text
                txtnamamtk.Text = .Item(0).SubItems(1).Text
                txtsks.Text = .Item(0).SubItems(2).Text
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ambildatadarilistview()
    End Sub
End Class