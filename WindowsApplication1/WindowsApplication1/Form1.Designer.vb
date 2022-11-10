<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Tanggal = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboDivisi = New System.Windows.Forms.ComboBox
        Me.TextNamaModul = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextUraian = New System.Windows.Forms.TextBox
        Me.ButtonSimpan = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextPerbaikan = New System.Windows.Forms.TextBox
        Me.TextPencegahan = New System.Windows.Forms.TextBox
        Me.ComboStatus = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioTidak = New System.Windows.Forms.RadioButton
        Me.RadioYa = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextNo = New System.Windows.Forms.TextBox
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.ButtonReport = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tanggal
        '
        Me.Tanggal.Location = New System.Drawing.Point(526, 29)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(198, 20)
        Me.Tanggal.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(402, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal Mulai"
        '
        'ComboDivisi
        '
        Me.ComboDivisi.FormattingEnabled = True
        Me.ComboDivisi.Items.AddRange(New Object() {"Receiving", "QC Sparepart", "Service", "Stock Keeper", "QC", "Assembling", "Gudang Kemasan", "Gudang Promosi", "Marketing", "IT", "General Affair", "Sur Sticker", "Sur & RnD", "Menu Stock Keeper Koli", "UMS"})
        Me.ComboDivisi.Location = New System.Drawing.Point(156, 80)
        Me.ComboDivisi.Name = "ComboDivisi"
        Me.ComboDivisi.Size = New System.Drawing.Size(170, 21)
        Me.ComboDivisi.TabIndex = 2
        '
        'TextNamaModul
        '
        Me.TextNamaModul.Location = New System.Drawing.Point(156, 120)
        Me.TextNamaModul.Name = "TextNamaModul"
        Me.TextNamaModul.Size = New System.Drawing.Size(823, 20)
        Me.TextNamaModul.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sub Divisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Modul"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Uraian"
        '
        'TextUraian
        '
        Me.TextUraian.Location = New System.Drawing.Point(156, 167)
        Me.TextUraian.Name = "TextUraian"
        Me.TextUraian.Size = New System.Drawing.Size(823, 20)
        Me.TextUraian.TabIndex = 14
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(29, 326)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(137, 33)
        Me.ButtonSimpan.TabIndex = 17
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 410)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(951, 247)
        Me.DataGridView1.TabIndex = 18
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(205, 326)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(137, 33)
        Me.ButtonHapus.TabIndex = 19
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(377, 326)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(137, 33)
        Me.ButtonUpdate.TabIndex = 20
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tindakan Perbaikan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tindakan Pencegahan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Status"
        '
        'TextPerbaikan
        '
        Me.TextPerbaikan.Location = New System.Drawing.Point(156, 203)
        Me.TextPerbaikan.Name = "TextPerbaikan"
        Me.TextPerbaikan.Size = New System.Drawing.Size(823, 20)
        Me.TextPerbaikan.TabIndex = 24
        '
        'TextPencegahan
        '
        Me.TextPencegahan.Location = New System.Drawing.Point(156, 242)
        Me.TextPencegahan.Name = "TextPencegahan"
        Me.TextPencegahan.Size = New System.Drawing.Size(823, 20)
        Me.TextPencegahan.TabIndex = 25
        '
        'ComboStatus
        '
        Me.ComboStatus.FormattingEnabled = True
        Me.ComboStatus.Items.AddRange(New Object() {"Proses", "Close"})
        Me.ComboStatus.Location = New System.Drawing.Point(156, 282)
        Me.ComboStatus.Name = "ComboStatus"
        Me.ComboStatus.Size = New System.Drawing.Size(170, 21)
        Me.ComboStatus.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioTidak)
        Me.GroupBox1.Controls.Add(Me.RadioYa)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 48)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trouble"
        '
        'RadioTidak
        '
        Me.RadioTidak.AutoSize = True
        Me.RadioTidak.Location = New System.Drawing.Point(67, 19)
        Me.RadioTidak.Name = "RadioTidak"
        Me.RadioTidak.Size = New System.Drawing.Size(52, 17)
        Me.RadioTidak.TabIndex = 1
        Me.RadioTidak.TabStop = True
        Me.RadioTidak.Text = "Tidak"
        Me.RadioTidak.UseVisualStyleBackColor = True
        '
        'RadioYa
        '
        Me.RadioYa.AutoSize = True
        Me.RadioYa.Location = New System.Drawing.Point(23, 19)
        Me.RadioYa.Name = "RadioYa"
        Me.RadioYa.Size = New System.Drawing.Size(38, 17)
        Me.RadioYa.TabIndex = 0
        Me.RadioYa.TabStop = True
        Me.RadioYa.Text = "Ya"
        Me.RadioYa.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "No Pekerjaan"
        '
        'TextNo
        '
        Me.TextNo.Location = New System.Drawing.Point(156, 29)
        Me.TextNo.Name = "TextNo"
        Me.TextNo.Size = New System.Drawing.Size(170, 20)
        Me.TextNo.TabIndex = 30
        '
        'ButtonInput
        '
        Me.ButtonInput.Location = New System.Drawing.Point(541, 326)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(137, 33)
        Me.ButtonInput.TabIndex = 31
        Me.ButtonInput.Text = "Input Data "
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'ButtonReport
        '
        Me.ButtonReport.Location = New System.Drawing.Point(742, 326)
        Me.ButtonReport.Name = "ButtonReport"
        Me.ButtonReport.Size = New System.Drawing.Size(137, 33)
        Me.ButtonReport.TabIndex = 32
        Me.ButtonReport.Text = "Report"
        Me.ButtonReport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 688)
        Me.Controls.Add(Me.ButtonReport)
        Me.Controls.Add(Me.ButtonInput)
        Me.Controls.Add(Me.TextNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboStatus)
        Me.Controls.Add(Me.TextPencegahan)
        Me.Controls.Add(Me.TextPerbaikan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.TextUraian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextNamaModul)
        Me.Controls.Add(Me.ComboDivisi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tanggal)
        Me.Name = "Form1"
        Me.Text = "Form Serah Terima Pekerjaan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents TextNamaModul As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextUraian As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextPerbaikan As System.Windows.Forms.TextBox
    Friend WithEvents TextPencegahan As System.Windows.Forms.TextBox
    Friend WithEvents ComboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioYa As System.Windows.Forms.RadioButton
    Friend WithEvents RadioTidak As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextNo As System.Windows.Forms.TextBox
    Public WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents ButtonReport As System.Windows.Forms.Button

End Class
