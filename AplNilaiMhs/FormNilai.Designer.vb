<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbota = New System.Windows.Forms.ComboBox()
        Me.cbosem = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncarimhs = New System.Windows.Forms.Button()
        Me.txtnamamhs = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnkodemtk = New System.Windows.Forms.Button()
        Me.txtsks = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnamamtk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtkdmtk = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncaridosen = New System.Windows.Forms.Button()
        Me.txtnamadosen = New System.Windows.Forms.TextBox()
        Me.txtnidn = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtnilaihuruf = New System.Windows.Forms.TextBox()
        Me.txtket = New System.Windows.Forms.TextBox()
        Me.txtjmlnilai = New System.Windows.Forms.TextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbobot = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnilaiakhir = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btncaridata = New System.Windows.Forms.Button()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(34, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Form Input Data Nilai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Tahun Akademik"
        '
        'cbota
        '
        Me.cbota.FormattingEnabled = True
        Me.cbota.Items.AddRange(New Object() {"2019/2020", "2020/2021", "2021/2022", "2022/2023"})
        Me.cbota.Location = New System.Drawing.Point(158, 56)
        Me.cbota.Name = "cbota"
        Me.cbota.Size = New System.Drawing.Size(121, 21)
        Me.cbota.TabIndex = 49
        '
        'cbosem
        '
        Me.cbosem.FormattingEnabled = True
        Me.cbosem.Items.AddRange(New Object() {"Ganjil", "Genap"})
        Me.cbosem.Location = New System.Drawing.Point(158, 88)
        Me.cbosem.Name = "cbosem"
        Me.cbosem.Size = New System.Drawing.Size(121, 21)
        Me.cbosem.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.btncarimhs)
        Me.Panel1.Controls.Add(Me.txtnamamhs)
        Me.Panel1.Controls.Add(Me.txtnim)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(38, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 83)
        Me.Panel1.TabIndex = 51
        '
        'btncarimhs
        '
        Me.btncarimhs.Location = New System.Drawing.Point(227, 11)
        Me.btncarimhs.Name = "btncarimhs"
        Me.btncarimhs.Size = New System.Drawing.Size(75, 23)
        Me.btncarimhs.TabIndex = 47
        Me.btncarimhs.Text = "Cari Data"
        Me.btncarimhs.UseVisualStyleBackColor = True
        '
        'txtnamamhs
        '
        Me.txtnamamhs.Location = New System.Drawing.Point(121, 45)
        Me.txtnamamhs.Name = "txtnamamhs"
        Me.txtnamamhs.Size = New System.Drawing.Size(181, 20)
        Me.txtnamamhs.TabIndex = 46
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(121, 14)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(100, 20)
        Me.txtnim.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Nama Mahasiswa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "NIM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnkodemtk)
        Me.Panel2.Controls.Add(Me.txtsks)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtnamamtk)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtkdmtk)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(38, 229)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 99)
        Me.Panel2.TabIndex = 52
        '
        'btnkodemtk
        '
        Me.btnkodemtk.Location = New System.Drawing.Point(221, 11)
        Me.btnkodemtk.Name = "btnkodemtk"
        Me.btnkodemtk.Size = New System.Drawing.Size(75, 23)
        Me.btnkodemtk.TabIndex = 48
        Me.btnkodemtk.Text = "Cari Data"
        Me.btnkodemtk.UseVisualStyleBackColor = True
        '
        'txtsks
        '
        Me.txtsks.Location = New System.Drawing.Point(121, 74)
        Me.txtsks.Name = "txtsks"
        Me.txtsks.Size = New System.Drawing.Size(125, 20)
        Me.txtsks.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Kode MTK"
        '
        'txtnamamtk
        '
        Me.txtnamamtk.Location = New System.Drawing.Point(120, 45)
        Me.txtnamamtk.Name = "txtnamamtk"
        Me.txtnamamtk.Size = New System.Drawing.Size(176, 20)
        Me.txtnamamtk.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Nama MTK"
        '
        'txtkdmtk
        '
        Me.txtkdmtk.Location = New System.Drawing.Point(120, 13)
        Me.txtkdmtk.Name = "txtkdmtk"
        Me.txtkdmtk.Size = New System.Drawing.Size(100, 20)
        Me.txtkdmtk.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "SKS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.Controls.Add(Me.btncaridosen)
        Me.Panel3.Controls.Add(Me.txtnamadosen)
        Me.Panel3.Controls.Add(Me.txtnidn)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(366, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 83)
        Me.Panel3.TabIndex = 53
        '
        'btncaridosen
        '
        Me.btncaridosen.Location = New System.Drawing.Point(226, 14)
        Me.btncaridosen.Name = "btncaridosen"
        Me.btncaridosen.Size = New System.Drawing.Size(75, 23)
        Me.btncaridosen.TabIndex = 54
        Me.btncaridosen.Text = "Cari Data"
        Me.btncaridosen.UseVisualStyleBackColor = True
        '
        'txtnamadosen
        '
        Me.txtnamadosen.Location = New System.Drawing.Point(105, 51)
        Me.txtnamadosen.Name = "txtnamadosen"
        Me.txtnamadosen.Size = New System.Drawing.Size(196, 20)
        Me.txtnamadosen.TabIndex = 53
        '
        'txtnidn
        '
        Me.txtnidn.Location = New System.Drawing.Point(105, 16)
        Me.txtnidn.Name = "txtnidn"
        Me.txtnidn.Size = New System.Drawing.Size(100, 20)
        Me.txtnidn.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Nama Dosen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "NIDN"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Salmon
        Me.Panel4.Controls.Add(Me.txtnilaihuruf)
        Me.Panel4.Controls.Add(Me.txtket)
        Me.Panel4.Controls.Add(Me.txtjmlnilai)
        Me.Panel4.Controls.Add(Me.btnproses)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtbobot)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtnilaiakhir)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(366, 229)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(322, 158)
        Me.Panel4.TabIndex = 54
        '
        'txtnilaihuruf
        '
        Me.txtnilaihuruf.Location = New System.Drawing.Point(105, 45)
        Me.txtnilaihuruf.Name = "txtnilaihuruf"
        Me.txtnilaihuruf.Size = New System.Drawing.Size(115, 20)
        Me.txtnilaihuruf.TabIndex = 92
        '
        'txtket
        '
        Me.txtket.Location = New System.Drawing.Point(105, 133)
        Me.txtket.Name = "txtket"
        Me.txtket.Size = New System.Drawing.Size(191, 20)
        Me.txtket.TabIndex = 91
        '
        'txtjmlnilai
        '
        Me.txtjmlnilai.Location = New System.Drawing.Point(105, 104)
        Me.txtjmlnilai.Name = "txtjmlnilai"
        Me.txtjmlnilai.Size = New System.Drawing.Size(45, 20)
        Me.txtjmlnilai.TabIndex = 90
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(221, 18)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(75, 23)
        Me.btnproses.TabIndex = 86
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Jumlah Nilai"
        '
        'txtbobot
        '
        Me.txtbobot.Location = New System.Drawing.Point(105, 78)
        Me.txtbobot.Name = "txtbobot"
        Me.txtbobot.Size = New System.Drawing.Size(45, 20)
        Me.txtbobot.TabIndex = 89
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Keterangan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Nilai Akhir"
        '
        'txtnilaiakhir
        '
        Me.txtnilaiakhir.Location = New System.Drawing.Point(105, 18)
        Me.txtnilaiakhir.Name = "txtnilaiakhir"
        Me.txtnilaiakhir.Size = New System.Drawing.Size(45, 20)
        Me.txtnilaiakhir.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Nilai Huruf"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Bobot"
        '
        'btncaridata
        '
        Me.btncaridata.Location = New System.Drawing.Point(285, 374)
        Me.btncaridata.Name = "btncaridata"
        Me.btncaridata.Size = New System.Drawing.Size(65, 26)
        Me.btncaridata.TabIndex = 98
        Me.btncaridata.Text = "Cari Data"
        Me.btncaridata.UseVisualStyleBackColor = True
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(113, 378)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(166, 20)
        Me.txtcaridata.TabIndex = 97
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(35, 380)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 96
        Me.Label16.Text = "Pencarian"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(285, 334)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(43, 34)
        Me.btnexit.TabIndex = 95
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(220, 334)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(59, 34)
        Me.btndelete.TabIndex = 94
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(166, 333)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(48, 34)
        Me.btnedit.TabIndex = 93
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(113, 332)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(47, 34)
        Me.btnsave.TabIndex = 92
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(37, 332)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(71, 34)
        Me.btnrefresh.TabIndex = 91
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(37, 406)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(651, 131)
        Me.ListView1.TabIndex = 99
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 548)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btncaridata)
        Me.Controls.Add(Me.txtcaridata)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbosem)
        Me.Controls.Add(Me.cbota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormNilai"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbota As System.Windows.Forms.ComboBox
    Friend WithEvents cbosem As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncarimhs As System.Windows.Forms.Button
    Friend WithEvents txtnamamhs As System.Windows.Forms.TextBox
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnkodemtk As System.Windows.Forms.Button
    Friend WithEvents txtsks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnamamtk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtkdmtk As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btncaridosen As System.Windows.Forms.Button
    Friend WithEvents txtnamadosen As System.Windows.Forms.TextBox
    Friend WithEvents txtnidn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtket As System.Windows.Forms.TextBox
    Friend WithEvents txtjmlnilai As System.Windows.Forms.TextBox
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbobot As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnilaiakhir As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btncaridata As System.Windows.Forms.Button
    Friend WithEvents txtcaridata As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txtnilaihuruf As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
