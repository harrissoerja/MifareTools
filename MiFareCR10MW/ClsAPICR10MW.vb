Imports Microsoft.VisualBasic
Imports System
Imports System.Runtime.InteropServices
Imports System.Text

'Class untuk mengakses API yang ada didalam mi.dll untuk reader tipe CR10MW Merk ZKTeco
'Written by suryadi.aris 21Agustus2014
'karena library mi.dll dicompile menggunakan VC++6.0 dan tidak bisa di reference langsung ke vb.net
'maka digunakanlah library  <DllImport("mi.dll")> dan Imports System.Runtime.InteropServices

Public Class ClsAPICR10MW
    Public Shared hComm As Long 'HandleCommunication default is 0

    'API Open Communication protocol
    <DllImport("mi.dll")> Public Shared Function API_OpenComm(ByRef comm As Byte, ByVal nBaudrate As Long) As Long
    End Function

    'API Close Communication protocol
    <DllImport("mi.dll")> Public Shared Function API_CloseComm(ByVal handle As Long) As Integer
    End Function

    'API untuk manggil SerialNumber Devices
    <DllImport("mi.dll")> Public Shared Function GET_SNR(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal half As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    'Untuk baca kartu
    <DllImport("mi.dll")> Public Shared Function API_PCDRead(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal blk_Addr As Byte, ByVal Num_blk As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    'Untuk menulis data ke kartu
    <DllImport("mi.dll")> Public Shared Function API_PCDWrite(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal blk_Addr As Byte, ByVal Num_blk As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function


    <DllImport("mi.dll")> Public Shared Function API_PCDInitVal(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal Num_blk As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    <DllImport("mi.dll")> Public Shared Function API_PCDDec(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal Num_blk As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    <DllImport("mi.dll")> Public Shared Function API_PCDInc(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal mode As Byte, ByVal Num_blk As Byte, _
        ByRef snr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    'Set Device Address
    <DllImport("mi.dll")> Public Shared Function API_SetDeviceAddress(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal new_Addr As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    'The bit rate of the computer
    <DllImport("mi.dll")> Public Shared Function API_SetBandrate(ByVal handle As Integer, ByVal deviceAddr As Integer, _
         ByVal newBaud As Byte, _
         ByRef Buffer As Byte) As Integer
    End Function

    'hcomm, addr0, jumlahBunyi, durasilama, buffer 2048
    <DllImport("mi.dll")> Public Shared Function API_ControlLED(ByVal handle As Integer, ByVal deviceAddr As Integer, _
        ByVal freq As Byte, ByVal duration As Byte, _
        ByRef Buffer As Byte) As Integer
    End Function

    <DllImport("mi.dll")> Public Shared Function API_ControlBuzzer(ByVal handle As Integer, ByVal deviceAddr As Integer,
        ByVal freq As Integer, ByVal duration As Integer, _
        ByRef Buffer As Byte) As Integer
    End Function

    'Read by the factory preset of a byte and 8-byte address reader serial number
    <DllImport("mi.dll")> Public Shared Function API_GetSerNum(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByRef Buffer As Byte) As Integer
    End Function

    'Read by the manufacturer preset one-byte and 8-byte address reader serial number
    <DllImport("mi.dll")> Public Shared Function API_SetSerNum(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByRef newvalue As Byte, ByRef Buffer As Byte) As Integer
    End Function

    'Select the card so that the card into the interrupted state
    <DllImport("mi.dll")> Public Shared Function MF_Halt(ByVal handle As Integer, ByVal deviceAddr As Integer) As Integer
    End Function

#Region "UltralightAPI"

    'Automatically reads the card Ultralight card number
    <DllImport("mi.dll")> Public Shared Function UL_Request(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal mode As Byte, _
            ByRef snr As Byte) As Integer
    End Function


    'Data 'reads the card specified sectors
    <DllImport("mi.dll")> Public Shared Function UL_HLRead(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal mode As Byte, ByVal blk_Addr As Byte, _
            ByRef snr As Byte, _
            ByRef Buffer As Byte) As Integer


    End Function

    'Take the card to write data specified sectors
    <DllImport("mi.dll")> Public Shared Function UL_HLWrite(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal mode As Byte, ByVal blk_Addr As Byte, _
            ByRef snr As Byte, _
            ByRef Buffer As Byte) As Integer
    End Function

#End Region

    'Take the card to write data specified sectors
    <DllImport("mi.dll")> Public Shared Function ISO15693_Inventory(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByRef snr As Byte, _
            ByRef Buffer As Byte) As Integer
    End Function

    'Read data
    <DllImport("mi.dll")> Public Shared Function API_ISO15693Read(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal flags As Byte, ByVal blk_Addr As Integer, ByVal Num_blk As Integer, _
            ByRef uid As Byte, _
            ByRef Buffer As Byte) As Integer
    End Function

    'Write Data
    <DllImport("mi.dll")> Public Shared Function API_ISO15693Write(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal flags As Byte, ByVal blk_Addr As Integer, ByVal Num_blk As Integer, _
            ByRef uid As Byte, _
            ByRef Buffer As Byte) As Integer
    End Function

    <DllImport("mi.dll")> Public Shared Function ReadUserInfo(ByVal handle As Integer, ByVal deviceAddr As Integer, _
            ByVal flags As Byte, ByVal blk_Addr As Integer, ByVal Num_blk As Integer, _
            ByRef uid As Byte, _
            ByRef Buffer As Byte) As Integer
    End Function

    Public Shared Function myVal(ByVal str As String)
        Dim retVal As Integer
        retVal = 0
        If Len(str) = 1 Then
            If str >= "0" And str <= "9" Then
                retVal = Val(str)
            ElseIf str >= "a" And str <= "z" Then
                retVal = Asc(str) - Asc("a") + 10
            ElseIf str >= "A" And str <= "Z" Then
                retVal = Asc(str) - Asc("A") + 10
            End If
        End If
        myVal = retVal
    End Function

    Public Shared Function asciiToBin(ByVal str As String, ByRef Buffer() As Byte)
        Dim i As Integer

        For i = 1 To Len(str)
            Buffer(i - 1) = Asc(Mid(str, i, 1))
        Next
        asciiToBin = i - 1
    End Function

    Public Shared Function hexToBin(ByVal str As String, ByRef Buffer() As Byte)
        Dim strRemain As String
        Dim firstChar As Boolean
        Dim i, count As Integer

        i = 0
        count = 0
        firstChar = True
        strRemain = str

        While Len(strRemain) > 0
            If Mid(strRemain, 1, 1) = " " Then
                firstChar = True
                strRemain = Mid(strRemain, 2)
            ElseIf firstChar = True Then
                If Len(strRemain) = 1 Then
                    Buffer(count) = myVal(strRemain)
                ElseIf Len(strRemain) >= 2 Then
                    Buffer(count) = myVal(Mid(strRemain, 1, 1)) * 16 + myVal(Mid(strRemain, 2, 1))
                    strRemain = Mid(strRemain, 3)
                End If

                count = count + 1
                firstChar = False
            Else
                strRemain = Mid(strRemain, 2)
            End If
        End While

        hexToBin = count
    End Function

    Public Shared Function strByAscii(ByRef Buffer() As Byte, ByVal bufferSize As Integer)
        Dim i As Integer
        Dim strRet, strSingle As String

        strRet = ""
        For i = 0 To bufferSize - 1
            strSingle = Chr(Buffer(i)) & "(" & Trim$(CStr(Buffer(i))) & ")"
            strRet = strRet + strSingle
        Next

        strByAscii = strRet
    End Function

    ' How much taken from the array
    Public Shared Function strByHex(ByRef Buffer() As Byte, ByVal bufferSize As Integer)
        Dim i As Integer
        Dim strRet, strSingle As String

        strRet = ""
        For i = 0 To bufferSize - 1
            strSingle = Hex$(Buffer(i))
            If Len(strSingle) = 1 Then
                strSingle = "0" & strSingle
            End If

            If bufferSize = 1 Then
                strRet = strSingle
            Else
                strRet = strRet + strSingle + " "
            End If

        Next

        strByHex = strRet
    End Function

    'Start number, and length of the
    Public Shared Function strByHexb(ByRef Buffer() As Byte, ByVal bufferSize As Integer, ByVal beginbuffer As Integer)
        Dim i As Integer
        Dim strRet, strSingle As String

        strRet = ""
        For i = beginbuffer To beginbuffer + bufferSize - 1
            strSingle = Hex$(Buffer(i))
            If Len(strSingle) = 1 Then
                strSingle = "0" & strSingle
            End If
            strRet = strRet + strSingle + " "
        Next

        strByHexb = strRet
    End Function

    'End of the number and length of
    Public Shared Function strByHexe(ByRef Buffer() As Byte, ByVal bufferSize As Integer, ByVal endbuffer As Integer)
        Dim i As Integer
        Dim strRet, strSingle As String

        strRet = ""
        For i = 0 To bufferSize - 1
            strSingle = Hex$(Buffer(endbuffer - i))
            If Len(strSingle) = 1 Then
                strSingle = "0" & strSingle
            End If
            strRet = strRet + strSingle + " "
        Next

        strByHexe = strRet
    End Function


    Public Shared Function falsereason(ByVal s As String)
        Dim reason As String = Nothing

        If s = "" Then
            reason = ""
        End If
        If s = "00" Then
            reason = "Error kemungkinan hardware belum terkoneksi"
        End If
        If s = "1" Then
            reason = "Perintah salah."
        End If
        If s = "2" Then
            reason = "Checksum Error....."
        End If
        If s = "3" Then
            reason = "COM Port belum dipilih"
        End If
        If s = "4" Then
            reason = "Time Out!"
        End If
        If s = "5" Then
            reason = "check sequence error....."
        End If
        If s = "7" Then
            reason = "check sum error....."
        End If
        If s = "10" Then
            reason = "the parameter value out of range....."
        End If
        If s = "80" Then
            reason = "Command OK....."
        End If
        If s = "81" Then
            reason = "Command FAILURE...."
        End If
        If s = "82" Then
            reason = "Reader reply time out error...."
        End If
        If s = "83" Then
            reason = "The card is not exist...."
        End If
        If s = "84" Then
            reason = "the data is error...."
        End If
        If s = "85" Then
            reason = "Reader received unknown command...."
        End If
        If s = "87" Then
            reason = "error...."
        End If
        If s = "89" Then
            reason = "The parameter of the command or the Format of the command Erro..."
        End If
        If s = "8A" Then
            reason = "Some Erro appear in the card InitVal process..."
        End If
        If s = "8B" Then
            reason = "Get The Wrong Snr during anticollison loop...."
        End If
        If s = "8C" Then
            reason = "The authentication failure...."
        End If
        If s = "8F" Then
            reason = "Reader received unknown command...."
        End If
        If s = "90" Then
            reason = "The Card do not support this command...."
        End If
        If s = "91" Then
            reason = "The Foarmat Of  The Command Erro...."
        End If
        If s = "92" Then
            reason = "Do not support Option mode...."
        End If
        If s = "93" Then
            reason = "The Block Do Not Exist...."
        End If
        If s = "94" Then
            reason = "The Object have been locked...."
        End If
        If s = "95" Then
            reason = "The lock Operation Do Not Success...."
        End If
        If s = "96" Then
            reason = "The Operation Do Not Success...."
        End If

        falsereason = reason
    End Function

    Public Shared Function StrToHex(ByVal Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1)
            If sVal.Length < 2 Then
                sHex = sHex & "0" & sVal
            Else
                sHex = sHex & sVal
            End If
        End While
        Return sHex

    End Function

    Public Shared Function HexToStr(ByVal Data As String) As String
        Dim com As String = ""
        For x = 0 To Data.Length - 1 Step 2
            com &= ChrW(CInt("&H" & Data.Substring(x, 2)))
        Next
        Return com
    End Function


    Public Shared Function SeparateWord(ByVal text As String) As String
        Dim hexs As String = Nothing
        Dim HexNumber As String = Nothing

        For i As Integer = 1 To text.Length * 2
            hexs = Mid(text, i, 2)
            HexNumber = HexNumber & " " & hexs
            i = i + 1
        Next

        Return HexNumber
    End Function

End Class
