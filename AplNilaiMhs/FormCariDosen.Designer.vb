<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariDosen
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
        Me.btncaridata = New System.Windows.Forms.Button()
        Me.txtcaridata = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 47)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(651, 131)
        Me.ListView1.TabIndex = 107
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'btncaridata
        '
        Me.btncaridata.Location = New System.Drawing.Point(599, 10)
        Me.btncaridata.Name = "btncaridata"
        Me.btncaridata.Size = New System.Drawing.Size(65, 26)
        Me.btncaridata.TabIndex = 106
        Me.btncaridata.Text = "Cari Data"
        Me.btncaridata.UseVisualStyleBackColor = True
        '
        'txtcaridata
        '
        Me.txtcaridata.Location = New System.Drawing.Point(427, 14)
        Me.txtcaridata.Name = "txtcaridata"
        Me.txtcaridata.Size = New System.Drawing.Size(166, 20)
        Me.txtcaridata.TabIndex = 105
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(349, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 16)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Pencarian"
        '
        'FormCariDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 191)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btncaridata)
        Me.Controls.Add(Me.txtcaridata)
        Me.Controls.Add(Me.Label16)
        Me.Name = "FormCariDosen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btncaridata As System.Windows.Forms.Button
    Friend WithEvents txtcaridata As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
