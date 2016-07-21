<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Universe 1", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Universe 2", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Universe 3", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Universe 4", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "1"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "127", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.MenuHighlight, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "127", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.MenuHighlight, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0"), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "0")}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"2049", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}, -1)
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lvValueFlags = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSelection = New System.Windows.Forms.ComboBox()
        Me.lblSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(475, 367)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lvValueFlags
        '
        Me.lvValueFlags.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvValueFlags.AutoArrange = False
        Me.lvValueFlags.BackColor = System.Drawing.SystemColors.Window
        Me.lvValueFlags.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.lvValueFlags.GridLines = True
        ListViewGroup9.Header = "Universe 1"
        ListViewGroup9.Name = "lvgUniverse1"
        ListViewGroup10.Header = "Universe 2"
        ListViewGroup10.Name = "lvgUniverse2"
        ListViewGroup11.Header = "Universe 3"
        ListViewGroup11.Name = "lvgUniverse3"
        ListViewGroup12.Header = "Universe 4"
        ListViewGroup12.Name = "lvgUniverse4"
        Me.lvValueFlags.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup9, ListViewGroup10, ListViewGroup11, ListViewGroup12})
        Me.lvValueFlags.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem5.Group = ListViewGroup9
        ListViewItem5.UseItemStyleForSubItems = False
        ListViewItem6.Group = ListViewGroup12
        Me.lvValueFlags.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6})
        Me.lvValueFlags.Location = New System.Drawing.Point(12, 12)
        Me.lvValueFlags.Name = "lvValueFlags"
        Me.lvValueFlags.Size = New System.Drawing.Size(538, 349)
        Me.lvValueFlags.TabIndex = 2
        Me.lvValueFlags.UseCompatibleStateImageBehavior = False
        Me.lvValueFlags.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = ""
        Me.ColumnHeader0.Width = 35
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "+0"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "+1"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 30
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "+2"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 30
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "+3"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 30
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "+4"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "+5"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 30
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "+6"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 30
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "+7"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 30
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "+8"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 30
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "+9"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 30
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "+10"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 30
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "+11"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 30
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "+13"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 30
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "+13"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 30
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "+14"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader15.Width = 30
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "+15"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader16.Width = 30
        '
        'cboSelection
        '
        Me.cboSelection.FormattingEnabled = True
        Me.cboSelection.Items.AddRange(New Object() {"Universe 1", "Universe 2", "Universe 3", "Universe 4", "None (0n+0)", "All (1n+0)", "Even (2n+0)", "Odd (2n+1)", "Every 3rd (3n+0)", "Every 3rd (3n+1)", "Every 3rd (3n+2)", "Every 4th (4n+0)", "Every 4th (4n+1)", "Every 4th (4n+2)", "Every 4th (4n+3)"})
        Me.cboSelection.Location = New System.Drawing.Point(12, 369)
        Me.cboSelection.Name = "cboSelection"
        Me.cboSelection.Size = New System.Drawing.Size(121, 21)
        Me.cboSelection.TabIndex = 3
        '
        'lblSelect
        '
        Me.lblSelect.Location = New System.Drawing.Point(139, 367)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(75, 23)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select"
        Me.lblSelect.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 400)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.cboSelection)
        Me.Controls.Add(Me.lvValueFlags)
        Me.Controls.Add(Me.cmdClose)
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.Text = "Channel Overrides"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClose As Button
    Friend WithEvents lvValueFlags As ListView
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents cboSelection As ComboBox
    Friend WithEvents lblSelect As Button
End Class
