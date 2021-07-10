<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class boreader_panelcontrol
#Region "Windows 窗体设计器生成的代码 "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        '此调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub
    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Command31 As System.Windows.Forms.Button
    Public WithEvents Timer2 As System.Windows.Forms.Timer
    Public WithEvents BtnLeerReg As System.Windows.Forms.Button
    Public WithEvents Command23 As System.Windows.Forms.Button
    Public WithEvents BtnTotales As System.Windows.Forms.Button
    Public WithEvents Command19 As System.Windows.Forms.Button
    Public WithEvents Command18 As System.Windows.Forms.Button
    Public WithEvents BtnReaderFile As System.Windows.Forms.Button
    Public WithEvents BtnWriteFile As System.Windows.Forms.Button
    Public WithEvents Command8 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器来修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(boreader_panelcontrol))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command31 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLeerReg = New System.Windows.Forms.Button()
        Me.Command23 = New System.Windows.Forms.Button()
        Me.BtnTotales = New System.Windows.Forms.Button()
        Me.Command19 = New System.Windows.Forms.Button()
        Me.Command18 = New System.Windows.Forms.Button()
        Me.BtnReaderFile = New System.Windows.Forms.Button()
        Me.BtnWriteFile = New System.Windows.Forms.Button()
        Me.Command8 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblId1 = New System.Windows.Forms.Label()
        Me.RadioCom = New System.Windows.Forms.RadioButton()
        Me.RadioNet = New System.Windows.Forms.RadioButton()
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.BtnNetDaemon = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.BtnHora = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnGenerarTXT = New System.Windows.Forms.Button()
        Me.Command10 = New System.Windows.Forms.Button()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblUltima = New System.Windows.Forms.Label()
        Me.lblEstado1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.cmbId = New System.Windows.Forms.ComboBox()
        Me.lblIntervalo = New System.Windows.Forms.Label()
        Me.txtIntervalo = New System.Windows.Forms.TextBox()
        Me.txttiempo = New System.Windows.Forms.Label()
        Me.Notify_icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSetDate = New System.Windows.Forms.Button()
        Me.Command22 = New System.Windows.Forms.Button()
        Me.lblErrorIntervalo = New System.Windows.Forms.Label()
        Me.lblArchivo1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Command31
        '
        Me.Command31.BackColor = System.Drawing.SystemColors.Control
        Me.Command31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command31.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command31.Location = New System.Drawing.Point(525, 90)
        Me.Command31.Name = "Command31"
        Me.Command31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command31.Size = New System.Drawing.Size(151, 25)
        Me.Command31.TabIndex = 30
        Me.Command31.Text = "Informaci髇..."
        Me.Command31.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 100000000
        '
        'BtnLeerReg
        '
        Me.BtnLeerReg.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLeerReg.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnLeerReg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLeerReg.Location = New System.Drawing.Point(173, 424)
        Me.BtnLeerReg.Name = "BtnLeerReg"
        Me.BtnLeerReg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnLeerReg.Size = New System.Drawing.Size(126, 25)
        Me.BtnLeerReg.TabIndex = 23
        Me.BtnLeerReg.Text = "Leer &Registros"
        Me.BtnLeerReg.UseVisualStyleBackColor = False
        '
        'Command23
        '
        Me.Command23.BackColor = System.Drawing.SystemColors.Control
        Me.Command23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command23.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command23.Location = New System.Drawing.Point(23, 358)
        Me.Command23.Name = "Command23"
        Me.Command23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command23.Size = New System.Drawing.Size(127, 25)
        Me.Command23.TabIndex = 22
        Me.Command23.Text = "Get/Add Message"
        Me.Command23.UseVisualStyleBackColor = False
        '
        'BtnTotales
        '
        Me.BtnTotales.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTotales.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnTotales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnTotales.Location = New System.Drawing.Point(523, 188)
        Me.BtnTotales.Name = "BtnTotales"
        Me.BtnTotales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTotales.Size = New System.Drawing.Size(152, 25)
        Me.BtnTotales.TabIndex = 19
        Me.BtnTotales.Text = "Leer Totales ..."
        Me.BtnTotales.UseVisualStyleBackColor = False
        '
        'Command19
        '
        Me.Command19.BackColor = System.Drawing.SystemColors.Control
        Me.Command19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command19.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command19.Location = New System.Drawing.Point(23, 486)
        Me.Command19.Name = "Command19"
        Me.Command19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command19.Size = New System.Drawing.Size(124, 25)
        Me.Command19.TabIndex = 18
        Me.Command19.Text = "Leer &Usuarios"
        Me.Command19.UseVisualStyleBackColor = False
        '
        'Command18
        '
        Me.Command18.BackColor = System.Drawing.SystemColors.Control
        Me.Command18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command18.Location = New System.Drawing.Point(23, 391)
        Me.Command18.Name = "Command18"
        Me.Command18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command18.Size = New System.Drawing.Size(127, 25)
        Me.Command18.TabIndex = 17
        Me.Command18.Text = "Get All Message Head" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Command18.UseVisualStyleBackColor = False
        '
        'BtnReaderFile
        '
        Me.BtnReaderFile.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReaderFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnReaderFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReaderFile.Location = New System.Drawing.Point(22, 455)
        Me.BtnReaderFile.Name = "BtnReaderFile"
        Me.BtnReaderFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnReaderFile.Size = New System.Drawing.Size(127, 25)
        Me.BtnReaderFile.TabIndex = 11
        Me.BtnReaderFile.Text = "Read file,set FP"
        Me.BtnReaderFile.UseVisualStyleBackColor = False
        '
        'BtnWriteFile
        '
        Me.BtnWriteFile.BackColor = System.Drawing.SystemColors.Control
        Me.BtnWriteFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnWriteFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnWriteFile.Location = New System.Drawing.Point(173, 455)
        Me.BtnWriteFile.Name = "BtnWriteFile"
        Me.BtnWriteFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnWriteFile.Size = New System.Drawing.Size(127, 25)
        Me.BtnWriteFile.TabIndex = 10
        Me.BtnWriteFile.Text = "Get FP,write file"
        Me.BtnWriteFile.UseVisualStyleBackColor = False
        '
        'Command8
        '
        Me.Command8.BackColor = System.Drawing.SystemColors.Control
        Me.Command8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command8.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command8.Location = New System.Drawing.Point(525, 155)
        Me.Command8.Name = "Command8"
        Me.Command8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command8.Size = New System.Drawing.Size(151, 25)
        Me.Command8.TabIndex = 7
        Me.Command8.Text = "Leer fecha y hora"
        Me.Command8.UseVisualStyleBackColor = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(525, 124)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(151, 25)
        Me.Command2.TabIndex = 1
        Me.Command2.Text = "Datos red..."
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(12, 308)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(126, 25)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Get From NET Device"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(171, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(128, 25)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Set/Get HitRingInfo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.Control
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(524, 19)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStart.Size = New System.Drawing.Size(151, 25)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Conectarse..."
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.SystemColors.Control
        Me.btnEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnd.Location = New System.Drawing.Point(524, 54)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEnd.Size = New System.Drawing.Size(151, 25)
        Me.btnEnd.TabIndex = 35
        Me.btnEnd.Text = "Cerrar conexi髇"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(172, 358)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(127, 25)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Set/Get Time Section"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'lblId1
        '
        Me.lblId1.AutoSize = True
        Me.lblId1.Location = New System.Drawing.Point(25, 34)
        Me.lblId1.Name = "lblId1"
        Me.lblId1.Size = New System.Drawing.Size(22, 13)
        Me.lblId1.TabIndex = 42
        Me.lblId1.Text = "ID:"
        '
        'RadioCom
        '
        Me.RadioCom.AutoSize = True
        Me.RadioCom.Location = New System.Drawing.Point(43, 124)
        Me.RadioCom.Name = "RadioCom"
        Me.RadioCom.Size = New System.Drawing.Size(46, 17)
        Me.RadioCom.TabIndex = 43
        Me.RadioCom.Text = "Com"
        Me.RadioCom.UseVisualStyleBackColor = True
        '
        'RadioNet
        '
        Me.RadioNet.AutoSize = True
        Me.RadioNet.Checked = True
        Me.RadioNet.Location = New System.Drawing.Point(41, 62)
        Me.RadioNet.Name = "RadioNet"
        Me.RadioNet.Size = New System.Drawing.Size(42, 17)
        Me.RadioNet.TabIndex = 44
        Me.RadioNet.TabStop = True
        Me.RadioNet.Text = "Lan"
        Me.RadioNet.UseVisualStyleBackColor = True
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Enabled = False
        Me.lblComPort.Location = New System.Drawing.Point(120, 126)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(57, 13)
        Me.lblComPort.TabIndex = 45
        Me.lblComPort.Text = "COM Port:"
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.Location = New System.Drawing.Point(153, 64)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(24, 13)
        Me.lblIp.TabIndex = 46
        Me.lblIp.Text = "IP :"
        '
        'cmbComPort
        '
        Me.cmbComPort.Enabled = False
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9"})
        Me.cmbComPort.Location = New System.Drawing.Point(187, 123)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(53, 21)
        Me.cmbComPort.TabIndex = 47
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(189, 62)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(72, 21)
        Me.txtIp.TabIndex = 48
        Me.txtIp.Text = "10.0.0.249"
        '
        'BtnNetDaemon
        '
        Me.BtnNetDaemon.BackColor = System.Drawing.SystemColors.Control
        Me.BtnNetDaemon.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnNetDaemon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNetDaemon.Location = New System.Drawing.Point(181, 296)
        Me.BtnNetDaemon.Name = "BtnNetDaemon"
        Me.BtnNetDaemon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNetDaemon.Size = New System.Drawing.Size(126, 25)
        Me.BtnNetDaemon.TabIndex = 50
        Me.BtnNetDaemon.Text = "Net Daemon"
        Me.BtnNetDaemon.UseVisualStyleBackColor = False
        Me.BtnNetDaemon.Visible = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button11.Location = New System.Drawing.Point(148, 293)
        Me.Button11.Name = "Button11"
        Me.Button11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button11.Size = New System.Drawing.Size(126, 25)
        Me.Button11.TabIndex = 49
        Me.Button11.Text = "Com Daemon"
        Me.Button11.UseVisualStyleBackColor = False
        Me.Button11.Visible = False
        '
        'BtnHora
        '
        Me.BtnHora.BackColor = System.Drawing.SystemColors.Control
        Me.BtnHora.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnHora.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHora.Location = New System.Drawing.Point(171, 327)
        Me.BtnHora.Name = "BtnHora"
        Me.BtnHora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnHora.Size = New System.Drawing.Size(127, 25)
        Me.BtnHora.TabIndex = 36
        Me.BtnHora.Text = "Set/Get Time Section"
        Me.BtnHora.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader13})
        Me.ListView1.Location = New System.Drawing.Point(833, 123)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(274, 223)
        Me.ListView1.TabIndex = 51
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Staffer No"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date/Time"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Machine ID"
        Me.ColumnHeader13.Width = 79
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(211, 244)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(257, 19)
        Me.ProgressBar1.TabIndex = 52
        Me.ProgressBar1.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(37, 223)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(274, 23)
        Me.ProgressBar2.TabIndex = 53
        Me.ProgressBar2.Visible = False
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Location = New System.Drawing.Point(1113, 123)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(274, 223)
        Me.ListView2.TabIndex = 55
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        Me.ListView2.Visible = False
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "No"
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Staffer No"
        Me.ColumnHeader15.Width = 78
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Name"
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "PWD"
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "CardNO"
        Me.ColumnHeader18.Width = 79
        '
        'BtnGenerarTXT
        '
        Me.BtnGenerarTXT.BackColor = System.Drawing.SystemColors.Control
        Me.BtnGenerarTXT.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnGenerarTXT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnGenerarTXT.Location = New System.Drawing.Point(670, 3)
        Me.BtnGenerarTXT.Name = "BtnGenerarTXT"
        Me.BtnGenerarTXT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnGenerarTXT.Size = New System.Drawing.Size(117, 28)
        Me.BtnGenerarTXT.TabIndex = 56
        Me.BtnGenerarTXT.Text = "Leer &Reloj ..."
        Me.BtnGenerarTXT.UseVisualStyleBackColor = False
        Me.BtnGenerarTXT.Visible = False
        '
        'Command10
        '
        Me.Command10.BackColor = System.Drawing.SystemColors.Control
        Me.Command10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command10.Location = New System.Drawing.Point(23, 424)
        Me.Command10.Name = "Command10"
        Me.Command10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command10.Size = New System.Drawing.Size(126, 25)
        Me.Command10.TabIndex = 9
        Me.Command10.Text = "Get/Set finger print"
        Me.Command10.UseVisualStyleBackColor = False
        '
        'lblTiempo
        '
        Me.lblTiempo.Location = New System.Drawing.Point(184, 174)
        Me.lblTiempo.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(127, 30)
        Me.lblTiempo.TabIndex = 57
        Me.lblTiempo.Text = "Sin reintentos a鷑"
        Me.lblTiempo.Visible = False
        '
        'lblUltima
        '
        Me.lblUltima.ForeColor = System.Drawing.Color.Red
        Me.lblUltima.Location = New System.Drawing.Point(75, 174)
        Me.lblUltima.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblUltima.Name = "lblUltima"
        Me.lblUltima.Size = New System.Drawing.Size(393, 73)
        Me.lblUltima.TabIndex = 58
        Me.lblUltima.Text = "Sin Lectura"
        '
        'lblEstado1
        '
        Me.lblEstado1.Location = New System.Drawing.Point(15, 174)
        Me.lblEstado1.Name = "lblEstado1"
        Me.lblEstado1.Size = New System.Drawing.Size(44, 19)
        Me.lblEstado1.TabIndex = 59
        Me.lblEstado1.Text = "Estado:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 600000
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSalir.Location = New System.Drawing.Point(564, 310)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSalir.Size = New System.Drawing.Size(125, 23)
        Me.BtnSalir.TabIndex = 60
        Me.BtnSalir.Text = "&Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'cmbId
        '
        Me.cmbId.FormattingEnabled = True
        Me.cmbId.Items.AddRange(New Object() {"55555555", "55555554", "1", "76130011", "76120114", "(Sin uso)"})
        Me.cmbId.Location = New System.Drawing.Point(53, 30)
        Me.cmbId.Name = "cmbId"
        Me.cmbId.Size = New System.Drawing.Size(79, 21)
        Me.cmbId.TabIndex = 61
        Me.cmbId.Text = "55555555"
        '
        'lblIntervalo
        '
        Me.lblIntervalo.AutoSize = True
        Me.lblIntervalo.Location = New System.Drawing.Point(10, 234)
        Me.lblIntervalo.Name = "lblIntervalo"
        Me.lblIntervalo.Size = New System.Drawing.Size(106, 13)
        Me.lblIntervalo.TabIndex = 62
        Me.lblIntervalo.Text = "Intervalo de lectura:"
        Me.lblIntervalo.Visible = False
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(120, 230)
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(45, 21)
        Me.txtIntervalo.TabIndex = 63
        Me.txtIntervalo.Text = "30"
        Me.txtIntervalo.Visible = False
        '
        'txttiempo
        '
        Me.txttiempo.AutoSize = True
        Me.txttiempo.Location = New System.Drawing.Point(168, 234)
        Me.txttiempo.Name = "txttiempo"
        Me.txttiempo.Size = New System.Drawing.Size(44, 13)
        Me.txttiempo.TabIndex = 64
        Me.txttiempo.Text = "Minutos"
        Me.txttiempo.Visible = False
        '
        'Notify_icon
        '
        Me.Notify_icon.BalloonTipText = "Leyendo relojes asociados..."
        Me.Notify_icon.BalloonTipTitle = "Zonda - Lector de Relojes"
        Me.Notify_icon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notify_icon.Icon = CType(resources.GetObject("Notify_icon.Icon"), System.Drawing.Icon)
        Me.Notify_icon.Text = "Zonda - Lector de Relojes"
        Me.Notify_icon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 48)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AbrirToolStripMenuItem.Text = "Estado de relojes"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSetDate)
        Me.GroupBox2.Controls.Add(Me.Command22)
        Me.GroupBox2.Controls.Add(Me.btnEnd)
        Me.GroupBox2.Controls.Add(Me.lblErrorIntervalo)
        Me.GroupBox2.Controls.Add(Me.lblEstado1)
        Me.GroupBox2.Controls.Add(Me.lblArchivo1)
        Me.GroupBox2.Controls.Add(Me.txttiempo)
        Me.GroupBox2.Controls.Add(Me.lblTiempo)
        Me.GroupBox2.Controls.Add(Me.BtnGenerarTXT)
        Me.GroupBox2.Controls.Add(Me.txtIntervalo)
        Me.GroupBox2.Controls.Add(Me.RadioCom)
        Me.GroupBox2.Controls.Add(Me.lblIntervalo)
        Me.GroupBox2.Controls.Add(Me.RadioNet)
        Me.GroupBox2.Controls.Add(Me.cmbComPort)
        Me.GroupBox2.Controls.Add(Me.lblComPort)
        Me.GroupBox2.Controls.Add(Me.txtIp)
        Me.GroupBox2.Controls.Add(Me.lblIp)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Command31)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Command2)
        Me.GroupBox2.Controls.Add(Me.lblUltima)
        Me.GroupBox2.Controls.Add(Me.Command8)
        Me.GroupBox2.Controls.Add(Me.BtnTotales)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 293)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        '
        'btnSetDate
        '
        Me.btnSetDate.BackColor = System.Drawing.SystemColors.Control
        Me.btnSetDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSetDate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSetDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSetDate.Image = CType(resources.GetObject("btnSetDate.Image"), System.Drawing.Image)
        Me.btnSetDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetDate.Location = New System.Drawing.Point(523, 222)
        Me.btnSetDate.Name = "btnSetDate"
        Me.btnSetDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSetDate.Size = New System.Drawing.Size(151, 25)
        Me.btnSetDate.TabIndex = 100
        Me.btnSetDate.Text = "   Actualizar fecha y hora"
        Me.btnSetDate.UseVisualStyleBackColor = False
        '
        'Command22
        '
        Me.Command22.BackColor = System.Drawing.SystemColors.Control
        Me.Command22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command22.Image = CType(resources.GetObject("Command22.Image"), System.Drawing.Image)
        Me.Command22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Command22.Location = New System.Drawing.Point(525, 258)
        Me.Command22.Name = "Command22"
        Me.Command22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command22.Size = New System.Drawing.Size(152, 25)
        Me.Command22.TabIndex = 99
        Me.Command22.Text = "  Limpiar fichadas !!"
        Me.Command22.UseVisualStyleBackColor = False
        '
        'lblErrorIntervalo
        '
        Me.lblErrorIntervalo.AutoSize = True
        Me.lblErrorIntervalo.ForeColor = System.Drawing.Color.Red
        Me.lblErrorIntervalo.Location = New System.Drawing.Point(230, 234)
        Me.lblErrorIntervalo.Name = "lblErrorIntervalo"
        Me.lblErrorIntervalo.Size = New System.Drawing.Size(192, 13)
        Me.lblErrorIntervalo.TabIndex = 97
        Me.lblErrorIntervalo.Text = "* El intervalo debe ser mayor que cero"
        Me.lblErrorIntervalo.Visible = False
        '
        'lblArchivo1
        '
        Me.lblArchivo1.ForeColor = System.Drawing.Color.Red
        Me.lblArchivo1.Location = New System.Drawing.Point(6, 195)
        Me.lblArchivo1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.lblArchivo1.Name = "lblArchivo1"
        Me.lblArchivo1.Size = New System.Drawing.Size(462, 18)
        Me.lblArchivo1.TabIndex = 80
        Me.lblArchivo1.Text = "Sin generar a鷑 archivo"
        Me.lblArchivo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArchivo1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(315, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(124, 25)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Leer &Usuarios"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'boreader_panelcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 310)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbId)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnNetDaemon)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.lblId1)
        Me.Controls.Add(Me.BtnHora)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnLeerReg)
        Me.Controls.Add(Me.Command23)
        Me.Controls.Add(Me.Command19)
        Me.Controls.Add(Me.Command18)
        Me.Controls.Add(Me.BtnReaderFile)
        Me.Controls.Add(Me.BtnWriteFile)
        Me.Controls.Add(Me.Command10)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(191, 74)
        Me.MaximizeBox = False
        Me.Name = "boreader_panelcontrol"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de control de Relojes (Anviz, BioOffice) - Zonda Gesti髇 2015"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents btnStart As System.Windows.Forms.Button
    Public WithEvents btnEnd As System.Windows.Forms.Button
    Public WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblId1 As System.Windows.Forms.Label
    Friend WithEvents RadioCom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioNet As System.Windows.Forms.RadioButton
    Friend WithEvents lblComPort As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents cmbComPort As System.Windows.Forms.ComboBox
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Public WithEvents BtnNetDaemon As System.Windows.Forms.Button
    Public WithEvents Button11 As System.Windows.Forms.Button
    Public WithEvents BtnHora As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Public WithEvents BtnGenerarTXT As System.Windows.Forms.Button
    Public WithEvents Command10 As System.Windows.Forms.Button
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents lblUltima As System.Windows.Forms.Label
    Friend WithEvents lblEstado1 As System.Windows.Forms.Label
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents cmbId As System.Windows.Forms.ComboBox
    Friend WithEvents lblIntervalo As System.Windows.Forms.Label
    Friend WithEvents txtIntervalo As System.Windows.Forms.TextBox
    Friend WithEvents txttiempo As System.Windows.Forms.Label
    Private WithEvents Notify_icon As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblErrorIntervalo As System.Windows.Forms.Label
    Friend WithEvents lblArchivo1 As System.Windows.Forms.Label
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Command22 As System.Windows.Forms.Button
    Public WithEvents btnSetDate As System.Windows.Forms.Button
#End Region
End Class