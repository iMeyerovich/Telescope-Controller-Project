<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSelScope = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.DataOutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UTCDateOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LSTOut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.moveAxis1Up = New System.Windows.Forms.Button()
        Me.moveAxis0CCW = New System.Windows.Forms.Button()
        Me.moveAxis0CW = New System.Windows.Forms.Button()
        Me.moveAxis1Dwn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.moveAxisRate = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.parkScope = New System.Windows.Forms.CheckBox()
        Me.setTracking = New System.Windows.Forms.CheckBox()
        Me.selScope = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LatInBx = New System.Windows.Forms.NumericUpDown()
        Me.LongInBx = New System.Windows.Forms.NumericUpDown()
        Me.LatLongIn = New System.Windows.Forms.Button()
        Me.LSTTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.moveAxisRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatInBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LongInBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelScope
        '
        Me.btnSelScope.Location = New System.Drawing.Point(279, 7)
        Me.btnSelScope.Name = "btnSelScope"
        Me.btnSelScope.Size = New System.Drawing.Size(146, 37)
        Me.btnSelScope.TabIndex = 1
        Me.btnSelScope.Text = "Choose Scope"
        Me.btnSelScope.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(431, 7)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(146, 37)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'DataOutTimer
        '
        Me.DataOutTimer.Interval = 1000
        '
        'UTCDateOut
        '
        Me.UTCDateOut.Location = New System.Drawing.Point(354, 91)
        Me.UTCDateOut.Name = "UTCDateOut"
        Me.UTCDateOut.ReadOnly = True
        Me.UTCDateOut.Size = New System.Drawing.Size(218, 26)
        Me.UTCDateOut.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "UTCDate:"
        '
        'LSTOut
        '
        Me.LSTOut.Location = New System.Drawing.Point(354, 120)
        Me.LSTOut.Name = "LSTOut"
        Me.LSTOut.ReadOnly = True
        Me.LSTOut.Size = New System.Drawing.Size(218, 26)
        Me.LSTOut.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LST:"
        '
        'moveAxis1Up
        '
        Me.moveAxis1Up.Enabled = False
        Me.moveAxis1Up.Location = New System.Drawing.Point(82, 83)
        Me.moveAxis1Up.Name = "moveAxis1Up"
        Me.moveAxis1Up.Size = New System.Drawing.Size(50, 50)
        Me.moveAxis1Up.TabIndex = 7
        Me.moveAxis1Up.Text = "↑"
        Me.moveAxis1Up.UseVisualStyleBackColor = True
        '
        'moveAxis0CCW
        '
        Me.moveAxis0CCW.Enabled = False
        Me.moveAxis0CCW.Location = New System.Drawing.Point(26, 139)
        Me.moveAxis0CCW.Name = "moveAxis0CCW"
        Me.moveAxis0CCW.Size = New System.Drawing.Size(50, 50)
        Me.moveAxis0CCW.TabIndex = 8
        Me.moveAxis0CCW.Text = "↶"
        Me.moveAxis0CCW.UseVisualStyleBackColor = True
        '
        'moveAxis0CW
        '
        Me.moveAxis0CW.Enabled = False
        Me.moveAxis0CW.Location = New System.Drawing.Point(138, 139)
        Me.moveAxis0CW.Name = "moveAxis0CW"
        Me.moveAxis0CW.Size = New System.Drawing.Size(50, 50)
        Me.moveAxis0CW.TabIndex = 9
        Me.moveAxis0CW.Text = "↷"
        Me.moveAxis0CW.UseVisualStyleBackColor = True
        '
        'moveAxis1Dwn
        '
        Me.moveAxis1Dwn.Enabled = False
        Me.moveAxis1Dwn.Location = New System.Drawing.Point(82, 195)
        Me.moveAxis1Dwn.Name = "moveAxis1Dwn"
        Me.moveAxis1Dwn.Size = New System.Drawing.Size(50, 50)
        Me.moveAxis1Dwn.TabIndex = 10
        Me.moveAxis1Dwn.Text = "↓"
        Me.moveAxis1Dwn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Manual Override"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(459, 283)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(113, 26)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(459, 315)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(113, 26)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(292, 315)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(113, 26)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(292, 283)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(113, 26)
        Me.TextBox4.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "RA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(244, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "DEC:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "AZ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(411, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ALT:"
        '
        'moveAxisRate
        '
        Me.moveAxisRate.Location = New System.Drawing.Point(68, 251)
        Me.moveAxisRate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.moveAxisRate.Name = "moveAxisRate"
        Me.moveAxisRate.Size = New System.Drawing.Size(88, 26)
        Me.moveAxisRate.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Rate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(161, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Steps/s"
        '
        'LoadTimer
        '
        Me.LoadTimer.Interval = 2000
        '
        'parkScope
        '
        Me.parkScope.AutoSize = True
        Me.parkScope.Checked = True
        Me.parkScope.CheckState = System.Windows.Forms.CheckState.Checked
        Me.parkScope.Enabled = False
        Me.parkScope.Location = New System.Drawing.Point(157, 97)
        Me.parkScope.Name = "parkScope"
        Me.parkScope.Size = New System.Drawing.Size(67, 24)
        Me.parkScope.TabIndex = 29
        Me.parkScope.Text = "Park"
        Me.parkScope.UseVisualStyleBackColor = True
        '
        'setTracking
        '
        Me.setTracking.AutoSize = True
        Me.setTracking.Enabled = False
        Me.setTracking.Location = New System.Drawing.Point(248, 248)
        Me.setTracking.Name = "setTracking"
        Me.setTracking.Size = New System.Drawing.Size(95, 24)
        Me.setTracking.TabIndex = 30
        Me.setTracking.Text = "Tracking"
        Me.setTracking.UseVisualStyleBackColor = True
        '
        'selScope
        '
        Me.selScope.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ASCOM_Debug.My.MySettings.Default, "Telescope", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.selScope.Location = New System.Drawing.Point(24, 12)
        Me.selScope.Name = "selScope"
        Me.selScope.Size = New System.Drawing.Size(249, 26)
        Me.selScope.TabIndex = 0
        Me.selScope.Text = Global.ASCOM_Debug.My.MySettings.Default.Telescope
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Longitude:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(277, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 20)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Latitude:"
        '
        'LatInBx
        '
        Me.LatInBx.DecimalPlaces = 7
        Me.LatInBx.Location = New System.Drawing.Point(354, 164)
        Me.LatInBx.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.LatInBx.Minimum = New Decimal(New Integer() {90, 0, 0, -2147483648})
        Me.LatInBx.Name = "LatInBx"
        Me.LatInBx.Size = New System.Drawing.Size(218, 26)
        Me.LatInBx.TabIndex = 35
        '
        'LongInBx
        '
        Me.LongInBx.DecimalPlaces = 7
        Me.LongInBx.Location = New System.Drawing.Point(354, 193)
        Me.LongInBx.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.LongInBx.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.LongInBx.Name = "LongInBx"
        Me.LongInBx.Size = New System.Drawing.Size(218, 26)
        Me.LongInBx.TabIndex = 36
        '
        'LatLongIn
        '
        Me.LatLongIn.Location = New System.Drawing.Point(459, 225)
        Me.LatLongIn.Name = "LatLongIn"
        Me.LatLongIn.Size = New System.Drawing.Size(113, 37)
        Me.LatLongIn.TabIndex = 37
        Me.LatLongIn.Text = "Locate"
        Me.LatLongIn.UseVisualStyleBackColor = True
        '
        'LSTTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 489)
        Me.Controls.Add(Me.LatLongIn)
        Me.Controls.Add(Me.LongInBx)
        Me.Controls.Add(Me.LatInBx)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.setTracking)
        Me.Controls.Add(Me.parkScope)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.moveAxisRate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.moveAxis1Dwn)
        Me.Controls.Add(Me.moveAxis0CW)
        Me.Controls.Add(Me.moveAxis0CCW)
        Me.Controls.Add(Me.moveAxis1Up)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LSTOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UTCDateOut)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnSelScope)
        Me.Controls.Add(Me.selScope)
        Me.Name = "Form1"
        Me.Text = "ASCOM Debug Monitor"
        CType(Me.moveAxisRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatInBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LongInBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selScope As System.Windows.Forms.TextBox
    Friend WithEvents btnSelScope As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents DataOutTimer As System.Windows.Forms.Timer
    Friend WithEvents UTCDateOut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LSTOut As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents moveAxis1Up As System.Windows.Forms.Button
    Friend WithEvents moveAxis0CCW As System.Windows.Forms.Button
    Friend WithEvents moveAxis0CW As System.Windows.Forms.Button
    Friend WithEvents moveAxis1Dwn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents moveAxisRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LoadTimer As System.Windows.Forms.Timer
    Friend WithEvents parkScope As System.Windows.Forms.CheckBox
    Friend WithEvents setTracking As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LatInBx As System.Windows.Forms.NumericUpDown
    Friend WithEvents LongInBx As System.Windows.Forms.NumericUpDown
    Friend WithEvents LatLongIn As System.Windows.Forms.Button
    Friend WithEvents LSTTimer As System.Windows.Forms.Timer

End Class
