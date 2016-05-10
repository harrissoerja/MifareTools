Imports System
Imports MiFareCR10MW.ClsAPICR10MW

Public Class MainForm

    Private Sub generateBtn_Click(sender As Object, e As EventArgs) Handles generateBtn.Click
        'Fungsi random nomor adalah untuk memberikan 6 angka random kepada kartu
        'disini fungsi ditekan khusus untuk menggenerate 6 angka unik
        'dan jika angka generate lebih dari 6 karakter maka akan di potong panjang karakternya
        'dan jika kurang, akan ditambahkan.

        Dim randomValue As Integer
        Dim upperBound As Integer
        Dim lowerBound As Integer

        upperBound = 1
        lowerBound = 999999
        randomValue = (Math.Floor((upperBound - lowerBound + 1) * Rnd())) + lowerBound

        '=======
        'TODO cek panjang karakter agar generate number selalu 6 angka
        '=======
        'If CType(randomValue, String).Length < 6 Then
        '    randomValue = (randomValue * 999)
        '    randomValue = CType(Mid(1, 6))

        '    MessageBox.Show("dibawah 6")
        'ElseIf CType(randomValue, String).Length > 6 Then
        '    randomValue = CType(Mid(1, 6))

        '    MessageBox.Show("diatas 6")
        'End If

        RandomNomorTxt.Text = randomValue

    End Sub
    Public Sub initComboBox()
        Dim i As Integer
        Dim DevAddress As String = cboAddress.Text

        'Fast read start address, by adding 16, 10 by default
        'sektor pada kartu
        For i = 0 To 63
            cboStartReadAdress.Items.Add(Val(i))
        Next

        cboStartReadAdress.Text = "10"

        'Read a start block number, adding 4, the default 01
        cboStartReadNumber.Items.Add("01")
        cboStartReadNumber.Items.Add("02")
        cboStartReadNumber.Items.Add("03")
        cboStartReadNumber.Items.Add("04")
        cboStartReadNumber.Text = "01"

        'Reading the password, add three default fffff
        cboReadKey.Items.Add("A0 A1 A2 A3 A4 A5")
        cboReadKey.Items.Add("B0 B1 B2 B3 B4 B5")
        cboReadKey.Items.Add("FF FF FF FF FF FF")
        cboReadKey.Text = "FF FF FF FF FF FF"
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComboBox()
    End Sub

    Private Sub cmdTulisKartu_Click(sender As Object, e As EventArgs) Handles cmdTulisKartu.Click
        'Proses Penulisan Kartu MiFare

        Dim ConvertStr As String = Nothing
        Dim ret As Integer
        Dim blk_Addr As Integer = Val(cboStartReadAdress.Text) 'Nomor Sektor
        Dim mode As Byte = &O0 'Mode Penulisan Kartu
        Dim devAddr As Byte = myVal(cboAddress.Text) 'Device Addres (beda dengan Port Address)
        Dim Num_blk As Byte = Val(cboStartReadNumber.Text)
        Dim ConvHex As String = Nothing
        Dim asnr(20) As Byte
        Dim aBuffer(2048) As Byte
        Dim CharGabungan As String
        Dim noKartu As String
        Dim DataSiapTulis As String

        'Penggabungan 4 Field Kartu yaitu KodePrefix & KodeOperator & RandomNumber & 8Barcode Nomor
        noKartu = KodePrefixTxt.Text & KodeOperatorTxt.Text & RandomNomorTxt.Text & txtNoKartu.Text

        'Penggabungan Nomor Kartu yang sudah digabung dengan data pengguna dan saldo
        CharGabungan = noKartu & "#" & txtNama.Text & "#" & txtSisaSaldo.Text

        'agar bisa ditulis ke dalam kartu, semua gabungan field harus di konvert ke hexa terlebih dahulu.
        ConvertStr = StrToHex(CharGabungan)
        DataSiapTulis = (ConvertStr)

        'Pemisahan Hexa menjadi 2 2 (byte per byte) Format
        DataSiapTulis = SeparateWord(DataSiapTulis)

        'Write fetch mode
        If Option1.Checked = True And opReadKeyA.Checked = True Then mode = &O0
        If Option1.Checked = True And opReadKeyB.Checked = True Then mode = &O2
        If opReadAll.Checked = True And opReadKeyA.Checked = True Then mode = &O1
        If opReadAll.Checked = True And opReadKeyB.Checked = True Then mode = &O3

        'A pointer passed is six byte key
        ret = hexToBin(cboReadKey.Text, asnr)

        'Menyiapkan data terakhir yang ingin ditulis
        ret = hexToBin(DataSiapTulis, aBuffer)

        'Tulis data ke kartu
        ret = API_PCDWrite(hComm, devAddr, mode, blk_Addr, Num_blk, asnr(0), aBuffer(0))

        If ret = 0 Then
            MsgBox("Tulis Data Sukses", vbInformation)
        Else

            If IsNothing(ret) Then
                MsgBox("Gagal menulis data, silakan ulang kembali")
            Else
                MsgBox(falsereason(CStr(strByHex(aBuffer, 1))))
            End If
        End If
    End Sub

    Private Sub cmdBacaKartu_Click(sender As Object, e As EventArgs) Handles cmdBacaKartu.Click
        'Proses Pembacaan Kartu MiFare

        Dim ret As Integer
        Dim blk_Addr As Integer = Val(cboStartReadAdress.Text) 'Nomor Sektor 1-64
        Dim devAddr As Integer = myVal(cboAddress.Text) '00
        Dim mode As Byte = &O0
        Dim Num_blk As Byte = Val(cboStartReadNumber.Text) 'Nomor Blok 1-4

        Dim AddrPortStr As String = cboReadKey.Text 'FF FF FF FF FF FF

        Dim asnr(20) As Byte
        Dim aRecvBuffer(2048) As Byte

        Dim ConvertStr As String = Nothing
        Dim ConvHex As String = Nothing

        Dim strRet As String

        Dim strDataKartu As String
        Dim ArrayDataKartu() As String

        Dim noKartu As String
        Dim DataSiapBaca As String

        'Read Mode 
        If Option1.Checked = True And opReadKeyA.Checked = True Then mode = &O0
        If Option1.Checked = True And opReadKeyB.Checked = True Then mode = &O2

        If opReadAll.Checked = True And opReadKeyA.Checked = True Then mode = &O1
        If opReadAll.Checked = True And opReadKeyB.Checked = True Then mode = &O3

        'A pointer passed is six byte key 
        ret = hexToBin(AddrPortStr, asnr)
        'MsgBox(asnr(0) & vbCrLf & asnr(1) & vbCrLf & asnr(2) & vbCrLf & asnr(3))

        'Baca data dari kartu sesuai konifgurasi yang sudah diset
        ret = API_PCDRead(hComm, devAddr, mode, blk_Addr, Num_blk, asnr(0), aRecvBuffer(0))

        Try
            If ret = 0 Then
                'Data sukses masuk
                GroupBox1.Text = "Data Kartu - " + strByHex(asnr, 4)
                DataSiapBaca = (strByHex(aRecvBuffer, Num_blk * 16))

                'Penggabungan dari Hexa karakter sehingga bisa dikonvert kedalam string
                ConvHex = (DataSiapBaca).Replace(" ", "")

                'Konversi ke String data mentah hexa yang masuk
                strDataKartu = HexToStr(ConvHex)
                'Pemisahan data split sesuai split character yaitu #, sehingga data yang berbaris dapat dipisah sesuai perkolom
                ArrayDataKartu = Split(strDataKartu, "#")

                'Masukkan data ke masing-masing field yang diinginkan.
                noKartu = ArrayDataKartu(0)

                KodePrefixTxt.Text = Mid(noKartu, 1, 3)
                KodeOperatorTxt.Text = Mid(noKartu, 4, 2)
                RandomNomorTxt.Text = Mid(noKartu, 6, 6)
                txtNoKartu.Text = Mid(noKartu, 12, 8)

                txtNama.Text = ArrayDataKartu(1)
                txtSisaSaldo.Text = ArrayDataKartu(2)
            Else
                If IsNothing(ret) Then
                    MsgBox("Tidak ada data yang diterima, silakan ulang kembali", vbExclamation)
                Else
                    strRet = strByHex(aRecvBuffer, 1)
                    MsgBox(falsereason(strByHex(aRecvBuffer, 1)), vbExclamation)
                    'MsgBox(strByHex(aRecvBuffer, 1))
                End If
            End If
        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Function cekLength() As String
        'untuk mengecek panjang data kode generator
        If Len(KodeOperatorTxt) <> 2 Then

        End If

        If Len(KodePrefixTxt) <> 3 Then

        End If

        If Len(RandomNomorTxt) <> 6 Then

        End If

        If Len(txtNoKartu) <> 8 Then

        End If

        Return Nothing
    End Function

    Private Sub cmdIsiSaldo_Click(sender As Object, e As EventArgs) Handles cmdIsiSaldo.Click
        Dim sisaSaldo As Long = txtSisaSaldo.Text
        Dim saldoTambahan As Long = txtSaldo.Text
        Dim totalsaldo As Long

        If txtNoKartu.Text <> "" Then
            If txtSaldo.Text <> "" Then
                totalsaldo = sisaSaldo + saldoTambahan
                txtSisaSaldo.Text = totalsaldo
                Me.cmdTulisKartu.PerformClick()
            End If
        Else
            MsgBox("Silakan Scan Kartu Terlebih dahulu", vbExclamation)
        End If
    End Sub

    Private Sub cmdPotongSaldo_Click(sender As Object, e As EventArgs) Handles cmdPotongSaldo.Click
        Dim sisaSaldo As Long = txtSisaSaldo.Text
        Dim saldoTambahan As Long = txtSaldo.Text
        Dim totalsaldo As Long

        If txtNoKartu.Text <> "" Then
            If txtSaldo.Text <> "" Then
                totalsaldo = sisaSaldo - saldoTambahan
                txtSisaSaldo.Text = totalsaldo
                Me.cmdTulisKartu.PerformClick()
            End If
        End If
    End Sub


End Class
