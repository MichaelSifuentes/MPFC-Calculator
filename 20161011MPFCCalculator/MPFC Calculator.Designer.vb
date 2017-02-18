<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMPFC
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblInventorFirst = New System.Windows.Forms.Label()
        Me.lblInventorLast = New System.Windows.Forms.Label()
        Me.grpTestInfo = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtTest = New System.Windows.Forms.TextBox()
        Me.grpInventor = New System.Windows.Forms.GroupBox()
        Me.txtInventorLast = New System.Windows.Forms.TextBox()
        Me.txtInventorFirst = New System.Windows.Forms.TextBox()
        Me.grpDriver = New System.Windows.Forms.GroupBox()
        Me.txtDriverPhone = New System.Windows.Forms.TextBox()
        Me.txtDriverLast = New System.Windows.Forms.TextBox()
        Me.txtDriverFirst = New System.Windows.Forms.TextBox()
        Me.cmoDriverID = New System.Windows.Forms.ComboBox()
        Me.picDriver = New System.Windows.Forms.PictureBox()
        Me.lblDriverPhone = New System.Windows.Forms.Label()
        Me.lblDriverLast = New System.Windows.Forms.Label()
        Me.lblDriverFirst = New System.Windows.Forms.Label()
        Me.lblDriverID = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAllTests = New System.Windows.Forms.Button()
        Me.cmoDV1 = New System.Windows.Forms.ComboBox()
        Me.cmoDV2 = New System.Windows.Forms.ComboBox()
        Me.cmoDV3 = New System.Windows.Forms.ComboBox()
        Me.cmoDV4 = New System.Windows.Forms.ComboBox()
        Me.txtDSM1 = New System.Windows.Forms.TextBox()
        Me.txtDEM1 = New System.Windows.Forms.TextBox()
        Me.txtDSF1 = New System.Windows.Forms.TextBox()
        Me.txtDSM2 = New System.Windows.Forms.TextBox()
        Me.txtDEM2 = New System.Windows.Forms.TextBox()
        Me.txtDSF2 = New System.Windows.Forms.TextBox()
        Me.txtDSM3 = New System.Windows.Forms.TextBox()
        Me.txtDEM3 = New System.Windows.Forms.TextBox()
        Me.txtDSF3 = New System.Windows.Forms.TextBox()
        Me.txtDSM4 = New System.Windows.Forms.TextBox()
        Me.txtDEM4 = New System.Windows.Forms.TextBox()
        Me.txtDSF4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDEF1 = New System.Windows.Forms.TextBox()
        Me.txtDEF2 = New System.Windows.Forms.TextBox()
        Me.txtDEF3 = New System.Windows.Forms.TextBox()
        Me.txtDEF4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRFC4 = New System.Windows.Forms.TextBox()
        Me.txtRFC3 = New System.Windows.Forms.TextBox()
        Me.txtRFC2 = New System.Windows.Forms.TextBox()
        Me.txtRFC1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRFU4 = New System.Windows.Forms.TextBox()
        Me.txtRM4 = New System.Windows.Forms.TextBox()
        Me.txtRF4 = New System.Windows.Forms.TextBox()
        Me.txtRFU3 = New System.Windows.Forms.TextBox()
        Me.txtRM3 = New System.Windows.Forms.TextBox()
        Me.txtRF3 = New System.Windows.Forms.TextBox()
        Me.txtRFU2 = New System.Windows.Forms.TextBox()
        Me.txtRM2 = New System.Windows.Forms.TextBox()
        Me.txtRF2 = New System.Windows.Forms.TextBox()
        Me.txtRFU1 = New System.Windows.Forms.TextBox()
        Me.txtRM1 = New System.Windows.Forms.TextBox()
        Me.txtRF1 = New System.Windows.Forms.TextBox()
        Me.txtRV1 = New System.Windows.Forms.TextBox()
        Me.txtRV2 = New System.Windows.Forms.TextBox()
        Me.txtRV3 = New System.Windows.Forms.TextBox()
        Me.txtRV4 = New System.Windows.Forms.TextBox()
        Me.txtRMPFCR1 = New System.Windows.Forms.TextBox()
        Me.txtRMPFCR2 = New System.Windows.Forms.TextBox()
        Me.txtRMPFCR3 = New System.Windows.Forms.TextBox()
        Me.txtRMPFCR4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panData = New System.Windows.Forms.Panel()
        Me.panResults = New System.Windows.Forms.Panel()
        Me.grpTestInfo.SuspendLayout()
        Me.grpInventor.SuspendLayout()
        Me.grpDriver.SuspendLayout()
        CType(Me.picDriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(14, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(299, 23)
        Me.lblTitle.TabIndex = 1000
        Me.lblTitle.Text = "Miles Per Fuel Cell (MPFC) Calculator"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(6, 23)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(38, 13)
        Me.lblTest.TabIndex = 1000
        Me.lblTest.Text = "Test #"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(7, 53)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1000
        Me.lblDate.Text = "Date:"
        '
        'lblInventorFirst
        '
        Me.lblInventorFirst.AutoSize = True
        Me.lblInventorFirst.Location = New System.Drawing.Point(6, 23)
        Me.lblInventorFirst.Name = "lblInventorFirst"
        Me.lblInventorFirst.Size = New System.Drawing.Size(60, 13)
        Me.lblInventorFirst.TabIndex = 1000
        Me.lblInventorFirst.Text = "First Name:"
        '
        'lblInventorLast
        '
        Me.lblInventorLast.AutoSize = True
        Me.lblInventorLast.Location = New System.Drawing.Point(6, 53)
        Me.lblInventorLast.Name = "lblInventorLast"
        Me.lblInventorLast.Size = New System.Drawing.Size(61, 13)
        Me.lblInventorLast.TabIndex = 1000
        Me.lblInventorLast.Text = "Last Name:"
        '
        'grpTestInfo
        '
        Me.grpTestInfo.Controls.Add(Me.txtDate)
        Me.grpTestInfo.Controls.Add(Me.txtTest)
        Me.grpTestInfo.Controls.Add(Me.lblTest)
        Me.grpTestInfo.Controls.Add(Me.lblDate)
        Me.grpTestInfo.Location = New System.Drawing.Point(16, 30)
        Me.grpTestInfo.Name = "grpTestInfo"
        Me.grpTestInfo.Size = New System.Drawing.Size(239, 91)
        Me.grpTestInfo.TabIndex = 1000
        Me.grpTestInfo.TabStop = False
        Me.grpTestInfo.Text = "Test Info"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(67, 50)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(135, 20)
        Me.txtDate.TabIndex = 1
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(67, 23)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(135, 20)
        Me.txtTest.TabIndex = 0
        '
        'grpInventor
        '
        Me.grpInventor.Controls.Add(Me.txtInventorLast)
        Me.grpInventor.Controls.Add(Me.txtInventorFirst)
        Me.grpInventor.Controls.Add(Me.lblInventorFirst)
        Me.grpInventor.Controls.Add(Me.lblInventorLast)
        Me.grpInventor.Location = New System.Drawing.Point(261, 30)
        Me.grpInventor.Name = "grpInventor"
        Me.grpInventor.Size = New System.Drawing.Size(223, 91)
        Me.grpInventor.TabIndex = 2
        Me.grpInventor.TabStop = False
        Me.grpInventor.Text = "Inventor Info"
        '
        'txtInventorLast
        '
        Me.txtInventorLast.Location = New System.Drawing.Point(72, 53)
        Me.txtInventorLast.Name = "txtInventorLast"
        Me.txtInventorLast.Size = New System.Drawing.Size(135, 20)
        Me.txtInventorLast.TabIndex = 4
        '
        'txtInventorFirst
        '
        Me.txtInventorFirst.Location = New System.Drawing.Point(72, 23)
        Me.txtInventorFirst.Name = "txtInventorFirst"
        Me.txtInventorFirst.Size = New System.Drawing.Size(135, 20)
        Me.txtInventorFirst.TabIndex = 3
        '
        'grpDriver
        '
        Me.grpDriver.Controls.Add(Me.txtDriverPhone)
        Me.grpDriver.Controls.Add(Me.txtDriverLast)
        Me.grpDriver.Controls.Add(Me.txtDriverFirst)
        Me.grpDriver.Controls.Add(Me.cmoDriverID)
        Me.grpDriver.Controls.Add(Me.picDriver)
        Me.grpDriver.Controls.Add(Me.lblDriverPhone)
        Me.grpDriver.Controls.Add(Me.lblDriverLast)
        Me.grpDriver.Controls.Add(Me.lblDriverFirst)
        Me.grpDriver.Controls.Add(Me.lblDriverID)
        Me.grpDriver.Location = New System.Drawing.Point(17, 127)
        Me.grpDriver.Name = "grpDriver"
        Me.grpDriver.Size = New System.Drawing.Size(467, 173)
        Me.grpDriver.TabIndex = 5
        Me.grpDriver.TabStop = False
        Me.grpDriver.Text = "Driver Info"
        '
        'txtDriverPhone
        '
        Me.txtDriverPhone.Location = New System.Drawing.Point(63, 101)
        Me.txtDriverPhone.Name = "txtDriverPhone"
        Me.txtDriverPhone.ReadOnly = True
        Me.txtDriverPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtDriverPhone.TabIndex = 1000
        Me.txtDriverPhone.TabStop = False
        '
        'txtDriverLast
        '
        Me.txtDriverLast.Location = New System.Drawing.Point(66, 75)
        Me.txtDriverLast.Name = "txtDriverLast"
        Me.txtDriverLast.ReadOnly = True
        Me.txtDriverLast.Size = New System.Drawing.Size(135, 20)
        Me.txtDriverLast.TabIndex = 1000
        Me.txtDriverLast.TabStop = False
        '
        'txtDriverFirst
        '
        Me.txtDriverFirst.Location = New System.Drawing.Point(66, 48)
        Me.txtDriverFirst.Name = "txtDriverFirst"
        Me.txtDriverFirst.ReadOnly = True
        Me.txtDriverFirst.Size = New System.Drawing.Size(135, 20)
        Me.txtDriverFirst.TabIndex = 1000
        Me.txtDriverFirst.TabStop = False
        '
        'cmoDriverID
        '
        Me.cmoDriverID.FormattingEnabled = True
        Me.cmoDriverID.Items.AddRange(New Object() {"100", "200", "300", "400"})
        Me.cmoDriverID.Location = New System.Drawing.Point(66, 21)
        Me.cmoDriverID.Name = "cmoDriverID"
        Me.cmoDriverID.Size = New System.Drawing.Size(135, 21)
        Me.cmoDriverID.TabIndex = 6
        '
        'picDriver
        '
        Me.picDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picDriver.Location = New System.Drawing.Point(244, 19)
        Me.picDriver.Name = "picDriver"
        Me.picDriver.Size = New System.Drawing.Size(207, 135)
        Me.picDriver.TabIndex = 1000
        Me.picDriver.TabStop = False
        '
        'lblDriverPhone
        '
        Me.lblDriverPhone.AutoSize = True
        Me.lblDriverPhone.Location = New System.Drawing.Point(6, 104)
        Me.lblDriverPhone.Name = "lblDriverPhone"
        Me.lblDriverPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblDriverPhone.TabIndex = 1000
        Me.lblDriverPhone.Text = "Phone:"
        '
        'lblDriverLast
        '
        Me.lblDriverLast.AutoSize = True
        Me.lblDriverLast.Location = New System.Drawing.Point(5, 78)
        Me.lblDriverLast.Name = "lblDriverLast"
        Me.lblDriverLast.Size = New System.Drawing.Size(61, 13)
        Me.lblDriverLast.TabIndex = 1000
        Me.lblDriverLast.Text = "Last Name:"
        '
        'lblDriverFirst
        '
        Me.lblDriverFirst.AutoSize = True
        Me.lblDriverFirst.Location = New System.Drawing.Point(6, 48)
        Me.lblDriverFirst.Name = "lblDriverFirst"
        Me.lblDriverFirst.Size = New System.Drawing.Size(60, 13)
        Me.lblDriverFirst.TabIndex = 1000
        Me.lblDriverFirst.Text = "First Name:"
        '
        'lblDriverID
        '
        Me.lblDriverID.AutoSize = True
        Me.lblDriverID.Location = New System.Drawing.Point(6, 21)
        Me.lblDriverID.Name = "lblDriverID"
        Me.lblDriverID.Size = New System.Drawing.Size(21, 13)
        Me.lblDriverID.TabIndex = 1000
        Me.lblDriverID.Text = "ID:"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(17, 584)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 11
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(108, 584)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAllTests
        '
        Me.btnAllTests.Location = New System.Drawing.Point(297, 584)
        Me.btnAllTests.Name = "btnAllTests"
        Me.btnAllTests.Size = New System.Drawing.Size(75, 23)
        Me.btnAllTests.TabIndex = 13
        Me.btnAllTests.Text = "&All Tests"
        Me.btnAllTests.UseVisualStyleBackColor = True
        '
        'cmoDV1
        '
        Me.cmoDV1.FormattingEnabled = True
        Me.cmoDV1.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cmoDV1.Location = New System.Drawing.Point(48, 331)
        Me.cmoDV1.Name = "cmoDV1"
        Me.cmoDV1.Size = New System.Drawing.Size(72, 21)
        Me.cmoDV1.TabIndex = 7
        '
        'cmoDV2
        '
        Me.cmoDV2.FormattingEnabled = True
        Me.cmoDV2.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cmoDV2.Location = New System.Drawing.Point(48, 358)
        Me.cmoDV2.Name = "cmoDV2"
        Me.cmoDV2.Size = New System.Drawing.Size(72, 21)
        Me.cmoDV2.TabIndex = 8
        '
        'cmoDV3
        '
        Me.cmoDV3.FormattingEnabled = True
        Me.cmoDV3.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cmoDV3.Location = New System.Drawing.Point(48, 385)
        Me.cmoDV3.Name = "cmoDV3"
        Me.cmoDV3.Size = New System.Drawing.Size(72, 21)
        Me.cmoDV3.TabIndex = 9
        '
        'cmoDV4
        '
        Me.cmoDV4.FormattingEnabled = True
        Me.cmoDV4.Items.AddRange(New Object() {"Banshee", "Ghost", "Chopper", "Hornet"})
        Me.cmoDV4.Location = New System.Drawing.Point(48, 412)
        Me.cmoDV4.Name = "cmoDV4"
        Me.cmoDV4.Size = New System.Drawing.Size(72, 21)
        Me.cmoDV4.TabIndex = 10
        '
        'txtDSM1
        '
        Me.txtDSM1.Location = New System.Drawing.Point(128, 331)
        Me.txtDSM1.Name = "txtDSM1"
        Me.txtDSM1.Size = New System.Drawing.Size(72, 20)
        Me.txtDSM1.TabIndex = 1000
        '
        'txtDEM1
        '
        Me.txtDEM1.Location = New System.Drawing.Point(206, 331)
        Me.txtDEM1.Name = "txtDEM1"
        Me.txtDEM1.Size = New System.Drawing.Size(72, 20)
        Me.txtDEM1.TabIndex = 1000
        '
        'txtDSF1
        '
        Me.txtDSF1.Location = New System.Drawing.Point(284, 331)
        Me.txtDSF1.Name = "txtDSF1"
        Me.txtDSF1.Size = New System.Drawing.Size(72, 20)
        Me.txtDSF1.TabIndex = 1000
        '
        'txtDSM2
        '
        Me.txtDSM2.Location = New System.Drawing.Point(128, 359)
        Me.txtDSM2.Name = "txtDSM2"
        Me.txtDSM2.Size = New System.Drawing.Size(72, 20)
        Me.txtDSM2.TabIndex = 1000
        '
        'txtDEM2
        '
        Me.txtDEM2.Location = New System.Drawing.Point(206, 359)
        Me.txtDEM2.Name = "txtDEM2"
        Me.txtDEM2.Size = New System.Drawing.Size(72, 20)
        Me.txtDEM2.TabIndex = 1000
        '
        'txtDSF2
        '
        Me.txtDSF2.Location = New System.Drawing.Point(284, 358)
        Me.txtDSF2.Name = "txtDSF2"
        Me.txtDSF2.Size = New System.Drawing.Size(72, 20)
        Me.txtDSF2.TabIndex = 1000
        '
        'txtDSM3
        '
        Me.txtDSM3.Location = New System.Drawing.Point(128, 385)
        Me.txtDSM3.Name = "txtDSM3"
        Me.txtDSM3.Size = New System.Drawing.Size(72, 20)
        Me.txtDSM3.TabIndex = 1000
        '
        'txtDEM3
        '
        Me.txtDEM3.Location = New System.Drawing.Point(206, 386)
        Me.txtDEM3.Name = "txtDEM3"
        Me.txtDEM3.Size = New System.Drawing.Size(72, 20)
        Me.txtDEM3.TabIndex = 1000
        '
        'txtDSF3
        '
        Me.txtDSF3.Location = New System.Drawing.Point(284, 385)
        Me.txtDSF3.Name = "txtDSF3"
        Me.txtDSF3.Size = New System.Drawing.Size(72, 20)
        Me.txtDSF3.TabIndex = 1000
        '
        'txtDSM4
        '
        Me.txtDSM4.Location = New System.Drawing.Point(128, 413)
        Me.txtDSM4.Name = "txtDSM4"
        Me.txtDSM4.Size = New System.Drawing.Size(72, 20)
        Me.txtDSM4.TabIndex = 1000
        '
        'txtDEM4
        '
        Me.txtDEM4.Location = New System.Drawing.Point(206, 413)
        Me.txtDEM4.Name = "txtDEM4"
        Me.txtDEM4.Size = New System.Drawing.Size(72, 20)
        Me.txtDEM4.TabIndex = 1000
        '
        'txtDSF4
        '
        Me.txtDSF4.Location = New System.Drawing.Point(284, 413)
        Me.txtDSF4.Name = "txtDSF4"
        Me.txtDSF4.Size = New System.Drawing.Size(72, 20)
        Me.txtDSF4.TabIndex = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1000
        Me.Label1.Text = "Vehicle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1000
        Me.Label2.Text = "Start Mileage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1000
        Me.Label3.Text = "End Mileage:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1000
        Me.Label4.Text = "Start Fuel:"
        '
        'txtDEF1
        '
        Me.txtDEF1.Location = New System.Drawing.Point(364, 330)
        Me.txtDEF1.Name = "txtDEF1"
        Me.txtDEF1.Size = New System.Drawing.Size(72, 20)
        Me.txtDEF1.TabIndex = 1000
        '
        'txtDEF2
        '
        Me.txtDEF2.Location = New System.Drawing.Point(364, 358)
        Me.txtDEF2.Name = "txtDEF2"
        Me.txtDEF2.Size = New System.Drawing.Size(72, 20)
        Me.txtDEF2.TabIndex = 1000
        '
        'txtDEF3
        '
        Me.txtDEF3.Location = New System.Drawing.Point(363, 385)
        Me.txtDEF3.Name = "txtDEF3"
        Me.txtDEF3.Size = New System.Drawing.Size(72, 20)
        Me.txtDEF3.TabIndex = 1000
        '
        'txtDEF4
        '
        Me.txtDEF4.Location = New System.Drawing.Point(364, 412)
        Me.txtDEF4.Name = "txtDEF4"
        Me.txtDEF4.Size = New System.Drawing.Size(72, 20)
        Me.txtDEF4.TabIndex = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 1000
        Me.Label5.Text = "End Fuel:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(363, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 1000
        Me.Label6.Text = "Fuel Cost:"
        '
        'txtRFC4
        '
        Me.txtRFC4.Location = New System.Drawing.Point(364, 553)
        Me.txtRFC4.Name = "txtRFC4"
        Me.txtRFC4.ReadOnly = True
        Me.txtRFC4.Size = New System.Drawing.Size(72, 20)
        Me.txtRFC4.TabIndex = 1000
        '
        'txtRFC3
        '
        Me.txtRFC3.Location = New System.Drawing.Point(363, 526)
        Me.txtRFC3.Name = "txtRFC3"
        Me.txtRFC3.ReadOnly = True
        Me.txtRFC3.Size = New System.Drawing.Size(72, 20)
        Me.txtRFC3.TabIndex = 1000
        '
        'txtRFC2
        '
        Me.txtRFC2.Location = New System.Drawing.Point(364, 499)
        Me.txtRFC2.Name = "txtRFC2"
        Me.txtRFC2.ReadOnly = True
        Me.txtRFC2.Size = New System.Drawing.Size(72, 20)
        Me.txtRFC2.TabIndex = 1000
        '
        'txtRFC1
        '
        Me.txtRFC1.Location = New System.Drawing.Point(364, 471)
        Me.txtRFC1.Name = "txtRFC1"
        Me.txtRFC1.ReadOnly = True
        Me.txtRFC1.Size = New System.Drawing.Size(72, 20)
        Me.txtRFC1.TabIndex = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(297, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 1000
        Me.Label7.Text = "Fuel Used:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(216, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 1000
        Me.Label8.Text = "Mileage:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(125, 444)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 1000
        Me.Label9.Text = "Family:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(62, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 1000
        Me.Label10.Text = "Vehicle:"
        '
        'txtRFU4
        '
        Me.txtRFU4.Location = New System.Drawing.Point(284, 554)
        Me.txtRFU4.Name = "txtRFU4"
        Me.txtRFU4.ReadOnly = True
        Me.txtRFU4.Size = New System.Drawing.Size(72, 20)
        Me.txtRFU4.TabIndex = 1000
        '
        'txtRM4
        '
        Me.txtRM4.Location = New System.Drawing.Point(206, 554)
        Me.txtRM4.Name = "txtRM4"
        Me.txtRM4.ReadOnly = True
        Me.txtRM4.Size = New System.Drawing.Size(72, 20)
        Me.txtRM4.TabIndex = 1000
        '
        'txtRF4
        '
        Me.txtRF4.Location = New System.Drawing.Point(128, 554)
        Me.txtRF4.Name = "txtRF4"
        Me.txtRF4.ReadOnly = True
        Me.txtRF4.Size = New System.Drawing.Size(72, 20)
        Me.txtRF4.TabIndex = 1000
        '
        'txtRFU3
        '
        Me.txtRFU3.Location = New System.Drawing.Point(285, 526)
        Me.txtRFU3.Name = "txtRFU3"
        Me.txtRFU3.ReadOnly = True
        Me.txtRFU3.Size = New System.Drawing.Size(72, 20)
        Me.txtRFU3.TabIndex = 1000
        '
        'txtRM3
        '
        Me.txtRM3.Location = New System.Drawing.Point(206, 527)
        Me.txtRM3.Name = "txtRM3"
        Me.txtRM3.ReadOnly = True
        Me.txtRM3.Size = New System.Drawing.Size(72, 20)
        Me.txtRM3.TabIndex = 1000
        '
        'txtRF3
        '
        Me.txtRF3.Location = New System.Drawing.Point(128, 526)
        Me.txtRF3.Name = "txtRF3"
        Me.txtRF3.ReadOnly = True
        Me.txtRF3.Size = New System.Drawing.Size(72, 20)
        Me.txtRF3.TabIndex = 1000
        '
        'txtRFU2
        '
        Me.txtRFU2.Location = New System.Drawing.Point(285, 499)
        Me.txtRFU2.Name = "txtRFU2"
        Me.txtRFU2.ReadOnly = True
        Me.txtRFU2.Size = New System.Drawing.Size(72, 20)
        Me.txtRFU2.TabIndex = 1000
        '
        'txtRM2
        '
        Me.txtRM2.Location = New System.Drawing.Point(206, 500)
        Me.txtRM2.Name = "txtRM2"
        Me.txtRM2.ReadOnly = True
        Me.txtRM2.Size = New System.Drawing.Size(72, 20)
        Me.txtRM2.TabIndex = 1000
        '
        'txtRF2
        '
        Me.txtRF2.Location = New System.Drawing.Point(128, 500)
        Me.txtRF2.Name = "txtRF2"
        Me.txtRF2.ReadOnly = True
        Me.txtRF2.Size = New System.Drawing.Size(72, 20)
        Me.txtRF2.TabIndex = 1000
        '
        'txtRFU1
        '
        Me.txtRFU1.Location = New System.Drawing.Point(284, 472)
        Me.txtRFU1.Name = "txtRFU1"
        Me.txtRFU1.ReadOnly = True
        Me.txtRFU1.Size = New System.Drawing.Size(72, 20)
        Me.txtRFU1.TabIndex = 1000
        '
        'txtRM1
        '
        Me.txtRM1.Location = New System.Drawing.Point(206, 472)
        Me.txtRM1.Name = "txtRM1"
        Me.txtRM1.ReadOnly = True
        Me.txtRM1.Size = New System.Drawing.Size(72, 20)
        Me.txtRM1.TabIndex = 1000
        '
        'txtRF1
        '
        Me.txtRF1.Location = New System.Drawing.Point(128, 472)
        Me.txtRF1.Name = "txtRF1"
        Me.txtRF1.ReadOnly = True
        Me.txtRF1.Size = New System.Drawing.Size(72, 20)
        Me.txtRF1.TabIndex = 1000
        '
        'txtRV1
        '
        Me.txtRV1.Location = New System.Drawing.Point(50, 474)
        Me.txtRV1.Name = "txtRV1"
        Me.txtRV1.ReadOnly = True
        Me.txtRV1.Size = New System.Drawing.Size(72, 20)
        Me.txtRV1.TabIndex = 1000
        '
        'txtRV2
        '
        Me.txtRV2.Location = New System.Drawing.Point(50, 499)
        Me.txtRV2.Name = "txtRV2"
        Me.txtRV2.ReadOnly = True
        Me.txtRV2.Size = New System.Drawing.Size(72, 20)
        Me.txtRV2.TabIndex = 1000
        '
        'txtRV3
        '
        Me.txtRV3.Location = New System.Drawing.Point(50, 527)
        Me.txtRV3.Name = "txtRV3"
        Me.txtRV3.ReadOnly = True
        Me.txtRV3.Size = New System.Drawing.Size(72, 20)
        Me.txtRV3.TabIndex = 1000
        '
        'txtRV4
        '
        Me.txtRV4.Location = New System.Drawing.Point(50, 553)
        Me.txtRV4.Name = "txtRV4"
        Me.txtRV4.ReadOnly = True
        Me.txtRV4.Size = New System.Drawing.Size(72, 20)
        Me.txtRV4.TabIndex = 1000
        '
        'txtRMPFCR1
        '
        Me.txtRMPFCR1.Location = New System.Drawing.Point(442, 471)
        Me.txtRMPFCR1.Name = "txtRMPFCR1"
        Me.txtRMPFCR1.ReadOnly = True
        Me.txtRMPFCR1.Size = New System.Drawing.Size(72, 20)
        Me.txtRMPFCR1.TabIndex = 1000
        '
        'txtRMPFCR2
        '
        Me.txtRMPFCR2.Location = New System.Drawing.Point(442, 500)
        Me.txtRMPFCR2.Name = "txtRMPFCR2"
        Me.txtRMPFCR2.ReadOnly = True
        Me.txtRMPFCR2.Size = New System.Drawing.Size(72, 20)
        Me.txtRMPFCR2.TabIndex = 1000
        '
        'txtRMPFCR3
        '
        Me.txtRMPFCR3.Location = New System.Drawing.Point(442, 527)
        Me.txtRMPFCR3.Name = "txtRMPFCR3"
        Me.txtRMPFCR3.ReadOnly = True
        Me.txtRMPFCR3.Size = New System.Drawing.Size(72, 20)
        Me.txtRMPFCR3.TabIndex = 1000
        '
        'txtRMPFCR4
        '
        Me.txtRMPFCR4.Location = New System.Drawing.Point(441, 553)
        Me.txtRMPFCR4.Name = "txtRMPFCR4"
        Me.txtRMPFCR4.ReadOnly = True
        Me.txtRMPFCR4.Size = New System.Drawing.Size(72, 20)
        Me.txtRMPFCR4.TabIndex = 1000
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(439, 445)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 1000
        Me.Label11.Text = "MPFC Rating"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(15, 330)
        Me.Label12.MaximumSize = New System.Drawing.Size(15, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 104)
        Me.Label12.TabIndex = 1000
        Me.Label12.Text = "     DATA       "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(13, 465)
        Me.Label13.MaximumSize = New System.Drawing.Size(15, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 117)
        Me.Label13.TabIndex = 1000
        Me.Label13.Text = "  RESULTS    "
        '
        'panData
        '
        Me.panData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panData.Location = New System.Drawing.Point(37, 324)
        Me.panData.Name = "panData"
        Me.panData.Size = New System.Drawing.Size(487, 109)
        Me.panData.TabIndex = 1000
        '
        'panResults
        '
        Me.panResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panResults.Location = New System.Drawing.Point(37, 465)
        Me.panResults.Name = "panResults"
        Me.panResults.Size = New System.Drawing.Size(487, 109)
        Me.panResults.TabIndex = 1000
        '
        'FrmMPFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 619)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRMPFCR4)
        Me.Controls.Add(Me.txtRMPFCR3)
        Me.Controls.Add(Me.txtRMPFCR2)
        Me.Controls.Add(Me.txtRMPFCR1)
        Me.Controls.Add(Me.txtRV4)
        Me.Controls.Add(Me.txtRV3)
        Me.Controls.Add(Me.txtRV2)
        Me.Controls.Add(Me.txtRV1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRFC4)
        Me.Controls.Add(Me.txtRFC3)
        Me.Controls.Add(Me.txtRFC2)
        Me.Controls.Add(Me.txtRFC1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRFU4)
        Me.Controls.Add(Me.txtRM4)
        Me.Controls.Add(Me.txtRF4)
        Me.Controls.Add(Me.txtRFU3)
        Me.Controls.Add(Me.txtRM3)
        Me.Controls.Add(Me.txtRF3)
        Me.Controls.Add(Me.txtRFU2)
        Me.Controls.Add(Me.txtRM2)
        Me.Controls.Add(Me.txtRF2)
        Me.Controls.Add(Me.txtRFU1)
        Me.Controls.Add(Me.txtRM1)
        Me.Controls.Add(Me.txtRF1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDEF4)
        Me.Controls.Add(Me.txtDEF3)
        Me.Controls.Add(Me.txtDEF2)
        Me.Controls.Add(Me.txtDEF1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDSF4)
        Me.Controls.Add(Me.txtDEM4)
        Me.Controls.Add(Me.txtDSM4)
        Me.Controls.Add(Me.txtDSF3)
        Me.Controls.Add(Me.txtDEM3)
        Me.Controls.Add(Me.txtDSM3)
        Me.Controls.Add(Me.txtDSF2)
        Me.Controls.Add(Me.txtDEM2)
        Me.Controls.Add(Me.txtDSM2)
        Me.Controls.Add(Me.txtDSF1)
        Me.Controls.Add(Me.txtDEM1)
        Me.Controls.Add(Me.txtDSM1)
        Me.Controls.Add(Me.cmoDV4)
        Me.Controls.Add(Me.cmoDV3)
        Me.Controls.Add(Me.cmoDV2)
        Me.Controls.Add(Me.cmoDV1)
        Me.Controls.Add(Me.btnAllTests)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.grpDriver)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpInventor)
        Me.Controls.Add(Me.grpTestInfo)
        Me.Controls.Add(Me.panData)
        Me.Controls.Add(Me.panResults)
        Me.Name = "FrmMPFC"
        Me.Text = "MPFC Calculator"
        Me.grpTestInfo.ResumeLayout(False)
        Me.grpTestInfo.PerformLayout()
        Me.grpInventor.ResumeLayout(False)
        Me.grpInventor.PerformLayout()
        Me.grpDriver.ResumeLayout(False)
        Me.grpDriver.PerformLayout()
        CType(Me.picDriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblInventorFirst As System.Windows.Forms.Label
    Friend WithEvents lblInventorLast As System.Windows.Forms.Label
    Friend WithEvents grpTestInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpInventor As System.Windows.Forms.GroupBox
    Friend WithEvents grpDriver As System.Windows.Forms.GroupBox
    Friend WithEvents lblDriverLast As System.Windows.Forms.Label
    Friend WithEvents lblDriverFirst As System.Windows.Forms.Label
    Friend WithEvents lblDriverID As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtTest As System.Windows.Forms.TextBox
    Friend WithEvents txtInventorLast As System.Windows.Forms.TextBox
    Friend WithEvents txtInventorFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverLast As System.Windows.Forms.TextBox
    Friend WithEvents txtDriverFirst As System.Windows.Forms.TextBox
    Friend WithEvents cmoDriverID As System.Windows.Forms.ComboBox
    Friend WithEvents picDriver As System.Windows.Forms.PictureBox
    Friend WithEvents lblDriverPhone As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAllTests As System.Windows.Forms.Button
    Friend WithEvents cmoDV1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmoDV2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmoDV3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmoDV4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtDSM1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEM1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSM2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEM2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSM3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEM3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSM4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEM4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDSF4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDEF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDEF4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRFC4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRFU4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRM4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRF4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFU3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRM3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRF3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFU2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRM2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRF2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFU1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRM1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRF1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRV1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRV2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRV3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRV4 As System.Windows.Forms.TextBox
    Friend WithEvents txtRMPFCR1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRMPFCR2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRMPFCR3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRMPFCR4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents panData As System.Windows.Forms.Panel
    Friend WithEvents panResults As System.Windows.Forms.Panel

End Class
