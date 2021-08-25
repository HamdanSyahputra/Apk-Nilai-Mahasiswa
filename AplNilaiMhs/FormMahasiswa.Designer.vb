<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMahasiswa
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.txtalmt = New System.Windows.Forms.TextBox()
        Me.cbkonghuchu = New System.Windows.Forms.CheckBox()
        Me.cbhindu = New System.Windows.Forms.CheckBox()
        Me.cbbuddha = New System.Windows.Forms.CheckBox()
        Me.cbkristen = New System.Windows.Forms.CheckBox()
        Me.cbislam = New System.Windows.Forms.CheckBox()
        Me.rdbperempuan = New System.Windows.Forms.RadioButton()
        Me.rdblaki_laki = New System.Windows.Forms.RadioButton()
        Me.txtusia = New System.Windows.Forms.TextBox()
        Me.dtptgllhr = New System.Windows.Forms.DateTimePicker()
        Me.txttgllhr = New System.Windows.Forms.TextBox()
        Me.txtnamamhs = New System.Windows.Forms.TextBox()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(28, 357)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(729, 102)
        Me.ListView1.TabIndex = 60
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(455, 299)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(71, 34)
        Me.btnexit.TabIndex = 59
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(349, 299)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(71, 34)
        Me.btndelete.TabIndex = 58
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(243, 299)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(71, 34)
        Me.btnedit.TabIndex = 57
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(137, 299)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 34)
        Me.btnsave.TabIndex = 56
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(31, 299)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(71, 34)
        Me.btnrefresh.TabIndex = 55
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(522, 234)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(100, 20)
        Me.txttelp.TabIndex = 54
        '
        'txtalmt
        '
        Me.txtalmt.Location = New System.Drawing.Point(522, 203)
        Me.txtalmt.Name = "txtalmt"
        Me.txtalmt.Size = New System.Drawing.Size(100, 20)
        Me.txtalmt.TabIndex = 53
        '
        'cbkonghuchu
        '
        Me.cbkonghuchu.AutoSize = True
        Me.cbkonghuchu.Location = New System.Drawing.Point(753, 153)
        Me.cbkonghuchu.Name = "cbkonghuchu"
        Me.cbkonghuchu.Size = New System.Drawing.Size(87, 17)
        Me.cbkonghuchu.TabIndex = 52
        Me.cbkonghuchu.Text = "Kong HuChu"
        Me.cbkonghuchu.UseVisualStyleBackColor = True
        '
        'cbhindu
        '
        Me.cbhindu.AutoSize = True
        Me.cbhindu.Location = New System.Drawing.Point(652, 177)
        Me.cbhindu.Name = "cbhindu"
        Me.cbhindu.Size = New System.Drawing.Size(54, 17)
        Me.cbhindu.TabIndex = 51
        Me.cbhindu.Text = "Hindu"
        Me.cbhindu.UseVisualStyleBackColor = True
        '
        'cbbuddha
        '
        Me.cbbuddha.AutoSize = True
        Me.cbbuddha.Location = New System.Drawing.Point(652, 153)
        Me.cbbuddha.Name = "cbbuddha"
        Me.cbbuddha.Size = New System.Drawing.Size(63, 17)
        Me.cbbuddha.TabIndex = 50
        Me.cbbuddha.Text = "Buddha"
        Me.cbbuddha.UseVisualStyleBackColor = True
        '
        'cbkristen
        '
        Me.cbkristen.AutoSize = True
        Me.cbkristen.Location = New System.Drawing.Point(522, 178)
        Me.cbkristen.Name = "cbkristen"
        Me.cbkristen.Size = New System.Drawing.Size(58, 17)
        Me.cbkristen.TabIndex = 49
        Me.cbkristen.Text = "Kristen"
        Me.cbkristen.UseVisualStyleBackColor = True
        '
        'cbislam
        '
        Me.cbislam.AutoSize = True
        Me.cbislam.Location = New System.Drawing.Point(522, 153)
        Me.cbislam.Name = "cbislam"
        Me.cbislam.Size = New System.Drawing.Size(50, 17)
        Me.cbislam.TabIndex = 48
        Me.cbislam.Text = "Islam"
        Me.cbislam.UseVisualStyleBackColor = True
        '
        'rdbperempuan
        '
        Me.rdbperempuan.AutoSize = True
        Me.rdbperempuan.Location = New System.Drawing.Point(652, 124)
        Me.rdbperempuan.Name = "rdbperempuan"
        Me.rdbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rdbperempuan.TabIndex = 47
        Me.rdbperempuan.TabStop = True
        Me.rdbperempuan.Text = "Perempuan"
        Me.rdbperempuan.UseVisualStyleBackColor = True
        '
        'rdblaki_laki
        '
        Me.rdblaki_laki.AutoSize = True
        Me.rdblaki_laki.Location = New System.Drawing.Point(522, 124)
        Me.rdblaki_laki.Name = "rdblaki_laki"
        Me.rdblaki_laki.Size = New System.Drawing.Size(68, 17)
        Me.rdblaki_laki.TabIndex = 46
        Me.rdblaki_laki.TabStop = True
        Me.rdblaki_laki.Text = "Laki-Laki"
        Me.rdblaki_laki.UseVisualStyleBackColor = True
        '
        'txtusia
        '
        Me.txtusia.Location = New System.Drawing.Point(522, 90)
        Me.txtusia.Name = "txtusia"
        Me.txtusia.Size = New System.Drawing.Size(100, 20)
        Me.txtusia.TabIndex = 45
        '
        'dtptgllhr
        '
        Me.dtptgllhr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptgllhr.Location = New System.Drawing.Point(133, 183)
        Me.dtptgllhr.Name = "dtptgllhr"
        Me.dtptgllhr.Size = New System.Drawing.Size(200, 20)
        Me.dtptgllhr.TabIndex = 44
        '
        'txttgllhr
        '
        Me.txttgllhr.Location = New System.Drawing.Point(133, 150)
        Me.txttgllhr.Name = "txttgllhr"
        Me.txttgllhr.Size = New System.Drawing.Size(100, 20)
        Me.txttgllhr.TabIndex = 43
        '
        'txtnamamhs
        '
        Me.txtnamamhs.Location = New System.Drawing.Point(133, 121)
        Me.txtnamamhs.Name = "txtnamamhs"
        Me.txtnamamhs.Size = New System.Drawing.Size(100, 20)
        Me.txtnamamhs.TabIndex = 42
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(133, 90)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(100, 20)
        Me.txtnim.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(414, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Telepon HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(414, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(414, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(414, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Jenis Kelamis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(414, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Usia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tanggal Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tempat Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nama Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Form Input Data Mahasiswa"
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 506)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.txtalmt)
        Me.Controls.Add(Me.cbkonghuchu)
        Me.Controls.Add(Me.cbhindu)
        Me.Controls.Add(Me.cbbuddha)
        Me.Controls.Add(Me.cbkristen)
        Me.Controls.Add(Me.cbislam)
        Me.Controls.Add(Me.rdbperempuan)
        Me.Controls.Add(Me.rdblaki_laki)
        Me.Controls.Add(Me.txtusia)
        Me.Controls.Add(Me.dtptgllhr)
        Me.Controls.Add(Me.txttgllhr)
        Me.Controls.Add(Me.txtnamamhs)
        Me.Controls.Add(Me.txtnim)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents txtalmt As System.Windows.Forms.TextBox
    Friend WithEvents cbkonghuchu As System.Windows.Forms.CheckBox
    Friend WithEvents cbhindu As System.Windows.Forms.CheckBox
    Friend WithEvents cbbuddha As System.Windows.Forms.CheckBox
    Friend WithEvents cbkristen As System.Windows.Forms.CheckBox
    Friend WithEvents cbislam As System.Windows.Forms.CheckBox
    Friend WithEvents rdbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rdblaki_laki As System.Windows.Forms.RadioButton
    Friend WithEvents txtusia As System.Windows.Forms.TextBox
    Friend WithEvents dtptgllhr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttgllhr As System.Windows.Forms.TextBox
    Friend WithEvents txtnamamhs As System.Windows.Forms.TextBox
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
