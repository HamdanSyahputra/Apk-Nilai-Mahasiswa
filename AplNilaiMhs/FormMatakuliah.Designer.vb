<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatakuliah
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
        Me.btncaridata = New System.Windows.Forms.Button()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.txtsks = New System.Windows.Forms.TextBox()
        Me.txtnamamtk = New System.Windows.Forms.TextBox()
        Me.txtkdmtk = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncaridata
        '
        Me.btncaridata.Location = New System.Drawing.Point(248, 213)
        Me.btncaridata.Name = "btncaridata"
        Me.btncaridata.Size = New System.Drawing.Size(65, 26)
        Me.btncaridata.TabIndex = 90
        Me.btncaridata.Text = "Cari Data"
        Me.btncaridata.UseVisualStyleBackColor = True
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(124, 217)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(100, 20)
        Me.txtcaridata.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Pencarian"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(22, 263)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(498, 102)
        Me.ListView1.TabIndex = 85
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(446, 156)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(71, 34)
        Me.btnexit.TabIndex = 84
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(340, 156)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(71, 34)
        Me.btndelete.TabIndex = 83
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(234, 156)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(71, 34)
        Me.btnedit.TabIndex = 82
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(128, 156)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(71, 34)
        Me.btnsave.TabIndex = 81
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(22, 156)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(71, 34)
        Me.btnrefresh.TabIndex = 80
        Me.btnrefresh.Text = "REFRESH"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'txtsks
        '
        Me.txtsks.Location = New System.Drawing.Point(124, 116)
        Me.txtsks.Name = "txtsks"
        Me.txtsks.Size = New System.Drawing.Size(100, 20)
        Me.txtsks.TabIndex = 79
        '
        'txtnamamtk
        '
        Me.txtnamamtk.Location = New System.Drawing.Point(124, 87)
        Me.txtnamamtk.Name = "txtnamamtk"
        Me.txtnamamtk.Size = New System.Drawing.Size(100, 20)
        Me.txtnamamtk.TabIndex = 78
        '
        'txtkdmtk
        '
        Me.txtkdmtk.Location = New System.Drawing.Point(124, 56)
        Me.txtkdmtk.Name = "txtkdmtk"
        Me.txtkdmtk.Size = New System.Drawing.Size(100, 20)
        Me.txtkdmtk.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "SKS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Nama MTK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Kode MTK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Form Input Data Mahasiswa"
        '
        'FormMatakuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 379)
        Me.Controls.Add(Me.btncaridata)
        Me.Controls.Add(Me.txtcaridata)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.txtsks)
        Me.Controls.Add(Me.txtnamamtk)
        Me.Controls.Add(Me.txtkdmtk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMatakuliah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncaridata As System.Windows.Forms.Button
    Friend WithEvents txtcaridata As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents txtsks As System.Windows.Forms.TextBox
    Friend WithEvents txtnamamtk As System.Windows.Forms.TextBox
    Friend WithEvents txtkdmtk As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
