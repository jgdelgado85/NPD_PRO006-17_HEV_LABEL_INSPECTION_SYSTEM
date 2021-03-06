﻿Imports System
Imports System.Net  'For FTP
Imports System.IO   'For File IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.NI4882
Imports CoreScanner
Imports System.Xml
Imports Cognex.InSight.Controls.Display.CvsInSightDisplay
Imports System.Net.Sockets
Imports System.Threading
Imports EasyModbus



Public Class MainForm
    Public GPIB_Device As NationalInstruments.NI4882.Device
    Public WithEvents cCoreScanner As CCoreScanner
    ' Public BarcodeScanner_Device2 As _ICoreScannerEvents

    Dim PrinterSelected As Boolean = False
    Dim DBfilepath As String = ""
    Dim PRNstring As String = ""
    Dim PRNfolder As String = ""
    Dim LogFolder As String = ""
    Dim ZEBRA_FUSE_IPaddress As String = ""
    Dim ZEBRA_BOX_IPaddress As String = ""

    Dim GPIB_Board_ID = ""
    Dim GPIB_Primary_Address = ""
    Dim GPIB_Secondary_Address = ""
    Dim GPIB_Read_Direction As String = "STATUS"
    Dim GPIB_TEGAM_READ As String = ""


    Public strdata As New System.Text.StringBuilder(255)
    Dim INIpath As String
    Dim LogSetup As Boolean = False
    Dim LogDateAndTime As String
    Dim gpibWAIT As Integer
    Dim ccorescannerWAIT As Integer
    Dim BCScannerDirection As String = "NONE"


    Const LED_GREEN_ON As String = "43"   ' Green  LED On                            
    Const LED_RED_ON As String = "47"  ' Red  LED On                              
    Const LED_GREEN_OFF As String = "42"  ' Green  LED Off                            
    Const LED_RED_OFF As String = "48"   ' Red  LED Off
    Const SCANNER_BEEP As String = "1"   ' Red  LED Off

    Dim Full_Stop As String = ""
    Dim TelnetClient As New TcpClient
    Dim modbusTCP1 As New EasyModbus.ModbusClient


    Private oTCPStream1 As Net.Sockets.NetworkStream
    Private oTCP1 As New Net.Sockets.TcpClient()
    Private oTCPStream2 As Net.Sockets.NetworkStream
    Private oTCP2 As New Net.Sockets.TcpClient()
    Private oTCPStream3 As Net.Sockets.NetworkStream
    Private oTCP3 As New Net.Sockets.TcpClient()
    Private bytWriting As [Byte]()
    Private bytReading As Byte()

    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal IpApplication As String, ByVal Ipkeyname As String, ByVal IpString As String, ByVal IpFileName As String) As Integer

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal IpApplicationName As String, ByVal IpKeyName As String, ByVal IpDefault As String, ByVal IPReturnedString As System.Text.StringBuilder, ByVal nsize As Integer, ByVal IpFileName As String) As Integer

    Private Sub WriteINIFile(INIsection As String, INIkey As String, INIvalue As String, INIpath As String)
        WritePrivateProfileString(INIsection, INIkey, INIvalue, INIpath)
    End Sub

    Private Function readIniFile(INIsection As String, INIkey As String, INIpath As String) As String
        GetPrivateProfileString(INIsection, INIkey, "", strdata, 100, INIpath)
        readIniFile = strdata.ToString
    End Function


    Sub GPIB_Open(Optional boardID As Integer = 0, Optional primaryAddress As Integer = 1, Optional secondaryAddress As Integer = 0)
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            GPIB_Device = New Device(boardID, primaryAddress, secondaryAddress)
            '#If NETFX2_0 Then
            '            'For .NET Framework 2.0, use SynchronizeCallbacks to specify that the object 
            '            'marshals callbacks across threads appropriately.
            '            GPIB_Device.SynchronizeCallbacks = True
            '#Else
            '            'For .NET Framework 1.1, set SynchronizingObject to the Windows Form to specify 
            '            'that the object marshals callbacks across threads appropriately.
            '            GPIB_Device.SynchronizingObject = Me
            '#End If
            '            SetupControlState(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
    Sub GPIB_Close()
        Try
            GPIB_Device.Dispose()
            'SetupControlState(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub GPIB_Write(stringToWrite As String)
        'stringToWrite = "*IDN?\n"
        Try
            GPIB_Device.BeginWrite(stringToWrite + vbLf, New AsyncCallback(AddressOf OnWriteComplete), Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OnWriteComplete(ByVal result As IAsyncResult)
        Dim elementsTransferred As String
        Dim lastIOStatus As String
        Try
            GPIB_Device.EndWrite(result)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        elementsTransferred = GPIB_Device.LastCount.ToString()
        lastIOStatus = GPIB_Device.LastStatus.ToString()
    End Sub 'OnWriteComplete
    Sub GPIB_Read()
        Try
            GPIB_Device.BeginRead(New AsyncCallback(AddressOf OnReadComplete), Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub 'readButton_Click
    Private Sub OnReadComplete(ByVal result As IAsyncResult)
        Dim elementsTransferred As String
        Dim lastIOStatus As String
        Dim stringReadTextBox As String = ""
        Try
            stringReadTextBox = InsertCommonEscapeSequences(GPIB_Device.EndReadString(result))
            stringReadTextBox = stringReadTextBox.Replace("\r\n", "")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        elementsTransferred = GPIB_Device.LastCount.ToString()
        lastIOStatus = GPIB_Device.LastStatus.ToString()
        Select Case GPIB_Read_Direction
            Case "STATUS"
                txtbReadGPIB.Text = stringReadTextBox '+ vbCrLf + txtbReadGPIB.Text
            Case "RESISTANCE_MEASUREMENT"
                GPIB_TEGAM_READ = stringReadTextBox '+ vbCrLf + txtbReadGPIB.Text
            Case Else
                txtbReadGPIB.Text = stringReadTextBox '+ vbCrLf + txtbReadGPIB.Text
        End Select

    End Sub 'OnReadComplete

    Private Function ReplaceCommonEscapeSequences(ByVal s As String) As String
        Return s.Replace("\n", ControlChars.Lf).Replace("\r", ControlChars.Cr)
    End Function 'ReplaceCommonEscapeSequences
    Private Function InsertCommonEscapeSequences(ByVal s As String) As String
        Return s.Replace(ControlChars.Lf, "\n").Replace(ControlChars.Cr, "\r")
    End Function 'InsertCommonEscapeSequences
    Sub GPIB_Terminate()
        Try
            GPIB_Device.AbortAsynchronousIO()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub 'terminateButton_Click
    Private Function FTP_Upload(ftpUserName As String, ftpPassWD As String, ftpFileToUpload As String, ftpFileSavedAs As String) As Boolean
        Try
            Dim wrUpload As FtpWebRequest = DirectCast(WebRequest.Create(ftpFileSavedAs), FtpWebRequest)         'Create Request To Upload File'
            wrUpload.Credentials = New NetworkCredential(ftpUserName, ftpPassWD)                                 'Specify Username & Password'
            wrUpload.Method = WebRequestMethods.Ftp.UploadFile                                                  'Start Upload Process'
            Dim btfile() As Byte = File.ReadAllBytes(ftpFileToUpload)                                           'Locate File And Store It In Byte Array'
            Dim strFile As Stream = wrUpload.GetRequestStream()                                                 'Get File'
            strFile.Write(btfile, 0, btfile.Length)                                                             'Upload Each Byte'
            strFile.Close()                                                                                     'Close'
            strFile.Dispose()                                                                                  'Free Memory'
            FTP_Upload = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            FTP_Upload = False
        End Try
    End Function



    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs)
        GPIB_Close()
    End Sub


    Private Sub btnREAD_Click(sender As Object, e As EventArgs)
        GPIB_Read()
    End Sub



    Private Sub btnRS232Test_Click(sender As Object, e As EventArgs) Handles btnRS232Write.Click
        OpenCom()
        SerialPort1.Write("Hello")
        CloseCom()
    End Sub

    Private Sub OpenCom()
        Dim ComErr As Boolean = False
        Dim UserCom As Integer = 1
        Try
            With SerialPort1
                .BaudRate = 57600
                .PortName = "COM" & UserCom
                .Parity = IO.Ports.Parity.None
                .Encoding = System.Text.Encoding.Default
                .ReceivedBytesThreshold = 1
                .Open()
            End With
        Catch ex As Exception
            ComErr = True
        End Try
    End Sub

    'Close comport
    Private Sub CloseCom()
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
        End If
    End Sub

    'When data is received on comport, this event is fired
    Private Sub ComPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim Inbuffer As String = ""
        If e.EventType = 1 Then
            Inbuffer = Inbuffer & SerialPort1.ReadExisting
        End If
        btnRS232Write.Text = Inbuffer
    End Sub

    Private Sub btnTRIGGER_Click(sender As Object, e As EventArgs)
        GPIB_Device.Trigger()
    End Sub



    Private Sub btnSendBarcodeOpcode_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScannerOpenDevice(deviceID As Integer)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        Dim numberOfScanners As Short
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 6000
        Dim inXML As String
        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>3</arg-int></cmdArgs></inArgs>"
        cCoreScanner = New CCoreScanner
        cCoreScanner.Open(0, scannerTypes, numberOfScannerTypes, status)
        cCoreScanner.GetScanners(numberOfScanners, connectedScannerIDList, outXML, status)
    End Sub

    Private Sub ScannerCloseDevice(deviceID As Integer)
        Dim status As Integer
        cCoreScanner.Close(0, status) 'Reserved argument set to 0
    End Sub
    Private Sub ScannerOpCodesSend(deviceID As Integer, actionCode As String)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        'Dim numberOfScanners As Short
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 6000
        Dim inXML As String
        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>" & actionCode & "</arg-int></cmdArgs></inArgs>"
        cCoreScanner.ExecCommand(opcode, inXML, outXML, status)
    End Sub

    Private Sub ScannerSubscribeEvent(deviceID As Integer)
        Dim scannerTypes(1) As Short
        scannerTypes(0) = 1
        Dim numberOfScannerTypes As Short = 1
        Dim status As Integer
        Dim connectedScannerIDList(255) As Integer
        Dim outXML As String = ""
        Dim opcode As Integer = 1001
        Dim inXML As String

        inXML = "<inArgs><scannerID>" & deviceID & "</scannerID><cmdArgs><arg-int>1</arg-int><arg-int>1</arg-int></cmdArgs></inArgs>"
        cCoreScanner.ExecCommand(opcode, inXML, outXML, status)
    End Sub
    Private Sub cCoreScanner_BarcodeEvent(eventType As Short, ByRef pscanData As String) Handles cCoreScanner.BarcodeEvent
        Dim Barcode As String
        Dim deviceID As String
        Dim ScannerID As Integer
        Dim RawData As String
        Dim RawDataStart As Integer
        Dim RawDataEnd As Integer
        Dim CharIndex As Integer
        Dim FormedString As String = ""
        Dim I As Integer
        Dim CurrentChar As String

        Barcode = pscanData
        deviceID = pscanData

        '*******************************************************************************Decode Device ID
        RawDataStart = InStr(deviceID, "<scannerID>")
        deviceID = deviceID.Remove(0, RawDataStart + 10)
        RawDataEnd = InStr(deviceID, "</scannerID>")
        deviceID = deviceID.Remove(RawDataEnd - 1, deviceID.Length - RawDataEnd)
        ScannerID = Convert.ToInt32(deviceID)
        '*******************************************************************************Decode Raw Data
        RawDataStart = InStr(Barcode, "<rawdata>")
        Barcode = Barcode.Remove(0, RawDataStart + 8)
        RawDataEnd = InStr(Barcode, "</rawdata>")
        RawData = Barcode.Remove(RawDataEnd - 1, Barcode.Length - RawDataEnd)

        RawData = RawData.Replace("0x", "")
        RawData = RawData.Replace(" ", "")
        CharIndex = RawData.Length - 2
        For I = 8 To CharIndex Step 2
            CurrentChar = RawData.Substring(I, 2)
            FormedString = FormedString + Convert.ToChar((Convert.ToInt32(CurrentChar, 16)))
        Next
        If ScannerID = 1 Then
            'MessageBox.Show(deviceID)
            Select Case BCScannerDirection
                Case "SHOP_PACK"
                    Me.Invoke(New MethodInvoker(Sub() txtbSHOP_PACK.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case "PART_NUMBER"
                    Me.Invoke(New MethodInvoker(Sub() txtbPART_NUMBER.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case "OPERATOR1"
                    Me.Invoke(New MethodInvoker(Sub() txtbOPERATOR1.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case "OPERATOR2"
                    Me.Invoke(New MethodInvoker(Sub() txtbOPERATOR2.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case "OPERATOR3"
                    Me.Invoke(New MethodInvoker(Sub() txtbOPERATOR3.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case "OPERATOR4"
                    Me.Invoke(New MethodInvoker(Sub() txtbOPERATOR4.Text = FormedString))
                    BCScannerDirection = "NONE"
                Case Else
                    BCScannerDirection = "NONE"
            End Select

        ElseIf ScannerID = 2 Then
            Me.Invoke(New MethodInvoker(Sub() txtbBCDevice_ReadST3A.Text = FormedString))
        End If
    End Sub


    Private Sub btnCloseBarcodeDevice_Click(sender As Object, e As EventArgs) Handles btnCloseBarcodeDeviceST1A.Click
        ScannerCloseDevice(1)
    End Sub

    Private Sub btnFTPupload_Click(sender As Object, e As EventArgs) Handles btnFTPUpJobST1B.Click      'Upload the Station 1B .job File as Current_ST1B.job
        Dim UploadStatus As Boolean
        UploadStatus = FTP_Upload("admin", "", txtbFTPUpJobST1B.Text, "ftp://" & txtbADDRESSCvsInSightDisplay1.Text & "/Current_ST1.job")
        If UploadStatus = True Then
            btnFTPUpJobST1B.BackColor = Color.LightGreen
        Else
            btnFTPUpJobST1B.BackColor = Color.Red
        End If

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '********************************************************************************************************Input data from localStartConfig.ini
        gpibWAIT = Convert.ToInt16(readIniFile("CONSTANTS", "gpibWAIT", "C:\HEV_INSPECTION_files\localStartConfig.ini"))
        ccorescannerWAIT = Convert.ToInt16(readIniFile("CONSTANTS", "ccorescannerWAIT", "C:\HEV_INSPECTION_files\localStartConfig.ini"))

        DBfilepath = readIniFile("FILEPATHS", "DBfilepath", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        txtbDBfilepath.Text = DBfilepath
        PRNfolder = readIniFile("FILEPATHS", "PRNfolder", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        txtbPRNfolder.Text = PRNfolder
        LogFolder = readIniFile("FILEPATHS", "LogFolder", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        txtbLOGfolder.Text = LogFolder
        ZEBRA_FUSE_IPaddress = readIniFile("ZEBRA_IP", "txtbZEBRA_FUSE_IPaddress", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        ZEBRA_BOX_IPaddress = readIniFile("ZEBRA_IP", "txtbZEBRA_BOX_IPaddress", "C:\HEV_INSPECTION_files\localStartConfig.ini")

        '********************************************************************************************************Calculate DATECODE
        txtbDATECODE.Text = "L" + DateAndTime.Now.Year.ToString.Last + MonthLetter() + DayDigits() + "F"

        GPIB_Board_ID = readIniFile("GPIB_ADDRESS", "Board_ID", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        GPIB_Primary_Address = readIniFile("GPIB_ADDRESS", "Primary_Address", "C:\HEV_INSPECTION_files\localStartConfig.ini")
        GPIB_Secondary_Address = readIniFile("GPIB_ADDRESS", "Secondary_Address", "C:\HEV_INSPECTION_files\localStartConfig.ini")

        '********************************************************************************************************Start Sequence


        LOAD_INI()
    End Sub
    Private Function MonthLetter() As String
        Select Case Date.Now.Month
            Case 1
                MonthLetter = "A"
            Case 2
                MonthLetter = "B"
            Case 3
                MonthLetter = "C"
            Case 4
                MonthLetter = "D"
            Case 5
                MonthLetter = "E"
            Case 6
                MonthLetter = "F"
            Case 7
                MonthLetter = "G"
            Case 8
                MonthLetter = "H"
            Case 9
                MonthLetter = "I"
            Case 10
                MonthLetter = "J"
            Case 11
                MonthLetter = "K"
            Case 12
                MonthLetter = "L"
            Case Else
                MonthLetter = "Error"
        End Select
    End Function
    Private Function DayDigits() As String
        Select Case DateAndTime.Now.Day
            Case 1 To 9
                DayDigits = "0" + DateAndTime.Now.Day.ToString
            Case Else
                DayDigits = DateAndTime.Now.Day.ToString
        End Select
    End Function

    Private Sub btnCvsInSightDisplay1_Click(sender As Object, e As EventArgs) Handles btnCONNECTCvsInSightDisplay1.Click
        If Not CvsInSightDisplay1.Connected Then
            CvsInSightDisplay1.Connect(txtbADDRESSCvsInSightDisplay1.Text, txtbUSERCvsInSightDisplay1.Text, txtbPASSWORDCvsInSightDisplay1.Text, False)
            btnCONNECTCvsInSightDisplay1.BackColor = Color.LightGreen
        End If
        Refresh()
    End Sub


    Private Sub btnDISCONNECTCvsInSightDisplay1_Click(sender As Object, e As EventArgs) Handles btnDISCONNECTCvsInSightDisplay1.Click
        If CvsInSightDisplay1.Connected Then
            CvsInSightDisplay1.Disconnect()
        End If
    End Sub

    Private Sub btnOpenTelnetClientST1B_Click(sender As Object, e As EventArgs) Handles btnOpenTelnetClientST1B.Click
        Try
            oTCP1.SendTimeout = 1500
            oTCP1.Connect(txtbADDRESSCvsInSightDisplay1.Text, 23) 'Fixed Port 23
            oTCPStream1 = oTCP1.GetStream
            WriteDataoTPC1(txtbUSERCvsInSightDisplay1.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            WriteDataoTPC1(txtbPASSWORDCvsInSightDisplay1.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            'MsgBox("Telnet Connection Succesfull")
            btnOpenTelnetClientST1B.BackColor = Color.LightGreen
        Catch Err As Exception
            MsgBox(Err.ToString)
            btnOpenTelnetClientST1B.BackColor = Color.Red
        End Try
    End Sub

    Private Sub btnCloseTelnetClient_Click(sender As Object, e As EventArgs) Handles btnCloseTelnetClientST1B.Click
        oTCPStream1.Close() 'Closed the NetworkStream
        oTCP1.Close() 'Closed the TcpClient/Socket
        btnOpenTelnetClientST1B.BackColor = DefaultBackColor
        Refresh()
    End Sub


    Private Sub btnTRIGGERCvsInSightDisplay1_Click(sender As Object, e As EventArgs) Handles btnTRIGGERCvsInSightDisplay1.Click
        WriteDataoTPC1("SE8" & vbCrLf)
    End Sub
    Private Function ReadDataoTPC1() As String
        Dim sData As String
        ReDim bytReading(oTCP1.ReceiveBufferSize)
        oTCPStream1.Read(bytReading, 0, oTCP1.ReceiveBufferSize)
        sData = Trim(System.Text.Encoding.ASCII.GetString(bytReading))
        ReadDataoTPC1 = sData
    End Function
    Private Sub WriteDataoTPC1(ByVal sData As String)
        If oTCP1.Client.Connected = True Then
            bytWriting = System.Text.Encoding.ASCII.GetBytes(sData)
            oTCPStream1.Write(bytWriting, 0, bytWriting.Length)
        Else
            MessageBox.Show("Cant't send command. Telnet Client is closed.")
        End If
    End Sub
    Private Function ReadDataoTPC2() As String
        Dim sData As String
        ReDim bytReading(oTCP2.ReceiveBufferSize)
        oTCPStream2.Read(bytReading, 0, oTCP2.ReceiveBufferSize)
        sData = Trim(System.Text.Encoding.ASCII.GetString(bytReading))
        ReadDataoTPC2 = sData
    End Function
    Private Sub WriteDataoTPC2(ByVal sData As String)
        If oTCP2.Client.Connected = True Then
            bytWriting = System.Text.Encoding.ASCII.GetBytes(sData)
            oTCPStream2.Write(bytWriting, 0, bytWriting.Length)
        Else
            MessageBox.Show("Cant't send command. Telnet Client is closed.")
        End If
    End Sub
    Private Function ReadDataoTPC3() As String
        Dim sData As String
        ReDim bytReading(oTCP3.ReceiveBufferSize)
        oTCPStream3.Read(bytReading, 0, oTCP3.ReceiveBufferSize)
        sData = Trim(System.Text.Encoding.ASCII.GetString(bytReading))
        ReadDataoTPC3 = sData
    End Function
    Private Sub WriteDataoTPC3(ByVal sData As String)
        If oTCP3.Client.Connected = True Then
            bytWriting = System.Text.Encoding.ASCII.GetBytes(sData)
            oTCPStream3.Write(bytWriting, 0, bytWriting.Length)
        Else
            MessageBox.Show("Cant't send command. Telnet Client is closed.")
        End If
    End Sub

    Private Sub btnGETPASSCvsInSightDisplay1_Click(sender As Object, e As EventArgs) Handles btnGETPASSCvsInSightDisplay1.Click
        Dim CurrentStream As String
        Dim GVdata As String
        CurrentStream = ReadDataoTPC1()
        WriteDataoTPC1("GVS001" & vbCrLf)
        System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
        GVdata = ReadDataoTPC1()
        WriteDataoTPC1(vbCrLf)

        txtbACKCvsInSightDisplay1.Text = GVdata.Substring(0, 1)
        txtbRETCvsInSightDisplay1.Text = GVdata.Substring(3, 1)
    End Sub

    Private Sub btnLOADFILECvsInSightDisplay1_Click(sender As Object, e As EventArgs) Handles btnLOADFILECvsInSightDisplay1.Click
        WriteDataoTPC1("LFCURRENT_ST1B.job" & vbCrLf)
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CvsInSightDisplay1_ResultsChanged(sender As Object, e As EventArgs) Handles CvsInSightDisplay1.ResultsChanged
        formSTATION_1A.pictboxCVS_InsightST1B.Image = CvsInSightDisplay1.GetBitmap
        'MessageBox.Show("Image Udpdated")
    End Sub

    Private Sub btnFTPUpJobST2A_Click(sender As Object, e As EventArgs) Handles btnFTPUpJobST2A.Click 'Upload the Station 2A .job File as Current_ST2A.job
        Dim UploadStatus As Boolean
        FTP_Upload("admin", "", txtbFTPUpJobST2A.Text, "ftp://" & txtbADDRESSCvsInSightDisplay2.Text & "/Current_ST2A.job")
        If UploadStatus = True Then
            btnFTPUpJobST2A.BackColor = Color.LightGreen
        Else
            btnFTPUpJobST2A.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnOpenTelnetClientST2A_Click(sender As Object, e As EventArgs) Handles btnOpenTelnetClientST2A.Click
        Try
            oTCP2.SendTimeout = 1500
            oTCP2.Connect(txtbADDRESSCvsInSightDisplay2.Text, 23) 'Fixed Port 23
            oTCPStream2 = oTCP2.GetStream
            WriteDataoTPC2(txtbUSERCvsInSightDisplay2.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            WriteDataoTPC2(txtbPASSWORDCvsInSightDisplay2.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            'MsgBox("Telnet Connection Succesfull")
            btnOpenTelnetClientST2A.BackColor = Color.LightGreen
        Catch Err As Exception
            MsgBox(Err.ToString)
            btnOpenTelnetClientST2A.BackColor = Color.Red
        End Try
    End Sub

    Private Sub btnCloseTelnetClientST2A_Click(sender As Object, e As EventArgs) Handles btnCloseTelnetClientST2A.Click
        oTCPStream2.Close() 'Closed the NetworkStream
        oTCP2.Close() 'Closed the TcpClient/Socket
        btnOpenTelnetClientST2A.BackColor = DefaultBackColor
        Refresh()
    End Sub

    Private Sub btnCONNECTCvsInSightDisplay2_Click(sender As Object, e As EventArgs) Handles btnCONNECTCvsInSightDisplay2.Click
        If Not CvsInSightDisplay2.Connected Then
            CvsInSightDisplay2.Connect(txtbADDRESSCvsInSightDisplay2.Text, txtbUSERCvsInSightDisplay2.Text, txtbPASSWORDCvsInSightDisplay2.Text, False)
            btnCONNECTCvsInSightDisplay2.BackColor = Color.LightGreen
        End If
        Refresh()
    End Sub

    Private Sub btnLOADFILECvsInSightDisplay2_Click(sender As Object, e As EventArgs) Handles btnLOADFILECvsInSightDisplay2.Click
        WriteDataoTPC2("LFCURRENT_ST2A.job" & vbCrLf)
    End Sub

    Private Sub btnTRIGGERCvsInSightDisplay2_Click(sender As Object, e As EventArgs) Handles btnTRIGGERCvsInSightDisplay2.Click
        WriteDataoTPC2("SE8" & vbCrLf)
    End Sub

    Private Sub btnGETPASSCvsInSightDisplay2_Click(sender As Object, e As EventArgs) Handles btnGETPASSCvsInSightDisplay2.Click
        Dim CurrentStream As String
        Dim GVdata As String
        CurrentStream = ReadDataoTPC2()
        WriteDataoTPC2("GVS001" & vbCrLf)
        System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
        GVdata = ReadDataoTPC2()
        WriteDataoTPC2(vbCrLf)

        txtbACKCvsInSightDisplay2.Text = GVdata.Substring(0, 1)
        txtbRETCvsInSightDisplay2.Text = GVdata.Substring(3, 1)
    End Sub

    Private Sub btnDISCONNECTCvsInSightDisplay2_Click(sender As Object, e As EventArgs) Handles btnDISCONNECTCvsInSightDisplay2.Click
        If CvsInSightDisplay2.Connected Then
            CvsInSightDisplay2.Disconnect()
        End If
    End Sub

    Private Sub btnFTPUpJobST3A_Click(sender As Object, e As EventArgs) Handles btnFTPUpJobST3A.Click 'Upload the Station 3A .job File as Current_ST3A.job
        Dim UploadStatus As Boolean
        FTP_Upload("admin", "", txtbFTPUpJobST3A.Text, "ftp://" & txtbADDRESSCvsInSightDisplay3.Text & "/Current_ST3A.job")
        If UploadStatus = True Then
            btnFTPUpJobST3A.BackColor = Color.LightGreen
        Else
            btnFTPUpJobST3A.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnOpenTelnetClientST3A_Click(sender As Object, e As EventArgs) Handles btnOpenTelnetClientST3A.Click
        Try
            oTCP3.SendTimeout = 1500
            oTCP3.Connect(txtbADDRESSCvsInSightDisplay3.Text, 23) 'Fixed Port 23
            oTCPStream3 = oTCP3.GetStream
            WriteDataoTPC3(txtbUSERCvsInSightDisplay3.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            WriteDataoTPC3(txtbPASSWORDCvsInSightDisplay3.Text & vbCrLf) 'This line can repeated as many times as you like. You just need to adjust the time the application waits before starting the next line of code.
            System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
            'MsgBox("Telnet Connection Succesfull")
            btnOpenTelnetClientST3A.BackColor = Color.LightGreen
        Catch Err As Exception
            MsgBox(Err.ToString)
            btnOpenTelnetClientST3A.BackColor = Color.Red
        End Try
    End Sub

    Private Sub btnCloseTelnetClientST3A_Click(sender As Object, e As EventArgs) Handles btnCloseTelnetClientST3A.Click
        oTCPStream3.Close() 'Closed the NetworkStream
        oTCP3.Close() 'Closed the TcpClient/Socket
        btnOpenTelnetClientST3A.BackColor = DefaultBackColor
        Refresh()
    End Sub

    Private Sub btnCONNECTCvsInSightDisplay3_Click(sender As Object, e As EventArgs) Handles btnCONNECTCvsInSightDisplay3.Click
        If Not CvsInSightDisplay3.Connected Then
            CvsInSightDisplay3.Connect(txtbADDRESSCvsInSightDisplay3.Text, txtbUSERCvsInSightDisplay3.Text, txtbPASSWORDCvsInSightDisplay3.Text, False)
            btnCONNECTCvsInSightDisplay3.BackColor = Color.LightGreen
        End If
        Refresh()

    End Sub

    Private Sub btnLOADFILECvsInSightDisplay3_Click(sender As Object, e As EventArgs) Handles btnLOADFILECvsInSightDisplay3.Click
        WriteDataoTPC2("LFCURRENT_ST3A.job" & vbCrLf)
    End Sub

    Private Sub btnTRIGGERCvsInSightDisplay3_Click(sender As Object, e As EventArgs) Handles btnTRIGGERCvsInSightDisplay3.Click
        WriteDataoTPC3("SE8" & vbCrLf)
    End Sub

    Private Sub btnGETPASSCvsInSightDisplay3_Click(sender As Object, e As EventArgs) Handles btnGETPASSCvsInSightDisplay3.Click
        Dim CurrentStream As String
        Dim GVdata As String
        CurrentStream = ReadDataoTPC3()
        WriteDataoTPC3("GVS001" & vbCrLf)
        System.Threading.Thread.Sleep(500) 'Pauses the application before starting the next line of code.
        GVdata = ReadDataoTPC3()
        WriteDataoTPC3(vbCrLf)

        txtbACKCvsInSightDisplay3.Text = GVdata.Substring(0, 1)
        txtbRETCvsInSightDisplay3.Text = GVdata.Substring(3, 1)
    End Sub

    Private Sub btnDISCONNECTCvsInSightDisplay3_Click(sender As Object, e As EventArgs) Handles btnDISCONNECTCvsInSightDisplay3.Click
        If CvsInSightDisplay3.Connected Then
            CvsInSightDisplay3.Disconnect()
        End If
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub

    Private Sub cCoreScanner_ScannerNotificationEvent(notificationType As Short, ByRef pScannerData As String) Handles cCoreScanner.ScannerNotificationEvent
        MessageBox.Show("Sanner Notification")
    End Sub
    Private Sub LOAD_INI()
        Dim strdata As New System.Text.StringBuilder(255)
        Try
            GetPrivateProfileString("PeripheralsEnable", "chkbSymbolBarcodeST1A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbSymbolBarcodeST1A.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbTEGAMGPIBInterface", "", strdata, 100, txtbINI_FilePath.Text)
            chkbTEGAMGPIBInterface.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbZebra110Xi4_ST1A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbZebra110Xi4_ST1A.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbCOGNEXInSightST1B", "", strdata, 100, txtbINI_FilePath.Text)
            chkbCOGNEXInSightST1B.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbP2000", "", strdata, 100, txtbINI_FilePath.Text)
            chkbP2000.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbCOGNEXInSightST2A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbCOGNEXInSightST2A.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbCOGNEXInSightST3A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbCOGNEXInSightST3A.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbScaleRS232", "", strdata, 100, txtbINI_FilePath.Text)
            chkbScaleRS232.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbSymbolBarcodeST3A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbSymbolBarcodeST3A.Checked = Convert.ToBoolean(strdata.ToString)

            GetPrivateProfileString("PeripheralsEnable", "chkbZebra110Xi4_ST3A", "", strdata, 100, txtbINI_FilePath.Text)
            chkbZebra110Xi4_ST3A.Checked = Convert.ToBoolean(strdata.ToString)
            '************************************************************************************************************************CVSJobsPaths
            GetPrivateProfileString("CVSJobsPaths", "txtbFTPUpJobST1B", "", strdata, 100, txtbINI_FilePath.Text)
            txtbFTPUpJobST1B.Text = strdata.ToString

            GetPrivateProfileString("CVSJobsPaths", "txtbFTPUpJobST2A", "", strdata, 100, txtbINI_FilePath.Text)
            txtbFTPUpJobST2A.Text = strdata.ToString

            GetPrivateProfileString("CVSJobsPaths", "txtbFTPUpJobST3A", "", strdata, 100, txtbINI_FilePath.Text)
            txtbFTPUpJobST3A.Text = strdata.ToString
            '************************************************************************************************************************CVS_IP
            GetPrivateProfileString("CVS_IP", "txtbADDRESSCvsInSightDisplay1", "", strdata, 100, txtbINI_FilePath.Text)
            txtbADDRESSCvsInSightDisplay1.Text = strdata.ToString

            GetPrivateProfileString("CVS_IP", "txtbADDRESSCvsInSightDisplay2", "", strdata, 100, txtbINI_FilePath.Text)
            txtbADDRESSCvsInSightDisplay2.Text = strdata.ToString

            GetPrivateProfileString("CVS_IP", "txtbADDRESSCvsInSightDisplay3", "", strdata, 100, txtbINI_FilePath.Text)
            txtbADDRESSCvsInSightDisplay3.Text = strdata.ToString

            '************************************************************************************************************************ZEBRA_IP
            txtbZEBRA_FUSE_IPaddress.Text = ZEBRA_FUSE_IPaddress
            'txtbPRN_File = 

            '************************************************************************************************************************CVS_USER_PASSWORD
            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbUSERCvsInSightDisplay1", "", strdata, 100, txtbINI_FilePath.Text)
            txtbUSERCvsInSightDisplay1.Text = strdata.ToString
            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbUSERCvsInSightDisplay2", "", strdata, 100, txtbINI_FilePath.Text)
            txtbUSERCvsInSightDisplay2.Text = strdata.ToString
            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbUSERCvsInSightDisplay3", "", strdata, 100, txtbINI_FilePath.Text)
            txtbUSERCvsInSightDisplay3.Text = strdata.ToString

            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbPASSWORDCvsInSightDisplay1", "", strdata, 100, txtbINI_FilePath.Text)
            txtbPASSWORDCvsInSightDisplay1.Text = strdata.ToString
            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbPASSWORDCvsInSightDisplay2", "", strdata, 100, txtbINI_FilePath.Text)
            txtbPASSWORDCvsInSightDisplay2.Text = strdata.ToString
            GetPrivateProfileString("CVS_USER_PASSWORD", "txtbPASSWORDCvsInSightDisplay3", "", strdata, 100, txtbINI_FilePath.Text)
            txtbPASSWORDCvsInSightDisplay3.Text = strdata.ToString

            ToolStripStatusLabel1.Text = "...INI File: " & txtbINI_FilePath.Text & " Loaded successfully."
        Catch
            ToolStripStatusLabel1.Text = "...INI File: " & txtbINI_FilePath.Text & " Load error."

        End Try
    End Sub
    Private Sub btnMODBUS_TCP_Connect_Click(sender As Object, e As EventArgs) Handles btnModbusTCP_Connect.Click
        Dim ComError As Integer = 0
        Try
            modbusTCP1.Connect(txtbMODBUS_TCP_IP_Address.Text, 502)
        Catch ex As Exception
            MessageBox.Show("PLC Communication Error")
        End Try
        timerModbusTCP1.Interval = 100
        timerModbusTCP1.Start()
    End Sub

    Private Sub txtbMODBUS_TCP_IP_Address_TextChanged(sender As Object, e As EventArgs) Handles txtbMODBUS_TCP_IP_Address.TextChanged

    End Sub

    Private Sub btnMODBUS_TCP_Refresh_Click(sender As Object, e As EventArgs) Handles btnModbusTCP_Refresh.Click
        Dim HRegister01 As Integer()    'Hold the HR Register
        Dim XCoils(15) As Boolean
        Dim YCoils(15) As Boolean

        If modbusTCP1.Connected = True Then

            YCoils = modbusTCP1.ReadCoils(16, 16)
            If YCoils(0) = True Then
                lblModbusTCP_Y01.BackColor = Color.Green
            Else
                lblModbusTCP_Y01.BackColor = Color.Gray
            End If
            If YCoils(1) = True Then
                lblModbusTCP_Y02.BackColor = Color.Green
            Else
                lblModbusTCP_Y02.BackColor = Color.Gray
            End If
            If YCoils(2) = True Then
                lblModbusTCP_Y03.BackColor = Color.Green
            Else
                lblModbusTCP_Y03.BackColor = Color.Gray
            End If
            If YCoils(3) = True Then
                lblModbusTCP_Y04.BackColor = Color.Green
            Else
                lblModbusTCP_Y04.BackColor = Color.Gray
            End If
            If YCoils(4) = True Then
                lblModbusTCP_Y05.BackColor = Color.Green
            Else
                lblModbusTCP_Y05.BackColor = Color.Gray
            End If
            If YCoils(5) = True Then
                lblModbusTCP_Y06.BackColor = Color.Green
            Else
                lblModbusTCP_Y06.BackColor = Color.Gray
            End If
            If YCoils(6) = True Then
                lblModbusTCP_Y07.BackColor = Color.Green
            Else
                lblModbusTCP_Y07.BackColor = Color.Gray
            End If
            If YCoils(7) = True Then
                lblModbusTCP_Y08.BackColor = Color.Green
            Else
                lblModbusTCP_Y08.BackColor = Color.Gray
            End If
            If YCoils(8) = True Then
                lblModbusTCP_Y09.BackColor = Color.Green
            Else
                lblModbusTCP_Y09.BackColor = Color.Gray
            End If
            If YCoils(9) = True Then
                lblModbusTCP_Y10.BackColor = Color.Green
            Else
                lblModbusTCP_Y10.BackColor = Color.Gray
            End If
            If YCoils(10) = True Then
                lblModbusTCP_Y11.BackColor = Color.Green
            Else
                lblModbusTCP_Y11.BackColor = Color.Gray
            End If
            If YCoils(11) = True Then
                lblModbusTCP_Y12.BackColor = Color.Green
            Else
                lblModbusTCP_Y12.BackColor = Color.Gray
            End If
            If YCoils(12) = True Then
                lblModbusTCP_Y13.BackColor = Color.Green
            Else
                lblModbusTCP_Y13.BackColor = Color.Gray
            End If
            If YCoils(13) = True Then
                lblModbusTCP_Y14.BackColor = Color.Green
            Else
                lblModbusTCP_Y14.BackColor = Color.Gray
            End If
            If YCoils(14) = True Then
                lblModbusTCP_Y15.BackColor = Color.Green
            Else
                lblModbusTCP_Y15.BackColor = Color.Gray
            End If
            If YCoils(15) = True Then
                lblModbusTCP_Y16.BackColor = Color.Green
            Else
                lblModbusTCP_Y16.BackColor = Color.Gray
            End If

            XCoils(0) = chkbModbusTCP_X01.Checked
            XCoils(1) = chkbModbusTCP_X02.Checked
            XCoils(2) = chkbModbusTCP_X03.Checked
            XCoils(3) = chkbModbusTCP_X04.Checked
            XCoils(4) = chkbModbusTCP_X05.Checked
            XCoils(5) = chkbModbusTCP_X06.Checked
            XCoils(6) = chkbModbusTCP_X07.Checked
            XCoils(7) = chkbModbusTCP_X08.Checked
            XCoils(8) = chkbModbusTCP_X09.Checked
            XCoils(9) = chkbModbusTCP_X10.Checked
            XCoils(10) = chkbModbusTCP_X11.Checked
            XCoils(11) = chkbModbusTCP_X12.Checked
            XCoils(12) = chkbModbusTCP_X13.Checked
            XCoils(13) = chkbModbusTCP_X14.Checked
            XCoils(14) = chkbModbusTCP_X15.Checked
            XCoils(15) = chkbModbusTCP_X16.Checked
            modbusTCP1.WriteMultipleCoils(0, XCoils)

            HRegister01 = modbusTCP1.ReadHoldingRegisters(0, 1)
            ToolStripStatusLabel1.Text = "Modbus TCP Refresh:" & HRegister01(0).ToString        'Read MHR1
        Else
            ToolStripStatusLabel1.Text = "Modbus TCP Not Connected!"
        End If

    End Sub

    Private Sub grpbxMODBUS_TCP_Enter(sender As Object, e As EventArgs) Handles grpbxMODBUS_TCP.Enter

    End Sub

    Private Sub btnModbusTCP_X00_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnModbusTCP_Disconnect_Click(sender As Object, e As EventArgs) Handles btnModbusTCP_Disconnect.Click
        modbusTCP1.Disconnect()
        timerModbusTCP1.Stop()
    End Sub

    Private Sub chkbModbusTCP_X01_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X01.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X02_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X02.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X03_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X03.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X04_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X04.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X05_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X05.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X06_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X06.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X07_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X07.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X08_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X08.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X09_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X09.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X10_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X10.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X11_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X11.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X12_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X12.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X13_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X13.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X14_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X14.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X15_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X15.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub chkbModbusTCP_X16_CheckedChanged(sender As Object, e As EventArgs) Handles chkbModbusTCP_X16.CheckedChanged
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timerModbusTCP1.Tick
        btnModbusTCP_Refresh.PerformClick()
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub Label37_Click(sender As Object, e As EventArgs) Handles Label37.Click

    End Sub

    Private Sub chkbSymbolBarcodeST3A_CheckedChanged(sender As Object, e As EventArgs) Handles chkbSymbolBarcodeST3A.CheckedChanged

    End Sub

    Private Sub chkbCOGNEXInSightST3A_CheckedChanged(sender As Object, e As EventArgs) Handles chkbCOGNEXInSightST3A.CheckedChanged

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub chkbScaleRS232_CheckedChanged(sender As Object, e As EventArgs) Handles chkbScaleRS232.CheckedChanged

    End Sub

    Private Sub chkbCOGNEXInSightST2A_CheckedChanged(sender As Object, e As EventArgs) Handles chkbCOGNEXInSightST2A.CheckedChanged

    End Sub

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click

    End Sub

    Private Sub chkbZebra110Xi4_ST3A_CheckedChanged(sender As Object, e As EventArgs) Handles chkbZebra110Xi4_ST3A.CheckedChanged

    End Sub


    Private Sub lblModbusTCP_Y01_BackColorChanged(sender As Object, e As EventArgs) Handles lblModbusTCP_Y01.BackColorChanged
        'If lblModbusTCP_Y01.BackColor = Color.Green Then
        '    MessageBox.Show("color changed!")
        'End If
        btnGPIB_MEASURE.PerformClick()

    End Sub

    Private Sub CvsInSightDisplay1_Load(sender As Object, e As EventArgs) Handles CvsInSightDisplay1.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.formSTATION_1A.Show()
        My.Forms.formSTATION_1A.Text = "Holi"
        My.Forms.formSTATION_1A.pictboxCVS_InsightST1B.Image = CvsInSightDisplay1.GetBitmap
        'With My.Forms.formSTATION_1A
        '    Show()
        '    Text = "Holi"
        'End With
    End Sub

    Private Sub tabpgCOGNEX_Insight_Click(sender As Object, e As EventArgs) Handles tabpgCOGNEX_Insight.Click

    End Sub

    Private Sub txtbFTPUpJobST2A_TextChanged(sender As Object, e As EventArgs) Handles txtbFTPUpJobST2A.TextChanged

    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub grpbxGPIB_TEGAM_Enter(sender As Object, e As EventArgs) Handles grpbxGPIB_TEGAM.Enter

    End Sub

    Private Sub Label50_Click(sender As Object, e As EventArgs) Handles Label50.Click

    End Sub

    Private Sub btnStartSelectedPeripherals_Click(sender As Object, e As EventArgs) Handles btnStartSelectedPeripherals.Click
        '*******************************************************************************Startup Barcode Scanner on ST1A
        grpbxBarcodeScannerST1A.Enabled = chkbSymbolBarcodeST1A.Checked
        btnINITbarcodeST1A.PerformClick()
        ScannerOpCodesSend(1, LED_GREEN_OFF)
        ScannerOpCodesSend(1, SCANNER_BEEP)

        grpbxGPIB_TEGAM.Enabled = chkbTEGAMGPIBInterface.Checked

        '*******************************************************************************Select SHOP PACK
        'BCScannerDirection = "SHOP_PACK"
        'Do While BCScannerDirection = "SHOP_PACK"       'Wait for the Background Worker to finish
        '    Application.DoEvents()              'But keep all of the functions working
        'Loop
        'txtbSHOP_PACK.BackColor = DefaultBackColor

        BCScannerDirection = "PART_NUMBER"
        Do While BCScannerDirection = "PART_NUMBER"       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop

        txtbPART_NUMBER.BackColor = DefaultBackColor

        'BCScannerDirection = "OPERATOR1"
        'Do While BCScannerDirection = "OPERATOR1"       'Wait for the Background Worker to finish
        '    Application.DoEvents()              'But keep all of the functions working
        'Loop

        'txtbOPERATOR1.BackColor = DefaultBackColor

        'BCScannerDirection = "OPERATOR2"
        'Do While BCScannerDirection = "OPERATOR2"       'Wait for the Background Worker to finish
        '    Application.DoEvents()              'But keep all of the functions working
        'Loop

        'txtbOPERATOR2.BackColor = DefaultBackColor

        'BCScannerDirection = "OPERATOR3"
        'Do While BCScannerDirection = "OPERATOR3"       'Wait for the Background Worker to finish
        '    Application.DoEvents()              'But keep all of the functions working
        'Loop

        'txtbOPERATOR3.BackColor = DefaultBackColor

        'BCScannerDirection = "OPERATOR4"
        'Do While BCScannerDirection = "OPERATOR4"       'Wait for the Background Worker to finish
        '    Application.DoEvents()              'But keep all of the functions working
        'Loop

        'txtbOPERATOR4.BackColor = DefaultBackColor

        '****************************************************************************************************************Select PRN Template
        Dim myStream As Stream = Nothing
        Dim PRNfilePath As String = ""

        txtbPRN_TEMPLATE.Text = readIniFile(txtbPART_NUMBER.Text, "LABEL_STYLE", DBfilepath)

        If txtbPRN_TEMPLATE.Text IsNot "" Then
            PRNfilePath = PRNfolder + txtbPRN_TEMPLATE.Text + ".prn"
            ToolStripStatusLabel1.Text = PRNfilePath
            'Convert the PRN file into a local string variable called PRNstring
            Using sr As StreamReader = File.OpenText(PRNfilePath)
                Do Until sr.EndOfStream
                    PRNstring = PRNstring + sr.ReadLine
                Loop
            End Using
        End If
        '**********************************************************************************************************************Initialize Resistance Limits
        txtbUPPERresistanceLIMIT.Text = readIniFile(txtbPART_NUMBER.Text, "RESISTANCE_MAX", DBfilepath)
        txtbLOWERresistanceLIMIT.Text = readIniFile(txtbPART_NUMBER.Text, "RESISTANCE_MIN", DBfilepath)

        '**********************************************************************************************************************Initialize TEGAM
        Dim gpibCommand As String = ""
        'Open GPIB connection
        GPIB_Open(Convert.ToInt32(GPIB_Board_ID), Convert.ToInt32(GPIB_Primary_Address), Convert.ToInt32(GPIB_Secondary_Address))
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END
        GPIB_Write("Q1X")
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END
        'btnGPIB_READ.PerformClick()
        ' GPIB_Device.Clear()
        GPIB_Read()
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END

        If txtbReadGPIB.Text IsNot "" Then
            txtbTEGAMstatus.Text = txtbReadGPIB.Text
            txtbTEGAMstatus.BackColor = Color.LightGreen
        Else
            txtbTEGAMstatus.Text = "Check Connection"
            txtbTEGAMstatus.BackColor = Color.Red
        End If

        GPIB_Write("R0X") 'Set AutoRange R0X
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END
        GPIB_Read()
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END
        GPIB_Terminate()
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        bkgworkGPIB_SLEEP.RunWorkerAsync(gpibWAIT) ' Set the Function to Run
        Do While bkgworkGPIB_SLEEP.IsBusy       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END

        btnModbusTCP_Connect.PerformClick()

        ToolStripStatusLabel1.Text = txtbReadGPIB.Text


    End Sub



    Private Sub bkgworkGPIB_SLEEP_DoWork(sender As Object, e As DoWorkEventArgs) Handles bkgworkGPIB_SLEEP.DoWork
        Dim I As Integer
        bkgworkGPIB_SLEEP.WorkerReportsProgress = True
        bkgworkGPIB_SLEEP.WorkerSupportsCancellation = True
        For I = 0 To e.Argument
            If bkgworkGPIB_SLEEP.CancellationPending = True Then            ' Has the background worker be told to stop?  
                e.Cancel = True                ' Set Cancel to True 
                Exit For
            End If
            System.Threading.Thread.Sleep(10) ' Sleep for 100 miliSecond  
            bkgworkGPIB_SLEEP.ReportProgress(I)             ' Report The progress of the Background Worker. 
        Next
    End Sub

    Private Sub bkgworkGPIB_SLEEP_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bkgworkGPIB_SLEEP.ProgressChanged
        prgsbarSleep1.Maximum = gpibWAIT
        prgsbarSleep1.Value = e.ProgressPercentage
    End Sub

    Private Sub btnGPIB_MEASURE_Click(sender As Object, e As EventArgs) Handles btnGPIB_MEASURE.Click
        Dim LOWERlimit As Single
        Dim UPPERlimit As Single
        Dim ACTUALresistance As Single
        Dim TEGAMresistValue As String


        btnGPIB_MEASURE.Enabled = False
        txtbRESISTANCE.Text = ""
        txtbRESISTANCE.BackColor = DefaultBackColor

        If txtbTEGAMstatus.BackColor = Color.Red Then
            MessageBox.Show("No GPIB connection made to TEGAM, check your connections.")
            Exit Sub
        End If

        'btnGPIB_TRIGGER.PerformClick()
        GPIB_Device.Trigger()
        GPIB_Read_Direction = "RESISTANCE_MEASUREMENT"
        GPIB_TEGAM_READ = ""
        GPIB_Read()
        '****************************************************************************************Sleep BackgroundWorker START
        '****************************************************************************************Sleep BackgroundWorker START
        Do While GPIB_TEGAM_READ = ""       'Wait for the Background Worker to finish
            Application.DoEvents()              'But keep all of the functions working
        Loop
        '****************************************************************************************Sleep BackgroundWorker END
        '****************************************************************************************Sleep BackgroundWorker END
        TEGAMresistValue = GPIB_TEGAM_READ
        TEGAMresistValue = TEGAMresistValue.Replace(" mOhm", "")
        TEGAMresistValue = TEGAMresistValue.Replace(" ", "")
        txtbRESISTANCE.Text = TEGAMresistValue


        If TEGAMresistValue = "" Then
            TEGAMresistValue = "9999.9999"
        ElseIf TEGAMresistValue = "29.999MOhm" Then
            TEGAMresistValue = "9999.9999"

        End If
        ACTUALresistance = Convert.ToSingle(TEGAMresistValue)
        LOWERlimit = Convert.ToSingle(txtbLOWERresistanceLIMIT.Text)
        UPPERlimit = Convert.ToSingle(txtbUPPERresistanceLIMIT.Text)
        If (ACTUALresistance < LOWERlimit Or ACTUALresistance > UPPERlimit) Then
            'MessageBox.Show("Resistance value out of spec.")
            txtbRESISTANCE.BackColor = Color.Red
            txtbRESISTANCEtest.Text = "FAIL"
        Else
            txtbRESISTANCE.BackColor = Color.LightGreen
            txtbRESISTANCEtest.Text = "PASS"
        End If
        btnGPIB_MEASURE.Enabled = True


    End Sub

    Private Sub btnZEBRA_FUSE_print_Click(sender As Object, e As EventArgs) Handles btnZEBRA_FUSE_print.Click
        Dim ipAddress As String
        Dim port As Integer = 9100
        Dim PRNreplacedValues As String
        If txtbRESISTANCEtest.Text = "PASS" Then
            PRNreplacedValues = PRNstring
            PRNreplacedValues = PRNreplacedValues.Replace("LXXXXF", txtbDATECODE.Text) 'Datecode
            Dim ZPLString As String = PRNreplacedValues
            ipAddress = ZEBRA_FUSE_IPaddress
            Try
                'Open Connection
                Dim client As New System.Net.Sockets.TcpClient
                client.Connect(ipAddress, port)
                'Write ZPL String to Connection
                Dim writer As New System.IO.StreamWriter(client.GetStream())
                writer.Write(ZPLString)
                writer.Flush()
                'Close Connection
                writer.Close()
                client.Close()
            Catch ex As Exception
                'Catch Exception Here
            End Try
        End If
        txtbRESISTANCEtest.Text = "NONE"
    End Sub

    Private Sub txtbLOWERresistanceLIMIT_TextChanged(sender As Object, e As EventArgs) Handles txtbLOWERresistanceLIMIT.TextChanged

    End Sub

    Private Sub txtbPART_NUMBER_SELECT_TextChanged(sender As Object, e As EventArgs) Handles txtbPART_NUMBER.TextChanged

    End Sub

    Private Sub btnINITbarcodeST1A_Click(sender As Object, e As EventArgs) Handles btnINITbarcodeST1A.Click
        ScannerOpenDevice(1)
        ScannerSubscribeEvent(1)
    End Sub

    Private Sub timerINPUT_BLINK_Tick(sender As Object, e As EventArgs) Handles timerINPUT_BLINK.Tick
        Select Case BCScannerDirection
            Case "SHOP_PACK"
                If txtbSHOP_PACK.BackColor = Color.LightGreen Then
                    txtbSHOP_PACK.BackColor = DefaultBackColor
                Else
                    txtbSHOP_PACK.BackColor = Color.LightGreen
                End If
            Case "PART_NUMBER"
                If txtbPART_NUMBER.BackColor = Color.LightGreen Then
                    txtbPART_NUMBER.BackColor = DefaultBackColor
                Else
                    txtbPART_NUMBER.BackColor = Color.LightGreen
                End If
            Case "OPERATOR1"
                If txtbOPERATOR1.BackColor = Color.LightGreen Then
                    txtbOPERATOR1.BackColor = DefaultBackColor
                Else
                    txtbOPERATOR1.BackColor = Color.LightGreen
                End If
            Case "OPERATOR2"
                If txtbOPERATOR2.BackColor = Color.LightGreen Then
                    txtbOPERATOR2.BackColor = DefaultBackColor
                Else
                    txtbOPERATOR2.BackColor = Color.LightGreen
                End If
            Case "OPERATOR3"
                If txtbOPERATOR3.BackColor = Color.LightGreen Then
                    txtbOPERATOR3.BackColor = DefaultBackColor
                Else
                    txtbOPERATOR3.BackColor = Color.LightGreen
                End If
            Case "OPERATOR4"
                If txtbOPERATOR4.BackColor = Color.LightGreen Then
                    txtbOPERATOR4.BackColor = DefaultBackColor
                Else
                    txtbOPERATOR4.BackColor = Color.LightGreen
                End If

        End Select
    End Sub



    Private Sub txtbRESISTANCEtest_TextChanged(sender As Object, e As EventArgs) Handles txtbRESISTANCEtest.TextChanged
        Select Case txtbRESISTANCEtest.Text
            Case "PASS"
                chkbModbusTCP_X01.Checked = True
                chkbModbusTCP_X02.Checked = False
                chkbModbusTCP_X03.Checked = False
            Case "FAIL"
                chkbModbusTCP_X01.Checked = False
                chkbModbusTCP_X02.Checked = True
                chkbModbusTCP_X03.Checked = False
            Case "NONE"
                chkbModbusTCP_X01.Checked = False
                chkbModbusTCP_X02.Checked = False
                chkbModbusTCP_X03.Checked = False
            Case Else
                chkbModbusTCP_X01.Checked = False
                chkbModbusTCP_X02.Checked = False
                chkbModbusTCP_X03.Checked = False
        End Select
    End Sub


    Private Sub lblModbusTCP_Y02_BackColorChanged(sender As Object, e As EventArgs) Handles lblModbusTCP_Y02.BackColorChanged
        If lblModbusTCP_Y02.BackColor = Color.Green Then
            btnGPIB_MEASURE.PerformClick()
            btnZEBRA_FUSE_print.PerformClick()

        End If
    End Sub


End Class
