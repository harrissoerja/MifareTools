<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAddress = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboReadKey = New System.Windows.Forms.ComboBox()
        Me.cboStartReadNumber = New System.Windows.Forms.ComboBox()
        Me.cboStartReadAdress = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.opReadKeyB = New System.Windows.Forms.RadioButton()
        Me.opReadKeyA = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.opReadAll = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdBacaKartu = New System.Windows.Forms.Button()
        Me.cmdTulisKartu = New System.Windows.Forms.Button()
        Me.generateBtn = New System.Windows.Forms.Button()
        Me.RandomNomorTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KodePrefixTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KodeOperatorTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSisaSaldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoKartu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdPotongSaldo = New System.Windows.Forms.Button()
        Me.cmdIsiSaldo = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.autoReadChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cboAddress)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboReadKey)
        Me.GroupBox3.Controls.Add(Me.cboStartReadNumber)
        Me.GroupBox3.Controls.Add(Me.cboStartReadAdress)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 140)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Konfigurasi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(245, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Address"
        '
        'cboAddress
        '
        Me.cboAddress.Location = New System.Drawing.Point(332, 104)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(59, 20)
        Me.cboAddress.TabIndex = 33
        Me.cboAddress.Text = "00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "6Bytes Block Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(245, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Number of Block"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Start Address of Block"
        '
        'cboReadKey
        '
        Me.cboReadKey.FormattingEnabled = True
        Me.cboReadKey.Location = New System.Drawing.Point(137, 103)
        Me.cboReadKey.Name = "cboReadKey"
        Me.cboReadKey.Size = New System.Drawing.Size(102, 21)
        Me.cboReadKey.TabIndex = 27
        '
        'cboStartReadNumber
        '
        Me.cboStartReadNumber.FormattingEnabled = True
        Me.cboStartReadNumber.Location = New System.Drawing.Point(332, 77)
        Me.cboStartReadNumber.Name = "cboStartReadNumber"
        Me.cboStartReadNumber.Size = New System.Drawing.Size(59, 21)
        Me.cboStartReadNumber.TabIndex = 28
        '
        'cboStartReadAdress
        '
        Me.cboStartReadAdress.FormattingEnabled = True
        Me.cboStartReadAdress.Location = New System.Drawing.Point(137, 76)
        Me.cboStartReadAdress.Name = "cboStartReadAdress"
        Me.cboStartReadAdress.Size = New System.Drawing.Size(102, 21)
        Me.cboStartReadAdress.TabIndex = 26
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.opReadKeyB)
        Me.GroupBox4.Controls.Add(Me.opReadKeyA)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(145, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(141, 50)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'opReadKeyB
        '
        Me.opReadKeyB.AutoSize = True
        Me.opReadKeyB.Location = New System.Drawing.Point(82, 19)
        Me.opReadKeyB.Name = "opReadKeyB"
        Me.opReadKeyB.Size = New System.Drawing.Size(53, 17)
        Me.opReadKeyB.TabIndex = 1
        Me.opReadKeyB.Text = "Key B"
        Me.opReadKeyB.UseVisualStyleBackColor = True
        '
        'opReadKeyA
        '
        Me.opReadKeyA.AutoSize = True
        Me.opReadKeyA.Checked = True
        Me.opReadKeyA.Location = New System.Drawing.Point(6, 19)
        Me.opReadKeyA.Name = "opReadKeyA"
        Me.opReadKeyA.Size = New System.Drawing.Size(53, 17)
        Me.opReadKeyA.TabIndex = 0
        Me.opReadKeyA.TabStop = True
        Me.opReadKeyA.Text = "Key A"
        Me.opReadKeyA.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.opReadAll)
        Me.GroupBox7.Controls.Add(Me.Option1)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(127, 50)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        '
        'opReadAll
        '
        Me.opReadAll.AutoSize = True
        Me.opReadAll.Location = New System.Drawing.Point(75, 19)
        Me.opReadAll.Name = "opReadAll"
        Me.opReadAll.Size = New System.Drawing.Size(36, 17)
        Me.opReadAll.TabIndex = 1
        Me.opReadAll.Text = "All"
        Me.opReadAll.UseVisualStyleBackColor = True
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Checked = True
        Me.Option1.Location = New System.Drawing.Point(15, 19)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(41, 17)
        Me.Option1.TabIndex = 0
        Me.Option1.TabStop = True
        Me.Option1.Text = "idle"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.autoReadChk)
        Me.GroupBox1.Controls.Add(Me.cmdBacaKartu)
        Me.GroupBox1.Controls.Add(Me.cmdTulisKartu)
        Me.GroupBox1.Controls.Add(Me.generateBtn)
        Me.GroupBox1.Controls.Add(Me.RandomNomorTxt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.KodePrefixTxt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.KodeOperatorTxt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSisaSaldo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNoKartu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 202)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Kartu"
        '
        'cmdBacaKartu
        '
        Me.cmdBacaKartu.Image = Global.MiFareCardTools.My.Resources.Resources.play
        Me.cmdBacaKartu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBacaKartu.Location = New System.Drawing.Point(179, 163)
        Me.cmdBacaKartu.Name = "cmdBacaKartu"
        Me.cmdBacaKartu.Size = New System.Drawing.Size(108, 23)
        Me.cmdBacaKartu.TabIndex = 34
        Me.cmdBacaKartu.Text = "Baca kartu"
        Me.cmdBacaKartu.UseVisualStyleBackColor = True
        '
        'cmdTulisKartu
        '
        Me.cmdTulisKartu.Image = Global.MiFareCardTools.My.Resources.Resources.reply
        Me.cmdTulisKartu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTulisKartu.Location = New System.Drawing.Point(293, 163)
        Me.cmdTulisKartu.Name = "cmdTulisKartu"
        Me.cmdTulisKartu.Size = New System.Drawing.Size(98, 23)
        Me.cmdTulisKartu.TabIndex = 35
        Me.cmdTulisKartu.Text = "Tulis Kartu"
        Me.cmdTulisKartu.UseVisualStyleBackColor = True
        '
        'generateBtn
        '
        Me.generateBtn.Image = Global.MiFareCardTools.My.Resources.Resources.foward
        Me.generateBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.generateBtn.Location = New System.Drawing.Point(301, 50)
        Me.generateBtn.Name = "generateBtn"
        Me.generateBtn.Size = New System.Drawing.Size(90, 23)
        Me.generateBtn.TabIndex = 33
        Me.generateBtn.Text = "Generate"
        Me.generateBtn.UseVisualStyleBackColor = True
        '
        'RandomNomorTxt
        '
        Me.RandomNomorTxt.BackColor = System.Drawing.Color.White
        Me.RandomNomorTxt.Location = New System.Drawing.Point(117, 52)
        Me.RandomNomorTxt.MaxLength = 6
        Me.RandomNomorTxt.Name = "RandomNomorTxt"
        Me.RandomNomorTxt.Size = New System.Drawing.Size(178, 20)
        Me.RandomNomorTxt.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Random Nomor"
        '
        'KodePrefixTxt
        '
        Me.KodePrefixTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KodePrefixTxt.Location = New System.Drawing.Point(117, 26)
        Me.KodePrefixTxt.MaxLength = 3
        Me.KodePrefixTxt.Name = "KodePrefixTxt"
        Me.KodePrefixTxt.Size = New System.Drawing.Size(44, 20)
        Me.KodePrefixTxt.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Kode Prefix"
        '
        'KodeOperatorTxt
        '
        Me.KodeOperatorTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KodeOperatorTxt.Location = New System.Drawing.Point(251, 26)
        Me.KodeOperatorTxt.MaxLength = 2
        Me.KodeOperatorTxt.Name = "KodeOperatorTxt"
        Me.KodeOperatorTxt.Size = New System.Drawing.Size(44, 20)
        Me.KodeOperatorTxt.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Kode Operator"
        '
        'txtSisaSaldo
        '
        Me.txtSisaSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSisaSaldo.Location = New System.Drawing.Point(117, 132)
        Me.txtSisaSaldo.Name = "txtSisaSaldo"
        Me.txtSisaSaldo.Size = New System.Drawing.Size(274, 20)
        Me.txtSisaSaldo.TabIndex = 16
        Me.txtSisaSaldo.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Saldo "
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.Location = New System.Drawing.Point(117, 106)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(274, 20)
        Me.txtNama.TabIndex = 14
        '
        'txtNoKartu
        '
        Me.txtNoKartu.BackColor = System.Drawing.Color.White
        Me.txtNoKartu.Location = New System.Drawing.Point(117, 78)
        Me.txtNoKartu.MaxLength = 8
        Me.txtNoKartu.Name = "txtNoKartu"
        Me.txtNoKartu.Size = New System.Drawing.Size(274, 20)
        Me.txtNoKartu.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nama Pemilik"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Barcode Kartu"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdPotongSaldo)
        Me.GroupBox2.Controls.Add(Me.cmdIsiSaldo)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 114)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldo"
        '
        'cmdPotongSaldo
        '
        Me.cmdPotongSaldo.Image = Global.MiFareCardTools.My.Resources.Resources.action_remove
        Me.cmdPotongSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPotongSaldo.Location = New System.Drawing.Point(293, 59)
        Me.cmdPotongSaldo.Name = "cmdPotongSaldo"
        Me.cmdPotongSaldo.Size = New System.Drawing.Size(98, 33)
        Me.cmdPotongSaldo.TabIndex = 34
        Me.cmdPotongSaldo.Text = "Potong"
        Me.cmdPotongSaldo.UseVisualStyleBackColor = True
        '
        'cmdIsiSaldo
        '
        Me.cmdIsiSaldo.Image = Global.MiFareCardTools.My.Resources.Resources.action_add
        Me.cmdIsiSaldo.Location = New System.Drawing.Point(195, 59)
        Me.cmdIsiSaldo.Name = "cmdIsiSaldo"
        Me.cmdIsiSaldo.Size = New System.Drawing.Size(92, 33)
        Me.cmdIsiSaldo.TabIndex = 33
        Me.cmdIsiSaldo.Text = "Tambah"
        Me.cmdIsiSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdIsiSaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdIsiSaldo.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldo.Location = New System.Drawing.Point(117, 33)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(274, 20)
        Me.txtSaldo.TabIndex = 16
        Me.txtSaldo.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jumlah Saldo"
        '
        'autoReadChk
        '
        Me.autoReadChk.AutoSize = True
        Me.autoReadChk.Location = New System.Drawing.Point(19, 169)
        Me.autoReadChk.Name = "autoReadChk"
        Me.autoReadChk.Size = New System.Drawing.Size(72, 17)
        Me.autoReadChk.TabIndex = 36
        Me.autoReadChk.Text = "Auto read"
        Me.autoReadChk.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(433, 501)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MiFare Card Tools"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboStartReadNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cboReadKey As System.Windows.Forms.ComboBox
    Friend WithEvents cboStartReadAdress As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents opReadKeyB As System.Windows.Forms.RadioButton
    Friend WithEvents opReadKeyA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents opReadAll As System.Windows.Forms.RadioButton
    Friend WithEvents Option1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSisaSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNoKartu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPotongSaldo As System.Windows.Forms.Button
    Friend WithEvents cmdIsiSaldo As System.Windows.Forms.Button
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAddress As System.Windows.Forms.TextBox
    Friend WithEvents cmdBacaKartu As System.Windows.Forms.Button
    Friend WithEvents cmdTulisKartu As System.Windows.Forms.Button
    Friend WithEvents generateBtn As System.Windows.Forms.Button
    Friend WithEvents RandomNomorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KodePrefixTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KodeOperatorTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents autoReadChk As System.Windows.Forms.CheckBox

End Class
