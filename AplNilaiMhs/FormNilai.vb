Imports MySql.Data.MySqlClient
Public Class FormNilai
    Dim sks As Integer
    Dim nilaiakhir As Double
    Dim bobot, jumlahnilai As Integer
    Dim nilaihuruf, keterangan As String
    Dim idnilai As String

    Private Sub bersihkandata()
        idnilai = ""
        cbota.Text = ""
        cbosem.Text = ""
        txtnim.Text = ""
        txtnamamhs.Text = ""
        txtnidn.Text = ""
        txtnamadosen.Text = ""
        txtkdmtk.Text = ""
        txtnamamtk.Text = ""
        txtsks.Text = ""
        txtnilaiakhir.Text = ""
        txtnilaihuruf.Text = ""
        txtbobot.Text = ""
        txtjmlnilai.Text = ""
        txtket.Text = ""
    End Sub
    Private Sub ambildatadarilistview()
        With ListView1.SelectedItems
            Try
                idnilai = .Item(0).SubItems(0).Text
                cbota.Text = .Item(0).SubItems(1).Text
                cbosem.Text = .Item(0).SubItems(2).Text
                txtnim.Text = .Item(0).SubItems(3).Text
                txtnamamhs.Text = .Item(0).SubItems(4).Text
                txtnidn.Text = .Item(0).SubItems(5).Text
                txtnamadosen.Text = .Item(0).SubItems(6).Text
                txtkdmtk.Text = .Item(0).SubItems(7).Text
                txtnamamtk.Text = .Item(0).SubItems(8).Text
                txtsks.Text = .Item(0).SubItems(9).Text
                txtnilaiakhir.Text = .Item(0).SubItems(10).Text
                txtnilaihuruf.Text = .Item(0).SubItems(11).Text
                txtbobot.Text = .Item(0).SubItems(12).Text
                txtjmlnilai.Text = .Item(0).SubItems(13).Text
                txtket.Text = .Item(0).SubItems(14).Text
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub posisilist()
        With ListView1.Columns
            .Add("Id Nilai", 60)
            .Add("Tahun Akademik", 100)
            .Add("Semester", 70)
            .Add("Nim", 70)
            .Add("Nama Mahasiswa", 130)
            .Add("NIDN", 70)
            .Add("Nama Dosen", 130)
            .Add("Kode MTK", 70)
            .Add("Nama Matakuliah", 130)
            .Add("SKS", 70)
            .Add("Nilai Akhir", 70)
            .Add("Nilai Huruf", 70)
            .Add("Bobot", 70)
            .Add("Jumlah", 70)
            .Add("Ketterangan", 130)
        End With
    End Sub
    Private Sub isilist()
        Dim a As Integer
        Try
            Query = "select * from relasi order by nim"
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
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(11))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(12))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(15))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(16))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(17))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(18))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(19))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(20))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(21))
                    .Items(a).SubItems.Add(dsData.Tables(0).Rows(a).Item(22))
                End With
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub prosesnilai()
        sks = txtsks.Text
        nilaiakhir = txtnilaiakhir.Text

        If ((nilaiakhir >= 80) And (nilaiakhir <= 100)) Then
            nilaihuruf = "A"
            bobot = 4
            jumlahnilai = sks * bobot
            keterangan = "Sangat Memuaskan"
        ElseIf ((nilaiakhir >= 70) And (nilaiakhir <= 80)) Then
            nilaihuruf = "B"
            bobot = 3
            jumlahnilai = sks * bobot
            keterangan = "Memuaskan"
        ElseIf ((nilaiakhir >= 60) And (nilaiakhir <= 70)) Then
            nilaihuruf = "C"
            bobot = 2
            jumlahnilai = sks * bobot
            keterangan = "Cukup"
        ElseIf ((nilaiakhir >= 45) And (nilaiakhir <= 60)) Then
            nilaihuruf = "D"
            bobot = 1
            jumlahnilai = sks * bobot
            keterangan = "Kurang"
        ElseIf ((nilaiakhir >= 0) And (nilaiakhir <= 45)) Then
            nilaihuruf = "E"
            bobot = 3
            jumlahnilai = sks * bobot
            keterangan = "Gagal"
        Else
            nilaihuruf = "eror"
            bobot = 0
            jumlahnilai = sks * bobot
            keterangan = "Nilai diluar range"
        End If
        txtnilaihuruf.Text = nilaihuruf
        txtbobot.Text = bobot
        txtjmlnilai.Text = jumlahnilai
        txtket.Text = keterangan
    End Sub

    Private Sub btncarimhs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncarimhs.Click
        FormCariMhs.Show()
    End Sub

    Private Sub btncaridosen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncaridosen.Click
        FormCariDosen.Show()
    End Sub

    Private Sub btnkodemtk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkodemtk.Click
        FormCariMtk.Show()
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        prosesnilai()
    End Sub

    Private Sub FormNilai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        posisilist()
        isilist()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If cbota.Text = "" Or cbosem.Text = "" Or txtnim.Text = "" Or txtnidn.Text = "" Or txtkdmtk.Text = "" Or txtnilaiakhir.Text = "" Or txtnilaihuruf.Text = "" Or txtbobot.Text = "" Or txtjmlnilai.Text = "" Or txtket.Text = "" Then
                MsgBox("Silahkan Lengkapi Data Terlebih Dahulu", MsgBoxStyle.Critical, "Pesan Data Kosong")
            Else
                Call KoneksikeDatabase()
                cmd = New MySqlCommand("select * from tbl_nilai where nim='" & txtnim.Text & "' and kdmtk='" & txtkdmtk.Text & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    MsgBox("nim dan kode mtk ini sudah ada", MsgBoxStyle.Critical, "ganda")
                Else
                    Call KoneksikeDatabase()
                    Query = "insert into tbl_nilai (ta,sem,nim,nidn,kdmtk,na,nh,bbt,jml,ket) values ('" & cbota.Text & "','" & cbosem.Text & "','" & txtnim.Text & "','" & txtnidn.Text & "','" & txtkdmtk.Text & "','" & txtnilaiakhir.Text & "','" & txtnilaihuruf.Text & "','" & txtbobot.Text & "','" & txtjmlnilai.Text & "','" & txtket.Text & "')"
                    daData = New MySqlDataAdapter(Query, Conn)
                    dsData = New DataSet
                    daData.Fill(dsData)
                    cbota.Focus()
                    MsgBox("data berhasil disimpan", MsgBoxStyle.Critical, "SAVE")
                    isilist()
                    posisilist()
                    txtkdmtk.Text = ""
                    txtnamamtk.Text = ""
                    txtsks.Text = ""
                    txtnilaiakhir.Text = ""
                    txtnilaihuruf.Text = ""
                    txtbobot.Text = ""
                    txtjmlnilai.Text = ""
                    txtket.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ambildatadarilistview()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            If cbota.Text = "" Or cbosem.Text = "" Or txtnim.Text = "" Or txtnidn.Text = "" Or txtkdmtk.Text = "" Or txtnilaiakhir.Text = "" Or txtnilaihuruf.Text = "" Or txtbobot.Text = "" Or txtjmlnilai.Text = "" Or txtket.Text = "" Then
                MsgBox("Lengkapi Data Yang Akan di Edit", MsgBoxStyle.Critical, "Pesesan Kosong")
            Else
                Query = "update tbl_nilai set ta='" & cbota.Text & "',sem='" & cbosem.Text & "',nim='" & txtnim.Text & "',nidn='" & txtnidn.Text & "',kdmtk='" & txtkdmtk.Text & "',na='" & txtnilaiakhir.Text & "',nh='" & txtnilaihuruf.Text & "',bbt='" & txtbobot.Text & "',jml='" & txtjmlnilai.Text & "',ket='" & txtket.Text & "'where id_nilai=" & idnilai & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                MsgBox("data berhasil di edit", MsgBoxStyle.Critical, "edit")
                isilist()
                cbota.Focus()
                bersihkandata()
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
                    cbota.Focus()
                    Exit Sub
                Case vbOK
                 
                    Query = "DELETE from tbl_nilai WHERE id_nilai ='" & idnilai & "'"
                        daData = New MySqlDataAdapter(Query, Conn)
                        dsData = New DataSet
                        daData.Fill(dsData)
                        isilist()
                    bersihkandata()
                        MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        bersihkandata()
    End Sub
End Class