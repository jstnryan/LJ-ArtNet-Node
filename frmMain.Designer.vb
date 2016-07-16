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
        Me.lblArtNet = New System.Windows.Forms.Label()
        Me.lblLightJockey = New System.Windows.Forms.Label()
        Me.lblUniv1 = New System.Windows.Forms.Label()
        Me.lblArtnet2 = New System.Windows.Forms.Label()
        Me.lblArtnet3 = New System.Windows.Forms.Label()
        Me.lblArtnet4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdStartStop = New System.Windows.Forms.Button()
        Me.pbLightJockey = New System.Windows.Forms.PictureBox()
        Me.pbArtnet4 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet3 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet2 = New System.Windows.Forms.PictureBox()
        Me.pbArtnet1 = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLightJockey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArtnet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblArtNet
        '
        Me.lblArtNet.AutoSize = True
        Me.lblArtNet.Location = New System.Drawing.Point(12, 9)
        Me.lblArtNet.Name = "lblArtNet"
        Me.lblArtNet.Size = New System.Drawing.Size(40, 13)
        Me.lblArtNet.TabIndex = 0
        Me.lblArtNet.Text = "Art-Net"
        '
        'lblLightJockey
        '
        Me.lblLightJockey.AutoSize = True
        Me.lblLightJockey.Location = New System.Drawing.Point(219, 9)
        Me.lblLightJockey.Name = "lblLightJockey"
        Me.lblLightJockey.Size = New System.Drawing.Size(67, 13)
        Me.lblLightJockey.TabIndex = 1
        Me.lblLightJockey.Text = "LightJockey:"
        '
        'lblUniv1
        '
        Me.lblUniv1.AutoSize = True
        Me.lblUniv1.Location = New System.Drawing.Point(52, 9)
        Me.lblUniv1.Name = "lblUniv1"
        Me.lblUniv1.Size = New System.Drawing.Size(16, 13)
        Me.lblUniv1.TabIndex = 2
        Me.lblUniv1.Text = "1:"
        '
        'lblArtnet2
        '
        Me.lblArtnet2.AutoSize = True
        Me.lblArtnet2.Location = New System.Drawing.Point(89, 9)
        Me.lblArtnet2.Name = "lblArtnet2"
        Me.lblArtnet2.Size = New System.Drawing.Size(16, 13)
        Me.lblArtnet2.TabIndex = 4
        Me.lblArtnet2.Text = "2:"
        '
        'lblArtnet3
        '
        Me.lblArtnet3.AutoSize = True
        Me.lblArtnet3.Location = New System.Drawing.Point(126, 9)
        Me.lblArtnet3.Name = "lblArtnet3"
        Me.lblArtnet3.Size = New System.Drawing.Size(16, 13)
        Me.lblArtnet3.TabIndex = 6
        Me.lblArtnet3.Text = "3:"
        '
        'lblArtnet4
        '
        Me.lblArtnet4.AutoSize = True
        Me.lblArtnet4.Location = New System.Drawing.Point(163, 9)
        Me.lblArtnet4.Name = "lblArtnet4"
        Me.lblArtnet4.Size = New System.Drawing.Size(16, 13)
        Me.lblArtnet4.TabIndex = 8
        Me.lblArtnet4.Text = "4:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 30)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(389, 219)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'Column15
        '
        Me.Column15.HeaderText = "Column15"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        '
        'Column16
        '
        Me.Column16.HeaderText = "Column16"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'cmdStartStop
        '
        Me.cmdStartStop.Location = New System.Drawing.Point(326, 4)
        Me.cmdStartStop.Name = "cmdStartStop"
        Me.cmdStartStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStartStop.TabIndex = 12
        Me.cmdStartStop.Text = "Start"
        Me.cmdStartStop.UseVisualStyleBackColor = True
        '
        'pbLightJockey
        '
        Me.pbLightJockey.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbLightJockey.Location = New System.Drawing.Point(285, 7)
        Me.pbLightJockey.Name = "pbLightJockey"
        Me.pbLightJockey.Size = New System.Drawing.Size(17, 17)
        Me.pbLightJockey.TabIndex = 10
        Me.pbLightJockey.TabStop = False
        '
        'pbArtnet4
        '
        Me.pbArtnet4.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet4.Location = New System.Drawing.Point(178, 7)
        Me.pbArtnet4.Name = "pbArtnet4"
        Me.pbArtnet4.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet4.TabIndex = 9
        Me.pbArtnet4.TabStop = False
        '
        'pbArtnet3
        '
        Me.pbArtnet3.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet3.Location = New System.Drawing.Point(140, 7)
        Me.pbArtnet3.Name = "pbArtnet3"
        Me.pbArtnet3.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet3.TabIndex = 7
        Me.pbArtnet3.TabStop = False
        '
        'pbArtnet2
        '
        Me.pbArtnet2.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet2.Location = New System.Drawing.Point(103, 7)
        Me.pbArtnet2.Name = "pbArtnet2"
        Me.pbArtnet2.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet2.TabIndex = 5
        Me.pbArtnet2.TabStop = False
        '
        'pbArtnet1
        '
        Me.pbArtnet1.Image = Global.LJ_ArtNet_Node.My.Resources.icons.statusred
        Me.pbArtnet1.Location = New System.Drawing.Point(66, 7)
        Me.pbArtnet1.Name = "pbArtnet1"
        Me.pbArtnet1.Size = New System.Drawing.Size(17, 17)
        Me.pbArtnet1.TabIndex = 3
        Me.pbArtnet1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 261)
        Me.Controls.Add(Me.cmdStartStop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pbLightJockey)
        Me.Controls.Add(Me.pbArtnet4)
        Me.Controls.Add(Me.lblArtnet4)
        Me.Controls.Add(Me.pbArtnet3)
        Me.Controls.Add(Me.lblArtnet3)
        Me.Controls.Add(Me.pbArtnet2)
        Me.Controls.Add(Me.lblArtnet2)
        Me.Controls.Add(Me.pbArtnet1)
        Me.Controls.Add(Me.lblUniv1)
        Me.Controls.Add(Me.lblLightJockey)
        Me.Controls.Add(Me.lblArtNet)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "LJ-ArtNet-Node"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLightJockey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArtnet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArtNet As Label
    Friend WithEvents lblLightJockey As Label
    Friend WithEvents lblUniv1 As Label
    Friend WithEvents pbArtnet1 As PictureBox
    Friend WithEvents lblArtnet2 As Label
    Friend WithEvents pbArtnet2 As PictureBox
    Friend WithEvents lblArtnet3 As Label
    Friend WithEvents pbArtnet3 As PictureBox
    Friend WithEvents lblArtnet4 As Label
    Friend WithEvents pbArtnet4 As PictureBox
    Friend WithEvents pbLightJockey As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents cmdStartStop As Button
    Friend WithEvents Timer As Timer
End Class
