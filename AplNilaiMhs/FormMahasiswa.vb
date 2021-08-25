Imports MySql.Data.MySqlClient
Public Class FormMahasiswa
    Dim agama As String
    Private Sub usia()
        Dim thn, bln As String
        thn = Year(Now) - Year(dtptgllhr.Value)
        bln = Month(Now) - Month(dtptgllhr.Value)
        txtusia.Text = thn & "Tahun," & bln & "Bulan"
    End Sub
    'membuat kolom pada listview
    Private Sub Posisilist()
        With ListView1.Columns
            .Add("NIM", 80)
            .Add("Nama Mahasiswa", 150)
            .Add("Tempat Lahir", 150)
            .Add("Tanggal Lahir", 100)
            .Add("Usia", 80)
            .Add("Jenis Kelamin", 90)
            .Add("Agama", 80)
            .Add("Alamat", 200)
            .Add("Telpon/HP", 90)
        End With
    End Sub

    'menampilkan data pada listview
    Private Sub Isilist()
        Dim a As Integer
        Try
            Query = "SELECT *FROM tbl_mahasiswa ORDER BY Nim"
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksikeDatabase()
        Posisilist()
        Isilist()

    End Sub

    Private Sub cbislam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbislam.CheckedChanged
        If cbislam.Checked = True Then
            cbkristen.Checked = False
            cbbuddha.Checked = False
            cbhindu.Checked = False
            cbkonghuchu.Checked = False
            agama = "Islam"
        End If
    End Sub

    Private Sub cbkristen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkristen.CheckedChanged
        If cbkristen.Checked = True Then
            cbislam.Checked = False
            cbbuddha.Checked = False
            cbhindu.Checked = False
            cbkonghuchu.Checked = False
            agama = "Kristen"
        End If
    End Sub

    Private Sub cbbuddha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbuddha.CheckedChanged
        If cbbuddha.Checked = True Then
            cbislam.Checked = False
            cbkristen.Checked = False
            cbhindu.Checked = False
            cbkonghuchu.Checked = False
            agama = "Buddha"
        End If
    End Sub

    Private Sub cbhindu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbhindu.CheckedChanged
        If cbhindu.Checked = True Then
            cbislam.Checked = False
            cbbuddha.Checked = False
            cbkristen.Checked = False
            cbkonghuchu.Checked = False
            agama = "Hindu"
        End If
    End Sub

    Private Sub cbkonghuchu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkonghuchu.CheckedChanged
        If cbkonghuchu.Checked = True Then
            cbislam.Checked = False
            cbbuddha.Checked = False
            cbhindu.Checked = False
            cbkristen.Checked = False
            agama = "Konghuchu"
        End If
    End Sub
    Private Sub bersih()
        txtnim.Text = ""
        txtnamamhs.Text = ""
        txttgllhr.Text = ""
        txtusia.Text = ""
        rdblaki_laki.Checked = False
        rdbperempuan.Text = False
        cbislam.Checked = False
        cbkristen.Checked = False
        cbhindu.Checked = False
        cbbuddha.Checked = False
        cbkonghuchu.Checked = False
        txtalmt.Text = ""
        txttelp.Text = ""
    End Sub
    Private Sub btnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrefresh.Click
        bersih()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            Dim jenkel As String
            If rdblaki_laki.Checked = True Then
                jenkel = "Laki-Laki"
            Else
                jenkel = "Perempuan"
            End If

            If txtnim.Text = "" Or txtnamamhs.Text = "" Or txttgllhr.Text = "" Or txtusia.Text = "" Or txtalmt.Text = "" Then
                MsgBox("Silahkan Lengkapi data terlebih dahulu", MsgBoxStyle.Critical, "error")
                txtnim.Focus()
            Else
                Query = "INSERT INTO tbl_mahasiswa VALUES('" & txtnim.Text & "','" & txtnamamhs.Text & "','" & txttgllhr.Text & "','" & Format(dtptgllhr.Value, "yyyy/MM/dd") & "','" & txtusia.Text & "','" & jenkel & "','" & agama & "','" & txtalmt.Text & "','" & txttelp.Text & "')"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                txtnim.Focus()
                MsgBox("data berhasil disimpan", MsgBoxStyle.Critical, "SAVE")
                Isilist()
                bersih()
            End If
        Catch ex As Exception
            MsgBox("nim ini sudah ada", MsgBoxStyle.Exclamation, "error")
            txtnim.Focus()
        End Try
    End Sub

    Private Sub dtptgllhr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtptgllhr.ValueChanged
        usia()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Try
            Dim jenkel As String
            If rdblaki_laki.Checked = True Then
                jenkel = "Laki-Laki"
            Else
                jenkel = "Perempuan"
            End If

            If txtnim.Text = "" Or txtnamamhs.Text = "" Or txttgllhr.Text = "" Or txtusia.Text = "" Or txtalmt.Text = "" Then
                MsgBox("Silahkan Silahkan Pilih Data Yang Akan Di Edit", MsgBoxStyle.Critical, "Pesan Data Kosong")
                txtnim.Focus()
            Else
                Query = "UPDATE tbl_mahasiswa SET nmmhs ='" & txtnamamhs.Text & "' ,templhr='" & txttgllhr.Text & "', tgllhr='" & Format(dtptgllhr.Value, "yyyy/MM/dd") & "', usia='" & txtusia.Text & "',jenkel='" & jenkel & "',agama='" & agama & "',alamat='" & txtalmt.Text & " ', telp='" & txttelp.Text & "' WHERE nim='" & txtnim.Text & "'"
                daData = New MySqlDataAdapter(Query, Conn)
                dsData = New DataSet
                daData.Fill(dsData)
                Isilist()
                bersih()
                txtnim.Focus()
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
                    txtnim.Focus()
                    Exit Sub
                Case vbOK
                    If txtnim.Text = "" Then
                        MsgBox("Input NIM Yang Akan Di Hapus", MsgBoxStyle.Critical, "Data Kosong")
                        txtnim.Focus()
                    Else
                        Query = "DELETE from tbl_mahasiswa WHERE nim='" & txtnim.Text & "'"
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

    Private Sub ambildatadarilistview()
        With ListView1.SelectedItems
            Try
                txtnim.Text = .Item(0).SubItems(0).Text
                txtnamamhs.Text = .Item(0).SubItems(1).Text
                txttgllhr.Text = .Item(0).SubItems(2).Text
                dtptgllhr.Text = .Item(0).SubItems(3).Text
                txtusia.Text = .Item(0).SubItems(4).Text

                Dim jenkel As String
                jenkel = .Item(0).SubItems(5).Text
                If jenkel = "Laki-Laki" Then
                    rdblaki_laki.Checked = True
                ElseIf jenkel = "Perempuan" Then
                    rdbperempuan.Checked = True
                End If

                Dim agama As String
                agama = .Item(0).SubItems(6).Text
                If agama = "Islam" Then
                    cbislam.Checked = True
                ElseIf agama = "Kristen" Then
                    cbkristen.Checked = True
                ElseIf agama = "Hindu" Then
                    cbhindu.Checked = True
                ElseIf agama = "Buddha" Then
                    cbbuddha.Checked = True
                ElseIf agama = "Kong HuChu" Then
                    cbkonghuchu.Checked = True
                End If

                txtalmt.Text = .Item(0).SubItems(7).Text
                txttelp.Text = .Item(0).SubItems(8).Text
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        ambildatadarilistview()
    End Sub

    Private Sub txttgllhr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttgllhr.TextChanged

    End Sub
End Class