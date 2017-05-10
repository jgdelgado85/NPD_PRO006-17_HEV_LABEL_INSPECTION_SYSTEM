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
        Me.btnGPIB_OPEN = New System.Windows.Forms.Button()
        Me.btnGPIB_CLOSE = New System.Windows.Forms.Button()
        Me.cbPrimaryAddress = New System.Windows.Forms.ComboBox()
        Me.cbSecondaryAddress = New System.Windows.Forms.ComboBox()
        Me.cbBoardID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGPIB_READ = New System.Windows.Forms.Button()
        Me.txtbReadGPIB = New System.Windows.Forms.TextBox()
        Me.txtbWriteGPIB = New System.Windows.Forms.TextBox()
        Me.btnGPIB_WRITE = New System.Windows.Forms.Button()
        Me.btnGPIB_TERMINATE = New System.Windows.Forms.Button()
        Me.btnRS232Write = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnGPIB_TRIGGER = New System.Windows.Forms.Button()
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
        Me.btnRS232Read = New System.Windows.Forms.Button()
        Me.grpbxBarcodeScannerST1A = New System.Windows.Forms.GroupBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.grpbxGPIB_TEGAM = New System.Windows.Forms.GroupBox()
        Me.prgsbarSleep1 = New System.Windows.Forms.ProgressBar()
        Me.btnGPIB_INIT = New System.Windows.Forms.Button()
        Me.btnGPIB_MEASURE = New System.Windows.Forms.Button()
        Me.txtbUPPERresistanceLIMIT = New System.Windows.Forms.TextBox()
        Me.txtbRESISTANCE = New System.Windows.Forms.TextBox()
        Me.txtbLOWERresistanceLIMIT = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.txtbINI_FilePath = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpgCOGNEX_Insight = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnStartSelectedPeripherals = New System.Windows.Forms.Button()
        Me.grpbxINIT = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtbLOGfolder = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtbPRNfolder = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtbPRINTERstatus = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtbOPERATOR1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtbPART_NUMBER = New System.Windows.Forms.TextBox()
        Me.txtbBARCODEstatus = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtbTEGAMstatus = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtbDBfilepath = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtbSHOP_PACK = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.bkgworkGPIB_SLEEP = New System.ComponentModel.BackgroundWorker()
        Me.grpbxZEBRA1 = New System.Windows.Forms.GroupBox()
        Me.txtbDATECODE = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtbPRN_TEMPLATE = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtbZEBRA_FUSE_IPaddress = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.btnZEBRA_FUSE_print = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpbxRS232.SuspendLayout()
        Me.grpbxBarcodeScannerST1A.SuspendLayout()
        Me.grpbxGPIB_TEGAM.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.grpbxINITIALIZE.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxMODBUS_TCP.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabpgCOGNEX_Insight.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpbxINIT.SuspendLayout()
        Me.grpbxZEBRA1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGPIB_OPEN
        '
        Me.btnGPIB_OPEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_OPEN.Location = New System.Drawing.Point(7, 89)
        Me.btnGPIB_OPEN.Name = "btnGPIB_OPEN"
        Me.btnGPIB_OPEN.Size = New System.Drawing.Size(60, 44)
        Me.btnGPIB_OPEN.TabIndex = 0
        Me.btnGPIB_OPEN.Text = "Open GPIB"
        Me.btnGPIB_OPEN.UseVisualStyleBackColor = True
        '
        'btnGPIB_CLOSE
        '
        Me.btnGPIB_CLOSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_CLOSE.Location = New System.Drawing.Point(135, 90)
        Me.btnGPIB_CLOSE.Name = "btnGPIB_CLOSE"
        Me.btnGPIB_CLOSE.Size = New System.Drawing.Size(60, 44)
        Me.btnGPIB_CLOSE.TabIndex = 1
        Me.btnGPIB_CLOSE.Text = "Close GPIB"
        Me.btnGPIB_CLOSE.UseVisualStyleBackColor = True
        '
        'cbPrimaryAddress
        '
        Me.cbPrimaryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPrimaryAddress.FormattingEnabled = True
        Me.cbPrimaryAddress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbPrimaryAddress.Location = New System.Drawing.Point(73, 50)
        Me.cbPrimaryAddress.Name = "cbPrimaryAddress"
        Me.cbPrimaryAddress.Size = New System.Drawing.Size(55, 33)
        Me.cbPrimaryAddress.TabIndex = 2
        Me.cbPrimaryAddress.Text = "12"
        '
        'cbSecondaryAddress
        '
        Me.cbSecondaryAddress.Enabled = False
        Me.cbSecondaryAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSecondaryAddress.FormattingEnabled = True
        Me.cbSecondaryAddress.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbSecondaryAddress.Location = New System.Drawing.Point(139, 50)
        Me.cbSecondaryAddress.Name = "cbSecondaryAddress"
        Me.cbSecondaryAddress.Size = New System.Drawing.Size(55, 33)
        Me.cbSecondaryAddress.TabIndex = 3
        Me.cbSecondaryAddress.Text = "0"
        '
        'cbBoardID
        '
        Me.cbBoardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBoardID.FormattingEnabled = True
        Me.cbBoardID.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbBoardID.Location = New System.Drawing.Point(9, 50)
        Me.cbBoardID.Name = "cbBoardID"
        Me.cbBoardID.Size = New System.Drawing.Size(55, 33)
        Me.cbBoardID.TabIndex = 4
        Me.cbBoardID.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Board ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Pr.Add:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sec.Add:"
        '
        'btnGPIB_READ
        '
        Me.btnGPIB_READ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_READ.Location = New System.Drawing.Point(134, 191)
        Me.btnGPIB_READ.Name = "btnGPIB_READ"
        Me.btnGPIB_READ.Size = New System.Drawing.Size(60, 30)
        Me.btnGPIB_READ.TabIndex = 8
        Me.btnGPIB_READ.Text = "Read"
        Me.btnGPIB_READ.UseVisualStyleBackColor = True
        '
        'txtbReadGPIB
        '
        Me.txtbReadGPIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbReadGPIB.Location = New System.Drawing.Point(7, 192)
        Me.txtbReadGPIB.Name = "txtbReadGPIB"
        Me.txtbReadGPIB.ReadOnly = True
        Me.txtbReadGPIB.Size = New System.Drawing.Size(121, 29)
        Me.txtbReadGPIB.TabIndex = 9
        '
        'txtbWriteGPIB
        '
        Me.txtbWriteGPIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbWriteGPIB.Location = New System.Drawing.Point(7, 156)
        Me.txtbWriteGPIB.Name = "txtbWriteGPIB"
        Me.txtbWriteGPIB.ReadOnly = True
        Me.txtbWriteGPIB.Size = New System.Drawing.Size(57, 29)
        Me.txtbWriteGPIB.TabIndex = 10
        Me.txtbWriteGPIB.Text = "Q1X"
        '
        'btnGPIB_WRITE
        '
        Me.btnGPIB_WRITE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_WRITE.Location = New System.Drawing.Point(70, 155)
        Me.btnGPIB_WRITE.Name = "btnGPIB_WRITE"
        Me.btnGPIB_WRITE.Size = New System.Drawing.Size(60, 30)
        Me.btnGPIB_WRITE.TabIndex = 11
        Me.btnGPIB_WRITE.Text = "Write"
        Me.btnGPIB_WRITE.UseVisualStyleBackColor = True
        '
        'btnGPIB_TERMINATE
        '
        Me.btnGPIB_TERMINATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_TERMINATE.Location = New System.Drawing.Point(70, 90)
        Me.btnGPIB_TERMINATE.Name = "btnGPIB_TERMINATE"
        Me.btnGPIB_TERMINATE.Size = New System.Drawing.Size(60, 44)
        Me.btnGPIB_TERMINATE.TabIndex = 12
        Me.btnGPIB_TERMINATE.Text = "Term. Asynch. "
        Me.btnGPIB_TERMINATE.UseVisualStyleBackColor = True
        '
        'btnRS232Write
        '
        Me.btnRS232Write.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRS232Write.Location = New System.Drawing.Point(42, 108)
        Me.btnRS232Write.Name = "btnRS232Write"
        Me.btnRS232Write.Size = New System.Drawing.Size(99, 32)
        Me.btnRS232Write.TabIndex = 13
        Me.btnRS232Write.Text = "Write"
        Me.btnRS232Write.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'btnGPIB_TRIGGER
        '
        Me.btnGPIB_TRIGGER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_TRIGGER.Location = New System.Drawing.Point(135, 155)
        Me.btnGPIB_TRIGGER.Name = "btnGPIB_TRIGGER"
        Me.btnGPIB_TRIGGER.Size = New System.Drawing.Size(60, 30)
        Me.btnGPIB_TRIGGER.TabIndex = 14
        Me.btnGPIB_TRIGGER.Text = "Trig."
        Me.btnGPIB_TRIGGER.UseVisualStyleBackColor = True
        '
        'btnOpenBarcodeDeviceST1A
        '
        Me.btnOpenBarcodeDeviceST1A.Location = New System.Drawing.Point(4, 40)
        Me.btnOpenBarcodeDeviceST1A.Name = "btnOpenBarcodeDeviceST1A"
        Me.btnOpenBarcodeDeviceST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnOpenBarcodeDeviceST1A.TabIndex = 15
        Me.btnOpenBarcodeDeviceST1A.Text = "Open"
        Me.btnOpenBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'txtbBCDevice_ReadST1A
        '
        Me.txtbBCDevice_ReadST1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbBCDevice_ReadST1A.Location = New System.Drawing.Point(4, 149)
        Me.txtbBCDevice_ReadST1A.Multiline = True
        Me.txtbBCDevice_ReadST1A.Name = "txtbBCDevice_ReadST1A"
        Me.txtbBCDevice_ReadST1A.ReadOnly = True
        Me.txtbBCDevice_ReadST1A.Size = New System.Drawing.Size(140, 25)
        Me.txtbBCDevice_ReadST1A.TabIndex = 16
        Me.txtbBCDevice_ReadST1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBCDevice_LEDsOFFST1A
        '
        Me.btnBCDevice_LEDsOFFST1A.Location = New System.Drawing.Point(100, 109)
        Me.btnBCDevice_LEDsOFFST1A.Name = "btnBCDevice_LEDsOFFST1A"
        Me.btnBCDevice_LEDsOFFST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDsOFFST1A.TabIndex = 17
        Me.btnBCDevice_LEDsOFFST1A.Text = "ALL OFF"
        Me.btnBCDevice_LEDsOFFST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDGreenONST1A
        '
        Me.btnBCDevice_LEDGreenONST1A.Location = New System.Drawing.Point(4, 109)
        Me.btnBCDevice_LEDGreenONST1A.Name = "btnBCDevice_LEDGreenONST1A"
        Me.btnBCDevice_LEDGreenONST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDGreenONST1A.TabIndex = 18
        Me.btnBCDevice_LEDGreenONST1A.Text = "Green ON"
        Me.btnBCDevice_LEDGreenONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDRedONST1A
        '
        Me.btnBCDevice_LEDRedONST1A.Location = New System.Drawing.Point(52, 109)
        Me.btnBCDevice_LEDRedONST1A.Name = "btnBCDevice_LEDRedONST1A"
        Me.btnBCDevice_LEDRedONST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDRedONST1A.TabIndex = 19
        Me.btnBCDevice_LEDRedONST1A.Text = "Red ON"
        Me.btnBCDevice_LEDRedONST1A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_BeepST1A
        '
        Me.btnBCDevice_BeepST1A.Location = New System.Drawing.Point(100, 84)
        Me.btnBCDevice_BeepST1A.Name = "btnBCDevice_BeepST1A"
        Me.btnBCDevice_BeepST1A.Size = New System.Drawing.Size(45, 19)
        Me.btnBCDevice_BeepST1A.TabIndex = 21
        Me.btnBCDevice_BeepST1A.Text = "BEEP"
        Me.btnBCDevice_BeepST1A.UseVisualStyleBackColor = True
        '
        'btnBCDeviceEventSubscribeST1A
        '
        Me.btnBCDeviceEventSubscribeST1A.Location = New System.Drawing.Point(52, 40)
        Me.btnBCDeviceEventSubscribeST1A.Name = "btnBCDeviceEventSubscribeST1A"
        Me.btnBCDeviceEventSubscribeST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDeviceEventSubscribeST1A.TabIndex = 22
        Me.btnBCDeviceEventSubscribeST1A.Text = "Event Subs."
        Me.btnBCDeviceEventSubscribeST1A.UseVisualStyleBackColor = True
        '
        'btnCloseBarcodeDeviceST1A
        '
        Me.btnCloseBarcodeDeviceST1A.Location = New System.Drawing.Point(101, 40)
        Me.btnCloseBarcodeDeviceST1A.Name = "btnCloseBarcodeDeviceST1A"
        Me.btnCloseBarcodeDeviceST1A.Size = New System.Drawing.Size(45, 34)
        Me.btnCloseBarcodeDeviceST1A.TabIndex = 23
        Me.btnCloseBarcodeDeviceST1A.Text = "Close"
        Me.btnCloseBarcodeDeviceST1A.UseVisualStyleBackColor = True
        '
        'btnFTPUpJobST1B
        '
        Me.btnFTPUpJobST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPUpJobST1B.Location = New System.Drawing.Point(706, 6)
        Me.btnFTPUpJobST1B.Name = "btnFTPUpJobST1B"
        Me.btnFTPUpJobST1B.Size = New System.Drawing.Size(100, 30)
        Me.btnFTPUpJobST1B.TabIndex = 28
        Me.btnFTPUpJobST1B.Text = "FTP Upload"
        Me.btnFTPUpJobST1B.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST1B
        '
        Me.txtbFTPUpJobST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST1B.Location = New System.Drawing.Point(250, 6)
        Me.txtbFTPUpJobST1B.Name = "txtbFTPUpJobST1B"
        Me.txtbFTPUpJobST1B.ReadOnly = True
        Me.txtbFTPUpJobST1B.Size = New System.Drawing.Size(450, 31)
        Me.txtbFTPUpJobST1B.TabIndex = 29
        Me.txtbFTPUpJobST1B.Text = "..."
        '
        'CvsInSightDisplay1
        '
        Me.CvsInSightDisplay1.AutoSize = True
        Me.CvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay1.DialogIcon = Nothing
        Me.CvsInSightDisplay1.GridOpacity = 0R
        Me.CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay1.Location = New System.Drawing.Point(6, 120)
        Me.CvsInSightDisplay1.Name = "CvsInSightDisplay1"
        Me.CvsInSightDisplay1.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay1.Size = New System.Drawing.Size(800, 600)
        Me.CvsInSightDisplay1.TabIndex = 33
        '
        'btnCONNECTCvsInSightDisplay1
        '
        Me.btnCONNECTCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCONNECTCvsInSightDisplay1.Location = New System.Drawing.Point(6, 87)
        Me.btnCONNECTCvsInSightDisplay1.Name = "btnCONNECTCvsInSightDisplay1"
        Me.btnCONNECTCvsInSightDisplay1.Size = New System.Drawing.Size(100, 30)
        Me.btnCONNECTCvsInSightDisplay1.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay1.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'txtbADDRESSCvsInSightDisplay1
        '
        Me.txtbADDRESSCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay1.Location = New System.Drawing.Point(184, 40)
        Me.txtbADDRESSCvsInSightDisplay1.Name = "txtbADDRESSCvsInSightDisplay1"
        Me.txtbADDRESSCvsInSightDisplay1.ReadOnly = True
        Me.txtbADDRESSCvsInSightDisplay1.Size = New System.Drawing.Size(162, 31)
        Me.txtbADDRESSCvsInSightDisplay1.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay1.Text = "xxx.xxx.xxx.xxx"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(120, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(350, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "User:"
        '
        'txtbUSERCvsInSightDisplay1
        '
        Me.txtbUSERCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay1.Location = New System.Drawing.Point(391, 40)
        Me.txtbUSERCvsInSightDisplay1.Name = "txtbUSERCvsInSightDisplay1"
        Me.txtbUSERCvsInSightDisplay1.ReadOnly = True
        Me.txtbUSERCvsInSightDisplay1.Size = New System.Drawing.Size(83, 31)
        Me.txtbUSERCvsInSightDisplay1.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay1.Text = "???"
        '
        'txtbPASSWORDCvsInSightDisplay1
        '
        Me.txtbPASSWORDCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay1.Location = New System.Drawing.Point(549, 40)
        Me.txtbPASSWORDCvsInSightDisplay1.Name = "txtbPASSWORDCvsInSightDisplay1"
        Me.txtbPASSWORDCvsInSightDisplay1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay1.ReadOnly = True
        Me.txtbPASSWORDCvsInSightDisplay1.Size = New System.Drawing.Size(43, 31)
        Me.txtbPASSWORDCvsInSightDisplay1.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(476, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Password:"
        '
        'btnDISCONNECTCvsInSightDisplay1
        '
        Me.btnDISCONNECTCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDISCONNECTCvsInSightDisplay1.Location = New System.Drawing.Point(706, 87)
        Me.btnDISCONNECTCvsInSightDisplay1.Name = "btnDISCONNECTCvsInSightDisplay1"
        Me.btnDISCONNECTCvsInSightDisplay1.Size = New System.Drawing.Size(100, 30)
        Me.btnDISCONNECTCvsInSightDisplay1.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay1.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay1
        '
        Me.btnTRIGGERCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTRIGGERCvsInSightDisplay1.Location = New System.Drawing.Point(216, 87)
        Me.btnTRIGGERCvsInSightDisplay1.Name = "btnTRIGGERCvsInSightDisplay1"
        Me.btnTRIGGERCvsInSightDisplay1.Size = New System.Drawing.Size(100, 30)
        Me.btnTRIGGERCvsInSightDisplay1.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay1.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnLOADFILECvsInSightDisplay1
        '
        Me.btnLOADFILECvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOADFILECvsInSightDisplay1.Location = New System.Drawing.Point(111, 87)
        Me.btnLOADFILECvsInSightDisplay1.Name = "btnLOADFILECvsInSightDisplay1"
        Me.btnLOADFILECvsInSightDisplay1.Size = New System.Drawing.Size(100, 30)
        Me.btnLOADFILECvsInSightDisplay1.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay1.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnGETPASSCvsInSightDisplay1
        '
        Me.btnGETPASSCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGETPASSCvsInSightDisplay1.Location = New System.Drawing.Point(321, 87)
        Me.btnGETPASSCvsInSightDisplay1.Name = "btnGETPASSCvsInSightDisplay1"
        Me.btnGETPASSCvsInSightDisplay1.Size = New System.Drawing.Size(111, 30)
        Me.btnGETPASSCvsInSightDisplay1.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay1.Text = "GV S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay1.UseVisualStyleBackColor = True
        '
        'btnOpenTelnetClientST1B
        '
        Me.btnOpenTelnetClientST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenTelnetClientST1B.Location = New System.Drawing.Point(600, 41)
        Me.btnOpenTelnetClientST1B.Name = "btnOpenTelnetClientST1B"
        Me.btnOpenTelnetClientST1B.Size = New System.Drawing.Size(100, 30)
        Me.btnOpenTelnetClientST1B.TabIndex = 47
        Me.btnOpenTelnetClientST1B.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST1B.UseVisualStyleBackColor = True
        '
        'btnCloseTelnetClientST1B
        '
        Me.btnCloseTelnetClientST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseTelnetClientST1B.Location = New System.Drawing.Point(706, 41)
        Me.btnCloseTelnetClientST1B.Name = "btnCloseTelnetClientST1B"
        Me.btnCloseTelnetClientST1B.Size = New System.Drawing.Size(100, 30)
        Me.btnCloseTelnetClientST1B.TabIndex = 48
        Me.btnCloseTelnetClientST1B.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST1B.UseVisualStyleBackColor = True
        '
        'txtbACKCvsInSightDisplay1
        '
        Me.txtbACKCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay1.Location = New System.Drawing.Point(516, 87)
        Me.txtbACKCvsInSightDisplay1.Name = "txtbACKCvsInSightDisplay1"
        Me.txtbACKCvsInSightDisplay1.ReadOnly = True
        Me.txtbACKCvsInSightDisplay1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay1.Size = New System.Drawing.Size(40, 31)
        Me.txtbACKCvsInSightDisplay1.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(443, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "CMD ACK:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(567, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "RTN VALUE:"
        '
        'txtbRETCvsInSightDisplay1
        '
        Me.txtbRETCvsInSightDisplay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay1.Location = New System.Drawing.Point(660, 87)
        Me.txtbRETCvsInSightDisplay1.Name = "txtbRETCvsInSightDisplay1"
        Me.txtbRETCvsInSightDisplay1.ReadOnly = True
        Me.txtbRETCvsInSightDisplay1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay1.Size = New System.Drawing.Size(40, 31)
        Me.txtbRETCvsInSightDisplay1.TabIndex = 51
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1912, 24)
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
        Me.grpbxRS232.Controls.Add(Me.btnRS232Read)
        Me.grpbxRS232.Controls.Add(Me.btnRS232Write)
        Me.grpbxRS232.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxRS232.Location = New System.Drawing.Point(1751, 224)
        Me.grpbxRS232.Name = "grpbxRS232"
        Me.grpbxRS232.Size = New System.Drawing.Size(149, 185)
        Me.grpbxRS232.TabIndex = 54
        Me.grpbxRS232.TabStop = False
        Me.grpbxRS232.Text = "Scale RS-232"
        '
        'btnRS232Read
        '
        Me.btnRS232Read.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRS232Read.Location = New System.Drawing.Point(42, 143)
        Me.btnRS232Read.Name = "btnRS232Read"
        Me.btnRS232Read.Size = New System.Drawing.Size(99, 32)
        Me.btnRS232Read.TabIndex = 14
        Me.btnRS232Read.Text = "Read"
        Me.btnRS232Read.UseVisualStyleBackColor = True
        '
        'grpbxBarcodeScannerST1A
        '
        Me.grpbxBarcodeScannerST1A.Controls.Add(Me.Label40)
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
        Me.grpbxBarcodeScannerST1A.Location = New System.Drawing.Point(463, 558)
        Me.grpbxBarcodeScannerST1A.Name = "grpbxBarcodeScannerST1A"
        Me.grpbxBarcodeScannerST1A.Size = New System.Drawing.Size(149, 180)
        Me.grpbxBarcodeScannerST1A.TabIndex = 55
        Me.grpbxBarcodeScannerST1A.TabStop = False
        Me.grpbxBarcodeScannerST1A.Text = "Symbol Barcode ST1A"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(3, 87)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 13)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "LEDs and Beep"
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
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.prgsbarSleep1)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_INIT)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_MEASURE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbUPPERresistanceLIMIT)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbRESISTANCE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbLOWERresistanceLIMIT)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label45)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label44)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label43)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label42)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label28)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_OPEN)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_CLOSE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbPrimaryAddress)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbSecondaryAddress)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.cbBoardID)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label1)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label2)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.Label3)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_READ)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbReadGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.txtbWriteGPIB)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_WRITE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_TERMINATE)
        Me.grpbxGPIB_TEGAM.Controls.Add(Me.btnGPIB_TRIGGER)
        Me.grpbxGPIB_TEGAM.Enabled = False
        Me.grpbxGPIB_TEGAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxGPIB_TEGAM.Location = New System.Drawing.Point(463, 29)
        Me.grpbxGPIB_TEGAM.Name = "grpbxGPIB_TEGAM"
        Me.grpbxGPIB_TEGAM.Size = New System.Drawing.Size(200, 523)
        Me.grpbxGPIB_TEGAM.TabIndex = 56
        Me.grpbxGPIB_TEGAM.TabStop = False
        Me.grpbxGPIB_TEGAM.Text = "TEGAM 1750 ST1A"
        '
        'prgsbarSleep1
        '
        Me.prgsbarSleep1.Location = New System.Drawing.Point(7, 268)
        Me.prgsbarSleep1.Name = "prgsbarSleep1"
        Me.prgsbarSleep1.Size = New System.Drawing.Size(187, 10)
        Me.prgsbarSleep1.TabIndex = 64
        '
        'btnGPIB_INIT
        '
        Me.btnGPIB_INIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_INIT.Location = New System.Drawing.Point(6, 227)
        Me.btnGPIB_INIT.Name = "btnGPIB_INIT"
        Me.btnGPIB_INIT.Size = New System.Drawing.Size(189, 37)
        Me.btnGPIB_INIT.TabIndex = 63
        Me.btnGPIB_INIT.Text = "INITIALIZE TEGAM 1750"
        Me.btnGPIB_INIT.UseVisualStyleBackColor = True
        '
        'btnGPIB_MEASURE
        '
        Me.btnGPIB_MEASURE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPIB_MEASURE.Location = New System.Drawing.Point(5, 478)
        Me.btnGPIB_MEASURE.Name = "btnGPIB_MEASURE"
        Me.btnGPIB_MEASURE.Size = New System.Drawing.Size(190, 40)
        Me.btnGPIB_MEASURE.TabIndex = 62
        Me.btnGPIB_MEASURE.Text = "TAKE MEASURENT"
        Me.btnGPIB_MEASURE.UseVisualStyleBackColor = True
        '
        'txtbUPPERresistanceLIMIT
        '
        Me.txtbUPPERresistanceLIMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUPPERresistanceLIMIT.Location = New System.Drawing.Point(6, 439)
        Me.txtbUPPERresistanceLIMIT.Name = "txtbUPPERresistanceLIMIT"
        Me.txtbUPPERresistanceLIMIT.ReadOnly = True
        Me.txtbUPPERresistanceLIMIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbUPPERresistanceLIMIT.Size = New System.Drawing.Size(188, 35)
        Me.txtbUPPERresistanceLIMIT.TabIndex = 61
        Me.txtbUPPERresistanceLIMIT.Text = "123.456"
        '
        'txtbRESISTANCE
        '
        Me.txtbRESISTANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRESISTANCE.Location = New System.Drawing.Point(6, 351)
        Me.txtbRESISTANCE.Name = "txtbRESISTANCE"
        Me.txtbRESISTANCE.ReadOnly = True
        Me.txtbRESISTANCE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRESISTANCE.Size = New System.Drawing.Size(189, 62)
        Me.txtbRESISTANCE.TabIndex = 60
        Me.txtbRESISTANCE.Text = "123.456"
        '
        'txtbLOWERresistanceLIMIT
        '
        Me.txtbLOWERresistanceLIMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbLOWERresistanceLIMIT.Location = New System.Drawing.Point(6, 297)
        Me.txtbLOWERresistanceLIMIT.Name = "txtbLOWERresistanceLIMIT"
        Me.txtbLOWERresistanceLIMIT.ReadOnly = True
        Me.txtbLOWERresistanceLIMIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbLOWERresistanceLIMIT.Size = New System.Drawing.Size(189, 35)
        Me.txtbLOWERresistanceLIMIT.TabIndex = 59
        Me.txtbLOWERresistanceLIMIT.Text = "123.456"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(4, 420)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(173, 13)
        Me.Label45.TabIndex = 58
        Me.Label45.Text = "RESISTANCE (Lower Limit) : "
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(6, 281)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(173, 13)
        Me.Label44.TabIndex = 57
        Me.Label44.Text = "RESISTANCE (Upper Limit) : "
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(4, 335)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(164, 13)
        Me.Label43.TabIndex = 56
        Me.Label43.Text = "RESISTANCE (Measured) : "
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(4, 136)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(124, 16)
        Me.Label42.TabIndex = 55
        Me.Label42.Text = "GPIB Commands"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "CVS InSight Display"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Telnet Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Upload *.job File to IS7200 ST1B :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "CVS InSight Display"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Telnet Client"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(242, 16)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Upload *.job File to IS7200 ST2A :"
        '
        'btnFTPUpJobST2A
        '
        Me.btnFTPUpJobST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPUpJobST2A.Location = New System.Drawing.Point(706, 6)
        Me.btnFTPUpJobST2A.Name = "btnFTPUpJobST2A"
        Me.btnFTPUpJobST2A.Size = New System.Drawing.Size(100, 30)
        Me.btnFTPUpJobST2A.TabIndex = 28
        Me.btnFTPUpJobST2A.Text = "FTP Upload"
        Me.btnFTPUpJobST2A.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST2A
        '
        Me.txtbFTPUpJobST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST2A.Location = New System.Drawing.Point(250, 6)
        Me.txtbFTPUpJobST2A.Name = "txtbFTPUpJobST2A"
        Me.txtbFTPUpJobST2A.ReadOnly = True
        Me.txtbFTPUpJobST2A.Size = New System.Drawing.Size(450, 31)
        Me.txtbFTPUpJobST2A.TabIndex = 29
        Me.txtbFTPUpJobST2A.Text = "..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(567, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 16)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "RTN VALUE:"
        '
        'btnCONNECTCvsInSightDisplay2
        '
        Me.btnCONNECTCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCONNECTCvsInSightDisplay2.Location = New System.Drawing.Point(6, 87)
        Me.btnCONNECTCvsInSightDisplay2.Name = "btnCONNECTCvsInSightDisplay2"
        Me.btnCONNECTCvsInSightDisplay2.Size = New System.Drawing.Size(100, 30)
        Me.btnCONNECTCvsInSightDisplay2.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay2.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'txtbRETCvsInSightDisplay2
        '
        Me.txtbRETCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay2.Location = New System.Drawing.Point(660, 87)
        Me.txtbRETCvsInSightDisplay2.Name = "txtbRETCvsInSightDisplay2"
        Me.txtbRETCvsInSightDisplay2.ReadOnly = True
        Me.txtbRETCvsInSightDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay2.Size = New System.Drawing.Size(40, 31)
        Me.txtbRETCvsInSightDisplay2.TabIndex = 51
        '
        'txtbADDRESSCvsInSightDisplay2
        '
        Me.txtbADDRESSCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay2.Location = New System.Drawing.Point(184, 40)
        Me.txtbADDRESSCvsInSightDisplay2.Name = "txtbADDRESSCvsInSightDisplay2"
        Me.txtbADDRESSCvsInSightDisplay2.ReadOnly = True
        Me.txtbADDRESSCvsInSightDisplay2.Size = New System.Drawing.Size(162, 31)
        Me.txtbADDRESSCvsInSightDisplay2.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay2.Text = "xxx.xxx.xxx.xxx"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(443, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "CMD ACK:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(120, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 16)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Address:"
        '
        'txtbACKCvsInSightDisplay2
        '
        Me.txtbACKCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay2.Location = New System.Drawing.Point(516, 87)
        Me.txtbACKCvsInSightDisplay2.Name = "txtbACKCvsInSightDisplay2"
        Me.txtbACKCvsInSightDisplay2.ReadOnly = True
        Me.txtbACKCvsInSightDisplay2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay2.Size = New System.Drawing.Size(40, 31)
        Me.txtbACKCvsInSightDisplay2.TabIndex = 49
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(350, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 16)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "User:"
        '
        'btnCloseTelnetClientST2A
        '
        Me.btnCloseTelnetClientST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseTelnetClientST2A.Location = New System.Drawing.Point(706, 41)
        Me.btnCloseTelnetClientST2A.Name = "btnCloseTelnetClientST2A"
        Me.btnCloseTelnetClientST2A.Size = New System.Drawing.Size(100, 30)
        Me.btnCloseTelnetClientST2A.TabIndex = 48
        Me.btnCloseTelnetClientST2A.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST2A.UseVisualStyleBackColor = True
        '
        'txtbUSERCvsInSightDisplay2
        '
        Me.txtbUSERCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay2.Location = New System.Drawing.Point(391, 40)
        Me.txtbUSERCvsInSightDisplay2.Name = "txtbUSERCvsInSightDisplay2"
        Me.txtbUSERCvsInSightDisplay2.ReadOnly = True
        Me.txtbUSERCvsInSightDisplay2.Size = New System.Drawing.Size(83, 31)
        Me.txtbUSERCvsInSightDisplay2.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay2.Text = "???"
        '
        'btnOpenTelnetClientST2A
        '
        Me.btnOpenTelnetClientST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenTelnetClientST2A.Location = New System.Drawing.Point(600, 41)
        Me.btnOpenTelnetClientST2A.Name = "btnOpenTelnetClientST2A"
        Me.btnOpenTelnetClientST2A.Size = New System.Drawing.Size(100, 30)
        Me.btnOpenTelnetClientST2A.TabIndex = 47
        Me.btnOpenTelnetClientST2A.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST2A.UseVisualStyleBackColor = True
        '
        'txtbPASSWORDCvsInSightDisplay2
        '
        Me.txtbPASSWORDCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay2.Location = New System.Drawing.Point(549, 40)
        Me.txtbPASSWORDCvsInSightDisplay2.Name = "txtbPASSWORDCvsInSightDisplay2"
        Me.txtbPASSWORDCvsInSightDisplay2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay2.ReadOnly = True
        Me.txtbPASSWORDCvsInSightDisplay2.Size = New System.Drawing.Size(43, 31)
        Me.txtbPASSWORDCvsInSightDisplay2.TabIndex = 39
        '
        'btnGETPASSCvsInSightDisplay2
        '
        Me.btnGETPASSCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGETPASSCvsInSightDisplay2.Location = New System.Drawing.Point(321, 87)
        Me.btnGETPASSCvsInSightDisplay2.Name = "btnGETPASSCvsInSightDisplay2"
        Me.btnGETPASSCvsInSightDisplay2.Size = New System.Drawing.Size(111, 30)
        Me.btnGETPASSCvsInSightDisplay2.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay2.Text = "GV S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(476, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 16)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Password:"
        '
        'btnLOADFILECvsInSightDisplay2
        '
        Me.btnLOADFILECvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOADFILECvsInSightDisplay2.Location = New System.Drawing.Point(111, 87)
        Me.btnLOADFILECvsInSightDisplay2.Name = "btnLOADFILECvsInSightDisplay2"
        Me.btnLOADFILECvsInSightDisplay2.Size = New System.Drawing.Size(100, 30)
        Me.btnLOADFILECvsInSightDisplay2.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay2.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay2
        '
        Me.btnTRIGGERCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTRIGGERCvsInSightDisplay2.Location = New System.Drawing.Point(216, 87)
        Me.btnTRIGGERCvsInSightDisplay2.Name = "btnTRIGGERCvsInSightDisplay2"
        Me.btnTRIGGERCvsInSightDisplay2.Size = New System.Drawing.Size(100, 30)
        Me.btnTRIGGERCvsInSightDisplay2.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay2.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'btnDISCONNECTCvsInSightDisplay2
        '
        Me.btnDISCONNECTCvsInSightDisplay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDISCONNECTCvsInSightDisplay2.Location = New System.Drawing.Point(706, 87)
        Me.btnDISCONNECTCvsInSightDisplay2.Name = "btnDISCONNECTCvsInSightDisplay2"
        Me.btnDISCONNECTCvsInSightDisplay2.Size = New System.Drawing.Size(100, 30)
        Me.btnDISCONNECTCvsInSightDisplay2.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay2.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay2.UseVisualStyleBackColor = True
        '
        'CvsInSightDisplay2
        '
        Me.CvsInSightDisplay2.AutoSize = True
        Me.CvsInSightDisplay2.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay2.DialogIcon = Nothing
        Me.CvsInSightDisplay2.GridOpacity = 0R
        Me.CvsInSightDisplay2.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay2.Location = New System.Drawing.Point(6, 120)
        Me.CvsInSightDisplay2.Name = "CvsInSightDisplay2"
        Me.CvsInSightDisplay2.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay2.Size = New System.Drawing.Size(800, 600)
        Me.CvsInSightDisplay2.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(146, 16)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "CVS InSight Display"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 16)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Telnet Client"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(242, 16)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Upload *.job File to IS7200 ST3A :"
        '
        'btnFTPUpJobST3A
        '
        Me.btnFTPUpJobST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPUpJobST3A.Location = New System.Drawing.Point(706, 6)
        Me.btnFTPUpJobST3A.Name = "btnFTPUpJobST3A"
        Me.btnFTPUpJobST3A.Size = New System.Drawing.Size(100, 30)
        Me.btnFTPUpJobST3A.TabIndex = 28
        Me.btnFTPUpJobST3A.Text = "FTP Upload"
        Me.btnFTPUpJobST3A.UseVisualStyleBackColor = True
        '
        'txtbFTPUpJobST3A
        '
        Me.txtbFTPUpJobST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFTPUpJobST3A.Location = New System.Drawing.Point(250, 6)
        Me.txtbFTPUpJobST3A.Name = "txtbFTPUpJobST3A"
        Me.txtbFTPUpJobST3A.ReadOnly = True
        Me.txtbFTPUpJobST3A.Size = New System.Drawing.Size(450, 31)
        Me.txtbFTPUpJobST3A.TabIndex = 29
        Me.txtbFTPUpJobST3A.Text = "..."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(567, 94)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 16)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "RTN VALUE:"
        '
        'btnCONNECTCvsInSightDisplay3
        '
        Me.btnCONNECTCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCONNECTCvsInSightDisplay3.Location = New System.Drawing.Point(6, 87)
        Me.btnCONNECTCvsInSightDisplay3.Name = "btnCONNECTCvsInSightDisplay3"
        Me.btnCONNECTCvsInSightDisplay3.Size = New System.Drawing.Size(100, 30)
        Me.btnCONNECTCvsInSightDisplay3.TabIndex = 34
        Me.btnCONNECTCvsInSightDisplay3.Text = "Connect CVS"
        Me.btnCONNECTCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'txtbRETCvsInSightDisplay3
        '
        Me.txtbRETCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbRETCvsInSightDisplay3.Location = New System.Drawing.Point(660, 87)
        Me.txtbRETCvsInSightDisplay3.Name = "txtbRETCvsInSightDisplay3"
        Me.txtbRETCvsInSightDisplay3.ReadOnly = True
        Me.txtbRETCvsInSightDisplay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbRETCvsInSightDisplay3.Size = New System.Drawing.Size(40, 31)
        Me.txtbRETCvsInSightDisplay3.TabIndex = 51
        '
        'txtbADDRESSCvsInSightDisplay3
        '
        Me.txtbADDRESSCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbADDRESSCvsInSightDisplay3.Location = New System.Drawing.Point(184, 40)
        Me.txtbADDRESSCvsInSightDisplay3.Name = "txtbADDRESSCvsInSightDisplay3"
        Me.txtbADDRESSCvsInSightDisplay3.ReadOnly = True
        Me.txtbADDRESSCvsInSightDisplay3.Size = New System.Drawing.Size(162, 31)
        Me.txtbADDRESSCvsInSightDisplay3.TabIndex = 35
        Me.txtbADDRESSCvsInSightDisplay3.Text = "xxx.xxx.xxx.xxx"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(443, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 16)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "CMD ACK:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(120, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 16)
        Me.Label25.TabIndex = 36
        Me.Label25.Text = "Address:"
        '
        'txtbACKCvsInSightDisplay3
        '
        Me.txtbACKCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbACKCvsInSightDisplay3.Location = New System.Drawing.Point(516, 87)
        Me.txtbACKCvsInSightDisplay3.Name = "txtbACKCvsInSightDisplay3"
        Me.txtbACKCvsInSightDisplay3.ReadOnly = True
        Me.txtbACKCvsInSightDisplay3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbACKCvsInSightDisplay3.Size = New System.Drawing.Size(40, 31)
        Me.txtbACKCvsInSightDisplay3.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(350, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 16)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "User:"
        '
        'btnCloseTelnetClientST3A
        '
        Me.btnCloseTelnetClientST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseTelnetClientST3A.Location = New System.Drawing.Point(706, 41)
        Me.btnCloseTelnetClientST3A.Name = "btnCloseTelnetClientST3A"
        Me.btnCloseTelnetClientST3A.Size = New System.Drawing.Size(100, 30)
        Me.btnCloseTelnetClientST3A.TabIndex = 48
        Me.btnCloseTelnetClientST3A.Text = "Close Telnet Client"
        Me.btnCloseTelnetClientST3A.UseVisualStyleBackColor = True
        '
        'txtbUSERCvsInSightDisplay3
        '
        Me.txtbUSERCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUSERCvsInSightDisplay3.Location = New System.Drawing.Point(391, 40)
        Me.txtbUSERCvsInSightDisplay3.Name = "txtbUSERCvsInSightDisplay3"
        Me.txtbUSERCvsInSightDisplay3.ReadOnly = True
        Me.txtbUSERCvsInSightDisplay3.Size = New System.Drawing.Size(83, 31)
        Me.txtbUSERCvsInSightDisplay3.TabIndex = 38
        Me.txtbUSERCvsInSightDisplay3.Text = "???"
        '
        'btnOpenTelnetClientST3A
        '
        Me.btnOpenTelnetClientST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenTelnetClientST3A.Location = New System.Drawing.Point(600, 41)
        Me.btnOpenTelnetClientST3A.Name = "btnOpenTelnetClientST3A"
        Me.btnOpenTelnetClientST3A.Size = New System.Drawing.Size(100, 30)
        Me.btnOpenTelnetClientST3A.TabIndex = 47
        Me.btnOpenTelnetClientST3A.Text = "Open Telnet Client"
        Me.btnOpenTelnetClientST3A.UseVisualStyleBackColor = True
        '
        'txtbPASSWORDCvsInSightDisplay3
        '
        Me.txtbPASSWORDCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPASSWORDCvsInSightDisplay3.Location = New System.Drawing.Point(549, 40)
        Me.txtbPASSWORDCvsInSightDisplay3.Name = "txtbPASSWORDCvsInSightDisplay3"
        Me.txtbPASSWORDCvsInSightDisplay3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbPASSWORDCvsInSightDisplay3.ReadOnly = True
        Me.txtbPASSWORDCvsInSightDisplay3.Size = New System.Drawing.Size(43, 31)
        Me.txtbPASSWORDCvsInSightDisplay3.TabIndex = 39
        '
        'btnGETPASSCvsInSightDisplay3
        '
        Me.btnGETPASSCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGETPASSCvsInSightDisplay3.Location = New System.Drawing.Point(321, 87)
        Me.btnGETPASSCvsInSightDisplay3.Name = "btnGETPASSCvsInSightDisplay3"
        Me.btnGETPASSCvsInSightDisplay3.Size = New System.Drawing.Size(111, 30)
        Me.btnGETPASSCvsInSightDisplay3.TabIndex = 46
        Me.btnGETPASSCvsInSightDisplay3.Text = "GV S1(GVS001)"
        Me.btnGETPASSCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(476, 43)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Password:"
        '
        'btnLOADFILECvsInSightDisplay3
        '
        Me.btnLOADFILECvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLOADFILECvsInSightDisplay3.Location = New System.Drawing.Point(111, 87)
        Me.btnLOADFILECvsInSightDisplay3.Name = "btnLOADFILECvsInSightDisplay3"
        Me.btnLOADFILECvsInSightDisplay3.Size = New System.Drawing.Size(100, 30)
        Me.btnLOADFILECvsInSightDisplay3.TabIndex = 45
        Me.btnLOADFILECvsInSightDisplay3.Text = "Load Job (LF)"
        Me.btnLOADFILECvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'btnTRIGGERCvsInSightDisplay3
        '
        Me.btnTRIGGERCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTRIGGERCvsInSightDisplay3.Location = New System.Drawing.Point(216, 87)
        Me.btnTRIGGERCvsInSightDisplay3.Name = "btnTRIGGERCvsInSightDisplay3"
        Me.btnTRIGGERCvsInSightDisplay3.Size = New System.Drawing.Size(100, 30)
        Me.btnTRIGGERCvsInSightDisplay3.TabIndex = 44
        Me.btnTRIGGERCvsInSightDisplay3.Text = "Trigger (SE8)"
        Me.btnTRIGGERCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'btnDISCONNECTCvsInSightDisplay3
        '
        Me.btnDISCONNECTCvsInSightDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDISCONNECTCvsInSightDisplay3.Location = New System.Drawing.Point(706, 87)
        Me.btnDISCONNECTCvsInSightDisplay3.Name = "btnDISCONNECTCvsInSightDisplay3"
        Me.btnDISCONNECTCvsInSightDisplay3.Size = New System.Drawing.Size(100, 30)
        Me.btnDISCONNECTCvsInSightDisplay3.TabIndex = 42
        Me.btnDISCONNECTCvsInSightDisplay3.Text = "Disconnect"
        Me.btnDISCONNECTCvsInSightDisplay3.UseVisualStyleBackColor = True
        '
        'CvsInSightDisplay3
        '
        Me.CvsInSightDisplay3.AutoSize = True
        Me.CvsInSightDisplay3.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional
        Me.CvsInSightDisplay3.DialogIcon = Nothing
        Me.CvsInSightDisplay3.GridOpacity = 0R
        Me.CvsInSightDisplay3.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit
        Me.CvsInSightDisplay3.Location = New System.Drawing.Point(6, 120)
        Me.CvsInSightDisplay3.Name = "CvsInSightDisplay3"
        Me.CvsInSightDisplay3.PreferredCropScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplayCropScaleMode.[Default]
        Me.CvsInSightDisplay3.Size = New System.Drawing.Size(800, 600)
        Me.CvsInSightDisplay3.TabIndex = 33
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1031)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1912, 22)
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
        Me.grpbxINITIALIZE.Controls.Add(Me.txtbINI_FilePath)
        Me.grpbxINITIALIZE.Controls.Add(Me.Label30)
        Me.grpbxINITIALIZE.Location = New System.Drawing.Point(7, 155)
        Me.grpbxINITIALIZE.Name = "grpbxINITIALIZE"
        Me.grpbxINITIALIZE.Size = New System.Drawing.Size(450, 222)
        Me.grpbxINITIALIZE.TabIndex = 63
        Me.grpbxINITIALIZE.TabStop = False
        Me.grpbxINITIALIZE.Text = "Initialize"
        '
        'btnLoadINI
        '
        Me.btnLoadINI.Location = New System.Drawing.Point(307, 30)
        Me.btnLoadINI.Name = "btnLoadINI"
        Me.btnLoadINI.Size = New System.Drawing.Size(137, 26)
        Me.btnLoadINI.TabIndex = 76
        Me.btnLoadINI.Text = "Load INI"
        Me.btnLoadINI.UseVisualStyleBackColor = True
        '
        'chkbSymbolBarcodeST3A
        '
        Me.chkbSymbolBarcodeST3A.AutoSize = True
        Me.chkbSymbolBarcodeST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbSymbolBarcodeST3A.Location = New System.Drawing.Point(262, 175)
        Me.chkbSymbolBarcodeST3A.Name = "chkbSymbolBarcodeST3A"
        Me.chkbSymbolBarcodeST3A.Size = New System.Drawing.Size(169, 20)
        Me.chkbSymbolBarcodeST3A.TabIndex = 74
        Me.chkbSymbolBarcodeST3A.Text = "Barcode Scanner ST3A"
        Me.chkbSymbolBarcodeST3A.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST3A
        '
        Me.chkbCOGNEXInSightST3A.AutoSize = True
        Me.chkbCOGNEXInSightST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbCOGNEXInSightST3A.Location = New System.Drawing.Point(262, 129)
        Me.chkbCOGNEXInSightST3A.Name = "chkbCOGNEXInSightST3A"
        Me.chkbCOGNEXInSightST3A.Size = New System.Drawing.Size(163, 20)
        Me.chkbCOGNEXInSightST3A.TabIndex = 73
        Me.chkbCOGNEXInSightST3A.Text = "COGNEX InSight ST3A"
        Me.chkbCOGNEXInSightST3A.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(259, 113)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 72
        Me.Label34.Text = "ST3"
        '
        'chkbScaleRS232
        '
        Me.chkbScaleRS232.AutoSize = True
        Me.chkbScaleRS232.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbScaleRS232.Location = New System.Drawing.Point(262, 152)
        Me.chkbScaleRS232.Name = "chkbScaleRS232"
        Me.chkbScaleRS232.Size = New System.Drawing.Size(113, 20)
        Me.chkbScaleRS232.TabIndex = 71
        Me.chkbScaleRS232.Text = "SCALE RS232"
        Me.chkbScaleRS232.UseVisualStyleBackColor = True
        '
        'chkbP2000
        '
        Me.chkbP2000.AutoSize = True
        Me.chkbP2000.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbP2000.Location = New System.Drawing.Point(7, 188)
        Me.chkbP2000.Name = "chkbP2000"
        Me.chkbP2000.Size = New System.Drawing.Size(129, 20)
        Me.chkbP2000.TabIndex = 70
        Me.chkbP2000.Text = "PLC P2000 ST1B"
        Me.chkbP2000.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST2A
        '
        Me.chkbCOGNEXInSightST2A.AutoSize = True
        Me.chkbCOGNEXInSightST2A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbCOGNEXInSightST2A.Location = New System.Drawing.Point(262, 90)
        Me.chkbCOGNEXInSightST2A.Name = "chkbCOGNEXInSightST2A"
        Me.chkbCOGNEXInSightST2A.Size = New System.Drawing.Size(163, 20)
        Me.chkbCOGNEXInSightST2A.TabIndex = 69
        Me.chkbCOGNEXInSightST2A.Text = "COGNEX InSight ST2A"
        Me.chkbCOGNEXInSightST2A.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(259, 74)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 13)
        Me.Label33.TabIndex = 67
        Me.Label33.Text = "ST2"
        '
        'chkbZebra110Xi4_ST3A
        '
        Me.chkbZebra110Xi4_ST3A.AutoSize = True
        Me.chkbZebra110Xi4_ST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbZebra110Xi4_ST3A.Location = New System.Drawing.Point(262, 199)
        Me.chkbZebra110Xi4_ST3A.Name = "chkbZebra110Xi4_ST3A"
        Me.chkbZebra110Xi4_ST3A.Size = New System.Drawing.Size(151, 20)
        Me.chkbZebra110Xi4_ST3A.TabIndex = 66
        Me.chkbZebra110Xi4_ST3A.Text = "ZEBRA 110Xi4 ST3A"
        Me.chkbZebra110Xi4_ST3A.UseVisualStyleBackColor = True
        '
        'chkbCOGNEXInSightST1B
        '
        Me.chkbCOGNEXInSightST1B.AutoSize = True
        Me.chkbCOGNEXInSightST1B.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbCOGNEXInSightST1B.Location = New System.Drawing.Point(7, 165)
        Me.chkbCOGNEXInSightST1B.Name = "chkbCOGNEXInSightST1B"
        Me.chkbCOGNEXInSightST1B.Size = New System.Drawing.Size(163, 20)
        Me.chkbCOGNEXInSightST1B.TabIndex = 64
        Me.chkbCOGNEXInSightST1B.Text = "COGNEX InSight ST1B"
        Me.chkbCOGNEXInSightST1B.UseVisualStyleBackColor = True
        '
        'chkbZebra110Xi4_ST1A
        '
        Me.chkbZebra110Xi4_ST1A.AutoSize = True
        Me.chkbZebra110Xi4_ST1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbZebra110Xi4_ST1A.Location = New System.Drawing.Point(7, 142)
        Me.chkbZebra110Xi4_ST1A.Name = "chkbZebra110Xi4_ST1A"
        Me.chkbZebra110Xi4_ST1A.Size = New System.Drawing.Size(151, 20)
        Me.chkbZebra110Xi4_ST1A.TabIndex = 63
        Me.chkbZebra110Xi4_ST1A.Text = "ZEBRA 110Xi4 ST1A"
        Me.chkbZebra110Xi4_ST1A.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(4, 82)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 13)
        Me.Label32.TabIndex = 62
        Me.Label32.Text = "ST1"
        '
        'chkbTEGAMGPIBInterface
        '
        Me.chkbTEGAMGPIBInterface.AutoSize = True
        Me.chkbTEGAMGPIBInterface.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbTEGAMGPIBInterface.Location = New System.Drawing.Point(7, 119)
        Me.chkbTEGAMGPIBInterface.Name = "chkbTEGAMGPIBInterface"
        Me.chkbTEGAMGPIBInterface.Size = New System.Drawing.Size(143, 20)
        Me.chkbTEGAMGPIBInterface.TabIndex = 61
        Me.chkbTEGAMGPIBInterface.Text = "TEGAM 1750 ST1A"
        Me.chkbTEGAMGPIBInterface.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(4, 59)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(143, 13)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Select Devices to Start:"
        '
        'chkbSymbolBarcodeST1A
        '
        Me.chkbSymbolBarcodeST1A.AutoSize = True
        Me.chkbSymbolBarcodeST1A.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbSymbolBarcodeST1A.Location = New System.Drawing.Point(7, 98)
        Me.chkbSymbolBarcodeST1A.Name = "chkbSymbolBarcodeST1A"
        Me.chkbSymbolBarcodeST1A.Size = New System.Drawing.Size(169, 20)
        Me.chkbSymbolBarcodeST1A.TabIndex = 59
        Me.chkbSymbolBarcodeST1A.Text = "Barcode Scanner ST1A"
        Me.chkbSymbolBarcodeST1A.UseVisualStyleBackColor = True
        '
        'txtbINI_FilePath
        '
        Me.txtbINI_FilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbINI_FilePath.Location = New System.Drawing.Point(7, 31)
        Me.txtbINI_FilePath.Multiline = True
        Me.txtbINI_FilePath.Name = "txtbINI_FilePath"
        Me.txtbINI_FilePath.Size = New System.Drawing.Size(294, 25)
        Me.txtbINI_FilePath.TabIndex = 58
        Me.txtbINI_FilePath.Text = "C:\HEV_INSPECTION_files\localStartConfig.ini"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(4, 14)
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
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.btnOpenBarcodeDeviceST3A)
        Me.GroupBox1.Controls.Add(Me.txtbBCDevice_ReadST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDGreenONST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDRedONST3A)
        Me.GroupBox1.Controls.Add(Me.btnBCDevice_LEDsOFFST3A)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.btnBCDeviceEventSubscribeST3A)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Location = New System.Drawing.Point(1750, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 180)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Symbol Barcode ST3A"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(4, 90)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(95, 13)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "LEDs and Beep"
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
        Me.btnOpenBarcodeDeviceST3A.Location = New System.Drawing.Point(5, 41)
        Me.btnOpenBarcodeDeviceST3A.Name = "btnOpenBarcodeDeviceST3A"
        Me.btnOpenBarcodeDeviceST3A.Size = New System.Drawing.Size(45, 34)
        Me.btnOpenBarcodeDeviceST3A.TabIndex = 15
        Me.btnOpenBarcodeDeviceST3A.Text = "Open"
        Me.btnOpenBarcodeDeviceST3A.UseVisualStyleBackColor = True
        '
        'txtbBCDevice_ReadST3A
        '
        Me.txtbBCDevice_ReadST3A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbBCDevice_ReadST3A.Location = New System.Drawing.Point(5, 149)
        Me.txtbBCDevice_ReadST3A.Multiline = True
        Me.txtbBCDevice_ReadST3A.Name = "txtbBCDevice_ReadST3A"
        Me.txtbBCDevice_ReadST3A.ReadOnly = True
        Me.txtbBCDevice_ReadST3A.Size = New System.Drawing.Size(140, 25)
        Me.txtbBCDevice_ReadST3A.TabIndex = 16
        Me.txtbBCDevice_ReadST3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBCDevice_LEDGreenONST3A
        '
        Me.btnBCDevice_LEDGreenONST3A.Location = New System.Drawing.Point(4, 110)
        Me.btnBCDevice_LEDGreenONST3A.Name = "btnBCDevice_LEDGreenONST3A"
        Me.btnBCDevice_LEDGreenONST3A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDGreenONST3A.TabIndex = 18
        Me.btnBCDevice_LEDGreenONST3A.Text = "Green ON"
        Me.btnBCDevice_LEDGreenONST3A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDRedONST3A
        '
        Me.btnBCDevice_LEDRedONST3A.Location = New System.Drawing.Point(52, 110)
        Me.btnBCDevice_LEDRedONST3A.Name = "btnBCDevice_LEDRedONST3A"
        Me.btnBCDevice_LEDRedONST3A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDRedONST3A.TabIndex = 19
        Me.btnBCDevice_LEDRedONST3A.Text = "LED RED ON"
        Me.btnBCDevice_LEDRedONST3A.UseVisualStyleBackColor = True
        '
        'btnBCDevice_LEDsOFFST3A
        '
        Me.btnBCDevice_LEDsOFFST3A.Location = New System.Drawing.Point(100, 110)
        Me.btnBCDevice_LEDsOFFST3A.Name = "btnBCDevice_LEDsOFFST3A"
        Me.btnBCDevice_LEDsOFFST3A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDevice_LEDsOFFST3A.TabIndex = 20
        Me.btnBCDevice_LEDsOFFST3A.Text = "LEDs OFF"
        Me.btnBCDevice_LEDsOFFST3A.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(99, 87)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(45, 19)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "BEEP"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnBCDeviceEventSubscribeST3A
        '
        Me.btnBCDeviceEventSubscribeST3A.Location = New System.Drawing.Point(52, 41)
        Me.btnBCDeviceEventSubscribeST3A.Name = "btnBCDeviceEventSubscribeST3A"
        Me.btnBCDeviceEventSubscribeST3A.Size = New System.Drawing.Size(45, 34)
        Me.btnBCDeviceEventSubscribeST3A.TabIndex = 22
        Me.btnBCDeviceEventSubscribeST3A.Text = "Event Subs."
        Me.btnBCDeviceEventSubscribeST3A.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(100, 41)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(45, 34)
        Me.Button9.TabIndex = 23
        Me.Button9.Text = "Close"
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
        Me.grpbxMODBUS_TCP.Location = New System.Drawing.Point(1357, 816)
        Me.grpbxMODBUS_TCP.Name = "grpbxMODBUS_TCP"
        Me.grpbxMODBUS_TCP.Size = New System.Drawing.Size(300, 180)
        Me.grpbxMODBUS_TCP.TabIndex = 64
        Me.grpbxMODBUS_TCP.TabStop = False
        Me.grpbxMODBUS_TCP.Text = "MODBUS TCP - P2000"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(8, 122)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 13)
        Me.Label39.TabIndex = 93
        Me.Label39.Text = "Read DI"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 54)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(68, 13)
        Me.Label38.TabIndex = 92
        Me.Label38.Text = "Write Coils"
        '
        'btnModbusTCP_Disconnect
        '
        Me.btnModbusTCP_Disconnect.Location = New System.Drawing.Point(218, 15)
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
        Me.chkbModbusTCP_X15.Location = New System.Drawing.Point(223, 94)
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
        Me.chkbModbusTCP_X14.Location = New System.Drawing.Point(187, 94)
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
        Me.chkbModbusTCP_X13.Location = New System.Drawing.Point(150, 94)
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
        Me.chkbModbusTCP_X12.Location = New System.Drawing.Point(114, 94)
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
        Me.chkbModbusTCP_X11.Location = New System.Drawing.Point(78, 94)
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
        Me.chkbModbusTCP_X10.Location = New System.Drawing.Point(42, 94)
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
        Me.chkbModbusTCP_X09.Location = New System.Drawing.Point(6, 94)
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
        Me.chkbModbusTCP_X08.Location = New System.Drawing.Point(259, 70)
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
        Me.chkbModbusTCP_X07.Location = New System.Drawing.Point(223, 70)
        Me.chkbModbusTCP_X07.Name = "chkbModbusTCP_X07"
        Me.chkbModbusTCP_X07.Size = New System.Drawing.Size(36, 23)
        Me.chkbModbusTCP_X07.TabIndex = 82
        Me.chkbModbusTCP_X07.Text = "X07"
        Me.chkbModbusTCP_X07.UseVisualStyleBackColor = True
        '
        'btnModbusTCP_Refresh
        '
        Me.btnModbusTCP_Refresh.Location = New System.Drawing.Point(180, 45)
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
        Me.chkbModbusTCP_X06.Location = New System.Drawing.Point(187, 70)
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
        Me.chkbModbusTCP_X05.Location = New System.Drawing.Point(150, 70)
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
        Me.chkbModbusTCP_X04.Location = New System.Drawing.Point(114, 70)
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
        Me.chkbModbusTCP_X03.Location = New System.Drawing.Point(78, 70)
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
        Me.chkbModbusTCP_X02.Location = New System.Drawing.Point(42, 70)
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
        Me.chkbModbusTCP_X01.Location = New System.Drawing.Point(6, 70)
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
        Me.chkbModbusTCP_X16.Location = New System.Drawing.Point(259, 94)
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
        Me.lblModbusTCP_Y15.Location = New System.Drawing.Point(228, 155)
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
        Me.lblModbusTCP_Y14.Location = New System.Drawing.Point(190, 155)
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
        Me.lblModbusTCP_Y13.Location = New System.Drawing.Point(153, 155)
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
        Me.lblModbusTCP_Y12.Location = New System.Drawing.Point(115, 155)
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
        Me.lblModbusTCP_Y11.Location = New System.Drawing.Point(79, 155)
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
        Me.lblModbusTCP_Y10.Location = New System.Drawing.Point(44, 155)
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
        Me.lblModbusTCP_Y09.Location = New System.Drawing.Point(9, 155)
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
        Me.lblModbusTCP_Y08.Location = New System.Drawing.Point(264, 138)
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
        Me.lblModbusTCP_Y07.Location = New System.Drawing.Point(228, 138)
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
        Me.lblModbusTCP_Y06.Location = New System.Drawing.Point(190, 138)
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
        Me.lblModbusTCP_Y05.Location = New System.Drawing.Point(153, 138)
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
        Me.lblModbusTCP_Y04.Location = New System.Drawing.Point(116, 138)
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
        Me.lblModbusTCP_Y03.Location = New System.Drawing.Point(79, 138)
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
        Me.lblModbusTCP_Y02.Location = New System.Drawing.Point(44, 138)
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
        Me.lblModbusTCP_Y01.Location = New System.Drawing.Point(9, 138)
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
        Me.lblModbusTCP_Y16.Location = New System.Drawing.Point(264, 155)
        Me.lblModbusTCP_Y16.Name = "lblModbusTCP_Y16"
        Me.lblModbusTCP_Y16.Size = New System.Drawing.Size(30, 17)
        Me.lblModbusTCP_Y16.TabIndex = 43
        Me.lblModbusTCP_Y16.Text = "Y16"
        '
        'btnModbusTCP_Connect
        '
        Me.btnModbusTCP_Connect.Location = New System.Drawing.Point(153, 15)
        Me.btnModbusTCP_Connect.Name = "btnModbusTCP_Connect"
        Me.btnModbusTCP_Connect.Size = New System.Drawing.Size(61, 25)
        Me.btnModbusTCP_Connect.TabIndex = 41
        Me.btnModbusTCP_Connect.Text = "Connect"
        Me.btnModbusTCP_Connect.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(118, 18)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(29, 26)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Port:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "502" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(3, 23)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 13)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "Address:"
        '
        'txtbMODBUS_TCP_IP_Address
        '
        Me.txtbMODBUS_TCP_IP_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbMODBUS_TCP_IP_Address.Location = New System.Drawing.Point(51, 19)
        Me.txtbMODBUS_TCP_IP_Address.Name = "txtbMODBUS_TCP_IP_Address"
        Me.txtbMODBUS_TCP_IP_Address.Size = New System.Drawing.Size(71, 22)
        Me.txtbMODBUS_TCP_IP_Address.TabIndex = 36
        Me.txtbMODBUS_TCP_IP_Address.Text = "169.254.6.150"
        '
        'timerModbusTCP1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(837, 832)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpgCOGNEX_Insight)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(929, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(820, 750)
        Me.TabControl1.TabIndex = 67
        '
        'tabpgCOGNEX_Insight
        '
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label6)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label5)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label4)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnTRIGGERCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnFTPUpJobST1B)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnLOADFILECvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbFTPUpJobST1B)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label10)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label14)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnGETPASSCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnCONNECTCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbRETCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnOpenTelnetClientST1B)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbADDRESSCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbUSERCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label13)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.btnCloseTelnetClientST1B)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label8)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.Label9)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.txtbACKCvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Controls.Add(Me.CvsInSightDisplay1)
        Me.tabpgCOGNEX_Insight.Location = New System.Drawing.Point(4, 22)
        Me.tabpgCOGNEX_Insight.Name = "tabpgCOGNEX_Insight"
        Me.tabpgCOGNEX_Insight.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpgCOGNEX_Insight.Size = New System.Drawing.Size(812, 724)
        Me.tabpgCOGNEX_Insight.TabIndex = 0
        Me.tabpgCOGNEX_Insight.Text = "CVSInsight_ST1B"
        Me.tabpgCOGNEX_Insight.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.btnFTPUpJobST2A)
        Me.TabPage2.Controls.Add(Me.btnTRIGGERCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.txtbFTPUpJobST2A)
        Me.TabPage2.Controls.Add(Me.btnLOADFILECvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.btnCONNECTCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.btnGETPASSCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.txtbRETCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.txtbADDRESSCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.btnOpenTelnetClientST2A)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtbUSERCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.btnCloseTelnetClientST2A)
        Me.TabPage2.Controls.Add(Me.txtbACKCvsInSightDisplay2)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.CvsInSightDisplay2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(812, 724)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CVSInsight_ST2A"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Controls.Add(Me.btnDISCONNECTCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.btnFTPUpJobST3A)
        Me.TabPage3.Controls.Add(Me.btnTRIGGERCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.txtbFTPUpJobST3A)
        Me.TabPage3.Controls.Add(Me.btnLOADFILECvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.btnCONNECTCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.btnGETPASSCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.txtbRETCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.txtbPASSWORDCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.txtbADDRESSCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.btnOpenTelnetClientST3A)
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.txtbUSERCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.Label25)
        Me.TabPage3.Controls.Add(Me.btnCloseTelnetClientST3A)
        Me.TabPage3.Controls.Add(Me.txtbACKCvsInSightDisplay3)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.CvsInSightDisplay3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(812, 724)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CVSInsight_ST3A"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnStartSelectedPeripherals
        '
        Me.btnStartSelectedPeripherals.BackColor = System.Drawing.Color.White
        Me.btnStartSelectedPeripherals.BackgroundImage = CType(resources.GetObject("btnStartSelectedPeripherals.BackgroundImage"), System.Drawing.Image)
        Me.btnStartSelectedPeripherals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStartSelectedPeripherals.Location = New System.Drawing.Point(7, 29)
        Me.btnStartSelectedPeripherals.Name = "btnStartSelectedPeripherals"
        Me.btnStartSelectedPeripherals.Size = New System.Drawing.Size(450, 120)
        Me.btnStartSelectedPeripherals.TabIndex = 68
        Me.btnStartSelectedPeripherals.UseVisualStyleBackColor = False
        '
        'grpbxINIT
        '
        Me.grpbxINIT.Controls.Add(Me.TextBox9)
        Me.grpbxINIT.Controls.Add(Me.Label60)
        Me.grpbxINIT.Controls.Add(Me.TextBox8)
        Me.grpbxINIT.Controls.Add(Me.Label59)
        Me.grpbxINIT.Controls.Add(Me.TextBox7)
        Me.grpbxINIT.Controls.Add(Me.Label58)
        Me.grpbxINIT.Controls.Add(Me.Label57)
        Me.grpbxINIT.Controls.Add(Me.TextBox6)
        Me.grpbxINIT.Controls.Add(Me.Label56)
        Me.grpbxINIT.Controls.Add(Me.TextBox5)
        Me.grpbxINIT.Controls.Add(Me.Label55)
        Me.grpbxINIT.Controls.Add(Me.TextBox4)
        Me.grpbxINIT.Controls.Add(Me.txtbLOGfolder)
        Me.grpbxINIT.Controls.Add(Me.Label46)
        Me.grpbxINIT.Controls.Add(Me.txtbPRNfolder)
        Me.grpbxINIT.Controls.Add(Me.Label47)
        Me.grpbxINIT.Controls.Add(Me.txtbPRINTERstatus)
        Me.grpbxINIT.Controls.Add(Me.Label48)
        Me.grpbxINIT.Controls.Add(Me.Label49)
        Me.grpbxINIT.Controls.Add(Me.txtbOPERATOR1)
        Me.grpbxINIT.Controls.Add(Me.Label50)
        Me.grpbxINIT.Controls.Add(Me.txtbPART_NUMBER)
        Me.grpbxINIT.Controls.Add(Me.txtbBARCODEstatus)
        Me.grpbxINIT.Controls.Add(Me.Label51)
        Me.grpbxINIT.Controls.Add(Me.txtbTEGAMstatus)
        Me.grpbxINIT.Controls.Add(Me.Label52)
        Me.grpbxINIT.Controls.Add(Me.txtbDBfilepath)
        Me.grpbxINIT.Controls.Add(Me.Label53)
        Me.grpbxINIT.Controls.Add(Me.txtbSHOP_PACK)
        Me.grpbxINIT.Controls.Add(Me.Label54)
        Me.grpbxINIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.grpbxINIT.Location = New System.Drawing.Point(7, 383)
        Me.grpbxINIT.Name = "grpbxINIT"
        Me.grpbxINIT.Size = New System.Drawing.Size(450, 562)
        Me.grpbxINIT.TabIndex = 82
        Me.grpbxINIT.TabStop = False
        Me.grpbxINIT.Text = "PERIPHERALS START UP:"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox9.Location = New System.Drawing.Point(190, 444)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(158, 22)
        Me.TextBox9.TabIndex = 109
        Me.TextBox9.Text = "--"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label60.Location = New System.Drawing.Point(21, 447)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(164, 16)
        Me.Label60.TabIndex = 108
        Me.Label60.Text = "OHAUS  Scale Status :"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.Location = New System.Drawing.Point(190, 360)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(158, 22)
        Me.TextBox8.TabIndex = 107
        Me.TextBox8.Text = "--"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label59.Location = New System.Drawing.Point(52, 363)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(133, 16)
        Me.Label59.TabIndex = 106
        Me.Label59.Text = "LS2208 #2 Status :"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.Location = New System.Drawing.Point(190, 413)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(158, 22)
        Me.TextBox7.TabIndex = 105
        Me.TextBox7.Text = "--"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label58.Location = New System.Drawing.Point(8, 416)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(177, 16)
        Me.Label58.TabIndex = 104
        Me.Label58.Text = "Printer 110Xi4 #2 Status :"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label57.Location = New System.Drawing.Point(34, 203)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(151, 25)
        Me.Label57.TabIndex = 103
        Me.Label57.Text = "Operator #4 :"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.Location = New System.Drawing.Point(190, 203)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(252, 31)
        Me.TextBox6.TabIndex = 102
        Me.TextBox6.Text = "--"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label56.Location = New System.Drawing.Point(34, 166)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(151, 25)
        Me.Label56.TabIndex = 101
        Me.Label56.Text = "Operator #3 :"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.Location = New System.Drawing.Point(190, 166)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(252, 31)
        Me.TextBox5.TabIndex = 100
        Me.TextBox5.Text = "--"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label55.Location = New System.Drawing.Point(34, 130)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(151, 25)
        Me.Label55.TabIndex = 99
        Me.Label55.Text = "Operator #2 :"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(190, 130)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(252, 31)
        Me.TextBox4.TabIndex = 98
        Me.TextBox4.Text = "--"
        '
        'txtbLOGfolder
        '
        Me.txtbLOGfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbLOGfolder.Location = New System.Drawing.Point(190, 288)
        Me.txtbLOGfolder.Name = "txtbLOGfolder"
        Me.txtbLOGfolder.ReadOnly = True
        Me.txtbLOGfolder.Size = New System.Drawing.Size(158, 22)
        Me.txtbLOGfolder.TabIndex = 97
        Me.txtbLOGfolder.Text = "--"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label46.Location = New System.Drawing.Point(94, 294)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(91, 16)
        Me.Label46.TabIndex = 96
        Me.Label46.Text = "Log Folder :"
        '
        'txtbPRNfolder
        '
        Me.txtbPRNfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPRNfolder.Location = New System.Drawing.Point(190, 263)
        Me.txtbPRNfolder.Name = "txtbPRNfolder"
        Me.txtbPRNfolder.ReadOnly = True
        Me.txtbPRNfolder.Size = New System.Drawing.Size(158, 22)
        Me.txtbPRNfolder.TabIndex = 95
        Me.txtbPRNfolder.Text = "--"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label47.Location = New System.Drawing.Point(16, 266)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(169, 16)
        Me.Label47.TabIndex = 94
        Me.Label47.Text = "Labels (PRN) Filepath :"
        '
        'txtbPRINTERstatus
        '
        Me.txtbPRINTERstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPRINTERstatus.Location = New System.Drawing.Point(190, 386)
        Me.txtbPRINTERstatus.Name = "txtbPRINTERstatus"
        Me.txtbPRINTERstatus.ReadOnly = True
        Me.txtbPRINTERstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbPRINTERstatus.TabIndex = 93
        Me.txtbPRINTERstatus.Text = "--"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label48.Location = New System.Drawing.Point(8, 389)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(177, 16)
        Me.Label48.TabIndex = 92
        Me.Label48.Text = "Printer 110Xi4 #1 Status :"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label49.Location = New System.Drawing.Point(34, 93)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(151, 25)
        Me.Label49.TabIndex = 91
        Me.Label49.Text = "Operator #1 :"
        '
        'txtbOPERATOR1
        '
        Me.txtbOPERATOR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbOPERATOR1.Location = New System.Drawing.Point(190, 93)
        Me.txtbOPERATOR1.Name = "txtbOPERATOR1"
        Me.txtbOPERATOR1.ReadOnly = True
        Me.txtbOPERATOR1.Size = New System.Drawing.Size(252, 31)
        Me.txtbOPERATOR1.TabIndex = 90
        Me.txtbOPERATOR1.Text = "--"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label50.Location = New System.Drawing.Point(28, 62)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(157, 25)
        Me.Label50.TabIndex = 89
        Me.Label50.Text = "Part Number :"
        '
        'txtbPART_NUMBER
        '
        Me.txtbPART_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbPART_NUMBER.Location = New System.Drawing.Point(190, 59)
        Me.txtbPART_NUMBER.Name = "txtbPART_NUMBER"
        Me.txtbPART_NUMBER.Size = New System.Drawing.Size(252, 31)
        Me.txtbPART_NUMBER.TabIndex = 88
        Me.txtbPART_NUMBER.Text = "0HEV030.ZXPCB"
        '
        'txtbBARCODEstatus
        '
        Me.txtbBARCODEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbBARCODEstatus.Location = New System.Drawing.Point(190, 337)
        Me.txtbBARCODEstatus.Name = "txtbBARCODEstatus"
        Me.txtbBARCODEstatus.ReadOnly = True
        Me.txtbBARCODEstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbBARCODEstatus.TabIndex = 87
        Me.txtbBARCODEstatus.Text = "--"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label51.Location = New System.Drawing.Point(52, 340)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(133, 16)
        Me.Label51.TabIndex = 86
        Me.Label51.Text = "LS2208 #1 Status :"
        '
        'txtbTEGAMstatus
        '
        Me.txtbTEGAMstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbTEGAMstatus.Location = New System.Drawing.Point(190, 313)
        Me.txtbTEGAMstatus.Name = "txtbTEGAMstatus"
        Me.txtbTEGAMstatus.ReadOnly = True
        Me.txtbTEGAMstatus.Size = New System.Drawing.Size(158, 22)
        Me.txtbTEGAMstatus.TabIndex = 85
        Me.txtbTEGAMstatus.Text = "--"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label52.Location = New System.Drawing.Point(33, 316)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(152, 16)
        Me.Label52.TabIndex = 84
        Me.Label52.Text = "TEGAM 1750 Status :"
        '
        'txtbDBfilepath
        '
        Me.txtbDBfilepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtbDBfilepath.Location = New System.Drawing.Point(190, 239)
        Me.txtbDBfilepath.Name = "txtbDBfilepath"
        Me.txtbDBfilepath.ReadOnly = True
        Me.txtbDBfilepath.Size = New System.Drawing.Size(158, 22)
        Me.txtbDBfilepath.TabIndex = 83
        Me.txtbDBfilepath.Text = "--"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label53.Location = New System.Drawing.Point(88, 239)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(97, 16)
        Me.Label53.TabIndex = 82
        Me.Label53.Text = "DB Filepath :"
        '
        'txtbSHOP_PACK
        '
        Me.txtbSHOP_PACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtbSHOP_PACK.Location = New System.Drawing.Point(190, 25)
        Me.txtbSHOP_PACK.Name = "txtbSHOP_PACK"
        Me.txtbSHOP_PACK.Size = New System.Drawing.Size(252, 31)
        Me.txtbSHOP_PACK.TabIndex = 81
        Me.txtbSHOP_PACK.Text = "--"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label54.Location = New System.Drawing.Point(26, 28)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(159, 25)
        Me.Label54.TabIndex = 80
        Me.Label54.Text = "Shop Pack # :"
        '
        'bkgworkGPIB_SLEEP
        '
        '
        'grpbxZEBRA1
        '
        Me.grpbxZEBRA1.Controls.Add(Me.txtbDATECODE)
        Me.grpbxZEBRA1.Controls.Add(Me.Label63)
        Me.grpbxZEBRA1.Controls.Add(Me.txtbPRN_TEMPLATE)
        Me.grpbxZEBRA1.Controls.Add(Me.Label62)
        Me.grpbxZEBRA1.Controls.Add(Me.txtbZEBRA_FUSE_IPaddress)
        Me.grpbxZEBRA1.Controls.Add(Me.Label61)
        Me.grpbxZEBRA1.Controls.Add(Me.btnZEBRA_FUSE_print)
        Me.grpbxZEBRA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxZEBRA1.Location = New System.Drawing.Point(463, 747)
        Me.grpbxZEBRA1.Name = "grpbxZEBRA1"
        Me.grpbxZEBRA1.Size = New System.Drawing.Size(200, 249)
        Me.grpbxZEBRA1.TabIndex = 83
        Me.grpbxZEBRA1.TabStop = False
        Me.grpbxZEBRA1.Text = "ZEBRA 110Xi4 FUSE LABEL"
        '
        'txtbDATECODE
        '
        Me.txtbDATECODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDATECODE.Location = New System.Drawing.Point(6, 135)
        Me.txtbDATECODE.Name = "txtbDATECODE"
        Me.txtbDATECODE.ReadOnly = True
        Me.txtbDATECODE.Size = New System.Drawing.Size(183, 62)
        Me.txtbDATECODE.TabIndex = 41
        Me.txtbDATECODE.Text = "LXXXF"
        Me.txtbDATECODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(6, 110)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(86, 16)
        Me.Label63.TabIndex = 42
        Me.Label63.Text = "DATECODE:"
        '
        'txtbPRN_TEMPLATE
        '
        Me.txtbPRN_TEMPLATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPRN_TEMPLATE.Location = New System.Drawing.Point(10, 84)
        Me.txtbPRN_TEMPLATE.Name = "txtbPRN_TEMPLATE"
        Me.txtbPRN_TEMPLATE.ReadOnly = True
        Me.txtbPRN_TEMPLATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtbPRN_TEMPLATE.Size = New System.Drawing.Size(183, 22)
        Me.txtbPRN_TEMPLATE.TabIndex = 39
        Me.txtbPRN_TEMPLATE.Text = "--"
        Me.txtbPRN_TEMPLATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(6, 65)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(126, 16)
        Me.Label62.TabIndex = 40
        Me.Label62.Text = "PRN FIle Template:"
        '
        'txtbZEBRA_FUSE_IPaddress
        '
        Me.txtbZEBRA_FUSE_IPaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbZEBRA_FUSE_IPaddress.Location = New System.Drawing.Point(9, 31)
        Me.txtbZEBRA_FUSE_IPaddress.Name = "txtbZEBRA_FUSE_IPaddress"
        Me.txtbZEBRA_FUSE_IPaddress.ReadOnly = True
        Me.txtbZEBRA_FUSE_IPaddress.Size = New System.Drawing.Size(183, 31)
        Me.txtbZEBRA_FUSE_IPaddress.TabIndex = 37
        Me.txtbZEBRA_FUSE_IPaddress.Text = "xxx.xxx.xxx.xxx"
        Me.txtbZEBRA_FUSE_IPaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(6, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(108, 16)
        Me.Label61.TabIndex = 38
        Me.Label61.Text = "TCP/IP Address:"
        '
        'btnZEBRA_FUSE_print
        '
        Me.btnZEBRA_FUSE_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZEBRA_FUSE_print.Location = New System.Drawing.Point(5, 202)
        Me.btnZEBRA_FUSE_print.Name = "btnZEBRA_FUSE_print"
        Me.btnZEBRA_FUSE_print.Size = New System.Drawing.Size(190, 40)
        Me.btnZEBRA_FUSE_print.TabIndex = 0
        Me.btnZEBRA_FUSE_print.Text = "PRINT FUSE LABEL"
        Me.btnZEBRA_FUSE_print.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1912, 1053)
        Me.Controls.Add(Me.grpbxZEBRA1)
        Me.Controls.Add(Me.grpbxINIT)
        Me.Controls.Add(Me.btnStartSelectedPeripherals)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpbxMODBUS_TCP)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbxINITIALIZE)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpbxGPIB_TEGAM)
        Me.Controls.Add(Me.grpbxBarcodeScannerST1A)
        Me.Controls.Add(Me.grpbxRS232)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.grpbxINITIALIZE.ResumeLayout(False)
        Me.grpbxINITIALIZE.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxMODBUS_TCP.ResumeLayout(False)
        Me.grpbxMODBUS_TCP.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabpgCOGNEX_Insight.ResumeLayout(False)
        Me.tabpgCOGNEX_Insight.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.grpbxINIT.ResumeLayout(False)
        Me.grpbxINIT.PerformLayout()
        Me.grpbxZEBRA1.ResumeLayout(False)
        Me.grpbxZEBRA1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGPIB_OPEN As System.Windows.Forms.Button
    Friend WithEvents btnGPIB_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cbPrimaryAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbSecondaryAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cbBoardID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGPIB_READ As System.Windows.Forms.Button
    Friend WithEvents txtbReadGPIB As System.Windows.Forms.TextBox
    Friend WithEvents txtbWriteGPIB As System.Windows.Forms.TextBox
    Friend WithEvents btnGPIB_WRITE As System.Windows.Forms.Button
    Friend WithEvents btnGPIB_TERMINATE As System.Windows.Forms.Button
    Friend WithEvents btnRS232Write As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnGPIB_TRIGGER As System.Windows.Forms.Button
    Friend WithEvents btnOpenBarcodeDeviceST1A As System.Windows.Forms.Button
    Friend WithEvents txtbBCDevice_ReadST1A As System.Windows.Forms.TextBox
    Friend WithEvents btnBCDevice_LEDsOFFST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDGreenONST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_LEDRedONST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDevice_BeepST1A As System.Windows.Forms.Button
    Friend WithEvents btnBCDeviceEventSubscribeST1A As System.Windows.Forms.Button
    Friend WithEvents btnCloseBarcodeDeviceST1A As System.Windows.Forms.Button
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents txtbINI_FilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkbTEGAMGPIBInterface As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkbSymbolBarcodeST1A As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents btnLoadINI As System.Windows.Forms.Button
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
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents btnRS232Read As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabpgCOGNEX_Insight As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label43 As Label
    Friend WithEvents txtbUPPERresistanceLIMIT As TextBox
    Friend WithEvents txtbRESISTANCE As TextBox
    Friend WithEvents txtbLOWERresistanceLIMIT As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents btnGPIB_MEASURE As Button
    Friend WithEvents btnStartSelectedPeripherals As Button
    Friend WithEvents grpbxINIT As GroupBox
    Friend WithEvents txtbLOGfolder As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtbPRNfolder As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtbPRINTERstatus As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents txtbOPERATOR1 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtbPART_NUMBER As TextBox
    Friend WithEvents txtbBARCODEstatus As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txtbTEGAMstatus As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtbDBfilepath As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents txtbSHOP_PACK As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnGPIB_INIT As Button
    Friend WithEvents bkgworkGPIB_SLEEP As System.ComponentModel.BackgroundWorker
    Friend WithEvents prgsbarSleep1 As ProgressBar
    Friend WithEvents grpbxZEBRA1 As GroupBox
    Friend WithEvents btnZEBRA_FUSE_print As Button
    Friend WithEvents txtbDATECODE As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txtbPRN_TEMPLATE As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents txtbZEBRA_FUSE_IPaddress As TextBox
    Friend WithEvents Label61 As Label
End Class
