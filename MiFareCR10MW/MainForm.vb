
Imports System.Runtime.InteropServices
Imports MiFareCR10MW.ClsAPICR10MW

Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'Fast start to write the address, adding 16, the default 10
        For i = 0 To 63
            cboStartWriteAdress.Items.Add(Val(i))
        Next
        cboStartWriteAdress.Text = "10"

        'Write the start block number, add 4, default 01
        cboStartWriteNumber.Items.Add("01")
        cboStartWriteNumber.Items.Add("02")
        cboStartWriteNumber.Items.Add("03")
        cboStartWriteNumber.Items.Add("04")
        cboStartWriteNumber.Text = "01"

        'Write the password, add three default fffff
        cboWriteKey.Items.Add("A0 A1 A2 A3 A4 A5")
        cboWriteKey.Items.Add("B0 B1 B2 B3 B4 B5")
        cboWriteKey.Items.Add("FF FF FF FF FF FF")
        cboWriteKey.Text = "FF FF FF FF FF FF"

        'Initialize the ListBox

        'Port of call to open the program
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ret, devAddr As Integer
        Dim asnr(20) As Byte
        Dim aBuffer(2048) As Byte

        'Factory preset address
        devAddr = myVal(cboAddress.Text)

        'Incoming data into a buffer
        ret = hexToBin(txtSetSerNum.Text, asnr)

        ret = API_SetSerNum(hComm, devAddr, asnr(0), aBuffer(0))
        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & (CStr(Now) + "  success..") & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & (CStr(Now) + "  success..") & vbCrLf
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ret, devAddr As Integer
        Dim aBuffer(2048) As Byte

        'Factory preset address
        devAddr = myVal(cboAddress.Text)
        ret = API_GetSerNum(hComm, devAddr, aBuffer(0))

        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & "success.." & vbCrLf
            TextBox1.Text = TextBox1.Text & CStr(Now) + " receive data:" & vbCrLf
            TextBox1.Text = TextBox1.Text & strByHexb(aBuffer, 8, 1) & vbCrLf
            txtDeviceNumber.Text = strByHexb(aBuffer, 8, 1)

            'TextBox1.Text = TextBox1.Text & aBuffer(8).ToString & vbCrLf
            'txtDeviceNumber.Text = aBuffer(1).ToString
        Else
            If IsNothing(ret) Then
                TextBox1.Text = TextBox1.Text & CStr(Now) + "  error,no data receive :" & vbCrLf
            Else
                TextBox1.Text = TextBox1.Text & CStr(Now) + "  false,the reason is.." + falsereason(CStr(strByHex(aBuffer, 1))) & vbCrLf
            End If
        End If
    End Sub

    Private Sub cmdWrite_Click(sender As Object, e As EventArgs) Handles cmdWrite.Click
        Dim ret As Integer
        Dim blk_Addr As Integer
        Dim mode, devAddr, Num_blk As Byte

        Dim asnr(20) As Byte
        Dim aBuffer(2048) As Byte

        'Dim strRet As String
        mode = &O0

        'Device address, if there is only one
        devAddr = myVal(cboAddress.Text)
        'Write to take the start address
        blk_Addr = Val(cboStartWriteAdress.Text)

        'Write fetch mode
        If Option2.Checked = True And opWriteKeyA.Checked = True Then mode = &O0
        If Option2.Checked = True And opWriteKeyB.Checked = True Then mode = &O2
        If opWriteAll.Checked = True And opWriteKeyA.Checked = True Then mode = &O1
        If opWriteAll.Checked = True And opWriteKeyB.Checked = True Then mode = &O3

        'Write the number of blocks
        Num_blk = Val(cboStartWriteNumber.Text)

        'A pointer passed is six byte key
        ret = hexToBin(cboWriteKey.Text, asnr)

        'Incoming data into a buffer
        ret = hexToBin(txtWriteData.Text, aBuffer)
        ret = API_PCDWrite(hComm, devAddr, mode, blk_Addr, Num_blk, asnr(0), aBuffer(0))
        'ret = API_PCDWrite(hComm, devAddr, mode, blk_Addr, Num_blk, asnr(0), txtWriteData.Text)

        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & "Success.." & vbCrLf
            TextBox1.Text = TextBox1.Text & "the receive card number is :" + strByHex(asnr, 4) & vbCrLf
        Else
            'If IsNothing(ret) Then
            '    TextBox1.Text = TextBox1.Text & "false,the reason is.." + falsereason(strByHex(aBuffer, 1)) & vbCrLf
            'Else
            '    TextBox1.Text = TextBox1.Text & "Error No data receive.." & vbCrLf
            'End If
            If IsNothing(ret) Then
                TextBox1.Text = TextBox1.Text & "error,no data receive :" & vbCrLf
            Else
                TextBox1.Text = TextBox1.Text & ("false,the reason is.." + falsereason(CStr(strByHex(aBuffer, 1)))) & vbCrLf
            End If
        End If

    End Sub

    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click

        Dim ret As Integer
        Dim blk_Addr, devAddr As Integer
        Dim mode, Num_blk As Byte

        Dim asnr(20) As Byte
        Dim aRecvBuffer(2048) As Byte
        Dim strRet As String
        mode = &O0

        'Device address, if there is only one 
        devAddr = myVal(cboAddress.Text)

        'Reads the start address
        blk_Addr = Val(cboStartReadAdress.Text)

        'Read Mode '¶ÁÈ¡Ä£Ê½
        If Option1.Checked = True And opReadKeyA.Checked = True Then mode = &O0
        If Option1.Checked = True And opReadKeyB.Checked = True Then mode = &O2

        If opReadAll.Checked = True And opReadKeyA.Checked = True Then mode = &O1
        If opReadAll.Checked = True And opReadKeyB.Checked = True Then mode = &O3

        'Read the number of blocks 
        Num_blk = Val(cboStartReadNumber.Text)

        'A pointer passed is six byte key 
        ret = hexToBin(cboReadKey.Text, asnr)
        ret = API_PCDRead(hComm, devAddr, mode, blk_Addr, Num_blk, asnr(0), aRecvBuffer(0))

        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & ("success..") & vbCrLf
            TextBox1.Text = TextBox1.Text & ("the receive card number is :" + strByHex(asnr, 4)) & vbCrLf
            TextBox1.Text = TextBox1.Text & (CStr(Now) + " receive data:") & vbCrLf
            TextBox1.Text = TextBox1.Text & (strByHex(aRecvBuffer, Num_blk * 16)) & vbCrLf
            txtWriteData.Text = (strByHex(aRecvBuffer, Num_blk * 16))
        Else
            If IsNothing(ret) Then
                TextBox1.Text = TextBox1.Text & (CStr(Now) + "  error,no data receive :") & vbCrLf
            Else
                strRet = strByHex(aRecvBuffer, 1)
                TextBox1.Text = TextBox1.Text & (CStr(Now) + "  false,the reason is.." + falsereason(strByHex(aRecvBuffer, 1))) & vbCrLf
                strRet = TextBox1.Text & falsereason(strByHex(aRecvBuffer, 1))
            End If
        End If

    End Sub

    Private Sub cmdcard_Click(sender As Object, e As EventArgs) Handles cmdcard.Click
        Dim ret As Integer
        'Dim dataLen As Integer
        Dim mode, devAddr, half As Byte
        Dim asnr(20) As Byte
        Dim aBuffer(2048) As Byte
        'Dim strRet As String

        mode = &O0

        'Device address, if there is only one 
        devAddr = myVal(cboAddress.Text)

        'Write fetch mode
        If Option17.Checked = True Then
            mode = 38
        Else
            mode = 82
        End If

        If opcardKeyA.Checked = True Then
            half = &O0
        Else
            half = &O1
        End If

        'ret = API_ControlBuzzer(hComm, devAddr, 1, half, aBuffer(0))
        ret = GET_SNR(hComm, devAddr, mode, half, asnr(0), aBuffer(0))

        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & "success.." & vbCrLf
            TextBox1.Text = TextBox1.Text & "the receive card number is :" + strByHex(aBuffer, 4) & vbCrLf

        Else
            If IsNothing(ret) Then
                TextBox1.Text = TextBox1.Text & "error,no data receive :" & vbCrLf
            Else
                TextBox1.Text = TextBox1.Text & ("false,the reason is.." + falsereason(CStr(strByHex(aBuffer, 1)))) & vbCrLf
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ConvertStr As String = Nothing

        ConvertStr = txtWriteData.Text
        txtWriteData.Text = StrToHex(ConvertStr)

        txtWriteData.Text = SeparateWord(txtWriteData.Text)
    End Sub

    'Function StringToHex(ByVal text As String) As String
    '    Dim hex As String = Nothing
    '    For i As Integer = 0 To text.Length - 1
    '        hex &= Asc(text.Substring(i, 1)).ToString("x").ToUpper
    '    Next

    '    Return hex
    'End Function

    'Function HexToString(ByVal hex As String) As String

    '    Dim text As New System.Text.StringBuilder(hex.Length \ 2)
    '    For i As Integer = 0 To hex.Length - 2 Step 2
    '        text.Append(Chr(Convert.ToByte(hex.Substring(i, 2), 16)))
    '    Next

    '    Return text.ToString

    'End Function


   

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ret, devAddr As Integer
        Dim asnr(20) As Byte
        Dim aBuffer(2048) As Byte

        'Factory preset address
        devAddr = myVal(cboAddress.Text)

        'Incoming data into a buffer
        ret = hexToBin(txtSetSerNum.Text, asnr)

        ret = API_SetDeviceAddress(hComm, DevAddress, cboAddress.Text, aBuffer(0))
        If ret = 0 Then
            TextBox1.Text = TextBox1.Text & (CStr(Now) + "  success..") & vbCrLf
        Else
            TextBox1.Text = TextBox1.Text & (CStr(Now) + "  success..") & vbCrLf
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ConvHex As String = Nothing

        ConvHex = (txtWriteData.Text).Replace(" ", "")
        txtWriteData.Text = HexToStr(ConvHex)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim ret As Integer
        Dim blk_Addr, devAddr As Integer
        Dim mode, Num_blk As Byte

        Dim asnr(20) As Byte
        Dim aRecvBuffer(2048) As Byte
        Dim strRet As String
        mode = &O0

        'Device address, if there is only one 
        devAddr = myVal(cboAddress.Text)

        'Reads the start address
        blk_Addr = Val(64)

        'Read Mode '¶ÁÈ¡Ä£Ê½
        If Option1.Checked = True And opReadKeyA.Checked = True Then mode = &O0
        If Option1.Checked = True And opReadKeyB.Checked = True Then mode = &O2

        If opReadAll.Checked = True And opReadKeyA.Checked = True Then mode = &O1
        If opReadAll.Checked = True And opReadKeyB.Checked = True Then mode = &O3

        'Read the number of blocks 
        Num_blk = Val(cboStartReadNumber.Text)
        If MsgBox("Batch read will sound buzzer for 64 times, do you still want to run it?", vbQuestion + vbYesNo) = vbYes Then
            'A pointer passed is six byte key 
            For i = 1 To blk_Addr
                ret = hexToBin(cboReadKey.Text, asnr)
                ret = API_PCDRead(hComm, devAddr, mode, i, Num_blk, asnr(0), aRecvBuffer(0))

                If ret = 0 Then
                    TextBox1.Text = TextBox1.Text & ("success..") & vbCrLf
                    TextBox1.Text = TextBox1.Text & ("the receive card number is :" + strByHex(asnr, 4)) & vbCrLf
                    TextBox1.Text = TextBox1.Text & "address blok : " & i & vbCrLf
                    TextBox1.Text = TextBox1.Text & (strByHex(aRecvBuffer, Num_blk * 16)) & vbCrLf
                    txtWriteData.Text = (strByHex(aRecvBuffer, Num_blk * 16))
                Else
                    If IsNothing(ret) Then
                        TextBox1.Text = TextBox1.Text & (CStr(Now) + "  error,no data receive :") & vbCrLf
                        TextBox1.Text = TextBox1.Text & "Address blok : " & i & vbCrLf
                    Else
                        strRet = strByHex(aRecvBuffer, 1)
                        TextBox1.Text = TextBox1.Text & (CStr(Now) + "  false,the reason is.." + falsereason(strByHex(aRecvBuffer, 1))) & vbCrLf
                        strRet = TextBox1.Text & falsereason(strByHex(aRecvBuffer, 1))
                        TextBox1.Text = TextBox1.Text & "Address blok : " & i & vbCrLf

                        'If card did not exist
                        'If strByHex(aRecvBuffer, 1) = 83 Then
                        ' Exit Sub
                        'End If

                    End If
                End If
            Next i
        End If
    End Sub

    Private Sub cboStartReadAdress_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStartReadAdress.KeyDown
        If e.KeyCode = 13 Then
            If cboStartReadAdress.Text <> "" Then
                Me.cmdRead.PerformClick()
                cboStartReadAdress.SelectAll()
            End If
        End If
    End Sub

    Private Sub cboStartReadAdress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStartReadAdress.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class


