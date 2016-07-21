<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.timerOutput = New System.Windows.Forms.Timer(Me.components)
        Me.grpArtNet = New System.Windows.Forms.GroupBox()
        Me.lblSubnet = New System.Windows.Forms.Label()
        Me.ipSubnet = New IPAddressControlLib.IPAddressControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudUniverse4 = New System.Windows.Forms.NumericUpDown()
        Me.nudUniverse3 = New System.Windows.Forms.NumericUpDown()
        Me.nudUniverse2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudUniverse1 = New System.Windows.Forms.NumericUpDown()
        Me.cmdInputStartStop = New System.Windows.Forms.Button()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.ipArtnet = New IPAddressControlLib.IPAddressControl()
        Me.pbArtnet4 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet3 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet2 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet1 = New System.Windows.Forms.PictureBox()
        Me.lblUniverse = New System.Windows.Forms.Label()
        Me.grpLightJockey = New System.Windows.Forms.GroupBox()
        Me.nudInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.cmdSettings = New System.Windows.Forms.Button()
        Me.cmdOutputStartStop = New System.Windows.Forms.Button()
        Me.pbLightJockey = New System.Windows.Forms.PictureBox()
        Me.timerInput = New System.Windows.Forms.Timer(Me.components)
        Me.grpArtNet.SuspendLayout()
        CType(Me.nudUniverse4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUniverse3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUniverse2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUniverse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLightJockey.SuspendLayout()
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLightJockey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerOutput
        '
        '
        'grpArtNet
        '
        Me.grpArtNet.Controls.Add(Me.lblSubnet)
        Me.grpArtNet.Controls.Add(Me.ipSubnet)
        Me.grpArtNet.Controls.Add(Me.Label4)
        Me.grpArtNet.Controls.Add(Me.Label3)
        Me.grpArtNet.Controls.Add(Me.Label2)
        Me.grpArtNet.Controls.Add(Me.nudUniverse4)
        Me.grpArtNet.Controls.Add(Me.nudUniverse3)
        Me.grpArtNet.Controls.Add(Me.nudUniverse2)
        Me.grpArtNet.Controls.Add(Me.Label1)
        Me.grpArtNet.Controls.Add(Me.nudUniverse1)
        Me.grpArtNet.Controls.Add(Me.cmdInputStartStop)
        Me.grpArtNet.Controls.Add(Me.lblIPAddress)
        Me.grpArtNet.Controls.Add(Me.ipArtnet)
        Me.grpArtNet.Controls.Add(Me.pbArtnet4)
        Me.grpArtNet.Controls.Add(Me.pbArtnet3)
        Me.grpArtNet.Controls.Add(Me.pbArtnet2)
        Me.grpArtNet.Controls.Add(Me.pbArtnet1)
        Me.grpArtNet.Controls.Add(Me.lblUniverse)
        Me.grpArtNet.Location = New System.Drawing.Point(12, 12)
        Me.grpArtNet.Name = "grpArtNet"
        Me.grpArtNet.Size = New System.Drawing.Size(277, 171)
        Me.grpArtNet.TabIndex = 16
        Me.grpArtNet.TabStop = False
        Me.grpArtNet.Text = "Art-Net"
        '
        'lblSubnet
        '
        Me.lblSubnet.AutoSize = True
        Me.lblSubnet.Location = New System.Drawing.Point(6, 42)
        Me.lblSubnet.Name = "lblSubnet"
        Me.lblSubnet.Size = New System.Drawing.Size(44, 13)
        Me.lblSubnet.TabIndex = 37
        Me.lblSubnet.Text = "Subnet:"
        '
        'ipSubnet
        '
        Me.ipSubnet.AllowInternalTab = False
        Me.ipSubnet.AutoHeight = True
        Me.ipSubnet.BackColor = System.Drawing.SystemColors.Window
        Me.ipSubnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ipSubnet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ipSubnet.Location = New System.Drawing.Point(73, 39)
        Me.ipSubnet.MinimumSize = New System.Drawing.Size(87, 20)
        Me.ipSubnet.Name = "ipSubnet"
        Me.ipSubnet.ReadOnly = False
        Me.ipSubnet.Size = New System.Drawing.Size(87, 20)
        Me.ipSubnet.TabIndex = 36
        Me.ipSubnet.Text = "255.255.255.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "-> LJ 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "-> LJ 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "-> LJ 2"
        '
        'nudUniverse4
        '
        Me.nudUniverse4.Location = New System.Drawing.Point(73, 143)
        Me.nudUniverse4.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudUniverse4.Name = "nudUniverse4"
        Me.nudUniverse4.Size = New System.Drawing.Size(50, 20)
        Me.nudUniverse4.TabIndex = 32
        Me.nudUniverse4.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'nudUniverse3
        '
        Me.nudUniverse3.Location = New System.Drawing.Point(73, 117)
        Me.nudUniverse3.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudUniverse3.Name = "nudUniverse3"
        Me.nudUniverse3.Size = New System.Drawing.Size(50, 20)
        Me.nudUniverse3.TabIndex = 31
        Me.nudUniverse3.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nudUniverse2
        '
        Me.nudUniverse2.Location = New System.Drawing.Point(73, 91)
        Me.nudUniverse2.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudUniverse2.Name = "nudUniverse2"
        Me.nudUniverse2.Size = New System.Drawing.Size(50, 20)
        Me.nudUniverse2.TabIndex = 30
        Me.nudUniverse2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "-> LJ 1"
        '
        'nudUniverse1
        '
        Me.nudUniverse1.Location = New System.Drawing.Point(73, 65)
        Me.nudUniverse1.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.nudUniverse1.Name = "nudUniverse1"
        Me.nudUniverse1.Size = New System.Drawing.Size(50, 20)
        Me.nudUniverse1.TabIndex = 28
        '
        'cmdInputStartStop
        '
        Me.cmdInputStartStop.Location = New System.Drawing.Point(197, 11)
        Me.cmdInputStartStop.Name = "cmdInputStartStop"
        Me.cmdInputStartStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdInputStartStop.TabIndex = 27
        Me.cmdInputStartStop.Text = "Input Start"
        Me.cmdInputStartStop.UseVisualStyleBackColor = True
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(6, 16)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(61, 13)
        Me.lblIPAddress.TabIndex = 26
        Me.lblIPAddress.Text = "IP Address:"
        '
        'ipArtnet
        '
        Me.ipArtnet.AllowInternalTab = False
        Me.ipArtnet.AutoHeight = True
        Me.ipArtnet.BackColor = System.Drawing.SystemColors.Window
        Me.ipArtnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ipArtnet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ipArtnet.Location = New System.Drawing.Point(73, 13)
        Me.ipArtnet.MinimumSize = New System.Drawing.Size(87, 20)
        Me.ipArtnet.Name = "ipArtnet"
        Me.ipArtnet.ReadOnly = False
        Me.ipArtnet.Size = New System.Drawing.Size(87, 20)
        Me.ipArtnet.TabIndex = 25
        Me.ipArtnet.Text = "127.0.0.1"
        '
        'pbArtnet4
        '
        Me.pbArtnet4.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet4.Location = New System.Drawing.Point(129, 145)
        Me.pbArtnet4.Name = "pbArtnet4"
        Me.pbArtnet4.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet4.TabIndex = 24
        Me.pbArtnet4.TabStop = False
        '
        'pbArtnet3
        '
        Me.pbArtnet3.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet3.Location = New System.Drawing.Point(129, 119)
        Me.pbArtnet3.Name = "pbArtnet3"
        Me.pbArtnet3.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet3.TabIndex = 22
        Me.pbArtnet3.TabStop = False
        '
        'pbArtnet2
        '
        Me.pbArtnet2.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet2.Location = New System.Drawing.Point(129, 93)
        Me.pbArtnet2.Name = "pbArtnet2"
        Me.pbArtnet2.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet2.TabIndex = 20
        Me.pbArtnet2.TabStop = False
        '
        'pbArtnet1
        '
        Me.pbArtnet1.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet1.Location = New System.Drawing.Point(129, 67)
        Me.pbArtnet1.Name = "pbArtnet1"
        Me.pbArtnet1.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet1.TabIndex = 18
        Me.pbArtnet1.TabStop = False
        '
        'lblUniverse
        '
        Me.lblUniverse.AutoSize = True
        Me.lblUniverse.Location = New System.Drawing.Point(6, 67)
        Me.lblUniverse.Name = "lblUniverse"
        Me.lblUniverse.Size = New System.Drawing.Size(52, 13)
        Me.lblUniverse.TabIndex = 16
        Me.lblUniverse.Text = "Universe:"
        '
        'grpLightJockey
        '
        Me.grpLightJockey.Controls.Add(Me.nudInterval)
        Me.grpLightJockey.Controls.Add(Me.lblInterval)
        Me.grpLightJockey.Controls.Add(Me.cmdSettings)
        Me.grpLightJockey.Controls.Add(Me.cmdOutputStartStop)
        Me.grpLightJockey.Controls.Add(Me.pbLightJockey)
        Me.grpLightJockey.Location = New System.Drawing.Point(12, 189)
        Me.grpLightJockey.Name = "grpLightJockey"
        Me.grpLightJockey.Size = New System.Drawing.Size(277, 40)
        Me.grpLightJockey.TabIndex = 17
        Me.grpLightJockey.TabStop = False
        Me.grpLightJockey.Text = "LightJockey"
        '
        'nudInterval
        '
        Me.nudInterval.Location = New System.Drawing.Point(73, 14)
        Me.nudInterval.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInterval.Name = "nudInterval"
        Me.nudInterval.Size = New System.Drawing.Size(50, 20)
        Me.nudInterval.TabIndex = 18
        Me.nudInterval.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(6, 16)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(48, 13)
        Me.lblInterval.TabIndex = 17
        Me.lblInterval.Text = "Inverval:"
        '
        'cmdSettings
        '
        Me.cmdSettings.Image = Global.LJ_ArtNet_Node.My.Resources.icons.gear
        Me.cmdSettings.Location = New System.Drawing.Point(158, 11)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(33, 23)
        Me.cmdSettings.TabIndex = 16
        Me.cmdSettings.UseVisualStyleBackColor = True
        '
        'cmdOutputStartStop
        '
        Me.cmdOutputStartStop.Location = New System.Drawing.Point(197, 11)
        Me.cmdOutputStartStop.Name = "cmdOutputStartStop"
        Me.cmdOutputStartStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdOutputStartStop.TabIndex = 15
        Me.cmdOutputStartStop.Text = "Output Start"
        Me.cmdOutputStartStop.UseVisualStyleBackColor = True
        '
        'pbLightJockey
        '
        Me.pbLightJockey.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbLightJockey.Location = New System.Drawing.Point(129, 16)
        Me.pbLightJockey.Name = "pbLightJockey"
        Me.pbLightJockey.Size = New System.Drawing.Size(17, 17)
        Me.pbLightJockey.TabIndex = 14
        Me.pbLightJockey.TabStop = False
        '
        'timerInput
        '
        Me.timerInput.Interval = 500
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 239)
        Me.Controls.Add(Me.grpLightJockey)
        Me.Controls.Add(Me.grpArtNet)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "LJ-ArtNet-Node"
        Me.grpArtNet.ResumeLayout(False)
        Me.grpArtNet.PerformLayout()
        CType(Me.nudUniverse4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUniverse3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUniverse2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUniverse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLightJockey.ResumeLayout(False)
        Me.grpLightJockey.PerformLayout()
        CType(Me.nudInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLightJockey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerOutput As Timer
    Friend WithEvents grpArtNet As GroupBox
    Friend WithEvents nudUniverse1 As NumericUpDown
    Friend WithEvents cmdInputStartStop As Button
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents ipArtnet As IPAddressControlLib.IPAddressControl
    Friend WithEvents pbArtnet4 As PictureBox
    Friend WithEvents pbArtnet3 As PictureBox
    Friend WithEvents pbArtnet2 As PictureBox
    Friend WithEvents pbArtnet1 As PictureBox
    Friend WithEvents lblUniverse As Label
    Friend WithEvents grpLightJockey As GroupBox
    Friend WithEvents cmdOutputStartStop As Button
    Friend WithEvents pbLightJockey As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudUniverse4 As NumericUpDown
    Friend WithEvents nudUniverse3 As NumericUpDown
    Friend WithEvents nudUniverse2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSettings As Button
    Friend WithEvents lblSubnet As Label
    Friend WithEvents ipSubnet As IPAddressControlLib.IPAddressControl
    Friend WithEvents lblInterval As Label
    Friend WithEvents nudInterval As NumericUpDown
    Friend WithEvents timerInput As Timer
End Class
