<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdosen
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
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnamadosen = New System.Windows.Forms.TextBox()
        Me.txtnidn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncaridata = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(117, 124)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 20)
        Me.txtemail.TabIndex = 50
        '
        'txtnamadosen
        '
        Me.txtnamadosen.Location = New System.Drawing.Point(117, 95)
        Me.txtnamadosen.Name = "txtnamadosen"
        Me.txtnamadosen.Size = New System.Drawing.Size(100, 20)
        Me.txtnamadosen.TabIndex = 49
        '
        'txtnidn
        '
        Me.txtnidn.Location = New System.Drawing.Point(117, 64)
        Me.txtnidn.Name = "txtnidn"
        Me.txtnidn.Size = New System.Drawing.Size(100, 20)
        Me.txtnidn.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nama Dosen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "NIDN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Form Input Data Mahasiswa"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 317)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(498, 102)
        Me.ListView1.TabIndex = 66
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(439, 208)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(71, 34)
        Me.btnexit.TabIndex = 65
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(333, 208)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(71, 34)
        Me.btndelete.TabIndex = 64
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(227, 208)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(71, 34)
        Me.btnedit.TabIndex = 63
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(121, 208)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 34)
        Me.btnsave.TabIndex = 62
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(15, 208)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(71, 34)
        Me.btnrefresh.TabIndex = 61
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(117, 165)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(100, 20)
        Me.txttelp.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Telepon HP"
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(117, 265)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(100, 20)
        Me.txtcaridata.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Pencarian"
        '
        'btncaridata
        '
        Me.btncaridata.Location = New System.Drawing.Point(241, 261)
        Me.btncaridata.Name = "btncaridata"
        Me.btncaridata.Size = New System.Drawing.Size(65, 26)
        Me.btncaridata.TabIndex = 72
        Me.btncaridata.Text = "Cari Data"
        Me.btncaridata.UseVisualStyleBackColor = True
        '
        'Formdosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 439)
        Me.Controls.Add(Me.btncaridata)
        Me.Controls.Add(Me.txtcaridata)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnamadosen)
        Me.Controls.Add(Me.txtnidn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formdosen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnamadosen As System.Windows.Forms.TextBox
    Friend WithEvents txtnidn As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcaridata As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btncaridata As System.Windows.Forms.Button
End Class
