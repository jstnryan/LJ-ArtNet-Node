Imports System.ComponentModel

Public Class frmSettings
    Protected Overrides Sub OnLoad(e As EventArgs)
        lvValueFlags.Items.Clear()

        For l As Byte = 0 To 127 '128 lines of 16 values = 2048 channels
            Dim group As New ListViewGroup
            Select Case l
                Case < 32
                    group = lvValueFlags.Groups(0)
                    Exit Select
                Case < 64
                    group = lvValueFlags.Groups(1)
                    Exit Select
                Case < 96
                    group = lvValueFlags.Groups(2)
                    Exit Select
                Case Else
                    group = lvValueFlags.Groups(3)
            End Select
            Dim item As ListViewItem = New ListViewItem(((l * 16) + 1).ToString, group)
            item.UseItemStyleForSubItems = False
            For s As Byte = 0 To 15 '16 channels per line
                ''Populate channels with current value:
                'item.SubItems.Add(New ListViewItem.ListViewSubItem(item, frmMain.ChannelValue((l * 16) + s).ToString))

                ''Populate channels with channel number (cumulative):
                'item.SubItems.Add(New ListViewItem.ListViewSubItem(item, ((l * 16) + s).ToString))

                ''Populate channels with channel number (in universe):
                item.SubItems.Add(New ListViewItem.ListViewSubItem(item, (((l * 16) Mod 512) + s).ToString))

                If frmMain.ChannelFlag((l * 16) + s) = 1 Then item.SubItems(s + 1).BackColor = SystemColors.MenuHighlight
            Next
            lvValueFlags.Items.Add(item)
        Next

        MyBase.OnLoad(e)
    End Sub

    Private Sub lvValueFlags_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvValueFlags.ColumnWidthChanging
        e.NewWidth = lvValueFlags.Columns(e.ColumnIndex).Width
        e.Cancel = True
    End Sub

    Private Sub lvValueFlags_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvValueFlags.ItemSelectionChanged
        If (e.IsSelected) Then e.Item.Selected = False
    End Sub

    Private Sub lvValueFlags_MouseDown(sender As Object, e As MouseEventArgs) Handles lvValueFlags.MouseDown
        'Point mousePos = ListView.PointToClient(Control.MousePosition);
        'ListViewHitTestInfo hitTest = ListView.HitTest(mousePos);
        Dim mousePos As Point = lvValueFlags.PointToClient(Control.MousePosition)
        Dim hitTest As ListViewHitTestInfo = lvValueFlags.HitTest(mousePos)
        If hitTest.SubItem IsNot Nothing AndAlso hitTest.Item.SubItems.IndexOf(hitTest.SubItem) <> 0 Then
            Dim channel As Integer = CType(hitTest.Item.Text, Integer) - 1 + hitTest.Item.SubItems.IndexOf(hitTest.SubItem) - 1
            If frmMain.ChannelFlag(channel) = 1 Then
                'deselect
                hitTest.SubItem.BackColor = SystemColors.Window
                frmMain.ChannelFlag(channel) = 0
            Else
                'select
                hitTest.SubItem.BackColor = SystemColors.MenuHighlight
                frmMain.ChannelFlag(channel) = 1
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub

    Private Sub lblSelect_Click(sender As Object, e As EventArgs) Handles lblSelect.Click
        Select Case cboSelection.SelectedIndex
            Case 0 'Universe 1
                For f As Integer = 0 To 511
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 1 'Universe 2
                For f As Integer = 512 To 1023
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 2 'Universe 3
                For f As Integer = 1024 To 1535
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 3 'Universe 4
                For f As Integer = 1536 To 2047
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 4 'None (0n+0)
                For f As Integer = 0 To 2047
                    frmMain.ChannelFlag(f) = 0
                Next
            Case 5 'All (1n+0)
                For f As Integer = 0 To 2047
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 6 'Even (2n+0)
                For f As Integer = 0 To 2046 Step 2
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 7 'Odd (2n+1)
                For f As Integer = 1 To 2047 Step 2
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 8 'Every 3rd (3n+0)
                For f As Integer = 0 To 2047 Step 3
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 9 'Every 3rd (3n+1)
                For f As Integer = 1 To 2047 Step 3
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 10 'Every 3rd (3n+2)
                For f As Integer = 2 To 2047 Step 3
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 11 'Every 4th (4n+0)
                For f As Integer = 0 To 2047 Step 4
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 12 'Every 4th (4n+1)
                For f As Integer = 1 To 2047 Step 4
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 13 'Every 4th (4n+2)
                For f As Integer = 2 To 2047 Step 4
                    frmMain.ChannelFlag(f) = 1
                Next
            Case 14 'Every 4th (4n+3)
                For f As Integer = 3 To 2047 Step 4
                    frmMain.ChannelFlag(f) = 1
                Next
        End Select
        UpdateFlags()
    End Sub

    Private Sub UpdateFlags()
        For l As Byte = 0 To 127 '128 lines of 16 values = 2048 channels
            For s As Byte = 0 To 15 '16 channels per line
                If frmMain.ChannelFlag((l * 16) + s) = 1 Then
                    lvValueFlags.Items(l).SubItems(s + 1).BackColor = SystemColors.MenuHighlight
                Else
                    lvValueFlags.Items(l).SubItems(s + 1).BackColor = SystemColors.Window
                End If
            Next
        Next
    End Sub
End Class