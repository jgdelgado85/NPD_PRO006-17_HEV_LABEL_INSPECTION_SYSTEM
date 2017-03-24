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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnOPEN = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.cbPrimaryAddress = New System.Windows.Forms.ComboBox()
        Me.cbSecondaryAddress = New System.Windows.Forms.ComboBox()
        Me.cbBoardID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnREAD = New System.Windows.Forms.Button()
        Me.txtbReadGPIB = New System.Windows.Forms.TextBox()
        Me.txtbWriteGPIB = New System.Windows.Forms.TextBox()
        Me.btnWRITE = New System.Windows.Forms.Button()
        Me.btnTERMINATE = New System.Windows.Forms.Button()
        Me.btnRS232Test = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnTRIGGER = New System.Windows.Forms.Button()
        Me.btnOpenBarcodeDeviceST1A = New System.Windows.Forms.Button()
        Me.txtbBCDevice_ReadST1A = New System.Windows.Forms.TextBox()
        Me.btnBCDevice_LEDsOFFST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDGreenONST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDRedONST1A = New System.Windows.Forms.Button()
        Me.btnBCDevice_BeepST1A = New System.Windows.Forms.Button()
        Me.btnBCDeviceEventSubscribeST1A = New System.Windows.Forms.Button()
        Me.btnCloseBarcodeDeviceST1A = New System.Windows.Forms.Button()
        Me.btnFTPUpJobST1B = New System.Windows.Forms.Button()
        Me.txtbFTPUpJobST1B = New System.Windows.Forms.TextBox()
        Me.btnFTPdownload = New System.Windows.Forms.Button()
        Me.CvsInSightDisplay1 = New Cognex.InSight.Controls.Display.CvsInSightDisplay()
        Me.btnCONNECTCvsInSightDisplay1 = New System.Windows.Forms.Button()
        Me.txtbADDRESSCvsInSightDisplay1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbUSERCvsInSightDisplay1 = New System.Windows.Forms.TextBox()
        Me.txtbPASSWORDCvsInSightDisplay1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDISCONNECTCvsInSightDisplay1 = New System.Windows.Forms.Button()
        Me.btnTRIGGERCvsInSightDisplay1 = New System.Windows.Forms.Button()
        Me.btnLOADFILECvsInSightDisplay1 = New System.Windows.Forms.Button()
        Me.btnGETPASSCvsInSightDisplay1 = New System.Windows.Forms.Button()
        Me.btnOpenTelnetClientST1B = New System.Windows.Forms.Button()
        Me.btnCloseTelnetClientST1B = New System.Windows.Forms.Button()
        Me.txtbACKCvsInSightDisplay1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbRETCvsInSightDisplay1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STARTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpbxRS232 = New System.Windows.Forms.GroupBox()
        Me.grpbxBarcodeScannerST1A = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.grpbxGPIB_TEGAM = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.grpbxP2000 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.grpbxCVSInsight_ST1B = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpbxCVSInsight_ST2A = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnFTPUpJobST2A = New System.Windows.Forms.Button()
        Me.txtbFTPUpJobST2A = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnCONNECTCvsInSightDisplay2 = New System.Windows.Forms.Button()
        Me.txtbRETCvsInSightDisplay2 = New System.Windows.Forms.TextBox()
        Me.txtbADDRESSCvsInSightDisplay2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbACKCvsInSightDisplay2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnCloseTelnetClientST2A = New System.Windows.Forms.Button()
        Me.txtbUSERCvsInSightDisplay2 = New System.Windows.Forms.TextBox()
        Me.btnOpenTelnetClientST2A = New System.Windows.Forms.Button()
        Me.txtbPASSWORDCvsInSightDisplay2 = New System.Windows.Forms.TextBox()
        Me.btnGETPASSCvsInSightDisplay2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnLOADFILECvsInSightDisplay2 = New System.Windows.Forms.Button()
        Me.btnTRIGGERCvsInSightDisplay2 = New System.Windows.Forms.Button()
        Me.btnDISCONNECTCvsInSightDisplay2 = New System.Windows.Forms.Button()
        Me.CvsInSightDisplay2 = New Cognex.InSight.Controls.Display.CvsInSightDisplay()
        Me.grpbxCVSInsight_ST3A = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnFTPUpJobST3A = New System.Windows.Forms.Button()
        Me.txtbFTPUpJobST3A = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnCONNECTCvsInSightDisplay3 = New System.Windows.Forms.Button()
        Me.txtbRETCvsInSightDisplay3 = New System.Windows.Forms.TextBox()
        Me.txtbADDRESSCvsInSightDisplay3 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtbACKCvsInSightDisplay3 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnCloseTelnetClientST3A = New System.Windows.Forms.Button()
        Me.txtbUSERCvsInSightDisplay3 = New System.Windows.Forms.TextBox()
        Me.btnOpenTelnetClientST3A = New System.Windows.Forms.Button()
        Me.txtbPASSWORDCvsInSightDisplay3 = New System.Windows.Forms.TextBox()
        Me.btnGETPASSCvsInSightDisplay3 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btnLOADFILECvsInSightDisplay3 = New System.Windows.Forms.Button()
        Me.btnTRIGGERCvsInSightDisplay3 = New System.Windows.Forms.Button()
        Me.btnDISCONNECTCvsInSightDisplay3 = New System.Windows.Forms.Button()
        Me.CvsInSightDisplay3 = New Cognex.InSight.Controls.Display.CvsInSightDisplay()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.grpbxINITIALIZE = New System.Windows.Forms.GroupBox()
        Me.btnLoadINI = New System.Windows.Forms.Button()
        Me.btnStartSelectedPeripherals = New System.Windows.Forms.Button()
        Me.chkbSymbolBarcodeST3A = New System.Windows.Forms.CheckBox()
        Me.chkbCOGNEXInSightST3A = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.chkbScaleRS232 = New System.Windows.Forms.CheckBox()
        Me.chkbP2000 = New System.Windows.Forms.CheckBox()
        Me.chkbCOGNEXInSightST2A = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.chkbZebra110Xi4_ST3A = New System.Windows.Forms.CheckBox()
        Me.chkbCOGNEXInSightST1B = New System.Windows.Forms.CheckBox()
        Me.chkbZebra110Xi4_ST1A = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkbTEGAMGPIBInterface = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.chkbSymbolBarcodeST1A = New System.Windows.Forms.CheckBox()
        Me.btnINI_FileSelection = New System.Windows.Forms.Button()
        Me.txtbINI_FilePath = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.btnOpenBarcodeDeviceST3A = New System.Windows.Forms.Button()
        Me.txtbBCDevice_ReadST3A = New System.Windows.Forms.TextBox()
        Me.btnBCDevice_LEDGreenONST3A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDRedONST3A = New System.Windows.Forms.Button()
        Me.btnBCDevice_LEDsOFFST3A = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnBCDeviceEventSubscribeST3A = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.grpbxMODBUS_TCP = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnModbusTCP_Disconnect = New System.Windows.Forms.Button()
        Me.chkbModbusTCP_X15 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X14 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X13 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X12 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X11 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X10 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X09 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X08 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X07 = New System.Windows.Forms.CheckBox()
        Me.btnModbusTCP_Refresh = New System.Windows.Forms.Button()
        Me.chkbModbusTCP_X06 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X05 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X04 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X03 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X02 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X01 = New System.Windows.Forms.CheckBox()
        Me.chkbModbusTCP_X16 = New System.Windows.Forms.CheckBox()
        Me.lblModbusTCP_Y15 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y14 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y13 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y12 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y11 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y10 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y09 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y08 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y07 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y06 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y05 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y04 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y03 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y02 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y01 = New System.Windows.Forms.Label()
        Me.lblModbusTCP_Y16 = New System.Windows.Forms.Label()
        Me.btnModbusTCP_Connect = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtbMODBUS_TCP_IP_Address = New System.Windows.Forms.TextBox()
        Me.timerModbusTCP1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.grpbxRS232.SuspendLayout()
        Me.grpbxBarcodeScannerST1A.SuspendLayout()
        Me.grpbxGPIB_TEGAM.SuspendLayout()
        Me.grpbxP2000.SuspendLayout()
        Me.grpbxCVSInsight_ST1B.SuspendLayout()
        Me.grpbxCVSInsight_ST2A.SuspendLayout()
        Me.grpbxCVSInsight_ST3A.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpbxINITIALIZE.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxMODBUS_TCP.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOPEN
        '
        Me.btnOPEN.Location = New System.Drawing.Point(14, 118)
        Me.btnOPEN.Name = "btnOPEN"
        Me.btnOPEN.Size = New System.Drawing.Size(120, 25)
        Me.btnOPEN.TabIndex = 0
        Me.btnOPEN.Text = "Open GPIB"
        Me.btnOPEN.UseVisualStyleBackColor = True
        '
        'btnCLOSE
        '
        Me.btnCLOSE.Location = New System.Drawing.Point(14, 293)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(120, 25)
        Me.btnCLOSE.TabIndex = 1
        Me.btnCLOSE.Text = "Close GPIB"
        Me.btnCLOSE.UseVisualStyleBackColor = True
        '
        'cbPrimaryAddress
        '
        Me.cbPrimaryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrimaryAddress.FormattingEnabled = True
        Me.cbPrimaryAddress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbPrimaryAddress.Location = New System.Drawing.Point(86, 57)
        Me.cbPrimaryAddress.Name = "cbPrimaryAddress"
        Me.cbPrimaryAddress.Size = New System.Drawing.Size(42, 24)
        Me.cbPrimaryAddress.TabIndex = 2
        Me.cbPrimaryAddress.Text = "12"
        '
        'cbSecondaryAddress
        '
        Me.cbSecondaryAddress.Enabled = False
        Me.cbSecondaryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSecondaryAddress.FormattingEnabled = True
        Me.cbSecondaryAddress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbSecondaryAddress.Location = New System.Drawing.Point(85, 85)
        Me.cbSecondaryAddress.Name = "cbSecondaryAddress"
        Me.cbSecondaryAddress.Size = New System.Drawing.Size(42, 24)
        Me.cbSecondaryAddress.TabIndex = 3
        Me.cbSecondaryAddress.Text = "0"
        '
        'cbBoardID
        '
        Me.cbBoardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBoardID.FormattingEnabled = True
        Me.cbBoardID.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbBoardID.Location = New System.Drawing.Point(86, 29)
        Me.cbBoardID.Name = "cbBoardID"
        Me.cbBoardID.Size = New System.Drawing.Size(42, 24)
        Me.cbBoardID.TabIndex = 4
        Me.cbBoardID.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Board ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Prim. Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sec. Address:"
        '
        'btnREAD
        '
        Me.btnREAD.Location = New System.Drawing.Point(14, 241)
        Me.btnREAD.Name = "btnREAD"
        Me.btnREAD.Size = New System.Drawing.Size(120, 25)
        Me.btnREAD.TabIndex = 8
        Me.btnREAD.Text = "Read GPIB"
        Me.btnREAD.UseVisualStyleBackColor = True
        '
        'txtbReadGPIB
        '
        Me.txtbReadGPIB.Location = New System.Drawing.Point(14, 270)
        Me.txtbReadGPIB.Name = "txtbReadGPIB"
        Me.txtbReadGPIB.ReadOnly = True
        Me.txtbReadGPIB.Size = New System.Drawing.Size(120, 20)
        Me.txtbReadGPIB.TabIndex = 9
        '
        'txtbWriteGPIB
        '
        Me.txtbWriteGPIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbWriteGPIB.Location = New System.Drawing.Point(14, 179)
        Me.txtbWriteGPIB.Name = "txtbWriteGPIB"
        Me.txtbWriteGPIB.Size = New System.Drawing.Size(52, 22)
        Me.txtbWriteGPIB.TabIndex = 10
        Me.txtbWriteGPIB.Text = "Q1X"
        '
        'btnWRITE
        '
        Me.btnWRITE.Location = New System.Drawing.Point(72, 179)
        Me.btnWRITE.Name = "btnWRITE"
        Me.btnWRITE.Size = New System.Drawing.Size(62, 25)
        Me.btnWRITE.TabIndex = 11
        Me.btnWRITE.Text = "Write"
        Me.btnWRITE.UseVisualStyleBackColor = True
        '
        'btnTERMINATE
        '
        Me.btnTERMINATE.Location = New System.Drawing.Point(14, 148)
        Me.btnTERMINATE.Name = "btnTERMINATE"
        Me.btnTERMINATE.Size = New System.Drawing.Size(120, 25)
        Me.btnTERMINATE.TabIndex = 12
        Me.btnTERMINATE.Text = "Terminate Asynch. GPIB"
        Me.btnTERMINATE.UseVisualStyleBackColor = True
        '
        'btnRS232Test
        '
        Me.btnRS232Test.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRS232Test.Location = New System.Drawing.Point(48, 30)
        Me.btnRS232Test.Name = "btnRS232Test"
        Me.btnRS232Test.Size = New System.Drawing.Size(99, 32)
        Me.btnRS232Test.TabIndex = 13
        Me.btnRS232Test.Text = "Write Test"
        Me.btnRS232Test.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'btnTRIGGER
        '
        Me.btnTRIGGER.Location = New System.Drawing.Point(14, 210)
        Me.btnTRIGGER.Name = "btnTRIGGER"
        Me.btnTRIGGER.Size = New System.Drawing.Size(120, 25)
        Me.btnTRIGGER.TabIndex = 14
        Me.btnTRIGGER.Text = "Send Trigger"
        Me.btnTRIGGER.UseVisualStyleBackColor = True
        '
        'btnOpenBarcodeDeviceST1A
        '
        Me.btnOpenBarcodeDeviceST1A.Location = New System.Drawing.Point(12, 40)
        Me.btnOpenBarcodeDeviceST1A.Name = "btnOpenBarcodeDeviceST1A"
        Me.btnOpenBarcodeDeviceST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnOpenBarcodeDeviceST1A.TabIndex = 15
        Me.btnOpenBarcodeDeviceST1A.Text = "Open Barcode Device"
        Me.btnOpenBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'txtbBCDevice_ReadST1A
        '
        Me.txtbBCDevice_ReadST1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbBCDevice_ReadST1A.Location = New System.Drawing.Point(12, 225)
        Me.txtbBCDevice_ReadST1A.Multiline = True
        Me.txtbBCDevice_ReadST1A.Name = "txtbBCDevice_ReadST1A"
        Me.txtbBCDevice_ReadST1A.ReadOnly = True
        Me.txtbBCDevice_ReadST1A.Size = New System.Drawing.Size(125, 25)
        Me.txtbBCDevice_ReadST1A.TabIndex = 16
        Me.txtbBCDevice_ReadST1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBCDevice_LEDsOFFST1A
        '
        Me.btnBCDevice_LEDsOFFST1A.Location = New System.Drawing.Point(12, 163)
        Me.btnBCDevice_LEDsOFFST1A.Name = "btnBCDevice_LEDsOFFST1A"
        Me.btnBCDevice_LEDsOFFST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_LEDsOFFST1A.TabIndex = 17
        Me.btnBCDevice_LEDsOFFST1A.Text = "LEDs OFF"
        Me.btnBCDevice_LEDsOFFST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDGreenONST1A
        '
        Me.btnBCDevice_LEDGreenONST1A.Location = New System.Drawing.Point(12, 100)
        Me.btnBCDevice_LEDGreenONST1A.Name = "btnBCDevice_LEDGreenONST1A"
        Me.btnBCDevice_LEDGreenONST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_LEDGreenONST1A.TabIndex = 18
        Me.btnBCDevice_LEDGreenONST1A.Text = "LED GREEN ON"
        Me.btnBCDevice_LEDGreenONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDRedONST1A
        '
        Me.btnBCDevice_LEDRedONST1A.Location = New System.Drawing.Point(12, 132)
        Me.btnBCDevice_LEDRedONST1A.Name = "btnBCDevice_LEDRedONST1A"
        Me.btnBCDevice_LEDRedONST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_LEDRedONST1A.TabIndex = 19
        Me.btnBCDevice_LEDRedONST1A.Text = "LED RED ON"
        Me.btnBCDevice_LEDRedONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_BeepST1A
        '
        Me.btnBCDevice_BeepST1A.Location = New System.Drawing.Point(12, 194)
        Me.btnBCDevice_BeepST1A.Name = "btnBCDevice_BeepST1A"
        Me.btnBCDevice_BeepST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_BeepST1A.TabIndex = 21
        Me.btnBCDevice_BeepST1A.Text = "BEEP"
        Me.btnBCDevice_BeepST1A.UseVisualStyleBackColor = True
        '
        'btnBCDeviceEventSubscribeST1A
        '
        Me.btnBCDeviceEventSubscribeST1A.Location = New System.Drawing.Point(12, 70)
        Me.btnBCDeviceEventSubscribeST1A.Name = "btnBCDeviceEventSubscribeST1A"
        Me.btnBCDeviceEventSubscribeST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDeviceEventSubscribeST1A.TabIndex = 22
        Me.btnBCDeviceEventSubscribeST1A.Text = "Event Subscribe"
        Me.btnBCDeviceEventSubscribeST1A.UseVisualStyleBackColor = True
        '
        'btnCloseBarcodeDeviceST1A
        '
        Me.btnCloseBarcodeDeviceST1A.Location = New System.Drawing.Point(13, 256)
        Me.btnCloseBarcodeDeviceST1A.Name = "btnCloseBarcodeDeviceST1A"
        Me.btnCloseBarcodeDeviceST1A.Size = New System.Drawing.Size(125, 25)
        Me.btnCloseBarcodeDeviceST1A.TabIndex = 23
        Me.btnCloseBarcodeDeviceST1A.Text = "Close Barcode Device"
        Me.btnCloseBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'btnFTPUpJobST1B
        '
        Me.btnFTPUpJobST1B.Location = New System.Drawing.Point(213, 31)
        Me.btnFTPUpJobST1B.Name = "btnFTPUpJobST1B"
        Me.btnFTPUpJobST1B.Size = New System.Drawing.Size(80, 25)
        Me.btnFTPUpJobST1B.TabIndex = 28
        Me.btnFTPUpJobST1B.Text = "FTP Upload"
        Me.btnFTPUpJobST1B.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST1B
        '
        Me.txtbFTPUpJobST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST1B.Location = New System.Drawing.Point(6, 34)
        Me.txtbFTPUpJobST1B.Name = "txtbFTPUpJobST1B"
        Me.txtbFTPUpJobST1B.ReadOnly = True
        Me.txtbFTPUpJobST1B.Size = New System.Drawing.Size(201, 22)
        Me.txtbFTPUpJobST1B.TabIndex = 29
        Me.txtbFTPUpJobST1B.Text = "..."
        '
        'btnFTPdownload
        '
        Me.btnFTPdownload.Location = New System.Drawing.Point(50, 84)
        Me.btnFTPdownload.Name = "btnFTPdownload"
        Me.btnFTPdownload.Size = New System.Drawing.Size(105, 22)
        Me.btnFTPdownload.TabIndex = 32
        Me.btnFTPdownload.Text = "FTP Download"
        Me.btnFTPdownload.UseVisualStyleBackColor = True
        '
        'CvsInSightDisplay1
        '
        Me.CvsInSightDisplay1.AutoSize = True
        Me.CvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay1.DialogIcon = Nothing
        Me.CvsInSightDisplay1.GridOpacity = 0.0R
        Me.CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay1.Location = New System.Drawing.Point(9, 142)
        Me.CvsInSightDisplay1.Name = "CvsInSightDisplay1"
        Me.CvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay1.Size = New System.Drawing.Size(200, 150)
        Me.CvsInSightDisplay1.TabIndex = 33
        '
        'btnCONNECTCvsInSightDisplay1
        '
        Me.btnCONNECTCvsInSightDisplay1.Location = New System.Drawing.Point(212, 142)
        Me.btnCONNECTCvsInSightDisplay1.Name = "btnCONNECTCvsInSightDisplay1"
        Me.btnCONNECTCvsInSightDisplay1.Size = New System.Drawing.Size(80, 25)
        Me.btnCONNECTCvsInSightDisplay1.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay1.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'txtbADDRESSCvsInSightDisplay1
        '
        Me.txtbADDRESSCvsInSightDisplay1.Enabled = False
        Me.txtbADDRESSCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay1.Location = New System.Drawing.Point(57, 74)
        Me.txtbADDRESSCvsInSightDisplay1.Name = "txtbADDRESSCvsInSightDisplay1"
        Me.txtbADDRESSCvsInSightDisplay1.Size = New System.Drawing.Size(150, 22)
        Me.txtbADDRESSCvsInSightDisplay1.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay1.Text = "xxx.xxx.xxx.xxx"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "User:"
        '
        'txtbUSERCvsInSightDisplay1
        '
        Me.txtbUSERCvsInSightDisplay1.Enabled = False
        Me.txtbUSERCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay1.Location = New System.Drawing.Point(40, 98)
        Me.txtbUSERCvsInSightDisplay1.Name = "txtbUSERCvsInSightDisplay1"
        Me.txtbUSERCvsInSightDisplay1.Size = New System.Drawing.Size(61, 22)
        Me.txtbUSERCvsInSightDisplay1.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay1.Text = "???"
        '
        'txtbPASSWORDCvsInSightDisplay1
        '
        Me.txtbPASSWORDCvsInSightDisplay1.Enabled = False
        Me.txtbPASSWORDCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay1.Location = New System.Drawing.Point(164, 98)
        Me.txtbPASSWORDCvsInSightDisplay1.Name = "txtbPASSWORDCvsInSightDisplay1"
        Me.txtbPASSWORDCvsInSightDisplay1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay1.Size = New System.Drawing.Size(43, 22)
        Me.txtbPASSWORDCvsInSightDisplay1.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(109, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Password:"
        '
        'btnDISCONNECTCvsInSightDisplay1
        '
        Me.btnDISCONNECTCvsInSightDisplay1.Location = New System.Drawing.Point(212, 267)
        Me.btnDISCONNECTCvsInSightDisplay1.Name = "btnDISCONNECTCvsInSightDisplay1"
        Me.btnDISCONNECTCvsInSightDisplay1.Size = New System.Drawing.Size(80, 25)
        Me.btnDISCONNECTCvsInSightDisplay1.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay1.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay1
        '
        Me.btnTRIGGERCvsInSightDisplay1.Location = New System.Drawing.Point(212, 198)
        Me.btnTRIGGERCvsInSightDisplay1.Name = "btnTRIGGERCvsInSightDisplay1"
        Me.btnTRIGGERCvsInSightDisplay1.Size = New System.Drawing.Size(80, 25)
        Me.btnTRIGGERCvsInSightDisplay1.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay1.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnLOADFILECvsInSightDisplay1
        '
        Me.btnLOADFILECvsInSightDisplay1.Location = New System.Drawing.Point(212, 170)
        Me.btnLOADFILECvsInSightDisplay1.Name = "btnLOADFILECvsInSightDisplay1"
        Me.btnLOADFILECvsInSightDisplay1.Size = New System.Drawing.Size(80, 25)
        Me.btnLOADFILECvsInSightDisplay1.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay1.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnGETPASSCvsInSightDisplay1
        '
        Me.btnGETPASSCvsInSightDisplay1.Location = New System.Drawing.Point(212, 226)
        Me.btnGETPASSCvsInSightDisplay1.Name = "btnGETPASSCvsInSightDisplay1"
        Me.btnGETPASSCvsInSightDisplay1.Size = New System.Drawing.Size(80, 36)
        Me.btnGETPASSCvsInSightDisplay1.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay1.Text = "Get Value S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnOpenTelnetClientST1B
        '
        Me.btnOpenTelnetClientST1B.Location = New System.Drawing.Point(212, 69)
        Me.btnOpenTelnetClientST1B.Name = "btnOpenTelnetClientST1B"
        Me.btnOpenTelnetClientST1B.Size = New System.Drawing.Size(80, 25)
        Me.btnOpenTelnetClientST1B.TabIndex = 47
        Me.btnOpenTelnetClientST1B.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST1B.UseVisualStyleBackColor = True
        '
        'btnCloseTelnetClientST1B
        '
        Me.btnCloseTelnetClientST1B.Location = New System.Drawing.Point(212, 96)
        Me.btnCloseTelnetClientST1B.Name = "btnCloseTelnetClientST1B"
        Me.btnCloseTelnetClientST1B.Size = New System.Drawing.Size(80, 25)
        Me.btnCloseTelnetClientST1B.TabIndex = 48
        Me.btnCloseTelnetClientST1B.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST1B.UseVisualStyleBackColor = True
        '
        'txtbACKCvsInSightDisplay1
        '
        Me.txtbACKCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay1.Location = New System.Drawing.Point(107, 293)
        Me.txtbACKCvsInSightDisplay1.Name = "txtbACKCvsInSightDisplay1"
        Me.txtbACKCvsInSightDisplay1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay1.Size = New System.Drawing.Size(40, 26)
        Me.txtbACKCvsInSightDisplay1.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Command ACK:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(161, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Return Value:"
        '
        'txtbRETCvsInSightDisplay1
        '
        Me.txtbRETCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay1.Location = New System.Drawing.Point(239, 293)
        Me.txtbRETCvsInSightDisplay1.Name = "txtbRETCvsInSightDisplay1"
        Me.txtbRETCvsInSightDisplay1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay1.Size = New System.Drawing.Size(40, 26)
        Me.txtbRETCvsInSightDisplay1.TabIndex = 51
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1550, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STARTToolStripMenuItem, Me.ENDToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'STARTToolStripMenuItem
        '
        Me.STARTToolStripMenuItem.Name = "STARTToolStripMenuItem"
        Me.STARTToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.STARTToolStripMenuItem.Text = "START"
        '
        'ENDToolStripMenuItem
        '
        Me.ENDToolStripMenuItem.Name = "ENDToolStripMenuItem"
        Me.ENDToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ENDToolStripMenuItem.Text = "END"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT.."
        '
        'grpbxRS232
        '
        Me.grpbxRS232.Controls.Add(Me.btnRS232Test)
        Me.grpbxRS232.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxRS232.Location = New System.Drawing.Point(1390, 324)
        Me.grpbxRS232.Name = "grpbxRS232"
        Me.grpbxRS232.Size = New System.Drawing.Size(151, 73)
        Me.grpbxRS232.TabIndex = 54
        Me.grpbxRS232.TabStop = False
        Me.grpbxRS232.Text = "RS-232"
        '
        'grpbxBarcodeScannerST1A
        '
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.Label29)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnOpenBarcodeDeviceST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDsOFFST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.txtbBCDevice_ReadST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDGreenONST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_LEDRedONST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDevice_BeepST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnBCDeviceEventSubscribeST1A)
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.btnCloseBarcodeDeviceST1A)
        Me.grpbxBarcodeScannerST1A.Enabled = False
        Me.grpbxBarcodeScannerST1A.Location = New System.Drawing.Point(316, 29)
        Me.grpbxBarcodeScannerST1A.Name = "grpbxBarcodeScannerST1A"
        Me.grpbxBarcodeScannerST1A.Size = New System.Drawing.Size(150, 292)
        Me.grpbxBarcodeScannerST1A.TabIndex = 55
        Me.grpbxBarcodeScannerST1A.TabStop = False
        Me.grpbxBarcodeScannerST1A.Text = "Symbol Barcode ST1A"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(3, 18)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(145, 13)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "Initialize Symbol LS2208"
        '
        'grpbxGPIB_TEGAM
        '
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label28)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnOPEN)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnCLOSE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbPrimaryAddress)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbSecondaryAddress)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbBoardID)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label1)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label2)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label3)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnREAD)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbReadGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbWriteGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnWRITE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnTERMINATE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnTRIGGER)
        Me.grpbxGPIB_TEGAM.Enabled = False
        Me.grpbxGPIB_TEGAM.Location = New System.Drawing.Point(316, 329)
        Me.grpbxGPIB_TEGAM.Name = "grpbxGPIB_TEGAM"
        Me.grpbxGPIB_TEGAM.Size = New System.Drawing.Size(150, 325)
        Me.grpbxGPIB_TEGAM.TabIndex = 56
        Me.grpbxGPIB_TEGAM.TabStop = False
        Me.grpbxGPIB_TEGAM.Text = "TEGAM 1750 ST1A"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(133, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Initialize TEGAM 1750"
        '
        'grpbxP2000
        '
        Me.grpbxP2000.Controls.Add(Me.TextBox4)
        Me.grpbxP2000.Controls.Add(Me.TextBox5)
        Me.grpbxP2000.Controls.Add(Me.Button6)
        Me.grpbxP2000.Controls.Add(Me.btnFTPdownload)
        Me.grpbxP2000.Location = New System.Drawing.Point(780, 360)
        Me.grpbxP2000.Name = "grpbxP2000"
        Me.grpbxP2000.Size = New System.Drawing.Size(597, 150)
        Me.grpbxP2000.TabIndex = 57
        Me.grpbxP2000.TabStop = False
        Me.grpbxP2000.Text = "P2000 PLC I/O"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(306, 31)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(249, 38)
        Me.TextBox4.TabIndex = 36
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(9, 21)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(194, 53)
        Me.TextBox5.TabIndex = 35
        Me.TextBox5.Text = "C:\Users\jdelgado2\Documents\COGNEX\HEV20A.job"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(208, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(76, 53)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "FTP Upload"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'grpbxCVSInsight_ST1B
        '
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label6)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label5)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label4)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnFTPUpJobST1B)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbFTPUpJobST1B)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label14)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnCONNECTCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbRETCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbADDRESSCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label13)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label8)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbACKCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label9)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnCloseTelnetClientST1B)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbUSERCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnOpenTelnetClientST1B)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnGETPASSCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.Label10)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnLOADFILECvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnTRIGGERCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Controls.Add(Me.CvsInSightDisplay1)
        Me.grpbxCVSInsight_ST1B.Location = New System.Drawing.Point(472, 27)
        Me.grpbxCVSInsight_ST1B.Name = "grpbxCVSInsight_ST1B"
        Me.grpbxCVSInsight_ST1B.Size = New System.Drawing.Size(300, 325)
        Me.grpbxCVSInsight_ST1B.TabIndex = 58
        Me.grpbxCVSInsight_ST1B.TabStop = False
        Me.grpbxCVSInsight_ST1B.Text = "COGNEX InSight ST1B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "CVS InSight Display"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Open Telnet Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Upload *.job File to IS7200 ST1B"
        '
        'grpbxCVSInsight_ST2A
        '
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label7)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label11)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label12)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnFTPUpJobST2A)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbFTPUpJobST2A)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label15)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnCONNECTCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbRETCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbADDRESSCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label16)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label17)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbACKCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label18)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnCloseTelnetClientST2A)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbUSERCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnOpenTelnetClientST2A)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnGETPASSCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.Label19)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnLOADFILECvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnTRIGGERCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Controls.Add(Me.CvsInSightDisplay2)
        Me.grpbxCVSInsight_ST2A.Enabled = False
        Me.grpbxCVSInsight_ST2A.Location = New System.Drawing.Point(778, 27)
        Me.grpbxCVSInsight_ST2A.Name = "grpbxCVSInsight_ST2A"
        Me.grpbxCVSInsight_ST2A.Size = New System.Drawing.Size(300, 325)
        Me.grpbxCVSInsight_ST2A.TabIndex = 59
        Me.grpbxCVSInsight_ST2A.TabStop = False
        Me.grpbxCVSInsight_ST2A.Text = "COGNEX InSight ST2A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "CVS InSight Display"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Open Telnet Client"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Upload *.job File to IS7200 ST2A"
        '
        'btnFTPUpJobST2A
        '
        Me.btnFTPUpJobST2A.Location = New System.Drawing.Point(212, 30)
        Me.btnFTPUpJobST2A.Name = "btnFTPUpJobST2A"
        Me.btnFTPUpJobST2A.Size = New System.Drawing.Size(80, 25)
        Me.btnFTPUpJobST2A.TabIndex = 28
        Me.btnFTPUpJobST2A.Text = "FTP Upload"
        Me.btnFTPUpJobST2A.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST2A
        '
        Me.txtbFTPUpJobST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST2A.Location = New System.Drawing.Point(6, 34)
        Me.txtbFTPUpJobST2A.Name = "txtbFTPUpJobST2A"
        Me.txtbFTPUpJobST2A.ReadOnly = True
        Me.txtbFTPUpJobST2A.Size = New System.Drawing.Size(201, 22)
        Me.txtbFTPUpJobST2A.TabIndex = 29
        Me.txtbFTPUpJobST2A.Text = "..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(161, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Return Value:"
        '
        'btnCONNECTCvsInSightDisplay2
        '
        Me.btnCONNECTCvsInSightDisplay2.Location = New System.Drawing.Point(212, 142)
        Me.btnCONNECTCvsInSightDisplay2.Name = "btnCONNECTCvsInSightDisplay2"
        Me.btnCONNECTCvsInSightDisplay2.Size = New System.Drawing.Size(80, 25)
        Me.btnCONNECTCvsInSightDisplay2.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay2.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'txtbRETCvsInSightDisplay2
        '
        Me.txtbRETCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay2.Location = New System.Drawing.Point(239, 293)
        Me.txtbRETCvsInSightDisplay2.Name = "txtbRETCvsInSightDisplay2"
        Me.txtbRETCvsInSightDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay2.Size = New System.Drawing.Size(40, 26)
        Me.txtbRETCvsInSightDisplay2.TabIndex = 51
        '
        'txtbADDRESSCvsInSightDisplay2
        '
        Me.txtbADDRESSCvsInSightDisplay2.Enabled = False
        Me.txtbADDRESSCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay2.Location = New System.Drawing.Point(57, 74)
        Me.txtbADDRESSCvsInSightDisplay2.Name = "txtbADDRESSCvsInSightDisplay2"
        Me.txtbADDRESSCvsInSightDisplay2.Size = New System.Drawing.Size(150, 22)
        Me.txtbADDRESSCvsInSightDisplay2.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay2.Text = "xxx.xxx.xxx.xxx"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 300)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 13)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Command ACK:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Address:"
        '
        'txtbACKCvsInSightDisplay2
        '
        Me.txtbACKCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay2.Location = New System.Drawing.Point(107, 293)
        Me.txtbACKCvsInSightDisplay2.Name = "txtbACKCvsInSightDisplay2"
        Me.txtbACKCvsInSightDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay2.Size = New System.Drawing.Size(40, 26)
        Me.txtbACKCvsInSightDisplay2.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "User:"
        '
        'btnCloseTelnetClientST2A
        '
        Me.btnCloseTelnetClientST2A.Location = New System.Drawing.Point(212, 96)
        Me.btnCloseTelnetClientST2A.Name = "btnCloseTelnetClientST2A"
        Me.btnCloseTelnetClientST2A.Size = New System.Drawing.Size(80, 25)
        Me.btnCloseTelnetClientST2A.TabIndex = 48
        Me.btnCloseTelnetClientST2A.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST2A.UseVisualStyleBackColor = True
        '
        'txtbUSERCvsInSightDisplay2
        '
        Me.txtbUSERCvsInSightDisplay2.Enabled = False
        Me.txtbUSERCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay2.Location = New System.Drawing.Point(40, 98)
        Me.txtbUSERCvsInSightDisplay2.Name = "txtbUSERCvsInSightDisplay2"
        Me.txtbUSERCvsInSightDisplay2.Size = New System.Drawing.Size(61, 22)
        Me.txtbUSERCvsInSightDisplay2.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay2.Text = "???"
        '
        'btnOpenTelnetClientST2A
        '
        Me.btnOpenTelnetClientST2A.Location = New System.Drawing.Point(212, 69)
        Me.btnOpenTelnetClientST2A.Name = "btnOpenTelnetClientST2A"
        Me.btnOpenTelnetClientST2A.Size = New System.Drawing.Size(80, 25)
        Me.btnOpenTelnetClientST2A.TabIndex = 47
        Me.btnOpenTelnetClientST2A.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST2A.UseVisualStyleBackColor = True
        '
        'txtbPASSWORDCvsInSightDisplay2
        '
        Me.txtbPASSWORDCvsInSightDisplay2.Enabled = False
        Me.txtbPASSWORDCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay2.Location = New System.Drawing.Point(164, 98)
        Me.txtbPASSWORDCvsInSightDisplay2.Name = "txtbPASSWORDCvsInSightDisplay2"
        Me.txtbPASSWORDCvsInSightDisplay2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay2.Size = New System.Drawing.Size(43, 22)
        Me.txtbPASSWORDCvsInSightDisplay2.TabIndex = 39
        '
        'btnGETPASSCvsInSightDisplay2
        '
        Me.btnGETPASSCvsInSightDisplay2.Location = New System.Drawing.Point(212, 226)
        Me.btnGETPASSCvsInSightDisplay2.Name = "btnGETPASSCvsInSightDisplay2"
        Me.btnGETPASSCvsInSightDisplay2.Size = New System.Drawing.Size(80, 36)
        Me.btnGETPASSCvsInSightDisplay2.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay2.Text = "Get Value S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(109, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Password:"
        '
        'btnLOADFILECvsInSightDisplay2
        '
        Me.btnLOADFILECvsInSightDisplay2.Location = New System.Drawing.Point(212, 170)
        Me.btnLOADFILECvsInSightDisplay2.Name = "btnLOADFILECvsInSightDisplay2"
        Me.btnLOADFILECvsInSightDisplay2.Size = New System.Drawing.Size(80, 25)
        Me.btnLOADFILECvsInSightDisplay2.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay2.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay2
        '
        Me.btnTRIGGERCvsInSightDisplay2.Location = New System.Drawing.Point(212, 198)
        Me.btnTRIGGERCvsInSightDisplay2.Name = "btnTRIGGERCvsInSightDisplay2"
        Me.btnTRIGGERCvsInSightDisplay2.Size = New System.Drawing.Size(80, 25)
        Me.btnTRIGGERCvsInSightDisplay2.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay2.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'btnDISCONNECTCvsInSightDisplay2
        '
        Me.btnDISCONNECTCvsInSightDisplay2.Location = New System.Drawing.Point(212, 267)
        Me.btnDISCONNECTCvsInSightDisplay2.Name = "btnDISCONNECTCvsInSightDisplay2"
        Me.btnDISCONNECTCvsInSightDisplay2.Size = New System.Drawing.Size(80, 25)
        Me.btnDISCONNECTCvsInSightDisplay2.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay2.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'CvsInSightDisplay2
        '
        Me.CvsInSightDisplay2.AutoSize = True
        Me.CvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay2.DialogIcon = Nothing
        Me.CvsInSightDisplay2.GridOpacity = 0.0R
        Me.CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay2.Location = New System.Drawing.Point(9, 142)
        Me.CvsInSightDisplay2.Name = "CvsInSightDisplay2"
        Me.CvsInSightDisplay2.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay2.Size = New System.Drawing.Size(200, 150)
        Me.CvsInSightDisplay2.TabIndex = 33
        '
        'grpbxCVSInsight_ST3A
        '
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label20)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label21)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label22)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnFTPUpJobST3A)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbFTPUpJobST3A)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label23)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnCONNECTCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbRETCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbADDRESSCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label24)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label25)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbACKCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label26)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnCloseTelnetClientST3A)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbUSERCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnOpenTelnetClientST3A)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnGETPASSCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.Label27)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnLOADFILECvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnTRIGGERCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Controls.Add(Me.CvsInSightDisplay3)
        Me.grpbxCVSInsight_ST3A.Enabled = False
        Me.grpbxCVSInsight_ST3A.Location = New System.Drawing.Point(1084, 29)
        Me.grpbxCVSInsight_ST3A.Name = "grpbxCVSInsight_ST3A"
        Me.grpbxCVSInsight_ST3A.Size = New System.Drawing.Size(300, 325)
        Me.grpbxCVSInsight_ST3A.TabIndex = 60
        Me.grpbxCVSInsight_ST3A.TabStop = False
        Me.grpbxCVSInsight_ST3A.Text = "COGNEX InSight ST3A"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 13)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "CVS InSight Display"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 13)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Open Telnet Client"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(195, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Upload *.job File to IS7200 ST3A"
        '
        'btnFTPUpJobST3A
        '
        Me.btnFTPUpJobST3A.Location = New System.Drawing.Point(213, 31)
        Me.btnFTPUpJobST3A.Name = "btnFTPUpJobST3A"
        Me.btnFTPUpJobST3A.Size = New System.Drawing.Size(80, 25)
        Me.btnFTPUpJobST3A.TabIndex = 28
        Me.btnFTPUpJobST3A.Text = "FTP Upload"
        Me.btnFTPUpJobST3A.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST3A
        '
        Me.txtbFTPUpJobST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST3A.Location = New System.Drawing.Point(6, 34)
        Me.txtbFTPUpJobST3A.Name = "txtbFTPUpJobST3A"
        Me.txtbFTPUpJobST3A.ReadOnly = True
        Me.txtbFTPUpJobST3A.Size = New System.Drawing.Size(201, 22)
        Me.txtbFTPUpJobST3A.TabIndex = 29
        Me.txtbFTPUpJobST3A.Text = "..."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(161, 300)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 13)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Return Value:"
        '
        'btnCONNECTCvsInSightDisplay3
        '
        Me.btnCONNECTCvsInSightDisplay3.Location = New System.Drawing.Point(212, 142)
        Me.btnCONNECTCvsInSightDisplay3.Name = "btnCONNECTCvsInSightDisplay3"
        Me.btnCONNECTCvsInSightDisplay3.Size = New System.Drawing.Size(80, 25)
        Me.btnCONNECTCvsInSightDisplay3.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay3.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'txtbRETCvsInSightDisplay3
        '
        Me.txtbRETCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay3.Location = New System.Drawing.Point(239, 293)
        Me.txtbRETCvsInSightDisplay3.Name = "txtbRETCvsInSightDisplay3"
        Me.txtbRETCvsInSightDisplay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay3.Size = New System.Drawing.Size(40, 26)
        Me.txtbRETCvsInSightDisplay3.TabIndex = 51
        '
        'txtbADDRESSCvsInSightDisplay3
        '
        Me.txtbADDRESSCvsInSightDisplay3.Enabled = False
        Me.txtbADDRESSCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay3.Location = New System.Drawing.Point(57, 74)
        Me.txtbADDRESSCvsInSightDisplay3.Name = "txtbADDRESSCvsInSightDisplay3"
        Me.txtbADDRESSCvsInSightDisplay3.Size = New System.Drawing.Size(150, 22)
        Me.txtbADDRESSCvsInSightDisplay3.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay3.Text = "xxx.xxx.xxx.xxx"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(20, 300)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 13)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "Command ACK:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 13)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Address:"
        '
        'txtbACKCvsInSightDisplay3
        '
        Me.txtbACKCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay3.Location = New System.Drawing.Point(107, 293)
        Me.txtbACKCvsInSightDisplay3.Name = "txtbACKCvsInSightDisplay3"
        Me.txtbACKCvsInSightDisplay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay3.Size = New System.Drawing.Size(40, 26)
        Me.txtbACKCvsInSightDisplay3.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 103)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(32, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "User:"
        '
        'btnCloseTelnetClientST3A
        '
        Me.btnCloseTelnetClientST3A.Location = New System.Drawing.Point(212, 96)
        Me.btnCloseTelnetClientST3A.Name = "btnCloseTelnetClientST3A"
        Me.btnCloseTelnetClientST3A.Size = New System.Drawing.Size(80, 25)
        Me.btnCloseTelnetClientST3A.TabIndex = 48
        Me.btnCloseTelnetClientST3A.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST3A.UseVisualStyleBackColor = True
        '
        'txtbUSERCvsInSightDisplay3
        '
        Me.txtbUSERCvsInSightDisplay3.Enabled = False
        Me.txtbUSERCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay3.Location = New System.Drawing.Point(40, 98)
        Me.txtbUSERCvsInSightDisplay3.Name = "txtbUSERCvsInSightDisplay3"
        Me.txtbUSERCvsInSightDisplay3.Size = New System.Drawing.Size(61, 22)
        Me.txtbUSERCvsInSightDisplay3.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay3.Text = "???"
        '
        'btnOpenTelnetClientST3A
        '
        Me.btnOpenTelnetClientST3A.Location = New System.Drawing.Point(212, 69)
        Me.btnOpenTelnetClientST3A.Name = "btnOpenTelnetClientST3A"
        Me.btnOpenTelnetClientST3A.Size = New System.Drawing.Size(80, 25)
        Me.btnOpenTelnetClientST3A.TabIndex = 47
        Me.btnOpenTelnetClientST3A.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST3A.UseVisualStyleBackColor = True
        '
        'txtbPASSWORDCvsInSightDisplay3
        '
        Me.txtbPASSWORDCvsInSightDisplay3.Enabled = False
        Me.txtbPASSWORDCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay3.Location = New System.Drawing.Point(164, 98)
        Me.txtbPASSWORDCvsInSightDisplay3.Name = "txtbPASSWORDCvsInSightDisplay3"
        Me.txtbPASSWORDCvsInSightDisplay3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay3.Size = New System.Drawing.Size(43, 22)
        Me.txtbPASSWORDCvsInSightDisplay3.TabIndex = 39
        '
        'btnGETPASSCvsInSightDisplay3
        '
        Me.btnGETPASSCvsInSightDisplay3.Location = New System.Drawing.Point(212, 226)
        Me.btnGETPASSCvsInSightDisplay3.Name = "btnGETPASSCvsInSightDisplay3"
        Me.btnGETPASSCvsInSightDisplay3.Size = New System.Drawing.Size(80, 36)
        Me.btnGETPASSCvsInSightDisplay3.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay3.Text = "Get Value S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(109, 103)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 13)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Password:"
        '
        'btnLOADFILECvsInSightDisplay3
        '
        Me.btnLOADFILECvsInSightDisplay3.Location = New System.Drawing.Point(212, 170)
        Me.btnLOADFILECvsInSightDisplay3.Name = "btnLOADFILECvsInSightDisplay3"
        Me.btnLOADFILECvsInSightDisplay3.Size = New System.Drawing.Size(80, 25)
        Me.btnLOADFILECvsInSightDisplay3.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay3.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay3
        '
        Me.btnTRIGGERCvsInSightDisplay3.Location = New System.Drawing.Point(212, 198)
        Me.btnTRIGGERCvsInSightDisplay3.Name = "btnTRIGGERCvsInSightDisplay3"
        Me.btnTRIGGERCvsInSightDisplay3.Size = New System.Drawing.Size(80, 25)
        Me.btnTRIGGERCvsInSightDisplay3.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay3.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'btnDISCONNECTCvsInSightDisplay3
        '
        Me.btnDISCONNECTCvsInSightDisplay3.Location = New System.Drawing.Point(212, 267)
        Me.btnDISCONNECTCvsInSightDisplay3.Name = "btnDISCONNECTCvsInSightDisplay3"
        Me.btnDISCONNECTCvsInSightDisplay3.Size = New System.Drawing.Size(80, 25)
        Me.btnDISCONNECTCvsInSightDisplay3.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay3.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'CvsInSightDisplay3
        '
        Me.CvsInSightDisplay3.AutoSize = True
        Me.CvsInSightDisplay3.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay3.DialogIcon = Nothing
        Me.CvsInSightDisplay3.GridOpacity = 0.0R
        Me.CvsInSightDisplay3.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay3.Location = New System.Drawing.Point(9, 142)
        Me.CvsInSightDisplay3.Name = "CvsInSightDisplay3"
        Me.CvsInSightDisplay3.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay3.Size = New System.Drawing.Size(200, 150)
        Me.CvsInSightDisplay3.TabIndex = 33
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 666)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1550, 22)
        Me.StatusStrip1.TabIndex = 62
        Me.StatusStrip1.Tag = "asd"
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'grpbxINITIALIZE
        '
        Me.grpbxINITIALIZE.Controls.Add(Me.btnLoadINI)
        Me.grpbxINITIALIZE.Controls.Add(Me.btnStartSelectedPeripherals)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbSymbolBarcodeST3A)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbCOGNEXInSightST3A)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label34)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbScaleRS232)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbP2000)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbCOGNEXInSightST2A)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label33)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbZebra110Xi4_ST3A)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbCOGNEXInSightST1B)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbZebra110Xi4_ST1A)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label32)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbTEGAMGPIBInterface)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label31)
        Me.grpbxINITIALIZE.Controls.Add(Me.chkbSymbolBarcodeST1A)
        Me.grpbxINITIALIZE.Controls.Add(Me.btnINI_FileSelection)
        Me.grpbxINITIALIZE.Controls.Add(Me.txtbINI_FilePath)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label30)
        Me.grpbxINITIALIZE.Location = New System.Drawing.Point(5, 27)
        Me.grpbxINITIALIZE.Name = "grpbxINITIALIZE"
        Me.grpbxINITIALIZE.Size = New System.Drawing.Size(282, 488)
        Me.grpbxINITIALIZE.TabIndex = 63
        Me.grpbxINITIALIZE.TabStop = False
        Me.grpbxINITIALIZE.Text = "Initialize"
        '
        'btnLoadINI
        '
        Me.btnLoadINI.Enabled = False
        Me.btnLoadINI.Location = New System.Drawing.Point(212, 61)
        Me.btnLoadINI.Name = "btnLoadINI"
        Me.btnLoadINI.Size = New System.Drawing.Size(64, 25)
        Me.btnLoadINI.TabIndex = 76
        Me.btnLoadINI.Text = "Load INI"
        Me.btnLoadINI.UseVisualStyleBackColor = True
        '
        'btnStartSelectedPeripherals
        '
        Me.btnStartSelectedPeripherals.Location = New System.Drawing.Point(10, 390)
        Me.btnStartSelectedPeripherals.Name = "btnStartSelectedPeripherals"
        Me.btnStartSelectedPeripherals.Size = New System.Drawing.Size(256, 36)
        Me.btnStartSelectedPeripherals.TabIndex = 75
        Me.btnStartSelectedPeripherals.Text = "Start Selected Peripherals"
        Me.btnStartSelectedPeripherals.UseVisualStyleBackColor = True
        '
        'chkbSymbolBarcodeST3A
        '
        Me.chkbSymbolBarcodeST3A.AutoSize = True
        Me.chkbSymbolBarcodeST3A.Location = New System.Drawing.Point(19, 343)
        Me.chkbSymbolBarcodeST3A.Name = "chkbSymbolBarcodeST3A"
        Me.chkbSymbolBarcodeST3A.Size = New System.Drawing.Size(186, 17)
        Me.chkbSymbolBarcodeST3A.TabIndex = 74
        Me.chkbSymbolBarcodeST3A.Text = "SYMBOL Barcode Scanner ST3A"
        Me.chkbSymbolBarcodeST3A.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST3A
        '
        Me.chkbCOGNEXInSightST3A.AutoSize = True
        Me.chkbCOGNEXInSightST3A.Location = New System.Drawing.Point(19, 297)
        Me.chkbCOGNEXInSightST3A.Name = "chkbCOGNEXInSightST3A"
        Me.chkbCOGNEXInSightST3A.Size = New System.Drawing.Size(137, 17)
        Me.chkbCOGNEXInSightST3A.TabIndex = 73
        Me.chkbCOGNEXInSightST3A.Text = "COGNEX InSight ST3A"
        Me.chkbCOGNEXInSightST3A.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(6, 279)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "ST2"
        '
        'chkbScaleRS232
        '
        Me.chkbScaleRS232.AutoSize = True
        Me.chkbScaleRS232.Location = New System.Drawing.Point(19, 320)
        Me.chkbScaleRS232.Name = "chkbScaleRS232"
        Me.chkbScaleRS232.Size = New System.Drawing.Size(96, 17)
        Me.chkbScaleRS232.TabIndex = 71
        Me.chkbScaleRS232.Text = "SCALE RS232"
        Me.chkbScaleRS232.UseVisualStyleBackColor = True
        '
        'chkbP2000
        '
        Me.chkbP2000.AutoSize = True
        Me.chkbP2000.Location = New System.Drawing.Point(20, 208)
        Me.chkbP2000.Name = "chkbP2000"
        Me.chkbP2000.Size = New System.Drawing.Size(197, 17)
        Me.chkbP2000.TabIndex = 70
        Me.chkbP2000.Text = "PLC P2000 / K50 Dome Light ST1B"
        Me.chkbP2000.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST2A
        '
        Me.chkbCOGNEXInSightST2A.AutoSize = True
        Me.chkbCOGNEXInSightST2A.Location = New System.Drawing.Point(20, 255)
        Me.chkbCOGNEXInSightST2A.Name = "chkbCOGNEXInSightST2A"
        Me.chkbCOGNEXInSightST2A.Size = New System.Drawing.Size(137, 17)
        Me.chkbCOGNEXInSightST2A.TabIndex = 69
        Me.chkbCOGNEXInSightST2A.Text = "COGNEX InSight ST2A"
        Me.chkbCOGNEXInSightST2A.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(7, 237)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 13)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "ST2"
        '
        'chkbZebra110Xi4_ST3A
        '
        Me.chkbZebra110Xi4_ST3A.AutoSize = True
        Me.chkbZebra110Xi4_ST3A.Location = New System.Drawing.Point(19, 367)
        Me.chkbZebra110Xi4_ST3A.Name = "chkbZebra110Xi4_ST3A"
        Me.chkbZebra110Xi4_ST3A.Size = New System.Drawing.Size(128, 17)
        Me.chkbZebra110Xi4_ST3A.TabIndex = 66
        Me.chkbZebra110Xi4_ST3A.Text = "ZEBRA 110Xi4 ST3A"
        Me.chkbZebra110Xi4_ST3A.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST1B
        '
        Me.chkbCOGNEXInSightST1B.AutoSize = True
        Me.chkbCOGNEXInSightST1B.Location = New System.Drawing.Point(20, 185)
        Me.chkbCOGNEXInSightST1B.Name = "chkbCOGNEXInSightST1B"
        Me.chkbCOGNEXInSightST1B.Size = New System.Drawing.Size(137, 17)
        Me.chkbCOGNEXInSightST1B.TabIndex = 64
        Me.chkbCOGNEXInSightST1B.Text = "COGNEX InSight ST1B"
        Me.chkbCOGNEXInSightST1B.UseVisualStyleBackColor = True
        '
        'chkbZebra110Xi4_ST1A
        '
        Me.chkbZebra110Xi4_ST1A.AutoSize = True
        Me.chkbZebra110Xi4_ST1A.Location = New System.Drawing.Point(20, 162)
        Me.chkbZebra110Xi4_ST1A.Name = "chkbZebra110Xi4_ST1A"
        Me.chkbZebra110Xi4_ST1A.Size = New System.Drawing.Size(128, 17)
        Me.chkbZebra110Xi4_ST1A.TabIndex = 63
        Me.chkbZebra110Xi4_ST1A.Text = "ZEBRA 110Xi4 ST1A"
        Me.chkbZebra110Xi4_ST1A.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(7, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 13)
        Me.Label32.TabIndex = 62
        Me.Label32.Text = "ST1"
        '
        'chkbTEGAMGPIBInterface
        '
        Me.chkbTEGAMGPIBInterface.AutoSize = True
        Me.chkbTEGAMGPIBInterface.Location = New System.Drawing.Point(20, 139)
        Me.chkbTEGAMGPIBInterface.Name = "chkbTEGAMGPIBInterface"
        Me.chkbTEGAMGPIBInterface.Size = New System.Drawing.Size(121, 17)
        Me.chkbTEGAMGPIBInterface.TabIndex = 61
        Me.chkbTEGAMGPIBInterface.Text = "TEGAM 1750 ST1A"
        Me.chkbTEGAMGPIBInterface.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(7, 83)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(160, 13)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Select Peripherals to Start:"
        '
        'chkbSymbolBarcodeST1A
        '
        Me.chkbSymbolBarcodeST1A.AutoSize = True
        Me.chkbSymbolBarcodeST1A.Location = New System.Drawing.Point(20, 116)
        Me.chkbSymbolBarcodeST1A.Name = "chkbSymbolBarcodeST1A"
        Me.chkbSymbolBarcodeST1A.Size = New System.Drawing.Size(186, 17)
        Me.chkbSymbolBarcodeST1A.TabIndex = 59
        Me.chkbSymbolBarcodeST1A.Text = "SYMBOL Barcode Scanner ST1A"
        Me.chkbSymbolBarcodeST1A.UseVisualStyleBackColor = True
        '
        'btnINI_FileSelection
        '
        Me.btnINI_FileSelection.Location = New System.Drawing.Point(212, 33)
        Me.btnINI_FileSelection.Name = "btnINI_FileSelection"
        Me.btnINI_FileSelection.Size = New System.Drawing.Size(64, 25)
        Me.btnINI_FileSelection.TabIndex = 57
        Me.btnINI_FileSelection.Text = "Select INI"
        Me.btnINI_FileSelection.UseVisualStyleBackColor = True
        '
        'txtbINI_FilePath
        '
        Me.txtbINI_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbINI_FilePath.Location = New System.Drawing.Point(6, 33)
        Me.txtbINI_FilePath.Multiline = True
        Me.txtbINI_FilePath.Name = "txtbINI_FilePath"
        Me.txtbINI_FilePath.Size = New System.Drawing.Size(200, 25)
        Me.txtbINI_FilePath.TabIndex = 58
        Me.txtbINI_FilePath.Text = "C:\Users\jdelgado2\Documents\COGNEX\HEV20A.job"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(5, 17)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 13)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Settings INI File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.btnOpenBarcodeDeviceST3A)
        Me.GroupBox1.Controls.Add(Me.txtbBCDevice_ReadST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDGreenONST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDRedONST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDsOFFST3A)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.btnBCDeviceEventSubscribeST3A)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Location = New System.Drawing.Point(1390, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 287)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Symbol Barcode ST3A"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(3, 18)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(145, 13)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Initialize Symbol LS2208"
        '
        'btnOpenBarcodeDeviceST3A
        '
        Me.btnOpenBarcodeDeviceST3A.Location = New System.Drawing.Point(13, 40)
        Me.btnOpenBarcodeDeviceST3A.Name = "btnOpenBarcodeDeviceST3A"
        Me.btnOpenBarcodeDeviceST3A.Size = New System.Drawing.Size(125, 25)
        Me.btnOpenBarcodeDeviceST3A.TabIndex = 15
        Me.btnOpenBarcodeDeviceST3A.Text = "Open Barcode Device"
        Me.btnOpenBarcodeDeviceST3A.UseVisualStyleBackColor = True
        '
        'txtbBCDevice_ReadST3A
        '
        Me.txtbBCDevice_ReadST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbBCDevice_ReadST3A.Location = New System.Drawing.Point(13, 224)
        Me.txtbBCDevice_ReadST3A.Multiline = True
        Me.txtbBCDevice_ReadST3A.Name = "txtbBCDevice_ReadST3A"
        Me.txtbBCDevice_ReadST3A.ReadOnly = True
        Me.txtbBCDevice_ReadST3A.Size = New System.Drawing.Size(125, 25)
        Me.txtbBCDevice_ReadST3A.TabIndex = 16
        Me.txtbBCDevice_ReadST3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBCDevice_LEDGreenONST3A
        '
        Me.btnBCDevice_LEDGreenONST3A.Location = New System.Drawing.Point(13, 100)
        Me.btnBCDevice_LEDGreenONST3A.Name = "btnBCDevice_LEDGreenONST3A"
        Me.btnBCDevice_LEDGreenONST3A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_LEDGreenONST3A.TabIndex = 18
        Me.btnBCDevice_LEDGreenONST3A.Text = "LED GREEN ON"
        Me.btnBCDevice_LEDGreenONST3A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDRedONST3A
        '
        Me.btnBCDevice_LEDRedONST3A.Location = New System.Drawing.Point(13, 131)
        Me.btnBCDevice_LEDRedONST3A.Name = "btnBCDevice_LEDRedONST3A"
        Me.btnBCDevice_LEDRedONST3A.Size = New System.Drawing.Size(123, 25)
        Me.btnBCDevice_LEDRedONST3A.TabIndex = 19
        Me.btnBCDevice_LEDRedONST3A.Text = "LED RED ON"
        Me.btnBCDevice_LEDRedONST3A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDsOFFST3A
        '
        Me.btnBCDevice_LEDsOFFST3A.Location = New System.Drawing.Point(13, 162)
        Me.btnBCDevice_LEDsOFFST3A.Name = "btnBCDevice_LEDsOFFST3A"
        Me.btnBCDevice_LEDsOFFST3A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDevice_LEDsOFFST3A.TabIndex = 20
        Me.btnBCDevice_LEDsOFFST3A.Text = "LEDs OFF"
        Me.btnBCDevice_LEDsOFFST3A.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(13, 193)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 25)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "BEEP"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnBCDeviceEventSubscribeST3A
        '
        Me.btnBCDeviceEventSubscribeST3A.Location = New System.Drawing.Point(13, 70)
        Me.btnBCDeviceEventSubscribeST3A.Name = "btnBCDeviceEventSubscribeST3A"
        Me.btnBCDeviceEventSubscribeST3A.Size = New System.Drawing.Size(125, 25)
        Me.btnBCDeviceEventSubscribeST3A.TabIndex = 22
        Me.btnBCDeviceEventSubscribeST3A.Text = "Event Subscribe"
        Me.btnBCDeviceEventSubscribeST3A.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(13, 255)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(125, 25)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "Close Barcode Device"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'grpbxMODBUS_TCP
        '
        Me.grpbxMODBUS_TCP.Controls.Add(Me.Label39)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.Label38)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.btnModbusTCP_Disconnect)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X15)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X14)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X13)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X12)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X11)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X10)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X09)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X08)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X07)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.btnModbusTCP_Refresh)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X06)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X05)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X04)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X03)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X02)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X01)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.chkbModbusTCP_X16)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y15)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y14)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y13)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y12)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y11)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y10)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y09)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y08)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y07)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y06)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y05)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y04)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y03)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y02)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y01)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.lblModbusTCP_Y16)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.btnModbusTCP_Connect)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.Label37)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.Label36)
        Me.grpbxMODBUS_TCP.Controls.Add(Me.txtbMODBUS_TCP_IP_Address)
        Me.grpbxMODBUS_TCP.Location = New System.Drawing.Point(478, 354)
        Me.grpbxMODBUS_TCP.Name = "grpbxMODBUS_TCP"
        Me.grpbxMODBUS_TCP.Size = New System.Drawing.Size(150, 300)
        Me.grpbxMODBUS_TCP.TabIndex = 64
        Me.grpbxMODBUS_TCP.TabStop = False
        Me.grpbxMODBUS_TCP.Text = "MODBUS TCP - P2000"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(76, 75)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 13)
        Me.Label39.TabIndex = 93
        Me.Label39.Text = "Read DI"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(11, 75)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(68, 13)
        Me.Label38.TabIndex = 92
        Me.Label38.Text = "Write Coils"
        '
        'btnModbusTCP_Disconnect
        '
        Me.btnModbusTCP_Disconnect.Location = New System.Drawing.Point(71, 16)
        Me.btnModbusTCP_Disconnect.Name = "btnModbusTCP_Disconnect"
        Me.btnModbusTCP_Disconnect.Size = New System.Drawing.Size(74, 25)
        Me.btnModbusTCP_Disconnect.TabIndex = 91
        Me.btnModbusTCP_Disconnect.Text = "Disconnect"
        Me.btnModbusTCP_Disconnect.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X15
        '
        Me.chkbModbusTCP_X15.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X15.AutoSize = True
        Me.chkbModbusTCP_X15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X15.Location = New System.Drawing.Point(43, 232)
        Me.chkbModbusTCP_X15.Name = "chkbModbusTCP_X15"
        Me.chkbModbusTCP_X15.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X15.TabIndex = 90
        Me.chkbModbusTCP_X15.Text = "X15"
        Me.chkbModbusTCP_X15.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X14
        '
        Me.chkbModbusTCP_X14.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X14.AutoSize = True
        Me.chkbModbusTCP_X14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X14.Location = New System.Drawing.Point(43, 209)
        Me.chkbModbusTCP_X14.Name = "chkbModbusTCP_X14"
        Me.chkbModbusTCP_X14.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X14.TabIndex = 89
        Me.chkbModbusTCP_X14.Text = "X14"
        Me.chkbModbusTCP_X14.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X13
        '
        Me.chkbModbusTCP_X13.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X13.AutoSize = True
        Me.chkbModbusTCP_X13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X13.Location = New System.Drawing.Point(43, 185)
        Me.chkbModbusTCP_X13.Name = "chkbModbusTCP_X13"
        Me.chkbModbusTCP_X13.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X13.TabIndex = 88
        Me.chkbModbusTCP_X13.Text = "X13"
        Me.chkbModbusTCP_X13.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X12
        '
        Me.chkbModbusTCP_X12.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X12.AutoSize = True
        Me.chkbModbusTCP_X12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X12.Location = New System.Drawing.Point(43, 161)
        Me.chkbModbusTCP_X12.Name = "chkbModbusTCP_X12"
        Me.chkbModbusTCP_X12.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X12.TabIndex = 87
        Me.chkbModbusTCP_X12.Text = "X12"
        Me.chkbModbusTCP_X12.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X11
        '
        Me.chkbModbusTCP_X11.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X11.AutoSize = True
        Me.chkbModbusTCP_X11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X11.Location = New System.Drawing.Point(43, 137)
        Me.chkbModbusTCP_X11.Name = "chkbModbusTCP_X11"
        Me.chkbModbusTCP_X11.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X11.TabIndex = 86
        Me.chkbModbusTCP_X11.Text = "X11"
        Me.chkbModbusTCP_X11.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X10
        '
        Me.chkbModbusTCP_X10.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X10.AutoSize = True
        Me.chkbModbusTCP_X10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X10.Location = New System.Drawing.Point(43, 114)
        Me.chkbModbusTCP_X10.Name = "chkbModbusTCP_X10"
        Me.chkbModbusTCP_X10.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X10.TabIndex = 85
        Me.chkbModbusTCP_X10.Text = "X10"
        Me.chkbModbusTCP_X10.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X09
        '
        Me.chkbModbusTCP_X09.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X09.AutoSize = True
        Me.chkbModbusTCP_X09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X09.Location = New System.Drawing.Point(43, 91)
        Me.chkbModbusTCP_X09.Name = "chkbModbusTCP_X09"
        Me.chkbModbusTCP_X09.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X09.TabIndex = 84
        Me.chkbModbusTCP_X09.Text = "X09"
        Me.chkbModbusTCP_X09.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X08
        '
        Me.chkbModbusTCP_X08.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X08.AutoSize = True
        Me.chkbModbusTCP_X08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X08.Location = New System.Drawing.Point(6, 256)
        Me.chkbModbusTCP_X08.Name = "chkbModbusTCP_X08"
        Me.chkbModbusTCP_X08.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X08.TabIndex = 83
        Me.chkbModbusTCP_X08.Text = "X08"
        Me.chkbModbusTCP_X08.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X07
        '
        Me.chkbModbusTCP_X07.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X07.AutoSize = True
        Me.chkbModbusTCP_X07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X07.Location = New System.Drawing.Point(6, 232)
        Me.chkbModbusTCP_X07.Name = "chkbModbusTCP_X07"
        Me.chkbModbusTCP_X07.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X07.TabIndex = 82
        Me.chkbModbusTCP_X07.Text = "X07"
        Me.chkbModbusTCP_X07.UseVisualStyleBackColor = True
        '
        'btnModbusTCP_Refresh
        '
        Me.btnModbusTCP_Refresh.Location = New System.Drawing.Point(81, 276)
        Me.btnModbusTCP_Refresh.Name = "btnModbusTCP_Refresh"
        Me.btnModbusTCP_Refresh.Size = New System.Drawing.Size(65, 20)
        Me.btnModbusTCP_Refresh.TabIndex = 42
        Me.btnModbusTCP_Refresh.Text = "Refresh"
        Me.btnModbusTCP_Refresh.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X06
        '
        Me.chkbModbusTCP_X06.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X06.AutoSize = True
        Me.chkbModbusTCP_X06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X06.Location = New System.Drawing.Point(6, 209)
        Me.chkbModbusTCP_X06.Name = "chkbModbusTCP_X06"
        Me.chkbModbusTCP_X06.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X06.TabIndex = 81
        Me.chkbModbusTCP_X06.Text = "X06"
        Me.chkbModbusTCP_X06.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X05
        '
        Me.chkbModbusTCP_X05.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X05.AutoSize = True
        Me.chkbModbusTCP_X05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X05.Location = New System.Drawing.Point(6, 185)
        Me.chkbModbusTCP_X05.Name = "chkbModbusTCP_X05"
        Me.chkbModbusTCP_X05.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X05.TabIndex = 80
        Me.chkbModbusTCP_X05.Text = "X05"
        Me.chkbModbusTCP_X05.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X04
        '
        Me.chkbModbusTCP_X04.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X04.AutoSize = True
        Me.chkbModbusTCP_X04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X04.Location = New System.Drawing.Point(6, 161)
        Me.chkbModbusTCP_X04.Name = "chkbModbusTCP_X04"
        Me.chkbModbusTCP_X04.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X04.TabIndex = 79
        Me.chkbModbusTCP_X04.Text = "X04"
        Me.chkbModbusTCP_X04.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X03
        '
        Me.chkbModbusTCP_X03.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X03.AutoSize = True
        Me.chkbModbusTCP_X03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X03.Location = New System.Drawing.Point(6, 137)
        Me.chkbModbusTCP_X03.Name = "chkbModbusTCP_X03"
        Me.chkbModbusTCP_X03.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X03.TabIndex = 78
        Me.chkbModbusTCP_X03.Text = "X03"
        Me.chkbModbusTCP_X03.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X02
        '
        Me.chkbModbusTCP_X02.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X02.AutoSize = True
        Me.chkbModbusTCP_X02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X02.Location = New System.Drawing.Point(6, 114)
        Me.chkbModbusTCP_X02.Name = "chkbModbusTCP_X02"
        Me.chkbModbusTCP_X02.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X02.TabIndex = 77
        Me.chkbModbusTCP_X02.Text = "X02"
        Me.chkbModbusTCP_X02.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X01
        '
        Me.chkbModbusTCP_X01.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X01.AutoSize = True
        Me.chkbModbusTCP_X01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X01.Location = New System.Drawing.Point(6, 91)
        Me.chkbModbusTCP_X01.Name = "chkbModbusTCP_X01"
        Me.chkbModbusTCP_X01.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X01.TabIndex = 76
        Me.chkbModbusTCP_X01.Text = "X01"
        Me.chkbModbusTCP_X01.UseVisualStyleBackColor = True
        '
        'chkbModbusTCP_X16
        '
        Me.chkbModbusTCP_X16.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkbModbusTCP_X16.AutoSize = True
        Me.chkbModbusTCP_X16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbModbusTCP_X16.Location = New System.Drawing.Point(43, 256)
        Me.chkbModbusTCP_X16.Name = "chkbModbusTCP_X16"
        Me.chkbModbusTCP_X16.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X16.TabIndex = 75
        Me.chkbModbusTCP_X16.Text = "X16"
        Me.chkbModbusTCP_X16.UseVisualStyleBackColor = True
        '
        'lblModbusTCP_Y15
        '
        Me.lblModbusTCP_Y15.AutoSize = True
        Me.lblModbusTCP_Y15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y15.Location = New System.Drawing.Point(115, 233)
        Me.lblModbusTCP_Y15.Name = "lblModbusTCP_Y15"
        Me.lblModbusTCP_Y15.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y15.TabIndex = 58
        Me.lblModbusTCP_Y15.Text = "Y15"
        '
        'lblModbusTCP_Y14
        '
        Me.lblModbusTCP_Y14.AutoSize = True
        Me.lblModbusTCP_Y14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y14.Location = New System.Drawing.Point(115, 210)
        Me.lblModbusTCP_Y14.Name = "lblModbusTCP_Y14"
        Me.lblModbusTCP_Y14.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y14.TabIndex = 57
        Me.lblModbusTCP_Y14.Text = "Y14"
        '
        'lblModbusTCP_Y13
        '
        Me.lblModbusTCP_Y13.AutoSize = True
        Me.lblModbusTCP_Y13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y13.Location = New System.Drawing.Point(115, 186)
        Me.lblModbusTCP_Y13.Name = "lblModbusTCP_Y13"
        Me.lblModbusTCP_Y13.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y13.TabIndex = 56
        Me.lblModbusTCP_Y13.Text = "Y13"
        '
        'lblModbusTCP_Y12
        '
        Me.lblModbusTCP_Y12.AutoSize = True
        Me.lblModbusTCP_Y12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y12.Location = New System.Drawing.Point(115, 162)
        Me.lblModbusTCP_Y12.Name = "lblModbusTCP_Y12"
        Me.lblModbusTCP_Y12.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y12.TabIndex = 55
        Me.lblModbusTCP_Y12.Text = "Y12"
        '
        'lblModbusTCP_Y11
        '
        Me.lblModbusTCP_Y11.AutoSize = True
        Me.lblModbusTCP_Y11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y11.Location = New System.Drawing.Point(115, 138)
        Me.lblModbusTCP_Y11.Name = "lblModbusTCP_Y11"
        Me.lblModbusTCP_Y11.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y11.TabIndex = 54
        Me.lblModbusTCP_Y11.Text = "Y11"
        '
        'lblModbusTCP_Y10
        '
        Me.lblModbusTCP_Y10.AutoSize = True
        Me.lblModbusTCP_Y10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y10.Location = New System.Drawing.Point(115, 115)
        Me.lblModbusTCP_Y10.Name = "lblModbusTCP_Y10"
        Me.lblModbusTCP_Y10.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y10.TabIndex = 53
        Me.lblModbusTCP_Y10.Text = "Y10"
        '
        'lblModbusTCP_Y09
        '
        Me.lblModbusTCP_Y09.AutoSize = True
        Me.lblModbusTCP_Y09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y09.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y09.Location = New System.Drawing.Point(115, 92)
        Me.lblModbusTCP_Y09.MaximumSize = New System.Drawing.Size(40, 22)
        Me.lblModbusTCP_Y09.Name = "lblModbusTCP_Y09"
        Me.lblModbusTCP_Y09.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y09.TabIndex = 52
        Me.lblModbusTCP_Y09.Text = "Y09"
        Me.lblModbusTCP_Y09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModbusTCP_Y08
        '
        Me.lblModbusTCP_Y08.AutoSize = True
        Me.lblModbusTCP_Y08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y08.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y08.Location = New System.Drawing.Point(81, 257)
        Me.lblModbusTCP_Y08.Name = "lblModbusTCP_Y08"
        Me.lblModbusTCP_Y08.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y08.TabIndex = 51
        Me.lblModbusTCP_Y08.Text = "Y08"
        '
        'lblModbusTCP_Y07
        '
        Me.lblModbusTCP_Y07.AutoSize = True
        Me.lblModbusTCP_Y07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y07.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y07.Location = New System.Drawing.Point(81, 233)
        Me.lblModbusTCP_Y07.Name = "lblModbusTCP_Y07"
        Me.lblModbusTCP_Y07.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y07.TabIndex = 50
        Me.lblModbusTCP_Y07.Text = "Y07"
        '
        'lblModbusTCP_Y06
        '
        Me.lblModbusTCP_Y06.AutoSize = True
        Me.lblModbusTCP_Y06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y06.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y06.Location = New System.Drawing.Point(81, 210)
        Me.lblModbusTCP_Y06.Name = "lblModbusTCP_Y06"
        Me.lblModbusTCP_Y06.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y06.TabIndex = 49
        Me.lblModbusTCP_Y06.Text = "Y06"
        '
        'lblModbusTCP_Y05
        '
        Me.lblModbusTCP_Y05.AutoSize = True
        Me.lblModbusTCP_Y05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y05.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y05.Location = New System.Drawing.Point(81, 186)
        Me.lblModbusTCP_Y05.Name = "lblModbusTCP_Y05"
        Me.lblModbusTCP_Y05.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y05.TabIndex = 48
        Me.lblModbusTCP_Y05.Text = "Y05"
        '
        'lblModbusTCP_Y04
        '
        Me.lblModbusTCP_Y04.AutoSize = True
        Me.lblModbusTCP_Y04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y04.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y04.Location = New System.Drawing.Point(81, 162)
        Me.lblModbusTCP_Y04.Name = "lblModbusTCP_Y04"
        Me.lblModbusTCP_Y04.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y04.TabIndex = 47
        Me.lblModbusTCP_Y04.Text = "Y04"
        '
        'lblModbusTCP_Y03
        '
        Me.lblModbusTCP_Y03.AutoSize = True
        Me.lblModbusTCP_Y03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y03.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y03.Location = New System.Drawing.Point(81, 138)
        Me.lblModbusTCP_Y03.Name = "lblModbusTCP_Y03"
        Me.lblModbusTCP_Y03.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y03.TabIndex = 46
        Me.lblModbusTCP_Y03.Text = "Y03"
        '
        'lblModbusTCP_Y02
        '
        Me.lblModbusTCP_Y02.AutoSize = True
        Me.lblModbusTCP_Y02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y02.Location = New System.Drawing.Point(81, 115)
        Me.lblModbusTCP_Y02.Name = "lblModbusTCP_Y02"
        Me.lblModbusTCP_Y02.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y02.TabIndex = 45
        Me.lblModbusTCP_Y02.Text = "Y02"
        '
        'lblModbusTCP_Y01
        '
        Me.lblModbusTCP_Y01.AutoSize = True
        Me.lblModbusTCP_Y01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y01.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y01.Location = New System.Drawing.Point(81, 92)
        Me.lblModbusTCP_Y01.Name = "lblModbusTCP_Y01"
        Me.lblModbusTCP_Y01.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y01.TabIndex = 44
        Me.lblModbusTCP_Y01.Text = "Y01"
        '
        'lblModbusTCP_Y16
        '
        Me.lblModbusTCP_Y16.AutoSize = True
        Me.lblModbusTCP_Y16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModbusTCP_Y16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModbusTCP_Y16.Location = New System.Drawing.Point(115, 257)
        Me.lblModbusTCP_Y16.Name = "lblModbusTCP_Y16"
        Me.lblModbusTCP_Y16.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y16.TabIndex = 43
        Me.lblModbusTCP_Y16.Text = "Y16"
        '
        'btnModbusTCP_Connect
        '
        Me.btnModbusTCP_Connect.Location = New System.Drawing.Point(6, 15)
        Me.btnModbusTCP_Connect.Name = "btnModbusTCP_Connect"
        Me.btnModbusTCP_Connect.Size = New System.Drawing.Size(61, 25)
        Me.btnModbusTCP_Connect.TabIndex = 41
        Me.btnModbusTCP_Connect.Text = "Connect"
        Me.btnModbusTCP_Connect.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(119, 45)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 26)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Port:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "502" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(4, 50)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 13)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "Address:"
        '
        'txtbMODBUS_TCP_IP_Address
        '
        Me.txtbMODBUS_TCP_IP_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbMODBUS_TCP_IP_Address.Location = New System.Drawing.Point(52, 46)
        Me.txtbMODBUS_TCP_IP_Address.Name = "txtbMODBUS_TCP_IP_Address"
        Me.txtbMODBUS_TCP_IP_Address.Size = New System.Drawing.Size(71, 22)
        Me.txtbMODBUS_TCP_IP_Address.TabIndex = 36
        Me.txtbMODBUS_TCP_IP_Address.Text = "10.60.3.11"
        '
        'timerModbusTCP1
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 688)
        Me.Controls.Add(Me.grpbxMODBUS_TCP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxINITIALIZE)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpbxCVSInsight_ST3A)
        Me.Controls.Add(Me.grpbxCVSInsight_ST2A)
        Me.Controls.Add(Me.grpbxCVSInsight_ST1B)
        Me.Controls.Add(Me.grpbxP2000)
        Me.Controls.Add(Me.grpbxGPIB_TEGAM)
        Me.Controls.Add(Me.grpbxBarcodeScannerST1A)
        Me.Controls.Add(Me.grpbxRS232)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HEV_Pkg_Inspection_CNTRL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpbxRS232.ResumeLayout(False)
        Me.grpbxBarcodeScannerST1A.ResumeLayout(False)
        Me.grpbxBarcodeScannerST1A.PerformLayout()
        Me.grpbxGPIB_TEGAM.ResumeLayout(False)
        Me.grpbxGPIB_TEGAM.PerformLayout()
        Me.grpbxP2000.ResumeLayout(False)
        Me.grpbxP2000.PerformLayout()
        Me.grpbxCVSInsight_ST1B.ResumeLayout(False)
        Me.grpbxCVSInsight_ST1B.PerformLayout()
        Me.grpbxCVSInsight_ST2A.ResumeLayout(False)
        Me.grpbxCVSInsight_ST2A.PerformLayout()
        Me.grpbxCVSInsight_ST3A.ResumeLayout(False)
        Me.grpbxCVSInsight_ST3A.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpbxINITIALIZE.ResumeLayout(False)
        Me.grpbxINITIALIZE.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxMODBUS_TCP.ResumeLayout(False)
        Me.grpbxMODBUS_TCP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOPEN As System.Windows.Forms.Button
    Friend WithEvents btnCLOSE As System.Windows.Forms.Button
    Friend WithEvents cbPrimaryAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbSecondaryAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbBoardID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnREAD As System.Windows.Forms.Button
    Friend WithEvents txtbReadGPIB As System.Windows.Forms.TextBox
    Friend WithEvents txtbWriteGPIB As System.Windows.Forms.TextBox
    Friend WithEvents btnWRITE As System.Windows.Forms.Button
    Friend WithEvents btnTERMINATE As System.Windows.Forms.Button
    Friend WithEvents btnRS232Test As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnTRIGGER As System.Windows.Forms.Button
    Friend WithEvents btnOpenBarcodeDeviceST1A As System.Windows.Forms.Button
    Friend WithEvents txtbBCDevice_ReadST1A As System.Windows.Forms.TextBox
    Friend WithEvents btnBCDevice_LEDsOFFST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDGreenONST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDRedONST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_BeepST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDeviceEventSubscribeST1A As System.Windows.Forms.Button
    Friend WithEvents btnCloseBarcodeDeviceST1A As System.Windows.Forms.Button
    Friend WithEvents btnFTPdownload As System.Windows.Forms.Button
    Friend WithEvents txtbFTPUpJobST1B As System.Windows.Forms.TextBox
    Friend WithEvents btnFTPUpJobST1B As System.Windows.Forms.Button
    Friend WithEvents CvsInSightDisplay1 As Cognex.InSight.Controls.Display.CvsInSightDisplay
    Friend WithEvents btnCONNECTCvsInSightDisplay1 As System.Windows.Forms.Button
    Friend WithEvents txtbADDRESSCvsInSightDisplay1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbUSERCvsInSightDisplay1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbPASSWORDCvsInSightDisplay1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDISCONNECTCvsInSightDisplay1 As System.Windows.Forms.Button
    Friend WithEvents btnTRIGGERCvsInSightDisplay1 As System.Windows.Forms.Button
    Friend WithEvents btnLOADFILECvsInSightDisplay1 As System.Windows.Forms.Button
    Friend WithEvents btnGETPASSCvsInSightDisplay1 As System.Windows.Forms.Button
    Friend WithEvents btnOpenTelnetClientST1B As System.Windows.Forms.Button
    Friend WithEvents btnCloseTelnetClientST1B As System.Windows.Forms.Button
    Friend WithEvents txtbACKCvsInSightDisplay1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbRETCvsInSightDisplay1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STARTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpbxRS232 As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxBarcodeScannerST1A As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxGPIB_TEGAM As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxP2000 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents grpbxCVSInsight_ST1B As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpbxCVSInsight_ST2A As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnFTPUpJobST2A As System.Windows.Forms.Button
    Friend WithEvents txtbFTPUpJobST2A As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnCONNECTCvsInSightDisplay2 As System.Windows.Forms.Button
    Friend WithEvents txtbRETCvsInSightDisplay2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbADDRESSCvsInSightDisplay2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtbACKCvsInSightDisplay2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnCloseTelnetClientST2A As System.Windows.Forms.Button
    Friend WithEvents txtbUSERCvsInSightDisplay2 As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenTelnetClientST2A As System.Windows.Forms.Button
    Friend WithEvents txtbPASSWORDCvsInSightDisplay2 As System.Windows.Forms.TextBox
    Friend WithEvents btnGETPASSCvsInSightDisplay2 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnLOADFILECvsInSightDisplay2 As System.Windows.Forms.Button
    Friend WithEvents btnTRIGGERCvsInSightDisplay2 As System.Windows.Forms.Button
    Friend WithEvents btnDISCONNECTCvsInSightDisplay2 As System.Windows.Forms.Button
    Friend WithEvents CvsInSightDisplay2 As Cognex.InSight.Controls.Display.CvsInSightDisplay
    Friend WithEvents grpbxCVSInsight_ST3A As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnFTPUpJobST3A As System.Windows.Forms.Button
    Friend WithEvents txtbFTPUpJobST3A As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnCONNECTCvsInSightDisplay3 As System.Windows.Forms.Button
    Friend WithEvents txtbRETCvsInSightDisplay3 As System.Windows.Forms.TextBox
    Friend WithEvents txtbADDRESSCvsInSightDisplay3 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtbACKCvsInSightDisplay3 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnCloseTelnetClientST3A As System.Windows.Forms.Button
    Friend WithEvents txtbUSERCvsInSightDisplay3 As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenTelnetClientST3A As System.Windows.Forms.Button
    Friend WithEvents txtbPASSWORDCvsInSightDisplay3 As System.Windows.Forms.TextBox
    Friend WithEvents btnGETPASSCvsInSightDisplay3 As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnLOADFILECvsInSightDisplay3 As System.Windows.Forms.Button
    Friend WithEvents btnTRIGGERCvsInSightDisplay3 As System.Windows.Forms.Button
    Friend WithEvents btnDISCONNECTCvsInSightDisplay3 As System.Windows.Forms.Button
    Friend WithEvents CvsInSightDisplay3 As Cognex.InSight.Controls.Display.CvsInSightDisplay
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents grpbxINITIALIZE As System.Windows.Forms.GroupBox
    Friend WithEvents btnINI_FileSelection As System.Windows.Forms.Button
    Friend WithEvents txtbINI_FilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkbTEGAMGPIBInterface As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkbSymbolBarcodeST1A As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnLoadINI As System.Windows.Forms.Button
    Friend WithEvents btnStartSelectedPeripherals As System.Windows.Forms.Button
    Friend WithEvents chkbSymbolBarcodeST3A As System.Windows.Forms.CheckBox
    Friend WithEvents chkbCOGNEXInSightST3A As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chkbScaleRS232 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbP2000 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbCOGNEXInSightST2A As System.Windows.Forms.CheckBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents chkbCOGNEXInSightST1B As System.Windows.Forms.CheckBox
    Friend WithEvents chkbZebra110Xi4_ST1A As System.Windows.Forms.CheckBox
    Friend WithEvents chkbZebra110Xi4_ST3A As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnOpenBarcodeDeviceST3A As System.Windows.Forms.Button
    Friend WithEvents txtbBCDevice_ReadST3A As System.Windows.Forms.TextBox
    Friend WithEvents btnBCDevice_LEDGreenONST3A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDRedONST3A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDsOFFST3A As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnBCDeviceEventSubscribeST3A As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents grpbxMODBUS_TCP As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtbMODBUS_TCP_IP_Address As System.Windows.Forms.TextBox
    Friend WithEvents btnModbusTCP_Connect As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnModbusTCP_Refresh As System.Windows.Forms.Button
    Friend WithEvents lblModbusTCP_Y15 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y14 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y13 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y12 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y11 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y10 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y09 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y08 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y07 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y06 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y05 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y04 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y03 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y02 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y01 As System.Windows.Forms.Label
    Friend WithEvents lblModbusTCP_Y16 As System.Windows.Forms.Label
    Friend WithEvents chkbModbusTCP_X15 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X14 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X13 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X12 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X11 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X10 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X09 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X08 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X07 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X06 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X05 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X04 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X03 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X02 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X01 As System.Windows.Forms.CheckBox
    Friend WithEvents chkbModbusTCP_X16 As System.Windows.Forms.CheckBox
    Friend WithEvents btnModbusTCP_Disconnect As System.Windows.Forms.Button
    Friend WithEvents timerModbusTCP1 As System.Windows.Forms.Timer
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label

End Class
