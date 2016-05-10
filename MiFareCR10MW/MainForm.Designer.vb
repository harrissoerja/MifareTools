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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cboAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDeviceNumber = New System.Windows.Forms.TextBox()
        Me.txtSetSerNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdWrite = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWriteData = New System.Windows.Forms.TextBox()
        Me.cboWriteKey = New System.Windows.Forms.ComboBox()
        Me.cboStartWriteNumber = New System.Windows.Forms.ComboBox()
        Me.cboStartWriteAdress = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.opWriteKeyB = New System.Windows.Forms.RadioButton()
        Me.opWriteKeyA = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.opWriteAll = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboStartReadNumber = New System.Windows.Forms.ComboBox()
        Me.cboReadKey = New System.Windows.Forms.ComboBox()
        Me.cboStartReadAdress = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.opReadKeyB = New System.Windows.Forms.RadioButton()
        Me.opReadKeyA = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.opReadAll = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.opcardKeyB = New System.Windows.Forms.RadioButton()
        Me.opcardKeyA = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.opcardAll = New System.Windows.Forms.RadioButton()
        Me.Option17 = New System.Windows.Forms.RadioButton()
        Me.cmdcard = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(589, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.cboAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDeviceNumber)
        Me.GroupBox1.Controls.Add(Me.txtSetSerNum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 127)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Device Command"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(316, 77)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "set DevAddr"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cboAddress
        '
        Me.cboAddress.Location = New System.Drawing.Point(117, 73)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(37, 20)
        Me.cboAddress.TabIndex = 16
        Me.cboAddress.Text = "00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Device Address"
        '
        'txtDeviceNumber
        '
        Me.txtDeviceNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDeviceNumber.Location = New System.Drawing.Point(117, 47)
        Me.txtDeviceNumber.Name = "txtDeviceNumber"
        Me.txtDeviceNumber.ReadOnly = True
        Me.txtDeviceNumber.Size = New System.Drawing.Size(193, 20)
        Me.txtDeviceNumber.TabIndex = 14
        '
        'txtSetSerNum
        '
        Me.txtSetSerNum.Location = New System.Drawing.Point(117, 22)
        Me.txtSetSerNum.Name = "txtSetSerNum"
        Me.txtSetSerNum.Size = New System.Drawing.Size(193, 20)
        Me.txtSetSerNum.TabIndex = 13
        Me.txtSetSerNum.Text = "AB AB AB AB AB AB AB AB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Device SN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Set Device SN"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(316, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Read SN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(316, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Set SN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdWrite)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtWriteData)
        Me.GroupBox2.Controls.Add(Me.cboWriteKey)
        Me.GroupBox2.Controls.Add(Me.cboStartWriteNumber)
        Me.GroupBox2.Controls.Add(Me.cboStartWriteAdress)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 219)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Write Data"
        '
        'cmdWrite
        '
        Me.cmdWrite.Location = New System.Drawing.Point(316, 32)
        Me.cmdWrite.Name = "cmdWrite"
        Me.cmdWrite.Size = New System.Drawing.Size(75, 23)
        Me.cmdWrite.TabIndex = 22
        Me.cmdWrite.Text = "Write Data"
        Me.cmdWrite.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "The Data for Write to Card"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "The Six Bytes Block Key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Number of Block"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Start Address of Block"
        '
        'txtWriteData
        '
        Me.txtWriteData.Location = New System.Drawing.Point(25, 178)
        Me.txtWriteData.Name = "txtWriteData"
        Me.txtWriteData.Size = New System.Drawing.Size(375, 20)
        Me.txtWriteData.TabIndex = 17
        Me.txtWriteData.Text = "AB AB AB AB AB AB AB AB AB AB AB AB AB AB AB AB AB"
        '
        'cboWriteKey
        '
        Me.cboWriteKey.FormattingEnabled = True
        Me.cboWriteKey.Location = New System.Drawing.Point(152, 130)
        Me.cboWriteKey.Name = "cboWriteKey"
        Me.cboWriteKey.Size = New System.Drawing.Size(141, 21)
        Me.cboWriteKey.TabIndex = 13
        '
        'cboStartWriteNumber
        '
        Me.cboStartWriteNumber.FormattingEnabled = True
        Me.cboStartWriteNumber.Location = New System.Drawing.Point(152, 103)
        Me.cboStartWriteNumber.Name = "cboStartWriteNumber"
        Me.cboStartWriteNumber.Size = New System.Drawing.Size(59, 21)
        Me.cboStartWriteNumber.TabIndex = 12
        '
        'cboStartWriteAdress
        '
        Me.cboStartWriteAdress.FormattingEnabled = True
        Me.cboStartWriteAdress.Location = New System.Drawing.Point(152, 76)
        Me.cboStartWriteAdress.Name = "cboStartWriteAdress"
        Me.cboStartWriteAdress.Size = New System.Drawing.Size(59, 21)
        Me.cboStartWriteAdress.TabIndex = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.opWriteKeyB)
        Me.GroupBox6.Controls.Add(Me.opWriteKeyA)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(152, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(141, 50)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        '
        'opWriteKeyB
        '
        Me.opWriteKeyB.AutoSize = True
        Me.opWriteKeyB.Location = New System.Drawing.Point(82, 19)
        Me.opWriteKeyB.Name = "opWriteKeyB"
        Me.opWriteKeyB.Size = New System.Drawing.Size(53, 17)
        Me.opWriteKeyB.TabIndex = 1
        Me.opWriteKeyB.Text = "Key B"
        Me.opWriteKeyB.UseVisualStyleBackColor = True
        '
        'opWriteKeyA
        '
        Me.opWriteKeyA.AutoSize = True
        Me.opWriteKeyA.Checked = True
        Me.opWriteKeyA.Location = New System.Drawing.Point(6, 19)
        Me.opWriteKeyA.Name = "opWriteKeyA"
        Me.opWriteKeyA.Size = New System.Drawing.Size(53, 17)
        Me.opWriteKeyA.TabIndex = 0
        Me.opWriteKeyA.TabStop = True
        Me.opWriteKeyA.Text = "Key A"
        Me.opWriteKeyA.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.opWriteAll)
        Me.GroupBox5.Controls.Add(Me.Option2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(127, 50)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        '
        'opWriteAll
        '
        Me.opWriteAll.AutoSize = True
        Me.opWriteAll.Location = New System.Drawing.Point(75, 19)
        Me.opWriteAll.Name = "opWriteAll"
        Me.opWriteAll.Size = New System.Drawing.Size(36, 17)
        Me.opWriteAll.TabIndex = 1
        Me.opWriteAll.Text = "All"
        Me.opWriteAll.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Checked = True
        Me.Option2.Location = New System.Drawing.Point(15, 19)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(41, 17)
        Me.Option2.TabIndex = 0
        Me.Option2.TabStop = True
        Me.Option2.Text = "idle"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboStartReadNumber)
        Me.GroupBox3.Controls.Add(Me.cboReadKey)
        Me.GroupBox3.Controls.Add(Me.cboStartReadAdress)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.cmdRead)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 370)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 165)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Read Data"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(316, 61)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Batch read"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "The Six Bytes Block Key"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Number of Block"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Start Address of Block"
        '
        'cboStartReadNumber
        '
        Me.cboStartReadNumber.FormattingEnabled = True
        Me.cboStartReadNumber.Location = New System.Drawing.Point(152, 103)
        Me.cboStartReadNumber.Name = "cboStartReadNumber"
        Me.cboStartReadNumber.Size = New System.Drawing.Size(59, 21)
        Me.cboStartReadNumber.TabIndex = 28
        '
        'cboReadKey
        '
        Me.cboReadKey.FormattingEnabled = True
        Me.cboReadKey.Location = New System.Drawing.Point(152, 130)
        Me.cboReadKey.Name = "cboReadKey"
        Me.cboReadKey.Size = New System.Drawing.Size(141, 21)
        Me.cboReadKey.TabIndex = 27
        '
        'cboStartReadAdress
        '
        Me.cboStartReadAdress.FormattingEnabled = True
        Me.cboStartReadAdress.Location = New System.Drawing.Point(152, 76)
        Me.cboStartReadAdress.Name = "cboStartReadAdress"
        Me.cboStartReadAdress.Size = New System.Drawing.Size(59, 21)
        Me.cboStartReadAdress.TabIndex = 26
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.opReadKeyB)
        Me.GroupBox4.Controls.Add(Me.opReadKeyA)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(152, 19)
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
        Me.GroupBox7.Location = New System.Drawing.Point(19, 19)
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
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(316, 32)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(75, 23)
        Me.cmdRead.TabIndex = 23
        Me.cmdRead.Text = "Read Data"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(427, 594)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Str To Hex"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.GroupBox10)
        Me.GroupBox8.Controls.Add(Me.cmdcard)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(12, 541)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(409, 79)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Card Number"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.opcardKeyB)
        Me.GroupBox9.Controls.Add(Me.opcardKeyA)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(152, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(141, 50)
        Me.GroupBox9.TabIndex = 11
        Me.GroupBox9.TabStop = False
        '
        'opcardKeyB
        '
        Me.opcardKeyB.AutoSize = True
        Me.opcardKeyB.Location = New System.Drawing.Point(73, 19)
        Me.opcardKeyB.Name = "opcardKeyB"
        Me.opcardKeyB.Size = New System.Drawing.Size(61, 17)
        Me.opcardKeyB.TabIndex = 1
        Me.opcardKeyB.Text = "No Halt"
        Me.opcardKeyB.UseVisualStyleBackColor = True
        '
        'opcardKeyA
        '
        Me.opcardKeyA.AutoSize = True
        Me.opcardKeyA.Checked = True
        Me.opcardKeyA.Location = New System.Drawing.Point(23, 19)
        Me.opcardKeyA.Name = "opcardKeyA"
        Me.opcardKeyA.Size = New System.Drawing.Size(44, 17)
        Me.opcardKeyA.TabIndex = 0
        Me.opcardKeyA.TabStop = True
        Me.opcardKeyA.Text = "Halt"
        Me.opcardKeyA.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.opcardAll)
        Me.GroupBox10.Controls.Add(Me.Option17)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(127, 50)
        Me.GroupBox10.TabIndex = 10
        Me.GroupBox10.TabStop = False
        '
        'opcardAll
        '
        Me.opcardAll.AutoSize = True
        Me.opcardAll.Location = New System.Drawing.Point(75, 19)
        Me.opcardAll.Name = "opcardAll"
        Me.opcardAll.Size = New System.Drawing.Size(36, 17)
        Me.opcardAll.TabIndex = 1
        Me.opcardAll.Text = "All"
        Me.opcardAll.UseVisualStyleBackColor = True
        '
        'Option17
        '
        Me.Option17.AutoSize = True
        Me.Option17.Checked = True
        Me.Option17.Location = New System.Drawing.Point(15, 19)
        Me.Option17.Name = "Option17"
        Me.Option17.Size = New System.Drawing.Size(41, 17)
        Me.Option17.TabIndex = 0
        Me.Option17.TabStop = True
        Me.Option17.Text = "idle"
        Me.Option17.UseVisualStyleBackColor = True
        '
        'cmdcard
        '
        Me.cmdcard.Location = New System.Drawing.Point(299, 32)
        Me.cmdcard.Name = "cmdcard"
        Me.cmdcard.Size = New System.Drawing.Size(101, 23)
        Me.cmdcard.TabIndex = 4
        Me.cmdcard.Text = "Card UID"
        Me.cmdcard.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.TextBox1)
        Me.GroupBox11.Location = New System.Drawing.Point(427, 12)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(417, 576)
        Me.GroupBox11.TabIndex = 12
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Data Receive"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(405, 551)
        Me.TextBox1.TabIndex = 2
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(508, 594)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Hex to Str"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(316, 90)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 33
        Me.Button8.Text = "Read Data"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 635)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CR10MW-RW Card - ATMOSFER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDeviceNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSetSerNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmdWrite As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtWriteData As System.Windows.Forms.TextBox
    Friend WithEvents cboWriteKey As System.Windows.Forms.ComboBox
    Friend WithEvents cboStartWriteNumber As System.Windows.Forms.ComboBox
    Friend WithEvents cboStartWriteAdress As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents opWriteKeyB As System.Windows.Forms.RadioButton
    Friend WithEvents opWriteKeyA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents opWriteAll As System.Windows.Forms.RadioButton
    Friend WithEvents Option2 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdRead As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents opcardKeyB As System.Windows.Forms.RadioButton
    Friend WithEvents opcardKeyA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents opcardAll As System.Windows.Forms.RadioButton
    Friend WithEvents Option17 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdcard As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
